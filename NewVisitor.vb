Imports System.Data.SqlClient
Imports MySql.Data.MySqlClient
Imports Mysqlx
Public Class NewVisitor
    Dim conn As New MySqlConnection("server=localhost;userid=root;password=;database=itecfinals")
    Dim cmd As New MySqlCommand
    Dim dr As MySqlDataReader

    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        ' ====== VALIDATION ======
        If String.IsNullOrWhiteSpace(txtVfname.Text) Or
           String.IsNullOrWhiteSpace(txtVmname.Text) Or
           String.IsNullOrWhiteSpace(txtVlname.Text) Or
           String.IsNullOrWhiteSpace(cmbgender.Text) Or
           String.IsNullOrWhiteSpace(txtrelationship.Text) Or
           String.IsNullOrWhiteSpace(txtPid.Text) Or
           String.IsNullOrWhiteSpace(MaskedTextBox_in.Text.Trim()) Or
           String.IsNullOrWhiteSpace(MaskedTextBox_out.Text.Trim()) Or
           String.IsNullOrWhiteSpace(txtcomment.Text) Then

            MessageBox.Show("Please complete all fields before saving.",
                    "Missing Information",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning)
            Exit Sub
        End If
        ' ====== END VALIDATION ======


        ' ====== CONFIRMATION ======
        Dim confirm As DialogResult = MessageBox.Show(
        "Are you sure that the information you entered is correct?",
        "Confirm Save",
        MessageBoxButtons.YesNo,
        MessageBoxIcon.Question
)

        If confirm = DialogResult.No Then
            MessageBox.Show("Save cancelled.", "Cancelled", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If
        ' ====== END CONFIRMATION ======

        Try
            conn.Open()
            cmd.Connection = conn

            cmd.CommandText = "INSERT INTO visitor
                (First_Name, Last_Name, Gender,  Relationship_to_Prisoner, Prisoner_Id, Visit_Date, Time_In, Time_Out,notes) 
                   VALUES (@vfname,@vlname,@gender, @relationship,@Pid,@visit_date,@in,@out,@notes)"
            cmd.Parameters.AddWithValue("@vfname", txtVfname.Text)
            cmd.Parameters.AddWithValue("@vlname", txtVlname.Text)
            cmd.Parameters.AddWithValue("@gender", cmbgender.Text)
            cmd.Parameters.AddWithValue("@relationship", txtrelationship.Text)
            cmd.Parameters.AddWithValue("@Pid", txtPid.Text)
            cmd.Parameters.AddWithValue("@visit_date", DateTimePicker_visit.Value)

            cmd.Parameters.AddWithValue("@notes", txtcomment.Text)

            Dim tIn As DateTime
            If DateTime.TryParse(MaskedTextBox_in.Text, tIn) Then
                cmd.Parameters.AddWithValue("@in", tIn.ToString("HH:mm:ss"))
            Else
                cmd.Parameters.AddWithValue("@in", DBNull.Value)
            End If

            Dim tOut As DateTime
            If DateTime.TryParse(MaskedTextBox_out.Text, tOut) Then
                cmd.Parameters.AddWithValue("@out", tOut.ToString("HH:mm:ss"))
            Else
                cmd.Parameters.AddWithValue("@out", DBNull.Value)
            End If


            dr = cmd.ExecuteReader()

            MessageBox.Show("Record Successfully Saved!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            txtVfname.Clear()
            txtVmname.Clear()
            txtVlname.Clear()
            txtrelationship.Clear()
            txtPid.Clear()
            txtcomment.Clear()
            cmbgender.SelectedIndex = -1
            MaskedTextBox_in.Clear()
            MaskedTextBox_out.Clear()
            DateTimePicker_visit.Value = DateTime.Now

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            conn.Close()
        End Try

    End Sub

    Private Sub NewVisitor_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub



    Private Sub btnprisonInfo_Click(sender As Object, e As EventArgs) Handles btnprisonInfo.Click
        prisoner_panel.Size = New Size(1325, 550)
        prisoner_panel.Location = New Point(3, 6)
        addvi_panel.Visible = False
        prisoner_panel.Visible = True

        ' Palitan ng iyong connection string
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

    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick

        If e.RowIndex < 0 Then Exit Sub  ' Prevent header clicks

        Try
            Dim cellNum As Object = DataGridView1.Rows(e.RowIndex).Cells("cellno").Value

            If cellNum IsNot Nothing Then
                txtPid.Text = cellNum.ToString()
            Else
                txtPid.Text = ""
            End If

        Catch ex As Exception
            MessageBox.Show("COLUMN NOT FOUND: " & ex.Message)
        End Try

        prisoner_panel.Visible = False
        addvi_panel.Visible = True
        addvi_panel.Size = New Size(1325, 550)
        addvi_panel.Location = New Point(3, 6)

    End Sub
    Private Sub back_btn_Click(sender As Object, e As EventArgs) Handles back_btn.Click
        prisoner_panel.Visible = False
        addvi_panel.Visible = True
        addvi_panel.Size = New Size(1325, 550)
        addvi_panel.Location = New Point(3, 6)
    End Sub

    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        Try
            conn.Open()
            Dim query As String = "SELECT * FROM prisoners 
                       WHERE firstname LIKE @keyword 
                       OR middlename LIKE @keyword 
                       OR lastname LIKE @keyword"

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

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Hide()
        ICPIM.Show()
    End Sub


    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtVfname.Clear()
        txtVmname.Clear()
        txtVlname.Clear()
        txtrelationship.Clear()
        txtPid.Clear()
        txtcomment.Clear()
        cmbgender.SelectedIndex = -1
        MaskedTextBox_in.Clear()
        MaskedTextBox_out.Clear()
        DateTimePicker_visit.Value = DateTime.Now
    End Sub
End Class