Imports System.Drawing.Printing

' ===== FormHasil.vb (Enhanced & Bug Fixed) =====
Public Class FormHasil
    Private hasilData As List(Of Tuple(Of String, String, Double))
    Private WithEvents printDoc As New PrintDocument()
    Private printContent As String = ""
    Private currentPrintLine As Integer = 0
    Private printLines As String() = Nothing

    Public Sub SetHasil(hasil As List(Of Tuple(Of String, String, Double)))
        hasilData = hasil
        If Me.IsHandleCreated Then
            TampilkanHasil()
        End If
    End Sub

    Private Sub FormHasil_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.StartPosition = FormStartPosition.CenterScreen
        Me.WindowState = FormWindowState.Maximized
        Me.Text = "Hasil Rekomendasi Tugas Akhir"
        Me.BackColor = Color.FromArgb(246, 248, 252)

        SetupControls()

        If hasilData IsNot Nothing Then
            TampilkanHasil()
        End If
    End Sub

    Private Sub SetupControls()
        Me.Controls.Clear()

        ' Main Card Panel
        Dim cardPanel As New Panel()
        cardPanel.Name = "PanelCard"
        cardPanel.BackColor = Color.White
        cardPanel.Location = New Point(40, 40)
        cardPanel.Size = New Size(Me.ClientSize.Width - 80, Me.ClientSize.Height - 80)
        cardPanel.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        Me.Controls.Add(cardPanel)

        ' Header Strip
        Dim headerStrip As New Panel()
        headerStrip.BackColor = Color.FromArgb(65, 105, 225)
        headerStrip.Dock = DockStyle.Top
        headerStrip.Height = 5
        cardPanel.Controls.Add(headerStrip)

        ' Title
        Dim lblTitle As New Label()
        lblTitle.Text = "Hasil Rekomendasi Tugas Akhir"
        lblTitle.Font = New Font("Segoe UI", 20, FontStyle.Bold)
        lblTitle.ForeColor = Color.FromArgb(44, 62, 80)
        lblTitle.Location = New Point(30, 20)
        lblTitle.AutoSize = True
        cardPanel.Controls.Add(lblTitle)

        ' Subtitle
        Dim lblSubtitle As New Label()
        lblSubtitle.Text = "Sistem Pakar Metode Certainty Factor"
        lblSubtitle.Font = New Font("Segoe UI", 10, FontStyle.Regular)
        lblSubtitle.ForeColor = Color.Gray
        lblSubtitle.Location = New Point(30, 60)
        lblSubtitle.AutoSize = True
        cardPanel.Controls.Add(lblSubtitle)

        ' === LEFT SECTION: Best Recommendation ===
        Dim lblBestHeader As New Label()
        lblBestHeader.Text = "REKOMENDASI TERBAIK"
        lblBestHeader.Font = New Font("Segoe UI", 9, FontStyle.Bold)
        lblBestHeader.ForeColor = Color.SlateGray
        lblBestHeader.Location = New Point(30, 100)
        lblBestHeader.AutoSize = True
        cardPanel.Controls.Add(lblBestHeader)

        Dim txtBest As New TextBox()
        txtBest.Name = "TextBoxBest"
        txtBest.Multiline = True
        txtBest.ScrollBars = ScrollBars.Vertical
        txtBest.ReadOnly = True
        txtBest.Font = New Font("Consolas", 9, FontStyle.Regular)
        txtBest.BackColor = Color.FromArgb(250, 250, 250)
        txtBest.ForeColor = Color.FromArgb(44, 62, 80)
        txtBest.BorderStyle = BorderStyle.FixedSingle
        txtBest.Location = New Point(30, 125)
        txtBest.Size = New Size(380, 250)
        txtBest.Anchor = AnchorStyles.Top Or AnchorStyles.Left
        cardPanel.Controls.Add(txtBest)

        ' === RIGHT SECTION: Chart ===
        Dim lblChartHeader As New Label()
        lblChartHeader.Text = "VISUALISASI TOP 5 REKOMENDASI"
        lblChartHeader.Font = New Font("Segoe UI", 9, FontStyle.Bold)
        lblChartHeader.ForeColor = Color.SlateGray
        lblChartHeader.Location = New Point(430, 100)
        lblChartHeader.AutoSize = True
        cardPanel.Controls.Add(lblChartHeader)

        ' Chart Container with scrollbar
        Dim chartContainer As New Panel()
        chartContainer.Name = "ChartContainer"
        chartContainer.Location = New Point(430, 125)
        chartContainer.Size = New Size(cardPanel.Width - 460, 250)
        chartContainer.BorderStyle = BorderStyle.FixedSingle
        chartContainer.AutoScroll = True
        chartContainer.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        cardPanel.Controls.Add(chartContainer)

        ' Chart Panel inside container
        Dim chartPanel As New Panel()
        chartPanel.Name = "ChartPanel"
        chartPanel.BackColor = Color.White
        chartPanel.Location = New Point(0, 0)
        chartPanel.Size = New Size(chartContainer.Width - 20, 450) ' Taller to accommodate legend
        AddHandler chartPanel.Paint, AddressOf ChartPanel_Paint
        chartContainer.Controls.Add(chartPanel)

        ' === BOTTOM SECTION: All Results ListBox ===
        Dim lblAllHeader As New Label()
        lblAllHeader.Text = "SEMUA HASIL REKOMENDASI"
        lblAllHeader.Font = New Font("Segoe UI", 9, FontStyle.Bold)
        lblAllHeader.ForeColor = Color.SlateGray
        lblAllHeader.Location = New Point(30, 390)
        lblAllHeader.AutoSize = True
        cardPanel.Controls.Add(lblAllHeader)

        Dim listBoxAll As New ListBox()
        listBoxAll.Name = "ListBoxHasil"
        listBoxAll.Font = New Font("Consolas", 9)
        listBoxAll.BackColor = Color.FromArgb(250, 250, 250)
        listBoxAll.ForeColor = Color.FromArgb(44, 62, 80)
        listBoxAll.BorderStyle = BorderStyle.FixedSingle
        listBoxAll.Location = New Point(30, 415)
        listBoxAll.Size = New Size(cardPanel.Width - 60, 150)
        listBoxAll.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        cardPanel.Controls.Add(listBoxAll)

        ' === BUTTONS ===
        Dim buttonY As Integer = cardPanel.Height - 60

        ' Button Print Preview
        Dim btnPrintPreview As New Button()
        btnPrintPreview.Name = "ButtonPrintPreview"
        btnPrintPreview.Text = "Print Preview"
        btnPrintPreview.Size = New Size(150, 40)
        btnPrintPreview.Location = New Point(30, buttonY)
        btnPrintPreview.Font = New Font("Segoe UI", 10, FontStyle.Bold)
        btnPrintPreview.BackColor = Color.FromArgb(33, 150, 243)
        btnPrintPreview.ForeColor = Color.White
        btnPrintPreview.FlatStyle = FlatStyle.Flat
        btnPrintPreview.FlatAppearance.BorderSize = 0
        btnPrintPreview.Cursor = Cursors.Hand
        btnPrintPreview.Anchor = AnchorStyles.Bottom Or AnchorStyles.Left
        AddHandler btnPrintPreview.Click, AddressOf ButtonPrintPreview_Click
        cardPanel.Controls.Add(btnPrintPreview)

        ' Button Save
        Dim btnSave As New Button()
        btnSave.Name = "ButtonSave"
        btnSave.Text = "Simpan ke File"
        btnSave.Size = New Size(150, 40)
        btnSave.Location = New Point(200, buttonY)
        btnSave.Font = New Font("Segoe UI", 10, FontStyle.Bold)
        btnSave.BackColor = Color.FromArgb(76, 175, 80)
        btnSave.ForeColor = Color.White
        btnSave.FlatStyle = FlatStyle.Flat
        btnSave.FlatAppearance.BorderSize = 0
        btnSave.Cursor = Cursors.Hand
        btnSave.Anchor = AnchorStyles.Bottom Or AnchorStyles.Left
        AddHandler btnSave.Click, AddressOf ButtonSave_Click
        cardPanel.Controls.Add(btnSave)

        ' Button Close
        Dim btnClose As New Button()
        btnClose.Name = "ButtonClose"
        btnClose.Text = "Tutup"
        btnClose.Size = New Size(120, 40)
        btnClose.Location = New Point(cardPanel.Width - 150, buttonY)
        btnClose.Font = New Font("Segoe UI", 10, FontStyle.Bold)
        btnClose.BackColor = Color.FromArgb(244, 67, 54)
        btnClose.ForeColor = Color.White
        btnClose.FlatStyle = FlatStyle.Flat
        btnClose.FlatAppearance.BorderSize = 0
        btnClose.Cursor = Cursors.Hand
        btnClose.Anchor = AnchorStyles.Bottom Or AnchorStyles.Right
        AddHandler btnClose.Click, AddressOf ButtonClose_Click
        cardPanel.Controls.Add(btnClose)
    End Sub

    Private Sub TampilkanHasil()
        If hasilData Is Nothing OrElse hasilData.Count = 0 Then Return

        ' Best Recommendation TextBox
        Dim txtBest As TextBox = CType(Me.Controls.Find("TextBoxBest", True).FirstOrDefault(), TextBox)
        If txtBest IsNot Nothing Then
            Dim terbaik As Tuple(Of String, String, Double) = hasilData(0)
            txtBest.Clear()
            txtBest.AppendText("╔══════════════════════════════════════════╗" & vbCrLf)
            txtBest.AppendText("║     REKOMENDASI TERBAIK UNTUK ANDA       ║" & vbCrLf)
            txtBest.AppendText("╚══════════════════════════════════════════╝" & vbCrLf & vbCrLf)
            txtBest.AppendText($"Kode    : {terbaik.Item1}" & vbCrLf & vbCrLf)
            txtBest.AppendText($"Judul   :" & vbCrLf)

            ' Wrap judul dengan benar
            Dim wrappedJudul As String = WrapText(terbaik.Item2, 40)
            For Each line As String In wrappedJudul.Split(New String() {vbCrLf}, StringSplitOptions.None)
                txtBest.AppendText("  " & line & vbCrLf)
            Next

            txtBest.AppendText(vbCrLf)
            txtBest.AppendText($"Tingkat Kepercayaan: {terbaik.Item3.ToString("0.00")}%" & vbCrLf & vbCrLf)
            txtBest.AppendText($"Status  : {GetStatusRekomendasi(terbaik.Item3)}" & vbCrLf & vbCrLf)
            txtBest.AppendText("──────────────────────────────────────────" & vbCrLf & vbCrLf)
            txtBest.AppendText("KESIMPULAN:" & vbCrLf)

            Dim kesimpulan As String = WrapText($"Judul ini merupakan rekomendasi terbaik dengan tingkat kepercayaan {terbaik.Item3.ToString("0.00")}% yang menunjukkan kesesuaian tinggi dengan minat dan kemampuan Anda.", 40)
            For Each line As String In kesimpulan.Split(New String() {vbCrLf}, StringSplitOptions.None)
                txtBest.AppendText(line & vbCrLf)
            Next

            txtBest.AppendText(vbCrLf)
            Dim saran As String = WrapText(GetRekomendasiTambahan(terbaik.Item3), 40)
            For Each line As String In saran.Split(New String() {vbCrLf}, StringSplitOptions.None)
                txtBest.AppendText(line & vbCrLf)
            Next
        End If

        ' All Results ListBox
        Dim listBox As ListBox = CType(Me.Controls.Find("ListBoxHasil", True).FirstOrDefault(), ListBox)
        If listBox IsNot Nothing Then
            listBox.Items.Clear()
            For i As Integer = 0 To hasilData.Count - 1
                Dim item As Tuple(Of String, String, Double) = hasilData(i)
                listBox.Items.Add($"#{i + 1} | {item.Item1} | {item.Item3.ToString("0.00")}% | {GetStatusRekomendasi(item.Item3)}")
            Next
        End If

        ' Refresh Chart
        Dim chartPanel As Panel = CType(Me.Controls.Find("ChartPanel", True).FirstOrDefault(), Panel)
        If chartPanel IsNot Nothing Then
            ' Adjust chart panel height based on number of items
            Dim itemCount As Integer = Math.Min(5, hasilData.Count)
            Dim requiredHeight As Integer = 250 + (itemCount * 30) ' Base height + legend space
            chartPanel.Height = Math.Max(450, requiredHeight)
            chartPanel.Invalidate()
        End If

        ' Prepare print content
        PreparePrintContent()
    End Sub

    Private Function WrapText(text As String, maxWidth As Integer) As String
        Dim words As String() = text.Split(" "c)
        Dim result As New System.Text.StringBuilder()
        Dim currentLine As String = ""

        For Each word As String In words
            If (currentLine & " " & word).Length > maxWidth Then
                result.AppendLine(currentLine.Trim())
                currentLine = word
            Else
                currentLine &= " " & word
            End If
        Next

        If currentLine.Length > 0 Then
            result.Append(currentLine.Trim())
        End If

        Return result.ToString()
    End Function

    Private Sub ChartPanel_Paint(sender As Object, e As PaintEventArgs)
        If hasilData Is Nothing OrElse hasilData.Count = 0 Then Return

        Dim g As Graphics = e.Graphics
        g.SmoothingMode = Drawing2D.SmoothingMode.AntiAlias
        g.Clear(Color.White)

        Dim panel As Panel = CType(sender, Panel)
        Dim centerX As Integer = panel.Width \ 2
        Dim centerY As Integer = (panel.Height \ 2) - 20
        Dim radius As Integer = Math.Min(panel.Width - 200, panel.Height - 100) \ 3

        Dim topData As List(Of Tuple(Of String, String, Double)) = hasilData.Take(Math.Min(5, hasilData.Count)).ToList()
        Dim total As Double = topData.Sum(Function(x) x.Item3)

        Dim colors As Color() = {
            Color.FromArgb(33, 150, 243),
            Color.FromArgb(76, 175, 80),
            Color.FromArgb(255, 193, 7),
            Color.FromArgb(255, 87, 34),
            Color.FromArgb(156, 39, 176)
        }

        ' Draw Pie Chart
        Dim startAngle As Single = 0
        For i As Integer = 0 To topData.Count - 1
            Dim item As Tuple(Of String, String, Double) = topData(i)
            Dim sweepAngle As Single = CSng((item.Item3 / total) * 360)

            Using brush As New SolidBrush(colors(i Mod colors.Length))
                g.FillPie(brush, centerX - radius, centerY - radius, radius * 2, radius * 2, startAngle, sweepAngle)
            End Using

            Using pen As New Pen(Color.White, 2)
                g.DrawPie(pen, centerX - radius, centerY - radius, radius * 2, radius * 2, startAngle, sweepAngle)
            End Using

            startAngle += sweepAngle
        Next

        ' Draw Legend
        Dim legendY As Integer = centerY + radius + 30
        Dim legendX As Integer = 40

        Using legendFont As New Font("Segoe UI", 9)
            For i As Integer = 0 To topData.Count - 1
                Dim item As Tuple(Of String, String, Double) = topData(i)

                Using brush As New SolidBrush(colors(i Mod colors.Length))
                    g.FillRectangle(brush, legendX, legendY, 20, 15)
                End Using
                g.DrawRectangle(Pens.Black, legendX, legendY, 20, 15)

                Dim legendText As String = $"{item.Item1}: {item.Item3.ToString("0.00")}%"
                g.DrawString(legendText, legendFont, Brushes.Black, legendX + 30, legendY - 2)

                legendY += 25
            Next
        End Using

        ' Info
        Using infoFont As New Font("Segoe UI", 8, FontStyle.Italic)
            g.DrawString($"Total: {hasilData.Count} rekomendasi", infoFont, Brushes.Gray, 10, panel.Height - 20)
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

            printContent &= "╔══════════════════════════════════════════════════════╗" & vbCrLf
            printContent &= "║          REKOMENDASI TERBAIK UNTUK ANDA              ║" & vbCrLf
            printContent &= "╚══════════════════════════════════════════════════════╝" & vbCrLf & vbCrLf
            printContent &= $"Kode Judul   : {terbaik.Item1}" & vbCrLf & vbCrLf

            ' Wrap judul untuk print
            printContent &= "Judul        : " & vbCrLf
            Dim wrappedJudul As String = WrapText(terbaik.Item2, 55)
            For Each line As String In wrappedJudul.Split(New String() {vbCrLf}, StringSplitOptions.None)
                printContent &= "               " & line & vbCrLf
            Next
            printContent &= vbCrLf

            printContent &= $"Tingkat Kepercayaan : {terbaik.Item3.ToString("0.00")}%" & vbCrLf & vbCrLf
            printContent &= "────────────────────────────────────────────────────────" & vbCrLf & vbCrLf
            printContent &= "KESIMPULAN:" & vbCrLf

            ' Wrap kesimpulan untuk print
            Dim kesimpulan As String = WrapText($"Judul ini merupakan rekomendasi terbaik dengan tingkat kepercayaan {terbaik.Item3.ToString("0.00")}% yang menunjukkan kesesuaian tinggi dengan minat dan kemampuan Anda.", 60)
            printContent &= kesimpulan & vbCrLf & vbCrLf

            ' Wrap saran untuk print
            Dim saran As String = WrapText(GetRekomendasiTambahan(terbaik.Item3), 60)
            printContent &= saran & vbCrLf & vbCrLf

            printContent &= "═══════════════════════════════════════════════════════════════" & vbCrLf & vbCrLf
            printContent &= "SEMUA REKOMENDASI:" & vbCrLf & vbCrLf

            For i As Integer = 0 To hasilData.Count - 1
                Dim item As Tuple(Of String, String, Double) = hasilData(i)
                printContent &= $"Peringkat {i + 1}" & vbCrLf
                printContent &= $"Kode        : {item.Item1}" & vbCrLf

                ' Wrap judul untuk setiap item
                printContent &= "Judul       : " & vbCrLf
                Dim itemJudul As String = WrapText(item.Item2, 55)
                For Each line As String In itemJudul.Split(New String() {vbCrLf}, StringSplitOptions.None)
                    printContent &= "              " & line & vbCrLf
                Next

                printContent &= $"Kepercayaan : {item.Item3.ToString("0.00")}%" & vbCrLf
                printContent &= $"Status      : {GetStatusRekomendasi(item.Item3)}" & vbCrLf
                printContent &= "─────────────────────────────────────────────────────────" & vbCrLf
                printContent &= vbCrLf
            Next
        End If
    End Sub

    Private Sub PrintDoc_PrintPage(sender As Object, e As PrintPageEventArgs) Handles printDoc.PrintPage
        ' FIXED: Proper pagination logic
        If printLines Is Nothing Then
            printLines = printContent.Split(New String() {vbCrLf}, StringSplitOptions.None)
            currentPrintLine = 0
        End If

        Dim font As New Font("Courier New", 10)
        Dim brush As New SolidBrush(Color.Black)
        Dim yPos As Single = e.MarginBounds.Top
        Dim linesPerPage As Integer = CInt(e.MarginBounds.Height / font.GetHeight(e.Graphics))

        While currentPrintLine < printLines.Length AndAlso linesPerPage > 0
            e.Graphics.DrawString(printLines(currentPrintLine), font, brush, e.MarginBounds.Left, yPos)
            yPos += font.GetHeight(e.Graphics)
            currentPrintLine += 1
            linesPerPage -= 1
        End While

        ' Check if more pages needed
        If currentPrintLine < printLines.Length Then
            e.HasMorePages = True
        Else
            e.HasMorePages = False
            ' Reset for next print job
            printLines = Nothing
            currentPrintLine = 0
        End If

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
            Return "SARAN: Judul ini cukup sesuai dengan minat Anda. Diskusikan lebih lanjut dengan dosen pembimbing."
        ElseIf persentase >= 40 Then
            Return "SARAN: Pertimbangkan untuk meningkatkan kepercayaan pada mata kuliah terkait."
        Else
            Return "SARAN: Eksplorasi topik lain yang lebih sesuai dengan kemampuan Anda."
        End If
    End Function

    Private Sub ButtonPrintPreview_Click(sender As Object, e As EventArgs)
        Try
            ' Reset print state before showing preview
            printLines = Nothing
            currentPrintLine = 0

            Dim printPreviewDialog As New PrintPreviewDialog()
            printPreviewDialog.Document = printDoc
            printPreviewDialog.Width = 900
            printPreviewDialog.Height = 700
            printPreviewDialog.ShowDialog()
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message, "Print Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub ButtonSave_Click(sender As Object, e As EventArgs)
        Dim saveDialog As New SaveFileDialog()
        saveDialog.Filter = "Text Files (*.txt)|*.txt"
        saveDialog.Title = "Simpan Hasil Rekomendasi"
        saveDialog.FileName = "Rekomendasi_" & DateTime.Now.ToString("yyyyMMdd_HHmmss") & ".txt"

        If saveDialog.ShowDialog() = DialogResult.OK Then
            Try
                System.IO.File.WriteAllText(saveDialog.FileName, printContent)
                MessageBox.Show("File berhasil disimpan!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Catch ex As Exception
                MessageBox.Show("Gagal menyimpan: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If
    End Sub

    Private Sub ButtonClose_Click(sender As Object, e As EventArgs)
        Me.Close()
    End Sub
End Class