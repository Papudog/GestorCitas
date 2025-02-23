Public Class Consulta
    Implements IConsulta

    Private Property _paciente As IPaciente
    Private Property _medico As IMedico
    Private Property _fechaConsulta As DateTime
    Private Property _horaConsulta As DateTime
    Private Property _diagnostico As String
    Private Property _medicamentos As ICollection(Of String)
    Private Property _metodoPago As String
    Private Property _numeroTarjeta As String
    Private Property _subtotal As Decimal

    Public Property Paciente As IPaciente Implements IConsulta.Paciente
        Get
            Return _paciente
        End Get
        Set(value As IPaciente)
            _paciente = value
        End Set
    End Property

    Public Property Medico As IMedico Implements IConsulta.Medico
        Get
            Return _medico
        End Get
        Set(value As IMedico)
            _medico = value
        End Set
    End Property

    Public Property FechaConsulta As Date Implements IConsulta.FechaConsulta
        Get
            Return _fechaConsulta
        End Get
        Set(value As Date)
            _fechaConsulta = value
        End Set
    End Property

    Public Property HoraConsulta As Date Implements IConsulta.HoraConsulta
        Get
            Return _horaConsulta
        End Get
        Set(value As Date)
            _horaConsulta = value
        End Set
    End Property

    Public Property Diagnostico As String Implements IConsulta.Diagnostico
        Get
            Return _diagnostico
        End Get
        Set(value As String)
            _diagnostico = value
        End Set
    End Property

    Public Property Medicamentos As ICollection(Of String) Implements IConsulta.Medicamentos
        Get
            Return _medicamentos
        End Get
        Set(value As ICollection(Of String))
            _medicamentos = value
        End Set
    End Property

    Public Property MetodoPago As String Implements IConsulta.MetodoPago
        Get
            Return _metodoPago
        End Get
        Set(value As String)
            _metodoPago = value
        End Set
    End Property

    Public Property NumeroTarjeta As String Implements IConsulta.NumeroTarjeta
        Get
            Return _numeroTarjeta
        End Get
        Set(value As String)
            _numeroTarjeta = value
        End Set
    End Property

    Public Property Subtotal As Decimal Implements IConsulta.Subtotal
        Get
            Return _subtotal
        End Get
        Set(value As Decimal)
            _subtotal = value
        End Set
    End Property

    Public ReadOnly Property TotalIVA As Decimal Implements IConsulta.TotalIVA
        Get
            Dim IVA As Decimal = Subtotal * 0.15
            Return Subtotal + IVA
        End Get
    End Property
End Class
