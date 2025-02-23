Imports GestorCitas.Domain

Public Interface IPacienteService
    Function ObtenerPacientes() As List(Of IPaciente)
    Function AgregarPaciente(paciente As IPaciente) As Dictionary(Of String, Object)
    Function ObtenerPacientePorCedula(cedula As String) As Dictionary(Of String, Object)
    Function ValidarCedula(cedula As String) As Boolean
    Function ValidarCorreo(correo As String) As Boolean
    Sub OnRepositoryChangedHandler()
    Event OnRepositoryChanged As Action
End Interface