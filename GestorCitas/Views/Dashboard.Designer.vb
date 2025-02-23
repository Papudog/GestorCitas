<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Dashboard
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
        MenuStrip1 = New MenuStrip()
        PacienteToolStripMenuItem = New ToolStripMenuItem()
        AñadirToolStripMenuItem = New ToolStripMenuItem()
        ListaToolStripMenuItem = New ToolStripMenuItem()
        ConsultaToolStripMenuItem = New ToolStripMenuItem()
        AñadirToolStripMenuItem1 = New ToolStripMenuItem()
        ListadoToolStripMenuItem = New ToolStripMenuItem()
        SistemaToolStripMenuItem = New ToolStripMenuItem()
        CerrarToolStripMenuItem = New ToolStripMenuItem()
        MenuStrip1.SuspendLayout()
        SuspendLayout()
        ' 
        ' MenuStrip1
        ' 
        MenuStrip1.ImageScalingSize = New Size(20, 20)
        MenuStrip1.Items.AddRange(New ToolStripItem() {PacienteToolStripMenuItem, ConsultaToolStripMenuItem, SistemaToolStripMenuItem})
        MenuStrip1.Location = New Point(0, 0)
        MenuStrip1.Name = "MenuStrip1"
        MenuStrip1.Size = New Size(982, 28)
        MenuStrip1.TabIndex = 1
        MenuStrip1.Text = "MenuStrip1"
        ' 
        ' PacienteToolStripMenuItem
        ' 
        PacienteToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {AñadirToolStripMenuItem, ListaToolStripMenuItem})
        PacienteToolStripMenuItem.Name = "PacienteToolStripMenuItem"
        PacienteToolStripMenuItem.Size = New Size(84, 24)
        PacienteToolStripMenuItem.Text = "Pacientes"
        ' 
        ' AñadirToolStripMenuItem
        ' 
        AñadirToolStripMenuItem.Name = "AñadirToolStripMenuItem"
        AñadirToolStripMenuItem.Size = New Size(140, 26)
        AñadirToolStripMenuItem.Text = "Añadir"
        ' 
        ' ListaToolStripMenuItem
        ' 
        ListaToolStripMenuItem.Name = "ListaToolStripMenuItem"
        ListaToolStripMenuItem.Size = New Size(140, 26)
        ListaToolStripMenuItem.Text = "Listado"
        ' 
        ' ConsultaToolStripMenuItem
        ' 
        ConsultaToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {AñadirToolStripMenuItem1, ListadoToolStripMenuItem})
        ConsultaToolStripMenuItem.Name = "ConsultaToolStripMenuItem"
        ConsultaToolStripMenuItem.Size = New Size(55, 24)
        ConsultaToolStripMenuItem.Text = "Citas"
        ' 
        ' AñadirToolStripMenuItem1
        ' 
        AñadirToolStripMenuItem1.Name = "AñadirToolStripMenuItem1"
        AñadirToolStripMenuItem1.Size = New Size(140, 26)
        AñadirToolStripMenuItem1.Text = "Añadir"
        ' 
        ' ListadoToolStripMenuItem
        ' 
        ListadoToolStripMenuItem.Name = "ListadoToolStripMenuItem"
        ListadoToolStripMenuItem.Size = New Size(140, 26)
        ListadoToolStripMenuItem.Text = "Listado"
        ' 
        ' SistemaToolStripMenuItem
        ' 
        SistemaToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {CerrarToolStripMenuItem})
        SistemaToolStripMenuItem.Name = "SistemaToolStripMenuItem"
        SistemaToolStripMenuItem.Size = New Size(75, 24)
        SistemaToolStripMenuItem.Text = "Sistema"
        ' 
        ' CerrarToolStripMenuItem
        ' 
        CerrarToolStripMenuItem.Name = "CerrarToolStripMenuItem"
        CerrarToolStripMenuItem.Size = New Size(132, 26)
        CerrarToolStripMenuItem.Text = "Cerrar"
        ' 
        ' Dashboard
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(982, 853)
        Controls.Add(MenuStrip1)
        IsMdiContainer = True
        MainMenuStrip = MenuStrip1
        Name = "Dashboard"
        Text = "Dashboard"
        MenuStrip1.ResumeLayout(False)
        MenuStrip1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents PacienteToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AñadirToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ListaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ConsultaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AñadirToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents ListadoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SistemaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CerrarToolStripMenuItem As ToolStripMenuItem
End Class
