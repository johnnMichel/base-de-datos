<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        btnListar = New Button()
        dgvCategoria = New DataGridView()
        CType(dgvCategoria, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' btnListar
        ' 
        btnListar.Location = New Point(26, 32)
        btnListar.Name = "btnListar"
        btnListar.Size = New Size(75, 23)
        btnListar.TabIndex = 0
        btnListar.Text = "LISTAR"
        btnListar.UseVisualStyleBackColor = True
        ' 
        ' dgvCategoria
        ' 
        dgvCategoria.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvCategoria.Dock = DockStyle.Bottom
        dgvCategoria.Location = New Point(0, 165)
        dgvCategoria.Name = "dgvCategoria"
        dgvCategoria.Size = New Size(800, 285)
        dgvCategoria.TabIndex = 1
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(dgvCategoria)
        Controls.Add(btnListar)
        Name = "Form1"
        Text = "Form1"
        CType(dgvCategoria, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents btnListar As Button
    Friend WithEvents dgvCategoria As DataGridView

End Class
