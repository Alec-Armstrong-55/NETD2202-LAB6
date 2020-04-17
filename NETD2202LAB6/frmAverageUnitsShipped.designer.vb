<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmAverageUnitsShipped
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
        Me.components = New System.ComponentModel.Container()
        Me.btnEnterUseable = New System.Windows.Forms.Button()
        Me.btnResetForm = New System.Windows.Forms.Button()
        Me.btnCloseForm = New System.Windows.Forms.Button()
        Me.txtGetUnits = New System.Windows.Forms.TextBox()
        Me.txtShowPreviousUnits1 = New System.Windows.Forms.TextBox()
        Me.lblUnits = New System.Windows.Forms.Label()
        Me.lblDay = New System.Windows.Forms.Label()
        Me.ttpAverageUnitsShippedForm = New System.Windows.Forms.ToolTip(Me.components)
        Me.lblShowAverage1 = New System.Windows.Forms.Label()
        Me.txtShowPreviousUnits2 = New System.Windows.Forms.TextBox()
        Me.lblShowAverage2 = New System.Windows.Forms.Label()
        Me.txtShowPreviousUnits3 = New System.Windows.Forms.TextBox()
        Me.lblShowAverage3 = New System.Windows.Forms.Label()
        Me.lblEmployee1 = New System.Windows.Forms.Label()
        Me.lblEmployee2 = New System.Windows.Forms.Label()
        Me.lblEmployee3 = New System.Windows.Forms.Label()
        Me.lblShowCompanyAverage = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnEnterUseable
        '
        Me.btnEnterUseable.BackColor = System.Drawing.Color.White
        Me.btnEnterUseable.Location = New System.Drawing.Point(191, 672)
        Me.btnEnterUseable.Name = "btnEnterUseable"
        Me.btnEnterUseable.Size = New System.Drawing.Size(153, 75)
        Me.btnEnterUseable.TabIndex = 12
        Me.btnEnterUseable.Text = "&Enter"
        Me.ttpAverageUnitsShippedForm.SetToolTip(Me.btnEnterUseable, "Assign the units entered to the day of the week.")
        Me.btnEnterUseable.UseVisualStyleBackColor = False
        '
        'btnResetForm
        '
        Me.btnResetForm.BackColor = System.Drawing.Color.White
        Me.btnResetForm.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnResetForm.Location = New System.Drawing.Point(632, 672)
        Me.btnResetForm.Name = "btnResetForm"
        Me.btnResetForm.Size = New System.Drawing.Size(153, 75)
        Me.btnResetForm.TabIndex = 13
        Me.btnResetForm.Text = "&Reset"
        Me.ttpAverageUnitsShippedForm.SetToolTip(Me.btnResetForm, "Reset the form to employee one, day one.")
        Me.btnResetForm.UseVisualStyleBackColor = False
        '
        'btnCloseForm
        '
        Me.btnCloseForm.BackColor = System.Drawing.Color.White
        Me.btnCloseForm.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnCloseForm.Location = New System.Drawing.Point(1060, 672)
        Me.btnCloseForm.Name = "btnCloseForm"
        Me.btnCloseForm.Size = New System.Drawing.Size(153, 75)
        Me.btnCloseForm.TabIndex = 14
        Me.btnCloseForm.Text = "&Close"
        Me.ttpAverageUnitsShippedForm.SetToolTip(Me.btnCloseForm, "Close the window.")
        Me.btnCloseForm.UseVisualStyleBackColor = False
        '
        'txtGetUnits
        '
        Me.txtGetUnits.BackColor = System.Drawing.Color.White
        Me.txtGetUnits.Location = New System.Drawing.Point(669, 37)
        Me.txtGetUnits.MaxLength = 4
        Me.txtGetUnits.Name = "txtGetUnits"
        Me.txtGetUnits.Size = New System.Drawing.Size(100, 38)
        Me.txtGetUnits.TabIndex = 1
        Me.ttpAverageUnitsShippedForm.SetToolTip(Me.txtGetUnits, "Enter the number of units shipped.")
        '
        'txtShowPreviousUnits1
        '
        Me.txtShowPreviousUnits1.BackColor = System.Drawing.Color.White
        Me.txtShowPreviousUnits1.Location = New System.Drawing.Point(101, 162)
        Me.txtShowPreviousUnits1.Multiline = True
        Me.txtShowPreviousUnits1.Name = "txtShowPreviousUnits1"
        Me.txtShowPreviousUnits1.ReadOnly = True
        Me.txtShowPreviousUnits1.Size = New System.Drawing.Size(360, 300)
        Me.txtShowPreviousUnits1.TabIndex = 4
        Me.txtShowPreviousUnits1.TabStop = False
        Me.ttpAverageUnitsShippedForm.SetToolTip(Me.txtShowPreviousUnits1, "Shows the units shipped on previous days for employee One.")
        '
        'lblUnits
        '
        Me.lblUnits.AutoSize = True
        Me.lblUnits.Location = New System.Drawing.Point(563, 43)
        Me.lblUnits.Name = "lblUnits"
        Me.lblUnits.Size = New System.Drawing.Size(88, 32)
        Me.lblUnits.TabIndex = 0
        Me.lblUnits.Text = "&Units:"
        Me.ttpAverageUnitsShippedForm.SetToolTip(Me.lblUnits, "Enter the number of units shipped.")
        '
        'lblDay
        '
        Me.lblDay.AutoSize = True
        Me.lblDay.Location = New System.Drawing.Point(799, 43)
        Me.lblDay.Name = "lblDay"
        Me.lblDay.Size = New System.Drawing.Size(0, 32)
        Me.lblDay.TabIndex = 2
        Me.ttpAverageUnitsShippedForm.SetToolTip(Me.lblDay, "Specifies the day of the week.")
        '
        'lblShowAverage1
        '
        Me.lblShowAverage1.BackColor = System.Drawing.Color.LightGray
        Me.lblShowAverage1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblShowAverage1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblShowAverage1.Location = New System.Drawing.Point(105, 485)
        Me.lblShowAverage1.Name = "lblShowAverage1"
        Me.lblShowAverage1.Size = New System.Drawing.Size(360, 60)
        Me.lblShowAverage1.TabIndex = 5
        Me.lblShowAverage1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.ttpAverageUnitsShippedForm.SetToolTip(Me.lblShowAverage1, "Displays the average units shipped over the seven days for employee One.")
        '
        'txtShowPreviousUnits2
        '
        Me.txtShowPreviousUnits2.BackColor = System.Drawing.Color.White
        Me.txtShowPreviousUnits2.Location = New System.Drawing.Point(532, 162)
        Me.txtShowPreviousUnits2.Multiline = True
        Me.txtShowPreviousUnits2.Name = "txtShowPreviousUnits2"
        Me.txtShowPreviousUnits2.ReadOnly = True
        Me.txtShowPreviousUnits2.Size = New System.Drawing.Size(360, 300)
        Me.txtShowPreviousUnits2.TabIndex = 7
        Me.txtShowPreviousUnits2.TabStop = False
        Me.ttpAverageUnitsShippedForm.SetToolTip(Me.txtShowPreviousUnits2, "Shows the units shipped on previous days for employee Two.")
        '
        'lblShowAverage2
        '
        Me.lblShowAverage2.BackColor = System.Drawing.Color.LightGray
        Me.lblShowAverage2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblShowAverage2.Location = New System.Drawing.Point(536, 485)
        Me.lblShowAverage2.Name = "lblShowAverage2"
        Me.lblShowAverage2.Size = New System.Drawing.Size(360, 60)
        Me.lblShowAverage2.TabIndex = 8
        Me.lblShowAverage2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.ttpAverageUnitsShippedForm.SetToolTip(Me.lblShowAverage2, "Displays the average units shipped over the seven days for employee Two.")
        '
        'txtShowPreviousUnits3
        '
        Me.txtShowPreviousUnits3.BackColor = System.Drawing.Color.White
        Me.txtShowPreviousUnits3.Location = New System.Drawing.Point(959, 162)
        Me.txtShowPreviousUnits3.Multiline = True
        Me.txtShowPreviousUnits3.Name = "txtShowPreviousUnits3"
        Me.txtShowPreviousUnits3.ReadOnly = True
        Me.txtShowPreviousUnits3.Size = New System.Drawing.Size(360, 300)
        Me.txtShowPreviousUnits3.TabIndex = 10
        Me.txtShowPreviousUnits3.TabStop = False
        Me.ttpAverageUnitsShippedForm.SetToolTip(Me.txtShowPreviousUnits3, "Shows the units shipped on previous days for employee Three.")
        '
        'lblShowAverage3
        '
        Me.lblShowAverage3.BackColor = System.Drawing.Color.LightGray
        Me.lblShowAverage3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblShowAverage3.Location = New System.Drawing.Point(963, 485)
        Me.lblShowAverage3.Name = "lblShowAverage3"
        Me.lblShowAverage3.Size = New System.Drawing.Size(360, 60)
        Me.lblShowAverage3.TabIndex = 11
        Me.lblShowAverage3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.ttpAverageUnitsShippedForm.SetToolTip(Me.lblShowAverage3, "Displays the average units shipped over the seven days for employee Three.")
        '
        'lblEmployee1
        '
        Me.lblEmployee1.AutoSize = True
        Me.lblEmployee1.BackColor = System.Drawing.Color.GhostWhite
        Me.lblEmployee1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.1!)
        Me.lblEmployee1.Location = New System.Drawing.Point(171, 115)
        Me.lblEmployee1.Name = "lblEmployee1"
        Me.lblEmployee1.Size = New System.Drawing.Size(211, 32)
        Me.lblEmployee1.TabIndex = 3
        Me.lblEmployee1.Text = "Employee One:"
        Me.ttpAverageUnitsShippedForm.SetToolTip(Me.lblEmployee1, "Shows the units shipped on previous days for employee One.")
        '
        'lblEmployee2
        '
        Me.lblEmployee2.AutoSize = True
        Me.lblEmployee2.Location = New System.Drawing.Point(616, 115)
        Me.lblEmployee2.Name = "lblEmployee2"
        Me.lblEmployee2.Size = New System.Drawing.Size(210, 32)
        Me.lblEmployee2.TabIndex = 6
        Me.lblEmployee2.Text = "Employee Two:"
        Me.ttpAverageUnitsShippedForm.SetToolTip(Me.lblEmployee2, "Shows the units shipped on previous days for employee Two.")
        '
        'lblEmployee3
        '
        Me.lblEmployee3.AutoSize = True
        Me.lblEmployee3.Location = New System.Drawing.Point(1035, 115)
        Me.lblEmployee3.Name = "lblEmployee3"
        Me.lblEmployee3.Size = New System.Drawing.Size(231, 32)
        Me.lblEmployee3.TabIndex = 9
        Me.lblEmployee3.Text = "Employee Three:"
        Me.ttpAverageUnitsShippedForm.SetToolTip(Me.lblEmployee3, "Shows the units shipped on previous days for employee Three.")
        '
        'lblShowCompanyAverage
        '
        Me.lblShowCompanyAverage.BackColor = System.Drawing.Color.LightGray
        Me.lblShowCompanyAverage.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblShowCompanyAverage.Location = New System.Drawing.Point(101, 585)
        Me.lblShowCompanyAverage.Name = "lblShowCompanyAverage"
        Me.lblShowCompanyAverage.Size = New System.Drawing.Size(1218, 60)
        Me.lblShowCompanyAverage.TabIndex = 15
        Me.lblShowCompanyAverage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'frmAverageUnitsShipped
        '
        Me.AcceptButton = Me.btnEnterUseable
        Me.AutoScaleDimensions = New System.Drawing.SizeF(16.0!, 31.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.GhostWhite
        Me.CancelButton = Me.btnResetForm
        Me.ClientSize = New System.Drawing.Size(1420, 772)
        Me.Controls.Add(Me.lblShowCompanyAverage)
        Me.Controls.Add(Me.lblEmployee3)
        Me.Controls.Add(Me.lblEmployee2)
        Me.Controls.Add(Me.lblEmployee1)
        Me.Controls.Add(Me.lblShowAverage3)
        Me.Controls.Add(Me.txtShowPreviousUnits3)
        Me.Controls.Add(Me.lblShowAverage2)
        Me.Controls.Add(Me.txtShowPreviousUnits2)
        Me.Controls.Add(Me.lblShowAverage1)
        Me.Controls.Add(Me.lblDay)
        Me.Controls.Add(Me.lblUnits)
        Me.Controls.Add(Me.txtShowPreviousUnits1)
        Me.Controls.Add(Me.txtGetUnits)
        Me.Controls.Add(Me.btnCloseForm)
        Me.Controls.Add(Me.btnResetForm)
        Me.Controls.Add(Me.btnEnterUseable)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(1452, 860)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(1452, 860)
        Me.Name = "frmAverageUnitsShipped"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Average Units Shipped"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnEnterUseable As Button
    Friend WithEvents btnResetForm As Button
    Friend WithEvents btnCloseForm As Button
    Friend WithEvents txtGetUnits As TextBox
    Friend WithEvents txtShowPreviousUnits1 As TextBox
    Friend WithEvents lblUnits As Label
    Friend WithEvents lblDay As Label
    Friend WithEvents ttpAverageUnitsShippedForm As ToolTip
    Friend WithEvents lblShowAverage1 As Label
    Friend WithEvents txtShowPreviousUnits2 As TextBox
    Friend WithEvents lblShowAverage2 As Label
    Friend WithEvents txtShowPreviousUnits3 As TextBox
    Friend WithEvents lblShowAverage3 As Label
    Friend WithEvents lblEmployee2 As Label
    Friend WithEvents lblEmployee3 As Label
    Friend WithEvents lblShowCompanyAverage As Label
    Public WithEvents lblEmployee1 As Label
End Class
