<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class GridPaciente
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
        DataGridPaciente = New DataGridView()
        CType(DataGridPaciente, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' DataGridPaciente
        ' 
        DataGridPaciente.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridPaciente.Location = New Point(12, 12)
        DataGridPaciente.Name = "DataGridPaciente"
        DataGridPaciente.RowHeadersWidth = 51
        DataGridPaciente.Size = New Size(651, 365)
        DataGridPaciente.TabIndex = 0
        ' 
        ' GridPaciente
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(675, 389)
        Controls.Add(DataGridPaciente)
        Name = "GridPaciente"
        Text = "Listado de pacientes"
        CType(DataGridPaciente, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents DataGridPaciente As DataGridView
End Class
