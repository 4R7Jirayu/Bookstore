<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        Me.btn_infobook = New System.Windows.Forms.Button()
        Me.btn_borrow = New System.Windows.Forms.Button()
        Me.btn_member = New System.Windows.Forms.Button()
        Me.btn_return = New System.Windows.Forms.Button()
        Me.btnShowBill = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btn_infobook
        '
        Me.btn_infobook.Location = New System.Drawing.Point(41, 48)
        Me.btn_infobook.Name = "btn_infobook"
        Me.btn_infobook.Size = New System.Drawing.Size(75, 23)
        Me.btn_infobook.TabIndex = 0
        Me.btn_infobook.Text = "ข้อมูลหนังสือ"
        Me.btn_infobook.UseVisualStyleBackColor = True
        '
        'btn_borrow
        '
        Me.btn_borrow.Location = New System.Drawing.Point(145, 48)
        Me.btn_borrow.Name = "btn_borrow"
        Me.btn_borrow.Size = New System.Drawing.Size(75, 23)
        Me.btn_borrow.TabIndex = 1
        Me.btn_borrow.Text = "ยืม"
        Me.btn_borrow.UseVisualStyleBackColor = True
        '
        'btn_member
        '
        Me.btn_member.Location = New System.Drawing.Point(41, 86)
        Me.btn_member.Name = "btn_member"
        Me.btn_member.Size = New System.Drawing.Size(75, 23)
        Me.btn_member.TabIndex = 2
        Me.btn_member.Text = "ข้อมูลสมาชิก"
        Me.btn_member.UseVisualStyleBackColor = True
        '
        'btn_return
        '
        Me.btn_return.Location = New System.Drawing.Point(226, 48)
        Me.btn_return.Name = "btn_return"
        Me.btn_return.Size = New System.Drawing.Size(75, 23)
        Me.btn_return.TabIndex = 3
        Me.btn_return.Text = "คืน"
        Me.btn_return.UseVisualStyleBackColor = True
        '
        'btnShowBill
        '
        Me.btnShowBill.Location = New System.Drawing.Point(145, 86)
        Me.btnShowBill.Name = "btnShowBill"
        Me.btnShowBill.Size = New System.Drawing.Size(156, 23)
        Me.btnShowBill.TabIndex = 4
        Me.btnShowBill.Text = "แสดงรายรับ"
        Me.btnShowBill.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(375, 184)
        Me.Controls.Add(Me.btnShowBill)
        Me.Controls.Add(Me.btn_return)
        Me.Controls.Add(Me.btn_member)
        Me.Controls.Add(Me.btn_borrow)
        Me.Controls.Add(Me.btn_infobook)
        Me.Name = "Form1"
        Me.Text = "Main"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btn_infobook As Button
    Friend WithEvents btn_borrow As Button
    Friend WithEvents btn_member As Button
    Friend WithEvents btn_return As Button
    Friend WithEvents btnShowBill As Button
End Class
