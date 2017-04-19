Public Class returnfrom
    Dim cdb As New conndb()
    Dim strcell As String
    Dim totalFee As Long = 0
    Private Sub returnfrom_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtFell.Text = calFee(Date.FromOADate((15 / 4 / 2017)), Date.FromOADate((18 / 4 / 2017))).ToString
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
        txtFell.Text = calFee(CDate(txtReDate.Text), Date.Now)
        totalFee += CInt(txtFell.Text)
        lbtotalFee.Text = "รวมค่าปรับทั้งหมด " + totalFee.ToString + " บาท"
    End Sub

    Private Sub btnS_Click(sender As Object, e As EventArgs) Handles btnS.Click
        showdata()
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        txtFell.Text = calFee(CDate(txtReDate.Text), Date.Now)
        totalFee += CInt(txtFell.Text)
        lbtotalFee.Text = "รวมค่าปรับทั้งหมด " + totalFee.ToString + " บาท"
        If CheckBox.Checked Then
            DGUpdateBook()
            DGUpdatefee()
            MessageBox.Show("คืนสำเร็จ")
            CheckBox.CheckState = CheckState.Unchecked
        End If
    End Sub
    Private Sub btnPFee_Click(sender As Object, e As EventArgs) Handles btnPFee.Click
        DGinsertBill()
        totalFee = 0
        lbtotalFee.Text = "รวมค่าปรับทั้งหมด " + totalFee.ToString + " บาท"
    End Sub

    Private Function calFee(ByVal FRedate As Date, ByVal redate As Date) As Long
        Dim days As Long
        Dim fee As Long
        days = DateDiff("d", FRedate, redate)
        If days > 0 Then
            ' คิดค่่าปรับ
            fee = days * 5
        Else
            fee = 0
        End If
        Return fee
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
    Private Sub DGUpdatefee()
        Dim connection As New Data.SqlClient.SqlConnection
        Dim cmd As New Data.SqlClient.SqlCommand

        connection.ConnectionString = cdb.myStrconn()
        cmd.CommandText = "UPDATE [bookbd].[dbo].[BorrowReturn] SET [Fee] = @valueFee WHERE [dbo].[BorrowReturn].[Borrow_ID] = @BrrID;"
        cmd.Parameters.Add("@valueFee", SqlDbType.Real)
        cmd.Parameters.Add("@BrrID", SqlDbType.VarChar)

        connection.Open()
        cmd.Connection = connection
        cmd.Parameters("@valueFee").Value = txtFell.Text
        cmd.Parameters("@BrrID").Value = strcell.Trim

        cmd.ExecuteNonQuery()

    End Sub

    Private Sub DGinsertBill()
        Dim connection As New Data.SqlClient.SqlConnection
        Dim cmd As New Data.SqlClient.SqlCommand

        connection.ConnectionString = cdb.myStrconn()
        cmd.CommandText = "INSERT INTO [dbo].[bill] ([Bdate],[SSN],[money],[type]) VALUES (@TBdate,@BSSN,@Bmoney,'F') ;"
        cmd.Parameters.Add("@TBdate", SqlDbType.DateTime)
        cmd.Parameters.Add("@BSSN", SqlDbType.VarChar)
        cmd.Parameters.Add("@Bmoney", SqlDbType.Int)

        connection.Open()
        cmd.Connection = connection


        cmd.Parameters("@TBdate").Value = Date.Now
        cmd.Parameters("@BSSN").Value = txtSkey.Text
        cmd.Parameters("@Bmoney").Value = totalFee

        cmd.ExecuteNonQuery()

    End Sub

    Private Sub showdata()
        cdb.mystr = "SELECT dbo.BorrowReturn.Borrow_ID, dbo.BorrowReturn.Borrow_Date, dbo.BorrowReturn.Return_Date, dbo.BorrowReturn.SSN, dbo.BorrowReturn.Book_ID, dbo.Book.Status
                     FROM  dbo.Book INNER JOIN dbo.BorrowReturn ON dbo.Book.Book_ID = dbo.BorrowReturn.Book_ID WHERE dbo.BorrowReturn.SSN = '" + txtSkey.Text + "' and dbo.book.Status <> 'yes'"
        cdb.myObjconn().Open()
        cdb.myda() = New SqlClient.SqlDataAdapter(cdb.mystr, cdb.myObjconn)
        cdb.myds() = New DataSet
        cdb.myda().Fill(cdb.myds(), "Book")

        DataGridView.DataMember = "Book"
        DataGridView.DataSource = cdb.myds()
        cdb.myObjconn().Close()
    End Sub



End Class