Imports GestorCitas.Domain

Public Interface IConsultaService
    Function ObtenerConsultas() As List(Of IConsulta)
    Function AgregarConsulta(paciente As IConsulta) As Dictionary(Of String, Object)
    Sub OnRepositoryChangedHandler()
    Event OnRepositoryChanged As Action
End Interface
