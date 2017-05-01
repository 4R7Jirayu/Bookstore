Imports CrystalDecisions.CrystalReports.Engine
Public Class ShowBill
    Dim p As String
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnShow.Click
        Dim rpt As New ReportDocument()
        Dim dir As String = My.Application.Info.DirectoryPath
        'rpt.Load("C:\Users\4R7\Google Drive\ICT_KKU\322239_DatabaseApp\DataAPP_Project\program\Bookstore\Bookstore\CrystalReport.rpt")
        rpt.Load(p)
        rpt.SetParameterValue("date_P", CDate(DateTimePickerS.Value))
        rpt.SetParameterValue("date_E", CDate(DateTimePickerE.Value))
        'rpt.SetParameterValue("StdID_parameter", TxtStdID.Text)
        Me.myCrytalReprotViewer.ReportSource = rpt
        Me.myCrytalReprotViewer.Refresh()
    End Sub

    Private Sub Btn_impCtr_Click(sender As Object, e As EventArgs) Handles Btn_impCtr.Click
        If (OpenFileDialog.ShowDialog() = DialogResult.OK) Then
            TxtPa.Text = OpenFileDialog.FileName
            p = TxtPa.Text
        End If
    End Sub
End Class