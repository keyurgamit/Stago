Imports System.IO

Public Class TextWindow
    Dim txtBuffer As System.IO.FileInfo
    Private Sub btnBrowse_Click(sender As Object, e As EventArgs) Handles btnBrowse.Click
        open.Title = "Open text Files"
        open.InitialDirectory = "C:\"
        open.Multiselect = False

        open.Filter = "text files (*.txt)|*.txt"

        open.ShowDialog()
    End Sub

    Private Sub open_FileOk(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles open.FileOk
        pboxImage.Image = Drawing.Image.FromFile(open.FileName)
        txtBuffer = New System.IO.FileInfo(open.FileName)
        ResizeFileName(open.FileName, txtBuffer.Name)
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

    Private Sub btnOperation_Click(sender As Object, e As EventArgs) Handles btnOperation.Click
        Dim Ready As Boolean = True
        Dim txtFileStream As System.IO.FileStream
        Try
            txtFileStream = txtBuffer.OpenRead
        Catch ex As Exception
            Ready = False
            MsgBox("Please load a Text file before clicking this button", MsgBoxStyle.Critical, "Error")
        End Try
        If Ready = True Then
            Dim txtBytes As Long = txtFileStream.Length
            Dim txtExt As String = txtBuffer.Extension
            Dim txtByteArray(txtBytes) As Byte
            txtFileStream.Read(txtByteArray, 0, txtBytes)
            Dim SentinelString() As Byte = {73, 116, 83, 116, 97, 114, 116, 115, 72, 101, 114, 101}
            If rbtEncrypt.Checked = True Then
                Dim PlainText As String = txtPlainText.Text
                Dim PlainTextByteArray(PlainText.Length) As Byte
                For i As Integer = 0 To (PlainText.Length - 1)
                    PlainTextByteArray(i) = CByte(AscW(PlainText.Chars(i)))
                    Application.DoEvents()
                Next
                Dim txtAndText(txtBytes + PlainText.Length + SentinelString.Length) As Byte
                For t As Long = 0 To (txtBytes - 1)
                    txtAndText(t) = txtByteArray(t)
                Next
                Dim count As Integer = 0
                For r As Long = txtBytes To (txtBytes + (SentinelString.Length) - 1)
                    txtAndText(r) = SentinelString(count)
                    count += 1
                Next
                count = 0
                For q As Long = (txtBytes + SentinelString.Length) To (txtBytes + SentinelString.Length + PlainText.Length - 1)
                    txtAndText(q) = PlainTextByteArray(count)
                    count += 1
                Next
                build.Filter = "text files (*.txt)|*.txt"
                build.ShowDialog()
                Dim NewFileName As String = build.FileName
                My.Computer.FileSystem.WriteAllBytes(NewFileName, txtAndText, False)

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
                Do While (count < (txtBytes - SentinelString.Length) And StopSearch = False)
                    If (txtByteArray(count) = SentinelString(0)) Then
                        leftCounter = count + 1
                        rightCounter = 1
                        InnerSearch = True
                        Do While (InnerSearch = True) And (rightCounter < SentinelString.Length) _
                        And (leftCounter < txtByteArray.Length)
                            If (txtByteArray(leftCounter) = SentinelString(rightCounter)) Then
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
                    Do While (leftCounter < txtBytes)
                        'Bytes need to be converted to an integer 
                        'then to an unicode character which will be the plaintext
                        txtRetrivedText.AppendText(ChrW(CInt(txtByteArray(leftCounter))))
                        leftCounter += 1
                    Loop
                Else
                    txtRetrivedText.Text = "The Text File does not contain any text"
                End If

            Else
                MsgBox("Please Select Method to Encrypt or Decrypt.!", MsgBoxStyle.Critical, "Error")
            End If
        End If
    End Sub
End Class