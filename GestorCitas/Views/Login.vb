Public Class Login
    Inherits Form
    Implements IForm

    Private ReadOnly Property admin As String = "admin"
    Private ReadOnly Property contraseña As String = "1234"

    Private Sub ButtonLogin_Click(sender As Object, e As EventArgs) Handles ButtonLogin.Click
        If Not ValidarCampos() Then Return

        If TextUsuario.Text = admin And TextContraseña.Text = contraseña Then
            Dim form As New Dashboard()
            form.Show()
            Me.Hide()
        Else
            MessageBox.Show(ErrorDictionary(INVALID_USER), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Public Function ValidarCampos() As Boolean Implements IForm.ValidarCampos
        ErrorProvider1.Clear()

        If TextUsuario.Text.Length = 0 Then
            ErrorProvider1.SetError(TextUsuario, ErrorDictionary(IS_EMPTY))
            Return False
        End If

        If TextContraseña.Text.Length = 0 Then
            ErrorProvider1.SetError(TextContraseña, ErrorDictionary(IS_EMPTY))
            Return False
        End If

        Return True
    End Function

    Public Sub LimpiarCampos() Implements IForm.LimpiarCampos
        TextUsuario.Clear()
        TextContraseña.Clear()
    End Sub
End Class
