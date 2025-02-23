Imports GestorCitas.Application

Public Class GridCita
    Inherits Form
    Implements IGrid

    Private ReadOnly Property _consultaService As IConsultaService

    Sub New(consultaService As IConsultaService)
        InitializeComponent()

        _consultaService = consultaService
        AddHandler _consultaService.OnRepositoryChanged, AddressOf PoblarGrid
    End Sub

    Public Sub PoblarGrid() Implements IGrid.PoblarGrid
        Dim listaConsultas = _consultaService.ObtenerConsultas().Select(Function(c) New With {
        .Paciente = c.Paciente.Nombre,
        .Medico = c.Medico.Nombre,
        .Especialidad = c.Medico.Especialidad.Nombre,
        c.Medico.Consultorio,
        .Fecha = c.FechaConsulta,
        .Hora = c.HoraConsulta,
        c.Diagnostico,
        .Medicamentos = String.Join(", ", c.Medicamentos),
        c.MetodoPago,
        c.Subtotal,
        c.TotalIVA
    }).ToList()

        DataGridConsultas.DataSource = listaConsultas

        With DataGridConsultas
            .Columns("Paciente").HeaderText = "Nombre del paciente"
            .Columns("Medico").HeaderText = "Nombre del médico"
            .Columns("Especialidad").HeaderText = "Especialidad del médico"
            .Columns("Consultorio").HeaderText = "Consultorio"
            .Columns("Fecha").HeaderText = "Fecha de Consulta"
            .Columns("Hora").HeaderText = "Hora de la consulta"
            .Columns("Diagnostico").HeaderText = "Diagnóstico"
            .Columns("Medicamentos").HeaderText = "Medicamentos recetados"
            .Columns("MetodoPago").HeaderText = "Método de pago"
            .Columns("Subtotal").HeaderText = "Subtotal"
            .Columns("TotalIVA").HeaderText = "Total con IVA"
        End With
    End Sub

    Private Sub GridCita_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        PoblarGrid()
    End Sub

    Private Sub DataGridConsultas_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridConsultas.CellDoubleClick
        If e.RowIndex And e.ColumnIndex < 0 Then Return

        Dim fila As DataGridViewRow = DataGridConsultas.Rows(e.RowIndex)

        Dim mensaje As String = $"Información de la consulta:{Environment.NewLine}{Environment.NewLine}" &
                            $"Paciente: {fila.Cells("Paciente").Value}{Environment.NewLine}" &
                            $"Médico: {fila.Cells("Medico").Value}{Environment.NewLine}" &
                            $"Especialidad: {fila.Cells("Especialidad").Value}{Environment.NewLine}" &
                            $"Consultorio: {fila.Cells("Consultorio").Value}{Environment.NewLine}" &
                            $"Fecha: {fila.Cells("Fecha").Value}{Environment.NewLine}" &
                            $"Hora: {fila.Cells("Hora").Value}{Environment.NewLine}" &
                            $"Diagnóstico: {fila.Cells("Diagnostico").Value}{Environment.NewLine}" &
                            $"Medicamentos: {fila.Cells("Medicamentos").Value}{Environment.NewLine}" &
                            $"Método de pago: {fila.Cells("MetodoPago").Value}{Environment.NewLine}" &
                            $"Subtotal: {fila.Cells("Subtotal").Value}{Environment.NewLine}" &
                            $"Total con IVA: {fila.Cells("TotalIVA").Value}"

        MessageBox.Show(mensaje, "Detalles de la Consulta", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub
End Class