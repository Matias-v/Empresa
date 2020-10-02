<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Tipos
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btn_agr = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.btn_elim = New System.Windows.Forms.Button()
        Me.btn_mod = New System.Windows.Forms.Button()
        Me.txt_tipo = New System.Windows.Forms.TextBox()
        Me.lbl_tipo = New System.Windows.Forms.Label()
        Me.gv_Tipos = New System.Windows.Forms.DataGridView()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.btn_listar = New System.Windows.Forms.Button()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.cbo_tabla = New System.Windows.Forms.ComboBox()
        Me.lbl_tabla = New System.Windows.Forms.Label()
        Me.lbl_ID = New System.Windows.Forms.Label()
        Me.txt_ID = New System.Windows.Forms.TextBox()
        Me.btn_clientes = New System.Windows.Forms.Button()
        Me.btn_articulos = New System.Windows.Forms.Button()
        Me.btn_empleados = New System.Windows.Forms.Button()
        Me.btn_personas = New System.Windows.Forms.Button()
        Me.btn_salir = New System.Windows.Forms.Button()
        CType(Me.gv_Tipos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(568, 300)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(44, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Agregar"
        '
        'btn_agr
        '
        Me.btn_agr.Location = New System.Drawing.Point(571, 316)
        Me.btn_agr.Name = "btn_agr"
        Me.btn_agr.Size = New System.Drawing.Size(102, 28)
        Me.btn_agr.TabIndex = 2
        Me.btn_agr.Text = "Siguiente"
        Me.btn_agr.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(705, 300)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(43, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Eliminar"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(568, 358)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(50, 13)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "Modificar"
        '
        'btn_elim
        '
        Me.btn_elim.Location = New System.Drawing.Point(708, 316)
        Me.btn_elim.Name = "btn_elim"
        Me.btn_elim.Size = New System.Drawing.Size(96, 31)
        Me.btn_elim.TabIndex = 8
        Me.btn_elim.Text = "Siguiente"
        Me.btn_elim.UseVisualStyleBackColor = True
        '
        'btn_mod
        '
        Me.btn_mod.Location = New System.Drawing.Point(571, 374)
        Me.btn_mod.Name = "btn_mod"
        Me.btn_mod.Size = New System.Drawing.Size(96, 30)
        Me.btn_mod.TabIndex = 10
        Me.btn_mod.Text = "Siguiente"
        Me.btn_mod.UseVisualStyleBackColor = True
        '
        'txt_tipo
        '
        Me.txt_tipo.Location = New System.Drawing.Point(187, 316)
        Me.txt_tipo.Name = "txt_tipo"
        Me.txt_tipo.Size = New System.Drawing.Size(93, 20)
        Me.txt_tipo.TabIndex = 16
        '
        'lbl_tipo
        '
        Me.lbl_tipo.AutoSize = True
        Me.lbl_tipo.Location = New System.Drawing.Point(186, 297)
        Me.lbl_tipo.Name = "lbl_tipo"
        Me.lbl_tipo.Size = New System.Drawing.Size(28, 13)
        Me.lbl_tipo.TabIndex = 17
        Me.lbl_tipo.Text = "Tipo"
        '
        'gv_Tipos
        '
        Me.gv_Tipos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.gv_Tipos.Location = New System.Drawing.Point(179, 48)
        Me.gv_Tipos.Name = "gv_Tipos"
        Me.gv_Tipos.Size = New System.Drawing.Size(639, 242)
        Me.gv_Tipos.TabIndex = 29
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(407, 20)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(65, 25)
        Me.Label10.TabIndex = 30
        Me.Label10.Text = "Tipos"
        '
        'btn_listar
        '
        Me.btn_listar.Location = New System.Drawing.Point(708, 374)
        Me.btn_listar.Name = "btn_listar"
        Me.btn_listar.Size = New System.Drawing.Size(96, 30)
        Me.btn_listar.TabIndex = 34
        Me.btn_listar.Text = "Siguiente"
        Me.btn_listar.UseVisualStyleBackColor = True
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(705, 358)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(35, 13)
        Me.Label9.TabIndex = 33
        Me.Label9.Text = "Listar "
        '
        'cbo_tabla
        '
        Me.cbo_tabla.FormattingEnabled = True
        Me.cbo_tabla.Items.AddRange(New Object() {"tipos_empleados", "tipos_articulo"})
        Me.cbo_tabla.Location = New System.Drawing.Point(320, 315)
        Me.cbo_tabla.Name = "cbo_tabla"
        Me.cbo_tabla.Size = New System.Drawing.Size(86, 21)
        Me.cbo_tabla.TabIndex = 37
        '
        'lbl_tabla
        '
        Me.lbl_tabla.AutoSize = True
        Me.lbl_tabla.Location = New System.Drawing.Point(320, 301)
        Me.lbl_tabla.Name = "lbl_tabla"
        Me.lbl_tabla.Size = New System.Drawing.Size(34, 13)
        Me.lbl_tabla.TabIndex = 38
        Me.lbl_tabla.Text = "Tabla"
        '
        'lbl_ID
        '
        Me.lbl_ID.AutoSize = True
        Me.lbl_ID.Location = New System.Drawing.Point(438, 297)
        Me.lbl_ID.Name = "lbl_ID"
        Me.lbl_ID.Size = New System.Drawing.Size(18, 13)
        Me.lbl_ID.TabIndex = 40
        Me.lbl_ID.Text = "ID"
        '
        'txt_ID
        '
        Me.txt_ID.Location = New System.Drawing.Point(439, 316)
        Me.txt_ID.Name = "txt_ID"
        Me.txt_ID.Size = New System.Drawing.Size(93, 20)
        Me.txt_ID.TabIndex = 39
        '
        'btn_clientes
        '
        Me.btn_clientes.Location = New System.Drawing.Point(24, 180)
        Me.btn_clientes.Name = "btn_clientes"
        Me.btn_clientes.Size = New System.Drawing.Size(129, 23)
        Me.btn_clientes.TabIndex = 77
        Me.btn_clientes.Text = "Clientes"
        Me.btn_clientes.UseVisualStyleBackColor = True
        '
        'btn_articulos
        '
        Me.btn_articulos.Location = New System.Drawing.Point(24, 226)
        Me.btn_articulos.Name = "btn_articulos"
        Me.btn_articulos.Size = New System.Drawing.Size(129, 23)
        Me.btn_articulos.TabIndex = 76
        Me.btn_articulos.Text = "Articulos"
        Me.btn_articulos.UseVisualStyleBackColor = True
        '
        'btn_empleados
        '
        Me.btn_empleados.Location = New System.Drawing.Point(24, 135)
        Me.btn_empleados.Name = "btn_empleados"
        Me.btn_empleados.Size = New System.Drawing.Size(129, 23)
        Me.btn_empleados.TabIndex = 75
        Me.btn_empleados.Text = "Empleados"
        Me.btn_empleados.UseVisualStyleBackColor = True
        '
        'btn_personas
        '
        Me.btn_personas.Location = New System.Drawing.Point(24, 91)
        Me.btn_personas.Name = "btn_personas"
        Me.btn_personas.Size = New System.Drawing.Size(129, 23)
        Me.btn_personas.TabIndex = 74
        Me.btn_personas.Text = "Personas"
        Me.btn_personas.UseVisualStyleBackColor = True
        '
        'btn_salir
        '
        Me.btn_salir.BackgroundImage = Global.TrabajoObligatorioII.My.Resources.Resources.salir
        Me.btn_salir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btn_salir.FlatAppearance.BorderSize = 0
        Me.btn_salir.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_salir.Location = New System.Drawing.Point(753, 6)
        Me.btn_salir.Name = "btn_salir"
        Me.btn_salir.Size = New System.Drawing.Size(51, 36)
        Me.btn_salir.TabIndex = 78
        Me.btn_salir.UseVisualStyleBackColor = True
        '
        'Tipos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(836, 430)
        Me.Controls.Add(Me.btn_salir)
        Me.Controls.Add(Me.btn_clientes)
        Me.Controls.Add(Me.btn_articulos)
        Me.Controls.Add(Me.btn_empleados)
        Me.Controls.Add(Me.btn_personas)
        Me.Controls.Add(Me.lbl_ID)
        Me.Controls.Add(Me.txt_ID)
        Me.Controls.Add(Me.lbl_tabla)
        Me.Controls.Add(Me.cbo_tabla)
        Me.Controls.Add(Me.btn_listar)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.gv_Tipos)
        Me.Controls.Add(Me.lbl_tipo)
        Me.Controls.Add(Me.txt_tipo)
        Me.Controls.Add(Me.btn_mod)
        Me.Controls.Add(Me.btn_elim)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.btn_agr)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Tipos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Tipos"
        CType(Me.gv_Tipos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents btn_agr As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents btn_elim As Button
    Friend WithEvents btn_mod As Button
    Friend WithEvents txt_tipo As TextBox
    Friend WithEvents lbl_tipo As Label
    Friend WithEvents gv_Tipos As DataGridView
    Friend WithEvents Label10 As Label
    Friend WithEvents btn_listar As Button
    Friend WithEvents Label9 As Label
    Friend WithEvents cbo_tabla As ComboBox
    Friend WithEvents lbl_tabla As Label
    Friend WithEvents lbl_ID As Label
    Friend WithEvents txt_ID As TextBox
    Friend WithEvents btn_clientes As Button
    Friend WithEvents btn_articulos As Button
    Friend WithEvents btn_empleados As Button
    Friend WithEvents btn_personas As Button
    Friend WithEvents btn_salir As Button
End Class
