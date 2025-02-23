<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Login
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        components = New ComponentModel.Container()
        Panel1 = New Panel()
        Label4 = New Label()
        PictureBox1 = New PictureBox()
        Label1 = New Label()
        TextUsuario = New TextBox()
        Label2 = New Label()
        Label3 = New Label()
        TextContraseña = New TextBox()
        GroupBox1 = New GroupBox()
        ButtonLogin = New Button()
        ErrorProvider1 = New ErrorProvider(components)
        Panel1.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        GroupBox1.SuspendLayout()
        CType(ErrorProvider1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.LightSkyBlue
        Panel1.Controls.Add(Label4)
        Panel1.Controls.Add(PictureBox1)
        Panel1.Location = New Point(385, 0)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(391, 458)
        Panel1.TabIndex = 0
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI", 16F, FontStyle.Bold)
        Label4.ForeColor = Color.FromArgb(CByte(0), CByte(63), CByte(151))
        Label4.Location = New Point(106, 67)
        Label4.Name = "Label4"
        Label4.Size = New Size(207, 37)
        Label4.TabIndex = 6
        Label4.Text = "Gestor de citas"
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = My.Resources.Resources.serpiente_medicina
        PictureBox1.Location = New Point(79, 120)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(247, 256)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 0
        PictureBox1.TabStop = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 14F)
        Label1.Location = New Point(105, 69)
        Label1.Name = "Label1"
        Label1.Size = New Size(134, 32)
        Label1.TabIndex = 1
        Label1.Text = "Bienvenido"
        ' 
        ' TextUsuario
        ' 
        TextUsuario.Location = New Point(6, 64)
        TextUsuario.Name = "TextUsuario"
        TextUsuario.Size = New Size(228, 27)
        TextUsuario.TabIndex = 2
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(6, 41)
        Label2.Name = "Label2"
        Label2.Size = New Size(59, 20)
        Label2.TabIndex = 3
        Label2.Text = "Usuario"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(6, 107)
        Label3.Name = "Label3"
        Label3.Size = New Size(83, 20)
        Label3.TabIndex = 5
        Label3.Text = "Contraseña"
        ' 
        ' TextContraseña
        ' 
        TextContraseña.Location = New Point(6, 130)
        TextContraseña.Name = "TextContraseña"
        TextContraseña.PasswordChar = "*"c
        TextContraseña.Size = New Size(228, 27)
        TextContraseña.TabIndex = 4
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Controls.Add(Label2)
        GroupBox1.Controls.Add(Label3)
        GroupBox1.Controls.Add(TextUsuario)
        GroupBox1.Controls.Add(TextContraseña)
        GroupBox1.Location = New Point(58, 139)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(243, 179)
        GroupBox1.TabIndex = 6
        GroupBox1.TabStop = False
        GroupBox1.Text = "Credenciales"
        ' 
        ' ButtonLogin
        ' 
        ButtonLogin.Location = New Point(111, 347)
        ButtonLogin.Name = "ButtonLogin"
        ButtonLogin.Size = New Size(123, 29)
        ButtonLogin.TabIndex = 7
        ButtonLogin.Text = "Iniciar sesión"
        ButtonLogin.UseVisualStyleBackColor = True
        ' 
        ' ErrorProvider1
        ' 
        ErrorProvider1.ContainerControl = Me
        ' 
        ' Login
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(767, 450)
        Controls.Add(ButtonLogin)
        Controls.Add(GroupBox1)
        Controls.Add(Label1)
        Controls.Add(Panel1)
        Name = "Login"
        Text = "Form1"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        CType(ErrorProvider1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents TextUsuario As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents TextContraseña As TextBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents ButtonLogin As Button
    Friend WithEvents ErrorProvider1 As ErrorProvider

End Class
