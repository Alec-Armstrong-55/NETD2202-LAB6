<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmArmstrongEditor
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
        Me.txtEditor = New System.Windows.Forms.TextBox()
        Me.opdOpen = New System.Windows.Forms.OpenFileDialog()
        Me.sfdSaveAs = New System.Windows.Forms.SaveFileDialog()
        Me.ttpMain = New System.Windows.Forms.ToolTip(Me.components)
        Me.SuspendLayout()
        '
        'txtEditor
        '
        Me.txtEditor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtEditor.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtEditor.Location = New System.Drawing.Point(0, 0)
        Me.txtEditor.Multiline = True
        Me.txtEditor.Name = "txtEditor"
        Me.txtEditor.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.txtEditor.Size = New System.Drawing.Size(2040, 1015)
        Me.txtEditor.TabIndex = 1
        Me.txtEditor.TabStop = False
        Me.ttpMain.SetToolTip(Me.txtEditor, "Editor.")
        '
        'frmArmstrongEditor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(16.0!, 31.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(2040, 1015)
        Me.Controls.Add(Me.txtEditor)
        Me.Name = "frmArmstrongEditor"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Armstrong Editor"
        Me.ttpMain.SetToolTip(Me, "Text editor application.")
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtEditor As TextBox
    Friend WithEvents opdOpen As OpenFileDialog
    Friend WithEvents sfdSaveAs As SaveFileDialog
    Friend WithEvents ttpMain As ToolTip
End Class
