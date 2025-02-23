<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class GridCita
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
        DataGridConsultas = New DataGridView()
        Label1 = New Label()
        CType(DataGridConsultas, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' DataGridConsultas
        ' 
        DataGridConsultas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridConsultas.Location = New Point(12, 12)
        DataGridConsultas.Name = "DataGridConsultas"
        DataGridConsultas.RowHeadersWidth = 51
        DataGridConsultas.Size = New Size(776, 400)
        DataGridConsultas.TabIndex = 0
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 9F, FontStyle.Italic)
        Label1.Location = New Point(12, 421)
        Label1.Name = "Label1"
        Label1.Size = New Size(335, 20)
        Label1.TabIndex = 1
        Label1.Text = "Doble click sobre una celda para imprimir consulta"
        ' 
        ' GridCita
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(Label1)
        Controls.Add(DataGridConsultas)
        Name = "GridCita"
        Text = "Listado de cobros realizados"
        CType(DataGridConsultas, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents DataGridConsultas As DataGridView
    Friend WithEvents Label1 As Label
End Class
