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
        Panel1 = New Panel()
        Panel2 = New Panel()
        btnLoginGuest = New Button()
        btnLoginAdmin = New Button()
        PictureBox1 = New PictureBox()
        Panel2.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.SlateGray
        Panel1.Location = New Point(1, 1)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(802, 65)
        Panel1.TabIndex = 0
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = Color.DarkGray
        Panel2.Controls.Add(PictureBox1)
        Panel2.Controls.Add(btnLoginGuest)
        Panel2.Controls.Add(btnLoginAdmin)
        Panel2.Location = New Point(1, 47)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(802, 402)
        Panel2.TabIndex = 1
        ' 
        ' btnLoginGuest
        ' 
        btnLoginGuest.Location = New Point(450, 212)
        btnLoginGuest.Name = "btnLoginGuest"
        btnLoginGuest.Size = New Size(171, 60)
        btnLoginGuest.TabIndex = 1
        btnLoginGuest.Text = "Login Sebagai Guest"
        btnLoginGuest.UseVisualStyleBackColor = True
        ' 
        ' btnLoginAdmin
        ' 
        btnLoginAdmin.Location = New Point(450, 85)
        btnLoginAdmin.Name = "btnLoginAdmin"
        btnLoginAdmin.Size = New Size(171, 60)
        btnLoginAdmin.TabIndex = 0
        btnLoginAdmin.Text = "Login Admin"
        btnLoginAdmin.UseVisualStyleBackColor = True
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(0, 0)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(255, 404)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 8
        PictureBox1.TabStop = False
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(Panel2)
        Controls.Add(Panel1)
        Name = "Form1"
        Text = "Form1"
        Panel2.ResumeLayout(False)
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents btnLoginGuest As Button
    Friend WithEvents btnLoginAdmin As Button
    Friend WithEvents PictureBox1 As PictureBox

End Class
