Public Class frmLogin
    Public main As frmVisual
    Dim userData As New Database(True)

    ' gets username and password from user, checks them against the users in the database
    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        Try
            If Not userData.UserFound(txtUsername.Text, txtPassword.Text) Then
                Throw New Exception("Username/Password not found.")
            Else
                Me.Hide()
                main = New frmVisual
                main.ShowDialog()
                Dim result As Integer = MessageBox.Show("Are you sure you want to exit A Need for Genesee Solutions?", "Exit Network Solver", MessageBoxButtons.YesNoCancel)
                If result = DialogResult.Yes Then
                    Application.Exit()
                Else
                    txtPassword.Text = ""
                    Me.Show()
                End If
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Login error")
        End Try
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Dim result As Integer = MessageBox.Show("Are you sure you want to exit A Need for Genesee Solutions?", "Exit Pathfinder", MessageBoxButtons.YesNoCancel)
        If result = DialogResult.Yes Then
            Application.Exit()
        End If
    End Sub
End Class