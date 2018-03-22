Imports System.Data.OleDb

Public Class Database
    Private Property myDataSet As New DataSet
    Private nodesDA As OleDbDataAdapter
    Private arcsDA As OleDbDataAdapter

    Public Sub New()

    End Sub

    Public Function GetDataAdapter(mySQL As String) As OleDbDataAdapter
        Dim connStr As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" &
            Application.StartupPath & "\Network.accdb"
        Return New OleDbDataAdapter(mySQL, connStr)

    End Function

    Public Function GetNodes() As SortedList(Of String, Node)
        nodesDA = GetDataAdapter("SELECT DISTINCT Tail FROM Arcs")
        nodesDA.Fill(myDataSet, "Nodes")
        Dim nodesList As New SortedList(Of String, Node)
        For i = 0 To myDataSet.Tables(“Nodes”).Rows.Count - 1
            Dim nodeName As String = myDataSet.Tables("Nodes").Rows(i)("Tail")
            Dim node As New Node(nodeName)
            nodesList.Add(nodeName, node)
        Next
        Return nodesList
    End Function

    Public Function GetArcs(nodeList As SortedList(Of String, Node)) As SortedList(Of String, Arc)
        arcsDA = GetDataAdapter("SELECT * FROM Arcs")
        arcsDA.Fill(myDataSet, "Arcs")
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
