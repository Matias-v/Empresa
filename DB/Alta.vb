
Public Class Alta
    Dim ejecutar As New EjecutarConsultas()
    Public Function insertArticulo(codigo As Integer, descripcion As String, precio As Integer, fecha_fab As String, tipo_art As String)
        Dim consulta As String = "insert into articulos (`codigo`, `foto`, `descripcion`, `precio`, `fecha_fabricacion`,`tipo_articulo`)"
        consulta = consulta + " values ("
        consulta = consulta & codigo.ToString & ","
        consulta = consulta & "'',"
        consulta = consulta & "'" & descripcion & "',"
        consulta = consulta & "'" & precio.ToString & "',"
        consulta = consulta & "'" & fecha_fab & "',"
        consulta = consulta & "'" & tipo_art & "');"

        Return ejecutar.tryComando(consulta)

    End Function

    Public Function insertPersona(cedula As Integer, pri_nom As String, seg_nom As String, pri_ape As String, seg_ape As String, telf As Integer, direccion As String)
        Dim consulta As String = "insert into personas (`cedula`, `primer_nombre`, `segundo_nombre`, `primer_apellido`, `segundo_apellido`,`telefono`,`direccion`)"
        consulta = consulta + " values ("
        consulta = consulta + cedula.ToString & ","
        consulta = consulta + "'" & pri_nom & "',"
        consulta = consulta + "'" & seg_nom & "',"
        consulta = consulta + "'" & pri_ape & "',"
        consulta = consulta + "'" & seg_ape & "',"
        consulta = consulta + telf.ToString & ","
        consulta = consulta + "'" & direccion & "');"

        Return ejecutar.tryComando(consulta)
    End Function

    Public Function insertEmpleado(id_persona As Integer, id_tipo As Integer, sueldo As Integer)
        Dim consulta As String = "insert into empleados (`id_persona`,`id_tipo`, `sueldoMens`)"
        consulta = consulta & "values ("
        consulta = consulta & id_persona.ToString & ","
        consulta = consulta & id_tipo.ToString & ","
        consulta = consulta & sueldo.ToString & ");"

        Return ejecutar.tryComando(consulta)
    End Function

    Public Function insertCliente(id_persona As Integer)
        Dim consulta As String = "insert into cliente (`id_persona`)"
        consulta = consulta & " values ("
        consulta = consulta & id_persona.ToString & ");"

        Return ejecutar.tryComando(consulta)
    End Function

    Public Function insertTipos(tipo As String, tabla As String)
        'TipoArticulo y TipoEmpleado'
        Dim consulta As String = "insert into " & tabla & " (`tipo`)"
        consulta = consulta & " values ('"
        consulta = consulta & tipo & "');"

        Return ejecutar.tryComando(consulta)
    End Function
End Class
