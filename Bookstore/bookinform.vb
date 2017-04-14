Public Class bookinform
    Dim cdb As New conndb()

    Public strcell As String
    Private Sub intoComboTypeS()
        ComboBKey.Text = "ค้นหาแบบ"
        With ComboBKey
            .Items.Insert(0, ("ชื่อหนังสือ"))
            .Items.Insert(1, ("ชื่อผู้เขียน"))
            .Items.Insert(2, ("รหัสหนังสือ"))
        End With
    End Sub
    Private Sub btnBUpdate_Click(sender As Object, e As EventArgs) Handles btnBUpdate.Click
        If btnBUpdate.Text = "แก้ไข" Then
            btnBUpdate.Text = "อัปเดตข้อมูล"
        ElseIf btnBUpdate.Text = "อัปเดตข้อมูล" Then
            btnBUpdate.Text = "แก้ไข"
            'txtBId.Text += cdb.mydr().Item(0)
            'txtBName.Text += cdb.mydr().Item(1)
            'txtBwrt.Text += cdb.mydr().Item(2)
            'txtBBrlP.Text += cdb.mydr().Item(3)
            'txtBCvP.Text += cdb.mydr().Item(4)
            'txtBLm.Text += cdb.mydr().Item(5)
            'txtBstt.Text += cdb.mydr().Item(6)
            'comboBtype.Text += cdb.mydr().Item(7)








            txtBId.Visible = True


            '    txtBId = Visible
            txtBName.Text = Visible
            txtBwrt.Text = Visible
            txtBBrlP.Text = Visible
            txtBCvP.Text = Visible
            txtBLm.Text = Visible
            txtBstt.Text = Visible
            comboBtype.Text = Visible

        End If
    End Sub
    Private Sub bookinform_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Try
        '    If cdb.myObjconn().State = ConnectionState.Closed Then
        '        cdb.myObjconn().Open()
        '        ' MessageBox.Show("Connect")
        '    End If
        'Catch ex As Exception
        '    MessageBox.Show(ex.ToString)
        '    Application.Exit()
        'End Try
        intoComboTypeS()
    End Sub
    Private Sub btnBInsert_Click(sender As Object, e As EventArgs) Handles btnBInsert.Click
        Dim Str As String 'คำสั่ง SQL ใช้ INSERT
        Str = "INSERT INTO [dbo].[Book] ([Book_ID],[Book_Name],[Writer],[BookBorrow_Price],[Book_Price],[LimitBorrow_Date],[Status],[BookType_ID]) "
        Str += "VALUES ('" + txtBId.Text + "','" + txtBName.Text + "','" + txtBwrt.Text + "','" + txtBBrlP.Text + "','" + txtBCvP.Text + "','" + txtBLm.Text + "','" + txtBstt.Text + "','" + comboBtype.SelectedValue.ToString + "');"

        Dim cmd = New SqlClient.SqlCommand(Str, cdb.myObjconn())
        cmd.ExecuteNonQuery()
        MessageBox.Show("เพิ่มข้อมูลได้สำเร็จ", "ผลการดำเนินการ")
        cdb.myObjconn().Close()
    End Sub

    Private Sub btnBSearch_Click(sender As Object, e As EventArgs) Handles btnBSearch.Click
        If ComboBKey.Text = "ชื่อหนังสือ" Then
            cdb.mystr = "SELECT [Book_ID],[Book_Name],[Writer],[BookBorrow_Price],[Book_Price],[LimitBorrow_Date],[Status],[BookType_ID] FROM [dbo].[Book] WHERE [Book_Name] = '" + txtBName.Text + "';"
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

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        typebookform.Show()
    End Sub
End Class