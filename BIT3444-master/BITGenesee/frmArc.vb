Public Class frmArc
    Private Sub ArcsBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles ArcsBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.ArcsBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DatabaseDataSet1)

    End Sub

    Private Sub frmNodes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DatabaseDataSet.Nodes' table. You can move, or remove it, as needed.
        Me.ArcsTableAdapter1.Fill(Me.DatabaseDataSet1.Arcs)
    End Sub
    Private Sub BindingNavigatorMoveNextItem_Click(sender As Object, e As EventArgs) Handles BindingNavigatorMoveNextItem.Click

    End Sub
End Class