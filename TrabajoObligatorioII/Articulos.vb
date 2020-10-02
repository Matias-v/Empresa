Public Class Articulos


    Public Sub New()

        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()
        txt_id.Hide()
        lbl_id.Hide()
        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().

    End Sub
    Private Sub btn_salir_Click(sender As Object, e As EventArgs) Handles btn_salir.Click
        Application.Exit()

    End Sub

    Private Sub btn_volver_Click(sender As Object, e As EventArgs)
        Me.Hide()
    End Sub

    Private Sub btn_listar_Click(sender As Object, e As EventArgs) Handles btn_listar.Click
        Dim list As New Logic.Articulo()
        gv_Articulos.DataSource = list.llamarSelect()
    End Sub

    Private Sub btn_eliminar_Click(sender As Object, e As EventArgs) Handles btn_eliminar.Click
        Dim eli As New Logic.Articulo()
        eli.llamarBaja(txt_cod.Text)
    End Sub

    Private Sub btn_agregar_Click(sender As Object, e As EventArgs) Handles btn_agregar.Click
        Dim agr As New Logic.Articulo()
        agr.llamarInsert(txt_cod.Text, txt_desc.Text, txt_precio.Text, txt_fecha.Text, txt_tipo.Text) 'codigo As Integer, descripcion As String, precio As Integer, fecha_fab As String, tipo_art As String
    End Sub

    Private Sub btn_modificar_Click(sender As Object, e As EventArgs) Handles btn_modificar.Click
        MsgBox("Ingresar el codigo a modificar")


        Try
            Dim modi As New Logic.Articulo()
            modi.llamarUpdate(Convert.ToInt32(txt_cod.Text), txt_desc.Text, Convert.ToDouble(txt_precio.Text), txt_fecha.Text, txt_tipo.Text)
        Catch ex As Exception
            MsgBox("Error en presentacion: " & ex.Message)

        End Try


    End Sub

    Private Sub btn_clientes_Click(sender As Object, e As EventArgs) Handles btn_clientes.Click
        Me.Hide()
        Clientes.Show()
    End Sub

    Private Sub btn_personas_Click(sender As Object, e As EventArgs) Handles btn_personas.Click
        Me.Hide()
        Personas.Show()
    End Sub

    Private Sub btn_empleados_Click(sender As Object, e As EventArgs) Handles btn_empleados.Click
        Me.Hide()
        Empleados.Show()
    End Sub

    Private Sub btn_tipos_Click(sender As Object, e As EventArgs) Handles btn_tipos.Click
        Me.Hide()
        Tipos.Show()
    End Sub
End Class
