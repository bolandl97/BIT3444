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
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtSatisfiedDemand = New System.Windows.Forms.TextBox()
        Me.btnNodes = New System.Windows.Forms.Button()
        Me.btnProduct = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lstNodes
        '
        Me.lstNodes.FormattingEnabled = True
        Me.lstNodes.ItemHeight = 20
        Me.lstNodes.Location = New System.Drawing.Point(28, 11)
        Me.lstNodes.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.lstNodes.Name = "lstNodes"
        Me.lstNodes.Size = New System.Drawing.Size(180, 364)
        Me.lstNodes.TabIndex = 0
        '
        'trvArcs
        '
        Me.trvArcs.Location = New System.Drawing.Point(339, 11)
        Me.trvArcs.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.trvArcs.Name = "trvArcs"
        Me.trvArcs.Size = New System.Drawing.Size(253, 364)
        Me.trvArcs.TabIndex = 1
        '
        'txtCost
        '
        Me.txtCost.Location = New System.Drawing.Point(414, 406)
        Me.txtCost.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtCost.Name = "txtCost"
        Me.txtCost.Size = New System.Drawing.Size(178, 26)
        Me.txtCost.TabIndex = 2
        '
        'lstProducts
        '
        Me.lstProducts.FormattingEnabled = True
        Me.lstProducts.ItemHeight = 20
        Me.lstProducts.Location = New System.Drawing.Point(28, 406)
        Me.lstProducts.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.lstProducts.Name = "lstProducts"
        Me.lstProducts.Size = New System.Drawing.Size(178, 144)
        Me.lstProducts.TabIndex = 3
        '
        'txtCapacity
        '
        Me.txtCapacity.Location = New System.Drawing.Point(414, 446)
        Me.txtCapacity.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtCapacity.Name = "txtCapacity"
        Me.txtCapacity.Size = New System.Drawing.Size(178, 26)
        Me.txtCapacity.TabIndex = 4
        '
        'txtFlow
        '
        Me.txtFlow.Location = New System.Drawing.Point(414, 486)
        Me.txtFlow.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtFlow.Name = "txtFlow"
        Me.txtFlow.Size = New System.Drawing.Size(178, 26)
        Me.txtFlow.TabIndex = 5
        '
        'txtDemand
        '
        Me.txtDemand.Location = New System.Drawing.Point(164, 562)
        Me.txtDemand.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtDemand.Name = "txtDemand"
        Me.txtDemand.Size = New System.Drawing.Size(148, 26)
        Me.txtDemand.TabIndex = 6
        '
        'btnSolve
        '
        Me.btnSolve.Location = New System.Drawing.Point(28, 606)
        Me.btnSolve.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnSolve.Name = "btnSolve"
        Me.btnSolve.Size = New System.Drawing.Size(285, 35)
        Me.btnSolve.TabIndex = 7
        Me.btnSolve.Text = "Solve LP Model"
        Me.btnSolve.UseVisualStyleBackColor = True
        '
        'txtTotalCost
        '
        Me.txtTotalCost.Location = New System.Drawing.Point(164, 654)
        Me.txtTotalCost.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtTotalCost.Name = "txtTotalCost"
        Me.txtTotalCost.Size = New System.Drawing.Size(148, 26)
        Me.txtTotalCost.TabIndex = 8
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(24, 658)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(81, 20)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "Total Cost"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(24, 566)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(129, 20)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "Product Demand"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(273, 411)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(130, 20)
        Me.Label3.TabIndex = 11
        Me.Label3.Text = "Arc Cost Per Mile"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(225, 451)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(178, 20)
        Me.Label4.TabIndex = 12
        Me.Label4.Text = "Remaining Arc Capacity"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(302, 491)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(101, 20)
        Me.Label5.TabIndex = 13
        Me.Label5.Text = "Product Flow"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(24, 708)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(136, 20)
        Me.Label6.TabIndex = 14
        Me.Label6.Text = "Satisfied Demand"
        '
        'txtSatisfiedDemand
        '
        Me.txtSatisfiedDemand.Location = New System.Drawing.Point(164, 703)
        Me.txtSatisfiedDemand.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtSatisfiedDemand.Name = "txtSatisfiedDemand"
        Me.txtSatisfiedDemand.Size = New System.Drawing.Size(148, 26)
        Me.txtSatisfiedDemand.TabIndex = 15
        '
        'btnNodes
        '
        Me.btnNodes.Location = New System.Drawing.Point(387, 566)
        Me.btnNodes.Name = "btnNodes"
        Me.btnNodes.Size = New System.Drawing.Size(205, 37)
        Me.btnNodes.TabIndex = 16
        Me.btnNodes.Text = "Show Nodes Form"
        Me.btnNodes.UseVisualStyleBackColor = True
        '
        'btnProduct
        '
        Me.btnProduct.Location = New System.Drawing.Point(387, 641)
        Me.btnProduct.Name = "btnProduct"
        Me.btnProduct.Size = New System.Drawing.Size(205, 37)
        Me.btnProduct.TabIndex = 17
        Me.btnProduct.Text = "Show Products Form"
        Me.btnProduct.UseVisualStyleBackColor = True
        '
        'frmVisual
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(638, 772)
        Me.Controls.Add(Me.btnProduct)
        Me.Controls.Add(Me.btnNodes)
        Me.Controls.Add(Me.txtSatisfiedDemand)
        Me.Controls.Add(Me.Label6)
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
    Friend WithEvents Label6 As Label
    Friend WithEvents txtSatisfiedDemand As TextBox
    Friend WithEvents btnNodes As Button
    Friend WithEvents btnProduct As Button
End Class
