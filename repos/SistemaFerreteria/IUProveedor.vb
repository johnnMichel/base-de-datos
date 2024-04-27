Public Class IUProveedor
#Region "Variables Locales"
    Private Indice As Integer
    Private IdPersona As Integer = 0
    Private ObjProveedorActual As New NEGOCIO.Proveedor()
    Private dtLista As DataTable
#End Region


    Private Sub IUProveedor_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'MyBase.btnImprimir.Visible = False
        ListarRegistros()
        MostrarPanelBotones(True)
        tpRegistro.Enabled = False
    End Sub

    Private Sub txtCriterio_KeyUp(ByVal sender As Object, ByVal e As KeyEventArgs) Handles txtCriterio.KeyUp
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
            Dim oProveedor As New NEGOCIO.Proveedor
            Dim dtProveedor As DataTable
            dtProveedor = oProveedor.Traer("")
            dgvListado.DataSource = dtProveedor


        Catch ex As Exception

        End Try
    End Sub

    Public Overrides Sub procesoListar()

        MyBase.ProcesoListar()
        If Me.txtCriterio.Text.Trim.Length > 0 Then
            Me.dtLista = ObjProveedorActual.Traer(" Nombre like '%" & Me.txtCriterio.Text & "%'  ")
        Else
            Me.dtLista = ObjProveedorActual.Traer("")
        End If

        Me.dgvListado.DataSource = Me.dtLista

    End Sub

    Private Sub TabControlDatos_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles TabControlDatos.SelectedIndexChanged
        If TabControlDatos.SelectedTab.Text = TabControlDatos.Text Then
            MostrarPanelBotones(False)
        Else
            MostrarPanelBotones(True)
        End If
    End Sub


#Region "Metodo Botones"
    Public Overrides Sub HabilitarEntradas(ByVal value As Boolean)

        MyBase.HabilitarEntradas(value)
        txtIdPersona.Enabled = False

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

        Dim oProveedor As New NEGOCIO.Proveedor()
        LeerDatos(oProveedor)
        Try
            If (IdPersona = 0) Then
                oProveedor.Insertar()
                txtIdPersona.Text = Convert.ToString(oProveedor.IdPersona)
                MsgBox("Guardado correctamente", MsgBoxStyle.Information)
            Else
                oProveedor.Modificar()
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
                Dim oProveedor As New NEGOCIO.Proveedor()
                LeerDatos(oProveedor)
                oProveedor.Eliminar()
                MessageBox.Show("Eliminado correctamente")
                ProcesarConsulta()

            End If

        Catch ex As Exception


            Throw New Exception("Error al eliminar el Proveedor")
        End Try
    End Sub

    Public Sub LeerDatos(ByRef oProveedor As NEGOCIO.Proveedor)

        Try
            If (txtIdPersona.Text.Trim.Length > 0) Then
                oProveedor.IdPersona = Convert.ToInt32(txtIdPersona.Text)
            End If

            oProveedor.nombre = txtNombre.Text
            oProveedor.Ap_Paterno = txtApellidoPaterno.Text
            oProveedor.Ap_Materno = txtApellidoMaterno.Text
            oProveedor.NombreEmpresa = txtNombreEmpresa.Text
            oProveedor.NombreContacto = txtNombreContacto.Text
            oProveedor.Direccion = txtDireccion.Text
            oProveedor.Telefono = txtTelefono.Text
            oProveedor.email = txtCorreo.Text


        Catch ex As Exception

        End Try

    End Sub

    Public Overrides Sub ProcesoModificar()
        If ((txtIdPersona.Text <> "")) Then

            IdPersona = Convert.ToInt32(txtIdPersona.Text)
            MyBase.ProcesoModificar()
            tpRegistro.Enabled = True
            txtNombre.Focus()
        Else
            MessageBox.Show("Busque un registro para modificar")
        End If
    End Sub

    Public Overrides Sub ProcesoEliminar()
        If ((txtIdPersona.Text <> "" And IdPersona > 0)) Then
            ObjProveedorActual.IdPersona = Convert.ToDecimal(txtIdPersona.Text)
            If MessageBox.Show("Esta Seguro que desea ELIMINAR el REGISTRO", "ELIMINAR", MessageBoxButtons.OKCancel) = Windows.Forms.DialogResult.OK Then
                ObjProveedorActual.Eliminar()
                MessageBox.Show("Se ha Eliminado correctamente")
            End If

        Else
            MessageBox.Show("Busque un registro para eliminar")
        End If
    End Sub
    Public Overrides Sub ProcesoNuevo()


        MyBase.ProcesoNuevo()
        IdPersona = 0

        txtIdPersona.Clear()
        txtNombre.Clear()
        txtApellidoPaterno.Clear()
        txtApellidoMaterno.Clear()
        txtNombreEmpresa.Clear()
        txtNombreContacto.Clear()
        txtDireccion.Clear()
        txtTelefono.Clear()
        txtCorreo.Clear()
        tpRegistro.Enabled = True
        TabControlDatos.SelectedTab = tpRegistro


        txtNombre.Focus()

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
        If (txtNombre.Text.Trim().Length = 0) Then
            epError.SetError(txtNombre, "Ingrese el nombre del Proveedor")
            sw = False
        End If

        If (txtApellidoPaterno.Text.Trim().Length = 0) Then
            epError.SetError(txtApellidoPaterno, "Ingrese la Descripcion del Proveedor")
            sw = False
        End If


        Return sw

    End Function

    Private Sub dgvListado_RowHeaderMouseDoubleClick(ByVal sender As Object, ByVal e As DataGridViewCellMouseEventArgs) Handles dgvListado.RowHeaderMouseDoubleClick
        If e.RowIndex >= 0 And e.RowIndex <= dgvListado.Rows.Count - 1 Then
            LimpiarEntradas()
            txtIdPersona.Text = dgvListado.Item(0, e.RowIndex).Value
            txtNombre.Text = dgvListado.Item("nombre", e.RowIndex).Value
            txtApellidoPaterno.Text = dgvListado.Item("Ap_Paterno", e.RowIndex).Value
            txtApellidoMaterno.Text = dgvListado.Item("Ap_Materno", e.RowIndex).Value
            txtNombreEmpresa.Text = dgvListado.Item("NombreEmpresa", e.RowIndex).Value
            txtNombreContacto.Text = dgvListado.Item("NombreContacto", e.RowIndex).Value
            txtDireccion.Text = dgvListado.Item("Direccion", e.RowIndex).Value
            txtTelefono.Text = dgvListado.Item("Telefono", e.RowIndex).Value
            txtCorreo.Text = dgvListado.Item("email", e.RowIndex).Value



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
End Class
