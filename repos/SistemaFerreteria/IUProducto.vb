Public Class IUProducto
#Region "Variables Locales"
    Private Indice As Integer
    Private IdProducto As Integer = 0
    Private ObjProductoActual As New NEGOCIO.Producto()
    Private dtLista As DataTable
#End Region


    Private Sub IUProducto_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'MyBase.btnImprimir.Visible = False
        ListarRegistros()
        MostrarPanelBotones(True)
        tpRegistro.Enabled = False
    End Sub

    Private Sub txtCriterio_KeyUp(ByVal sender As Object, ByVal e As KeyEventArgs)
        'If e.KeyCode = Keys.Enter Then
        '    If txtCriterio.Text.Trim.Length = 0 Then
        '        procesarBuscar("'%'")
        '    Else
        '        procesarBuscar("'%" + txtCriterio.Text + "%'")
        '    End If
        'End If
    End Sub
    Private Sub ListarRegistros()
        Try
            Dim oProducto As New NEGOCIO.Producto
            Dim dtProducto As DataTable
            dtProducto = oProducto.Traer("")
            dgvListado.DataSource = dtProducto


        Catch ex As Exception

        End Try
    End Sub

    Public Overrides Sub procesoListar()

        MyBase.ProcesoListar()
        If Me.txtCriterio.Text.Trim.Length > 0 Then
            Me.dtLista = ObjProductoActual.Traer(" Nombre like '%" & Me.txtCriterio.Text & "%'  ")
        Else
            Me.dtLista = ObjProductoActual.Traer("")
        End If

        Me.dgvListado.DataSource = Me.dtLista

    End Sub

    Private Sub TabControlDatos_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs)
        If TabControlDatos.SelectedTab.Text = TabControlDatos.Text Then
            MostrarPanelBotones(False)
        Else
            MostrarPanelBotones(True)
        End If
    End Sub


#Region "Metodo Botones"
    Public Overrides Sub HabilitarEntradas(ByVal value As Boolean)

        MyBase.HabilitarEntradas(value)
        txtIdProducto.Enabled = False

    End Sub




    ''' <summary>
    ''' Este procedimiento es para guardar nuevo registro, tambien modifica un registro
    ''' </summary>
    ''' <remarks></remarks>
    Public Overrides Sub ProcesoAceptar()
        If (ValidarDatos() = False) Then
            MessageBox.Show("FALTA Ingresar datos")
            Return
        End If

        Dim oProducto As New NEGOCIO.Producto()
        LeerDatos(oProducto)
        Try
            If (IdProducto = 0) Then
                oProducto.Insertar()
                txtIdProducto.Text = Convert.ToString(oProducto.IdProducto)
                MsgBox("Guardado correctamente", MsgBoxStyle.Information)
            Else
                oProducto.Modificar()
                MsgBox("Modificado correctamente", MsgBoxStyle.Information)
            End If
            LimpiarEntradas()

            ListarRegistros()
            tpRegistro.Enabled = False
            TabControlDatos.SelectedTab = tpListado

            MyBase.HabilitarOperaciones(True)
        Catch ex As Exception
            MsgBox("Error al guardar el Proveedor: " + ex.ToString(), MsgBoxStyle.Critical)
        End Try

    End Sub

    Public Overrides Sub ProcesoCancelar()

        MyBase.Cancelar()
        MyBase.HabilitarOperaciones(True)
        TabControlDatos.SelectedTab = tpListado
    End Sub

    Public Overrides Sub Eliminar()
        Try
            If (MessageBox.Show("Confirma la Eliminarcion", "ELIMINAR", MessageBoxButtons.OKCancel) = DialogResult.OK) Then
                Dim oProducto As New NEGOCIO.Producto()
                LeerDatos(oProducto)
                oProducto.Eliminar()
                MessageBox.Show("Eliminado correctamente")
                ProcesarConsulta()

            End If

        Catch ex As Exception


            Throw New Exception("Error al eliminar el Producto")
        End Try
    End Sub

    Public Sub LeerDatos(ByRef oProducto As NEGOCIO.Producto)

        Try
            If (txtIdProducto.Text.Trim.Length > 0) Then
                oProducto.IdProducto = Convert.ToInt32(txtIdProducto.Text)
            End If

            oProducto.IdProducto = txtIdProducto.Text
            oProducto.fkIdCategoria = txtfkIdCategoria.Text
            oProducto.Codigo = txtCodigo.Text
            oProducto.Nombre = txtNombre.Text
            oProducto.Precio_Compra = txtPrecio_Compra.Text
            oProducto.Fecha_Ultima_Compra = dtpFecha_Ultima_Compra.Text
            oProducto.Precio_Venta = txtPrecio_Venta.Text
            oProducto.Stock = txtStock.Text
            oProducto.Descripcion = txtDescripcion.Text
            oProducto.Estado = txtEstado.Text


        Catch ex As Exception

        End Try

    End Sub

    Public Overrides Sub ProcesoModificar()
        If ((txtIdProducto.Text <> "")) Then

            IdProducto = Convert.ToInt32(txtIdProducto.Text)
            MyBase.ProcesoModificar()
            tpRegistro.Enabled = True
            txtfkIdCategoria.Focus()
        Else
            MessageBox.Show("Busque un registro para modificar")
        End If
    End Sub

    Public Overrides Sub ProcesoEliminar()
        If ((txtIdProducto.Text <> "" And IdProducto > 0)) Then
            ObjProductoActual.IdProducto = Convert.ToDecimal(txtIdProducto.Text)
            If MessageBox.Show("Esta Seguro que desea ELIMINAR el REGISTRO", "ELIMINAR", MessageBoxButtons.OKCancel) = Windows.Forms.DialogResult.OK Then
                ObjProductoActual.Eliminar()
                MessageBox.Show("Se ha Eliminado correctamente")
            End If

        Else
            MessageBox.Show("Busque un registro para eliminar")
        End If
    End Sub
    Public Overrides Sub ProcesoNuevo()


        MyBase.ProcesoNuevo()
        IdProducto = 0

        txtIdProducto.Clear()
        txtfkIdCategoria.Clear()
        txtCodigo.Clear()
        txtNombre.Clear()
        txtPrecio_Compra.Clear()
        '''dtpFecha_Ultima_Compra.Clear()'''
        txtPrecio_Venta.Clear()
        txtStock.Clear()
        txtDescripcion.Clear()
        tpRegistro.Enabled = True
        TabControlDatos.SelectedTab = tpRegistro


        txtfkIdCategoria.Focus()

    End Sub
#End Region

    Public Sub Limpiar_TextBox()

        'Recorremos todos los controles del formulario que enviamos  
        For Each control As Control In Me.Controls

            'Filtramos solo aquellos de tipo TextBox 
            If TypeOf control Is TextBox Then
                control.Text = "" ' eliminar el texto  
            End If
        Next

    End Sub


    Private Function ValidarDatos() As Boolean

        Dim sw As Boolean = True
        epError.Clear()
        If (txtfkIdCategoria.Text.Trim().Length = 0) Then
            epError.SetError(txtfkIdCategoria, "Ingrese el nombre del Proveedor")
            sw = False
        End If

        If (txtCodigo.Text.Trim().Length = 0) Then
            epError.SetError(txtCodigo, "Ingrese la Descripcion del Proveedor")
            sw = False
        End If


        Return sw

    End Function

    Private Sub dgvListado_RowHeaderMouseDoubleClick(ByVal sender As Object, ByVal e As DataGridViewCellMouseEventArgs)
        If e.RowIndex >= 0 And e.RowIndex <= dgvListado.Rows.Count - 1 Then
            LimpiarEntradas()
            txtIdProducto.Text = dgvListado.Item(0, e.RowIndex).Value
            txtfkIdCategoria.Text = dgvListado.Item("fkIdCategoria", e.RowIndex).Value
            txtCodigo.Text = dgvListado.Item("Codigo", e.RowIndex).Value
            txtNombre.Text = dgvListado.Item("Nombre", e.RowIndex).Value
            txtPrecio_Compra.Text = dgvListado.Item("Precio_Compra", e.RowIndex).Value
            dtpFecha_Ultima_Compra.Text = dgvListado.Item("Fecha_Ultima_Compra", e.RowIndex).Value
            txtPrecio_Venta.Text = dgvListado.Item("Precio_Venta", e.RowIndex).Value
            txtStock.Text = dgvListado.Item("Stock", e.RowIndex).Value
            txtDescripcion.Text = dgvListado.Item("Descripcion", e.RowIndex).Value
            txtEstado.Text = dgvListado.Item("Estado", e.RowIndex).Value


            'Me.gbDatos.Enabled = False
            TabControlDatos.SelectedTab = tpRegistro

        End If
    End Sub

    Private Sub btnBuscar_Click(sender As Object, e As EventArgs)
        Try
            procesoListar()
        Catch ex As Exception

        End Try
    End Sub
End Class