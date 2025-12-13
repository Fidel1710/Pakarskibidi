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
        PanelCard = New Panel()
        ButtonCetak = New Button()
        PanelDetailContainer = New Panel()
        TextBoxDetail = New TextBox()
        PanelListContainer = New Panel()
        ListBoxHasil = New ListBox()
        LabelDetailHeader = New Label()
        LabelListHeader = New Label()
        LabelSubtitle1 = New Label()
        LabelTitle1 = New Label()
        PanelHeaderStrip = New Panel()
        PanelCard.SuspendLayout()
        PanelDetailContainer.SuspendLayout()
        PanelListContainer.SuspendLayout()
        SuspendLayout()
        ' 
        ' PanelCard
        ' 
        PanelCard.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        PanelCard.BackColor = Color.White
        PanelCard.Controls.Add(ButtonCetak)
        PanelCard.Controls.Add(PanelDetailContainer)
        PanelCard.Controls.Add(PanelListContainer)
        PanelCard.Controls.Add(LabelDetailHeader)
        PanelCard.Controls.Add(LabelListHeader)
        PanelCard.Controls.Add(LabelSubtitle1)
        PanelCard.Controls.Add(LabelTitle1)
        PanelCard.Controls.Add(PanelHeaderStrip)
        PanelCard.Location = New Point(40, 40)
        PanelCard.Name = "PanelCard"
        PanelCard.Padding = New Padding(30)
        PanelCard.Size = New Size(1012, 544)
        PanelCard.TabIndex = 0
        ' 
        ' ButtonCetak
        ' 
        ButtonCetak.Anchor = AnchorStyles.Bottom Or AnchorStyles.Right
        ButtonCetak.BackColor = Color.FromArgb(CByte(65), CByte(105), CByte(225))
        ButtonCetak.Cursor = Cursors.Hand
        ButtonCetak.FlatAppearance.BorderSize = 0
        ButtonCetak.FlatStyle = FlatStyle.Flat
        ButtonCetak.Font = New Font("Segoe UI Semibold", 10F, FontStyle.Bold)
        ButtonCetak.ForeColor = Color.White
        ButtonCetak.Location = New Point(832, 469)
        ButtonCetak.Name = "ButtonCetak"
        ButtonCetak.Size = New Size(150, 40)
        ButtonCetak.TabIndex = 7
        ButtonCetak.Text = "Cetak Laporan"
        ButtonCetak.UseVisualStyleBackColor = False
        ' 
        ' PanelDetailContainer
        ' 
        PanelDetailContainer.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        PanelDetailContainer.BackColor = Color.WhiteSmoke
        PanelDetailContainer.Controls.Add(TextBoxDetail)
        PanelDetailContainer.Location = New Point(340, 160)
        PanelDetailContainer.Name = "PanelDetailContainer"
        PanelDetailContainer.Padding = New Padding(10)
        PanelDetailContainer.Size = New Size(642, 280)
        PanelDetailContainer.TabIndex = 6
        ' 
        ' TextBoxDetail
        ' 
        TextBoxDetail.BackColor = Color.WhiteSmoke
        TextBoxDetail.BorderStyle = BorderStyle.None
        TextBoxDetail.Dock = DockStyle.Fill
        TextBoxDetail.Font = New Font("Consolas", 10F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        TextBoxDetail.ForeColor = Color.FromArgb(CByte(44), CByte(62), CByte(80))
        TextBoxDetail.Location = New Point(10, 10)
        TextBoxDetail.Multiline = True
        TextBoxDetail.Name = "TextBoxDetail"
        TextBoxDetail.ReadOnly = True
        TextBoxDetail.ScrollBars = ScrollBars.Vertical
        TextBoxDetail.Size = New Size(622, 260)
        TextBoxDetail.TabIndex = 1
        TextBoxDetail.Text = "Pilih data di sebelah kiri untuk melihat detail..."
        ' 
        ' PanelListContainer
        ' 
        PanelListContainer.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left
        PanelListContainer.BackColor = Color.WhiteSmoke
        PanelListContainer.Controls.Add(ListBoxHasil)
        PanelListContainer.Location = New Point(30, 160)
        PanelListContainer.Name = "PanelListContainer"
        PanelListContainer.Padding = New Padding(1)
        PanelListContainer.Size = New Size(280, 280)
        PanelListContainer.TabIndex = 5
        ' 
        ' ListBoxHasil
        ' 
        ListBoxHasil.BackColor = Color.WhiteSmoke
        ListBoxHasil.BorderStyle = BorderStyle.None
        ListBoxHasil.Dock = DockStyle.Fill
        ListBoxHasil.Font = New Font("Segoe UI", 10F)
        ListBoxHasil.ForeColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        ListBoxHasil.FormattingEnabled = True
        ListBoxHasil.ItemHeight = 23
        ListBoxHasil.Location = New Point(1, 1)
        ListBoxHasil.Name = "ListBoxHasil"
        ListBoxHasil.Size = New Size(278, 278)
        ListBoxHasil.TabIndex = 0
        ' 
        ' LabelDetailHeader
        ' 
        LabelDetailHeader.AutoSize = True
        LabelDetailHeader.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        LabelDetailHeader.ForeColor = Color.SlateGray
        LabelDetailHeader.Location = New Point(340, 140)
        LabelDetailHeader.Name = "LabelDetailHeader"
        LabelDetailHeader.Size = New Size(136, 20)
        LabelDetailHeader.TabIndex = 4
        LabelDetailHeader.Text = "DETAIL LAPORAN"
        ' 
        ' LabelListHeader
        ' 
        LabelListHeader.AutoSize = True
        LabelListHeader.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        LabelListHeader.ForeColor = Color.SlateGray
        LabelListHeader.Location = New Point(30, 140)
        LabelListHeader.Name = "LabelListHeader"
        LabelListHeader.Size = New Size(149, 20)
        LabelListHeader.TabIndex = 3
        LabelListHeader.Text = "RIWAYAT / DAFTAR"
        ' 
        ' LabelSubtitle1
        ' 
        LabelSubtitle1.AutoSize = True
        LabelSubtitle1.Font = New Font("Segoe UI", 10F)
        LabelSubtitle1.ForeColor = Color.Gray
        LabelSubtitle1.Location = New Point(30, 90)
        LabelSubtitle1.Name = "LabelSubtitle1"
        LabelSubtitle1.Size = New Size(495, 23)
        LabelSubtitle1.TabIndex = 2
        LabelSubtitle1.Text = "Pilih riwayat dari daftar di sebelah kiri untuk melihat detail hasil."
        ' 
        ' LabelTitle1
        ' 
        LabelTitle1.AutoSize = True
        LabelTitle1.Font = New Font("Segoe UI Semibold", 20F, FontStyle.Bold)
        LabelTitle1.ForeColor = Color.FromArgb(CByte(44), CByte(62), CByte(80))
        LabelTitle1.Location = New Point(24, 50)
        LabelTitle1.Name = "LabelTitle1"
        LabelTitle1.Size = New Size(358, 46)
        LabelTitle1.TabIndex = 1
        LabelTitle1.Text = "Laporan Hasil Analisis"
        ' 
        ' PanelHeaderStrip
        ' 
        PanelHeaderStrip.BackColor = Color.FromArgb(CByte(65), CByte(105), CByte(225))
        PanelHeaderStrip.Dock = DockStyle.Top
        PanelHeaderStrip.Location = New Point(30, 30)
        PanelHeaderStrip.Name = "PanelHeaderStrip"
        PanelHeaderStrip.Size = New Size(952, 5)
        PanelHeaderStrip.TabIndex = 0
        ' 
        ' FormHasil
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(246), CByte(248), CByte(252))
        ClientSize = New Size(1092, 624)
        Controls.Add(PanelCard)
        Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Name = "FormHasil"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Laporan Hasil"
        WindowState = FormWindowState.Maximized
        PanelCard.ResumeLayout(False)
        PanelCard.PerformLayout()
        PanelDetailContainer.ResumeLayout(False)
        PanelDetailContainer.PerformLayout()
        PanelListContainer.ResumeLayout(False)
        ResumeLayout(False)

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