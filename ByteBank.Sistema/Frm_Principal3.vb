Imports System.Text.RegularExpressions
Imports ByteBank.Bibliotecas.Classes.Clientes
Imports ByteBank.Bibliotecas.Classes.Funcionarios
Imports ByteBank.Bibliotecas.Classes.Sistema

Public Class Frm_Principal3
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

        Me.Text = "Formulário Principal 3"
        Lbl_Principal3.Text = "Formulário Principal 3"
        Btm_Principal3.Text = "Clique Aqui"
        Btm_Principal03a.Text = "Clique Aqui"
        Btm_Principal03b.Text = "Clique Aqui"

    End Sub

    Private Sub Btm_Principal3_Click(sender As Object, e As EventArgs) Handles Btm_Principal3.Click

        Dim vFrase As String = "O telefone é 92334-4332"
        'Dim vExpressaoRegular As String = "[0123456789][0123456789][0123456789][0123456789][-][0123456789][0123456789][0123456789][0123456789]"
        'Dim vExpressaoRegular As String = "[0-9][0-9][0-9][0-9][-][0-9][0-9][0-9][0-9]"
        'Dim vExpressaoRegular As String = "[0-9]{4}[-][0-9]{4}"
        'Dim vExpressaoRegular As String = "[0-9]{4,5}[-][0-9]{4}"
        'Dim vExpressaoRegular As String = "[0-9]{4,5}[-]{0,1}[0-9]{4}"
        'Dim vExpressaoRegular As String = "[0-9]{4,5}[-]?[0-9]{4}"
        Dim vExpressaoRegular As String = "[0-9]{4,5}-?[0-9]{4}"

        Dim x As Boolean = Regex.IsMatch(vFrase, vExpressaoRegular)
        MsgBox(x)

        Dim y As Match = Regex.Match(vFrase, vExpressaoRegular)
        MsgBox(y.Value)

    End Sub

    Private Sub Btm_Principal03a_Click(sender As Object, e As EventArgs) Handles Btm_Principal03a.Click

        'Dim X As String = "aaaaaa"
        'Dim Y As Integer = 23
        'Dim Z As Boolean = True
        'MsgBox(X.ToString)
        'MsgBox(Y.ToString)
        'MsgBox(Z.ToString)

        'Dim conta As New ContaCorrente(2222, 23232323)
        'MsgBox(conta.ToString)

        Dim Cliente_1 As New Cliente()
        Dim Cliente_2 As New Cliente()

        Cliente_1.nome = "Carlos"
        Cliente_1.cpf = "123.123.123-23"
        Cliente_1.profissao = "Analista de Sistemas"

        Cliente_2.nome = "Carlos"
        Cliente_2.cpf = "123.123.123-23"
        Cliente_2.profissao = "Analista de Sistemas"

        Dim Ger As New Gerente("123.123.123-23")
        Dim KK As String = "aaaaaaaaaaaaaaa"

        If (Cliente_1.Equals(Cliente_2)) Then
            MsgBox("SÃO IGUAIS!!!")
        Else
            MsgBox("NÃO SÃO IGUAIS!!!")
        End If

    End Sub

    Sub Teste(F As Funcionario)

        ' fazer alguma coisa

    End Sub

    Private Sub Btm_Principal03b_Click(sender As Object, e As EventArgs) Handles Btm_Principal03b.Click

        Dim url As String = "https://www.bytebank.com.br/cambio?moedaOrigem=dolar&moedaDestino=real&valor=1500"
        Dim X As New ExtrairValordeArgumentosUrl(url)
        Dim Y As String = X.GetTodosArgumentos

        MsgBox(Y)

    End Sub
End Class