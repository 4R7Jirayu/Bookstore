<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class memberform
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
        Me.txtAds = New System.Windows.Forms.RichTextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TxtTel = New System.Windows.Forms.TextBox()
        Me.txtLname = New System.Windows.Forms.TextBox()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.txtSNN = New System.Windows.Forms.TextBox()
        Me.btnInsertMem = New System.Windows.Forms.Button()
        Me.txtInSearch = New System.Windows.Forms.TextBox()
        Me.btnSearchMem = New System.Windows.Forms.Button()
        Me.btnUpdateMem = New System.Windows.Forms.Button()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DataGridViewShow = New System.Windows.Forms.DataGridView()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        CType(Me.DataGridViewShow, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtAds
        '
        Me.txtAds.Location = New System.Drawing.Point(118, 139)
        Me.txtAds.Name = "txtAds"
        Me.txtAds.Size = New System.Drawing.Size(186, 96)
        Me.txtAds.TabIndex = 50
        Me.txtAds.Text = ""
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(29, 142)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(27, 13)
        Me.Label6.TabIndex = 49
        Me.Label6.Text = "ที่อยู่"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(29, 116)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(31, 13)
        Me.Label5.TabIndex = 48
        Me.Label5.Text = "เบอร์"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(29, 90)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(46, 13)
        Me.Label4.TabIndex = 47
        Me.Label4.Text = "นามสกุล"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(29, 64)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(20, 13)
        Me.Label3.TabIndex = 46
        Me.Label3.Text = "ชื่อ"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(29, 38)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(66, 13)
        Me.Label2.TabIndex = 45
        Me.Label2.Text = "เลขประจำตัว"
        '
        'TxtTel
        '
        Me.TxtTel.Location = New System.Drawing.Point(118, 109)
        Me.TxtTel.Name = "TxtTel"
        Me.TxtTel.Size = New System.Drawing.Size(186, 20)
        Me.TxtTel.TabIndex = 43
        '
        'txtLname
        '
        Me.txtLname.Location = New System.Drawing.Point(118, 83)
        Me.txtLname.Name = "txtLname"
        Me.txtLname.Size = New System.Drawing.Size(186, 20)
        Me.txtLname.TabIndex = 42
        '
        'txtName
        '
        Me.txtName.Location = New System.Drawing.Point(118, 57)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(186, 20)
        Me.txtName.TabIndex = 41
        '
        'txtSNN
        '
        Me.txtSNN.Location = New System.Drawing.Point(118, 31)
        Me.txtSNN.Name = "txtSNN"
        Me.txtSNN.Size = New System.Drawing.Size(186, 20)
        Me.txtSNN.TabIndex = 40
        '
        'btnInsertMem
        '
        Me.btnInsertMem.Location = New System.Drawing.Point(49, 284)
        Me.btnInsertMem.Name = "btnInsertMem"
        Me.btnInsertMem.Size = New System.Drawing.Size(85, 23)
        Me.btnInsertMem.TabIndex = 38
        Me.btnInsertMem.Text = "สมัครสมาชิก"
        Me.btnInsertMem.UseVisualStyleBackColor = True
        '
        'txtInSearch
        '
        Me.txtInSearch.Location = New System.Drawing.Point(108, 335)
        Me.txtInSearch.Name = "txtInSearch"
        Me.txtInSearch.Size = New System.Drawing.Size(100, 20)
        Me.txtInSearch.TabIndex = 51
        '
        'btnSearchMem
        '
        Me.btnSearchMem.Location = New System.Drawing.Point(229, 333)
        Me.btnSearchMem.Name = "btnSearchMem"
        Me.btnSearchMem.Size = New System.Drawing.Size(75, 23)
        Me.btnSearchMem.TabIndex = 52
        Me.btnSearchMem.Text = "ค้นหา"
        Me.btnSearchMem.UseVisualStyleBackColor = True
        '
        'btnUpdateMem
        '
        Me.btnUpdateMem.Location = New System.Drawing.Point(182, 284)
        Me.btnUpdateMem.Name = "btnUpdateMem"
        Me.btnUpdateMem.Size = New System.Drawing.Size(85, 23)
        Me.btnUpdateMem.TabIndex = 53
        Me.btnUpdateMem.Text = "อัปเดตข้อมูล"
        Me.btnUpdateMem.UseVisualStyleBackColor = True
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Location = New System.Drawing.Point(21, 21)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(351, 399)
        Me.TabControl1.TabIndex = 54
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.Label1)
        Me.TabPage1.Controls.Add(Me.txtSNN)
        Me.TabPage1.Controls.Add(Me.btnSearchMem)
        Me.TabPage1.Controls.Add(Me.txtInSearch)
        Me.TabPage1.Controls.Add(Me.btnUpdateMem)
        Me.TabPage1.Controls.Add(Me.btnInsertMem)
        Me.TabPage1.Controls.Add(Me.txtName)
        Me.TabPage1.Controls.Add(Me.txtLname)
        Me.TabPage1.Controls.Add(Me.txtAds)
        Me.TabPage1.Controls.Add(Me.TxtTel)
        Me.TabPage1.Controls.Add(Me.Label6)
        Me.TabPage1.Controls.Add(Me.Label2)
        Me.TabPage1.Controls.Add(Me.Label5)
        Me.TabPage1.Controls.Add(Me.Label3)
        Me.TabPage1.Controls.Add(Me.Label4)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(343, 373)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "ข้อมูลสมาชิก"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.DataGridViewShow)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(343, 373)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "แสดงทั้งหมด"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(29, 338)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(66, 13)
        Me.Label1.TabIndex = 54
        Me.Label1.Text = "เลขประจำตัว"
        '
        'DataGridViewShow
        '
        Me.DataGridViewShow.AllowUserToAddRows = False
        Me.DataGridViewShow.AllowUserToDeleteRows = False
        Me.DataGridViewShow.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViewShow.Location = New System.Drawing.Point(0, 0)
        Me.DataGridViewShow.Name = "DataGridViewShow"
        Me.DataGridViewShow.ReadOnly = True
        Me.DataGridViewShow.Size = New System.Drawing.Size(343, 370)
        Me.DataGridViewShow.TabIndex = 0
        '
        'memberform
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(395, 448)
        Me.Controls.Add(Me.TabControl1)
        Me.Name = "memberform"
        Me.Text = "ข้อมูลสมาชิก"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        CType(Me.DataGridViewShow, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents txtAds As RichTextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents TxtTel As TextBox
    Friend WithEvents txtLname As TextBox
    Friend WithEvents txtName As TextBox
    Friend WithEvents txtSNN As TextBox
    Friend WithEvents btnInsertMem As Button
    Friend WithEvents txtInSearch As TextBox
    Friend WithEvents btnSearchMem As Button
    Friend WithEvents btnUpdateMem As Button
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents Label1 As Label
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents DataGridViewShow As DataGridView
End Class
