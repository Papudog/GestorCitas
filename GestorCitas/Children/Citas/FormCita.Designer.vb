<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormCita
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        components = New ComponentModel.Container()
        GroupBox1 = New GroupBox()
        PicturePaciente = New PictureBox()
        TextEdad = New TextBox()
        Label4 = New Label()
        TextNacimiento = New TextBox()
        Label3 = New Label()
        Label2 = New Label()
        TextNombre = New TextBox()
        Label1 = New Label()
        TextCedula = New TextBox()
        GroupBox2 = New GroupBox()
        TextDiagnostico = New TextBox()
        Label11 = New Label()
        ButtonEliminar = New Button()
        ButtonAgregar = New Button()
        TextMedicamento = New TextBox()
        Label10 = New Label()
        ListBoxMedicamentos = New ListBox()
        ComboConsultorio = New ComboBox()
        Label9 = New Label()
        DateTimeHora = New DateTimePicker()
        Label8 = New Label()
        DateTimeCita = New DateTimePicker()
        Label7 = New Label()
        ComboMedico = New ComboBox()
        Label6 = New Label()
        ComboEspecialidad = New ComboBox()
        Label5 = New Label()
        GroupBox3 = New GroupBox()
        TextIVA = New TextBox()
        Label14 = New Label()
        TextSubtotal = New TextBox()
        Label13 = New Label()
        TextTarjeta = New TextBox()
        Label12 = New Label()
        GroupBox4 = New GroupBox()
        RadioTarjeta = New RadioButton()
        RadioEfectivo = New RadioButton()
        ButtonCobro = New Button()
        ButtonLimpiar = New Button()
        ErrorProvider1 = New ErrorProvider(components)
        GroupBox1.SuspendLayout()
        CType(PicturePaciente, ComponentModel.ISupportInitialize).BeginInit()
        GroupBox2.SuspendLayout()
        GroupBox3.SuspendLayout()
        GroupBox4.SuspendLayout()
        CType(ErrorProvider1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Controls.Add(PicturePaciente)
        GroupBox1.Controls.Add(TextEdad)
        GroupBox1.Controls.Add(Label4)
        GroupBox1.Controls.Add(TextNacimiento)
        GroupBox1.Controls.Add(Label3)
        GroupBox1.Controls.Add(Label2)
        GroupBox1.Controls.Add(TextNombre)
        GroupBox1.Controls.Add(Label1)
        GroupBox1.Controls.Add(TextCedula)
        GroupBox1.Location = New Point(12, 12)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(611, 234)
        GroupBox1.TabIndex = 0
        GroupBox1.TabStop = False
        GroupBox1.Text = "Paciente"
        ' 
        ' PicturePaciente
        ' 
        PicturePaciente.Image = My.Resources.Resources.user_icon
        PicturePaciente.Location = New Point(329, 15)
        PicturePaciente.Name = "PicturePaciente"
        PicturePaciente.Size = New Size(276, 213)
        PicturePaciente.SizeMode = PictureBoxSizeMode.StretchImage
        PicturePaciente.TabIndex = 8
        PicturePaciente.TabStop = False
        ' 
        ' TextEdad
        ' 
        TextEdad.Enabled = False
        TextEdad.Location = New Point(158, 184)
        TextEdad.Name = "TextEdad"
        TextEdad.Size = New Size(146, 27)
        TextEdad.TabIndex = 3
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(158, 161)
        Label4.Name = "Label4"
        Label4.Size = New Size(43, 20)
        Label4.TabIndex = 6
        Label4.Text = "Edad"
        ' 
        ' TextNacimiento
        ' 
        TextNacimiento.Enabled = False
        TextNacimiento.Location = New Point(6, 184)
        TextNacimiento.Name = "TextNacimiento"
        TextNacimiento.Size = New Size(146, 27)
        TextNacimiento.TabIndex = 2
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(6, 161)
        Label3.Name = "Label3"
        Label3.Size = New Size(146, 20)
        Label3.TabIndex = 4
        Label3.Text = "Fecha de nacimiento"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(6, 94)
        Label2.Name = "Label2"
        Label2.Size = New Size(150, 20)
        Label2.TabIndex = 3
        Label2.Text = "Nombre del paciente"
        ' 
        ' TextNombre
        ' 
        TextNombre.Enabled = False
        TextNombre.Location = New Point(6, 117)
        TextNombre.Name = "TextNombre"
        TextNombre.Size = New Size(298, 27)
        TextNombre.TabIndex = 1
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(6, 32)
        Label1.Name = "Label1"
        Label1.Size = New Size(55, 20)
        Label1.TabIndex = 1
        Label1.Text = "Cedula"
        ' 
        ' TextCedula
        ' 
        TextCedula.Location = New Point(6, 55)
        TextCedula.Name = "TextCedula"
        TextCedula.Size = New Size(298, 27)
        TextCedula.TabIndex = 0
        ' 
        ' GroupBox2
        ' 
        GroupBox2.Controls.Add(TextDiagnostico)
        GroupBox2.Controls.Add(Label11)
        GroupBox2.Controls.Add(ButtonEliminar)
        GroupBox2.Controls.Add(ButtonAgregar)
        GroupBox2.Controls.Add(TextMedicamento)
        GroupBox2.Controls.Add(Label10)
        GroupBox2.Controls.Add(ListBoxMedicamentos)
        GroupBox2.Controls.Add(ComboConsultorio)
        GroupBox2.Controls.Add(Label9)
        GroupBox2.Controls.Add(DateTimeHora)
        GroupBox2.Controls.Add(Label8)
        GroupBox2.Controls.Add(DateTimeCita)
        GroupBox2.Controls.Add(Label7)
        GroupBox2.Controls.Add(ComboMedico)
        GroupBox2.Controls.Add(Label6)
        GroupBox2.Controls.Add(ComboEspecialidad)
        GroupBox2.Controls.Add(Label5)
        GroupBox2.Location = New Point(12, 252)
        GroupBox2.Name = "GroupBox2"
        GroupBox2.Size = New Size(611, 374)
        GroupBox2.TabIndex = 1
        GroupBox2.TabStop = False
        GroupBox2.Text = "Datos de la consulta"
        ' 
        ' TextDiagnostico
        ' 
        TextDiagnostico.Location = New Point(370, 196)
        TextDiagnostico.Multiline = True
        TextDiagnostico.Name = "TextDiagnostico"
        TextDiagnostico.Size = New Size(235, 172)
        TextDiagnostico.TabIndex = 10
        ' 
        ' Label11
        ' 
        Label11.AutoSize = True
        Label11.Location = New Point(370, 173)
        Label11.Name = "Label11"
        Label11.Size = New Size(168, 20)
        Label11.TabIndex = 21
        Label11.Text = "Diagnóstico del médico"
        ' 
        ' ButtonEliminar
        ' 
        ButtonEliminar.Location = New Point(6, 229)
        ButtonEliminar.Name = "ButtonEliminar"
        ButtonEliminar.Size = New Size(173, 29)
        ButtonEliminar.TabIndex = 18
        ButtonEliminar.Text = "Eliminar"
        ButtonEliminar.UseVisualStyleBackColor = True
        ' 
        ' ButtonAgregar
        ' 
        ButtonAgregar.Location = New Point(185, 229)
        ButtonAgregar.Name = "ButtonAgregar"
        ButtonAgregar.Size = New Size(162, 29)
        ButtonAgregar.TabIndex = 19
        ButtonAgregar.Text = "Agregar"
        ButtonAgregar.UseVisualStyleBackColor = True
        ' 
        ' TextMedicamento
        ' 
        TextMedicamento.Location = New Point(6, 196)
        TextMedicamento.Name = "TextMedicamento"
        TextMedicamento.Size = New Size(341, 27)
        TextMedicamento.TabIndex = 9
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.Location = New Point(6, 173)
        Label10.Name = "Label10"
        Label10.Size = New Size(176, 20)
        Label10.TabIndex = 17
        Label10.Text = "Medicamentos recetados"
        ' 
        ' ListBoxMedicamentos
        ' 
        ListBoxMedicamentos.FormattingEnabled = True
        ListBoxMedicamentos.Location = New Point(6, 264)
        ListBoxMedicamentos.Name = "ListBoxMedicamentos"
        ListBoxMedicamentos.Size = New Size(341, 104)
        ListBoxMedicamentos.TabIndex = 16
        ' 
        ' ComboConsultorio
        ' 
        ComboConsultorio.Enabled = False
        ComboConsultorio.FormattingEnabled = True
        ComboConsultorio.Location = New Point(185, 58)
        ComboConsultorio.Name = "ComboConsultorio"
        ComboConsultorio.Size = New Size(162, 28)
        ComboConsultorio.TabIndex = 6
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Location = New Point(185, 35)
        Label9.Name = "Label9"
        Label9.Size = New Size(162, 20)
        Label9.TabIndex = 14
        Label9.Text = "Número de consultorio"
        ' 
        ' DateTimeHora
        ' 
        DateTimeHora.CustomFormat = "hh:mm"
        DateTimeHora.Format = DateTimePickerFormat.Custom
        DateTimeHora.Location = New Point(370, 122)
        DateTimeHora.Name = "DateTimeHora"
        DateTimeHora.Size = New Size(235, 27)
        DateTimeHora.TabIndex = 8
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Location = New Point(370, 99)
        Label8.Name = "Label8"
        Label8.Size = New Size(138, 20)
        Label8.TabIndex = 12
        Label8.Text = "Hora de la consulta"
        ' 
        ' DateTimeCita
        ' 
        DateTimeCita.CustomFormat = "dd/MM/yyyy"
        DateTimeCita.Format = DateTimePickerFormat.Custom
        DateTimeCita.Location = New Point(370, 58)
        DateTimeCita.Name = "DateTimeCita"
        DateTimeCita.Size = New Size(235, 27)
        DateTimeCita.TabIndex = 7
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Location = New Point(370, 35)
        Label7.Name = "Label7"
        Label7.Size = New Size(112, 20)
        Label7.TabIndex = 9
        Label7.Text = "Fecha de la cita"
        ' 
        ' ComboMedico
        ' 
        ComboMedico.Enabled = False
        ComboMedico.FormattingEnabled = True
        ComboMedico.Location = New Point(6, 122)
        ComboMedico.Name = "ComboMedico"
        ComboMedico.Size = New Size(151, 28)
        ComboMedico.TabIndex = 5
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(6, 99)
        Label6.Name = "Label6"
        Label6.Size = New Size(59, 20)
        Label6.TabIndex = 5
        Label6.Text = "Médico"
        ' 
        ' ComboEspecialidad
        ' 
        ComboEspecialidad.FormattingEnabled = True
        ComboEspecialidad.Location = New Point(6, 58)
        ComboEspecialidad.Name = "ComboEspecialidad"
        ComboEspecialidad.Size = New Size(151, 28)
        ComboEspecialidad.TabIndex = 4
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(6, 35)
        Label5.Name = "Label5"
        Label5.Size = New Size(93, 20)
        Label5.TabIndex = 3
        Label5.Text = "Especialidad"
        ' 
        ' GroupBox3
        ' 
        GroupBox3.Controls.Add(TextIVA)
        GroupBox3.Controls.Add(Label14)
        GroupBox3.Controls.Add(TextSubtotal)
        GroupBox3.Controls.Add(Label13)
        GroupBox3.Controls.Add(TextTarjeta)
        GroupBox3.Controls.Add(Label12)
        GroupBox3.Controls.Add(GroupBox4)
        GroupBox3.Location = New Point(12, 632)
        GroupBox3.Name = "GroupBox3"
        GroupBox3.Size = New Size(611, 96)
        GroupBox3.TabIndex = 16
        GroupBox3.TabStop = False
        GroupBox3.Text = "Costo de la consulta"
        ' 
        ' TextIVA
        ' 
        TextIVA.Enabled = False
        TextIVA.Location = New Point(496, 55)
        TextIVA.Name = "TextIVA"
        TextIVA.Size = New Size(109, 27)
        TextIVA.TabIndex = 15
        ' 
        ' Label14
        ' 
        Label14.AutoSize = True
        Label14.Location = New Point(421, 58)
        Label14.Name = "Label14"
        Label14.Size = New Size(78, 20)
        Label14.TabIndex = 5
        Label14.Text = "Total (IVA)"
        ' 
        ' TextSubtotal
        ' 
        TextSubtotal.Enabled = False
        TextSubtotal.Location = New Point(496, 23)
        TextSubtotal.Name = "TextSubtotal"
        TextSubtotal.Size = New Size(109, 27)
        TextSubtotal.TabIndex = 14
        ' 
        ' Label13
        ' 
        Label13.AutoSize = True
        Label13.Location = New Point(421, 26)
        Label13.Name = "Label13"
        Label13.Size = New Size(65, 20)
        Label13.TabIndex = 3
        Label13.Text = "Subtotal"
        ' 
        ' TextTarjeta
        ' 
        TextTarjeta.Enabled = False
        TextTarjeta.Location = New Point(216, 55)
        TextTarjeta.Name = "TextTarjeta"
        TextTarjeta.Size = New Size(179, 27)
        TextTarjeta.TabIndex = 13
        ' 
        ' Label12
        ' 
        Label12.AutoSize = True
        Label12.Location = New Point(216, 26)
        Label12.Name = "Label12"
        Label12.Size = New Size(131, 20)
        Label12.TabIndex = 1
        Label12.Text = "Número de tarjeta"
        ' 
        ' GroupBox4
        ' 
        GroupBox4.Controls.Add(RadioTarjeta)
        GroupBox4.Controls.Add(RadioEfectivo)
        GroupBox4.Location = New Point(6, 26)
        GroupBox4.Name = "GroupBox4"
        GroupBox4.Size = New Size(183, 60)
        GroupBox4.TabIndex = 0
        GroupBox4.TabStop = False
        GroupBox4.Text = "Método de pago"
        ' 
        ' RadioTarjeta
        ' 
        RadioTarjeta.AutoSize = True
        RadioTarjeta.Location = New Point(102, 30)
        RadioTarjeta.Name = "RadioTarjeta"
        RadioTarjeta.Size = New Size(74, 24)
        RadioTarjeta.TabIndex = 12
        RadioTarjeta.TabStop = True
        RadioTarjeta.Text = "Tarjeta"
        RadioTarjeta.UseVisualStyleBackColor = True
        ' 
        ' RadioEfectivo
        ' 
        RadioEfectivo.AutoSize = True
        RadioEfectivo.Location = New Point(6, 30)
        RadioEfectivo.Name = "RadioEfectivo"
        RadioEfectivo.Size = New Size(83, 24)
        RadioEfectivo.TabIndex = 11
        RadioEfectivo.TabStop = True
        RadioEfectivo.Text = "Efectivo"
        RadioEfectivo.UseVisualStyleBackColor = True
        ' 
        ' ButtonCobro
        ' 
        ButtonCobro.Location = New Point(508, 744)
        ButtonCobro.Name = "ButtonCobro"
        ButtonCobro.Size = New Size(115, 29)
        ButtonCobro.TabIndex = 17
        ButtonCobro.Text = "Efectuar cobro"
        ButtonCobro.UseVisualStyleBackColor = True
        ' 
        ' ButtonLimpiar
        ' 
        ButtonLimpiar.Location = New Point(368, 744)
        ButtonLimpiar.Name = "ButtonLimpiar"
        ButtonLimpiar.Size = New Size(130, 29)
        ButtonLimpiar.TabIndex = 16
        ButtonLimpiar.Text = "Limpiar campos"
        ButtonLimpiar.UseVisualStyleBackColor = True
        ' 
        ' ErrorProvider1
        ' 
        ErrorProvider1.ContainerControl = Me
        ' 
        ' FormCita
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(633, 785)
        Controls.Add(ButtonLimpiar)
        Controls.Add(ButtonCobro)
        Controls.Add(GroupBox3)
        Controls.Add(GroupBox2)
        Controls.Add(GroupBox1)
        Name = "FormCita"
        Text = "Formulario de citas"
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        CType(PicturePaciente, ComponentModel.ISupportInitialize).EndInit()
        GroupBox2.ResumeLayout(False)
        GroupBox2.PerformLayout()
        GroupBox3.ResumeLayout(False)
        GroupBox3.PerformLayout()
        GroupBox4.ResumeLayout(False)
        GroupBox4.PerformLayout()
        CType(ErrorProvider1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label1 As Label
    Friend WithEvents TextCedula As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents TextNombre As TextBox
    Friend WithEvents TextEdad As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents TextNacimiento As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents PicturePaciente As PictureBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents ComboEspecialidad As ComboBox
    Friend WithEvents Label5 As Label
    Friend WithEvents DateTimeHora As DateTimePicker
    Friend WithEvents Label8 As Label
    Friend WithEvents DateTimeCita As DateTimePicker
    Friend WithEvents Label7 As Label
    Friend WithEvents ComboMedico As ComboBox
    Friend WithEvents Label6 As Label
    Friend WithEvents ComboConsultorio As ComboBox
    Friend WithEvents Label9 As Label
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents Label10 As Label
    Friend WithEvents ListBoxMedicamentos As ListBox
    Friend WithEvents ButtonEliminar As Button
    Friend WithEvents ButtonAgregar As Button
    Friend WithEvents TextMedicamento As TextBox
    Friend WithEvents TextDiagnostico As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents RadioTarjeta As RadioButton
    Friend WithEvents RadioEfectivo As RadioButton
    Friend WithEvents Label13 As Label
    Friend WithEvents TextTarjeta As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents TextIVA As TextBox
    Friend WithEvents Label14 As Label
    Friend WithEvents TextSubtotal As TextBox
    Friend WithEvents ButtonCobro As Button
    Friend WithEvents ButtonLimpiar As Button
    Friend WithEvents ErrorProvider1 As ErrorProvider
End Class
