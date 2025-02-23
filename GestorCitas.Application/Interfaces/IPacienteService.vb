Imports GestorCitas.Domain

Public Interface IPacienteService
    Function ObtenerPacientes() As List(Of IPaciente)
    Function AgregarPaciente(paciente As IPaciente) As Dictionary(Of String, Object)
    Function ValidarCedula(cedula As String) As Boolean
    Function ValidarCorreo(correo As String) As Boolean
    Event OnRepositoryChanged As Action
End Interface