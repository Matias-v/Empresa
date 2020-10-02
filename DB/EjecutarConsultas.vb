Imports System.Data.Common
Imports System.Data.Odbc
Imports Mysql.Data.MySqlClient

Public Class EjecutarConsultas
    Property _conODBC As New OdbcConnection("dsn=Empresa;uid=root;pwd=")
    Private connMysql As String = "server=localhost;database=empresa;user id=root;password=;port=3306;"
    Private conn As New MySqlConnection
    Dim guardado As Boolean = False

    Public Sub New(connMysql As String, conn As MySqlConnection)
        Me.connMysql = connMysql
        Me.conn = conn
    End Sub

    Public Sub New()

    End Sub

    Public Sub probarConexion()

        Dim datos_conexion As New MySqlConnectionStringBuilder
        Dim con As MySqlConnection
        datos_conexion.Server = "localhost"
        datos_conexion.Port = "3306"
        datos_conexion.UserID = "root"
        datos_conexion.Password = ""
        datos_conexion.Database = "empresa"
        con = New MySqlConnection(datos_conexion.ToString)
        con.Open()
        MsgBox("Conexión establecida con éxito ! ")
        con.Close()

    End Sub

    Public Function tryComando(consulta)
        Dim command As New OdbcCommand(consulta, _conODBC)
        Dim dt As New DataTable
        Dim da As OdbcDataAdapter
        Dim ds As New DataSet

        Try
            da = New OdbcDataAdapter(consulta, _conODBC)
            _conODBC.Open()
            da.Fill(ds)
            command.ExecuteNonQuery()
            dt = ds.Tables(0)
            _conODBC.Close()


        Catch ex As Exception
            MsgBox("Error en ejecutar: " & ex.Message)
        End Try

        Return dt

    End Function
    Public Function consultaEjecutar(consulta As String)
        Dim commandSQL As New MySqlCommand(consulta, conn)
        Try
            conn.Open()
            commandSQL.ExecuteNonQuery()
            conn.Close()
            Return True
        Catch ex As Exception
            MsgBox("Error en ejecutar: " & ex.Message)
            conn.Close()
            Return False
        End Try
    End Function

End Class
