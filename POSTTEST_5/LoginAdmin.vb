Public Class LoginAdmin

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        ErrorProvider1.Clear()
        Dim usernameValid As Boolean = ValidasiTextBox(ErrorProvider1, txtUsername, "Username tidak boleh kosong")
        Dim passwordValid As Boolean = ValidasiTextBox(ErrorProvider1, txtPassword, "Password tidak boleh kosong")

        If Not usernameValid OrElse Not passwordValid Then Exit Sub

        If txtUsername.Text.Trim() = "admin" AndAlso txtPassword.Text.Trim() = "admin" Then
            DashboardAdmin.Show()
            Me.Hide()
        Else
            MessageBox.Show("Username atau password salah!", "", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtPassword.Clear()
            txtUsername.Focus()
        End If
    End Sub

    Private Sub btnBatal_Click(sender As Object, e As EventArgs) Handles btnBatal.Click
        txtUsername.Clear()
        txtPassword.Clear()
        ErrorProvider1.Clear()
        Form1.Show()
        Me.Hide()
    End Sub

    Private Sub LoginAdmin_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Form1.Show()
    End Sub

    Private Sub LoginAdmin_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class