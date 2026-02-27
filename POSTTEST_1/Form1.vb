Public Class Form1

    Dim totalIP As Double
    Dim jumlahSemester As Integer
    Dim ip As Double
    Dim ipk As Double
    Dim nilaiPredikat As String

    Private Sub TmblTambah_Click(sender As Object, e As EventArgs) Handles TmblTambah.Click
        If Double.TryParse(InputIP.Text, ip) Then

            totalIP = totalIP + ip
            jumlahSemester = jumlahSemester + 1

            ipk = totalIP / jumlahSemester
            OutputIP.Text = ipk.ToString("0.00")

            If ipk >= 2.0 And ipk <= 2.75 Then
                nilaiPredikat = "Cukup"
            ElseIf ipk >= 2.76 And ipk <= 3.0 Then
                nilaiPredikat = "Memuaskan"
            ElseIf ipk >= 3.01 Then
                nilaiPredikat = "Sangat Memuaskan"
            Else
                nilaiPredikat = "-"
            End If

            lblPredikat.Text = nilaiPredikat
            InputIP.Clear()
            InputIP.Focus()

        Else
            MessageBox.Show("Input harus angka!")
        End If
    End Sub

    Private Sub TmblReset_Click(sender As Object, e As EventArgs) Handles TmblReset.Click
        totalIP = 0
        jumlahSemester = 0
        ipk = 0
        nilaiPredikat = ""

        InputIP.Clear()
        OutputIP.Clear()
        lblPredikat.Text = "-"
        InputIP.Focus()
    End Sub

End Class