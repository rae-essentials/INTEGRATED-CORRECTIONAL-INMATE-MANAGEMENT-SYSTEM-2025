<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class login
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
        Me.txtusername = New System.Windows.Forms.TextBox()
        Me.txtpassword = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.proceed = New System.Windows.Forms.Button()
        Me.back = New System.Windows.Forms.Button()
        Me.chkShowPassword = New System.Windows.Forms.CheckBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.login_panel = New System.Windows.Forms.Panel()
        Me.forgotpass = New System.Windows.Forms.Button()
        Me.forgotpass_panel = New System.Windows.Forms.Panel()
        Me.backbtn = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.messagelbl = New System.Windows.Forms.Label()
        Me.btnOk = New System.Windows.Forms.Button()
        Me.txtretypepass = New System.Windows.Forms.TextBox()
        Me.txtnewpass = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.currentpass = New System.Windows.Forms.Label()
        Me.login_panel.SuspendLayout()
        Me.forgotpass_panel.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtusername
        '
        Me.txtusername.Location = New System.Drawing.Point(179, 181)
        Me.txtusername.Name = "txtusername"
        Me.txtusername.Size = New System.Drawing.Size(194, 22)
        Me.txtusername.TabIndex = 0
        '
        'txtpassword
        '
        Me.txtpassword.Location = New System.Drawing.Point(179, 230)
        Me.txtpassword.Name = "txtpassword"
        Me.txtpassword.Size = New System.Drawing.Size(194, 22)
        Me.txtpassword.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(77, 185)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(87, 18)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "username:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(78, 234)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(86, 18)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "password:"
        '
        'proceed
        '
        Me.proceed.BackColor = System.Drawing.SystemColors.Control
        Me.proceed.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.proceed.Location = New System.Drawing.Point(153, 340)
        Me.proceed.Name = "proceed"
        Me.proceed.Size = New System.Drawing.Size(94, 33)
        Me.proceed.TabIndex = 4
        Me.proceed.Text = "LOGIN"
        Me.proceed.UseVisualStyleBackColor = False
        '
        'back
        '
        Me.back.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.back.Location = New System.Drawing.Point(6, 340)
        Me.back.Name = "back"
        Me.back.Size = New System.Drawing.Size(94, 33)
        Me.back.TabIndex = 5
        Me.back.Text = "BACK"
        Me.back.UseVisualStyleBackColor = True
        '
        'chkShowPassword
        '
        Me.chkShowPassword.AutoSize = True
        Me.chkShowPassword.BackColor = System.Drawing.Color.Transparent
        Me.chkShowPassword.Location = New System.Drawing.Point(179, 258)
        Me.chkShowPassword.Name = "chkShowPassword"
        Me.chkShowPassword.Size = New System.Drawing.Size(122, 20)
        Me.chkShowPassword.TabIndex = 6
        Me.chkShowPassword.Text = "show password"
        Me.chkShowPassword.UseVisualStyleBackColor = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Georgia", 19.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(201, 74)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(139, 39)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "LOGIN"
        '
        'login_panel
        '
        Me.login_panel.BackColor = System.Drawing.Color.Transparent
        Me.login_panel.Controls.Add(Me.forgotpass)
        Me.login_panel.Controls.Add(Me.Label3)
        Me.login_panel.Controls.Add(Me.txtusername)
        Me.login_panel.Controls.Add(Me.chkShowPassword)
        Me.login_panel.Controls.Add(Me.txtpassword)
        Me.login_panel.Controls.Add(Me.back)
        Me.login_panel.Controls.Add(Me.Label1)
        Me.login_panel.Controls.Add(Me.proceed)
        Me.login_panel.Controls.Add(Me.Label2)
        Me.login_panel.Location = New System.Drawing.Point(478, 48)
        Me.login_panel.Name = "login_panel"
        Me.login_panel.Size = New System.Drawing.Size(515, 10)
        Me.login_panel.TabIndex = 8
        '
        'forgotpass
        '
        Me.forgotpass.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.forgotpass.Location = New System.Drawing.Point(299, 339)
        Me.forgotpass.Name = "forgotpass"
        Me.forgotpass.Size = New System.Drawing.Size(175, 33)
        Me.forgotpass.TabIndex = 8
        Me.forgotpass.Text = "Forgot Password"
        Me.forgotpass.UseVisualStyleBackColor = True
        '
        'forgotpass_panel
        '
        Me.forgotpass_panel.BackColor = System.Drawing.Color.Transparent
        Me.forgotpass_panel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.forgotpass_panel.Controls.Add(Me.backbtn)
        Me.forgotpass_panel.Controls.Add(Me.Label4)
        Me.forgotpass_panel.Controls.Add(Me.messagelbl)
        Me.forgotpass_panel.Controls.Add(Me.btnOk)
        Me.forgotpass_panel.Controls.Add(Me.txtretypepass)
        Me.forgotpass_panel.Controls.Add(Me.txtnewpass)
        Me.forgotpass_panel.Controls.Add(Me.Label5)
        Me.forgotpass_panel.Controls.Add(Me.currentpass)
        Me.forgotpass_panel.Location = New System.Drawing.Point(478, 61)
        Me.forgotpass_panel.Name = "forgotpass_panel"
        Me.forgotpass_panel.Size = New System.Drawing.Size(572, 477)
        Me.forgotpass_panel.TabIndex = 9
        '
        'backbtn
        '
        Me.backbtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.backbtn.Location = New System.Drawing.Point(122, 352)
        Me.backbtn.Name = "backbtn"
        Me.backbtn.Size = New System.Drawing.Size(88, 40)
        Me.backbtn.TabIndex = 7
        Me.backbtn.Text = "Back"
        Me.backbtn.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Georgia", 19.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(64, 74)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(334, 39)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Forgot Password?"
        '
        'messagelbl
        '
        Me.messagelbl.AutoSize = True
        Me.messagelbl.Location = New System.Drawing.Point(219, 225)
        Me.messagelbl.Name = "messagelbl"
        Me.messagelbl.Size = New System.Drawing.Size(10, 16)
        Me.messagelbl.TabIndex = 5
        Me.messagelbl.Text = "."
        '
        'btnOk
        '
        Me.btnOk.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnOk.Location = New System.Drawing.Point(299, 352)
        Me.btnOk.Name = "btnOk"
        Me.btnOk.Size = New System.Drawing.Size(88, 40)
        Me.btnOk.TabIndex = 4
        Me.btnOk.Text = "Submit"
        Me.btnOk.UseVisualStyleBackColor = True
        '
        'txtretypepass
        '
        Me.txtretypepass.Location = New System.Drawing.Point(222, 265)
        Me.txtretypepass.Name = "txtretypepass"
        Me.txtretypepass.Size = New System.Drawing.Size(176, 22)
        Me.txtretypepass.TabIndex = 3
        '
        'txtnewpass
        '
        Me.txtnewpass.Location = New System.Drawing.Point(222, 197)
        Me.txtnewpass.Name = "txtnewpass"
        Me.txtnewpass.Size = New System.Drawing.Size(176, 22)
        Me.txtnewpass.TabIndex = 2
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(65, 269)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(145, 18)
        Me.Label5.TabIndex = 1
        Me.Label5.Text = "Retype Password:"
        '
        'currentpass
        '
        Me.currentpass.AutoSize = True
        Me.currentpass.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.currentpass.Location = New System.Drawing.Point(65, 198)
        Me.currentpass.Name = "currentpass"
        Me.currentpass.Size = New System.Drawing.Size(126, 18)
        Me.currentpass.TabIndex = 0
        Me.currentpass.Text = "New Password:"
        '
        'login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.BackgroundImage = Global.Project.My.Resources.Resources.bg
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1250, 594)
        Me.Controls.Add(Me.forgotpass_panel)
        Me.Controls.Add(Me.login_panel)
        Me.DoubleBuffered = True
        Me.Name = "login"
        Me.Text = "login"
        Me.login_panel.ResumeLayout(False)
        Me.login_panel.PerformLayout()
        Me.forgotpass_panel.ResumeLayout(False)
        Me.forgotpass_panel.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents txtusername As TextBox
    Friend WithEvents txtpassword As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents proceed As Button
    Friend WithEvents back As Button
    Friend WithEvents chkShowPassword As CheckBox
    Friend WithEvents Label3 As Label
    Friend WithEvents login_panel As Panel
    Friend WithEvents forgotpass_panel As Panel
    Friend WithEvents currentpass As Label
    Friend WithEvents txtretypepass As TextBox
    Friend WithEvents txtnewpass As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents messagelbl As Label
    Friend WithEvents btnOk As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents forgotpass As Button
    Friend WithEvents backbtn As Button
End Class
