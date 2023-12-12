<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        btnConectar = New Button()
        MenuStrip1 = New MenuStrip()
        PresentacionToolStripMenuItem = New ToolStripMenuItem()
        Mantenimiento = New ToolStripMenuItem()
        EstudianteToolStripMenuItem = New ToolStripMenuItem()
        ProfesorToolStripMenuItem = New ToolStripMenuItem()
        SalirToolStripMenuItem = New ToolStripMenuItem()
        Label1 = New Label()
        Label2 = New Label()
        MenuStrip1.SuspendLayout()
        SuspendLayout()
        ' 
        ' btnConectar
        ' 
        btnConectar.Location = New Point(660, 40)
        btnConectar.Name = "btnConectar"
        btnConectar.Size = New Size(101, 23)
        btnConectar.TabIndex = 0
        btnConectar.Text = "Conectar BD"
        btnConectar.UseVisualStyleBackColor = True
        ' 
        ' MenuStrip1
        ' 
        MenuStrip1.Items.AddRange(New ToolStripItem() {PresentacionToolStripMenuItem, Mantenimiento, SalirToolStripMenuItem})
        MenuStrip1.Location = New Point(0, 0)
        MenuStrip1.Name = "MenuStrip1"
        MenuStrip1.Size = New Size(800, 24)
        MenuStrip1.TabIndex = 1
        MenuStrip1.Text = "MenuStrip1"
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
        Label1.Location = New Point(251, 80)
        Label1.Name = "Label1"
        Label1.Size = New Size(0, 15)
        Label1.TabIndex = 2
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(284, 93)
        Label2.Name = "Label2"
        Label2.Size = New Size(41, 15)
        Label2.TabIndex = 3
        Label2.Text = "Label2"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(btnConectar)
        Controls.Add(MenuStrip1)
        MainMenuStrip = MenuStrip1
        Name = "Form1"
        Text = "Form1"
        MenuStrip1.ResumeLayout(False)
        MenuStrip1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents btnConectar As Button
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents Mantenimiento As ToolStripMenuItem
    Friend WithEvents EstudianteToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ProfesorToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SalirToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PresentacionToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
End Class
