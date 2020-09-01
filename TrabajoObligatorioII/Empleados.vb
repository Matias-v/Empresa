Public Class Empleados
    Private Sub btn_agr_Click(sender As Object, e As EventArgs) Handles btn_agr.Click
        Dim agr As New Logic.Empleado()
        Try
            agr.llamarInsert(Convert.ToInt32(txt_idpersona.Text), Convert.ToInt32(txt_idtipo.Text), Convert.ToInt32(txt_sueldo.Text))
            'id_empleado As Integer, id_persona As Integer, id_tipo As Integer, sueldo As Integer
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btn_List_Click(sender As Object, e As EventArgs) Handles btn_List.Click
        Dim list As New Logic.Empleado()
        gv_Empleados.DataSource = list.llamarSelect()
    End Sub

    Private Sub btn_elim_Click(sender As Object, e As EventArgs) Handles btn_elim.Click
        Dim eli As New Logic.Empleado()
        Try
            eli.llamarBaja(Convert.ToInt32(txt_idempleado.Text))
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btn_mod_Click(sender As Object, e As EventArgs) Handles btn_mod.Click
        Dim modi As New Logic.Empleado()
        Try
            modi.llamarUpdate(Convert.ToInt32(txt_idempleado.Text), Convert.ToInt32(txt_idpersona.Text), Convert.ToInt32(txt_idtipo.Text), Convert.ToInt32(txt_sueldo.Text))
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btn_salir_Click(sender As Object, e As EventArgs) Handles btn_salir.Click
        Me.Close()
    End Sub

    Private Sub btn_volver_Click(sender As Object, e As EventArgs) Handles btn_volver.Click
        Me.Hide()
    End Sub
End Class