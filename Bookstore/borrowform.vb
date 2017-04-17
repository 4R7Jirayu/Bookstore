Imports System.Data.SqlClient
Public Class borrowform
    Dim cdb As New conndb()
    Dim totalBRP As Integer
    Dim DateReturn As Integer
    Dim checkadd As Boolean = False
    Dim checkshowi As Boolean = False

    Private Sub borrowform_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LbShowTime.Text = Date.Now.ToString("yyyyMMdd")
    End Sub
    Private Sub btnAdd2L_Click(sender As Object, e As EventArgs) Handles btnAdd2L.Click
        Dim num As Integer
        num = DataGVList.RowCount
        checkshowi = False

        Dim dataT As String() = New String() {num + 1, txtMemb.Text, getValueFBook("Book_Name"), CInt(getValueFBook("BookBorrow_Price")), CDate(Date.Now.AddDays(CInt(getValueFBook("LimitBorrow_Date")))).ToString("dd/MM/yyyy")}
        If checkadd Then
            DataGVList.Rows.Add(dataT)
            LlTot.Text = calBRP.ToString() + " บาท"
        End If

    End Sub

    Private Sub btnConf_Click(sender As Object, e As EventArgs) Handles btnConf.Click
        Dim connection As New Data.SqlClient.SqlConnection
        Dim cmd As New Data.SqlClient.SqlCommand

        connection.ConnectionString = cdb.myStrconn()
        cmd.CommandText = "INSERT INTO [bookbd].[dbo].[BorrowReturn] ([Borrow_ID]
           ,[Borrow_Date]
           ,[Return_Date]
           ,[Fee]
           ,[SSN]
           ,[Book_ID]
           ,[Status]) 
            VALUES (@Borrow_ID, @Borrow_Date, @Return_Date, @Fee, @SSN, @Book_ID,@Status)"
        cmd.Parameters.Add("@Borrow_ID", SqlDbType.VarChar)
        cmd.Parameters.Add("@Borrow_Date", SqlDbType.DateTime)
        cmd.Parameters.Add("@Return_Date", SqlDbType.DateTime)
        cmd.Parameters.Add("@Fee", SqlDbType.Real)
        cmd.Parameters.Add("@SSN", SqlDbType.VarChar)
        cmd.Parameters.Add("@Book_ID", SqlDbType.VarChar)
        cmd.Parameters.Add("@Status", SqlDbType.NChar)

        connection.Open()
        cmd.Connection = connection

        For i As Integer = 0 To DataGVList.Rows.Count - 1
            ' DataGridViewTypeBook.Rows.Item(e.RowIndex).Cells(0).Value
            cmd.Parameters("@Borrow_ID").Value = LbShowTime.Text + DataGVList.Rows.Item(i).Cells(0).Value
            cmd.Parameters("@Borrow_Date").Value = Date.Now  'DataGVList.Rows.Item(i).Cells(1).Value
            cmd.Parameters("@Return_Date").Value = DataGVList.Rows.Item(i).Cells(4).Value 'DataGVList.Rows.Item(i).Cells(2).Value
            cmd.Parameters("@Fee").Value = 0 'DataGVList.Rows.Item(i).Cells(4).Value
            cmd.Parameters("@SSN").Value = txtMemb.Text 'DataGVList.Rows.Item(i).Cells(4).Value
            cmd.Parameters("@Book_ID").Value = txtBookID.Text 'DataGVList.Rows.Item(i).Cells(5).Value
            cmd.Parameters("@Status").Value = DataGVList.Rows.Item(i).Cells(4).Value
            cmd.ExecuteNonQuery()
        Next
    End Sub
    Private Function getValueFBook(ByVal sKey As String) As String
        cdb.mystr = "Select [Book_Name],[BookBorrow_Price],[LimitBorrow_Date] FROM [bookbd].[dbo].[Book] WHERE [Book].[Book_ID] = '" + txtBookID.Text + "';"
        cdb.myObjconn = New SqlConnection(cdb.myStrconn)
                cdb.myObjconn.Open()
        Dim objCmd As SqlCommand = New SqlCommand(cdb.mystr, cdb.myObjconn)
        cdb.mydr = objCmd.ExecuteReader()
        cdb.mydr.Read()
        If cdb.mydr.HasRows Then
            checkadd = True
            If sKey = "Book_Name" Then
                Return (cdb.mydr.Item(0))
            ElseIf sKey = "BookBorrow_Price" Then
                Return (cdb.mydr.Item(1))
            ElseIf sKey = "LimitBorrow_Date" Then
                Return (cdb.mydr.Item(2))
            Else
                Return ""
            End If
        Else
            checkadd = False
            If Not (checkshowi) Then
                MessageBox.Show("ไม่มีข้อมูล", "ไม่พบหนังสือ")
                checkshowi = True
                Return "0"
            End If
        End If
            cdb.mydr.Close()
        cdb.myObjconn.Close()
    End Function

    Private Function calBRP() As Integer
        Dim totalBRP As Integer = 0
        For i As Integer = 1 To DataGVList.RowCount - 1
            totalBRP += DataGVList.Rows(i).Cells(3).Value
        Next
        totalBRP += DataGVList.Item(3, DataGVList.CurrentRow.Index).Value
        Return totalBRP
    End Function
End Class