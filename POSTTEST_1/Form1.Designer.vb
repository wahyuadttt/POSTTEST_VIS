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
        IPSemester = New Label()
        IPKumulatif = New Label()
        InputIP = New TextBox()
        OutputIP = New TextBox()
        TmblTambah = New Button()
        TmblReset = New Button()
        lblPredikat = New Label()
        SuspendLayout()
        ' 
        ' IPSemester
        ' 
        IPSemester.AutoSize = True
        IPSemester.Location = New Point(192, 98)
        IPSemester.Name = "IPSemester"
        IPSemester.Size = New Size(105, 25)
        IPSemester.TabIndex = 0
        IPSemester.Text = "IP Semester"
        ' 
        ' IPKumulatif
        ' 
        IPKumulatif.AutoSize = True
        IPKumulatif.Location = New Point(190, 246)
        IPKumulatif.Name = "IPKumulatif"
        IPKumulatif.Size = New Size(107, 25)
        IPKumulatif.TabIndex = 1
        IPKumulatif.Text = "IP Kumulatif"
        ' 
        ' InputIP
        ' 
        InputIP.Location = New Point(352, 105)
        InputIP.Name = "InputIP"
        InputIP.Size = New Size(186, 31)
        InputIP.TabIndex = 2
        ' 
        ' OutputIP
        ' 
        OutputIP.Location = New Point(352, 240)
        OutputIP.Name = "OutputIP"
        OutputIP.Size = New Size(186, 31)
        OutputIP.TabIndex = 3
        ' 
        ' TmblTambah
        ' 
        TmblTambah.Location = New Point(352, 175)
        TmblTambah.Name = "TmblTambah"
        TmblTambah.Size = New Size(84, 34)
        TmblTambah.TabIndex = 4
        TmblTambah.Text = "Tambah"
        TmblTambah.UseVisualStyleBackColor = True
        ' 
        ' TmblReset
        ' 
        TmblReset.Location = New Point(454, 175)
        TmblReset.Name = "TmblReset"
        TmblReset.Size = New Size(84, 34)
        TmblReset.TabIndex = 5
        TmblReset.Text = "Reset"
        TmblReset.UseVisualStyleBackColor = True
        ' 
        ' lblPredikat
        ' 
        lblPredikat.AutoSize = True
        lblPredikat.Location = New Point(362, 311)
        lblPredikat.Name = "lblPredikat"
        lblPredikat.Size = New Size(29, 25)
        lblPredikat.TabIndex = 6
        lblPredikat.Text = " - "
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(841, 450)
        Controls.Add(lblPredikat)
        Controls.Add(TmblReset)
        Controls.Add(TmblTambah)
        Controls.Add(OutputIP)
        Controls.Add(InputIP)
        Controls.Add(IPKumulatif)
        Controls.Add(IPSemester)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents IPSemester As Label
    Friend WithEvents IPKumulatif As Label
    Friend WithEvents InputIP As TextBox
    Friend WithEvents OutputIP As TextBox
    Friend WithEvents TmblTambah As Button
    Friend WithEvents TmblReset As Button
    Friend WithEvents lblPredikat As Label

End Class
