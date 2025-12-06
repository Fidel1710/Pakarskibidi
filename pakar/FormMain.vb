Imports Microsoft.Data.SqlClient

' ===== FormMain.vb =====
Public Class FormMain
    ' Struktur data untuk menyimpan informasi mata kuliah
    Structure MataKuliah
        Dim Id As Integer
        Dim Nama As String
        Dim TrackBar As TrackBar
        Dim LabelNama As Label
        Dim LabelNilai As Label
    End Structure

    ' Struktur data untuk menyimpan informasi judul
    Structure JudulTugasAkhir
        Dim Id As Integer
        Dim Judul As String
        Dim MataKuliah1 As Integer
        Dim CF1 As Double
        Dim MataKuliah2 As Integer?
        Dim CF2 As Double
        Dim MataKuliah3 As Integer?
        Dim CF3 As Double
    End Structure

    ' List untuk menyimpan data
    Private mataKuliahList As New List(Of MataKuliah)
    Private judulList As New List(Of JudulTugasAkhir)

    ' Panel untuk menampung kontrol dinamis
    Private panelKonten As New Panel()
    Private panelButton As New Panel()

    Private Sub FormMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            ' Setup form
            Me.Text = "Sistem Pakar Rekomendasi Tugas Akhir"
            Me.WindowState = FormWindowState.Maximized
            Me.AutoScroll = True

            ' Load data dari database
            LoadMataKuliah()
            LoadRules()

            ' Buat UI dinamis
            CreateDynamicUI()

            MessageBox.Show($"Berhasil memuat {mataKuliahList.Count} mata kuliah dan {judulList.Count} rules.", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information)

        Catch ex As Exception
            MessageBox.Show("Error saat memuat data: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub LoadMataKuliah()
        mataKuliahList.Clear()

        Using conn As SqlConnection = modulkoneksi.getConnection()
            If conn IsNot Nothing Then
                Dim query As String = "SELECT id, nama_mata_kuliah FROM matakuliah ORDER BY id"
                Using cmd As New SqlCommand(query, conn)
                    Using reader As SqlDataReader = cmd.ExecuteReader()
                        While reader.Read()
                            Dim mk As New MataKuliah With {
                                .Id = reader.GetInt32(0),
                                .Nama = reader.GetString(1)
                            }
                            mataKuliahList.Add(mk)
                        End While
                    End Using
                End Using
                conn.Close()
            End If
        End Using
    End Sub

    Private Sub LoadRules()
        judulList.Clear()

        Using conn As SqlConnection = modulkoneksi.getConnection()
            If conn IsNot Nothing Then
                Dim query As String = "SELECT id, judul, mata_kuliah1, cf1, mata_kuliah2, cf2, mata_kuliah3, cf3 FROM rules ORDER BY id"
                Using cmd As New SqlCommand(query, conn)
                    Using reader As SqlDataReader = cmd.ExecuteReader()
                        While reader.Read()
                            Dim judul As New JudulTugasAkhir With {
                                .Id = reader.GetInt32(0),
                                .Judul = reader.GetString(1),
                                .MataKuliah1 = reader.GetInt32(2),
                                .CF1 = reader.GetDouble(3),
                                .MataKuliah2 = If(reader.IsDBNull(4), Nothing, CType(reader.GetInt32(4), Integer?)),
                                .CF2 = If(reader.IsDBNull(5), 0, reader.GetDouble(5)),
                                .MataKuliah3 = If(reader.IsDBNull(6), Nothing, CType(reader.GetInt32(6), Integer?)),
                                .CF3 = If(reader.IsDBNull(7), 0, reader.GetDouble(7))
                            }
                            judulList.Add(judul)
                        End While
                    End Using
                End Using
                conn.Close()
            End If
        End Using
    End Sub

    Private Sub CreateDynamicUI()
        ' Clear existing controls
        Me.Controls.Clear()

        ' Setup panel konten
        panelKonten.Dock = DockStyle.Fill
        panelKonten.AutoScroll = True
        panelKonten.Padding = New Padding(20)
        panelKonten.BackColor = Color.FromArgb(240, 240, 240)
        Me.Controls.Add(panelKonten)

        ' Setup panel button
        panelButton.Dock = DockStyle.Bottom
        panelButton.Height = 80
        panelButton.Padding = New Padding(20)
        panelButton.BackColor = Color.White
        Me.Controls.Add(panelButton)

        Dim yPosition As Integer = 20

        ' Buat header
        Dim lblHeader As New Label()
        lblHeader.Text = "SISTEM PAKAR REKOMENDASI TUGAS AKHIR MAHASISWA"
        lblHeader.Font = New Font("Segoe UI", 16, FontStyle.Bold)
        lblHeader.AutoSize = True
        lblHeader.Location = New Point(20, yPosition)
        lblHeader.ForeColor = Color.FromArgb(0, 122, 204)
        panelKonten.Controls.Add(lblHeader)
        yPosition += 50

        Dim lblSubHeader As New Label()
        lblSubHeader.Text = "Silakan tentukan tingkat kepercayaan Anda terhadap setiap mata kuliah (0-100)"
        lblSubHeader.Font = New Font("Segoe UI", 10, FontStyle.Regular)
        lblSubHeader.AutoSize = True
        lblSubHeader.Location = New Point(20, yPosition)
        lblSubHeader.ForeColor = Color.FromArgb(64, 64, 64)
        panelKonten.Controls.Add(lblSubHeader)
        yPosition += 40

        ' Buat separator
        Dim separator1 As New Panel()
        separator1.Height = 2
        separator1.Width = Me.Width - 60
        separator1.BackColor = Color.FromArgb(0, 122, 204)
        separator1.Location = New Point(20, yPosition)
        panelKonten.Controls.Add(separator1)
        yPosition += 20

        ' Buat kontrol untuk setiap mata kuliah
        For i As Integer = 0 To mataKuliahList.Count - 1
            Dim mk As MataKuliah = mataKuliahList(i)

            ' Panel untuk setiap item
            Dim itemPanel As New Panel()
            itemPanel.Location = New Point(20, yPosition)
            itemPanel.Width = Me.Width - 80
            itemPanel.Height = 100
            itemPanel.BackColor = Color.White
            itemPanel.BorderStyle = BorderStyle.FixedSingle
            panelKonten.Controls.Add(itemPanel)

            ' Label nama mata kuliah dengan nomor
            Dim lblNama As New Label()
            lblNama.Text = $"{i + 1}. {mk.Nama}?"
            lblNama.Font = New Font("Segoe UI", 11, FontStyle.Bold)
            lblNama.AutoSize = True
            lblNama.Location = New Point(10, 10)
            lblNama.ForeColor = Color.FromArgb(33, 33, 33)
            itemPanel.Controls.Add(lblNama)
            mk.LabelNama = lblNama

            ' TrackBar
            Dim trackBar As New TrackBar()
            trackBar.Minimum = 0
            trackBar.Maximum = 100
            trackBar.Value = 0
            trackBar.TickFrequency = 10
            trackBar.Width = 600
            trackBar.Location = New Point(10, 40)
            trackBar.Tag = i ' Simpan index untuk referensi
            AddHandler trackBar.ValueChanged, AddressOf TrackBar_ValueChanged
            itemPanel.Controls.Add(trackBar)
            mk.TrackBar = trackBar

            ' Label nilai di samping trackbar
            Dim lblNilai As New Label()
            lblNilai.Text = GetKepercayaanText(0)
            lblNilai.Font = New Font("Segoe UI", 10, FontStyle.Bold)
            lblNilai.AutoSize = True
            lblNilai.Location = New Point(620, 50)
            lblNilai.ForeColor = Color.FromArgb(0, 122, 204)
            itemPanel.Controls.Add(lblNilai)
            mk.LabelNilai = lblNilai

            ' Update data di list
            mataKuliahList(i) = mk

            yPosition += 110
        Next

        ' Set minimum height untuk panel konten
        panelKonten.AutoScrollMinSize = New Size(0, yPosition + 20)

        ' Tombol Proses
        Dim btnProses As New Button()
        btnProses.Text = "PROSES REKOMENDASI"
        btnProses.Font = New Font("Segoe UI", 12, FontStyle.Bold)
        btnProses.Size = New Size(250, 50)
        btnProses.Location = New Point(20, 15)
        btnProses.BackColor = Color.FromArgb(0, 122, 204)
        btnProses.ForeColor = Color.White
        btnProses.FlatStyle = FlatStyle.Flat
        btnProses.FlatAppearance.BorderSize = 0
        btnProses.Cursor = Cursors.Hand
        AddHandler btnProses.Click, AddressOf ButtonProses_Click
        panelButton.Controls.Add(btnProses)

        ' Tombol Reset
        Dim btnReset As New Button()
        btnReset.Text = "RESET"
        btnReset.Font = New Font("Segoe UI", 12, FontStyle.Bold)
        btnReset.Size = New Size(150, 50)
        btnReset.Location = New Point(290, 15)
        btnReset.BackColor = Color.FromArgb(255, 87, 34)
        btnReset.ForeColor = Color.White
        btnReset.FlatStyle = FlatStyle.Flat
        btnReset.FlatAppearance.BorderSize = 0
        btnReset.Cursor = Cursors.Hand
        AddHandler btnReset.Click, AddressOf ButtonReset_Click
        panelButton.Controls.Add(btnReset)

        ' Tombol Refresh Data
        Dim btnRefresh As New Button()
        btnRefresh.Text = "REFRESH DATA"
        btnRefresh.Font = New Font("Segoe UI", 12, FontStyle.Bold)
        btnRefresh.Size = New Size(200, 50)
        btnRefresh.Location = New Point(460, 15)
        btnRefresh.BackColor = Color.FromArgb(76, 175, 80)
        btnRefresh.ForeColor = Color.White
        btnRefresh.FlatStyle = FlatStyle.Flat
        btnRefresh.FlatAppearance.BorderSize = 0
        btnRefresh.Cursor = Cursors.Hand
        AddHandler btnRefresh.Click, AddressOf ButtonRefresh_Click
        panelButton.Controls.Add(btnRefresh)
    End Sub

    Private Sub TrackBar_ValueChanged(sender As Object, e As EventArgs)
        Dim trackBar As TrackBar = CType(sender, TrackBar)
        Dim index As Integer = CInt(trackBar.Tag)

        If index >= 0 AndAlso index < mataKuliahList.Count Then
            Dim mk As MataKuliah = mataKuliahList(index)
            mk.LabelNilai.Text = GetKepercayaanText(trackBar.Value)

            ' Update warna label berdasarkan nilai
            If trackBar.Value = 0 Then
                mk.LabelNilai.ForeColor = Color.Gray
            ElseIf trackBar.Value <= 25 Then
                mk.LabelNilai.ForeColor = Color.FromArgb(244, 67, 54) ' Red
            ElseIf trackBar.Value <= 50 Then
                mk.LabelNilai.ForeColor = Color.FromArgb(255, 152, 0) ' Orange
            ElseIf trackBar.Value <= 70 Then
                mk.LabelNilai.ForeColor = Color.FromArgb(3, 169, 244) ' Blue
            Else
                mk.LabelNilai.ForeColor = Color.FromArgb(76, 175, 80) ' Green
            End If
        End If
    End Sub

    Private Function GetKepercayaanText(nilai As Integer) As String
        Dim cf As Double = nilai / 100.0

        If cf = 0 Then
            Return "Tidak Dipilih (0.00)"
        ElseIf cf <= 0.1 Then
            Return $"Kurang Yakin ({cf.ToString("0.00")})"
        ElseIf cf <= 0.25 Then
            Return $"Agak Yakin ({cf.ToString("0.00")})"
        ElseIf cf <= 0.5 Then
            Return $"Cukup Yakin ({cf.ToString("0.00")})"
        ElseIf cf <= 0.7 Then
            Return $"Yakin ({cf.ToString("0.00")})"
        Else
            Return $"Sangat Yakin ({cf.ToString("0.00")})"
        End If
    End Function

    Private Function HitungCF(cfPakar As Double, cfUser As Double) As Double
        ' CF[H,E] = CF[H] * CF[E]
        Return cfPakar * cfUser
    End Function

    Private Function HitungCFCombine(cf1 As Double, cf2 As Double) As Double
        ' CFcombine = CF1 + CF2 * (1 - CF1)
        Return cf1 + cf2 * (1 - cf1)
    End Function

    Private Sub ButtonProses_Click(sender As Object, e As EventArgs)
        ' Validasi input - pastikan ada minimal 1 mata kuliah yang dipilih
        Dim adaPilihan As Boolean = False
        For Each mk As MataKuliah In mataKuliahList
            If mk.TrackBar.Value > 0 Then
                adaPilihan = True
                Exit For
            End If
        Next

        If Not adaPilihan Then
            MessageBox.Show("Silakan pilih minimal satu mata kuliah dengan mengatur nilai kepercayaan!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Try
            ' List untuk menyimpan hasil perhitungan
            Dim hasilList As New List(Of Tuple(Of String, String, Double))

            ' Hitung CF untuk setiap judul
            For Each judul As JudulTugasAkhir In judulList
                Dim cfList As New List(Of Double)

                ' Cari CF user untuk mata kuliah 1
                Dim mk1 As MataKuliah = mataKuliahList.FirstOrDefault(Function(x) x.Id = judul.MataKuliah1)
                If mk1.TrackBar IsNot Nothing Then
                    Dim cfUser1 As Double = mk1.TrackBar.Value / 100.0
                    If cfUser1 > 0 Then
                        Dim cf As Double = HitungCF(judul.CF1, cfUser1)
                        cfList.Add(cf)
                    End If
                End If

                ' Cari CF user untuk mata kuliah 2 (jika ada)
                If judul.MataKuliah2.HasValue Then
                    Dim mk2 As MataKuliah = mataKuliahList.FirstOrDefault(Function(x) x.Id = judul.MataKuliah2.Value)
                    If mk2.TrackBar IsNot Nothing Then
                        Dim cfUser2 As Double = mk2.TrackBar.Value / 100.0
                        If cfUser2 > 0 Then
                            Dim cf As Double = HitungCF(judul.CF2, cfUser2)
                            cfList.Add(cf)
                        End If
                    End If
                End If

                ' Cari CF user untuk mata kuliah 3 (jika ada)
                If judul.MataKuliah3.HasValue Then
                    Dim mk3 As MataKuliah = mataKuliahList.FirstOrDefault(Function(x) x.Id = judul.MataKuliah3.Value)
                    If mk3.TrackBar IsNot Nothing Then
                        Dim cfUser3 As Double = mk3.TrackBar.Value / 100.0
                        If cfUser3 > 0 Then
                            Dim cf As Double = HitungCF(judul.CF3, cfUser3)
                            cfList.Add(cf)
                        End If
                    End If
                End If

                ' Kombinasikan CF jika ada
                If cfList.Count > 0 Then
                    Dim cfAkhir As Double = cfList(0)

                    For i As Integer = 1 To cfList.Count - 1
                        cfAkhir = HitungCFCombine(cfAkhir, cfList(i))
                    Next

                    Dim persentase As Double = cfAkhir * 100
                    hasilList.Add(New Tuple(Of String, String, Double)($"J{judul.Id.ToString("D3")}", judul.Judul, persentase))
                End If
            Next

            ' Urutkan hasil berdasarkan persentase (descending)
            hasilList.Sort(Function(x, y) y.Item3.CompareTo(x.Item3))

            ' Tampilkan hasil di FormHasil
            If hasilList.Count > 0 Then
                Dim formHasil As New FormHasil()
                formHasil.SetHasil(hasilList)
                formHasil.ShowDialog()
            Else
                MessageBox.Show("Tidak ada rekomendasi yang sesuai dengan pilihan Anda." & vbCrLf & "Pastikan mata kuliah yang dipilih sesuai dengan rules yang tersedia.", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If

        Catch ex As Exception
            MessageBox.Show("Error saat memproses data: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub ButtonReset_Click(sender As Object, e As EventArgs)
        ' Reset semua trackbar ke 0
        For Each mk As MataKuliah In mataKuliahList
            If mk.TrackBar IsNot Nothing Then
                mk.TrackBar.Value = 0
            End If
        Next

        MessageBox.Show("Semua input telah direset.", "Reset", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub ButtonRefresh_Click(sender As Object, e As EventArgs)
        Try
            ' Reload data dari database
            LoadMataKuliah()
            LoadRules()

            ' Recreate UI
            CreateDynamicUI()

            MessageBox.Show($"Data berhasil direfresh!" & vbCrLf & vbCrLf &
                          $"Mata Kuliah: {mataKuliahList.Count}" & vbCrLf &
                          $"Rules: {judulList.Count}", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information)

        Catch ex As Exception
            MessageBox.Show("Error saat refresh data: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
End Class


