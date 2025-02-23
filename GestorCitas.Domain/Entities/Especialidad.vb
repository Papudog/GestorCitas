Public Class Especialidad
    Implements IEspecialidad

    Private Property _nombre As String
    Private Property _costo As Decimal

    Public Property Nombre As String Implements IEspecialidad.Nombre
        Get
            Return _nombre
        End Get
        Set(value As String)
            _nombre = value
        End Set
    End Property

    Public Property Costo As Decimal Implements IEspecialidad.Costo
        Get
            Return _costo
        End Get
        Set(value As Decimal)
            _costo = value
        End Set
    End Property
End Class
