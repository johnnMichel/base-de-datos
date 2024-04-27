Imports System.Data
Imports System.Data.SqlClient


' Creado por Ing. David Ribera Blanco
' Celular:   72130344
' E-Mail:    davidriberablanco@hotmail.com
' Fecha y Hora 27/3/2024 21:46:31
' Negocio para la tabla Categoria
Public Class Categoria
    Inherits CONEXION.DAC

#Region "Atributos" 
       private m_IdCategoria as Int32
       private m_nombre as String
       private m_descripcion as String
       private m_estado as Boolean
#End Region

   #region "Propiedades" 
       Public Property IdCategoria() As Int32
           Get
               Return m_IdCategoria
           End Get

           Set(ByVal value As Int32)
               m_IdCategoria = value
           End Set
       End Property

       Public Property nombre() As String
           Get
               Return m_nombre
           End Get

           Set(ByVal value As String)
               m_nombre = value
           End Set
       End Property

       Public Property descripcion() As String
           Get
               Return m_descripcion
           End Get

           Set(ByVal value As String)
               m_descripcion = value
           End Set
       End Property

       Public Property estado() As Boolean
           Get
               Return m_estado
           End Get

           Set(ByVal value As Boolean)
               m_estado = value
           End Set
       End Property

   #End Region

   #region "Metodos" 
   Public Function Insertar() As Integer
       DIM sInsert As String
       DIM listPrm As List(Of SqlParameter)
       DIM trn As SqlTransaction= Me.IniciarTransaccion()
       Try
           sInsert = "pCategoriaAdd"
           listPrm=CONEXION.DAC.CargarListaParametros("@IdCategoria", IdCategoria, "@nombre", nombre, "@descripcion", descripcion, "@estado", estado)
           m_IdCategoria = EjecutarInsertProc(sInsert,ListPrm,trn)
       Me.TerminarTransaccion(trn)
       Return m_IdCategoria
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
           sUpdate = "pCategoriaUpd"
           listPrm=CONEXION.DAC.CargarListaParametros("@IdCategoria", IdCategoria, "@nombre", nombre, "@descripcion", descripcion, "@estado", estado)
           EjecutarProc(sUpdate,ListPrm)
       Catch ex As DataException
           Throw
       End Try
   End Sub 

   Public Sub Eliminar()
       DIM sDelete AS String
       DIM listPrm As List(Of SqlParameter)
       Try
           sDelete = "pCategoriaDel"
           listPrm=CONEXION.DAC.CargarListaParametros("@IdCategoria" ,m_IdCategoria)
           EjecutarProc(sDelete,ListPrm)
       Catch ex As DataException
           Throw
       End Try
   End Sub 

   Public Function Traer(ByVal filtro As String) as DataTable
       If filtro = String.Empty Then
           Return Consultar("SELECT * FROM Categoria").Tables(0)
       Else
           Return Consultar("SELECT * FROM Categoria WHERE  " & filtro).Tables(0)
       End If
   End Function

   Public Function Traer(ByVal Columnas As String, ByVal Filtro As String) as DataTable
       If Filtro.Trim = String.Empty Then
           If Columnas.Trim = String.Empty Then
               Return Consultar("SELECT * FROM Categoria").Tables(0)
           Else
               Return Consultar("SELECT " & Columnas  & " FROM Categoria").Tables(0)
           End If
       Else
           If Columnas.Trim = String.Empty Then
               Return Consultar("SELECT * FROM Categoria WHERE " & Filtro & " ").Tables(0)
           Else
               Return Consultar("SELECT " & Columnas  &  "  FROM Categoria WHERE " &  Filtro & " ").Tables(0)
           End If
       End If
   End Function

   ''' <summary>
   ''' Busca y Carga la clase a partir de la llave primaria de la tabla
   ''' Cargar llave primaria 'IdCategoria' para traer los datos del registro
   ''' </summary>
   ''' <remarks></remarks>
   Public Sub ObtenerRegistro()
       Dim dt As DataTable = Traer("IdCategoria=" & m_IdCategoria)
       If dt.Rows.Count > 0 Then
           Dim dr As DataRow = dt.Rows(0)
            m_IdCategoria=dr.Item("IdCategoria")
            m_nombre=dr.Item("nombre")
            m_descripcion=IIF(IsDBNull(dr.Item("descripcion"))= False,dr.Item("descripcion"),"")
            m_estado=IIF(IsDBNull(dr.Item("estado"))= False,dr.Item("estado"),False)

       Else
           m_IdCategoria = 0
       End If
   End Sub
   #End Region
   end class
