<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class returnfrom
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtSkey = New System.Windows.Forms.TextBox()
        Me.btnS = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtReDate = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtBID = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtBname = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.txtFell = New System.Windows.Forms.TextBox()
        Me.lbtotalFee = New System.Windows.Forms.Label()
        Me.CheckBox = New System.Windows.Forms.CheckBox()
        Me.DataGridView = New System.Windows.Forms.DataGridView()
        Me.btnPFee = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.DataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(52, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(58, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "รหัสสมาชิก"
        '
        'txtSkey
        '
        Me.txtSkey.Location = New System.Drawing.Point(152, 19)
        Me.txtSkey.Name = "txtSkey"
        Me.txtSkey.Size = New System.Drawing.Size(100, 20)
        Me.txtSkey.TabIndex = 1
        '
        'btnS
        '
        Me.btnS.Location = New System.Drawing.Point(295, 15)
        Me.btnS.Name = "btnS"
        Me.btnS.Size = New System.Drawing.Size(113, 23)
        Me.btnS.TabIndex = 2
        Me.btnS.Text = "แสดงรายการยืม"
        Me.btnS.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnS)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.txtSkey)
        Me.GroupBox1.Location = New System.Drawing.Point(83, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(479, 51)
        Me.GroupBox1.TabIndex = 3
        Me.GroupBox1.TabStop = False
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.btnPFee)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.txtReDate)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.txtBID)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.txtBname)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.btnUpdate)
        Me.GroupBox2.Controls.Add(Me.txtFell)
        Me.GroupBox2.Controls.Add(Me.lbtotalFee)
        Me.GroupBox2.Controls.Add(Me.CheckBox)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 70)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(638, 92)
        Me.GroupBox2.TabIndex = 4
        Me.GroupBox2.TabStop = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(202, 25)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(56, 13)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "กำหนดคืน"
        '
        'txtReDate
        '
        Me.txtReDate.Location = New System.Drawing.Point(260, 22)
        Me.txtReDate.Name = "txtReDate"
        Me.txtReDate.Size = New System.Drawing.Size(100, 20)
        Me.txtReDate.TabIndex = 8
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(6, 55)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(58, 13)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "รหัสหนังสือ"
        '
        'txtBID
        '
        Me.txtBID.Location = New System.Drawing.Point(71, 52)
        Me.txtBID.Name = "txtBID"
        Me.txtBID.Size = New System.Drawing.Size(100, 20)
        Me.txtBID.TabIndex = 6
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(13, 25)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(52, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "ชื่อหนังสือ"
        '
        'txtBname
        '
        Me.txtBname.Location = New System.Drawing.Point(71, 22)
        Me.txtBname.Name = "txtBname"
        Me.txtBname.Size = New System.Drawing.Size(100, 20)
        Me.txtBname.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(380, 25)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(39, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "ค่าปรับ"
        '
        'btnUpdate
        '
        Me.btnUpdate.Location = New System.Drawing.Point(260, 55)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(63, 23)
        Me.btnUpdate.TabIndex = 3
        Me.btnUpdate.Text = "ยืนยัน"
        Me.btnUpdate.UseVisualStyleBackColor = True
        '
        'txtFell
        '
        Me.txtFell.Location = New System.Drawing.Point(425, 22)
        Me.txtFell.Name = "txtFell"
        Me.txtFell.Size = New System.Drawing.Size(53, 20)
        Me.txtFell.TabIndex = 2
        '
        'lbtotalFee
        '
        Me.lbtotalFee.AutoSize = True
        Me.lbtotalFee.Location = New System.Drawing.Point(492, 25)
        Me.lbtotalFee.Name = "lbtotalFee"
        Me.lbtotalFee.Size = New System.Drawing.Size(58, 13)
        Me.lbtotalFee.TabIndex = 1
        Me.lbtotalFee.Text = "รวมค่าปรับ"
        '
        'CheckBox
        '
        Me.CheckBox.AutoSize = True
        Me.CheckBox.Location = New System.Drawing.Point(201, 59)
        Me.CheckBox.Name = "CheckBox"
        Me.CheckBox.Size = New System.Drawing.Size(41, 17)
        Me.CheckBox.TabIndex = 0
        Me.CheckBox.Text = "คืน"
        Me.CheckBox.UseVisualStyleBackColor = True
        '
        'DataGridView
        '
        Me.DataGridView.AllowUserToAddRows = False
        Me.DataGridView.AllowUserToDeleteRows = False
        Me.DataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView.Location = New System.Drawing.Point(33, 180)
        Me.DataGridView.Name = "DataGridView"
        Me.DataGridView.ReadOnly = True
        Me.DataGridView.Size = New System.Drawing.Size(599, 262)
        Me.DataGridView.TabIndex = 5
        '
        'btnPFee
        '
        Me.btnPFee.Location = New System.Drawing.Point(412, 55)
        Me.btnPFee.Name = "btnPFee"
        Me.btnPFee.Size = New System.Drawing.Size(66, 23)
        Me.btnPFee.TabIndex = 10
        Me.btnPFee.Text = "จ่ายค่าปรับ"
        Me.btnPFee.UseVisualStyleBackColor = True
        '
        'returnfrom
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(664, 461)
        Me.Controls.Add(Me.DataGridView)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "returnfrom"
        Me.Text = "คืน"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.DataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents txtSkey As TextBox
    Friend WithEvents btnS As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents btnUpdate As Button
    Friend WithEvents txtFell As TextBox
    Friend WithEvents lbtotalFee As Label
    Friend WithEvents CheckBox As CheckBox
    Friend WithEvents DataGridView As DataGridView
    Friend WithEvents Label2 As Label
    Friend WithEvents txtBname As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtBID As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents txtReDate As TextBox
    Friend WithEvents btnPFee As Button
End Class
