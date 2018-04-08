Public Class Arc
    Public Property ID As String
    Public Property Tail As Node
    Public Property Head As Node
    Public Property Capacity As Decimal
    Public Property Cost As Decimal
    'these next two properties are supposed to be part of a TArc class in all the examples,
    'but it works fine this way so I'll ask Seref in class on Tuesday what he wants to see
    'Public Property PathList As New List(Of String())
    'Public Property MultiFlow As New SortedList(Of String, Decimal)

    ' Default Constructor
    Public Sub New()

    End Sub
    ' Constructor to build new arc object
    Public Sub New(t As Node, h As Node)
        Try
            If t Is Nothing Or h Is Nothing Then
                Throw New Exception("Tail or head node does not exist.")
            End If
            Tail = t
            Head = h

            ID = Tail.ID & "-TO-" & Head.ID
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Arc error")
        End Try
    End Sub
    'not currently used, but could be useful in forms
    ' Returns info. on Arc by overriding ToString method
    Public Overrides Function ToString() As String
        Return "(" & Tail.ID & ", " & Head.ID & ") " &
            "Capa: " & Capacity & " Cost: " & Cost
    End Function
End Class
