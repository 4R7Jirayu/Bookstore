<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class typebookform
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
        Me.txtBTypeName = New System.Windows.Forms.TextBox()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.DataGridViewTypeBook = New System.Windows.Forms.DataGridView()
        Me.txtBTypeID = New System.Windows.Forms.TextBox()
        Me.btnDel = New System.Windows.Forms.Button()
        CType(Me.DataGridViewTypeBook, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtBTypeName
        '
        Me.txtBTypeName.Location = New System.Drawing.Point(100, 46)
        Me.txtBTypeName.Name = "txtBTypeName"
        Me.txtBTypeName.Size = New System.Drawing.Size(160, 20)
        Me.txtBTypeName.TabIndex = 1
        '
        'btnAdd
        '
        Me.btnAdd.Location = New System.Drawing.Point(287, 15)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(75, 23)
        Me.btnAdd.TabIndex = 2
        Me.btnAdd.Text = "เพิ่ม"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(63, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "รหัสประเภท"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 49)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(57, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "ชื่อประเภท"
        '
        'DataGridViewTypeBook
        '
        Me.DataGridViewTypeBook.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViewTypeBook.Location = New System.Drawing.Point(12, 85)
        Me.DataGridViewTypeBook.MultiSelect = False
        Me.DataGridViewTypeBook.Name = "DataGridViewTypeBook"
        Me.DataGridViewTypeBook.ReadOnly = True
        Me.DataGridViewTypeBook.Size = New System.Drawing.Size(350, 314)
        Me.DataGridViewTypeBook.TabIndex = 5
        '
        'txtBTypeID
        '
        Me.txtBTypeID.Location = New System.Drawing.Point(100, 15)
        Me.txtBTypeID.Name = "txtBTypeID"
        Me.txtBTypeID.Size = New System.Drawing.Size(160, 20)
        Me.txtBTypeID.TabIndex = 6
        '
        'btnDel
        '
        Me.btnDel.Location = New System.Drawing.Point(287, 46)
        Me.btnDel.Name = "btnDel"
        Me.btnDel.Size = New System.Drawing.Size(75, 23)
        Me.btnDel.TabIndex = 7
        Me.btnDel.Text = "ลบ"
        Me.btnDel.UseVisualStyleBackColor = True
        '
        'typebookform
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(374, 411)
        Me.Controls.Add(Me.btnDel)
        Me.Controls.Add(Me.txtBTypeID)
        Me.Controls.Add(Me.DataGridViewTypeBook)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.txtBTypeName)
        Me.Name = "typebookform"
        Me.Text = "typebookform"
        CType(Me.DataGridViewTypeBook, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtBTypeName As TextBox
    Friend WithEvents btnAdd As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents DataGridViewTypeBook As DataGridView
    Friend WithEvents txtBTypeID As TextBox
    Friend WithEvents btnDel As Button
End Class
