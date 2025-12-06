Imports Microsoft.Data.SqlClient

Public Class FormAdmin

    Private Sub Form4_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Using conn As SqlConnection = getConnection()

            ' LOAD DATAGRID
            Using cmd As New SqlCommand("SELECT * FROM matakuliah", conn)
                Using adapter As New SqlDataAdapter(cmd)
                    Dim table As New DataTable()
                    adapter.Fill(table)
                    DataGridView1.DataSource = table
                End Using
            End Using

            ' LOAD COMBOBOX
            Using cmd As New SqlCommand("SELECT nama_mata_kuliah FROM matakuliah", conn)
                Using reader As SqlDataReader = cmd.ExecuteReader()
                    While reader.Read()
                        Dim nama As String = reader("nama_mata_kuliah").ToString()
                        ComboBox1.Items.Add(nama)
                        ComboBox2.Items.Add(nama)
                        ComboBox3.Items.Add(nama)
                    End While
                End Using
            End Using
        End Using
    End Sub

    Private Sub FormAdmin_Closed(sender As Object, e As EventArgs) Handles MyBase.Closed
        Me.Hide()
        Dim frm As New FormLogin()
        frm.Show()
    End Sub


    ' ========================
    '  TABLE CLICK -> EDIT BOX
    ' ========================
    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        If e.RowIndex >= 0 Then
            TextBox2.Text = DataGridView1.Rows(e.RowIndex).Cells(1).Value.ToString()
        End If
    End Sub



    ' ====================
    '  INSERT MATAKULIAH
    ' ====================
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click

        Dim matakuliah As String = TextBox2.Text.Trim()

        If matakuliah = "" Then
            ErrorProvider1.SetError(TextBox2, "Matakuliah tidak boleh kosong!")
            Return
        End If

        Using conn As SqlConnection = getConnection()

            Using cmd As New SqlCommand("INSERT INTO matakuliah (nama_mata_kuliah) VALUES (@mk)", conn)
                cmd.Parameters.AddWithValue("@mk", matakuliah)

                Try
                    cmd.ExecuteNonQuery()
                    MessageBox.Show("Data Matakuliah Berhasil Ditambahkan!", "Sukses")
                    TextBox2.Clear()

                Catch ex As Exception
                    MessageBox.Show("Error: " & ex.Message)
                End Try
            End Using

        End Using

    End Sub



    ' ====================
    '  DELETE MATAKULIAH
    ' ====================
    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click

        Dim matakuliah As String = TextBox2.Text.Trim()

        If matakuliah = "" Then
            ErrorProvider1.SetError(TextBox2, "Matakuliah tidak boleh kosong!")
            Return
        End If

        Using conn As SqlConnection = getConnection()

            Using cmd As New SqlCommand("DELETE FROM matakuliah WHERE nama_mata_kuliah = @mk", conn)
                cmd.Parameters.AddWithValue("@mk", matakuliah)

                Try
                    Dim rows As Integer = cmd.ExecuteNonQuery()

                    If rows > 0 Then
                        MessageBox.Show("Data Matakuliah Berhasil Dihapus!", "Sukses")
                        TextBox2.Clear()
                    Else
                        MessageBox.Show("Matakuliah tidak ditemukan!", "Gagal")
                    End If

                Catch ex As Exception
                    MessageBox.Show("Error: " & ex.Message)
                End Try
            End Using

        End Using

    End Sub



    ' ====================
    '  UPDATE MATAKULIAH
    ' ====================
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        Dim matakuliah As String = TextBox2.Text.Trim()

        If matakuliah = "" Then
            ErrorProvider1.SetError(TextBox2, "Matakuliah tidak boleh kosong!")
            Return
        End If

        Dim oldValue As String = ""
        If DataGridView1.SelectedRows.Count > 0 Then
            oldValue = DataGridView1.SelectedRows(0).Cells(1).Value.ToString()
        Else
            MessageBox.Show("Pilih baris pada tabel untuk update!")
            Return
        End If

        Using conn As SqlConnection = getConnection()

            Using cmd As New SqlCommand("UPDATE matakuliah SET nama_mata_kuliah = @baru WHERE nama_mata_kuliah = @lama", conn)
                cmd.Parameters.AddWithValue("@baru", matakuliah)
                cmd.Parameters.AddWithValue("@lama", oldValue)

                Try
                    Dim rows = cmd.ExecuteNonQuery()

                    If rows > 0 Then
                        MessageBox.Show("Data Matakuliah Berhasil Diupdate!", "Sukses")
                        TextBox2.Clear()
                    Else
                        MessageBox.Show("Matakuliah tidak ditemukan!", "Gagal")
                    End If

                Catch ex As Exception
                    MessageBox.Show("Error: " & ex.Message)
                End Try
            End Using

        End Using

    End Sub



    ' ====================
    '  INSERT KASUS
    ' ====================
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim judul As String = TextBox1.Text.Trim()

        If judul = "" Then
            ErrorProvider1.SetError(TextBox1, "Judul tidak boleh kosong!")
            Return
        End If

        If ComboBox1.SelectedIndex = -1 And ComboBox2.SelectedIndex = -1 And ComboBox3.SelectedIndex = -1 Then
            ErrorProvider1.SetError(ComboBox1, "Mata Kuliah Tidak Boleh Kosong!")
            Return
        End If

        If NumericUpDown1.Value = 0 And NumericUpDown2.Value = 0 And NumericUpDown3.Value = 0 Then
            ErrorProvider1.SetError(NumericUpDown1, "Certainty Factor Tidak Boleh Nol!")
            Return
        End If

        Dim mk1 As String =  ComboBox1.SelectedIndex
        Dim mk2 As String = ComboBox2.SelectedIndex
        Dim mk3 As String = ComboBox3.SelectedIndex

        Dim cf1 As Double = NumericUpDown1.Value
        Dim cf2 As Double = NumericUpDown2.Value
        Dim cf3 As Double = NumericUpDown3.Value

        If mk1 = "" And mk2 = "" And mk3 = "" Then
            MessageBox.Show("Pilih minimal 1 mata kuliah!")
            Return
        End If

        Using conn As SqlConnection = getConnection()

            Using cmd As New SqlCommand("
                INSERT INTO rules 
                (judul, mata_kuliah1, cf1, mata_kuliah2, cf2, mata_kuliah3, cf3)
                VALUES (@judul, @mk1, @cf1, @mk2, @cf2, @mk3, @cf3)", conn)

                cmd.Parameters.AddWithValue("@judul", judul)
                cmd.Parameters.AddWithValue("@mk1", mk1)
                cmd.Parameters.AddWithValue("@cf1", cf1)
                cmd.Parameters.AddWithValue("@mk2", mk2)
                cmd.Parameters.AddWithValue("@cf2", cf2)
                cmd.Parameters.AddWithValue("@mk3", mk3)
                cmd.Parameters.AddWithValue("@cf3", cf3)

                Try
                    cmd.ExecuteNonQuery()

                    MessageBox.Show("Judul berhasil ditambahkan!", "Sukses")

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
