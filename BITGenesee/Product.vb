Public Class Product
    Public Property ID As Integer
    Public Property Name As String
    Public Sub New()

    End Sub

    Public Sub New(i As Integer, n As String)
        ID = i
        Name = n
    End Sub

End Class
