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
        ' Clear previous errors
        ErrorProvider1.Clear()

        Dim judul As String = TextBox1.Text.Trim()
        If judul = "" Then
            ErrorProvider1.SetError(TextBox1, "Judul tidak boleh kosong!")
            Return
        End If

        ' Check if at least one ComboBox is selected
        If ComboBox1.SelectedIndex = -1 And ComboBox2.SelectedIndex = -1 And ComboBox3.SelectedIndex = -1 Then
            ErrorProvider1.SetError(ComboBox1, "Pilih minimal 1 mata kuliah!")
            Return
        End If

        ' Check if corresponding CF is filled for selected ComboBoxes
        If (ComboBox1.SelectedIndex <> -1 And NumericUpDown1.Value = 0) Or
           (ComboBox2.SelectedIndex <> -1 And NumericUpDown2.Value = 0) Or
           (ComboBox3.SelectedIndex <> -1 And NumericUpDown3.Value = 0) Then
            ErrorProvider1.SetError(NumericUpDown1, "Certainty Factor tidak boleh nol untuk mata kuliah yang dipilih!")
            Return
        End If

        Using conn As SqlConnection = getConnection()
            If conn Is Nothing Then Return

            Using cmd As New SqlCommand("
            INSERT INTO rules 
            (judul, mata_kuliah1, cf1, mata_kuliah2, cf2, mata_kuliah3, cf3)
            VALUES (@judul, @mk1, @cf1, @mk2, @cf2, @mk3, @cf3)", conn)

                cmd.Parameters.AddWithValue("@judul", judul)

                ' Handle mata_kuliah1 and cf1
                If ComboBox1.SelectedIndex <> -1 Then
                    cmd.Parameters.AddWithValue("@mk1", ComboBox1.SelectedIndex)
                    cmd.Parameters.AddWithValue("@cf1", CDbl(NumericUpDown1.Value))
                Else
                    cmd.Parameters.AddWithValue("@mk1", DBNull.Value)
                    cmd.Parameters.AddWithValue("@cf1", DBNull.Value)
                End If

                ' Handle mata_kuliah2 and cf2
                If ComboBox2.SelectedIndex <> -1 Then
                    cmd.Parameters.AddWithValue("@mk2", ComboBox2.SelectedIndex)
                    cmd.Parameters.AddWithValue("@cf2", CDbl(NumericUpDown2.Value))
                Else
                    cmd.Parameters.AddWithValue("@mk2", DBNull.Value)
                    cmd.Parameters.AddWithValue("@cf2", DBNull.Value)
                End If

                ' Handle mata_kuliah3 and cf3
                If ComboBox3.SelectedIndex <> -1 Then
                    cmd.Parameters.AddWithValue("@mk3", ComboBox3.SelectedIndex)
                    cmd.Parameters.AddWithValue("@cf3", CDbl(NumericUpDown3.Value))
                Else
                    cmd.Parameters.AddWithValue("@mk3", DBNull.Value)
                    cmd.Parameters.AddWithValue("@cf3", DBNull.Value)
                End If

                Try
                    cmd.ExecuteNonQuery()
                    MessageBox.Show("Judul berhasil ditambahkan!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information)

                    ' Clear form
                    TextBox1.Clear()
                    ComboBox1.SelectedIndex = -1
                    ComboBox2.SelectedIndex = -1
                    ComboBox3.SelectedIndex = -1
                    NumericUpDown1.Value = 0
                    NumericUpDown2.Value = 0
                    NumericUpDown3.Value = 0
                    ErrorProvider1.Clear()
                Catch ex As Exception
                    MessageBox.Show("Error: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End Try
            End Using
        End Using
    End Sub
End Class
