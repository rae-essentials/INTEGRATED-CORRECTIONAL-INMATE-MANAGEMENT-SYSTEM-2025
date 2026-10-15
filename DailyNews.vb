Imports MySql.Data.MySqlClient
Imports Mysqlx.Crud
Public Class DailyNews
    Dim conn As New MySqlConnection("server=localhost;user id=root;password=;database=itecfinals")
    Private Sub LoadDailyNews()
        Try
            conn.Open()
            Dim query As String = "SELECT news_date, visitor_count, admitted_count, released_count, incident_count, descriptions 
                       FROM daily_news 
                       ORDER BY news_date DESC"
            Dim cmd As New MySqlCommand(query, conn)
            Dim adapter As New MySqlDataAdapter(cmd)
            Dim table As New DataTable()
            adapter.Fill(table)
            DataGridView1.DataSource = table

            ' Optional formatting
            DataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
            DataGridView1.ReadOnly = True
            DataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect

            conn.Close()
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        Finally
            conn.Close()
        End Try
    End Sub

    ' Clear input fields
    Private Sub ClearInputs()
        txtvisitCount.Text = 0
        txtadmmiCount.Text = 0
        txtreliCount.Text = 0
        txtinciCount.Text = 0
        txtdescription.Clear()
        DateTimePicker_news.Value = Date.Today
        txtSearch.Clear()
    End Sub

    ' Save Daily News
    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Try
            conn.Open()
            Dim query As String = "INSERT INTO daily_news (news_date, visitor_count, admitted_count, released_count, incident_count, descriptions) " &
                                  "VALUES (@news_date, @visitor, @admitted, @released, @incident, @desc)"
            Dim cmd As New MySqlCommand(query, conn)
            cmd.Parameters.AddWithValue("@news_date", DateTimePicker_news.Value.ToString("yyyy-MM-dd"))
            cmd.Parameters.AddWithValue("@visitor", CInt(txtvisitCount.Text))
            cmd.Parameters.AddWithValue("@admitted", CInt(txtadmmiCount.Text))
            cmd.Parameters.AddWithValue("@released", CInt(txtreliCount.Text))
            cmd.Parameters.AddWithValue("@incident", CInt(txtinciCount.Text))
            cmd.Parameters.AddWithValue("@desc", txtdescription.Text)
            cmd.ExecuteNonQuery()
            conn.Close()

            MessageBox.Show("Daily news saved successfully!")
            LoadDailyNews()
            ClearInputs()
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        Finally
            conn.Close()
        End Try
    End Sub

    ' Refresh DataGridView
    Private Sub btnRefresh_Click(sender As Object, e As EventArgs) Handles btnRefresh.Click
        LoadDailyNews()
        ClearInputs()
    End Sub

    ' Search Daily News
    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        Try
            conn.Open()
            Dim query As String = "SELECT * FROM daily_news WHERE descriptions LIKE @keyword"
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



    ' Optional: live search while typing
    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        btnSearch_Click(sender, e)
    End Sub

    ' Form Load
    Private Sub DailyNews_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadDailyNews()
        ' HEADER FONT
        DataGridView1.ColumnHeadersDefaultCellStyle.Font = New Font("Segoe UI", 8, FontStyle.Bold)

        ' HEADER HEIGHT
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        DataGridView1.ColumnHeadersHeight = 30

        ' WORD WRAP
        DataGridView1.ColumnHeadersDefaultCellStyle.WrapMode = DataGridViewTriState.True

        ' AUTO-SIZE COLUMNS
        DataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells

    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Me.Close()
        ICPIM.Show()
    End Sub
End Class
