Public Class Network
    Public Property NodeList As New SortedList(Of String, Node)
    Public Property ArcList As New SortedList(Of String, Arc)
    Public Property ProdList As SortedList(Of String, Integer)

    Public Sub New()

    End Sub

    'Return node instance given id
    Public Function GetNode(id As String) As Node
        Try
            If Not NodeList.ContainsKey(id) Then
                Throw New Exception("Node " & id & " does not exist.")
            End If
            Return NodeList(id)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Node error")
            Return Nothing
        End Try
    End Function

    ' Return arc instance given tail and head node
    Public Function GetArc(t As String, h As String) As Arc
        Try
            Dim id As String = t & "-TO-" & h
            If Not ArcList.ContainsKey(id) Then
                Throw New Exception("Arc" & id & " does not exist.")
            End If
            Return ArcList(id)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Arc error")
            Return Nothing
        End Try
    End Function




End Class
