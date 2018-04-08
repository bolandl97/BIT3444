'This is the network class, used in the solver model

Public Class Network
    Public Property NodeList As New SortedList(Of String, Node)
    Public Property ArcList As New SortedList(Of String, Arc)
    Public Property ProdList As New SortedList(Of String, Product)

    Public Event Changed(net As Network)

    Public Sub New()

    End Sub

    Public Sub AddNodes(nodesList As SortedList(Of String, Node))
        For Each n In nodesList
            NodeList.Add(n.Key, n.Value)
        Next
    End Sub

    Public Sub AddArcs(arcsList As SortedList(Of String, Arc))
        For Each a In arcsList
            ArcList.Add(a.Key, a.Value)
        Next
    End Sub

    Public Sub AddProducts(prodsList As SortedList(Of String, Product))
        For Each p In prodsList
            ProdList.Add(p.Key, p.Value)
        Next
    End Sub

End Class
