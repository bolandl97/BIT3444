Public Class Arc
    Public Property ID As String
    Public Property Tail As Node
    Public Property Head As Node
    Public Property Distance As Decimal

    Public Sub New()

    End Sub

    Public Sub New(t As Node, h As Node, d As Decimal)
        Try
            If t Is Nothing Or h Is Nothing Then
                Throw New Exception("Tail or head node does not exist.")
            End If
            Tail = t
            Head = h
            Distance = d
            ID = Tail.ID & "-TO-" & Head.ID
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Arc error")
        End Try
    End Sub
End Class
