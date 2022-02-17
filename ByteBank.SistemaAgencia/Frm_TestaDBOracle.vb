Imports ByteBank.Bibliotecas.Classes.BancoDeDados

Public Class Frm_TestaDBOracle

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        DtGrid_Resultado.Columns.Clear()
        DtGrid_Resultado.DataSource = Nothing
        Try
            Dim Dt As New DataTable
            Dim DB As New OracleConn("XE", "system", "admin")
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
            Dim DB As New OracleConn("XE", "system", "MPsj@#$270678")
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
            Dim DB As New OracleConn("XE", "system", "MPsj@#$270678")
            Dim Retorno As String = DB.SQLCommand(Comando)
            MsgBox("Cliente Abelardo Barbosa excluído com sucesso!!!")
            DB.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

End Class