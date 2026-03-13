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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        PictureBox1 = New PictureBox()
        BtnBrowse = New Button()
        txtNama = New TextBox()
        txtUmur = New TextBox()
        txtNomorTelepon = New TextBox()
        txtAlamat = New TextBox()
        DTPTL = New DateTimePicker()
        GBJK = New GroupBox()
        RBP = New RadioButton()
        RBL = New RadioButton()
        GBHobby = New GroupBox()
        chkMenulis = New CheckBox()
        chkMenggambar = New CheckBox()
        chkMemasak = New CheckBox()
        chkFotografi = New CheckBox()
        chkTraveling = New CheckBox()
        chkMembaca = New CheckBox()
        chkOlahraga = New CheckBox()
        chkMenonton = New CheckBox()
        chkMusik = New CheckBox()
        chkGame = New CheckBox()
        BtnCetakKartu = New Button()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        PictureBox2 = New PictureBox()
        Panel1 = New Panel()
        Label6 = New Label()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        GBJK.SuspendLayout()
        GBHobby.SuspendLayout()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        Panel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BorderStyle = BorderStyle.FixedSingle
        PictureBox1.Location = New Point(12, 68)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(236, 359)
        PictureBox1.TabIndex = 0
        PictureBox1.TabStop = False
        ' 
        ' BtnBrowse
        ' 
        BtnBrowse.BackColor = Color.DarkGray
        BtnBrowse.FlatStyle = FlatStyle.Flat
        BtnBrowse.Location = New Point(78, 433)
        BtnBrowse.Name = "BtnBrowse"
        BtnBrowse.Size = New Size(112, 34)
        BtnBrowse.TabIndex = 1
        BtnBrowse.Text = "Browse"
        BtnBrowse.UseVisualStyleBackColor = False
        ' 
        ' txtNama
        ' 
        txtNama.Location = New Point(434, 68)
        txtNama.Name = "txtNama"
        txtNama.Size = New Size(425, 31)
        txtNama.TabIndex = 2
        ' 
        ' txtUmur
        ' 
        txtUmur.Location = New Point(434, 105)
        txtUmur.Name = "txtUmur"
        txtUmur.Size = New Size(425, 31)
        txtUmur.TabIndex = 3
        ' 
        ' txtNomorTelepon
        ' 
        txtNomorTelepon.Location = New Point(434, 179)
        txtNomorTelepon.Name = "txtNomorTelepon"
        txtNomorTelepon.Size = New Size(425, 31)
        txtNomorTelepon.TabIndex = 4
        ' 
        ' txtAlamat
        ' 
        txtAlamat.Location = New Point(434, 216)
        txtAlamat.Name = "txtAlamat"
        txtAlamat.Size = New Size(425, 31)
        txtAlamat.TabIndex = 5
        ' 
        ' DTPTL
        ' 
        DTPTL.Location = New Point(434, 142)
        DTPTL.Name = "DTPTL"
        DTPTL.Size = New Size(425, 31)
        DTPTL.TabIndex = 6
        ' 
        ' GBJK
        ' 
        GBJK.Controls.Add(RBP)
        GBJK.Controls.Add(RBL)
        GBJK.Location = New Point(268, 267)
        GBJK.Name = "GBJK"
        GBJK.Size = New Size(291, 200)
        GBJK.TabIndex = 7
        GBJK.TabStop = False
        GBJK.Text = "Jenis Kelamin"
        ' 
        ' RBP
        ' 
        RBP.AutoSize = True
        RBP.Location = New Point(20, 79)
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
        RBL.Location = New Point(20, 39)
        RBL.Name = "RBL"
        RBL.Size = New Size(104, 29)
        RBL.TabIndex = 0
        RBL.TabStop = True
        RBL.Text = "Laki-Laki"
        RBL.UseVisualStyleBackColor = True
        ' 
        ' GBHobby
        ' 
        GBHobby.Controls.Add(chkMenulis)
        GBHobby.Controls.Add(chkMenggambar)
        GBHobby.Controls.Add(chkMemasak)
        GBHobby.Controls.Add(chkFotografi)
        GBHobby.Controls.Add(chkTraveling)
        GBHobby.Controls.Add(chkMembaca)
        GBHobby.Controls.Add(chkOlahraga)
        GBHobby.Controls.Add(chkMenonton)
        GBHobby.Controls.Add(chkMusik)
        GBHobby.Controls.Add(chkGame)
        GBHobby.Location = New Point(568, 258)
        GBHobby.Name = "GBHobby"
        GBHobby.Size = New Size(291, 200)
        GBHobby.TabIndex = 8
        GBHobby.TabStop = False
        GBHobby.Text = "Hobby"
        ' 
        ' chkMenulis
        ' 
        chkMenulis.AutoSize = True
        chkMenulis.Location = New Point(172, 166)
        chkMenulis.Name = "chkMenulis"
        chkMenulis.Size = New Size(99, 29)
        chkMenulis.TabIndex = 9
        chkMenulis.Text = "Menulis"
        chkMenulis.UseVisualStyleBackColor = True
        ' 
        ' chkMenggambar
        ' 
        chkMenggambar.AutoSize = True
        chkMenggambar.Location = New Point(18, 165)
        chkMenggambar.Name = "chkMenggambar"
        chkMenggambar.Size = New Size(146, 29)
        chkMenggambar.TabIndex = 8
        chkMenggambar.Text = "Menggambar"
        chkMenggambar.UseVisualStyleBackColor = True
        ' 
        ' chkMemasak
        ' 
        chkMemasak.AutoSize = True
        chkMemasak.Location = New Point(172, 135)
        chkMemasak.Name = "chkMemasak"
        chkMemasak.Size = New Size(114, 29)
        chkMemasak.TabIndex = 7
        chkMemasak.Text = "Memasak"
        chkMemasak.UseVisualStyleBackColor = True
        ' 
        ' chkFotografi
        ' 
        chkFotografi.AutoSize = True
        chkFotografi.Location = New Point(18, 130)
        chkFotografi.Name = "chkFotografi"
        chkFotografi.Size = New Size(111, 29)
        chkFotografi.TabIndex = 6
        chkFotografi.Text = "Fotografi"
        chkFotografi.UseVisualStyleBackColor = True
        ' 
        ' chkTraveling
        ' 
        chkTraveling.AutoSize = True
        chkTraveling.Location = New Point(172, 100)
        chkTraveling.Name = "chkTraveling"
        chkTraveling.Size = New Size(107, 29)
        chkTraveling.TabIndex = 5
        chkTraveling.Text = "Traveling"
        chkTraveling.UseVisualStyleBackColor = True
        ' 
        ' chkMembaca
        ' 
        chkMembaca.AutoSize = True
        chkMembaca.Location = New Point(19, 100)
        chkMembaca.Name = "chkMembaca"
        chkMembaca.Size = New Size(116, 29)
        chkMembaca.TabIndex = 4
        chkMembaca.Text = "Membaca"
        chkMembaca.UseVisualStyleBackColor = True
        ' 
        ' chkOlahraga
        ' 
        chkOlahraga.AutoSize = True
        chkOlahraga.Location = New Point(172, 65)
        chkOlahraga.Name = "chkOlahraga"
        chkOlahraga.Size = New Size(110, 29)
        chkOlahraga.TabIndex = 3
        chkOlahraga.Text = "Olahraga"
        chkOlahraga.UseVisualStyleBackColor = True
        ' 
        ' chkMenonton
        ' 
        chkMenonton.AutoSize = True
        chkMenonton.Location = New Point(18, 65)
        chkMenonton.Name = "chkMenonton"
        chkMenonton.Size = New Size(121, 29)
        chkMenonton.TabIndex = 2
        chkMenonton.Text = "Menonton"
        chkMenonton.UseVisualStyleBackColor = True
        ' 
        ' chkMusik
        ' 
        chkMusik.AutoSize = True
        chkMusik.Location = New Point(172, 30)
        chkMusik.Name = "chkMusik"
        chkMusik.Size = New Size(85, 29)
        chkMusik.TabIndex = 1
        chkMusik.Text = "Musik"
        chkMusik.UseVisualStyleBackColor = True
        ' 
        ' chkGame
        ' 
        chkGame.AutoSize = True
        chkGame.Location = New Point(18, 30)
        chkGame.Name = "chkGame"
        chkGame.Size = New Size(84, 29)
        chkGame.TabIndex = 0
        chkGame.Text = "Game"
        chkGame.UseVisualStyleBackColor = True
        ' 
        ' BtnCetakKartu
        ' 
        BtnCetakKartu.BackColor = Color.OrangeRed
        BtnCetakKartu.FlatStyle = FlatStyle.Flat
        BtnCetakKartu.ForeColor = SystemColors.ButtonHighlight
        BtnCetakKartu.Location = New Point(271, 473)
        BtnCetakKartu.Name = "BtnCetakKartu"
        BtnCetakKartu.Size = New Size(588, 34)
        BtnCetakKartu.TabIndex = 9
        BtnCetakKartu.Text = "Cetak Kartu"
        BtnCetakKartu.UseVisualStyleBackColor = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(268, 68)
        Label1.Name = "Label1"
        Label1.Size = New Size(59, 25)
        Label1.TabIndex = 10
        Label1.Text = "Nama"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(271, 105)
        Label2.Name = "Label2"
        Label2.Size = New Size(56, 25)
        Label2.TabIndex = 11
        Label2.Text = "Umur"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(271, 142)
        Label3.Name = "Label3"
        Label3.Size = New Size(115, 25)
        Label3.TabIndex = 12
        Label3.Text = "Tanggal Lahir"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(271, 179)
        Label4.Name = "Label4"
        Label4.Size = New Size(135, 25)
        Label4.TabIndex = 13
        Label4.Text = "Nomor Telepon"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(271, 219)
        Label5.Name = "Label5"
        Label5.Size = New Size(68, 25)
        Label5.TabIndex = 14
        Label5.Text = "Alamat"
        ' 
        ' PictureBox2
        ' 
        PictureBox2.BackColor = Color.Transparent
        PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), Image)
        PictureBox2.Location = New Point(3, 8)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(152, 49)
        PictureBox2.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox2.TabIndex = 15
        PictureBox2.TabStop = False
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.Black
        Panel1.Controls.Add(PictureBox2)
        Panel1.Controls.Add(Label6)
        Panel1.Location = New Point(0, 1)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(884, 61)
        Panel1.TabIndex = 16
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.BackColor = Color.Transparent
        Label6.Font = New Font("Segoe UI", 20F)
        Label6.ForeColor = SystemColors.ButtonFace
        Label6.Location = New Point(268, 3)
        Label6.Name = "Label6"
        Label6.Size = New Size(398, 54)
        Label6.TabIndex = 16
        Label6.Text = "Data Profil Pengguna"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(882, 516)
        Controls.Add(Panel1)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(BtnCetakKartu)
        Controls.Add(GBHobby)
        Controls.Add(GBJK)
        Controls.Add(DTPTL)
        Controls.Add(txtAlamat)
        Controls.Add(txtNomorTelepon)
        Controls.Add(txtUmur)
        Controls.Add(txtNama)
        Controls.Add(BtnBrowse)
        Controls.Add(PictureBox1)
        Name = "Form1"
        Text = "Form1"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        GBJK.ResumeLayout(False)
        GBJK.PerformLayout()
        GBHobby.ResumeLayout(False)
        GBHobby.PerformLayout()
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents BtnBrowse As Button
    Friend WithEvents txtNama As TextBox
    Friend WithEvents txtUmur As TextBox
    Friend WithEvents txtNomorTelepon As TextBox
    Friend WithEvents txtAlamat As TextBox
    Friend WithEvents DTPTL As DateTimePicker
    Friend WithEvents GBJK As GroupBox
    Friend WithEvents GBHobby As GroupBox
    Friend WithEvents RBP As RadioButton
    Friend WithEvents RBL As RadioButton
    Friend WithEvents BtnCetakKartu As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents chkMemasak As CheckBox
    Friend WithEvents chkFotografi As CheckBox
    Friend WithEvents chkTraveling As CheckBox
    Friend WithEvents chkMembaca As CheckBox
    Friend WithEvents chkOlahraga As CheckBox
    Friend WithEvents chkMenonton As CheckBox
    Friend WithEvents chkMusik As CheckBox
    Friend WithEvents chkGame As CheckBox
    Friend WithEvents chkMenulis As CheckBox
    Friend WithEvents chkMenggambar As CheckBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label6 As Label

End Class
