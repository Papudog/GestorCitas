Imports System.Text.RegularExpressions
Imports GestorCitas.Domain
Imports GestorCitas.Infrastructure

Public Class PacienteService
    Implements IPacienteService

    Public Event OnRepositoryChanged As Action Implements IPacienteService.OnRepositoryChanged
    Private ReadOnly Property _pacienteRepository As IPacienteRepository

    Sub New(pacienteRepository As IPacienteRepository)
        _pacienteRepository = pacienteRepository
    End Sub

    Public Function ObtenerPacientes() As List(Of IPaciente) Implements IPacienteService.ObtenerPacientes
        Return _pacienteRepository.Pacientes.ToList()
    End Function

    Public Function AgregarPaciente(paciente As IPaciente) As Dictionary(Of String, Object) Implements IPacienteService.AgregarPaciente
        Dim response As New Response()

        If ObtenerPacientes.Find(Function(p) p.Cedula = paciente.Cedula) IsNot Nothing Then
            response.Message = "El paciente ya existe"
            response.Success = False
            response.Data = Nothing

            Return New Dictionary(Of String, Object) From {
                {"message", response.Message},
                {"success", response.Success},
                {"data", response.Data}
            }
        End If

        Dim pacienteAgregado = _pacienteRepository.AgregarPaciente(paciente)
        Return New Dictionary(Of String, Object) From {
            {"message", "Paciente agregado"},
            {"success", True},
            {"data", pacienteAgregado}
        }
    End Function

    Public Function ValidarCedula(cedula As String) As Boolean Implements IPacienteService.ValidarCedula
        Return REGEX_CEDULA.IsMatch(cedula)
    End Function

    Public Function ValidarCorreo(correo As String) As Boolean Implements IPacienteService.ValidarCorreo
        Return REGEX_CORREO.IsMatch(correo)
    End Function
End Class
