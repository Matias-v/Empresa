Public Class Empleado
    Inherits Persona
    Property _id_empleado As Integer
    Property _id_persona As Integer
    Property _id_tipo As Integer
    Property _sueldo As Integer

    Public Sub Empleado()

    End Sub
    Public Sub Empleado(id_empleado As Integer, id_persona As Integer, id_tipo As Integer, sueldo As Integer)
        _id_empleado = id_empleado
        _id_persona = id_persona
        _id_tipo = id_tipo
        _sueldo = sueldo
    End Sub

    Public Function llamarInsert(id_persona As Integer, id_tipo As Integer, sueldo As Integer)
        Dim alta As New DB.Alta()
        Return alta.insertEmpleado(id_persona, id_tipo, sueldo)
        'Verificar si los datos no estan vacios va directamente en la presentacion'

    End Function

    Public Function llamarBaja(id_empleado As Integer)
        Dim baja As New DB.Baja()
        Return baja.deleteEmpleado(id_empleado)
        'Verificar si los datos no estan vacios va directamente en la presentacion'

    End Function

    Public Function llamarUpdate(id_empleado As Integer, id_persona As Integer, id_tipo As Integer, sueldo As Integer)
        Dim modi As New DB.Modificar
        Return modi.updateEmpleado(id_empleado, id_persona, id_tipo, sueldo)
    End Function

    Public Function llamarSelect()
        Dim listar As New DB.Listar
        Return listar.listar("Empleados")
    End Function
End Class
