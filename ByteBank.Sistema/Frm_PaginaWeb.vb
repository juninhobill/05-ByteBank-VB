Imports ByteBank.Bibliotecas.Classes.Sistema

Public Class Frm_PaginaWeb
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Me.Text = "Página Web"
        Lbl_URL.Text = "URL"
        Btm_URL.Text = "GO"
        Grp_URL.Text = ""
        Grp_WebBrowser.Text = ""
        Btm_Propriedades.Text = "Prop"

    End Sub

    Private Sub Btm_URL_Click(sender As Object, e As EventArgs) Handles Btm_URL.Click

        Dim URL As String = Txt_URL.Text
        If URL = "" Then
            MsgBox("Favor digitar uma URL.", MsgBoxStyle.Critical, "URL")
        Else
            Wb_Pagina.ScriptErrorsSuppressed = True
            Wb_Pagina.Navigate(URL)
        End If

    End Sub

    Private Sub Btm_Propriedades_Click(sender As Object, e As EventArgs) Handles Btm_Propriedades.Click

        Dim URL As String = Txt_URL.Text
        If URL = "" Then
            MsgBox("Favor digitar uma URL.", MsgBoxStyle.Critical, "URL")
        Else
            URL = Wb_Pagina.Url.ToString
            Txt_URL.Text = URL
            Dim paginaURL As New ExtrairValordeArgumentosUrl(URL)
            Dim propriedadesURL As String = paginaURL.GetTodosArgumentos
            MsgBox(propriedadesURL, MsgBoxStyle.Information, "URL")
        End If

    End Sub
End Class