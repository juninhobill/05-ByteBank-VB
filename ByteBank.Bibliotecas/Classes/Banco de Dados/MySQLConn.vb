Imports MySql.Data.MySqlClient


Namespace Classes.BancoDeDados

    Public Class MySQLConn

#Region "PROPRIEDADES"

        Public Property StringConn As String
        Public Property connDB As MySqlConnection

#End Region

#Region "CONSTRUTORES"

        Public Sub New(Servidor As String, vUser As String, vPassword As String, vDatabase As String)

            'StringConn = "server=<DATASOURCE>; database=<SCHEMA>; User Id=<USUARIO>; Password=<PASSWORD>"
            StringConn = "server=" + Servidor + ";database=" + vDatabase + "; User Id=" + vUser + "; Password=" + vPassword + ""
            connDB = New MySqlConnection(StringConn)
            connDB.Open()
        End Sub

#End Region

#Region "MÉTODOS"

        Public Function SQLQuery(SQL As String, ByRef DT As DataTable) As String

            Try
                Dim myCommand As IDbCommand = New MySqlCommand(SQL, connDB)
                myCommand.CommandTimeout = 0
                Dim myReader As IDataReader = myCommand.ExecuteReader
                DT.Load(myReader)
                Return ""
            Catch ex As Exception
                Throw New Exception(ex.Message)
            End Try

        End Function

        Public Function SQLCommand(SQL As String) As String

            Try
                Dim myCommand As IDbCommand = New MySqlCommand(SQL, connDB)
                myCommand.CommandTimeout = 0
                myCommand.ExecuteReader()
                Return ""
            Catch ex As Exception
                Throw New Exception(ex.Message)
            End Try

        End Function

        Public Sub Close()
            connDB.Close()
        End Sub

#End Region

    End Class

End Namespace

