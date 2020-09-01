Imports System.Data.Common
Imports System.Data.Odbc
Imports DB.Alta
Imports DB.Baja
Imports DB.Modificar
Public Class Articulo
    Property _codigo As Integer
    Property _descripcion As String
    Property _precio As Integer
    Property _fecha_fab As String
    Property tipo_art As String

    Public Sub Articulo()

    End Sub
    Public Sub Articulo(codigo As Integer, descripcion As String, precio As Integer, fecha_fab As String, tipo_art As String)
        _codigo = codigo
        _descripcion = descripcion
        _precio = precio
        _fecha_fab = fecha_fab
        _tipo_art = tipo_art
    End Sub

    Public Function llamarInsert(codigo As Integer, descripcion As String, precio As Integer, fecha_fab As String, tipo_art As String)
        Dim alta As New DB.Alta()
        Return alta.insertArticulo(codigo, descripcion, precio, fecha_fab, tipo_art) 'codigo As Integer, descripcion As String, precio As Integer, fecha_fab As String, tipo_art As String
        'Verificar si los datos no estan vacios va directamente en la presentacion'

    End Function

    Public Function llamarBaja(codigo As Integer)
        Dim baja As New DB.Baja()
        Return baja.deleteArticulo(codigo)
        'Verificar si los datos no estan vacios va directamente en la presentacion'

    End Function

    Public Function llamarUpdate(codigo As Integer, descripcion As String, precio As Integer, fecha_fab As String, tipo_art As String)
        Dim modi As New DB.Modificar
        Return modi.updateArticulo(codigo, descripcion, precio, fecha_fab, tipo_art)
    End Function

    Public Function llamarSelect()
        Dim listar As New DB.Listar
        Return listar.listar("Articulos")
    End Function

End Class
