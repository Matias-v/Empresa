Imports System.Data.Common
Imports System.Data.Odbc
Public Class EjecutarConsultas
    Property _conODBC As New OdbcConnection("dsn=Empresa;uid=root;pwd=")
    Dim guardado As Boolean = False
    Public Function tryComando(consulta)
        Dim command As New OdbcCommand(consulta, _conODBC)
        Dim dt As New DataTable
        Dim da As OdbcDataAdapter
        Dim ds As New DataSet

        Try
            da = New OdbcDataAdapter(consulta, _conODBC)
            _conODBC.Open()
            da.Fill(ds)
            'command.ExecuteNonQuery()
            _conODBC.Close()
            dt = ds.Tables(0)

        Catch ex As Exception
            MsgBox("Error en ejecutar: " & ex.Message)
        End Try

        Return dt
    End Function
End Class
