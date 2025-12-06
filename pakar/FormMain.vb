' ===== FormMain.vb =====
Public Class FormMain
    ' Struktur data untuk menyimpan informasi judul
    Structure JudulTugasAkhir
        Dim Kode As String
        Dim Nama As String
        Dim MataKuliah As List(Of String)
        Dim CFPakar As List(Of Double)
    End Structure

    ' Dictionary untuk menyimpan data judul
    Private judulList As New List(Of JudulTugasAkhir)

    ' Array nama mata kuliah sesuai dengan trackbar
    Private namaMK() As String = {
        "MK01 - Teori Automata",
        "MK02 - AR and VR",
        "MK03 - Mobile Programming",
        "MK04 - Sistem Pendukung Keputusan",
        "MK05 - Database",
        "MK06 - Web Programming",
        "MK07 - Data Mining",
        "MK08 - Data Science",
        "MK09 - Analisis Data",
        "MK10 - Sistem Pakar",
        "MK11 - Manajemen Software",
        "MK12 - Big Data",
        "MK13 - Sistem Otomasi",
        "MK14 - IoT",
        "MK15 - Artificial Intelligence",
        "MK16 - Pengolahan Citra",
        "MK17 - Robotik",
        "MK18 - Jaringan Komputer"
    }

    Private Sub FormMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Inisialisasi trackbar
        InitializeTrackbars()

        ' Load data judul tugas akhir
        LoadDataJudul()

        ' Setup UI
        SetupUI()
    End Sub

    Private Sub InitializeTrackbars()
        ' Setup 18 trackbar dengan nilai 0-100 (akan dikonversi ke 0-1)
        Dim trackbars() As TrackBar = {TrackBar1, TrackBar2, TrackBar3, TrackBar4, TrackBar5,
                                       TrackBar6, TrackBar7, TrackBar8, TrackBar9, TrackBar10,
                                       TrackBar11, TrackBar12, TrackBar13, TrackBar14, TrackBar15,
                                       TrackBar16, TrackBar17, TrackBar18}

        For i As Integer = 0 To trackbars.Length - 1
            trackbars(i).Minimum = 0
            trackbars(i).Maximum = 100
            trackbars(i).Value = 0
            trackbars(i).TickFrequency = 10

            ' Add event handler untuk update label
            AddHandler trackbars(i).ValueChanged, AddressOf TrackBar_ValueChanged
        Next
    End Sub

    Private Sub SetupUI()
        ' Setup label untuk trackbar
        UpdateAllLabels()
    End Sub

    Private Sub LoadDataJudul()
        judulList.Clear()

        ' J01
        Dim j01 As New JudulTugasAkhir With {
            .Kode = "J01",
            .Nama = "Rancang Bangun Game 2D Shooter Platformer Menggunakan Metode Finite State Machine",
            .MataKuliah = New List(Of String) From {"MK01", "MK02", "MK03"},
            .CFPakar = New List(Of Double) From {0.9, 0.8, 0.4}
        }
        judulList.Add(j01)

        ' J02
        Dim j02 As New JudulTugasAkhir With {
            .Kode = "J02",
            .Nama = "Sistem Informasi Inventory Menggunakan Framework Bootstrap",
            .MataKuliah = New List(Of String) From {"MK04", "MK05", "MK06"},
            .CFPakar = New List(Of Double) From {0.9, 0.8, 0.5}
        }
        judulList.Add(j02)

        ' J03
        Dim j03 As New JudulTugasAkhir With {
            .Kode = "J03",
            .Nama = "Prediksi Permintaan Mata Kuliah Pada Semester Padat Dengan Menggunakan Teknik Association Rule Dengan Algoritma Apriori",
            .MataKuliah = New List(Of String) From {"MK07", "MK08", "MK09"},
            .CFPakar = New List(Of Double) From {0.8, 0.6, 0.9}
        }
        judulList.Add(j03)

        ' J04
        Dim j04 As New JudulTugasAkhir With {
            .Kode = "J04",
            .Nama = "Analisis Perbandingan Framework CodeIgniter Dan Framework Laravel",
            .MataKuliah = New List(Of String) From {"MK06", "MK09", "MK11"},
            .CFPakar = New List(Of Double) From {0.8, 0.3, 0.5}
        }
        judulList.Add(j04)

        ' J05
        Dim j05 As New JudulTugasAkhir With {
            .Kode = "J05",
            .Nama = "Sistem Pakar Diagnosa Penyakit Pencernaan Pada Manusia Menggunakan Metode Certainty Factor Berbasis Web",
            .MataKuliah = New List(Of String) From {"MK10", "MK06", "MK09"},
            .CFPakar = New List(Of Double) From {1.0, 0.8, 0.6}
        }
        judulList.Add(j05)

        ' J06
        Dim j06 As New JudulTugasAkhir With {
            .Kode = "J06",
            .Nama = "Klasifikasi Topik Berita Dan Analisis Sentimen Pada Tweets Divisi Humas Polri Dengan Metode Naïve Bayes Classifier",
            .MataKuliah = New List(Of String) From {"MK07", "MK09", "MK12"},
            .CFPakar = New List(Of Double) From {0.9, 0.8, 0.5}
        }
        judulList.Add(j06)

        ' J07
        Dim j07 As New JudulTugasAkhir With {
            .Kode = "J07",
            .Nama = "Group Decision Support System (GDSS) untuk Pemilihan Konsentrasi Studi Mahasiswa Menggunakan AHP dan TOPSIS",
            .MataKuliah = New List(Of String) From {"MK04", "MK07", "MK11"},
            .CFPakar = New List(Of Double) From {1.0, 0.8, 0.2}
        }
        judulList.Add(j07)

        ' J08
        Dim j08 As New JudulTugasAkhir With {
            .Kode = "J08",
            .Nama = "Sistem Monitoring Keadaan Ruang Laboratorium Berbasis IoT",
            .MataKuliah = New List(Of String) From {"MK13", "MK03", "MK14"},
            .CFPakar = New List(Of Double) From {1.0, 0.8, 0.8}
        }
        judulList.Add(j08)

        ' J09
        Dim j09 As New JudulTugasAkhir With {
            .Kode = "J09",
            .Nama = "Penerapan Metode Jaringan Syaraf Tiruan Pada Sistem Deteksi Citra Darah Manusia",
            .MataKuliah = New List(Of String) From {"MK15", "MK16", "MK09"},
            .CFPakar = New List(Of Double) From {0.8, 1.0, 0.6}
        }
        judulList.Add(j09)

        ' J10
        Dim j10 As New JudulTugasAkhir With {
            .Kode = "J10",
            .Nama = "Aplikasi Manajemen Central Rental Mobil Menggunakan Framework CodeIgniter",
            .MataKuliah = New List(Of String) From {"MK06", "MK11", "MK05"},
            .CFPakar = New List(Of Double) From {1.0, 0.6, 0.4}
        }
        judulList.Add(j10)

        ' J11
        Dim j11 As New JudulTugasAkhir With {
            .Kode = "J11",
            .Nama = "Otomatisasi Penyiram Dan Pencahayaan Tanaman Buah Naga Berbasis Arduino Uno",
            .MataKuliah = New List(Of String) From {"MK14", "MK13", "MK17"},
            .CFPakar = New List(Of Double) From {0.9, 0.9, 0.4}
        }
        judulList.Add(j11)

        ' J12
        Dim j12 As New JudulTugasAkhir With {
            .Kode = "J12",
            .Nama = "Aplikasi Augmented Reality Pada Pemasaran Perumahan Berbasis Android",
            .MataKuliah = New List(Of String) From {"MK02", "MK03", "MK11"},
            .CFPakar = New List(Of Double) From {0.9, 0.8, 0.6}
        }
        judulList.Add(j12)

        ' J13
        Dim j13 As New JudulTugasAkhir With {
            .Kode = "J13",
            .Nama = "Perancangan Dan Penerapan Aplikasi Kasir Dengan Menggunakan Bahasa Pemrograman PHP Dan MySQL",
            .MataKuliah = New List(Of String) From {"MK05", "MK11", "MK06"},
            .CFPakar = New List(Of Double) From {0.8, 0.6, 1.0}
        }
        judulList.Add(j13)

        ' J14
        Dim j14 As New JudulTugasAkhir With {
            .Kode = "J14",
            .Nama = "Implementasi Metode Fuzzy Logic Untuk Sistem Pengukuran Kualitas Udara Di Kota Medan Berbasis IoT",
            .MataKuliah = New List(Of String) From {"MK14", "MK09", "MK15"},
            .CFPakar = New List(Of Double) From {1.0, 0.4, 0.2}
        }
        judulList.Add(j14)

        ' J15
        Dim j15 As New JudulTugasAkhir With {
            .Kode = "J15",
            .Nama = "Rancang Bangun Sistem Enkripsi Pengiriman Informasi Menggunakan Algoritma Kriptografi Klasik",
            .MataKuliah = New List(Of String) From {"MK18", "MK16", "MK09"},
            .CFPakar = New List(Of Double) From {0.8, 0.9, 0.4}
        }
        judulList.Add(j15)
    End Sub

    Private Sub TrackBar_ValueChanged(sender As Object, e As EventArgs)
        UpdateAllLabels()
    End Sub

    Private Sub UpdateAllLabels()
        ' Update label untuk setiap trackbar
        Label1.Text = GetKepercayaanText(TrackBar1.Value)
        Label2.Text = GetKepercayaanText(TrackBar2.Value)
        Label3.Text = GetKepercayaanText(TrackBar3.Value)
        Label4.Text = GetKepercayaanText(TrackBar4.Value)
        Label5.Text = GetKepercayaanText(TrackBar5.Value)
        Label6.Text = GetKepercayaanText(TrackBar6.Value)
        Label7.Text = GetKepercayaanText(TrackBar7.Value)
        Label8.Text = GetKepercayaanText(TrackBar8.Value)
        Label9.Text = GetKepercayaanText(TrackBar9.Value)
        Label10.Text = GetKepercayaanText(TrackBar10.Value)
        Label11.Text = GetKepercayaanText(TrackBar11.Value)
        Label12.Text = GetKepercayaanText(TrackBar12.Value)
        Label13.Text = GetKepercayaanText(TrackBar13.Value)
        Label14.Text = GetKepercayaanText(TrackBar14.Value)
        Label15.Text = GetKepercayaanText(TrackBar15.Value)
        Label16.Text = GetKepercayaanText(TrackBar16.Value)
        Label17.Text = GetKepercayaanText(TrackBar17.Value)
        Label18.Text = GetKepercayaanText(TrackBar18.Value)
    End Sub

    Private Function GetKepercayaanText(nilai As Integer) As String
        Dim cf As Double = nilai / 100.0

        If cf = 0 Then
            Return "Tidak Dipilih (0)"
        ElseIf cf <= 0.1 Then
            Return "Kurang Yakin (" & cf.ToString("0.00") & ")"
        ElseIf cf <= 0.25 Then
            Return "Agak Yakin (" & cf.ToString("0.00") & ")"
        ElseIf cf <= 0.5 Then
            Return "Cukup Yakin (" & cf.ToString("0.00") & ")"
        ElseIf cf <= 0.7 Then
            Return "Yakin (" & cf.ToString("0.00") & ")"
        Else
            Return "Sangat Yakin (" & cf.ToString("0.00") & ")"
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

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ' Validasi input - pastikan ada minimal 1 mata kuliah yang dipilih
        Dim adaPilihan As Boolean = False
        For i As Integer = 1 To 18
            Dim tb As TrackBar = CType(Me.Controls("TrackBar" & i.ToString()), TrackBar)
            If tb.Value > 0 Then
                adaPilihan = True
                Exit For
            End If
        Next

        If Not adaPilihan Then
            MessageBox.Show("Silakan pilih minimal satu mata kuliah dengan mengatur trackbar!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        ' Ambil nilai CF dari trackbar (konversi ke 0-1)
        Dim cfUser(17) As Double
        cfUser(0) = TrackBar1.Value / 100.0
        cfUser(1) = TrackBar2.Value / 100.0
        cfUser(2) = TrackBar3.Value / 100.0
        cfUser(3) = TrackBar4.Value / 100.0
        cfUser(4) = TrackBar5.Value / 100.0
        cfUser(5) = TrackBar6.Value / 100.0
        cfUser(6) = TrackBar7.Value / 100.0
        cfUser(7) = TrackBar8.Value / 100.0
        cfUser(8) = TrackBar9.Value / 100.0
        cfUser(9) = TrackBar10.Value / 100.0
        cfUser(10) = TrackBar11.Value / 100.0
        cfUser(11) = TrackBar12.Value / 100.0
        cfUser(12) = TrackBar13.Value / 100.0
        cfUser(13) = TrackBar14.Value / 100.0
        cfUser(14) = TrackBar15.Value / 100.0
        cfUser(15) = TrackBar16.Value / 100.0
        cfUser(16) = TrackBar17.Value / 100.0
        cfUser(17) = TrackBar18.Value / 100.0

        ' List untuk menyimpan hasil perhitungan
        Dim hasilList As New List(Of Tuple(Of String, String, Double))

        ' Hitung CF untuk setiap judul
        For Each judul As JudulTugasAkhir In judulList
            Dim cfList As New List(Of Double)

            ' Hitung CF untuk setiap mata kuliah yang relevan
            For i As Integer = 0 To judul.MataKuliah.Count - 1
                Dim mkIndex As Integer = Integer.Parse(judul.MataKuliah(i).Substring(2)) - 1
                Dim cfPakar As Double = judul.CFPakar(i)
                Dim cfUserMK As Double = cfUser(mkIndex)

                ' Hanya hitung jika user memberikan nilai > 0
                If cfUserMK > 0 Then
                    Dim cf As Double = HitungCF(cfPakar, cfUserMK)
                    cfList.Add(cf)
                End If
            Next

            ' Kombinasikan CF jika ada
            If cfList.Count > 0 Then
                Dim cfAkhir As Double = cfList(0)

                For i As Integer = 1 To cfList.Count - 1
                    cfAkhir = HitungCFCombine(cfAkhir, cfList(i))
                Next

                Dim persentase As Double = cfAkhir * 100
                hasilList.Add(New Tuple(Of String, String, Double)(judul.Kode, judul.Nama, persentase))
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
            MessageBox.Show("Tidak ada rekomendasi yang sesuai dengan pilihan Anda.", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If

        TrackBar1.Value = 0
        TrackBar2.Value = 0
        TrackBar3.Value = 0
        TrackBar4.Value = 0
        TrackBar5.Value = 0
        TrackBar6.Value = 0
        TrackBar7.Value = 0
        TrackBar8.Value = 0
        TrackBar9.Value = 0
        TrackBar10.Value = 0
        TrackBar11.Value = 0
        TrackBar12.Value = 0
        TrackBar13.Value = 0
        TrackBar14.Value = 0
        TrackBar15.Value = 0
        TrackBar16.Value = 0
        TrackBar17.Value = 0
        TrackBar18.Value = 0
    End Sub
End Class


