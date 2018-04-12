Public Class Node

    Public Property ID As String
    Public Property CityName As String
    Public Property ArcsIn As New List(Of Arc)
    Public Property ArcsOut As New List(Of Arc)
    Public Property Demand As New SortedList(Of String, Decimal)

    'default constructor
    Public Sub New()

    End Sub

    'custom constructor, takes city ID as string
    Public Sub New(value As String)
        ID = value
        ArcsIn = New List(Of Arc)
        ArcsOut = New List(Of Arc)
    End Sub


End Class
