Public Class Frm_Principal
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

        Me.Text = "Sistema de Agências ByteBank"


    End Sub

    Private Sub Video01ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles Video01ToolStripMenuItem.Click

        Dim f As New Frm_Secundario
        f.MdiParent = Me
        f.Show()

    End Sub

End Class
