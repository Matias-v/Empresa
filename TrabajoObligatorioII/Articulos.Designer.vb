<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Articulos
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
        Me.btn_modificar = New System.Windows.Forms.Button()
        Me.btn_eliminar = New System.Windows.Forms.Button()
        Me.lbl_modificar = New System.Windows.Forms.Label()
        Me.lbl_eliminar = New System.Windows.Forms.Label()
        Me.btn_agregar = New System.Windows.Forms.Button()
        Me.lbl_agregar = New System.Windows.Forms.Label()
        Me.btn_listar = New System.Windows.Forms.Button()
        Me.lbl_List = New System.Windows.Forms.Label()
        Me.gv_Articulos = New System.Windows.Forms.DataGridView()
        Me.txt_id = New System.Windows.Forms.TextBox()
        Me.txt_cod = New System.Windows.Forms.TextBox()
        Me.txt_precio = New System.Windows.Forms.TextBox()
        Me.txt_desc = New System.Windows.Forms.TextBox()
        Me.txt_tipo = New System.Windows.Forms.TextBox()
        Me.txt_fecha = New System.Windows.Forms.TextBox()
        Me.lbl_id = New System.Windows.Forms.Label()
        Me.lbl_cod = New System.Windows.Forms.Label()
        Me.lbl_precio = New System.Windows.Forms.Label()
        Me.lbl_desc = New System.Windows.Forms.Label()
        Me.lbl_tipo = New System.Windows.Forms.Label()
        Me.lbl_fecha = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.lbl_titulo = New System.Windows.Forms.Label()
        Me.btn_personas = New System.Windows.Forms.Button()
        Me.btn_empleados = New System.Windows.Forms.Button()
        Me.btn_clientes = New System.Windows.Forms.Button()
        Me.btn_tipos = New System.Windows.Forms.Button()
        Me.btn_salir = New System.Windows.Forms.Button()
        CType(Me.gv_Articulos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btn_modificar
        '
        Me.btn_modificar.Location = New System.Drawing.Point(779, 336)
        Me.btn_modificar.Name = "btn_modificar"
        Me.btn_modificar.Size = New System.Drawing.Size(119, 33)
        Me.btn_modificar.TabIndex = 21
        Me.btn_modificar.Text = "Siguiente"
        Me.btn_modificar.UseVisualStyleBackColor = True
        '
        'btn_eliminar
        '
        Me.btn_eliminar.Location = New System.Drawing.Point(648, 402)
        Me.btn_eliminar.Name = "btn_eliminar"
        Me.btn_eliminar.Size = New System.Drawing.Size(119, 33)
        Me.btn_eliminar.TabIndex = 20
        Me.btn_eliminar.Text = "Siguiente"
        Me.btn_eliminar.UseVisualStyleBackColor = True
        '
        'lbl_modificar
        '
        Me.lbl_modificar.AutoSize = True
        Me.lbl_modificar.Location = New System.Drawing.Point(776, 320)
        Me.lbl_modificar.Name = "lbl_modificar"
        Me.lbl_modificar.Size = New System.Drawing.Size(92, 13)
        Me.lbl_modificar.TabIndex = 19
        Me.lbl_modificar.Text = "Modificar articulos"
        '
        'lbl_eliminar
        '
        Me.lbl_eliminar.AutoSize = True
        Me.lbl_eliminar.Location = New System.Drawing.Point(645, 386)
        Me.lbl_eliminar.Name = "lbl_eliminar"
        Me.lbl_eliminar.Size = New System.Drawing.Size(85, 13)
        Me.lbl_eliminar.TabIndex = 18
        Me.lbl_eliminar.Text = "Eliminar articulos"
        '
        'btn_agregar
        '
        Me.btn_agregar.Location = New System.Drawing.Point(648, 336)
        Me.btn_agregar.Name = "btn_agregar"
        Me.btn_agregar.Size = New System.Drawing.Size(125, 33)
        Me.btn_agregar.TabIndex = 17
        Me.btn_agregar.Text = "Siguiente"
        Me.btn_agregar.UseVisualStyleBackColor = True
        '
        'lbl_agregar
        '
        Me.lbl_agregar.AutoSize = True
        Me.lbl_agregar.Location = New System.Drawing.Point(645, 320)
        Me.lbl_agregar.Name = "lbl_agregar"
        Me.lbl_agregar.Size = New System.Drawing.Size(86, 13)
        Me.lbl_agregar.TabIndex = 16
        Me.lbl_agregar.Text = "Agregar articulos"
        '
        'btn_listar
        '
        Me.btn_listar.Location = New System.Drawing.Point(779, 402)
        Me.btn_listar.Name = "btn_listar"
        Me.btn_listar.Size = New System.Drawing.Size(119, 33)
        Me.btn_listar.TabIndex = 27
        Me.btn_listar.Text = "Siguiente"
        Me.btn_listar.UseVisualStyleBackColor = True
        '
        'lbl_List
        '
        Me.lbl_List.AutoSize = True
        Me.lbl_List.Location = New System.Drawing.Point(776, 386)
        Me.lbl_List.Name = "lbl_List"
        Me.lbl_List.Size = New System.Drawing.Size(74, 13)
        Me.lbl_List.TabIndex = 26
        Me.lbl_List.Text = "Listar articulos"
        '
        'gv_Articulos
        '
        Me.gv_Articulos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.gv_Articulos.Location = New System.Drawing.Point(177, 61)
        Me.gv_Articulos.Name = "gv_Articulos"
        Me.gv_Articulos.Size = New System.Drawing.Size(726, 242)
        Me.gv_Articulos.TabIndex = 28
        '
        'txt_id
        '
        Me.txt_id.Location = New System.Drawing.Point(136, 343)
        Me.txt_id.Name = "txt_id"
        Me.txt_id.Size = New System.Drawing.Size(122, 20)
        Me.txt_id.TabIndex = 29
        '
        'txt_cod
        '
        Me.txt_cod.Location = New System.Drawing.Point(137, 409)
        Me.txt_cod.Name = "txt_cod"
        Me.txt_cod.Size = New System.Drawing.Size(122, 20)
        Me.txt_cod.TabIndex = 30
        '
        'txt_precio
        '
        Me.txt_precio.Location = New System.Drawing.Point(301, 343)
        Me.txt_precio.Name = "txt_precio"
        Me.txt_precio.Size = New System.Drawing.Size(122, 20)
        Me.txt_precio.TabIndex = 31
        '
        'txt_desc
        '
        Me.txt_desc.Location = New System.Drawing.Point(301, 409)
        Me.txt_desc.Name = "txt_desc"
        Me.txt_desc.Size = New System.Drawing.Size(122, 20)
        Me.txt_desc.TabIndex = 32
        '
        'txt_tipo
        '
        Me.txt_tipo.Location = New System.Drawing.Point(462, 343)
        Me.txt_tipo.Name = "txt_tipo"
        Me.txt_tipo.Size = New System.Drawing.Size(122, 20)
        Me.txt_tipo.TabIndex = 33
        '
        'txt_fecha
        '
        Me.txt_fecha.Location = New System.Drawing.Point(462, 409)
        Me.txt_fecha.Name = "txt_fecha"
        Me.txt_fecha.Size = New System.Drawing.Size(122, 20)
        Me.txt_fecha.TabIndex = 34
        '
        'lbl_id
        '
        Me.lbl_id.AutoSize = True
        Me.lbl_id.Location = New System.Drawing.Point(138, 327)
        Me.lbl_id.Name = "lbl_id"
        Me.lbl_id.Size = New System.Drawing.Size(55, 13)
        Me.lbl_id.TabIndex = 36
        Me.lbl_id.Text = "ID articulo"
        '
        'lbl_cod
        '
        Me.lbl_cod.AutoSize = True
        Me.lbl_cod.Location = New System.Drawing.Point(138, 393)
        Me.lbl_cod.Name = "lbl_cod"
        Me.lbl_cod.Size = New System.Drawing.Size(40, 13)
        Me.lbl_cod.TabIndex = 37
        Me.lbl_cod.Text = "Codigo"
        '
        'lbl_precio
        '
        Me.lbl_precio.AutoSize = True
        Me.lbl_precio.Location = New System.Drawing.Point(298, 327)
        Me.lbl_precio.Name = "lbl_precio"
        Me.lbl_precio.Size = New System.Drawing.Size(37, 13)
        Me.lbl_precio.TabIndex = 38
        Me.lbl_precio.Text = "Precio"
        '
        'lbl_desc
        '
        Me.lbl_desc.AutoSize = True
        Me.lbl_desc.Location = New System.Drawing.Point(298, 393)
        Me.lbl_desc.Name = "lbl_desc"
        Me.lbl_desc.Size = New System.Drawing.Size(63, 13)
        Me.lbl_desc.TabIndex = 39
        Me.lbl_desc.Text = "Descripcion"
        '
        'lbl_tipo
        '
        Me.lbl_tipo.AutoSize = True
        Me.lbl_tipo.Location = New System.Drawing.Point(459, 327)
        Me.lbl_tipo.Name = "lbl_tipo"
        Me.lbl_tipo.Size = New System.Drawing.Size(80, 13)
        Me.lbl_tipo.TabIndex = 40
        Me.lbl_tipo.Text = "Tipo de articulo"
        '
        'lbl_fecha
        '
        Me.lbl_fecha.AutoSize = True
        Me.lbl_fecha.Location = New System.Drawing.Point(459, 393)
        Me.lbl_fecha.Name = "lbl_fecha"
        Me.lbl_fecha.Size = New System.Drawing.Size(107, 13)
        Me.lbl_fecha.TabIndex = 41
        Me.lbl_fecha.Text = "Fecha de fabricacion"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(705, 290)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(0, 13)
        Me.Label12.TabIndex = 42
        '
        'lbl_titulo
        '
        Me.lbl_titulo.AutoSize = True
        Me.lbl_titulo.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_titulo.Location = New System.Drawing.Point(457, 29)
        Me.lbl_titulo.Name = "lbl_titulo"
        Me.lbl_titulo.Size = New System.Drawing.Size(105, 29)
        Me.lbl_titulo.TabIndex = 43
        Me.lbl_titulo.Text = "Articulos"
        '
        'btn_personas
        '
        Me.btn_personas.Location = New System.Drawing.Point(12, 106)
        Me.btn_personas.Name = "btn_personas"
        Me.btn_personas.Size = New System.Drawing.Size(137, 23)
        Me.btn_personas.TabIndex = 44
        Me.btn_personas.Text = "Personas"
        Me.btn_personas.UseVisualStyleBackColor = True
        '
        'btn_empleados
        '
        Me.btn_empleados.Location = New System.Drawing.Point(12, 150)
        Me.btn_empleados.Name = "btn_empleados"
        Me.btn_empleados.Size = New System.Drawing.Size(137, 23)
        Me.btn_empleados.TabIndex = 45
        Me.btn_empleados.Text = "Empleados"
        Me.btn_empleados.UseVisualStyleBackColor = True
        '
        'btn_clientes
        '
        Me.btn_clientes.Location = New System.Drawing.Point(12, 197)
        Me.btn_clientes.Name = "btn_clientes"
        Me.btn_clientes.Size = New System.Drawing.Size(137, 23)
        Me.btn_clientes.TabIndex = 46
        Me.btn_clientes.Text = "Clientes"
        Me.btn_clientes.UseVisualStyleBackColor = True
        '
        'btn_tipos
        '
        Me.btn_tipos.Location = New System.Drawing.Point(12, 245)
        Me.btn_tipos.Name = "btn_tipos"
        Me.btn_tipos.Size = New System.Drawing.Size(137, 23)
        Me.btn_tipos.TabIndex = 47
        Me.btn_tipos.Text = "Tipos"
        Me.btn_tipos.UseVisualStyleBackColor = True
        '
        'btn_salir
        '
        Me.btn_salir.BackgroundImage = Global.TrabajoObligatorioII.My.Resources.Resources.salir
        Me.btn_salir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btn_salir.FlatAppearance.BorderSize = 0
        Me.btn_salir.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_salir.Location = New System.Drawing.Point(852, 12)
        Me.btn_salir.Name = "btn_salir"
        Me.btn_salir.Size = New System.Drawing.Size(51, 36)
        Me.btn_salir.TabIndex = 23
        Me.btn_salir.UseVisualStyleBackColor = True
        '
        'Articulos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(926, 482)
        Me.Controls.Add(Me.btn_tipos)
        Me.Controls.Add(Me.btn_clientes)
        Me.Controls.Add(Me.btn_empleados)
        Me.Controls.Add(Me.btn_personas)
        Me.Controls.Add(Me.lbl_titulo)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.lbl_fecha)
        Me.Controls.Add(Me.lbl_tipo)
        Me.Controls.Add(Me.lbl_desc)
        Me.Controls.Add(Me.lbl_precio)
        Me.Controls.Add(Me.lbl_cod)
        Me.Controls.Add(Me.lbl_id)
        Me.Controls.Add(Me.txt_fecha)
        Me.Controls.Add(Me.txt_tipo)
        Me.Controls.Add(Me.txt_desc)
        Me.Controls.Add(Me.txt_precio)
        Me.Controls.Add(Me.txt_cod)
        Me.Controls.Add(Me.txt_id)
        Me.Controls.Add(Me.gv_Articulos)
        Me.Controls.Add(Me.btn_listar)
        Me.Controls.Add(Me.lbl_List)
        Me.Controls.Add(Me.btn_salir)
        Me.Controls.Add(Me.btn_modificar)
        Me.Controls.Add(Me.btn_eliminar)
        Me.Controls.Add(Me.lbl_modificar)
        Me.Controls.Add(Me.lbl_eliminar)
        Me.Controls.Add(Me.btn_agregar)
        Me.Controls.Add(Me.lbl_agregar)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Articulos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        CType(Me.gv_Articulos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btn_salir As Button
    Friend WithEvents btn_modificar As Button
    Friend WithEvents btn_eliminar As Button
    Friend WithEvents lbl_modificar As Label
    Friend WithEvents lbl_eliminar As Label
    Friend WithEvents btn_agregar As Button
    Friend WithEvents lbl_agregar As Label
    Friend WithEvents btn_listar As Button
    Friend WithEvents lbl_List As Label
    Friend WithEvents gv_Articulos As DataGridView
    Friend WithEvents txt_id As TextBox
    Friend WithEvents txt_cod As TextBox
    Friend WithEvents txt_precio As TextBox
    Friend WithEvents txt_desc As TextBox
    Friend WithEvents txt_tipo As TextBox
    Friend WithEvents txt_fecha As TextBox
    Friend WithEvents lbl_id As Label
    Friend WithEvents lbl_cod As Label
    Friend WithEvents lbl_precio As Label
    Friend WithEvents lbl_desc As Label
    Friend WithEvents lbl_tipo As Label
    Friend WithEvents lbl_fecha As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents lbl_titulo As Label
    Friend WithEvents btn_personas As Button
    Friend WithEvents btn_empleados As Button
    Friend WithEvents btn_clientes As Button
    Friend WithEvents btn_tipos As Button
End Class
