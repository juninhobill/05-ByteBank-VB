Namespace Classes.Sistema
    Public Class ExtrairValordeArgumentosUrl

#Region "PROPRIEDADES"

        Public ReadOnly Property url As String
        Public ReadOnly Property argumento As String
        Private ReadOnly Property dominio As String


#End Region

#Region "CONSTRUTORES"

        Public Sub New(urlString As String)

            If String.IsNullOrEmpty(urlString) Then
                Throw New ArgumentException("URL possui valor vazio ou nulo", NameOf(urlString))
            End If

            Dim posicaoInterrogacao As Integer
            posicaoInterrogacao = urlString.IndexOf("?")
            argumento = urlString.Substring(posicaoInterrogacao + 1)
            dominio = "https://www.bytebank.com.br"

            url = urlString

        End Sub

#End Region

#Region "MÉTODOS"

        Public Function GetValor(propriedade As String) As String

            Dim vPropriedade As String = propriedade + "="
            Dim vIndex As Integer = argumento.ToUpper.IndexOf(vPropriedade.ToUpper)
            Dim vValor As String

            If vIndex = -1 Then
                vValor = ""
            Else
                vIndex += vPropriedade.Length()
                Dim vArgumentoParcial As String = argumento.Substring(vIndex)
                Dim vIndex2 As Integer = vArgumentoParcial.IndexOf("&")
                If vIndex2 = -1 Then
                    vValor = vArgumentoParcial
                Else
                    vValor = vArgumentoParcial.Remove(vIndex2)
                End If
            End If

            Return vValor

        End Function

        Public Function IsByteBank() As Boolean

            Return url.ToLower.StartsWith(dominio)

        End Function

#End Region

    End Class

End Namespace


