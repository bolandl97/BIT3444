Imports System.Data.OleDb

Public Class Database
    Private Property myDataSet As New DataSet
    Private nodesDA As OleDbDataAdapter
    Private arcsDA As OleDbDataAdapter
    Private productsDA As OleDbDataAdapter
    Private supplyDemandDA As OleDbDataAdapter
    Private UsersDA As OleDbDataAdapter

    'creates data adapter
    Public Function GetDataAdapter(mySQL As String) As OleDbDataAdapter
        Dim connStr As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" &
            Application.StartupPath & "\Database.accdb"
        Return New OleDbDataAdapter(mySQL, connStr)

    End Function
    Public Function GetUserDataAdapter(mySQL As String)
        Dim connStr As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" &
            Application.StartupPath & "\USERS.accdb"
        Return New OleDbDataAdapter(mySQL, connStr)
    End Function

    'creates new database class
    Public Sub New()
        'fills myDataSet nodes table with info from database
        nodesDA = GetDataAdapter("SELECT * FROM Nodes")
        nodesDA.Fill(myDataSet, "Nodes")
        'fills myDataSet arcs table with info from database
        arcsDA = GetDataAdapter("SELECT * FROM Arcs")
        arcsDA.Fill(myDataSet, "Arcs")
        'fills myDataSet products table with info from database
        productsDA = GetDataAdapter("SELECT * FROM Products")
        productsDA.Fill(myDataSet, "Products")
        'fills myDataSet DemandSupply table with info from database
        supplyDemandDA = GetDataAdapter("SELECT Code, Prod1Dem, Prod2Dem, Prod3Dem FROM Nodes")
        supplyDemandDA.Fill(myDataSet, "DemandSupply")
    End Sub
    ' a second custom constructor just for the Users table
    Public Sub New(IsUserData As Boolean)
        UsersDA = GetUserDataAdapter("SELECT * FROM Users")
        UsersDA.Fill(myDataSet, "Users")
    End Sub
    'returns a sorted list of nodes
    Public Function GetNodes() As SortedList(Of String, Node)
        Dim nodesList As New SortedList(Of String, Node)
        'for each row of Nodes table in myDataSet, creates new node object with ID and sets
        'city name property, then adds node to nodeList
        For i = 0 To myDataSet.Tables(“Nodes”).Rows.Count - 1
            Dim nodeID As String = myDataSet.Tables("Nodes").Rows(i)("Code")
            Dim nodeName As String = myDataSet.Tables("Nodes").Rows(i)("City")
            Dim dem1 As Decimal = myDataSet.Tables("Nodes").Rows(i)("Prod1Dem")
            Dim dem2 As Decimal = myDataSet.Tables("Nodes").Rows(i)("Prod2Dem")
            Dim dem3 As Decimal = myDataSet.Tables("Nodes").Rows(i)("Prod3Dem")
            Dim node As New Node(nodeID)
            node.CityName = nodeName
            node.Demand.Add("Genesee", dem1)
            node.Demand.Add("Genny Lite", dem2)
            node.Demand.Add("Cream Ale", dem3)
            nodesList.Add(nodeID, node)
        Next
        Return nodesList
    End Function

    'returns a sorted list of arcs
    Public Function GetArcs(nodeList As SortedList(Of String, Node)) As SortedList(Of String, Arc)
        Dim arcsList As New SortedList(Of String, Arc)
        'for each row of Arcs table in myDataSet, creates new arc object with tail node property,
        'head node property, and distance/cost property
        'then adds arc to arcList
        For i = 0 To myDataSet.Tables(“Arcs”).Rows.Count - 1
            Dim tail As String = myDataSet.Tables("Arcs").Rows(i)("Tail")
            Dim head As String = myDataSet.Tables("Arcs").Rows(i)("Head")
            Dim dist As Decimal = myDataSet.Tables("Arcs").Rows(i)("Distance")
            Dim capacity As Decimal = myDataSet.Tables("Arcs").Rows(i)("Capacity")
            Dim arc As New Arc(nodeList(tail), nodeList(head))
            'cost for arc is $0.39 per ton per mile
            arc.Cost = dist * 0.39
            arc.Capacity = capacity
            nodeList(tail).ArcsOut.Add(arc)
            nodeList(head).ArcsIn.Add(arc)
            arcsList.Add(arc.ID, arc)
        Next
        Return arcsList
    End Function

    Public Function GetProducts() As SortedList(Of String, Product)
        Dim prodsList As New SortedList(Of String, Product)
        For i = 0 To myDataSet.Tables("Products").Rows.Count - 1
            Dim prodID As Integer = myDataSet.Tables("Products").Rows(i)("ID")
            Dim prodName As String = myDataSet.Tables("Products").Rows(i)("Name")
            Dim product As New Product(prodID, prodName)
            prodsList.Add(prodName, product)
        Next
        Return prodsList
    End Function

    Public Function GetDemand(n As Node, p As Product) As Decimal
        Dim d As Decimal = n.Demand(p.Name)
        Return d
    End Function

    ' Checks if user/password exists
    Public Function UserFound(usr As String, pwd As String) As Boolean
        Dim r() As DataRow = myDataSet.Tables("Users").Select("Username = '" & usr & "' AND Password = '" & pwd & "'")
        If r.Length > 0 Then
            Return True
        Else
            Return False
        End If
    End Function
End Class
