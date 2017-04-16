Public Class borrowform
    Dim cdb As New conndb()
    Dim totalBRP As Integer
    Dim DateReturn As Integer
    Private Sub borrowform_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LbShowTime.Text = Date.Now.ToShortDateString
    End Sub
    Private Sub btnAdd2L_Click(sender As Object, e As EventArgs) Handles btnAdd2L.Click
        Dim num As Integer
        DateReturn = getLimitBor()  'กำหนดเวลาในการยืม
        Dim DateMReturn As DateTime = Date.Now.AddDays(DateReturn)

        num = DataGVList.RowCount
        Dim dataT As String() = New String() {num + 1, txtMemb.Text, txtBookID.Text, 10, CDate(DateMReturn).ToString("dd/MM/yyyy")}
        DataGVList.Rows.Add(dataT)
        LlTot.Text = calBRP.ToString() + " บาท"
    End Sub
    Private Function getLimitBor() As Integer
        Dim limit As Integer
        cdb.myObjconn.Open()
        cdb.mystr = "SELECT [LimitBorrow_Date] FROM [bookbd].[dbo].[Book] WHERE [Book].[Book_ID] = '" + txtBookID.Text + "';"
        cdb.mydr = cdb.mycmd.ExecuteReader()
        If cdb.mydr().HasRows Then
            While cdb.mydr().Read
                limit = CInt(cdb.mydr().Item(0))
            End While
        Else
            MessageBox.Show("ไม่มีข้อมูล", "ไม่พบหนังสือ")
        End If

        Return limit
        cdb.mydr.Close()
        'cdb.myObjconn().Close()
    End Function

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