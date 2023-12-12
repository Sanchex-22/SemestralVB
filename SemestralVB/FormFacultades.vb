Imports MySql.Data.MySqlClient

Public Class FormFacultades

    Dim connectionString As String = "Server=localhost;Database=Vb;User ID=root;Password=12345;"

    Private Sub TuFormulario_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CargarDatosFacultades()
    End Sub

    Private Sub CargarDatosFacultades()
        Try
            ' Crear la conexión
            Using connection As New MySqlConnection(connectionString)
                ' Abrir la conexión
                connection.Open()

                ' Consulta SQL para seleccionar todas las filas de la tabla Facultad
                Dim query As String = "SELECT * FROM Facultad"
                Using command As New MySqlCommand(query, connection)
                    ' Crear un adaptador de datos
                    Using adapter As New MySqlDataAdapter(command)
                        ' Crear un DataTable para almacenar los resultados de la consulta
                        Dim dataTable As New DataTable()

                        ' Llenar el DataTable con los resultados de la consulta
                        adapter.Fill(dataTable)

                        ' Mostrar los datos en el DataGridView
                        dgvFacultades.DataSource = dataTable
                    End Using
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error al cargar datos de facultades: " & ex.Message)
        End Try
    End Sub

    Private Sub ToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles Mantenimiento.Click

    End Sub

    Private Sub PresentacionToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PresentacionToolStripMenuItem.Click
        Me.Close()
        Form1.Show()
    End Sub

    Private Sub SalirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalirToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub EstudianteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EstudianteToolStripMenuItem.Click
        Me.Hide()
        FormEstudiante.Show()
    End Sub

    Private Sub ProfesorToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ProfesorToolStripMenuItem.Click
        Me.Hide()
        FormProfesor.Show()
    End Sub

    Private Sub FacultadToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FacultadToolStripMenuItem.Click

    End Sub
End Class