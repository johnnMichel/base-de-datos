<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class IUCategoria
    Inherits IUBase


    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        components = New ComponentModel.Container()
        TabControlDatos = New TabControl()
        tpListado = New TabPage()
        dgvListado = New DataGridView()
        gbBuscarPor = New GroupBox()
        btnBuscar = New Button()
        txtCriterio = New TextBox()
        lbCriterioBusqueda = New Label()
        tpRegistro = New TabPage()
        gbEstado = New GroupBox()
        rbtnInactivo = New RadioButton()
        rbtnActivo = New RadioButton()
        txtDescripcion = New TextBox()
        txtNombre = New TextBox()
        txtIdCategoria = New TextBox()
        lblDescripcion = New Label()
        lblNombre = New Label()
        lblIdCategoria = New Label()
        epError = New ErrorProvider(components)
        TabControlDatos.SuspendLayout()
        tpListado.SuspendLayout()
        CType(dgvListado, ComponentModel.ISupportInitialize).BeginInit()
        gbBuscarPor.SuspendLayout()
        tpRegistro.SuspendLayout()
        gbEstado.SuspendLayout()
        CType(epError, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' TabControlDatos
        ' 
        TabControlDatos.Controls.Add(tpListado)
        TabControlDatos.Controls.Add(tpRegistro)
        TabControlDatos.Location = New Point(12, 3)
        TabControlDatos.Name = "TabControlDatos"
        TabControlDatos.SelectedIndex = 0
        TabControlDatos.Size = New Size(776, 368)
        TabControlDatos.TabIndex = 4
        ' 
        ' tpListado
        ' 
        tpListado.Controls.Add(dgvListado)
        tpListado.Controls.Add(gbBuscarPor)
        tpListado.Location = New Point(4, 24)
        tpListado.Name = "tpListado"
        tpListado.Padding = New Padding(3)
        tpListado.Size = New Size(768, 340)
        tpListado.TabIndex = 0
        tpListado.Text = "LISTADO"
        tpListado.UseVisualStyleBackColor = True
        ' 
        ' dgvListado
        ' 
        dgvListado.BackgroundColor = SystemColors.GradientActiveCaption
        dgvListado.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvListado.Dock = DockStyle.Bottom
        dgvListado.Location = New Point(3, 71)
        dgvListado.Name = "dgvListado"
        dgvListado.RowTemplate.Height = 25
        dgvListado.Size = New Size(762, 266)
        dgvListado.TabIndex = 5
        ' 
        ' gbBuscarPor
        ' 
        gbBuscarPor.Controls.Add(btnBuscar)
        gbBuscarPor.Controls.Add(txtCriterio)
        gbBuscarPor.Controls.Add(lbCriterioBusqueda)
        gbBuscarPor.Dock = DockStyle.Top
        gbBuscarPor.Location = New Point(3, 3)
        gbBuscarPor.Name = "gbBuscarPor"
        gbBuscarPor.Size = New Size(762, 61)
        gbBuscarPor.TabIndex = 0
        gbBuscarPor.TabStop = False
        gbBuscarPor.Text = "Buscar Por"
        ' 
        ' btnBuscar
        ' 
        btnBuscar.Location = New Point(276, 26)
        btnBuscar.Name = "btnBuscar"
        btnBuscar.Size = New Size(75, 23)
        btnBuscar.TabIndex = 3
        btnBuscar.Text = "BUSCAR"
        btnBuscar.UseVisualStyleBackColor = True
        ' 
        ' txtCriterio
        ' 
        txtCriterio.BackColor = SystemColors.InactiveCaption
        txtCriterio.Location = New Point(131, 27)
        txtCriterio.Name = "txtCriterio"
        txtCriterio.Size = New Size(100, 23)
        txtCriterio.TabIndex = 2
        ' 
        ' lbCriterioBusqueda
        ' 
        lbCriterioBusqueda.AutoSize = True
        lbCriterioBusqueda.Location = New Point(21, 30)
        lbCriterioBusqueda.Name = "lbCriterioBusqueda"
        lbCriterioBusqueda.Size = New Size(104, 15)
        lbCriterioBusqueda.TabIndex = 0
        lbCriterioBusqueda.Text = "Criterio busqueda:"
        ' 
        ' tpRegistro
        ' 
        tpRegistro.BackColor = Color.LightSteelBlue
        tpRegistro.Controls.Add(gbEstado)
        tpRegistro.Controls.Add(txtDescripcion)
        tpRegistro.Controls.Add(txtNombre)
        tpRegistro.Controls.Add(txtIdCategoria)
        tpRegistro.Controls.Add(lblDescripcion)
        tpRegistro.Controls.Add(lblNombre)
        tpRegistro.Controls.Add(lblIdCategoria)
        tpRegistro.Location = New Point(4, 24)
        tpRegistro.Name = "tpRegistro"
        tpRegistro.Padding = New Padding(3)
        tpRegistro.Size = New Size(768, 340)
        tpRegistro.TabIndex = 1
        tpRegistro.Text = "REGISTRO"
        ' 
        ' gbEstado
        ' 
        gbEstado.Controls.Add(rbtnInactivo)
        gbEstado.Controls.Add(rbtnActivo)
        gbEstado.Location = New Point(390, 27)
        gbEstado.Name = "gbEstado"
        gbEstado.Size = New Size(200, 100)
        gbEstado.TabIndex = 6
        gbEstado.TabStop = False
        gbEstado.Text = "ESTADO"
        ' 
        ' rbtnInactivo
        ' 
        rbtnInactivo.AutoSize = True
        rbtnInactivo.Location = New Point(39, 57)
        rbtnInactivo.Name = "rbtnInactivo"
        rbtnInactivo.Size = New Size(67, 19)
        rbtnInactivo.TabIndex = 1
        rbtnInactivo.TabStop = True
        rbtnInactivo.Text = "Inactivo"
        rbtnInactivo.UseVisualStyleBackColor = True
        ' 
        ' rbtnActivo
        ' 
        rbtnActivo.AutoSize = True
        rbtnActivo.Location = New Point(39, 28)
        rbtnActivo.Name = "rbtnActivo"
        rbtnActivo.Size = New Size(59, 19)
        rbtnActivo.TabIndex = 0
        rbtnActivo.TabStop = True
        rbtnActivo.Text = "Activo"
        rbtnActivo.UseVisualStyleBackColor = True
        ' 
        ' txtDescripcion
        ' 
        txtDescripcion.Location = New Point(99, 97)
        txtDescripcion.Name = "txtDescripcion"
        txtDescripcion.Size = New Size(233, 23)
        txtDescripcion.TabIndex = 5
        ' 
        ' txtNombre
        ' 
        txtNombre.Location = New Point(99, 55)
        txtNombre.Name = "txtNombre"
        txtNombre.Size = New Size(190, 23)
        txtNombre.TabIndex = 4
        ' 
        ' txtIdCategoria
        ' 
        txtIdCategoria.Location = New Point(99, 19)
        txtIdCategoria.Name = "txtIdCategoria"
        txtIdCategoria.Size = New Size(100, 23)
        txtIdCategoria.TabIndex = 3
        ' 
        ' lblDescripcion
        ' 
        lblDescripcion.AutoSize = True
        lblDescripcion.Location = New Point(24, 100)
        lblDescripcion.Name = "lblDescripcion"
        lblDescripcion.Size = New Size(72, 15)
        lblDescripcion.TabIndex = 2
        lblDescripcion.Text = "Descripcion:"
        ' 
        ' lblNombre
        ' 
        lblNombre.AutoSize = True
        lblNombre.Location = New Point(39, 63)
        lblNombre.Name = "lblNombre"
        lblNombre.Size = New Size(54, 15)
        lblNombre.TabIndex = 1
        lblNombre.Text = "Nombre:"
        ' 
        ' lblIdCategoria
        ' 
        lblIdCategoria.AutoSize = True
        lblIdCategoria.Location = New Point(19, 27)
        lblIdCategoria.Name = "lblIdCategoria"
        lblIdCategoria.Size = New Size(77, 15)
        lblIdCategoria.TabIndex = 0
        lblIdCategoria.Text = "Id. Categoria:"
        ' 
        ' epError
        ' 
        epError.ContainerControl = Me
        ' 
        ' IUCategoria
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(TabControlDatos)
        Name = "IUCategoria"
        Text = "IUCategoria"
        Controls.SetChildIndex(TabControlDatos, 0)
        TabControlDatos.ResumeLayout(False)
        tpListado.ResumeLayout(False)
        CType(dgvListado, ComponentModel.ISupportInitialize).EndInit()
        gbBuscarPor.ResumeLayout(False)
        gbBuscarPor.PerformLayout()
        tpRegistro.ResumeLayout(False)
        tpRegistro.PerformLayout()
        gbEstado.ResumeLayout(False)
        gbEstado.PerformLayout()
        CType(epError, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents TabControlDatos As TabControl
    Friend WithEvents tpListado As TabPage
    Friend WithEvents tpRegistro As TabPage
    Friend WithEvents gbBuscarPor As GroupBox
    Friend WithEvents txtCriterio As TextBox
    Friend WithEvents lbCriterioBusqueda As Label
    Friend WithEvents btnBuscar As Button
    Friend WithEvents dgvListado As DataGridView
    Friend WithEvents gbEstado As GroupBox
    Friend WithEvents rbtnInactivo As RadioButton
    Friend WithEvents rbtnActivo As RadioButton
    Friend WithEvents txtDescripcion As TextBox
    Friend WithEvents txtNombre As TextBox
    Friend WithEvents txtIdCategoria As TextBox
    Friend WithEvents lblDescripcion As Label
    Friend WithEvents lblNombre As Label
    Friend WithEvents lblIdCategoria As Label
End Class
