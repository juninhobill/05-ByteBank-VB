Imports System.IO
Imports System.Text
Imports ByteBank.Bibliotecas.Classes.Clientes

Public Class Frm_EntradaSaida
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim EnderecoDoArquivo As String = "tempo.txt"

        Using FluxoDoArquivo As New FileStream(EnderecoDoArquivo, FileMode.Open)
            TextBox1.Text = ""
            TextBox2.Text = ""

            Dim Buffer = New Byte(1024) {} ' 1Kbyte

            Dim NumeroBytesLidos As Integer = -1

            While NumeroBytesLidos <> 0
                NumeroBytesLidos = FluxoDoArquivo.Read(Buffer, 0, 1024)
                TextBox1.AppendText(EscreveBuffer(Buffer))
                TextBox2.AppendText(EscreveBufferUTF(Buffer, NumeroBytesLidos))

            End While

        End Using

    End Sub

    Function EscreveBuffer(Buffer As Byte()) As String
        Dim vRetorno As String = ""
        For Each MeuByte As Byte In Buffer
            vRetorno += MeuByte.ToString + " "
        Next
        Return vRetorno
    End Function

    Function EscreveBufferUTF(Buffer As Byte(), NumeroBytesLidos As Integer) As String
        Dim vRetorno As String
        Dim UTF As New UTF8Encoding
        vRetorno = UTF.GetString(Buffer, 0, NumeroBytesLidos)
        Return vRetorno
    End Function

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        Dim EnderecoDoArquivo As String = "tempo.txt"
        TextBox2.Text = ""
        Using FluxoDoArquivo As New FileStream(EnderecoDoArquivo, FileMode.Open)
            Using Leitor = New StreamReader(FluxoDoArquivo)
                While Not (Leitor.EndOfStream)
                    Dim vLinha As String = Leitor.ReadLine()
                    Dim CC As ContaCorrente = CriarContaCorrente(vLinha)
                    TextBox2.AppendText(CC.ToString + vbCrLf)
                End While
            End Using
        End Using

    End Sub

    Function CriarContaCorrente(Linha As String) As ContaCorrente

        Dim VetorLinha() As String = Linha.Split(" ")
        Dim Cliente As New Cliente()
        Cliente.cpf = VetorLinha(3)
        Cliente.nome = VetorLinha(4)

        Dim CC As New ContaCorrente(VetorLinha(0), VetorLinha(1))
        CC.titular = Cliente

        Dim SaldoConvertido As Double = Double.Parse(VetorLinha(2))

        CC.Depositar(SaldoConvertido - 100)

        Return CC

    End Function

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click

        Dim CaminhoNovoArquivo As String = "ContasExternas.csv"
        Using FluxoDoArquivo As New FileStream(CaminhoNovoArquivo, FileMode.Create)

            Dim ContaString As String = "456;78945;4785,90;234536473;Pedro Silva"
            Dim UTF As New UTF8Encoding()
            Dim Bytes = UTF.GetBytes(ContaString)

            FluxoDoArquivo.Write(Bytes, 0, Bytes.Length)

        End Using

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click

        Dim CaminhoNovoArquivo As String = "ContasExternas.csv"
        Using FluxoDoArquivo As New FileStream(CaminhoNovoArquivo, FileMode.Create)
            Using Escritor = New StreamWriter(FluxoDoArquivo)
                Dim ContaString As String = "456;78945;4785,90;234536473;João Tavela"
                Escritor.Write(ContaString)
            End Using
        End Using

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click

        Dim CaminhoNovoArquivo As String = "Teste.txt"
        Using FluxoDoArquivo As New FileStream(CaminhoNovoArquivo, FileMode.Create)
            Using Escritor = New StreamWriter(FluxoDoArquivo)
                For I As Integer = 0 To 100000
                    Dim ContaString As String = "Linha " + I.ToString
                    Escritor.WriteLine(ContaString)
                    Escritor.Flush()
                    MsgBox("Escrevi a linha: " + ContaString)
                Next
            End Using
        End Using

    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click

        Dim CaminhoNovoArquivo As String = "ContaCorrenteBinario.txt"
        Using FluxoDoArquivo As New FileStream(CaminhoNovoArquivo, FileMode.Create)
            Using Escritor = New BinaryWriter(FluxoDoArquivo)
                Dim agencia As Integer = 234
                Dim conta As Integer = 13123123
                Dim saldo As Double = 1213
                Dim CPF As String = "213213123"
                Dim nome As String = "João Tavela"

                Escritor.Write(agencia)
                Escritor.Write(conta)
                Escritor.Write(saldo)
                Escritor.Write(CPF)
                Escritor.Write(nome)

            End Using
        End Using

        Using FluxoDoArquivo As New FileStream(CaminhoNovoArquivo, FileMode.Open)
            Using Escritor = New BinaryReader(FluxoDoArquivo)
                Dim agencia As Integer = Escritor.ReadInt32()
                Dim conta As Integer = Escritor.ReadInt32()
                Dim saldo As Double = Escritor.ReadDouble()
                Dim CPF As String = Escritor.ReadString()
                Dim nome As String = Escritor.ReadString()

                MsgBox($"Agencia: {agencia}, Conta: {conta}, Saldo: {saldo}, CPF: {CPF}, Nome: {nome}")

            End Using
        End Using

    End Sub
End Class