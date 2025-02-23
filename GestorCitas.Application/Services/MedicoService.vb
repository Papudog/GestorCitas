Imports GestorCitas.Domain
Imports GestorCitas.Infrastructure

Public Class MedicoService
    Implements IMedicoService

    Private ReadOnly Property _medicoRepository As IMedicoRepository
    Sub New(medicoRepository As IMedicoRepository)
        _medicoRepository = medicoRepository
    End Sub

    Public Function ObtenerEspecialidades() As IEspecialidad() Implements IMedicoService.ObtenerEspecialidades
        Return _medicoRepository.Especialidades.ToArray()
    End Function

    Public Function ObtenerMedicos() As List(Of IMedico) Implements IMedicoService.ObtenerMedicos
        Return _medicoRepository.Medicos.ToList()
    End Function

    Public Function ObtenerConsultorios() As Integer() Implements IMedicoService.ObtenerConsultorios
        Return _medicoRepository.Consultorios.ToArray()
    End Function
End Class
