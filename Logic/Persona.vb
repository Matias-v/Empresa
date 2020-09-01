Public Class Persona
    Property _id_persona As Integer
    Property _cedula As Integer
    Property _telf As Integer
    Property _priNom As String
    Property _segNom As String
    Property _priApe As String
    Property _segApe As String

    Public Sub Persona()

    End Sub
    Public Sub Persona(cedula As Integer, pri_nom As String, seg_nom As String, pri_ape As String, seg_ape As String, telf As Integer, direccion As String)
        _cedula = cedula
        _telf = telf
        _priNom = pri_nom
        _segNom = seg_nom
        _priApe = pri_ape
        _segApe = seg_ape
    End Sub

    Public Function llamarInsert(cedula As Integer, pri_nom As String, seg_nom As String, pri_ape As String, seg_ape As String, telf As Integer, direccion As String)
        Dim alta As New DB.Alta()
        Return alta.insertPersona(cedula, pri_nom, seg_nom, pri_ape, seg_ape, telf, direccion)
        'Verificar si los datos no estan vacios va directamente en la presentacion'

    End Function

    Public Function llamarBaja(cedula As Integer)
        Dim baja As New DB.Baja()
        Return baja.deletePersona(cedula)
        'Verificar si los datos no estan vacios va directamente en la presentacion'

    End Function

    Public Function llamarUpdate(cedula As Integer, pri_nom As String, seg_nom As String, pri_ape As String, seg_ape As String, telf As Integer, direccion As String)
        Dim modi As New DB.Modificar
        Return modi.updatePersona(cedula, pri_nom, seg_nom, pri_ape, seg_ape, telf, direccion)
    End Function

    Public Function llamarSelect()
        Dim listar As New DB.Listar
        Return listar.listar("Personas")
    End Function

End Class
