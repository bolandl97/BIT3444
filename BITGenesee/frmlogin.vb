Public Class frmlogin
    'Public Main As frmMain
    Dim UserData As New Database

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnLogin.Click

    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnCloseCancel.Click
        Dim result As Integer = MessageBox.Show("Are you sure you want to exit A Need for Genesee Solutions?", "Exit Pathfinder", MessageBoxButtons.YesNoCancel)
        If result = DialogResult.Yes Then
            Application.Exit()
        End If
    End Sub
End Class