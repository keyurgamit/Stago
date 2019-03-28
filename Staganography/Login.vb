Public Class Login
    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        Try
            Dim isLoginOK As Boolean = False

            Dim connstring As String = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=D:\MyProjects\Staganography\StegoTool\finalcopy\Database\db.mdb"
            Dim conn As New OleDb.OleDbConnection(connstring)
            Dim sql As String = "select * from tbl_user where email='" + txtemail.Text + "' AND password = '" + txtpassword.Text + "'"
            Dim command As New OleDb.OleDbCommand(sql, conn)

            Try
                If Not conn.State = ConnectionState.Open Then
                    conn.Open()
                End If

                Dim dr As OleDb.OleDbDataReader = command.ExecuteReader()

                While dr.Read
                    isLoginOK = True
                End While

            Catch ex As Exception
                isLoginOK = False
            End Try

            If isLoginOK Then

                Dim objfrmEncrypt As New Selection
                objfrmEncrypt.WindowState = FormWindowState.Normal
                objfrmEncrypt.Show()
                Me.Hide()

            Else
                MessageBox.Show("Invalid Email or Password")
                txtemail.Text = ""
                txtpassword.Text = ""

            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnSignup_Click(sender As Object, e As EventArgs) Handles btnSignup.Click
        Signup.Show()
        Me.Hide()
    End Sub
End Class