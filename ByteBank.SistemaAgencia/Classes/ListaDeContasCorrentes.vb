Imports ByteBank.Bibliotecas.Classes.Clientes

Public Class ListaDeContasCorrentes

#Region "PROPRIEDADES"

    Private Property _items() As ContaCorrente()
    Private Property _proximaposicao As Integer

#End Region

#Region "CONSTRUTORES"

    Public Sub New(Optional numeroPosicoesIniciais As Integer = 5)

        _items = New ContaCorrente(numeroPosicoesIniciais - 1) {}
        _proximaposicao = 0

    End Sub

#End Region

#Region "MÉTODOS"

    Public Sub Adicionar(item As ContaCorrente)

        VerificarCapacidadeArrayCopy(_proximaposicao + 1)
        Console.WriteLine("Novo membro adicionado na posição: " + _proximaposicao.ToString)
        _items(_proximaposicao) = item
        _proximaposicao += 1

    End Sub

    Private Sub VerificarCapacidadeArrayCopy(tamanhoNecessario As Integer)

        If _items.Length >= tamanhoNecessario Then
            Return
        End If

        Dim novoTamanho As Integer = _items.Length * 2

        If novoTamanho < tamanhoNecessario Then
            novoTamanho = tamanhoNecessario
        End If

        Dim NovoArray(novoTamanho) As ContaCorrente
        Array.Copy(_items, NovoArray, _items.Length)

        _items = NovoArray

    End Sub

    Private Sub VerificarCapacidadeArray(tamanhoNecessario As Integer)

        If _items.Length >= tamanhoNecessario Then
            Return
        End If

        Dim novoTamanho As Integer = _items.Length * 2

        If novoTamanho < tamanhoNecessario Then
            novoTamanho = tamanhoNecessario
        End If

        Dim NovoArray(novoTamanho) As ContaCorrente

        For i As Integer = 0 To _items.Length - 1
            Console.WriteLine(".")
            NovoArray(i) = _items(i)
        Next
        _items = NovoArray

    End Sub

#End Region

End Class
