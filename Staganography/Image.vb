Imports System.IO
Public Class Image


    Dim PicBuffer As System.IO.FileInfo
    Private Sub btnBrowse_Click(sender As Object, e As EventArgs) Handles btnBrowse.Click
        open.Title = "Open Picture Files"
        open.InitialDirectory = "C:\"

        open.Multiselect = False
        open.Filter = "Image files (*.jpg, *.jpeg, *.png)|*.jpg; *.jpeg; *.png"
        open.ShowDialog()
    End Sub

    Private Sub open_FileOk(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles open.FileOk
        pboxImage.Image = Drawing.Image.FromFile(open.FileName)
        PicBuffer = New System.IO.FileInfo(open.FileName)
        ResizeFileName(open.FileName, PicBuffer.Name)
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
        fs.Filter = "Image files (*.jpg,*.jpeg, *.png)|*.jpg; *.jpeg; *.png"
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
        Dim PicFileStream As System.IO.FileStream
        Try
            PicFileStream = PicBuffer.OpenRead
        Catch ex As Exception
            Ready = False
            MsgBox("Please load a picture before clicking this button", MsgBoxStyle.Critical, "Error")
        End Try
        If Ready = True Then
            Dim PicBytes As Long = PicFileStream.Length
            Dim PicExt As String = PicBuffer.Extension
            Dim PicByteArray(PicBytes) As Byte
            PicFileStream.Read(PicByteArray, 0, PicBytes)
            Dim SentinelString() As Byte = {73, 116, 83, 116, 97, 114, 116, 115, 72, 101, 114, 101}
            If rbtEncrypt.Checked = True Then
                Dim PlainText As String = txtPlainText.Text
                Dim PlainTextByteArray(PlainText.Length) As Byte
                For i As Integer = 0 To (PlainText.Length - 1)
                    PlainTextByteArray(i) = CByte(AscW(PlainText.Chars(i)))
                    Application.DoEvents()
                Next
                Dim PicAndText(PicBytes + PlainText.Length + SentinelString.Length) As Byte
                For t As Long = 0 To (PicBytes - 1)
                    PicAndText(t) = PicByteArray(t)
                Next
                Dim count As Integer = 0
                For r As Long = PicBytes To (PicBytes + (SentinelString.Length) - 1)
                    PicAndText(r) = SentinelString(count)
                    count += 1
                Next
                count = 0
                For q As Long = (PicBytes + SentinelString.Length) To (PicBytes + SentinelString.Length + PlainText.Length - 1)
                    PicAndText(q) = PlainTextByteArray(count)
                    count += 1
                Next
                build.Filter = "Image files (*.jpg, *.jpeg, *.png)|*.jpg; *.jpeg; *.png"
                build.ShowDialog()
                Dim NewFileName As String = build.FileName
                My.Computer.FileSystem.WriteAllBytes(NewFileName, PicAndText, False)

                MsgBox("Encryption Process done Successfully", MsgBoxStyle.MsgBoxRight, "Error")

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
                Do While (count < (PicBytes - SentinelString.Length) And StopSearch = False)
                    If (PicByteArray(count) = SentinelString(0)) Then
                        leftCounter = count + 1
                        rightCounter = 1
                        InnerSearch = True
                        Do While (InnerSearch = True) And (rightCounter < SentinelString.Length) _
                        And (leftCounter < PicByteArray.Length)
                            If (PicByteArray(leftCounter) = SentinelString(rightCounter)) Then
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
                    Do While (leftCounter < PicBytes)
                        'Bytes need to be converted to an integer 
                        'then to an unicode character which will be the plaintext
                        txtRetrivedText.AppendText(ChrW(CInt(PicByteArray(leftCounter))))
                        leftCounter += 1
                    Loop
                    MsgBox("Decryption Process done Successfully", MsgBoxStyle.MsgBoxRight, "Error")
                Else
                    txtRetrivedText.Text = "The Picture does not contain any text"
                End If

            Else
                MsgBox("Please Select Method to Encrypt or Decrypt.!", MsgBoxStyle.Critical, "Error")
            End If
        End If


    End Sub
End Class