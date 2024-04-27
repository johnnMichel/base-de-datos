<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class IUCompra
    Inherits IUBase


    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
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
        txtEstado = New Label()
        lblIdCompra = New Label()
        txtIdCompra = New TextBox()
        dtpFecha = New DateTimePicker()
        lblTotal = New Label()
        lblImpuesto = New Label()
        lblFecha = New Label()
        lblNum_Comprobante = New Label()
        lblSerie_Comprobante = New Label()
        txtImpuesto = New TextBox()
        txtTotal = New TextBox()
        txtNum_Comprobante = New TextBox()
        txtSerie_Comprobante = New TextBox()
        txtfkIdProveedor = New TextBox()
        txtTipo_Comprobante = New TextBox()
        txtfkIdUsuario = New TextBox()
        lblTipo_Comprobante = New Label()
        lblfkIdUsuario = New Label()
        lblfkIdProveedor = New Label()
        TabControlDatos.SuspendLayout()
        tpListado.SuspendLayout()
        CType(dgvListado, ComponentModel.ISupportInitialize).BeginInit()
        gbBuscarPor.SuspendLayout()
        tpRegistro.SuspendLayout()
        gbEstado.SuspendLayout()
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
        tpRegistro.Controls.Add(txtEstado)
        tpRegistro.Controls.Add(lblIdCompra)
        tpRegistro.Controls.Add(txtIdCompra)
        tpRegistro.Controls.Add(dtpFecha)
        tpRegistro.Controls.Add(lblTotal)
        tpRegistro.Controls.Add(lblImpuesto)
        tpRegistro.Controls.Add(lblFecha)
        tpRegistro.Controls.Add(lblNum_Comprobante)
        tpRegistro.Controls.Add(lblSerie_Comprobante)
        tpRegistro.Controls.Add(txtImpuesto)
        tpRegistro.Controls.Add(txtTotal)
        tpRegistro.Controls.Add(txtNum_Comprobante)
        tpRegistro.Controls.Add(txtSerie_Comprobante)
        tpRegistro.Controls.Add(txtfkIdProveedor)
        tpRegistro.Controls.Add(txtTipo_Comprobante)
        tpRegistro.Controls.Add(txtfkIdUsuario)
        tpRegistro.Controls.Add(lblTipo_Comprobante)
        tpRegistro.Controls.Add(lblfkIdUsuario)
        tpRegistro.Controls.Add(lblfkIdProveedor)
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
        gbEstado.Location = New Point(472, 30)
        gbEstado.Name = "gbEstado"
        gbEstado.Size = New Size(200, 100)
        gbEstado.TabIndex = 21
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
        ' txtEstado
        ' 
        txtEstado.AutoSize = True
        txtEstado.Location = New Point(79, 314)
        txtEstado.Name = "txtEstado"
        txtEstado.Size = New Size(0, 15)
        txtEstado.TabIndex = 20
        ' 
        ' lblIdCompra
        ' 
        lblIdCompra.AutoSize = True
        lblIdCompra.Location = New Point(38, 9)
        lblIdCompra.Name = "lblIdCompra"
        lblIdCompra.Size = New Size(69, 15)
        lblIdCompra.TabIndex = 19
        lblIdCompra.Text = "Id. Compra:"
        ' 
        ' txtIdCompra
        ' 
        txtIdCompra.Location = New Point(126, 6)
        txtIdCompra.Name = "txtIdCompra"
        txtIdCompra.Size = New Size(190, 23)
        txtIdCompra.TabIndex = 18
        ' 
        ' dtpFecha
        ' 
        dtpFecha.Location = New Point(126, 217)
        dtpFecha.MaxDate = New Date(2024, 4, 26, 1, 42, 31, 0)
        dtpFecha.MinDate = New Date(2024, 4, 25, 0, 0, 0, 0)
        dtpFecha.Name = "dtpFecha"
        dtpFecha.Size = New Size(250, 23)
        dtpFecha.TabIndex = 17
        dtpFecha.Value = New Date(2024, 4, 25, 0, 0, 0, 0)
        ' 
        ' lblTotal
        ' 
        lblTotal.AutoSize = True
        lblTotal.Location = New Point(72, 288)
        lblTotal.Name = "lblTotal"
        lblTotal.Size = New Size(35, 15)
        lblTotal.TabIndex = 16
        lblTotal.Text = "Total:"
        ' 
        ' lblImpuesto
        ' 
        lblImpuesto.AutoSize = True
        lblImpuesto.Location = New Point(58, 259)
        lblImpuesto.Name = "lblImpuesto"
        lblImpuesto.Size = New Size(60, 15)
        lblImpuesto.TabIndex = 15
        lblImpuesto.Text = "Impuesto:"
        ' 
        ' lblFecha
        ' 
        lblFecha.AutoSize = True
        lblFecha.Location = New Point(79, 223)
        lblFecha.Name = "lblFecha"
        lblFecha.Size = New Size(41, 15)
        lblFecha.TabIndex = 14
        lblFecha.Text = "Fecha:"
        ' 
        ' lblNum_Comprobante
        ' 
        lblNum_Comprobante.AutoSize = True
        lblNum_Comprobante.Location = New Point(6, 188)
        lblNum_Comprobante.Name = "lblNum_Comprobante"
        lblNum_Comprobante.Size = New Size(114, 15)
        lblNum_Comprobante.TabIndex = 13
        lblNum_Comprobante.Text = "Num Comprobante:"
        ' 
        ' lblSerie_Comprobante
        ' 
        lblSerie_Comprobante.AutoSize = True
        lblSerie_Comprobante.Location = New Point(8, 150)
        lblSerie_Comprobante.Name = "lblSerie_Comprobante"
        lblSerie_Comprobante.Size = New Size(112, 15)
        lblSerie_Comprobante.TabIndex = 12
        lblSerie_Comprobante.Text = "Serie Comprobante:"
        ' 
        ' txtImpuesto
        ' 
        txtImpuesto.Location = New Point(126, 256)
        txtImpuesto.Name = "txtImpuesto"
        txtImpuesto.Size = New Size(190, 23)
        txtImpuesto.TabIndex = 11
        ' 
        ' txtTotal
        ' 
        txtTotal.Location = New Point(124, 285)
        txtTotal.Name = "txtTotal"
        txtTotal.Size = New Size(190, 23)
        txtTotal.TabIndex = 10
        ' 
        ' txtNum_Comprobante
        ' 
        txtNum_Comprobante.Location = New Point(126, 188)
        txtNum_Comprobante.Name = "txtNum_Comprobante"
        txtNum_Comprobante.Size = New Size(190, 23)
        txtNum_Comprobante.TabIndex = 9
        ' 
        ' txtSerie_Comprobante
        ' 
        txtSerie_Comprobante.Location = New Point(126, 150)
        txtSerie_Comprobante.Name = "txtSerie_Comprobante"
        txtSerie_Comprobante.Size = New Size(190, 23)
        txtSerie_Comprobante.TabIndex = 8
        ' 
        ' txtfkIdProveedor
        ' 
        txtfkIdProveedor.Location = New Point(124, 40)
        txtfkIdProveedor.Name = "txtfkIdProveedor"
        txtfkIdProveedor.Size = New Size(190, 23)
        txtfkIdProveedor.TabIndex = 7
        ' 
        ' txtTipo_Comprobante
        ' 
        txtTipo_Comprobante.Location = New Point(126, 112)
        txtTipo_Comprobante.Name = "txtTipo_Comprobante"
        txtTipo_Comprobante.Size = New Size(233, 23)
        txtTipo_Comprobante.TabIndex = 5
        ' 
        ' txtfkIdUsuario
        ' 
        txtfkIdUsuario.Location = New Point(126, 77)
        txtfkIdUsuario.Name = "txtfkIdUsuario"
        txtfkIdUsuario.Size = New Size(190, 23)
        txtfkIdUsuario.TabIndex = 4
        ' 
        ' lblTipo_Comprobante
        ' 
        lblTipo_Comprobante.AutoSize = True
        lblTipo_Comprobante.Location = New Point(10, 115)
        lblTipo_Comprobante.Name = "lblTipo_Comprobante"
        lblTipo_Comprobante.Size = New Size(110, 15)
        lblTipo_Comprobante.TabIndex = 2
        lblTipo_Comprobante.Text = "Tipo Comprobante:"
        ' 
        ' lblfkIdUsuario
        ' 
        lblfkIdUsuario.AutoSize = True
        lblfkIdUsuario.Location = New Point(44, 80)
        lblfkIdUsuario.Name = "lblfkIdUsuario"
        lblfkIdUsuario.Size = New Size(63, 15)
        lblfkIdUsuario.TabIndex = 1
        lblfkIdUsuario.Text = "Id Usuario:"
        ' 
        ' lblfkIdProveedor
        ' 
        lblfkIdProveedor.AutoSize = True
        lblfkIdProveedor.Location = New Point(38, 48)
        lblfkIdProveedor.Name = "lblfkIdProveedor"
        lblfkIdProveedor.Size = New Size(80, 15)
        lblfkIdProveedor.TabIndex = 0
        lblfkIdProveedor.Text = "Id. Proveedor:"
        ' 
        ' IUCompra
        ' 
        AutoScaleDimensions = New SizeF(7.0F, 15.0F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(TabControlDatos)
        Name = "IUCompra"
        Text = "IUCompra"
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
    Friend WithEvents txtTipo_Comprobante As TextBox
    Friend WithEvents txtfkIdUsuario As TextBox
    Friend WithEvents lblTipo_Comprobante As Label
    Friend WithEvents lblfkIdUsuario As Label
    Friend WithEvents lblfkIdProveedor As Label
    Friend WithEvents txtSerie_Comprobante As TextBox
    Friend WithEvents txtfkIdProveedor As TextBox
    Friend WithEvents txtImpuesto As TextBox
    Friend WithEvents txtTotal As TextBox
    Friend WithEvents txtNum_Comprobante As TextBox
    Friend WithEvents lblTotal As Label
    Friend WithEvents lblImpuesto As Label
    Friend WithEvents lblFecha As Label
    Friend WithEvents lblNum_Comprobante As Label
    Friend WithEvents lblSerie_Comprobante As Label
    Friend WithEvents dtpFecha As DateTimePicker
    Friend WithEvents lblIdCompra As Label
    Friend WithEvents txtIdCompra As TextBox
    Friend WithEvents txtEstado As Label
    Friend WithEvents gbEstado As GroupBox
    Friend WithEvents rbtnInactivo As RadioButton
    Friend WithEvents rbtnActivo As RadioButton
End Class
