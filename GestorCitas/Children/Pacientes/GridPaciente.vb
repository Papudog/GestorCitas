Imports GestorCitas.Application

Public Class GridPaciente
    Inherits Form
    Implements IGrid

    Private ReadOnly Property _pacienteService As IPacienteService

    Sub New(pacienteService As IPacienteService)
        InitializeComponent()

        _pacienteService = pacienteService
        AddHandler _pacienteService.OnRepositoryChanged, AddressOf PoblarGrid
    End Sub

    Private Sub GridPaciente_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        PoblarGrid()
    End Sub

    Public Sub PoblarGrid() Implements IGrid.PoblarGrid
        DataGridPaciente.DataSource = _pacienteService.ObtenerPacientes().Select(Function(p) New With {
            p.Nombre,
            p.Cedula,
            p.Telefono,
            p.Correo,
            p.Edad,
            p.Direccion
        }).ToList()
    End Sub
End Class