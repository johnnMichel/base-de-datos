Imports System.Data
Imports System.Data.SqlClient
' Creado por Ing. David Ribera Blanco
' Celular:   72130344
' E-Mail:    davidriberablanco@hotmail.com
' Fecha y Hora 24/4/2024 19:46:44
' Negocio para la tabla Compra
Public Class Compra
    Inherits CONEXION.DAC

#Region "Atributos" 
       private m_IdCompra as Int32
       private m_fkIdProveedor as Int32
       private m_fkIdUsuario as Int32
       private m_Tipo_Comprobante as String
       private m_Serie_Comprobante as String
       private m_Num_Comprobante as String
       private m_Fecha as DateTime
       private m_Impuesto as Decimal
       private m_Total as Decimal
       private m_Estado as Boolean
#End Region

   #region "Propiedades" 
       Public Property IdCompra() As Int32
           Get
               Return m_IdCompra
           End Get

           Set(ByVal value As Int32)
               m_IdCompra = value
           End Set
       End Property

       Public Property fkIdProveedor() As Int32
           Get
               Return m_fkIdProveedor
           End Get

           Set(ByVal value As Int32)
               m_fkIdProveedor = value
           End Set
       End Property

       Public Property fkIdUsuario() As Int32
           Get
               Return m_fkIdUsuario
           End Get

           Set(ByVal value As Int32)
               m_fkIdUsuario = value
           End Set
       End Property

       Public Property Tipo_Comprobante() As String
           Get
               Return m_Tipo_Comprobante
           End Get

           Set(ByVal value As String)
               m_Tipo_Comprobante = value
           End Set
       End Property

       Public Property Serie_Comprobante() As String
           Get
               Return m_Serie_Comprobante
           End Get

           Set(ByVal value As String)
               m_Serie_Comprobante = value
           End Set
       End Property

       Public Property Num_Comprobante() As String
           Get
               Return m_Num_Comprobante
           End Get

           Set(ByVal value As String)
               m_Num_Comprobante = value
           End Set
       End Property

       Public Property Fecha() As DateTime
           Get
               Return m_Fecha
           End Get

           Set(ByVal value As DateTime)
               m_Fecha = value
           End Set
       End Property

       Public Property Impuesto() As Decimal
           Get
               Return m_Impuesto
           End Get

           Set(ByVal value As Decimal)
               m_Impuesto = value
           End Set
       End Property

       Public Property Total() As Decimal
           Get
               Return m_Total
           End Get

           Set(ByVal value As Decimal)
               m_Total = value
           End Set
       End Property

       Public Property Estado() As Boolean
           Get
               Return m_Estado
           End Get

           Set(ByVal value As Boolean)
               m_Estado = value
           End Set
       End Property

   #End Region

   #region "Metodos" 
   Public Function Insertar() As Integer
       DIM sInsert As String
       DIM listPrm As List(Of SqlParameter)
       DIM trn As SqlTransaction= Me.IniciarTransaccion()
       Try
           sInsert = "pCompraAdd"
           listPrm=CONEXION.DAC.CargarListaParametros("@IdCompra", IdCompra, "@fkIdProveedor", fkIdProveedor, "@fkIdUsuario", fkIdUsuario, "@Tipo_Comprobante", Tipo_Comprobante, "@Serie_Comprobante", Serie_Comprobante, "@Num_Comprobante", Num_Comprobante, "@Fecha", Fecha, "@Impuesto", Impuesto, "@Total", Total, "@Estado", Estado)
           m_IdCompra = EjecutarInsertProc(sInsert,ListPrm,trn)
       Me.TerminarTransaccion(trn)
       Return m_IdCompra
       Catch ex As DataException
           If Not IsNothing(trn)Then
       Me.AbortarTransaccion(trn)
           End If
           Throw
       End Try
   End Function 

   Public Sub Modificar()
       DIM sUpdate AS String
       DIM listPrm As List(Of SqlParameter)
       Try
           sUpdate = "pCompraUpd"
           listPrm=CONEXION.DAC.CargarListaParametros("@IdCompra", IdCompra, "@fkIdProveedor", fkIdProveedor, "@fkIdUsuario", fkIdUsuario, "@Tipo_Comprobante", Tipo_Comprobante, "@Serie_Comprobante", Serie_Comprobante, "@Num_Comprobante", Num_Comprobante, "@Fecha", Fecha, "@Impuesto", Impuesto, "@Total", Total, "@Estado", Estado)
           EjecutarProc(sUpdate,ListPrm)
       Catch ex As DataException
           Throw
       End Try
   End Sub 

   Public Sub Eliminar()
       DIM sDelete AS String
       DIM listPrm As List(Of SqlParameter)
       Try
           sDelete = "pCompraDel"
           listPrm=CONEXION.DAC.CargarListaParametros("@IdCompra" ,m_IdCompra)
           EjecutarProc(sDelete,ListPrm)
       Catch ex As DataException
           Throw
       End Try
   End Sub 

   Public Function Traer(ByVal filtro As String) as DataTable
       If filtro = String.Empty Then
           Return Consultar("SELECT * FROM Compra").Tables(0)
       Else
           Return Consultar("SELECT * FROM Compra WHERE  " & filtro).Tables(0)
       End If
   End Function

   Public Function Traer(ByVal Columnas As String, ByVal Filtro As String) as DataTable
       If Filtro.Trim = String.Empty Then
           If Columnas.Trim = String.Empty Then
               Return Consultar("SELECT * FROM Compra").Tables(0)
           Else
               Return Consultar("SELECT " & Columnas  & " FROM Compra").Tables(0)
           End If
       Else
           If Columnas.Trim = String.Empty Then
               Return Consultar("SELECT * FROM Compra WHERE " & Filtro & " ").Tables(0)
           Else
               Return Consultar("SELECT " & Columnas  &  "  FROM Compra WHERE " &  Filtro & " ").Tables(0)
           End If
       End If
   End Function

   ''' <summary>
   ''' Busca y Carga la clase a partir de la llave primaria de la tabla
   ''' Cargar llave primaria 'IdCompra' para traer los datos del registro
   ''' </summary>
   ''' <remarks></remarks>
   Public Sub ObtenerRegistro()
       Dim dt As DataTable = Traer("IdCompra=" & m_IdCompra)
       If dt.Rows.Count > 0 Then
           Dim dr As DataRow = dt.Rows(0)
            m_IdCompra=dr.Item("IdCompra")
            m_fkIdProveedor=dr.Item("fkIdProveedor")
            m_fkIdUsuario=dr.Item("fkIdUsuario")
            m_Tipo_Comprobante=dr.Item("Tipo_Comprobante")
            m_Serie_Comprobante=IIF(IsDBNull(dr.Item("Serie_Comprobante"))= False,dr.Item("Serie_Comprobante"),"")
            m_Num_Comprobante=dr.Item("Num_Comprobante")
            m_Fecha=dr.Item("Fecha")
            m_Impuesto=dr.Item("Impuesto")
            m_Total=dr.Item("Total")
            m_Estado=dr.Item("Estado")

       Else
           m_IdCompra = 0
       End If
   End Sub
   #End Region
   end class
