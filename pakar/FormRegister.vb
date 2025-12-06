Imports Microsoft.Data.SqlClient

Public Class FormRegister

    ' Tombol REGISTER (Pastikan nama tombolnya Button1 sesuai Designer Anda)
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim username As String = TextBox1.Text.Trim()
        Dim password As String = TextBox2.Text.Trim()

        If username = "" Or password = "" Then
            MessageBox.Show("Username dan Password tidak boleh kosong!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Using conn As SqlConnection = getConnection()
            If conn Is Nothing Then Return

            Try
                ' Cek Username
                Dim queryCek As String = "SELECT COUNT(*) FROM tbl_user WHERE username = @user"
                Dim cmdCek As New SqlCommand(queryCek, conn)
                cmdCek.Parameters.AddWithValue("@user", username)

                Dim count As Integer = Convert.ToInt32(cmdCek.ExecuteScalar())

                If count > 0 Then
                    MessageBox.Show("Username sudah terdaftar!", "Gagal", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Else
                    ' Simpan Data
                    Dim querySimpan As String = "INSERT INTO tbl_user (username, password) VALUES (@user, @pass)"
                    Dim cmdSimpan As New SqlCommand(querySimpan, conn)
                    cmdSimpan.Parameters.AddWithValue("@user", username)
                    cmdSimpan.Parameters.AddWithValue("@pass", password)

                    cmdSimpan.ExecuteNonQuery()

                    MessageBox.Show("Registrasi Berhasil! Silakan Login.", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Me.Close()
                End If

            Catch ex As Exception
                MessageBox.Show("Error: " & ex.Message)
            End Try
        End Using
    End Sub

End Class