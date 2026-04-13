Public Class DashboardAdmin

    Private selectedIdPembalap As Integer = -1
    Private selectedIdTim As Integer = -1
    Private selectedIdRace As Integer = -1

    Private Sub DashboardAdmin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TabControl1.SelectedTab = TPPembalap
        TampilPembalap()
        TampilTim()
        TampilRace()
        MuatComboBoxTim()
    End Sub

    Private Sub mnuPembalap_Click(sender As Object, e As EventArgs) Handles mnuPembalap.Click
        TabControl1.SelectedTab = TPPembalap
    End Sub

    Private Sub mnuTim_Click(sender As Object, e As EventArgs) Handles mnuTim.Click
        TabControl1.SelectedTab = TPTim
    End Sub

    Private Sub mnuRace_Click(sender As Object, e As EventArgs) Handles mnuRace.Click
        TabControl1.SelectedTab = TPRace
    End Sub

    Private Sub mnuKeluar_Click(sender As Object, e As EventArgs) Handles mnuKeluar.Click
        Dim hasil As DialogResult
        hasil = MessageBox.Show("Apakah Anda yakin ingin keluar?", "Konfirmasi Keluar",
                                MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If hasil = DialogResult.Yes Then
            Form1.Show()
            Me.Hide()
        End If
    End Sub

    Private Sub DashboardAdmin_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Form1.Show()
    End Sub

    Private Sub MuatComboBoxTim()
        cbTim.Items.Clear()
        Dim listTim As List(Of String) = GetNamaTim()
        For Each tim As String In listTim
            cbTim.Items.Add(tim)
        Next
        If cbTim.Items.Count > 0 Then cbTim.SelectedIndex = 0
    End Sub

    Private Sub KosongPembalap()
        txtNamaPembalap.Clear()
        txtNegara.Clear()
        txtNomor.Clear()
        txtSearchPembalap.Clear()
        ErrorProvider1.Clear()
        selectedIdPembalap = -1
        If cbTim.Items.Count > 0 Then cbTim.SelectedIndex = 0
        txtNamaPembalap.Focus()
    End Sub

    Private Sub TampilPembalap()
        dgvPembalap.DataSource = GetAllPembalap()
        dgvPembalap.Columns("id").Visible = False

        dgvPembalap.Columns("nama").HeaderText = "Nama Pembalap"
        dgvPembalap.Columns("negara").HeaderText = "Negara"
        dgvPembalap.Columns("nomor").HeaderText = "Nomor"
        dgvPembalap.Columns("tim").HeaderText = "Tim"
    End Sub

    Private Function ValidasiPembalap() As Boolean
        ErrorProvider1.Clear()
        Dim namaValid As Boolean = ValidasiTextBox(ErrorProvider1, txtNamaPembalap, "Inputan tidak boleh kosong")
        Dim negaraValid As Boolean = ValidasiTextBox(ErrorProvider1, txtNegara, "Inputan tidak boleh kosong")
        Dim nomorValid As Boolean = ValidasiTextBox(ErrorProvider1, txtNomor, "Inputan tidak boleh kosong")

        If Not namaValid OrElse Not negaraValid OrElse Not nomorValid Then
            MessageBox.Show("Inputan tidak boleh kosong", "", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return False
        End If
        Return True
    End Function

    Private Sub btnSimpanPembalap_Click(sender As Object, e As EventArgs) Handles btnSimpanPembalap.Click
        If Not ValidasiPembalap() Then Exit Sub

        Dim hasil As DialogResult = MessageBox.Show("Apakah data ingin disimpan?", "Konfirmasi",
                                                     MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If hasil = DialogResult.Yes Then
            If SimpanPembalap(txtNamaPembalap.Text.Trim(), txtNegara.Text.Trim(),
                              txtNomor.Text.Trim(), cbTim.SelectedItem.ToString()) Then
                MessageBox.Show("Data berhasil disimpan", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information)
                TampilPembalap()
                KosongPembalap()
            End If
        End If
    End Sub

    Private Sub btnUbahPembalap_Click(sender As Object, e As EventArgs) Handles btnUbahPembalap.Click
        If selectedIdPembalap = -1 Then
            MessageBox.Show("Pilih data yang akan diubah", "", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        If Not ValidasiPembalap() Then Exit Sub

        Dim hasil As DialogResult = MessageBox.Show("Apakah data ingin diubah?", "Konfirmasi",
                                                     MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If hasil = DialogResult.Yes Then
            If UbahPembalap(selectedIdPembalap, txtNamaPembalap.Text.Trim(), txtNegara.Text.Trim(),
                            txtNomor.Text.Trim(), cbTim.SelectedItem.ToString()) Then
                MessageBox.Show("Data berhasil diubah", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information)
                TampilPembalap()
                KosongPembalap()
            End If
        End If
    End Sub

    Private Sub btnHapusPembalap_Click(sender As Object, e As EventArgs) Handles btnHapusPembalap.Click
        If selectedIdPembalap = -1 Then
            MessageBox.Show("Pilih data yang akan dihapus", "", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        Dim hasil As DialogResult = MessageBox.Show("Apakah data ingin dihapus?", "Konfirmasi",
                                                     MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If hasil = DialogResult.Yes Then
            If HapusPembalap(selectedIdPembalap) Then
                MessageBox.Show("Data berhasil dihapus", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information)
                TampilPembalap()
                KosongPembalap()
            End If
        End If
    End Sub

    Private Sub btnBatalPembalap_Click(sender As Object, e As EventArgs) Handles btnBatalPembalap.Click
        KosongPembalap()
        TampilPembalap()
    End Sub

    Private Sub dgvPembalap_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvPembalap.CellClick
        If e.RowIndex >= 0 Then
            Dim row As DataGridViewRow = dgvPembalap.Rows(e.RowIndex)
            selectedIdPembalap = Convert.ToInt32(row.Cells("id").Value)
            txtNamaPembalap.Text = row.Cells("nama").Value.ToString()
            txtNegara.Text = row.Cells("negara").Value.ToString()
            txtNomor.Text = row.Cells("nomor").Value.ToString()
            Dim timValue As String = row.Cells("tim").Value.ToString()
            If cbTim.Items.Contains(timValue) Then
                cbTim.SelectedItem = timValue
            End If
        End If
    End Sub

    Private Sub txtSearchPembalap_TextChanged(sender As Object, e As EventArgs) Handles txtSearchPembalap.TextChanged
        If txtSearchPembalap.Text.Trim() = "" Then
            TampilPembalap()
        Else
            dgvPembalap.DataSource = SearchPembalap(txtSearchPembalap.Text.Trim())
        End If
    End Sub

    Private Sub txtNamaPembalap_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNamaPembalap.KeyPress
        HanyaHuruf(e)
    End Sub

    Private Sub txtNegara_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNegara.KeyPress
        HanyaHuruf(e)
    End Sub

    Private Sub txtNomor_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNomor.KeyPress
        HanyaAngka(e)
    End Sub

    Private Sub KosongTim()
        txtNamaTim.Clear()
        txtNegaraTim.Clear()
        txtMesin.Clear()
        txtChasis.Clear()
        txtSearchTim.Clear()
        ErrorProvider2.Clear()
        selectedIdTim = -1
        txtNamaTim.Focus()
    End Sub

    Private Sub TampilTim()
        dgvTim.DataSource = GetAllTim()
        dgvTim.Columns("id").Visible = False

        dgvTim.Columns("namaTim").HeaderText = "Nama Tim"
        dgvTim.Columns("negara").HeaderText = "Negara"
        dgvTim.Columns("mesin").HeaderText = "Mesin"
        dgvTim.Columns("chasis").HeaderText = "Chasis"

    End Sub

    Private Function ValidasiTim() As Boolean
        ErrorProvider2.Clear()
        Dim namaValid As Boolean = ValidasiTextBox(ErrorProvider2, txtNamaTim, "Inputan tidak boleh kosong")
        Dim negaraValid As Boolean = ValidasiTextBox(ErrorProvider2, txtNegaraTim, "Inputan tidak boleh kosong")
        Dim mesinValid As Boolean = ValidasiTextBox(ErrorProvider2, txtMesin, "Inputan tidak boleh kosong")
        Dim chasisValid As Boolean = ValidasiTextBox(ErrorProvider2, txtChasis, "Inputan tidak boleh kosong")

        If Not namaValid OrElse Not negaraValid OrElse Not mesinValid OrElse Not chasisValid Then
            MessageBox.Show("Inputan tidak boleh kosong", "", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return False
        End If
        Return True
    End Function

    Private Sub btnSimpanTim_Click(sender As Object, e As EventArgs) Handles btnSimpanTim.Click
        If Not ValidasiTim() Then Exit Sub

        Dim hasil As DialogResult = MessageBox.Show("Apakah data ingin disimpan?", "Konfirmasi",
                                                     MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If hasil = DialogResult.Yes Then
            If SimpanTim(txtNamaTim.Text.Trim(), txtNegaraTim.Text.Trim(),
                         txtMesin.Text.Trim(), txtChasis.Text.Trim()) Then
                MessageBox.Show("Data berhasil disimpan", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information)
                TampilTim()
                KosongTim()
                MuatComboBoxTim()
            End If
        End If
    End Sub

    Private Sub btnUbahTim_Click(sender As Object, e As EventArgs) Handles btnUbahTim.Click
        If selectedIdTim = -1 Then
            MessageBox.Show("Pilih data yang akan diubah", "", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        If Not ValidasiTim() Then Exit Sub

        Dim hasil As DialogResult = MessageBox.Show("Apakah data ingin diubah?", "Konfirmasi",
                                                     MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If hasil = DialogResult.Yes Then
            If UbahTim(selectedIdTim, txtNamaTim.Text.Trim(), txtNegaraTim.Text.Trim(),
                       txtMesin.Text.Trim(), txtChasis.Text.Trim()) Then
                MessageBox.Show("Data berhasil diubah", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information)
                TampilTim()
                KosongTim()
                MuatComboBoxTim()
            End If
        End If
    End Sub

    Private Sub btnHapusTim_Click(sender As Object, e As EventArgs) Handles btnHapusTim.Click
        If selectedIdTim = -1 Then
            MessageBox.Show("Pilih data yang akan dihapus", "", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        Dim hasil As DialogResult = MessageBox.Show("Apakah data ingin dihapus?", "Konfirmasi",
                                                     MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If hasil = DialogResult.Yes Then
            If HapusTim(selectedIdTim) Then
                MessageBox.Show("Data berhasil dihapus", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information)
                TampilTim()
                KosongTim()
                MuatComboBoxTim()
            End If
        End If
    End Sub

    Private Sub btnBatalTim_Click(sender As Object, e As EventArgs) Handles btnBatalTim.Click
        KosongTim()
        TampilTim()
    End Sub

    Private Sub dgvTim_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvTim.CellClick
        If e.RowIndex >= 0 Then
            Dim row As DataGridViewRow = dgvTim.Rows(e.RowIndex)
            selectedIdTim = Convert.ToInt32(row.Cells("id").Value)
            txtNamaTim.Text = row.Cells("namaTim").Value.ToString()
            txtNegaraTim.Text = row.Cells("negara").Value.ToString()
            txtMesin.Text = row.Cells("mesin").Value.ToString()
            txtChasis.Text = row.Cells("chasis").Value.ToString()
        End If
    End Sub

    Private Sub txtSearchTim_TextChanged(sender As Object, e As EventArgs) Handles txtSearchTim.TextChanged
        If txtSearchTim.Text.Trim() = "" Then
            TampilTim()
        Else
            dgvTim.DataSource = SearchTim(txtSearchTim.Text.Trim())
        End If
    End Sub

    Private Sub txtNamaTim_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNamaTim.KeyPress
        HanyaHuruf(e)
    End Sub

    Private Sub txtNegaraTim_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNegaraTim.KeyPress
        HanyaHuruf(e)
    End Sub

    Private Sub KosongRace()
        txtNamaRace.Clear()
        txtLokasi.Clear()
        txtPutaran.Clear()
        txtSearchRace.Clear()
        ErrorProvider3.Clear()
        selectedIdRace = -1
        dtpTanggal.Value = DateTime.Now
        txtNamaRace.Focus()
    End Sub

    Private Sub TampilRace()
        dgvRace.DataSource = GetAllRace()
        dgvRace.Columns("id").Visible = False

        dgvRace.Columns("namaRace").HeaderText = "Nama Race"
        dgvRace.Columns("lokasi").HeaderText = "Lokasi"
        dgvRace.Columns("tanggal").HeaderText = "Tanggal"
        dgvRace.Columns("putaran").HeaderText = "Putaran"
    End Sub

    Private Function ValidasiRace() As Boolean
        ErrorProvider3.Clear()
        Dim namaValid As Boolean = ValidasiTextBox(ErrorProvider3, txtNamaRace, "Inputan tidak boleh kosong")
        Dim lokasiValid As Boolean = ValidasiTextBox(ErrorProvider3, txtLokasi, "Inputan tidak boleh kosong")
        Dim putaranValid As Boolean = ValidasiTextBox(ErrorProvider3, txtPutaran, "Inputan tidak boleh kosong")

        If Not namaValid OrElse Not lokasiValid OrElse Not putaranValid Then
            MessageBox.Show("Inputan tidak boleh kosong", "", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return False
        End If
        Return True
    End Function

    Private Sub btnSimpanRace_Click(sender As Object, e As EventArgs) Handles btnSimpanRace.Click
        If Not ValidasiRace() Then Exit Sub

        Dim hasil As DialogResult = MessageBox.Show("Apakah data ingin disimpan?", "Konfirmasi",
                                                     MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If hasil = DialogResult.Yes Then
            If SimpanRace(txtNamaRace.Text.Trim(), txtLokasi.Text.Trim(),
                          dtpTanggal.Value.ToString("yyyy-MM-dd"), txtPutaran.Text.Trim()) Then
                MessageBox.Show("Data berhasil disimpan", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information)
                TampilRace()
                KosongRace()
            End If
        End If
    End Sub

    Private Sub btnUbahRace_Click(sender As Object, e As EventArgs) Handles btnUbahRace.Click
        If selectedIdRace = -1 Then
            MessageBox.Show("Pilih data yang akan diubah", "", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        If Not ValidasiRace() Then Exit Sub

        Dim hasil As DialogResult = MessageBox.Show("Apakah data ingin diubah?", "Konfirmasi",
                                                     MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If hasil = DialogResult.Yes Then
            If UbahRace(selectedIdRace, txtNamaRace.Text.Trim(), txtLokasi.Text.Trim(),
                        dtpTanggal.Value.ToString("yyyy-MM-dd"), txtPutaran.Text.Trim()) Then
                MessageBox.Show("Data berhasil diubah", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information)
                TampilRace()
                KosongRace()
            End If
        End If
    End Sub

    Private Sub btnHapusRace_Click(sender As Object, e As EventArgs) Handles btnHapusRace.Click
        If selectedIdRace = -1 Then
            MessageBox.Show("Pilih data yang akan dihapus", "", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        Dim hasil As DialogResult = MessageBox.Show("Apakah data ingin dihapus?", "Konfirmasi",
                                                     MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If hasil = DialogResult.Yes Then
            If HapusRace(selectedIdRace) Then
                MessageBox.Show("Data berhasil dihapus", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information)
                TampilRace()
                KosongRace()
            End If
        End If
    End Sub

    Private Sub btnBatalRace_Click(sender As Object, e As EventArgs) Handles btnBatalRace.Click
        KosongRace()
        TampilRace()
    End Sub

    Private Sub dgvRace_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvRace.CellClick
        If e.RowIndex >= 0 Then
            Dim row As DataGridViewRow = dgvRace.Rows(e.RowIndex)
            selectedIdRace = Convert.ToInt32(row.Cells("id").Value)
            txtNamaRace.Text = row.Cells("namaRace").Value.ToString()
            txtLokasi.Text = row.Cells("lokasi").Value.ToString()
            txtPutaran.Text = row.Cells("putaran").Value.ToString()
            Dim tgl As String = row.Cells("tanggal").Value.ToString()
            If tgl <> "" Then
                dtpTanggal.Value = Convert.ToDateTime(tgl)
            End If
        End If
    End Sub

    Private Sub txtSearchRace_TextChanged(sender As Object, e As EventArgs) Handles txtSearchRace.TextChanged
        If txtSearchRace.Text.Trim() = "" Then
            TampilRace()
        Else
            dgvRace.DataSource = SearchRace(txtSearchRace.Text.Trim())
        End If
    End Sub

    Private Sub txtNamaRace_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNamaRace.KeyPress
        HanyaHuruf(e)
    End Sub

    Private Sub txtLokasi_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtLokasi.KeyPress
        HanyaHuruf(e)
    End Sub

    Private Sub txtPutaran_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtPutaran.KeyPress
        HanyaAngka(e)
    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs)
    End Sub
End Class