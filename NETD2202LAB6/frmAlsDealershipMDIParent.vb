' Author: Alec Armstrong 100617553
' Date: April 16, 2020
' Description:
'   This program is a MDI Parent form that contains a text editor, a car inventory form, and a average units shipped form.
'   The text editor has full file manipulation capabilities, including new, open, save, cut, copy, and paste.
'   The car inventory and average units shipped forms are fully functioning, and may only have one open at a time. They also have copy
'   and paste functionality in certain text boxes. 
'   The MDI Parent form contains a menu bar that is the path to all functionality and a tool strip for more commonly used functions of the form.

Option Strict On

Public Class frmAlsDealershipMDIParent

#Region "File manipulation"

    ' Open a text file within the current form. using two click options
    Private Sub mnuFileOpen_Click(sender As Object, e As EventArgs) Handles mnuFileOpen.Click, tsFileOpen.Click

        ' If the current form is a open text editor.
        If TypeOf (ActiveMdiChild) Is frmArmstrongEditor Then

            ' Call upon the editors file open.
            CType(ActiveMdiChild, frmArmstrongEditor).FileOpen()

            ' If the current form is car inventory or average units shipped.
        ElseIf TypeOf (ActiveMdiChild) Is frmCarInventory Or TypeOf (ActiveMdiChild) Is frmAverageUnitsShipped Then

            ' Display error.
            MessageBox.Show("You cannot open from this form.")

        Else

            ' If there is nothing open in the MDI parent open a text editor and call upon the open file.
            OpenTextEditor(sender, e)
            CType(ActiveMdiChild, frmArmstrongEditor).FileOpen()

        End If

    End Sub

    ' Save the current text file using two click options.
    Private Sub mnuFileSave_Click(sender As Object, e As EventArgs) Handles mnuFileSave.Click, tsFileSave.Click

        ' if the current form is an open text editor.
        If TypeOf (ActiveMdiChild) Is frmArmstrongEditor Then

            ' Call upon the file save of the text editor.
            CType(ActiveMdiChild, frmArmstrongEditor).FileSave()

        Else

            ' if the current form is not an open text editor.
            ' Show error.
            MessageBox.Show("You cannot save this form.")

        End If

    End Sub

    ' Save as the current text file. 
    Private Sub mnuFileSaveAs_Click(sender As Object, e As EventArgs) Handles mnuFileSaveAs.Click

        ' if the current form is an open text editor.
        If TypeOf (ActiveMdiChild) Is frmArmstrongEditor Then

            ' Call upon the file save as of the text editor.
            CType(ActiveMdiChild, frmArmstrongEditor).FileSaveAs()

        Else

            ' if the current form is not an open text editor.
            ' Show error.
            MessageBox.Show("You cannot save this form.")

        End If

    End Sub

    ' Close the current form.
    Private Sub mnuFileClose_Click(sender As Object, e As EventArgs) Handles mnuFileClose.Click

        ' If the current form is a text editor.
        If TypeOf (ActiveMdiChild) Is frmArmstrongEditor Then

            ' Call the file close.
            CType(ActiveMdiChild, frmArmstrongEditor).FileClose()

            ' if the current form is car inventory.
        ElseIf TypeOf (ActiveMdiChild) Is frmCarInventory Then

            ' call the close.
            CType(ActiveMdiChild, frmCarInventory).MeClose()

            ' if the current form is average units shipped.
        ElseIf TypeOf (ActiveMdiChild) Is frmAverageUnitsShipped Then

            ' call the close.
            CType(ActiveMdiChild, frmAverageUnitsShipped).btnCloseForm_Click(sender, e)

        Else

            ' if there is not an open form in the MDI parent close the MDI parent.
            Me.Close()

        End If

    End Sub

    ' Exit the program.
    Private Sub mnuFileExit_Click(sender As Object, e As EventArgs) Handles mnuFileExit.Click

        Me.Close()

    End Sub

#End Region

#Region "Edit functionality"

    ' Copy functionality for the windows.
    Private Sub mnuEditCopy_Click(sender As Object, e As EventArgs) Handles mnuEditCopy.Click

        ' if the user is within a text editor.
        If TypeOf (ActiveMdiChild) Is frmArmstrongEditor Then

            ' call the copy. 
            CType(ActiveMdiChild, frmArmstrongEditor).EditCopy()

            ' if the user is within the car inventory.
        ElseIf TypeOf (ActiveMdiChild) Is frmCarInventory Then

            ' call the copy.
            CType(ActiveMdiChild, frmCarInventory).EditCopy()

            ' if the user is within the average units shipped.
        ElseIf TypeOf (ActiveMdiChild) Is frmAverageUnitsShipped Then

            ' call the copy.
            CType(ActiveMdiChild, frmAverageUnitsShipped).EditCopy()

        Else

            ' user cannot copy from the MDI parent form.
            MessageBox.Show("This functionality is not available in this form.")

        End If

    End Sub

    ' Cut functionality in the windows.
    Private Sub mnuEditCut_Click(sender As Object, e As EventArgs) Handles mnuEditCut.Click

        ' if the user is in a text editor.
        If TypeOf (ActiveMdiChild) Is frmArmstrongEditor Then

            ' call the cut.
            CType(ActiveMdiChild, frmArmstrongEditor).EditCut()

        Else

            ' the user cannot cut from the MDI parent, car inventory or the average units shipped forms.
            MessageBox.Show("This functionality is not available in this form.")

        End If

    End Sub

    ' Copy functionality in the windows.
    Private Sub mnuEditPaste_Click(sender As Object, e As EventArgs) Handles mnuEditPaste.Click

        ' if the user is within a text editor.
        If TypeOf (ActiveMdiChild) Is frmArmstrongEditor Then

            ' call the paste.
            CType(ActiveMdiChild, frmArmstrongEditor).EditPaste()

            ' if the user is within the car inventory.
        ElseIf TypeOf (ActiveMdiChild) Is frmCarInventory Then

            ' call the paste.
            CType(ActiveMdiChild, frmCarInventory).EditPaste()

            ' if the user is within the average units shipped.
        ElseIf TypeOf (ActiveMdiChild) Is frmAverageUnitsShipped Then

            ' callt the paste.
            CType(ActiveMdiChild, frmAverageUnitsShipped).EditPaste()

        Else

            ' user cannot paste to the MDI parent form.
            MessageBox.Show("This functionality is not available in this form.")

        End If

    End Sub

#End Region

#Region "About information"

    ' About information for each form.
    Private Sub mnuHelpAbout_Click(sender As Object, e As EventArgs) Handles mnuHelpAbout.Click

        ' if the user is within a text editor.
        If TypeOf (ActiveMdiChild) Is frmArmstrongEditor Then

            ' call the about.
            CType(ActiveMdiChild, frmArmstrongEditor).HelpAbout()

            ' if the user is within the car inventory. 
        ElseIf TypeOf (ActiveMdiChild) Is frmCarInventory Then

            ' call the about.
            CType(ActiveMdiChild, frmCarInventory).HelpAbout()

            ' if the user is within the average units shipped.
        ElseIf TypeOf (ActiveMdiChild) Is frmAverageUnitsShipped Then

            ' call the about.
            CType(ActiveMdiChild, frmAverageUnitsShipped).HelpAbout()

        Else

            ' Show About for the MDI parent form.
            MessageBox.Show("Lab 6" & vbCrLf & vbCrLf & "Alec Armstrong 100617553" & vbCrLf & vbCrLf & "16-04-2020")

        End If

    End Sub

#End Region

#Region "Formatting of MDI parent"

    ' Cascade the open windows.
    Private Sub mnuWindowsCascade_Click(sender As Object, e As EventArgs) Handles mnuWindowsCascade.Click

        ' call the layout to be cascaded.
        Me.LayoutMdi(MdiLayout.Cascade)

    End Sub

    ' Tile the open windows vertically.
    Private Sub mnuWindowsTileVertically_Click(sender As Object, e As EventArgs) Handles mnuWindowsTileVertically.Click

        ' call the layout to be tiled vertically.
        Me.LayoutMdi(MdiLayout.TileVertical)

    End Sub

    ' Tile the open windows horizontally.
    Private Sub mnuWindowsTileHorizontally_Click(sender As Object, e As EventArgs) Handles mnuWindowsTileHorizontally.Click

        ' call the layout to be tiled horizontally.
        Me.LayoutMdi(MdiLayout.TileHorizontal)

    End Sub

#End Region

#Region "Open forms"

    ' Open a new text editor using multiple click options.
    Private Sub OpenTextEditor(sender As Object, e As EventArgs) Handles mnuWindowsOpenTextEditor.Click, mnuFileNew.Click, tsFileNew.Click

        ' declare a new text editor form.
        Dim myTextEditor As New frmArmstrongEditor

        ' make the MDI parent the parent form.
        myTextEditor.MdiParent = Me

        ' show the text editor.
        myTextEditor.Show()

    End Sub

    ' Open the car inventory with two click options.
    Private Sub OpenCarList(sender As Object, e As EventArgs) Handles mnuWindowsOpenCarList.Click, tsWindowsOpenCarInventory.Click

        ' declare/check for the one instance of car inventory.
        Dim myCarInventory As frmCarInventory = frmCarInventory.Instance

        ' make the MDI parent the parent form.
        myCarInventory.MdiParent = Me

        ' show the car inventory form.
        myCarInventory.Show()

        ' focus the form if it is already open.
        myCarInventory.Focus()

    End Sub

    ' Open the average untis shipped with two click options.
    Private Sub OpenAverageUnitsShipped(sender As Object, e As EventArgs) Handles mnuWindowsOpenAverageUnitsShipped.Click, tsWindowsOpenAverageUnitsShipped.Click

        ' declare/check for the one instance of average units shipped.
        Dim myAverageUnitsShipped As frmAverageUnitsShipped = frmAverageUnitsShipped.Instance

        ' make the MDI parent the parent form.
        myAverageUnitsShipped.MdiParent = Me

        ' show the average units shipped form.
        myAverageUnitsShipped.Show()

        ' focus the from if it is already open.
        myAverageUnitsShipped.Focus()

    End Sub

#End Region

End Class