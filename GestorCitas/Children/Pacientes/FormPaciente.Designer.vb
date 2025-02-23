<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormPaciente
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
        Label7 = New Label()
        TextTelefono = New TextBox()
        Label6 = New Label()
        TextDireccion = New TextBox()
        Label5 = New Label()
        TextCorreo = New TextBox()
        TextEdad = New TextBox()
        Label4 = New Label()
        DateTimeNacimiento = New DateTimePicker()
        Label3 = New Label()
        Label2 = New Label()
        TextCedula = New TextBox()
        Label1 = New Label()
        TextNombre = New TextBox()
        GroupBox2 = New GroupBox()
        PictureBox1 = New PictureBox()
        ButtonAñadir = New Button()
        ButtonLimpiar = New Button()
        ButtonImagen = New Button()
        ErrorProvider1 = New ErrorProvider(components)
        OpenFileDialog1 = New OpenFileDialog()
        GroupBox1.SuspendLayout()
        GroupBox2.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        CType(ErrorProvider1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Controls.Add(Label7)
        GroupBox1.Controls.Add(TextTelefono)
        GroupBox1.Controls.Add(Label6)
        GroupBox1.Controls.Add(TextDireccion)
        GroupBox1.Controls.Add(Label5)
        GroupBox1.Controls.Add(TextCorreo)
        GroupBox1.Controls.Add(TextEdad)
        GroupBox1.Controls.Add(Label4)
        GroupBox1.Controls.Add(DateTimeNacimiento)
        GroupBox1.Controls.Add(Label3)
        GroupBox1.Controls.Add(Label2)
        GroupBox1.Controls.Add(TextCedula)
        GroupBox1.Controls.Add(Label1)
        GroupBox1.Controls.Add(TextNombre)
        GroupBox1.Location = New Point(12, 30)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(310, 497)
        GroupBox1.TabIndex = 0
        GroupBox1.TabStop = False
        GroupBox1.Text = "Datos del paciente"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Location = New Point(6, 311)
        Label7.Name = "Label7"
        Label7.Size = New Size(67, 20)
        Label7.TabIndex = 14
        Label7.Text = "Teléfono"
        ' 
        ' TextTelefono
        ' 
        TextTelefono.Location = New Point(6, 334)
        TextTelefono.Name = "TextTelefono"
        TextTelefono.Size = New Size(295, 27)
        TextTelefono.TabIndex = 13
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(6, 376)
        Label6.Name = "Label6"
        Label6.Size = New Size(72, 20)
        Label6.TabIndex = 12
        Label6.Text = "Dirección"
        ' 
        ' TextDireccion
        ' 
        TextDireccion.Location = New Point(6, 399)
        TextDireccion.Multiline = True
        TextDireccion.Name = "TextDireccion"
        TextDireccion.Size = New Size(295, 84)
        TextDireccion.TabIndex = 11
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(6, 249)
        Label5.Name = "Label5"
        Label5.Size = New Size(132, 20)
        Label5.TabIndex = 10
        Label5.Text = "Correo electrónico"
        ' 
        ' TextCorreo
        ' 
        TextCorreo.Location = New Point(6, 272)
        TextCorreo.Name = "TextCorreo"
        TextCorreo.Size = New Size(295, 27)
        TextCorreo.TabIndex = 9
        ' 
        ' TextEdad
        ' 
        TextEdad.Enabled = False
        TextEdad.Location = New Point(179, 201)
        TextEdad.Name = "TextEdad"
        TextEdad.Size = New Size(125, 27)
        TextEdad.TabIndex = 8
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(179, 178)
        Label4.Name = "Label4"
        Label4.Size = New Size(43, 20)
        Label4.TabIndex = 7
        Label4.Text = "Edad"
        ' 
        ' DateTimeNacimiento
        ' 
        DateTimeNacimiento.CustomFormat = "dd/MM/yyyy"
        DateTimeNacimiento.Format = DateTimePickerFormat.Custom
        DateTimeNacimiento.Location = New Point(6, 201)
        DateTimeNacimiento.Name = "DateTimeNacimiento"
        DateTimeNacimiento.Size = New Size(150, 27)
        DateTimeNacimiento.TabIndex = 6
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(6, 178)
        Label3.Name = "Label3"
        Label3.Size = New Size(146, 20)
        Label3.TabIndex = 5
        Label3.Text = "Fecha de nacimiento"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(6, 107)
        Label2.Name = "Label2"
        Label2.Size = New Size(55, 20)
        Label2.TabIndex = 3
        Label2.Text = "Cédula"
        ' 
        ' TextCedula
        ' 
        TextCedula.Location = New Point(6, 130)
        TextCedula.Name = "TextCedula"
        TextCedula.Size = New Size(295, 27)
        TextCedula.TabIndex = 2
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(6, 38)
        Label1.Name = "Label1"
        Label1.Size = New Size(150, 20)
        Label1.TabIndex = 1
        Label1.Text = "Nombre del paciente"
        ' 
        ' TextNombre
        ' 
        TextNombre.Location = New Point(6, 61)
        TextNombre.Name = "TextNombre"
        TextNombre.Size = New Size(295, 27)
        TextNombre.TabIndex = 0
        ' 
        ' GroupBox2
        ' 
        GroupBox2.Controls.Add(PictureBox1)
        GroupBox2.Location = New Point(337, 30)
        GroupBox2.Name = "GroupBox2"
        GroupBox2.Size = New Size(250, 269)
        GroupBox2.TabIndex = 1
        GroupBox2.TabStop = False
        GroupBox2.Text = "Foto del paciente"
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = My.Resources.Resources.user_icon
        PictureBox1.Location = New Point(6, 26)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(238, 237)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 0
        PictureBox1.TabStop = False
        ' 
        ' ButtonAñadir
        ' 
        ButtonAñadir.Location = New Point(462, 498)
        ButtonAñadir.Name = "ButtonAñadir"
        ButtonAñadir.Size = New Size(125, 29)
        ButtonAñadir.TabIndex = 2
        ButtonAñadir.Text = "Añadir paciente"
        ButtonAñadir.UseVisualStyleBackColor = True
        ' 
        ' ButtonLimpiar
        ' 
        ButtonLimpiar.Location = New Point(462, 463)
        ButtonLimpiar.Name = "ButtonLimpiar"
        ButtonLimpiar.Size = New Size(125, 29)
        ButtonLimpiar.TabIndex = 3
        ButtonLimpiar.Text = "Limpiar campos"
        ButtonLimpiar.UseVisualStyleBackColor = True
        ' 
        ' ButtonImagen
        ' 
        ButtonImagen.Location = New Point(462, 308)
        ButtonImagen.Name = "ButtonImagen"
        ButtonImagen.Size = New Size(125, 29)
        ButtonImagen.TabIndex = 4
        ButtonImagen.Text = "Cargar imagen"
        ButtonImagen.UseVisualStyleBackColor = True
        ' 
        ' ErrorProvider1
        ' 
        ErrorProvider1.ContainerControl = Me
        ' 
        ' OpenFileDialog1
        ' 
        OpenFileDialog1.FileName = "OpenFileDialog1"
        ' 
        ' FormPaciente
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(599, 543)
        Controls.Add(ButtonImagen)
        Controls.Add(ButtonLimpiar)
        Controls.Add(ButtonAñadir)
        Controls.Add(GroupBox2)
        Controls.Add(GroupBox1)
        Name = "FormPaciente"
        Text = "Formulario del paciente"
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        GroupBox2.ResumeLayout(False)
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        CType(ErrorProvider1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents TextEdad As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents DateTimeNacimiento As DateTimePicker
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents TextCedula As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents TextNombre As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents TextTelefono As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents TextDireccion As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents TextCorreo As TextBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents ButtonAñadir As Button
    Friend WithEvents ButtonLimpiar As Button
    Friend WithEvents ButtonImagen As Button
    Friend WithEvents ErrorProvider1 As ErrorProvider
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
End Class
