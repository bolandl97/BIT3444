Public Class Node

    Public Property ID As String
    Public Property ArcsIn As New List(Of Arc)
    Public Property ArcsOut As New List(Of Arc)

    Public Sub New()

    End Sub


    Public Sub New(value As String)
        ID = value

    End Sub


End Class
