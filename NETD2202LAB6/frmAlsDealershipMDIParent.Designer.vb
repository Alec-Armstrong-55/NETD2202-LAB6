<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAlsDealershipMDIParent
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
        Me.mnuMenu = New System.Windows.Forms.MenuStrip()
        Me.mnuFile = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuFileNew = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuFileOpen = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuFileSave = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuFileSaveAs = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuFileClose = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuFileExit = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuEdit = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuEditCopy = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuEditCut = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuEditPaste = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuWindows = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuWindowsCascade = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuWindowsTileVertically = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuWindowsTileHorizontally = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuWindowsSeperator = New System.Windows.Forms.ToolStripSeparator()
        Me.mnuWindowsOpenTextEditor = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuWindowsOpenCarList = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuWindowsOpenAverageUnitsShipped = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuHelp = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuHelpAbout = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsToolStrip = New System.Windows.Forms.ToolStrip()
        Me.tsFileNew = New System.Windows.Forms.ToolStripButton()
        Me.tsFileOpen = New System.Windows.Forms.ToolStripButton()
        Me.tsFileSave = New System.Windows.Forms.ToolStripButton()
        Me.tsWindowsOpenCarInventory = New System.Windows.Forms.ToolStripButton()
        Me.tsWindowsOpenAverageUnitsShipped = New System.Windows.Forms.ToolStripButton()
        Me.ttpToolTips = New System.Windows.Forms.ToolTip(Me.components)
        Me.mnuMenu.SuspendLayout()
        Me.tsToolStrip.SuspendLayout()
        Me.SuspendLayout()
        '
        'mnuMenu
        '
        Me.mnuMenu.GripMargin = New System.Windows.Forms.Padding(2, 2, 0, 2)
        Me.mnuMenu.ImageScalingSize = New System.Drawing.Size(15, 15)
        Me.mnuMenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuFile, Me.mnuEdit, Me.mnuWindows, Me.mnuHelp})
        Me.mnuMenu.Location = New System.Drawing.Point(0, 0)
        Me.mnuMenu.Name = "mnuMenu"
        Me.mnuMenu.Size = New System.Drawing.Size(2179, 49)
        Me.mnuMenu.TabIndex = 1
        Me.mnuMenu.Text = "MenuStrip1"
        '
        'mnuFile
        '
        Me.mnuFile.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuFileNew, Me.mnuFileOpen, Me.mnuFileSave, Me.mnuFileSaveAs, Me.mnuFileClose, Me.mnuFileExit})
        Me.mnuFile.Name = "mnuFile"
        Me.mnuFile.Size = New System.Drawing.Size(87, 45)
        Me.mnuFile.Text = "&File"
        Me.mnuFile.ToolTipText = "File manipulation."
        '
        'mnuFileNew
        '
        Me.mnuFileNew.Image = Global.NETD2202LAB6.My.Resources.Resources.NewFile
        Me.mnuFileNew.Name = "mnuFileNew"
        Me.mnuFileNew.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.N), System.Windows.Forms.Keys)
        Me.mnuFileNew.Size = New System.Drawing.Size(366, 54)
        Me.mnuFileNew.Text = "&New"
        Me.mnuFileNew.ToolTipText = "Create a new blank file."
        '
        'mnuFileOpen
        '
        Me.mnuFileOpen.Image = Global.NETD2202LAB6.My.Resources.Resources.OpenFile
        Me.mnuFileOpen.Name = "mnuFileOpen"
        Me.mnuFileOpen.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.O), System.Windows.Forms.Keys)
        Me.mnuFileOpen.Size = New System.Drawing.Size(366, 54)
        Me.mnuFileOpen.Text = "&Open"
        Me.mnuFileOpen.ToolTipText = "Open an existing file."
        '
        'mnuFileSave
        '
        Me.mnuFileSave.Image = Global.NETD2202LAB6.My.Resources.Resources.SaveFile
        Me.mnuFileSave.Name = "mnuFileSave"
        Me.mnuFileSave.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.S), System.Windows.Forms.Keys)
        Me.mnuFileSave.Size = New System.Drawing.Size(366, 54)
        Me.mnuFileSave.Text = "&Save"
        Me.mnuFileSave.ToolTipText = "Save the current file."
        '
        'mnuFileSaveAs
        '
        Me.mnuFileSaveAs.Name = "mnuFileSaveAs"
        Me.mnuFileSaveAs.Size = New System.Drawing.Size(366, 54)
        Me.mnuFileSaveAs.Text = "S&ave As"
        Me.mnuFileSaveAs.ToolTipText = "Save the current file as."
        '
        'mnuFileClose
        '
        Me.mnuFileClose.Name = "mnuFileClose"
        Me.mnuFileClose.Size = New System.Drawing.Size(366, 54)
        Me.mnuFileClose.Text = "&Close"
        Me.mnuFileClose.ToolTipText = "Close the current window."
        '
        'mnuFileExit
        '
        Me.mnuFileExit.Name = "mnuFileExit"
        Me.mnuFileExit.Size = New System.Drawing.Size(366, 54)
        Me.mnuFileExit.Text = "E&xit"
        Me.mnuFileExit.ToolTipText = "Exit the program."
        '
        'mnuEdit
        '
        Me.mnuEdit.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuEditCopy, Me.mnuEditCut, Me.mnuEditPaste})
        Me.mnuEdit.Name = "mnuEdit"
        Me.mnuEdit.Size = New System.Drawing.Size(92, 45)
        Me.mnuEdit.Text = "&Edit"
        Me.mnuEdit.ToolTipText = "Edit the text."
        '
        'mnuEditCopy
        '
        Me.mnuEditCopy.Image = Global.NETD2202LAB6.My.Resources.Resources.Copy
        Me.mnuEditCopy.Name = "mnuEditCopy"
        Me.mnuEditCopy.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.C), System.Windows.Forms.Keys)
        Me.mnuEditCopy.Size = New System.Drawing.Size(358, 54)
        Me.mnuEditCopy.Text = "&Copy"
        Me.mnuEditCopy.ToolTipText = "Copy the selected text."
        '
        'mnuEditCut
        '
        Me.mnuEditCut.Image = Global.NETD2202LAB6.My.Resources.Resources.Cut
        Me.mnuEditCut.Name = "mnuEditCut"
        Me.mnuEditCut.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.X), System.Windows.Forms.Keys)
        Me.mnuEditCut.Size = New System.Drawing.Size(358, 54)
        Me.mnuEditCut.Text = "Cu&t"
        Me.mnuEditCut.ToolTipText = "Cut the slected text."
        '
        'mnuEditPaste
        '
        Me.mnuEditPaste.Image = Global.NETD2202LAB6.My.Resources.Resources.Paste
        Me.mnuEditPaste.Name = "mnuEditPaste"
        Me.mnuEditPaste.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.V), System.Windows.Forms.Keys)
        Me.mnuEditPaste.Size = New System.Drawing.Size(358, 54)
        Me.mnuEditPaste.Text = "&Paste"
        Me.mnuEditPaste.ToolTipText = "Paste text in the clipboard."
        '
        'mnuWindows
        '
        Me.mnuWindows.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuWindowsCascade, Me.mnuWindowsTileVertically, Me.mnuWindowsTileHorizontally, Me.mnuWindowsSeperator, Me.mnuWindowsOpenTextEditor, Me.mnuWindowsOpenCarList, Me.mnuWindowsOpenAverageUnitsShipped})
        Me.mnuWindows.Name = "mnuWindows"
        Me.mnuWindows.Size = New System.Drawing.Size(165, 45)
        Me.mnuWindows.Text = "&Windows"
        Me.mnuWindows.ToolTipText = "Window manipulaton."
        '
        'mnuWindowsCascade
        '
        Me.mnuWindowsCascade.Name = "mnuWindowsCascade"
        Me.mnuWindowsCascade.Size = New System.Drawing.Size(567, 54)
        Me.mnuWindowsCascade.Text = "&Cascade"
        Me.mnuWindowsCascade.ToolTipText = "Cascade all windows that are open."
        '
        'mnuWindowsTileVertically
        '
        Me.mnuWindowsTileVertically.Name = "mnuWindowsTileVertically"
        Me.mnuWindowsTileVertically.Size = New System.Drawing.Size(567, 54)
        Me.mnuWindowsTileVertically.Text = "Tile &Vertically"
        Me.mnuWindowsTileVertically.ToolTipText = "Tile the open windows vertically."
        '
        'mnuWindowsTileHorizontally
        '
        Me.mnuWindowsTileHorizontally.Name = "mnuWindowsTileHorizontally"
        Me.mnuWindowsTileHorizontally.Size = New System.Drawing.Size(567, 54)
        Me.mnuWindowsTileHorizontally.Text = "Tile &Horizontally"
        Me.mnuWindowsTileHorizontally.ToolTipText = "Tile the open windows horizontally."
        '
        'mnuWindowsSeperator
        '
        Me.mnuWindowsSeperator.Name = "mnuWindowsSeperator"
        Me.mnuWindowsSeperator.Size = New System.Drawing.Size(564, 6)
        '
        'mnuWindowsOpenTextEditor
        '
        Me.mnuWindowsOpenTextEditor.Image = Global.NETD2202LAB6.My.Resources.Resources.TextEditor
        Me.mnuWindowsOpenTextEditor.Name = "mnuWindowsOpenTextEditor"
        Me.mnuWindowsOpenTextEditor.Size = New System.Drawing.Size(567, 54)
        Me.mnuWindowsOpenTextEditor.Text = "Open New &Text Editor"
        Me.mnuWindowsOpenTextEditor.ToolTipText = "Open a new Text Editor window."
        '
        'mnuWindowsOpenCarList
        '
        Me.mnuWindowsOpenCarList.Image = Global.NETD2202LAB6.My.Resources.Resources.CarInventory
        Me.mnuWindowsOpenCarList.Name = "mnuWindowsOpenCarList"
        Me.mnuWindowsOpenCarList.Size = New System.Drawing.Size(567, 54)
        Me.mnuWindowsOpenCarList.Text = "Open Car &List"
        Me.mnuWindowsOpenCarList.ToolTipText = "Open the Car Inventoty List."
        '
        'mnuWindowsOpenAverageUnitsShipped
        '
        Me.mnuWindowsOpenAverageUnitsShipped.Image = Global.NETD2202LAB6.My.Resources.Resources.AverageUnitsShipped
        Me.mnuWindowsOpenAverageUnitsShipped.Name = "mnuWindowsOpenAverageUnitsShipped"
        Me.mnuWindowsOpenAverageUnitsShipped.Size = New System.Drawing.Size(567, 54)
        Me.mnuWindowsOpenAverageUnitsShipped.Text = "Open &Average Units Shipped"
        Me.mnuWindowsOpenAverageUnitsShipped.ToolTipText = "Open the Average Units Shipped."
        '
        'mnuHelp
        '
        Me.mnuHelp.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuHelpAbout})
        Me.mnuHelp.Name = "mnuHelp"
        Me.mnuHelp.Size = New System.Drawing.Size(104, 45)
        Me.mnuHelp.Text = "&Help"
        Me.mnuHelp.ToolTipText = "Help Options."
        '
        'mnuHelpAbout
        '
        Me.mnuHelpAbout.Name = "mnuHelpAbout"
        Me.mnuHelpAbout.ShortcutKeys = System.Windows.Forms.Keys.F1
        Me.mnuHelpAbout.Size = New System.Drawing.Size(315, 54)
        Me.mnuHelpAbout.Text = "&About"
        Me.mnuHelpAbout.ToolTipText = "About the application."
        '
        'tsToolStrip
        '
        Me.tsToolStrip.ImageScalingSize = New System.Drawing.Size(15, 15)
        Me.tsToolStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsFileNew, Me.tsFileOpen, Me.tsFileSave, Me.tsWindowsOpenCarInventory, Me.tsWindowsOpenAverageUnitsShipped})
        Me.tsToolStrip.Location = New System.Drawing.Point(0, 49)
        Me.tsToolStrip.Name = "tsToolStrip"
        Me.tsToolStrip.Size = New System.Drawing.Size(2179, 26)
        Me.tsToolStrip.TabIndex = 3
        Me.tsToolStrip.Text = "ToolStrip1"
        '
        'tsFileNew
        '
        Me.tsFileNew.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsFileNew.Image = Global.NETD2202LAB6.My.Resources.Resources.NewFile
        Me.tsFileNew.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsFileNew.Name = "tsFileNew"
        Me.tsFileNew.Size = New System.Drawing.Size(58, 19)
        Me.tsFileNew.ToolTipText = "Create a new blank file."
        '
        'tsFileOpen
        '
        Me.tsFileOpen.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsFileOpen.Image = Global.NETD2202LAB6.My.Resources.Resources.OpenFile
        Me.tsFileOpen.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsFileOpen.Name = "tsFileOpen"
        Me.tsFileOpen.Size = New System.Drawing.Size(58, 19)
        Me.tsFileOpen.ToolTipText = "Open an existing file."
        '
        'tsFileSave
        '
        Me.tsFileSave.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsFileSave.Image = Global.NETD2202LAB6.My.Resources.Resources.SaveFile
        Me.tsFileSave.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsFileSave.Name = "tsFileSave"
        Me.tsFileSave.Size = New System.Drawing.Size(58, 19)
        Me.tsFileSave.ToolTipText = "Save the current file."
        '
        'tsWindowsOpenCarInventory
        '
        Me.tsWindowsOpenCarInventory.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsWindowsOpenCarInventory.Image = Global.NETD2202LAB6.My.Resources.Resources.CarInventory
        Me.tsWindowsOpenCarInventory.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsWindowsOpenCarInventory.Name = "tsWindowsOpenCarInventory"
        Me.tsWindowsOpenCarInventory.Size = New System.Drawing.Size(58, 19)
        Me.tsWindowsOpenCarInventory.ToolTipText = "Open the Car Inventoty List."
        '
        'tsWindowsOpenAverageUnitsShipped
        '
        Me.tsWindowsOpenAverageUnitsShipped.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsWindowsOpenAverageUnitsShipped.Image = Global.NETD2202LAB6.My.Resources.Resources.AverageUnitsShipped
        Me.tsWindowsOpenAverageUnitsShipped.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsWindowsOpenAverageUnitsShipped.Name = "tsWindowsOpenAverageUnitsShipped"
        Me.tsWindowsOpenAverageUnitsShipped.Size = New System.Drawing.Size(58, 19)
        Me.tsWindowsOpenAverageUnitsShipped.ToolTipText = "Open the Average Units Shipped."
        '
        'frmAlsDealershipMDIParent
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(16.0!, 31.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(2179, 1001)
        Me.Controls.Add(Me.tsToolStrip)
        Me.Controls.Add(Me.mnuMenu)
        Me.IsMdiContainer = True
        Me.Name = "frmAlsDealershipMDIParent"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Als Dealership"
        Me.ttpToolTips.SetToolTip(Me, "MDI Parent form.")
        Me.mnuMenu.ResumeLayout(False)
        Me.mnuMenu.PerformLayout()
        Me.tsToolStrip.ResumeLayout(False)
        Me.tsToolStrip.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents mnuMenu As MenuStrip
    Friend WithEvents mnuFile As ToolStripMenuItem
    Friend WithEvents mnuFileNew As ToolStripMenuItem
    Friend WithEvents mnuFileOpen As ToolStripMenuItem
    Friend WithEvents mnuFileSave As ToolStripMenuItem
    Friend WithEvents mnuFileSaveAs As ToolStripMenuItem
    Friend WithEvents mnuFileExit As ToolStripMenuItem
    Friend WithEvents mnuEdit As ToolStripMenuItem
    Friend WithEvents mnuEditCopy As ToolStripMenuItem
    Friend WithEvents mnuEditCut As ToolStripMenuItem
    Friend WithEvents mnuEditPaste As ToolStripMenuItem
    Friend WithEvents mnuWindows As ToolStripMenuItem
    Friend WithEvents mnuHelp As ToolStripMenuItem
    Friend WithEvents mnuHelpAbout As ToolStripMenuItem
    Friend WithEvents mnuWindowsCascade As ToolStripMenuItem
    Friend WithEvents mnuWindowsTileVertically As ToolStripMenuItem
    Friend WithEvents mnuWindowsTileHorizontally As ToolStripMenuItem
    Friend WithEvents mnuWindowsOpenTextEditor As ToolStripMenuItem
    Friend WithEvents mnuWindowsOpenCarList As ToolStripMenuItem
    Friend WithEvents mnuFileClose As ToolStripMenuItem
    Friend WithEvents mnuWindowsSeperator As ToolStripSeparator
    Friend WithEvents mnuWindowsOpenAverageUnitsShipped As ToolStripMenuItem
    Friend WithEvents tsToolStrip As ToolStrip
    Friend WithEvents tsFileNew As ToolStripButton
    Friend WithEvents tsFileOpen As ToolStripButton
    Friend WithEvents tsFileSave As ToolStripButton
    Friend WithEvents tsWindowsOpenCarInventory As ToolStripButton
    Friend WithEvents tsWindowsOpenAverageUnitsShipped As ToolStripButton
    Friend WithEvents ttpToolTips As ToolTip
End Class
