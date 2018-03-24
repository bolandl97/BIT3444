Public Class Arc
    Public Property ID As String
    Public Property Tail As Node
    Public Property Head As Node
    Public Property Capacity As Decimal
    Public Property Cost As Decimal
    Public Property Flow As Decimal
    ' Default Constructor
    Public Sub New()

    End Sub
    ' Constructor to build new arc object
    Public Sub New(t As Node, h As Node, d As Decimal)
        Try
            If t Is Nothing Or h Is Nothing Then
                Throw New Exception("Tail or head node does not exist.")
            End If
            Tail = t
            Head = h
            Cost = d
            ID = Tail.ID & "-TO-" & Head.ID
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Arc error")
        End Try
    End Sub

    ' Returns info. on Arc by overriding ToString method
    Public Overrides Function ToString() As String
        Return "(" & Tail.ID & ", " & Head.ID & ") " &
            "Capa: " & Capacity & " Cost: " & Cost
    End Function
End Class
