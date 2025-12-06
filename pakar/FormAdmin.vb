Imports System.Data.SqlClient
Imports Microsoft.Data.SqlClient
Public Class FormAdmin
    Private Sub Form4_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Using conn As SqlConnection = getConnection()
            conn.Open()
            Using cmd As New SqlCommand("SELECT * FROM matakuliah", conn)
                Using adapter As New SqlDataAdapter(cmd)
                    Dim table As New DataTable()
                    adapter.Fill(table)
                    DataGridView1.DataSource = table
                End Using
            End Using

            Using cmd As New SqlCommand("SELECT nama_mata_kuliah FROM matakuliah", conn)
                Dim reader As SqlDataReader = cmd.ExecuteReader()
                While reader.Read()
                    ComboBox1.Items.Add(reader("nama_mata_kuliah").ToString())
                    ComboBox2.Items.Add(reader("nama_mata_kuliah").ToString())
                    ComboBox3.Items.Add(reader("nama_mata_kuliah").ToString())
                End While
            End Using
        End Using
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        TextBox2.Text = DataGridView1.Rows(e.RowIndex).Cells(1).Value.ToString()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim matakuliah As String = TextBox2.Text.Trim()

        Dim id As Integer = Integer.Parse(DataGridView1.Rows(DataGridView1.Rows.Count - 2).Cells(0).Value.ToString()) + 1

        Using conn As SqlConnection = getConnection()
            conn.Open()

            If TextBox2.Text.Trim() = "" Then
                ErrorProvider1.SetError(TextBox2, "Matakuliah tidak boleh kosong!")
            End If

            Using cmd As New SqlCommand("INSERT INTO matakuliah (id, nama_mata_kuliah) VALUES (@id, @matakuliah)", conn)
                cmd.Parameters.AddWithValue("@matakuliah", matakuliah)
                Try
                    cmd.ExecuteNonQuery()
                    MessageBox.Show("Data Matakuliah Berhasil Ditambahkan!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    TextBox2.Clear()
                Catch ex As Exception
                    MessageBox.Show("Error: " & ex.Message)
                End Try
            End Using
        End Using
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim matakuliah As String = TextBox2.Text.Trim()

        Using conn As SqlConnection = getConnection()
            conn.Open()
            If TextBox2.Text.Trim() = "" Then
                ErrorProvider1.SetError(TextBox2, "Matakuliah tidak boleh kosong!")
            End If
            Using cmd As New SqlCommand("DELETE FROM matakuliah WHERE nama_mata_kuliah = @matakuliah", conn)
                cmd.Parameters.AddWithValue("@matakuliah", matakuliah)
                Try
                    Dim rowsAffected As Integer = cmd.ExecuteNonQuery()
                    If rowsAffected > 0 Then
                        MessageBox.Show("Data Matakuliah Berhasil Dihapus!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        TextBox2.Clear()
                    Else
                        MessageBox.Show("Matakuliah tidak ditemukan!", "Gagal", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    End If
                Catch ex As Exception
                    MessageBox.Show("Error: " & ex.Message)
                End Try
            End Using
        End Using
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim matakuliah As String = TextBox2.Text.Trim()

        Using conn As SqlConnection = getConnection()
            conn.Open()
            If TextBox2.Text.Trim() = "" Then
                ErrorProvider1.SetError(TextBox2, "Matakuliah tidak boleh kosong!")
            End If
            Using cmd As New SqlCommand("UPDATE matakuliah SET nama_mata_kuliah = @matakuliah WHERE nama_mata_kuliah = @matakuliah", conn)
                cmd.Parameters.AddWithValue("@matakuliah", matakuliah)
                Try
                    Dim rowsAffected As Integer = cmd.ExecuteNonQuery()
                    If rowsAffected > 0 Then
                        MessageBox.Show("Data Matakuliah Berhasil Diperbarui!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        TextBox2.Clear()
                    Else
                        MessageBox.Show("Matakuliah tidak ditemukan!", "Gagal", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    End If
                Catch ex As Exception
                    MessageBox.Show("Error: " & ex.Message)
                End Try
            End Using
        End Using
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim judul As String = TextBox1.Text.Trim()
        Dim mk1 As String = ComboBox1.SelectedItem.ToString()
        Dim mk2 As String = ComboBox2.SelectedItem.ToString()
        Dim mk3 As String = ComboBox3.SelectedItem.ToString()
        Dim cf1 As Double = Double.Parse(NumericUpDown1.Text.Trim())
        Dim cf2 As Double = Double.Parse(NumericUpDown2.Text.Trim())
        Dim cf3 As Double = Double.Parse(NumericUpDown3.Text.Trim())

        If judul = "" Then
            ErrorProvider1.SetError(TextBox1, "Judul Kasus tidak boleh kosong!")
        End If

        If mk1 = "" And mk2 = "" And mk3 = "" Then
            ErrorProvider1.SetError(ComboBox1, "Pilih minimal 1 Mata Kuliah!")
        End If

        If mk1 IsNot "" Then
            If cf1 <= 0 Then
                ErrorProvider1.SetError(NumericUpDown1, "CF Mata Kuliah 1 harus lebih dari 0!")
                Return
            End If
        End If

        If mk2 IsNot "" Then
            If cf2 <= 0 Then
                ErrorProvider1.SetError(NumericUpDown2, "CF Mata Kuliah 2 harus lebih dari 0!")
                Return
            End If
        End If

        If mk3 IsNot "" Then
            If cf3 <= 0 Then
                ErrorProvider1.SetError(NumericUpDown3, "CF Mata Kuliah 3 harus lebih dari 0!")
            End If
        End If

        Using conn As SqlConnection = getConnection()
            conn.Open()

            Using cmd As New SqlCommand("INSERT INTO kasus (judul_kasus, mata_kuliah1, cf1, mata_kuliah2, cf2, mata_kuliah3, cf3) VALUES (@judul, @mk1, @cf1, @mk2, @cf2, @mk3, @cf3)", conn)
                cmd.Parameters.AddWithValue("@judul", judul)
                cmd.Parameters.AddWithValue("@mk1", mk1)
                cmd.Parameters.AddWithValue("@cf1", cf1)
                cmd.Parameters.AddWithValue("@mk2", mk2)
                cmd.Parameters.AddWithValue("@cf2", cf2)
                cmd.Parameters.AddWithValue("@mk3", mk3)
                cmd.Parameters.AddWithValue("@cf3", cf3)
                Try
                    cmd.ExecuteNonQuery()
                    MessageBox.Show("Data Kasus Berhasil Ditambahkan!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    TextBox1.Clear()
                    ComboBox1.SelectedIndex = -1
                    ComboBox2.SelectedIndex = -1
                    ComboBox3.SelectedIndex = -1
                    NumericUpDown1.Value = 0
                    NumericUpDown2.Value = 0
                    NumericUpDown3.Value = 0
                Catch ex As Exception
                    MessageBox.Show("Error: " & ex.Message)
                End Try
            End Using
        End Using
    End Sub
End Class