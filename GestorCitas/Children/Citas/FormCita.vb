Imports GestorCitas.Application
Imports GestorCitas.Domain

Public Class FormCita
    Inherits Form
    Implements IForm

    Private ReadOnly _pacienteService As IPacienteService
    Private ReadOnly _medicoService As IMedicoService
    Private ReadOnly _consultaService As IConsultaService
    Private _paciente As IPaciente

    Sub New(pacienteServie As IPacienteService, medicoService As IMedicoService, consultaService As IConsultaService)
        InitializeComponent()

        _pacienteService = pacienteServie
        _medicoService = medicoService
        _consultaService = consultaService
    End Sub

    Private Sub FormCita_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ComboEspecialidad.DataSource = _medicoService.ObtenerEspecialidades()
        ComboEspecialidad.DisplayMember = "Nombre"

        RadioEfectivo.Checked = True
    End Sub

    Private Sub ButtonCobro_Click(sender As Object, e As EventArgs) Handles ButtonCobro.Click
        If Not ValidarCampos() Then Return

        Dim response = _consultaService.AgregarConsulta(New Consulta With {
            .Paciente = _paciente,
            .Medico = CType(ComboMedico.SelectedItem, IMedico),
            .FechaConsulta = DateTimeCita.Value,
            .HoraConsulta = DateTimeHora.Value,
            .Diagnostico = TextDiagnostico.Text,
            .Medicamentos = ListBoxMedicamentos.Items.Cast(Of String).ToList(),
            .NumeroTarjeta = If(RadioEfectivo.Checked, "", TextTarjeta.Text),
            .MetodoPago = If(RadioEfectivo.Checked, "Efectivo", "Tarjeta"),
            .Subtotal = TextSubtotal.Text
        })

        If response(SUCCESS) Then
            MessageBox.Show(response(MESSAGE), "Cobro exitoso", MessageBoxButtons.OK, MessageBoxIcon.Information)
            LimpiarCampos()
        Else
            MessageBox.Show(response(MESSAGE), "Error al efectuar el cobro", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub ButtonLimpiar_Click(sender As Object, e As EventArgs) Handles ButtonLimpiar.Click
        LimpiarCampos()
    End Sub

    Public Function ValidarCampos() As Boolean Implements IForm.ValidarCampos
        ErrorProvider1.Clear()

        If _paciente Is Nothing Then
            ErrorProvider1.SetError(TextCedula, "Ingrese una cédula válida")
            Return False
        End If

        If ComboEspecialidad.SelectedItem Is Nothing Then
            ErrorProvider1.SetError(ComboEspecialidad, "Seleccione una especialidad")
            Return False
        End If

        If ComboMedico.SelectedItem Is Nothing Then
            ErrorProvider1.SetError(ComboMedico, "Seleccione un médico")
            Return False
        End If

        If ComboConsultorio.SelectedItem Is Nothing Then
            ErrorProvider1.SetError(ComboConsultorio, "Seleccione un consultorio")
            Return False
        End If

        If DateTimeCita.Value.Date > DateTime.Today Then
            ErrorProvider1.SetError(DateTimeCita, "Ingrese una fecha")
            Return False
        End If

        If String.IsNullOrWhiteSpace(TextDiagnostico.Text) Then
            ErrorProvider1.SetError(TextDiagnostico, "Ingrese un diagnóstico")
            Return False
        End If

        If RadioTarjeta.Checked AndAlso String.IsNullOrWhiteSpace(TextTarjeta.Text) Then
            ErrorProvider1.SetError(TextTarjeta, "Ingrese un número de tarjeta")
            Return False
        End If

        Return True
    End Function

    Public Sub LimpiarCampos() Implements IForm.LimpiarCampos
        _paciente = Nothing
        TextCedula.Clear()
        TextNombre.Clear()
        TextNacimiento.Clear()
        TextEdad.Clear()
        PicturePaciente.Image = My.Resources.user_icon

        ComboEspecialidad.SelectedIndex = -1
        ComboMedico.SelectedIndex = -1
        ComboConsultorio.SelectedIndex = -1

        TextDiagnostico.Clear()
        TextMedicamento.Clear()
        ListBoxMedicamentos.Items.Clear()
        DateTimeCita.Value = DateTime.Now
        DateTimeHora.Value = DateTime.Now
        RadioEfectivo.Checked = True
        TextSubtotal.Clear()
        TextIVA.Clear()
    End Sub

    Private Sub TextCedula_KeyDown(sender As Object, e As KeyEventArgs) Handles TextCedula.KeyDown
        If e.KeyValue <> 13 Then Return

        _paciente = _pacienteService.ObtenerPacientePorCedula(TextCedula.Text)(DATA)

        If _paciente Is Nothing Then
            MessageBox.Show("Paciente no encontrado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        TextNombre.Text = _paciente.Nombre
        TextCedula.Text = _paciente.Cedula
        TextNacimiento.Text = _paciente.FechaNacimiento.Date
        TextEdad.Text = _paciente.Edad
        PicturePaciente.Image = If(_paciente.Foto, My.Resources.user_icon)
    End Sub

    Private Sub ComboEspecialidad_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboEspecialidad.SelectedIndexChanged
        If ComboEspecialidad.SelectedIndex = -1 Then
            ComboMedico.DataSource = Nothing
            ComboMedico.Enabled = False
            Return
        End If

        Dim especialidad As IEspecialidad = CType(ComboEspecialidad.SelectedItem, IEspecialidad)
        Dim medicos As List(Of IMedico) = _medicoService.ObtenerMedicos()

        ComboMedico.DataSource = medicos.FindAll(Function(m) m.Especialidad.Nombre = especialidad.Nombre)
        ComboMedico.DisplayMember = "Nombre"
        ComboMedico.Enabled = True

        Dim iva As Decimal = especialidad.Costo * 0.15
        TextSubtotal.Text = especialidad.Costo
        TextIVA.Text = iva + especialidad.Costo
    End Sub

    Private Sub ComboMedico_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboMedico.SelectedIndexChanged
        If ComboMedico.SelectedIndex = -1 Then
            ComboConsultorio.DataSource = Nothing
            ComboConsultorio.Enabled = False
            Return
        End If

        Dim medico As IMedico = CType(ComboMedico.SelectedItem, IMedico)

        ComboConsultorio.DataSource = New List(Of Integer) From {medico.Consultorio}
        ComboConsultorio.Enabled = True
    End Sub

    Private Sub ButtonAgregar_Click(sender As Object, e As EventArgs) Handles ButtonAgregar.Click
        If String.IsNullOrWhiteSpace(TextMedicamento.Text) Then Return
        ListBoxMedicamentos.Items.Add(TextMedicamento.Text)
        TextMedicamento.Text = ""
    End Sub

    Private Sub ButtonEliminar_Click(sender As Object, e As EventArgs) Handles ButtonEliminar.Click
        If ListBoxMedicamentos.SelectedIndex = -1 Then Return
        ListBoxMedicamentos.Items.RemoveAt(ListBoxMedicamentos.SelectedIndex)
    End Sub

    Private Sub RadioEfectivo_CheckedChanged(sender As Object, e As EventArgs) Handles RadioEfectivo.CheckedChanged
        If RadioEfectivo.Checked Then
            TextTarjeta.Enabled = False
            TextTarjeta.Clear()
        Else
            TextTarjeta.Enabled = True
        End If
    End Sub
End Class