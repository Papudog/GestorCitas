Imports GestorCitas.Domain

Public Class ConsultaRepository
    Implements IConsultaRepository

    Property _consultas As ICollection(Of IConsulta) = New List(Of IConsulta)
    Public Event OnConsultasChanged As Action(Of IConsulta) Implements IConsultaRepository.OnConsultasChanged

    Public ReadOnly Property Consultas As ICollection(Of IConsulta) Implements IConsultaRepository.Consultas
        Get
            Return _consultas
        End Get
    End Property

    Public Function AgregarConsulta(consulta As IConsulta) As IConsulta Implements IConsultaRepository.AgregarConsulta
        If consulta Is Nothing Then Return Nothing

        _consultas.Add(consulta)
        RaiseEvent OnConsultasChanged(consulta)

        Return consulta
    End Function
End Class
