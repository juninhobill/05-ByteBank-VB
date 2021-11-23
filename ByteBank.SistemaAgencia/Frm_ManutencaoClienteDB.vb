Imports ByteBank.Bibliotecas.Classes.BancoDeDados

Public Class Frm_ManutencaoClienteDB
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

        Me.Text = "Manutenção Clientes"
        Grp_Lista.Text = "Lista de Clientes"
        Lbl_CPF.Text = "CPF"
        Lbl_Nome.Text = "Nome"
        Lbl_Profissao.Text = "Profissao"

        FormatarListView()
        CriarColunas()
        AtualizarListView()

    End Sub

    Sub FormatarListView()
        ' Formatar o ListView

        Lvw_Clientes.View = View.Details
        Lvw_Clientes.LabelEdit = False
        Lvw_Clientes.AllowColumnReorder = False
        Lvw_Clientes.FullRowSelect = True
        Lvw_Clientes.GridLines = True

    End Sub

    Sub CriarColunas()
        ' Configurar colunas

        Lvw_Clientes.Columns.Add("CPF", 100, HorizontalAlignment.Center)
        Lvw_Clientes.Columns.Add("Nome", 150, HorizontalAlignment.Center)
        Lvw_Clientes.Columns.Add("Profissão", 100, HorizontalAlignment.Center)
    End Sub

    Sub AtualizarListView()

        ' Inclusao dos elementos

        Lvw_Clientes.Items.Clear()
        Try
            Dim Dt As New DataTable
            Dt = ManutencaoClienteBD.RetornaClientes()

            For I As Integer = 0 To Dt.Rows.Count - 1
                Dim Linha As New ListViewItem
                Linha.Name = Dt.Rows(I)("CPF").ToString
                Linha.Text = Dt.Rows(I)("CPF").ToString
                Linha.SubItems.Add(Dt.Rows(I)("nome").ToString)
                Linha.SubItems.Add(Dt.Rows(I)("profissao").ToString)
                Lvw_Clientes.Items.Add(Linha)
            Next
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub Lvw_Clientes_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Lvw_Clientes.SelectedIndexChanged

        For I As Integer = 0 To Lvw_Clientes.Items.Count - 1
            If Lvw_Clientes.Items(I).Selected Then
                Txt_CPF.Text = Lvw_Clientes.Items(I).SubItems(0).Text
                Txt_Nome.Text = Lvw_Clientes.Items(I).SubItems(1).Text
                Txt_Profissao.Text = Lvw_Clientes.Items(I).SubItems(2).Text
                Exit For
            End If
        Next

    End Sub

    Private Sub NovoToolStripButton_Click(sender As Object, e As EventArgs) Handles NovoToolStripButton.Click

        If Txt_CPF.Text = "" Then
            MsgBox("Cpf vazio.")
        Else
            If Txt_Nome.Text = "" Then
                MsgBox("Nome vazio.")
            Else
                If Txt_Profissao.Text = "" Then
                    MsgBox("Profissão vazio.")
                Else
                    Try
                        Dim vRetorno As String = ManutencaoClienteBD.EditaCliente(Txt_CPF.Text, Txt_Nome.Text, Txt_Profissao.Text)
                        MsgBox(vRetorno)
                        AtualizarListView()
                    Catch ex As Exception
                        MsgBox(ex.Message)
                    End Try

                End If
            End If
        End If

    End Sub

    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs) Handles ToolStripButton1.Click

        If Txt_CPF.Text = "" Then
            MsgBox("Cpf vazio.")
        Else
            Try
                Dim vRetorno As String = ManutencaoClienteBD.ExcluiCliente(Txt_CPF.Text)
                MsgBox(vRetorno)
                AtualizarListView()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try

        End If

    End Sub
End Class