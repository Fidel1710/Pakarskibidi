<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormHasil
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        ListBoxHasil = New ListBox()
        TextBoxDetail = New TextBox()
        ButtonCetak = New Button()
        SuspendLayout()
        ' 
        ' ListBoxHasil
        ' 
        ListBoxHasil.FormattingEnabled = True
        ListBoxHasil.ItemHeight = 15
        ListBoxHasil.Location = New Point(561, 48)
        ListBoxHasil.Name = "ListBoxHasil"
        ListBoxHasil.Size = New Size(216, 259)
        ListBoxHasil.TabIndex = 0
        ' 
        ' TextBoxDetail
        ' 
        TextBoxDetail.Location = New Point(49, 48)
        TextBoxDetail.Multiline = True
        TextBoxDetail.Name = "TextBoxDetail"
        TextBoxDetail.Size = New Size(450, 266)
        TextBoxDetail.TabIndex = 1
        ' 
        ' ButtonCetak
        ' 
        ButtonCetak.Location = New Point(308, 326)
        ButtonCetak.Name = "ButtonCetak"
        ButtonCetak.Size = New Size(75, 23)
        ButtonCetak.TabIndex = 2
        ButtonCetak.Text = "Button1"
        ButtonCetak.UseVisualStyleBackColor = True
        ' 
        ' FormHasil
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1092, 624)
        Controls.Add(ButtonCetak)
        Controls.Add(TextBoxDetail)
        Controls.Add(ListBoxHasil)
        Name = "FormHasil"
        Text = "FormHasil"
        WindowState = FormWindowState.Maximized
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents ListBoxHasil As ListBox
    Friend WithEvents TextBoxDetail As TextBox
    Friend WithEvents ButtonCetak As Button
End Class
