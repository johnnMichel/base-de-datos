Public Class IUCompra
#Region "Variables Locales"
    Private Indice As Integer
    Private IdCompra As Integer = 0
    Private ObjCompraActual As New NEGOCIO.Compra()
    Private dtLista As DataTable
#End Region
    Private Sub IUCompra_Load(sender As Object, e As EventArgs) Handles MyBase.Load

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
            Dim oCompra As New NEGOCIO.Compra
            Dim dtCompra As DataTable
            dtCompra = oCompra.Traer("")
            dgvListado.DataSource = dtCompra


        Catch ex As Exception

        End Try
    End Sub

    Public Overrides Sub procesoListar()
        MyBase.ProcesoListar() ' Llama al método de la clase base si es necesario
        Try
            If Me.txtCriterio.Text.Trim.Length > 0 Then
                Me.dtLista = ObjCompraActual.Traer(" Tipo_Comprobante like '%" & Me.txtCriterio.Text & "%'  ")
            Else
                Me.dtLista = ObjCompraActual.Traer("")
            End If

            Me.dgvListado.DataSource = Me.dtLista
        Catch ex As Exception
            ' Manejar la excepción si ocurre algún error al listar
        End Try
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
        txtIdCompra.Enabled = False

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

        Dim oCompra As New NEGOCIO.Compra()
        LeerDatos(oCompra)
        Try
            If (IdCompra = 0) Then
                oCompra.Insertar()
                txtIdCompra.Text = Convert.ToString(oCompra.IdCompra)
                MsgBox("Guardado correctamente", MsgBoxStyle.Information)
            Else
                oCompra.Modificar()
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
                Dim oCompra As New NEGOCIO.Compra()
                LeerDatos(oCompra)
                oCompra.Eliminar()
                MessageBox.Show("Eliminado correctamente")
                ProcesarConsulta()

            End If

        Catch ex As Exception


            Throw New Exception("Error al eliminar el Producto")
        End Try
    End Sub

    Public Sub LeerDatos(ByRef oCompra As NEGOCIO.Compra)
        Try
            If (txtIdCompra.Text.Trim.Length > 0) Then
                oCompra.IdCompra = Convert.ToInt32(txtIdCompra.Text)
            End If

            ' Elimina esta línea: oCompra.IdCompra = txtIdCompra.Text

            oCompra.fkIdProveedor = txtfkIdProveedor.Text
            oCompra.fkIdUsuario = txtfkIdUsuario.Text
            oCompra.Tipo_Comprobante = txtTipo_Comprobante.Text
            oCompra.Serie_Comprobante = txtSerie_Comprobante.Text
            oCompra.Num_Comprobante = txtNum_Comprobante.Text
            oCompra.Fecha = dtpFecha.Value
            oCompra.Impuesto = txtImpuesto.Text
            oCompra.Total = txtTotal.Text

            If rbtnActivo.Checked Then
                oCompra.Estado = True
            ElseIf rbtnInactivo.Checked Then
                oCompra.Estado = False
            End If
        Catch ex As Exception
            ' Manejo de excepciones
        End Try
    End Sub


    Public Overrides Sub ProcesoModificar()
        If ((txtIdCompra.Text <> "")) Then

            IdCompra = Convert.ToInt32(txtIdCompra.Text)
            MyBase.ProcesoModificar()
            tpRegistro.Enabled = True
            txtfkIdProveedor.Focus()
        Else
            MessageBox.Show("Busque un registro para modificar")
        End If
    End Sub

    Public Overrides Sub ProcesoEliminar()
        If ((txtIdCompra.Text <> "" And IdCompra > 0)) Then
            ObjCompraActual.IdCompra = Convert.ToDecimal(txtIdCompra.Text)
            If MessageBox.Show("Esta Seguro que desea ELIMINAR el REGISTRO", "ELIMINAR", MessageBoxButtons.OKCancel) = Windows.Forms.DialogResult.OK Then
                ObjCompraActual.Eliminar()
                MessageBox.Show("Se ha Eliminado correctamente")
            End If

        Else
            MessageBox.Show("Busque un registro para eliminar")
        End If
    End Sub
    Public Overrides Sub ProcesoNuevo()


        MyBase.ProcesoNuevo()
        IdCompra = 0
        txtfkIdProveedor.Clear()
        txtfkIdUsuario.Clear()
        txtTipo_Comprobante.Clear()
        txtSerie_Comprobante.Clear()
        txtNum_Comprobante.Clear()
        '''dtpFecha_Ultima_Compra.Clear()'''
        txtImpuesto.Clear()
        txtTotal.Clear()

        tpRegistro.Enabled = True
        TabControlDatos.SelectedTab = tpRegistro

        txtfkIdProveedor.Focus()

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
        If (txtfkIdProveedor.Text.Trim().Length = 0) Then
            epError.SetError(txtfkIdProveedor, "Ingrese el nombre del Proveedor")
            sw = False
        End If
        If (txtfkIdUsuario.Text.Trim().Length = 0) Then
            epError.SetError(txtfkIdUsuario, "Ingrese la Descripcion del Proveedor")
            sw = False
        End If
        Return sw

    End Function

    Private Sub dgvListado_RowHeaderMouseDoubleClick(ByVal sender As Object, ByVal e As DataGridViewCellMouseEventArgs) Handles dgvListado.CellMouseDoubleClick
        If e.RowIndex >= 0 And e.RowIndex <= dgvListado.Rows.Count - 1 Then
            LimpiarEntradas()
            txtIdCompra.Text = dgvListado.Item(0, e.RowIndex).Value
            txtfkIdProveedor.Text = dgvListado.Item("fkIdProveedor", e.RowIndex).Value
            txtfkIdUsuario.Text = dgvListado.Item("fkIdUsuario", e.RowIndex).Value
            txtTipo_Comprobante.Text = dgvListado.Item("Tipo_Comprobante", e.RowIndex).Value
            txtSerie_Comprobante.Text = dgvListado.Item("Serie_Comprobante", e.RowIndex).Value
            txtNum_Comprobante.Text = dgvListado.Item("Num_Comprobante", e.RowIndex).Value
            dtpFecha.Text = dgvListado.Item("Fecha", e.RowIndex).Value
            txtImpuesto.Text = dgvListado.Item("Impuesto", e.RowIndex).Value
            txtTotal.Text = dgvListado.Item("Total", e.RowIndex).Value
            txtEstado.Text = dgvListado.Item("Estado", e.RowIndex).Value


            'Me.gbDatos.Enabled = False
            TabControlDatos.SelectedTab = tpRegistro

        End If
    End Sub

    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        Try
            procesoListar()
        Catch ex As Exception

        End Try
    End Sub


    Private Sub dtpFecha_ValueChanged(sender As Object, e As EventArgs) Handles dtpFecha.ValueChanged

    End Sub

    Private Sub txtIdCompra_TextChanged(sender As Object, e As EventArgs) Handles txtIdCompra.TextChanged

    End Sub

    Private Sub dgvListado_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvListado.CellContentClick

    End Sub
End Class