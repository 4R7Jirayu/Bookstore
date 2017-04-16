Public Class bookinform
    Dim cdb As New conndb()

    Public strcell As String
    Private Sub bookinform_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        intoComboTypeS()
        ' setheaderGridview()
        intocomboBType()
        showdata()
    End Sub

    Private Sub btnBUpdate_Click(sender As Object, e As EventArgs) Handles btnBUpdate.Click
        If btnBUpdate.Text = "แก้ไข" Then
            btnBUpdate.Text = "อัปเดตข้อมูล"
        ElseIf btnBUpdate.Text = "อัปเดตข้อมูล" Then
            btnBUpdate.Text = "แก้ไข"

            'txtBId.Visible = True
            ''    txtBId = Visible
            'txtBName.Text = Visible
            'txtBwrt.Text = Visible
            'txtBBrlP.Text = Visible
            'txtBCvP.Text = Visible
            'txtBLm.Text = Visible
            'txtBstt.Text = Visible
            'comboBtype.Text = Visible

        End If
    End Sub

    Private Sub btnBInsert_Click(sender As Object, e As EventArgs) Handles btnBInsert.Click
        Dim Str As String 'คำสั่ง SQL ใช้ INSERT]

        cdb.mystr = "INSERT INTO [bookbd].[dbo].[Book] ([Book_ID],[Book_Name],[Writer],[BookBorrow_Price],[Book_Price],[LimitBorrow_Date],[Status],[BookType_ID]) "
        cdb.mystr += "VALUES ('" + txtBId.Text + "','" + txtBName.Text + "','" + txtBwrt.Text + "','" + txtBBrlP.Text + "','" + txtBCvP.Text + "','" + txtBLm.Text + "','" + txtBstt.Text + "','" + comboBtype.SelectedValue + "');"

        cdb.myObjconn.Open()

        'Dim cmd = New SqlClient.SqlCommand(cdb.mystr, cdb.myObjconn)
        'cmd.ExecuteNonQuery()
        cdb.mycmd.ExecuteNonQuery()
        MessageBox.Show("เพิ่มข้อมูลได้สำเร็จ", "ผลการดำเนินการ")
        cdb.myObjconn().Close()
    End Sub

    Private Sub btnBSearch_Click(sender As Object, e As EventArgs) Handles btnBSearch.Click

        If ComboBKey.Text = "ชื่อหนังสือ" Then
            cdb.myObjconn.Open()
            cdb.mystr = "SELECT [Book_ID],[Book_Name],[Writer],[BookBorrow_Price],[Book_Price],[LimitBorrow_Date],[Status],[BookType_ID] FROM [bookbd].[dbo].[Book] WHERE [Book_Name] = '" + txtBSearch.Text + "';"
            If cdb.mydr().HasRows Then
                While cdb.mydr().Read
                    db2txtB()
                End While
            Else
                MessageBox.Show("ไม่มีข้อมูล", "ผลการดำเนินการ")
            End If
            cdb.mydr.Close()
        End If
    End Sub
    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        typebookform.Show()
    End Sub

    Private Sub db2txtB()
        txtBId.Text += cdb.mydr().Item(0)
        txtBName.Text += cdb.mydr().Item(1)
        txtBwrt.Text += cdb.mydr().Item(2)
        txtBBrlP.Text += cdb.mydr().Item(3)
        txtBCvP.Text += cdb.mydr().Item(4)
        txtBLm.Text += cdb.mydr().Item(5)
        txtBstt.Text += cdb.mydr().Item(6)
        comboBtype.Text += cdb.mydr().Item(7)
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
        cdb.myObjconn().Open()
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
        comboBtype.DataSource = New BindingSource(comboSource, Nothing)
        comboBtype.DisplayMember = "Value"
        comboBtype.ValueMember = "Key"
        cdb.myObjconn().Close()
    End Sub
    Private Sub showdata()
        cdb.mystr = "SELECT * FROM [bookbd].[dbo].[Book]"
        cdb.myObjconn().Open()
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
End Class