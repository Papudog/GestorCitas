Imports GestorCitas.Application
Imports GestorCitas.Infrastructure

Public Class Dashboard

    Private ReadOnly Property _pacienteService As New PacienteService(New PacienteRepository)

    Sub New()
        InitializeComponent()
    End Sub

    Private Sub AñadirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AñadirToolStripMenuItem.Click
        Dim formPaciente As New FormPaciente(_pacienteService) With {
            .MdiParent = Me
        }
        formPaciente.Show()
    End Sub
End Class