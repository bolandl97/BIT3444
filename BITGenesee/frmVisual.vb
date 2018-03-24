Public Class frmVisual

    Dim data As New Database
    Dim nodesList As New SortedList(Of String, Node)
    Dim arcsList As New SortedList(Of String, Arc)

    Private Sub UpdateTreeView(city As String)
        trvArcs.Nodes.Clear()
        Dim newTreeNode As New TreeNode(city)
        trvArcs.Nodes.Add(newTreeNode)
        Dim arcsIn As New TreeNode("ArcsIn")
        Dim arcsOut As New TreeNode("ArcsOut")
        newTreeNode.Nodes.Add(arcsIn)
        newTreeNode.Nodes.Add(arcsOut)
        Dim node As Node = nodesList(city)
        For Each Arc In node.ArcsIn
            Dim arcIn As New TreeNode(Arc.Tail.ID)
            arcsIn.Nodes.Add(arcIn)
        Next
        For Each Arc In node.ArcsOut
            Dim arcOut As New TreeNode(Arc.Head.ID)
            arcsOut.Nodes.Add(arcOut)
        Next

    End Sub

    Private Sub frmColleges_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        data = New Database()
        nodesList = data.GetNodes()
        arcsList = data.GetArcs(nodesList)
        For Each node In nodesList
            lstNodes.Items.Add(node.Key)
        Next
        lstNodes.SelectedIndex = 0
        UpdateTreeView(lstNodes.SelectedItem)
    End Sub

    Private Sub trvNetwork_AfterSelect(sender As Object, e As TreeViewEventArgs) Handles trvArcs.AfterSelect
        Dim tn As TreeNode = trvArcs.SelectedNode
        Dim arcID As String
        Try
            If tn.Text = trvArcs.Nodes(0).Text OrElse tn.Parent.Text = trvArcs.Nodes(0).Text Then
                Throw New Exception("Select a destination or origin node.")
            End If
            If tn.Parent.Text = "ArcsIn" Then
                arcID = tn.Text & "-TO-" & trvArcs.Nodes(0).Text
            Else
                arcID = trvArcs.Nodes(0).Text & "-TO-" & tn.Text
            End If
            txtDistance.Text = arcsList(arcID).Cost
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Selection Error")
        End Try
    End Sub

    Private Sub lstColleges_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstNodes.SelectedIndexChanged
        UpdateTreeView(lstNodes.SelectedItem)

    End Sub
End Class
