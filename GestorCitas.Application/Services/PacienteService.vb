Imports GestorCitas.Domain
Imports GestorCitas.Infrastructure

Public Class PacienteService
    Implements IPacienteService

    Public Event OnRepositoryChanged As Action Implements IPacienteService.OnRepositoryChanged
    Private ReadOnly Property _pacienteRepository As IPacienteRepository

    Sub New(pacienteRepository As IPacienteRepository)
        _pacienteRepository = pacienteRepository
        AddHandler _pacienteRepository.OnPacientesChanged, AddressOf OnRepositoryChangedHandler
    End Sub

    Public Sub OnRepositoryChangedHandler() Implements IPacienteService.OnRepositoryChangedHandler
        RaiseEvent OnRepositoryChanged()
    End Sub

    Public Function ObtenerPacientes() As List(Of IPaciente) Implements IPacienteService.ObtenerPacientes
        Return _pacienteRepository.Pacientes.ToList()
    End Function

    Public Function AgregarPaciente(paciente As IPaciente) As Dictionary(Of String, Object) Implements IPacienteService.AgregarPaciente
        Dim pacienteEncontrado As IPaciente = _pacienteRepository.ObtenerPacientePorCedula(paciente.Cedula)

        If pacienteEncontrado IsNot Nothing Then Return Respuesta.Crear("El paciente ya existe", False, Nothing)

        Return Respuesta.Crear("Paciente agregado", True, _pacienteRepository.AgregarPaciente(paciente))
    End Function

    Public Function ValidarCedula(cedula As String) As Boolean Implements IPacienteService.ValidarCedula
        Return REGEX_CEDULA.IsMatch(cedula)
    End Function

    Public Function ValidarCorreo(correo As String) As Boolean Implements IPacienteService.ValidarCorreo
        Return REGEX_CORREO.IsMatch(correo)
    End Function

    Public Function ObtenerPacientePorCedula(cedula As String) As Dictionary(Of String, Object) Implements IPacienteService.ObtenerPacientePorCedula
        Dim paciente As IPaciente = _pacienteRepository.ObtenerPacientePorCedula(cedula)

        If paciente Is Nothing Then Return Respuesta.Crear("Paciente no encontrado", False, Nothing)

        Return Respuesta.Crear("Paciente encontrado", True, paciente)
    End Function
End Class