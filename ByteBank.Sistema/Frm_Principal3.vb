Imports System.Text.RegularExpressions

Public Class Frm_Principal3
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

        Me.Text = "Formulário Principal 3"
        Lbl_Principal3.Text = "Formulário Principal 3"
        Btm_Principal3.Text = "Clique Aqui"

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
End Class