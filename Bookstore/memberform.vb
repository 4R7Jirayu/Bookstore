﻿Public Class memberform
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
    Private Sub btnInsertMem_Click(sender As Object, e As EventArgs) Handles btnInsertMem.Click
        'Dim Str As String 'คำสั่ง SQL ใช้ INSERT

        Dim result As Integer = MessageBox.Show("ยืนยันการสมัครหรือไม่ ", "การสมัครสมาชิก", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If result = DialogResult.Yes Then
            cdb.mystr = "INSERT INTO  [bookbd].[dbo].[Member] (SSN,FName,LName,Tel,Address) "
            cdb.mystr += "VALUES('" + txtSNN.Text + "','" + txtName.Text + "','" + txtLname.Text + "','" + TxtTel.Text + "','" + txtAds.Text + "');"
            ' cdb.myObjconn.Open()
            Dim cmd = New SqlClient.SqlCommand(cdb.mystr, cdb.myObjconn())
            cmd.ExecuteNonQuery()
            cdb.myObjconn().Close()
            MessageBox.Show("เพิ่มข้อมูลได้สำเร็จ", "ผลการดำเนินการ",MessageBoxButtons.OK,MessageBoxIcon.Information )
            Cleartxt()
        Else

        End If

    End Sub


    Private Sub btnSearchMem_Click(sender As Object, e As EventArgs) Handles btnSearchMem.Click
        cdb.mystr = "SELECT Member.SSN,Member.FName,Member.LName,Member.Tel,Member.Address FROM Member WHERE Member.SSN = '" + txtInSearch.Text + "';"
        Dim cmd As New SqlClient.SqlCommand(cdb.mystr, cdb.myObjconn())
        cdb.mydr = cmd.ExecuteReader()
        If cdb.mydr().HasRows Then
            While cdb.mydr().Read
                txtSNN.Text = cdb.mydr().Item(0)
                txtName.Text = cdb.mydr().Item(1)
                txtLname.Text = cdb.mydr().Item(2)
                TxtTel.Text = cdb.mydr().Item(3)
                txtAds.Text = cdb.mydr().Item(4)
            End While
        Else
            MessageBox.Show("ไม่มีข้อมูล", "ผลการดำเนินการ",MessageBoxButtons.OK,MessageBoxIcon.Warning)
        End If
        cdb.mydr.Close()
    End Sub

    Private Sub btnUpdateMem_Click(sender As Object, e As EventArgs) Handles btnUpdateMem.Click
        'SQL ในการอัปเดต 'Member.SSN ='" + txtSNN.Text + "',
        cdb.mystr = "UPDATE Member SET Member.FName ='" + txtName.Text + "',Member.LName='" + txtLname.Text + "',Member.Tel ='" + TxtTel.Text + "',Member.Address ='" + txtAds.Text + "' WHERE Member.SSN = '" + txtSNN.Text + "';"
        Dim cmd = New SqlClient.SqlCommand(cdb.mystr, cdb.myObjconn)
        cmd.ExecuteNonQuery()
        MessageBox.Show("อัฟเดตข้อมูลได้สำเร็จ", "ผลการดำเนินการ",MessageBoxButtons.OK,MessageBoxIcon.Information)
        Cleartxt()

    End Sub

    Private Sub Cleartxt()
        cdb.myObjconn.Close()
        txtSNN.Clear()
        txtName.Clear()
        txtLname.Clear()
        TxtTel.Clear()
        txtAds.Clear()
        txtInSearch.Clear()
    End Sub

    Private Sub showdata()
        cdb.mystr = "SELECT * FROM [bookbd].[dbo].[Member]"
        cdb.myda() = New SqlClient.SqlDataAdapter(cdb.mystr, cdb.myObjconn)
        cdb.myds() = New DataSet
        cdb.myda().Fill(cdb.myds(), "mem")

        DataGridViewShow.DataMember = "mem"
        DataGridViewShow.DataSource = cdb.myds()
        cdb.myObjconn().Close()

        DataGridViewShow.Columns(0).HeaderText = "รหัสประจำตัวประชาชน"
        DataGridViewShow.Columns(1).HeaderText = "ชื่อ"
        DataGridViewShow.Columns(2).HeaderText = "นามสกุล"
        DataGridViewShow.Columns(3).HeaderText = "เบอร์โทร"
        DataGridViewShow.Columns(4).HeaderText = "ที่อยู่"
        'DataGridViewShow.Columns(5).HeaderText = "อีเมล์"
        '  DataGridViewShow.Columns(6).HeaderText = "เบอร์โทรศัพท์"
    End Sub

    Private Sub TabControl1_MouseClick(sender As Object, e As MouseEventArgs) Handles TabControl1.MouseClick

        'intocomboBType()
        If TabControl1.SelectedTab Is TabControl1.TabPages(1) Then
            showdata()
        End If

    End Sub
End Class