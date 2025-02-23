Imports System.Runtime.Intrinsics.Wasm
Imports GestorCitas.Domain

Public Class PacienteRepository
    Implements IPacienteRepository

    Private ReadOnly Property _pacientes As ICollection(Of IPaciente) = New List(Of IPaciente) From {
        New Paciente With {
            .Nombre = "Manuel López",
            .Cedula = "001-120908-1003K",
            .FechaNacimiento = New DateTime(2008, 9, 12).ToString("dd/MM/yyyy"),
            .Telefono = "88888888",
            .Direccion = "Managua",
            .Correo = "papu@gmail.com",
            .Foto = Nothing
        }
    }

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

    Public Function ObtenerPacientePorCedula(cedula As String) As IPaciente Implements IPacienteRepository.ObtenerPacientePorCedula
        Dim paciente As IPaciente = _pacientes.ToList().Find(Function(p) p.Cedula = cedula)

        If paciente Is Nothing Then Return Nothing

        Return paciente
    End Function
End Class
