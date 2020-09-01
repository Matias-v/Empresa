Public Class Baja
    Dim ejecutar As New EjecutarConsultas()
    Public Function deleteArticulo(codigo As Integer)
        Dim consulta As String = "delete from articulos where codigo=" & codigo & ";"

        Return ejecutar.tryComando(consulta)
    End Function

    Public Function deletePersona(cedula As Integer)
        Dim consulta As String = "delete from personas where cedula=" & cedula & ";"

        Return ejecutar.tryComando(consulta)
    End Function

    Public Function deleteEmpleado(id_empleado As Integer)
        Dim consulta As String = "delete from empleados where id_empleado=" & id_empleado & ";"

        Return ejecutar.tryComando(consulta)
    End Function

    Public Function deleteCliente(id_cliente As Integer)
        Dim consulta As String = "delete from cliente where id_cliente=" & id_cliente & ";"

        Return ejecutar.tryComando(consulta)
    End Function

    Public Function deleteTipos(tipo As String, tabla As String)
        'TipoArticulo y TipoEmpleado'
        Dim consulta As String = "delete from " & tabla & " where tipo= '" & tipo & "';"

        Return ejecutar.tryComando(consulta)
    End Function
End Class
