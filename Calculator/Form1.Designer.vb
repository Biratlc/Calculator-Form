<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.lblName = New System.Windows.Forms.Label()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.btnOK = New System.Windows.Forms.Button()
        Me.txtMessage = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.txtAddVal1 = New System.Windows.Forms.TextBox()
        Me.btnAddValues = New System.Windows.Forms.Button()
        Me.txtAddVal2 = New System.Windows.Forms.TextBox()
        Me.lblAddEqual = New System.Windows.Forms.Label()
        Me.txtSumAnswer = New System.Windows.Forms.TextBox()
        Me.txtDivisionAnswer = New System.Windows.Forms.TextBox()
        Me.lblDivideEqual = New System.Windows.Forms.Label()
        Me.txtDivideVal2 = New System.Windows.Forms.TextBox()
        Me.btnDivideValues = New System.Windows.Forms.Button()
        Me.txtDivideVal1 = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'lblName
        '
        Me.lblName.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblName.Location = New System.Drawing.Point(64, 42)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(142, 52)
        Me.lblName.TabIndex = 0
        Me.lblName.Text = "Name"
        Me.lblName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtName
        '
        Me.txtName.Location = New System.Drawing.Point(241, 42)
        Me.txtName.Multiline = True
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(280, 41)
        Me.txtName.TabIndex = 1
        '
        'btnOK
        '
        Me.btnOK.Location = New System.Drawing.Point(69, 131)
        Me.btnOK.Name = "btnOK"
        Me.btnOK.Size = New System.Drawing.Size(163, 55)
        Me.btnOK.TabIndex = 2
        Me.btnOK.Text = "&OK"
        Me.btnOK.UseVisualStyleBackColor = True
        '
        'txtMessage
        '
        Me.txtMessage.Location = New System.Drawing.Point(370, 131)
        Me.txtMessage.Name = "txtMessage"
        Me.txtMessage.Size = New System.Drawing.Size(163, 55)
        Me.txtMessage.TabIndex = 3
        Me.txtMessage.Text = "&Message"
        Me.txtMessage.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(680, 131)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(163, 55)
        Me.btnExit.TabIndex = 4
        Me.btnExit.Text = "E&xit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'txtAddVal1
        '
        Me.txtAddVal1.Location = New System.Drawing.Point(69, 236)
        Me.txtAddVal1.Multiline = True
        Me.txtAddVal1.Name = "txtAddVal1"
        Me.txtAddVal1.Size = New System.Drawing.Size(163, 56)
        Me.txtAddVal1.TabIndex = 5
        '
        'btnAddValues
        '
        Me.btnAddValues.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.875!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAddValues.Location = New System.Drawing.Point(250, 236)
        Me.btnAddValues.Name = "btnAddValues"
        Me.btnAddValues.Size = New System.Drawing.Size(87, 56)
        Me.btnAddValues.TabIndex = 6
        Me.btnAddValues.Text = "+"
        Me.btnAddValues.UseVisualStyleBackColor = True
        '
        'txtAddVal2
        '
        Me.txtAddVal2.Location = New System.Drawing.Point(370, 236)
        Me.txtAddVal2.Multiline = True
        Me.txtAddVal2.Name = "txtAddVal2"
        Me.txtAddVal2.Size = New System.Drawing.Size(163, 56)
        Me.txtAddVal2.TabIndex = 7
        '
        'lblAddEqual
        '
        Me.lblAddEqual.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAddEqual.Location = New System.Drawing.Point(539, 239)
        Me.lblAddEqual.Name = "lblAddEqual"
        Me.lblAddEqual.Size = New System.Drawing.Size(142, 56)
        Me.lblAddEqual.TabIndex = 8
        Me.lblAddEqual.Text = "="
        Me.lblAddEqual.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtSumAnswer
        '
        Me.txtSumAnswer.Location = New System.Drawing.Point(680, 232)
        Me.txtSumAnswer.Multiline = True
        Me.txtSumAnswer.Name = "txtSumAnswer"
        Me.txtSumAnswer.Size = New System.Drawing.Size(163, 60)
        Me.txtSumAnswer.TabIndex = 9
        '
        'txtDivisionAnswer
        '
        Me.txtDivisionAnswer.Location = New System.Drawing.Point(680, 334)
        Me.txtDivisionAnswer.Multiline = True
        Me.txtDivisionAnswer.Name = "txtDivisionAnswer"
        Me.txtDivisionAnswer.Size = New System.Drawing.Size(163, 60)
        Me.txtDivisionAnswer.TabIndex = 14
        '
        'lblDivideEqual
        '
        Me.lblDivideEqual.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDivideEqual.Location = New System.Drawing.Point(539, 334)
        Me.lblDivideEqual.Name = "lblDivideEqual"
        Me.lblDivideEqual.Size = New System.Drawing.Size(142, 56)
        Me.lblDivideEqual.TabIndex = 13
        Me.lblDivideEqual.Text = "="
        Me.lblDivideEqual.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtDivideVal2
        '
        Me.txtDivideVal2.Location = New System.Drawing.Point(370, 334)
        Me.txtDivideVal2.Multiline = True
        Me.txtDivideVal2.Name = "txtDivideVal2"
        Me.txtDivideVal2.Size = New System.Drawing.Size(163, 56)
        Me.txtDivideVal2.TabIndex = 12
        '
        'btnDivideValues
        '
        Me.btnDivideValues.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.875!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDivideValues.Location = New System.Drawing.Point(250, 334)
        Me.btnDivideValues.Name = "btnDivideValues"
        Me.btnDivideValues.Size = New System.Drawing.Size(87, 56)
        Me.btnDivideValues.TabIndex = 11
        Me.btnDivideValues.Text = "/"
        Me.btnDivideValues.UseVisualStyleBackColor = True
        '
        'txtDivideVal1
        '
        Me.txtDivideVal1.Location = New System.Drawing.Point(69, 334)
        Me.txtDivideVal1.Multiline = True
        Me.txtDivideVal1.Name = "txtDivideVal1"
        Me.txtDivideVal1.Size = New System.Drawing.Size(163, 56)
        Me.txtDivideVal1.TabIndex = 10
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(936, 720)
        Me.Controls.Add(Me.txtDivisionAnswer)
        Me.Controls.Add(Me.lblDivideEqual)
        Me.Controls.Add(Me.txtDivideVal2)
        Me.Controls.Add(Me.btnDivideValues)
        Me.Controls.Add(Me.txtDivideVal1)
        Me.Controls.Add(Me.txtSumAnswer)
        Me.Controls.Add(Me.lblAddEqual)
        Me.Controls.Add(Me.txtAddVal2)
        Me.Controls.Add(Me.btnAddValues)
        Me.Controls.Add(Me.lblName)
        Me.Controls.Add(Me.txtAddVal1)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.txtMessage)
        Me.Controls.Add(Me.btnOK)
        Me.Controls.Add(Me.txtName)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblName As Label
    Friend WithEvents txtName As TextBox
    Friend WithEvents btnOK As Button
    Friend WithEvents txtMessage As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents txtAddVal1 As TextBox
    Friend WithEvents btnAddValues As Button
    Friend WithEvents txtAddVal2 As TextBox
    Friend WithEvents lblAddEqual As Label
    Friend WithEvents txtSumAnswer As TextBox
    Friend WithEvents txtDivisionAnswer As TextBox
    Friend WithEvents lblDivideEqual As Label
    Friend WithEvents txtDivideVal2 As TextBox
    Friend WithEvents btnDivideValues As Button
    Friend WithEvents txtDivideVal1 As TextBox
End Class
