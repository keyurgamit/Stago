<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Signup
    Inherits MetroFramework.Forms.MetroForm

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.lblFirstname = New MetroFramework.Controls.MetroLabel()
        Me.lblLastname = New MetroFramework.Controls.MetroLabel()
        Me.LblEmail = New MetroFramework.Controls.MetroLabel()
        Me.lblPassword = New MetroFramework.Controls.MetroLabel()
        Me.txtFirstname = New MetroFramework.Controls.MetroTextBox()
        Me.txtLastname = New MetroFramework.Controls.MetroTextBox()
        Me.txtEmail = New MetroFramework.Controls.MetroTextBox()
        Me.txtPassword = New MetroFramework.Controls.MetroTextBox()
        Me.btnSignup = New MetroFramework.Controls.MetroButton()
        Me.chkSignin = New MetroFramework.Controls.MetroCheckBox()
        Me.SuspendLayout()
        '
        'lblFirstname
        '
        Me.lblFirstname.AutoSize = True
        Me.lblFirstname.Location = New System.Drawing.Point(153, 99)
        Me.lblFirstname.Name = "lblFirstname"
        Me.lblFirstname.Size = New System.Drawing.Size(73, 19)
        Me.lblFirstname.TabIndex = 0
        Me.lblFirstname.Text = "Firstname :"
        Me.lblFirstname.Theme = MetroFramework.MetroThemeStyle.Dark
        '
        'lblLastname
        '
        Me.lblLastname.AutoSize = True
        Me.lblLastname.Location = New System.Drawing.Point(153, 147)
        Me.lblLastname.Name = "lblLastname"
        Me.lblLastname.Size = New System.Drawing.Size(71, 19)
        Me.lblLastname.TabIndex = 0
        Me.lblLastname.Text = "Lastname :"
        Me.lblLastname.Theme = MetroFramework.MetroThemeStyle.Dark
        '
        'LblEmail
        '
        Me.LblEmail.AutoSize = True
        Me.LblEmail.Location = New System.Drawing.Point(153, 195)
        Me.LblEmail.Name = "LblEmail"
        Me.LblEmail.Size = New System.Drawing.Size(48, 19)
        Me.LblEmail.TabIndex = 0
        Me.LblEmail.Text = "Email :"
        Me.LblEmail.Theme = MetroFramework.MetroThemeStyle.Dark
        '
        'lblPassword
        '
        Me.lblPassword.AutoSize = True
        Me.lblPassword.Location = New System.Drawing.Point(153, 243)
        Me.lblPassword.Name = "lblPassword"
        Me.lblPassword.Size = New System.Drawing.Size(70, 19)
        Me.lblPassword.TabIndex = 0
        Me.lblPassword.Text = "Password :"
        Me.lblPassword.Theme = MetroFramework.MetroThemeStyle.Dark
        '
        'txtFirstname
        '
        '
        '
        '
        Me.txtFirstname.CustomButton.Image = Nothing
        Me.txtFirstname.CustomButton.Location = New System.Drawing.Point(173, 1)
        Me.txtFirstname.CustomButton.Name = ""
        Me.txtFirstname.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.txtFirstname.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtFirstname.CustomButton.TabIndex = 1
        Me.txtFirstname.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtFirstname.CustomButton.UseSelectable = True
        Me.txtFirstname.CustomButton.Visible = False
        Me.txtFirstname.Lines = New String(-1) {}
        Me.txtFirstname.Location = New System.Drawing.Point(254, 99)
        Me.txtFirstname.MaxLength = 32767
        Me.txtFirstname.Name = "txtFirstname"
        Me.txtFirstname.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtFirstname.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtFirstname.SelectedText = ""
        Me.txtFirstname.SelectionLength = 0
        Me.txtFirstname.SelectionStart = 0
        Me.txtFirstname.ShortcutsEnabled = True
        Me.txtFirstname.Size = New System.Drawing.Size(195, 23)
        Me.txtFirstname.TabIndex = 0
        Me.txtFirstname.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.txtFirstname.UseSelectable = True
        Me.txtFirstname.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtFirstname.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'txtLastname
        '
        '
        '
        '
        Me.txtLastname.CustomButton.Image = Nothing
        Me.txtLastname.CustomButton.Location = New System.Drawing.Point(173, 1)
        Me.txtLastname.CustomButton.Name = ""
        Me.txtLastname.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.txtLastname.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtLastname.CustomButton.TabIndex = 1
        Me.txtLastname.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtLastname.CustomButton.UseSelectable = True
        Me.txtLastname.CustomButton.Visible = False
        Me.txtLastname.Lines = New String(-1) {}
        Me.txtLastname.Location = New System.Drawing.Point(254, 147)
        Me.txtLastname.MaxLength = 32767
        Me.txtLastname.Name = "txtLastname"
        Me.txtLastname.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtLastname.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtLastname.SelectedText = ""
        Me.txtLastname.SelectionLength = 0
        Me.txtLastname.SelectionStart = 0
        Me.txtLastname.ShortcutsEnabled = True
        Me.txtLastname.Size = New System.Drawing.Size(195, 23)
        Me.txtLastname.TabIndex = 1
        Me.txtLastname.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.txtLastname.UseSelectable = True
        Me.txtLastname.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtLastname.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'txtEmail
        '
        '
        '
        '
        Me.txtEmail.CustomButton.Image = Nothing
        Me.txtEmail.CustomButton.Location = New System.Drawing.Point(173, 1)
        Me.txtEmail.CustomButton.Name = ""
        Me.txtEmail.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.txtEmail.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtEmail.CustomButton.TabIndex = 1
        Me.txtEmail.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtEmail.CustomButton.UseSelectable = True
        Me.txtEmail.CustomButton.Visible = False
        Me.txtEmail.Lines = New String(-1) {}
        Me.txtEmail.Location = New System.Drawing.Point(254, 191)
        Me.txtEmail.MaxLength = 32767
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtEmail.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtEmail.SelectedText = ""
        Me.txtEmail.SelectionLength = 0
        Me.txtEmail.SelectionStart = 0
        Me.txtEmail.ShortcutsEnabled = True
        Me.txtEmail.Size = New System.Drawing.Size(195, 23)
        Me.txtEmail.TabIndex = 2
        Me.txtEmail.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.txtEmail.UseSelectable = True
        Me.txtEmail.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtEmail.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'txtPassword
        '
        '
        '
        '
        Me.txtPassword.CustomButton.Image = Nothing
        Me.txtPassword.CustomButton.Location = New System.Drawing.Point(173, 1)
        Me.txtPassword.CustomButton.Name = ""
        Me.txtPassword.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.txtPassword.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtPassword.CustomButton.TabIndex = 1
        Me.txtPassword.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtPassword.CustomButton.UseSelectable = True
        Me.txtPassword.CustomButton.Visible = False
        Me.txtPassword.Lines = New String(-1) {}
        Me.txtPassword.Location = New System.Drawing.Point(254, 243)
        Me.txtPassword.MaxLength = 32767
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtPassword.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtPassword.SelectedText = ""
        Me.txtPassword.SelectionLength = 0
        Me.txtPassword.SelectionStart = 0
        Me.txtPassword.ShortcutsEnabled = True
        Me.txtPassword.Size = New System.Drawing.Size(195, 23)
        Me.txtPassword.TabIndex = 3
        Me.txtPassword.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.txtPassword.UseSelectable = True
        Me.txtPassword.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtPassword.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'btnSignup
        '
        Me.btnSignup.Location = New System.Drawing.Point(374, 290)
        Me.btnSignup.Name = "btnSignup"
        Me.btnSignup.Size = New System.Drawing.Size(75, 23)
        Me.btnSignup.TabIndex = 5
        Me.btnSignup.Text = "Signup"
        Me.btnSignup.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.btnSignup.UseSelectable = True
        '
        'chkSignin
        '
        Me.chkSignin.AllowDrop = True
        Me.chkSignin.AutoSize = True
        Me.chkSignin.Location = New System.Drawing.Point(280, 290)
        Me.chkSignin.Name = "chkSignin"
        Me.chkSignin.Size = New System.Drawing.Size(59, 15)
        Me.chkSignin.TabIndex = 4
        Me.chkSignin.Text = "Sign in"
        Me.chkSignin.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.chkSignin.UseSelectable = True
        '
        'Signup
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(639, 410)
        Me.Controls.Add(Me.chkSignin)
        Me.Controls.Add(Me.btnSignup)
        Me.Controls.Add(Me.txtPassword)
        Me.Controls.Add(Me.txtEmail)
        Me.Controls.Add(Me.txtLastname)
        Me.Controls.Add(Me.txtFirstname)
        Me.Controls.Add(Me.lblPassword)
        Me.Controls.Add(Me.LblEmail)
        Me.Controls.Add(Me.lblLastname)
        Me.Controls.Add(Me.lblFirstname)
        Me.Name = "Signup"
        Me.Text = "Signup"
        Me.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblFirstname As MetroFramework.Controls.MetroLabel
    Friend WithEvents lblLastname As MetroFramework.Controls.MetroLabel
    Friend WithEvents LblEmail As MetroFramework.Controls.MetroLabel
    Friend WithEvents lblPassword As MetroFramework.Controls.MetroLabel
    Friend WithEvents txtFirstname As MetroFramework.Controls.MetroTextBox
    Friend WithEvents txtLastname As MetroFramework.Controls.MetroTextBox
    Friend WithEvents txtEmail As MetroFramework.Controls.MetroTextBox
    Friend WithEvents txtPassword As MetroFramework.Controls.MetroTextBox
    Friend WithEvents btnSignup As MetroFramework.Controls.MetroButton
    Friend WithEvents chkSignin As MetroFramework.Controls.MetroCheckBox
End Class
