Imports Microsoft.Data.SqlClient

Public Class Form2

    ' Tombol LOGIN (Button1)
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim username As String = TextBox1.Text.Trim()
        Dim password As String = TextBox2.Text.Trim()

        If username = "" Or password = "" Then
            MessageBox.Show("Isi username dan password!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Using conn As SqlConnection = getConnection()
            If conn Is Nothing Then Return

            Try
                ' Cek Username dan Password di Database
                Dim query As String = "SELECT COUNT(*) FROM tbl_user WHERE username = @user AND password = @pass"
                Dim cmd As New SqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@user", username)
                cmd.Parameters.AddWithValue("@pass", password)

                Dim count As Integer = Convert.ToInt32(cmd.ExecuteScalar())

                If count > 0 Then
                    MessageBox.Show("Login Berhasil!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information)

                    ' Buka Form Utama (Form1 - Sistem Pakar)
                    Dim frmUtama As New Form1()
                    frmUtama.Show()

                    ' Sembunyikan Form Login
                    Me.Hide()
                Else
                    MessageBox.Show("Username atau Password salah!", "Gagal", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If

            Catch ex As Exception
                MessageBox.Show("Error: " & ex.Message)
            End Try
        End Using
    End Sub

    ' Tombol REGISTER (Button2) - Untuk pindah ke Form3
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim frmReg As New Form3()
        frmReg.ShowDialog() ' Buka sebagai dialog agar user fokus register
    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class