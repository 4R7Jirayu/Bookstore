Public Class typebookform
    Dim cdb As New conndb()
    Private strcell As String
    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        ' comboBTypeID.SelectedValue.ToString()
        cdb.mystr = "INSERT INTO  [bookbd].[dbo].[Book_Type] (BookType_ID,BookType_Name) "
        cdb.mystr += "VALUES('" + txtBTypeID.Text + "','" + txtBTypeName.Text + "');"
        cdb.myObjconn().Open()
        Dim cmd = New SqlClient.SqlCommand(cdb.mystr, cdb.myObjconn())
        cmd.ExecuteNonQuery()
        cdb.myObjconn().Close()
        MessageBox.Show("เพิ่มข้อมูลได้สำเร็จ", "ผลการดำเนินการ", MessageBoxButtons.OK, MessageBoxIcon.Information)
        showdata()
    End Sub
    Private Sub intocombo() 'นำข้อมูลจากฐานข้อมูลมาใส่ Combobox
        'cdb.mystr = "SELECT Book_Type.BookType_ID FROM Book_Type"
        'Dim comboSource As New Dictionary(Of String, String)()
        'comboSource.Add(0, "เพิ่มรหัสประเภทหนังสือ")
        'If cdb.mydr.HasRows Then
        '    While cdb.mydr.Read
        '        comboSource.Add(cdb.mydr.Item(0), cdb.mydr.Item(0))
        '    End While
        '    cdb.mydr.Close()
        'End If
        'comboBTypeID.DataSource = New BindingSource(comboSource, Nothing)
        'comboBTypeID.DisplayMember = "Value"
        'comboBTypeID.ValueMember = "Key"
    End Sub
    Private Sub showdata()
        cdb.mystr = "SELECT Book_Type.BookType_ID,Book_Type.BookType_Name FROM [bookbd].[dbo].[Book_Type]"
        cdb.myObjconn().Open()
        cdb.myda() = New SqlClient.SqlDataAdapter(cdb.mystr, cdb.myObjconn())
        cdb.myds() = New DataSet
        cdb.myda().Fill(cdb.myds(), "TypeBook")
        DataGridViewTypeBook.DataMember = "TypeBook"
        DataGridViewTypeBook.DataSource = cdb.myds()
        cdb.myObjconn().Close()
    End Sub
    Private Sub typebookform_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        '  intocombo()
        showdata()
    End Sub
    Private Sub deldtgridview()
        cdb.mystr = "Delete From [bookbd].[dbo].[Book_Type] where [dbo].[Book_Type].[BookType_ID] = '" + strcell.Trim + "';"
        'cdb.mystr = "DELETE FROM [dbo].[Book_Type] WHERE [dbo].[Book_Type].[BookType_ID] = '" + strcell.Trim + "';"
        Dim result As Integer = MessageBox.Show("ลบข้อมูลรหัสหนังสือ " + strcell.Trim, "", MessageBoxButtons.YesNo)
        If result = DialogResult.Yes Then
            showdata()
            cdb.myObjconn().Open()
            Dim cmd = New SqlClient.SqlCommand(cdb.mystr, cdb.myObjconn())
            cmd.ExecuteNonQuery()
            MessageBox.Show("ลบข้อความเรียบร้อยแล้ว", "ผลการดำเนินการ", MessageBoxButtons.OK, MessageBoxIcon.Information)
            cdb.myObjconn().Close()
            showdata()
        End If
    End Sub

    Private Sub DataGridViewTypeBook_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridViewTypeBook.CellContentClick
        With Me.DataGridViewTypeBook
            .SelectionMode = DataGridViewSelectionMode.FullRowSelect
            .MultiSelect = False
        End With
        strcell = DataGridViewTypeBook.Rows.Item(e.RowIndex).Cells(0).Value.ToString
    End Sub

    Private Sub btnDel_Click(sender As Object, e As EventArgs) Handles btnDel.Click
        deldtgridview()
        showdata()
    End Sub
End Class