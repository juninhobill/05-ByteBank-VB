Imports ByteBank.Bibliotecas.Classes.Clientes

Public Class Frm_Principal
    Public Sub New()

        ' Esta chamada é requerida pelo designer.
        InitializeComponent()

        ' Adicione qualquer inicialização após a chamada InitializeComponent().

        Lbl_Principal.Text = "Principal"
        Me.Text = "Principal"
        Btm_Principal.Text = "Clique Aqui"
        Btm_Principal2.Text = "Clique Aqui"
        Btm_Principal3.Text = "Clique Aqui"
        Btm_Principal4.Text = "Clique Aqui"
        Btm_Principal5.Text = "Clique Aqui"

    End Sub

    Private Sub Btm_Principal_Click(sender As Object, e As EventArgs) Handles Btm_Principal.Click

        Dim idade(3) As Integer
        idade(0) = 34
        idade(1) = 30
        idade(2) = 34
        idade(3) = 38

        Dim vPosicoes As Integer = idade.Length

        Dim media As Double = 0
        For I As Integer = 0 To vPosicoes - 1
            media += idade(I)
        Next
        media = media / vPosicoes

        Dim idade2(3) As Integer
        idade2(0) = 34
        idade2(1) = 30
        idade2(2) = 34
        idade2(3) = 38

        Dim vPosicoes2 As Integer = idade2.Length
        Dim vSomaArray As Integer = idade2.Sum
        Dim media2 As Double = vSomaArray / vPosicoes2

        Dim idade3(3) As Integer
        idade3(0) = 34
        idade3(1) = 30
        idade3(2) = 34
        idade3(3) = 38
        Dim media3 As Double = idade3.Average

        Dim vFirst As Integer = idade3.First
        Dim vLast As Integer = idade3.Last
        Dim vMax As Integer = idade3.Max
        Dim vMin As Integer = idade3.Min

        MsgBox(media)
        MsgBox(media2)
        MsgBox(media3)

    End Sub

    Private Sub Btm_Principal2_Click(sender As Object, e As EventArgs) Handles Btm_Principal2.Click

        Dim contas() As ContaCorrente

        contas = {New ContaCorrente(111, 111111), New ContaCorrente(222, 222222),
            New ContaCorrente(333, 333333), New ContaCorrente(444, 444444)}

        For i As Integer = 0 To contas.Length - 1

            Dim ContaAtual As ContaCorrente = contas(i)
            Dim vNumero As Integer = ContaAtual.numero
            MsgBox(vNumero)

        Next

        contas = {New ContaCorrente(111, 111111), New ContaCorrente(222, 222222),
            New ContaCorrente(333, 333333), New ContaCorrente(444, 444444), New ContaCorrente(555, 555555)}

        For i As Integer = 0 To contas.Length - 1

            Dim ContaAtual As ContaCorrente = contas(i)
            Dim vNumero As Integer = ContaAtual.numero
            MsgBox(vNumero)

        Next

    End Sub

    Private Sub Btm_Principal3_Click(sender As Object, e As EventArgs) Handles Btm_Principal3.Click

        Dim Lista As New ListaDeContasCorrentes(10)

        Lista.Adicionar(New ContaCorrente(111, 111111))
        Lista.Adicionar(New ContaCorrente(222, 222222))
        Lista.Adicionar(New ContaCorrente(333, 333333))
        Lista.Adicionar(New ContaCorrente(444, 444444))
        Lista.Adicionar(New ContaCorrente(555, 555555))
        Lista.Adicionar(New ContaCorrente(666, 666666))

        Dim vPosicao As Integer = Lista.posicaoElemento(New ContaCorrente(444, 444444))
        MsgBox(vPosicao)

    End Sub

    Private Sub Btm_Principal4_Click(sender As Object, e As EventArgs) Handles Btm_Principal4.Click

        Dim Lista As New ListaDeObjects()

        Lista.Adicionar(12)
        Lista.Adicionar(13)
        Lista.Adicionar(15)
        Lista.AdicionarVariosUmaUm(12, 15, 14, 13, 18, 20)

        Dim soma As Integer = 0
        For i As Integer = 0 To Lista.tamanho - 1
            soma += Lista(i)
        Next

        MsgBox(soma)

        Dim Lista2 As New ListaDeObjects()

        Lista2.Adicionar("a1")
        Lista2.Adicionar("a2")
        Lista2.Adicionar("a3")
        Lista2.AdicionarVariosUmaUm("a4", "a5", "a6", "a7", "a8", "a9")

        Dim somaStr As String = ""
        For i As Integer = 0 To Lista2.tamanho - 1
            somaStr += Lista2(i)
        Next

        MsgBox(somaStr)

        Dim Lista3 As New ListaDeObjects()

        Lista3.Adicionar(New ContaCorrente(1, 1))
        Lista3.Adicionar(New ContaCorrente(1, 1))
        Lista3.Adicionar(New ContaCorrente(1, 1))
        Lista3.AdicionarVariosUmaUm(New ContaCorrente(1, 1), New ContaCorrente(1, 1), New ContaCorrente(1, 1),
                                    New ContaCorrente(1, 1), New ContaCorrente(1, 1), New ContaCorrente(1, 1))

        Dim soma3 As String = ""
        For i As Integer = 0 To Lista3.tamanho - 1
            Dim contaAtual As ContaCorrente = TryCast(Lista3(i), ContaCorrente)
            soma3 += contaAtual.agencia.ToString + " - " + contaAtual.numero.ToString + " ; "
        Next

        MsgBox(soma3)

    End Sub

    Private Sub Btm_Principal5_Click(sender As Object, e As EventArgs) Handles Btm_Principal5.Click

        Dim Lista As New Lista(Of Integer)

        Lista.Adicionar(12)
        Lista.Adicionar(13)
        Lista.Adicionar(15)
        Lista.AdicionarVariosUmaUm(12, 15, 14, 13, 18, 20)

        Dim soma As Integer = 0
        For i As Integer = 0 To Lista.tamanho - 1
            soma += Lista(i)
        Next

        MsgBox(soma)

        Dim Lista2 As New ListaDeObjects()

        Lista2.Adicionar("a1")
        Lista2.Adicionar("a2")
        Lista2.Adicionar("a3")
        Lista2.AdicionarVariosUmaUm("a4", "a5", "a6", "a7", "a8", "a9")

        Dim somaStr As String = ""
        For i As Integer = 0 To Lista2.tamanho - 1
            somaStr += Lista2(i)
        Next

        MsgBox(somaStr)

        Dim Lista3 As New ListaDeObjects()

        Lista3.Adicionar(New ContaCorrente(1, 1))
        Lista3.Adicionar(New ContaCorrente(1, 1))
        Lista3.Adicionar(New ContaCorrente(1, 1))
        Lista3.AdicionarVariosUmaUm(New ContaCorrente(1, 1), New ContaCorrente(1, 1), New ContaCorrente(1, 1),
                                    New ContaCorrente(1, 1), New ContaCorrente(1, 1), New ContaCorrente(1, 1))

        Dim soma3 As String = ""
        For i As Integer = 0 To Lista3.tamanho - 1
            Dim contaAtual As ContaCorrente = TryCast(Lista3(i), ContaCorrente)
            soma3 += contaAtual.agencia.ToString + " - " + contaAtual.numero.ToString + " ; "
        Next

        MsgBox(soma3)

    End Sub
End Class