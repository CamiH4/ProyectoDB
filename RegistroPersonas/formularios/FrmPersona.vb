Public Class FrmPersona
    Dim ciudadDao As New CiudadDao

    Private Sub FrmPersonas_Load(sender As Object, e As EventArgs) Handles MyBase.Load


    End Sub

    Sub llenarCiudades()
        Dim ds As New DataSet
        ds = ciudadDao.MostrarRegistros

    End Sub
End Class