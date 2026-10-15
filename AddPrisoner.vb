Imports MySql.Data.MySqlClient
Imports Project.datacon
Public Class AddPrisoner

    Dim fullname As String
    Dim gender As String
    Dim datebirth As String
    Dim age As Integer
    Dim contact As Integer
    Dim address As String
    Dim phonenum As String
    Dim cellnum As String
    Dim crimecommited As String
    Dim crimedes As String
    Dim admmitdate As String
    Dim descrip As String
    Dim released As String
    Dim sentlenght As Integer

    Dim yearInt As Integer = Date.Now.Year
    Dim con As String = "server=localhost;userid=root;password=;database=itecfinals"
    Dim db As New datacon

    Private Function Agecounter(yearbirth As Integer)
        Dim age As Integer = yearInt - yearbirth
        Return age
    End Function

    Private Sub btnclear_Click(sender As Object, e As EventArgs) Handles btnclear.Click
        txtPfn.Clear()
        txtPln.Clear()
        middle_txt.Clear()
        address_txt.Clear()
        cellnumber_txt.Clear()
        descrpTxt.Clear()
        txtcellno.Clear()
        gendercmb.SelectedIndex = -1
        crimeclassdrp.SelectedIndex = -1

        DateTimePicker_admission.Format = DateTimePickerFormat.Custom
        DateTimePicker_admission.CustomFormat = "'Select Admission Date'"

        DateTimePicker_bday.Format = DateTimePickerFormat.Custom
        DateTimePicker_bday.CustomFormat = "'Select Birthdate'"

        DateTimePicker_release.Format = DateTimePickerFormat.Custom
        DateTimePicker_release.CustomFormat = "'Select Release Date'"
    End Sub

    Private Sub DateTimePicker_admission_ValueChanged(sender As Object, e As EventArgs) Handles DateTimePicker_admission.ValueChanged
        DateTimePicker_admission.Format = DateTimePickerFormat.Long
    End Sub

    Private Sub DateTimePicker_bday_ValueChanged(sender As Object, e As EventArgs) Handles DateTimePicker_bday.ValueChanged
        DateTimePicker_bday.Format = DateTimePickerFormat.Long
    End Sub

    Private Sub DateTimePicker_release_ValueChanged(sender As Object, e As EventArgs) Handles DateTimePicker_release.ValueChanged
        DateTimePicker_release.Format = DateTimePickerFormat.Long
    End Sub

    Private Sub btnsubmit_Click(sender As Object, e As EventArgs)
    End Sub

    Private Sub AddPrisoner_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        panel_addprisoner.Visible = True
        panel_addprisoner.Size = New Size(1325, 550)
        panel_addprisoner.Location = New Point(3, 6)

        DateTimePicker_admission.Format = DateTimePickerFormat.Custom
        DateTimePicker_admission.CustomFormat = "'Select Admission Date?'"

        DateTimePicker_bday.Format = DateTimePickerFormat.Custom
        DateTimePicker_bday.CustomFormat = "'Select Birthdate'"

        DateTimePicker_release.Format = DateTimePickerFormat.Custom
        DateTimePicker_release.CustomFormat = "'Select Release Date'"

        gendercmb.Text = "Select Gender"
    End Sub

    Private Sub btnsubmit_Click_1(sender As Object, e As EventArgs) Handles btnsubmit.Click
        '-Confirm talaga toh-

        datebirth = DateTimePicker_bday.Value.Year

        ' --- VALIDATE INPUTS FIRST ---
        If Not ValidatePrisonerInputs() Then
            Exit Sub
        End If

        If Agecounter(datebirth) < 18 Then
            MessageBox.Show("Prisoner must be at least 18 years old.", "Invalid Age")
            Exit Sub
        End If

        ' --- SHOW CONFIRMATION PANEL ONLY IF VALIDATION PASSES ---
        confirmation_panel.Size = New Size(1325, 550)
        confirmation_panel.Location = New Point(3, 6)
        panel_addprisoner.Visible = False
        confirmation_panel.Visible = True

        ' --- GET FULL NAME & GENDER ---
        fullname = txtPln.Text.Trim() + ", " + txtPfn.Text.Trim() + ", " + middle_txt.Text.Trim()
        gender = gendercmb.Text
        datebirth = DateTimePicker_bday.Value.DayOfYear
        crimecommited = crimeclassdrp.Text
        cellnum = cellnumber_txt.Text
        phonenum = txtcellno.Text
        address = address_txt.Text
        descrip = descrpTxt.Text
        admmitdate = DateTimePicker_admission.Value.DayOfYear
        released = DateTimePicker_release.Value.DayOfYear

        ' --- COMPUTE AGE ---
        age = Agecounter(DateTimePicker_bday.Value.Year)

        ' --- COMPUTE TOTAL SENTENCE (YEARS) ---
        sentlenght = GetTotalSentence(DateTimePicker_admission.Value, DateTimePicker_release.Value)

        ' --- DISPLAY TO TEXTBOXES IN CONFIRMATION PANEL ---
        txtFullname.Text = fullname
        txtGender.Text = gender
        txtBday.Text = DateTimePicker_bday.Value.ToLongDateString()
        txtPhone.Text = phonenum
        txtCell.Text = cellnum
        txtAddress.Text = address
        txtCrimeCommit.Text = crimecommited
        txtDescrip.Text = descrip
        txtAdmit.Text = DateTimePicker_admission.Value.ToLongDateString()
        txtRelease.Text = DateTimePicker_release.Value.ToLongDateString()
        txtAge.Text = age.ToString()
        txtSentence.Text = sentlenght.ToString() & " year(s)"




    End Sub

    Private Function ValidatePrisonerInputs() As Boolean

        ' --- NAME VALIDATION ---
        If txtPln.Text.Trim() = "" Then
            MessageBox.Show("Please enter Last Name.", "Missing Data")
            txtPln.Focus()
            Return False
        End If

        If txtPfn.Text.Trim() = "" Then
            MessageBox.Show("Please enter First Name.", "Missing Data")
            txtPfn.Focus()
            Return False
        End If

        ' --- GENDER ---
        If gendercmb.SelectedIndex = -1 Then
            MessageBox.Show("Please select Gender.", "Missing Data")
            gendercmb.Focus()
            Return False
        End If

        ' --- BIRTHDAY ---
        If DateTimePicker_bday.Value > Date.Today Then
            MessageBox.Show("Birthday cannot be in the future.", "Invalid Date")
            Return False
        End If

        ' --- CELL NO. CLASS ---
        If txtcellno.Text.Trim() = "" Then
            MessageBox.Show("Please enter cellphone Number")
            txtcellno.Focus()
            Return False
        End If

        ' --- CRIME CLASS ---
        If crimeclassdrp.SelectedIndex = -1 Then
            MessageBox.Show("Please select Crime Class.", "Missing Data")
            crimeclassdrp.Focus()
            Return False
        End If

        Return True
    End Function

    Private Sub btnback_Click(sender As Object, e As EventArgs) Handles btnback.Click
        confirmation_panel.Visible = False
        panel_addprisoner.Visible = True
        panel_addprisoner.Size = New Size(1325, 550)
        panel_addprisoner.Location = New Point(3, 6)
    End Sub




    Private Sub btnexit_Click(sender As Object, e As EventArgs) Handles btnexit.Click
        ICPIM.Show()
        Me.Hide()

    End Sub
    Private Sub btnconfirm_Click(sender As Object, e As EventArgs) Handles btnconfirm.Click
        '--ito ang submit hahaha--

        ' --- GET INPUT FIELDS ---
        Dim firstname As String = txtPfn.Text.Trim()
        Dim lastname As String = txtPln.Text.Trim()
        Dim middlename As String = middle_txt.Text.Trim()
        Dim gender As String = gendercmb.SelectedItem.ToString()
        Dim address As String = address_txt.Text.Trim()
        Dim cellphone As String = txtcellno.Text.Trim()
        Dim cellno As String = cellnumber_txt.Text.Trim()
        Dim crimeclass As String = crimeclassdrp.SelectedItem.ToString()
        Dim crimedes As String = descrpTxt.Text.Trim()

        Dim birthdate As Date = DateTimePicker_bday.Value
        Dim admitdate As Date = DateTimePicker_admission.Value
        Dim releasedate As Date = DateTimePicker_release.Value

        ' --- COMPUTE AGE ---
        Dim age As Integer = GetAge(birthdate)

        ' --- COMPUTE TOTAL SENTENCE (days) ---
        Dim totalsentence As Integer = GetTotalSentence(admitdate, releasedate) & " year(s)"

        ' --- SQL INSERT ---
        Dim query As String =
        "INSERT INTO prisoners " &
        "(firstname, lastname, middlename, gender, birthdate, age, address, cellphone, crimeclass, crimedescrip, cellno, admissiondate, releasedate, totalsentence) " &
        "VALUES (@firstname, @lastname, @middlename, @gender, @birthdate, @age, @address, @cellphone, @crimeclass, @crimedescrip, @cellno, @admissiondate, @releasedate, @totalsentence)"

        Try
            Using conn As New MySqlConnection(con)
                conn.Open()

                Using cmd As New MySqlCommand(query, conn)

                    cmd.Parameters.AddWithValue("@firstname", firstname)
                    cmd.Parameters.AddWithValue("@lastname", lastname)
                    cmd.Parameters.AddWithValue("@middlename", middlename)
                    cmd.Parameters.AddWithValue("@gender", gender)
                    cmd.Parameters.AddWithValue("@birthdate", birthdate)
                    cmd.Parameters.AddWithValue("@age", age)
                    cmd.Parameters.AddWithValue("@address", address)
                    cmd.Parameters.AddWithValue("@cellphone", cellphone)
                    cmd.Parameters.AddWithValue("@crimeclass", crimeclass)
                    cmd.Parameters.AddWithValue("@crimedescrip", crimedes)
                    cmd.Parameters.AddWithValue("@cellno", cellno)
                    cmd.Parameters.AddWithValue("@admissiondate", admitdate)
                    cmd.Parameters.AddWithValue("@releasedate", releasedate)
                    cmd.Parameters.AddWithValue("@totalsentence", totalsentence)

                    cmd.ExecuteNonQuery()
                End Using
            End Using

            MessageBox.Show("Prisoner record saved successfully!", "Success")
            confirmation_panel.Visible = False
            panel_addprisoner.Visible = True
            panel_addprisoner.Size = New Size(1325, 550)
            panel_addprisoner.Location = New Point(3, 6)

            btnclear.PerformClick()

        Catch ex As Exception
            MessageBox.Show("Database Error: " & ex.Message)
        End Try


    End Sub
    Private Function GetAge(birth As Date) As Integer
        Dim age As Integer = Date.Today.Year - birth.Year
        If Date.Today < birth.AddYears(age) Then
            age -= 1
        End If
        Return age
    End Function

    Private Function GetTotalSentence(admitdate As Date, released As Date) As Integer
        Dim totalDays As Integer = (released - admitdate).Days
        Dim years As Integer = totalDays \ 365   ' integer division
        Return years
    End Function

    Private Sub AddPrinsoner_Deactivate(sender As Object, e As EventArgs) Handles MyBase.Deactivate

    End Sub

End Class