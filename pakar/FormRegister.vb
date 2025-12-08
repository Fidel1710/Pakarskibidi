Imports System.Security.Policy
Imports Microsoft.Data.SqlClient
Imports System.Security.Cryptography
Imports System.Text

Public Class FormRegister

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim username As String = TextBox1.Text.Trim()
        Dim password As String = TextBox2.Text.Trim()
        Dim role As String = ComboBox1.SelectedItem?.ToString()

        If username = "" Or password = "" Then
            MessageBox.Show("Username dan Password tidak boleh kosong!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        If ComboBox1.SelectedIndex = -1 Then
            MessageBox.Show("Pilih Role terlebih dahulu!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        password = HashPassword(password)

        Using conn As SqlConnection = getConnection()
            If conn Is Nothing Then Return

            Try
                ' Cek Username
                Dim queryCek As String = "SELECT COUNT(*) FROM users WHERE username = @user"
                Dim cmdCek As New SqlCommand(queryCek, conn)
                cmdCek.Parameters.AddWithValue("@user", username)

                Dim count As Integer = Convert.ToInt32(cmdCek.ExecuteScalar())

                If count > 0 Then
                    MessageBox.Show("Username sudah terdaftar!", "Gagal", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Else
                    ' Simpan Data (Password is already hashed above)
                    Dim querySimpan As String = "INSERT INTO users (username, role, password) VALUES (@user, @role, @pass)"
                    Dim cmdSimpan As New SqlCommand(querySimpan, conn)
                    cmdSimpan.Parameters.AddWithValue("@user", username)
                    cmdSimpan.Parameters.AddWithValue("@role", role)
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

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Close()
    End Sub
End Class