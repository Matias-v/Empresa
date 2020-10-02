Public Class Listar
    Dim ejecutar As New EjecutarConsultas()
    Public Function listar(tabla As String)
        Dim consulta As String = "select * from " & tabla

        Return ejecutar.consultaEjecutar(consulta)
    End Function
End Class
