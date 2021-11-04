Imports ByteBank.Bibliotecas.Classes.Sistema
Public Class Frm_Principal2
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

        Me.Text = "Formulário Principal 2"
        Lbl_Principal2.Text = "Formulário Principal 2"
        Lbl_URL.Text = "URL"
        Lbl_Argumento.Text = "Argumento"
        Txt_Argumento.ReadOnly = True
        Btm_Processa.Text = "Processa"
        Lbl_Propriedade.Text = "Propriedade"

        ' Inicializando textbox

        Txt_URL.Text = "https://www.bytebank.com.br/cambio?moedaOrigem=dolar&moedaDestino=real&valor=1500"
        Txt_Propriedade.Text = "moedaDestino"

    End Sub

    Private Sub Btm_Processa_Click(sender As Object, e As EventArgs) Handles Btm_Processa.Click

        Dim vURL As New ExtrairValordeArgumentosUrl(Txt_URL.Text)
        If Not vURL.IsByteBank Then
            MsgBox("URL não é do dominio do ByteBank")

        Else
            Txt_Argumento.Text = vURL.argumento
            Dim vPropriedade As String = Txt_Propriedade.Text
            MsgBox(vURL.GetValor(vPropriedade))

        End If

    End Sub
End Class