﻿Public Class Form1
    Public Sub New()

        InitializeComponent()
        Label2.Text = "Universidad tecnologica de Panama" & vbCrLf &
              "Desarrollo de Software VIII" & vbCrLf & vbCrLf &
              "Nombre: Carlos Sanchez" & vbCrLf &
              "Cedula: 8-979-2162"

    End Sub
    Private Sub ToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles Mantenimiento.Click

    End Sub

    Private Sub PresentacionToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PresentacionToolStripMenuItem.Click

    End Sub

    Private Sub SalirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalirToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub EstudianteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EstudianteToolStripMenuItem.Click

        FormEstudiante.Show()
        Me.Close()
    End Sub

    Private Sub ProfesorToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ProfesorToolStripMenuItem.Click
        Me.Hide()
        FormProfesor.Show()
    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub FacultadesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FacultadesToolStripMenuItem.Click
        Me.Hide()
        FormFacultades.Show()
    End Sub
End Class
