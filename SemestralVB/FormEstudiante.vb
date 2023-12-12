Imports MySql.Data.MySqlClient
Imports Mysqlx

Public Class FormEstudiante
    Dim command As MySqlCommand
    Dim sql As String
    Dim SqlReader As MySqlDataReader
    Dim sqlAdapter As MySqlDataAdapter

    Dim connectionString As String = "Server=localhost;Database=Vb;User ID=root;Password=12345;"
    Dim connection As New MySqlConnection(connectionString)

    ' Constructor que acepta la referencia a Form1
    Private Sub FormEstudiante_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Puedes agregar código adicional si es necesario cuando el formulario se carga
    End Sub

    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click

        Try
            ' Abrir la conexión
            connection.Open()

            ' Crear y ejecutar la consulta SQL
            Dim query As String = "SELECT * FROM Estudiante"
            Dim command As New MySqlCommand(query, connection)
            Dim adapter As New MySqlDataAdapter(command)
            Dim dataTable As New DataTable()

            ' Llenar el DataTable con los resultados de la consulta
            adapter.Fill(dataTable)

            ' Mostrar los datos en el DataGridView llamado dgvEstudiantes
            dgvEstudiantes.DataSource = dataTable
        Catch ex As Exception
            MessageBox.Show("Error al buscar datos: " & ex.Message)
        Finally
            ' Cerrar la conexión
            connection.Close()
        End Try
    End Sub

    Private Sub btnBuscarEstudiante_Click(sender As Object, e As EventArgs) Handles btnBuscarEstudiante.Click
        Try
            ' Obtener el número de cédula del estudiante que se va a buscar
            Dim cedulaEstudiante As String = txtCedulaEstudiante.Text

            ' Abrir la conexión
            connection.Open()

            ' Crear y ejecutar la consulta SQL de búsqueda
            Dim query As String = "SELECT * FROM Estudiante WHERE cedula = @Cedula"
            Dim command As New MySqlCommand(query, connection)

            ' Parámetro para la consulta de búsqueda
            command.Parameters.AddWithValue("@Cedula", cedulaEstudiante)

            ' Crear un adaptador de datos para llenar un DataTable con los resultados de la consulta
            Dim adapter As New MySqlDataAdapter(command)
            Dim dataTable As New DataTable()

            ' Llenar el DataTable con los resultados de la consulta
            adapter.Fill(dataTable)

            ' Mostrar los datos en el DataGridView llamado dgvEstudiantes
            dgvEstudiantes.DataSource = dataTable
        Catch ex As Exception
            MessageBox.Show("Error al buscar estudiante: " & ex.Message)
        Finally
            ' Cerrar la conexión
            connection.Close()
        End Try
    End Sub

    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        Try
            ' Abrir la conexión
            connection.Open()

            ' Crear y ejecutar la consulta SQL de inserción
            Dim query As String = "INSERT INTO Estudiante (cedula, nombre, apellido, direccion, celular, correo, cod_facultad, cod_carrera, indice_academico, sexo, estatus) " &
                                  "VALUES (@Cedula, @Nombre, @Apellido, @Direccion, @Celular, @Correo, @CodFacultad, @CodCarrera, @IndiceAcademico, @Sexo, @Estatus)"

            Dim command As New MySqlCommand(query, connection)

            ' Parámetros para la consulta de inserción obtenidos de los controles en el formulario
            command.Parameters.AddWithValue("@Cedula", txtCedula.Text)
            command.Parameters.AddWithValue("@Nombre", txtNombre.Text)
            command.Parameters.AddWithValue("@Apellido", txtApellido.Text)
            command.Parameters.AddWithValue("@Direccion", txtDireccion.Text)
            command.Parameters.AddWithValue("@Celular", txtCelular.Text)
            command.Parameters.AddWithValue("@Correo", txtCorreo.Text)
            command.Parameters.AddWithValue("@CodFacultad", txtCodFacultad.Text)
            command.Parameters.AddWithValue("@CodCarrera", txtCodCarrera.Text)
            command.Parameters.AddWithValue("@IndiceAcademico", Convert.ToDecimal(txtIndiceAcademico.Text))
            command.Parameters.AddWithValue("@Sexo", cmbSexo.Text)
            command.Parameters.AddWithValue("@Estatus", cmbEstatus.Text)

            ' Ejecutar la consulta
            command.ExecuteNonQuery()

            MessageBox.Show("Datos insertados correctamente.")
        Catch ex As Exception
            MessageBox.Show("Error al insertar datos: " & ex.Message)
        Finally
            ' Cerrar la conexión
            connection.Close()
        End Try
    End Sub

    Private Sub ToolStripMenuItem_Click(sender As Object, e2 As EventArgs)

    End Sub

    Private Sub PresentacionToolStripMenuItem_Click(sender As Object, e2 As EventArgs) Handles PresentacionToolStripMenuItem.Click

        Form1.Show()
        Me.Close()
    End Sub

    Private Sub SalirToolStripMenuItem_Click(sender As Object, e2 As EventArgs) Handles SalirToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub ProfesorToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ProfesorToolStripMenuItem.Click
        Me.Hide()
        FormProfesor.Show()
    End Sub

    Private Sub codFacultad_Click(sender As Object, e As EventArgs) Handles codFacultad.Click

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Try
            ' Obtener el ID del estudiante que se va a eliminar
            Dim idEstudiante As Integer = Integer.Parse(txtIdEstudiante.Text)

            ' Abrir la conexión
            connection.Open()

            ' Crear y ejecutar la consulta SQL de eliminación
            Dim query As String = "DELETE FROM Estudiante WHERE Id = @Id"
            Dim command As New MySqlCommand(query, connection)

            ' Parámetro para la consulta de eliminación
            command.Parameters.AddWithValue("@Id", idEstudiante)

            ' Ejecutar la consulta
            Dim filasAfectadas As Integer = command.ExecuteNonQuery()

            If filasAfectadas > 0 Then
                MessageBox.Show("Estudiante eliminado correctamente.")
            Else
                MessageBox.Show("No se encontró un estudiante con el ID proporcionado.")
            End If
        Catch ex As Exception
            MessageBox.Show("Error al eliminar estudiante: " & ex.Message)
        Finally
            ' Cerrar la conexión
            connection.Close()
        End Try
    End Sub

    Private Sub btnModificar_Click(sender As Object, e As EventArgs) Handles btnModificar.Click
        Try
            ' Obtener el ID del estudiante que se va a editar
            Dim idEstudiante As Integer = Integer.Parse(txtIdEstudiante.Text)

            ' Abrir la conexión
            connection.Open()

            ' Crear y ejecutar la consulta SQL de actualización
            Dim query As String = "UPDATE Estudiante SET cedula = @Cedula, nombre = @Nombre, apellido = @Apellido, " &
                                  "direccion = @Direccion, celular = @Celular, correo = @Correo, " &
                                  "cod_facultad = @CodFacultad, cod_carrera = @CodCarrera, " &
                                  "indice_academico = @IndiceAcademico, sexo = @Sexo, estatus = @Estatus " &
                                  "WHERE Id = @Id"

            Dim command As New MySqlCommand(query, connection)

            ' Parámetros para la consulta de actualización obtenidos de los controles en el formulario
            command.Parameters.AddWithValue("@Cedula", txtCedula.Text)
            command.Parameters.AddWithValue("@Nombre", txtNombre.Text)
            command.Parameters.AddWithValue("@Apellido", txtApellido.Text)
            command.Parameters.AddWithValue("@Direccion", txtDireccion.Text)
            command.Parameters.AddWithValue("@Celular", txtCelular.Text)
            command.Parameters.AddWithValue("@Correo", txtCorreo.Text)
            command.Parameters.AddWithValue("@CodFacultad", txtCodFacultad.Text)
            command.Parameters.AddWithValue("@CodCarrera", txtCodCarrera.Text)
            command.Parameters.AddWithValue("@IndiceAcademico", Convert.ToDecimal(txtIndiceAcademico.Text))
            command.Parameters.AddWithValue("@Sexo", cmbSexo.Text)
            command.Parameters.AddWithValue("@Estatus", cmbEstatus.Text)
            command.Parameters.AddWithValue("@Id", idEstudiante)

            ' Ejecutar la consulta
            Dim filasAfectadas As Integer = command.ExecuteNonQuery()

            If filasAfectadas > 0 Then
                MessageBox.Show("Datos del estudiante actualizados correctamente.")
            Else
                MessageBox.Show("No se encontró un estudiante con el ID proporcionado.")
            End If
        Catch ex As Exception
            MessageBox.Show("Error al actualizar datos del estudiante: " & ex.Message)
        Finally
            ' Cerrar la conexión
            connection.Close()
        End Try
    End Sub

    Private Sub Mantenimiento_Click(sender As Object, e As EventArgs) Handles Mantenimiento.Click

    End Sub

    Private Sub ModificarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ModificarToolStripMenuItem.Click
        Me.Hide()
        'FormEstudianteEdit.Show()
    End Sub

End Class
