Public Class FrmCiudad
    Dim ciudadAct As New Ciudad

    Sub MostrarRegistros()
        Dim ciudadDao As New CiudadDao
        DgvCiudades.DataSource = ciudadDao.MostrarRegistros().Tables(0)
        DgvCiudades.Refresh()
        GbRegistrosCiudades.Text = "Registros Guardados: " & DgvCiudades.Rows.Count
    End Sub

    Private Sub FrmCiudad_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MostrarRegistros()
    End Sub

    Private Sub BtnNuevo_Click(sender As Object, e As EventArgs) Handles BtnNuevo.Click
        TxtId.Clear()
        TxtNombre.Clear()
        TxtNombre.Focus()
    End Sub

    Private Sub BtnGuardar_Click(sender As Object, e As EventArgs) Handles BtnGuardar.Click
        Try
            Dim ciudad = New Ciudad()
            ciudad.Nombre = TxtNombre.Text.Trim
            Dim ciudadDao As New CiudadDao()
            Dim resp = ciudadDao.AgregarRegistro(ciudad)
            If (resp) Then
                MsgBox("Registro guardado satisfactoriamente", MsgBoxStyle.Information,
                       "Ciudades de Nicaragua")
            End If
        Catch ex As Exception
            MsgBox("Error al guardar registro.", MsgBoxStyle.Critical,
                       "Ciudades de Nicaragua")
        End Try
        MostrarRegistros()
    End Sub

    Private Sub BtnEditar_Click(sender As Object, e As EventArgs) Handles BtnEditar.Click
        Try
            Dim ciudad As New Ciudad(CInt(TxtId.Text), TxtNombre.Text, True)
            Dim ciudadDao As New CiudadDao()
            Dim resp = ciudadDao.EditarRegistro(ciudad)
            If (resp) Then
                MsgBox("Registro editado satisfactoriamente", MsgBoxStyle.Information,
                       "Ciudades de Nicaragua")
            End If
        Catch ex As Exception
            MsgBox("Error al editar registro.", MsgBoxStyle.Critical,
                        "Ciudades de Nicaragua")
        End Try
        MostrarRegistros()
    End Sub

    Private Sub BtnEliminar_Click(sender As Object, e As EventArgs) Handles BtnEliminar.Click
        Dim codigo As Integer = TxtId.Text
        Dim ciudadDao As New CiudadDao()
        Dim ciudad As New Ciudad
        ciudad = ciudadDao.BuscarRegistro(codigo)
        If (ciudad.IdCiudad = 0) Then
            MsgBox("Registro no existente. ", MsgBoxStyle.Exclamation, "Ciudades de Nicaragua")
            Exit Sub
        End If

        Dim resp As VariantType
        resp = (MsgBox("Desea eliminar esta ciudad " & ciudad.IdCiudad, MsgBoxStyle.Question +
                       MsgBoxStyle.YesNo, "Ciudades de Nicaragua"))
        If (resp = vbNo) Then
            MsgBox("Operación cancelada", MsgBoxStyle.Information, "Ciudades de Nicaragua")
            Exit Sub
        End If

        Dim eliminado = ciudadDao.EliminarRegistro(ciudad.IdCiudad)
        If (eliminado) Then
            MsgBox("Registro eliminado satisfactoriamente", MsgBoxStyle.Critical, "Cuidades de Nicaragua")
        Else
            MsgBox("Error al eliminar el registro", MsgBoxStyle.Critical, "Ciudades de Nicaragua")
        End If
        MostrarRegistros()
    End Sub

    Private Sub DgvCiudades_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles DgvCiudades.MouseDoubleClick
        Dim fila As Integer = DgvCiudades.CurrentRow.Index
        TxtId.Text = DgvCiudades.Rows(fila).Cells(0).Value
        TxtNombre.Text = DgvCiudades.Rows(fila).Cells(1).Value
    End Sub

    Private Sub BtnBuscar_Click(sender As Object, e As EventArgs) Handles BtnBuscar.Click
        Dim ciudadDao As New CiudadDao
        DgvCiudades.DataSource = ciudadDao.buscarRegistro(TxtBuscar.Text.Trim).Tables(0)
        DgvCiudades.Refresh()
    End Sub
End Class