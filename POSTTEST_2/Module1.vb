Module Module1

    Public DaftarBuku(99, 1) As String
    Public JumlahBuku As Integer = 0

    Public Sub TambahBuku(judul As String, genre As String)

        If JumlahBuku < 100 Then
            DaftarBuku(JumlahBuku, 0) = judul
            DaftarBuku(JumlahBuku, 1) = genre
            JumlahBuku += 1
        Else
            MessageBox.Show("Kapasitas buku sudah penuh.")
        End If

    End Sub

    Public Function CariIndexBuku(judul As String) As Integer

        For i As Integer = 0 To JumlahBuku - 1
            If DaftarBuku(i, 0).ToLower() = judul.ToLower() Then
                Return i
            End If
        Next

        Return -1

    End Function

    Public Sub HapusBuku(index As Integer)

        If index >= 0 And index < JumlahBuku Then

            For i As Integer = index To JumlahBuku - 2
                DaftarBuku(i, 0) = DaftarBuku(i + 1, 0)
                DaftarBuku(i, 1) = DaftarBuku(i + 1, 1)
            Next

            JumlahBuku -= 1
            DaftarBuku(JumlahBuku, 0) = Nothing
            DaftarBuku(JumlahBuku, 1) = Nothing

        Else
            MessageBox.Show("Judul buku tidak ditemukan.")
        End If

    End Sub

End Module