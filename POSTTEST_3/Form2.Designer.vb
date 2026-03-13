<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form2))
        PictureBox1 = New PictureBox()
        lblNama = New Label()
        lblUmur = New Label()
        lblTanggalLahir = New Label()
        lblNomorTelepon = New Label()
        lblHobby = New Label()
        lblAlamat = New Label()
        lblJenisKelamin = New Label()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        Label6 = New Label()
        Label7 = New Label()
        Panel2 = New Panel()
        Label8 = New Label()
        PictureBox2 = New PictureBox()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        Panel2.SuspendLayout()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Location = New Point(26, 90)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(255, 295)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 0
        PictureBox1.TabStop = False
        ' 
        ' lblNama
        ' 
        lblNama.AutoSize = True
        lblNama.Location = New Point(521, 90)
        lblNama.Name = "lblNama"
        lblNama.Size = New Size(63, 25)
        lblNama.TabIndex = 1
        lblNama.Text = "Label1"
        ' 
        ' lblUmur
        ' 
        lblUmur.AutoSize = True
        lblUmur.Location = New Point(521, 133)
        lblUmur.Name = "lblUmur"
        lblUmur.Size = New Size(63, 25)
        lblUmur.TabIndex = 2
        lblUmur.Text = "Label1"
        ' 
        ' lblTanggalLahir
        ' 
        lblTanggalLahir.AutoSize = True
        lblTanggalLahir.Location = New Point(521, 178)
        lblTanggalLahir.Name = "lblTanggalLahir"
        lblTanggalLahir.Size = New Size(63, 25)
        lblTanggalLahir.TabIndex = 3
        lblTanggalLahir.Text = "Label1"
        ' 
        ' lblNomorTelepon
        ' 
        lblNomorTelepon.AutoSize = True
        lblNomorTelepon.Location = New Point(521, 270)
        lblNomorTelepon.Name = "lblNomorTelepon"
        lblNomorTelepon.Size = New Size(63, 25)
        lblNomorTelepon.TabIndex = 4
        lblNomorTelepon.Text = "Label1"
        ' 
        ' lblHobby
        ' 
        lblHobby.AutoSize = True
        lblHobby.Location = New Point(521, 313)
        lblHobby.Name = "lblHobby"
        lblHobby.Size = New Size(63, 25)
        lblHobby.TabIndex = 5
        lblHobby.Text = "Label1"
        ' 
        ' lblAlamat
        ' 
        lblAlamat.AutoSize = True
        lblAlamat.Location = New Point(521, 360)
        lblAlamat.Name = "lblAlamat"
        lblAlamat.Size = New Size(63, 25)
        lblAlamat.TabIndex = 6
        lblAlamat.Text = "Label1"
        ' 
        ' lblJenisKelamin
        ' 
        lblJenisKelamin.AutoSize = True
        lblJenisKelamin.Location = New Point(521, 223)
        lblJenisKelamin.Name = "lblJenisKelamin"
        lblJenisKelamin.Size = New Size(63, 25)
        lblJenisKelamin.TabIndex = 7
        lblJenisKelamin.Text = "Label1"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(335, 223)
        Label1.Name = "Label1"
        Label1.Size = New Size(125, 25)
        Label1.TabIndex = 14
        Label1.Text = "Jenis Kelamin :"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(335, 360)
        Label2.Name = "Label2"
        Label2.Size = New Size(77, 25)
        Label2.TabIndex = 13
        Label2.Text = "Alamat :"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(335, 313)
        Label3.Name = "Label3"
        Label3.Size = New Size(76, 25)
        Label3.TabIndex = 12
        Label3.Text = "Hobby :"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(335, 270)
        Label4.Name = "Label4"
        Label4.Size = New Size(144, 25)
        Label4.TabIndex = 11
        Label4.Text = "Nomor Telepon :"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(335, 178)
        Label5.Name = "Label5"
        Label5.Size = New Size(124, 25)
        Label5.TabIndex = 10
        Label5.Text = "Tanggal Lahir :"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(335, 133)
        Label6.Name = "Label6"
        Label6.Size = New Size(65, 25)
        Label6.TabIndex = 9
        Label6.Text = "Umur :"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Location = New Point(335, 90)
        Label7.Name = "Label7"
        Label7.Size = New Size(68, 25)
        Label7.TabIndex = 8
        Label7.Text = "Nama :"
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = Color.Black
        Panel2.Controls.Add(Label8)
        Panel2.Controls.Add(PictureBox2)
        Panel2.Location = New Point(0, 2)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(800, 71)
        Panel2.TabIndex = 16
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.BackColor = Color.Transparent
        Label8.Font = New Font("Segoe UI", 20F)
        Label8.ForeColor = SystemColors.ButtonHighlight
        Label8.Location = New Point(240, 9)
        Label8.Name = "Label8"
        Label8.Size = New Size(398, 54)
        Label8.TabIndex = 1
        Label8.Text = "Data Profil Pengguna"
        ' 
        ' PictureBox2
        ' 
        PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), Image)
        PictureBox2.Location = New Point(12, 7)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(142, 56)
        PictureBox2.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox2.TabIndex = 0
        PictureBox2.TabStop = False
        ' 
        ' Form2
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(763, 404)
        Controls.Add(Panel2)
        Controls.Add(Label1)
        Controls.Add(Label2)
        Controls.Add(Label3)
        Controls.Add(Label4)
        Controls.Add(Label5)
        Controls.Add(Label6)
        Controls.Add(Label7)
        Controls.Add(lblJenisKelamin)
        Controls.Add(lblAlamat)
        Controls.Add(lblHobby)
        Controls.Add(lblNomorTelepon)
        Controls.Add(lblTanggalLahir)
        Controls.Add(lblUmur)
        Controls.Add(lblNama)
        Controls.Add(PictureBox1)
        Name = "Form2"
        Text = "Form2"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents lblNama As Label
    Friend WithEvents lblUmur As Label
    Friend WithEvents lblTanggalLahir As Label
    Friend WithEvents lblNomorTelepon As Label
    Friend WithEvents lblHobby As Label
    Friend WithEvents lblAlamat As Label
    Friend WithEvents lblJenisKelamin As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Label8 As Label
End Class
