<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Selection
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
        Me.btnImage = New MetroFramework.Controls.MetroButton()
        Me.btnAudio = New MetroFramework.Controls.MetroButton()
        Me.btnVideo = New MetroFramework.Controls.MetroButton()
        Me.btnText = New MetroFramework.Controls.MetroButton()
        Me.btnSignout = New MetroFramework.Controls.MetroButton()
        Me.SuspendLayout()
        '
        'btnImage
        '
        Me.btnImage.Location = New System.Drawing.Point(133, 152)
        Me.btnImage.Name = "btnImage"
        Me.btnImage.Size = New System.Drawing.Size(75, 23)
        Me.btnImage.TabIndex = 0
        Me.btnImage.Text = "Image"
        Me.btnImage.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.btnImage.UseSelectable = True
        '
        'btnAudio
        '
        Me.btnAudio.Location = New System.Drawing.Point(133, 201)
        Me.btnAudio.Name = "btnAudio"
        Me.btnAudio.Size = New System.Drawing.Size(75, 23)
        Me.btnAudio.TabIndex = 0
        Me.btnAudio.Text = "Audio"
        Me.btnAudio.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.btnAudio.UseSelectable = True
        '
        'btnVideo
        '
        Me.btnVideo.Location = New System.Drawing.Point(133, 249)
        Me.btnVideo.Name = "btnVideo"
        Me.btnVideo.Size = New System.Drawing.Size(75, 23)
        Me.btnVideo.TabIndex = 0
        Me.btnVideo.Text = "Video"
        Me.btnVideo.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.btnVideo.UseSelectable = True
        '
        'btnText
        '
        Me.btnText.Location = New System.Drawing.Point(133, 298)
        Me.btnText.Name = "btnText"
        Me.btnText.Size = New System.Drawing.Size(75, 23)
        Me.btnText.TabIndex = 0
        Me.btnText.Text = "Text"
        Me.btnText.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.btnText.UseSelectable = True
        '
        'btnSignout
        '
        Me.btnSignout.Location = New System.Drawing.Point(133, 399)
        Me.btnSignout.Name = "btnSignout"
        Me.btnSignout.Size = New System.Drawing.Size(75, 23)
        Me.btnSignout.TabIndex = 1
        Me.btnSignout.Text = "Sign Out"
        Me.btnSignout.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.btnSignout.UseSelectable = True
        '
        'Selection
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(348, 501)
        Me.Controls.Add(Me.btnSignout)
        Me.Controls.Add(Me.btnText)
        Me.Controls.Add(Me.btnVideo)
        Me.Controls.Add(Me.btnAudio)
        Me.Controls.Add(Me.btnImage)
        Me.Name = "Selection"
        Me.Text = "Select Media Type to Process"
        Me.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnImage As MetroFramework.Controls.MetroButton
    Friend WithEvents btnAudio As MetroFramework.Controls.MetroButton
    Friend WithEvents btnVideo As MetroFramework.Controls.MetroButton
    Friend WithEvents btnText As MetroFramework.Controls.MetroButton
    Friend WithEvents btnSignout As MetroFramework.Controls.MetroButton
End Class
