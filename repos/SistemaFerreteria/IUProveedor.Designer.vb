<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class IUProveedor
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
        txtApellidoMaterno = New TextBox()
        txtNombreEmpresa = New TextBox()
        txtNombreContacto = New TextBox()
        txtDireccion = New TextBox()
        txtTelefono = New TextBox()
        txtCorreo = New TextBox()
        lblNombreEmpresa = New Label()
        lblNombreContacto = New Label()
        lblDireccion = New Label()
        lblTelefono = New Label()
        lblEmail = New Label()
        lblApMaterno = New Label()
        txtApellidoPaterno = New TextBox()
        txtNombre = New TextBox()
        txtIdPersona = New TextBox()
        lblApPaterno = New Label()
        lblNombre = New Label()
        lblIdPersona = New Label()
        epError = New ErrorProvider(components)
        TabControlDatos.SuspendLayout()
        tpListado.SuspendLayout()
        CType(dgvListado, ComponentModel.ISupportInitialize).BeginInit()
        gbBuscarPor.SuspendLayout()
        tpRegistro.SuspendLayout()
        CType(epError, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' TabControlDatos
        ' 
        TabControlDatos.Controls.Add(tpListado)
        TabControlDatos.Controls.Add(tpRegistro)
        TabControlDatos.Dock = DockStyle.Fill
        TabControlDatos.Location = New Point(0, 0)
        TabControlDatos.Name = "TabControlDatos"
        TabControlDatos.SelectedIndex = 0
        TabControlDatos.Size = New Size(800, 423)
        TabControlDatos.TabIndex = 5
        ' 
        ' tpListado
        ' 
        tpListado.Controls.Add(dgvListado)
        tpListado.Controls.Add(gbBuscarPor)
        tpListado.Location = New Point(4, 24)
        tpListado.Name = "tpListado"
        tpListado.Padding = New Padding(3)
        tpListado.Size = New Size(792, 395)
        tpListado.TabIndex = 0
        tpListado.Text = "LISTADO"
        tpListado.UseVisualStyleBackColor = True
        ' 
        ' dgvListado
        ' 
        dgvListado.BackgroundColor = SystemColors.GradientActiveCaption
        dgvListado.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvListado.Dock = DockStyle.Fill
        dgvListado.Location = New Point(3, 64)
        dgvListado.Name = "dgvListado"
        dgvListado.RowTemplate.Height = 25
        dgvListado.Size = New Size(786, 328)
        dgvListado.TabIndex = 6
        ' 
        ' gbBuscarPor
        ' 
        gbBuscarPor.Controls.Add(btnBuscar)
        gbBuscarPor.Controls.Add(txtCriterio)
        gbBuscarPor.Controls.Add(lbCriterioBusqueda)
        gbBuscarPor.Dock = DockStyle.Top
        gbBuscarPor.Location = New Point(3, 3)
        gbBuscarPor.Name = "gbBuscarPor"
        gbBuscarPor.Size = New Size(786, 61)
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
        tpRegistro.Controls.Add(txtApellidoMaterno)
        tpRegistro.Controls.Add(txtNombreEmpresa)
        tpRegistro.Controls.Add(txtNombreContacto)
        tpRegistro.Controls.Add(txtDireccion)
        tpRegistro.Controls.Add(txtTelefono)
        tpRegistro.Controls.Add(txtCorreo)
        tpRegistro.Controls.Add(lblNombreEmpresa)
        tpRegistro.Controls.Add(lblNombreContacto)
        tpRegistro.Controls.Add(lblDireccion)
        tpRegistro.Controls.Add(lblTelefono)
        tpRegistro.Controls.Add(lblEmail)
        tpRegistro.Controls.Add(lblApMaterno)
        tpRegistro.Controls.Add(txtApellidoPaterno)
        tpRegistro.Controls.Add(txtNombre)
        tpRegistro.Controls.Add(txtIdPersona)
        tpRegistro.Controls.Add(lblApPaterno)
        tpRegistro.Controls.Add(lblNombre)
        tpRegistro.Controls.Add(lblIdPersona)
        tpRegistro.Location = New Point(4, 24)
        tpRegistro.Name = "tpRegistro"
        tpRegistro.Padding = New Padding(3)
        tpRegistro.Size = New Size(792, 395)
        tpRegistro.TabIndex = 1
        tpRegistro.Text = "REGISTRO"
        ' 
        ' txtApellidoMaterno
        ' 
        txtApellidoMaterno.Location = New Point(107, 89)
        txtApellidoMaterno.Name = "txtApellidoMaterno"
        txtApellidoMaterno.Size = New Size(233, 23)
        txtApellidoMaterno.TabIndex = 18
        ' 
        ' txtNombreEmpresa
        ' 
        txtNombreEmpresa.Location = New Point(107, 117)
        txtNombreEmpresa.Name = "txtNombreEmpresa"
        txtNombreEmpresa.Size = New Size(233, 23)
        txtNombreEmpresa.TabIndex = 17
        ' 
        ' txtNombreContacto
        ' 
        txtNombreContacto.Location = New Point(107, 142)
        txtNombreContacto.Name = "txtNombreContacto"
        txtNombreContacto.Size = New Size(233, 23)
        txtNombreContacto.TabIndex = 16
        ' 
        ' txtDireccion
        ' 
        txtDireccion.Location = New Point(107, 167)
        txtDireccion.Name = "txtDireccion"
        txtDireccion.Size = New Size(233, 23)
        txtDireccion.TabIndex = 15
        ' 
        ' txtTelefono
        ' 
        txtTelefono.Location = New Point(107, 193)
        txtTelefono.Name = "txtTelefono"
        txtTelefono.Size = New Size(233, 23)
        txtTelefono.TabIndex = 14
        ' 
        ' txtCorreo
        ' 
        txtCorreo.Location = New Point(107, 222)
        txtCorreo.Name = "txtCorreo"
        txtCorreo.Size = New Size(233, 23)
        txtCorreo.TabIndex = 13
        ' 
        ' lblNombreEmpresa
        ' 
        lblNombreEmpresa.AutoSize = True
        lblNombreEmpresa.Location = New Point(13, 125)
        lblNombreEmpresa.Name = "lblNombreEmpresa"
        lblNombreEmpresa.Size = New Size(88, 15)
        lblNombreEmpresa.TabIndex = 12
        lblNombreEmpresa.Text = "Nom. Empresa:"
        ' 
        ' lblNombreContacto
        ' 
        lblNombreContacto.AutoSize = True
        lblNombreContacto.Location = New Point(6, 150)
        lblNombreContacto.Name = "lblNombreContacto"
        lblNombreContacto.Size = New Size(92, 15)
        lblNombreContacto.TabIndex = 11
        lblNombreContacto.Text = "Nom. Contacto:"
        ' 
        ' lblDireccion
        ' 
        lblDireccion.AutoSize = True
        lblDireccion.Location = New Point(45, 175)
        lblDireccion.Name = "lblDireccion"
        lblDireccion.Size = New Size(60, 15)
        lblDireccion.TabIndex = 10
        lblDireccion.Text = "Direccion:"
        ' 
        ' lblTelefono
        ' 
        lblTelefono.AutoSize = True
        lblTelefono.Location = New Point(46, 204)
        lblTelefono.Name = "lblTelefono"
        lblTelefono.Size = New Size(55, 15)
        lblTelefono.TabIndex = 9
        lblTelefono.Text = "Telefono:"
        ' 
        ' lblEmail
        ' 
        lblEmail.AutoSize = True
        lblEmail.Location = New Point(55, 231)
        lblEmail.Name = "lblEmail"
        lblEmail.Size = New Size(46, 15)
        lblEmail.TabIndex = 8
        lblEmail.Text = "Correo:"
        ' 
        ' lblApMaterno
        ' 
        lblApMaterno.AutoSize = True
        lblApMaterno.Location = New Point(25, 99)
        lblApMaterno.Name = "lblApMaterno"
        lblApMaterno.Size = New Size(76, 15)
        lblApMaterno.TabIndex = 7
        lblApMaterno.Text = "Ap. Materno:"
        ' 
        ' txtApellidoPaterno
        ' 
        txtApellidoPaterno.Location = New Point(107, 63)
        txtApellidoPaterno.Name = "txtApellidoPaterno"
        txtApellidoPaterno.Size = New Size(233, 23)
        txtApellidoPaterno.TabIndex = 5
        ' 
        ' txtNombre
        ' 
        txtNombre.Location = New Point(107, 38)
        txtNombre.Name = "txtNombre"
        txtNombre.Size = New Size(190, 23)
        txtNombre.TabIndex = 4
        ' 
        ' txtIdPersona
        ' 
        txtIdPersona.Location = New Point(107, 14)
        txtIdPersona.Name = "txtIdPersona"
        txtIdPersona.Size = New Size(100, 23)
        txtIdPersona.TabIndex = 3
        ' 
        ' lblApPaterno
        ' 
        lblApPaterno.AutoSize = True
        lblApPaterno.Location = New Point(29, 71)
        lblApPaterno.Name = "lblApPaterno"
        lblApPaterno.Size = New Size(72, 15)
        lblApPaterno.TabIndex = 2
        lblApPaterno.Text = "Ap. Paterno:"
        ' 
        ' lblNombre
        ' 
        lblNombre.AutoSize = True
        lblNombre.Cursor = Cursors.Cross
        lblNombre.Location = New Point(42, 46)
        lblNombre.Name = "lblNombre"
        lblNombre.Size = New Size(59, 15)
        lblNombre.TabIndex = 1
        lblNombre.Text = "Nombres:"
        ' 
        ' lblIdPersona
        ' 
        lblIdPersona.AutoSize = True
        lblIdPersona.Location = New Point(33, 22)
        lblIdPersona.Name = "lblIdPersona"
        lblIdPersona.Size = New Size(68, 15)
        lblIdPersona.TabIndex = 0
        lblIdPersona.Text = "Id. Persona:"
        ' 
        ' epError
        ' 
        epError.ContainerControl = Me
        ' 
        ' IUProveedor
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 499)
        Controls.Add(TabControlDatos)
        Name = "IUProveedor"
        Text = "IUProveedor"
        Controls.SetChildIndex(TabControlDatos, 0)
        TabControlDatos.ResumeLayout(False)
        tpListado.ResumeLayout(False)
        CType(dgvListado, ComponentModel.ISupportInitialize).EndInit()
        gbBuscarPor.ResumeLayout(False)
        gbBuscarPor.PerformLayout()
        tpRegistro.ResumeLayout(False)
        tpRegistro.PerformLayout()
        CType(epError, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents TabControlDatos As TabControl
    Friend WithEvents tpListado As TabPage
    Friend WithEvents gbBuscarPor As GroupBox
    Friend WithEvents btnBuscar As Button
    Friend WithEvents txtCriterio As TextBox
    Friend WithEvents lbCriterioBusqueda As Label
    Friend WithEvents tpRegistro As TabPage
    Friend WithEvents txtApellidoPaterno As TextBox
    Friend WithEvents txtNombre As TextBox
    Friend WithEvents txtIdPersona As TextBox
    Friend WithEvents lblApPaterno As Label
    Friend WithEvents lblNombre As Label
    Friend WithEvents lblIdPersona As Label
    Friend WithEvents txtApellidoMaterno As TextBox
    Friend WithEvents txtNombreEmpresa As TextBox
    Friend WithEvents txtNombreContacto As TextBox
    Friend WithEvents txtDireccion As TextBox
    Friend WithEvents txtTelefono As TextBox
    Friend WithEvents txtCorreo As TextBox
    Friend WithEvents lblNombreEmpresa As Label
    Friend WithEvents lblNombreContacto As Label
    Friend WithEvents lblDireccion As Label
    Friend WithEvents lblTelefono As Label
    Friend WithEvents lblEmail As Label
    Friend WithEvents lblApMaterno As Label
    Friend WithEvents dgvListado As DataGridView
End Class
