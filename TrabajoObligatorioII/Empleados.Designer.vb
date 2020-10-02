<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Empleados
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
        Me.lbl_listar = New System.Windows.Forms.Label()
        Me.lbl_titulo = New System.Windows.Forms.Label()
        Me.lbl_idpersona = New System.Windows.Forms.Label()
        Me.lbl_idempleado = New System.Windows.Forms.Label()
        Me.txt_idpersona = New System.Windows.Forms.TextBox()
        Me.txt_idempleado = New System.Windows.Forms.TextBox()
        Me.gv_Empleados = New System.Windows.Forms.DataGridView()
        Me.btn_List = New System.Windows.Forms.Button()
        Me.btn_mod = New System.Windows.Forms.Button()
        Me.btn_elim = New System.Windows.Forms.Button()
        Me.lbl_modificar = New System.Windows.Forms.Label()
        Me.lbl_eliminar = New System.Windows.Forms.Label()
        Me.btn_agr = New System.Windows.Forms.Button()
        Me.lbl_agregar = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txt_idtipo = New System.Windows.Forms.TextBox()
        Me.lbl_sueldo = New System.Windows.Forms.Label()
        Me.txt_sueldo = New System.Windows.Forms.TextBox()
        Me.btn_tipos = New System.Windows.Forms.Button()
        Me.btn_articulos = New System.Windows.Forms.Button()
        Me.btn_clientes = New System.Windows.Forms.Button()
        Me.btn_personas = New System.Windows.Forms.Button()
        Me.btn_salir = New System.Windows.Forms.Button()
        CType(Me.gv_Empleados, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lbl_listar
        '
        Me.lbl_listar.AutoSize = True
        Me.lbl_listar.Location = New System.Drawing.Point(784, 385)
        Me.lbl_listar.Name = "lbl_listar"
        Me.lbl_listar.Size = New System.Drawing.Size(81, 13)
        Me.lbl_listar.TabIndex = 87
        Me.lbl_listar.Text = "Listar empleado"
        '
        'lbl_titulo
        '
        Me.lbl_titulo.AutoSize = True
        Me.lbl_titulo.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_titulo.Location = New System.Drawing.Point(458, 28)
        Me.lbl_titulo.Name = "lbl_titulo"
        Me.lbl_titulo.Size = New System.Drawing.Size(136, 29)
        Me.lbl_titulo.TabIndex = 86
        Me.lbl_titulo.Text = "Empleados"
        '
        'lbl_idpersona
        '
        Me.lbl_idpersona.AutoSize = True
        Me.lbl_idpersona.Location = New System.Drawing.Point(343, 326)
        Me.lbl_idpersona.Name = "lbl_idpersona"
        Me.lbl_idpersona.Size = New System.Drawing.Size(59, 13)
        Me.lbl_idpersona.TabIndex = 85
        Me.lbl_idpersona.Text = "ID persona"
        '
        'lbl_idempleado
        '
        Me.lbl_idempleado.AutoSize = True
        Me.lbl_idempleado.Location = New System.Drawing.Point(183, 326)
        Me.lbl_idempleado.Name = "lbl_idempleado"
        Me.lbl_idempleado.Size = New System.Drawing.Size(67, 13)
        Me.lbl_idempleado.TabIndex = 84
        Me.lbl_idempleado.Text = "ID empleado"
        '
        'txt_idpersona
        '
        Me.txt_idpersona.Location = New System.Drawing.Point(346, 342)
        Me.txt_idpersona.Name = "txt_idpersona"
        Me.txt_idpersona.Size = New System.Drawing.Size(122, 20)
        Me.txt_idpersona.TabIndex = 83
        '
        'txt_idempleado
        '
        Me.txt_idempleado.Location = New System.Drawing.Point(181, 342)
        Me.txt_idempleado.Name = "txt_idempleado"
        Me.txt_idempleado.Size = New System.Drawing.Size(122, 20)
        Me.txt_idempleado.TabIndex = 82
        '
        'gv_Empleados
        '
        Me.gv_Empleados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.gv_Empleados.Location = New System.Drawing.Point(181, 60)
        Me.gv_Empleados.Name = "gv_Empleados"
        Me.gv_Empleados.Size = New System.Drawing.Size(726, 242)
        Me.gv_Empleados.TabIndex = 81
        '
        'btn_List
        '
        Me.btn_List.Location = New System.Drawing.Point(783, 401)
        Me.btn_List.Name = "btn_List"
        Me.btn_List.Size = New System.Drawing.Size(119, 33)
        Me.btn_List.TabIndex = 80
        Me.btn_List.Text = "Siguiente"
        Me.btn_List.UseVisualStyleBackColor = True
        '
        'btn_mod
        '
        Me.btn_mod.Location = New System.Drawing.Point(783, 335)
        Me.btn_mod.Name = "btn_mod"
        Me.btn_mod.Size = New System.Drawing.Size(119, 33)
        Me.btn_mod.TabIndex = 75
        Me.btn_mod.Text = "Siguiente"
        Me.btn_mod.UseVisualStyleBackColor = True
        '
        'btn_elim
        '
        Me.btn_elim.Location = New System.Drawing.Point(652, 401)
        Me.btn_elim.Name = "btn_elim"
        Me.btn_elim.Size = New System.Drawing.Size(119, 33)
        Me.btn_elim.TabIndex = 74
        Me.btn_elim.Text = "Siguiente"
        Me.btn_elim.UseVisualStyleBackColor = True
        '
        'lbl_modificar
        '
        Me.lbl_modificar.AutoSize = True
        Me.lbl_modificar.Location = New System.Drawing.Point(780, 319)
        Me.lbl_modificar.Name = "lbl_modificar"
        Me.lbl_modificar.Size = New System.Drawing.Size(99, 13)
        Me.lbl_modificar.TabIndex = 73
        Me.lbl_modificar.Text = "Modificar empleado"
        '
        'lbl_eliminar
        '
        Me.lbl_eliminar.AutoSize = True
        Me.lbl_eliminar.Location = New System.Drawing.Point(649, 385)
        Me.lbl_eliminar.Name = "lbl_eliminar"
        Me.lbl_eliminar.Size = New System.Drawing.Size(92, 13)
        Me.lbl_eliminar.TabIndex = 72
        Me.lbl_eliminar.Text = "Eliminar empleado"
        '
        'btn_agr
        '
        Me.btn_agr.Location = New System.Drawing.Point(652, 335)
        Me.btn_agr.Name = "btn_agr"
        Me.btn_agr.Size = New System.Drawing.Size(125, 33)
        Me.btn_agr.TabIndex = 71
        Me.btn_agr.Text = "Siguiente"
        Me.btn_agr.UseVisualStyleBackColor = True
        '
        'lbl_agregar
        '
        Me.lbl_agregar.AutoSize = True
        Me.lbl_agregar.Location = New System.Drawing.Point(649, 319)
        Me.lbl_agregar.Name = "lbl_agregar"
        Me.lbl_agregar.Size = New System.Drawing.Size(93, 13)
        Me.lbl_agregar.TabIndex = 70
        Me.lbl_agregar.Text = "Agregar empleado"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(178, 385)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(38, 13)
        Me.Label1.TabIndex = 89
        Me.Label1.Text = "ID tipo"
        '
        'txt_idtipo
        '
        Me.txt_idtipo.Location = New System.Drawing.Point(181, 401)
        Me.txt_idtipo.Name = "txt_idtipo"
        Me.txt_idtipo.Size = New System.Drawing.Size(122, 20)
        Me.txt_idtipo.TabIndex = 88
        '
        'lbl_sueldo
        '
        Me.lbl_sueldo.AutoSize = True
        Me.lbl_sueldo.Location = New System.Drawing.Point(343, 385)
        Me.lbl_sueldo.Name = "lbl_sueldo"
        Me.lbl_sueldo.Size = New System.Drawing.Size(40, 13)
        Me.lbl_sueldo.TabIndex = 91
        Me.lbl_sueldo.Text = "Sueldo"
        '
        'txt_sueldo
        '
        Me.txt_sueldo.Location = New System.Drawing.Point(346, 401)
        Me.txt_sueldo.Name = "txt_sueldo"
        Me.txt_sueldo.Size = New System.Drawing.Size(122, 20)
        Me.txt_sueldo.TabIndex = 90
        '
        'btn_tipos
        '
        Me.btn_tipos.Location = New System.Drawing.Point(31, 229)
        Me.btn_tipos.Name = "btn_tipos"
        Me.btn_tipos.Size = New System.Drawing.Size(99, 23)
        Me.btn_tipos.TabIndex = 95
        Me.btn_tipos.Text = "Tipos"
        Me.btn_tipos.UseVisualStyleBackColor = True
        '
        'btn_articulos
        '
        Me.btn_articulos.Location = New System.Drawing.Point(31, 181)
        Me.btn_articulos.Name = "btn_articulos"
        Me.btn_articulos.Size = New System.Drawing.Size(99, 23)
        Me.btn_articulos.TabIndex = 94
        Me.btn_articulos.Text = "Articulos"
        Me.btn_articulos.UseVisualStyleBackColor = True
        '
        'btn_clientes
        '
        Me.btn_clientes.Location = New System.Drawing.Point(31, 134)
        Me.btn_clientes.Name = "btn_clientes"
        Me.btn_clientes.Size = New System.Drawing.Size(99, 23)
        Me.btn_clientes.TabIndex = 93
        Me.btn_clientes.Text = "Clientes"
        Me.btn_clientes.UseVisualStyleBackColor = True
        '
        'btn_personas
        '
        Me.btn_personas.Location = New System.Drawing.Point(31, 90)
        Me.btn_personas.Name = "btn_personas"
        Me.btn_personas.Size = New System.Drawing.Size(99, 23)
        Me.btn_personas.TabIndex = 92
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
        Me.btn_salir.TabIndex = 96
        Me.btn_salir.UseVisualStyleBackColor = True
        '
        'Empleados
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(930, 482)
        Me.Controls.Add(Me.btn_salir)
        Me.Controls.Add(Me.btn_tipos)
        Me.Controls.Add(Me.btn_articulos)
        Me.Controls.Add(Me.btn_clientes)
        Me.Controls.Add(Me.btn_personas)
        Me.Controls.Add(Me.lbl_sueldo)
        Me.Controls.Add(Me.txt_sueldo)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txt_idtipo)
        Me.Controls.Add(Me.lbl_listar)
        Me.Controls.Add(Me.lbl_titulo)
        Me.Controls.Add(Me.lbl_idpersona)
        Me.Controls.Add(Me.lbl_idempleado)
        Me.Controls.Add(Me.txt_idpersona)
        Me.Controls.Add(Me.txt_idempleado)
        Me.Controls.Add(Me.gv_Empleados)
        Me.Controls.Add(Me.btn_List)
        Me.Controls.Add(Me.btn_mod)
        Me.Controls.Add(Me.btn_elim)
        Me.Controls.Add(Me.lbl_modificar)
        Me.Controls.Add(Me.lbl_eliminar)
        Me.Controls.Add(Me.btn_agr)
        Me.Controls.Add(Me.lbl_agregar)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Empleados"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Empleados"
        CType(Me.gv_Empleados, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lbl_listar As Label
    Friend WithEvents lbl_titulo As Label
    Friend WithEvents lbl_idpersona As Label
    Friend WithEvents lbl_idempleado As Label
    Friend WithEvents txt_idpersona As TextBox
    Friend WithEvents txt_idempleado As TextBox
    Friend WithEvents gv_Empleados As DataGridView
    Friend WithEvents btn_List As Button
    Friend WithEvents btn_mod As Button
    Friend WithEvents btn_elim As Button
    Friend WithEvents lbl_modificar As Label
    Friend WithEvents lbl_eliminar As Label
    Friend WithEvents btn_agr As Button
    Friend WithEvents lbl_agregar As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txt_idtipo As TextBox
    Friend WithEvents lbl_sueldo As Label
    Friend WithEvents txt_sueldo As TextBox
    Friend WithEvents btn_tipos As Button
    Friend WithEvents btn_articulos As Button
    Friend WithEvents btn_clientes As Button
    Friend WithEvents btn_personas As Button
    Friend WithEvents btn_salir As Button
End Class
