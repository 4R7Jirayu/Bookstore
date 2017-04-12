Public Class memberform
    Dim cdb As New conndb()
    Private Sub memberform_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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
    Private Sub btnSearchMem_Click(sender As Object, e As EventArgs) Handles btnSearchMem.Click

    End Sub

    Private Sub btnInsertMem_Click(sender As Object, e As EventArgs) Handles btnInsertMem.Click
        Dim Str As String 'คำสั่ง SQL ใช้ INSERT
        Str = "INSERT INTO  [bookbd].[dbo].[Member] (SSN,FName,LName,Tel,Address) "
        Str += "VALUES('" + txtSNN.Text + "','" + txtName.Text + "','" + txtLname.Text + "','" + TxtTel.Text + "','" + txtAds.Text + "');"
        Dim cmd = New SqlClient.SqlCommand(Str, cdb.myObjconn())
        cmd.ExecuteNonQuery()
        cdb.myObjconn().Close()
        MessageBox.Show("เพิ่มข้อมูลได้สำเร็จ", "ผลการดำเนินการ")
    End Sub

    Private Sub btnUpdateMem_Click(sender As Object, e As EventArgs) Handles btnUpdateMem.Click

    End Sub


End Class