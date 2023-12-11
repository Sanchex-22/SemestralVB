Public Class Form1
    Private Sub btnConectar_Click(sender As Object, e As EventArgs) Handles btnConectar.Click
        ' Crea una instancia de tu clase BD
        Dim bd As New BD()

        ' Llama al método que realiza la conexión
        bd.Conectar()

        ' Muestra un mensaje de conexión exitosa
        MessageBox.Show("Conexión exitosa desde el formulario principal")
    End Sub

End Class
