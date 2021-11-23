Public Class Frm_Cliente_SQLServer
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

        Me.Text = "Cadastro de Clientes SQL Server"

    End Sub

    Private Sub ClienteBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles ClienteBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.ClienteBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.BytebankDataSet)

    End Sub

    Private Sub Frm_Cliente_SQLServer_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'BytebankDataSet.Cliente' table. You can move, or remove it, as needed.
        Me.ClienteTableAdapter.Fill(Me.BytebankDataSet.Cliente)

    End Sub
End Class