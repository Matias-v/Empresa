<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Diseño
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
        Me.MenuTop = New System.Windows.Forms.Panel()
        Me.lblDashboard = New System.Windows.Forms.Label()
        Me.SidebarWrapper = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.MenuSidebar = New System.Windows.Forms.PictureBox()
        Me.MenuTop.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MenuSidebar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MenuTop
        '
        Me.MenuTop.BackColor = System.Drawing.Color.DarkGray
        Me.MenuTop.Controls.Add(Me.PictureBox1)
        Me.MenuTop.Controls.Add(Me.lblDashboard)
        Me.MenuTop.Controls.Add(Me.MenuSidebar)
        Me.MenuTop.Dock = System.Windows.Forms.DockStyle.Top
        Me.MenuTop.Location = New System.Drawing.Point(0, 0)
        Me.MenuTop.Name = "MenuTop"
        Me.MenuTop.Size = New System.Drawing.Size(950, 100)
        Me.MenuTop.TabIndex = 0
        '
        'lblDashboard
        '
        Me.lblDashboard.AutoSize = True
        Me.lblDashboard.Font = New System.Drawing.Font("Nirmala UI", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDashboard.ForeColor = System.Drawing.Color.White
        Me.lblDashboard.Location = New System.Drawing.Point(69, 47)
        Me.lblDashboard.Name = "lblDashboard"
        Me.lblDashboard.Size = New System.Drawing.Size(110, 23)
        Me.lblDashboard.TabIndex = 1
        Me.lblDashboard.Text = "DASHBOARD"
        '
        'SidebarWrapper
        '
        Me.SidebarWrapper.Dock = System.Windows.Forms.DockStyle.Left
        Me.SidebarWrapper.Location = New System.Drawing.Point(0, 100)
        Me.SidebarWrapper.Name = "SidebarWrapper"
        Me.SidebarWrapper.Size = New System.Drawing.Size(186, 550)
        Me.SidebarWrapper.TabIndex = 1
        '
        'PictureBox1
        '
        Me.PictureBox1.Location = New System.Drawing.Point(882, 40)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(30, 30)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 2
        Me.PictureBox1.TabStop = False
        '
        'MenuSidebar
        '
        Me.MenuSidebar.Location = New System.Drawing.Point(33, 40)
        Me.MenuSidebar.Name = "MenuSidebar"
        Me.MenuSidebar.Size = New System.Drawing.Size(30, 30)
        Me.MenuSidebar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.MenuSidebar.TabIndex = 0
        Me.MenuSidebar.TabStop = False
        '
        'Diseño
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(950, 650)
        Me.Controls.Add(Me.SidebarWrapper)
        Me.Controls.Add(Me.MenuTop)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Diseño"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Diseño"
        Me.MenuTop.ResumeLayout(False)
        Me.MenuTop.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MenuSidebar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents MenuTop As Windows.Forms.Panel
    Friend WithEvents SidebarWrapper As Windows.Forms.Panel
    Friend WithEvents MenuSidebar As Windows.Forms.PictureBox
    Friend WithEvents lblDashboard As Windows.Forms.Label
    Friend WithEvents PictureBox1 As Windows.Forms.PictureBox
End Class
