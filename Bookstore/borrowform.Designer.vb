﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class borrowform
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.txtMemb = New System.Windows.Forms.TextBox()
        Me.txtBookID = New System.Windows.Forms.TextBox()
        Me.btnAdd2L = New System.Windows.Forms.Button()
        Me.btnConf = New System.Windows.Forms.Button()
        Me.DataGVList = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.LbShowTime = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.LlTot = New System.Windows.Forms.Label()
        CType(Me.DataGVList, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtMemb
        '
        Me.txtMemb.Location = New System.Drawing.Point(109, 35)
        Me.txtMemb.Name = "txtMemb"
        Me.txtMemb.Size = New System.Drawing.Size(100, 20)
        Me.txtMemb.TabIndex = 0
        '
        'txtBookID
        '
        Me.txtBookID.Location = New System.Drawing.Point(292, 33)
        Me.txtBookID.Name = "txtBookID"
        Me.txtBookID.Size = New System.Drawing.Size(100, 20)
        Me.txtBookID.TabIndex = 1
        '
        'btnAdd2L
        '
        Me.btnAdd2L.Location = New System.Drawing.Point(492, 31)
        Me.btnAdd2L.Name = "btnAdd2L"
        Me.btnAdd2L.Size = New System.Drawing.Size(75, 23)
        Me.btnAdd2L.TabIndex = 2
        Me.btnAdd2L.Text = "เพิ่ม"
        Me.btnAdd2L.UseVisualStyleBackColor = True
        '
        'btnConf
        '
        Me.btnConf.Location = New System.Drawing.Point(515, 426)
        Me.btnConf.Name = "btnConf"
        Me.btnConf.Size = New System.Drawing.Size(103, 23)
        Me.btnConf.TabIndex = 3
        Me.btnConf.Text = "ยืนยันการยืม"
        Me.btnConf.UseVisualStyleBackColor = True
        '
        'DataGVList
        '
        Me.DataGVList.AllowUserToAddRows = False
        Me.DataGVList.AllowUserToDeleteRows = False
        Me.DataGVList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGVList.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3, Me.Column4, Me.Column5})
        Me.DataGVList.Location = New System.Drawing.Point(12, 84)
        Me.DataGVList.Name = "DataGVList"
        Me.DataGVList.ReadOnly = True
        Me.DataGVList.Size = New System.Drawing.Size(640, 336)
        Me.DataGVList.TabIndex = 4
        '
        'Column1
        '
        Me.Column1.HeaderText = "No."
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        '
        'Column2
        '
        Me.Column2.HeaderText = "ชื่อผู้ยืม"
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        '
        'Column3
        '
        Me.Column3.HeaderText = "ชื่อหนังสือ"
        Me.Column3.Name = "Column3"
        Me.Column3.ReadOnly = True
        '
        'Column4
        '
        Me.Column4.HeaderText = "ราคายืม"
        Me.Column4.Name = "Column4"
        Me.Column4.ReadOnly = True
        '
        'Column5
        '
        Me.Column5.HeaderText = "กำหนดวันส่ง"
        Me.Column5.Name = "Column5"
        Me.Column5.ReadOnly = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(62, 36)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(41, 13)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "ชื่อผู้ยืม"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(228, 37)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(58, 13)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "ไอดีหนังสือ"
        '
        'LbShowTime
        '
        Me.LbShowTime.AutoSize = True
        Me.LbShowTime.Location = New System.Drawing.Point(413, 35)
        Me.LbShowTime.Name = "LbShowTime"
        Me.LbShowTime.Size = New System.Drawing.Size(43, 13)
        Me.LbShowTime.TabIndex = 7
        Me.LbShowTime.Text = "เวลายืม"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(12, 439)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(108, 13)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "รวมราคายืมทั้งหมด  : "
        '
        'LlTot
        '
        Me.LlTot.AutoSize = True
        Me.LlTot.Location = New System.Drawing.Point(126, 439)
        Me.LlTot.Name = "LlTot"
        Me.LlTot.Size = New System.Drawing.Size(0, 13)
        Me.LlTot.TabIndex = 9
        '
        'borrowform
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(664, 461)
        Me.Controls.Add(Me.LlTot)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.LbShowTime)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.DataGVList)
        Me.Controls.Add(Me.btnConf)
        Me.Controls.Add(Me.btnAdd2L)
        Me.Controls.Add(Me.txtBookID)
        Me.Controls.Add(Me.txtMemb)
        Me.Name = "borrowform"
        Me.Text = "ยืม"
        CType(Me.DataGVList, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtMemb As TextBox
    Friend WithEvents txtBookID As TextBox
    Friend WithEvents btnAdd2L As Button
    Friend WithEvents btnConf As Button
    Friend WithEvents DataGVList As DataGridView
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents LbShowTime As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents LlTot As Label
End Class