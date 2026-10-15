<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class NewVisitor
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(NewVisitor))
        Me.addvi_panel = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.btnprisonInfo = New System.Windows.Forms.Button()
        Me.txtVmname = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtVlname = New System.Windows.Forms.TextBox()
        Me.cmbgender = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtrelationship = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtPid = New System.Windows.Forms.TextBox()
        Me.txtVfname = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.btnSubmit = New System.Windows.Forms.Button()
        Me.MaskedTextBox_out = New System.Windows.Forms.MaskedTextBox()
        Me.MaskedTextBox_in = New System.Windows.Forms.MaskedTextBox()
        Me.DateTimePicker_visit = New System.Windows.Forms.DateTimePicker()
        Me.txtcomment = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.prisoner_panel = New System.Windows.Forms.Panel()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txtSearch = New System.Windows.Forms.TextBox()
        Me.back_btn = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.addvi_panel.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.prisoner_panel.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'addvi_panel
        '
        Me.addvi_panel.BackColor = System.Drawing.Color.Transparent
        Me.addvi_panel.Controls.Add(Me.PictureBox1)
        Me.addvi_panel.Controls.Add(Me.btnprisonInfo)
        Me.addvi_panel.Controls.Add(Me.txtVmname)
        Me.addvi_panel.Controls.Add(Me.Label4)
        Me.addvi_panel.Controls.Add(Me.txtVlname)
        Me.addvi_panel.Controls.Add(Me.cmbgender)
        Me.addvi_panel.Controls.Add(Me.Label3)
        Me.addvi_panel.Controls.Add(Me.txtrelationship)
        Me.addvi_panel.Controls.Add(Me.Label2)
        Me.addvi_panel.Controls.Add(Me.Label5)
        Me.addvi_panel.Controls.Add(Me.Label11)
        Me.addvi_panel.Controls.Add(Me.txtPid)
        Me.addvi_panel.Controls.Add(Me.txtVfname)
        Me.addvi_panel.Controls.Add(Me.Label10)
        Me.addvi_panel.Controls.Add(Me.btnClear)
        Me.addvi_panel.Controls.Add(Me.btnExit)
        Me.addvi_panel.Controls.Add(Me.btnSubmit)
        Me.addvi_panel.Controls.Add(Me.MaskedTextBox_out)
        Me.addvi_panel.Controls.Add(Me.MaskedTextBox_in)
        Me.addvi_panel.Controls.Add(Me.DateTimePicker_visit)
        Me.addvi_panel.Controls.Add(Me.txtcomment)
        Me.addvi_panel.Controls.Add(Me.Label9)
        Me.addvi_panel.Controls.Add(Me.Label8)
        Me.addvi_panel.Controls.Add(Me.Label7)
        Me.addvi_panel.Controls.Add(Me.Label6)
        Me.addvi_panel.Controls.Add(Me.Label1)
        Me.addvi_panel.Location = New System.Drawing.Point(13, 13)
        Me.addvi_panel.Name = "addvi_panel"
        Me.addvi_panel.Size = New System.Drawing.Size(1294, 573)
        Me.addvi_panel.TabIndex = 0
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = Global.Project.My.Resources.Resources.logo
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.Location = New System.Drawing.Point(11, 32)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(213, 216)
        Me.PictureBox1.TabIndex = 55
        Me.PictureBox1.TabStop = False
        '
        'btnprisonInfo
        '
        Me.btnprisonInfo.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnprisonInfo.Location = New System.Drawing.Point(680, 394)
        Me.btnprisonInfo.Name = "btnprisonInfo"
        Me.btnprisonInfo.Size = New System.Drawing.Size(40, 32)
        Me.btnprisonInfo.TabIndex = 54
        Me.btnprisonInfo.Text = "🔍"
        Me.btnprisonInfo.UseVisualStyleBackColor = True
        '
        'txtVmname
        '
        Me.txtVmname.Location = New System.Drawing.Point(525, 174)
        Me.txtVmname.Name = "txtVmname"
        Me.txtVmname.Size = New System.Drawing.Size(195, 22)
        Me.txtVmname.TabIndex = 53
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(322, 176)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(124, 20)
        Me.Label4.TabIndex = 52
        Me.Label4.Text = "Middle Name:"
        '
        'txtVlname
        '
        Me.txtVlname.Location = New System.Drawing.Point(525, 249)
        Me.txtVlname.Margin = New System.Windows.Forms.Padding(10)
        Me.txtVlname.Name = "txtVlname"
        Me.txtVlname.Size = New System.Drawing.Size(195, 22)
        Me.txtVlname.TabIndex = 39
        '
        'cmbgender
        '
        Me.cmbgender.FormattingEnabled = True
        Me.cmbgender.Items.AddRange(New Object() {"Male", "Female"})
        Me.cmbgender.Location = New System.Drawing.Point(525, 318)
        Me.cmbgender.Margin = New System.Windows.Forms.Padding(10)
        Me.cmbgender.Name = "cmbgender"
        Me.cmbgender.Size = New System.Drawing.Size(195, 24)
        Me.cmbgender.TabIndex = 50
        Me.cmbgender.Text = "Select Gender"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(322, 322)
        Me.Label3.Margin = New System.Windows.Forms.Padding(10)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(76, 20)
        Me.Label3.TabIndex = 32
        Me.Label3.Text = "Gender:"
        '
        'txtrelationship
        '
        Me.txtrelationship.Location = New System.Drawing.Point(1015, 113)
        Me.txtrelationship.Margin = New System.Windows.Forms.Padding(10, 10, 250, 10)
        Me.txtrelationship.Name = "txtrelationship"
        Me.txtrelationship.Size = New System.Drawing.Size(200, 22)
        Me.txtrelationship.TabIndex = 38
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(322, 115)
        Me.Label2.Margin = New System.Windows.Forms.Padding(10)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(108, 20)
        Me.Label2.TabIndex = 31
        Me.Label2.Text = "First Name:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(322, 404)
        Me.Label5.Margin = New System.Windows.Forms.Padding(10)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(187, 20)
        Me.Label5.TabIndex = 33
        Me.Label5.Text = "Cell No. of  Prisoner:"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(322, 251)
        Me.Label11.Margin = New System.Windows.Forms.Padding(10)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(106, 20)
        Me.Label11.TabIndex = 51
        Me.Label11.Text = "Last Name:"
        '
        'txtPid
        '
        Me.txtPid.Location = New System.Drawing.Point(552, 399)
        Me.txtPid.Margin = New System.Windows.Forms.Padding(10)
        Me.txtPid.Name = "txtPid"
        Me.txtPid.Size = New System.Drawing.Size(124, 22)
        Me.txtPid.TabIndex = 41
        '
        'txtVfname
        '
        Me.txtVfname.Location = New System.Drawing.Point(525, 113)
        Me.txtVfname.Margin = New System.Windows.Forms.Padding(10)
        Me.txtVfname.Name = "txtVfname"
        Me.txtVfname.Size = New System.Drawing.Size(195, 22)
        Me.txtVfname.TabIndex = 40
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(768, 115)
        Me.Label10.Margin = New System.Windows.Forms.Padding(10)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(218, 20)
        Me.Label10.TabIndex = 49
        Me.Label10.Text = "Relationship to Prisoner:"
        '
        'btnClear
        '
        Me.btnClear.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClear.Location = New System.Drawing.Point(552, 497)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(97, 31)
        Me.btnClear.TabIndex = 48
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.Location = New System.Drawing.Point(828, 497)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(97, 31)
        Me.btnExit.TabIndex = 47
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'btnSubmit
        '
        Me.btnSubmit.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSubmit.Location = New System.Drawing.Point(697, 497)
        Me.btnSubmit.Name = "btnSubmit"
        Me.btnSubmit.Size = New System.Drawing.Size(97, 31)
        Me.btnSubmit.TabIndex = 46
        Me.btnSubmit.Text = "Submit"
        Me.btnSubmit.UseVisualStyleBackColor = True
        '
        'MaskedTextBox_out
        '
        Me.MaskedTextBox_out.Location = New System.Drawing.Point(1015, 318)
        Me.MaskedTextBox_out.Name = "MaskedTextBox_out"
        Me.MaskedTextBox_out.Size = New System.Drawing.Size(200, 22)
        Me.MaskedTextBox_out.TabIndex = 45
        '
        'MaskedTextBox_in
        '
        Me.MaskedTextBox_in.Location = New System.Drawing.Point(1015, 249)
        Me.MaskedTextBox_in.Name = "MaskedTextBox_in"
        Me.MaskedTextBox_in.Size = New System.Drawing.Size(200, 22)
        Me.MaskedTextBox_in.TabIndex = 44
        '
        'DateTimePicker_visit
        '
        Me.DateTimePicker_visit.Location = New System.Drawing.Point(1015, 172)
        Me.DateTimePicker_visit.Name = "DateTimePicker_visit"
        Me.DateTimePicker_visit.Size = New System.Drawing.Size(232, 22)
        Me.DateTimePicker_visit.TabIndex = 43
        '
        'txtcomment
        '
        Me.txtcomment.Location = New System.Drawing.Point(1015, 404)
        Me.txtcomment.Name = "txtcomment"
        Me.txtcomment.Size = New System.Drawing.Size(200, 22)
        Me.txtcomment.TabIndex = 42
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(768, 404)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(94, 20)
        Me.Label9.TabIndex = 37
        Me.Label9.Text = "Comment:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(768, 322)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(92, 20)
        Me.Label8.TabIndex = 36
        Me.Label8.Text = "Time Out:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(768, 251)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(77, 20)
        Me.Label7.TabIndex = 35
        Me.Label7.Text = "Time In:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(768, 174)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(121, 20)
        Me.Label6.TabIndex = 34
        Me.Label6.Text = "Date of Visit:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Impact", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(22, 287)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(192, 150)
        Me.Label1.TabIndex = 30
        Me.Label1.Text = "New " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Visitor" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'prisoner_panel
        '
        Me.prisoner_panel.BackColor = System.Drawing.Color.Transparent
        Me.prisoner_panel.Controls.Add(Me.PictureBox2)
        Me.prisoner_panel.Controls.Add(Me.Label13)
        Me.prisoner_panel.Controls.Add(Me.Label12)
        Me.prisoner_panel.Controls.Add(Me.txtSearch)
        Me.prisoner_panel.Controls.Add(Me.back_btn)
        Me.prisoner_panel.Controls.Add(Me.DataGridView1)
        Me.prisoner_panel.Location = New System.Drawing.Point(13, 29)
        Me.prisoner_panel.Name = "prisoner_panel"
        Me.prisoner_panel.Size = New System.Drawing.Size(1294, 10)
        Me.prisoner_panel.TabIndex = 1
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(275, 37)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(102, 22)
        Me.Label12.TabIndex = 3
        Me.Label12.Text = "Search🔍:"
        '
        'txtSearch
        '
        Me.txtSearch.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSearch.Location = New System.Drawing.Point(394, 37)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(271, 27)
        Me.txtSearch.TabIndex = 2
        '
        'back_btn
        '
        Me.back_btn.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.back_btn.Location = New System.Drawing.Point(64, 507)
        Me.back_btn.Name = "back_btn"
        Me.back_btn.Size = New System.Drawing.Size(81, 37)
        Me.back_btn.TabIndex = 1
        Me.back_btn.Text = "Back"
        Me.back_btn.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.WhiteSmoke
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(279, 83)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersWidth = 51
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.Size = New System.Drawing.Size(992, 461)
        Me.DataGridView1.TabIndex = 0
        '
        'PictureBox2
        '
        Me.PictureBox2.BackgroundImage = CType(resources.GetObject("PictureBox2.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox2.Location = New System.Drawing.Point(11, 9)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(213, 223)
        Me.PictureBox2.TabIndex = 7
        Me.PictureBox2.TabStop = False
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.BackColor = System.Drawing.Color.Transparent
        Me.Label13.Font = New System.Drawing.Font("Impact", 28.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label13.Location = New System.Drawing.Point(11, 235)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(213, 177)
        Me.Label13.TabIndex = 6
        Me.Label13.Text = "Records" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & " of " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Prisoners"
        Me.Label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'NewVisitor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Project.My.Resources.Resources.bg2
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1310, 598)
        Me.Controls.Add(Me.prisoner_panel)
        Me.Controls.Add(Me.addvi_panel)
        Me.DoubleBuffered = True
        Me.Name = "NewVisitor"
        Me.Text = "NewVisitor"
        Me.addvi_panel.ResumeLayout(False)
        Me.addvi_panel.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.prisoner_panel.ResumeLayout(False)
        Me.prisoner_panel.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents addvi_panel As Panel
    Friend WithEvents txtVlname As TextBox
    Friend WithEvents cmbgender As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtrelationship As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents txtPid As TextBox
    Friend WithEvents txtVfname As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents btnClear As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents btnSubmit As Button
    Friend WithEvents MaskedTextBox_out As MaskedTextBox
    Friend WithEvents MaskedTextBox_in As MaskedTextBox
    Friend WithEvents DateTimePicker_visit As DateTimePicker
    Friend WithEvents txtcomment As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txtVmname As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents btnprisonInfo As Button
    Friend WithEvents prisoner_panel As Panel
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents back_btn As Button
    Friend WithEvents Label12 As Label
    Friend WithEvents txtSearch As TextBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Label13 As Label
End Class
