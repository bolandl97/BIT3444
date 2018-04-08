Public Class frmVisual

    Dim data As New Database
    Dim WithEvents net As New Network
    Dim opt As New Optimization
    Dim nodesList As New SortedList(Of String, Node)
    Dim arcsList As New SortedList(Of String, Arc)
    Dim prodsList As New SortedList(Of String, Product)

    'sub idea taken from homework 3
    'updates tree view object based on selected city
    Private Sub UpdateTreeView(city As String)
        'clears any city already populating trv object
        trvArcs.Nodes.Clear()
        'creates new tree node object
        Dim newTreeNode As New TreeNode(city)
        'adds tree node to trvArcs
        trvArcs.Nodes.Add(newTreeNode)
        'adds arcsIn and arcsOut nodes as children of parent tree node
        Dim arcsIn As New TreeNode("ArcsIn")
        Dim arcsOut As New TreeNode("ArcsOut")
        newTreeNode.Nodes.Add(arcsIn)
        newTreeNode.Nodes.Add(arcsOut)
        Dim node As Node = net.NodeList(city)
        'adds each ingoing node to tree
        For Each Arc In node.ArcsIn
            Dim arcIn As New TreeNode(Arc.Tail.ID)
            arcsIn.Nodes.Add(arcIn)
        Next
        'adds each outgoing node to tree
        For Each Arc In node.ArcsOut
            Dim arcOut As New TreeNode(Arc.Head.ID)
            arcsOut.Nodes.Add(arcOut)
        Next

    End Sub

    'handles selection of arc node in tree object
    Private Sub trvNetwork_AfterSelect(sender As Object, e As TreeViewEventArgs) Handles trvArcs.AfterSelect
        'sets selected node as parent node
        Dim tn As TreeNode = trvArcs.SelectedNode
        Dim arcID As String
        Try
            'checks to make sure correct node is selected
            If tn.Text = trvArcs.Nodes(0).Text OrElse tn.Parent.Text = trvArcs.Nodes(0).Text Then
                Throw New Exception("Select a destination or origin node.")
            End If
            'determines if click is in arcsIn or arcsOut
            If tn.Parent.Text = "ArcsIn" Then
                arcID = tn.Text & "-TO-" & trvArcs.Nodes(0).Text
            Else
                arcID = trvArcs.Nodes(0).Text & "-TO-" & tn.Text
            End If
            'sets text box to cost of arc
            txtCost.Text = net.ArcList(arcID).Cost
            'sets text box to remaining arc capacity
            txtCapacity.Text = net.ArcList(arcID).Capacity
            'sets text box to arc flow for selected product
            txtFlow.Text = net.ArcList(arcID).MultiFlow(lstProducts.SelectedItem)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Selection Error")
        End Try
    End Sub

    'handles selection in nodes list box
    Private Sub lstNodes_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstNodes.SelectedIndexChanged
        UpdateTreeView(lstNodes.SelectedItem)
        'sets text box to node demand for selected product
        If Not lstProducts.SelectedItem = "" Then
            txtDemand.Text = data.GetDemand(net.NodeList(lstNodes.SelectedItem), net.ProdList(lstProducts.SelectedItem))
        End If
    End Sub
    'handles selection in products list box
    Private Sub lstProducts_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstProducts.SelectedIndexChanged
        'sets text box to node demand for selected product
        txtDemand.Text = data.GetDemand(net.NodeList(lstNodes.SelectedItem), net.ProdList(lstProducts.SelectedItem))
    End Sub
    'builds network for solver model
    Public Sub BuildNetwork()
        'clear previous network properties
        net.NodeList.Clear()
        net.ArcList.Clear()
        net.ProdList.Clear()
        'set new network properties
        net.AddNodes(data.GetNodes)
        net.AddArcs(data.GetArcs(net.NodeList))
        net.AddProducts(data.GetProducts)
        'clears list boxes
        lstProducts.Items.Clear()
        lstNodes.Items.Clear()
        'adds nodes to list box
        For Each node In net.NodeList
            lstNodes.Items.Add(node.Key)
        Next
        'adds products to list box
        For Each p In net.ProdList
            lstProducts.Items.Add(p.Key)
        Next
        'selects first city
        lstNodes.SelectedIndex = 0
        'selects first product
        lstProducts.SelectedIndex = 0
        'txtDemand.Text = data.GetDemand(net.NodeList(lstNodes.SelectedItem), net.ProdList(lstProducts.SelectedItem))
    End Sub
    'solves LP model
    Private Sub btnSolve_Click(sender As Object, e As EventArgs) Handles btnSolve.Click
        data = New Database()
        BuildNetwork()

        Dim totalCost As Decimal = 0
        For Each p In net.ProdList
            totalCost += opt.MinCostFlow(net, p.Key)
        Next


        txtTotalCost.Text = totalCost
        txtDemand.Text = data.GetDemand(net.NodeList(lstNodes.SelectedItem), net.ProdList(lstProducts.SelectedItem))
    End Sub
End Class
