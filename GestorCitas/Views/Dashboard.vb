Imports GestorCitas.Application
Imports GestorCitas.Infrastructure

Public Class Dashboard

    Private ReadOnly Property _pacienteService As New PacienteService(New PacienteRepository)
    Private ReadOnly Property _medicoService As New MedicoService(New MedicoRepository)
    Private ReadOnly Property _consultaService As New ConsultaService(New ConsultaRepository)

    Sub New()
        InitializeComponent()
    End Sub

    Private Sub AñadirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AñadirToolStripMenuItem.Click
        Dim formPaciente As New FormPaciente(_pacienteService) With {
            .MdiParent = Me
        }
        formPaciente.Show()
    End Sub

    Private Sub ListaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ListaToolStripMenuItem.Click
        Dim gridPaciente As New GridPaciente(_pacienteService) With {
            .MdiParent = Me
        }
        gridPaciente.Show()
    End Sub

    Private Sub AñadirToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles AñadirToolStripMenuItem1.Click
        Dim formCita As New FormCita(_pacienteService, _medicoService, _consultaService) With {
            .MdiParent = Me
        }
        formCita.Show()
    End Sub

    Private Sub Dashboard_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        Login.Close()
    End Sub

    Private Sub ListadoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ListadoToolStripMenuItem.Click
        Dim gridCita As New GridCita(_consultaService) With {
            .MdiParent = Me
        }
        gridCita.Show()
    End Sub

    Private Sub Dashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim gridPaciente As New GridPaciente(_pacienteService) With {
          .MdiParent = Me
      }
        gridPaciente.Show()
    End Sub

    Private Sub CerrarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CerrarToolStripMenuItem.Click
        Login.Close()
    End Sub
End Class