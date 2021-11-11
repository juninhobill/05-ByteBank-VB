Imports ByteBank.Bibliotecas.Classes.Clientes

Public Class Frm_ContasCorrentesListas

    'Dim Lista As New Lista(Of ContaCorrente)
    Dim Lista As New List(Of ContaCorrente)

    Public Sub New()

        ' Esta chamada é requerida pelo designer.
        InitializeComponent()

        ' Adicione qualquer inicialização após a chamada InitializeComponent().

        Me.Text = "Contas Correntes Listas"

        Lbl_Agencia.Text = "Conta Corrente"
        Btm_Adicionar.Text = "Adicionar"
        Btm_Remover.Text = "Remover"
        Grp_AdicionarVarios.Text = "Adicionar Vários"

        Btm_AdicionaVarios.Text = "Adicionar"
        Lbl_Agencia1.Text = "Conta Corrente 1"
        Lbl_Agencia2.Text = "Conta Corrente 2"
        Lbl_Agencia3.Text = "Conta Corrente 3"
        Lbl_Agencia4.Text = "Conta Corrente 4"

    End Sub

    Private Sub Btm_Adicionar_Click(sender As Object, e As EventArgs) Handles Btm_Adicionar.Click

        If Txt_Agencia.Text <> "" And Txt_Conta.Text <> "" Then
            Dim conta As New ContaCorrente(Txt_Agencia.Text, Txt_Conta.Text, Txt_Nome.Text)
            Lista.add(conta)
            Txt_Array.Text = EscreverElementosArrayIndexador()
        End If

    End Sub

    Private Sub Btm_Remover_Click(sender As Object, e As EventArgs) Handles Btm_Remover.Click
        If Txt_Agencia.Text <> "" And Txt_Conta.Text <> "" Then
            Dim conta As New ContaCorrente(Txt_Agencia.Text, Txt_Conta.Text, Txt_Nome.Text)
            Lista.Remove(conta)
            Txt_Array.Text = EscreverElementosArrayIndexador()
        End If

    End Sub

    Public Function EscreverElementosArray() As String

        Dim elementos As String = String.Empty
        For i As Integer = 0 To Lista.Count - 1
            'elementos += Lista(i).agencia.ToString + " - " + Lista(i).numero.ToString + vbCrLf
            elementos += Lista(i).ToString + vbCrLf
        Next
        Return elementos

    End Function

    Public Function EscreverElementosArrayIndexador() As String

        Dim elementos As String = String.Empty
        For i As Integer = 0 To Lista.Count - 1
            'elementos += Lista(i).agencia.ToString + " - " + Lista(i).numero.ToString + vbCrLf
            elementos += Lista(i).ToString + vbCrLf
        Next
        Return elementos

    End Function

    Private Sub Btm_AdicionaVarios_Click(sender As Object, e As EventArgs) Handles Btm_AdicionaVarios.Click

        Dim ListaTemporaria As New List(Of ContaCorrente)

        If Txt_Agencia1.Text <> "" And Txt_Conta1.Text <> "" Then
            Dim Conta1 As New ContaCorrente(Txt_Agencia1.Text, Txt_Conta1.Text, Txt_Nome1.Text)
            ListaTemporaria.Add(Conta1)
            If Txt_Agencia2.Text <> "" And Txt_Conta2.Text <> "" Then
                Dim Conta2 As New ContaCorrente(Txt_Agencia2.Text, Txt_Conta2.Text, Txt_Nome2.Text)
                ListaTemporaria.Add(Conta2)
                If txt_Agencia3.Text <> "" And Txt_Conta3.Text <> "" Then
                    Dim Conta3 As New ContaCorrente(txt_Agencia3.Text, Txt_Conta3.Text, Txt_Nome3.Text)
                    ListaTemporaria.Add(Conta3)
                    If Txt_Agencia4.Text <> "" And Txt_Conta4.Text <> "" Then
                        Dim Conta4 As New ContaCorrente(Txt_Agencia4.Text, Txt_Conta4.Text, Txt_Nome4.Text)
                        ListaTemporaria.Add(Conta4)
                        Lista.AddRange(ListaTemporaria)
                        Txt_Array.Text = EscreverElementosArrayIndexador()
                    Else
                        Lista.AddRange(ListaTemporaria)
                        Txt_Array.Text = EscreverElementosArrayIndexador()
                    End If
                Else
                    Lista.AddRange(ListaTemporaria)
                    Txt_Array.Text = EscreverElementosArrayIndexador()
                End If
            Else
                Lista.AddRange(ListaTemporaria)
                Txt_Array.Text = EscreverElementosArrayIndexador()
            End If
        End If
    End Sub
End Class