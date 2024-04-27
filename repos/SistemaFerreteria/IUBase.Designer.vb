<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class IUBase
    Inherits System.Windows.Forms.Form

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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(IUBase))
        tsBotones = New ToolStrip()
        tsbtnNuevo = New ToolStripButton()
        tsbtnModificar = New ToolStripButton()
        tsbtnEliminar = New ToolStripButton()
        tsbtnAceptar = New ToolStripButton()
        tsbtnCancelar = New ToolStripButton()
        sslblEstado = New ToolStripStatusLabel()
        ssEstado = New StatusStrip()
        sslblMensaje = New ToolStripStatusLabel()
        sslblCreadoPor = New ToolStripStatusLabel()
        sslblUsuarioCreado = New ToolStripStatusLabel()
        sslblFechaCreado = New ToolStripStatusLabel()
        sslblModificadoPor = New ToolStripStatusLabel()
        sslblUsuarioModificador = New ToolStripStatusLabel()
        sslblFechaModificado = New ToolStripStatusLabel()
        epError = New ErrorProvider(components)
        tsBotones.SuspendLayout()
        ssEstado.SuspendLayout()
        CType(epError, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' tsBotones
        ' 
        tsBotones.Dock = DockStyle.Bottom
        tsBotones.ImageScalingSize = New Size(32, 32)
        tsBotones.Items.AddRange(New ToolStripItem() {tsbtnNuevo, tsbtnModificar, tsbtnEliminar, tsbtnAceptar, tsbtnCancelar})
        tsBotones.Location = New Point(0, 374)
        tsBotones.Name = "tsBotones"
        tsBotones.Size = New Size(800, 54)
        tsBotones.TabIndex = 3
        tsBotones.Text = "ToolStrip1"
        ' 
        ' tsbtnNuevo
        ' 
        tsbtnNuevo.Image = CType(resources.GetObject("tsbtnNuevo.Image"), Image)
        tsbtnNuevo.ImageTransparentColor = Color.Magenta
        tsbtnNuevo.Name = "tsbtnNuevo"
        tsbtnNuevo.Size = New Size(50, 51)
        tsbtnNuevo.Text = "NUEVO"
        tsbtnNuevo.TextImageRelation = TextImageRelation.ImageAboveText
        ' 
        ' tsbtnModificar
        ' 
        tsbtnModificar.Image = CType(resources.GetObject("tsbtnModificar.Image"), Image)
        tsbtnModificar.ImageTransparentColor = Color.Magenta
        tsbtnModificar.Name = "tsbtnModificar"
        tsbtnModificar.Size = New Size(48, 51)
        tsbtnModificar.Text = "EDITAR"
        tsbtnModificar.TextImageRelation = TextImageRelation.ImageAboveText
        ' 
        ' tsbtnEliminar
        ' 
        tsbtnEliminar.Image = CType(resources.GetObject("tsbtnEliminar.Image"), Image)
        tsbtnEliminar.ImageTransparentColor = Color.Magenta
        tsbtnEliminar.Name = "tsbtnEliminar"
        tsbtnEliminar.Size = New Size(64, 51)
        tsbtnEliminar.Text = "ELIMINAR"
        tsbtnEliminar.TextImageRelation = TextImageRelation.ImageAboveText
        ' 
        ' tsbtnAceptar
        ' 
        tsbtnAceptar.ForeColor = SystemColors.HotTrack
        tsbtnAceptar.Image = CType(resources.GetObject("tsbtnAceptar.Image"), Image)
        tsbtnAceptar.ImageTransparentColor = Color.Magenta
        tsbtnAceptar.Name = "tsbtnAceptar"
        tsbtnAceptar.Size = New Size(60, 51)
        tsbtnAceptar.Text = "ACEPTAR"
        tsbtnAceptar.TextImageRelation = TextImageRelation.ImageAboveText
        ' 
        ' tsbtnCancelar
        ' 
        tsbtnCancelar.ForeColor = Color.FromArgb(CByte(192), CByte(0), CByte(0))
        tsbtnCancelar.Image = CType(resources.GetObject("tsbtnCancelar.Image"), Image)
        tsbtnCancelar.ImageTransparentColor = Color.Magenta
        tsbtnCancelar.Name = "tsbtnCancelar"
        tsbtnCancelar.Size = New Size(71, 51)
        tsbtnCancelar.Text = "CANCELAR"
        tsbtnCancelar.TextImageRelation = TextImageRelation.ImageAboveText
        ' 
        ' sslblEstado
        ' 
        sslblEstado.Name = "sslblEstado"
        sslblEstado.Size = New Size(42, 17)
        sslblEstado.Text = "Estado"
        ' 
        ' ssEstado
        ' 
        ssEstado.Items.AddRange(New ToolStripItem() {sslblEstado, sslblMensaje, sslblCreadoPor, sslblUsuarioCreado, sslblFechaCreado, sslblModificadoPor, sslblUsuarioModificador, sslblFechaModificado})
        ssEstado.Location = New Point(0, 428)
        ssEstado.Name = "ssEstado"
        ssEstado.Size = New Size(800, 22)
        ssEstado.TabIndex = 2
        ssEstado.Text = "StatusStrip1"
        ' 
        ' sslblMensaje
        ' 
        sslblMensaje.Name = "sslblMensaje"
        sslblMensaje.Size = New Size(51, 17)
        sslblMensaje.Text = "Mensaje"
        ' 
        ' sslblCreadoPor
        ' 
        sslblCreadoPor.Name = "sslblCreadoPor"
        sslblCreadoPor.Size = New Size(66, 17)
        sslblCreadoPor.Text = "CreadoPor:"
        ' 
        ' sslblUsuarioCreado
        ' 
        sslblUsuarioCreado.Name = "sslblUsuarioCreado"
        sslblUsuarioCreado.Size = New Size(88, 17)
        sslblUsuarioCreado.Text = "UsuarioCreado:"
        ' 
        ' sslblFechaCreado
        ' 
        sslblFechaCreado.Name = "sslblFechaCreado"
        sslblFechaCreado.Size = New Size(79, 17)
        sslblFechaCreado.Text = "FechaCreado:"
        ' 
        ' sslblModificadoPor
        ' 
        sslblModificadoPor.Name = "sslblModificadoPor"
        sslblModificadoPor.Size = New Size(89, 17)
        sslblModificadoPor.Text = "ModificadoPor:"
        ' 
        ' sslblUsuarioModificador
        ' 
        sslblUsuarioModificador.Name = "sslblUsuarioModificador"
        sslblUsuarioModificador.Size = New Size(115, 17)
        sslblUsuarioModificador.Text = "UsuarioModificador:"
        ' 
        ' sslblFechaModificado
        ' 
        sslblFechaModificado.Name = "sslblFechaModificado"
        sslblFechaModificado.Size = New Size(102, 17)
        sslblFechaModificado.Text = "FechaModificado:"
        ' 
        ' epError
        ' 
        epError.ContainerControl = Me
        ' 
        ' IUBase
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(tsBotones)
        Controls.Add(ssEstado)
        Name = "IUBase"
        Text = "IUBase"
        tsBotones.ResumeLayout(False)
        tsBotones.PerformLayout()
        ssEstado.ResumeLayout(False)
        ssEstado.PerformLayout()
        CType(epError, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents tsBotones As ToolStrip
    Friend WithEvents tsbtnNuevo As ToolStripButton
    Friend WithEvents tsbtnModificar As ToolStripButton
    Friend WithEvents tsbtnEliminar As ToolStripButton
    Friend WithEvents tsbtnAceptar As ToolStripButton
    Friend WithEvents tsbtnCancelar As ToolStripButton
    Friend WithEvents sslblEstado As ToolStripStatusLabel
    Friend WithEvents ssEstado As StatusStrip
    Friend WithEvents sslblMensaje As ToolStripStatusLabel
    Friend WithEvents sslblCreadoPor As ToolStripStatusLabel
    Friend WithEvents sslblUsuarioCreado As ToolStripStatusLabel
    Friend WithEvents sslblFechaCreado As ToolStripStatusLabel
    Friend WithEvents sslblModificadoPor As ToolStripStatusLabel
    Friend WithEvents sslblUsuarioModificador As ToolStripStatusLabel
    Friend WithEvents sslblFechaModificado As ToolStripStatusLabel
    Friend WithEvents epError As ErrorProvider
End Class
