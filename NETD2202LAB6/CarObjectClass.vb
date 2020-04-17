' Alec Armstrong 100617553
' 13-03-2020
' Description: Object class for a car, to create inventory for the inventory tracker application.
'

Option Strict On

Imports Microsoft.VisualBasic

Public Class CarObjectClass

#Region "Variable Declarations"

    ''' <summary>
    ''' Variables for the class.
    ''' </summary>
    Private Shared carCount As Integer = 0
    Private carIdentificationNumber As Integer = 0
    Private carMake As String = String.Empty
    Private carModel As String = String.Empty
    Private carYear As Integer = 0
    Private carPrice As Decimal = 0.0D
    Private carIsNew As Boolean = True

#End Region

#Region "Constructors"

    ''' <summary>
    ''' Non-parameterized constructor for the class.
    ''' </summary>
    Friend Sub New()

        carCount += 1
        carIdentificationNumber = carCount

    End Sub

    ''' <summary>
    ''' Parameterized constructor for the class.
    ''' </summary>
    ''' <param name="makeValue"> A cars manufacturer</param>
    ''' <param name="modelValue"> A cars model</param>
    ''' <param name="yearValue"> A cars year of manufacturing</param>
    ''' <param name="priceValue"> A cars current value</param>
    ''' <param name="newValue"> If the car is new or not</param>
    Friend Sub New(makeValue As String, modelValue As String, yearValue As Integer, priceValue As Decimal, newValue As Boolean)

        Me.New()

        carMake = makeValue
        carModel = modelValue
        carYear = yearValue
        carPrice = priceValue
        carIsNew = newValue
    End Sub

#End Region

#Region "Property Procedures"

    ''' <summary>
    ''' Accessor that returns the car count.
    ''' </summary>
    ''' <returns> The car count. </returns>
    Friend Shared ReadOnly Property Count As Integer
        Get
            Return carCount
        End Get
    End Property

    ''' <summary>
    ''' Accessor that returns the car id.
    ''' </summary>
    ''' <returns> The cars id. </returns>
    Friend ReadOnly Property Id As Integer
        Get
            Return carIdentificationNumber
        End Get
    End Property

    ''' <summary>
    ''' Function to return or change the cars make.
    ''' </summary>
    ''' <returns> The car make. </returns>
    Friend Property Make As String
        Get
            Return carMake
        End Get
        Set(value As String)
            carMake = value
        End Set
    End Property

    ''' <summary>
    ''' Function to return or change the cars model.
    ''' </summary>
    ''' <returns> The car model. </returns>
    Friend Property Model As String
        Get
            Return carModel
        End Get
        Set(value As String)
            carModel = value
        End Set
    End Property

    ''' <summary>
    ''' Function to return or change the cars year.
    ''' </summary>
    ''' <returns> The car year. </returns>
    Friend Property Year As Integer
        Get
            Return carYear
        End Get
        Set(value As Integer)
            carYear = value
        End Set
    End Property

    ''' <summary>
    ''' Function to return or change the cars price.
    ''' </summary>
    ''' <returns> The car price. </returns>
    Friend Property Price As Decimal
        Get
            Return carPrice
        End Get
        Set(value As Decimal)
            carPrice = value
        End Set
    End Property

    ''' <summary>
    ''' Function to return or change the cars new state.
    ''' </summary>
    ''' <returns> The car new state. </returns>
    Friend Property IsNew As Boolean
        Get
            Return carIsNew
        End Get
        Set(value As Boolean)
            carIsNew = value
        End Set
    End Property

#End Region

#Region "Methods"

    ''' <summary>
    ''' Function to return the car class' tostring.
    ''' </summary>
    ''' <returns> A tostring. </returns>
    Friend Function GetCarData() As String

        Return IIf(carIsNew, "New ", "Used ").ToString & carYear.ToString & " " & carMake & " " & carModel & " for " & carPrice.ToString("c")

    End Function

#End Region

End Class
