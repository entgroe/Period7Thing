' Name:         Employee
' Purpose:      Defines an Employee object
' Programmer:   <your name> on <current date>

Option Explicit On
Option Strict On
Option Infer Off

Public Class Employee
    Private _number As String
    Private _empName As String

    Public Property Number() As String
        Get
            Return _number
        End Get
        Set(ByVal value As String)
            _number = value
        End Set
    End Property

    Public Property EmpName() As String
        Get
            Return _empName
        End Get
        Set(ByVal value As String)
            _empName = value
        End Set
    End Property

    Public Sub New()
        _number = String.Empty
        _empName = String.Empty
    End Sub

    Public Sub New(ByVal num As String, ByVal name As String)
        Number = num
        EmpName = name
    End Sub

    Public Function GetGross(ByVal salary As Double) As Double
        ' calculates the gross pay for salaried
        ' employees, who are paid twice per month

        Return salary / 24
    End Function

    Public Function GetGross(ByVal hours As Double,
                             ByVal rate As Double) As Double
        ' calculates the weekly gross pay for hourly employees

        Return hours * rate
    End Function
End Class