Public Class Frm_Principal
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

        Me.Text = "Formulário Principal"
        Lbl_Principal.Text = "Formulário Principal"
        Btm_Principal.Text = "Clique Aqui (InStr)"
        Lbl_URL.Text = "URL"
        Lbl_Separador.Text = "Separador"
        Btm_Principal2.Text = "Clique Aqui (IndexOf)"

    End Sub

    Private Sub Btm_Principal_Click(sender As Object, e As EventArgs) Handles Btm_Principal.Click

        Try
            ExecutaTesteURL()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Sub ExecutaTesteURL()

        Dim url As String = Txt_URL.Text

        If url = "" Then
            Throw New Exception("URL Vazia")
        End If

        Dim separador As String = Txt_Separador.Text

        If separador = "" Then
            Throw New Exception("Separador Vazio")
        End If

        Dim posicaoInterrogacao As Integer
        posicaoInterrogacao = InStr(url, separador)

        If posicaoInterrogacao = 0 Then
            Throw New Exception("Posição Vazia")
        End If

        url = url.Substring(posicaoInterrogacao)
        MsgBox(url)

    End Sub

    Private Sub Btm_Principal2_Click(sender As Object, e As EventArgs) Handles Btm_Principal2.Click

        Try
            ExecutaTesteURL2()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Sub ExecutaTesteURL2()

        Dim url As String = Txt_URL.Text

        If url = "" Then
            Throw New Exception("URL Vazia")
        End If

        Dim separador As String = Txt_Separador.Text

        If separador = "" Then
            Throw New Exception("Separador Vazio")
        End If

        Dim posicaoInterrogacao As Integer
        posicaoInterrogacao = url.IndexOf(separador)

        If posicaoInterrogacao = -1 Then
            Throw New Exception("Posição Vazia")
        End If

        url = url.Substring(posicaoInterrogacao + 1)
        MsgBox(url)

    End Sub

End Class
