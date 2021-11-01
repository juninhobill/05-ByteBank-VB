Namespace Classes.Bibliotecas

    Public Class ClasseTeste

        Sub Teste()

            'Dim x As New ModificadoresTeste
            'x.MetodoPublico()
            'x.MetodoPrivado()
            'x.MetodoProtegido()
            'x.MetodoInterno()

        End Sub

    End Class

    Public Class ClasseDerivada
        Inherits ModificadoresTeste

        Sub Teste2()
            MetodoProtegido()
        End Sub

    End Class

    Public Class ModificadoresTeste

        Public Sub Teste()

            Dim x As New ModificadoresTeste
            x.MetodoPublico()
            x.MetodoPrivado()
            x.MetodoProtegido()

        End Sub

        Public Sub MetodoPublico()

            'Método acessado pela própria classe, pela classe do mesmo projeto e por classes de outros projetos

        End Sub

        Private Sub MetodoPrivado()

            'Método acessado pela própria classe, não é acessado pela classe do mesmo projeto e não é acessado
            'por classes de outros projetos

        End Sub

        Protected Sub MetodoProtegido()

            'Método acessado pela própria classe, não é acessado pela classe do mesmo projeto e não é acessado
            'por classes de outros projetos, mas pode ser acessado pelas classes derivadas

        End Sub

        Friend Sub MetodoInterno()

            'Método acessado pela própria classe, acessado pela classe do mesmo projeto e não é acessado
            'por classes de outros projetos

        End Sub

    End Class

End Namespace


