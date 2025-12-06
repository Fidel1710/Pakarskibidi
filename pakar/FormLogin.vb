Imports Microsoft.Data.SqlClient

Public Class FormLogin
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim username As String = TextBox1.Text.Trim()
        Dim password As String = TextBox2.Text.Trim()

        If username = "" Or password = "" Then
            MessageBox.Show("Isi username dan password!", "Peringatan")
            Return
        End If

        Using conn As SqlConnection = getConnection()
            If conn Is Nothing Then Return

            Try
                Dim query As String = "SELECT role FROM users WHERE username = @user AND password = @pass"
                Dim cmd As New SqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@user", username)
                cmd.Parameters.AddWithValue("@pass", password)

                Dim role As Object = cmd.ExecuteScalar()

                If role Is Nothing Then
                    MessageBox.Show("Username atau Password salah!", "Gagal")
                    Return
                End If

                Dim userRole As String = role.ToString()

                If userRole = "admin" Then
                    MessageBox.Show("Selamat Datang Admin")
                    Dim frm As New FormAdmin()
                    frm.Show()
                    Me.Hide()

                ElseIf userRole = "user" Then
                    MessageBox.Show("Selamat Datang User")
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

    ' Tombol REGISTER (Button2) - Untuk pindah ke Form3
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim frmReg As New FormRegister()
        frmReg.ShowDialog() ' Buka sebagai dialog agar user fokus register
    End Sub

    Private Sub FormLogin_Closed(sender As Object, e As EventArgs) Handles MyBase.Closed
        Application.Exit() ' Pastikan aplikasi keluar saat form login ditutup
    End Sub
End Class