<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Clientes
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.lbl_titulo = New System.Windows.Forms.Label()
        Me.lbl_idpersona = New System.Windows.Forms.Label()
        Me.lbl_idcliente = New System.Windows.Forms.Label()
        Me.txt_idpersona = New System.Windows.Forms.TextBox()
        Me.txt_idcliente = New System.Windows.Forms.TextBox()
        Me.gv_Clientes = New System.Windows.Forms.DataGridView()
        Me.btn_List = New System.Windows.Forms.Button()
        Me.btn_mod = New System.Windows.Forms.Button()
        Me.btn_elim = New System.Windows.Forms.Button()
        Me.lbl_modificar = New System.Windows.Forms.Label()
        Me.lbl_eliminar = New System.Windows.Forms.Label()
        Me.btn_agr = New System.Windows.Forms.Button()
        Me.lbl_agregar = New System.Windows.Forms.Label()
        Me.lbl_listar = New System.Windows.Forms.Label()
        Me.btn_tipos = New System.Windows.Forms.Button()
        Me.btn_articulos = New System.Windows.Forms.Button()
        Me.btn_empleados = New System.Windows.Forms.Button()
        Me.btn_personas = New System.Windows.Forms.Button()
        Me.btn_salir = New System.Windows.Forms.Button()
        CType(Me.gv_Clientes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lbl_titulo
        '
        Me.lbl_titulo.AutoSize = True
        Me.lbl_titulo.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_titulo.Location = New System.Drawing.Point(452, 34)
        Me.lbl_titulo.Name = "lbl_titulo"
        Me.lbl_titulo.Size = New System.Drawing.Size(101, 29)
        Me.lbl_titulo.TabIndex = 68
        Me.lbl_titulo.Text = "Clientes"
        '
        'lbl_idpersona
        '
        Me.lbl_idpersona.AutoSize = True
        Me.lbl_idpersona.Location = New System.Drawing.Point(373, 321)
        Me.lbl_idpersona.Name = "lbl_idpersona"
        Me.lbl_idpersona.Size = New System.Drawing.Size(59, 13)
        Me.lbl_idpersona.TabIndex = 64
        Me.lbl_idpersona.Text = "ID persona"
        '
        'lbl_idcliente
        '
        Me.lbl_idcliente.AutoSize = True
        Me.lbl_idcliente.Location = New System.Drawing.Point(213, 321)
        Me.lbl_idcliente.Name = "lbl_idcliente"
        Me.lbl_idcliente.Size = New System.Drawing.Size(52, 13)
        Me.lbl_idcliente.TabIndex = 62
        Me.lbl_idcliente.Text = "ID cliente"
        '
        'txt_idpersona
        '
        Me.txt_idpersona.Location = New System.Drawing.Point(376, 337)
        Me.txt_idpersona.Name = "txt_idpersona"
        Me.txt_idpersona.Size = New System.Drawing.Size(122, 20)
        Me.txt_idpersona.TabIndex = 58
        '
        'txt_idcliente
        '
        Me.txt_idcliente.Location = New System.Drawing.Point(211, 337)
        Me.txt_idcliente.Name = "txt_idcliente"
        Me.txt_idcliente.Size = New System.Drawing.Size(122, 20)
        Me.txt_idcliente.TabIndex = 56
        '
        'gv_Clientes
        '
        Me.gv_Clientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.gv_Clientes.Location = New System.Drawing.Point(181, 66)
        Me.gv_Clientes.Name = "gv_Clientes"
        Me.gv_Clientes.Size = New System.Drawing.Size(726, 242)
        Me.gv_Clientes.TabIndex = 55
        '
        'btn_List
        '
        Me.btn_List.Location = New System.Drawing.Point(761, 403)
        Me.btn_List.Name = "btn_List"
        Me.btn_List.Size = New System.Drawing.Size(119, 33)
        Me.btn_List.TabIndex = 54
        Me.btn_List.Text = "Siguiente"
        Me.btn_List.UseVisualStyleBackColor = True
        '
        'btn_mod
        '
        Me.btn_mod.Location = New System.Drawing.Point(761, 337)
        Me.btn_mod.Name = "btn_mod"
        Me.btn_mod.Size = New System.Drawing.Size(119, 33)
        Me.btn_mod.TabIndex = 49
        Me.btn_mod.Text = "Siguiente"
        Me.btn_mod.UseVisualStyleBackColor = True
        '
        'btn_elim
        '
        Me.btn_elim.Location = New System.Drawing.Point(630, 403)
        Me.btn_elim.Name = "btn_elim"
        Me.btn_elim.Size = New System.Drawing.Size(119, 33)
        Me.btn_elim.TabIndex = 48
        Me.btn_elim.Text = "Siguiente"
        Me.btn_elim.UseVisualStyleBackColor = True
        '
        'lbl_modificar
        '
        Me.lbl_modificar.AutoSize = True
        Me.lbl_modificar.Location = New System.Drawing.Point(758, 321)
        Me.lbl_modificar.Name = "lbl_modificar"
        Me.lbl_modificar.Size = New System.Drawing.Size(84, 13)
        Me.lbl_modificar.TabIndex = 47
        Me.lbl_modificar.Text = "Modificar cliente"
        '
        'lbl_eliminar
        '
        Me.lbl_eliminar.AutoSize = True
        Me.lbl_eliminar.Location = New System.Drawing.Point(627, 387)
        Me.lbl_eliminar.Name = "lbl_eliminar"
        Me.lbl_eliminar.Size = New System.Drawing.Size(77, 13)
        Me.lbl_eliminar.TabIndex = 46
        Me.lbl_eliminar.Text = "Eliminar cliente"
        '
        'btn_agr
        '
        Me.btn_agr.Location = New System.Drawing.Point(630, 337)
        Me.btn_agr.Name = "btn_agr"
        Me.btn_agr.Size = New System.Drawing.Size(125, 33)
        Me.btn_agr.TabIndex = 45
        Me.btn_agr.Text = "Siguiente"
        Me.btn_agr.UseVisualStyleBackColor = True
        '
        'lbl_agregar
        '
        Me.lbl_agregar.AutoSize = True
        Me.lbl_agregar.Location = New System.Drawing.Point(627, 321)
        Me.lbl_agregar.Name = "lbl_agregar"
        Me.lbl_agregar.Size = New System.Drawing.Size(78, 13)
        Me.lbl_agregar.TabIndex = 44
        Me.lbl_agregar.Text = "Agregar cliente"
        '
        'lbl_listar
        '
        Me.lbl_listar.AutoSize = True
        Me.lbl_listar.Location = New System.Drawing.Point(762, 387)
        Me.lbl_listar.Name = "lbl_listar"
        Me.lbl_listar.Size = New System.Drawing.Size(71, 13)
        Me.lbl_listar.TabIndex = 69
        Me.lbl_listar.Text = "Listar clientes"
        '
        'btn_tipos
        '
        Me.btn_tipos.Location = New System.Drawing.Point(24, 245)
        Me.btn_tipos.Name = "btn_tipos"
        Me.btn_tipos.Size = New System.Drawing.Size(132, 23)
        Me.btn_tipos.TabIndex = 73
        Me.btn_tipos.Text = "Tipos"
        Me.btn_tipos.UseVisualStyleBackColor = True
        '
        'btn_articulos
        '
        Me.btn_articulos.Location = New System.Drawing.Point(24, 197)
        Me.btn_articulos.Name = "btn_articulos"
        Me.btn_articulos.Size = New System.Drawing.Size(132, 23)
        Me.btn_articulos.TabIndex = 72
        Me.btn_articulos.Text = "Articulos"
        Me.btn_articulos.UseVisualStyleBackColor = True
        '
        'btn_empleados
        '
        Me.btn_empleados.Location = New System.Drawing.Point(24, 150)
        Me.btn_empleados.Name = "btn_empleados"
        Me.btn_empleados.Size = New System.Drawing.Size(132, 23)
        Me.btn_empleados.TabIndex = 71
        Me.btn_empleados.Text = "Empleados"
        Me.btn_empleados.UseVisualStyleBackColor = True
        '
        'btn_personas
        '
        Me.btn_personas.Location = New System.Drawing.Point(24, 106)
        Me.btn_personas.Name = "btn_personas"
        Me.btn_personas.Size = New System.Drawing.Size(132, 23)
        Me.btn_personas.TabIndex = 70
        Me.btn_personas.Text = "Personas"
        Me.btn_personas.UseVisualStyleBackColor = True
        '
        'btn_salir
        '
        Me.btn_salir.BackgroundImage = Global.TrabajoObligatorioII.My.Resources.Resources.salir
        Me.btn_salir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btn_salir.FlatAppearance.BorderSize = 0
        Me.btn_salir.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_salir.Location = New System.Drawing.Point(856, 12)
        Me.btn_salir.Name = "btn_salir"
        Me.btn_salir.Size = New System.Drawing.Size(51, 36)
        Me.btn_salir.TabIndex = 74
        Me.btn_salir.UseVisualStyleBackColor = True
        '
        'Clientes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(924, 474)
        Me.Controls.Add(Me.btn_salir)
        Me.Controls.Add(Me.btn_tipos)
        Me.Controls.Add(Me.btn_articulos)
        Me.Controls.Add(Me.btn_empleados)
        Me.Controls.Add(Me.btn_personas)
        Me.Controls.Add(Me.lbl_listar)
        Me.Controls.Add(Me.lbl_titulo)
        Me.Controls.Add(Me.lbl_idpersona)
        Me.Controls.Add(Me.lbl_idcliente)
        Me.Controls.Add(Me.txt_idpersona)
        Me.Controls.Add(Me.txt_idcliente)
        Me.Controls.Add(Me.gv_Clientes)
        Me.Controls.Add(Me.btn_List)
        Me.Controls.Add(Me.btn_mod)
        Me.Controls.Add(Me.btn_elim)
        Me.Controls.Add(Me.lbl_modificar)
        Me.Controls.Add(Me.lbl_eliminar)
        Me.Controls.Add(Me.btn_agr)
        Me.Controls.Add(Me.lbl_agregar)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Clientes"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Clientes"
        CType(Me.gv_Clientes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lbl_titulo As Label
    Friend WithEvents lbl_idpersona As Label
    Friend WithEvents lbl_idcliente As Label
    Friend WithEvents txt_idpersona As TextBox
    Friend WithEvents txt_idcliente As TextBox
    Friend WithEvents gv_Clientes As DataGridView
    Friend WithEvents btn_List As Button
    Friend WithEvents btn_mod As Button
    Friend WithEvents btn_elim As Button
    Friend WithEvents lbl_modificar As Label
    Friend WithEvents lbl_eliminar As Label
    Friend WithEvents btn_agr As Button
    Friend WithEvents lbl_agregar As Label
    Friend WithEvents lbl_listar As Label
    Friend WithEvents btn_tipos As Button
    Friend WithEvents btn_articulos As Button
    Friend WithEvents btn_empleados As Button
    Friend WithEvents btn_personas As Button
    Friend WithEvents btn_salir As Button
End Class
