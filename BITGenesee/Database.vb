Imports System.Data.OleDb

Public Class Database
    Private Property myDataSet As New DataSet
    Private nodesDA As OleDbDataAdapter
    Private arcsDA As OleDbDataAdapter
    Private productsDA As OleDbDataAdapter
    Private supplyDemandDA As OleDbDataAdapter

    Public Function GetDataAdapter(mySQL As String) As OleDbDataAdapter
        Dim connStr As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" &
            Application.StartupPath & "\Database.accdb"
        Return New OleDbDataAdapter(mySQL, connStr)

    End Function

    Public Sub New()
        nodesDA = GetDataAdapter("SELECT Code, City FROM Nodes")
        nodesDA.Fill(myDataSet, "Nodes")
        arcsDA = GetDataAdapter("SELECT * FROM Arcs")
        arcsDA.Fill(myDataSet, "Arcs")
        productsDA = GetDataAdapter("SELECT * FROM Products")
        productsDA.Fill(myDataSet, "Products")
        supplyDemandDA = GetDataAdapter("SELECT Code, Prod1Dem, Prod2Dem, Prod3Dem FROM Nodes")
        supplyDemandDA.Fill(myDataSet, "DemandSupply")
    End Sub

    Public Function GetNodes() As SortedList(Of String, Node)
        Dim nodesList As New SortedList(Of String, Node)
        For i = 0 To myDataSet.Tables(“Nodes”).Rows.Count - 1
            Dim nodeID As String = myDataSet.Tables("Nodes").Rows(i)("Code")
            Dim nodeName As String = myDataSet.Tables("Nodes").Rows(i)("City")
            Dim node As New Node(nodeID)
            node.CityName = nodeName
            nodesList.Add(nodeID, node)
        Next
        Return nodesList
    End Function

    Public Function GetArcs(nodeList As SortedList(Of String, Node)) As SortedList(Of String, Arc)
        Dim arcsList As New SortedList(Of String, Arc)
        For i = 0 To myDataSet.Tables(“Arcs”).Rows.Count - 1
            Dim tail As String = myDataSet.Tables("Arcs").Rows(i)("Tail")
            Dim head As String = myDataSet.Tables("Arcs").Rows(i)("Head")
            Dim dist As Decimal = myDataSet.Tables("Arcs").Rows(i)("Distance")
            Dim arc As New Arc(nodeList(tail), nodeList(head), dist)
            nodeList(tail).ArcsOut.Add(arc)
            nodeList(head).ArcsIn.Add(arc)
            arcsList.Add(arc.ID, arc)
        Next
        Return arcsList
    End Function

End Class
