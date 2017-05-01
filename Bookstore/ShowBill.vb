Imports CrystalDecisions.CrystalReports.Engine
Public Class ShowBill
    Dim p As String
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnShow.Click
        Dim rpt As New ReportDocument()
        Dim dir As String = My.Application.Info.DirectoryPath
        'rpt.Load("C:\Users\4R7\Google Drive\ICT_KKU\322239_DatabaseApp\DataAPP_Project\program\Bookstore\Bookstore\CrystalReport.rpt")

        Dim path As String = My.Application.Info.DirectoryPath
        Dim pfile As String = IO.Path.Combine(path, "CrystalReport.rpt")
        rpt.Load(pfile)
        rpt.SetParameterValue("date_P", CDate(DateTimePickerS.Value))
        rpt.SetParameterValue("date_E", CDate(DateTimePickerE.Value))
        Me.myCrytalReprotViewer.ReportSource = rpt
        Me.myCrytalReprotViewer.Refresh()


    End Sub


End Class