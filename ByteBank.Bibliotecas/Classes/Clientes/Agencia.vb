Imports System.Collections.ObjectModel

Namespace Classes.Clientes

    Public Class Agencia

#Region "PROPRIEDADES"

        Public ReadOnly Property agencia As Integer

        Private _contasCorrentes As ISet(Of ContaCorrente)

        Public ReadOnly Property ContasCorrentes As IList(Of ContaCorrente)
            Get
                Dim contasCorrentesLista As New List(Of ContaCorrente)(_contasCorrentes)
                Return New ReadOnlyCollection(Of ContaCorrente)(contasCorrentesLista)
            End Get
        End Property

#End Region

#Region "CONSTRUTORES"

        Public Sub New(codigo As Integer)

            agencia = codigo
            _contasCorrentes = New HashSet(Of ContaCorrente)

        End Sub

#End Region

#Region "MÉTODOS"

        Public Sub AbrirContaCorrente(Numero As Integer, Nome As String)
            _contasCorrentes.Add(New ContaCorrente(agencia, Numero, Nome))
        End Sub

        Public Sub FecharContaCorrente(Numero As Integer, Nome As String)
            _contasCorrentes.Remove(New ContaCorrente(agencia, Numero, Nome))
        End Sub

        Public Function BuscaCC(Numero As Integer) As ContaCorrente

            Dim contaBuscar As New ContaCorrente(agencia, Numero)
            For Each conta As ContaCorrente In _contasCorrentes
                If conta.Equals(contaBuscar) Then
                    Return conta
                End If
            Next
            Throw New Exception("Conta não existente!!")
        End Function

        Public Sub AlterarCC(Numero As Integer, Nome As String)

            For Each conta As ContaCorrente In _contasCorrentes
                If conta.numero = Numero Then
                    conta.titular.nome = Nome
                End If
            Next

        End Sub

#End Region

    End Class

End Namespace