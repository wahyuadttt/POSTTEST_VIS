<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DashboardUser
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
        Panel2 = New Panel()
        TabControl1 = New TabControl()
        TPPembalap = New TabPage()
        dgvPembalap = New DataGridView()
        txtSearchPembalap = New TextBox()
        TPTim = New TabPage()
        dgvTim = New DataGridView()
        txtSearchTim = New TextBox()
        TPRace = New TabPage()
        dgvRace = New DataGridView()
        txtSearchRace = New TextBox()
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
        MenuStrip2.SuspendLayout()
        SuspendLayout()
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = Color.LightGray
        Panel2.Controls.Add(TabControl1)
        Panel2.Location = New Point(-1, 35)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(1039, 359)
        Panel2.TabIndex = 5
        ' 
        ' TabControl1
        ' 
        TabControl1.Controls.Add(TPPembalap)
        TabControl1.Controls.Add(TPTim)
        TabControl1.Controls.Add(TPRace)
        TabControl1.Location = New Point(3, 3)
        TabControl1.Name = "TabControl1"
        TabControl1.SelectedIndex = 0
        TabControl1.Size = New Size(1024, 331)
        TabControl1.TabIndex = 3
        ' 
        ' TPPembalap
        ' 
        TPPembalap.BackColor = Color.Gainsboro
        TPPembalap.Controls.Add(dgvPembalap)
        TPPembalap.Controls.Add(txtSearchPembalap)
        TPPembalap.Location = New Point(4, 34)
        TPPembalap.Name = "TPPembalap"
        TPPembalap.Padding = New Padding(3)
        TPPembalap.Size = New Size(1016, 293)
        TPPembalap.TabIndex = 0
        TPPembalap.Text = "Pembalap"
        ' 
        ' dgvPembalap
        ' 
        dgvPembalap.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvPembalap.Location = New Point(6, 59)
        dgvPembalap.Name = "dgvPembalap"
        dgvPembalap.ReadOnly = True
        dgvPembalap.RowHeadersWidth = 62
        dgvPembalap.Size = New Size(1004, 228)
        dgvPembalap.TabIndex = 10
        ' 
        ' txtSearchPembalap
        ' 
        txtSearchPembalap.ForeColor = Color.Gray
        txtSearchPembalap.Location = New Point(6, 15)
        txtSearchPembalap.Name = "txtSearchPembalap"
        txtSearchPembalap.Size = New Size(1004, 31)
        txtSearchPembalap.TabIndex = 9
        txtSearchPembalap.Text = "Search"
        ' 
        ' TPTim
        ' 
        TPTim.BackColor = Color.Gainsboro
        TPTim.Controls.Add(dgvTim)
        TPTim.Controls.Add(txtSearchTim)
        TPTim.Location = New Point(4, 34)
        TPTim.Name = "TPTim"
        TPTim.Padding = New Padding(3)
        TPTim.Size = New Size(1016, 293)
        TPTim.TabIndex = 1
        TPTim.Text = "Tim"
        ' 
        ' dgvTim
        ' 
        dgvTim.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvTim.Location = New Point(6, 60)
        dgvTim.Name = "dgvTim"
        dgvTim.ReadOnly = True
        dgvTim.RowHeadersWidth = 62
        dgvTim.Size = New Size(1004, 227)
        dgvTim.TabIndex = 26
        ' 
        ' txtSearchTim
        ' 
        txtSearchTim.ForeColor = Color.Gray
        txtSearchTim.Location = New Point(6, 20)
        txtSearchTim.Name = "txtSearchTim"
        txtSearchTim.Size = New Size(1004, 31)
        txtSearchTim.TabIndex = 25
        txtSearchTim.Text = "Search"
        ' 
        ' TPRace
        ' 
        TPRace.BackColor = Color.Gainsboro
        TPRace.Controls.Add(dgvRace)
        TPRace.Controls.Add(txtSearchRace)
        TPRace.Location = New Point(4, 34)
        TPRace.Name = "TPRace"
        TPRace.Padding = New Padding(3)
        TPRace.Size = New Size(1016, 293)
        TPRace.TabIndex = 2
        TPRace.Text = "Race"
        ' 
        ' dgvRace
        ' 
        dgvRace.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvRace.Location = New Point(6, 64)
        dgvRace.Name = "dgvRace"
        dgvRace.ReadOnly = True
        dgvRace.RowHeadersWidth = 62
        dgvRace.Size = New Size(1004, 223)
        dgvRace.TabIndex = 42
        ' 
        ' txtSearchRace
        ' 
        txtSearchRace.ForeColor = Color.Gray
        txtSearchRace.Location = New Point(6, 17)
        txtSearchRace.Name = "txtSearchRace"
        txtSearchRace.Size = New Size(1004, 31)
        txtSearchRace.TabIndex = 41
        txtSearchRace.Text = "Search"
        ' 
        ' MenuStrip2
        ' 
        MenuStrip2.BackColor = Color.SlateGray
        MenuStrip2.ImageScalingSize = New Size(24, 24)
        MenuStrip2.Items.AddRange(New ToolStripItem() {mnuPembalap, mnuTim, mnuRace, mnuKeluar})
        MenuStrip2.Location = New Point(0, 0)
        MenuStrip2.Name = "MenuStrip2"
        MenuStrip2.Size = New Size(1038, 33)
        MenuStrip2.TabIndex = 6
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
        ' DashboardUser
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1038, 366)
        Controls.Add(Panel2)
        Controls.Add(MenuStrip2)
        MainMenuStrip = MenuStrip2
        Name = "DashboardUser"
        Text = "DashboardUser"
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
        MenuStrip2.ResumeLayout(False)
        MenuStrip2.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents Panel2 As Panel
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TPPembalap As TabPage
    Friend WithEvents dgvPembalap As DataGridView
    Friend WithEvents txtSearchPembalap As TextBox
    Friend WithEvents TPTim As TabPage
    Friend WithEvents dgvTim As DataGridView
    Friend WithEvents txtSearchTim As TextBox
    Friend WithEvents TPRace As TabPage
    Friend WithEvents dgvRace As DataGridView
    Friend WithEvents txtSearchRace As TextBox
    Friend WithEvents MenuStrip2 As MenuStrip
    Friend WithEvents mnuPembalap As ToolStripMenuItem
    Friend WithEvents mnuTim As ToolStripMenuItem
    Friend WithEvents mnuRace As ToolStripMenuItem
    Friend WithEvents mnuKeluar As ToolStripMenuItem
End Class
