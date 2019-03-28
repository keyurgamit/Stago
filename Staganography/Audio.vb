Imports System.IO

Public Class Audio
    Dim audioBuffer As System.IO.FileInfo
    Private Sub btnBrowse_Click(sender As Object, e As EventArgs) Handles btnBrowse.Click
        open.Title = "Open Audio Files"
        open.InitialDirectory = "C:\"
        open.Multiselect = False

        open.Filter = "Audio files (*.mp3)|*.mp3"

        open.ShowDialog()
    End Sub

    Private Sub open_FileOk(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles open.FileOk

    End Sub

    Private Sub ResizeFileName(LongFileName As String, ShortFileName As String)
        If LongFileName.Length > 71 Then
            Dim LongFileNameSize As Integer = LongFileName.Length
            Dim ShortFileNameSize As Integer = ShortFileName.Length
            Dim Cut As Integer = 71 - (5 + ShortFileNameSize)
            Dim i As Integer
            txtPath.Clear()
            For i = 0 To (Cut) - 1
                txtPath.AppendText(LongFileName.Chars(i))
            Next
            For i = 0 To 4
                txtPath.AppendText(".")
            Next
            For i = 0 To (ShortFileNameSize - 1)
                txtPath.AppendText(ShortFileName(i))
            Next
        Else
            txtPath.Text = LongFileName
        End If

    End Sub
    Dim path As String = Nothing
    Private Sub btnLoadfile_Click(sender As Object, e As EventArgs) Handles btnLoadfile.Click
        Dim fo As New OpenFileDialog
        fo.Filter = "Text Files|*.txt"
        fo.FilterIndex = 1
        fo.ShowDialog()
        If (fo.FileName = Nothing) Then
            MsgBox("No file selected.")
        Else
            path = fo.FileName
            Using sr As New StreamReader(fo.FileName)
                txtPlainText.Text = sr.ReadToEnd()
            End Using
        End If
    End Sub

    Private Sub btnSaveas_Click(sender As Object, e As EventArgs) Handles btnSaveas.Click
        Dim fs As New SaveFileDialog
        fs.Filter = "Audio files (*.mp3)|*.mp3"
        fs.FilterIndex = 1
        fs.ShowDialog()
        If (Not fs.FileName = Nothing) Then
            Using sw As New StreamWriter(fs.FileName)
                sw.Write(txtRetrivedText.Text)
            End Using
        End If
    End Sub

    Private Sub btnOperation_Click(sender As Object, e As EventArgs) Handles btnOperation.Click
        Dim Ready As Boolean = True
        Dim audioFileStream As System.IO.FileStream
        Try
            audioFileStream = audioBuffer.OpenRead
        Catch ex As Exception
            Ready = False
            MsgBox("Please load a Audio before clicking this button", MsgBoxStyle.Critical, "Error")
        End Try
        If Ready = True Then
            Dim audioBytes As Long = audioFileStream.Length
            Dim audioExt As String = audioBuffer.Extension
            Dim audioByteArray(audioBytes) As Byte
            audioFileStream.Read(audioByteArray, 0, audioBytes)
            Dim SentinelString() As Byte = {73, 116, 83, 116, 97, 114, 116, 115, 72, 101, 114, 101}

            If rbtEncrypt.Checked = True Then
                Dim PlainText As String = txtPlainText.Text
                Dim PlainTextByteArray(PlainText.Length) As Byte
                For i As Integer = 0 To (PlainText.Length - 1)
                    PlainTextByteArray(i) = CByte(AscW(PlainText.Chars(i)))
                    Application.DoEvents()
                Next
                Dim audioAndText(audioBytes + PlainText.Length + SentinelString.Length) As Byte
                For t As Long = 0 To (audioBytes - 1)
                    audioAndText(t) = audioByteArray(t)
                Next
                Dim count As Integer = 0
                For r As Long = audioBytes To (audioBytes + (SentinelString.Length) - 1)
                    audioAndText(r) = SentinelString(count)
                    count += 1
                Next
                count = 0
                For q As Long = (audioBytes + SentinelString.Length) To (audioBytes + SentinelString.Length + PlainText.Length - 1)
                    audioAndText(q) = PlainTextByteArray(count)
                    count += 1
                Next
                build.Filter = "Audio files (*.mp3)|*.mp3"
                build.ShowDialog()
                Dim NewFileName As String = build.FileName
                My.Computer.FileSystem.WriteAllBytes(NewFileName, audioAndText, False)

                'Decrypt'

            ElseIf rbtDecrypt.Checked Then
                txtRetrivedText.Clear()
                Dim OutterSearch, InnerSearch, StopSearch As Boolean
                OutterSearch = True
                InnerSearch = True
                StopSearch = False
                Dim count As Long = 0
                Dim leftCounter As Long
                Dim rightCounter As Integer
                leftCounter = 0
                rightCounter = 0
                Do While (count < (audioBytes - SentinelString.Length) And StopSearch = False)
                    If (audioByteArray(count) = SentinelString(0)) Then
                        leftCounter = count + 1
                        rightCounter = 1
                        InnerSearch = True
                        Do While (InnerSearch = True) And (rightCounter < SentinelString.Length) _
                        And (leftCounter < audioByteArray.Length)
                            If (audioByteArray(leftCounter) = SentinelString(rightCounter)) Then
                                rightCounter += 1
                                leftCounter += 1
                                If (rightCounter = (SentinelString.Length - 1)) Then
                                    StopSearch = True
                                End If
                            Else
                                InnerSearch = False
                                count += 1
                            End If
                        Loop
                    Else
                        count += 1
                    End If
                Loop
                If StopSearch = True Then
                    'leftCounter contains the starting string that is being retrieved
                    Do While (leftCounter < audioBytes)
                        'Bytes need to be converted to an integer 
                        'then to an unicode character which will be the plaintext
                        txtRetrivedText.AppendText(ChrW(CInt(audioByteArray(leftCounter))))
                        leftCounter += 1
                    Loop
                Else
                    txtRetrivedText.Text = "The Audio does not contain any text"
                End If

            End If

        End If

    End Sub

End Class