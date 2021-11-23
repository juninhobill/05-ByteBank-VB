Imports ByteBank.Bibliotecas.Classes.BancodeDados

Public Class Frm_TesteDB
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        DtGrid_Resultado.Columns.Clear()
        DtGrid_Resultado.DataSource = Nothing
        Try
            Dim Dt As New DataTable
            Dim DB As New SQLServerConn("NOTE0038", "bytebank")
            Dim Retorno As String = DB.SQLQuery("SELECT CPF,Nome,Profissao FROM Cliente", Dt)
            DtGrid_Resultado.DataSource = Dt
            DB.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        Try
            Dim Comando As String = "INSERT INTO CLIENTE (CPF, nome, profissao) VALUES ('03485964300','Abelardo Barbosa','Técnico');"
            Dim DB As New SQLServerConn("NOTE0038", "bytebank")
            Dim Dt As New DataTable
            Dim Retorno As String = DB.SQLQuery("SELECT CPF,Nome,Profissao FROM Cliente WHERE CPF = '03485964300'", Dt)
            If Dt.Rows.Count > 0 Then
                MsgBox("Cliente não pode ser incluído porque já existe na base!!!")
            Else
                Dim Retorno2 As String = DB.SQLCommand(Comando)
                MsgBox("Cliente incluído com sucesso!!!")
            End If
            DB.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click

        Try
            Dim Comando As String = "DELETE FROM CLIENTE WHERE CPF = '03485964300'"
            Dim DB As New SQLServerConn("NOTE0038", "bytebank")
            Dim Retorno As String = DB.SQLCommand(Comando)
            DB.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub
End Class