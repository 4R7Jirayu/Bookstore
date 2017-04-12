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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TxtTel = New System.Windows.Forms.TextBox()
        Me.txtLname = New System.Windows.Forms.TextBox()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.txtSNN = New System.Windows.Forms.TextBox()
        Me.txtMemId = New System.Windows.Forms.TextBox()
        Me.btnInsertMem = New System.Windows.Forms.Button()
        Me.txtInSearch = New System.Windows.Forms.TextBox()
        Me.btnSearchMem = New System.Windows.Forms.Button()
        Me.btnUpdateMem = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'txtAds
        '
        Me.txtAds.Location = New System.Drawing.Point(130, 226)
        Me.txtAds.Name = "txtAds"
        Me.txtAds.Size = New System.Drawing.Size(186, 96)
        Me.txtAds.TabIndex = 50
        Me.txtAds.Text = ""
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(41, 229)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(27, 13)
        Me.Label6.TabIndex = 49
        Me.Label6.Text = "ที่อยู่"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(41, 203)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(31, 13)
        Me.Label5.TabIndex = 48
        Me.Label5.Text = "เบอร์"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(41, 177)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(46, 13)
        Me.Label4.TabIndex = 47
        Me.Label4.Text = "นามสกุล"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(41, 151)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(20, 13)
        Me.Label3.TabIndex = 46
        Me.Label3.Text = "ชื่อ"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(41, 125)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(66, 13)
        Me.Label2.TabIndex = 45
        Me.Label2.Text = "เลขประจำตัว"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(41, 99)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(58, 13)
        Me.Label1.TabIndex = 44
        Me.Label1.Text = "รหัสสมาชิก"
        '
        'TxtTel
        '
        Me.TxtTel.Location = New System.Drawing.Point(130, 196)
        Me.TxtTel.Name = "TxtTel"
        Me.TxtTel.Size = New System.Drawing.Size(186, 20)
        Me.TxtTel.TabIndex = 43
        '
        'txtLname
        '
        Me.txtLname.Location = New System.Drawing.Point(130, 170)
        Me.txtLname.Name = "txtLname"
        Me.txtLname.Size = New System.Drawing.Size(186, 20)
        Me.txtLname.TabIndex = 42
        '
        'txtName
        '
        Me.txtName.Location = New System.Drawing.Point(130, 144)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(186, 20)
        Me.txtName.TabIndex = 41
        '
        'txtSNN
        '
        Me.txtSNN.Location = New System.Drawing.Point(130, 118)
        Me.txtSNN.Name = "txtSNN"
        Me.txtSNN.Size = New System.Drawing.Size(186, 20)
        Me.txtSNN.TabIndex = 40
        '
        'txtMemId
        '
        Me.txtMemId.Location = New System.Drawing.Point(130, 92)
        Me.txtMemId.Name = "txtMemId"
        Me.txtMemId.Size = New System.Drawing.Size(186, 20)
        Me.txtMemId.TabIndex = 39
        '
        'btnInsertMem
        '
        Me.btnInsertMem.Location = New System.Drawing.Point(61, 371)
        Me.btnInsertMem.Name = "btnInsertMem"
        Me.btnInsertMem.Size = New System.Drawing.Size(85, 23)
        Me.btnInsertMem.TabIndex = 38
        Me.btnInsertMem.Text = "สมัครสมาชิก"
        Me.btnInsertMem.UseVisualStyleBackColor = True
        '
        'txtInSearch
        '
        Me.txtInSearch.Location = New System.Drawing.Point(93, 26)
        Me.txtInSearch.Name = "txtInSearch"
        Me.txtInSearch.Size = New System.Drawing.Size(100, 20)
        Me.txtInSearch.TabIndex = 51
        '
        'btnSearchMem
        '
        Me.btnSearchMem.Location = New System.Drawing.Point(214, 24)
        Me.btnSearchMem.Name = "btnSearchMem"
        Me.btnSearchMem.Size = New System.Drawing.Size(75, 23)
        Me.btnSearchMem.TabIndex = 52
        Me.btnSearchMem.Text = "ค้นหา"
        Me.btnSearchMem.UseVisualStyleBackColor = True
        '
        'btnUpdateMem
        '
        Me.btnUpdateMem.Location = New System.Drawing.Point(194, 371)
        Me.btnUpdateMem.Name = "btnUpdateMem"
        Me.btnUpdateMem.Size = New System.Drawing.Size(85, 23)
        Me.btnUpdateMem.TabIndex = 53
        Me.btnUpdateMem.Text = "อัปเดตข้อมูล"
        Me.btnUpdateMem.UseVisualStyleBackColor = True
        '
        'memberform
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(369, 465)
        Me.Controls.Add(Me.btnUpdateMem)
        Me.Controls.Add(Me.btnSearchMem)
        Me.Controls.Add(Me.txtInSearch)
        Me.Controls.Add(Me.txtAds)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TxtTel)
        Me.Controls.Add(Me.txtLname)
        Me.Controls.Add(Me.txtName)
        Me.Controls.Add(Me.txtSNN)
        Me.Controls.Add(Me.txtMemId)
        Me.Controls.Add(Me.btnInsertMem)
        Me.Name = "memberform"
        Me.Text = "ข้อมูลสมาชิก"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtAds As RichTextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents TxtTel As TextBox
    Friend WithEvents txtLname As TextBox
    Friend WithEvents txtName As TextBox
    Friend WithEvents txtSNN As TextBox
    Friend WithEvents txtMemId As TextBox
    Friend WithEvents btnInsertMem As Button
    Friend WithEvents txtInSearch As TextBox
    Friend WithEvents btnSearchMem As Button
    Friend WithEvents btnUpdateMem As Button
End Class
