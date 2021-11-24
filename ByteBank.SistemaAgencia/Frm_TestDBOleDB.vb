Imports ByteBank.Bibliotecas.Classes.BancoDeDados

Public Class Frm_TestDBOleDB
    Dim stringConn As String = ""

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        DtGrid_Resultado.Columns.Clear()
        DtGrid_Resultado.DataSource = Nothing
        Try
            Dim Dt As New DataTable
            Dim DB As New OleDBConn(stringConn)
            Dim Retorno As String = DB.SQLQuery("SELECT CPF,NOME,PROFISSAO FROM CLIENTE", Dt)
            DtGrid_Resultado.DataSource = Dt
            DB.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        Try
            Dim Comando As String = "INSERT INTO CLIENTE (CPF, NOME, PROFISSAO) VALUES ('03485964300','Abelardo Barbosa','Técnico')"
            Dim DB As New OleDBConn(stringConn)
            Dim Dt As New DataTable
            Dim Retorno As String = DB.SQLQuery("SELECT CPF,NOME,PROFISSAO FROM CLIENTE WHERE CPF = '03485964300'", Dt)
            If Dt.Rows.Count > 0 Then
                MsgBox("Cliente não pode ser incluído porque já existe na base!!!")
            Else
                Dim Retorno2 As String = DB.SQLCommand(Comando)
                MsgBox("Cliente Abelardo Barbosa incluído com sucesso!!!")
            End If
            DB.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click

        Try
            Dim Comando As String = "DELETE FROM CLIENTE WHERE CPF = '03485964300'"
            Dim DB As New OleDBConn(stringConn)
            Dim Retorno As String = DB.SQLCommand(Comando)
            MsgBox("Cliente Abelardo Barbosa excluído com sucesso!!!")
            DB.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton1.CheckedChanged
        stringConn = "Provider=SQLOLEDB.1;Persist Security Info=False;User ID=sa;Password=admin;Initial Catalog=bytebank;Data Source=NOTE0038"
    End Sub

    Private Sub RadioButton2_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton2.CheckedChanged
        stringConn = "Provider=OraOLEDB.Oracle.1;Persist Security Info=False;User ID=system;Password=MPsj@#$270678;Data Source=XE"
    End Sub
End Class