'This is the network class, used in the solver model

Public Class Network
    Public Property NodeList As New SortedList(Of String, Node)
    Public Property ArcList As New SortedList(Of String, TArc)
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
        For Each a In arcsList.Values
            Dim t As New TArc
            t.Head = a.Head
            t.Tail = a.Tail
            t.Capacity = a.Capacity
            t.Cost = a.Cost
            t.ID = a.ID
            ArcList.Add(t.ID, t)
        Next
    End Sub

    Public Sub AddProducts(prodsList As SortedList(Of String, Product))
        For Each p In prodsList
            ProdList.Add(p.Key, p.Value)
        Next
    End Sub

    Public Sub BuildNetwork(nodesList As SortedList(Of String, Node),
                            arcsList As SortedList(Of String, Arc),
                            prodsList As SortedList(Of String, Product))
        Dim progForm As New frmProgress
        progForm.prbNodes.Minimum = 1
        progForm.prbNodes.Maximum = nodesList.Count + arcsList.Count + prodsList.Count
        progForm.Show()

        Dim cnt As Integer = 0
        For Each n In nodesList
            NodeList.Add(n.Key, n.Value)
            cnt += 1
            progForm.prbNodes.Value = cnt
            progForm.Refresh()
        Next

        For Each a In arcsList.Values
            Dim t As New TArc
            t.Head = a.Head
            t.Tail = a.Tail
            t.Capacity = a.Capacity
            t.Cost = a.Cost
            t.ID = a.ID
            ArcList.Add(t.ID, t)
            cnt += 1
            progForm.prbNodes.Value = cnt
            progForm.Refresh()
        Next
        For Each p In prodsList
            ProdList.Add(p.Key, p.Value)
            cnt += 1
            progForm.prbNodes.Value = cnt
            progForm.Refresh()
        Next
        progForm.Close()
    End Sub

End Class
