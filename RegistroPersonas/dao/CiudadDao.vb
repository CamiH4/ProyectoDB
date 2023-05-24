Imports System.Data.SqlClient
Public Class CiudadDao
    'Conection
    Dim strConn As String = My.Settings.StrConexion.ToString()

    Public Function AgregarRegistro(ByVal ciudad As Ciudad) As Boolean
        Dim resp As Boolean = False
        Try
            Dim tsql As String = "Insert into Ciudad(nombre) values(@nombre)"
            Dim conn As New SqlConnection(strConn)
            Dim cmd As New SqlCommand()
            cmd.Parameters.AddWithValue("@nombre", ciudad.Nombre)
            cmd.CommandType = CommandType.Text
            cmd.CommandText = tsql
            cmd.Connection = conn
            cmd.Connection.Open()
            If (cmd.ExecuteNonQuery <> 0) Then
                resp = True
            End If
            cmd.Connection.Close()
        Catch ex As Exception
            MsgBox("Ha ocurrido un error al obtener los registros " & ex.Message,
                    MsgBoxStyle.Critical, "Error")
        End Try
        Return resp
    End Function

    Public Function EditarRegistro(ByVal ciudad As Ciudad) As Boolean
        Dim flag = False
        Try
            Dim tsql As String = "update Ciudad set nombre = @nombre, estado = @estado where idCiudad = @idCiudad"
            Dim conn As New SqlConnection(My.Settings.StrConexion)
            Dim cmd As New SqlCommand(tsql, conn)
            cmd.Parameters.AddWithValue("@nombre", ciudad.Nombre)
            cmd.Parameters.AddWithValue("@estado", ciudad.Estado)
            cmd.Parameters.AddWithValue("@idCiudad", ciudad.IdCiudad)
            cmd.Connection.Open()
            If (cmd.ExecuteNonQuery <> 0) Then
                flag = True
            End If
            cmd.Connection.Close()
        Catch ex As Exception
            MsgBox("Ha ocurrido un error al obtener los registros " & ex.Message,
                    MsgBoxStyle.Critical, "Error")
        End Try
        Return flag
    End Function

    Public Function EliminarRegistro(ByVal idCiudad As Integer) As Boolean
        Dim resp As Boolean = False
        Try
            Dim tsql As String = "delete from Ciudad where idCiudad = @idCiudad"
            Dim conn As New SqlConnection(strConn)
            conn.Open()
            Dim cmd As New SqlCommand(tsql, conn)
            cmd.CommandType = CommandType.Text
            cmd.Parameters.AddWithValue("@idCiudad", idCiudad)
            If (cmd.ExecuteNonQuery <> 0) Then
                resp = True
            End If
            conn.Close()
        Catch ex As Exception
            resp = False
        End Try
        Return resp
    End Function

    Public Function MostrarRegistros() As DataSet
        Dim ds As New DataSet
        Try
            Dim tsql As String = "select idCiudad as N'Codigo', nombre as N'Ciudad' from Ciudad"
            Dim conn As New SqlConnection(strConn)
            Dim da As New SqlDataAdapter(tsql, conn)
            da.Fill(ds)
        Catch ex As Exception
            MsgBox("Ha ocurrido un error al obtener los registros " & ex.Message,
                    MsgBoxStyle.Critical, "Error")
        End Try
        Return ds
    End Function

    Public Function BuscarRegistro(ByVal idCiudad As Integer) As Ciudad
        Dim ciudad As New Ciudad
        Try
            Dim tsql As String = "select * from Ciudad where idCiudad = @idCiudad"
            Dim conn As New SqlConnection(strConn)
            Dim tbl As New DataTable
            Dim da As New SqlDataAdapter(tsql, conn)
            da.SelectCommand.Parameters.AddWithValue("@idCiudad", idCiudad)
            da.Fill(tbl)
            If tbl.Rows.Count > 0 Then
                ciudad.IdCiudad = tbl.Rows(0).Item("idCiudad")
                ciudad.Nombre = tbl.Rows(0).Item("nombre")
                ciudad.estado = tbl.Rows(0).Item("estado")
            End If
        Catch ex As Exception

        End Try
        Return ciudad
    End Function

    Public Function buscarRegistro(ByVal nombre As String) As DataSet
        Dim ds As New DataSet
        nombre = nombre + "%"
        Try
            Dim conn As New SqlConnection(strConn)
            Dim tsql As String = "select idCiudad as N'Codigo', nombre as N'Ciudad' from Ciudad where nombre like @nombre"
            Dim da As New SqlDataAdapter(tsql, conn)
            da.SelectCommand.Parameters.AddWithValue("@nombre", nombre)
            da.Fill(ds)
        Catch ex As Exception
            MsgBox("Ha ocurrido un error al obtener los registros " & ex.Message,
                    MsgBoxStyle.Critical, "Error")
        End Try
        Return ds
    End Function
End Class
