Imports GestorCitas.Application
Imports GestorCitas.Domain

Public Class FormPaciente
    Inherits Form
    Implements IForm

    Private ReadOnly Property _pacienteService As IPacienteService

    Sub New(pacienteService As IPacienteService)
        InitializeComponent()
        _pacienteService = pacienteService
    End Sub

    Private Sub FormPaciente_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TextEdad.Text = CalcularEdad().ToString()
    End Sub

    Private Sub ButtonAñadir_Click(sender As Object, e As EventArgs) Handles ButtonAñadir.Click
        If Not ValidarCampos() Then Return

        Dim response = _pacienteService.AgregarPaciente(New Paciente With {
            .Nombre = TextNombre.Text,
            .Cedula = TextCedula.Text,
            .FechaNacimiento = DateTimeNacimiento.Value,
            .Correo = TextCorreo.Text,
            .Direccion = TextDireccion.Text,
            .Foto = PictureBox1.Image
        })

        If response("success") Then
            MessageBox.Show(response("message"), "Creación exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information)
            LimpiarCampos()
        Else
            MessageBox.Show(response("message"), "Error al agregar paciente", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub ButtonImagen_Click(sender As Object, e As EventArgs) Handles ButtonImagen.Click
        OpenFileDialog1.Filter = "Archivos de imagen|*.jpg;*.jpeg;*.png"
        OpenFileDialog1.Title = "Seleccionar una imagen"

        If OpenFileDialog1.ShowDialog() = DialogResult.OK Then
            PictureBox1.Image = Image.FromFile(OpenFileDialog1.FileName)
        End If
    End Sub

    Public Function ValidarCampos() As Boolean Implements IForm.ValidarCampos
        ErrorProvider1.Clear()

        If TextNombre.Text.Length <= 0 Then
            ErrorProvider1.SetError(TextNombre, ErrorDictionary(IS_EMPTY))
            Return False
        End If

        If TextCedula.Text.Length <= 0 Then
            ErrorProvider1.SetError(TextCedula, ErrorDictionary(IS_EMPTY))
            Return False
        End If

        If Not _pacienteService.ValidarCedula(TextCedula.Text) Then
            ErrorProvider1.SetError(TextCedula, ErrorDictionary(INVALID_CEDULA))
            Return False
        End If

        If DateTimeNacimiento.Value >= DateTime.Now Then
            ErrorProvider1.SetError(DateTimeNacimiento, ErrorDictionary(INVALID_NACIMIENTO))
            Return False
        End If

        If Integer.Parse(TextEdad.Text) < 0 Then
            ErrorProvider1.SetError(DateTimeNacimiento, ErrorDictionary(INVALID_EDAD))
            Return False
        End If

        If TextCorreo.Text.Length <= 0 Then
            ErrorProvider1.SetError(TextCorreo, ErrorDictionary(IS_EMPTY))
            Return False
        End If

        If Not _pacienteService.ValidarCorreo(TextCorreo.Text) Then
            ErrorProvider1.SetError(TextCorreo, ErrorDictionary(INVALID_CORREO))
            Return False
        End If

        If TextTelefono.Text.Length < 8 Or TextTelefono.Text.Length > 8 Then
            ErrorProvider1.SetError(TextTelefono, ErrorDictionary(INVALID_TELEFONO))
            Return False
        End If

        If TextDireccion.Text.Length <= 0 Then
            ErrorProvider1.SetError(TextDireccion, ErrorDictionary(IS_EMPTY))
            Return False
        End If

        Return True
    End Function

    Public Sub LimpiarCampos() Implements IForm.LimpiarCampos
        TextNombre.Clear()
        TextCedula.Clear()
        DateTimeNacimiento.Value = DateTime.Now
        TextTelefono.Clear()
        TextCorreo.Clear()
        TextDireccion.Clear()
        PictureBox1.Image = My.Resources.Resources.user_icon
    End Sub

    Private Function CalcularEdad() As Integer
        Dim fechaNacimiento As Date = DateTimeNacimiento.Value
        Dim edad As Integer = DateTime.Now.Year - fechaNacimiento.Year

        If DateTime.Now.DayOfYear < fechaNacimiento.DayOfYear Then edad -= 1

        Return edad
    End Function

    Private Sub DateTimeNacimiento_ValueChanged(sender As Object, e As EventArgs) Handles DateTimeNacimiento.ValueChanged
        TextEdad.Text = CalcularEdad().ToString()
    End Sub

    Private Sub ButtonLimpiar_Click(sender As Object, e As EventArgs) Handles ButtonLimpiar.Click
        LimpiarCampos()
    End Sub
End Class