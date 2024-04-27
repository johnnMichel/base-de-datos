Public Class IUCategoria
#Region "Variables Locales"
    Private Indice As Integer
    Private IdCategoria As Integer = 0
    Private ObjCategoriaActual As New NEGOCIO.Categoria()
    Private dtLista As DataTable
#End Region


    Private Sub IUCategoria_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MostrarPanelBotones(True)
        'MyBase.btnImprimir.Visible = False
        ListarRegistros()

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
            Dim oCategoria As New NEGOCIO.Categoria
            Dim dtCategoria As DataTable
            dtCategoria = oCategoria.Traer("")
            dgvListado.DataSource = dtCategoria


        Catch ex As Exception

        End Try
    End Sub

    Public Overrides Sub procesoListar()

        MyBase.ProcesoListar()
        If Me.txtCriterio.Text.Trim.Length > 0 Then
            Me.dtLista = ObjCategoriaActual.Traer(" Nombre like '%" & Me.txtCriterio.Text & "%'  ")
        Else
            Me.dtLista = ObjCategoriaActual.Traer("")
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
        txtIdCategoria.Enabled = False

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

        Dim oCategoria As New NEGOCIO.Categoria()
        LeerDatos(oCategoria)
        Try
            If (IdCategoria = 0) Then
                oCategoria.Insertar()
                txtIdCategoria.Text = Convert.ToString(oCategoria.IdCategoria)
                MsgBox("Guardado correctamente", MsgBoxStyle.Information)
            Else
                oCategoria.Modificar()
                MsgBox("Modificado correctamente", MsgBoxStyle.Information)
            End If
            LimpiarEntradas()
            tpRegistro.Enabled = False
            ListarRegistros()
            TabControlDatos.SelectedTab = tpRegistro

            MyBase.HabilitarOperaciones(True)
        Catch ex As Exception
            MsgBox("Error al guardar el Categoria: " + ex.ToString(), MsgBoxStyle.Critical)
        End Try

    End Sub

    Public Overrides Sub ProcesoCancelar()

        MyBase.Cancelar()
        MyBase.HabilitarOperaciones(True)
    End Sub

    Public Overrides Sub Eliminar()
        Try
            If (MessageBox.Show("Confirma la Eliminarcion", "ELIMINAR", MessageBoxButtons.OKCancel) = DialogResult.OK) Then
                Dim oCategoria As New NEGOCIO.Categoria()
                LeerDatos(oCategoria)
                oCategoria.Eliminar()
                MessageBox.Show("Eliminado correctamente")
                ProcesarConsulta()

            End If

        Catch ex As Exception


            Throw New Exception("Error al eliminar el Categoria")
        End Try
    End Sub

    Public Sub LeerDatos(ByRef oCategoria As NEGOCIO.Categoria)

        Try
            If (txtIdCategoria.Text.Trim.Length > 0) Then
                oCategoria.IdCategoria = Convert.ToInt32(txtIdCategoria.Text)
            End If

            oCategoria.nombre = txtNombre.Text
            oCategoria.descripcion = txtDescripcion.Text
            If rbtnActivo.Checked Then
                oCategoria.estado = True

            ElseIf rbtnInactivo.Checked Then

                oCategoria.estado = False
            End If

        Catch ex As Exception

        End Try

    End Sub

    Public Overrides Sub ProcesoModificar()
        If ((txtIdCategoria.Text <> "")) Then

            IdCategoria = Convert.ToInt32(txtIdCategoria.Text)
            MyBase.ProcesoModificar()
            tpRegistro.Enabled = True
            txtNombre.Focus()
        Else
            MessageBox.Show("Busque un registro para modificar")
        End If
    End Sub

    Public Overrides Sub ProcesoEliminar()
        If ((txtIdCategoria.Text <> "" And IdCategoria > 0)) Then
            ObjCategoriaActual.IdCategoria = Convert.ToDecimal(txtIdCategoria.Text)
            If MessageBox.Show("Esta Seguro que desea ELIMINAR el REGISTRO", "ELIMINAR", MessageBoxButtons.OKCancel) = Windows.Forms.DialogResult.OK Then
                ObjCategoriaActual.Eliminar()
                MessageBox.Show("Se ha Eliminado correctamente")
            End If

        Else
            MessageBox.Show("Busque un registro para eliminar")
        End If
    End Sub
    Public Overrides Sub ProcesoNuevo()


        MyBase.ProcesoNuevo()
        IdCategoria = 0

        txtIdCategoria.Clear()
        txtNombre.Clear()
        txtDescripcion.Clear()
        rbtnActivo.Checked = True
        TabControlDatos.Enabled = True


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
            epError.SetError(txtNombre, "Ingrese el nombre del Categoria")
            sw = False
        End If

        If (txtDescripcion.Text.Trim().Length = 0) Then
            epError.SetError(txtDescripcion, "Ingrese la Descripcion del Categoria")
            sw = False
        End If

        If (rbtnActivo.Checked = rbtnInactivo.Checked) Then
            epError.SetError(rbtnActivo, "Seleccione estado estado")
            sw = False
        End If

        Return sw

    End Function

    Private Sub dgvListado_RowHeaderMouseDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles dgvListado.RowHeaderMouseDoubleClick
        If e.RowIndex >= 0 And e.RowIndex <= Me.dgvListado.Rows.Count - 1 Then
            Me.LimpiarEntradas()
            Me.txtIdCategoria.Text = Me.dgvListado.Item(0, e.RowIndex).Value
            Me.txtNombre.Text = Me.dgvListado.Item("nombre", e.RowIndex).Value
            Me.txtDescripcion.Text = Me.dgvListado.Item("descripcion", e.RowIndex).Value

            If Me.dgvListado.Item("Estado", e.RowIndex).Value = True Then
                Me.rbtnActivo.Checked = True
                Me.rbtnInactivo.Checked = False
            Else
                Me.rbtnActivo.Checked = False
                Me.rbtnInactivo.Checked = True
            End If

            'Me.gbDatos.Enabled = False
            Me.TabControlDatos.SelectedTab = tpRegistro

        End If
    End Sub

    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        Try
            procesoListar()
        Catch ex As Exception

        End Try
    End Sub
End Class