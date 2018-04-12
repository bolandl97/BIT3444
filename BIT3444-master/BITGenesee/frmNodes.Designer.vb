<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmNodes
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim CityLabel As System.Windows.Forms.Label
        Dim CodeLabel As System.Windows.Forms.Label
        Dim Prod1DemLabel As System.Windows.Forms.Label
        Dim Prod2DemLabel As System.Windows.Forms.Label
        Dim Prod3DemLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmNodes))
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigator1 = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.DatabaseDataSet = New BITGenesee.DatabaseDataSet()
        Me.NodesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.NodesTableAdapter = New BITGenesee.DatabaseDataSetTableAdapters.NodesTableAdapter()
        Me.TableAdapterManager = New BITGenesee.DatabaseDataSetTableAdapters.TableAdapterManager()
        Me.CityTextBox = New System.Windows.Forms.TextBox()
        Me.CodeTextBox = New System.Windows.Forms.TextBox()
        Me.Prod1DemTextBox = New System.Windows.Forms.TextBox()
        Me.Prod2DemTextBox = New System.Windows.Forms.TextBox()
        Me.Prod3DemTextBox = New System.Windows.Forms.TextBox()
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
        Me.SaveFileDialog2 = New System.Windows.Forms.SaveFileDialog()
        Me.SaveFileDialog3 = New System.Windows.Forms.SaveFileDialog()
        CityLabel = New System.Windows.Forms.Label()
        CodeLabel = New System.Windows.Forms.Label()
        Prod1DemLabel = New System.Windows.Forms.Label()
        Prod2DemLabel = New System.Windows.Forms.Label()
        Prod3DemLabel = New System.Windows.Forms.Label()
        CType(Me.BindingNavigator1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.BindingNavigator1.SuspendLayout()
        CType(Me.DatabaseDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NodesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'CityLabel
        '
        CityLabel.AutoSize = True
        CityLabel.Location = New System.Drawing.Point(206, 129)
        CityLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        CityLabel.Name = "CityLabel"
        CityLabel.Size = New System.Drawing.Size(39, 20)
        CityLabel.TabIndex = 1
        CityLabel.Text = "City:"
        '
        'CodeLabel
        '
        CodeLabel.AutoSize = True
        CodeLabel.Location = New System.Drawing.Point(194, 159)
        CodeLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        CodeLabel.Name = "CodeLabel"
        CodeLabel.Size = New System.Drawing.Size(51, 20)
        CodeLabel.TabIndex = 3
        CodeLabel.Text = "Code:"
        '
        'Prod1DemLabel
        '
        Prod1DemLabel.AutoSize = True
        Prod1DemLabel.Location = New System.Drawing.Point(103, 189)
        Prod1DemLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Prod1DemLabel.Name = "Prod1DemLabel"
        Prod1DemLabel.Size = New System.Drawing.Size(144, 20)
        Prod1DemLabel.TabIndex = 5
        Prod1DemLabel.Text = "Genesee Demand:"
        '
        'Prod2DemLabel
        '
        Prod2DemLabel.AutoSize = True
        Prod2DemLabel.Location = New System.Drawing.Point(158, 218)
        Prod2DemLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Prod2DemLabel.Name = "Prod2DemLabel"
        Prod2DemLabel.Size = New System.Drawing.Size(90, 20)
        Prod2DemLabel.TabIndex = 7
        Prod2DemLabel.Text = "Genny Lite:"
        '
        'Prod3DemLabel
        '
        Prod3DemLabel.AutoSize = True
        Prod3DemLabel.Location = New System.Drawing.Point(158, 247)
        Prod3DemLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Prod3DemLabel.Name = "Prod3DemLabel"
        Prod3DemLabel.Size = New System.Drawing.Size(87, 20)
        Prod3DemLabel.TabIndex = 9
        Prod3DemLabel.Text = "Cream Ale:"
        '
        'BindingNavigatorMoveFirstItem
        '
        Me.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
        Me.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(36, 36)
        Me.BindingNavigatorMoveFirstItem.Text = "Move first"
        '
        'BindingNavigatorMovePreviousItem
        '
        Me.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
        Me.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(36, 36)
        Me.BindingNavigatorMovePreviousItem.Text = "Move previous"
        '
        'BindingNavigatorSeparator
        '
        Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 39)
        '
        'BindingNavigatorPositionItem
        '
        Me.BindingNavigatorPositionItem.AccessibleName = "Position"
        Me.BindingNavigatorPositionItem.AutoSize = False
        Me.BindingNavigatorPositionItem.Name = "BindingNavigatorPositionItem"
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(38, 31)
        Me.BindingNavigatorPositionItem.Text = "0"
        Me.BindingNavigatorPositionItem.ToolTipText = "Current position"
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(54, 36)
        Me.BindingNavigatorCountItem.Text = "of {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Total number of items"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator1"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 39)
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(36, 36)
        Me.BindingNavigatorMoveNextItem.Text = "Move next"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(36, 36)
        Me.BindingNavigatorMoveLastItem.Text = "Move last"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator2"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 39)
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(36, 36)
        Me.BindingNavigatorAddNewItem.Text = "Add new"
        '
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(36, 36)
        Me.BindingNavigatorDeleteItem.Text = "Delete"
        '
        'BindingNavigator1
        '
        Me.BindingNavigator1.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.BindingNavigator1.CountItem = Me.BindingNavigatorCountItem
        Me.BindingNavigator1.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.BindingNavigator1.ImageScalingSize = New System.Drawing.Size(32, 32)
        Me.BindingNavigator1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem})
        Me.BindingNavigator1.Location = New System.Drawing.Point(0, 0)
        Me.BindingNavigator1.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.BindingNavigator1.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.BindingNavigator1.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.BindingNavigator1.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.BindingNavigator1.Name = "BindingNavigator1"
        Me.BindingNavigator1.PositionItem = Me.BindingNavigatorPositionItem
        Me.BindingNavigator1.Size = New System.Drawing.Size(475, 39)
        Me.BindingNavigator1.TabIndex = 0
        Me.BindingNavigator1.Text = "BindingNavigator1"
        '
        'DatabaseDataSet
        '
        Me.DatabaseDataSet.DataSetName = "DatabaseDataSet"
        Me.DatabaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'NodesBindingSource
        '
        Me.NodesBindingSource.DataMember = "Nodes"
        Me.NodesBindingSource.DataSource = Me.DatabaseDataSet
        '
        'NodesTableAdapter
        '
        Me.NodesTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.ArcsTableAdapter = Nothing
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.NodesTableAdapter = Me.NodesTableAdapter
        Me.TableAdapterManager.ProductsTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = BITGenesee.DatabaseDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'CityTextBox
        '
        Me.CityTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.NodesBindingSource, "City", True))
        Me.CityTextBox.Location = New System.Drawing.Point(251, 126)
        Me.CityTextBox.Margin = New System.Windows.Forms.Padding(2)
        Me.CityTextBox.Name = "CityTextBox"
        Me.CityTextBox.Size = New System.Drawing.Size(76, 26)
        Me.CityTextBox.TabIndex = 2
        '
        'CodeTextBox
        '
        Me.CodeTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.NodesBindingSource, "Code", True))
        Me.CodeTextBox.Location = New System.Drawing.Point(251, 156)
        Me.CodeTextBox.Margin = New System.Windows.Forms.Padding(2)
        Me.CodeTextBox.Name = "CodeTextBox"
        Me.CodeTextBox.Size = New System.Drawing.Size(76, 26)
        Me.CodeTextBox.TabIndex = 4
        '
        'Prod1DemTextBox
        '
        Me.Prod1DemTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.NodesBindingSource, "Prod1Dem", True))
        Me.Prod1DemTextBox.Location = New System.Drawing.Point(251, 186)
        Me.Prod1DemTextBox.Margin = New System.Windows.Forms.Padding(2)
        Me.Prod1DemTextBox.Name = "Prod1DemTextBox"
        Me.Prod1DemTextBox.Size = New System.Drawing.Size(76, 26)
        Me.Prod1DemTextBox.TabIndex = 6
        '
        'Prod2DemTextBox
        '
        Me.Prod2DemTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.NodesBindingSource, "Prod2Dem", True))
        Me.Prod2DemTextBox.Location = New System.Drawing.Point(251, 215)
        Me.Prod2DemTextBox.Margin = New System.Windows.Forms.Padding(2)
        Me.Prod2DemTextBox.Name = "Prod2DemTextBox"
        Me.Prod2DemTextBox.Size = New System.Drawing.Size(76, 26)
        Me.Prod2DemTextBox.TabIndex = 8
        '
        'Prod3DemTextBox
        '
        Me.Prod3DemTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.NodesBindingSource, "Prod3Dem", True))
        Me.Prod3DemTextBox.Location = New System.Drawing.Point(251, 245)
        Me.Prod3DemTextBox.Margin = New System.Windows.Forms.Padding(2)
        Me.Prod3DemTextBox.Name = "Prod3DemTextBox"
        Me.Prod3DemTextBox.Size = New System.Drawing.Size(76, 26)
        Me.Prod3DemTextBox.TabIndex = 10
        '
        'frmNodes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(475, 402)
        Me.Controls.Add(CityLabel)
        Me.Controls.Add(Me.CityTextBox)
        Me.Controls.Add(CodeLabel)
        Me.Controls.Add(Me.CodeTextBox)
        Me.Controls.Add(Prod1DemLabel)
        Me.Controls.Add(Me.Prod1DemTextBox)
        Me.Controls.Add(Prod2DemLabel)
        Me.Controls.Add(Me.Prod2DemTextBox)
        Me.Controls.Add(Prod3DemLabel)
        Me.Controls.Add(Me.Prod3DemTextBox)
        Me.Controls.Add(Me.BindingNavigator1)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "frmNodes"
        Me.Text = "Nodes"
        CType(Me.BindingNavigator1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.BindingNavigator1.ResumeLayout(False)
        Me.BindingNavigator1.PerformLayout()
        CType(Me.DatabaseDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NodesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BindingNavigatorMoveFirstItem As ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As ToolStripTextBox
    Friend WithEvents BindingNavigatorCountItem As ToolStripLabel
    Friend WithEvents BindingNavigatorSeparator1 As ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As ToolStripSeparator
    Friend WithEvents BindingNavigatorAddNewItem As ToolStripButton
    Friend WithEvents BindingNavigatorDeleteItem As ToolStripButton
    Friend WithEvents BindingNavigator1 As BindingNavigator
    Friend WithEvents DatabaseDataSet As DatabaseDataSet
    Friend WithEvents NodesBindingSource As BindingSource
    Friend WithEvents NodesTableAdapter As DatabaseDataSetTableAdapters.NodesTableAdapter
    Friend WithEvents TableAdapterManager As DatabaseDataSetTableAdapters.TableAdapterManager
    Friend WithEvents CityTextBox As TextBox
    Friend WithEvents CodeTextBox As TextBox
    Friend WithEvents Prod1DemTextBox As TextBox
    Friend WithEvents Prod2DemTextBox As TextBox
    Friend WithEvents Prod3DemTextBox As TextBox
    Friend WithEvents SaveFileDialog1 As SaveFileDialog
    Friend WithEvents SaveFileDialog2 As SaveFileDialog
    Friend WithEvents SaveFileDialog3 As SaveFileDialog
End Class
