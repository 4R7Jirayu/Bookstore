Imports CrystalDecisions.CrystalReports.Engine
Public Class ShowBill
    Dim p As String
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnShow.Click
        Dim rpt As New ReportDocument()
        Dim dir As String = My.Application.Info.DirectoryPath
        Dim path As String = My.Application.Info.DirectoryPath
        Dim pfile As String = IO.Path.Combine(path, "CrystalReport.rpt")
        rpt.Load(pfile)
        rpt.SetParameterValue("date_P", CDate(DateTimePickerS.Value.ToLongDateString))
        rpt.SetParameterValue("date_E", CDate(DateTimePickerE.Value.ToLongDateString))
        Me.myCrytalReprotViewer.ReportSource = rpt
        Me.myCrytalReprotViewer.Refresh()
    End Sub


End Class