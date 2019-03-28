<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Login
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
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.lblemail = New MetroFramework.Controls.MetroLabel()
        Me.lblpassword = New MetroFramework.Controls.MetroLabel()
        Me.txtemail = New MetroFramework.Controls.MetroTextBox()
        Me.txtpassword = New MetroFramework.Controls.MetroTextBox()
        Me.btnSignup = New MetroFramework.Controls.MetroButton()
        Me.btnLogin = New MetroFramework.Controls.MetroButton()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Staganography.My.Resources.Resource.loginicon
        Me.PictureBox1.Location = New System.Drawing.Point(244, 63)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(187, 102)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'lblemail
        '
        Me.lblemail.AutoSize = True
        Me.lblemail.Location = New System.Drawing.Point(129, 191)
        Me.lblemail.Name = "lblemail"
        Me.lblemail.Size = New System.Drawing.Size(99, 19)
        Me.lblemail.TabIndex = 1
        Me.lblemail.Text = "Email Address :"
        Me.lblemail.Theme = MetroFramework.MetroThemeStyle.Dark
        '
        'lblpassword
        '
        Me.lblpassword.AutoSize = True
        Me.lblpassword.Location = New System.Drawing.Point(129, 235)
        Me.lblpassword.Name = "lblpassword"
        Me.lblpassword.Size = New System.Drawing.Size(70, 19)
        Me.lblpassword.TabIndex = 2
        Me.lblpassword.Text = "Password :"
        Me.lblpassword.Theme = MetroFramework.MetroThemeStyle.Dark
        '
        'txtemail
        '
        '
        '
        '
        Me.txtemail.CustomButton.Image = Nothing
        Me.txtemail.CustomButton.Location = New System.Drawing.Point(165, 1)
        Me.txtemail.CustomButton.Name = ""
        Me.txtemail.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.txtemail.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtemail.CustomButton.TabIndex = 1
        Me.txtemail.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtemail.CustomButton.UseSelectable = True
        Me.txtemail.CustomButton.Visible = False
        Me.txtemail.Lines = New String(-1) {}
        Me.txtemail.Location = New System.Drawing.Point(244, 187)
        Me.txtemail.MaxLength = 32767
        Me.txtemail.Name = "txtemail"
        Me.txtemail.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtemail.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtemail.SelectedText = ""
        Me.txtemail.SelectionLength = 0
        Me.txtemail.SelectionStart = 0
        Me.txtemail.ShortcutsEnabled = True
        Me.txtemail.Size = New System.Drawing.Size(187, 23)
        Me.txtemail.TabIndex = 3
        Me.txtemail.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.txtemail.UseSelectable = True
        Me.txtemail.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtemail.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'txtpassword
        '
        '
        '
        '
        Me.txtpassword.CustomButton.Image = Nothing
        Me.txtpassword.CustomButton.Location = New System.Drawing.Point(165, 1)
        Me.txtpassword.CustomButton.Name = ""
        Me.txtpassword.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.txtpassword.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtpassword.CustomButton.TabIndex = 1
        Me.txtpassword.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtpassword.CustomButton.UseSelectable = True
        Me.txtpassword.CustomButton.Visible = False
        Me.txtpassword.Lines = New String(-1) {}
        Me.txtpassword.Location = New System.Drawing.Point(244, 226)
        Me.txtpassword.MaxLength = 32767
        Me.txtpassword.Name = "txtpassword"
        Me.txtpassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtpassword.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtpassword.SelectedText = ""
        Me.txtpassword.SelectionLength = 0
        Me.txtpassword.SelectionStart = 0
        Me.txtpassword.ShortcutsEnabled = True
        Me.txtpassword.Size = New System.Drawing.Size(187, 23)
        Me.txtpassword.TabIndex = 4
        Me.txtpassword.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.txtpassword.UseSelectable = True
        Me.txtpassword.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtpassword.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'btnSignup
        '
        Me.btnSignup.Location = New System.Drawing.Point(244, 280)
        Me.btnSignup.Name = "btnSignup"
        Me.btnSignup.Size = New System.Drawing.Size(75, 23)
        Me.btnSignup.TabIndex = 5
        Me.btnSignup.Text = "Signup"
        Me.btnSignup.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.btnSignup.UseSelectable = True
        '
        'btnLogin
        '
        Me.btnLogin.Location = New System.Drawing.Point(356, 280)
        Me.btnLogin.Name = "btnLogin"
        Me.btnLogin.Size = New System.Drawing.Size(75, 23)
        Me.btnLogin.TabIndex = 5
        Me.btnLogin.Text = "Login"
        Me.btnLogin.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.btnLogin.UseSelectable = True
        '
        'Login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(592, 387)
        Me.Controls.Add(Me.btnLogin)
        Me.Controls.Add(Me.btnSignup)
        Me.Controls.Add(Me.txtpassword)
        Me.Controls.Add(Me.txtemail)
        Me.Controls.Add(Me.lblpassword)
        Me.Controls.Add(Me.lblemail)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "Login"
        Me.Text = "Login"
        Me.Theme = MetroFramework.MetroThemeStyle.Dark
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents lblemail As MetroFramework.Controls.MetroLabel
    Friend WithEvents lblpassword As MetroFramework.Controls.MetroLabel
    Friend WithEvents txtemail As MetroFramework.Controls.MetroTextBox
    Friend WithEvents txtpassword As MetroFramework.Controls.MetroTextBox
    Friend WithEvents btnSignup As MetroFramework.Controls.MetroButton
    Friend WithEvents btnLogin As MetroFramework.Controls.MetroButton
End Class
