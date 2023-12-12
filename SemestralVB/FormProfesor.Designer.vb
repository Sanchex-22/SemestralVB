<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormProfesor
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
        SalirToolStripMenuItem = New ToolStripMenuItem()
        Label1 = New Label()
        btnBuscar = New Button()
        dgvProfesores = New DataGridView()
        btnAgregar = New Button()
        btnEliminarProfesor = New Button()
        lbligo = New Label()
        txtCodigo = New TextBox()
        txtCedulaProfesor = New TextBox()
        txtNombreProfesor = New TextBox()
        Label2 = New Label()
        Label3 = New Label()
        txtApellidoProfesor = New TextBox()
        Apellido = New Label()
        txtDireccionProfesor = New TextBox()
        txtCelularProfesor = New TextBox()
        txtCorreoProfesor = New TextBox()
        txtCodProvincia = New TextBox()
        Label4 = New Label()
        celular = New Label()
        Label5 = New Label()
        Provincia = New Label()
        txtCodDistrito = New TextBox()
        Distrito = New Label()
        txtSalarioBase = New TextBox()
        salario = New Label()
        cmbEstatusProfesor = New TextBox()
        estatus = New Label()
        txtIdProfesor = New TextBox()
        btnEditarProfesor = New Button()
        Label6 = New Label()
        btnLimpiarProfesor = New Button()
        FacultadesToolStripMenuItem = New ToolStripMenuItem()
        MenuStrip.SuspendLayout()
        CType(dgvProfesores, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' MenuStrip
        ' 
        MenuStrip.Items.AddRange(New ToolStripItem() {PresentacionToolStripMenuItem, Mantenimiento, SalirToolStripMenuItem, FacultadesToolStripMenuItem})
        MenuStrip.Location = New Point(0, 0)
        MenuStrip.Name = "MenuStrip"
        MenuStrip.Size = New Size(800, 24)
        MenuStrip.TabIndex = 2
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
        ' SalirToolStripMenuItem
        ' 
        SalirToolStripMenuItem.Name = "SalirToolStripMenuItem"
        SalirToolStripMenuItem.Size = New Size(41, 20)
        SalirToolStripMenuItem.Text = "Salir"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(23, 48)
        Label1.Name = "Label1"
        Label1.Size = New Size(62, 15)
        Label1.TabIndex = 3
        Label1.Text = "Profesores"
        ' 
        ' btnBuscar
        ' 
        btnBuscar.Location = New Point(108, 44)
        btnBuscar.Name = "btnBuscar"
        btnBuscar.Size = New Size(75, 23)
        btnBuscar.TabIndex = 4
        btnBuscar.Text = "Buscar"
        btnBuscar.UseVisualStyleBackColor = True
        ' 
        ' dgvProfesores
        ' 
        dgvProfesores.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvProfesores.Location = New Point(23, 73)
        dgvProfesores.Name = "dgvProfesores"
        dgvProfesores.RowTemplate.Height = 25
        dgvProfesores.Size = New Size(765, 98)
        dgvProfesores.TabIndex = 5
        ' 
        ' btnAgregar
        ' 
        btnAgregar.Location = New Point(294, 384)
        btnAgregar.Name = "btnAgregar"
        btnAgregar.Size = New Size(100, 23)
        btnAgregar.TabIndex = 6
        btnAgregar.Text = "Agregar"
        btnAgregar.UseVisualStyleBackColor = True
        ' 
        ' btnEliminarProfesor
        ' 
        btnEliminarProfesor.Location = New Point(518, 204)
        btnEliminarProfesor.Name = "btnEliminarProfesor"
        btnEliminarProfesor.Size = New Size(75, 23)
        btnEliminarProfesor.TabIndex = 7
        btnEliminarProfesor.Text = "Eliminar"
        btnEliminarProfesor.UseVisualStyleBackColor = True
        ' 
        ' lbligo
        ' 
        lbligo.AutoSize = True
        lbligo.Location = New Point(23, 231)
        lbligo.Name = "lbligo"
        lbligo.Size = New Size(46, 15)
        lbligo.TabIndex = 8
        lbligo.Text = "Codigo"
        ' 
        ' txtCodigo
        ' 
        txtCodigo.Location = New Point(23, 249)
        txtCodigo.Name = "txtCodigo"
        txtCodigo.Size = New Size(100, 23)
        txtCodigo.TabIndex = 9
        ' 
        ' txtCedulaProfesor
        ' 
        txtCedulaProfesor.Location = New Point(23, 293)
        txtCedulaProfesor.Name = "txtCedulaProfesor"
        txtCedulaProfesor.Size = New Size(100, 23)
        txtCedulaProfesor.TabIndex = 10
        ' 
        ' txtNombreProfesor
        ' 
        txtNombreProfesor.Location = New Point(23, 337)
        txtNombreProfesor.Name = "txtNombreProfesor"
        txtNombreProfesor.Size = New Size(100, 23)
        txtNombreProfesor.TabIndex = 11
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(23, 275)
        Label2.Name = "Label2"
        Label2.Size = New Size(89, 15)
        Label2.TabIndex = 12
        Label2.Text = "cedula profesor"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(23, 319)
        Label3.Name = "Label3"
        Label3.Size = New Size(49, 15)
        Label3.TabIndex = 13
        Label3.Text = "nombre"
        ' 
        ' txtApellidoProfesor
        ' 
        txtApellidoProfesor.Location = New Point(23, 384)
        txtApellidoProfesor.Name = "txtApellidoProfesor"
        txtApellidoProfesor.Size = New Size(100, 23)
        txtApellidoProfesor.TabIndex = 14
        ' 
        ' Apellido
        ' 
        Apellido.AutoSize = True
        Apellido.Location = New Point(23, 363)
        Apellido.Name = "Apellido"
        Apellido.Size = New Size(51, 15)
        Apellido.TabIndex = 15
        Apellido.Text = "Apellido"
        ' 
        ' txtDireccionProfesor
        ' 
        txtDireccionProfesor.Location = New Point(158, 249)
        txtDireccionProfesor.Name = "txtDireccionProfesor"
        txtDireccionProfesor.Size = New Size(100, 23)
        txtDireccionProfesor.TabIndex = 16
        ' 
        ' txtCelularProfesor
        ' 
        txtCelularProfesor.Location = New Point(158, 293)
        txtCelularProfesor.Name = "txtCelularProfesor"
        txtCelularProfesor.Size = New Size(100, 23)
        txtCelularProfesor.TabIndex = 17
        ' 
        ' txtCorreoProfesor
        ' 
        txtCorreoProfesor.Location = New Point(158, 337)
        txtCorreoProfesor.Name = "txtCorreoProfesor"
        txtCorreoProfesor.Size = New Size(100, 23)
        txtCorreoProfesor.TabIndex = 18
        ' 
        ' txtCodProvincia
        ' 
        txtCodProvincia.Location = New Point(158, 384)
        txtCodProvincia.Name = "txtCodProvincia"
        txtCodProvincia.Size = New Size(100, 23)
        txtCodProvincia.TabIndex = 19
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(158, 231)
        Label4.Name = "Label4"
        Label4.Size = New Size(57, 15)
        Label4.TabIndex = 20
        Label4.Text = "Direccion"
        ' 
        ' celular
        ' 
        celular.AutoSize = True
        celular.Location = New Point(158, 275)
        celular.Name = "celular"
        celular.Size = New Size(42, 15)
        celular.TabIndex = 21
        celular.Text = "celular"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(159, 322)
        Label5.Name = "Label5"
        Label5.Size = New Size(41, 15)
        Label5.TabIndex = 22
        Label5.Text = "correo"
        ' 
        ' Provincia
        ' 
        Provincia.AutoSize = True
        Provincia.Location = New Point(159, 366)
        Provincia.Name = "Provincia"
        Provincia.Size = New Size(81, 15)
        Provincia.TabIndex = 23
        Provincia.Text = "Cod Provincia"
        ' 
        ' txtCodDistrito
        ' 
        txtCodDistrito.Location = New Point(294, 252)
        txtCodDistrito.Name = "txtCodDistrito"
        txtCodDistrito.Size = New Size(100, 23)
        txtCodDistrito.TabIndex = 24
        ' 
        ' Distrito
        ' 
        Distrito.AutoSize = True
        Distrito.Location = New Point(294, 234)
        Distrito.Name = "Distrito"
        Distrito.Size = New Size(69, 15)
        Distrito.TabIndex = 25
        Distrito.Text = "Cod distrito"
        ' 
        ' txtSalarioBase
        ' 
        txtSalarioBase.Location = New Point(294, 293)
        txtSalarioBase.Name = "txtSalarioBase"
        txtSalarioBase.Size = New Size(100, 23)
        txtSalarioBase.TabIndex = 26
        ' 
        ' salario
        ' 
        salario.AutoSize = True
        salario.Location = New Point(297, 278)
        salario.Name = "salario"
        salario.Size = New Size(41, 15)
        salario.TabIndex = 27
        salario.Text = "salario"
        ' 
        ' cmbEstatusProfesor
        ' 
        cmbEstatusProfesor.AcceptsReturn = True
        cmbEstatusProfesor.Location = New Point(294, 337)
        cmbEstatusProfesor.Name = "cmbEstatusProfesor"
        cmbEstatusProfesor.Size = New Size(100, 23)
        cmbEstatusProfesor.TabIndex = 28
        ' 
        ' estatus
        ' 
        estatus.AutoSize = True
        estatus.Location = New Point(297, 322)
        estatus.Name = "estatus"
        estatus.Size = New Size(44, 15)
        estatus.TabIndex = 29
        estatus.Text = "estatus"
        ' 
        ' txtIdProfesor
        ' 
        txtIdProfesor.Location = New Point(297, 204)
        txtIdProfesor.Name = "txtIdProfesor"
        txtIdProfesor.Size = New Size(100, 23)
        txtIdProfesor.TabIndex = 30
        ' 
        ' btnEditarProfesor
        ' 
        btnEditarProfesor.Location = New Point(426, 204)
        btnEditarProfesor.Name = "btnEditarProfesor"
        btnEditarProfesor.Size = New Size(75, 23)
        btnEditarProfesor.TabIndex = 31
        btnEditarProfesor.Text = "editar"
        btnEditarProfesor.UseVisualStyleBackColor = True
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(23, 204)
        Label6.Name = "Label6"
        Label6.Size = New Size(201, 15)
        Label6.TabIndex = 32
        Label6.Text = "ingrese el id para editar o eliminar ->"
        ' 
        ' btnLimpiarProfesor
        ' 
        btnLimpiarProfesor.Location = New Point(713, 42)
        btnLimpiarProfesor.Name = "btnLimpiarProfesor"
        btnLimpiarProfesor.Size = New Size(75, 23)
        btnLimpiarProfesor.TabIndex = 33
        btnLimpiarProfesor.Text = "Limpiar"
        btnLimpiarProfesor.UseVisualStyleBackColor = True
        ' 
        ' FacultadesToolStripMenuItem
        ' 
        FacultadesToolStripMenuItem.Name = "FacultadesToolStripMenuItem"
        FacultadesToolStripMenuItem.Size = New Size(73, 20)
        FacultadesToolStripMenuItem.Text = "facultades"
        ' 
        ' FormProfesor
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(btnLimpiarProfesor)
        Controls.Add(Label6)
        Controls.Add(btnEditarProfesor)
        Controls.Add(txtIdProfesor)
        Controls.Add(estatus)
        Controls.Add(cmbEstatusProfesor)
        Controls.Add(salario)
        Controls.Add(txtSalarioBase)
        Controls.Add(Distrito)
        Controls.Add(txtCodDistrito)
        Controls.Add(Provincia)
        Controls.Add(Label5)
        Controls.Add(celular)
        Controls.Add(Label4)
        Controls.Add(txtCodProvincia)
        Controls.Add(txtCorreoProfesor)
        Controls.Add(txtCelularProfesor)
        Controls.Add(txtDireccionProfesor)
        Controls.Add(Apellido)
        Controls.Add(txtApellidoProfesor)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(txtNombreProfesor)
        Controls.Add(txtCedulaProfesor)
        Controls.Add(txtCodigo)
        Controls.Add(lbligo)
        Controls.Add(btnEliminarProfesor)
        Controls.Add(btnAgregar)
        Controls.Add(dgvProfesores)
        Controls.Add(btnBuscar)
        Controls.Add(Label1)
        Controls.Add(MenuStrip)
        Name = "FormProfesor"
        Text = "FormProfesor"
        MenuStrip.ResumeLayout(False)
        MenuStrip.PerformLayout()
        CType(dgvProfesores, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents MenuStrip As MenuStrip
    Friend WithEvents PresentacionToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Mantenimiento As ToolStripMenuItem
    Friend WithEvents EstudianteToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ProfesorToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SalirToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Label1 As Label
    Friend WithEvents btnBuscar As Button
    Friend WithEvents dgvProfesores As DataGridView
    Friend WithEvents btnAgregar As Button
    Friend WithEvents btnEliminarProfesor As Button
    Friend WithEvents lbligo As Label
    Friend WithEvents txtCodigo As TextBox
    Friend WithEvents txtCedulaProfesor As TextBox
    Friend WithEvents txtNombreProfesor As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txtApellidoProfesor As TextBox
    Friend WithEvents Apellido As Label
    Friend WithEvents txtDireccionProfesor As TextBox
    Friend WithEvents txtCelularProfesor As TextBox
    Friend WithEvents txtCorreoProfesor As TextBox
    Friend WithEvents txtCodProvincia As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents celular As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Provincia As Label
    Friend WithEvents txtCodDistrito As TextBox
    Friend WithEvents Distrito As Label
    Friend WithEvents txtSalarioBase As TextBox
    Friend WithEvents salario As Label
    Friend WithEvents cmbEstatusProfesor As TextBox
    Friend WithEvents estatus As Label
    Friend WithEvents txtIdProfesor As TextBox
    Friend WithEvents btnEditarProfesor As Button
    Friend WithEvents Label6 As Label
    Friend WithEvents btnLimpiarProfesor As Button
    Friend WithEvents FacultadesToolStripMenuItem As ToolStripMenuItem
End Class
