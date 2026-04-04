<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        components = New ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        txtNama = New TextBox()
        txtID = New TextBox()
        DTPTL = New DateTimePicker()
        RBP = New RadioButton()
        RBL = New RadioButton()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        PictureBox2 = New PictureBox()
        Panel1 = New Panel()
        Label6 = New Label()
        MenuStrip1 = New MenuStrip()
        SMInput = New ToolStripMenuItem()
        SMLihat = New ToolStripMenuItem()
        SMSimpan = New ToolStripMenuItem()
        SMBuka = New ToolStripMenuItem()
        SMKeluar = New ToolStripMenuItem()
        TabControl1 = New TabControl()
        TPData = New TabPage()
        cbTim = New ComboBox()
        TPKontak = New TabPage()
        mtxtNoHP = New MaskedTextBox()
        Label9 = New Label()
        Label7 = New Label()
        Label8 = New Label()
        txtEmail = New TextBox()
        txtAlamat = New TextBox()
        TPProfil = New TabPage()
        btnSimpan = New Button()
        GBPeran = New GroupBox()
        RBMedia = New RadioButton()
        RBTP = New RadioButton()
        RBStrategist = New RadioButton()
        RBPC = New RadioButton()
        RBEngineer = New RadioButton()
        RBDriver = New RadioButton()
        btnBrowse = New Button()
        GBAktivitas = New GroupBox()
        chkVideografi = New CheckBox()
        chkDesigner = New CheckBox()
        chkFotografi = New CheckBox()
        chkSB = New CheckBox()
        chkSM = New CheckBox()
        chkAnalyst = New CheckBox()
        chkEditing = New CheckBox()
        chkDriving = New CheckBox()
        PictureBox1 = New PictureBox()
        ErrorProvider1 = New ErrorProvider(components)
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        Panel1.SuspendLayout()
        MenuStrip1.SuspendLayout()
        TabControl1.SuspendLayout()
        TPData.SuspendLayout()
        TPKontak.SuspendLayout()
        TPProfil.SuspendLayout()
        GBPeran.SuspendLayout()
        GBAktivitas.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        CType(ErrorProvider1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' txtNama
        ' 
        txtNama.Location = New Point(196, 22)
        txtNama.Name = "txtNama"
        txtNama.Size = New Size(425, 31)
        txtNama.TabIndex = 2
        ' 
        ' txtID
        ' 
        txtID.Location = New Point(196, 83)
        txtID.Name = "txtID"
        txtID.Size = New Size(425, 31)
        txtID.TabIndex = 3
        ' 
        ' DTPTL
        ' 
        DTPTL.Location = New Point(196, 144)
        DTPTL.Name = "DTPTL"
        DTPTL.Size = New Size(425, 31)
        DTPTL.TabIndex = 6
        ' 
        ' RBP
        ' 
        RBP.AutoSize = True
        RBP.Location = New Point(349, 208)
        RBP.Name = "RBP"
        RBP.Size = New Size(126, 29)
        RBP.TabIndex = 1
        RBP.TabStop = True
        RBP.Text = "Perempuan"
        RBP.UseVisualStyleBackColor = True
        ' 
        ' RBL
        ' 
        RBL.AutoSize = True
        RBL.Location = New Point(196, 208)
        RBL.Name = "RBL"
        RBL.Size = New Size(104, 29)
        RBL.TabIndex = 0
        RBL.TabStop = True
        RBL.Text = "Laki-Laki"
        RBL.UseVisualStyleBackColor = True
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(30, 22)
        Label1.Name = "Label1"
        Label1.Size = New Size(131, 25)
        Label1.TabIndex = 10
        Label1.Text = "Nama Lengkap"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(33, 83)
        Label2.Name = "Label2"
        Label2.Size = New Size(103, 25)
        Label2.TabIndex = 11
        Label2.Text = "Id Anggota"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(33, 144)
        Label3.Name = "Label3"
        Label3.Size = New Size(115, 25)
        Label3.TabIndex = 12
        Label3.Text = "Tanggal Lahir"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(33, 208)
        Label4.Name = "Label4"
        Label4.Size = New Size(116, 25)
        Label4.TabIndex = 13
        Label4.Text = "Jenis Kelamin"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(33, 270)
        Label5.Name = "Label5"
        Label5.Size = New Size(41, 25)
        Label5.TabIndex = 14
        Label5.Text = "Tim"
        ' 
        ' PictureBox2
        ' 
        PictureBox2.BackColor = Color.Transparent
        PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), Image)
        PictureBox2.Location = New Point(31, 8)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(157, 42)
        PictureBox2.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox2.TabIndex = 15
        PictureBox2.TabStop = False
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = SystemColors.Desktop
        Panel1.Controls.Add(Label6)
        Panel1.Controls.Add(PictureBox2)
        Panel1.Location = New Point(-28, 33)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(913, 61)
        Panel1.TabIndex = 16
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.BackColor = Color.Transparent
        Label6.Font = New Font("Segoe UI", 20F)
        Label6.ForeColor = Color.White
        Label6.Location = New Point(253, 4)
        Label6.Name = "Label6"
        Label6.Size = New Size(398, 54)
        Label6.TabIndex = 16
        Label6.Text = "Data Profil Pengguna"
        ' 
        ' MenuStrip1
        ' 
        MenuStrip1.BackColor = SystemColors.ActiveCaptionText
        MenuStrip1.ImageScalingSize = New Size(24, 24)
        MenuStrip1.Items.AddRange(New ToolStripItem() {SMInput, SMLihat, SMSimpan, SMBuka, SMKeluar})
        MenuStrip1.Location = New Point(0, 0)
        MenuStrip1.Name = "MenuStrip1"
        MenuStrip1.Size = New Size(678, 33)
        MenuStrip1.TabIndex = 17
        MenuStrip1.Text = "MenuStrip1"
        ' 
        ' SMInput
        ' 
        SMInput.ForeColor = SystemColors.ControlLightLight
        SMInput.Name = "SMInput"
        SMInput.Size = New Size(112, 29)
        SMInput.Text = "Input Data"
        ' 
        ' SMLihat
        ' 
        SMLihat.ForeColor = SystemColors.ControlLightLight
        SMLihat.Name = "SMLihat"
        SMLihat.Size = New Size(111, 29)
        SMLihat.Text = "Lihat Kartu"
        ' 
        ' SMSimpan
        ' 
        SMSimpan.ForeColor = SystemColors.ControlLightLight
        SMSimpan.Name = "SMSimpan"
        SMSimpan.Size = New Size(130, 29)
        SMSimpan.Text = "Simpan Data"
        ' 
        ' SMBuka
        ' 
        SMBuka.ForeColor = SystemColors.ControlLightLight
        SMBuka.Name = "SMBuka"
        SMBuka.Size = New Size(108, 29)
        SMBuka.Text = "Buka Data"
        ' 
        ' SMKeluar
        ' 
        SMKeluar.ForeColor = SystemColors.ControlLightLight
        SMKeluar.Name = "SMKeluar"
        SMKeluar.Size = New Size(76, 29)
        SMKeluar.Text = "Keluar"
        ' 
        ' TabControl1
        ' 
        TabControl1.Controls.Add(TPData)
        TabControl1.Controls.Add(TPKontak)
        TabControl1.Controls.Add(TPProfil)
        TabControl1.Location = New Point(12, 113)
        TabControl1.Name = "TabControl1"
        TabControl1.SelectedIndex = 0
        TabControl1.Size = New Size(654, 436)
        TabControl1.TabIndex = 18
        ' 
        ' TPData
        ' 
        TPData.Controls.Add(RBP)
        TPData.Controls.Add(Label5)
        TPData.Controls.Add(cbTim)
        TPData.Controls.Add(Label4)
        TPData.Controls.Add(RBL)
        TPData.Controls.Add(Label3)
        TPData.Controls.Add(Label1)
        TPData.Controls.Add(Label2)
        TPData.Controls.Add(txtNama)
        TPData.Controls.Add(txtID)
        TPData.Controls.Add(DTPTL)
        TPData.Location = New Point(4, 34)
        TPData.Name = "TPData"
        TPData.Padding = New Padding(3)
        TPData.Size = New Size(646, 398)
        TPData.TabIndex = 0
        TPData.Text = "Data Utama"
        TPData.UseVisualStyleBackColor = True
        ' 
        ' cbTim
        ' 
        cbTim.FormattingEnabled = True
        cbTim.Items.AddRange(New Object() {"Mercedes AMG", "Scuderia Ferrari", "Mclaren", "Red Bull", "Haas", "Williams", "Alpine", "Racing Bulls", "Audi", "Cadillac", "Aston Martin"})
        cbTim.Location = New Point(196, 265)
        cbTim.Name = "cbTim"
        cbTim.Size = New Size(425, 33)
        cbTim.TabIndex = 0
        ' 
        ' TPKontak
        ' 
        TPKontak.Controls.Add(mtxtNoHP)
        TPKontak.Controls.Add(Label9)
        TPKontak.Controls.Add(Label7)
        TPKontak.Controls.Add(Label8)
        TPKontak.Controls.Add(txtEmail)
        TPKontak.Controls.Add(txtAlamat)
        TPKontak.Location = New Point(4, 34)
        TPKontak.Name = "TPKontak"
        TPKontak.Padding = New Padding(3)
        TPKontak.Size = New Size(646, 398)
        TPKontak.TabIndex = 1
        TPKontak.Text = "Kontak dan Info"
        TPKontak.UseVisualStyleBackColor = True
        ' 
        ' mtxtNoHP
        ' 
        mtxtNoHP.Location = New Point(194, 44)
        mtxtNoHP.Mask = "0000-0000-0000"
        mtxtNoHP.Name = "mtxtNoHP"
        mtxtNoHP.Size = New Size(425, 31)
        mtxtNoHP.TabIndex = 17
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Location = New Point(31, 44)
        Label9.Name = "Label9"
        Label9.Size = New Size(135, 25)
        Label9.TabIndex = 16
        Label9.Text = "Nomor Telepon"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Location = New Point(28, 106)
        Label7.Name = "Label7"
        Label7.Size = New Size(54, 25)
        Label7.TabIndex = 14
        Label7.Text = "Email"
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Location = New Point(28, 169)
        Label8.Name = "Label8"
        Label8.Size = New Size(68, 25)
        Label8.TabIndex = 15
        Label8.Text = "Alamat"
        ' 
        ' txtEmail
        ' 
        txtEmail.Location = New Point(194, 106)
        txtEmail.Name = "txtEmail"
        txtEmail.Size = New Size(425, 31)
        txtEmail.TabIndex = 12
        ' 
        ' txtAlamat
        ' 
        txtAlamat.Location = New Point(194, 169)
        txtAlamat.Name = "txtAlamat"
        txtAlamat.Size = New Size(425, 31)
        txtAlamat.TabIndex = 13
        ' 
        ' TPProfil
        ' 
        TPProfil.Controls.Add(btnSimpan)
        TPProfil.Controls.Add(GBPeran)
        TPProfil.Controls.Add(btnBrowse)
        TPProfil.Controls.Add(GBAktivitas)
        TPProfil.Controls.Add(PictureBox1)
        TPProfil.Location = New Point(4, 34)
        TPProfil.Name = "TPProfil"
        TPProfil.Padding = New Padding(3)
        TPProfil.Size = New Size(646, 398)
        TPProfil.TabIndex = 2
        TPProfil.Text = "Profil dan Aktivitas"
        TPProfil.UseVisualStyleBackColor = True
        ' 
        ' btnSimpan
        ' 
        btnSimpan.Location = New Point(284, 333)
        btnSimpan.Name = "btnSimpan"
        btnSimpan.Size = New Size(323, 34)
        btnSimpan.TabIndex = 12
        btnSimpan.Text = "Simpan dan Cetak Kartu"
        btnSimpan.UseVisualStyleBackColor = True
        ' 
        ' GBPeran
        ' 
        GBPeran.Controls.Add(RBMedia)
        GBPeran.Controls.Add(RBTP)
        GBPeran.Controls.Add(RBStrategist)
        GBPeran.Controls.Add(RBPC)
        GBPeran.Controls.Add(RBEngineer)
        GBPeran.Controls.Add(RBDriver)
        GBPeran.Location = New Point(284, 6)
        GBPeran.Name = "GBPeran"
        GBPeran.Size = New Size(339, 131)
        GBPeran.TabIndex = 11
        GBPeran.TabStop = False
        GBPeran.Text = "Peran"
        ' 
        ' RBMedia
        ' 
        RBMedia.AutoSize = True
        RBMedia.Location = New Point(172, 98)
        RBMedia.Name = "RBMedia"
        RBMedia.Size = New Size(86, 29)
        RBMedia.TabIndex = 5
        RBMedia.TabStop = True
        RBMedia.Text = "Media"
        RBMedia.UseVisualStyleBackColor = True
        ' 
        ' RBTP
        ' 
        RBTP.AutoSize = True
        RBTP.Location = New Point(5, 98)
        RBTP.Name = "RBTP"
        RBTP.Size = New Size(149, 29)
        RBTP.TabIndex = 4
        RBTP.TabStop = True
        RBTP.Text = "Team Principal"
        RBTP.UseVisualStyleBackColor = True
        ' 
        ' RBStrategist
        ' 
        RBStrategist.AutoSize = True
        RBStrategist.Location = New Point(173, 63)
        RBStrategist.Name = "RBStrategist"
        RBStrategist.Size = New Size(111, 29)
        RBStrategist.TabIndex = 3
        RBStrategist.TabStop = True
        RBStrategist.Text = "Strategist"
        RBStrategist.UseVisualStyleBackColor = True
        ' 
        ' RBPC
        ' 
        RBPC.AutoSize = True
        RBPC.Location = New Point(172, 28)
        RBPC.Name = "RBPC"
        RBPC.Size = New Size(101, 29)
        RBPC.TabIndex = 2
        RBPC.TabStop = True
        RBPC.Text = "Pit Crew"
        RBPC.UseVisualStyleBackColor = True
        ' 
        ' RBEngineer
        ' 
        RBEngineer.AutoSize = True
        RBEngineer.Location = New Point(6, 63)
        RBEngineer.Name = "RBEngineer"
        RBEngineer.Size = New Size(105, 29)
        RBEngineer.TabIndex = 1
        RBEngineer.TabStop = True
        RBEngineer.Text = "Engineer"
        RBEngineer.UseVisualStyleBackColor = True
        ' 
        ' RBDriver
        ' 
        RBDriver.AutoSize = True
        RBDriver.Location = New Point(6, 28)
        RBDriver.Name = "RBDriver"
        RBDriver.Size = New Size(84, 29)
        RBDriver.TabIndex = 0
        RBDriver.TabStop = True
        RBDriver.Text = "Driver"
        RBDriver.UseVisualStyleBackColor = True
        ' 
        ' btnBrowse
        ' 
        btnBrowse.Location = New Point(61, 284)
        btnBrowse.Name = "btnBrowse"
        btnBrowse.Size = New Size(112, 34)
        btnBrowse.TabIndex = 10
        btnBrowse.Text = "Browse"
        btnBrowse.UseVisualStyleBackColor = True
        ' 
        ' GBAktivitas
        ' 
        GBAktivitas.Controls.Add(chkVideografi)
        GBAktivitas.Controls.Add(chkDesigner)
        GBAktivitas.Controls.Add(chkFotografi)
        GBAktivitas.Controls.Add(chkSB)
        GBAktivitas.Controls.Add(chkSM)
        GBAktivitas.Controls.Add(chkAnalyst)
        GBAktivitas.Controls.Add(chkEditing)
        GBAktivitas.Controls.Add(chkDriving)
        GBAktivitas.Location = New Point(284, 143)
        GBAktivitas.Name = "GBAktivitas"
        GBAktivitas.Size = New Size(339, 175)
        GBAktivitas.TabIndex = 9
        GBAktivitas.TabStop = False
        GBAktivitas.Text = "Aktivitas"
        ' 
        ' chkVideografi
        ' 
        chkVideografi.AutoSize = True
        chkVideografi.Location = New Point(172, 135)
        chkVideografi.Name = "chkVideografi"
        chkVideografi.Size = New Size(120, 29)
        chkVideografi.TabIndex = 7
        chkVideografi.Text = "Videografi"
        chkVideografi.UseVisualStyleBackColor = True
        ' 
        ' chkDesigner
        ' 
        chkDesigner.AutoSize = True
        chkDesigner.Location = New Point(18, 130)
        chkDesigner.Name = "chkDesigner"
        chkDesigner.Size = New Size(108, 29)
        chkDesigner.TabIndex = 6
        chkDesigner.Text = "Designer"
        chkDesigner.UseVisualStyleBackColor = True
        ' 
        ' chkFotografi
        ' 
        chkFotografi.AutoSize = True
        chkFotografi.Location = New Point(172, 100)
        chkFotografi.Name = "chkFotografi"
        chkFotografi.Size = New Size(111, 29)
        chkFotografi.TabIndex = 5
        chkFotografi.Text = "Fotografi"
        chkFotografi.UseVisualStyleBackColor = True
        ' 
        ' chkSB
        ' 
        chkSB.AutoSize = True
        chkSB.Location = New Point(19, 100)
        chkSB.Name = "chkSB"
        chkSB.Size = New Size(146, 29)
        chkSB.TabIndex = 4
        chkSB.Text = "Strategi Balap"
        chkSB.UseVisualStyleBackColor = True
        ' 
        ' chkSM
        ' 
        chkSM.AutoSize = True
        chkSM.Location = New Point(172, 65)
        chkSM.Name = "chkSM"
        chkSM.Size = New Size(135, 29)
        chkSM.TabIndex = 3
        chkSM.Text = "Setup Mobil"
        chkSM.UseVisualStyleBackColor = True
        ' 
        ' chkAnalyst
        ' 
        chkAnalyst.AutoSize = True
        chkAnalyst.Location = New Point(18, 65)
        chkAnalyst.Name = "chkAnalyst"
        chkAnalyst.Size = New Size(96, 29)
        chkAnalyst.TabIndex = 2
        chkAnalyst.Text = "Analyst"
        chkAnalyst.UseVisualStyleBackColor = True
        ' 
        ' chkEditing
        ' 
        chkEditing.AutoSize = True
        chkEditing.Location = New Point(172, 30)
        chkEditing.Name = "chkEditing"
        chkEditing.Size = New Size(93, 29)
        chkEditing.TabIndex = 1
        chkEditing.Text = "Editing"
        chkEditing.UseVisualStyleBackColor = True
        ' 
        ' chkDriving
        ' 
        chkDriving.AutoSize = True
        chkDriving.Location = New Point(18, 30)
        chkDriving.Name = "chkDriving"
        chkDriving.Size = New Size(95, 29)
        chkDriving.TabIndex = 0
        chkDriving.Text = "Driving"
        chkDriving.UseVisualStyleBackColor = True
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Location = New Point(24, 23)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(208, 249)
        PictureBox1.TabIndex = 0
        PictureBox1.TabStop = False
        ' 
        ' ErrorProvider1
        ' 
        ErrorProvider1.ContainerControl = Me
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(678, 567)
        Controls.Add(Panel1)
        Controls.Add(MenuStrip1)
        Controls.Add(TabControl1)
        MainMenuStrip = MenuStrip1
        Name = "Form1"
        Text = "Form1"
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        MenuStrip1.ResumeLayout(False)
        MenuStrip1.PerformLayout()
        TabControl1.ResumeLayout(False)
        TPData.ResumeLayout(False)
        TPData.PerformLayout()
        TPKontak.ResumeLayout(False)
        TPKontak.PerformLayout()
        TPProfil.ResumeLayout(False)
        GBPeran.ResumeLayout(False)
        GBPeran.PerformLayout()
        GBAktivitas.ResumeLayout(False)
        GBAktivitas.PerformLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        CType(ErrorProvider1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents txtNama As TextBox
    Friend WithEvents txtID As TextBox
    Friend WithEvents DTPTL As DateTimePicker
    Friend WithEvents RBP As RadioButton
    Friend WithEvents RBL As RadioButton
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label6 As Label
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents SMInput As ToolStripMenuItem
    Friend WithEvents SMLihat As ToolStripMenuItem
    Friend WithEvents SMSimpan As ToolStripMenuItem
    Friend WithEvents SMBuka As ToolStripMenuItem
    Friend WithEvents SMKeluar As ToolStripMenuItem
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TPData As TabPage
    Friend WithEvents TPKontak As TabPage
    Friend WithEvents cbTim As ComboBox
    Friend WithEvents TPProfil As TabPage
    Friend WithEvents mtxtNoHP As MaskedTextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents txtAlamat As TextBox
    Friend WithEvents GBAktivitas As GroupBox
    Friend WithEvents chkVideografi As CheckBox
    Friend WithEvents chkDesigner As CheckBox
    Friend WithEvents chkFotografi As CheckBox
    Friend WithEvents chkSB As CheckBox
    Friend WithEvents chkSM As CheckBox
    Friend WithEvents chkAnalyst As CheckBox
    Friend WithEvents chkEditing As CheckBox
    Friend WithEvents chkDriving As CheckBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents GBPeran As GroupBox
    Friend WithEvents RBPC As RadioButton
    Friend WithEvents RBEngineer As RadioButton
    Friend WithEvents RBDriver As RadioButton
    Friend WithEvents btnBrowse As Button
    Friend WithEvents RBStrategist As RadioButton
    Friend WithEvents btnSimpan As Button
    Friend WithEvents ErrorProvider1 As ErrorProvider
    Friend WithEvents RBMedia As RadioButton
    Friend WithEvents RBTP As RadioButton

End Class
