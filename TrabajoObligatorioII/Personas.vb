Public Class Personas

    Private Sub Personas_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btn_List_Click(sender As Object, e As EventArgs) Handles btn_List.Click
        Dim list As New Logic.Persona()
        gv_Personas.DataSource = list.llamarSelect()
    End Sub

    Private Sub btn_salir_Click(sender As Object, e As EventArgs)
        Me.Close()
    End Sub

    Private Sub btn_volver_Click(sender As Object, e As EventArgs)
        Me.Hide()
    End Sub

    Private Sub btn_elim_Click(sender As Object, e As EventArgs) Handles btn_elim.Click
        Dim eli As New Logic.Persona()
        eli.llamarBaja(txt_cedula.Text)

    End Sub

    Private Sub btn_agr_Click(sender As Object, e As EventArgs) Handles btn_agr.Click
        Dim agr As New Logic.Persona()
        agr.llamarInsert(txt_cedula.Text, txt_pNom.Text, txt_sNom.Text, txt_pApe.Text, txt_sApe.Text, Convert.ToInt32(txt_telf.Text), txt_dir.Text)
        '(cedula As Integer, pri_nom As String, seg_nom As String, pri_ape As String, seg_ape As String, telf As Integer, direccion As String
    End Sub

    Private Sub btn_mod_Click(sender As Object, e As EventArgs) Handles btn_mod.Click
        Dim modi As New Logic.Persona()
        Try
            modi.llamarUpdate(Convert.ToInt32(txt_cedula.Text), txt_pNom.Text, txt_sNom.Text, txt_pApe.Text, txt_sApe.Text, Convert.ToInt32(txt_telf.Text), txt_dir.Text)
        Catch ex As Exception

        End Try
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

    Private Sub btn_tipos_Click(sender As Object, e As EventArgs) Handles btn_tipos.Click
        Me.Close()
        Tipos.Show()
    End Sub

    Private Sub btn_salir_Click_1(sender As Object, e As EventArgs) Handles btn_salir.Click
        Application.Exit()

    End Sub
End Class