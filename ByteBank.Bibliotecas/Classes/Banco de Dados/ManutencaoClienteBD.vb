Imports ByteBank.Bibliotecas.Classes.Clientes

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

        Shared Function RetornaListaClientes() As List(Of Cliente)

            Dim Cli As New List(Of Cliente)
            Try
                Dim Dt As New DataTable
                Dt = RetornaClientes()
                For I As Integer = 0 To Dt.Rows.Count - 1
                    Dim cliAux As New Cliente
                    cliAux.cpf = Dt.Rows(I)("CPF").ToString
                    cliAux.nome = Dt.Rows(I)("nome").ToString
                    cliAux.profissao = Dt.Rows(I)("profissao").ToString
                    Cli.Add(cliAux)
                Next
                Return Cli
            Catch ex As Exception
                Throw New Exception(ex.Message)
            End Try

        End Function

        Shared Function RetornaListaContasCorrente(Cliente As List(Of Cliente)) As List(Of ContaCorrente)

            Dim CC As New List(Of ContaCorrente)
            Try
                Dim Dt As New DataTable
                Dt = RetornaContas()
                For I As Integer = 0 To Dt.Rows.Count - 1
                    Dim contaAux As New ContaCorrente(Dt.Rows(I)("agencia"), Dt.Rows(I)("conta"))
                    contaAux.Depositar(Dt.Rows(I)("saldo") - 100)
                    Dim vCPF As String = Dt.Rows(I)("CPF")
                    Dim ClienteFiltro As List(Of Cliente) = Cliente.FindAll(Function(c As Cliente) c.cpf = vCPF)
                    If Not (ClienteFiltro Is Nothing) AndAlso ClienteFiltro.Count > 0 Then
                        contaAux.titular = ClienteFiltro(0)
                    End If
                    CC.Add(contaAux)
                Next
                Return CC
            Catch ex As Exception
                Throw New Exception(ex.Message)
            End Try

        End Function

        Shared Function RetornaContas() As DataTable

            Dim Dt As New DataTable
            Try
                Dim DB As New SQLServerConn("NOTE0038", "bytebank")
                Dim Retorno As String = DB.SQLQuery("Select Agencia, Conta ,CPF ,Saldo FROM Conta", Dt)
                DB.Close()
            Catch ex As Exception
                Throw New Exception(ex.Message)
            End Try

            Return Dt

        End Function

        Shared Function DescarregaContasCorrentes(Dt As DataTable) As String

            Try
                Dim DB As New SQLServerConn("NOTE0038", "bytebank")
                Dim Comando As String = "DELETE FROM CONTA"
                Dim Retorno2 As String = DB.SQLCommand(Comando)
                DB.Close()

                For I As Integer = 0 To Dt.Rows.Count - 1
                    DB = New SQLServerConn("NOTE0038", "bytebank")
                    Dim vAgencia As Integer = Dt.Rows(I)("agencia")
                    Dim vConta As Integer = Dt.Rows(I)("conta")
                    Dim vCPF As String = Dt.Rows(I)("CPF")
                    Dim vSaldo As Double = Dt.Rows(I)("saldo")
                    Comando = "INSERT INTO CONTA (Agencia, Conta, CPF, Saldo) "
                    Comando += "VALUES (" + vAgencia.ToString + "," + vConta.ToString + ",'" + vCPF + "'," + vSaldo.ToString + ")"
                    Retorno2 = DB.SQLCommand(Comando)
                    DB.Close()
                Next
                Return "Contas atualizadas com sucesso!!!"

            Catch ex As Exception
                Throw New Exception(ex.Message)
            End Try
            Return ""

        End Function

    End Class
End Namespace


