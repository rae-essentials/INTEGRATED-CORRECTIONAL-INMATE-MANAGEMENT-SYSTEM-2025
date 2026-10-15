Imports System.Data.SqlClient
Imports MySql.Data.MySqlClient
Imports Mysqlx
Public Class displayP
    Dim conn As New MySqlConnection("server=localhost;userid=root;password=;database=itecfinals")
    Dim cmd As New MySqlCommand
    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        Try
            conn.Open()
            Dim query As String = "SELECT * FROM prisoners 
                       WHERE firstname LIKE @keyword 
                       OR middlename LIKE @keyword 
                       OR lastname LIKE @keyword
                       OR admissiondate LIKE @keyword
                       OR releasedate LIKE @keyword"

            Dim cmd As New MySqlCommand(query, conn)
            cmd.Parameters.AddWithValue("@keyword", "%" & txtSearch.Text.Trim() & "%")

            Dim adapter As New MySqlDataAdapter(cmd)
            Dim table As New DataTable()
            adapter.Fill(table)

            DataGridView1.DataSource = table

            If table.Rows.Count = 0 Then
                MessageBox.Show("No records found!")
            End If
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        Finally
            conn.Close()
        End Try
    End Sub

    Private Sub displayP_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim conStr As String = "server=localhost;user id=root;password=;database=itecfinals"
        Dim sqlQuery As String = "SELECT * FROM prisoners"

        Using connection As New MySqlConnection(conStr)
            Using adapter As New MySqlDataAdapter(sqlQuery, connection)
                Dim dataTable As New DataTable()
                Try
                    connection.Open()
                    adapter.Fill(dataTable)
                    DataGridView1.DataSource = dataTable

                Catch ex As Exception
                    MessageBox.Show("Error loading data: " & ex.Message)
                End Try
            End Using
        End Using
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Me.Close()
        ICPIM.Show()
    End Sub
End Class