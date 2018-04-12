Public Class frmProducts
    Private Sub ProductsBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles ProductsBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.ProductsBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DatabaseDataSet)

    End Sub

    Private Sub frmProducts_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DatabaseDataSet.Products' table. You can move, or remove it, as needed.
        Me.ProductsTableAdapter.Fill(Me.DatabaseDataSet.Products)

    End Sub

End Class