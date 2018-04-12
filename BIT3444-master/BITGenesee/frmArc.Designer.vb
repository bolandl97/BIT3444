<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmArc
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmArc))
        Dim TailLabel As System.Windows.Forms.Label
        Dim HeadLabel As System.Windows.Forms.Label
        Dim DistanceLabel As System.Windows.Forms.Label
        Dim CapacityLabel As System.Windows.Forms.Label
        Me.DatabaseDataSet1 = New BITGenesee.DatabaseDataSet()
        Me.ArcsTableAdapter1 = New BITGenesee.DatabaseDataSetTableAdapters.ArcsTableAdapter()
        Me.ArcsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TableAdapterManager = New BITGenesee.DatabaseDataSetTableAdapters.TableAdapterManager()
        Me.ArcsBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
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
        Me.ArcsBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.TailTextBox = New System.Windows.Forms.TextBox()
        Me.HeadTextBox = New System.Windows.Forms.TextBox()
        Me.DistanceTextBox = New System.Windows.Forms.TextBox()
        Me.CapacityTextBox = New System.Windows.Forms.TextBox()
        TailLabel = New System.Windows.Forms.Label()
        HeadLabel = New System.Windows.Forms.Label()
        DistanceLabel = New System.Windows.Forms.Label()
        CapacityLabel = New System.Windows.Forms.Label()
        CType(Me.DatabaseDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ArcsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ArcsBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ArcsBindingNavigator.SuspendLayout()
        Me.SuspendLayout()
        '
        'DatabaseDataSet1
        '
        Me.DatabaseDataSet1.DataSetName = "DatabaseDataSet"
        Me.DatabaseDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ArcsTableAdapter1
        '
        Me.ArcsTableAdapter1.ClearBeforeFill = True
        '
        'ArcsBindingSource
        '
        Me.ArcsBindingSource.DataMember = "Arcs"
        Me.ArcsBindingSource.DataSource = Me.DatabaseDataSet1
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.ArcsTableAdapter = Me.ArcsTableAdapter1
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.NodesTableAdapter = Nothing
        Me.TableAdapterManager.ProductsTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = BITGenesee.DatabaseDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'ArcsBindingNavigator
        '
        Me.ArcsBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.ArcsBindingNavigator.BindingSource = Me.ArcsBindingSource
        Me.ArcsBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.ArcsBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.ArcsBindingNavigator.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.ArcsBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.ArcsBindingNavigatorSaveItem})
        Me.ArcsBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.ArcsBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.ArcsBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.ArcsBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.ArcsBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.ArcsBindingNavigator.Name = "ArcsBindingNavigator"
        Me.ArcsBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.ArcsBindingNavigator.Size = New System.Drawing.Size(539, 31)
        Me.ArcsBindingNavigator.TabIndex = 0
        Me.ArcsBindingNavigator.Text = "BindingNavigator1"
        '
        'BindingNavigatorMoveFirstItem
        '
        Me.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
        Me.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(28, 22)
        Me.BindingNavigatorMoveFirstItem.Text = "Move first"
        '
        'BindingNavigatorMovePreviousItem
        '
        Me.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
        Me.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(28, 22)
        Me.BindingNavigatorMovePreviousItem.Text = "Move previous"
        '
        'BindingNavigatorSeparator
        '
        Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorPositionItem
        '
        Me.BindingNavigatorPositionItem.AccessibleName = "Position"
        Me.BindingNavigatorPositionItem.AutoSize = False
        Me.BindingNavigatorPositionItem.Name = "BindingNavigatorPositionItem"
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(50, 31)
        Me.BindingNavigatorPositionItem.Text = "0"
        Me.BindingNavigatorPositionItem.ToolTipText = "Current position"
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(54, 25)
        Me.BindingNavigatorCountItem.Text = "of {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Total number of items"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 6)
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(28, 28)
        Me.BindingNavigatorMoveNextItem.Text = "Move next"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(28, 28)
        Me.BindingNavigatorMoveLastItem.Text = "Move last"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 6)
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(28, 28)
        Me.BindingNavigatorAddNewItem.Text = "Add new"
        '
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(28, 28)
        Me.BindingNavigatorDeleteItem.Text = "Delete"
        '
        'ArcsBindingNavigatorSaveItem
        '
        Me.ArcsBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ArcsBindingNavigatorSaveItem.Image = CType(resources.GetObject("ArcsBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.ArcsBindingNavigatorSaveItem.Name = "ArcsBindingNavigatorSaveItem"
        Me.ArcsBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 23)
        Me.ArcsBindingNavigatorSaveItem.Text = "Save Data"
        '
        'TailLabel
        '
        TailLabel.AutoSize = True
        TailLabel.Location = New System.Drawing.Point(153, 168)
        TailLabel.Name = "TailLabel"
        TailLabel.Size = New System.Drawing.Size(37, 20)
        TailLabel.TabIndex = 1
        TailLabel.Text = "Tail:"
        '
        'TailTextBox
        '
        Me.TailTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ArcsBindingSource, "Tail", True))
        Me.TailTextBox.Location = New System.Drawing.Point(235, 165)
        Me.TailTextBox.Name = "TailTextBox"
        Me.TailTextBox.Size = New System.Drawing.Size(100, 26)
        Me.TailTextBox.TabIndex = 2
        '
        'HeadLabel
        '
        HeadLabel.AutoSize = True
        HeadLabel.Location = New System.Drawing.Point(153, 200)
        HeadLabel.Name = "HeadLabel"
        HeadLabel.Size = New System.Drawing.Size(52, 20)
        HeadLabel.TabIndex = 3
        HeadLabel.Text = "Head:"
        '
        'HeadTextBox
        '
        Me.HeadTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ArcsBindingSource, "Head", True))
        Me.HeadTextBox.Location = New System.Drawing.Point(235, 197)
        Me.HeadTextBox.Name = "HeadTextBox"
        Me.HeadTextBox.Size = New System.Drawing.Size(100, 26)
        Me.HeadTextBox.TabIndex = 4
        '
        'DistanceLabel
        '
        DistanceLabel.AutoSize = True
        DistanceLabel.Location = New System.Drawing.Point(153, 232)
        DistanceLabel.Name = "DistanceLabel"
        DistanceLabel.Size = New System.Drawing.Size(76, 20)
        DistanceLabel.TabIndex = 5
        DistanceLabel.Text = "Distance:"
        '
        'DistanceTextBox
        '
        Me.DistanceTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ArcsBindingSource, "Distance", True))
        Me.DistanceTextBox.Location = New System.Drawing.Point(235, 229)
        Me.DistanceTextBox.Name = "DistanceTextBox"
        Me.DistanceTextBox.Size = New System.Drawing.Size(100, 26)
        Me.DistanceTextBox.TabIndex = 6
        '
        'CapacityLabel
        '
        CapacityLabel.AutoSize = True
        CapacityLabel.Location = New System.Drawing.Point(153, 264)
        CapacityLabel.Name = "CapacityLabel"
        CapacityLabel.Size = New System.Drawing.Size(74, 20)
        CapacityLabel.TabIndex = 7
        CapacityLabel.Text = "Capacity:"
        '
        'CapacityTextBox
        '
        Me.CapacityTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ArcsBindingSource, "Capacity", True))
        Me.CapacityTextBox.Location = New System.Drawing.Point(235, 261)
        Me.CapacityTextBox.Name = "CapacityTextBox"
        Me.CapacityTextBox.Size = New System.Drawing.Size(100, 26)
        Me.CapacityTextBox.TabIndex = 8
        '
        'frmArc
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(539, 497)
        Me.Controls.Add(TailLabel)
        Me.Controls.Add(Me.TailTextBox)
        Me.Controls.Add(HeadLabel)
        Me.Controls.Add(Me.HeadTextBox)
        Me.Controls.Add(DistanceLabel)
        Me.Controls.Add(Me.DistanceTextBox)
        Me.Controls.Add(CapacityLabel)
        Me.Controls.Add(Me.CapacityTextBox)
        Me.Controls.Add(Me.ArcsBindingNavigator)
        Me.Name = "frmArc"
        Me.Text = "frmArc"
        CType(Me.DatabaseDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ArcsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ArcsBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ArcsBindingNavigator.ResumeLayout(False)
        Me.ArcsBindingNavigator.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DatabaseDataSet1 As DatabaseDataSet
    Friend WithEvents ArcsTableAdapter1 As DatabaseDataSetTableAdapters.ArcsTableAdapter
    Friend WithEvents ArcsBindingSource As BindingSource
    Friend WithEvents TableAdapterManager As DatabaseDataSetTableAdapters.TableAdapterManager
    Friend WithEvents ArcsBindingNavigator As BindingNavigator
    Friend WithEvents BindingNavigatorAddNewItem As ToolStripButton
    Friend WithEvents BindingNavigatorCountItem As ToolStripLabel
    Friend WithEvents BindingNavigatorDeleteItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveFirstItem As ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As ToolStripSeparator
    Friend WithEvents ArcsBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents TailTextBox As TextBox
    Friend WithEvents HeadTextBox As TextBox
    Friend WithEvents DistanceTextBox As TextBox
    Friend WithEvents CapacityTextBox As TextBox
End Class
