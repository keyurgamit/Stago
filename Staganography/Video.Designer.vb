<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Video
    Inherits MetroFramework.Forms.MetroForm

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
        Me.pboxImage = New System.Windows.Forms.PictureBox()
        Me.txtPath = New MetroFramework.Controls.MetroTextBox()
        Me.btnBrowse = New MetroFramework.Controls.MetroButton()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.rbtDecrypt = New MetroFramework.Controls.MetroRadioButton()
        Me.rbtEncrypt = New MetroFramework.Controls.MetroRadioButton()
        Me.MetroLabel1 = New MetroFramework.Controls.MetroLabel()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.btnOperation = New MetroFramework.Controls.MetroButton()
        Me.btnSaveas = New MetroFramework.Controls.MetroButton()
        Me.btnLoadfile = New MetroFramework.Controls.MetroButton()
        Me.MetroLabel2 = New MetroFramework.Controls.MetroLabel()
        Me.txtRetrivedText = New MetroFramework.Controls.MetroTextBox()
        Me.txtPlainText = New MetroFramework.Controls.MetroTextBox()
        Me.build = New System.Windows.Forms.SaveFileDialog()
        Me.open = New System.Windows.Forms.OpenFileDialog()
        CType(Me.pboxImage, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'pboxImage
        '
        Me.pboxImage.Image = Global.Staganography.My.Resources.Resource.VIDEO
        Me.pboxImage.Location = New System.Drawing.Point(37, 143)
        Me.pboxImage.Name = "pboxImage"
        Me.pboxImage.Size = New System.Drawing.Size(324, 387)
        Me.pboxImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pboxImage.TabIndex = 0
        Me.pboxImage.TabStop = False
        '
        'txtPath
        '
        '
        '
        '
        Me.txtPath.CustomButton.Image = Nothing
        Me.txtPath.CustomButton.Location = New System.Drawing.Point(708, 1)
        Me.txtPath.CustomButton.Name = ""
        Me.txtPath.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.txtPath.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtPath.CustomButton.TabIndex = 1
        Me.txtPath.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtPath.CustomButton.UseSelectable = True
        Me.txtPath.CustomButton.Visible = False
        Me.txtPath.Lines = New String(-1) {}
        Me.txtPath.Location = New System.Drawing.Point(37, 35)
        Me.txtPath.MaxLength = 32767
        Me.txtPath.Name = "txtPath"
        Me.txtPath.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtPath.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtPath.SelectedText = ""
        Me.txtPath.SelectionLength = 0
        Me.txtPath.SelectionStart = 0
        Me.txtPath.ShortcutsEnabled = True
        Me.txtPath.Size = New System.Drawing.Size(730, 23)
        Me.txtPath.TabIndex = 1
        Me.txtPath.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.txtPath.UseSelectable = True
        Me.txtPath.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtPath.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'btnBrowse
        '
        Me.btnBrowse.Location = New System.Drawing.Point(787, 34)
        Me.btnBrowse.Name = "btnBrowse"
        Me.btnBrowse.Size = New System.Drawing.Size(88, 23)
        Me.btnBrowse.TabIndex = 2
        Me.btnBrowse.Text = "Browse"
        Me.btnBrowse.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.btnBrowse.UseSelectable = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.rbtDecrypt)
        Me.GroupBox1.Controls.Add(Me.rbtEncrypt)
        Me.GroupBox1.Location = New System.Drawing.Point(767, 69)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(125, 64)
        Me.GroupBox1.TabIndex = 3
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "GroupBox1"
        '
        'rbtDecrypt
        '
        Me.rbtDecrypt.AutoSize = True
        Me.rbtDecrypt.Location = New System.Drawing.Point(19, 37)
        Me.rbtDecrypt.Name = "rbtDecrypt"
        Me.rbtDecrypt.Size = New System.Drawing.Size(88, 15)
        Me.rbtDecrypt.TabIndex = 0
        Me.rbtDecrypt.Text = "Decrypt Text"
        Me.rbtDecrypt.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.rbtDecrypt.UseSelectable = True
        '
        'rbtEncrypt
        '
        Me.rbtEncrypt.AutoSize = True
        Me.rbtEncrypt.Location = New System.Drawing.Point(19, 16)
        Me.rbtEncrypt.Name = "rbtEncrypt"
        Me.rbtEncrypt.Size = New System.Drawing.Size(87, 15)
        Me.rbtEncrypt.TabIndex = 0
        Me.rbtEncrypt.Text = "Encrypt Text"
        Me.rbtEncrypt.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.rbtEncrypt.UseSelectable = True
        '
        'MetroLabel1
        '
        Me.MetroLabel1.AutoSize = True
        Me.MetroLabel1.Location = New System.Drawing.Point(62, 27)
        Me.MetroLabel1.Name = "MetroLabel1"
        Me.MetroLabel1.Size = New System.Drawing.Size(129, 19)
        Me.MetroLabel1.TabIndex = 4
        Me.MetroLabel1.Text = "Enter Plain Text Here"
        Me.MetroLabel1.Theme = MetroFramework.MetroThemeStyle.Dark
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.btnOperation)
        Me.GroupBox2.Controls.Add(Me.btnSaveas)
        Me.GroupBox2.Controls.Add(Me.btnLoadfile)
        Me.GroupBox2.Controls.Add(Me.MetroLabel2)
        Me.GroupBox2.Controls.Add(Me.MetroLabel1)
        Me.GroupBox2.Controls.Add(Me.txtRetrivedText)
        Me.GroupBox2.Controls.Add(Me.txtPlainText)
        Me.GroupBox2.Location = New System.Drawing.Point(390, 143)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(504, 387)
        Me.GroupBox2.TabIndex = 5
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "GroupBox2"
        '
        'btnOperation
        '
        Me.btnOperation.Location = New System.Drawing.Point(197, 341)
        Me.btnOperation.Name = "btnOperation"
        Me.btnOperation.Size = New System.Drawing.Size(113, 23)
        Me.btnOperation.TabIndex = 6
        Me.btnOperation.Text = "Perform Operation"
        Me.btnOperation.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.btnOperation.UseSelectable = True
        '
        'btnSaveas
        '
        Me.btnSaveas.Location = New System.Drawing.Point(336, 52)
        Me.btnSaveas.Name = "btnSaveas"
        Me.btnSaveas.Size = New System.Drawing.Size(75, 23)
        Me.btnSaveas.TabIndex = 5
        Me.btnSaveas.Text = "Save as File"
        Me.btnSaveas.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.btnSaveas.UseSelectable = True
        '
        'btnLoadfile
        '
        Me.btnLoadfile.Location = New System.Drawing.Point(87, 52)
        Me.btnLoadfile.Name = "btnLoadfile"
        Me.btnLoadfile.Size = New System.Drawing.Size(75, 23)
        Me.btnLoadfile.TabIndex = 5
        Me.btnLoadfile.Text = "Load File"
        Me.btnLoadfile.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.btnLoadfile.UseSelectable = True
        '
        'MetroLabel2
        '
        Me.MetroLabel2.AutoSize = True
        Me.MetroLabel2.Location = New System.Drawing.Point(293, 27)
        Me.MetroLabel2.Name = "MetroLabel2"
        Me.MetroLabel2.Size = New System.Drawing.Size(154, 19)
        Me.MetroLabel2.TabIndex = 4
        Me.MetroLabel2.Text = "Retrived Text from Video"
        Me.MetroLabel2.Theme = MetroFramework.MetroThemeStyle.Dark
        '
        'txtRetrivedText
        '
        '
        '
        '
        Me.txtRetrivedText.CustomButton.Image = Nothing
        Me.txtRetrivedText.CustomButton.Location = New System.Drawing.Point(-24, 2)
        Me.txtRetrivedText.CustomButton.Name = ""
        Me.txtRetrivedText.CustomButton.Size = New System.Drawing.Size(235, 235)
        Me.txtRetrivedText.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtRetrivedText.CustomButton.TabIndex = 1
        Me.txtRetrivedText.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtRetrivedText.CustomButton.UseSelectable = True
        Me.txtRetrivedText.CustomButton.Visible = False
        Me.txtRetrivedText.Lines = New String(-1) {}
        Me.txtRetrivedText.Location = New System.Drawing.Point(271, 81)
        Me.txtRetrivedText.MaxLength = 32767
        Me.txtRetrivedText.Name = "txtRetrivedText"
        Me.txtRetrivedText.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtRetrivedText.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtRetrivedText.SelectedText = ""
        Me.txtRetrivedText.SelectionLength = 0
        Me.txtRetrivedText.SelectionStart = 0
        Me.txtRetrivedText.ShortcutsEnabled = True
        Me.txtRetrivedText.Size = New System.Drawing.Size(214, 240)
        Me.txtRetrivedText.TabIndex = 0
        Me.txtRetrivedText.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.txtRetrivedText.UseSelectable = True
        Me.txtRetrivedText.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtRetrivedText.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'txtPlainText
        '
        '
        '
        '
        Me.txtPlainText.CustomButton.Image = Nothing
        Me.txtPlainText.CustomButton.Location = New System.Drawing.Point(-24, 2)
        Me.txtPlainText.CustomButton.Name = ""
        Me.txtPlainText.CustomButton.Size = New System.Drawing.Size(235, 235)
        Me.txtPlainText.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtPlainText.CustomButton.TabIndex = 1
        Me.txtPlainText.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtPlainText.CustomButton.UseSelectable = True
        Me.txtPlainText.CustomButton.Visible = False
        Me.txtPlainText.Lines = New String(-1) {}
        Me.txtPlainText.Location = New System.Drawing.Point(20, 81)
        Me.txtPlainText.MaxLength = 32767
        Me.txtPlainText.Name = "txtPlainText"
        Me.txtPlainText.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtPlainText.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtPlainText.SelectedText = ""
        Me.txtPlainText.SelectionLength = 0
        Me.txtPlainText.SelectionStart = 0
        Me.txtPlainText.ShortcutsEnabled = True
        Me.txtPlainText.Size = New System.Drawing.Size(214, 240)
        Me.txtPlainText.TabIndex = 0
        Me.txtPlainText.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.txtPlainText.UseSelectable = True
        Me.txtPlainText.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtPlainText.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'Video
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(917, 572)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btnBrowse)
        Me.Controls.Add(Me.txtPath)
        Me.Controls.Add(Me.pboxImage)
        Me.Name = "Video"
        Me.Theme = MetroFramework.MetroThemeStyle.Dark
        CType(Me.pboxImage, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents pboxImage As PictureBox
    Friend WithEvents txtPath As MetroFramework.Controls.MetroTextBox
    Friend WithEvents btnBrowse As MetroFramework.Controls.MetroButton
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents rbtDecrypt As MetroFramework.Controls.MetroRadioButton
    Friend WithEvents rbtEncrypt As MetroFramework.Controls.MetroRadioButton
    Friend WithEvents MetroLabel1 As MetroFramework.Controls.MetroLabel
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents txtRetrivedText As MetroFramework.Controls.MetroTextBox
    Friend WithEvents txtPlainText As MetroFramework.Controls.MetroTextBox
    Friend WithEvents btnSaveas As MetroFramework.Controls.MetroButton
    Friend WithEvents btnLoadfile As MetroFramework.Controls.MetroButton
    Friend WithEvents MetroLabel2 As MetroFramework.Controls.MetroLabel
    Friend WithEvents btnOperation As MetroFramework.Controls.MetroButton
    Friend WithEvents build As SaveFileDialog
    Friend WithEvents open As OpenFileDialog
End Class
