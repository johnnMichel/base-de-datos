<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class IUProducto
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
        DataGridViewTextBoxColumn1 = New DataGridViewTextBoxColumn()
        DataGridViewTextBoxColumn2 = New DataGridViewTextBoxColumn()
        DataGridViewTextBoxColumn3 = New DataGridViewTextBoxColumn()
        DataGridViewTextBoxColumn4 = New DataGridViewTextBoxColumn()
        DataGridViewTextBoxColumn5 = New DataGridViewTextBoxColumn()
        DataGridViewTextBoxColumn6 = New DataGridViewTextBoxColumn()
        DataGridViewTextBoxColumn7 = New DataGridViewTextBoxColumn()
        DataGridViewTextBoxColumn8 = New DataGridViewTextBoxColumn()
        DataGridViewTextBoxColumn9 = New DataGridViewTextBoxColumn()
        TabControlDatos = New TabControl()
        tpListado = New TabPage()
        dgvListado = New DataGridView()
        gbBuscarPor = New GroupBox()
        btnBuscar = New Button()
        txtCriterio = New TextBox()
        lbCriterioBusqueda = New Label()
        tpRegistro = New TabPage()
        dtpFecha_Ultima_Compra = New DateTimePicker()
        txtEstado = New TextBox()
        lblEstado = New Label()
        txtNombre = New TextBox()
        txtPrecio_Compra = New TextBox()
        txtPrecio_Venta = New TextBox()
        txtStock = New TextBox()
        txtDescripcion = New TextBox()
        lblPrecio_Compra = New Label()
        lblFecha_Ultima_Compra = New Label()
        lblPrecio_Venta = New Label()
        lblStock = New Label()
        lblDescripcion = New Label()
        lblNombre = New Label()
        txtCodigo = New TextBox()
        txtfkIdCategoria = New TextBox()
        txtIdProducto = New TextBox()
        lblCodigo = New Label()
        lblfkIdCategoria = New Label()
        lblIdProducto = New Label()
        TabControlDatos.SuspendLayout()
        tpListado.SuspendLayout()
        CType(dgvListado, ComponentModel.ISupportInitialize).BeginInit()
        gbBuscarPor.SuspendLayout()
        tpRegistro.SuspendLayout()
        SuspendLayout()
        ' 
        ' DataGridViewTextBoxColumn1
        ' 
        DataGridViewTextBoxColumn1.DataPropertyName = "IdPersona"
        DataGridViewTextBoxColumn1.HeaderText = "IdPersona"
        DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        ' 
        ' DataGridViewTextBoxColumn2
        ' 
        DataGridViewTextBoxColumn2.DataPropertyName = "Nombre"
        DataGridViewTextBoxColumn2.HeaderText = "Nombre"
        DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        ' 
        ' DataGridViewTextBoxColumn3
        ' 
        DataGridViewTextBoxColumn3.DataPropertyName = "Ap_Paterno"
        DataGridViewTextBoxColumn3.HeaderText = "Ap_Paterno"
        DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        ' 
        ' DataGridViewTextBoxColumn4
        ' 
        DataGridViewTextBoxColumn4.DataPropertyName = "Ap_Materno"
        DataGridViewTextBoxColumn4.HeaderText = "Ap_Materno"
        DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        ' 
        ' DataGridViewTextBoxColumn5
        ' 
        DataGridViewTextBoxColumn5.DataPropertyName = "NombreEmpresa"
        DataGridViewTextBoxColumn5.HeaderText = "NombreEmpresa"
        DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        ' 
        ' DataGridViewTextBoxColumn6
        ' 
        DataGridViewTextBoxColumn6.DataPropertyName = "NombreContacto"
        DataGridViewTextBoxColumn6.HeaderText = "NombreContacto"
        DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        ' 
        ' DataGridViewTextBoxColumn7
        ' 
        DataGridViewTextBoxColumn7.DataPropertyName = "Direccion"
        DataGridViewTextBoxColumn7.HeaderText = "Direccion"
        DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        ' 
        ' DataGridViewTextBoxColumn8
        ' 
        DataGridViewTextBoxColumn8.DataPropertyName = "Telefono"
        DataGridViewTextBoxColumn8.HeaderText = "Telefono"
        DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        ' 
        ' DataGridViewTextBoxColumn9
        ' 
        DataGridViewTextBoxColumn9.DataPropertyName = "email"
        DataGridViewTextBoxColumn9.HeaderText = "email"
        DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        ' 
        ' TabControlDatos
        ' 
        TabControlDatos.Controls.Add(tpListado)
        TabControlDatos.Controls.Add(tpRegistro)
        TabControlDatos.Dock = DockStyle.Fill
        TabControlDatos.Location = New Point(0, 0)
        TabControlDatos.Name = "TabControlDatos"
        TabControlDatos.SelectedIndex = 0
        TabControlDatos.Size = New Size(800, 374)
        TabControlDatos.TabIndex = 6
        ' 
        ' tpListado
        ' 
        tpListado.Controls.Add(dgvListado)
        tpListado.Controls.Add(gbBuscarPor)
        tpListado.Location = New Point(4, 24)
        tpListado.Name = "tpListado"
        tpListado.Padding = New Padding(3)
        tpListado.Size = New Size(792, 346)
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
        dgvListado.Size = New Size(786, 279)
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
        tpRegistro.Controls.Add(dtpFecha_Ultima_Compra)
        tpRegistro.Controls.Add(txtEstado)
        tpRegistro.Controls.Add(lblEstado)
        tpRegistro.Controls.Add(txtNombre)
        tpRegistro.Controls.Add(txtPrecio_Compra)
        tpRegistro.Controls.Add(txtPrecio_Venta)
        tpRegistro.Controls.Add(txtStock)
        tpRegistro.Controls.Add(txtDescripcion)
        tpRegistro.Controls.Add(lblPrecio_Compra)
        tpRegistro.Controls.Add(lblFecha_Ultima_Compra)
        tpRegistro.Controls.Add(lblPrecio_Venta)
        tpRegistro.Controls.Add(lblStock)
        tpRegistro.Controls.Add(lblDescripcion)
        tpRegistro.Controls.Add(lblNombre)
        tpRegistro.Controls.Add(txtCodigo)
        tpRegistro.Controls.Add(txtfkIdCategoria)
        tpRegistro.Controls.Add(txtIdProducto)
        tpRegistro.Controls.Add(lblCodigo)
        tpRegistro.Controls.Add(lblfkIdCategoria)
        tpRegistro.Controls.Add(lblIdProducto)
        tpRegistro.Location = New Point(4, 24)
        tpRegistro.Name = "tpRegistro"
        tpRegistro.Padding = New Padding(3)
        tpRegistro.Size = New Size(792, 346)
        tpRegistro.TabIndex = 1
        tpRegistro.Text = "REGISTRO"
        ' 
        ' dtpFecha_Ultima_Compra
        ' 
        dtpFecha_Ultima_Compra.Location = New Point(147, 140)
        dtpFecha_Ultima_Compra.Name = "dtpFecha_Ultima_Compra"
        dtpFecha_Ultima_Compra.Size = New Size(233, 23)
        dtpFecha_Ultima_Compra.TabIndex = 21
        ' 
        ' txtEstado
        ' 
        txtEstado.Location = New Point(147, 251)
        txtEstado.Name = "txtEstado"
        txtEstado.Size = New Size(233, 23)
        txtEstado.TabIndex = 20
        ' 
        ' lblEstado
        ' 
        lblEstado.AutoSize = True
        lblEstado.Location = New Point(96, 259)
        lblEstado.Name = "lblEstado"
        lblEstado.Size = New Size(45, 15)
        lblEstado.TabIndex = 19
        lblEstado.Text = "Estado:"
        ' 
        ' txtNombre
        ' 
        txtNombre.Location = New Point(147, 89)
        txtNombre.Name = "txtNombre"
        txtNombre.Size = New Size(233, 23)
        txtNombre.TabIndex = 18
        ' 
        ' txtPrecio_Compra
        ' 
        txtPrecio_Compra.Location = New Point(147, 113)
        txtPrecio_Compra.Name = "txtPrecio_Compra"
        txtPrecio_Compra.Size = New Size(233, 23)
        txtPrecio_Compra.TabIndex = 17
        ' 
        ' txtPrecio_Venta
        ' 
        txtPrecio_Venta.Location = New Point(147, 167)
        txtPrecio_Venta.Name = "txtPrecio_Venta"
        txtPrecio_Venta.Size = New Size(233, 23)
        txtPrecio_Venta.TabIndex = 15
        ' 
        ' txtStock
        ' 
        txtStock.Location = New Point(147, 193)
        txtStock.Name = "txtStock"
        txtStock.Size = New Size(233, 23)
        txtStock.TabIndex = 14
        ' 
        ' txtDescripcion
        ' 
        txtDescripcion.Location = New Point(147, 222)
        txtDescripcion.Name = "txtDescripcion"
        txtDescripcion.Size = New Size(233, 23)
        txtDescripcion.TabIndex = 13
        ' 
        ' lblPrecio_Compra
        ' 
        lblPrecio_Compra.AutoSize = True
        lblPrecio_Compra.Location = New Point(52, 121)
        lblPrecio_Compra.Name = "lblPrecio_Compra"
        lblPrecio_Compra.Size = New Size(89, 15)
        lblPrecio_Compra.TabIndex = 12
        lblPrecio_Compra.Text = "Precio Compra:"
        ' 
        ' lblFecha_Ultima_Compra
        ' 
        lblFecha_Ultima_Compra.AutoSize = True
        lblFecha_Ultima_Compra.Location = New Point(16, 146)
        lblFecha_Ultima_Compra.Name = "lblFecha_Ultima_Compra"
        lblFecha_Ultima_Compra.Size = New Size(125, 15)
        lblFecha_Ultima_Compra.TabIndex = 11
        lblFecha_Ultima_Compra.Text = "Fecha Ultima Compra:"
        ' 
        ' lblPrecio_Venta
        ' 
        lblPrecio_Venta.AutoSize = True
        lblPrecio_Venta.Location = New Point(66, 175)
        lblPrecio_Venta.Name = "lblPrecio_Venta"
        lblPrecio_Venta.Size = New Size(75, 15)
        lblPrecio_Venta.TabIndex = 10
        lblPrecio_Venta.Text = "Precio Venta:"
        ' 
        ' lblStock
        ' 
        lblStock.AutoSize = True
        lblStock.Location = New Point(102, 201)
        lblStock.Name = "lblStock"
        lblStock.Size = New Size(39, 15)
        lblStock.TabIndex = 9
        lblStock.Text = "Stock:"
        ' 
        ' lblDescripcion
        ' 
        lblDescripcion.AutoSize = True
        lblDescripcion.Location = New Point(69, 230)
        lblDescripcion.Name = "lblDescripcion"
        lblDescripcion.Size = New Size(72, 15)
        lblDescripcion.TabIndex = 8
        lblDescripcion.Text = "Descripcion:"
        ' 
        ' lblNombre
        ' 
        lblNombre.AutoSize = True
        lblNombre.Location = New Point(87, 97)
        lblNombre.Name = "lblNombre"
        lblNombre.Size = New Size(54, 15)
        lblNombre.TabIndex = 7
        lblNombre.Text = "Nombre:"
        ' 
        ' txtCodigo
        ' 
        txtCodigo.Location = New Point(147, 63)
        txtCodigo.Name = "txtCodigo"
        txtCodigo.Size = New Size(233, 23)
        txtCodigo.TabIndex = 5
        ' 
        ' txtfkIdCategoria
        ' 
        txtfkIdCategoria.Location = New Point(147, 38)
        txtfkIdCategoria.Name = "txtfkIdCategoria"
        txtfkIdCategoria.Size = New Size(233, 23)
        txtfkIdCategoria.TabIndex = 4
        ' 
        ' txtIdProducto
        ' 
        txtIdProducto.Location = New Point(147, 14)
        txtIdProducto.Name = "txtIdProducto"
        txtIdProducto.Size = New Size(100, 23)
        txtIdProducto.TabIndex = 3
        ' 
        ' lblCodigo
        ' 
        lblCodigo.AutoSize = True
        lblCodigo.Location = New Point(92, 71)
        lblCodigo.Name = "lblCodigo"
        lblCodigo.Size = New Size(49, 15)
        lblCodigo.TabIndex = 2
        lblCodigo.Text = "Codigo:"
        ' 
        ' lblfkIdCategoria
        ' 
        lblfkIdCategoria.AutoSize = True
        lblfkIdCategoria.Cursor = Cursors.Cross
        lblfkIdCategoria.Location = New Point(60, 46)
        lblfkIdCategoria.Name = "lblfkIdCategoria"
        lblfkIdCategoria.Size = New Size(81, 15)
        lblfkIdCategoria.TabIndex = 1
        lblfkIdCategoria.Text = "fkIdCategoria:"
        ' 
        ' lblIdProducto
        ' 
        lblIdProducto.AutoSize = True
        lblIdProducto.Location = New Point(66, 22)
        lblIdProducto.Name = "lblIdProducto"
        lblIdProducto.Size = New Size(75, 15)
        lblIdProducto.TabIndex = 0
        lblIdProducto.Text = "Id. Producto:"
        ' 
        ' IUProducto
        ' 
        AutoScaleDimensions = New SizeF(7.0F, 15.0F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(TabControlDatos)
        Name = "IUProducto"
        Text = "IUProducto"
        Controls.SetChildIndex(TabControlDatos, 0)
        TabControlDatos.ResumeLayout(False)
        tpListado.ResumeLayout(False)
        CType(dgvListado, ComponentModel.ISupportInitialize).EndInit()
        gbBuscarPor.ResumeLayout(False)
        gbBuscarPor.PerformLayout()
        tpRegistro.ResumeLayout(False)
        tpRegistro.PerformLayout()
        ResumeLayout(False)
        PerformLayout()

    End Sub

    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn9 As DataGridViewTextBoxColumn
    Friend WithEvents TabControlDatos As TabControl
    Friend WithEvents tpListado As TabPage
    Friend WithEvents dgvListado As DataGridView
    Friend WithEvents gbBuscarPor As GroupBox
    Friend WithEvents btnBuscar As Button
    Friend WithEvents txtCriterio As TextBox
    Friend WithEvents lbCriterioBusqueda As Label
    Friend WithEvents tpRegistro As TabPage
    Friend WithEvents txtNombre As TextBox
    Friend WithEvents txtPrecio_Compra As TextBox
    Friend WithEvents txtPrecio_Venta As TextBox
    Friend WithEvents txtStock As TextBox
    Friend WithEvents txtDescripcion As TextBox
    Friend WithEvents lblPrecio_Compra As Label
    Friend WithEvents lblFecha_Ultima_Compra As Label
    Friend WithEvents lblPrecio_Venta As Label
    Friend WithEvents lblStock As Label
    Friend WithEvents lblDescripcion As Label
    Friend WithEvents lblNombre As Label
    Friend WithEvents txtCodigo As TextBox
    Friend WithEvents txtfkIdCategoria As TextBox
    Friend WithEvents txtIdProducto As TextBox
    Friend WithEvents lblCodigo As Label
    Friend WithEvents lblfkIdCategoria As Label
    Friend WithEvents lblIdProducto As Label
    Friend WithEvents txtEstado As TextBox
    Friend WithEvents lblEstado As Label
    '''Friend WithEvents epError As ErrorProvider'''
    Friend WithEvents dtpFecha_Ultima_Compra As DateTimePicker
End Class
