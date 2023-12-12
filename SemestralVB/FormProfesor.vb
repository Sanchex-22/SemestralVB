Imports MySql.Data.MySqlClient
Imports Mysqlx

Public Class FormProfesor
    Dim command As MySqlCommand
    Dim sql As String
    Dim SqlReader As MySqlDataReader
    Dim sqlAdapter As MySqlDataAdapter

    Dim connectionString As String = "Server=localhost;Database=Vb;User ID=root;Password=12345;"
    Dim connection As New MySqlConnection(connectionString)

    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        Try
            ' Abrir la conexión
            connection.Open()

            ' Crear y ejecutar la consulta SQL de inserción
            Dim query As String = "INSERT INTO Profesor (codigo, cedula, nombre, apellido, direccion, celular, correo, cod_provincia, cod_distrito, salario_base, estatus) " &
                                  "VALUES (@Codigo, @Cedula, @Nombre, @Apellido, @Direccion, @Celular, @Correo, @CodProvincia, @CodDistrito, @SalarioBase, @Estatus)"

            Dim command As New MySqlCommand(query, connection)

            ' Parámetros para la consulta de inserción obtenidos de los controles en el formulario
            command.Parameters.AddWithValue("@Codigo", txtCodigo.Text)
            command.Parameters.AddWithValue("@Cedula", txtCedulaProfesor.Text)
            command.Parameters.AddWithValue("@Nombre", txtNombreProfesor.Text)
            command.Parameters.AddWithValue("@Apellido", txtApellidoProfesor.Text)
            command.Parameters.AddWithValue("@Direccion", txtDireccionProfesor.Text)
            command.Parameters.AddWithValue("@Celular", txtCelularProfesor.Text)
            command.Parameters.AddWithValue("@Correo", txtCorreoProfesor.Text)
            command.Parameters.AddWithValue("@CodProvincia", txtCodProvincia.Text)
            command.Parameters.AddWithValue("@CodDistrito", txtCodDistrito.Text)
            command.Parameters.AddWithValue("@SalarioBase", Convert.ToDecimal(txtSalarioBase.Text))
            command.Parameters.AddWithValue("@Estatus", cmbEstatusProfesor.Text)

            ' Ejecutar la consulta
            command.ExecuteNonQuery()

            MessageBox.Show("Datos del profesor insertados correctamente.")
        Catch ex As Exception
            MessageBox.Show("Error al insertar datos del profesor: " & ex.Message)
        Finally
            ' Cerrar la conexión
            connection.Close()
        End Try
    End Sub
    Private Sub FormProfesor_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Puedes agregar código adicional si es necesario cuando el formulario se carga
    End Sub

    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click

        Try
            ' Abrir la conexión
            connection.Open()

            ' Crear y ejecutar la consulta SQL
            Dim query As String = "SELECT * FROM Profesor"
            Dim command As New MySqlCommand(query, connection)
            Dim adapter As New MySqlDataAdapter(command)
            Dim dataTable As New DataTable()

            ' Llenar el DataTable con los resultados de la consulta
            adapter.Fill(dataTable)

            ' Mostrar los datos en el DataGridView llamado dgvProfesores
            dgvProfesores.DataSource = dataTable
        Catch ex As Exception
            MessageBox.Show("Error al buscar datos: " & ex.Message)
        Finally
            ' Cerrar la conexión
            connection.Close()
        End Try
    End Sub

    Private Sub btnEliminarProfesor_Click(sender As Object, e As EventArgs)
        Try
            ' Obtener el ID del profesor que se va a eliminar
            Dim idProfesor As Integer = Integer.Parse(txtIdProfesor.Text)

            ' Abrir la conexión
            connection.Open()

            ' Crear y ejecutar la consulta SQL de eliminación
            Dim query As String = "DELETE FROM Profesor WHERE Id = @Id"
            Dim command As New MySqlCommand(query, connection)

            ' Parámetro para la consulta de eliminación
            command.Parameters.AddWithValue("@Id", idProfesor)

            ' Ejecutar la consulta
            Dim filasAfectadas As Integer = command.ExecuteNonQuery()

            If filasAfectadas > 0 Then
                MessageBox.Show("Profesor eliminado correctamente.")
            Else
                MessageBox.Show("No se encontró un profesor con el ID proporcionado.")
            End If
        Catch ex As Exception
            MessageBox.Show("Error al eliminar profesor: " & ex.Message)
        Finally
            ' Cerrar la conexión
            connection.Close()
        End Try
    End Sub

    Private Sub btnEditarProfesor_Click(sender As Object, e As EventArgs) Handles btnEditarProfesor.Click
        Try
            ' Obtener el ID del profesor que se va a editar
            Dim idProfesor As Integer = Integer.Parse(txtIdProfesor.Text)

            ' Abrir la conexión
            connection.Open()

            ' Crear y ejecutar la consulta SQL de actualización
            Dim query As String = "UPDATE Profesor SET codigo = @Codigo, cedula = @Cedula, nombre = @Nombre, " &
                                  "apellido = @Apellido, direccion = @Direccion, celular = @Celular, " &
                                  "correo = @Correo, cod_provincia = @CodProvincia, cod_distrito = @CodDistrito, " &
                                  "salario_base = @SalarioBase, estatus = @Estatus " &
                                  "WHERE Id = @Id"

            Dim command As New MySqlCommand(query, connection)

            ' Parámetros para la consulta de actualización obtenidos de los controles en el formulario
            command.Parameters.AddWithValue("@Codigo", txtCodigo.Text)
            command.Parameters.AddWithValue("@Cedula", txtCedulaProfesor.Text)
            command.Parameters.AddWithValue("@Nombre", txtNombreProfesor.Text)
            command.Parameters.AddWithValue("@Apellido", txtApellidoProfesor.Text)
            command.Parameters.AddWithValue("@Direccion", txtDireccionProfesor.Text)
            command.Parameters.AddWithValue("@Celular", txtCelularProfesor.Text)
            command.Parameters.AddWithValue("@Correo", txtCorreoProfesor.Text)
            command.Parameters.AddWithValue("@CodProvincia", txtCodProvincia.Text)
            command.Parameters.AddWithValue("@CodDistrito", txtCodDistrito.Text)
            command.Parameters.AddWithValue("@SalarioBase", Convert.ToDecimal(txtSalarioBase.Text))
            command.Parameters.AddWithValue("@Estatus", cmbEstatusProfesor.Text)
            command.Parameters.AddWithValue("@Id", idProfesor)

            ' Ejecutar la consulta
            Dim filasAfectadas As Integer = command.ExecuteNonQuery()

            If filasAfectadas > 0 Then
                MessageBox.Show("Datos del profesor actualizados correctamente.")
            Else
                MessageBox.Show("No se encontró un profesor con el ID proporcionado.")
            End If
        Catch ex As Exception
            MessageBox.Show("Error al actualizar datos del profesor: " & ex.Message)
        Finally
            ' Cerrar la conexión
            connection.Close()
        End Try
    End Sub

    Private Sub btnLimpiarProfesor_Click(sender As Object, e As EventArgs) Handles btnLimpiarProfesor.Click
        ' Limpiar los valores de los controles del formulario
        txtIdProfesor.Clear()
        txtCodigo.Clear()
        txtCedulaProfesor.Clear()
        txtNombreProfesor.Clear()
        txtApellidoProfesor.Clear()
        txtDireccionProfesor.Clear()
        txtCelularProfesor.Clear()
        txtCorreoProfesor.Clear()
        txtCodProvincia.Clear()
        txtCodDistrito.Clear()
        txtSalarioBase.Clear()
        cmbEstatusProfesor.Clear()

    End Sub

    Private Sub ToolStripMenuItem1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub PresentacionToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PresentacionToolStripMenuItem.Click
        Me.Hide()
        Form1.Show()
    End Sub

    Private Sub SalirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalirToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub EstudianteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EstudianteToolStripMenuItem.Click
        Me.Hide()
        FormEstudiante.Show()
    End Sub

    Private Sub FacultadesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FacultadesToolStripMenuItem.Click
        Me.Hide()
        FormFacultades.Show()
    End Sub
End Class
