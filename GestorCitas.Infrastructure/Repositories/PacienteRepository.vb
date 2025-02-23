Imports GestorCitas.Domain

Public Class PacienteRepository
    Implements IPacienteRepository

    Private ReadOnly Property _pacientes As ICollection(Of IPaciente) = New List(Of IPaciente)

    Public ReadOnly Property Pacientes As ICollection(Of IPaciente) Implements IPacienteRepository.Pacientes
        Get
            Return _pacientes
        End Get
    End Property

    Public Event OnPacientesChanged As Action(Of IPaciente) Implements IPacienteRepository.OnPacientesChanged

    Public Function AgregarPaciente(paciente As IPaciente) As IPaciente Implements IPacienteRepository.AgregarPaciente
        If paciente Is Nothing Then Return Nothing

        _pacientes.Add(paciente)
        RaiseEvent OnPacientesChanged(paciente)

        Return paciente
    End Function
End Class
