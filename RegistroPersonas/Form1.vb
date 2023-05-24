Imports System.Data.SqlClient
Imports Microsoft.Reporting.WinForms
Public Class FrmPrincipal

    Dim strConn As String = My.Settings.StrConexion.ToString()
    Private Sub CiudadToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CiudadToolStripMenuItem.Click
        Dim frm As New FrmCiudad
        frm.MdiParent = Me
        frm.Show()
    End Sub

    Private Sub PersonaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PersonaToolStripMenuItem.Click
        Dim frm As New FrmPersona
        frm.MdiParent = Me
        frm.Show()
    End Sub

    Sub verReporte(ByVal t As DataTable, ByVal ds As String, ByVal nombreRpt As String)
        Try
            Dim rpt As New ReportDataSource(ds, t)

            FrmVistaPrevia.ReportViewer1.LocalReport.DataSources.Clear()
            FrmVistaPrevia.ReportViewer1.LocalReport.DataSources.Add(rpt)
            FrmVistaPrevia.ReportViewer1.LocalReport.ReportPath = nombreRpt
            FrmVistaPrevia.ReportViewer1.Refresh()
            FrmVistaPrevia.Show()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error al mostrar reporte")
        End Try
    End Sub

    Private Sub ReportesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ReportesToolStripMenuItem.Click
        Try
            Dim tsql As String = "SELECT * FROM ListadoPersona"
            Dim conex As New SqlConnection(strConn)
            Dim da As New SqlDataAdapter(tsql, conex)
            Dim t As New DataTable
            da.Fill(t)
            verReporte(t, "dsRegistros", "C: \reportes\RptPersona.rdlc")
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error al cargar reporte")
        End Try
    End Sub
End Class
