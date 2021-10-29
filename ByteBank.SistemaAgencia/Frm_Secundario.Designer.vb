<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_Secundario
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Frm_Secundario))
        Me.Pic_Logo = New System.Windows.Forms.PictureBox()
        CType(Me.Pic_Logo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Pic_Logo
        '
        Me.Pic_Logo.Image = Global.ByteBank.SistemaAgencia.My.Resources.Resources.ByteBankImage2
        Me.Pic_Logo.Location = New System.Drawing.Point(12, 12)
        Me.Pic_Logo.Name = "Pic_Logo"
        Me.Pic_Logo.Size = New System.Drawing.Size(327, 243)
        Me.Pic_Logo.TabIndex = 0
        Me.Pic_Logo.TabStop = False
        '
        'Frm_Secundario
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(348, 269)
        Me.Controls.Add(Me.Pic_Logo)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Frm_Secundario"
        Me.Text = "Frm_Secundario"
        CType(Me.Pic_Logo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Pic_Logo As PictureBox
End Class
