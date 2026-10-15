Imports MySql.Data.MySqlClient

Public Class dailyActivities
    Dim conn As New MySqlConnection("server=localhost;user id=root;password=;database=itecfinals")
    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    Private Sub backbtn_Click(sender As Object, e As EventArgs) Handles backbtn.Click
        Me.Close()
        ICPIM.Show()
    End Sub

    Private Sub dailyActivities_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            conn.Open()
            Dim query As String = "SELECT day_of_week, time_start, time_end, activity_description FROM prisoner_daily_activity ORDER BY FIELD(day_of_week, 'Monday','Tuesday','Wednesday','Thursday','Friday','Saturday','Sunday'), time_start"
            Dim cmd As New MySqlCommand(query, conn)
            Dim adapter As New MySqlDataAdapter(cmd)
            Dim table As New DataTable()
            adapter.Fill(table)

            DataGridView1.DataSource = table

            DataGridView1.DefaultCellStyle.Font = New Font("Segoe UI", 12)                ' Row text
            DataGridView1.ColumnHeadersDefaultCellStyle.Font = New Font("Segoe UI", 12, FontStyle.Bold)  ' Header text
            DataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells

            conn.Close()

        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        Finally
            conn.Close()
        End Try
    End Sub


End Class

