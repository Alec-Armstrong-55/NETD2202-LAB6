' Author: Alec Armstrong 100617553
' Date: April 2, 2020
' Description:
'   This program is a simple text editor.
'   A user can enter text into the textbox, and resize and inimize the form.
'   Basic functionality to Save, Open, Exit and create a new form, also some clipboard
'   functionality in Copy, Paste and Cut. About info is also available.

Option Strict On

Imports System.IO

Public Class frmArmstrongEditor

#Region "Variables"

    ' Variable for keeping track of the file path
    Dim filePath As String = String.Empty

    ' Checks if the cut function was last used before the paste.
    Dim isCut As Boolean = False

#End Region

#Region "Load event handler"

    ''' <summary>
    ''' When the application is opened, set to defaults.
    ''' </summary>
    Private Sub frmArmstrongEditor_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        SetDefaults()

    End Sub

#End Region

#Region "File Event Handlers"

    ''' <summary>
    ''' Opens a new file after checking if the user wants to save the current file, setting to defaults.
    ''' </summary>
    Friend Sub FileNew()

        SetDefaults()

    End Sub

    ''' <summary>
    ''' Opens a previously created text document.
    ''' </summary>
    Friend Sub FileOpen()

        ' objects used to open and read a file.
        Dim openFile As FileStream
        Dim fileReader As StreamReader

        ' If a file is selected.
        If opdOpen.ShowDialog() = DialogResult.OK Then

            ' Make the file path the chosen one.
            filePath = opdOpen.FileName

            ' Update the form title.
            UpdateFormTitle()

            ' Open the chosen file and read it.
            openFile = New FileStream(filePath, FileMode.Open, FileAccess.Read)
            fileReader = New StreamReader(openFile)
            txtEditor.Text = fileReader.ReadToEnd

            ' Close the file reader.
            fileReader.Close()

        End If

    End Sub

    ''' <summary>
    ''' Saves the document currently open or calls upon the save as option.
    ''' </summary>
    Friend Sub FileSave()

        If filePath = String.Empty Then

            ' Use Save As.
            FileSaveAs()

        Else

            ' Save the file.
            SaveTextFile(filePath)

        End If

    End Sub

    ''' <summary>
    ''' Saves the document currently open to the specified locationin memory.
    ''' </summary>
    Friend Sub FileSaveAs()

        ' Sets the filter for the save dialog.
        sfdSaveAs.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*"

        ' If the user selects a file.
        If sfdSaveAs.ShowDialog() = DialogResult.OK Then

            ' Set the new file path
            filePath = sfdSaveAs.FileName

            ' Update the form title
            UpdateFormTitle()

            ' Save the file.
            SaveTextFile(filePath)

        End If

    End Sub

    ''' <summary>
    ''' Exit the application.
    ''' </summary>
    Friend Sub FileClose()

        Me.Close()

    End Sub

#End Region

#Region "Edit Event Handlers"

    ''' <summary>
    ''' Copy the selected text.
    ''' </summary>
    Friend Sub EditCopy()

        If Not txtEditor.SelectedText = String.Empty Then

            Clipboard.SetText(txtEditor.SelectedText)

        End If

    End Sub

    ''' <summary>
    ''' Cuts the selected text.
    ''' </summary>
    Friend Sub EditCut()

        If Not txtEditor.SelectedText = String.Empty Then

            Clipboard.SetText(txtEditor.SelectedText)
            txtEditor.SelectedText = String.Empty

            isCut = True

        End If


    End Sub

    ''' <summary>
    ''' Pastes the clipboard.
    ''' </summary>
    Friend Sub EditPaste()

        txtEditor.Paste(Clipboard.GetText())

        If isCut = True Then

            Clipboard.Clear()

            isCut = False

        End If

    End Sub

#End Region

#Region "Help Event Handler"

    ''' <summary>
    ''' Displays info on the form.
    ''' </summary>
    Friend Sub HelpAbout()

        MessageBox.Show("Lab 5" & vbCrLf & vbCrLf & "Alec Armstrong 100617553" & vbCrLf & vbCrLf & "02-04-2020")

    End Sub

#End Region

#Region "Methods"

    ''' <summary>
    ''' Set the defaults of the form.
    ''' </summary>
    Friend Sub SetDefaults()

        ' Clear anything inside the text box and put focus on the Editor.
        txtEditor.Text = String.Empty
        txtEditor.Focus()

        ' Unset the saved file path and update the form title
        filePath = String.Empty
        UpdateFormTitle()

    End Sub

    ''' <summary>
    ''' Saves the file that is passed into it.
    ''' </summary>
    ''' <param name="path">A full file path as a string</param>
    Friend Sub SaveTextFile(path As String)

        Dim fileToAccess As New FileStream(path, FileMode.Create, FileAccess.Write)
        Dim writer As New StreamWriter(fileToAccess)

        writer.Write(txtEditor.Text)

        writer.Close()

    End Sub

    ''' <summary>
    ''' Updates the form's title text to include the open file path.
    ''' </summary>
    Friend Sub UpdateFormTitle()

        Me.Text = "Armstrong Editor"

        If Not filePath = String.Empty Then

            Me.Text &= " - " & filePath

        End If

    End Sub

#End Region

End Class
