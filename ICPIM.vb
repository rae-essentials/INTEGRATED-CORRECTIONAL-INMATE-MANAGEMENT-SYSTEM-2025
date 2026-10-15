Public Class ICPIM
    Private Sub logOutBtn_Click(sender As Object, e As EventArgs) Handles logOutBtn.Click
        Dim logout As DialogResult = MessageBox.Show("Are you sure you want to logout?", "Confirm Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If logout = DialogResult.Yes Then
            Me.Close()
            Form1.Show()
        End If
    End Sub

    Private Sub aboutUsbtn_Click(sender As Object, e As EventArgs) Handles aboutUsbtn.Click
        Dim aboutUsForm As New Us()
        aboutUsForm.Show()
        Me.Hide()
    End Sub

    Private Sub dailyActbtn_Click(sender As Object, e As EventArgs) Handles dailyActbtn.Click
        Dim dailyactivities As New dailyActivities()
        dailyactivities.Show()
        Me.Hide()
    End Sub

    Private Sub btnaddPrisoner_Click(sender As Object, e As EventArgs) Handles btnaddPrisoner.Click
        Dim addprisoner As New AddPrisoner()
        addprisoner.Show()
        Me.Hide()
    End Sub

    Private Sub btnnewVisitor_Click(sender As Object, e As EventArgs) Handles btnnewVisitor.Click
        Dim newvisitor As New NewVisitor()
        newvisitor.Show()
        Me.Hide()
    End Sub

    Private Sub newsbtn_Click(sender As Object, e As EventArgs) Handles newsbtn.Click
        Me.Close()
        DailyNews.Show()
    End Sub

    Private Sub prisonerbtn_Click(sender As Object, e As EventArgs) Handles prisonerbtn.Click
        Me.Close()
        displayP.Show()
    End Sub

    Private Sub visitorbtn_Click(sender As Object, e As EventArgs) Handles visitorbtn.Click
        Me.Close()
        displayV.Show()
    End Sub
End Class