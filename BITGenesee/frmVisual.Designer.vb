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
        Me.txtDistance = New System.Windows.Forms.TextBox()
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
        Me.trvArcs.Size = New System.Drawing.Size(291, 306)
        Me.trvArcs.TabIndex = 1
        '
        'txtDistance
        '
        Me.txtDistance.Location = New System.Drawing.Point(19, 282)
        Me.txtDistance.Name = "txtDistance"
        Me.txtDistance.Size = New System.Drawing.Size(120, 20)
        Me.txtDistance.TabIndex = 2
        '
        'frmVisual
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(499, 339)
        Me.Controls.Add(Me.txtDistance)
        Me.Controls.Add(Me.trvArcs)
        Me.Controls.Add(Me.lstNodes)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "frmVisual"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lstNodes As ListBox
    Friend WithEvents trvArcs As TreeView
    Friend WithEvents txtDistance As TextBox
End Class
