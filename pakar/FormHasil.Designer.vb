<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormHasil
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.PanelCard = New System.Windows.Forms.Panel()
        Me.PanelHeaderStrip = New System.Windows.Forms.Panel()
        Me.LabelTitle1 = New System.Windows.Forms.Label()
        Me.LabelSubtitle1 = New System.Windows.Forms.Label()
        Me.LabelListHeader = New System.Windows.Forms.Label()
        Me.LabelDetailHeader = New System.Windows.Forms.Label()
        Me.PanelListContainer = New System.Windows.Forms.Panel()
        Me.ListBoxHasil = New System.Windows.Forms.ListBox()
        Me.PanelDetailContainer = New System.Windows.Forms.Panel()
        Me.TextBoxDetail = New System.Windows.Forms.TextBox()
        Me.ButtonCetak = New System.Windows.Forms.Button()
        Me.PanelCard.SuspendLayout()
        Me.PanelListContainer.SuspendLayout()
        Me.PanelDetailContainer.SuspendLayout()
        Me.SuspendLayout()
        '
        'PanelCard
        '
        Me.PanelCard.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PanelCard.BackColor = System.Drawing.Color.White
        Me.PanelCard.Controls.Add(Me.ButtonCetak)
        Me.PanelCard.Controls.Add(Me.PanelDetailContainer)
        Me.PanelCard.Controls.Add(Me.PanelListContainer)
        Me.PanelCard.Controls.Add(Me.LabelDetailHeader)
        Me.PanelCard.Controls.Add(Me.LabelListHeader)
        Me.PanelCard.Controls.Add(Me.LabelSubtitle1)
        Me.PanelCard.Controls.Add(Me.LabelTitle1)
        Me.PanelCard.Controls.Add(Me.PanelHeaderStrip)
        Me.PanelCard.Location = New System.Drawing.Point(40, 40)
        Me.PanelCard.Name = "PanelCard"
        Me.PanelCard.Padding = New System.Windows.Forms.Padding(30)
        Me.PanelCard.Size = New System.Drawing.Size(1012, 544)
        Me.PanelCard.TabIndex = 0
        '
        'PanelHeaderStrip
        '
        Me.PanelHeaderStrip.BackColor = System.Drawing.Color.FromArgb(CType(CType(65, Byte), Integer), CType(CType(105, Byte), Integer), CType(CType(225, Byte), Integer))
        Me.PanelHeaderStrip.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelHeaderStrip.Location = New System.Drawing.Point(30, 30)
        Me.PanelHeaderStrip.Name = "PanelHeaderStrip"
        Me.PanelHeaderStrip.Size = New System.Drawing.Size(952, 5)
        Me.PanelHeaderStrip.TabIndex = 0
        '
        'LabelTitle1
        '
        Me.LabelTitle1.AutoSize = True
        Me.LabelTitle1.Font = New System.Drawing.Font("Segoe UI Semibold", 20.0!, System.Drawing.FontStyle.Bold)
        Me.LabelTitle1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.LabelTitle1.Location = New System.Drawing.Point(24, 50)
        Me.LabelTitle1.Name = "LabelTitle1"
        Me.LabelTitle1.Size = New System.Drawing.Size(271, 37)
        Me.LabelTitle1.TabIndex = 1
        Me.LabelTitle1.Text = "Laporan Hasil Analisis"
        '
        'LabelSubtitle1
        '
        Me.LabelSubtitle1.AutoSize = True
        Me.LabelSubtitle1.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.LabelSubtitle1.ForeColor = System.Drawing.Color.Gray
        Me.LabelSubtitle1.Location = New System.Drawing.Point(30, 90)
        Me.LabelSubtitle1.Name = "LabelSubtitle1"
        Me.LabelSubtitle1.Size = New System.Drawing.Size(394, 19)
        Me.LabelSubtitle1.TabIndex = 2
        Me.LabelSubtitle1.Text = "Pilih riwayat dari daftar di sebelah kiri untuk melihat detail hasil."
        '
        'LabelListHeader
        '
        Me.LabelListHeader.AutoSize = True
        Me.LabelListHeader.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.LabelListHeader.ForeColor = System.Drawing.Color.SlateGray
        Me.LabelListHeader.Location = New System.Drawing.Point(30, 140)
        Me.LabelListHeader.Name = "LabelListHeader"
        Me.LabelListHeader.Size = New System.Drawing.Size(107, 15)
        Me.LabelListHeader.TabIndex = 3
        Me.LabelListHeader.Text = "RIWAYAT / DAFTAR"
        '
        'LabelDetailHeader
        '
        Me.LabelDetailHeader.AutoSize = True
        Me.LabelDetailHeader.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.LabelDetailHeader.ForeColor = System.Drawing.Color.SlateGray
        Me.LabelDetailHeader.Location = New System.Drawing.Point(340, 140)
        Me.LabelDetailHeader.Name = "LabelDetailHeader"
        Me.LabelDetailHeader.Size = New System.Drawing.Size(102, 15)
        Me.LabelDetailHeader.TabIndex = 4
        Me.LabelDetailHeader.Text = "DETAIL LAPORAN"
        '
        'PanelListContainer
        '
        Me.PanelListContainer.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.PanelListContainer.BackColor = System.Drawing.Color.WhiteSmoke
        Me.PanelListContainer.Controls.Add(Me.ListBoxHasil)
        Me.PanelListContainer.Location = New System.Drawing.Point(30, 160)
        Me.PanelListContainer.Name = "PanelListContainer"
        Me.PanelListContainer.Padding = New System.Windows.Forms.Padding(1)
        Me.PanelListContainer.Size = New System.Drawing.Size(280, 280)
        Me.PanelListContainer.TabIndex = 5
        '
        'ListBoxHasil
        '
        Me.ListBoxHasil.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ListBoxHasil.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.ListBoxHasil.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ListBoxHasil.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.ListBoxHasil.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.ListBoxHasil.FormattingEnabled = True
        Me.ListBoxHasil.ItemHeight = 17
        Me.ListBoxHasil.Location = New System.Drawing.Point(1, 1)
        Me.ListBoxHasil.Name = "ListBoxHasil"
        Me.ListBoxHasil.Size = New System.Drawing.Size(278, 278)
        Me.ListBoxHasil.TabIndex = 0
        '
        'PanelDetailContainer
        '
        Me.PanelDetailContainer.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PanelDetailContainer.BackColor = System.Drawing.Color.WhiteSmoke
        Me.PanelDetailContainer.Controls.Add(Me.TextBoxDetail)
        Me.PanelDetailContainer.Location = New System.Drawing.Point(340, 160)
        Me.PanelDetailContainer.Name = "PanelDetailContainer"
        Me.PanelDetailContainer.Padding = New System.Windows.Forms.Padding(10)
        Me.PanelDetailContainer.Size = New System.Drawing.Size(642, 280)
        Me.PanelDetailContainer.TabIndex = 6
        '
        'TextBoxDetail
        '
        Me.TextBoxDetail.BackColor = System.Drawing.Color.WhiteSmoke
        Me.TextBoxDetail.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBoxDetail.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TextBoxDetail.Font = New System.Drawing.Font("Consolas", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxDetail.ForeColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.TextBoxDetail.Location = New System.Drawing.Point(10, 10)
        Me.TextBoxDetail.Multiline = True
        Me.TextBoxDetail.Name = "TextBoxDetail"
        Me.TextBoxDetail.ReadOnly = True
        Me.TextBoxDetail.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.TextBoxDetail.Size = New System.Drawing.Size(622, 260)
        Me.TextBoxDetail.TabIndex = 1
        Me.TextBoxDetail.Text = "Pilih data di sebelah kiri untuk melihat detail..."
        '
        'ButtonCetak
        '
        Me.ButtonCetak.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ButtonCetak.BackColor = System.Drawing.Color.FromArgb(CType(CType(65, Byte), Integer), CType(CType(105, Byte), Integer), CType(CType(225, Byte), Integer))
        Me.ButtonCetak.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ButtonCetak.FlatAppearance.BorderSize = 0
        Me.ButtonCetak.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonCetak.Font = New System.Drawing.Font("Segoe UI Semibold", 10.0!, System.Drawing.FontStyle.Bold)
        Me.ButtonCetak.ForeColor = System.Drawing.Color.White
        Me.ButtonCetak.Location = New System.Drawing.Point(832, 469)
        Me.ButtonCetak.Name = "ButtonCetak"
        Me.ButtonCetak.Size = New System.Drawing.Size(150, 40)
        Me.ButtonCetak.TabIndex = 7
        Me.ButtonCetak.Text = "Cetak Laporan"
        Me.ButtonCetak.UseVisualStyleBackColor = False
        '
        'FormHasil
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(246, Byte), Integer), CType(CType(248, Byte), Integer), CType(CType(252, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1092, 624)
        Me.Controls.Add(Me.PanelCard)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "FormHasil"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Laporan Hasil"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.PanelCard.ResumeLayout(False)
        Me.PanelCard.PerformLayout()
        Me.PanelListContainer.ResumeLayout(False)
        Me.PanelDetailContainer.ResumeLayout(False)
        Me.PanelDetailContainer.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PanelCard As System.Windows.Forms.Panel
    Friend WithEvents PanelHeaderStrip As System.Windows.Forms.Panel
    Friend WithEvents LabelTitle1 As System.Windows.Forms.Label
    Friend WithEvents LabelSubtitle1 As System.Windows.Forms.Label
    Friend WithEvents LabelListHeader As System.Windows.Forms.Label
    Friend WithEvents LabelDetailHeader As System.Windows.Forms.Label
    Friend WithEvents PanelListContainer As System.Windows.Forms.Panel
    Friend WithEvents ListBoxHasil As System.Windows.Forms.ListBox
    Friend WithEvents PanelDetailContainer As System.Windows.Forms.Panel
    Friend WithEvents TextBoxDetail As System.Windows.Forms.TextBox
    Friend WithEvents ButtonCetak As System.Windows.Forms.Button
End Class