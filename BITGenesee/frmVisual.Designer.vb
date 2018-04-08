<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmVisual
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
        Me.lstNodes = New System.Windows.Forms.ListBox()
        Me.trvArcs = New System.Windows.Forms.TreeView()
        Me.txtCost = New System.Windows.Forms.TextBox()
        Me.lstProducts = New System.Windows.Forms.ListBox()
        Me.txtCapacity = New System.Windows.Forms.TextBox()
        Me.txtFlow = New System.Windows.Forms.TextBox()
        Me.txtDemand = New System.Windows.Forms.TextBox()
        Me.btnSolve = New System.Windows.Forms.Button()
        Me.txtTotalCost = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lstNodes
        '
        Me.lstNodes.FormattingEnabled = True
        Me.lstNodes.Location = New System.Drawing.Point(19, 7)
        Me.lstNodes.Name = "lstNodes"
        Me.lstNodes.Size = New System.Drawing.Size(121, 238)
        Me.lstNodes.TabIndex = 0
        '
        'trvArcs
        '
        Me.trvArcs.Location = New System.Drawing.Point(181, 9)
        Me.trvArcs.Name = "trvArcs"
        Me.trvArcs.Size = New System.Drawing.Size(240, 306)
        Me.trvArcs.TabIndex = 1
        '
        'txtCost
        '
        Me.txtCost.Location = New System.Drawing.Point(301, 328)
        Me.txtCost.Name = "txtCost"
        Me.txtCost.Size = New System.Drawing.Size(120, 20)
        Me.txtCost.TabIndex = 2
        '
        'lstProducts
        '
        Me.lstProducts.FormattingEnabled = True
        Me.lstProducts.Location = New System.Drawing.Point(19, 252)
        Me.lstProducts.Name = "lstProducts"
        Me.lstProducts.Size = New System.Drawing.Size(120, 95)
        Me.lstProducts.TabIndex = 3
        '
        'txtCapacity
        '
        Me.txtCapacity.Location = New System.Drawing.Point(301, 354)
        Me.txtCapacity.Name = "txtCapacity"
        Me.txtCapacity.Size = New System.Drawing.Size(120, 20)
        Me.txtCapacity.TabIndex = 4
        '
        'txtFlow
        '
        Me.txtFlow.Location = New System.Drawing.Point(301, 380)
        Me.txtFlow.Name = "txtFlow"
        Me.txtFlow.Size = New System.Drawing.Size(120, 20)
        Me.txtFlow.TabIndex = 5
        '
        'txtDemand
        '
        Me.txtDemand.Location = New System.Drawing.Point(301, 406)
        Me.txtDemand.Name = "txtDemand"
        Me.txtDemand.Size = New System.Drawing.Size(100, 20)
        Me.txtDemand.TabIndex = 6
        '
        'btnSolve
        '
        Me.btnSolve.Location = New System.Drawing.Point(19, 352)
        Me.btnSolve.Name = "btnSolve"
        Me.btnSolve.Size = New System.Drawing.Size(75, 23)
        Me.btnSolve.TabIndex = 7
        Me.btnSolve.Text = "Solve LP Model"
        Me.btnSolve.UseVisualStyleBackColor = True
        '
        'txtTotalCost
        '
        Me.txtTotalCost.Location = New System.Drawing.Point(77, 380)
        Me.txtTotalCost.Name = "txtTotalCost"
        Me.txtTotalCost.Size = New System.Drawing.Size(100, 20)
        Me.txtTotalCost.TabIndex = 8
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(16, 383)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(55, 13)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "Total Cost"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(208, 409)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(87, 13)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "Product Demand"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(207, 331)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(88, 13)
        Me.Label3.TabIndex = 11
        Me.Label3.Text = "Arc Cost Per Mile"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(175, 357)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(120, 13)
        Me.Label4.TabIndex = 12
        Me.Label4.Text = "Remaining Arc Capacity"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(226, 383)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(69, 13)
        Me.Label5.TabIndex = 13
        Me.Label5.Text = "Product Flow"
        '
        'frmVisual
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(441, 439)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtTotalCost)
        Me.Controls.Add(Me.btnSolve)
        Me.Controls.Add(Me.txtDemand)
        Me.Controls.Add(Me.txtFlow)
        Me.Controls.Add(Me.txtCapacity)
        Me.Controls.Add(Me.lstProducts)
        Me.Controls.Add(Me.txtCost)
        Me.Controls.Add(Me.trvArcs)
        Me.Controls.Add(Me.lstNodes)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "frmVisual"
        Me.Text = "Network"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lstNodes As ListBox
    Friend WithEvents trvArcs As TreeView
    Friend WithEvents txtCost As TextBox
    Friend WithEvents lstProducts As ListBox
    Friend WithEvents txtCapacity As TextBox
    Friend WithEvents txtFlow As TextBox
    Friend WithEvents txtDemand As TextBox
    Friend WithEvents btnSolve As Button
    Friend WithEvents txtTotalCost As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
End Class
