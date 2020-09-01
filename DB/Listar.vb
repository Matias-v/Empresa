Public Class Listar
    Dim ejecutar As New EjecutarConsultas()
    Public Function listar(tabla As String)
        Dim consulta As String = "select * from " & tabla

        Return ejecutar.tryComando(consulta)
    End Function
End Class
