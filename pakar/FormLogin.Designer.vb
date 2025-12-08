<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormLogin
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.PanelCard = New System.Windows.Forms.Panel()
        Me.PanelHeaderStrip = New System.Windows.Forms.Panel()
        Me.PanelUserContainer = New System.Windows.Forms.Panel()
        Me.PanelPassContainer = New System.Windows.Forms.Panel()
        Me.LabelSubtitle = New System.Windows.Forms.Label()
        Me.LabelUserIcon = New System.Windows.Forms.Label()
        Me.LabelPassIcon = New System.Windows.Forms.Label()
        Me.ButtonShowPass = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.PanelDivider = New System.Windows.Forms.Panel()
        Me.LabelWelcome = New System.Windows.Forms.Label()
        Me.PanelCard.SuspendLayout()
        Me.PanelUserContainer.SuspendLayout()
        Me.PanelPassContainer.SuspendLayout()
        Me.SuspendLayout()
        '
        'PanelCard
        '
        Me.PanelCard.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.PanelCard.BackColor = System.Drawing.Color.White
        Me.PanelCard.Controls.Add(Me.LabelWelcome)
        Me.PanelCard.Controls.Add(Me.PanelDivider)
        Me.PanelCard.Controls.Add(Me.Label4)
        Me.PanelCard.Controls.Add(Me.PanelHeaderStrip)
        Me.PanelCard.Controls.Add(Me.Label1)
        Me.PanelCard.Controls.Add(Me.Button2)
        Me.PanelCard.Controls.Add(Me.LabelSubtitle)
        Me.PanelCard.Controls.Add(Me.Button1)
        Me.PanelCard.Controls.Add(Me.Label2)
        Me.PanelCard.Controls.Add(Me.Label3)
        Me.PanelCard.Controls.Add(Me.PanelUserContainer)
        Me.PanelCard.Controls.Add(Me.PanelPassContainer)
        Me.PanelCard.Location = New System.Drawing.Point(200, 75)
        Me.PanelCard.Name = "PanelCard"
        Me.PanelCard.Size = New System.Drawing.Size(400, 500)
        Me.PanelCard.TabIndex = 7
        '
        'PanelHeaderStrip
        '
        Me.PanelHeaderStrip.BackColor = System.Drawing.Color.FromArgb(CType(CType(65, Byte), Integer), CType(CType(105, Byte), Integer), CType(CType(225, Byte), Integer))
        Me.PanelHeaderStrip.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelHeaderStrip.Location = New System.Drawing.Point(0, 0)
        Me.PanelHeaderStrip.Name = "PanelHeaderStrip"
        Me.PanelHeaderStrip.Size = New System.Drawing.Size(400, 5)
        Me.PanelHeaderStrip.TabIndex = 9
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(70, 40)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(260, 45)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Selamat Datang"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LabelSubtitle
        '
        Me.LabelSubtitle.AutoSize = True
        Me.LabelSubtitle.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.LabelSubtitle.ForeColor = System.Drawing.Color.Gray
        Me.LabelSubtitle.Location = New System.Drawing.Point(92, 90)
        Me.LabelSubtitle.Name = "LabelSubtitle"
        Me.LabelSubtitle.Size = New System.Drawing.Size(217, 17)
        Me.LabelSubtitle.TabIndex = 2
        Me.LabelSubtitle.Text = "Silahkan login untuk mengakses sistem"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.SlateGray
        Me.Label2.Location = New System.Drawing.Point(42, 175)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(69, 15)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "USERNAME"
        '
        'PanelUserContainer
        '
        Me.PanelUserContainer.BackColor = System.Drawing.Color.WhiteSmoke
        Me.PanelUserContainer.Controls.Add(Me.LabelUserIcon)
        Me.PanelUserContainer.Controls.Add(Me.TextBox1)
        Me.PanelUserContainer.Location = New System.Drawing.Point(42, 195)
        Me.PanelUserContainer.Name = "PanelUserContainer"
        Me.PanelUserContainer.Size = New System.Drawing.Size(316, 40)
        Me.PanelUserContainer.TabIndex = 7
        '
        'TextBox1
        '
        Me.TextBox1.BackColor = System.Drawing.Color.WhiteSmoke
        Me.TextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox1.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.TextBox1.Location = New System.Drawing.Point(12, 10)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(260, 20)
        Me.TextBox1.TabIndex = 3
        '
        'LabelUserIcon
        '
        Me.LabelUserIcon.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.LabelUserIcon.ForeColor = System.Drawing.Color.FromArgb(CType(CType(65, Byte), Integer), CType(CType(105, Byte), Integer), CType(CType(225, Byte), Integer))
        Me.LabelUserIcon.Location = New System.Drawing.Point(278, 7)
        Me.LabelUserIcon.Name = "LabelUserIcon"
        Me.LabelUserIcon.Size = New System.Drawing.Size(30, 25)
        Me.LabelUserIcon.TabIndex = 4
        Me.LabelUserIcon.Text = "👤"
        Me.LabelUserIcon.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.SlateGray
        Me.Label3.Location = New System.Drawing.Point(42, 255)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(73, 15)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "PASSWORD"
        '
        'PanelPassContainer
        '
        Me.PanelPassContainer.BackColor = System.Drawing.Color.WhiteSmoke
        Me.PanelPassContainer.Controls.Add(Me.ButtonShowPass)
        Me.PanelPassContainer.Controls.Add(Me.LabelPassIcon)
        Me.PanelPassContainer.Controls.Add(Me.TextBox2)
        Me.PanelPassContainer.Location = New System.Drawing.Point(42, 275)
        Me.PanelPassContainer.Name = "PanelPassContainer"
        Me.PanelPassContainer.Size = New System.Drawing.Size(316, 40)
        Me.PanelPassContainer.TabIndex = 8
        '
        'TextBox2
        '
        Me.TextBox2.BackColor = System.Drawing.Color.WhiteSmoke
        Me.TextBox2.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox2.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.TextBox2.Location = New System.Drawing.Point(12, 10)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.PasswordChar = Global.Microsoft.VisualBasic.ChrW(8226)
        Me.TextBox2.Size = New System.Drawing.Size(220, 20)
        Me.TextBox2.TabIndex = 4
        Me.TextBox2.UseSystemPasswordChar = True
        '
        'LabelPassIcon
        '
        Me.LabelPassIcon.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.LabelPassIcon.ForeColor = System.Drawing.Color.FromArgb(CType(CType(65, Byte), Integer), CType(CType(105, Byte), Integer), CType(CType(225, Byte), Integer))
        Me.LabelPassIcon.Location = New System.Drawing.Point(278, 7)
        Me.LabelPassIcon.Name = "LabelPassIcon"
        Me.LabelPassIcon.Size = New System.Drawing.Size(30, 25)
        Me.LabelPassIcon.TabIndex = 5
        Me.LabelPassIcon.Text = "🔒"
        Me.LabelPassIcon.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'ButtonShowPass
        '
        Me.ButtonShowPass.BackColor = System.Drawing.Color.Transparent
        Me.ButtonShowPass.FlatAppearance.BorderSize = 0
        Me.ButtonShowPass.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonShowPass.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.ButtonShowPass.ForeColor = System.Drawing.Color.Gray
        Me.ButtonShowPass.Location = New System.Drawing.Point(238, 5)
        Me.ButtonShowPass.Name = "ButtonShowPass"
        Me.ButtonShowPass.Size = New System.Drawing.Size(35, 30)
        Me.ButtonShowPass.TabIndex = 6
        Me.ButtonShowPass.Text = "👁"
        Me.ButtonShowPass.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(65, Byte), Integer), CType(CType(105, Byte), Integer), CType(CType(225, Byte), Integer))
        Me.Button1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Segoe UI Semibold", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.White
        Me.Button1.Location = New System.Drawing.Point(42, 340)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(316, 50)
        Me.Button1.TabIndex = 5
        Me.Button1.Text = "✦  Masuk Sekarang  ✦"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'PanelDivider
        '
        Me.PanelDivider.BackColor = System.Drawing.Color.FromArgb(CType(CType(220, Byte), Integer), CType(CType(220, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.PanelDivider.Location = New System.Drawing.Point(42, 405)
        Me.PanelDivider.Name = "PanelDivider"
        Me.PanelDivider.Size = New System.Drawing.Size(316, 1)
        Me.PanelDivider.TabIndex = 10
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label4.ForeColor = System.Drawing.Color.Gray
        Me.Label4.Location = New System.Drawing.Point(115, 416)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(170, 13)
        Me.Label4.TabIndex = 11
        Me.Label4.Text = "Belum memiliki akun? Daftar dulu"
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.White
        Me.Button2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button2.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(65, Byte), Integer), CType(CType(105, Byte), Integer), CType(CType(225, Byte), Integer))
        Me.Button2.FlatAppearance.BorderSize = 2
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(65, Byte), Integer), CType(CType(105, Byte), Integer), CType(CType(225, Byte), Integer))
        Me.Button2.Location = New System.Drawing.Point(42, 440)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(316, 40)
        Me.Button2.TabIndex = 6
        Me.Button2.Text = "Buat Akun Baru"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'FormLogin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(246, Byte), Integer), CType(CType(248, Byte), Integer), CType(CType(252, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(800, 650)
        Me.Controls.Add(Me.PanelCard)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "FormLogin"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Login System"
        Me.PanelCard.ResumeLayout(False)
        Me.PanelCard.PerformLayout()
        Me.PanelUserContainer.ResumeLayout(False)
        Me.PanelUserContainer.PerformLayout()
        Me.PanelPassContainer.ResumeLayout(False)
        Me.PanelPassContainer.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents PanelCard As System.Windows.Forms.Panel
    Friend WithEvents PanelUserContainer As System.Windows.Forms.Panel
    Friend WithEvents PanelPassContainer As System.Windows.Forms.Panel
    Friend WithEvents LabelSubtitle As System.Windows.Forms.Label
    Friend WithEvents PanelHeaderStrip As System.Windows.Forms.Panel
    Friend WithEvents LabelUserIcon As System.Windows.Forms.Label
    Friend WithEvents LabelPassIcon As System.Windows.Forms.Label
    Friend WithEvents ButtonShowPass As System.Windows.Forms.Button
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents PanelDivider As System.Windows.Forms.Panel
    Friend WithEvents LabelWelcome As System.Windows.Forms.Label
End Class