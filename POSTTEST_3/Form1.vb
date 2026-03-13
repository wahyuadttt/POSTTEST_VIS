Public Class Form1
    Public Sub HanyaAngka(sender As Object, e As KeyPressEventArgs)
        If Char.IsDigit(e.KeyChar) OrElse Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Public Sub HanyaHuruf(sender As Object, e As KeyPressEventArgs)
        If Char.IsLetter(e.KeyChar) OrElse Char.IsWhiteSpace(e.KeyChar) OrElse Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub BtnBrowse_Click(sender As Object, e As EventArgs) Handles BtnBrowse.Click
        Dim openFile As New OpenFileDialog
        openFile.Filter = "Image Files|*.jpg;*.jpeg;*.png"

        If openFile.ShowDialog = DialogResult.OK Then
            PictureBox1.Image = Image.FromFile(openFile.FileName)
        End If
    End Sub

    Private Sub txtUmur_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtUmur.KeyPress
        HanyaAngka(sender, e)
    End Sub

    Private Sub txtNomorTelepon_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNomorTelepon.KeyPress
        HanyaAngka(sender, e)
    End Sub

    Private Sub txtNama_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNama.KeyPress
        HanyaHuruf(sender, e)
    End Sub

    Private Sub BtnCetakKartu_Click(sender As Object, e As EventArgs) Handles BtnCetakKartu.Click
        If txtNama.Text = "" Or txtUmur.Text = "" Or txtNomorTelepon.Text = "" Or txtAlamat.Text = "" Then
            MessageBox.Show("Inputan tidak boleh kosong")
            Exit Sub
        End If

        If PictureBox1.Image Is Nothing Then
            MessageBox.Show("Inputan tidak boleh kosong")
            Exit Sub
        End If

        If Not RBL.Checked And Not RBP.Checked Then
            MessageBox.Show("Inputan tidak boleh kosong")
            Exit Sub
        End If

        Dim daftarHobby As String = ""

        If chkMembaca.Checked Then
            daftarHobby &= chkMembaca.Text & ", "
        End If

        If chkOlahraga.Checked Then
            daftarHobby &= chkOlahraga.Text & ", "
        End If

        If chkMusik.Checked Then
            daftarHobby &= chkMusik.Text & ", "
        End If

        If chkGame.Checked Then
            daftarHobby &= chkGame.Text & ", "
        End If

        If chkMenonton.Checked Then
            daftarHobby &= chkMenonton.Text & ", "
        End If

        If chkTraveling.Checked Then
            daftarHobby &= chkTraveling.Text & ", "
        End If

        If chkMemasak.Checked Then
            daftarHobby &= chkMemasak.Text & ", "
        End If

        If chkFotografi.Checked Then
            daftarHobby &= chkFotografi.Text & ", "
        End If

        If chkMenggambar.Checked Then
            daftarHobby &= chkMenggambar.Text & ", "
        End If

        If chkMenulis.Checked Then
            daftarHobby &= chkMenulis.Text & ", "
        End If

        If daftarHobby = "" Then
            MessageBox.Show("Inputan tidak boleh kosong")
            Exit Sub
        End If

        daftarHobby = daftarHobby.TrimEnd(","c, " "c)

        Form2.lblNama.Text = txtNama.Text
        Form2.lblUmur.Text = txtUmur.Text
        Form2.lblTanggalLahir.Text = DTPTL.Value.ToShortDateString
        Form2.lblNomorTelepon.Text = txtNomorTelepon.Text
        Form2.lblAlamat.Text = txtAlamat.Text
        Form2.lblHobby.Text = daftarHobby

        If RBL.Checked Then
            Form2.lblJenisKelamin.Text = "Laki-laki"
        Else
            Form2.lblJenisKelamin.Text = "Perempuan"
        End If

        Form2.PictureBox1.Image = PictureBox1.Image

        Form2.Show()
    End Sub

End Class
