Public Class Cliente
    Inherits Persona
    Property _id_cliente As Integer
    Property _id_persona As Integer

    Public Sub Cliente()

    End Sub
    Public Sub Cliente(id_cliente As Integer, id_persona As Integer)
        _id_cliente = _id_cliente
        _id_persona = id_persona
    End Sub

    Public Function llamarInsert(id_persona As Integer)
        Dim alta As New DB.Alta()
        Return alta.insertCliente(id_persona)
        'Verificar si los datos no estan vacios va directamente en la presentacion'

    End Function

    Public Function llamarBaja(id_cliente As Integer)
        Dim baja As New DB.Baja()
        Return baja.deleteCliente(id_cliente)
        'Verificar si los datos no estan vacios va directamente en la presentacion'

    End Function

    Public Function llamarUpdate(id_cliente As Integer, id_persona As Integer)
        Dim modi As New DB.Modificar
        Return modi.updateCliente(id_cliente, id_persona)
    End Function

    Public Function llamarSelect()
        Dim listar As New DB.Listar
        Return listar.listar("cliente")
    End Function
End Class
