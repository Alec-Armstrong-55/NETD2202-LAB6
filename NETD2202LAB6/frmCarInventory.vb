' Alec Armstrong 100617553
' 13-03-2020
' Description: A car inventory application that uses the car object class and an array to keep track of the inventory. It also uses a listview to display the entered inventory.
'              The user may enter a car make using a combo box, model using a text box, year using a numeric up down, price using a text box and a checkbox if the car is new.
'              After the enter button is clicked all data is validated and added to the list view, otherwise error messages are shown in the display output box, the user may 
'              also change existing inventory by clicking on them, changing and clicking the enter key. The reset button resets the from to its original state without changing
'              anything in the list view. The user may also exit using the exit button at any time. 

Option Strict On

Public Class frmCarInventory

#Region "Variables Declarations"

    Dim selectedInventory As CarObjectClass            'Create a new car object.
    Dim isInventorySelected As Boolean = False         'Keeps track of if inventory is selected. 
    Dim addToListView As Boolean = False               'Keeps track of if an object should be added to the inventory list.
    Dim inventoryList As New List(Of CarObjectClass)   'Collection list of all inventory.
    Dim price As Double = 0
    Dim year As Integer = 1920

    Private Shared carFrmInstance As frmCarInventory   'To create an instance of the form, to make sure only one is open.

#End Region

#Region "EventHandlers"

    Private Sub NETD2202LAB4_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        ' Set form back to default state.
        Defaults()

    End Sub

    Private Sub frmCarInventoryClosing(sender As Object, e As EventArgs) Handles MyBase.FormClosing

        ' Set the form to not being open.
        carFrmInstance = Nothing

    End Sub

    Private Sub btnEnter_Click(sender As Object, e As EventArgs) Handles btnEnter.Click

        ' Check that data in the form is valid using the InputValidation procedure.
        If InputValidation() = True Then

            ' If an inventory item is not selected.
            If Not isInventorySelected Then

                ' Create a new car object and it to the inventory list.
                selectedInventory = New CarObjectClass(cmbMake.Text, txtModel.Text, CInt(nudYear.Value), CDec(txtPrice.Text), chkNew.Checked)
                inventoryList.Add(selectedInventory)

                ' Else if an inventory item is selected.
            ElseIf selectedInventory.Id > 0 Then

                ' Update the inventory item.
                selectedInventory.Make = cmbMake.Text
                selectedInventory.Model = txtModel.Text
                selectedInventory.Year = CInt(nudYear.Value)
                selectedInventory.Price = CDec(txtPrice.Text)
                selectedInventory.IsNew = chkNew.Checked

            End If

            ' Set form back to default state.
            Defaults()
            lblOutput.Text = "It worked!" & vbCrLf & selectedInventory.GetCarData()

        End If

    End Sub

    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click

        ' Set form back to default state.
        Defaults()

    End Sub

    Friend Sub MeClose() Handles btnClose.Click

        ' Close the form.
        Me.Close()

    End Sub

    Friend Sub HelpAbout()

        ' Displays info about the form.
        MessageBox.Show("Lab 4" & vbCrLf & vbCrLf & "Alec Armstrong 100617553" & vbCrLf & vbCrLf)

    End Sub

    Private Sub lvwCarInventory_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lvwCarInventory.SelectedIndexChanged

        ' Check if any inventory in the listview is selected.
        If lvwCarInventory.SelectedIndices.Count = 1 Then

            ' Make sure the correct object is slected.
            selectedInventory = inventoryList(lvwCarInventory.SelectedIndices(0))
            isInventorySelected = True

            ' Display info in data entry fields.
            cmbMake.Text = selectedInventory.Make
            txtModel.Text = selectedInventory.Model
            nudYear.Value = selectedInventory.Year
            txtPrice.Text = selectedInventory.Price.ToString()
            chkNew.Checked = selectedInventory.IsNew

            ' Display update to car in output field.
            lblOutput.Text = selectedInventory.GetCarData()

        Else

            ' Inventory is not selected.
            isInventorySelected = False
        End If

    End Sub

    Private Sub lvwCarInventory_ItemCheck(sender As Object, e As ItemCheckEventArgs) Handles lvwCarInventory.ItemCheck

        ' If not currently adding to inventory checkboxes cannot be changed.
        If Not addToListView Then
            e.NewValue = e.CurrentValue
        End If

    End Sub

#End Region

#Region "Procedures"

    Private Sub Defaults()

        ' Set all fields to default values.
        cmbMake.SelectedIndex = -1
        txtModel.Clear()
        nudYear.Value = 1920
        txtPrice.Clear()
        chkNew.Checked = False
        lblOutput.Text = String.Empty

        ' Use ListInventory procedure to output the ListView.
        ListInventory()

        ' No inventory is selected, focus the combo box.
        isInventorySelected = False
        cmbMake.Focus()

    End Sub

    Private Function InputValidation() As Boolean

        Dim isValidInput As Boolean = True       ' Stores if the validation was successful, set to true(only changes if there is a problem).
        Dim output As String = String.Empty      ' Output that will go into the output text box.
        Dim tryParseTester As Double = 0

        ' Checks if there is anything entered into the make text box.
        ' If nothing is there then it will add a output error and set isValidInout to false.
        If cmbMake.SelectedIndex < 0 Then
            output += "Please enter the cars make." & vbCrLf
            isValidInput = False
        End If

        ' Checks if there is anything entered into the model text box.
        ' If nothing is there then it will add a output error and set isValidInout to false.
        If txtModel.Text.Trim.Length = 0 Then
            output += "Please enter the cars model." & vbCrLf
            isValidInput = False
        End If

        ' Checks if there is a number entered into the price text box.
        ' If anything but a number is there then it will add a output error and set isValidInout to false.
        If Double.TryParse(txtPrice.Text, tryParseTester) = False Then

            ' Checks if there is anything entered into the price text box.
            ' If nothing is there then it will add a output error and set isValidInout to false.
            If txtPrice.Text.Trim.Length = 0 Then
                output += "Please enter the cars price." & vbCrLf
            Else
                output += "Please enter the cars price as a number." & vbCrLf
            End If

            isValidInput = False

        End If

        ' If isValidInput is false output the errors to the output text box.
        If isValidInput = False Then
            lblOutput.Text = "There are the following ERRORS:" & vbCrLf & output
        End If

        ' Return if validation was successful or not.
        Return isValidInput

    End Function

    Sub ListInventory()

        ' Clear current list view items.
        lvwCarInventory.Items.Clear()

        ' Populate the list.
        For inventory As Integer = 0 To inventoryList.Count - 1

            ' create a new ListViewItem.
            Dim inventoryItem As New ListViewItem()

            ' Populate all parts of the item.
            inventoryItem.Checked = inventoryList(inventory).IsNew
            inventoryItem.SubItems.Add(inventoryList(inventory).Id.ToString())
            inventoryItem.SubItems.Add(inventoryList(inventory).Make)
            inventoryItem.SubItems.Add(inventoryList(inventory).Model)
            inventoryItem.SubItems.Add(inventoryList(inventory).Year.ToString())
            inventoryItem.SubItems.Add(inventoryList(inventory).Price.ToString("c"))

            ' Add inventory to ListView.
            addToListView = True
            lvwCarInventory.Items.Add(inventoryItem)

            ' Done adding to the ListView.
            addToListView = False

        Next

    End Sub

#End Region

#Region "Copy and Paste"

    ''' <summary>
    ''' Copy the selected text.
    ''' </summary>
    Friend Sub EditCopy()

        If Not ActiveControl.Text = String.Empty Then

            Clipboard.SetText(ActiveControl.Text)

        End If

    End Sub

    ''' <summary>
    ''' Pastes the clipboard.
    ''' </summary>
    Friend Sub EditPaste()

        If ActiveControl Is txtModel Or ActiveControl Is txtPrice Then

            ActiveControl.Text += Clipboard.GetText()

        End If

    End Sub

#End Region

#Region "Form Properties"

    Friend Shared ReadOnly Property Instance() As frmCarInventory

        Get

            ' Check if the form has been created.
            If carFrmInstance Is Nothing Then

                ' Create the instance of the form.
                carFrmInstance = New frmCarInventory

            End If

            ' Return the form no matter what.
            Return carFrmInstance

        End Get

    End Property


#End Region

End Class
