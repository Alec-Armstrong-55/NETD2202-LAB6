'Project: Lab3
'Name: Alec Armstrong 100617553
'Date: 2020-02-23
'Desc: Will take an input for each day in the week numbered from 1 to 7 for each of the three employees.
'Input data will Then be validated And displayed to the user. Once the number of units has been entered 
'For the final day a calculation for average will be done and displayed to the user. After the 7th day 
'will Not allow the user to access the enter key Or input any more data until the form is reset. 
'The user will be allowed To Exit at any time.

Option Strict On

Public Class frmAverageUnitsShipped

#Region "Variable and constant declarations"

    'Constants
    'Days in the week
    Const DAYS_IN_WEEK As Integer = 7
    'Number of emloyees
    Const NUMBER_EMPLOYEES As Integer = 3
    ' Min and Max enterable value
    Const MAXIMUM_UNITS As Double = 5000.0
    Const MINIMUM_UNITS As Double = 0.0

    'Variables
    'Day counter to keep track of day in week
    Dim dayCounter As Integer = 1
    'Employee counter to keep track of employee
    Dim employeeCounter As Integer = 1
    'Average, double
    Dim averageUnitsShipped As Double = 0.0
    'Tester used to check if number is a whole number, integer
    Dim tryParseTesterInteger As Integer = 0
    'Tester used to check if number is a real number, double
    Dim tryParseTesterDouble As Double = 0.0

    'Array
    'Set to contain unit entries for each employee and each day, using  number employees and days in the week constants.
    Dim unitsShipped(NUMBER_EMPLOYEES - 1, DAYS_IN_WEEK - 1) As Integer

    Private Shared unitsFrmInstance As frmAverageUnitsShipped   'To create an instance of the form, to make sure only one is open.

#End Region

#Region "Event handlers"

    'Initialize variables, array and day display on form load
    Private Sub frmAverageUnitsShipped_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'Reset variables
        'Day counter to keep track of day in week
        dayCounter = 1
        'Employee counter to keep tack of employee
        employeeCounter = 1
        'Average
        averageUnitsShipped = 0.0
        'Testers
        tryParseTesterInteger = 0
        tryParseTesterDouble = 0.0

        'Array
        'Set to contain unit entries for each day, using days in the week constant, integers
        ReDim unitsShipped(NUMBER_EMPLOYEES - 1, DAYS_IN_WEEK - 1)

        'Day display
        lblDay.Text = "Day: " & CType(dayCounter, String)

        'Show focus is on employee 1
        lblEmployee1.BackColor = Color.Yellow
        lblEmployee1.Font = New Font(lblEmployee3.Font, FontStyle.Bold)

    End Sub

    'Exit button
    Friend Sub btnCloseForm_Click(sender As Object, e As EventArgs) Handles btnCloseForm.Click

        'Close the form
        Me.Close()

    End Sub

    Private Sub frmAverageUnitsShippedClosing(sender As Object, e As EventArgs) Handles MyBase.FormClosing

        ' Set the form to not being open.
        unitsFrmInstance = Nothing

    End Sub

    Friend Sub HelpAbout()

        ' Displays info about the form.
        MessageBox.Show("Lab 3" & vbCrLf & vbCrLf & "Alec Armstrong 100617553" & vbCrLf & vbCrLf)

    End Sub

    'Reset button
    Private Sub btnResetForm_Click(sender As Object, e As EventArgs) Handles btnResetForm.Click

        'Clear all fields 
        txtGetUnits.Clear()
        lblShowAverage1.Text = ""
        txtShowPreviousUnits1.Clear()
        lblShowAverage2.Text = ""
        txtShowPreviousUnits2.Clear()
        lblShowAverage3.Text = ""
        txtShowPreviousUnits3.Clear()
        lblShowCompanyAverage.Text = ""


        'Clear contents of array and variables
        ReDim unitsShipped(NUMBER_EMPLOYEES - 1, DAYS_IN_WEEK - 1)
        averageUnitsShipped = 0.0
        tryParseTesterInteger = 0
        tryParseTesterDouble = 0.0
        dayCounter = 1
        employeeCounter = 1

        'Set focus on the input field and reset all tools
        lblDay.Text = "Day: " & CType(dayCounter, String)
        lblEmployee1.BackColor = Color.Yellow
        lblEmployee1.Font = New Font(lblEmployee3.Font, FontStyle.Bold)
        lblEmployee2.Font = New Font(lblEmployee3.Font, FontStyle.Regular)
        lblEmployee3.Font = New Font(lblEmployee3.Font, FontStyle.Regular)
        btnEnterUseable.Enabled = True
        btnEnterUseable.BackColor = Color.White
        txtGetUnits.ReadOnly = False
        txtGetUnits.BackColor = Color.White
        txtGetUnits.Focus()

    End Sub

    'Enter button
    Private Sub btnEnterUseable_Click(sender As Object, e As EventArgs) Handles btnEnterUseable.Click

        'Validate that input is an integer and in range
        If Integer.TryParse(txtGetUnits.Text, tryParseTesterInteger) = True And tryParseTesterInteger >= MINIMUM_UNITS And tryParseTesterInteger <= MAXIMUM_UNITS Then

            'Check what day of the week it is
            If dayCounter <= DAYS_IN_WEEK - 1 Then

                'If days 1-6 store units in day array and display in the PrevUnits text box based on the employee, reset integer tester
                unitsShipped(employeeCounter - 1, dayCounter - 1) = tryParseTesterInteger
                If employeeCounter = 1 Then
                    txtShowPreviousUnits1.Text = txtShowPreviousUnits1.Text + CType(unitsShipped(employeeCounter - 1, dayCounter - 1), String) + vbNewLine
                ElseIf employeeCounter = 2 Then
                    txtShowPreviousUnits2.Text = txtShowPreviousUnits2.Text + CType(unitsShipped(employeeCounter - 1, dayCounter - 1), String) + vbNewLine
                ElseIf employeeCounter = 3 Then
                    txtShowPreviousUnits3.Text = txtShowPreviousUnits3.Text + CType(unitsShipped(employeeCounter - 1, dayCounter - 1), String) + vbNewLine
                End If

                txtGetUnits.Clear()
                tryParseTesterInteger = 0

                'Update day counter and display
                dayCounter = dayCounter + 1
                lblDay.Text = "Day: " & CType(dayCounter, String)

            ElseIf dayCounter = DAYS_IN_WEEK Then

                'If day 7 store units in day array, display in the PrevUnits text box based on which employee it is
                'Also make the enter button hidden and get units field and show the unuseable enter button and unusable units label
                'Update day counter
                unitsShipped(employeeCounter - 1, dayCounter - 1) = tryParseTesterInteger
                If employeeCounter = 1 Then
                    txtShowPreviousUnits1.Text = txtShowPreviousUnits1.Text + CType(unitsShipped(employeeCounter - 1, dayCounter - 1), String) + vbNewLine
                ElseIf employeeCounter = 2 Then
                    txtShowPreviousUnits2.Text = txtShowPreviousUnits2.Text + CType(unitsShipped(employeeCounter - 1, dayCounter - 1), String) + vbNewLine
                ElseIf employeeCounter = 3 Then
                    txtShowPreviousUnits3.Text = txtShowPreviousUnits3.Text + CType(unitsShipped(employeeCounter - 1, dayCounter - 1), String) + vbNewLine
                End If
                txtGetUnits.Clear()
                tryParseTesterInteger = 0

                'Calculate the average of all the days in the week
                For averageCounter As Integer = 1 To DAYS_IN_WEEK

                    averageUnitsShipped = averageUnitsShipped + unitsShipped(employeeCounter - 1, averageCounter - 1)

                Next

                'Check what employee and update. If it is the last employee set to do nothing.
                If employeeCounter = 1 Then

                    'Display the average of all the days
                    averageUnitsShipped = averageUnitsShipped / DAYS_IN_WEEK
                    lblShowAverage1.Text = "Average Per Day: " & CType(Math.Round(averageUnitsShipped, 2), String)

                    ' Reset daycounter and average, update employee counter and show which employee is to be entered
                    dayCounter = 1
                    lblDay.Text = "Day: " & CType(dayCounter, String)
                    employeeCounter = employeeCounter + 1
                    averageUnitsShipped = 0
                    lblEmployee1.BackColor = Color.GhostWhite
                    lblEmployee1.Font = New Font(lblEmployee3.Font, FontStyle.Regular)
                    lblEmployee2.BackColor = Color.Yellow
                    lblEmployee2.Font = New Font(lblEmployee3.Font, FontStyle.Bold)

                ElseIf employeeCounter = 2 Then

                    'Display the average of all the days
                    averageUnitsShipped = averageUnitsShipped / DAYS_IN_WEEK
                    lblShowAverage2.Text = "Average Per Day: " & CType(Math.Round(averageUnitsShipped, 2), String)

                    ' Reset daycounter and average, update employee counter and show which employee is to be entered
                    dayCounter = 1
                    lblDay.Text = "Day: " & CType(dayCounter, String)
                    employeeCounter = employeeCounter + 1
                    averageUnitsShipped = 0
                    lblEmployee2.BackColor = Color.GhostWhite
                    lblEmployee2.Font = New Font(lblEmployee3.Font, FontStyle.Regular)
                    lblEmployee3.BackColor = Color.Yellow
                    lblEmployee3.Font = New Font(lblEmployee3.Font, FontStyle.Bold)

                ElseIf employeeCounter = 3 Then

                    'Display the average of all the days for employee 3
                    averageUnitsShipped = averageUnitsShipped / DAYS_IN_WEEK
                    lblShowAverage3.Text = "Average Per Day: " & CType(Math.Round(averageUnitsShipped, 2), String)
                    averageUnitsShipped = 0

                    'Calculate the company average
                    For employeeCount As Integer = 1 To NUMBER_EMPLOYEES
                        'Calculate the average of all the days in the array
                        For averageCounter As Integer = 1 To DAYS_IN_WEEK

                            averageUnitsShipped = averageUnitsShipped + unitsShipped(employeeCount - 1, averageCounter - 1)

                        Next
                    Next

                    ' Display the company average
                    averageUnitsShipped = averageUnitsShipped / (DAYS_IN_WEEK * NUMBER_EMPLOYEES)
                    lblShowCompanyAverage.Text = "The Company Average Per Day: " & CType(Math.Round(averageUnitsShipped, 2), String)

                    ' Disable enter button and entry field, also set daycounter out of range so nothing can be entered, reset average
                    dayCounter = dayCounter + 1
                    averageUnitsShipped = 0
                    btnEnterUseable.Enabled = False
                    btnEnterUseable.BackColor = Color.LightGray
                    txtGetUnits.ReadOnly = True
                    txtGetUnits.BackColor = Color.LightGray
                    lblEmployee3.Font = New Font(lblEmployee3.Font, FontStyle.Regular)
                    lblEmployee3.BackColor = Color.GhostWhite
                    lblDay.Text = "Done"

                End If

            Else

                'Do nothing until reset button is used

            End If

        Else

            If Double.TryParse(txtGetUnits.Text, tryParseTesterDouble) = False Then

                'Display must be a number error
                MessageBox.Show("Please enter a numeric value.")
                txtGetUnits.Clear()
                txtGetUnits.Focus()

            Else

                If tryParseTesterDouble < MINIMUM_UNITS Or tryParseTesterDouble > MAXIMUM_UNITS Then

                    'Display must be in range number error
                    MessageBox.Show("Please enter a numeric value between 0 and 5000.")
                    txtGetUnits.Clear()
                    txtGetUnits.Focus()

                Else

                    'Display must be a integer error
                    MessageBox.Show("Please enter a whole numeric value.")
                    txtGetUnits.Clear()
                    txtGetUnits.Focus()

                End If

            End If

        End If

    End Sub

#End Region

#Region "Form properties"

    Friend Shared ReadOnly Property Instance() As frmAverageUnitsShipped

        Get

            ' Check if the form has been created.
            If unitsFrmInstance Is Nothing Then

                ' Create the instance of the form.
                unitsFrmInstance = New frmAverageUnitsShipped

            End If

            ' Return the form no matter what.
            Return unitsFrmInstance

        End Get

    End Property

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

        If ActiveControl Is txtGetUnits Then

            txtGetUnits.Text += Clipboard.GetText()

        End If

    End Sub

#End Region

End Class
