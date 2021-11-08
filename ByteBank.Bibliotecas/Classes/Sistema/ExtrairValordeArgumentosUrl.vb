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
            If posicaoInterrogacao = -1 Then
                argumento = ""
            Else
                argumento = urlString.Substring(posicaoInterrogacao + 1)
            End If
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

        Public Function GetTodosArgumentos() As String

            If argumento = "" Then
                Return ""
            End If

            Dim vListaArgumentos As String = String.Empty
            Dim vIndex As Integer = argumento.IndexOf("&")
            If vIndex = -1 Then
                Return argumento
            Else
                vListaArgumentos = argumento.Substring(0, vIndex)
                Dim vArgumentoRestos As String = argumento.Remove(0, vIndex + 1)
                While vIndex <> -1
                    vIndex = vArgumentoRestos.IndexOf("&")
                    If vIndex = -1 Then
                        vListaArgumentos += vbCrLf + vArgumentoRestos
                    Else
                        vListaArgumentos += vbCrLf + vArgumentoRestos.Substring(0, vIndex)
                        vArgumentoRestos = vArgumentoRestos.Remove(0, vIndex + 1)
                    End If
                End While
            End If

            Return vListaArgumentos

        End Function

#End Region

    End Class

End Namespace


