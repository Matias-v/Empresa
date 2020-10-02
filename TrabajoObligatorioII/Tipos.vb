Public Class Tipos

    Private Sub btn_listar_tipEmp_Click(sender As Object, e As EventArgs) Handles btn_listar.Click
        Dim listar As New Logic.Tipos()
        gv_Tipos.DataSource = listar.llamarSelect(cbo_tabla.Text)
    End Sub

    Private Sub btn_salir_Click(sender As Object, e As EventArgs)
        Me.Close()
    End Sub


    Private Sub btn_elimTipEmp_Click(sender As Object, e As EventArgs) Handles btn_elim.Click
        Dim eli As New Logic.Tipos()
        eli.llamarBaja(txt_tipo.Text, cbo_tabla.Text)
    End Sub

    Private Sub Label9_Click(sender As Object, e As EventArgs) Handles Label9.Click

    End Sub

    Private Sub btn_agr_Click(sender As Object, e As EventArgs) Handles btn_agr.Click
        Dim agr As New Logic.Tipos()
        agr.llamarInsert(txt_tipo.Text, cbo_tabla.Text)
    End Sub

    Private Sub btn_mod_Click(sender As Object, e As EventArgs) Handles btn_mod.Click
        Dim modi As New Logic.Tipos()
        modi.llamarUpdate(txt_tipo.Text, cbo_tabla.Text, txt_ID.Text) 'tipo As String, tabla As String, condicion As Integer
    End Sub

    Private Sub Tipos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txt_ID.Clear()
        txt_tipo.Clear()

    End Sub

    Private Sub btn_volver_Click(sender As Object, e As EventArgs)
        Me.Hide()
    End Sub

    Private Sub btn_personas_Click(sender As Object, e As EventArgs) Handles btn_personas.Click
        Me.Hide()
        Personas.Show()

    End Sub

    Private Sub btn_empleados_Click(sender As Object, e As EventArgs) Handles btn_empleados.Click
        Me.Hide()
        Empleados.Show()

    End Sub

    Private Sub btn_clientes_Click(sender As Object, e As EventArgs) Handles btn_clientes.Click
        Me.Hide()
        Clientes.Show()

    End Sub

    Private Sub btn_articulos_Click(sender As Object, e As EventArgs) Handles btn_articulos.Click
        Me.Hide()
        Articulos.Show()

    End Sub

    Private Sub btn_salir_Click_1(sender As Object, e As EventArgs) Handles btn_salir.Click
        Application.Exit()

    End Sub
End Class