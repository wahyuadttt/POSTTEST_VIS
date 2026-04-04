Public Class Form1

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TabControl1.SelectedTab = TPData

    End Sub

    Public Sub HanyaHuruf(sender As Object, e As KeyPressEventArgs)
        If Char.IsLetter(e.KeyChar) OrElse Char.IsWhiteSpace(e.KeyChar) OrElse Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Public Sub HanyaAngka(sender As Object, e As KeyPressEventArgs)
        If Char.IsDigit(e.KeyChar) OrElse Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub txtNama_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNama.KeyPress
        HanyaHuruf(sender, e)
    End Sub

    Private Sub txtID_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtID.KeyPress
        HanyaAngka(sender, e)
    End Sub

    Private Sub mtxtNoHP_Leave(sender As Object, e As EventArgs) Handles mtxtNoHP.Leave
        If Not mtxtNoHP.MaskCompleted Then
            ErrorProvider1.SetError(mtxtNoHP, "Nomor HP harus lengkap, contoh: 0812-3456-7890")
        Else
            ErrorProvider1.SetError(mtxtNoHP, "")
        End If
    End Sub

    Private Sub btnBrowse_Click(sender As Object, e As EventArgs) Handles btnBrowse.Click
        Dim openFile As New OpenFileDialog
        openFile.Filter = "Image Files|*.jpg;*.jpeg;*.png"
        openFile.Title = "Pilih Foto Profil"

        If openFile.ShowDialog() = DialogResult.OK Then
            PictureBox1.Image = Image.FromFile(openFile.FileName)
            PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        End If
    End Sub

    Private Function ValidasiInput() As Boolean
        ErrorProvider1.Clear()
        Dim valid As Boolean = True

        If txtNama.Text.Trim() = "" Then
            ErrorProvider1.SetError(txtNama, "Inputan tidak boleh kosong")
            valid = False
        End If

        If txtID.Text.Trim() = "" Then
            ErrorProvider1.SetError(txtID, "Inputan tidak boleh kosong")
            valid = False
        End If

        If Not RBL.Checked AndAlso Not RBP.Checked Then
            ErrorProvider1.SetError(RBL, "Inputan tidak boleh kosong")
            valid = False
        End If

        If Not mtxtNoHP.MaskCompleted Then
            ErrorProvider1.SetError(mtxtNoHP, "Nomor HP harus lengkap, contoh: 0812-3456-7890")
            valid = False
        End If

        If txtEmail.Text.Trim() = "" Then
            ErrorProvider1.SetError(txtEmail, "Inputan tidak boleh kosong")
            valid = False
        End If

        If txtAlamat.Text.Trim() = "" Then
            ErrorProvider1.SetError(txtAlamat, "Inputan tidak boleh kosong")
            valid = False
        End If

        If PictureBox1.Image Is Nothing Then
            ErrorProvider1.SetError(btnBrowse, "Inputan tidak boleh kosong")
            valid = False
        End If

        If Not RBDriver.Checked AndAlso Not RBEngineer.Checked AndAlso
           Not RBPC.Checked AndAlso Not RBStrategist.Checked AndAlso
           Not RBTP.Checked AndAlso Not RBMedia.Checked Then
            ErrorProvider1.SetError(GBPeran, "Inputan tidak boleh kosong")
            valid = False
        End If

        If Not chkDriving.Checked AndAlso Not chkEditing.Checked AndAlso
           Not chkAnalyst.Checked AndAlso Not chkSM.Checked AndAlso
           Not chkSB.Checked AndAlso Not chkFotografi.Checked AndAlso
           Not chkDesigner.Checked AndAlso Not chkVideografi.Checked Then
            ErrorProvider1.SetError(GBPeran, "Inputan tidak boleh kosong")
            valid = False
        End If

        If Not valid Then
            MessageBox.Show("Inputan tidak boleh kosong", "",
            MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If

        Return valid
    End Function

    Private Function KumpulkanAktivitas() As String
        Dim daftarAktivitas As String = ""

        If chkDriving.Checked Then daftarAktivitas &= chkDriving.Text & ", "
        If chkEditing.Checked Then daftarAktivitas &= chkEditing.Text & ", "
        If chkAnalyst.Checked Then daftarAktivitas &= chkAnalyst.Text & ", "
        If chkSM.Checked Then daftarAktivitas &= chkSM.Text & ", "
        If chkSB.Checked Then daftarAktivitas &= chkSB.Text & ", "
        If chkFotografi.Checked Then daftarAktivitas &= chkFotografi.Text & ", "
        If chkDesigner.Checked Then daftarAktivitas &= chkDesigner.Text & ", "
        If chkVideografi.Checked Then daftarAktivitas &= chkVideografi.Text & ", "

        If daftarAktivitas.Length > 0 Then
            daftarAktivitas = daftarAktivitas.TrimEnd(","c, " "c)
        End If

        Return daftarAktivitas
    End Function

    Private Sub KirimKeForm2()
        Form2.lblNama.Text = txtNama.Text
        Form2.lblID.Text = txtID.Text
        Form2.lblTTL.Text = DTPTL.Value.ToShortDateString()
        Form2.lblTim.Text = cbTim.SelectedItem.ToString()
        Form2.lblHP.Text = mtxtNoHP.Text
        Form2.lblEmail.Text = txtEmail.Text
        Form2.lblAlamat.Text = txtAlamat.Text
        Form2.lblAktivitas.Text = KumpulkanAktivitas()
        Form2.PictureBox1.Image = PictureBox1.Image

        If RBL.Checked Then
            Form2.lblJK.Text = "Laki-laki"
        Else
            Form2.lblJK.Text = "Perempuan"
        End If

        If RBDriver.Checked Then
            Form2.lblPeran.Text = "Driver"
        ElseIf RBPC.Checked Then
            Form2.lblPeran.Text = "Pit Crew"
        ElseIf RBEngineer.Checked Then
            Form2.lblPeran.Text = "Engineer"
        ElseIf RBStrategist.Checked Then
            Form2.lblPeran.Text = "Strategist"
        ElseIf RBTP.Checked Then
            Form2.lblPeran.Text = "Team Principal"
        ElseIf RBMedia.Checked Then
            Form2.lblPeran.Text = "Media"
        End If
    End Sub

    Private Sub btnSimpan_Click(sender As Object, e As EventArgs) Handles btnSimpan.Click
        If Not ValidasiInput() Then Exit Sub

        Dim hasil As DialogResult
        hasil = MessageBox.Show(
            "Apakah data sudah benar dan ingin dicetak?",
            "Konfirmasi Cetak",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Question
        )

        If hasil = DialogResult.Yes Then
            KirimKeForm2()
            Form2.Show()
        End If
    End Sub

    Private Sub SMInput_Click(sender As Object, e As EventArgs) Handles SMInput.Click
        TabControl1.SelectedTab = TPData
    End Sub

    Private Sub SMLihat_Click(sender As Object, e As EventArgs) Handles SMLihat.Click
        If Not ValidasiInput() Then Exit Sub
        KirimKeForm2()
        Form2.Show()
    End Sub

    Private Sub SMSimpan_Click(sender As Object, e As EventArgs) Handles SMSimpan.Click
        If Not ValidasiInput() Then Exit Sub

        Dim saveFile As New SaveFileDialog
        saveFile.Filter = "Text File|*.txt|CSV File|*.csv"
        saveFile.Title = "Simpan Data Anggota"

        If saveFile.ShowDialog() = DialogResult.OK Then
            Dim isiFile As String = ""
            isiFile &= "Nama          : " & txtNama.Text & Environment.NewLine
            isiFile &= "ID Anggota    : " & txtID.Text & Environment.NewLine
            isiFile &= "Tanggal Lahir : " & DTPTL.Value.ToShortDateString() & Environment.NewLine
            isiFile &= "Jenis Kelamin : " & If(RBL.Checked, "Laki-laki", "Perempuan") & Environment.NewLine
            isiFile &= "Tim F1        : " & cbTim.SelectedItem.ToString() & Environment.NewLine
            isiFile &= "No. HP        : " & mtxtNoHP.Text & Environment.NewLine
            isiFile &= "Email         : " & txtEmail.Text & Environment.NewLine
            isiFile &= "Alamat        : " & txtAlamat.Text & Environment.NewLine
            isiFile &= "Hobby         : " & KumpulkanAktivitas() & Environment.NewLine

            IO.File.WriteAllText(saveFile.FileName, isiFile)

            MessageBox.Show("Data berhasil disimpan!", "Sukses",
                            MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub SMBuka_Click(sender As Object, e As EventArgs) Handles SMBuka.Click
        Dim openFile As New OpenFileDialog
        openFile.Filter = "Text File|*.txt|CSV File|*.csv"
        openFile.Title = "Buka Data Anggota"

        If openFile.ShowDialog() = DialogResult.OK Then
            Dim isiFile As String = IO.File.ReadAllText(openFile.FileName)
            MessageBox.Show(isiFile, "Data Anggota",
                            MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub SMKeluar_Click(sender As Object, e As EventArgs) Handles SMKeluar.Click
        Dim hasil As DialogResult
        hasil = MessageBox.Show(
            "Apakah Anda yakin ingin keluar?",
            "Konfirmasi Keluar",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Question
        )

        If hasil = DialogResult.Yes Then
            Me.Close()
        End If
    End Sub

End Class