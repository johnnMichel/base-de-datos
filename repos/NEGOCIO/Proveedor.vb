Imports System.Data
Imports System.Data.SqlClient
' Creado por Ing. David Ribera Blanco
' Celular:   72130344
' E-Mail:    davidriberablanco@hotmail.com
' Fecha y Hora 27/3/2024 21:46:31
' Negocio para la tabla Proveedor
Public Class Proveedor
    Inherits CONEXION.DAC

#Region "Atributos" 
       private m_IdPersona as Int32
       private m_Nombre as String
       private m_Ap_Paterno as String
    Private m_Ap_Materno As String
    Private m_NombreEmpresa as String
       private m_NombreContacto as String
       private m_Direccion as String
       private m_Telefono as String
       private m_email as String
#End Region

   #region "Propiedades" 
       Public Property IdPersona() As Int32
           Get
               Return m_IdPersona
           End Get

           Set(ByVal value As Int32)
               m_IdPersona = value
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

       Public Property Ap_Paterno() As String
           Get
               Return m_Ap_Paterno
           End Get

           Set(ByVal value As String)
               m_Ap_Paterno = value
           End Set
       End Property

    Public Property Ap_Materno() As String
        Get
            Return m_Ap_Materno
        End Get

        Set(ByVal value As String)
            m_Ap_Materno = value
        End Set
    End Property

    Public Property NombreEmpresa() As String
           Get
               Return m_NombreEmpresa
           End Get

           Set(ByVal value As String)
               m_NombreEmpresa = value
           End Set
       End Property

       Public Property NombreContacto() As String
           Get
               Return m_NombreContacto
           End Get

           Set(ByVal value As String)
               m_NombreContacto = value
           End Set
       End Property

       Public Property Direccion() As String
           Get
               Return m_Direccion
           End Get

           Set(ByVal value As String)
               m_Direccion = value
           End Set
       End Property

       Public Property Telefono() As String
           Get
               Return m_Telefono
           End Get

           Set(ByVal value As String)
               m_Telefono = value
           End Set
       End Property

       Public Property email() As String
           Get
               Return m_email
           End Get

           Set(ByVal value As String)
               m_email = value
           End Set
       End Property

   #End Region

   #region "Metodos" 
   Public Function Insertar() As Integer
       DIM sInsert As String
       DIM listPrm As List(Of SqlParameter)
       DIM trn As SqlTransaction= Me.IniciarTransaccion()
       Try
           sInsert = "pProveedorAdd"
            listPrm = CONEXION.DAC.CargarListaParametros("@IdPersona", IdPersona, "@Nombre", Nombre, "@Ap_Paterno", Ap_Paterno, "@Ap_Materno", Ap_Materno, "@NombreEmpresa", NombreEmpresa, "@NombreContacto", NombreContacto, "@Direccion", Direccion, "@Telefono", Telefono, "@email", email)
            EjecutarProc(sInsert,ListPrm,trn)
       Me.TerminarTransaccion(trn)
       Return m_IdPersona
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
           sUpdate = "pProveedorUpd"
            listPrm = CONEXION.DAC.CargarListaParametros("@IdPersona", IdPersona, "@Nombre", Nombre, "@Ap_Paterno", Ap_Paterno, "@Ap_Materno", Ap_Materno, "@NombreEmpresa", NombreEmpresa, "@NombreContacto", NombreContacto, "@Direccion", Direccion, "@Telefono", Telefono, "@email", email)
            EjecutarProc(sUpdate,ListPrm)
       Catch ex As DataException
           Throw
       End Try
   End Sub 

   Public Sub Eliminar()
       DIM sDelete AS String
       DIM listPrm As List(Of SqlParameter)
       Try
           sDelete = "pProveedorDel"
           listPrm=CONEXION.DAC.CargarListaParametros("@IdPersona" ,m_IdPersona)
           EjecutarProc(sDelete,ListPrm)
       Catch ex As DataException
           Throw
       End Try
   End Sub 

   Public Function Traer(ByVal filtro As String) as DataTable
       If filtro = String.Empty Then
           Return Consultar("SELECT * FROM Proveedor").Tables(0)
       Else
           Return Consultar("SELECT * FROM Proveedor WHERE  " & filtro).Tables(0)
       End If
   End Function

   Public Function Traer(ByVal Columnas As String, ByVal Filtro As String) as DataTable
       If Filtro.Trim = String.Empty Then
           If Columnas.Trim = String.Empty Then
               Return Consultar("SELECT * FROM Proveedor").Tables(0)
           Else
               Return Consultar("SELECT " & Columnas  & " FROM Proveedor").Tables(0)
           End If
       Else
           If Columnas.Trim = String.Empty Then
               Return Consultar("SELECT * FROM Proveedor WHERE " & Filtro & " ").Tables(0)
           Else
               Return Consultar("SELECT " & Columnas  &  "  FROM Proveedor WHERE " &  Filtro & " ").Tables(0)
           End If
       End If
   End Function

   ''' <summary>
   ''' Busca y Carga la clase a partir de la llave primaria de la tabla
   ''' Cargar llave primaria 'IdPersona' para traer los datos del registro
   ''' </summary>
   ''' <remarks></remarks>
   Public Sub ObtenerRegistro()
       Dim dt As DataTable = Traer("IdPersona=" & m_IdPersona)
       If dt.Rows.Count > 0 Then
           Dim dr As DataRow = dt.Rows(0)
            m_IdPersona=dr.Item("IdPersona")
            m_Nombre=dr.Item("Nombre")
            m_Ap_Paterno=IIF(IsDBNull(dr.Item("Ap_Paterno"))= False,dr.Item("Ap_Paterno"),"")
            m_Ap_Materno = IIf(IsDBNull(dr.Item("Ap_Materno")) = False, dr.Item("Ap_Materno"), "")
            m_NombreEmpresa =IIF(IsDBNull(dr.Item("NombreEmpresa"))= False,dr.Item("NombreEmpresa"),"")
            m_NombreContacto=IIF(IsDBNull(dr.Item("NombreContacto"))= False,dr.Item("NombreContacto"),"")
            m_Direccion=IIF(IsDBNull(dr.Item("Direccion"))= False,dr.Item("Direccion"),"")
            m_Telefono=IIF(IsDBNull(dr.Item("Telefono"))= False,dr.Item("Telefono"),"")
            m_email=IIF(IsDBNull(dr.Item("email"))= False,dr.Item("email"),"")

       Else
           m_IdPersona = 0
       End If
   End Sub
   #End Region
   end class
