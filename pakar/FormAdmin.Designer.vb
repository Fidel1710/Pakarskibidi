<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormAdmin
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
        components = New ComponentModel.Container()
        Dim DataGridViewCellStyle1 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As DataGridViewCellStyle = New DataGridViewCellStyle()
        TabControl1 = New TabControl()
        TabPage1 = New TabPage()
        PanelCardRule = New Panel()
        PanelHeaderStrip = New Panel()
        LabelTitle1 = New Label()
        LabelSubtitle1 = New Label()
        Button1 = New Button()
        ComboBox3 = New ComboBox()
        ComboBox2 = New ComboBox()
        ComboBox1 = New ComboBox()
        NumericUpDown3 = New NumericUpDown()
        NumericUpDown2 = New NumericUpDown()
        NumericUpDown1 = New NumericUpDown()
        Label8 = New Label()
        Label7 = New Label()
        Label6 = New Label()
        Label5 = New Label()
        Label4 = New Label()
        Label3 = New Label()
        Label2 = New Label()
        TextBox1 = New TextBox()
        Label1 = New Label()
        TabPage2 = New TabPage()
        PanelCardData = New Panel()
        LabelTitle2 = New Label()
        Button4 = New Button()
        Button3 = New Button()
        Button2 = New Button()
        TextBox2 = New TextBox()
        Label9 = New Label()
        DataGridView1 = New DataGridView()
        ErrorProvider1 = New ErrorProvider(components)
        TabControl1.SuspendLayout()
        TabPage1.SuspendLayout()
        PanelCardRule.SuspendLayout()
        CType(NumericUpDown3, ComponentModel.ISupportInitialize).BeginInit()
        CType(NumericUpDown2, ComponentModel.ISupportInitialize).BeginInit()
        CType(NumericUpDown1, ComponentModel.ISupportInitialize).BeginInit()
        TabPage2.SuspendLayout()
        PanelCardData.SuspendLayout()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        CType(ErrorProvider1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' TabControl1
        ' 
        TabControl1.Controls.Add(TabPage1)
        TabControl1.Controls.Add(TabPage2)
        TabControl1.Dock = DockStyle.Fill
        TabControl1.Font = New Font("Segoe UI", 10F)
        TabControl1.ItemSize = New Size(120, 40)
        TabControl1.Location = New Point(0, 0)
        TabControl1.Name = "TabControl1"
        TabControl1.Padding = New Point(25, 5)
        TabControl1.SelectedIndex = 0
        TabControl1.Size = New Size(800, 600)
        TabControl1.SizeMode = TabSizeMode.Fixed
        TabControl1.TabIndex = 0
        ' 
        ' TabPage1
        ' 
        TabPage1.BackColor = Color.FromArgb(CByte(246), CByte(248), CByte(252))
        TabPage1.Controls.Add(PanelCardRule)
        TabPage1.Location = New Point(4, 44)
        TabPage1.Name = "TabPage1"
        TabPage1.Padding = New Padding(40)
        TabPage1.Size = New Size(792, 552)
        TabPage1.TabIndex = 0
        TabPage1.Text = "Konfigurasi Rule"
        ' 
        ' PanelCardRule
        ' 
        PanelCardRule.Anchor = AnchorStyles.None
        PanelCardRule.BackColor = Color.White
        PanelCardRule.Controls.Add(PanelHeaderStrip)
        PanelCardRule.Controls.Add(LabelTitle1)
        PanelCardRule.Controls.Add(LabelSubtitle1)
        PanelCardRule.Controls.Add(Button1)
        PanelCardRule.Controls.Add(ComboBox3)
        PanelCardRule.Controls.Add(ComboBox2)
        PanelCardRule.Controls.Add(ComboBox1)
        PanelCardRule.Controls.Add(NumericUpDown3)
        PanelCardRule.Controls.Add(NumericUpDown2)
        PanelCardRule.Controls.Add(NumericUpDown1)
        PanelCardRule.Controls.Add(Label8)
        PanelCardRule.Controls.Add(Label7)
        PanelCardRule.Controls.Add(Label6)
        PanelCardRule.Controls.Add(Label5)
        PanelCardRule.Controls.Add(Label4)
        PanelCardRule.Controls.Add(Label3)
        PanelCardRule.Controls.Add(Label2)
        PanelCardRule.Controls.Add(TextBox1)
        PanelCardRule.Controls.Add(Label1)
        PanelCardRule.Location = New Point(121, 36)
        PanelCardRule.Name = "PanelCardRule"
        PanelCardRule.Padding = New Padding(40)
        PanelCardRule.Size = New Size(550, 480)
        PanelCardRule.TabIndex = 17
        ' 
        ' PanelHeaderStrip
        ' 
        PanelHeaderStrip.BackColor = Color.FromArgb(CByte(65), CByte(105), CByte(225))
        PanelHeaderStrip.Dock = DockStyle.Top
        PanelHeaderStrip.Location = New Point(40, 40)
        PanelHeaderStrip.Name = "PanelHeaderStrip"
        PanelHeaderStrip.Size = New Size(470, 3)
        PanelHeaderStrip.TabIndex = 20
        ' 
        ' LabelTitle1
        ' 
        LabelTitle1.AutoSize = True
        LabelTitle1.Font = New Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        LabelTitle1.ForeColor = Color.FromArgb(CByte(44), CByte(62), CByte(80))
        LabelTitle1.Location = New Point(34, 55)
        LabelTitle1.Name = "LabelTitle1"
        LabelTitle1.Size = New Size(246, 41)
        LabelTitle1.TabIndex = 18
        LabelTitle1.Text = "Pengaturan Rule"
        ' 
        ' LabelSubtitle1
        ' 
        LabelSubtitle1.AutoSize = True
        LabelSubtitle1.Font = New Font("Segoe UI", 9F)
        LabelSubtitle1.ForeColor = Color.Gray
        LabelSubtitle1.Location = New Point(38, 90)
        LabelSubtitle1.Name = "LabelSubtitle1"
        LabelSubtitle1.Size = New Size(418, 20)
        LabelSubtitle1.TabIndex = 19
        LabelSubtitle1.Text = "Sesuaikan parameter certainty factor untuk sistem pakar anda."
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.FromArgb(CByte(65), CByte(105), CByte(225))
        Button1.Cursor = Cursors.Hand
        Button1.FlatAppearance.BorderSize = 0
        Button1.FlatStyle = FlatStyle.Flat
        Button1.Font = New Font("Segoe UI Semibold", 10F, FontStyle.Bold)
        Button1.ForeColor = Color.White
        Button1.Location = New Point(40, 400)
        Button1.Name = "Button1"
        Button1.Size = New Size(470, 45)
        Button1.TabIndex = 16
        Button1.Text = "Simpan Data"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' ComboBox3
        ' 
        ComboBox3.BackColor = Color.WhiteSmoke
        ComboBox3.DropDownStyle = ComboBoxStyle.DropDownList
        ComboBox3.FlatStyle = FlatStyle.Flat
        ComboBox3.Font = New Font("Segoe UI", 10F)
        ComboBox3.ForeColor = Color.Black
        ComboBox3.FormattingEnabled = True
        ComboBox3.Location = New Point(40, 230)
        ComboBox3.Name = "ComboBox3"
        ComboBox3.Size = New Size(280, 31)
        ComboBox3.TabIndex = 15
        ' 
        ' ComboBox2
        ' 
        ComboBox2.BackColor = Color.WhiteSmoke
        ComboBox2.DropDownStyle = ComboBoxStyle.DropDownList
        ComboBox2.FlatStyle = FlatStyle.Flat
        ComboBox2.Font = New Font("Segoe UI", 10F)
        ComboBox2.ForeColor = Color.Black
        ComboBox2.FormattingEnabled = True
        ComboBox2.Location = New Point(40, 350)
        ComboBox2.Name = "ComboBox2"
        ComboBox2.Size = New Size(280, 31)
        ComboBox2.TabIndex = 14
        ' 
        ' ComboBox1
        ' 
        ComboBox1.BackColor = Color.WhiteSmoke
        ComboBox1.DropDownStyle = ComboBoxStyle.DropDownList
        ComboBox1.FlatStyle = FlatStyle.Flat
        ComboBox1.Font = New Font("Segoe UI", 10F)
        ComboBox1.ForeColor = Color.Black
        ComboBox1.FormattingEnabled = True
        ComboBox1.Location = New Point(40, 290)
        ComboBox1.Name = "ComboBox1"
        ComboBox1.Size = New Size(280, 31)
        ComboBox1.TabIndex = 13
        ' 
        ' NumericUpDown3
        ' 
        NumericUpDown3.BackColor = Color.WhiteSmoke
        NumericUpDown3.BorderStyle = BorderStyle.None
        NumericUpDown3.DecimalPlaces = 2
        NumericUpDown3.Font = New Font("Segoe UI", 11F)
        NumericUpDown3.Increment = New Decimal(New Integer() {1, 0, 0, 65536})
        NumericUpDown3.Location = New Point(360, 351)
        NumericUpDown3.Maximum = New Decimal(New Integer() {1, 0, 0, 0})
        NumericUpDown3.Name = "NumericUpDown3"
        NumericUpDown3.Size = New Size(150, 28)
        NumericUpDown3.TabIndex = 12
        NumericUpDown3.TextAlign = HorizontalAlignment.Center
        ' 
        ' NumericUpDown2
        ' 
        NumericUpDown2.BackColor = Color.WhiteSmoke
        NumericUpDown2.BorderStyle = BorderStyle.None
        NumericUpDown2.DecimalPlaces = 2
        NumericUpDown2.Font = New Font("Segoe UI", 11F)
        NumericUpDown2.Increment = New Decimal(New Integer() {1, 0, 0, 65536})
        NumericUpDown2.Location = New Point(360, 291)
        NumericUpDown2.Maximum = New Decimal(New Integer() {1, 0, 0, 0})
        NumericUpDown2.Name = "NumericUpDown2"
        NumericUpDown2.Size = New Size(150, 28)
        NumericUpDown2.TabIndex = 11
        NumericUpDown2.TextAlign = HorizontalAlignment.Center
        ' 
        ' NumericUpDown1
        ' 
        NumericUpDown1.BackColor = Color.WhiteSmoke
        NumericUpDown1.BorderStyle = BorderStyle.None
        NumericUpDown1.DecimalPlaces = 2
        NumericUpDown1.Font = New Font("Segoe UI", 11F)
        NumericUpDown1.Increment = New Decimal(New Integer() {1, 0, 0, 65536})
        NumericUpDown1.Location = New Point(360, 231)
        NumericUpDown1.Maximum = New Decimal(New Integer() {1, 0, 0, 0})
        NumericUpDown1.Name = "NumericUpDown1"
        NumericUpDown1.Size = New Size(150, 28)
        NumericUpDown1.TabIndex = 10
        NumericUpDown1.TextAlign = HorizontalAlignment.Center
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Font = New Font("Segoe UI", 8F, FontStyle.Bold)
        Label8.ForeColor = Color.SlateGray
        Label8.Location = New Point(357, 330)
        Label8.Name = "Label8"
        Label8.Size = New Size(77, 19)
        Label8.TabIndex = 9
        Label8.Text = "NILAI CF 3"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Segoe UI", 8F, FontStyle.Bold)
        Label7.ForeColor = Color.SlateGray
        Label7.Location = New Point(357, 270)
        Label7.Name = "Label7"
        Label7.Size = New Size(77, 19)
        Label7.TabIndex = 8
        Label7.Text = "NILAI CF 2"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Segoe UI", 8F, FontStyle.Bold)
        Label6.ForeColor = Color.SlateGray
        Label6.Location = New Point(357, 210)
        Label6.Name = "Label6"
        Label6.Size = New Size(77, 19)
        Label6.TabIndex = 7
        Label6.Text = "NILAI CF 1"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI", 8F, FontStyle.Bold)
        Label5.ForeColor = Color.SlateGray
        Label5.Location = New Point(37, 330)
        Label5.Name = "Label5"
        Label5.Size = New Size(115, 19)
        Label5.TabIndex = 6
        Label5.Text = "MATA KULIAH 3"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI", 8F, FontStyle.Bold)
        Label4.ForeColor = Color.SlateGray
        Label4.Location = New Point(37, 270)
        Label4.Name = "Label4"
        Label4.Size = New Size(115, 19)
        Label4.TabIndex = 5
        Label4.Text = "MATA KULIAH 2"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 8F, FontStyle.Bold)
        Label3.ForeColor = Color.SlateGray
        Label3.Location = New Point(37, 210)
        Label3.Name = "Label3"
        Label3.Size = New Size(115, 19)
        Label3.TabIndex = 3
        Label3.Text = "MATA KULIAH 1"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 8F, FontStyle.Bold)
        Label2.ForeColor = Color.SlateGray
        Label2.Location = New Point(37, 140)
        Label2.Name = "Label2"
        Label2.Size = New Size(92, 19)
        Label2.TabIndex = 2
        Label2.Text = "JUDUL DATA"
        ' 
        ' TextBox1
        ' 
        TextBox1.BackColor = Color.WhiteSmoke
        TextBox1.BorderStyle = BorderStyle.None
        TextBox1.Font = New Font("Segoe UI", 11F)
        TextBox1.ForeColor = Color.Black
        TextBox1.Location = New Point(40, 160)
        TextBox1.Multiline = True
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(470, 28)
        TextBox1.TabIndex = 1
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(300, 270)
        Label1.Name = "Label1"
        Label1.Size = New Size(0, 23)
        Label1.TabIndex = 0
        ' 
        ' TabPage2
        ' 
        TabPage2.BackColor = Color.FromArgb(CByte(246), CByte(248), CByte(252))
        TabPage2.Controls.Add(PanelCardData)
        TabPage2.Location = New Point(4, 44)
        TabPage2.Name = "TabPage2"
        TabPage2.Padding = New Padding(30)
        TabPage2.Size = New Size(792, 552)
        TabPage2.TabIndex = 1
        TabPage2.Text = "Data Master"
        ' 
        ' PanelCardData
        ' 
        PanelCardData.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        PanelCardData.BackColor = Color.White
        PanelCardData.Controls.Add(LabelTitle2)
        PanelCardData.Controls.Add(Button4)
        PanelCardData.Controls.Add(Button3)
        PanelCardData.Controls.Add(Button2)
        PanelCardData.Controls.Add(TextBox2)
        PanelCardData.Controls.Add(Label9)
        PanelCardData.Controls.Add(DataGridView1)
        PanelCardData.Location = New Point(33, 33)
        PanelCardData.Name = "PanelCardData"
        PanelCardData.Padding = New Padding(30)
        PanelCardData.Size = New Size(726, 486)
        PanelCardData.TabIndex = 0
        ' 
        ' LabelTitle2
        ' 
        LabelTitle2.AutoSize = True
        LabelTitle2.Font = New Font("Segoe UI Semibold", 18F, FontStyle.Bold)
        LabelTitle2.ForeColor = Color.FromArgb(CByte(44), CByte(62), CByte(80))
        LabelTitle2.Location = New Point(26, 25)
        LabelTitle2.Name = "LabelTitle2"
        LabelTitle2.Size = New Size(277, 41)
        LabelTitle2.TabIndex = 20
        LabelTitle2.Text = "Daftar Mata Kuliah"
        ' 
        ' Button4
        ' 
        Button4.Anchor = AnchorStyles.Bottom Or AnchorStyles.Right
        Button4.BackColor = Color.White
        Button4.Cursor = Cursors.Hand
        Button4.FlatAppearance.BorderColor = Color.FromArgb(CByte(231), CByte(76), CByte(60))
        Button4.FlatStyle = FlatStyle.Flat
        Button4.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold)
        Button4.ForeColor = Color.FromArgb(CByte(231), CByte(76), CByte(60))
        Button4.Location = New Point(603, 418)
        Button4.Name = "Button4"
        Button4.Size = New Size(90, 35)
        Button4.TabIndex = 6
        Button4.Text = "HAPUS"
        Button4.UseVisualStyleBackColor = False
        ' 
        ' Button3
        ' 
        Button3.Anchor = AnchorStyles.Bottom Or AnchorStyles.Right
        Button3.BackColor = Color.FromArgb(CByte(46), CByte(204), CByte(113))
        Button3.Cursor = Cursors.Hand
        Button3.FlatAppearance.BorderSize = 0
        Button3.FlatStyle = FlatStyle.Flat
        Button3.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold)
        Button3.ForeColor = Color.White
        Button3.Location = New Point(507, 418)
        Button3.Name = "Button3"
        Button3.Size = New Size(90, 35)
        Button3.TabIndex = 5
        Button3.Text = "TAMBAH"
        Button3.UseVisualStyleBackColor = False
        ' 
        ' Button2
        ' 
        Button2.Anchor = AnchorStyles.Bottom Or AnchorStyles.Right
        Button2.BackColor = Color.White
        Button2.Cursor = Cursors.Hand
        Button2.FlatAppearance.BorderColor = Color.FromArgb(CByte(241), CByte(196), CByte(15))
        Button2.FlatStyle = FlatStyle.Flat
        Button2.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold)
        Button2.ForeColor = Color.FromArgb(CByte(243), CByte(156), CByte(18))
        Button2.Location = New Point(411, 418)
        Button2.Name = "Button2"
        Button2.Size = New Size(90, 35)
        Button2.TabIndex = 4
        Button2.Text = "EDIT"
        Button2.UseVisualStyleBackColor = False
        ' 
        ' TextBox2
        ' 
        TextBox2.Anchor = AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        TextBox2.BackColor = Color.WhiteSmoke
        TextBox2.BorderStyle = BorderStyle.None
        TextBox2.Font = New Font("Segoe UI", 11F)
        TextBox2.ForeColor = Color.Black
        TextBox2.Location = New Point(30, 370)
        TextBox2.Multiline = True
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(663, 28)
        TextBox2.TabIndex = 3
        ' 
        ' Label9
        ' 
        Label9.Anchor = AnchorStyles.Bottom Or AnchorStyles.Left
        Label9.AutoSize = True
        Label9.Font = New Font("Segoe UI", 8F, FontStyle.Bold)
        Label9.ForeColor = Color.SlateGray
        Label9.Location = New Point(27, 350)
        Label9.Name = "Label9"
        Label9.Size = New Size(151, 19)
        Label9.TabIndex = 2
        Label9.Text = "NAMA MATA KULIAH"
        ' 
        ' DataGridView1
        ' 
        DataGridView1.AllowUserToAddRows = False
        DataGridView1.AllowUserToDeleteRows = False
        DataGridView1.AllowUserToResizeRows = False
        DataGridViewCellStyle1.BackColor = Color.White
        DataGridViewCellStyle1.ForeColor = Color.Black
        DataGridView1.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        DataGridView1.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        DataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        DataGridView1.BackgroundColor = Color.White
        DataGridView1.BorderStyle = BorderStyle.None
        DataGridView1.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal
        DataGridView1.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = Color.White
        DataGridViewCellStyle2.Font = New Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        DataGridViewCellStyle2.ForeColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        DataGridViewCellStyle2.SelectionBackColor = Color.White
        DataGridViewCellStyle2.SelectionForeColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        DataGridViewCellStyle2.WrapMode = DataGridViewTriState.True
        DataGridView1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        DataGridView1.ColumnHeadersHeight = 45
        DataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = Color.White
        DataGridViewCellStyle3.Font = New Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        DataGridViewCellStyle3.ForeColor = Color.FromArgb(CByte(44), CByte(62), CByte(80))
        DataGridViewCellStyle3.Padding = New Padding(10, 0, 0, 0)
        DataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(CByte(240), CByte(244), CByte(255))
        DataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(CByte(65), CByte(105), CByte(225))
        DataGridViewCellStyle3.WrapMode = DataGridViewTriState.False
        DataGridView1.DefaultCellStyle = DataGridViewCellStyle3
        DataGridView1.EnableHeadersVisualStyles = False
        DataGridView1.GridColor = Color.WhiteSmoke
        DataGridView1.Location = New Point(30, 80)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.ReadOnly = True
        DataGridView1.RowHeadersVisible = False
        DataGridView1.RowHeadersWidth = 51
        DataGridView1.RowTemplate.Height = 45
        DataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        DataGridView1.Size = New Size(663, 275)
        DataGridView1.TabIndex = 1
        ' 
        ' ErrorProvider1
        ' 
        ErrorProvider1.ContainerControl = Me
        ' 
        ' FormAdmin
        ' 
        AutoScaleDimensions = New SizeF(9F, 21F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(246), CByte(248), CByte(252))
        ClientSize = New Size(800, 600)
        Controls.Add(TabControl1)
        Font = New Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Name = "FormAdmin"
        StartPosition = FormStartPosition.CenterScreen
        Text = "System Admin"
        TabControl1.ResumeLayout(False)
        TabPage1.ResumeLayout(False)
        PanelCardRule.ResumeLayout(False)
        PanelCardRule.PerformLayout()
        CType(NumericUpDown3, ComponentModel.ISupportInitialize).EndInit()
        CType(NumericUpDown2, ComponentModel.ISupportInitialize).EndInit()
        CType(NumericUpDown1, ComponentModel.ISupportInitialize).EndInit()
        TabPage2.ResumeLayout(False)
        PanelCardData.ResumeLayout(False)
        PanelCardData.PerformLayout()
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        CType(ErrorProvider1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)

    End Sub

    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents ComboBox2 As System.Windows.Forms.ComboBox
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents NumericUpDown3 As System.Windows.Forms.NumericUpDown
    Friend WithEvents NumericUpDown2 As System.Windows.Forms.NumericUpDown
    Friend WithEvents NumericUpDown1 As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents ComboBox3 As System.Windows.Forms.ComboBox
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents ErrorProvider1 As System.Windows.Forms.ErrorProvider
    Friend WithEvents PanelCardRule As System.Windows.Forms.Panel
    Friend WithEvents LabelTitle1 As System.Windows.Forms.Label
    Friend WithEvents LabelSubtitle1 As System.Windows.Forms.Label
    Friend WithEvents PanelCardData As System.Windows.Forms.Panel
    Friend WithEvents LabelTitle2 As System.Windows.Forms.Label
    Friend WithEvents PanelHeaderStrip As System.Windows.Forms.Panel
End Class