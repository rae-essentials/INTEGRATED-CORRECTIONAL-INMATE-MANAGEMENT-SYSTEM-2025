Imports System.IO
Imports System.Text
Imports System.Text.RegularExpressions
Imports MySql.Data.MySqlClient

Public Class datacon

    Public Function OpenConnectionAndCheckTable(ByVal connectionString As String) As (Connection As MySqlConnection, StatusMessage As String)
        Dim conn As MySqlConnection = Nothing
        Dim status As String = ""

        Try
            conn = New MySqlConnection(connectionString)
            conn.Open()
            status = "Connection successful."

            ' Now check if the table exists
            'If TableExists(conn, tableName) Then
            'status &= $" Table '{tableName}' exists."
            'Else
            'status &= $" Table '{tableName}' does not exist."
            'End If

            MessageBox.Show(status)  ' Show combined feedback
            Return (conn, status)
        Catch ex As MySqlException
            status = $"Connection failed: {ex.Message}"
            LogError(ex)
            MessageBox.Show(status)
            If conn IsNot Nothing AndAlso conn.State = ConnectionState.Open Then conn.Close()
            Return (Nothing, status)

        End Try
    End Function

    'Create Table in Sql'
    Public Sub CreateTable(ByVal createTables As String, ByVal connectionString As String)

        ' Validate inputs
        If String.IsNullOrWhiteSpace(createTables) Then
            MessageBox.Show("SQL command is empty.")
            Return
        End If

        If String.IsNullOrWhiteSpace(connectionString) Then
            MessageBox.Show("Connection string is empty.")
            Return
        End If

        ' Extract table name
        Dim tableName As String = ExtractTableName(createTables)
        If String.IsNullOrEmpty(tableName) Then
            MessageBox.Show("Unable to detect the table name in your SQL.")
            Return
        End If

        MessageBox.Show("Detected table name: " & tableName)

        Using conn As New MySqlConnection(connectionString)
            Try
                conn.Open()

                ' Check if table already exists
                If TableExists(conn, tableName) Then
                    MessageBox.Show($"Table '{tableName}' already exists.")
                    Return
                End If

                ' Create table
                Using cmd As New MySqlCommand(createTables, conn)
                    cmd.ExecuteNonQuery()
                    MessageBox.Show($"Table '{tableName}' created successfully.")
                End Using

            Catch ex As Exception
                MessageBox.Show("Error: " & ex.Message)
                LogError(ex)
            Finally
                If conn.State = ConnectionState.Open Then conn.Close()
            End Try
        End Using

    End Sub


    ' Helper: Check if table exists
    Private Function TableExists(conn As MySqlConnection, tableName As String) As Boolean

        Dim query As String =
        "SELECT COUNT(*) FROM INFORMATION_SCHEMA.TABLES " &
        "WHERE TABLE_SCHEMA = DATABASE() AND TABLE_NAME = @name"

        Using cmd As New MySqlCommand(query, conn)
            cmd.Parameters.AddWithValue("@name", tableName)

            Return Convert.ToInt32(cmd.ExecuteScalar()) > 0
        End Using

    End Function


    ' Helper: Extract table name from CREATE TABLE SQL (basic implementation)
    Private Function ExtractTableName(sql As String) As String
        ' Regex supports:
        ' CREATE TABLE [IF NOT EXISTS] schema.table
        ' backticks, spaces, special characters

        Dim pattern As String =
        "CREATE\s+TABLE\s+(?:IF\s+NOT\s+EXISTS\s+)?(?:[\w`]+\.)?(`?[\w\s]+`?)"

        Dim match As Match = Regex.Match(sql, pattern, RegexOptions.IgnoreCase)

        If match.Success Then
            Dim name As String = match.Groups(1).Value

            ' Remove backticks if any
            name = name.Replace("`", "").Trim()

            Return name
        End If

        Return ""
    End Function


    Public Function InsertRowsBatch(
    ByVal tableName As String,
    ByVal columns As List(Of String),
    ByVal rows As List(Of List(Of Object)),
    ByVal connectionString As String
) As Integer

        Dim colList As String = String.Join(",", columns.Select(Function(c) $"`{c}`"))

        Dim valuesList As New List(Of String)

        For Each row In rows
            Dim formatted = String.Join(",", row.Select(Function(v) $"'{v.ToString().Replace("'", "''")}'"))
            valuesList.Add($"({formatted})")
        Next

        Dim query As String = $"INSERT INTO `{tableName}` ({colList}) VALUES {String.Join(",", valuesList)};"

        Using conn As New MySqlConnection(connectionString)
            conn.Open()
            Using cmd As New MySqlCommand(query, conn)
                Return cmd.ExecuteNonQuery()
            End Using
        End Using
    End Function


    Public Function SelectRowsBatch(
        ByVal tableName As String,
        ByVal columns As List(Of String),
        ByVal connectionString As String,
        Optional ByVal whereClause As String = ""
    ) As List(Of Dictionary(Of String, Object))

        ' Validate inputs
        If String.IsNullOrWhiteSpace(tableName) Or String.IsNullOrWhiteSpace(connectionString) Then
            Throw New ArgumentException("Table name and connection string are required.")
        End If

        Using conn As New MySqlConnection(connectionString)
            Try
                conn.Open()

                ' Check if table exists
                If Not TableExists(conn, tableName) Then
                    LogError(New Exception($"Table '{tableName}' does not exist."))
                    Return New List(Of Dictionary(Of String, Object))()  ' Return empty list
                End If

                ' Check if columns exist (if specified)
                If columns IsNot Nothing AndAlso columns.Count > 0 Then
                    Dim missingColumns = GetMissingColumns(conn, tableName, columns)
                    If missingColumns.Count > 0 Then
                        LogError(New Exception($"Columns not found in table '{tableName}': {String.Join(", ", missingColumns)}"))
                        Return New List(Of Dictionary(Of String, Object))()  ' Return empty list
                    End If
                End If

                ' Build column list
                Dim colList As String = If(columns Is Nothing OrElse columns.Count = 0, "*", String.Join(",", columns.Select(Function(c) $"`{c}`")))

                ' Build query
                Dim query As String = $"SELECT {colList} FROM `{tableName}`"
                If Not String.IsNullOrWhiteSpace(whereClause) Then
                    query &= $" WHERE {whereClause}"
                End If
                query &= ";"

                Dim results As New List(Of Dictionary(Of String, Object))

                Using cmd As New MySqlCommand(query, conn)
                    Using reader As MySqlDataReader = cmd.ExecuteReader()
                        Dim rowCount As Integer = 0
                        While reader.Read()
                            Dim row As New Dictionary(Of String, Object)
                            For i As Integer = 0 To reader.FieldCount - 1
                                Dim colName As String = reader.GetName(i)
                                Dim value As Object = If(reader.IsDBNull(i), Nothing, reader.GetValue(i))
                                row.Add(colName, value)
                            Next
                            results.Add(row)
                            rowCount += 1
                        End While

                        ' Log if no rows found (not an error, but useful)
                        If rowCount = 0 Then
                            LogError(New Exception($"No rows found in table '{tableName}' with the given criteria."))
                        End If
                    End Using
                End Using

                Return results

            Catch ex As MySqlException
                LogError(ex)
                ' Optionally re-throw or return empty list

            Catch ex As Exception
                LogError(ex)

            Finally
                If conn.State = ConnectionState.Open Then conn.Close()
            End Try
        End Using
    End Function


    ' Helper: Get missing columns in the table
    Private Function GetMissingColumns(conn As MySqlConnection, tableName As String, requestedColumns As List(Of String)) As List(Of String)
        Dim query As String = "SELECT COLUMN_NAME FROM INFORMATION_SCHEMA.COLUMNS WHERE TABLE_SCHEMA = DATABASE() AND TABLE_NAME = @tableName"
        Dim existingColumns As New List(Of String)
        Using cmd As New MySqlCommand(query, conn)
            cmd.Parameters.AddWithValue("@tableName", tableName)
            Using reader As MySqlDataReader = cmd.ExecuteReader()
                While reader.Read()
                    existingColumns.Add(reader.GetString(0))
                End While
            End Using
        End Using

        Return requestedColumns.Where(Function(c) Not existingColumns.Contains(c)).ToList()
    End Function

    ' Logging helper (from your datacon class)
    Private Sub LogError(ex As Exception)
        Try
            Dim sb As New StringBuilder()
            sb.AppendLine($"[{DateTime.UtcNow:yyyy-MM-dd HH:mm:ss} UTC] {ex.GetType().FullName}: {ex.Message}")
            If ex.StackTrace IsNot Nothing Then sb.AppendLine(ex.StackTrace)
            File.AppendAllText("db_errors.log", sb.ToString())
        Catch
            ' Ignore logging errors
        End Try
    End Sub





End Class
