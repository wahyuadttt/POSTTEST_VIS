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
        Dim GroupBox1 As GroupBox
        BtnTambah = New Button()
        LblTambah = New Label()
        txtTambahGenre = New TextBox()
        LblTambahJudul = New Label()
        LblGenre = New Label()
        txtTambahJudul = New TextBox()
        BtnHapus = New Button()
        txtHapusJudul = New TextBox()
        LblHapusJudul = New Label()
        DGV1 = New DataGridView()
        KolomJudul = New DataGridViewTextBoxColumn()
        KolomGenre = New DataGridViewTextBoxColumn()
        GroupBox2 = New GroupBox()
        LblJudul = New Label()
        GroupBox1 = New GroupBox()
        GroupBox1.SuspendLayout()
        CType(DGV1, ComponentModel.ISupportInitialize).BeginInit()
        GroupBox2.SuspendLayout()
        SuspendLayout()
        ' 
        ' GroupBox1
        ' 
        GroupBox1.BackColor = SystemColors.ActiveCaption
        GroupBox1.Controls.Add(BtnTambah)
        GroupBox1.Controls.Add(LblTambah)
        GroupBox1.Controls.Add(txtTambahGenre)
        GroupBox1.Controls.Add(LblTambahJudul)
        GroupBox1.Controls.Add(LblGenre)
        GroupBox1.Controls.Add(txtTambahJudul)
        GroupBox1.Location = New Point(41, 63)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(369, 168)
        GroupBox1.TabIndex = 4
        GroupBox1.TabStop = False
        GroupBox1.Text = "Tambah Buku"
        ' 
        ' BtnTambah
        ' 
        BtnTambah.BackColor = Color.LightGreen
        BtnTambah.Location = New Point(217, 123)
        BtnTambah.Name = "BtnTambah"
        BtnTambah.Size = New Size(112, 34)
        BtnTambah.TabIndex = 4
        BtnTambah.Text = "Tambah"
        BtnTambah.UseVisualStyleBackColor = False
        ' 
        ' LblTambah
        ' 
        LblTambah.AutoSize = True
        LblTambah.Location = New Point(59, 76)
        LblTambah.Name = "LblTambah"
        LblTambah.Size = New Size(0, 25)
        LblTambah.TabIndex = 0
        ' 
        ' txtTambahGenre
        ' 
        txtTambahGenre.Location = New Point(179, 83)
        txtTambahGenre.Name = "txtTambahGenre"
        txtTambahGenre.Size = New Size(150, 31)
        txtTambahGenre.TabIndex = 3
        ' 
        ' LblTambahJudul
        ' 
        LblTambahJudul.AutoSize = True
        LblTambahJudul.Location = New Point(32, 38)
        LblTambahJudul.Name = "LblTambahJudul"
        LblTambahJudul.Size = New Size(97, 25)
        LblTambahJudul.TabIndex = 0
        LblTambahJudul.Text = "Judul Buku"
        ' 
        ' LblGenre
        ' 
        LblGenre.AutoSize = True
        LblGenre.Location = New Point(30, 83)
        LblGenre.Name = "LblGenre"
        LblGenre.Size = New Size(58, 25)
        LblGenre.TabIndex = 1
        LblGenre.Text = "Genre"
        ' 
        ' txtTambahJudul
        ' 
        txtTambahJudul.Location = New Point(179, 38)
        txtTambahJudul.Name = "txtTambahJudul"
        txtTambahJudul.Size = New Size(150, 31)
        txtTambahJudul.TabIndex = 2
        ' 
        ' BtnHapus
        ' 
        BtnHapus.BackColor = Color.LightCoral
        BtnHapus.Location = New Point(215, 123)
        BtnHapus.Name = "BtnHapus"
        BtnHapus.Size = New Size(112, 34)
        BtnHapus.TabIndex = 5
        BtnHapus.Text = "Hapus"
        BtnHapus.UseVisualStyleBackColor = False
        ' 
        ' txtHapusJudul
        ' 
        txtHapusJudul.Location = New Point(177, 41)
        txtHapusJudul.Name = "txtHapusJudul"
        txtHapusJudul.Size = New Size(150, 31)
        txtHapusJudul.TabIndex = 4
        ' 
        ' LblHapusJudul
        ' 
        LblHapusJudul.AutoSize = True
        LblHapusJudul.Location = New Point(29, 41)
        LblHapusJudul.Name = "LblHapusJudul"
        LblHapusJudul.Size = New Size(97, 25)
        LblHapusJudul.TabIndex = 2
        LblHapusJudul.Text = "Judul Buku"
        ' 
        ' DGV1
        ' 
        DGV1.BackgroundColor = Color.Gainsboro
        DGV1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DGV1.Columns.AddRange(New DataGridViewColumn() {KolomJudul, KolomGenre})
        DGV1.Location = New Point(212, 246)
        DGV1.Name = "DGV1"
        DGV1.RowHeadersWidth = 62
        DGV1.Size = New Size(364, 192)
        DGV1.TabIndex = 3
        ' 
        ' KolomJudul
        ' 
        KolomJudul.HeaderText = "Judul"
        KolomJudul.MinimumWidth = 8
        KolomJudul.Name = "KolomJudul"
        KolomJudul.Width = 150
        ' 
        ' KolomGenre
        ' 
        KolomGenre.HeaderText = "Genre"
        KolomGenre.MinimumWidth = 8
        KolomGenre.Name = "KolomGenre"
        KolomGenre.Width = 150
        ' 
        ' GroupBox2
        ' 
        GroupBox2.BackColor = SystemColors.ActiveCaption
        GroupBox2.Controls.Add(BtnHapus)
        GroupBox2.Controls.Add(LblHapusJudul)
        GroupBox2.Controls.Add(txtHapusJudul)
        GroupBox2.Location = New Point(417, 63)
        GroupBox2.Name = "GroupBox2"
        GroupBox2.Size = New Size(357, 168)
        GroupBox2.TabIndex = 5
        GroupBox2.TabStop = False
        GroupBox2.Text = "Hapus Buku"
        ' 
        ' LblJudul
        ' 
        LblJudul.AutoSize = True
        LblJudul.Font = New Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        LblJudul.Location = New Point(235, 9)
        LblJudul.Name = "LblJudul"
        LblJudul.Size = New Size(357, 45)
        LblJudul.TabIndex = 6
        LblJudul.Text = "Sistem Informasi Buku"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(LblJudul)
        Controls.Add(GroupBox2)
        Controls.Add(DGV1)
        Controls.Add(GroupBox1)
        Name = "Form1"
        Text = "Form1"
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        CType(DGV1, ComponentModel.ISupportInitialize).EndInit()
        GroupBox2.ResumeLayout(False)
        GroupBox2.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents txtHapusJudul As TextBox
    Friend WithEvents LblHapusJudul As Label
    Friend WithEvents LblTambah As Label
    Friend WithEvents BtnHapus As Button
    Friend WithEvents DGV1 As DataGridView
    Friend WithEvents KolomJudul As DataGridViewTextBoxColumn
    Friend WithEvents KolomGenre As DataGridViewTextBoxColumn
    Friend WithEvents LblTambahJudul As Label
    Friend WithEvents LblGenre As Label
    Friend WithEvents txtTambahJudul As TextBox
    Friend WithEvents txtTambahGenre As TextBox
    Friend WithEvents BtnTambah As Button
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents LblJudul As Label

End Class
