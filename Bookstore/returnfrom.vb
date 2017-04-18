Public Class returnfrom
    Dim cdb As New conndb()
    Dim strcell As String
    Private Sub returnfrom_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtFell.Text = calFee(Date.FromOADate((15 / 4 / 2017)), Date.FromOADate((18 / 4 / 2017))).ToString
    End Sub
    Private Sub showdata()
        cdb.mystr = "SELECT dbo.BorrowReturn.Borrow_ID, dbo.BorrowReturn.Borrow_Date, dbo.BorrowReturn.Return_Date, dbo.BorrowReturn.Fee, dbo.BorrowReturn.SSN, dbo.BorrowReturn.Book_ID, dbo.Book.Status
                     FROM  dbo.Book INNER JOIN dbo.BorrowReturn ON dbo.Book.Book_ID = dbo.BorrowReturn.Book_ID WHERE dbo.BorrowReturn.SSN = '" + txtSkey.Text + "' "
        cdb.myObjconn().Open()
        cdb.myda() = New SqlClient.SqlDataAdapter(cdb.mystr, cdb.myObjconn)
        cdb.myds() = New DataSet
        cdb.myda().Fill(cdb.myds(), "Book")

        DataGridView.DataMember = "Book"
        DataGridView.DataSource = cdb.myds()
        cdb.myObjconn().Close()
    End Sub

    Private Sub intotxt()
        ctxt()
        cdb.mystr = " SELECT        dbo.Book.Book_Name, dbo.Book.Book_ID, dbo.BorrowReturn.Return_Date FROM dbo.Book INNER JOIN dbo.BorrowReturn ON dbo.Book.Book_ID = dbo.BorrowReturn.Book_ID where dbo.BorrowReturn.Borrow_ID = '" + strcell.Trim + "';"
        cdb.myObjconn.Open()
        Dim cmd As New SqlClient.SqlCommand(cdb.mystr, cdb.myObjconn())
        cdb.mydr = cmd.ExecuteReader()
        If cdb.mydr.HasRows Then
            While cdb.mydr.Read
                txtBname.Text += cdb.mydr.Item(0)
                txtBID.Text += cdb.mydr.Item(1)
                txtReDate.Text += cdb.mydr.Item(2)
            End While
        Else
            MessageBox.Show("ไม่มีข้อมูล", "ผลการดำเนินการ")
        End If
        cdb.mydr.Close()
        cdb.myObjconn().Close()
    End Sub
    Private Sub ctxt()
        txtReDate.Clear()
        txtBID.Clear()
        txtBname.Clear()

    End Sub
    Private Sub DataGridView_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView.CellContentClick
        With Me.DataGridView
            .SelectionMode = DataGridViewSelectionMode.FullRowSelect
            .MultiSelect = False
        End With
        strcell = DataGridView.Rows.Item(e.RowIndex).Cells(0).Value.ToString
        intotxt()

    End Sub

    Private Sub btnS_Click(sender As Object, e As EventArgs) Handles btnS.Click
        showdata()
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        If CheckBox.Checked Then
            DGUpdateBook()
            MessageBox.Show("คืนสำเร็จ")
            CheckBox.CheckState = CheckState.Unchecked
        End If
    End Sub

    Private Function calFee(ByVal FRedate As Date, ByVal redate As Date) As Integer
        Dim diff
        diff = DateDiff(DateInterval.Day, FRedate, redate)
        Return diff
    End Function

    Private Sub DGUpdateBook()
        Dim connection As New Data.SqlClient.SqlConnection
        Dim cmd As New Data.SqlClient.SqlCommand

        connection.ConnectionString = cdb.myStrconn()
        cmd.CommandText = "UPDATE [bookbd].[dbo].[Book] SET [Status] = @valueStatus WHERE [dbo].[Book].[Book_ID] = @BookID;"
        cmd.Parameters.Add("@BookID", SqlDbType.VarChar)
        cmd.Parameters.Add("@valueStatus", SqlDbType.VarChar)

        connection.Open()
        cmd.Connection = connection
        cmd.Parameters("@BookID").Value = txtBID.Text
        cmd.Parameters("@valueStatus").Value = "yes"

        cmd.ExecuteNonQuery()

    End Sub
End Class