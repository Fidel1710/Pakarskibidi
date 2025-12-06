' ===== FormHasil.vb =====
Public Class FormHasil
    Private hasilData As List(Of Tuple(Of String, String, Double))

    Public Sub SetHasil(hasil As List(Of Tuple(Of String, String, Double)))
        hasilData = hasil
        TampilkanHasil()
    End Sub

    Private Sub TampilkanHasil()
        ' Clear controls
        ListBoxHasil.Items.Clear()
        TextBoxDetail.Clear()

        If hasilData IsNot Nothing AndAlso hasilData.Count > 0 Then
            ' Tampilkan di ListBox
            ListBoxHasil.Items.Add("╔═══════════════════════════════════════════════════════════════╗")
            ListBoxHasil.Items.Add("║       HASIL REKOMENDASI JUDUL TUGAS AKHIR MAHASISWA          ║")
            ListBoxHasil.Items.Add("║         SISTEM PAKAR METODE CERTAINTY FACTOR                  ║")
            ListBoxHasil.Items.Add("╚═══════════════════════════════════════════════════════════════╝")
            ListBoxHasil.Items.Add("")

            For i As Integer = 0 To hasilData.Count - 1
                Dim item As Tuple(Of String, String, Double) = hasilData(i)
                ListBoxHasil.Items.Add($"┌─ Peringkat {i + 1} ─────────────────────────────────────────────")
                ListBoxHasil.Items.Add($"│ Kode        : {item.Item1}")
                ListBoxHasil.Items.Add($"│ Judul       : {item.Item2}")
                ListBoxHasil.Items.Add($"│ Kepercayaan : {item.Item3.ToString("0.00")}%")
                ListBoxHasil.Items.Add($"│ Status      : {GetStatusRekomendasi(item.Item3)}")
                ListBoxHasil.Items.Add("└──────────────────────────────────────────────────────────────")
                ListBoxHasil.Items.Add("")
            Next

            ' Tampilkan rekomendasi utama di TextBox
            Dim terbaik As Tuple(Of String, String, Double) = hasilData(0)
            TextBoxDetail.Text = "╔════════════════════════════════════════════════════╗" & vbCrLf
            TextBoxDetail.Text &= "║          REKOMENDASI TERBAIK UNTUK ANDA            ║" & vbCrLf
            TextBoxDetail.Text &= "╚════════════════════════════════════════════════════╝" & vbCrLf & vbCrLf
            TextBoxDetail.Text &= $"Kode Judul   : {terbaik.Item1}" & vbCrLf & vbCrLf
            TextBoxDetail.Text &= $"Judul        : " & vbCrLf
            TextBoxDetail.Text &= $"{terbaik.Item2}" & vbCrLf & vbCrLf
            TextBoxDetail.Text &= $"Tingkat Kepercayaan : {terbaik.Item3.ToString("0.00")}%" & vbCrLf & vbCrLf
            TextBoxDetail.Text &= "─────────────────────────────────────────────────────" & vbCrLf & vbCrLf
            TextBoxDetail.Text &= "KESIMPULAN:" & vbCrLf
            TextBoxDetail.Text &= "Judul ini merupakan rekomendasi terbaik berdasarkan " & vbCrLf
            TextBoxDetail.Text &= "tingkat kepercayaan dan minat Anda terhadap mata " & vbCrLf
            TextBoxDetail.Text &= "kuliah yang dipilih. Sistem pakar memberikan nilai " & vbCrLf
            TextBoxDetail.Text &= $"kepercayaan {terbaik.Item3.ToString("0.00")}% yang menunjukkan bahwa " & vbCrLf
            TextBoxDetail.Text &= "judul ini sangat sesuai dengan kemampuan dan minat Anda." & vbCrLf & vbCrLf
            TextBoxDetail.Text &= GetRekomendasiTambahan(terbaik.Item3)
        End If
    End Sub

    Private Function GetStatusRekomendasi(persentase As Double) As String
        If persentase >= 80 Then
            Return "Sangat Direkomendasikan ⭐⭐⭐"
        ElseIf persentase >= 60 Then
            Return "Direkomendasikan ⭐⭐"
        ElseIf persentase >= 40 Then
            Return "Cukup Sesuai ⭐"
        Else
            Return "Kurang Sesuai"
        End If
    End Function

    Private Function GetRekomendasiTambahan(persentase As Double) As String
        If persentase >= 80 Then
            Return "SARAN: Judul ini sangat cocok untuk Anda! Segera konsultasikan " & vbCrLf &
                   "dengan dosen pembimbing untuk memulai penelitian."
        ElseIf persentase >= 60 Then
            Return "SARAN: Judul ini cukup sesuai dengan minat Anda. Diskusikan " & vbCrLf &
                   "lebih lanjut dengan dosen pembimbing untuk menyempurnakan topik."
        ElseIf persentase >= 40 Then
            Return "SARAN: Pertimbangkan untuk memilih mata kuliah dengan tingkat " & vbCrLf &
                   "kepercayaan yang lebih tinggi untuk mendapatkan rekomendasi yang lebih baik."
        Else
            Return "SARAN: Tingkatkan kepercayaan Anda pada mata kuliah terkait " & vbCrLf &
                   "atau pertimbangkan topik lain yang lebih sesuai dengan kemampuan Anda."
        End If
    End Function

    Private Sub ButtonCetak_Click(sender As Object, e As EventArgs) Handles ButtonCetak.Click
        ' Fungsi untuk mencetak atau menyimpan hasil
        Dim saveDialog As New SaveFileDialog()
        saveDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*"
        saveDialog.Title = "Simpan Hasil Rekomendasi"
        saveDialog.FileName = "Hasil_Rekomendasi_" & DateTime.Now.ToString("yyyyMMdd_HHmmss") & ".txt"

        If saveDialog.ShowDialog() = DialogResult.OK Then
            Try
                Dim fileContent As String = ""
                fileContent &= "═══════════════════════════════════════════════════════════════" & vbCrLf
                fileContent &= "       HASIL REKOMENDASI JUDUL TUGAS AKHIR MAHASISWA" & vbCrLf
                fileContent &= "         SISTEM PAKAR METODE CERTAINTY FACTOR" & vbCrLf
                fileContent &= "═══════════════════════════════════════════════════════════════" & vbCrLf
                fileContent &= "Tanggal: " & DateTime.Now.ToString("dd MMMM yyyy HH:mm:ss") & vbCrLf
                fileContent &= vbCrLf

                For i As Integer = 0 To hasilData.Count - 1
                    Dim item As Tuple(Of String, String, Double) = hasilData(i)
                    fileContent &= $"Peringkat {i + 1}" & vbCrLf
                    fileContent &= $"Kode        : {item.Item1}" & vbCrLf
                    fileContent &= $"Judul       : {item.Item2}" & vbCrLf
                    fileContent &= $"Kepercayaan : {item.Item3.ToString("0.00")}%" & vbCrLf
                    fileContent &= $"Status      : {GetStatusRekomendasi(item.Item3)}" & vbCrLf
                    fileContent &= "───────────────────────────────────────────────────────────" & vbCrLf
                    fileContent &= vbCrLf
                Next

                System.IO.File.WriteAllText(saveDialog.FileName, fileContent)
                MessageBox.Show("Hasil rekomendasi berhasil disimpan!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Catch ex As Exception
                MessageBox.Show("Gagal menyimpan file: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If
    End Sub

    Private Sub FormHasil_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Set properties form
        Me.StartPosition = FormStartPosition.CenterScreen
    End Sub

End Class