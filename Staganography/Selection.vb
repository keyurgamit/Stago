Public Class Selection
    Private Sub btnImage_Click(sender As Object, e As EventArgs) Handles btnImage.Click
        Image.Show()
        Me.Hide()
    End Sub

    Private Sub btnAudio_Click(sender As Object, e As EventArgs) Handles btnAudio.Click
        Audio.Show()
        Me.Hide()
    End Sub

    Private Sub btnVideo_Click(sender As Object, e As EventArgs) Handles btnVideo.Click
        Video.Show()
        Me.Hide()
    End Sub

    Private Sub btnText_Click(sender As Object, e As EventArgs) Handles btnText.Click
        TextWindow.Show()
        Me.Hide()
    End Sub

    Private Sub btnSignout_Click(sender As Object, e As EventArgs) Handles btnSignout.Click
        Welcome.Show()
        Me.Hide()
    End Sub
End Class