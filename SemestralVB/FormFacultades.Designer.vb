<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormFacultades
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
        MenuStrip = New MenuStrip()
        PresentacionToolStripMenuItem = New ToolStripMenuItem()
        Mantenimiento = New ToolStripMenuItem()
        EstudianteToolStripMenuItem = New ToolStripMenuItem()
        ProfesorToolStripMenuItem = New ToolStripMenuItem()
        FacultadToolStripMenuItem = New ToolStripMenuItem()
        SalirToolStripMenuItem = New ToolStripMenuItem()
        dgvFacultades = New DataGridView()
        dgvEstudianteDatos = New DataGridView()
        MenuStrip.SuspendLayout()
        CType(dgvFacultades, ComponentModel.ISupportInitialize).BeginInit()
        CType(dgvEstudianteDatos, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' MenuStrip
        ' 
        MenuStrip.Items.AddRange(New ToolStripItem() {PresentacionToolStripMenuItem, Mantenimiento, FacultadToolStripMenuItem, SalirToolStripMenuItem})
        MenuStrip.Location = New Point(0, 0)
        MenuStrip.Name = "MenuStrip"
        MenuStrip.Size = New Size(800, 24)
        MenuStrip.TabIndex = 3
        MenuStrip.Text = "MenuStrip1"
        ' 
        ' PresentacionToolStripMenuItem
        ' 
        PresentacionToolStripMenuItem.Name = "PresentacionToolStripMenuItem"
        PresentacionToolStripMenuItem.Size = New Size(87, 20)
        PresentacionToolStripMenuItem.Text = "Presentacion"
        ' 
        ' Mantenimiento
        ' 
        Mantenimiento.DropDownItems.AddRange(New ToolStripItem() {EstudianteToolStripMenuItem, ProfesorToolStripMenuItem})
        Mantenimiento.Name = "Mantenimiento"
        Mantenimiento.Size = New Size(101, 20)
        Mantenimiento.Text = "Mantenimiento"
        ' 
        ' EstudianteToolStripMenuItem
        ' 
        EstudianteToolStripMenuItem.Name = "EstudianteToolStripMenuItem"
        EstudianteToolStripMenuItem.Size = New Size(129, 22)
        EstudianteToolStripMenuItem.Text = "Estudiante"
        ' 
        ' ProfesorToolStripMenuItem
        ' 
        ProfesorToolStripMenuItem.Name = "ProfesorToolStripMenuItem"
        ProfesorToolStripMenuItem.Size = New Size(129, 22)
        ProfesorToolStripMenuItem.Text = "Profesor"
        ' 
        ' FacultadToolStripMenuItem
        ' 
        FacultadToolStripMenuItem.Name = "FacultadToolStripMenuItem"
        FacultadToolStripMenuItem.Size = New Size(73, 20)
        FacultadToolStripMenuItem.Text = "facultades"
        ' 
        ' SalirToolStripMenuItem
        ' 
        SalirToolStripMenuItem.Name = "SalirToolStripMenuItem"
        SalirToolStripMenuItem.Size = New Size(41, 20)
        SalirToolStripMenuItem.Text = "Salir"
        ' 
        ' dgvFacultades
        ' 
        dgvFacultades.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvFacultades.Location = New Point(12, 52)
        dgvFacultades.Name = "dgvFacultades"
        dgvFacultades.RowTemplate.Height = 25
        dgvFacultades.Size = New Size(776, 150)
        dgvFacultades.TabIndex = 4
        ' 
        ' dgvEstudianteDatos
        ' 
        dgvEstudianteDatos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvEstudianteDatos.Location = New Point(12, 274)
        dgvEstudianteDatos.Name = "dgvEstudianteDatos"
        dgvEstudianteDatos.RowTemplate.Height = 25
        dgvEstudianteDatos.Size = New Size(776, 150)
        dgvEstudianteDatos.TabIndex = 5
        ' 
        ' FormFacultades
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(dgvEstudianteDatos)
        Controls.Add(dgvFacultades)
        Controls.Add(MenuStrip)
        Name = "FormFacultades"
        Text = "FormFacultades"
        MenuStrip.ResumeLayout(False)
        MenuStrip.PerformLayout()
        CType(dgvFacultades, ComponentModel.ISupportInitialize).EndInit()
        CType(dgvEstudianteDatos, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents MenuStrip As MenuStrip
    Friend WithEvents PresentacionToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Mantenimiento As ToolStripMenuItem
    Friend WithEvents EstudianteToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ProfesorToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents FacultadToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SalirToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents dgvFacultades As DataGridView
    Friend WithEvents dgvEstudianteDatos As DataGridView
End Class
