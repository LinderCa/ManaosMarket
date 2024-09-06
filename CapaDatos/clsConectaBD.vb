'importaciones de espacios de nombre
Imports System.Data 'ADO Net 
Imports System.Data.SqlClient 'Prov SQL Server  

Public Class clsConectaBD
    Private cn As SqlConnection

    Sub New()
        cn = New SqlConnection  'Objeto de conexión a BD

        'Autenticación Windows
        cn.ConnectionString = "data source=(LAPTOP-N19UNALS\SQLEXPRESS);Initial catalog=ManaosMarket;integrated security=SSPI;language=spanish"

        'Autenticación SQL Server
        'cn.ConnectionString = "data source=(local);Initial catalog=BDBiblioteca_22-II;user id=sa;password=aljanare;language=spanish"

    End Sub

    Public Sub conectar()
        Try
            If cn.State = ConnectionState.Closed Then
                cn.Open()
            End If
        Catch ex As Exception
            'mensaje de error
        End Try
    End Sub

    Public Sub desconectar()
        Try
            If cn.State <> ConnectionState.Closed Then
                cn.Close()
            End If
        Catch ex As Exception
        End Try
    End Sub

    Public ReadOnly Property estadoCN() As String
        Get
            If cn.State = ConnectionState.Open Then
                Return "BD está abierta."

            Else
                Return "BD está cerrada."
            End If
        End Get
    End Property

    Public ReadOnly Property miConexion() As SqlConnection
        Get
            Return cn
        End Get
    End Property

    Public ReadOnly Property Servidor() As String
        Get
            Return cn.DataSource.ToString
        End Get
    End Property

    Public Sub abrirconexion()
        Try
            If cn.State <> ConnectionState.Open Then ' SI EL ESTADO DE  LA CONEXION ES DIFERENTE DE ABIERTO ENTONCES ABRE LA CONEXION
                cn.Open()
            End If
        Catch Ex As Exception
            Err.Raise(Err.Number, Err.Source, Err.Description)
        End Try
    End Sub

    Public Sub cerrarconexion()
        Try
            If cn.State = ConnectionState.Open Then
                cn.Close()
            End If
        Catch Ex As Exception
            Err.Raise(Err.Number, Err.Source, Err.Description)
        End Try
    End Sub

 
End Class
