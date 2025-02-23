Imports GestorCitas.Domain

Public Interface IMedicoService
    Function ObtenerEspecialidades() As IEspecialidad()
    Function ObtenerMedicos() As List(Of IMedico)
    Function ObtenerConsultorios() As Integer()
End Interface
