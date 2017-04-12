Public Class bookinform
    Dim cdb As New conndb()
    Public strcell As String
    Private Sub btnBUpdate_Click(sender As Object, e As EventArgs) Handles btnBUpdate.Click
        If btnBUpdate.Text = "แก้ไข" Then
            btnBUpdate.Text = "อัปเดตข้อมูล"
        End If
    End Sub

    Private Sub btnBInsert_Click(sender As Object, e As EventArgs) Handles btnBInsert.Click
        Dim Str As String 'คำสั่ง SQL ใช้ INSERT
        '   Str = "INSERT INTO Student values ('" + TxtIdStudent.Text + "','" + TxtName.Text + "','" + TxtLastName.Text + "','" + TxtMajor.SelectedValue.ToString() + "','" + TxtAddress.Text + "','" + TxtEmail.Text + "','" + TxtTel.Text + "');"
        Dim cmd = New SqlClient.SqlCommand(Str, cdb.myObjconn())
        cmd.ExecuteNonQuery()
        MessageBox.Show("เพิ่มข้อมูลได้สำเร็จ", "ผลการดำเนินการ")
        cdb.myObjconn().Close()
    End Sub
End Class