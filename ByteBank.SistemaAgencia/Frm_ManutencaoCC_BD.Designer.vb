<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_ManutencaoCC_BD
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Frm_ManutencaoCC_BD))
        Me.Grp_Lista = New System.Windows.Forms.GroupBox()
        Me.Lvw_Contas = New System.Windows.Forms.ListView()
        Me.Grp_CriterioOrdenacao = New System.Windows.Forms.GroupBox()
        Me.Rb_Saldo = New System.Windows.Forms.RadioButton()
        Me.Rb_Nome = New System.Windows.Forms.RadioButton()
        Me.Rb_Conta = New System.Windows.Forms.RadioButton()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.NovoToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton()
        Me.SaveToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.toolStripSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.toolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.Grp_Lista.SuspendLayout()
        Me.Grp_CriterioOrdenacao.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Grp_Lista
        '
        Me.Grp_Lista.Controls.Add(Me.Lvw_Contas)
        Me.Grp_Lista.Location = New System.Drawing.Point(12, 28)
        Me.Grp_Lista.Name = "Grp_Lista"
        Me.Grp_Lista.Size = New System.Drawing.Size(475, 370)
        Me.Grp_Lista.TabIndex = 1
        Me.Grp_Lista.TabStop = False
        Me.Grp_Lista.Text = "GroupBox1"
        '
        'Lvw_Contas
        '
        Me.Lvw_Contas.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Lvw_Contas.HideSelection = False
        Me.Lvw_Contas.Location = New System.Drawing.Point(3, 16)
        Me.Lvw_Contas.Name = "Lvw_Contas"
        Me.Lvw_Contas.Size = New System.Drawing.Size(469, 351)
        Me.Lvw_Contas.TabIndex = 0
        Me.Lvw_Contas.UseCompatibleStateImageBehavior = False
        '
        'Grp_CriterioOrdenacao
        '
        Me.Grp_CriterioOrdenacao.Controls.Add(Me.Rb_Saldo)
        Me.Grp_CriterioOrdenacao.Controls.Add(Me.Rb_Nome)
        Me.Grp_CriterioOrdenacao.Controls.Add(Me.Rb_Conta)
        Me.Grp_CriterioOrdenacao.Location = New System.Drawing.Point(12, 411)
        Me.Grp_CriterioOrdenacao.Name = "Grp_CriterioOrdenacao"
        Me.Grp_CriterioOrdenacao.Size = New System.Drawing.Size(475, 42)
        Me.Grp_CriterioOrdenacao.TabIndex = 3
        Me.Grp_CriterioOrdenacao.TabStop = False
        Me.Grp_CriterioOrdenacao.Text = "GroupBox1"
        '
        'Rb_Saldo
        '
        Me.Rb_Saldo.AutoSize = True
        Me.Rb_Saldo.Location = New System.Drawing.Point(274, 19)
        Me.Rb_Saldo.Name = "Rb_Saldo"
        Me.Rb_Saldo.Size = New System.Drawing.Size(90, 17)
        Me.Rb_Saldo.TabIndex = 2
        Me.Rb_Saldo.TabStop = True
        Me.Rb_Saldo.Text = "RadioButton3"
        Me.Rb_Saldo.UseVisualStyleBackColor = True
        '
        'Rb_Nome
        '
        Me.Rb_Nome.AutoSize = True
        Me.Rb_Nome.Location = New System.Drawing.Point(135, 20)
        Me.Rb_Nome.Name = "Rb_Nome"
        Me.Rb_Nome.Size = New System.Drawing.Size(90, 17)
        Me.Rb_Nome.TabIndex = 1
        Me.Rb_Nome.TabStop = True
        Me.Rb_Nome.Text = "RadioButton2"
        Me.Rb_Nome.UseVisualStyleBackColor = True
        '
        'Rb_Conta
        '
        Me.Rb_Conta.AutoSize = True
        Me.Rb_Conta.Location = New System.Drawing.Point(7, 20)
        Me.Rb_Conta.Name = "Rb_Conta"
        Me.Rb_Conta.Size = New System.Drawing.Size(90, 17)
        Me.Rb_Conta.TabIndex = 0
        Me.Rb_Conta.TabStop = True
        Me.Rb_Conta.Text = "RadioButton1"
        Me.Rb_Conta.UseVisualStyleBackColor = True
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NovoToolStripButton, Me.ToolStripButton1, Me.SaveToolStripButton, Me.toolStripSeparator, Me.toolStripSeparator1})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(499, 25)
        Me.ToolStrip1.TabIndex = 4
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'NovoToolStripButton
        '
        Me.NovoToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.NovoToolStripButton.Image = CType(resources.GetObject("NovoToolStripButton.Image"), System.Drawing.Image)
        Me.NovoToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.NovoToolStripButton.Name = "NovoToolStripButton"
        Me.NovoToolStripButton.Size = New System.Drawing.Size(23, 22)
        Me.NovoToolStripButton.Text = "&Novo"
        '
        'ToolStripButton1
        '
        Me.ToolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton1.Image = CType(resources.GetObject("ToolStripButton1.Image"), System.Drawing.Image)
        Me.ToolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton1.Name = "ToolStripButton1"
        Me.ToolStripButton1.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton1.Text = "Apagar"
        '
        'SaveToolStripButton
        '
        Me.SaveToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.SaveToolStripButton.Image = CType(resources.GetObject("SaveToolStripButton.Image"), System.Drawing.Image)
        Me.SaveToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.SaveToolStripButton.Name = "SaveToolStripButton"
        Me.SaveToolStripButton.Size = New System.Drawing.Size(23, 22)
        Me.SaveToolStripButton.Text = "&Save"
        '
        'toolStripSeparator
        '
        Me.toolStripSeparator.Name = "toolStripSeparator"
        Me.toolStripSeparator.Size = New System.Drawing.Size(6, 25)
        '
        'toolStripSeparator1
        '
        Me.toolStripSeparator1.Name = "toolStripSeparator1"
        Me.toolStripSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'Frm_ManutencaoCC_BD
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(499, 465)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.Grp_CriterioOrdenacao)
        Me.Controls.Add(Me.Grp_Lista)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Frm_ManutencaoCC_BD"
        Me.Text = "Frm_ManutencaoCC_BD"
        Me.Grp_Lista.ResumeLayout(False)
        Me.Grp_CriterioOrdenacao.ResumeLayout(False)
        Me.Grp_CriterioOrdenacao.PerformLayout()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Grp_Lista As GroupBox
    Friend WithEvents Lvw_Contas As ListView
    Friend WithEvents Grp_CriterioOrdenacao As GroupBox
    Friend WithEvents Rb_Saldo As RadioButton
    Friend WithEvents Rb_Nome As RadioButton
    Friend WithEvents Rb_Conta As RadioButton
    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents NovoToolStripButton As ToolStripButton
    Friend WithEvents ToolStripButton1 As ToolStripButton
    Friend WithEvents SaveToolStripButton As ToolStripButton
    Friend WithEvents toolStripSeparator As ToolStripSeparator
    Friend WithEvents toolStripSeparator1 As ToolStripSeparator
End Class
