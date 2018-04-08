Public Class Product
    Public Property ID As Integer
    Public Property Name As String

    'default constructor
    Public Sub New()

    End Sub

    'custom constuctor, takes product ID and product name
    Public Sub New(i As Integer, n As String)
        ID = i
        Name = n
    End Sub

End Class
