Imports GestorCitas.Domain

Public Interface IMedicoService
    Function ObtenerEspecialidades() As IEspecialidad()
    Function ObtenerMedicos() As List(Of IMedico)
End Interface
