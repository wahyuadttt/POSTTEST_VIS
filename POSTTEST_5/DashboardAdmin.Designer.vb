<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DashboardAdmin
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
        components = New ComponentModel.Container()
        Panel2 = New Panel()
        TabControl1 = New TabControl()
        TPPembalap = New TabPage()
        btnBatalPembalap = New Button()
        btnSimpanPembalap = New Button()
        cbTim = New ComboBox()
        btnHapusPembalap = New Button()
        btnUbahPembalap = New Button()
        dgvPembalap = New DataGridView()
        txtSearchPembalap = New TextBox()
        txtNomor = New TextBox()
        txtNegara = New TextBox()
        txtNamaPembalap = New TextBox()
        lblTim = New Label()
        lblNomor = New Label()
        lblNegaraPembalap = New Label()
        lblNamaPembalap = New Label()
        TPTim = New TabPage()
        txtChasis = New TextBox()
        btnBatalTim = New Button()
        btnSimpanTim = New Button()
        btnHapusTim = New Button()
        btnUbahTim = New Button()
        dgvTim = New DataGridView()
        txtSearchTim = New TextBox()
        txtMesin = New TextBox()
        txtNegaraTim = New TextBox()
        txtNamaTim = New TextBox()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        TPRace = New TabPage()
        dtpTanggal = New DateTimePicker()
        txtPutaran = New TextBox()
        btnBatalRace = New Button()
        btnSimpanRace = New Button()
        btnHapusRace = New Button()
        btnUbahRace = New Button()
        dgvRace = New DataGridView()
        txtSearchRace = New TextBox()
        txtLokasi = New TextBox()
        txtNamaRace = New TextBox()
        Label7 = New Label()
        Label8 = New Label()
        Label9 = New Label()
        Label10 = New Label()
        ErrorProvider1 = New ErrorProvider(components)
        ErrorProvider2 = New ErrorProvider(components)
        ErrorProvider3 = New ErrorProvider(components)
        MenuStrip2 = New MenuStrip()
        mnuPembalap = New ToolStripMenuItem()
        mnuTim = New ToolStripMenuItem()
        mnuRace = New ToolStripMenuItem()
        mnuKeluar = New ToolStripMenuItem()
        Panel2.SuspendLayout()
        TabControl1.SuspendLayout()
        TPPembalap.SuspendLayout()
        CType(dgvPembalap, ComponentModel.ISupportInitialize).BeginInit()
        TPTim.SuspendLayout()
        CType(dgvTim, ComponentModel.ISupportInitialize).BeginInit()
        TPRace.SuspendLayout()
        CType(dgvRace, ComponentModel.ISupportInitialize).BeginInit()
        CType(ErrorProvider1, ComponentModel.ISupportInitialize).BeginInit()
        CType(ErrorProvider2, ComponentModel.ISupportInitialize).BeginInit()
        CType(ErrorProvider3, ComponentModel.ISupportInitialize).BeginInit()
        MenuStrip2.SuspendLayout()
        SuspendLayout()
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = Color.LightGray
        Panel2.Controls.Add(TabControl1)
        Panel2.Location = New Point(0, 33)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(1049, 404)
        Panel2.TabIndex = 3
        ' 
        ' TabControl1
        ' 
        TabControl1.Controls.Add(TPPembalap)
        TabControl1.Controls.Add(TPTim)
        TabControl1.Controls.Add(TPRace)
        TabControl1.Location = New Point(3, 1)
        TabControl1.Name = "TabControl1"
        TabControl1.SelectedIndex = 0
        TabControl1.Size = New Size(1034, 402)
        TabControl1.TabIndex = 3
        ' 
        ' TPPembalap
        ' 
        TPPembalap.BackColor = Color.Gainsboro
        TPPembalap.Controls.Add(btnBatalPembalap)
        TPPembalap.Controls.Add(btnSimpanPembalap)
        TPPembalap.Controls.Add(cbTim)
        TPPembalap.Controls.Add(btnHapusPembalap)
        TPPembalap.Controls.Add(btnUbahPembalap)
        TPPembalap.Controls.Add(dgvPembalap)
        TPPembalap.Controls.Add(txtSearchPembalap)
        TPPembalap.Controls.Add(txtNomor)
        TPPembalap.Controls.Add(txtNegara)
        TPPembalap.Controls.Add(txtNamaPembalap)
        TPPembalap.Controls.Add(lblTim)
        TPPembalap.Controls.Add(lblNomor)
        TPPembalap.Controls.Add(lblNegaraPembalap)
        TPPembalap.Controls.Add(lblNamaPembalap)
        TPPembalap.Location = New Point(4, 34)
        TPPembalap.Name = "TPPembalap"
        TPPembalap.Padding = New Padding(3)
        TPPembalap.Size = New Size(1026, 364)
        TPPembalap.TabIndex = 0
        TPPembalap.Text = "Pembalap"
        ' 
        ' btnBatalPembalap
        ' 
        btnBatalPembalap.BackColor = Color.White
        btnBatalPembalap.FlatAppearance.MouseDownBackColor = Color.FromArgb(CByte(90), CByte(98), CByte(104))
        btnBatalPembalap.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(130), CByte(138), CByte(145))
        btnBatalPembalap.FlatStyle = FlatStyle.Flat
        btnBatalPembalap.ForeColor = SystemColors.ActiveCaptionText
        btnBatalPembalap.Location = New Point(66, 320)
        btnBatalPembalap.Name = "btnBatalPembalap"
        btnBatalPembalap.Size = New Size(112, 34)
        btnBatalPembalap.TabIndex = 16
        btnBatalPembalap.Text = "Batal"
        btnBatalPembalap.UseVisualStyleBackColor = False
        ' 
        ' btnSimpanPembalap
        ' 
        btnSimpanPembalap.BackColor = Color.White
        btnSimpanPembalap.FlatAppearance.MouseDownBackColor = Color.FromArgb(CByte(0), CByte(90), CByte(158))
        btnSimpanPembalap.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(28), CByte(151), CByte(234))
        btnSimpanPembalap.FlatStyle = FlatStyle.Flat
        btnSimpanPembalap.ForeColor = SystemColors.ActiveCaptionText
        btnSimpanPembalap.Location = New Point(66, 187)
        btnSimpanPembalap.Name = "btnSimpanPembalap"
        btnSimpanPembalap.Size = New Size(112, 34)
        btnSimpanPembalap.TabIndex = 15
        btnSimpanPembalap.Text = "Simpan"
        btnSimpanPembalap.UseVisualStyleBackColor = False
        ' 
        ' cbTim
        ' 
        cbTim.FormattingEnabled = True
        cbTim.Location = New Point(91, 138)
        cbTim.Name = "cbTim"
        cbTim.Size = New Size(166, 33)
        cbTim.TabIndex = 14
        ' 
        ' btnHapusPembalap
        ' 
        btnHapusPembalap.BackColor = Color.White
        btnHapusPembalap.FlatAppearance.MouseDownBackColor = Color.FromArgb(CByte(200), CByte(35), CByte(51))
        btnHapusPembalap.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(240), CByte(80), CByte(90))
        btnHapusPembalap.FlatStyle = FlatStyle.Flat
        btnHapusPembalap.ForeColor = SystemColors.ActiveCaptionText
        btnHapusPembalap.Location = New Point(66, 279)
        btnHapusPembalap.Name = "btnHapusPembalap"
        btnHapusPembalap.Size = New Size(112, 34)
        btnHapusPembalap.TabIndex = 13
        btnHapusPembalap.Text = "Hapus"
        btnHapusPembalap.UseVisualStyleBackColor = False
        ' 
        ' btnUbahPembalap
        ' 
        btnUbahPembalap.BackColor = Color.White
        btnUbahPembalap.FlatAppearance.MouseDownBackColor = Color.FromArgb(CByte(255), CByte(160), CByte(0))
        btnUbahPembalap.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(28), CByte(151), CByte(234))
        btnUbahPembalap.FlatStyle = FlatStyle.Flat
        btnUbahPembalap.Location = New Point(66, 234)
        btnUbahPembalap.Name = "btnUbahPembalap"
        btnUbahPembalap.Size = New Size(112, 34)
        btnUbahPembalap.TabIndex = 12
        btnUbahPembalap.Text = "Edit"
        btnUbahPembalap.UseVisualStyleBackColor = False
        ' 
        ' dgvPembalap
        ' 
        dgvPembalap.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvPembalap.Location = New Point(284, 47)
        dgvPembalap.Name = "dgvPembalap"
        dgvPembalap.RowHeadersWidth = 62
        dgvPembalap.Size = New Size(736, 307)
        dgvPembalap.TabIndex = 10
        ' 
        ' txtSearchPembalap
        ' 
        txtSearchPembalap.ForeColor = SystemColors.WindowFrame
        txtSearchPembalap.Location = New Point(284, 10)
        txtSearchPembalap.Name = "txtSearchPembalap"
        txtSearchPembalap.Size = New Size(736, 31)
        txtSearchPembalap.TabIndex = 9
        txtSearchPembalap.Text = "Search"
        ' 
        ' txtNomor
        ' 
        txtNomor.Location = New Point(91, 98)
        txtNomor.Name = "txtNomor"
        txtNomor.Size = New Size(166, 31)
        txtNomor.TabIndex = 6
        ' 
        ' txtNegara
        ' 
        txtNegara.Location = New Point(91, 50)
        txtNegara.Name = "txtNegara"
        txtNegara.Size = New Size(166, 31)
        txtNegara.TabIndex = 5
        ' 
        ' txtNamaPembalap
        ' 
        txtNamaPembalap.Location = New Point(91, 10)
        txtNamaPembalap.Name = "txtNamaPembalap"
        txtNamaPembalap.Size = New Size(166, 31)
        txtNamaPembalap.TabIndex = 4
        ' 
        ' lblTim
        ' 
        lblTim.AutoSize = True
        lblTim.Location = New Point(7, 138)
        lblTim.Name = "lblTim"
        lblTim.Size = New Size(41, 25)
        lblTim.TabIndex = 3
        lblTim.Text = "Tim"
        ' 
        ' lblNomor
        ' 
        lblNomor.AutoSize = True
        lblNomor.Location = New Point(7, 98)
        lblNomor.Name = "lblNomor"
        lblNomor.Size = New Size(69, 25)
        lblNomor.TabIndex = 2
        lblNomor.Text = "Nomor"
        ' 
        ' lblNegaraPembalap
        ' 
        lblNegaraPembalap.AutoSize = True
        lblNegaraPembalap.Location = New Point(7, 53)
        lblNegaraPembalap.Name = "lblNegaraPembalap"
        lblNegaraPembalap.Size = New Size(69, 25)
        lblNegaraPembalap.TabIndex = 1
        lblNegaraPembalap.Text = "Negara"
        ' 
        ' lblNamaPembalap
        ' 
        lblNamaPembalap.AutoSize = True
        lblNamaPembalap.Location = New Point(7, 10)
        lblNamaPembalap.Name = "lblNamaPembalap"
        lblNamaPembalap.Size = New Size(59, 25)
        lblNamaPembalap.TabIndex = 0
        lblNamaPembalap.Text = "Nama"
        ' 
        ' TPTim
        ' 
        TPTim.BackColor = Color.Gainsboro
        TPTim.Controls.Add(txtChasis)
        TPTim.Controls.Add(btnBatalTim)
        TPTim.Controls.Add(btnSimpanTim)
        TPTim.Controls.Add(btnHapusTim)
        TPTim.Controls.Add(btnUbahTim)
        TPTim.Controls.Add(dgvTim)
        TPTim.Controls.Add(txtSearchTim)
        TPTim.Controls.Add(txtMesin)
        TPTim.Controls.Add(txtNegaraTim)
        TPTim.Controls.Add(txtNamaTim)
        TPTim.Controls.Add(Label2)
        TPTim.Controls.Add(Label3)
        TPTim.Controls.Add(Label4)
        TPTim.Controls.Add(Label5)
        TPTim.Location = New Point(4, 34)
        TPTim.Name = "TPTim"
        TPTim.Padding = New Padding(3)
        TPTim.Size = New Size(1026, 364)
        TPTim.TabIndex = 1
        TPTim.Text = "Tim"
        ' 
        ' txtChasis
        ' 
        txtChasis.Location = New Point(95, 139)
        txtChasis.Name = "txtChasis"
        txtChasis.Size = New Size(150, 31)
        txtChasis.TabIndex = 32
        ' 
        ' btnBatalTim
        ' 
        btnBatalTim.Location = New Point(70, 321)
        btnBatalTim.Name = "btnBatalTim"
        btnBatalTim.Size = New Size(112, 34)
        btnBatalTim.TabIndex = 31
        btnBatalTim.Text = "Batal"
        btnBatalTim.UseVisualStyleBackColor = True
        ' 
        ' btnSimpanTim
        ' 
        btnSimpanTim.Location = New Point(70, 188)
        btnSimpanTim.Name = "btnSimpanTim"
        btnSimpanTim.Size = New Size(112, 34)
        btnSimpanTim.TabIndex = 30
        btnSimpanTim.Text = "Simpan"
        btnSimpanTim.UseVisualStyleBackColor = True
        ' 
        ' btnHapusTim
        ' 
        btnHapusTim.Location = New Point(70, 280)
        btnHapusTim.Name = "btnHapusTim"
        btnHapusTim.Size = New Size(112, 34)
        btnHapusTim.TabIndex = 28
        btnHapusTim.Text = "Hapus"
        btnHapusTim.UseVisualStyleBackColor = True
        ' 
        ' btnUbahTim
        ' 
        btnUbahTim.Location = New Point(70, 235)
        btnUbahTim.Name = "btnUbahTim"
        btnUbahTim.Size = New Size(112, 34)
        btnUbahTim.TabIndex = 27
        btnUbahTim.Text = "Edit"
        btnUbahTim.UseVisualStyleBackColor = True
        ' 
        ' dgvTim
        ' 
        dgvTim.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvTim.Location = New Point(288, 48)
        dgvTim.Name = "dgvTim"
        dgvTim.RowHeadersWidth = 62
        dgvTim.Size = New Size(732, 307)
        dgvTim.TabIndex = 26
        ' 
        ' txtSearchTim
        ' 
        txtSearchTim.Location = New Point(288, 11)
        txtSearchTim.Name = "txtSearchTim"
        txtSearchTim.Size = New Size(732, 31)
        txtSearchTim.TabIndex = 25
        txtSearchTim.Text = "Search"
        ' 
        ' txtMesin
        ' 
        txtMesin.Location = New Point(95, 99)
        txtMesin.Name = "txtMesin"
        txtMesin.Size = New Size(150, 31)
        txtMesin.TabIndex = 23
        ' 
        ' txtNegaraTim
        ' 
        txtNegaraTim.Location = New Point(95, 51)
        txtNegaraTim.Name = "txtNegaraTim"
        txtNegaraTim.Size = New Size(150, 31)
        txtNegaraTim.TabIndex = 22
        ' 
        ' txtNamaTim
        ' 
        txtNamaTim.Location = New Point(95, 11)
        txtNamaTim.Name = "txtNamaTim"
        txtNamaTim.Size = New Size(150, 31)
        txtNamaTim.TabIndex = 21
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(11, 139)
        Label2.Name = "Label2"
        Label2.Size = New Size(62, 25)
        Label2.TabIndex = 20
        Label2.Text = "Chasis"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(11, 99)
        Label3.Name = "Label3"
        Label3.Size = New Size(59, 25)
        Label3.TabIndex = 19
        Label3.Text = "Mesin"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(11, 54)
        Label4.Name = "Label4"
        Label4.Size = New Size(69, 25)
        Label4.TabIndex = 18
        Label4.Text = "Negara"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(11, 11)
        Label5.Name = "Label5"
        Label5.Size = New Size(59, 25)
        Label5.TabIndex = 17
        Label5.Text = "Nama"
        ' 
        ' TPRace
        ' 
        TPRace.BackColor = Color.Gainsboro
        TPRace.Controls.Add(dtpTanggal)
        TPRace.Controls.Add(txtPutaran)
        TPRace.Controls.Add(btnBatalRace)
        TPRace.Controls.Add(btnSimpanRace)
        TPRace.Controls.Add(btnHapusRace)
        TPRace.Controls.Add(btnUbahRace)
        TPRace.Controls.Add(dgvRace)
        TPRace.Controls.Add(txtSearchRace)
        TPRace.Controls.Add(txtLokasi)
        TPRace.Controls.Add(txtNamaRace)
        TPRace.Controls.Add(Label7)
        TPRace.Controls.Add(Label8)
        TPRace.Controls.Add(Label9)
        TPRace.Controls.Add(Label10)
        TPRace.Location = New Point(4, 34)
        TPRace.Name = "TPRace"
        TPRace.Padding = New Padding(3)
        TPRace.Size = New Size(1026, 364)
        TPRace.TabIndex = 2
        TPRace.Text = "Race"
        ' 
        ' dtpTanggal
        ' 
        dtpTanggal.Location = New Point(92, 94)
        dtpTanggal.Name = "dtpTanggal"
        dtpTanggal.Size = New Size(187, 31)
        dtpTanggal.TabIndex = 48
        ' 
        ' txtPutaran
        ' 
        txtPutaran.Location = New Point(92, 139)
        txtPutaran.Name = "txtPutaran"
        txtPutaran.Size = New Size(187, 31)
        txtPutaran.TabIndex = 47
        ' 
        ' btnBatalRace
        ' 
        btnBatalRace.Location = New Point(67, 321)
        btnBatalRace.Name = "btnBatalRace"
        btnBatalRace.Size = New Size(112, 34)
        btnBatalRace.TabIndex = 46
        btnBatalRace.Text = "Batal"
        btnBatalRace.UseVisualStyleBackColor = True
        ' 
        ' btnSimpanRace
        ' 
        btnSimpanRace.Location = New Point(67, 188)
        btnSimpanRace.Name = "btnSimpanRace"
        btnSimpanRace.Size = New Size(112, 34)
        btnSimpanRace.TabIndex = 45
        btnSimpanRace.Text = "Simpan"
        btnSimpanRace.UseVisualStyleBackColor = True
        ' 
        ' btnHapusRace
        ' 
        btnHapusRace.Location = New Point(67, 280)
        btnHapusRace.Name = "btnHapusRace"
        btnHapusRace.Size = New Size(112, 34)
        btnHapusRace.TabIndex = 44
        btnHapusRace.Text = "Hapus"
        btnHapusRace.UseVisualStyleBackColor = True
        ' 
        ' btnUbahRace
        ' 
        btnUbahRace.Location = New Point(67, 235)
        btnUbahRace.Name = "btnUbahRace"
        btnUbahRace.Size = New Size(112, 34)
        btnUbahRace.TabIndex = 43
        btnUbahRace.Text = "Edit"
        btnUbahRace.UseVisualStyleBackColor = True
        ' 
        ' dgvRace
        ' 
        dgvRace.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvRace.Location = New Point(297, 48)
        dgvRace.Name = "dgvRace"
        dgvRace.RowHeadersWidth = 62
        dgvRace.Size = New Size(723, 307)
        dgvRace.TabIndex = 42
        ' 
        ' txtSearchRace
        ' 
        txtSearchRace.Location = New Point(297, 11)
        txtSearchRace.Name = "txtSearchRace"
        txtSearchRace.Size = New Size(723, 31)
        txtSearchRace.TabIndex = 41
        txtSearchRace.Text = "Search"
        ' 
        ' txtLokasi
        ' 
        txtLokasi.Location = New Point(92, 51)
        txtLokasi.Name = "txtLokasi"
        txtLokasi.Size = New Size(187, 31)
        txtLokasi.TabIndex = 38
        ' 
        ' txtNamaRace
        ' 
        txtNamaRace.Location = New Point(92, 11)
        txtNamaRace.Name = "txtNamaRace"
        txtNamaRace.Size = New Size(187, 31)
        txtNamaRace.TabIndex = 37
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Location = New Point(8, 139)
        Label7.Name = "Label7"
        Label7.Size = New Size(72, 25)
        Label7.TabIndex = 36
        Label7.Text = "Putaran"
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Location = New Point(8, 99)
        Label8.Name = "Label8"
        Label8.Size = New Size(73, 25)
        Label8.TabIndex = 35
        Label8.Text = "Tanggal"
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Location = New Point(8, 54)
        Label9.Name = "Label9"
        Label9.Size = New Size(61, 25)
        Label9.TabIndex = 34
        Label9.Text = "Lokasi"
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.Location = New Point(8, 11)
        Label10.Name = "Label10"
        Label10.Size = New Size(59, 25)
        Label10.TabIndex = 33
        Label10.Text = "Nama"
        ' 
        ' ErrorProvider1
        ' 
        ErrorProvider1.ContainerControl = Me
        ' 
        ' ErrorProvider2
        ' 
        ErrorProvider2.ContainerControl = Me
        ' 
        ' ErrorProvider3
        ' 
        ErrorProvider3.ContainerControl = Me
        ' 
        ' MenuStrip2
        ' 
        MenuStrip2.BackColor = Color.SlateGray
        MenuStrip2.ImageScalingSize = New Size(24, 24)
        MenuStrip2.Items.AddRange(New ToolStripItem() {mnuPembalap, mnuTim, mnuRace, mnuKeluar})
        MenuStrip2.Location = New Point(0, 0)
        MenuStrip2.Name = "MenuStrip2"
        MenuStrip2.Size = New Size(1049, 33)
        MenuStrip2.TabIndex = 4
        MenuStrip2.Text = "MenuStrip2"
        ' 
        ' mnuPembalap
        ' 
        mnuPembalap.Name = "mnuPembalap"
        mnuPembalap.Size = New Size(106, 29)
        mnuPembalap.Text = "Pembalap"
        ' 
        ' mnuTim
        ' 
        mnuTim.Name = "mnuTim"
        mnuTim.Size = New Size(57, 29)
        mnuTim.Text = "Tim"
        ' 
        ' mnuRace
        ' 
        mnuRace.Name = "mnuRace"
        mnuRace.Size = New Size(65, 29)
        mnuRace.Text = "Race"
        ' 
        ' mnuKeluar
        ' 
        mnuKeluar.Name = "mnuKeluar"
        mnuKeluar.Size = New Size(76, 29)
        mnuKeluar.Text = "Keluar"
        ' 
        ' DashboardAdmin
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1049, 437)
        Controls.Add(Panel2)
        Controls.Add(MenuStrip2)
        Name = "DashboardAdmin"
        Text = "DashboardAdmin"
        Panel2.ResumeLayout(False)
        TabControl1.ResumeLayout(False)
        TPPembalap.ResumeLayout(False)
        TPPembalap.PerformLayout()
        CType(dgvPembalap, ComponentModel.ISupportInitialize).EndInit()
        TPTim.ResumeLayout(False)
        TPTim.PerformLayout()
        CType(dgvTim, ComponentModel.ISupportInitialize).EndInit()
        TPRace.ResumeLayout(False)
        TPRace.PerformLayout()
        CType(dgvRace, ComponentModel.ISupportInitialize).EndInit()
        CType(ErrorProvider1, ComponentModel.ISupportInitialize).EndInit()
        CType(ErrorProvider2, ComponentModel.ISupportInitialize).EndInit()
        CType(ErrorProvider3, ComponentModel.ISupportInitialize).EndInit()
        MenuStrip2.ResumeLayout(False)
        MenuStrip2.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Panel2 As Panel
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TPPembalap As TabPage
    Friend WithEvents txtNomor As TextBox
    Friend WithEvents txtNegara As TextBox
    Friend WithEvents txtNamaPembalap As TextBox
    Friend WithEvents lblTim As Label
    Friend WithEvents lblNomor As Label
    Friend WithEvents lblNegaraPembalap As Label
    Friend WithEvents lblNamaPembalap As Label
    Friend WithEvents TPTim As TabPage
    Friend WithEvents btnUbahPembalap As Button
    Friend WithEvents dgvPembalap As DataGridView
    Friend WithEvents txtSearchPembalap As TextBox
    Friend WithEvents btnSimpanPembalap As Button
    Friend WithEvents btnHapusPembalap As Button
    Friend WithEvents cbTim As ComboBox
    Friend WithEvents btnBatalPembalap As Button
    Friend WithEvents btnBatalTim As Button
    Friend WithEvents btnSimpanTim As Button
    Friend WithEvents btnHapusTim As Button
    Friend WithEvents btnUbahTim As Button
    Friend WithEvents dgvTim As DataGridView
    Friend WithEvents txtSearchTim As TextBox
    Friend WithEvents txtNegaraTim As TextBox
    Friend WithEvents txtNamaTim As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents ErrorProvider1 As ErrorProvider
    Friend WithEvents ErrorProvider2 As ErrorProvider
    Friend WithEvents txtChasis As TextBox
    Friend WithEvents txtMesin As TextBox
    Friend WithEvents TPRace As TabPage
    Friend WithEvents txtPutaran As TextBox
    Friend WithEvents btnBatalRace As Button
    Friend WithEvents btnSimpanRace As Button
    Friend WithEvents btnHapusRace As Button
    Friend WithEvents btnUbahRace As Button
    Friend WithEvents dgvRace As DataGridView
    Friend WithEvents txtSearchRace As TextBox
    Friend WithEvents txtLokasi As TextBox
    Friend WithEvents txtNamaRace As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents dtpTanggal As DateTimePicker
    Friend WithEvents ErrorProvider3 As ErrorProvider

    Private Sub dgvPembalap_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvPembalap.CellContentClick

    End Sub

    Friend WithEvents MenuStrip2 As MenuStrip
    Friend WithEvents mnuPembalap As ToolStripMenuItem
    Friend WithEvents mnuTim As ToolStripMenuItem
    Friend WithEvents mnuRace As ToolStripMenuItem
    Friend WithEvents mnuKeluar As ToolStripMenuItem
End Class
