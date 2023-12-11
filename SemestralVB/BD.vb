Imports MySql.Data.MySqlClient

Public Class BD
    Public Sub Conectar()
        Dim connectionString As String = "Server=localhost;Database=Vb;User ID=root;Password=12345;"

        Using connection As New MySqlConnection(connectionString)
            Try
                connection.Open()

                ' Puedes realizar operaciones en la base de datos aquí si lo deseas

                ' Muestra un mensaje de conexión exitosa
                MessageBox.Show("Conexión exitosa a la base de datos")

            Catch ex As MySqlException
                ' Maneja las excepciones específicas de MySQL
                MessageBox.Show("Error de MySQL al conectar: " & ex.Message)

            Catch ex As Exception
                ' Maneja otras excepciones generales
                MessageBox.Show("Error al conectar a la base de datos: " & ex.Message)

            Finally
                ' Cierra la conexión si está abierta
                If connection.State = ConnectionState.Open Then
                    connection.Close()
                End If
            End Try
        End Using
    End Sub
End Class
