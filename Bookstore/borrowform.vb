Public Class borrowform
    Dim cdb As New conndb()
    Dim totalBRP As Integer
    Private Sub borrowform_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LbShowTime.Text = Date.Now.ToShortDateString
    End Sub
    Private Sub btnAdd2L_Click(sender As Object, e As EventArgs) Handles btnAdd2L.Click
        Dim num As Integer
        num = DataGVList.RowCount
        Dim dataT As String() = New String() {num + 1, txtMemb.Text, txtBookID.Text, 10, LbShowTime.Text}
        DataGVList.Rows.Add(dataT)
        LlTot.Text = calBRP.ToString() + " บาท"
    End Sub

    Private Function calBRP() As Integer
        totalBRP += DataGVList.Item(3, DataGVList.CurrentRow.Index).Value
        Return totalBRP
    End Function

    Private Sub btnConf_Click(sender As Object, e As EventArgs) Handles btnConf.Click
        Try

        Catch ex As Exception

        End Try
    End Sub
End Class