Public Class Form1
    Private Sub exitbtn_Click(sender As Object, e As EventArgs) Handles exitbtn.Click
        Dim result As DialogResult = MessageBox.Show("Do you want to close?", "Confirm Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If result = DialogResult.Yes Then
            Application.Exit()
        End If
    End Sub

    Private Sub loginbtn_Click(sender As Object, e As EventArgs) Handles loginbtn.Click
        Me.Hide()

        login.Show()
    End Sub

    Private Sub loginbtn_MouseEnter(sender As Object, e As EventArgs) Handles loginbtn.MouseEnter
        lblMessage.Text = "Only admin can login"
        lblMessage.Visible = True
    End Sub

    Private Sub loginbtn_MouseLeave(sender As Object, e As EventArgs) Handles loginbtn.MouseLeave
        lblMessage.Visible = False
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblMessage.Visible = False

    End Sub


End Class
