Public Class memberform
    Dim cdb As New conndb()
    Private Sub memberform_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Try
        '    If cdb.myObjconn().State = ConnectionState.Closed Then
        '        cdb.myObjconn().Open()
        '        ' MessageBox.Show("Connect")
        '    End If
        'Catch ex As Exception
        '    MessageBox.Show(ex.ToString)
        '    Application.Exit()
        'End Try
    End Sub
    Private Sub btnInsertMem_Click(sender As Object, e As EventArgs) Handles btnInsertMem.Click
        'Dim Str As String 'คำสั่ง SQL ใช้ INSERT
        cdb.mystr = "INSERT INTO  [bookbd].[dbo].[Member] (SSN,FName,LName,Tel,Address) "
        cdb.mystr += "VALUES('" + txtSNN.Text + "','" + txtName.Text + "','" + txtLname.Text + "','" + TxtTel.Text + "','" + txtAds.Text + "');"
        cdb.myObjconn.Open()
        Dim cmd = New SqlClient.SqlCommand(cdb.mystr, cdb.myObjconn())
        cmd.ExecuteNonQuery()
        cdb.myObjconn().Close()
        MessageBox.Show("เพิ่มข้อมูลได้สำเร็จ", "ผลการดำเนินการ")
    End Sub
    Private Sub btnSearchMem_Click(sender As Object, e As EventArgs) Handles btnSearchMem.Click
        cdb.mystr = "SELECT Member.SSN,Member.FName,Member.LName,Member.Tel,Member.Address FROM Member WHERE Member.SSN = '" + txtSNN.Text + "';"
        If cdb.mydr().HasRows Then
            While cdb.mydr().Read
                txtSNN.Text += cdb.mydr().Item(0)
                txtName.Text += cdb.mydr().Item(1)
                txtLname.Text += cdb.mydr().Item(2)
                TxtTel.Text += cdb.mydr().Item(3)
                txtAds.Text += cdb.mydr().Item(4)
            End While
        Else
            MessageBox.Show("ไม่มีข้อมูล", "ผลการดำเนินการ")
        End If
        cdb.mydr.Close()
    End Sub

    Private Sub btnUpdateMem_Click(sender As Object, e As EventArgs) Handles btnUpdateMem.Click
        'SQL ในการอัปเดต 'Member.SSN ='" + txtSNN.Text + "',
        cdb.mystr = "UPDATE Member SET Member.FName ='" + txtName.Text + "',Member.LName='" + txtLname.Text + "',Member.Tel ='" + TxtTel.Text + "',Member.Address ='" + txtAds.Text + "' WHERE Member.SSN = '" + txtSNN.Text + "';"
        Dim cmd = New SqlClient.SqlCommand(cdb.mystr, cdb.myObjconn)
        cmd.ExecuteNonQuery()
        MessageBox.Show("อัฟเดตข้อมูลได้สำเร็จ", "ผลการดำเนินการ")
        cdb.myObjconn.Close()
    End Sub


End Class