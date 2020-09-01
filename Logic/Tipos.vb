Public Class Tipos
    Property _tabla As String
    Property _tipo As String
    Property _condicion As String
    Public Sub Tipos()

    End Sub
    Public Sub Tipos(tabla As String, tipo As String, condicion As String)
        _tabla = tabla
        _tipo = tipo
        _condicion = condicion
    End Sub

    Public Function llamarInsert(tipo As String, tabla As String)
        Dim alta As New DB.Alta()
        Return alta.insertTipos(tipo, tabla)
        'Verificar si los datos no estan vacios va directamente en la presentacion'

    End Function

    Public Function llamarBaja(tipo As String, tabla As String)
        Dim baja As New DB.Baja()
        Return baja.deleteTipos(tipo, tabla)
        'Verificar si los datos no estan vacios va directamente en la presentacion'

    End Function

    Public Function llamarUpdate(tipo As String, tabla As String, condicion As Integer)
        Dim modi As New DB.Modificar
        Return modi.updateTipos(tipo, tabla, condicion)
    End Function

    Public Function llamarSelect(tabla As String)
        Dim listar As New DB.Listar
        Return listar.listar(tabla)
    End Function
End Class
