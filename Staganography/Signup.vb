Public Class Signup
    Private Sub btnSignup_Click(sender As Object, e As EventArgs) Handles btnSignup.Click
        Try
            Dim connstring As String = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=D:\MyProjects\Staganography\StegoTool\finalcopy\Database\db.mdb"
            Dim conn As New OleDb.OleDbConnection(connstring)
            Dim sql As String = "insert into tbl_user values ('" + txtFirstname.Text + "','" + txtLastname.Text + "','" + txtEmail.Text + "','" + txtPassword.Text + "')"
            Dim command As New OleDb.OleDbCommand(sql, conn)

            Try
                If Not conn.State = ConnectionState.Open Then
                    conn.Open()
                End If

                command.ExecuteScalar()

                MessageBox.Show("Registration sucessful")
                If chkSignin.Checked Then
                    Dim objfrmEncrypt As New Selection
                    objfrmEncrypt.WindowState = FormWindowState.Normal
                    objfrmEncrypt.Show()
                    Me.Hide()
                Else
                    Login.Show()
                End If


            Catch ex As Exception
                MessageBox.Show("Error in registration")
            End Try

        Catch ex As Exception

        End Try
    End Sub
End Class