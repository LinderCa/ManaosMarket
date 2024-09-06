Imports System.Data
Imports System.Data.SqlClient
Imports capaDatos

Public Class clsMantenimiento
    Dim objConecta As New clsConectaBD
    Dim cm As New SqlCommand

    'Insert, update y delete
    Sub ejecutarComando(strConsulta As String)
        Try
            objConecta.abrirconexion()
            cm.Connection = objConecta.miConexion
            cm.CommandText = strConsulta
            cm.ExecuteNonQuery() 'Ejecuta la consulta en la base de datos
            objConecta.cerrarconexion()
        Catch ex As Exception
            Throw New Exception("Error al ejecutar la operación...")
        End Try
    End Sub

    'select
    Public Function listarComando(strConsulta As String) As DataTable
        Dim dt As New DataTable
        Dim da As SqlDataAdapter
        Try
            objConecta.abrirconexion() 'No es necesario??
            da = New SqlDataAdapter(strConsulta, objConecta.miConexion)
            da.Fill(dt) 'Llenar la tabla, ejecuta la consulta de selección
            objConecta.cerrarconexion()
            Return dt
        Catch ex As Exception
            Throw New Exception("Error al realizar la consulta...")
        End Try
        Return Nothing
    End Function

    Public Function listarComando(strConsulta As String, ds As DataSet) As DataSet
        'Dim ds As New DataSet
        Dim da As SqlDataAdapter
        Try
            objConecta.abrirconexion() 'No es necesario??
            da = New SqlDataAdapter(strConsulta, objConecta.miConexion)
            da.Fill(ds, "tabla") 'Llenar la tabla, ejecuta la consulta de selección
            objConecta.cerrarconexion()
            Return ds
        Catch ex As Exception
            Throw New Exception("Error al realizar la consulta...")
        End Try
        Return Nothing
    End Function

End Class
