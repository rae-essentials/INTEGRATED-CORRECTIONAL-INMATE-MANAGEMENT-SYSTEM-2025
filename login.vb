Imports MySql.Data.MySqlClient

Public Class login

    Dim con As New MySqlConnection("server=localhost;userid=root;password=;database=itecfinals")
    Dim cmd As New MySqlCommand
    Dim dr As MySqlDataReader

    Private Sub login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtpassword.PasswordChar = "*"c
        Me.Size = New Size(900, 500)
        'Parehong panel size para exact same position ng mga controls
        login_panel.Size = New Size(700, 450)
        forgotpass_panel.Size = New Size(700, 450)

        'I-center pareho
        CenterPanel(login_panel)
        CenterPanel(forgotpass_panel)

        'Default visible panel
        login_panel.Visible = True
        forgotpass_panel.Visible = False
    End Sub

    Private Sub CenterPanel(p As Panel)
        p.Location = New Point(
        (Me.ClientSize.Width - p.Width) \ 1,
        (Me.ClientSize.Height - p.Height) \ 2
    )
    End Sub

    Private Sub login_Deactivate(sender As Object, e As EventArgs) Handles MyBase.Deactivate

    End Sub
    Private Sub proceed_Click(sender As Object, e As EventArgs) Handles proceed.Click
        Try
            con.Open()

            Dim query As String = "SELECT * FROM user_tb WHERE username=@username AND password=@password"
            cmd = New MySqlCommand(query, con)

            cmd.Parameters.AddWithValue("@username", txtusername.Text)
            cmd.Parameters.AddWithValue("@password", txtpassword.Text)

            dr = cmd.ExecuteReader()

            If dr.HasRows Then
                MessageBox.Show("Login Successful!")
                Me.Hide()
                ICPIM.Show()
            Else
                MessageBox.Show("Invalid username or password.")
                txtusername.Clear()
                txtpassword.Clear()
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            con.Close()
        End Try
    End Sub

    Private Sub back_Click(sender As Object, e As EventArgs) Handles back.Click
        Me.Close()
        Form1.Show()
    End Sub
    Private Sub chkShowPassword_CheckedChanged(sender As Object, e As EventArgs) Handles chkShowPassword.CheckedChanged
        If chkShowPassword.Checked Then
            txtpassword.PasswordChar = ControlChars.NullChar
        Else
            txtpassword.PasswordChar = "*"c
        End If
    End Sub

    Private Function ValidatePasswordStrength(password As String) As Boolean

        Dim passwordPattern As String = "^(?=.*[a-zA-Z])(?=.*[0-9]).{8,}$"

        Return System.Text.RegularExpressions.Regex.IsMatch(password, passwordPattern)
    End Function

    ' --- Inalis ko na muna ang logic dito dahil ang request ay sa button na lang mag-display ---
    Private Sub txtNewPassword_TextChanged(sender As Object, e As EventArgs) Handles txtnewpass.TextChanged

        Dim isValid As Boolean = ValidatePasswordStrength(txtnewpass.Text)

        If isValid Then
            messagelbl.ForeColor = Color.Green
            messagelbl.Text = "Password is strong."
        Else
            messagelbl.Text = "" ' I-clear ang messagelbl
        '         ' Huwag muna magpakita ng error sa Label4 dito para sa real-time
        End If
    End Sub

    Private Sub btnOk_Click(sender As Object, e As EventArgs) Handles btnOk.Click
        Dim newPass As String = txtnewpass.Text.Trim()
        Dim retypePass As String = txtretypepass.Text.Trim()

        messagelbl.Text = ""

        '--- Check if fields are empty ---
        If newPass = "" Or retypePass = "" Then
            MessageBox.Show("Please enter all fields.")
            Exit Sub
        End If

        '--- Password Match Check ---
        If newPass <> retypePass Then
            MessageBox.Show("Passwords do not match.", "Error")
            Exit Sub
        End If

        '--- Password Strength Check ---
        Dim isValid As Boolean = ValidatePasswordStrength(newPass)

        If Not isValid Then
            ' ✨ Ito na ang gusto mong mangyari: Simpleng mensahe sa Label4 at iwasan ang update.
            messagelbl.ForeColor = Color.Red
            messagelbl.Text = "Must contain letter and number, at least 8 characters long."
            ' Maaari mo ring tanggalin ang MessageBox.Show() na ito:
            MessageBox.Show("Password is too weak.", "Weak Password")
            Exit Sub
        End If


        Try

            con.Open()

            Dim specificUsernameToUpdate As String = "Admin"
            Dim query As String = "UPDATE user_tb SET password=@pass WHERE username=@user"
            Dim cmd As New MySqlCommand(query, con)

            cmd.Parameters.AddWithValue("@user", specificUsernameToUpdate)
            cmd.Parameters.AddWithValue("@pass", newPass)

            Dim result = cmd.ExecuteNonQuery()

            If result > 0 Then
                MessageBox.Show("Password updated successfully!", "Success")
                CenterPanel(login_panel)
                forgotpass_panel.Visible = False
                login_panel.Visible = True
            Else
                MessageBox.Show("Update failed. User not found.")
            End If

            con.Close()
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        End Try
    End Sub



    Private Sub forgotpass_Click(sender As Object, e As EventArgs) Handles forgotpass.Click
        CenterPanel(forgotpass_panel)
        login_panel.Visible = False
        forgotpass_panel.Visible = True
    End Sub

    Private Sub backbtn_Click(sender As Object, e As EventArgs) Handles backbtn.Click
        CenterPanel(login_panel)
        forgotpass_panel.Visible = False
        login_panel.Visible = True
    End Sub
End Class