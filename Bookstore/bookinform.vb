Public Class bookinform
    Dim cdb As New conndb()

    Public strcell As String
    Private Sub bookinform_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        showdata()
        cdb.myObjconn.Open()
        intoComboTypeS()

    End Sub

    Private Sub btnBUpdate_Click(sender As Object, e As EventArgs) Handles btnBUpdate.Click
        If btnBUpdate.Text = "แก้ไข" Then
            ' 
            '  cdb.mystr = "UPDATE Student SET Student.std_name ='" + txtName.Text + "',Student.std_lastname ='" + txtLastname.Text + "',Student.dept_id='" + cbDept.SelectedValue.ToString() + "',Student.std_address ='" + txtAddress.Text + "',Student.email ='" + txtmail.Text + "',Student.tel ='" + txttel.Text + "' WHERE Student.std_id='" + txtStdID.Text + "';"
            cdb.mystr = "UPDATE [dbo].[Book]
   SET [Book_ID] = '" + txtBId.Text + "'
      ,[Book_Name] ='" + txtBName.Text + "'
      ,[Writer] = '" + txtBwrt.Text + "'
      ,[BookBorrow_Price] = '" + txtBBrlP.Text + "'
      ,[Book_Price] = '" + txtBCvP.Text + "'
      ,[LimitBorrow_Date] = '" + txtBLm.Text + "'
      ,[Status] = '" + txtBstt.Text + "'
      ,[BookType_ID] = '" + comboBtype.SelectedValue + "'
 WHERE [Book_ID] =  '" + txtBId.Text + "'"
            Dim cmd = New SqlClient.SqlCommand(cdb.mystr, cdb.myObjconn())
            cmd.ExecuteNonQuery()
            MessageBox.Show("อัฟเดตข้อมูลได้สำเร็จ", "ผลการดำเนินการ")
            cdb.myObjconn.Close()
            btnBUpdate.Text = "อัปเดตข้อมูล"
        ElseIf btnBUpdate.Text = "อัปเดตข้อมูล" Then
            btnBUpdate.Text = "แก้ไข"

        End If
    End Sub

    Private Sub btnBInsert_Click(sender As Object, e As EventArgs) Handles btnBInsert.Click

        cdb.mystr = "INSERT INTO [bookbd].[dbo].[Book] ([Book_ID],[Book_Name],[Writer],[BookBorrow_Price],[Book_Price],[LimitBorrow_Date],[Status],[BookType_ID]) "
        cdb.mystr += "VALUES ('" + txtBId.Text + "','" + txtBName.Text + "','" + txtBwrt.Text + "','" + txtBBrlP.Text + "','" + txtBCvP.Text + "','" + txtBLm.Text + "','" + txtBstt.Text + "','" + comboBtype.SelectedValue + "');"

        cdb.mycmd.ExecuteNonQuery()
        MessageBox.Show("เพิ่มข้อมูลได้สำเร็จ", "ผลการดำเนินการ")
        cdb.myObjconn().Close()
    End Sub

    Private Sub btnBSearch_Click(sender As Object, e As EventArgs) Handles btnBSearch.Click
        If ComboBKey.Text = "ชื่อหนังสือ" Then
            cdb.mystr = "SELECT [Book_ID],[Book_Name],[Writer],[BookBorrow_Price],[Book_Price],[LimitBorrow_Date],[Status],[BookType_ID] FROM [bookbd].[dbo].[Book] WHERE [Book_Name] like '%" + txtBSearch.Text + "%';"
            cdb.myda() = New SqlClient.SqlDataAdapter(cdb.mystr, cdb.myObjconn())
            cdb.myds() = New DataSet

            cdb.myda.Fill(cdb.myds(), "book")
            DataGridViewShowinfoBook.DataMember = "book"
            DataGridViewShowinfoBook.DataSource = cdb.myds()

            cdb.mydr.Close()
        End If
        If ComboBKey.Text = "ชื่อผู้เขียน" Then
            cdb.mystr = "SELECT [Book_ID],[Book_Name],[Writer],[BookBorrow_Price],[Book_Price],[LimitBorrow_Date],[Status],[BookType_ID] FROM [bookbd].[dbo].[Book] WHERE [Writer] like '%" + txtBSearch.Text + "%';"
            cdb.myda() = New SqlClient.SqlDataAdapter(cdb.mystr, cdb.myObjconn())
            cdb.myds() = New DataSet

            cdb.myda.Fill(cdb.myds(), "book")
            DataGridViewShowinfoBook.DataMember = "book"
            DataGridViewShowinfoBook.DataSource = cdb.myds()

            cdb.mydr.Close()
        End If
        If ComboBKey.Text = "รหัสหนังสือ" Then
            cdb.mystr = "SELECT [Book_ID],[Book_Name],[Writer],[BookBorrow_Price],[Book_Price],[LimitBorrow_Date],[Status],[BookType_ID] FROM [bookbd].[dbo].[Book] WHERE [Book_ID] like '%" + txtBSearch.Text + "%';"
            cdb.myda() = New SqlClient.SqlDataAdapter(cdb.mystr, cdb.myObjconn())
            cdb.myds() = New DataSet

            cdb.myda.Fill(cdb.myds(), "book")
            DataGridViewShowinfoBook.DataMember = "book"
            DataGridViewShowinfoBook.DataSource = cdb.myds()

            cdb.mydr.Close()
        End If
    End Sub
    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        typebookform.Show()
    End Sub


    Private Sub intoComboTypeS()
        ComboBKey.Text = "ค้นหาแบบ"
        With ComboBKey
            .Items.Insert(0, ("ชื่อหนังสือ"))
            .Items.Insert(1, ("ชื่อผู้เขียน"))
            .Items.Insert(2, ("รหัสหนังสือ"))
        End With
    End Sub

    Private Sub intocomboBType() 'นำข้อมูลจากฐานข้อมูลมาใส่ Combobox
        cdb.mystr = "SELECT * FROM [bookbd].[dbo].[Book_Type]"
        Dim cmd As New SqlClient.SqlCommand(cdb.mystr(), cdb.myObjconn())
        cdb.mydr = cmd.ExecuteReader()
        Dim comboSource As New Dictionary(Of String, String)()
        comboSource.Add(0, "เลือกประเภท")
        If cdb.mydr.HasRows Then
            While cdb.mydr.Read
                comboSource.Add(cdb.mydr.Item(0), cdb.mydr.Item(1))
            End While
            cdb.mydr.Close()
        End If
        ' comboSource.Add(comboSource.Count + 1, "อื่นๆ")
        comboBtype.DataSource = New BindingSource(comboSource, Nothing)
        comboBtype.DisplayMember = "Value"
        comboBtype.ValueMember = "Key"
        'cdb.mydr.Close()
        'cdb.myObjconn().Close()
    End Sub
    Private Sub showdata()
        cdb.mystr = "SELECT * FROM [bookbd].[dbo].[Book]"
        cdb.myda() = New SqlClient.SqlDataAdapter(cdb.mystr, cdb.myObjconn)
        cdb.myds() = New DataSet
        cdb.myda().Fill(cdb.myds(), "Book")

        DataGridViewShowinfoBook.DataMember = "Book"
        DataGridViewShowinfoBook.DataSource = cdb.myds()
        cdb.myObjconn().Close()
    End Sub
    Private Sub setheaderGridview()
        DataGridViewShowinfoBook.Columns(0).HeaderText = "No."
        DataGridViewShowinfoBook.Columns(1).HeaderText = "ไอดีหนังสือ"
        DataGridViewShowinfoBook.Columns(3).HeaderText = "ชื่อหนังสือ"
        DataGridViewShowinfoBook.Columns(4).HeaderText = "ประเภทหนังสือ"
        DataGridViewShowinfoBook.Columns(5).HeaderText = "ผู้เขียน"
        DataGridViewShowinfoBook.Columns(6).HeaderText = "ราคายืม"
        DataGridViewShowinfoBook.Columns(7).HeaderText = "ราคาปก"
        DataGridViewShowinfoBook.Columns(8).HeaderText = "ยืมได้"
        DataGridViewShowinfoBook.Columns(9).HeaderText = "สถานะ"
    End Sub

    Private Sub in2txt()
        cdb.mystr = "SELECT        dbo.Book.Book_ID, dbo.Book.Book_Name, dbo.Book.Writer, dbo.Book.BookBorrow_Price, dbo.Book.Book_Price, dbo.Book.LimitBorrow_Date, dbo.Book.Status, dbo.Book_Type.BookType_Name
FROM            dbo.Book INNER JOIN
                         dbo.Book_Type ON dbo.Book.BookType_ID = dbo.Book_Type.BookType_ID where Book_ID = '" + strcell.Trim + "';"
        Dim cmd As New SqlClient.SqlCommand(cdb.mystr, cdb.myObjconn())
        cdb.mydr = cmd.ExecuteReader()

        If cdb.mydr.HasRows Then
            While cdb.mydr.Read
                txtBId.Text = cdb.mydr.Item(0)
                txtBName.Text = cdb.mydr().Item(1)
                txtBwrt.Text = cdb.mydr().Item(2)
                txtBBrlP.Text = cdb.mydr().Item(3)
                txtBCvP.Text = cdb.mydr().Item(4)
                txtBLm.Text = cdb.mydr().Item(5)
                txtBstt.Text = cdb.mydr().Item(6)
                comboBtype.Text = cdb.mydr().Item(7)


            End While
        Else
            MessageBox.Show("ไม่มีข้อมูล", "ผลการดำเนินการ")
        End If
        cdb.mydr.Close()
    End Sub

    Private Sub DataGridViewShowinfoBook_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles DataGridViewShowinfoBook.MouseDoubleClick
        TabControlBShow.SelectedTab = TabControlBShow.TabPages(1)
        in2txt()
        intocomboBType()
    End Sub
    Private Sub DataGridViewShowinfoBook_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridViewShowinfoBook.CellClick
        With Me.DataGridViewShowinfoBook
            .SelectionMode = DataGridViewSelectionMode.FullRowSelect
            .MultiSelect = False
        End With
        strcell = DataGridViewShowinfoBook.Rows.Item(e.RowIndex).Cells(0).Value.ToString
    End Sub

    Private Sub TabControlBShow_MouseClick(sender As Object, e As MouseEventArgs) Handles TabControlBShow.MouseClick
        'intocomboBType()
        If TabControlBShow.SelectedTab Is TabControlBShow.TabPages(1) Then
            intocomboBType()
        ElseIf TabControlBShow.SelectedTab Is TabControlBShow.TabPages(0) Then
            showdata()
        End If
    End Sub
End Class