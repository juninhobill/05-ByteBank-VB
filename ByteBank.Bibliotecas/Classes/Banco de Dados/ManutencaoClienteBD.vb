Namespace Classes.BancoDeDados

    Public Class ManutencaoClienteBD

        Shared Function RetornaClientes() As DataTable

            Dim Dt As New DataTable
            Try
                Dim DB As New SQLServerConn("NOTE0038", "bytebank")
                Dim Retorno As String = DB.SQLQuery("SELECT CPF,Nome,Profissao FROM Cliente", Dt)
                DB.Close()
            Catch ex As Exception
                Throw New Exception(ex.Message)
            End Try

            Return Dt

        End Function

        Shared Function EditaCliente(vCPF As String, vNome As String, vProfissao As String) As String

            Try
                Dim Dt As New DataTable
                Dim DB As New SQLServerConn("NOTE0038", "bytebank")
                Dim Retorno As String = DB.SQLQuery("SELECT CPF FROM Cliente WHERE CPF = '" + vCPF + "'", Dt)
                Dim vMensagem As String = ""
                If Dt.Rows.Count = 0 Then
                    Dim Comando As String = "INSERT INTO CLIENTE (CPF, nome, profissao) VALUES ('" + vCPF + "','" + vNome + "','" + vProfissao + "')"
                    Dim Retorno2 As String = DB.SQLCommand(Comando)
                    DB.Close()
                    vMensagem = "Cliente " + vCPF + " incluído com sucesso!!!"
                Else
                    Dim Comando As String = "UPDATE CLIENTE SET nome = '" + vNome + "', profissao = '" + vProfissao + "' WHERE CPF = '" + vCPF + "'"
                    Dim Retorno2 As String = DB.SQLCommand(Comando)
                    DB.Close()
                    vMensagem = "Cliente " + vCPF + " alterado com sucesso!!!"
                End If
                Return vMensagem

            Catch ex As Exception
                Throw New Exception(ex.Message)
            End Try
            Return ""

        End Function

        Shared Function ExcluiCliente(vCPF As String) As String

            Try
                Dim Dt As New DataTable
                Dim DB As New SQLServerConn("NOTE0038", "bytebank")
                Dim Retorno As String = DB.SQLQuery("SELECT CPF FROM Cliente WHERE CPF = '" + vCPF + "'", Dt)
                Dim vMensagem As String = ""
                If Dt.Rows.Count = 0 Then
                    vMensagem = "Cliente não pode ser excluído porque não existe: " + vCPF
                Else
                    Dim Comando As String = "DELETE FROM CLIENTE WHERE CPF = '" + vCPF + "'"
                    Dim Retorno2 As String = DB.SQLCommand(Comando)
                    DB.Close()
                    vMensagem = "Cliente " + vCPF + " excluído com sucesso!!!"
                End If
                Return vMensagem

            Catch ex As Exception
                Throw New Exception(ex.Message)
            End Try
            Return ""

        End Function

    End Class
End Namespace


