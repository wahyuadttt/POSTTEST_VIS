Public Class DashboardUser

    Private Sub DashboardUser_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TabControl1.SelectedTab = TPPembalap
        TampilPembalap()
        TampilTim()
        TampilRace()
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

    Private Sub DashboardUser_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Form1.Show()
    End Sub

    Private Sub TampilPembalap()
        dgvPembalap.DataSource = GetAllPembalap()
        dgvPembalap.ReadOnly = True

        dgvPembalap.Columns("id").Visible = False
        dgvPembalap.Columns("idTim").Visible = False

        dgvPembalap.Columns("nama").HeaderText = "Nama Pembalap"
        dgvPembalap.Columns("negara").HeaderText = "Negara"
        dgvPembalap.Columns("nomor").HeaderText = "Nomor"
        dgvPembalap.Columns("tim").HeaderText = "Tim"
    End Sub

    Private Sub TampilTim()
        dgvTim.DataSource = GetAllTim()
        dgvTim.ReadOnly = True
        dgvTim.Columns("id").Visible = False

        dgvTim.Columns("namaTim").HeaderText = "Nama Tim"
        dgvTim.Columns("negara").HeaderText = "Negara"
        dgvTim.Columns("mesin").HeaderText = "Mesin"
        dgvTim.Columns("chasis").HeaderText = "Chasis"
    End Sub

    Private Sub TampilRace()
        dgvRace.DataSource = GetAllRace()
        dgvRace.ReadOnly = True
        dgvRace.Columns("id").Visible = False

        dgvRace.Columns("namaRace").HeaderText = "Nama Race"
        dgvRace.Columns("lokasi").HeaderText = "Lokasi"
        dgvRace.Columns("tanggal").HeaderText = "Tanggal"
        dgvRace.Columns("putaran").HeaderText = "Putaran"
    End Sub

    Private Sub txtSearchPembalap_TextChanged(sender As Object, e As EventArgs) Handles txtSearchPembalap.TextChanged
        If txtSearchPembalap.Text.Trim() = "" Then
            TampilPembalap()
        Else
            dgvPembalap.DataSource = SearchPembalap(txtSearchPembalap.Text.Trim())
            If dgvPembalap.Columns.Contains("id") Then dgvPembalap.Columns("id").Visible = False
            If dgvPembalap.Columns.Contains("idTim") Then dgvPembalap.Columns("idTim").Visible = False
        End If
    End Sub

    Private Sub txtSearchTim_TextChanged(sender As Object, e As EventArgs) Handles txtSearchTim.TextChanged
        If txtSearchTim.Text.Trim() = "" Then
            TampilTim()
        Else
            dgvTim.DataSource = SearchTim(txtSearchTim.Text.Trim())
            If dgvTim.Columns.Contains("id") Then dgvTim.Columns("id").Visible = False
        End If
    End Sub

    Private Sub txtSearchRace_TextChanged(sender As Object, e As EventArgs) Handles txtSearchRace.TextChanged
        If txtSearchRace.Text.Trim() = "" Then
            TampilRace()
        Else
            dgvRace.DataSource = SearchRace(txtSearchRace.Text.Trim())
            If dgvRace.Columns.Contains("id") Then dgvRace.Columns("id").Visible = False
        End If
    End Sub

End Class