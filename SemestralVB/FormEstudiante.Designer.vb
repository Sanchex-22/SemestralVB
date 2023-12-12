<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormEstudiante
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
        Label1 = New Label()
        btnBuscar = New Button()
        dgvEstudiantes = New DataGridView()
        btnAgregar = New Button()
        txtCedula = New TextBox()
        cedula = New Label()
        Label2 = New Label()
        txtNombre = New TextBox()
        Label3 = New Label()
        txtApellido = New TextBox()
        Label4 = New Label()
        txtDireccion = New TextBox()
        Label5 = New Label()
        txtCelular = New TextBox()
        Label6 = New Label()
        txtCorreo = New TextBox()
        codFacultad = New Label()
        txtCodFacultad = New TextBox()
        Label8 = New Label()
        txtCodCarrera = New TextBox()
        Label9 = New Label()
        txtIndiceAcademico = New TextBox()
        cmbSexo = New TextBox()
        cmbEstatus = New TextBox()
        sexo = New Label()
        Estatus = New Label()
        btnModificar = New Button()
        Button2 = New Button()
        txtIdEstudiante = New TextBox()
        txtCedulaEstudiante = New TextBox()
        btnBuscarEstudiante = New Button()
        Label7 = New Label()
        btnLimpiarEstudiante = New Button()
        MenuStrip.SuspendLayout()
        CType(dgvEstudiantes, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' MenuStrip
        ' 
        MenuStrip.Items.AddRange(New ToolStripItem() {PresentacionToolStripMenuItem, Mantenimiento, FacultadToolStripMenuItem, SalirToolStripMenuItem})
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
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(19, 47)
        Label1.Name = "Label1"
        Label1.Size = New Size(67, 15)
        Label1.TabIndex = 3
        Label1.Text = "Estudiantes"
        ' 
        ' btnBuscar
        ' 
        btnBuscar.Location = New Point(101, 43)
        btnBuscar.Name = "btnBuscar"
        btnBuscar.Size = New Size(124, 23)
        btnBuscar.TabIndex = 4
        btnBuscar.Text = "Buscar todos"
        btnBuscar.UseVisualStyleBackColor = True
        ' 
        ' dgvEstudiantes
        ' 
        dgvEstudiantes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvEstudiantes.Location = New Point(19, 80)
        dgvEstudiantes.Name = "dgvEstudiantes"
        dgvEstudiantes.RowTemplate.Height = 25
        dgvEstudiantes.Size = New Size(769, 108)
        dgvEstudiantes.TabIndex = 5
        ' 
        ' btnAgregar
        ' 
        btnAgregar.Location = New Point(266, 396)
        btnAgregar.Name = "btnAgregar"
        btnAgregar.Size = New Size(98, 24)
        btnAgregar.TabIndex = 6
        btnAgregar.Text = "Agregar"
        btnAgregar.UseVisualStyleBackColor = True
        ' 
        ' txtCedula
        ' 
        txtCedula.Location = New Point(19, 257)
        txtCedula.Name = "txtCedula"
        txtCedula.Size = New Size(100, 23)
        txtCedula.TabIndex = 7
        ' 
        ' cedula
        ' 
        cedula.AutoSize = True
        cedula.Location = New Point(19, 239)
        cedula.Name = "cedula"
        cedula.Size = New Size(42, 15)
        cedula.TabIndex = 8
        cedula.Text = "cedula"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(19, 283)
        Label2.Name = "Label2"
        Label2.Size = New Size(49, 15)
        Label2.TabIndex = 9
        Label2.Text = "nombre"
        ' 
        ' txtNombre
        ' 
        txtNombre.Location = New Point(19, 301)
        txtNombre.Name = "txtNombre"
        txtNombre.Size = New Size(100, 23)
        txtNombre.TabIndex = 10
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(19, 327)
        Label3.Name = "Label3"
        Label3.Size = New Size(49, 15)
        Label3.TabIndex = 11
        Label3.Text = "apellido"
        ' 
        ' txtApellido
        ' 
        txtApellido.Location = New Point(19, 345)
        txtApellido.Name = "txtApellido"
        txtApellido.Size = New Size(100, 23)
        txtApellido.TabIndex = 12
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(19, 380)
        Label4.Name = "Label4"
        Label4.Size = New Size(56, 15)
        Label4.TabIndex = 13
        Label4.Text = "direccion"
        ' 
        ' txtDireccion
        ' 
        txtDireccion.Location = New Point(19, 398)
        txtDireccion.Name = "txtDireccion"
        txtDireccion.Size = New Size(100, 23)
        txtDireccion.TabIndex = 14
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(144, 239)
        Label5.Name = "Label5"
        Label5.Size = New Size(42, 15)
        Label5.TabIndex = 15
        Label5.Text = "celular"
        ' 
        ' txtCelular
        ' 
        txtCelular.Location = New Point(144, 257)
        txtCelular.Name = "txtCelular"
        txtCelular.Size = New Size(100, 23)
        txtCelular.TabIndex = 16
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(144, 283)
        Label6.Name = "Label6"
        Label6.Size = New Size(41, 15)
        Label6.TabIndex = 17
        Label6.Text = "correo"
        ' 
        ' txtCorreo
        ' 
        txtCorreo.Location = New Point(144, 301)
        txtCorreo.Name = "txtCorreo"
        txtCorreo.Size = New Size(100, 23)
        txtCorreo.TabIndex = 18
        ' 
        ' codFacultad
        ' 
        codFacultad.AutoSize = True
        codFacultad.Location = New Point(144, 327)
        codFacultad.Name = "codFacultad"
        codFacultad.Size = New Size(73, 15)
        codFacultad.TabIndex = 19
        codFacultad.Text = "cod facultad"
        ' 
        ' txtCodFacultad
        ' 
        txtCodFacultad.Location = New Point(144, 345)
        txtCodFacultad.Name = "txtCodFacultad"
        txtCodFacultad.Size = New Size(100, 23)
        txtCodFacultad.TabIndex = 20
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Location = New Point(144, 380)
        Label8.Name = "Label8"
        Label8.Size = New Size(66, 15)
        Label8.TabIndex = 22
        Label8.Text = "cod carrera"
        ' 
        ' txtCodCarrera
        ' 
        txtCodCarrera.Location = New Point(144, 398)
        txtCodCarrera.Name = "txtCodCarrera"
        txtCodCarrera.Size = New Size(100, 23)
        txtCodCarrera.TabIndex = 23
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Location = New Point(264, 243)
        Label9.Name = "Label9"
        Label9.Size = New Size(102, 15)
        Label9.TabIndex = 24
        Label9.Text = "Indice Academico"
        ' 
        ' txtIndiceAcademico
        ' 
        txtIndiceAcademico.Location = New Point(266, 257)
        txtIndiceAcademico.Name = "txtIndiceAcademico"
        txtIndiceAcademico.Size = New Size(100, 23)
        txtIndiceAcademico.TabIndex = 25
        ' 
        ' cmbSexo
        ' 
        cmbSexo.Location = New Point(266, 301)
        cmbSexo.Name = "cmbSexo"
        cmbSexo.Size = New Size(100, 23)
        cmbSexo.TabIndex = 26
        ' 
        ' cmbEstatus
        ' 
        cmbEstatus.Location = New Point(264, 345)
        cmbEstatus.Name = "cmbEstatus"
        cmbEstatus.Size = New Size(100, 23)
        cmbEstatus.TabIndex = 27
        ' 
        ' sexo
        ' 
        sexo.AutoSize = True
        sexo.Location = New Point(266, 283)
        sexo.Name = "sexo"
        sexo.Size = New Size(31, 15)
        sexo.TabIndex = 28
        sexo.Text = "sexo"
        ' 
        ' Estatus
        ' 
        Estatus.AutoSize = True
        Estatus.Location = New Point(266, 327)
        Estatus.Name = "Estatus"
        Estatus.Size = New Size(44, 15)
        Estatus.TabIndex = 29
        Estatus.Text = "estatus"
        ' 
        ' btnModificar
        ' 
        btnModificar.Location = New Point(399, 201)
        btnModificar.Name = "btnModificar"
        btnModificar.Size = New Size(75, 23)
        btnModificar.TabIndex = 30
        btnModificar.Text = "Modificar"
        btnModificar.UseVisualStyleBackColor = True
        ' 
        ' Button2
        ' 
        Button2.Location = New Point(503, 201)
        Button2.Name = "Button2"
        Button2.Size = New Size(75, 23)
        Button2.TabIndex = 31
        Button2.Text = "eliminar"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' txtIdEstudiante
        ' 
        txtIdEstudiante.Location = New Point(266, 201)
        txtIdEstudiante.Name = "txtIdEstudiante"
        txtIdEstudiante.Size = New Size(100, 23)
        txtIdEstudiante.TabIndex = 32
        ' 
        ' txtCedulaEstudiante
        ' 
        txtCedulaEstudiante.Location = New Point(374, 47)
        txtCedulaEstudiante.Name = "txtCedulaEstudiante"
        txtCedulaEstudiante.Size = New Size(100, 23)
        txtCedulaEstudiante.TabIndex = 33
        ' 
        ' btnBuscarEstudiante
        ' 
        btnBuscarEstudiante.Location = New Point(480, 47)
        btnBuscarEstudiante.Name = "btnBuscarEstudiante"
        btnBuscarEstudiante.Size = New Size(75, 23)
        btnBuscarEstudiante.TabIndex = 34
        btnBuscarEstudiante.Text = "Buscar"
        btnBuscarEstudiante.UseVisualStyleBackColor = True
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Location = New Point(19, 201)
        Label7.Name = "Label7"
        Label7.Size = New Size(222, 15)
        Label7.TabIndex = 35
        Label7.Text = "Ingrese el id para modificar o eliminar ->"
        ' 
        ' btnLimpiarEstudiante
        ' 
        btnLimpiarEstudiante.Location = New Point(561, 47)
        btnLimpiarEstudiante.Name = "btnLimpiarEstudiante"
        btnLimpiarEstudiante.Size = New Size(75, 23)
        btnLimpiarEstudiante.TabIndex = 36
        btnLimpiarEstudiante.Text = "Limpiar"
        btnLimpiarEstudiante.UseVisualStyleBackColor = True
        ' 
        ' FormEstudiante
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(btnLimpiarEstudiante)
        Controls.Add(Label7)
        Controls.Add(btnBuscarEstudiante)
        Controls.Add(txtCedulaEstudiante)
        Controls.Add(txtIdEstudiante)
        Controls.Add(Button2)
        Controls.Add(btnModificar)
        Controls.Add(Estatus)
        Controls.Add(sexo)
        Controls.Add(cmbEstatus)
        Controls.Add(cmbSexo)
        Controls.Add(txtIndiceAcademico)
        Controls.Add(Label9)
        Controls.Add(txtCodCarrera)
        Controls.Add(Label8)
        Controls.Add(txtCodFacultad)
        Controls.Add(codFacultad)
        Controls.Add(txtCorreo)
        Controls.Add(Label6)
        Controls.Add(txtCelular)
        Controls.Add(Label5)
        Controls.Add(txtDireccion)
        Controls.Add(Label4)
        Controls.Add(txtApellido)
        Controls.Add(Label3)
        Controls.Add(txtNombre)
        Controls.Add(Label2)
        Controls.Add(cedula)
        Controls.Add(txtCedula)
        Controls.Add(btnAgregar)
        Controls.Add(dgvEstudiantes)
        Controls.Add(btnBuscar)
        Controls.Add(Label1)
        Controls.Add(MenuStrip)
        Name = "FormEstudiante"
        Text = "FormEstudiante"
        MenuStrip.ResumeLayout(False)
        MenuStrip.PerformLayout()
        CType(dgvEstudiantes, ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents dgvEstudiantes As DataGridView
    Friend WithEvents btnAgregar As Button
    Friend WithEvents txtCedula As TextBox
    Friend WithEvents cedula As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtNombre As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtApellido As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtDireccion As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txtCelular As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txtCorreo As TextBox
    Friend WithEvents codFacultad As Label
    Friend WithEvents txtCodFacultad As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents txtCodCarrera As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents txtIndiceAcademico As TextBox
    Friend WithEvents cmbSexo As TextBox
    Friend WithEvents cmbEstatus As TextBox
    Friend WithEvents sexo As Label
    Friend WithEvents Estatus As Label
    Friend WithEvents btnModificar As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents txtIdEstudiante As TextBox
    Friend WithEvents txtCedulaEstudiante As TextBox
    Friend WithEvents btnBuscarEstudiante As Button
    Friend WithEvents ModificarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Label7 As Label
    Friend WithEvents btnLimpiarEstudiante As Button
    Friend WithEvents FacultadToolStripMenuItem As ToolStripMenuItem
End Class
