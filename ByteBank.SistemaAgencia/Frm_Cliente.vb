Public Class Frm_Cliente
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

        Me.Text = "Cadastro de Clientes"

    End Sub

    Private Sub ClienteBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles ClienteBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.ClienteBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.ByteBankDBDataSet)

    End Sub

    Private Sub Frm_Cliente_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'ByteBankDBDataSet.Cliente' table. You can move, or remove it, as needed.
        Me.ClienteTableAdapter.Fill(Me.ByteBankDBDataSet.Cliente)

    End Sub
End Class