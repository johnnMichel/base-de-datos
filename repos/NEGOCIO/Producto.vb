Imports System.Data
Imports System.Data.SqlClient
' Creado por Ing. David Ribera Blanco
' Celular:   72130344
' E-Mail:    davidriberablanco@hotmail.com
' Fecha y Hora 27/3/2024 21:46:31
' Negocio para la tabla Producto
Public Class Producto
    Inherits CONEXION.DAC

#Region "Atributos" 
       private m_IdProducto as Int32
       private m_fkIdCategoria as Int32
       private m_Codigo as String
       private m_Nombre as String
       private m_Precio_Compra as Decimal
       private m_Fecha_Ultima_Compra as DateTime
       private m_Precio_Venta as Decimal
       private m_Stock as Int32
       private m_Descripcion as String
       private m_Estado as Boolean
#End Region

   #region "Propiedades" 
       Public Property IdProducto() As Int32
           Get
               Return m_IdProducto
           End Get

           Set(ByVal value As Int32)
               m_IdProducto = value
           End Set
       End Property

       Public Property fkIdCategoria() As Int32
           Get
               Return m_fkIdCategoria
           End Get

           Set(ByVal value As Int32)
               m_fkIdCategoria = value
           End Set
       End Property

       Public Property Codigo() As String
           Get
               Return m_Codigo
           End Get

           Set(ByVal value As String)
               m_Codigo = value
           End Set
       End Property

       Public Property Nombre() As String
           Get
               Return m_Nombre
           End Get

           Set(ByVal value As String)
               m_Nombre = value
           End Set
       End Property

       Public Property Precio_Compra() As Decimal
           Get
               Return m_Precio_Compra
           End Get

           Set(ByVal value As Decimal)
               m_Precio_Compra = value
           End Set
       End Property

       Public Property Fecha_Ultima_Compra() As DateTime
           Get
               Return m_Fecha_Ultima_Compra
           End Get

           Set(ByVal value As DateTime)
               m_Fecha_Ultima_Compra = value
           End Set
       End Property

       Public Property Precio_Venta() As Decimal
           Get
               Return m_Precio_Venta
           End Get

           Set(ByVal value As Decimal)
               m_Precio_Venta = value
           End Set
       End Property

       Public Property Stock() As Int32
           Get
               Return m_Stock
           End Get

           Set(ByVal value As Int32)
               m_Stock = value
           End Set
       End Property

       Public Property Descripcion() As String
           Get
               Return m_Descripcion
           End Get

           Set(ByVal value As String)
               m_Descripcion = value
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
           sInsert = "pProductoAdd"
           listPrm=CONEXION.DAC.CargarListaParametros("@IdProducto", IdProducto, "@fkIdCategoria", fkIdCategoria, "@Codigo", Codigo, "@Nombre", Nombre, "@Precio_Compra", Precio_Compra, "@Fecha_Ultima_Compra", Fecha_Ultima_Compra, "@Precio_Venta", Precio_Venta, "@Stock", Stock, "@Descripcion", Descripcion, "@Estado", Estado)
           m_IdProducto = EjecutarInsertProc(sInsert,ListPrm,trn)
       Me.TerminarTransaccion(trn)
       Return m_IdProducto
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
           sUpdate = "pProductoUpd"
           listPrm=CONEXION.DAC.CargarListaParametros("@IdProducto", IdProducto, "@fkIdCategoria", fkIdCategoria, "@Codigo", Codigo, "@Nombre", Nombre, "@Precio_Compra", Precio_Compra, "@Fecha_Ultima_Compra", Fecha_Ultima_Compra, "@Precio_Venta", Precio_Venta, "@Stock", Stock, "@Descripcion", Descripcion, "@Estado", Estado)
           EjecutarProc(sUpdate,ListPrm)
       Catch ex As DataException
           Throw
       End Try
   End Sub 

   Public Sub Eliminar()
       DIM sDelete AS String
       DIM listPrm As List(Of SqlParameter)
       Try
           sDelete = "pProductoDel"
           listPrm=CONEXION.DAC.CargarListaParametros("@IdProducto" ,m_IdProducto)
           EjecutarProc(sDelete,ListPrm)
       Catch ex As DataException
           Throw
       End Try
   End Sub 

   Public Function Traer(ByVal filtro As String) as DataTable
       If filtro = String.Empty Then
           Return Consultar("SELECT * FROM Producto").Tables(0)
       Else
           Return Consultar("SELECT * FROM Producto WHERE  " & filtro).Tables(0)
       End If
   End Function

   Public Function Traer(ByVal Columnas As String, ByVal Filtro As String) as DataTable
       If Filtro.Trim = String.Empty Then
           If Columnas.Trim = String.Empty Then
               Return Consultar("SELECT * FROM Producto").Tables(0)
           Else
               Return Consultar("SELECT " & Columnas  & " FROM Producto").Tables(0)
           End If
       Else
           If Columnas.Trim = String.Empty Then
               Return Consultar("SELECT * FROM Producto WHERE " & Filtro & " ").Tables(0)
           Else
               Return Consultar("SELECT " & Columnas  &  "  FROM Producto WHERE " &  Filtro & " ").Tables(0)
           End If
       End If
   End Function

   ''' <summary>
   ''' Busca y Carga la clase a partir de la llave primaria de la tabla
   ''' Cargar llave primaria 'IdProducto' para traer los datos del registro
   ''' </summary>
   ''' <remarks></remarks>
   Public Sub ObtenerRegistro()
       Dim dt As DataTable = Traer("IdProducto=" & m_IdProducto)
       If dt.Rows.Count > 0 Then
           Dim dr As DataRow = dt.Rows(0)
            m_IdProducto=dr.Item("IdProducto")
            m_fkIdCategoria=dr.Item("fkIdCategoria")
            m_Codigo=IIF(IsDBNull(dr.Item("Codigo"))= False,dr.Item("Codigo"),"")
            m_Nombre=dr.Item("Nombre")
            m_Precio_Compra=IIF(IsDBNull(dr.Item("Precio_Compra"))= False,dr.Item("Precio_Compra"),0)
            m_Fecha_Ultima_Compra=IIF(IsDBNull(dr.Item("Fecha_Ultima_Compra"))= False,dr.Item("Fecha_Ultima_Compra"),"01/01/1900")
            m_Precio_Venta=dr.Item("Precio_Venta")
            m_Stock=dr.Item("Stock")
            m_Descripcion=IIF(IsDBNull(dr.Item("Descripcion"))= False,dr.Item("Descripcion"),"")
            m_Estado=IIF(IsDBNull(dr.Item("Estado"))= False,dr.Item("Estado"),False)

       Else
           m_IdProducto = 0
       End If
   End Sub
   #End Region
   end class
