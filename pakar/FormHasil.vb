Imports System.Drawing.Printing

' ===== FormHasil.vb (Fixed Scrollable Version) =====
Public Class FormHasil
    Private hasilData As List(Of Tuple(Of String, String, Double))
    Private WithEvents printDoc As New PrintDocument()
    Private printContent As String = ""

    Public Sub SetHasil(hasil As List(Of Tuple(Of String, String, Double)))
        hasilData = hasil

        ' Debug: Check if data is received
        If hasilData IsNot Nothing Then
            Console.WriteLine($"SetHasil received {hasilData.Count} items")
            For Each item In hasilData
                Console.WriteLine($"  - {item.Item1}: {item.Item2} ({item.Item3}%)")
            Next
        Else
            Console.WriteLine("SetHasil received NULL data")
        End If

        TampilkanHasil()
    End Sub

    Private Sub FormHasil_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Set properties form
        Me.StartPosition = FormStartPosition.CenterScreen
        Me.WindowState = FormWindowState.Maximized
        Me.Text = "Hasil Rekomendasi Tugas Akhir"
        Me.BackColor = Color.FromArgb(240, 240, 240)

        ' Setup controls jika belum ada
        SetupControls()
    End Sub

    Private Sub SetupControls()
        Me.Controls.Clear()

        ' Button Panel di atas (fixed position)
        Dim panelButton As New Panel()
        panelButton.Dock = DockStyle.Top
        panelButton.Height = 80
        panelButton.BackColor = Color.White
        panelButton.Padding = New Padding(20)
        Me.Controls.Add(panelButton)

        ' Button Print Preview
        Dim btnPrintPreview As New Button()
        btnPrintPreview.Name = "ButtonPrintPreview"
        btnPrintPreview.Text = "PRINT PREVIEW"
        btnPrintPreview.Size = New Size(200, 50)
        btnPrintPreview.Location = New Point(20, 15)
        btnPrintPreview.Font = New Font("Segoe UI", 11, FontStyle.Bold)
        btnPrintPreview.BackColor = Color.FromArgb(33, 150, 243)
        btnPrintPreview.ForeColor = Color.White
        btnPrintPreview.FlatStyle = FlatStyle.Flat
        btnPrintPreview.FlatAppearance.BorderSize = 0
        btnPrintPreview.Cursor = Cursors.Hand
        AddHandler btnPrintPreview.Click, AddressOf ButtonPrintPreview_Click
        panelButton.Controls.Add(btnPrintPreview)

        ' Button Print
        Dim btnPrint As New Button()
        btnPrint.Name = "ButtonPrint"
        btnPrint.Text = "PRINT"
        btnPrint.Size = New Size(150, 50)
        btnPrint.Location = New Point(240, 15)
        btnPrint.Font = New Font("Segoe UI", 11, FontStyle.Bold)
        btnPrint.BackColor = Color.FromArgb(103, 58, 183)
        btnPrint.ForeColor = Color.White
        btnPrint.FlatStyle = FlatStyle.Flat
        btnPrint.FlatAppearance.BorderSize = 0
        btnPrint.Cursor = Cursors.Hand
        AddHandler btnPrint.Click, AddressOf ButtonPrint_Click
        panelButton.Controls.Add(btnPrint)

        ' Button Simpan
        Dim btnSimpan As New Button()
        btnSimpan.Name = "ButtonSimpan"
        btnSimpan.Text = "SIMPAN HASIL"
        btnSimpan.Size = New Size(200, 50)
        btnSimpan.Location = New Point(410, 15)
        btnSimpan.Font = New Font("Segoe UI", 11, FontStyle.Bold)
        btnSimpan.BackColor = Color.FromArgb(76, 175, 80)
        btnSimpan.ForeColor = Color.White
        btnSimpan.FlatStyle = FlatStyle.Flat
        btnSimpan.FlatAppearance.BorderSize = 0
        btnSimpan.Cursor = Cursors.Hand
        AddHandler btnSimpan.Click, AddressOf ButtonSimpan_Click
        panelButton.Controls.Add(btnSimpan)

        ' Button Kembali
        Dim btnKembali As New Button()
        btnKembali.Name = "ButtonKembali"
        btnKembali.Text = "KEMBALI"
        btnKembali.Size = New Size(150, 50)
        btnKembali.Location = New Point(630, 15)
        btnKembali.Font = New Font("Segoe UI", 11, FontStyle.Bold)
        btnKembali.BackColor = Color.FromArgb(255, 87, 34)
        btnKembali.ForeColor = Color.White
        btnKembali.FlatStyle = FlatStyle.Flat
        btnKembali.FlatAppearance.BorderSize = 0
        btnKembali.Cursor = Cursors.Hand
        AddHandler btnKembali.Click, AddressOf ButtonKembali_Click
        panelButton.Controls.Add(btnKembali)

        ' Main Scrollable Panel
        Dim scrollPanel As New Panel()
        scrollPanel.Dock = DockStyle.Fill
        scrollPanel.AutoScroll = True
        scrollPanel.BackColor = Color.FromArgb(240, 240, 240)
        scrollPanel.Padding = New Padding(20)
        Me.Controls.Add(scrollPanel)

        ' Container Panel inside scroll panel (untuk layout vertical)
        Dim contentContainer As New Panel()
        contentContainer.Name = "ContentContainer"
        contentContainer.AutoSize = True
        contentContainer.MinimumSize = New Size(scrollPanel.Width - 40, 0)
        contentContainer.Padding = New Padding(10)
        contentContainer.Location = New Point(0, 0)
        scrollPanel.Controls.Add(contentContainer)

        ' Panel untuk ListBox (Rekomendasi Detail)
        Dim listBoxPanel As New Panel()
        listBoxPanel.Dock = DockStyle.Top
        listBoxPanel.Height = 600
        listBoxPanel.Padding = New Padding(10)
        listBoxPanel.BackColor = Color.Transparent
        contentContainer.Controls.Add(listBoxPanel)

        ' Header untuk ListBox
        Dim lblHeader As New Label()
        lblHeader.Text = "REKOMENDASI TUGAS AKHIR"
        lblHeader.Font = New Font("Segoe UI", 14, FontStyle.Bold)
        lblHeader.Dock = DockStyle.Top
        lblHeader.Height = 40
        lblHeader.TextAlign = ContentAlignment.MiddleLeft
        lblHeader.ForeColor = Color.FromArgb(0, 122, 204)
        lblHeader.BackColor = Color.Transparent
        listBoxPanel.Controls.Add(lblHeader)

        ' ListBox dengan detail rekomendasi
        Dim listBox As New ListBox()
        listBox.Name = "ListBoxHasil"
        listBox.Dock = DockStyle.Fill
        listBox.Font = New Font("Segoe UI", 9)
        listBox.BackColor = Color.White
        listBox.ForeColor = Color.Black ' Explicitly set text color
        listBox.BorderStyle = BorderStyle.FixedSingle
        listBox.IntegralHeight = False ' Allow partial items to show
        listBoxPanel.Controls.Add(listBox)

        ' Spacer
        Dim spacer As New Panel()
        spacer.Dock = DockStyle.Top
        spacer.Height = 20
        spacer.BackColor = Color.Transparent
        contentContainer.Controls.Add(spacer)

        ' Panel untuk Chart dengan PROPER STRUCTURE
        Dim chartOuterPanel As New Panel()
        chartOuterPanel.Dock = DockStyle.Top
        chartOuterPanel.Height = 650 ' Increased height to accommodate header
        chartOuterPanel.BackColor = Color.Transparent
        chartOuterPanel.Padding = New Padding(10)
        contentContainer.Controls.Add(chartOuterPanel)

        ' Header untuk Chart (OUTSIDE the paint panel)
        Dim lblChartHeader As New Label()
        lblChartHeader.Text = "VISUALISASI DATA"
        lblChartHeader.Font = New Font("Segoe UI", 14, FontStyle.Bold)
        lblChartHeader.Dock = DockStyle.Top
        lblChartHeader.Height = 50
        lblChartHeader.TextAlign = ContentAlignment.MiddleLeft
        lblChartHeader.ForeColor = Color.FromArgb(0, 122, 204)
        lblChartHeader.BackColor = Color.Transparent
        chartOuterPanel.Controls.Add(lblChartHeader)

        ' Chart Panel (ONLY for drawing, no header inside)
        Dim chartPanel As New Panel()
        chartPanel.Name = "ChartPanel"
        chartPanel.Dock = DockStyle.Fill
        chartPanel.BackColor = Color.White
        chartPanel.BorderStyle = BorderStyle.FixedSingle
        chartPanel.Padding = New Padding(10)
        AddHandler chartPanel.Paint, AddressOf ChartPanel_Paint
        chartOuterPanel.Controls.Add(chartPanel)

        ' Bottom spacer
        Dim bottomSpacer As New Panel()
        bottomSpacer.Dock = DockStyle.Top
        bottomSpacer.Height = 20
        bottomSpacer.BackColor = Color.Transparent
        contentContainer.Controls.Add(bottomSpacer)
    End Sub

    Private Sub TampilkanHasil()
        ' Cari controls
        Dim listBox As ListBox = CType(Me.Controls.Find("ListBoxHasil", True).FirstOrDefault(), ListBox)
        Dim chartPanel As Panel = CType(Me.Controls.Find("ChartPanel", True).FirstOrDefault(), Panel)

        ' Debug info
        Console.WriteLine($"TampilkanHasil called. ListBox found: {listBox IsNot Nothing}")
        Console.WriteLine($"Chart panel found: {chartPanel IsNot Nothing}")

        If listBox Is Nothing Then
            MessageBox.Show("Error: ListBox tidak ditemukan!", "Debug Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        ' Clear controls
        listBox.Items.Clear()

        If hasilData IsNot Nothing AndAlso hasilData.Count > 0 Then
            Console.WriteLine($"Displaying {hasilData.Count} results")

            ' Ambil rekomendasi terbaik
            Dim terbaik As Tuple(Of String, String, Double) = hasilData(0)

            ' Tampilkan detail rekomendasi terbaik di ListBox
            listBox.Items.Add("╔════════════════════════════════════════════════════╗")
            listBox.Items.Add("║          REKOMENDASI TERBAIK UNTUK ANDA            ║")
            listBox.Items.Add("╚════════════════════════════════════════════════════╝")
            listBox.Items.Add("")
            listBox.Items.Add($"Kode Judul   : {terbaik.Item1}")
            listBox.Items.Add("")
            listBox.Items.Add("Judul        :")

            ' Split judul jika terlalu panjang
            Dim words As String() = terbaik.Item2.Split(" "c)
            Dim currentLine As String = ""
            For Each word As String In words
                If (currentLine & " " & word).Length > 50 Then
                    listBox.Items.Add("  " & currentLine.Trim())
                    currentLine = word
                Else
                    currentLine &= " " & word
                End If
            Next
            If currentLine.Length > 0 Then
                listBox.Items.Add("  " & currentLine.Trim())
            End If

            listBox.Items.Add("")
            listBox.Items.Add($"Tingkat Kepercayaan : {terbaik.Item3.ToString("0.00")}%")
            listBox.Items.Add("")
            listBox.Items.Add("─────────────────────────────────────────────────────")
            listBox.Items.Add("")
            listBox.Items.Add("KESIMPULAN:")
            listBox.Items.Add("Judul ini merupakan rekomendasi terbaik berdasarkan")
            listBox.Items.Add("tingkat kepercayaan dan minat Anda terhadap mata")
            listBox.Items.Add("kuliah yang dipilih. Sistem pakar memberikan nilai")
            listBox.Items.Add($"kepercayaan {terbaik.Item3.ToString("0.00")}% yang menunjukkan bahwa")
            listBox.Items.Add("judul ini sangat sesuai dengan kemampuan dan minat")
            listBox.Items.Add("Anda.")
            listBox.Items.Add("")
            listBox.Items.Add(GetRekomendasiTambahan(terbaik.Item3))
            listBox.Items.Add("")
            listBox.Items.Add("═══════════════════════════════════════════════════")
            listBox.Items.Add("")
            listBox.Items.Add("SEMUA REKOMENDASI:")
            listBox.Items.Add("")

            ' Tampilkan semua rekomendasi
            For i As Integer = 0 To hasilData.Count - 1
                Dim item As Tuple(Of String, String, Double) = hasilData(i)
                listBox.Items.Add($"┌─ Peringkat {i + 1} ─────────────────────────────────")
                listBox.Items.Add($"│ Kode        : {item.Item1}")
                listBox.Items.Add($"│ Kepercayaan : {item.Item3.ToString("0.00")}%")
                listBox.Items.Add($"│ Status      : {GetStatusRekomendasi(item.Item3)}")
                listBox.Items.Add("└──────────────────────────────────────────────────")
                listBox.Items.Add("")
            Next

            Console.WriteLine($"Added {listBox.Items.Count} items to ListBox")

            ' Force refresh
            listBox.Refresh()

            ' Refresh chart
            If chartPanel IsNot Nothing Then
                chartPanel.Invalidate()
                chartPanel.Refresh()
            End If

            ' Prepare print content
            PreparePrintContent()
        Else
            Console.WriteLine("No data to display!")
            listBox.Items.Add("Tidak ada data untuk ditampilkan.")
            listBox.Items.Add("")
            listBox.Items.Add("Silakan kembali ke form utama dan coba lagi.")
        End If
    End Sub

    Private Sub ChartPanel_Paint(sender As Object, e As PaintEventArgs)
        If hasilData Is Nothing OrElse hasilData.Count = 0 Then Return

        Dim g As Graphics = e.Graphics
        g.SmoothingMode = Drawing2D.SmoothingMode.AntiAlias
        g.Clear(Color.White)

        Dim panel As Panel = CType(sender, Panel)
        Dim centerX As Integer = panel.Width \ 2
        Dim centerY As Integer = (panel.Height \ 2) + 20 ' Adjusted for better centering
        Dim radius As Integer = Math.Min(panel.Width - 100, panel.Height - 150) \ 3

        ' Ambil top 5 atau semua data jika kurang dari 5
        Dim topData As List(Of Tuple(Of String, String, Double)) = hasilData.Take(Math.Min(5, hasilData.Count)).ToList()

        ' Hitung total untuk percentage
        Dim total As Double = topData.Sum(Function(x) x.Item3)

        ' Warna untuk setiap slice
        Dim colors As Color() = {
            Color.FromArgb(33, 150, 243),
            Color.FromArgb(76, 175, 80),
            Color.FromArgb(255, 193, 7),
            Color.FromArgb(255, 87, 34),
            Color.FromArgb(156, 39, 176)
        }

        ' Title untuk chart (inside paint area)
        Using titleFont As New Font("Segoe UI", 12, FontStyle.Bold)
            Dim titleText As String = "Top " & topData.Count.ToString() & " Rekomendasi"
            Dim titleSize As SizeF = g.MeasureString(titleText, titleFont)
            g.DrawString(titleText, titleFont, Brushes.Black, (panel.Width - titleSize.Width) / 2, 10)
        End Using

        ' Gambar Pie Chart
        Dim startAngle As Single = 0

        For i As Integer = 0 To topData.Count - 1
            Dim item As Tuple(Of String, String, Double) = topData(i)
            Dim sweepAngle As Single = CSng((item.Item3 / total) * 360)

            ' Gambar slice
            Using brush As New SolidBrush(colors(i Mod colors.Length))
                g.FillPie(brush, centerX - radius, centerY - radius, radius * 2, radius * 2, startAngle, sweepAngle)
            End Using

            ' Gambar border slice
            g.DrawPie(Pens.White, centerX - radius, centerY - radius, radius * 2, radius * 2, startAngle, sweepAngle)

            startAngle += sweepAngle
        Next

        ' Gambar legend
        Dim legendY As Integer = centerY + radius + 30
        Dim legendX As Integer = 50

        Using legendFont As New Font("Segoe UI", 9)
            For i As Integer = 0 To topData.Count - 1
                Dim item As Tuple(Of String, String, Double) = topData(i)

                ' Color box
                Using brush As New SolidBrush(colors(i Mod colors.Length))
                    g.FillRectangle(brush, legendX, legendY, 20, 20)
                End Using
                g.DrawRectangle(Pens.Black, legendX, legendY, 20, 20)

                ' Text
                Dim legendText As String = $"{item.Item1}: {item.Item3.ToString("0.00")}%"
                g.DrawString(legendText, legendFont, Brushes.Black, legendX + 30, legendY + 2)

                legendY += 30

                ' Jika legend terlalu panjang, pindah ke kolom berikutnya
                If legendY > panel.Height - 80 Then
                    legendY = centerY + radius + 30
                    legendX += 300
                End If
            Next
        End Using

        ' Gambar info tambahan
        Using infoFont As New Font("Segoe UI", 8, FontStyle.Italic)
            Dim infoText As String = $"Total Rekomendasi: {hasilData.Count}"
            g.DrawString(infoText, infoFont, Brushes.Gray, 10, panel.Height - 25)
        End Using
    End Sub

    Private Sub PreparePrintContent()
        printContent = ""
        printContent &= "═══════════════════════════════════════════════════════════════" & vbCrLf
        printContent &= "       HASIL REKOMENDASI JUDUL TUGAS AKHIR MAHASISWA" & vbCrLf
        printContent &= "         SISTEM PAKAR METODE CERTAINTY FACTOR" & vbCrLf
        printContent &= "═══════════════════════════════════════════════════════════════" & vbCrLf
        printContent &= "Tanggal: " & DateTime.Now.ToString("dd MMMM yyyy HH:mm:ss") & vbCrLf
        printContent &= vbCrLf

        If hasilData IsNot Nothing AndAlso hasilData.Count > 0 Then
            Dim terbaik As Tuple(Of String, String, Double) = hasilData(0)

            printContent &= "╔════════════════════════════════════════════════════╗" & vbCrLf
            printContent &= "║          REKOMENDASI TERBAIK UNTUK ANDA            ║" & vbCrLf
            printContent &= "╚════════════════════════════════════════════════════╝" & vbCrLf & vbCrLf
            printContent &= $"Kode Judul   : {terbaik.Item1}" & vbCrLf & vbCrLf
            printContent &= $"Judul        : {terbaik.Item2}" & vbCrLf & vbCrLf
            printContent &= $"Tingkat Kepercayaan : {terbaik.Item3.ToString("0.00")}%" & vbCrLf & vbCrLf
            printContent &= "─────────────────────────────────────────────────────" & vbCrLf & vbCrLf
            printContent &= "KESIMPULAN:" & vbCrLf
            printContent &= "Judul ini merupakan rekomendasi terbaik berdasarkan tingkat" & vbCrLf
            printContent &= "kepercayaan dan minat Anda terhadap mata kuliah yang dipilih." & vbCrLf
            printContent &= $"Sistem pakar memberikan nilai kepercayaan {terbaik.Item3.ToString("0.00")}% yang" & vbCrLf
            printContent &= "menunjukkan bahwa judul ini sangat sesuai dengan kemampuan" & vbCrLf
            printContent &= "dan minat Anda." & vbCrLf & vbCrLf
            printContent &= GetRekomendasiTambahan(terbaik.Item3) & vbCrLf & vbCrLf
            printContent &= "═══════════════════════════════════════════════════════════════" & vbCrLf & vbCrLf
            printContent &= "SEMUA REKOMENDASI:" & vbCrLf & vbCrLf

            For i As Integer = 0 To hasilData.Count - 1
                Dim item As Tuple(Of String, String, Double) = hasilData(i)
                printContent &= $"Peringkat {i + 1}" & vbCrLf
                printContent &= $"Kode        : {item.Item1}" & vbCrLf
                printContent &= $"Judul       : {item.Item2}" & vbCrLf
                printContent &= $"Kepercayaan : {item.Item3.ToString("0.00")}%" & vbCrLf
                printContent &= $"Status      : {GetStatusRekomendasi(item.Item3)}" & vbCrLf
                printContent &= "───────────────────────────────────────────────────────────" & vbCrLf
                printContent &= vbCrLf
            Next
        End If
    End Sub

    Private Sub PrintDoc_PrintPage(sender As Object, e As PrintPageEventArgs) Handles printDoc.PrintPage
        Dim font As New Font("Courier New", 10)
        Dim brush As New SolidBrush(Color.Black)
        Dim leftMargin As Single = e.MarginBounds.Left
        Dim topMargin As Single = e.MarginBounds.Top
        Dim yPos As Single = topMargin

        ' Split content by lines
        Dim lines As String() = printContent.Split(New String() {vbCrLf}, StringSplitOptions.None)

        For Each line As String In lines
            e.Graphics.DrawString(line, font, brush, leftMargin, yPos)
            yPos += font.GetHeight(e.Graphics)

            ' Check if we need a new page
            If yPos >= e.MarginBounds.Bottom Then
                e.HasMorePages = True
                Exit For
            End If
        Next

        ' Cleanup
        font.Dispose()
        brush.Dispose()
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
            Return "SARAN: Judul ini sangat cocok untuk Anda! Segera konsultasikan dengan dosen pembimbing untuk memulai penelitian."
        ElseIf persentase >= 60 Then
            Return "SARAN: Judul ini cukup sesuai dengan minat Anda. Diskusikan lebih lanjut dengan dosen pembimbing untuk menyempurnakan topik."
        ElseIf persentase >= 40 Then
            Return "SARAN: Pertimbangkan untuk memilih mata kuliah dengan tingkat kepercayaan yang lebih tinggi untuk mendapatkan rekomendasi yang lebih baik."
        Else
            Return "SARAN: Tingkatkan kepercayaan Anda pada mata kuliah terkait atau pertimbangkan topik lain yang lebih sesuai dengan kemampuan Anda."
        End If
    End Function

    Private Sub ButtonPrintPreview_Click(sender As Object, e As EventArgs)
        Try
            Dim printPreviewDialog As New PrintPreviewDialog()
            printPreviewDialog.Document = printDoc
            printPreviewDialog.Width = 800
            printPreviewDialog.Height = 600
            printPreviewDialog.ShowDialog()
        Catch ex As Exception
            MessageBox.Show("Error saat menampilkan print preview: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub ButtonPrint_Click(sender As Object, e As EventArgs)
        Try
            Dim printDialog As New PrintDialog()
            printDialog.Document = printDoc

            If printDialog.ShowDialog() = DialogResult.OK Then
                printDoc.Print()
                MessageBox.Show("Dokumen berhasil dicetak!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Catch ex As Exception
            MessageBox.Show("Error saat mencetak: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub ButtonSimpan_Click(sender As Object, e As EventArgs)
        Dim saveDialog As New SaveFileDialog()
        saveDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*"
        saveDialog.Title = "Simpan Hasil Rekomendasi"
        saveDialog.FileName = "Hasil_Rekomendasi_" & DateTime.Now.ToString("yyyyMMdd_HHmmss") & ".txt"

        If saveDialog.ShowDialog() = DialogResult.OK Then
            Try
                System.IO.File.WriteAllText(saveDialog.FileName, printContent)
                MessageBox.Show("Hasil rekomendasi berhasil disimpan!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Catch ex As Exception
                MessageBox.Show("Gagal menyimpan file: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If
    End Sub

    Private Sub ButtonKembali_Click(sender As Object, e As EventArgs)
        Me.Close()
    End Sub
End Class