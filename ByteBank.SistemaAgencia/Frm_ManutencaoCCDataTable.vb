﻿Imports ByteBank.Bibliotecas.Classes.Clientes

Public Class Frm_ManutencaoCCDataTable

    Public DS As New DataSet
    Public DtListView As New DataTable

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

        Me.Text = "Manutenção Conta Corrente"
        Grp_Lista.Text = "Lista de Contas Correntes"
        Grp_CriterioOrdenacao.Text = "Critério de Ordenação"
        Rb_Conta.Text = "Conta"
        Rb_Nome.Text = "Nome"
        Rb_Saldo.Text = "Saldo"

        InicializacaoContas()
        FormatarListView()
        CriarColunas()
        CriarDataTableListView()
        'AtualizarListView()
        AtualizarListView1()
        AtualizarListView2()

    End Sub

    Sub InicializacaoContas()
        ' #################################################################################
        ' Criar uma lista de contas correntes e clientes
        ' #################################################################################

        Dim Cliente As New List(Of Cliente)

        Cliente.Add(CriarCliente("123456789", "João Tavela", "Médico"))
        Cliente.Add(CriarCliente("987654321", "José Silva", "Engenheiro"))
        Cliente.Add(CriarCliente("543409789", "Alberto Luis", "Bombeiro"))
        Cliente.Add(CriarCliente("543456789", "Luis Castro", "Dentista"))
        Cliente.Add(CriarCliente("983456789", "Diogo Barbosa", "Mecanico"))
        Cliente.Add(CriarCliente("873456789", "Eduardo Andrade", "Analista de Sistemas"))

        Dim Contas As New List(Of ContaCorrente)

        Contas.Add(New ContaCorrente(277, 1234532))
        Contas(0).titular = Cliente(0)
        Contas.Add(New ContaCorrente(277, 1239832))
        Contas(1).titular = Cliente(0)
        Contas.Add(New ContaCorrente(277, 9345372))
        Contas(2).titular = Cliente(2)
        Contas.Add(New ContaCorrente(277, 5434532))
        Contas(3).titular = Cliente(1)
        Contas.Add(New ContaCorrente(277, 8734532))
        Contas(4).titular = Cliente(1)
        Contas.Add(New ContaCorrente(277, 1344532))
        Contas(5).titular = Cliente(3)
        Contas.Add(New ContaCorrente(277, 5434531))
        Contas(6).titular = Cliente(3)
        Contas.Add(New ContaCorrente(277, 7654532))
        Contas(7).titular = Cliente(4)
        Contas.Add(New ContaCorrente(277, 9875732))
        Contas(8).titular = Cliente(5)

        ' #################################################################################
        ' Criar tabela de contas correntes
        ' #################################################################################

        ' Conta Corrente: Agencia (Int), Conta (Int), cpf (String), saldo (Double)

        Dim Dt As New DataTable

        Dt.Columns.Add(CriarColuna("Agencia", "System.Int32"))
        Dt.Columns.Add(CriarColuna("Conta", "System.Int32"))
        Dt.Columns.Add(CriarColuna("CPF", "System.String"))
        Dt.Columns.Add(CriarColuna("Saldo", "System.Double"))

        ' Definir chave primária 

        Dim vArrayChavesContas(1) As DataColumn
        Dt.Columns("Agencia").AllowDBNull = False
        Dt.Columns("Conta").AllowDBNull = False
        vArrayChavesContas(0) = Dt.Columns("Agencia")
        vArrayChavesContas(1) = Dt.Columns("Conta")
        Dt.PrimaryKey = vArrayChavesContas

        ' Nome da tabela

        Dt.TableName = "Contas Correntes"

        ' #################################################################################
        ' Criar a tabela de clientes
        ' #################################################################################

        Dim Dt2 As New DataTable
        Dt2.Columns.Add(CriarColuna("CPF", "System.String"))
        Dt2.Columns.Add(CriarColuna("Nome", "System.String"))
        Dt2.Columns.Add(CriarColuna("Profissao", "System.String"))

        ' Criando chave primária para cliente

        Dim vArrayChavesCliente(0) As DataColumn
        Dt2.Columns("CPF").AllowDBNull = False
        vArrayChavesCliente(0) = Dt2.Columns("CPF")
        Dt2.PrimaryKey = vArrayChavesCliente

        ' Nome da tabela

        Dt2.TableName = "Clientes"

        ' #################################################################################
        ' Criar o dataset
        ' #################################################################################

        DS.Tables.Add(Dt)
        DS.Tables.Add(Dt2)

        ' #################################################################################
        ' Criar a chave estrangeira
        ' Clientes -----> Contas Correntes (FK)
        ' #################################################################################

        Dim FKClientesCC As New ForeignKeyConstraint("FKClientesCC", DS.Tables("Clientes").Columns("CPF"),
                                                     DS.Tables("Contas Correntes").Columns("CPF"))
        FKClientesCC.DeleteRule = Rule.None
        DS.Tables("Contas Correntes").Constraints.Add(FKClientesCC)

        ' #################################################################################
        ' Incluir dados da tabela de clientes do dataset
        ' #################################################################################

        For I As Integer = 0 To Cliente.Count - 1
            Dim ClienteAtual As Cliente = Cliente(I)
            Dim Dr As DataRow = DS.Tables("Clientes").NewRow

            Dr(0) = ClienteAtual.cpf
            Dr(1) = ClienteAtual.nome
            Dr(2) = ClienteAtual.profissao
            DS.Tables("Clientes").Rows.Add(Dr)
        Next

        ' #################################################################################
        ' Incluir dados da tabela de contas correntes do dataset
        ' #################################################################################

        For I As Integer = 0 To Contas.Count - 1
            Dim ContaAtual As ContaCorrente = Contas(I)
            Dim Dr As DataRow = DS.Tables("Contas Correntes").NewRow

            Dr(0) = ContaAtual.agencia
            Dr(1) = ContaAtual.numero
            Dr(2) = ContaAtual.titular.cpf
            Dr(3) = ContaAtual.saldo
            DS.Tables("Contas Correntes").Rows.Add(Dr)
        Next

    End Sub

    Sub FormatarListView()
        Lvw_Contas.View = View.Details
        Lvw_Contas.LabelEdit = False
        Lvw_Contas.AllowColumnReorder = False
        Lvw_Contas.FullRowSelect = True
        Lvw_Contas.GridLines = True
    End Sub

    Sub CriarColunas()
        Lvw_Contas.Columns.Add("Conta Corrente", 100, HorizontalAlignment.Center)
        Lvw_Contas.Columns.Add("Correntista", 150, HorizontalAlignment.Center)
        Lvw_Contas.Columns.Add("Saldo em R$", 100, HorizontalAlignment.Center)
    End Sub

    Sub AtualizarListView()

        Lvw_Contas.Items.Clear()

        For I As Integer = 0 To DS.Tables("Contas Correntes").Rows.Count - 1
            Dim vContaNumero As String = DS.Tables("Contas Correntes").Rows(I)("Agencia").ToString +
                " - " + DS.Tables("Contas Correntes").Rows(I)("Conta").ToString
            Dim Linha As New ListViewItem
            Linha.Name = vContaNumero
            Linha.Text = vContaNumero
            Linha.SubItems.Add(BuscaCliente(DS.Tables("Contas Correntes").Rows(I)("CPF").ToString))
            Linha.SubItems.Add(DS.Tables("Contas Correntes").Rows(I)("saldo").ToString)
            Lvw_Contas.Items.Add(Linha)
        Next

    End Sub

    Private Sub NewToolStripButton_Click(sender As Object, e As EventArgs) Handles NewToolStripButton.Click
        Dim F As New Frm_ContaCorrenteDT(DS.Tables("Clientes"))
        F.ShowDialog()
        If F.Retorno Then
            Dim Dr As DataRow = DS.Tables("Contas Correntes").NewRow
            Dr(0) = F.Agencia
            Dr(1) = F.Conta
            Dr(2) = F.CPF
            Dr(3) = 100
            DS.Tables("Contas Correntes").Rows.Add(Dr)
            'AtualizarListView()
            AtualizarListView1()
            AtualizarListView2()
        End If

    End Sub

    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs) Handles ToolStripButton1.Click

        For I As Integer = 0 To Lvw_Contas.Items.Count - 1
            If Lvw_Contas.Items(I).Selected Then
                Dim vAgenciaConta As String = Lvw_Contas.Items(I).SubItems(0).Text
                Dim vPos As Integer = InStr(vAgenciaConta, "-")
                Dim vAgencia As Integer = Val(Mid(vAgenciaConta, 1, vPos))
                Dim vConta As Integer = Val(Mid(vAgenciaConta, vPos + 1))

                Dim vCriterio2 As String = "Agencia = " + vAgencia.ToString + " AND CONTA = " + vConta.ToString
                Dim DrLinhas2 As DataRow() = DS.Tables("Contas Correntes").Select(vCriterio2)
                For Each row As DataRow In DrLinhas2
                    DS.Tables("Contas Correntes").Rows.Remove(row)
                Next

            End If
        Next
        'AtualizarListView()
        AtualizarListView1()
        AtualizarListView2()

    End Sub

    Private Sub Rb_Conta_CheckedChanged(sender As Object, e As EventArgs) Handles Rb_Conta.CheckedChanged

        AtualizarListView1()

        Dim DtView As DataView
        DtView = DtListView.DefaultView
        Dim vCriterioOrdenacao As String = "Conta Corrente"
        DtView.Sort = vCriterioOrdenacao
        DtListView = DtView.ToTable

        AtualizarListView2()

    End Sub

    Private Sub Rb_Nome_CheckedChanged(sender As Object, e As EventArgs) Handles Rb_Nome.CheckedChanged

        AtualizarListView1()

        Dim DtView As DataView
        DtView = DtListView.DefaultView
        Dim vCriterioOrdenacao As String = "Correntista"
        DtView.Sort = vCriterioOrdenacao
        DtListView = DtView.ToTable

        AtualizarListView2()

    End Sub

    Private Sub Rb_Saldo_CheckedChanged(sender As Object, e As EventArgs) Handles Rb_Saldo.CheckedChanged

        AtualizarListView1()

        Dim DtView As DataView
        DtView = DtListView.DefaultView
        Dim vCriterioOrdenacao As String = "Saldo"
        DtView.Sort = vCriterioOrdenacao
        DtListView = DtView.ToTable

        AtualizarListView2()

    End Sub

    Function CriarColuna(NomeColuna As String, TipoColuna As String) As DataColumn
        Dim Dc As New DataColumn
        Dc.ColumnName = NomeColuna
        Dc.DataType = System.Type.GetType(TipoColuna)
        Return Dc
    End Function

    Function CriarCliente(CPF As String, Nome As String, Profissao As String) As Cliente
        Dim C As New Cliente
        C.cpf = CPF
        C.nome = Nome
        C.profissao = Profissao
        Return C
    End Function

    Function BuscaCliente(CPF) As String

        Dim vCriterio As String = "CPF = '" + CPF + "'"
        Dim DtFiltro As DataTable = DS.Tables("Clientes").Clone
        Dim DrLinhas As DataRow() = DS.Tables("Clientes").Select(vCriterio)
        For Each row As DataRow In DrLinhas
            DtFiltro.ImportRow(row)
        Next
        If DtFiltro.Rows.Count > 0 Then
            Return DtFiltro.Rows(0)("nome")
        End If
        Return ""

    End Function

    Sub CriarDataTableListView()
        DtListView.Columns.Add(CriarColuna("Conta Corrente", "System.String"))
        DtListView.Columns.Add(CriarColuna("Correntista", "System.String"))
        DtListView.Columns.Add(CriarColuna("Saldo", "System.String"))
    End Sub

    Sub AtualizarListView1()

        DtListView.Rows.Clear()

        For I As Integer = 0 To DS.Tables("Contas Correntes").Rows.Count - 1
            Dim vContaNumero As String = DS.Tables("Contas Correntes").Rows(I)("Agencia").ToString +
                " - " + DS.Tables("Contas Correntes").Rows(I)("Conta").ToString
            Dim Linha As DataRow = DtListView.NewRow
            Linha(0) = vContaNumero
            Linha(1) = BuscaCliente(DS.Tables("Contas Correntes").Rows(I)("CPF").ToString)
            Linha(2) = DS.Tables("Contas Correntes").Rows(I)("saldo").ToString
            DtListView.Rows.Add(Linha)
        Next

    End Sub

    Sub AtualizarListView2()

        Lvw_Contas.Items.Clear()

        For I As Integer = 0 To DtListView.Rows.Count - 1
            Dim Linha As New ListViewItem
            Linha.Name = DtListView.Rows(I)(0).ToString
            Linha.Text = DtListView.Rows(I)(0).ToString
            Linha.SubItems.Add(DtListView.Rows(I)(1).ToString)
            Linha.SubItems.Add(DtListView.Rows(I)(2).ToString)
            Lvw_Contas.Items.Add(Linha)
        Next

    End Sub

End Class