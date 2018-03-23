Public Class TArc
    ' Implements TArc class which inherits Arc class, and adds a list of trans-paths
    ' Dependencies: Arc
    Public Class TArc
        .
        Inherits Arc

        Public Property PathList As New List(Of String())

        Public Property MultiFlow As New SortedList(Of String, Decimal)

        Public Sub New()

        End Sub

        ' Creates new instance with tail and head node
        Public Sub New(t As Node, h As Node)
            MyBase.New(t, h)
        End Sub

        ' Returns information on TArc instance
        Public Overrides Function ToString() As String
            Return MyBase.ToString & ", Trans Paths: " & PathList.Count
        End Function

    End Class
End Class
