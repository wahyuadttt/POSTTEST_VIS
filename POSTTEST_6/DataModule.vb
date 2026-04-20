Imports MySqlConnector

Module DataModule

    Public Function GetAllPembalap() As DataTable
        Dim dt As New DataTable()
        Try
            Dim query As String =
                "SELECT p.id, p.nama, p.negara, p.nomor, " &
                "p.idTim, t.namaTim AS tim " &
                "FROM TabelPembalap p " &
                "INNER JOIN TabelTim t ON p.idTim = t.id " &
                "ORDER BY p.id ASC"
            Using conn As MySqlConnection = GetConnection()
                Using da As New MySqlDataAdapter(query, conn)
                    da.Fill(dt)
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Gagal menampilkan data pembalap: " & ex.Message,
                            "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        Return dt
    End Function


    Public Function SearchPembalap(keyword As String) As DataTable
        Dim dt As New DataTable()
        Try
            Dim query As String =
                "SELECT p.id, p.nama, p.negara, p.nomor, " &
                "p.idTim, t.namaTim AS tim " &
                "FROM TabelPembalap p " &
                "INNER JOIN TabelTim t ON p.idTim = t.id " &
                "WHERE p.nama LIKE @kw OR p.negara LIKE @kw " &
                "   OR p.nomor LIKE @kw OR t.namaTim LIKE @kw " &
                "ORDER BY p.id ASC"
            Using conn As MySqlConnection = GetConnection()
                Using da As New MySqlDataAdapter(query, conn)
                    da.SelectCommand.Parameters.AddWithValue("@kw", "%" & keyword & "%")
                    da.Fill(dt)
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Gagal mencari data pembalap: " & ex.Message,
                            "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        Return dt
    End Function

    Public Function SimpanPembalap(nama As String, negara As String,
                                   nomor As String, idTim As Integer) As Boolean
        Try
            Dim query As String =
                "INSERT INTO TabelPembalap (nama, negara, nomor, idTim) " &
                "VALUES (@nama, @negara, @nomor, @idTim)"
            Using conn As MySqlConnection = GetConnection()
                conn.Open()
                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@nama", nama)
                    cmd.Parameters.AddWithValue("@negara", negara)
                    cmd.Parameters.AddWithValue("@nomor", nomor)
                    cmd.Parameters.AddWithValue("@idTim", idTim)
                    cmd.ExecuteNonQuery()
                End Using
            End Using
            Return True
        Catch ex As Exception
            MessageBox.Show("Gagal menyimpan data pembalap: " & ex.Message,
                            "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End Try
    End Function

    Public Function UbahPembalap(id As Integer, nama As String, negara As String,
                                 nomor As String, idTim As Integer) As Boolean
        Try
            Dim query As String =
                "UPDATE TabelPembalap " &
                "SET nama=@nama, negara=@negara, nomor=@nomor, idTim=@idTim " &
                "WHERE id=@id"
            Using conn As MySqlConnection = GetConnection()
                conn.Open()
                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@id", id)
                    cmd.Parameters.AddWithValue("@nama", nama)
                    cmd.Parameters.AddWithValue("@negara", negara)
                    cmd.Parameters.AddWithValue("@nomor", nomor)
                    cmd.Parameters.AddWithValue("@idTim", idTim)
                    Return cmd.ExecuteNonQuery() > 0
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Gagal mengubah data pembalap: " & ex.Message,
                            "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End Try
    End Function

    Public Function HapusPembalap(id As Integer) As Boolean
        Try
            Dim query As String = "DELETE FROM TabelPembalap WHERE id=@id"
            Using conn As MySqlConnection = GetConnection()
                conn.Open()
                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@id", id)
                    Return cmd.ExecuteNonQuery() > 0
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Gagal menghapus data pembalap: " & ex.Message,
                            "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End Try
    End Function

    Public Function GetAllTim() As DataTable
        Dim dt As New DataTable()
        Try
            Dim query As String =
                "SELECT id, namaTim, negara, mesin, chasis " &
                "FROM TabelTim ORDER BY id ASC"
            Using conn As MySqlConnection = GetConnection()
                Using da As New MySqlDataAdapter(query, conn)
                    da.Fill(dt)
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Gagal menampilkan data tim: " & ex.Message,
                            "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        Return dt
    End Function

    Public Function SearchTim(keyword As String) As DataTable
        Dim dt As New DataTable()
        Try
            Dim query As String =
                "SELECT id, namaTim, negara, mesin, chasis FROM TabelTim " &
                "WHERE namaTim LIKE @kw OR negara LIKE @kw " &
                "   OR mesin LIKE @kw OR chasis LIKE @kw " &
                "ORDER BY id ASC"
            Using conn As MySqlConnection = GetConnection()
                Using da As New MySqlDataAdapter(query, conn)
                    da.SelectCommand.Parameters.AddWithValue("@kw", "%" & keyword & "%")
                    da.Fill(dt)
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Gagal mencari data tim: " & ex.Message,
                            "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        Return dt
    End Function

    Public Function SimpanTim(namaTim As String, negara As String,
                               mesin As String, chasis As String) As Boolean
        Try
            Dim query As String =
                "INSERT INTO TabelTim (namaTim, negara, mesin, chasis) " &
                "VALUES (@namaTim, @negara, @mesin, @chasis)"
            Using conn As MySqlConnection = GetConnection()
                conn.Open()
                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@namaTim", namaTim)
                    cmd.Parameters.AddWithValue("@negara", negara)
                    cmd.Parameters.AddWithValue("@mesin", mesin)
                    cmd.Parameters.AddWithValue("@chasis", chasis)
                    cmd.ExecuteNonQuery()
                End Using
            End Using
            Return True
        Catch ex As Exception
            MessageBox.Show("Gagal menyimpan data tim: " & ex.Message,
                            "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End Try
    End Function

    Public Function UbahTim(id As Integer, namaTim As String, negara As String,
                             mesin As String, chasis As String) As Boolean
        Try
            Dim query As String =
                "UPDATE TabelTim " &
                "SET namaTim=@namaTim, negara=@negara, mesin=@mesin, chasis=@chasis " &
                "WHERE id=@id"
            Using conn As MySqlConnection = GetConnection()
                conn.Open()
                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@id", id)
                    cmd.Parameters.AddWithValue("@namaTim", namaTim)
                    cmd.Parameters.AddWithValue("@negara", negara)
                    cmd.Parameters.AddWithValue("@mesin", mesin)
                    cmd.Parameters.AddWithValue("@chasis", chasis)
                    Return cmd.ExecuteNonQuery() > 0
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Gagal mengubah data tim: " & ex.Message,
                            "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End Try
    End Function

    Public Function HapusTim(id As Integer) As Boolean
        Try
            Dim query As String = "DELETE FROM TabelTim WHERE id=@id"
            Using conn As MySqlConnection = GetConnection()
                conn.Open()
                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@id", id)
                    Return cmd.ExecuteNonQuery() > 0
                End Using
            End Using
        Catch ex As Exception
            If ex.Message.ToLower().Contains("foreign key") OrElse
               ex.Message.ToLower().Contains("a foreign") Then
                MessageBox.Show(
                    "Tim tidak dapat dihapus karena masih memiliki pembalap yang terdaftar." &
                    Environment.NewLine & "Hapus atau pindahkan pembalap terlebih dahulu.",
                    "Peringatan Foreign Key",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Else
                MessageBox.Show("Gagal menghapus data tim: " & ex.Message,
                                "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
            Return False
        End Try
    End Function

    Public Function GetTimUntukComboBox() As DataTable
        Dim dt As New DataTable()
        Try
            Dim query As String =
                "SELECT id, namaTim FROM TabelTim ORDER BY namaTim ASC"
            Using conn As MySqlConnection = GetConnection()
                Using da As New MySqlDataAdapter(query, conn)
                    da.Fill(dt)
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Gagal mengambil data tim: " & ex.Message,
                            "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        Return dt
    End Function


    Public Function GetAllRace() As DataTable
        Dim dt As New DataTable()
        Try
            Dim query As String =
                "SELECT id, namaRace, lokasi, tanggal, putaran " &
                "FROM TabelRace ORDER BY id ASC"
            Using conn As MySqlConnection = GetConnection()
                Using da As New MySqlDataAdapter(query, conn)
                    da.Fill(dt)
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Gagal menampilkan data race: " & ex.Message,
                            "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        Return dt
    End Function

    Public Function SearchRace(keyword As String) As DataTable
        Dim dt As New DataTable()
        Try
            Dim query As String =
                "SELECT id, namaRace, lokasi, tanggal, putaran FROM TabelRace " &
                "WHERE namaRace LIKE @kw OR lokasi LIKE @kw OR putaran LIKE @kw " &
                "ORDER BY id ASC"
            Using conn As MySqlConnection = GetConnection()
                Using da As New MySqlDataAdapter(query, conn)
                    da.SelectCommand.Parameters.AddWithValue("@kw", "%" & keyword & "%")
                    da.Fill(dt)
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Gagal mencari data race: " & ex.Message,
                            "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        Return dt
    End Function

    Public Function SimpanRace(namaRace As String, lokasi As String,
                                tanggal As String, putaran As String) As Boolean
        Try
            Dim query As String =
                "INSERT INTO TabelRace (namaRace, lokasi, tanggal, putaran) " &
                "VALUES (@namaRace, @lokasi, @tanggal, @putaran)"
            Using conn As MySqlConnection = GetConnection()
                conn.Open()
                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@namaRace", namaRace)
                    cmd.Parameters.AddWithValue("@lokasi", lokasi)
                    cmd.Parameters.AddWithValue("@tanggal", tanggal)
                    cmd.Parameters.AddWithValue("@putaran", putaran)
                    cmd.ExecuteNonQuery()
                End Using
            End Using
            Return True
        Catch ex As Exception
            MessageBox.Show("Gagal menyimpan data race: " & ex.Message,
                            "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End Try
    End Function

    Public Function UbahRace(id As Integer, namaRace As String, lokasi As String,
                              tanggal As String, putaran As String) As Boolean
        Try
            Dim query As String =
                "UPDATE TabelRace " &
                "SET namaRace=@namaRace, lokasi=@lokasi, tanggal=@tanggal, putaran=@putaran " &
                "WHERE id=@id"
            Using conn As MySqlConnection = GetConnection()
                conn.Open()
                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@id", id)
                    cmd.Parameters.AddWithValue("@namaRace", namaRace)
                    cmd.Parameters.AddWithValue("@lokasi", lokasi)
                    cmd.Parameters.AddWithValue("@tanggal", tanggal)
                    cmd.Parameters.AddWithValue("@putaran", putaran)
                    Return cmd.ExecuteNonQuery() > 0
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Gagal mengubah data race: " & ex.Message,
                            "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End Try
    End Function

    Public Function HapusRace(id As Integer) As Boolean
        Try
            Dim query As String = "DELETE FROM TabelRace WHERE id=@id"
            Using conn As MySqlConnection = GetConnection()
                conn.Open()
                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@id", id)
                    Return cmd.ExecuteNonQuery() > 0
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Gagal menghapus data race: " & ex.Message,
                            "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End Try
    End Function

End Module