Public Class Modificar
    Dim ejecutar As New EjecutarConsultas()
    Public Function updateArticulo(codigo As Integer, descripcion As String, precio As Integer, fecha_fab As String, tipo_art As String)
        Dim consulta As String = "update articulos set "
        consulta &= "descripcion = '" & descripcion & "',"
        consulta &= "precio =" & precio.ToString & ","
        consulta &= "fecha_fabricacion = '" & fecha_fab & "',"
        consulta &= "tipo_articulo = '" & tipo_art & "' "
        consulta &= "where codigo =" & codigo.ToString

        Return ejecutar.tryComando(consulta)
    End Function

    Public Function updatePersona(cedula As Integer, pri_nom As String, seg_nom As String, pri_ape As String, seg_ape As String, telf As Integer, direccion As String)
        Dim consulta As String = "UPDATE personas SET "
        consulta &= "primer_nombre = '" & pri_nom & "',"
        consulta &= "segundo_nombre = '" & seg_nom & "',"
        consulta &= "primer_apellido = '" & pri_ape & "',"
        consulta &= "segundo_apellido = '" & seg_ape & "',"
        consulta &= "telefono = " & telf.ToString & ","
        consulta &= "direccion = '" & direccion & "'"
        consulta &= "where cedula= " & cedula.ToString

        Return ejecutar.tryComando(consulta)
    End Function

    Public Function updateEmpleado(id_empleado As Integer, id_persona As Integer, id_tipo As Integer, sueldo As Integer)
        Dim consulta As String = "update empleados set "
        consulta &= "id_persona = " & id_persona.ToString & ", "
        consulta &= "id_tipo = " & id_tipo.ToString & ", "
        consulta &= "sueldoMens =" & sueldo.ToString & " "
        consulta &= "where id_empleado =" & id_empleado.ToString & ";"

        Return ejecutar.tryComando(consulta)
    End Function

    Public Function updateCliente(id_cliente As Integer, id_persona As Integer)
        Dim consulta As String = "update cliente set id_persona=" & id_persona & " where id_cliente = " & id_cliente & ";" 'update cliente set id_persona=6 where id_cliente=7;

        Return ejecutar.tryComando(consulta)
    End Function

    Public Function updateTipos(tipo As String, tabla As String, condicion As Integer)
        'TipoArticulo y TipoEmpleado'
        Dim consulta As String = "UPDATE " & tabla & " SET tipo = '" & tipo & "' WHERE id_" & tabla & "= " & condicion & ";"

        Return ejecutar.tryComando(consulta)
    End Function
End Class
