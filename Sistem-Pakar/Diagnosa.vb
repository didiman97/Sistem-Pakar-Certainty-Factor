Imports System.Data.OleDb

Public Class Diagnosa
    Sub TampilData()
       
        Using koneksi As New OleDbConnection(Skripsi)
            Using cmd As New OleDbCommand("select * from Gejala ORDER By Kd_Gejala asc", koneksi)
                koneksi.Open()
                Using Data As OleDbDataReader = cmd.ExecuteReader
                    Dim x As Integer = 0
                    ListView1.Items.Clear()

                    While Data.Read
                        ListView1.Items.Add(Data("Kd_Gejala"))
                        ListView1.Items(x).SubItems.Add(Data("Nm_Gejala"))
                        x = x + 1
                    End While
                End Using
            End Using
        End Using
    End Sub
    Private Sub Diagnosa_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call TampilData()
        Refresh()
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Dim pasien As String = InputBox("Masukkan Nama Pasien")
        If pasien = "" Then
            pasien = InputBox("Masukkan Nama Anda Pasien")

        Else
            Dim jumlaharray As Integer = 0
            Dim gejalacek As String = ""

            Dim gejala As String = ""
            ListView2.Items.Clear()
            For Each b1 In ListView1.CheckedItems
                Dim a As String = Microsoft.VisualBasic.Mid(b1.ToString, 16, 3)

                jumlaharray = jumlaharray + 1

                Dim Kd_Gejala As String = ""
                Using koneksi1 As New OleDbConnection(Skripsi)
                    Using cmd1 As New OleDbCommand("select * from Gejala where Kd_Gejala = '" & a & "'", koneksi1)
                        koneksi1.Open()
                        Using Data1 As OleDbDataReader = cmd1.ExecuteReader
                            While Data1.Read


                                gejalacek = gejalacek & Data1("Nm_Gejala") & ", "
                            End While
                        End Using
                    End Using
                End Using
            Next
            Dim cfpakar(jumlaharray) As String
            For Each b1 In ListView1.CheckedItems
                Dim a As String = Microsoft.VisualBasic.Mid(b1.ToString, 16, 3)
            Next


            Using koneksi As New OleDbConnection(Skripsi)
                Using cmd As New OleDbCommand("select * from Penyakit order by Kd_Penyakit asc", koneksi)
                    koneksi.Open()
                    Using Data As OleDbDataReader = cmd.ExecuteReader
                        While Data.Read
                            Dim Penyakit As String = Data("Kd_Penyakit")
                            Dim NmPenyakit As String = Data("Nm_Penyakit")
                            Dim hasil As Double = 0
                            gejala = ""
                            Dim mdlama As Double = 0
                            Dim mblama As Double = 0
                            Dim Cflama As Double = 0
                            For Each b1 In ListView1.CheckedItems
                                Dim a As String = Microsoft.VisualBasic.Mid(b1.ToString, 16, 3)
                                Dim Kd_Gejala As String = ""
                                Using koneksi1 As New OleDbConnection(Skripsi)
                                    Using cmd1 As New OleDbCommand("select * from Gejala where Kd_Gejala= '" & a & "'", koneksi1)
                                        koneksi1.Open()
                                        Using Data1 As OleDbDataReader = cmd1.ExecuteReader
                                            While Data1.Read
                                                Kd_Gejala = a

                                                Using koneksi2 As New OleDbConnection(Skripsi)
                                                    Using cmd2 As New OleDbCommand("select * from Basis_Pengetahuan where Kd_Gejala= '" & Kd_Gejala & "' and Kd_Penyakit='" & Penyakit & "'", koneksi2)
                                                        koneksi2.Open()
                                                        Using Data2 As OleDbDataReader = cmd2.ExecuteReader
                                                            While Data2.Read
                                                                Dim mb = Data2("cf")
                                                                Dim md = Data2("md")
                                                                Dim cf As Double = mb - md
                                                                Cflama = Cflama + (cf * (1 - Cflama))
                                                                'mdlama = (mdlama + md) * (1 - mdlama)
                                                                mdlama = mdlama + md * ((1 - mdlama))
                                                                'mblama = (mblama + mb) * (1 - mblama)
                                                                mblama = mblama + mb * ((1 - mblama))
                                                                'Dim bobot As Double = mb - md
                                                                'hasil = hasil + (bobot * (1 - hasil))

                                                            End While
                                                        End Using
                                                    End Using
                                                End Using

                                            End While
                                        End Using
                                    End Using
                                End Using


                            Next
                            hasil = Cflama

                            ListView2.Items.Add(Penyakit)
                            ListView2.Items(ListView2.Items.Count - 1).SubItems.Add(NmPenyakit)
                            ListView2.Items(ListView2.Items.Count - 1).SubItems.Add(hasil)



                        End While
                    End Using
                End Using
            End Using


            ' pengecekan nilai tertinggi\
            Dim max As String = ""
            Dim max1 As Double = 0

            For i = 0 To ListView2.Items.Count - 1
                Dim n As Double = ListView2.Items(i).SubItems(2).Text.ToString
                If max1 < n Then
                    max = ListView2.Items(i).Text.ToString
                    max1 = n
                End If

            Next
            Dim Nm_Penyakit As String = ""
            Dim Saran As String = ""
            Using koneksi As New OleDbConnection(Skripsi)
                Using cmd As New OleDbCommand("select * from Penyakit where Kd_Penyakit='" & max & "'", koneksi)
                    koneksi.Open()
                    Using Data As OleDbDataReader = cmd.ExecuteReader
                        Dim x As Integer = 0
                        While Data.Read
                            Nm_Penyakit = Data("Nm_Penyakit")
                            Saran = Data("Saran")
                            x = x + 1
                        End While
                    End Using
                End Using
            End Using
            TextBox1.Text = Nm_Penyakit
            TextBox2.Text = max1
            TextBox3.Text = Saran
            Using Koneksi As New OleDbConnection(Skripsi)
                Using Cmd As New OleDbCommand("delete * from Diagnosa", Koneksi)
                    Koneksi.Open()
                    Cmd.CommandType = CommandType.Text
                    Cmd.ExecuteNonQuery()
                End Using
            End Using
            Dim keterangan As String = Nm_Penyakit & " dengan nilai CF = " & max1
            Using koneksi As New OleDbConnection(Skripsi)
                Using Cmd As New OleDbCommand("insert into Diagnosa values('" & _
                                              DateTimePicker1.Value & "','" & _
                                              pasien & "','" & _
                                              gejalacek & "','" & _
                                               keterangan & "','" & _
                                             Saran & "')", koneksi)
                    koneksi.Open()
                    Cmd.CommandType = CommandType.Text
                    Cmd.ExecuteNonQuery()

                End Using
            End Using

        End If
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        FormLaporan.Show()
    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        FormPenyakit.Show()
        Me.Close()
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        FormDataGejala.Show()
        Me.Close()
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        Rule.Show()
        Me.Close()
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Me.Close()
        FormMenuUtama.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        ListView2.Clear()
        TextBox1.Clear()
        TextBox2.Clear()
        TextBox3.Clear()
    End Sub
End Class