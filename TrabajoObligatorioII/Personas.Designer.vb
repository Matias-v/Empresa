<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Personas
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.lbl_pApe = New System.Windows.Forms.Label()
        Me.txt_pApe = New System.Windows.Forms.TextBox()
        Me.lbl_pNom = New System.Windows.Forms.Label()
        Me.txt_pNom = New System.Windows.Forms.TextBox()
        Me.lbl_listar = New System.Windows.Forms.Label()
        Me.lbl_titulo = New System.Windows.Forms.Label()
        Me.lbl_cedula = New System.Windows.Forms.Label()
        Me.lbl_idPersona = New System.Windows.Forms.Label()
        Me.txt_cedula = New System.Windows.Forms.TextBox()
        Me.txt_idPersona = New System.Windows.Forms.TextBox()
        Me.gv_Personas = New System.Windows.Forms.DataGridView()
        Me.btn_List = New System.Windows.Forms.Button()
        Me.btn_mod = New System.Windows.Forms.Button()
        Me.btn_elim = New System.Windows.Forms.Button()
        Me.lbl_modificar = New System.Windows.Forms.Label()
        Me.lbl_eliminar = New System.Windows.Forms.Label()
        Me.btn_agr = New System.Windows.Forms.Button()
        Me.lbl_agregar = New System.Windows.Forms.Label()
        Me.lbl_sApe = New System.Windows.Forms.Label()
        Me.txt_sApe = New System.Windows.Forms.TextBox()
        Me.lbl_sNom = New System.Windows.Forms.Label()
        Me.txt_sNom = New System.Windows.Forms.TextBox()
        Me.lbl_telf = New System.Windows.Forms.Label()
        Me.txt_telf = New System.Windows.Forms.TextBox()
        Me.lbl_dir = New System.Windows.Forms.Label()
        Me.txt_dir = New System.Windows.Forms.TextBox()
        Me.btn_tipos = New System.Windows.Forms.Button()
        Me.btn_articulos = New System.Windows.Forms.Button()
        Me.btn_clientes = New System.Windows.Forms.Button()
        Me.btn_empleados = New System.Windows.Forms.Button()
        Me.btn_salir = New System.Windows.Forms.Button()
        CType(Me.gv_Personas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lbl_pApe
        '
        Me.lbl_pApe.AutoSize = True
        Me.lbl_pApe.Location = New System.Drawing.Point(332, 392)
        Me.lbl_pApe.Name = "lbl_pApe"
        Me.lbl_pApe.Size = New System.Drawing.Size(75, 13)
        Me.lbl_pApe.TabIndex = 113
        Me.lbl_pApe.Text = "Primer apellido"
        '
        'txt_pApe
        '
        Me.txt_pApe.Location = New System.Drawing.Point(335, 408)
        Me.txt_pApe.Name = "txt_pApe"
        Me.txt_pApe.Size = New System.Drawing.Size(122, 20)
        Me.txt_pApe.TabIndex = 112
        '
        'lbl_pNom
        '
        Me.lbl_pNom.AutoSize = True
        Me.lbl_pNom.Location = New System.Drawing.Point(167, 392)
        Me.lbl_pNom.Name = "lbl_pNom"
        Me.lbl_pNom.Size = New System.Drawing.Size(74, 13)
        Me.lbl_pNom.TabIndex = 111
        Me.lbl_pNom.Text = "Primer nombre"
        '
        'txt_pNom
        '
        Me.txt_pNom.Location = New System.Drawing.Point(170, 408)
        Me.txt_pNom.Name = "txt_pNom"
        Me.txt_pNom.Size = New System.Drawing.Size(122, 20)
        Me.txt_pNom.TabIndex = 110
        '
        'lbl_listar
        '
        Me.lbl_listar.AutoSize = True
        Me.lbl_listar.Location = New System.Drawing.Point(776, 392)
        Me.lbl_listar.Name = "lbl_listar"
        Me.lbl_listar.Size = New System.Drawing.Size(118, 13)
        Me.lbl_listar.TabIndex = 109
        Me.lbl_listar.Text = "Listar todas las persona"
        '
        'lbl_titulo
        '
        Me.lbl_titulo.AutoSize = True
        Me.lbl_titulo.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_titulo.Location = New System.Drawing.Point(435, 34)
        Me.lbl_titulo.Name = "lbl_titulo"
        Me.lbl_titulo.Size = New System.Drawing.Size(115, 29)
        Me.lbl_titulo.TabIndex = 108
        Me.lbl_titulo.Text = "Personas"
        '
        'lbl_cedula
        '
        Me.lbl_cedula.AutoSize = True
        Me.lbl_cedula.Location = New System.Drawing.Point(332, 333)
        Me.lbl_cedula.Name = "lbl_cedula"
        Me.lbl_cedula.Size = New System.Drawing.Size(40, 13)
        Me.lbl_cedula.TabIndex = 107
        Me.lbl_cedula.Text = "Cedula"
        '
        'lbl_idPersona
        '
        Me.lbl_idPersona.AutoSize = True
        Me.lbl_idPersona.Location = New System.Drawing.Point(172, 333)
        Me.lbl_idPersona.Name = "lbl_idPersona"
        Me.lbl_idPersona.Size = New System.Drawing.Size(59, 13)
        Me.lbl_idPersona.TabIndex = 106
        Me.lbl_idPersona.Text = "ID persona"
        '
        'txt_cedula
        '
        Me.txt_cedula.Location = New System.Drawing.Point(335, 349)
        Me.txt_cedula.Name = "txt_cedula"
        Me.txt_cedula.Size = New System.Drawing.Size(122, 20)
        Me.txt_cedula.TabIndex = 105
        '
        'txt_idPersona
        '
        Me.txt_idPersona.Location = New System.Drawing.Point(170, 349)
        Me.txt_idPersona.Name = "txt_idPersona"
        Me.txt_idPersona.Size = New System.Drawing.Size(122, 20)
        Me.txt_idPersona.TabIndex = 104
        '
        'gv_Personas
        '
        Me.gv_Personas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.gv_Personas.Location = New System.Drawing.Point(168, 66)
        Me.gv_Personas.Name = "gv_Personas"
        Me.gv_Personas.Size = New System.Drawing.Size(726, 242)
        Me.gv_Personas.TabIndex = 103
        '
        'btn_List
        '
        Me.btn_List.Location = New System.Drawing.Point(775, 408)
        Me.btn_List.Name = "btn_List"
        Me.btn_List.Size = New System.Drawing.Size(119, 33)
        Me.btn_List.TabIndex = 102
        Me.btn_List.Text = "Siguiente"
        Me.btn_List.UseVisualStyleBackColor = True
        '
        'btn_mod
        '
        Me.btn_mod.Location = New System.Drawing.Point(775, 342)
        Me.btn_mod.Name = "btn_mod"
        Me.btn_mod.Size = New System.Drawing.Size(119, 33)
        Me.btn_mod.TabIndex = 97
        Me.btn_mod.Text = "Siguiente"
        Me.btn_mod.UseVisualStyleBackColor = True
        '
        'btn_elim
        '
        Me.btn_elim.Location = New System.Drawing.Point(644, 408)
        Me.btn_elim.Name = "btn_elim"
        Me.btn_elim.Size = New System.Drawing.Size(119, 33)
        Me.btn_elim.TabIndex = 96
        Me.btn_elim.Text = "Siguiente"
        Me.btn_elim.UseVisualStyleBackColor = True
        '
        'lbl_modificar
        '
        Me.lbl_modificar.AutoSize = True
        Me.lbl_modificar.Location = New System.Drawing.Point(772, 326)
        Me.lbl_modificar.Name = "lbl_modificar"
        Me.lbl_modificar.Size = New System.Drawing.Size(91, 13)
        Me.lbl_modificar.TabIndex = 95
        Me.lbl_modificar.Text = "Modificar persona"
        '
        'lbl_eliminar
        '
        Me.lbl_eliminar.AutoSize = True
        Me.lbl_eliminar.Location = New System.Drawing.Point(641, 392)
        Me.lbl_eliminar.Name = "lbl_eliminar"
        Me.lbl_eliminar.Size = New System.Drawing.Size(84, 13)
        Me.lbl_eliminar.TabIndex = 94
        Me.lbl_eliminar.Text = "Eliminar persona"
        '
        'btn_agr
        '
        Me.btn_agr.Location = New System.Drawing.Point(644, 342)
        Me.btn_agr.Name = "btn_agr"
        Me.btn_agr.Size = New System.Drawing.Size(125, 33)
        Me.btn_agr.TabIndex = 93
        Me.btn_agr.Text = "Siguiente"
        Me.btn_agr.UseVisualStyleBackColor = True
        '
        'lbl_agregar
        '
        Me.lbl_agregar.AutoSize = True
        Me.lbl_agregar.Location = New System.Drawing.Point(641, 326)
        Me.lbl_agregar.Name = "lbl_agregar"
        Me.lbl_agregar.Size = New System.Drawing.Size(85, 13)
        Me.lbl_agregar.TabIndex = 92
        Me.lbl_agregar.Text = "Agregar persona"
        '
        'lbl_sApe
        '
        Me.lbl_sApe.AutoSize = True
        Me.lbl_sApe.Location = New System.Drawing.Point(493, 392)
        Me.lbl_sApe.Name = "lbl_sApe"
        Me.lbl_sApe.Size = New System.Drawing.Size(89, 13)
        Me.lbl_sApe.TabIndex = 117
        Me.lbl_sApe.Text = "Segundo apellido"
        '
        'txt_sApe
        '
        Me.txt_sApe.Location = New System.Drawing.Point(496, 408)
        Me.txt_sApe.Name = "txt_sApe"
        Me.txt_sApe.Size = New System.Drawing.Size(122, 20)
        Me.txt_sApe.TabIndex = 116
        '
        'lbl_sNom
        '
        Me.lbl_sNom.AutoSize = True
        Me.lbl_sNom.Location = New System.Drawing.Point(493, 333)
        Me.lbl_sNom.Name = "lbl_sNom"
        Me.lbl_sNom.Size = New System.Drawing.Size(88, 13)
        Me.lbl_sNom.TabIndex = 115
        Me.lbl_sNom.Text = "Segundo nombre"
        '
        'txt_sNom
        '
        Me.txt_sNom.Location = New System.Drawing.Point(496, 349)
        Me.txt_sNom.Name = "txt_sNom"
        Me.txt_sNom.Size = New System.Drawing.Size(122, 20)
        Me.txt_sNom.TabIndex = 114
        '
        'lbl_telf
        '
        Me.lbl_telf.AutoSize = True
        Me.lbl_telf.Location = New System.Drawing.Point(332, 443)
        Me.lbl_telf.Name = "lbl_telf"
        Me.lbl_telf.Size = New System.Drawing.Size(49, 13)
        Me.lbl_telf.TabIndex = 121
        Me.lbl_telf.Text = "Telefono"
        '
        'txt_telf
        '
        Me.txt_telf.Location = New System.Drawing.Point(335, 459)
        Me.txt_telf.Name = "txt_telf"
        Me.txt_telf.Size = New System.Drawing.Size(122, 20)
        Me.txt_telf.TabIndex = 120
        '
        'lbl_dir
        '
        Me.lbl_dir.AutoSize = True
        Me.lbl_dir.Location = New System.Drawing.Point(167, 443)
        Me.lbl_dir.Name = "lbl_dir"
        Me.lbl_dir.Size = New System.Drawing.Size(52, 13)
        Me.lbl_dir.TabIndex = 119
        Me.lbl_dir.Text = "Direccion"
        '
        'txt_dir
        '
        Me.txt_dir.Location = New System.Drawing.Point(170, 459)
        Me.txt_dir.Name = "txt_dir"
        Me.txt_dir.Size = New System.Drawing.Size(122, 20)
        Me.txt_dir.TabIndex = 118
        '
        'btn_tipos
        '
        Me.btn_tipos.Location = New System.Drawing.Point(24, 249)
        Me.btn_tipos.Name = "btn_tipos"
        Me.btn_tipos.Size = New System.Drawing.Size(119, 23)
        Me.btn_tipos.TabIndex = 126
        Me.btn_tipos.Text = "Tipos"
        Me.btn_tipos.UseVisualStyleBackColor = True
        '
        'btn_articulos
        '
        Me.btn_articulos.Location = New System.Drawing.Point(24, 201)
        Me.btn_articulos.Name = "btn_articulos"
        Me.btn_articulos.Size = New System.Drawing.Size(119, 23)
        Me.btn_articulos.TabIndex = 125
        Me.btn_articulos.Text = "Articulos"
        Me.btn_articulos.UseVisualStyleBackColor = True
        '
        'btn_clientes
        '
        Me.btn_clientes.Location = New System.Drawing.Point(24, 154)
        Me.btn_clientes.Name = "btn_clientes"
        Me.btn_clientes.Size = New System.Drawing.Size(119, 23)
        Me.btn_clientes.TabIndex = 124
        Me.btn_clientes.Text = "Clientes"
        Me.btn_clientes.UseVisualStyleBackColor = True
        '
        'btn_empleados
        '
        Me.btn_empleados.Location = New System.Drawing.Point(24, 110)
        Me.btn_empleados.Name = "btn_empleados"
        Me.btn_empleados.Size = New System.Drawing.Size(119, 23)
        Me.btn_empleados.TabIndex = 123
        Me.btn_empleados.Text = "Empleados"
        Me.btn_empleados.UseVisualStyleBackColor = True
        '
        'btn_salir
        '
        Me.btn_salir.BackgroundImage = Global.TrabajoObligatorioII.My.Resources.Resources.salir
        Me.btn_salir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btn_salir.FlatAppearance.BorderSize = 0
        Me.btn_salir.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_salir.Location = New System.Drawing.Point(845, 12)
        Me.btn_salir.Name = "btn_salir"
        Me.btn_salir.Size = New System.Drawing.Size(51, 36)
        Me.btn_salir.TabIndex = 127
        Me.btn_salir.UseVisualStyleBackColor = True
        '
        'Personas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(915, 504)
        Me.Controls.Add(Me.btn_salir)
        Me.Controls.Add(Me.btn_tipos)
        Me.Controls.Add(Me.btn_articulos)
        Me.Controls.Add(Me.btn_clientes)
        Me.Controls.Add(Me.btn_empleados)
        Me.Controls.Add(Me.lbl_telf)
        Me.Controls.Add(Me.txt_telf)
        Me.Controls.Add(Me.lbl_dir)
        Me.Controls.Add(Me.txt_dir)
        Me.Controls.Add(Me.lbl_sApe)
        Me.Controls.Add(Me.txt_sApe)
        Me.Controls.Add(Me.lbl_sNom)
        Me.Controls.Add(Me.txt_sNom)
        Me.Controls.Add(Me.lbl_pApe)
        Me.Controls.Add(Me.txt_pApe)
        Me.Controls.Add(Me.lbl_pNom)
        Me.Controls.Add(Me.txt_pNom)
        Me.Controls.Add(Me.lbl_listar)
        Me.Controls.Add(Me.lbl_titulo)
        Me.Controls.Add(Me.lbl_cedula)
        Me.Controls.Add(Me.lbl_idPersona)
        Me.Controls.Add(Me.txt_cedula)
        Me.Controls.Add(Me.txt_idPersona)
        Me.Controls.Add(Me.gv_Personas)
        Me.Controls.Add(Me.btn_List)
        Me.Controls.Add(Me.btn_mod)
        Me.Controls.Add(Me.btn_elim)
        Me.Controls.Add(Me.lbl_modificar)
        Me.Controls.Add(Me.lbl_eliminar)
        Me.Controls.Add(Me.btn_agr)
        Me.Controls.Add(Me.lbl_agregar)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Personas"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Personas"
        CType(Me.gv_Personas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lbl_pApe As Label
    Friend WithEvents txt_pApe As TextBox
    Friend WithEvents lbl_pNom As Label
    Friend WithEvents txt_pNom As TextBox
    Friend WithEvents lbl_listar As Label
    Friend WithEvents lbl_titulo As Label
    Friend WithEvents lbl_cedula As Label
    Friend WithEvents lbl_idPersona As Label
    Friend WithEvents txt_cedula As TextBox
    Friend WithEvents txt_idPersona As TextBox
    Friend WithEvents gv_Personas As DataGridView
    Friend WithEvents btn_List As Button
    Friend WithEvents btn_mod As Button
    Friend WithEvents btn_elim As Button
    Friend WithEvents lbl_modificar As Label
    Friend WithEvents lbl_eliminar As Label
    Friend WithEvents btn_agr As Button
    Friend WithEvents lbl_agregar As Label
    Friend WithEvents lbl_sApe As Label
    Friend WithEvents txt_sApe As TextBox
    Friend WithEvents lbl_sNom As Label
    Friend WithEvents txt_sNom As TextBox
    Friend WithEvents lbl_telf As Label
    Friend WithEvents txt_telf As TextBox
    Friend WithEvents lbl_dir As Label
    Friend WithEvents txt_dir As TextBox
    Friend WithEvents btn_tipos As Button
    Friend WithEvents btn_articulos As Button
    Friend WithEvents btn_clientes As Button
    Friend WithEvents btn_empleados As Button
    Friend WithEvents btn_salir As Button
End Class
