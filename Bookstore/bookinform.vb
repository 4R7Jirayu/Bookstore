Public Class bookinform
    Dim cdb As New conndb()
    Public strcell As String
    Private Sub btnBUpdate_Click(sender As Object, e As EventArgs) Handles btnBUpdate.Click
        If btnBUpdate.Text = "แก้ไข" Then
            btnBUpdate.Text = "อัปเดตข้อมูล"
        ElseIf btnBUpdate.Text = "อัปเดตข้อมูล" Then
            btnBUpdate.Text = "แก้ไข"
        End If
    End Sub
    Private Sub bookinform_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            If cdb.myObjconn().State = ConnectionState.Closed Then
                cdb.myObjconn().Open()
                ' MessageBox.Show("Connect")
            End If
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
            Application.Exit()
        End Try
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


End Class