Imports Microsoft.Data.SqlClient
Imports System.Security.Cryptography
Imports System.Text

Public Class FormLogin
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim username As String = TextBox1.Text.Trim()
        Dim password As String = TextBox2.Text.Trim()

        If username = "" Or password = "" Then
            MessageBox.Show("Isi username dan password!", "Peringatan")
            Return
        End If

        Dim hashedPassword As String = HashPassword(password)

        Using conn As SqlConnection = getConnection()
            If conn Is Nothing Then Return

            Try
                Dim query As String = "SELECT role FROM users WHERE username = @user AND password = @pass"
                Dim cmd As New SqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@user", username)
                cmd.Parameters.AddWithValue("@pass", hashedPassword)

                Dim role As Object = cmd.ExecuteScalar()

                If role Is Nothing Then
                    MessageBox.Show("Username atau Password salah!", "Gagal")
                    Return
                End If

                Dim userRole As String = role.ToString()

                If userRole = "Admin" Then
                    MessageBox.Show("Selamat Datang " & username)
                    Dim frm As New FormAdmin()
                    frm.Show()
                    Me.Hide()

                ElseIf userRole = "User" Then
                    MessageBox.Show("Selamat Datang " & username)
                    Dim frm As New FormMain()
                    frm.Show()
                    Me.Hide()

                Else
                    MessageBox.Show("Role tidak dikenali!", "Error")
                End If

            Catch ex As Exception
                MessageBox.Show("Error: " & ex.Message)
            End Try
        End Using
    End Sub

    Private Function HashPassword(ByVal password As String) As String
        Using sha256 As SHA256 = SHA256.Create()
            Dim bytes As Byte() = sha256.ComputeHash(Encoding.UTF8.GetBytes(password))
            Dim builder As New StringBuilder()
            For i As Integer = 0 To bytes.Length - 1
                builder.Append(bytes(i).ToString("x2"))
            Next
            Return builder.ToString()
        End Using
    End Function

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim frmReg As New FormRegister()
        frmReg.ShowDialog()
    End Sub

    Private Sub FormLogin_Closed(sender As Object, e As EventArgs) Handles MyBase.Closed
        Application.Exit()
    End Sub
End Class