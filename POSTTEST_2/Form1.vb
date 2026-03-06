Public Class Form1

    Public Judul As String
    Public Genre As String
    Public index As Integer

    Private Sub BtnTambah_Click(sender As Object, e As EventArgs) Handles BtnTambah.Click

        If txtTambahJudul.Text = "" Or txtTambahGenre.Text = "" Then
            MessageBox.Show("Judul dan Genre harus diisi")
            Exit Sub
        End If

        Judul = txtTambahJudul.Text
        Genre = txtTambahGenre.Text

        Module1.TambahBuku(Judul, Genre)

        TampilkanData()

    End Sub


    Private Sub BtnHapus_Click(sender As Object, e As EventArgs) Handles BtnHapus.Click

        Judul = txtHapusJudul.Text

        index = Module1.CariIndexBuku(Judul)

        If index <> -1 Then
            Module1.HapusBuku(index)
        Else
            MessageBox.Show("Buku tidak ditemukan")
        End If

        tampilkanData()

    End Sub


    Private Sub TampilkanData()

        DGV1.Rows.Clear()
        For i As Integer = 0 To Module1.JumlahBuku - 1
            DGV1.Rows.Add(Module1.DaftarBuku(i, 0),
                          Module1.DaftarBuku(i, 1))
        Next

    End Sub


    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

End Class