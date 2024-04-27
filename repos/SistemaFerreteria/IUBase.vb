Public Class IUBase

#Region "Metodos"



    Public Overridable Sub ProcesoNuevo()
        LimpiarEntradas()
        HabilitarEntradas(True)
        HabilitarOperaciones(False)


        'habilitarAceptarCancelar(True)
        'habilitarBuscarImprimir(False)
        'Estado = Utilitarios.EstadoABM._EstadoABM.Guardar
        'sslblEstado.Text = "Nuevo registro"
        'sslblMensaje.Text = "Editando un nuevo registro"

    End Sub
    Public Overridable Sub ProcesoModificar()

        HabilitarEntradas(True)
        HabilitarOperaciones(False)
        'habilitarAceptarCancelar(True)
        HabilitarBuscarImprimir(False)
        'Estado = Utilitarios.EstadoABM._EstadoABM.Modificar
        sslblEstado.Text = "Modificar registro"
        sslblMensaje.Text = "Modificando el registro"

    End Sub
    Public Overridable Sub ProcesoEliminar()

        HabilitarEntradas(False)
        HabilitarOperaciones(False)
        'habilitarAceptarCancelar(True)
        HabilitarBuscarImprimir(False)
        'Estado = Utilitarios.EstadoABM._EstadoABM.Eliminar
        sslblEstado.Text = "Eliminar registro"
        sslblMensaje.Text = "Eliminando el registro actual"

    End Sub

    'Public Overridable Sub Guardar()


    'End Sub
    Public Overridable Sub Cancelar()

        HabilitarEntradas(False)
        HabilitarOperaciones(False)
        'Estado = Utilitarios.EstadoABM._EstadoABM.Consultar
        sslblEstado.Text = ""
        sslblMensaje.Text = ""
    End Sub
    Public Overridable Sub Eliminar()


    End Sub
    'Public Overridable Sub Modificar()


    'End Sub

    ''' <summary>
    ''' Acepta el proceso en curso puede ser:
    ''' Guardar;Modificar o Eliminar 
    ''' </summary>
    ''' <remarks></remarks>
    Public Overridable Sub ProcesoAceptar()
        Try
            'Select Case Estado
            '    'Case Utilitario.Utilitarios._ABM.Guardar : Guardar()
            '    'Case Utilitario.Utilitarios._ABM.Modificar : Modificar()
            '    'Case Utilitarios.EstadoABM._EstadoABM.Eliminar : Eliminar()
            'End Select

        Catch ex As Exception

        End Try
    End Sub
    Public Overridable Sub ProcesoCancelar()
        Try
            Me.HabilitarOperaciones(True)
            'Me.HabilitarAceptarCancelar(False)

        Catch ex As Exception

        End Try
    End Sub
    Public Overridable Sub ProcesarConsulta()

        HabilitarEntradas(False)
        HabilitarOperaciones(True)
        'habilitarAceptarCancelar(False)
        HabilitarBuscarImprimir(True)
        LimpiarEntradas()
        'Estado = Utilitarios.EstadoABM._EstadoABM.Consultar
        sslblEstado.Text = "Consulta"
        sslblMensaje.Text = ""
    End Sub
    Public Overridable Sub ProcesoListar()

    End Sub
    Public Overridable Sub ProcesoBuscar()

    End Sub
    Public Overridable Sub ProcesoImprimir()


    End Sub
    Public Overridable Sub ProcesoCerrar()
        Close()
    End Sub

    Public Overridable Sub HabilitarEntradas(ByVal value As Boolean)


    End Sub
    Public Overridable Sub LimpiarEntradas()

    End Sub
    ''' <summary>
    '''  btnNuevo.Enabled = value
    '''  btnModificar.Enabled = value
    '''  btnEliminar.Enabled = value
    '''  btnAceptar.Enabled = Not value
    '''  btnCancelar.Enabled = Not value
    ''' </summary>
    ''' <param name="value"></param>
    ''' <remarks></remarks>
    Public Overridable Sub HabilitarOperaciones(ByVal value As Boolean)
        ssEstado.Enabled = value
        tsbtnModificar.Enabled = value
        tsbtnEliminar.Enabled = value

        tsbtnAceptar.Enabled = Not value
        tsbtnCancelar.Enabled = Not value
    End Sub
    'Public Overridable Sub HabilitarAceptarCancelar(ByVal value As Boolean)
    '    btnNuevo.Enabled = Not value
    '    btnModificar.Enabled = Not value
    '    btnEliminar.Enabled = Not value

    '    btnAceptar.Enabled = value
    '    btnCancelar.Enabled = value
    'End Sub
    Public Overridable Sub HabilitarBuscarImprimir(ByVal value As Boolean)
        'tsbtnBuscar.Enabled = value
        ''tsbtnImprimir.Enabled = value
    End Sub

    Public Overridable Sub MostrarPanelBotones(ByVal bool As Boolean)
        Me.tsBotones.Visible = bool
        Me.ssEstado.Visible = bool
    End Sub

#Region "Seguridad sobre registros"

    ''' <summary>
    ''' Muestra los datos de un registro, quien lo creo y quien lo modifico con sus fecha y horas respectivas
    ''' </summary>
    ''' <param name="IdUsuarioCreador"></param>
    ''' <param name="FechaCreado"></param>
    ''' <param name="IdUsuarioModificador"></param>
    ''' <param name="FechaModificado"></param>
    ''' <remarks></remarks>
    Public Overridable Sub MostrarSeguridad(ByVal IdUsuarioCreador As Integer, ByVal FechaCreado As Date, ByVal IdUsuarioModificador As Integer, ByVal FechaModificado As Date)
        Try
            'Me.sslblUsuarioCreado.Visible = False
            'Me.sslblCreadoPor.Visible = False
            'Me.sslblFechaCreado.Visible = False

            'Me.sslblUsuarioModificador.Visible = False
            'Me.sslblModificadoPor.Visible = False
            'Me.sslblFechaModificado.Visible = False

            'If IdUsuarioCreador > 0 Then
            '    Dim oUsuarioCreador As New NEGOCIO.guUsuario
            '    oUsuarioCreador.IdUsuario = IdUsuarioCreador
            '    oUsuarioCreador.ObtenerRegistro()

            '    Me.sslblUsuarioCreador.Tag = oUsuarioCreador.IdUsuario
            '    Me.sslblUsuarioCreador.Text = oUsuarioCreador.Usuario
            '    Me.sslblFechaCreado.Text = FechaCreado.ToString
            '    Me.sslblUsuarioCreador.Visible = True
            '    Me.sslblCreadoPor.Visible = True
            '    Me.sslblFechaCreado.Visible = True

            '    If IdUsuarioModificador > 0 Then
            '        Dim oUsuarioModificador As New NEGOCIO.guUsuario
            '        oUsuarioModificador.IdUsuario = IdUsuarioCreador
            '        oUsuarioModificador.ObtenerRegistro()

            '        Me.sslblUsuarioModificador.Tag = oUsuarioModificador.IdUsuario
            '        Me.sslblUsuarioModificador.Text = oUsuarioModificador.Usuario
            '        Me.sslblFechaModificado.Text = FechaModificado.ToString

            '        Me.sslblUsuarioModificador.Visible = True
            '        Me.sslblModificadoPor.Visible = True
            '        Me.sslblFechaModificado.Visible = True

            '    End If

            'End If

        Catch ex As Exception

        End Try
    End Sub


    Public Overridable Function DevolverIdCreador() As Integer
        Try
            ''Return Convert.ToInt32(Me.sslblUsuarioCreador..Tag)
            Return True
        Catch ex As Exception
            Return Nothing
        End Try
    End Function

    Public Overridable Function DevolverFechaCreado() As Date
        Try
            Return Convert.ToDateTime(Me.sslblFechaCreado.Text)
        Catch ex As Exception
            Return Nothing
        End Try
    End Function

    Public Overridable Function DevolverIdModificador() As Integer
        Try
            Return Convert.ToInt32(Me.sslblUsuarioModificador.Tag)
        Catch ex As Exception
            Return Nothing
        End Try
    End Function

    Public Overridable Function DevolverFechaModificado() As Date
        Try
            Return Convert.ToDateTime(Me.sslblFechaModificado.Text)
        Catch ex As Exception
            Return Nothing
        End Try
    End Function

#End Region

#End Region


#Region "Eventos"
    Private Sub IUBase_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
        ProcesarConsulta()
    End Sub

    Private Sub tsbtnNuevo_Click(sender As Object, e As EventArgs) Handles tsbtnNuevo.Click
        ProcesoNuevo()
    End Sub

    Private Sub tsbtnModificar_Click(sender As Object, e As EventArgs) Handles tsbtnModificar.Click
        ProcesoModificar()
    End Sub


    Private Sub tsbtnEliminar_Click(sender As Object, e As EventArgs) Handles tsbtnEliminar.Click
        ProcesoEliminar()
    End Sub


    Private Sub tsbtnAceptar_Click(sender As Object, e As EventArgs) Handles tsbtnAceptar.Click
        ProcesoAceptar()
    End Sub




    Private Sub tsbtnCancelar_Click(sender As Object, e As EventArgs) Handles tsbtnCancelar.Click
        ProcesoCancelar()
    End Sub















    ''Private Sub btnBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscar.Click
    ''    ProcesoBuscar()
    ''End Sub

    ''Private Sub btnImprimir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnImprimir.Click
    ''    ProcesoImprimir()
    ''End Sub

    ''Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click
    ''    ProcesoCerrar()
    ''End Sub
#End Region
End Class