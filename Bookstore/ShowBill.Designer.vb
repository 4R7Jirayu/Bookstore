<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ShowBill
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
        Me.DateTimePickerS = New System.Windows.Forms.DateTimePicker()
        Me.DateTimePickerE = New System.Windows.Forms.DateTimePicker()
        Me.btnShow = New System.Windows.Forms.Button()
        Me.myCrytalReprotViewer = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Btn_impCtr = New System.Windows.Forms.Button()
        Me.TxtPa = New System.Windows.Forms.TextBox()
        Me.OpenFileDialog = New System.Windows.Forms.OpenFileDialog()
        Me.SuspendLayout()
        '
        'DateTimePickerS
        '
        Me.DateTimePickerS.Location = New System.Drawing.Point(65, 27)
        Me.DateTimePickerS.Name = "DateTimePickerS"
        Me.DateTimePickerS.Size = New System.Drawing.Size(124, 20)
        Me.DateTimePickerS.TabIndex = 0
        '
        'DateTimePickerE
        '
        Me.DateTimePickerE.Location = New System.Drawing.Point(270, 27)
        Me.DateTimePickerE.Name = "DateTimePickerE"
        Me.DateTimePickerE.Size = New System.Drawing.Size(143, 20)
        Me.DateTimePickerE.TabIndex = 1
        '
        'btnShow
        '
        Me.btnShow.Location = New System.Drawing.Point(451, 24)
        Me.btnShow.Name = "btnShow"
        Me.btnShow.Size = New System.Drawing.Size(75, 23)
        Me.btnShow.TabIndex = 2
        Me.btnShow.Text = "แสดง"
        Me.btnShow.UseVisualStyleBackColor = True
        '
        'myCrytalReprotViewer
        '
        Me.myCrytalReprotViewer.ActiveViewIndex = -1
        Me.myCrytalReprotViewer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.myCrytalReprotViewer.Cursor = System.Windows.Forms.Cursors.Default
        Me.myCrytalReprotViewer.Location = New System.Drawing.Point(12, 61)
        Me.myCrytalReprotViewer.Name = "myCrytalReprotViewer"
        Me.myCrytalReprotViewer.Size = New System.Drawing.Size(1027, 456)
        Me.myCrytalReprotViewer.TabIndex = 3
        Me.myCrytalReprotViewer.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(23, 27)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(25, 13)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "จาก"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(230, 33)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(19, 13)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "ถึง"
        '
        'Btn_impCtr
        '
        Me.Btn_impCtr.Location = New System.Drawing.Point(546, 23)
        Me.Btn_impCtr.Name = "Btn_impCtr"
        Me.Btn_impCtr.Size = New System.Drawing.Size(75, 23)
        Me.Btn_impCtr.TabIndex = 6
        Me.Btn_impCtr.Text = "Browser"
        Me.Btn_impCtr.UseVisualStyleBackColor = True
        '
        'TxtPa
        '
        Me.TxtPa.Location = New System.Drawing.Point(643, 24)
        Me.TxtPa.Name = "TxtPa"
        Me.TxtPa.Size = New System.Drawing.Size(248, 20)
        Me.TxtPa.TabIndex = 7
        '
        'OpenFileDialog
        '
        Me.OpenFileDialog.FileName = "OpenFileDialog"
        '
        'ShowBill
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1051, 529)
        Me.Controls.Add(Me.TxtPa)
        Me.Controls.Add(Me.Btn_impCtr)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.myCrytalReprotViewer)
        Me.Controls.Add(Me.btnShow)
        Me.Controls.Add(Me.DateTimePickerE)
        Me.Controls.Add(Me.DateTimePickerS)
        Me.Name = "ShowBill"
        Me.Text = "ShowBill"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DateTimePickerS As DateTimePicker
    Friend WithEvents DateTimePickerE As DateTimePicker
    Friend WithEvents btnShow As Button
    Friend WithEvents myCrytalReprotViewer As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Btn_impCtr As Button
    Friend WithEvents TxtPa As TextBox
    Friend WithEvents OpenFileDialog As OpenFileDialog
End Class
