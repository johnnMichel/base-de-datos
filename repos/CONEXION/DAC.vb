Imports System.Collections.Generic
Imports System.Data
Imports System.Data.SqlClient


Public Class DAC

    Private TipoBaseDatos As String = ""

#Region "Atributos"

    Private m_DB As String
    Private m_Password As String
    Private m_Server As String
    Private m_User As String
    Private m_StrCon As String

#End Region


#Region "Metodos"

    Private Sub CargarStrConfig()
        ' m_StrCon = My.Settings.StringConexion
        m_StrCon = "Data Source=DESKTOP-74I4U32\SQLEXPRESS;Initial Catalog=dbFerreteria;Integrated Security=True;Encrypt=False"
        ' m_StrCon = "Data Source=(local);Initial Catalog=dbFastFood;User ID=sa;Password=server"

    End Sub

    Public Sub GuardarStringConexion(ByVal cnx As String)
        'My.Settings.StringConexion = "Data Source=192.168.1.12;Initial Catalog=dbORBIS;User ID=sa;Password=TBS3rv3r"
        'My.Settings.StringConexion = "Data Source=192.168.1.10;Initial Catalog=dbORBIS;Integrated Security=True"

    End Sub

    Protected Function IniciarTransaccion() As SqlClient.SqlTransaction
        Return Me.ConectarSQLServer.BeginTransaction
    End Function

    Protected Sub TerminarTransaccion(ByRef trn As SqlClient.SqlTransaction)
        Try
            Dim cn As SqlClient.SqlConnection = trn.Connection
            trn.Commit()
            Me.CerrarConexion(cn)
        Catch ex As Exception
            AbortarTransaccion(trn)
            Throw New Exception("Error Metodo TerminarTransaccion DAC : " & ex.Message)
        End Try
    End Sub

    Protected Sub AbortarTransaccion(ByVal trn As SqlClient.SqlTransaction)
        Try
            Dim cn As SqlClient.SqlConnection = trn.Connection
            trn.Rollback()
            Me.CerrarConexion(cn)
        Catch ex As Exception
            Throw New Exception("Error Metodo AbortarTransaccion DAC : " & ex.Message)
        End Try
    End Sub

    Protected Sub CerrarConexion(ByVal cn As SqlClient.SqlConnection)
        If (Not Information.IsNothing(cn) AndAlso (cn.State = ConnectionState.Open)) Then
            cn.Close()
        End If
    End Sub

    Protected Function ConectarSQLServer() As SqlClient.SqlConnection
        Try
            'Me.CargarAppConfig()
            'Dim scon As String = "Data Source=" + m_Server + ";Initial Catalog=" + m_DB + ";Persist Security Info=True;User ID=" + m_User + ";Password=" + m_Password + ";"
            Me.CargarStrConfig()
            Dim scon As String = m_StrCon
            Dim cn As New SqlClient.SqlConnection(scon)
            cn.Open()
            Return cn
        Catch ex As Exception
            Throw New Exception("Error Metodo ConectarSQLServer DAC : " & ex.Message)
        End Try
    End Function

    Protected Function Consultar(ByVal sQuery As String) As DataSet
        Dim ds As New DataSet
        Dim trn As SqlClient.SqlTransaction = Me.IniciarTransaccion
        Try
            ds = Me.Consultar(sQuery, trn)
            Me.TerminarTransaccion(trn)
        Catch ex As Exception
            Me.AbortarTransaccion(trn)
            Throw New Exception("Error Metodo Consultar DAC : " & ex.Message)
        End Try
        Return ds
    End Function

    Protected Function Consultar(ByVal sQuery As String, ByVal trn As SqlClient.SqlTransaction) As DataSet
        Dim ada As New SqlClient.SqlDataAdapter(sQuery, trn.Connection)
        ada.SelectCommand.Transaction = trn
        Dim ds As New DataSet
        ada.Fill(ds)
        Return ds
    End Function

    Protected Function ConsultarProc(ByVal NameProc As String, ByVal listPrm As List(Of SqlClient.SqlParameter)) As DataSet
        Dim ds As DataSet
        Dim trn As SqlClient.SqlTransaction = Me.IniciarTransaccion
        Try
            ds = Me.ConsultarProc(NameProc, listPrm, trn)
            Me.TerminarTransaccion(trn)
        Catch ex As Exception
            Me.AbortarTransaccion(trn)
            Throw New Exception("Error en procedimiento " & NameProc.ToString & ": " & ex.Message)
        Finally

        End Try
        Return ds
    End Function

    Protected Function ConsultarProc(ByVal NameProc As String, ByVal listPrm As List(Of SqlClient.SqlParameter), ByVal trn As SqlClient.SqlTransaction) As DataSet
        Try
            Dim ds As New DataSet
            Dim ada As New SqlClient.SqlDataAdapter(NameProc, trn.Connection)
            ada.SelectCommand.Transaction = trn
            Me.CargarListaParametros(ada.SelectCommand, listPrm)
            ada.SelectCommand.CommandType = CommandType.StoredProcedure
            ada.Fill(ds)
            Return ds
        Catch ex As Exception
            Throw New Exception("Error en procedimiento " & NameProc.ToString & ": " & ex.Message)
            Return Nothing
        End Try

    End Function

    Protected Function DevolverCorrelativo(ByVal sTabla As String, ByVal trn As SqlClient.SqlTransaction) As Object
        Dim Obj As Object
        Try
            Dim cmd As New SqlClient.SqlCommand("DevolverCorrelativo", trn.Connection)
            cmd.Transaction = trn
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.Add(New SqlClient.SqlParameter("@Tabla", sTabla))
            Obj = cmd.ExecuteScalar
        Catch ex As Exception
            Throw New Exception("Error en Tabla " & sTabla.ToString & ": " & ex.Message)
        End Try
        Return Obj
    End Function

    Protected Function DevolverFechaActual() As DateTime
        Dim sQuery As String = "SELECT GetDate()"
        Return Convert.ToDateTime(DevolverValor(sQuery))
    End Function

    Public Shared Function DevolverFechaActualServidor() As DateTime
        Dim oDac As New DAC
        Return oDac.DevolverFechaActual
    End Function

    Protected Function DevolverValor(ByVal sQuery As String) As Object
        Dim trn As SqlClient.SqlTransaction = Me.IniciarTransaccion
        Dim obj As Object
        Try
            obj = Me.DevolverValor(sQuery, trn)
            Me.TerminarTransaccion(trn)
        Catch ex As Exception
            AbortarTransaccion(trn)
            Throw New Exception("Error Metodo DevolverValor DAC : " & ex.Message)
        End Try
        Return obj
    End Function

    Protected Function DevolverValor(ByVal sQuery As String, ByVal trn As SqlClient.SqlTransaction) As Object
        Dim obj As Object
        Try
            Dim cmd As New SqlClient.SqlCommand(sQuery, trn.Connection)
            cmd.Transaction = trn
            obj = cmd.ExecuteScalar
        Catch ex As Exception
            Throw New Exception("Error Metodo DevolverValor DAC : " & ex.Message)
        End Try
        Return obj
    End Function

    Protected Function Ejecutar(ByVal sDML As String) As Integer

        Dim trn As SqlClient.SqlTransaction = Me.IniciarTransaccion
        Dim control As Integer
        Try
            control = Me.Ejecutar(sDML, trn)
            If (control > 0) Then
                Me.TerminarTransaccion(trn)
            Else
                Me.AbortarTransaccion(trn)
            End If
        Catch ex As Exception
            Me.AbortarTransaccion(trn)
            Throw New Exception("Error Metodo Ejecutar DAC : " & ex.Message)
        End Try
        Return control

    End Function

    Protected Function Ejecutar(ByVal sDML As String, ByVal trn As SqlClient.SqlTransaction) As Integer
        Dim cmd As New SqlClient.SqlCommand(sDML, trn.Connection)
        cmd.Transaction = trn
        Return cmd.ExecuteNonQuery
    End Function

    Protected Function EjecutarInsertProc(ByVal NameProc As String, ByVal listPrm As List(Of SqlClient.SqlParameter), Optional ByVal trn As SqlClient.SqlTransaction = Nothing) As Integer
        Dim sw As Boolean = False
        If (trn Is Nothing) Then
            trn = Me.IniciarTransaccion
            sw = True
        End If
        Dim cmd As New SqlClient.SqlCommand(NameProc, trn.Connection)
        Try
            cmd.Transaction = trn
            Me.CargarListaParametros(cmd, listPrm)
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.Item(0).Direction = ParameterDirection.Output
            If (cmd.ExecuteNonQuery > 0) Then
                If sw Then
                    Me.TerminarTransaccion(trn)
                End If
            ElseIf sw Then
                Me.AbortarTransaccion(trn)
            End If
        Catch ex As Exception
            If sw Then
                Me.AbortarTransaccion(trn)
            End If
            Throw New Exception("Error Metodo EjecutarInsertProc DAC : " & ex.Message)
        End Try
        Return cmd.Parameters.Item(0).Value
    End Function

    Protected Function EjecutarProc(ByVal NameProc As String, ByVal listPrm As List(Of SqlClient.SqlParameter)) As Integer
        Dim trn As SqlClient.SqlTransaction = Me.IniciarTransaccion
        Try
            Dim control As Integer = Me.EjecutarProc(NameProc, listPrm, trn)
            If (control > 0) Then
                Me.TerminarTransaccion(trn)
            Else
                Me.AbortarTransaccion(trn)
            End If
            Return control
        Catch ex As Exception
            Me.AbortarTransaccion(trn)
            Throw New Exception("Error Metodo EjecutarProc DAC : " & ex.Message)
        End Try
    End Function

    Protected Function EjecutarProc(ByVal NameProc As String, ByVal listPrm As List(Of SqlClient.SqlParameter), ByVal trn As SqlClient.SqlTransaction) As Integer
        Dim cmd As New SqlClient.SqlCommand(NameProc, trn.Connection)
        cmd.Transaction = trn
        Me.CargarListaParametros(cmd, listPrm)
        cmd.CommandType = CommandType.StoredProcedure
        Return cmd.ExecuteNonQuery
    End Function

    Protected Function ConsultarProcedimiento(ByVal NameProc As String, ByVal listPrm As List(Of SqlClient.SqlParameter)) As DataTable
        Dim trn As SqlClient.SqlTransaction = Me.IniciarTransaccion
        Try
            Dim dtResultado As DataTable = Me.ConsultarProcedimiento(NameProc, listPrm, trn)
            If (IsDBNull(dtResultado) = False) Then
                Me.TerminarTransaccion(trn)
            Else
                Me.AbortarTransaccion(trn)
            End If
            Return dtResultado
        Catch ex As Exception
            Me.AbortarTransaccion(trn)
            Throw New Exception("Error Metodo ConsultarProcedimiento DAC : " & ex.Message)
        End Try
    End Function

    Protected Function ConsultarProcedimiento(ByVal NameProc As String, ByVal listPrm As List(Of SqlClient.SqlParameter), ByVal trn As SqlClient.SqlTransaction) As DataTable
        Try
            Dim cmd As New SqlClient.SqlCommand(NameProc, trn.Connection)
            cmd.Transaction = trn
            Me.CargarListaParametros(cmd, listPrm)
            cmd.CommandType = CommandType.StoredProcedure

            Dim sda As New SqlClient.SqlDataAdapter(cmd)
            Dim ds As New DataSet
            sda.Fill(ds)

            Return ds.Tables(0)
        Catch ex As Exception
            Throw New Exception("Error Metodo ConsultarProcedimiento DAC : " & ex.Message)
        End Try
    End Function

    Private Sub CargarListaParametros(ByVal cmd As SqlClient.SqlCommand, ByVal listPrm As List(Of SqlClient.SqlParameter))
        If (Not listPrm Is Nothing) Then
            cmd.Parameters.AddRange(listPrm.ToArray)
        End If
    End Sub

#End Region

#Region "Métodos compartidos"

    Public Shared Function CargarListaParametros(ByVal ParamArray ListObj As Object()) As List(Of SqlClient.SqlParameter)
        Dim listPrm As New List(Of SqlClient.SqlParameter)()
        Dim prm As SqlClient.SqlParameter
        Dim count As Integer = ListObj.Length / 2
        Dim c As Integer = 0
        For i As Integer = 0 To count - 1
            prm = New SqlClient.SqlParameter(Convert.ToString(ListObj(c)), IIf(IsNothing(ListObj(c + 1)), DBNull.Value, ListObj(c + 1)))
            listPrm.Add(prm)
            c += 2
        Next
        Return listPrm
    End Function

#End Region



End Class
