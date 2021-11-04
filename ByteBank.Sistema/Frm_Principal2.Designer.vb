<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_Principal2
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
        Me.Lbl_Principal2 = New System.Windows.Forms.Label()
        Me.Txt_URL = New System.Windows.Forms.TextBox()
        Me.Lbl_URL = New System.Windows.Forms.Label()
        Me.Lbl_Argumento = New System.Windows.Forms.Label()
        Me.Txt_Argumento = New System.Windows.Forms.TextBox()
        Me.Btm_Processa = New System.Windows.Forms.Button()
        Me.Lbl_Propriedade = New System.Windows.Forms.Label()
        Me.Txt_Propriedade = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'Lbl_Principal2
        '
        Me.Lbl_Principal2.AutoSize = True
        Me.Lbl_Principal2.Location = New System.Drawing.Point(13, 13)
        Me.Lbl_Principal2.Name = "Lbl_Principal2"
        Me.Lbl_Principal2.Size = New System.Drawing.Size(39, 13)
        Me.Lbl_Principal2.TabIndex = 0
        Me.Lbl_Principal2.Text = "Label1"
        '
        'Txt_URL
        '
        Me.Txt_URL.Location = New System.Drawing.Point(18, 75)
        Me.Txt_URL.Multiline = True
        Me.Txt_URL.Name = "Txt_URL"
        Me.Txt_URL.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.Txt_URL.Size = New System.Drawing.Size(766, 97)
        Me.Txt_URL.TabIndex = 6
        '
        'Lbl_URL
        '
        Me.Lbl_URL.AutoSize = True
        Me.Lbl_URL.Location = New System.Drawing.Point(15, 49)
        Me.Lbl_URL.Name = "Lbl_URL"
        Me.Lbl_URL.Size = New System.Drawing.Size(39, 13)
        Me.Lbl_URL.TabIndex = 5
        Me.Lbl_URL.Text = "Label1"
        '
        'Lbl_Argumento
        '
        Me.Lbl_Argumento.AutoSize = True
        Me.Lbl_Argumento.Location = New System.Drawing.Point(15, 185)
        Me.Lbl_Argumento.Name = "Lbl_Argumento"
        Me.Lbl_Argumento.Size = New System.Drawing.Size(39, 13)
        Me.Lbl_Argumento.TabIndex = 7
        Me.Lbl_Argumento.Text = "Label1"
        '
        'Txt_Argumento
        '
        Me.Txt_Argumento.Location = New System.Drawing.Point(16, 217)
        Me.Txt_Argumento.Multiline = True
        Me.Txt_Argumento.Name = "Txt_Argumento"
        Me.Txt_Argumento.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.Txt_Argumento.Size = New System.Drawing.Size(766, 110)
        Me.Txt_Argumento.TabIndex = 8
        '
        'Btm_Processa
        '
        Me.Btm_Processa.Location = New System.Drawing.Point(653, 180)
        Me.Btm_Processa.Name = "Btm_Processa"
        Me.Btm_Processa.Size = New System.Drawing.Size(129, 23)
        Me.Btm_Processa.TabIndex = 9
        Me.Btm_Processa.Text = "Button1"
        Me.Btm_Processa.UseVisualStyleBackColor = True
        '
        'Lbl_Propriedade
        '
        Me.Lbl_Propriedade.AutoSize = True
        Me.Lbl_Propriedade.Location = New System.Drawing.Point(15, 342)
        Me.Lbl_Propriedade.Name = "Lbl_Propriedade"
        Me.Lbl_Propriedade.Size = New System.Drawing.Size(39, 13)
        Me.Lbl_Propriedade.TabIndex = 10
        Me.Lbl_Propriedade.Text = "Label1"
        '
        'Txt_Propriedade
        '
        Me.Txt_Propriedade.Location = New System.Drawing.Point(16, 373)
        Me.Txt_Propriedade.Name = "Txt_Propriedade"
        Me.Txt_Propriedade.Size = New System.Drawing.Size(650, 20)
        Me.Txt_Propriedade.TabIndex = 11
        '
        'Frm_Principal2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(796, 405)
        Me.Controls.Add(Me.Txt_Propriedade)
        Me.Controls.Add(Me.Lbl_Propriedade)
        Me.Controls.Add(Me.Btm_Processa)
        Me.Controls.Add(Me.Txt_Argumento)
        Me.Controls.Add(Me.Lbl_Argumento)
        Me.Controls.Add(Me.Txt_URL)
        Me.Controls.Add(Me.Lbl_URL)
        Me.Controls.Add(Me.Lbl_Principal2)
        Me.Name = "Frm_Principal2"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Frm_Principal2"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Lbl_Principal2 As Label
    Friend WithEvents Txt_URL As TextBox
    Friend WithEvents Lbl_URL As Label
    Friend WithEvents Lbl_Argumento As Label
    Friend WithEvents Txt_Argumento As TextBox
    Friend WithEvents Btm_Processa As Button
    Friend WithEvents Lbl_Propriedade As Label
    Friend WithEvents Txt_Propriedade As TextBox
End Class
