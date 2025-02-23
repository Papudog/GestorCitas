Imports GestorCitas.Domain
Imports GestorCitas.Infrastructure

Public Class ConsultaService
    Implements IConsultaService

    Private ReadOnly Property _consultaRepository As IConsultaRepository
    Public Event OnRepositoryChanged As Action Implements IConsultaService.OnRepositoryChanged

    Sub New(consultaRepository As IConsultaRepository)
        _consultaRepository = consultaRepository

        AddHandler _consultaRepository.OnConsultasChanged, AddressOf OnRepositoryChangedHandler
    End Sub

    Public Sub OnRepositoryChangedHandler() Implements IConsultaService.OnRepositoryChangedHandler
        RaiseEvent OnRepositoryChanged()
    End Sub

    Public Function ObtenerConsultas() As List(Of IConsulta) Implements IConsultaService.ObtenerConsultas
        Return _consultaRepository.Consultas.ToList()
    End Function

    Public Function AgregarConsulta(paciente As IConsulta) As Dictionary(Of String, Object) Implements IConsultaService.AgregarConsulta
        Dim response As New Respuesta()

        Dim consultaAgregada = _consultaRepository.AgregarConsulta(paciente)
        Return New Dictionary(Of String, Object) From {
            {"message", "Consulta agregada"},
            {"success", True},
            {"data", consultaAgregada}
        }
    End Function
End Class