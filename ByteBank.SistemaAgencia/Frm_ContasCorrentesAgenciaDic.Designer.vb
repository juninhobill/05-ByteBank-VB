<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_ContasCorrentesAgenciaDic
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
        Me.Txt_Array = New System.Windows.Forms.TextBox()
        Me.Btm_Remover = New System.Windows.Forms.Button()
        Me.Btm_Adicionar = New System.Windows.Forms.Button()
        Me.Txt_Conta = New System.Windows.Forms.TextBox()
        Me.Lbl_Agencia = New System.Windows.Forms.Label()
        Me.Txt_Nome = New System.Windows.Forms.TextBox()
        Me.Grp_Conta = New System.Windows.Forms.GroupBox()
        Me.Grp_Busca = New System.Windows.Forms.GroupBox()
        Me.Txt_Resultado = New System.Windows.Forms.TextBox()
        Me.Btm_Busca = New System.Windows.Forms.Button()
        Me.Txt_CCBusca = New System.Windows.Forms.TextBox()
        Me.Grp_AlterarCC = New System.Windows.Forms.GroupBox()
        Me.Txt_NomeAlterar = New System.Windows.Forms.TextBox()
        Me.Txt_CCAlterar = New System.Windows.Forms.TextBox()
        Me.Btm_AlterarCC = New System.Windows.Forms.Button()
        Me.Grp_Conta.SuspendLayout()
        Me.Grp_Busca.SuspendLayout()
        Me.Grp_AlterarCC.SuspendLayout()
        Me.SuspendLayout()
        '
        'Txt_Array
        '
        Me.Txt_Array.Location = New System.Drawing.Point(315, 13)
        Me.Txt_Array.Multiline = True
        Me.Txt_Array.Name = "Txt_Array"
        Me.Txt_Array.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.Txt_Array.Size = New System.Drawing.Size(363, 335)
        Me.Txt_Array.TabIndex = 14
        '
        'Btm_Remover
        '
        Me.Btm_Remover.Location = New System.Drawing.Point(161, 85)
        Me.Btm_Remover.Name = "Btm_Remover"
        Me.Btm_Remover.Size = New System.Drawing.Size(75, 23)
        Me.Btm_Remover.TabIndex = 13
        Me.Btm_Remover.Text = "Button1"
        Me.Btm_Remover.UseVisualStyleBackColor = True
        '
        'Btm_Adicionar
        '
        Me.Btm_Adicionar.Location = New System.Drawing.Point(161, 56)
        Me.Btm_Adicionar.Name = "Btm_Adicionar"
        Me.Btm_Adicionar.Size = New System.Drawing.Size(75, 23)
        Me.Btm_Adicionar.TabIndex = 12
        Me.Btm_Adicionar.Text = "Button1"
        Me.Btm_Adicionar.UseVisualStyleBackColor = True
        '
        'Txt_Conta
        '
        Me.Txt_Conta.Location = New System.Drawing.Point(9, 59)
        Me.Txt_Conta.Name = "Txt_Conta"
        Me.Txt_Conta.Size = New System.Drawing.Size(130, 20)
        Me.Txt_Conta.TabIndex = 11
        '
        'Lbl_Agencia
        '
        Me.Lbl_Agencia.AutoSize = True
        Me.Lbl_Agencia.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_Agencia.Location = New System.Drawing.Point(6, 16)
        Me.Lbl_Agencia.Name = "Lbl_Agencia"
        Me.Lbl_Agencia.Size = New System.Drawing.Size(72, 24)
        Me.Lbl_Agencia.TabIndex = 8
        Me.Lbl_Agencia.Text = "Label1"
        '
        'Txt_Nome
        '
        Me.Txt_Nome.Location = New System.Drawing.Point(9, 85)
        Me.Txt_Nome.Name = "Txt_Nome"
        Me.Txt_Nome.Size = New System.Drawing.Size(130, 20)
        Me.Txt_Nome.TabIndex = 21
        '
        'Grp_Conta
        '
        Me.Grp_Conta.Controls.Add(Me.Lbl_Agencia)
        Me.Grp_Conta.Controls.Add(Me.Txt_Nome)
        Me.Grp_Conta.Controls.Add(Me.Txt_Conta)
        Me.Grp_Conta.Controls.Add(Me.Btm_Adicionar)
        Me.Grp_Conta.Controls.Add(Me.Btm_Remover)
        Me.Grp_Conta.Location = New System.Drawing.Point(12, 13)
        Me.Grp_Conta.Name = "Grp_Conta"
        Me.Grp_Conta.Size = New System.Drawing.Size(256, 116)
        Me.Grp_Conta.TabIndex = 22
        Me.Grp_Conta.TabStop = False
        Me.Grp_Conta.Text = "GroupBox1"
        '
        'Grp_Busca
        '
        Me.Grp_Busca.Controls.Add(Me.Txt_Resultado)
        Me.Grp_Busca.Controls.Add(Me.Btm_Busca)
        Me.Grp_Busca.Controls.Add(Me.Txt_CCBusca)
        Me.Grp_Busca.Location = New System.Drawing.Point(12, 135)
        Me.Grp_Busca.Name = "Grp_Busca"
        Me.Grp_Busca.Size = New System.Drawing.Size(256, 125)
        Me.Grp_Busca.TabIndex = 23
        Me.Grp_Busca.TabStop = False
        Me.Grp_Busca.Text = "GroupBox1"
        '
        'Txt_Resultado
        '
        Me.Txt_Resultado.Location = New System.Drawing.Point(9, 61)
        Me.Txt_Resultado.Multiline = True
        Me.Txt_Resultado.Name = "Txt_Resultado"
        Me.Txt_Resultado.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.Txt_Resultado.Size = New System.Drawing.Size(227, 58)
        Me.Txt_Resultado.TabIndex = 24
        '
        'Btm_Busca
        '
        Me.Btm_Busca.Location = New System.Drawing.Point(161, 32)
        Me.Btm_Busca.Name = "Btm_Busca"
        Me.Btm_Busca.Size = New System.Drawing.Size(75, 23)
        Me.Btm_Busca.TabIndex = 23
        Me.Btm_Busca.Text = "Button1"
        Me.Btm_Busca.UseVisualStyleBackColor = True
        '
        'Txt_CCBusca
        '
        Me.Txt_CCBusca.Location = New System.Drawing.Point(9, 32)
        Me.Txt_CCBusca.Name = "Txt_CCBusca"
        Me.Txt_CCBusca.Size = New System.Drawing.Size(130, 20)
        Me.Txt_CCBusca.TabIndex = 22
        '
        'Grp_AlterarCC
        '
        Me.Grp_AlterarCC.Controls.Add(Me.Txt_NomeAlterar)
        Me.Grp_AlterarCC.Controls.Add(Me.Txt_CCAlterar)
        Me.Grp_AlterarCC.Controls.Add(Me.Btm_AlterarCC)
        Me.Grp_AlterarCC.Location = New System.Drawing.Point(12, 266)
        Me.Grp_AlterarCC.Name = "Grp_AlterarCC"
        Me.Grp_AlterarCC.Size = New System.Drawing.Size(256, 82)
        Me.Grp_AlterarCC.TabIndex = 24
        Me.Grp_AlterarCC.TabStop = False
        Me.Grp_AlterarCC.Text = "GroupBox1"
        '
        'Txt_NomeAlterar
        '
        Me.Txt_NomeAlterar.Location = New System.Drawing.Point(9, 45)
        Me.Txt_NomeAlterar.Name = "Txt_NomeAlterar"
        Me.Txt_NomeAlterar.Size = New System.Drawing.Size(130, 20)
        Me.Txt_NomeAlterar.TabIndex = 21
        '
        'Txt_CCAlterar
        '
        Me.Txt_CCAlterar.Location = New System.Drawing.Point(9, 19)
        Me.Txt_CCAlterar.Name = "Txt_CCAlterar"
        Me.Txt_CCAlterar.Size = New System.Drawing.Size(130, 20)
        Me.Txt_CCAlterar.TabIndex = 11
        '
        'Btm_AlterarCC
        '
        Me.Btm_AlterarCC.Location = New System.Drawing.Point(161, 33)
        Me.Btm_AlterarCC.Name = "Btm_AlterarCC"
        Me.Btm_AlterarCC.Size = New System.Drawing.Size(75, 23)
        Me.Btm_AlterarCC.TabIndex = 12
        Me.Btm_AlterarCC.Text = "Button1"
        Me.Btm_AlterarCC.UseVisualStyleBackColor = True
        '
        'Frm_ContasCorrentesAgenciaDic
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(693, 361)
        Me.Controls.Add(Me.Grp_AlterarCC)
        Me.Controls.Add(Me.Grp_Busca)
        Me.Controls.Add(Me.Grp_Conta)
        Me.Controls.Add(Me.Txt_Array)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Frm_ContasCorrentesAgenciaDic"
        Me.Text = "Frm_ContasCorrentesArray"
        Me.Grp_Conta.ResumeLayout(False)
        Me.Grp_Conta.PerformLayout()
        Me.Grp_Busca.ResumeLayout(False)
        Me.Grp_Busca.PerformLayout()
        Me.Grp_AlterarCC.ResumeLayout(False)
        Me.Grp_AlterarCC.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Txt_Array As TextBox
    Friend WithEvents Btm_Remover As Button
    Friend WithEvents Btm_Adicionar As Button
    Friend WithEvents Txt_Conta As TextBox
    Friend WithEvents Lbl_Agencia As Label
    Friend WithEvents Txt_Nome As TextBox
    Friend WithEvents Grp_Conta As GroupBox
    Friend WithEvents Grp_Busca As GroupBox
    Friend WithEvents Txt_Resultado As TextBox
    Friend WithEvents Btm_Busca As Button
    Friend WithEvents Txt_CCBusca As TextBox
    Friend WithEvents Grp_AlterarCC As GroupBox
    Friend WithEvents Txt_NomeAlterar As TextBox
    Friend WithEvents Txt_CCAlterar As TextBox
    Friend WithEvents Btm_AlterarCC As Button
End Class