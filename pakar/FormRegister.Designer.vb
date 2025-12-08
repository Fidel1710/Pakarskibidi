<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormRegister
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
        TextBox2 = New TextBox()
        TextBox1 = New TextBox()
        Label3 = New Label()
        Label2 = New Label()
        Label1 = New Label()
        Button1 = New Button()
        Label4 = New Label()
        ComboBox1 = New ComboBox()
        PanelCard = New Panel()
        Label5 = New Label()
        Button3 = New Button()
        PanelRoleContainer = New Panel()
        LabelRoleIcon = New Label()
        PanelPassContainer = New Panel()
        Button2 = New Button()
        LabelPassIcon = New Label()
        PanelUserContainer = New Panel()
        LabelUserIcon = New Label()
        LabelSubtitle = New Label()
        PanelHeaderStrip = New Panel()
        PanelCard.SuspendLayout()
        PanelRoleContainer.SuspendLayout()
        PanelPassContainer.SuspendLayout()
        PanelUserContainer.SuspendLayout()
        SuspendLayout()
        ' 
        ' TextBox2
        ' 
        TextBox2.BackColor = Color.WhiteSmoke
        TextBox2.BorderStyle = BorderStyle.None
        TextBox2.Font = New Font("Segoe UI", 11.25F)
        TextBox2.ForeColor = Color.FromArgb(CByte(44), CByte(62), CByte(80))
        TextBox2.Location = New Point(12, 10)
        TextBox2.Name = "TextBox2"
        TextBox2.PasswordChar = "●"c
        TextBox2.Size = New Size(220, 20)
        TextBox2.TabIndex = 0
        ' 
        ' TextBox1
        ' 
        TextBox1.BackColor = Color.WhiteSmoke
        TextBox1.BorderStyle = BorderStyle.None
        TextBox1.Font = New Font("Segoe UI", 11.25F)
        TextBox1.ForeColor = Color.FromArgb(CByte(44), CByte(62), CByte(80))
        TextBox1.Location = New Point(12, 10)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(260, 20)
        TextBox1.TabIndex = 0
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 9.0F, FontStyle.Bold)
        Label3.ForeColor = Color.SlateGray
        Label3.Location = New Point(39, 205)
        Label3.Name = "Label3"
        Label3.Size = New Size(73, 15)
        Label3.TabIndex = 5
        Label3.Text = "PASSWORD"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 9.0F, FontStyle.Bold)
        Label2.ForeColor = Color.SlateGray
        Label2.Location = New Point(39, 125)
        Label2.Name = "Label2"
        Label2.Size = New Size(71, 15)
        Label2.TabIndex = 3
        Label2.Text = "USERNAME"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 20.25F, FontStyle.Bold)
        Label1.ForeColor = Color.FromArgb(CByte(44), CByte(62), CByte(80))
        Label1.Location = New Point(90, 40)
        Label1.Name = "Label1"
        Label1.Size = New Size(215, 37)
        Label1.TabIndex = 1
        Label1.Text = "Buat Akun Baru"
        Label1.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.FromArgb(CByte(65), CByte(105), CByte(225))
        Button1.Cursor = Cursors.Hand
        Button1.FlatAppearance.BorderSize = 0
        Button1.FlatStyle = FlatStyle.Flat
        Button1.Font = New Font("Segoe UI Semibold", 11.25F, FontStyle.Bold)
        Button1.ForeColor = Color.White
        Button1.Location = New Point(42, 370)
        Button1.Name = "Button1"
        Button1.Size = New Size(316, 50)
        Button1.TabIndex = 9
        Button1.Text = "✦  Daftar Sekarang  ✦"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI", 9.0F, FontStyle.Bold)
        Label4.ForeColor = Color.SlateGray
        Label4.Location = New Point(39, 285)
        Label4.Name = "Label4"
        Label4.Size = New Size(36, 15)
        Label4.TabIndex = 7
        Label4.Text = "ROLE"
        ' 
        ' ComboBox1
        ' 
        ComboBox1.BackColor = Color.WhiteSmoke
        ComboBox1.DropDownStyle = ComboBoxStyle.DropDownList
        ComboBox1.FlatStyle = FlatStyle.Flat
        ComboBox1.Font = New Font("Segoe UI", 11.25F)
        ComboBox1.ForeColor = Color.FromArgb(CByte(44), CByte(62), CByte(80))
        ComboBox1.FormattingEnabled = True
        ComboBox1.Items.AddRange(New Object() {"User", "Admin"})
        ComboBox1.Location = New Point(12, 6)
        ComboBox1.Name = "ComboBox1"
        ComboBox1.Size = New Size(260, 28)
        ComboBox1.TabIndex = 0
        ' 
        ' PanelCard
        ' 
        PanelCard.Anchor = AnchorStyles.None
        PanelCard.BackColor = Color.White
        PanelCard.Controls.Add(Label5)
        PanelCard.Controls.Add(Button3)
        PanelCard.Controls.Add(PanelRoleContainer)
        PanelCard.Controls.Add(Label4)
        PanelCard.Controls.Add(PanelPassContainer)
        PanelCard.Controls.Add(Label3)
        PanelCard.Controls.Add(PanelUserContainer)
        PanelCard.Controls.Add(Label2)
        PanelCard.Controls.Add(Button1)
        PanelCard.Controls.Add(LabelSubtitle)
        PanelCard.Controls.Add(Label1)
        PanelCard.Controls.Add(PanelHeaderStrip)
        PanelCard.Location = New Point(200, 50)
        PanelCard.Name = "PanelCard"
        PanelCard.Size = New Size(400, 550)
        PanelCard.TabIndex = 0
        ' 
        ' Label5
        ' 
        Label5.Font = New Font("Segoe UI", 16.0F)
        Label5.ForeColor = Color.FromArgb(CByte(65), CByte(105), CByte(225))
        Label5.Location = New Point(170, 475)
        Label5.Name = "Label5"
        Label5.Size = New Size(60, 40)
        Label5.TabIndex = 11
        Label5.Text = "✦"
        Label5.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Button3
        ' 
        Button3.BackColor = Color.White
        Button3.Cursor = Cursors.Hand
        Button3.FlatAppearance.BorderSize = 0
        Button3.FlatStyle = FlatStyle.Flat
        Button3.Font = New Font("Segoe UI", 9.0F, FontStyle.Bold)
        Button3.ForeColor = Color.FromArgb(CByte(65), CByte(105), CByte(225))
        Button3.Location = New Point(42, 435)
        Button3.Name = "Button3"
        Button3.Size = New Size(316, 35)
        Button3.TabIndex = 10
        Button3.Text = "Sudah punya akun? Masuk disini"
        Button3.UseVisualStyleBackColor = False
        ' 
        ' PanelRoleContainer
        ' 
        PanelRoleContainer.BackColor = Color.WhiteSmoke
        PanelRoleContainer.Controls.Add(LabelRoleIcon)
        PanelRoleContainer.Controls.Add(ComboBox1)
        PanelRoleContainer.Location = New Point(42, 305)
        PanelRoleContainer.Name = "PanelRoleContainer"
        PanelRoleContainer.Size = New Size(316, 40)
        PanelRoleContainer.TabIndex = 8
        ' 
        ' LabelRoleIcon
        ' 
        LabelRoleIcon.Font = New Font("Segoe UI", 12.0F)
        LabelRoleIcon.ForeColor = Color.FromArgb(CByte(65), CByte(105), CByte(225))
        LabelRoleIcon.Location = New Point(278, 6)
        LabelRoleIcon.Name = "LabelRoleIcon"
        LabelRoleIcon.Size = New Size(30, 25)
        LabelRoleIcon.TabIndex = 1
        LabelRoleIcon.Text = "⚡"
        LabelRoleIcon.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' PanelPassContainer
        ' 
        PanelPassContainer.BackColor = Color.WhiteSmoke
        PanelPassContainer.Controls.Add(Button2)
        PanelPassContainer.Controls.Add(LabelPassIcon)
        PanelPassContainer.Controls.Add(TextBox2)
        PanelPassContainer.Location = New Point(42, 225)
        PanelPassContainer.Name = "PanelPassContainer"
        PanelPassContainer.Size = New Size(316, 40)
        PanelPassContainer.TabIndex = 6
        ' 
        ' Button2
        ' 
        Button2.BackColor = Color.Transparent
        Button2.FlatAppearance.BorderSize = 0
        Button2.FlatStyle = FlatStyle.Flat
        Button2.Font = New Font("Segoe UI", 10.0F)
        Button2.ForeColor = Color.Gray
        Button2.Location = New Point(238, 5)
        Button2.Name = "Button2"
        Button2.Size = New Size(35, 30)
        Button2.TabIndex = 2
        Button2.Text = "👁"
        Button2.UseVisualStyleBackColor = False
        ' 
        ' LabelPassIcon
        ' 
        LabelPassIcon.Font = New Font("Segoe UI", 12.0F)
        LabelPassIcon.ForeColor = Color.FromArgb(CByte(65), CByte(105), CByte(225))
        LabelPassIcon.Location = New Point(278, 8)
        LabelPassIcon.Name = "LabelPassIcon"
        LabelPassIcon.Size = New Size(30, 25)
        LabelPassIcon.TabIndex = 1
        LabelPassIcon.Text = "🔒"
        LabelPassIcon.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' PanelUserContainer
        ' 
        PanelUserContainer.BackColor = Color.WhiteSmoke
        PanelUserContainer.Controls.Add(LabelUserIcon)
        PanelUserContainer.Controls.Add(TextBox1)
        PanelUserContainer.Location = New Point(42, 145)
        PanelUserContainer.Name = "PanelUserContainer"
        PanelUserContainer.Size = New Size(316, 40)
        PanelUserContainer.TabIndex = 4
        ' 
        ' LabelUserIcon
        ' 
        LabelUserIcon.Font = New Font("Segoe UI", 12.0F)
        LabelUserIcon.ForeColor = Color.FromArgb(CByte(65), CByte(105), CByte(225))
        LabelUserIcon.Location = New Point(278, 8)
        LabelUserIcon.Name = "LabelUserIcon"
        LabelUserIcon.Size = New Size(30, 25)
        LabelUserIcon.TabIndex = 1
        LabelUserIcon.Text = "👤"
        LabelUserIcon.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' LabelSubtitle
        ' 
        LabelSubtitle.AutoSize = True
        LabelSubtitle.Font = New Font("Segoe UI", 9.0F)
        LabelSubtitle.ForeColor = Color.Gray
        LabelSubtitle.Location = New Point(70, 82)
        LabelSubtitle.Name = "LabelSubtitle"
        LabelSubtitle.Size = New Size(248, 15)
        LabelSubtitle.TabIndex = 2
        LabelSubtitle.Text = "Daftar sekarang untuk mengakses semua fitur"
        ' 
        ' PanelHeaderStrip
        ' 
        PanelHeaderStrip.BackColor = Color.FromArgb(CByte(65), CByte(105), CByte(225))
        PanelHeaderStrip.Dock = DockStyle.Top
        PanelHeaderStrip.Location = New Point(0, 0)
        PanelHeaderStrip.Name = "PanelHeaderStrip"
        PanelHeaderStrip.Size = New Size(400, 5)
        PanelHeaderStrip.TabIndex = 0
        ' 
        ' FormRegister
        ' 
        AutoScaleDimensions = New SizeF(7.0F, 15.0F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(246), CByte(248), CByte(252))
        ClientSize = New Size(800, 650)
        Controls.Add(PanelCard)
        FormBorderStyle = FormBorderStyle.FixedSingle
        MaximizeBox = False
        Name = "FormRegister"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Register System"
        PanelCard.ResumeLayout(False)
        PanelCard.PerformLayout()
        PanelRoleContainer.ResumeLayout(False)
        PanelPassContainer.ResumeLayout(False)
        PanelPassContainer.PerformLayout()
        PanelUserContainer.ResumeLayout(False)
        PanelUserContainer.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents PanelCard As Panel
    Friend WithEvents PanelHeaderStrip As Panel
    Friend WithEvents LabelSubtitle As Label
    Friend WithEvents PanelUserContainer As Panel
    Friend WithEvents LabelUserIcon As Label
    Friend WithEvents PanelPassContainer As Panel
    Friend WithEvents LabelPassIcon As Label
    Friend WithEvents Button2 As Button
    Friend WithEvents PanelRoleContainer As Panel
    Friend WithEvents LabelRoleIcon As Label
    Friend WithEvents Button3 As Button
    Friend WithEvents Label5 As Label
End Class