<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class bookinform
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnBSearch = New System.Windows.Forms.Button()
        Me.txtBSearch = New System.Windows.Forms.TextBox()
        Me.ComboBKey = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnBInsert = New System.Windows.Forms.Button()
        Me.txtBId = New System.Windows.Forms.TextBox()
        Me.txtBName = New System.Windows.Forms.TextBox()
        Me.txtBwrt = New System.Windows.Forms.TextBox()
        Me.txtBBrlP = New System.Windows.Forms.TextBox()
        Me.txtBCvP = New System.Windows.Forms.TextBox()
        Me.txtBLm = New System.Windows.Forms.TextBox()
        Me.txtBstt = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.btnBUpdate = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(210, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(64, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "ข้อมูลหนังสือ"
        '
        'btnBSearch
        '
        Me.btnBSearch.Location = New System.Drawing.Point(354, 18)
        Me.btnBSearch.Name = "btnBSearch"
        Me.btnBSearch.Size = New System.Drawing.Size(75, 23)
        Me.btnBSearch.TabIndex = 1
        Me.btnBSearch.Text = "ค้นหา"
        Me.btnBSearch.UseVisualStyleBackColor = True
        '
        'txtBSearch
        '
        Me.txtBSearch.Location = New System.Drawing.Point(126, 19)
        Me.txtBSearch.Name = "txtBSearch"
        Me.txtBSearch.Size = New System.Drawing.Size(200, 20)
        Me.txtBSearch.TabIndex = 2
        '
        'ComboBKey
        '
        Me.ComboBKey.FormattingEnabled = True
        Me.ComboBKey.Location = New System.Drawing.Point(13, 20)
        Me.ComboBKey.Name = "ComboBKey"
        Me.ComboBKey.Size = New System.Drawing.Size(77, 21)
        Me.ComboBKey.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(122, 118)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(0, 13)
        Me.Label2.TabIndex = 4
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtBSearch)
        Me.GroupBox1.Controls.Add(Me.btnBSearch)
        Me.GroupBox1.Controls.Add(Me.ComboBKey)
        Me.GroupBox1.Location = New System.Drawing.Point(26, 25)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(441, 57)
        Me.GroupBox1.TabIndex = 5
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "ค้นหาหนังสือ"
        '
        'btnBInsert
        '
        Me.btnBInsert.Location = New System.Drawing.Point(156, 345)
        Me.btnBInsert.Name = "btnBInsert"
        Me.btnBInsert.Size = New System.Drawing.Size(75, 23)
        Me.btnBInsert.TabIndex = 6
        Me.btnBInsert.Text = "เพิ่มหนังสือ"
        Me.btnBInsert.UseVisualStyleBackColor = True
        '
        'txtBId
        '
        Me.txtBId.Location = New System.Drawing.Point(225, 111)
        Me.txtBId.Name = "txtBId"
        Me.txtBId.Size = New System.Drawing.Size(147, 20)
        Me.txtBId.TabIndex = 7
        '
        'txtBName
        '
        Me.txtBName.Location = New System.Drawing.Point(225, 137)
        Me.txtBName.Name = "txtBName"
        Me.txtBName.Size = New System.Drawing.Size(147, 20)
        Me.txtBName.TabIndex = 8
        '
        'txtBwrt
        '
        Me.txtBwrt.Location = New System.Drawing.Point(225, 163)
        Me.txtBwrt.Name = "txtBwrt"
        Me.txtBwrt.Size = New System.Drawing.Size(147, 20)
        Me.txtBwrt.TabIndex = 9
        '
        'txtBBrlP
        '
        Me.txtBBrlP.Location = New System.Drawing.Point(225, 189)
        Me.txtBBrlP.Name = "txtBBrlP"
        Me.txtBBrlP.Size = New System.Drawing.Size(147, 20)
        Me.txtBBrlP.TabIndex = 10
        '
        'txtBCvP
        '
        Me.txtBCvP.Location = New System.Drawing.Point(225, 215)
        Me.txtBCvP.Name = "txtBCvP"
        Me.txtBCvP.Size = New System.Drawing.Size(147, 20)
        Me.txtBCvP.TabIndex = 11
        '
        'txtBLm
        '
        Me.txtBLm.Location = New System.Drawing.Point(225, 241)
        Me.txtBLm.Name = "txtBLm"
        Me.txtBLm.Size = New System.Drawing.Size(147, 20)
        Me.txtBLm.TabIndex = 12
        '
        'txtBstt
        '
        Me.txtBstt.Location = New System.Drawing.Point(225, 267)
        Me.txtBstt.Name = "txtBstt"
        Me.txtBstt.Size = New System.Drawing.Size(147, 20)
        Me.txtBstt.TabIndex = 13
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(128, 114)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(58, 13)
        Me.Label3.TabIndex = 14
        Me.Label3.Text = "ไอดีหนังสือ"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(128, 140)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(52, 13)
        Me.Label4.TabIndex = 15
        Me.Label4.Text = "ชื่อหน้งสือ"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(128, 166)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(40, 13)
        Me.Label5.TabIndex = 16
        Me.Label5.Text = "ผู้เขียน"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(128, 192)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(44, 13)
        Me.Label6.TabIndex = 17
        Me.Label6.Text = "ราคายืม"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(128, 218)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(44, 13)
        Me.Label7.TabIndex = 18
        Me.Label7.Text = "ราคาปก"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(128, 244)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(34, 13)
        Me.Label8.TabIndex = 19
        Me.Label8.Text = "ยืมได้"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(128, 270)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(38, 13)
        Me.Label9.TabIndex = 20
        Me.Label9.Text = "สถานะ"
        '
        'btnBUpdate
        '
        Me.btnBUpdate.Location = New System.Drawing.Point(277, 345)
        Me.btnBUpdate.Name = "btnBUpdate"
        Me.btnBUpdate.Size = New System.Drawing.Size(75, 23)
        Me.btnBUpdate.TabIndex = 21
        Me.btnBUpdate.Text = "แก้ไข"
        Me.btnBUpdate.UseVisualStyleBackColor = True
        '
        'bookinform
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(510, 456)
        Me.Controls.Add(Me.btnBUpdate)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtBstt)
        Me.Controls.Add(Me.txtBLm)
        Me.Controls.Add(Me.txtBCvP)
        Me.Controls.Add(Me.txtBBrlP)
        Me.Controls.Add(Me.txtBwrt)
        Me.Controls.Add(Me.txtBName)
        Me.Controls.Add(Me.txtBId)
        Me.Controls.Add(Me.btnBInsert)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "bookinform"
        Me.Text = "bookinform"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents btnBSearch As Button
    Friend WithEvents txtBSearch As TextBox
    Friend WithEvents ComboBKey As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents btnBInsert As Button
    Friend WithEvents txtBId As TextBox
    Friend WithEvents txtBName As TextBox
    Friend WithEvents txtBwrt As TextBox
    Friend WithEvents txtBBrlP As TextBox
    Friend WithEvents txtBCvP As TextBox
    Friend WithEvents txtBLm As TextBox
    Friend WithEvents txtBstt As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents btnBUpdate As Button
End Class
