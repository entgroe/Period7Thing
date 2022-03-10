' Class filename:       Computer.vb
' Created/revised by:   <your name> on <current date>

Option Explicit On
Option Strict On
Option Infer Off

Public Class Computer
    Private _id As String
    Private _price As String

    Public Property Id() As String
        Get
            Return _id
        End Get
        Set(ByVal value As String)
            _id = value
        End Set
    End Property

    Public Property Price() As String
        Get
            Return _price
        End Get
        Set(ByVal value As String)
            _id = value
        End Set
    End Property

    Public Sub New()
        _id = String.Empty
        _price = String.Empty
    End Sub

    Public Sub New(ByVal model As String, ByVal cost As String)
        Id = model
        Price = cost
    End Sub

    Public Function CalcNewPrice(ByVal discountPercent As Decimal) As Decimal
        Dim oldPrice As Decimal
        Dim newPrice As Decimal

        Decimal.TryParse(_price, oldPrice)
        newPrice = oldPrice - oldPrice * discountPercent

    End Function
End Class
