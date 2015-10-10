Public Class Kalkulator
    Dim masukanpertama As Integer
    Dim masukankedua As Integer
    Dim pilihan As Boolean
    Dim perhitungan As String


    'method 1
    Private Sub masukanmethod(ByVal numb As Char)
        If Me.pilihan = True Then
            If Me.TextBox1.Text = "0" Then
                Me.TextBox1.Text = Convert.ToString(numb)
            Else
                Dim TextBox1 As TextBox = Me.TextBox1
                TextBox1.Text = TextBox1.Text & Convert.ToString(numb)
            End If
        Else

            Me.TextBox1.Text = Convert.ToString(numb)
            Me.pilihan = True
        End If
    End Sub
    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Me.masukanmethod("7")
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        Me.masukanmethod("8")
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        Me.masukanmethod("9")
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Me.masukanmethod("4")
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Me.masukanmethod("5")
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Me.masukanmethod("6")
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.masukanmethod("1")
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.masukanmethod("2")
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.masukanmethod("3")
    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        Me.masukanmethod("0")
    End Sub

    'method 2
    Private Sub masukanmethodproses(ByVal operasi As String)
        If Me.TextBox1.Text <> "0" Then
            If Me.perhitungan = String.Empty Then
                Me.masukanpertama = Convert.ToInt32(Me.TextBox1.Text)
                Me.TextBox1.Text = Me.masukanpertama.ToString
                Me.pilihan = False
            Else
                'proses + -
                Me.masukankedua = Convert.ToInt32(Me.TextBox1.Text)

                Select Case Me.perhitungan
                    Case "tambah"
                        Me.masukanpertama = Me.masukanpertama + Me.masukankedua
                        Exit Select
                    Case "kurangi"
                        Me.masukanpertama = Me.masukanpertama - Me.masukankedua
                        Exit Select
                    Case "kali"
                        Me.masukanpertama = Me.masukanpertama * Me.masukankedua
                        Exit Select
                    Case "bagi"
                        Me.masukanpertama = Me.masukanpertama / Me.masukankedua
                        Exit Select

                End Select

                Me.TextBox1.Text = Me.masukanpertama.ToString

                Me.pilihan = False

            End If
            Me.perhitungan = operasi
        End If
    End Sub

    Private Sub minus_Click(sender As Object, e As EventArgs) Handles minus.Click
        Me.masukanmethodproses("kurangi")
    End Sub

    Private Sub plus_Click(sender As Object, e As EventArgs) Handles plus.Click
        Me.masukanmethodproses("tambah")
    End Sub

    Private Sub kali_Click(sender As Object, e As EventArgs) Handles kali.Click
        Me.masukanmethodproses("kali")
    End Sub
    Private Sub Bagi_Click(sender As Object, e As EventArgs) Handles Bagi.Click
        Me.masukanmethodproses("bagi")
    End Sub


   
    Private Sub clearr_Click(sender As Object, e As EventArgs) Handles clearr.Click
        Me.TextBox1.Text = "0"

        Me.masukanpertama = 0

        Me.perhitungan = String.Empty
    End Sub


    Private Sub samadengan_Click(sender As Object, e As EventArgs) Handles samadengan.Click
        If Me.TextBox1.Text <> "0" And Me.masukanpertama <> 0 Then

            'proses + -
            Me.masukankedua = Convert.ToInt32(Me.TextBox1.Text)

            Select Case Me.perhitungan
                Case "tambah"
                    Me.masukanpertama = Me.masukanpertama + Me.masukankedua
                    Exit Select
                Case "kurangi"
                    Me.masukanpertama = Me.masukanpertama - Me.masukankedua
                    Exit Select
                Case "kali"
                    Me.masukanpertama = Me.masukanpertama * Me.masukankedua
                    Exit Select
                Case "bagi"
                    Me.masukanpertama = Me.masukanpertama / Me.masukankedua
                    Exit Select
            End Select

            Me.TextBox1.Text = Me.masukanpertama.ToString

            Me.pilihan = False

            Me.perhitungan = String.Empty

        End If
    End Sub

   
  
End Class
