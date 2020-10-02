Public Class Clientes
    Private Sub btn_modArt_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub btn_List_Click(sender As Object, e As EventArgs) Handles btn_List.Click
        Dim list As New Logic.Cliente()
        gv_Clientes.DataSource = list.llamarSelect()
    End Sub

    Private Sub btn_salir_Click(sender As Object, e As EventArgs)
        Me.Close()
    End Sub

    Private Sub btn_volver_Click(sender As Object, e As EventArgs)
        Me.Hide()
    End Sub

    Private Sub btn_agr_Click(sender As Object, e As EventArgs) Handles btn_agr.Click
        Try
            Dim agr As New Logic.Cliente()
            agr.llamarInsert(Convert.ToInt32(txt_idpersona.Text))
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btn_elim_Click(sender As Object, e As EventArgs) Handles btn_elim.Click
        MsgBox("Ingresar el ID del cliente")
        Try
            Dim eli As New Logic.Cliente()
            eli.llamarBaja(Convert.ToInt32(txt_idcliente.Text))
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btn_mod_Click(sender As Object, e As EventArgs) Handles btn_mod.Click
        Try
            Dim modi As New Logic.Cliente()
            modi.llamarUpdate(Convert.ToInt32(txt_idcliente.Text), Convert.ToInt32(txt_idpersona.Text))
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btn_articulos_Click(sender As Object, e As EventArgs) Handles btn_articulos.Click
        Me.Hide()
        Articulos.Show()

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

    Private Sub btn_salir_Click_1(sender As Object, e As EventArgs) Handles btn_salir.Click
        Application.Exit()

    End Sub
End Class