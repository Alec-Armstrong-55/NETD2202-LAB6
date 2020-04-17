<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCarInventory
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
        Me.components = New System.ComponentModel.Container()
        Me.cmbMake = New System.Windows.Forms.ComboBox()
        Me.txtModel = New System.Windows.Forms.TextBox()
        Me.nudYear = New System.Windows.Forms.NumericUpDown()
        Me.txtPrice = New System.Windows.Forms.TextBox()
        Me.chkNew = New System.Windows.Forms.CheckBox()
        Me.lblMake = New System.Windows.Forms.Label()
        Me.lblModel = New System.Windows.Forms.Label()
        Me.lblYear = New System.Windows.Forms.Label()
        Me.lblPrice = New System.Windows.Forms.Label()
        Me.lvwCarInventory = New System.Windows.Forms.ListView()
        Me.colNew = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colId = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colModel = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colMake = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colYear = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colPrice = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.lblOutput = New System.Windows.Forms.Label()
        Me.btnReset = New System.Windows.Forms.Button()
        Me.btnEnter = New System.Windows.Forms.Button()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.ttpCarInventoryHelp = New System.Windows.Forms.ToolTip(Me.components)
        CType(Me.nudYear, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cmbMake
        '
        Me.cmbMake.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbMake.FormattingEnabled = True
        Me.cmbMake.Items.AddRange(New Object() {"Acura", "Honda", "Ford", "Ram", "Chrystler", "Jeep", "Subaru", "Volkswagen"})
        Me.cmbMake.Location = New System.Drawing.Point(245, 12)
        Me.cmbMake.Name = "cmbMake"
        Me.cmbMake.Size = New System.Drawing.Size(275, 39)
        Me.cmbMake.TabIndex = 1
        Me.ttpCarInventoryHelp.SetToolTip(Me.cmbMake, "Choose the make of the car.")
        '
        'txtModel
        '
        Me.txtModel.Location = New System.Drawing.Point(245, 69)
        Me.txtModel.MaxLength = 15
        Me.txtModel.Multiline = True
        Me.txtModel.Name = "txtModel"
        Me.txtModel.Size = New System.Drawing.Size(275, 39)
        Me.txtModel.TabIndex = 3
        Me.ttpCarInventoryHelp.SetToolTip(Me.txtModel, "Enter the model of the car.")
        '
        'nudYear
        '
        Me.nudYear.Location = New System.Drawing.Point(245, 122)
        Me.nudYear.Maximum = New Decimal(New Integer() {2020, 0, 0, 0})
        Me.nudYear.Minimum = New Decimal(New Integer() {1920, 0, 0, 0})
        Me.nudYear.Name = "nudYear"
        Me.nudYear.ReadOnly = True
        Me.nudYear.Size = New System.Drawing.Size(275, 38)
        Me.nudYear.TabIndex = 5
        Me.nudYear.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ttpCarInventoryHelp.SetToolTip(Me.nudYear, "Choose the year of manufacturing.")
        Me.nudYear.Value = New Decimal(New Integer() {1920, 0, 0, 0})
        '
        'txtPrice
        '
        Me.txtPrice.Location = New System.Drawing.Point(245, 175)
        Me.txtPrice.MaxLength = 12
        Me.txtPrice.Multiline = True
        Me.txtPrice.Name = "txtPrice"
        Me.txtPrice.Size = New System.Drawing.Size(275, 39)
        Me.txtPrice.TabIndex = 7
        Me.txtPrice.Tag = ""
        Me.ttpCarInventoryHelp.SetToolTip(Me.txtPrice, "Enter the price of the car.")
        '
        'chkNew
        '
        Me.chkNew.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.chkNew.Location = New System.Drawing.Point(153, 227)
        Me.chkNew.Name = "chkNew"
        Me.chkNew.Size = New System.Drawing.Size(129, 36)
        Me.chkNew.TabIndex = 9
        Me.chkNew.Text = "&New"
        Me.ttpCarInventoryHelp.SetToolTip(Me.chkNew, "Choose if the car is new.")
        Me.chkNew.UseVisualStyleBackColor = True
        '
        'lblMake
        '
        Me.lblMake.Location = New System.Drawing.Point(129, 19)
        Me.lblMake.Name = "lblMake"
        Me.lblMake.Size = New System.Drawing.Size(110, 32)
        Me.lblMake.TabIndex = 0
        Me.lblMake.Text = "&Make"
        Me.lblMake.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ttpCarInventoryHelp.SetToolTip(Me.lblMake, "Choose the make of the car.")
        '
        'lblModel
        '
        Me.lblModel.Location = New System.Drawing.Point(135, 76)
        Me.lblModel.Name = "lblModel"
        Me.lblModel.Size = New System.Drawing.Size(104, 32)
        Me.lblModel.TabIndex = 2
        Me.lblModel.Text = "M&odel"
        Me.lblModel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ttpCarInventoryHelp.SetToolTip(Me.lblModel, "Enter the model of the car.")
        '
        'lblYear
        '
        Me.lblYear.Location = New System.Drawing.Point(123, 124)
        Me.lblYear.Name = "lblYear"
        Me.lblYear.Size = New System.Drawing.Size(110, 32)
        Me.lblYear.TabIndex = 4
        Me.lblYear.Text = "&Year"
        Me.lblYear.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ttpCarInventoryHelp.SetToolTip(Me.lblYear, "Choose the year of manufacturing.")
        '
        'lblPrice
        '
        Me.lblPrice.Location = New System.Drawing.Point(135, 178)
        Me.lblPrice.Name = "lblPrice"
        Me.lblPrice.Size = New System.Drawing.Size(98, 32)
        Me.lblPrice.TabIndex = 6
        Me.lblPrice.Text = "&Price"
        Me.lblPrice.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ttpCarInventoryHelp.SetToolTip(Me.lblPrice, "Enter the price of the car.")
        '
        'lvwCarInventory
        '
        Me.lvwCarInventory.CheckBoxes = True
        Me.lvwCarInventory.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.colNew, Me.colId, Me.colModel, Me.colMake, Me.colYear, Me.colPrice})
        Me.lvwCarInventory.FullRowSelect = True
        Me.lvwCarInventory.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable
        Me.lvwCarInventory.HideSelection = False
        Me.lvwCarInventory.Location = New System.Drawing.Point(12, 269)
        Me.lvwCarInventory.MultiSelect = False
        Me.lvwCarInventory.Name = "lvwCarInventory"
        Me.lvwCarInventory.Size = New System.Drawing.Size(977, 451)
        Me.lvwCarInventory.TabIndex = 10
        Me.ttpCarInventoryHelp.SetToolTip(Me.lvwCarInventory, "Displays inventory.")
        Me.lvwCarInventory.UseCompatibleStateImageBehavior = False
        Me.lvwCarInventory.View = System.Windows.Forms.View.Details
        '
        'colNew
        '
        Me.colNew.Tag = ""
        Me.colNew.Text = "New"
        Me.colNew.Width = 35
        '
        'colId
        '
        Me.colId.Text = "ID"
        Me.colId.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.colId.Width = 40
        '
        'colModel
        '
        Me.colModel.Text = "Model"
        Me.colModel.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.colModel.Width = 70
        '
        'colMake
        '
        Me.colMake.Text = "Make"
        Me.colMake.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.colMake.Width = 70
        '
        'colYear
        '
        Me.colYear.Text = "Year"
        Me.colYear.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.colYear.Width = 70
        '
        'colPrice
        '
        Me.colPrice.Text = "Price"
        Me.colPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.colPrice.Width = 70
        '
        'lblOutput
        '
        Me.lblOutput.BackColor = System.Drawing.Color.LightGray
        Me.lblOutput.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblOutput.Location = New System.Drawing.Point(17, 734)
        Me.lblOutput.Name = "lblOutput"
        Me.lblOutput.Size = New System.Drawing.Size(977, 180)
        Me.lblOutput.TabIndex = 11
        Me.ttpCarInventoryHelp.SetToolTip(Me.lblOutput, "Application feedback.")
        '
        'btnReset
        '
        Me.btnReset.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnReset.Location = New System.Drawing.Point(640, 938)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(150, 60)
        Me.btnReset.TabIndex = 13
        Me.btnReset.Text = "&Reset"
        Me.ttpCarInventoryHelp.SetToolTip(Me.btnReset, "Reset input fields.")
        Me.btnReset.UseVisualStyleBackColor = True
        '
        'btnEnter
        '
        Me.btnEnter.Location = New System.Drawing.Point(441, 938)
        Me.btnEnter.Name = "btnEnter"
        Me.btnEnter.Size = New System.Drawing.Size(150, 60)
        Me.btnEnter.TabIndex = 12
        Me.btnEnter.Text = "&Enter"
        Me.ttpCarInventoryHelp.SetToolTip(Me.btnEnter, "Enter into car inventory.")
        Me.btnEnter.UseVisualStyleBackColor = True
        '
        'btnClose
        '
        Me.btnClose.Location = New System.Drawing.Point(839, 938)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(150, 60)
        Me.btnClose.TabIndex = 14
        Me.btnClose.Text = "&Close"
        Me.ttpCarInventoryHelp.SetToolTip(Me.btnClose, "Close the window.")
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'frmCarInventory
        '
        Me.AcceptButton = Me.btnEnter
        Me.AutoScaleDimensions = New System.Drawing.SizeF(16.0!, 31.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.CancelButton = Me.btnReset
        Me.ClientSize = New System.Drawing.Size(1008, 1022)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.btnEnter)
        Me.Controls.Add(Me.btnReset)
        Me.Controls.Add(Me.lblOutput)
        Me.Controls.Add(Me.lvwCarInventory)
        Me.Controls.Add(Me.lblPrice)
        Me.Controls.Add(Me.lblYear)
        Me.Controls.Add(Me.lblModel)
        Me.Controls.Add(Me.lblMake)
        Me.Controls.Add(Me.chkNew)
        Me.Controls.Add(Me.txtPrice)
        Me.Controls.Add(Me.nudYear)
        Me.Controls.Add(Me.txtModel)
        Me.Controls.Add(Me.cmbMake)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(1040, 1110)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(1040, 1110)
        Me.Name = "frmCarInventory"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Car Inventory"
        Me.ttpCarInventoryHelp.SetToolTip(Me, "Car Inventory Application.")
        CType(Me.nudYear, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents cmbMake As ComboBox
    Friend WithEvents txtModel As TextBox
    Friend WithEvents txtPrice As TextBox
    Friend WithEvents chkNew As CheckBox
    Friend WithEvents lblMake As Label
    Friend WithEvents lblModel As Label
    Friend WithEvents lblYear As Label
    Friend WithEvents lblPrice As Label
    Friend WithEvents lvwCarInventory As ListView
    Friend WithEvents lblOutput As Label
    Friend WithEvents btnReset As Button
    Friend WithEvents btnEnter As Button
    Friend WithEvents btnClose As Button
    Friend WithEvents nudYear As NumericUpDown
    Friend WithEvents colNew As ColumnHeader
    Friend WithEvents colId As ColumnHeader
    Friend WithEvents colModel As ColumnHeader
    Friend WithEvents colMake As ColumnHeader
    Friend WithEvents colYear As ColumnHeader
    Friend WithEvents colPrice As ColumnHeader
    Friend WithEvents ttpCarInventoryHelp As ToolTip
End Class
