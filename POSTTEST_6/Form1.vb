Public Class Form1

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnLoginAdmin_Click(sender As Object, e As EventArgs) Handles btnLoginAdmin.Click
        LoginAdmin.Show()
        Me.Hide()
    End Sub

    Private Sub btnLoginGuest_Click(sender As Object, e As EventArgs) Handles Panel2.Click
        DashboardUser.Show()
        Me.Hide()
    End Sub

End Class