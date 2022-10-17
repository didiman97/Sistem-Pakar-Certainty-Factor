Imports System.Data.OleDb

Public Class FormBasisPengetahuan
    Sub TampilData()
        On Error Resume Next

        Using koneksi As New OleDbConnection(Skripsi)
            Using cmd As New OleDbCommand("select * from Rule", koneksi)
                koneksi.Open()
                Using Data As OleDbDataReader = cmd.ExecuteReader
                    Dim x As Integer = 0
                    ListView1.Items.Clear()
                    While Data.Read
                        ListView1.Items.Add(x + 1)
                        ListView1.Items(x).SubItems.Add(Data("Kodepengetahuan"))
                        ListView1.Items(x).SubItems.Add(Data("Kd_Penyakit"))
                        ListView1.Items(x).SubItems.Add(Data("Kd_Gejala"))
                        ListView1.Items(x).SubItems.Add(Data("mb"))
                        ListView1.Items(x).SubItems.Add(Data("md"))
                        x = x + 1
                    End While
                End Using
            End Using
        End Using
        Using koneksi As New OleDbConnection(Skripsi)
            Using cmd As New OleDbCommand("select * from Gejala order by Kd_Gejala asc", koneksi)
                koneksi.Open()
                Using Data As OleDbDataReader = cmd.ExecuteReader
                    Dim x As Integer = 0
                    ComboBox2.Items.Clear()
                    While Data.Read
                        ComboBox2.Items.Add(Data("Kd_Gejala"))
                    End While
                End Using
            End Using
        End Using

        Using koneksi As New OleDbConnection(Skripsi)
            Using cmd As New OleDbCommand("select * from Penyakit order by Kd_Penyakit asc", koneksi)
                koneksi.Open()
                Using Data As OleDbDataReader = cmd.ExecuteReader
                    Dim x As Integer = 0
                    ComboBox1.Items.Clear()
                    While Data.Read
                        ComboBox1.Items.Add(Data("Kd_Penyakit"))
                    End While
                End Using
            End Using
        End Using
    End Sub
    Sub bersihdata()
        TextBox1.Clear()
        TextBox4.Clear()
        TextBox5.Clear()
        ComboBox1.Text = ""
        ComboBox2.Text = ""

    End Sub

    Private Sub FormRule_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call TampilData()

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub ListView1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles ListView1.Click

        TextBox1.Text = ListView1.SelectedItems(0).SubItems(1).Text.ToString
        ComboBox1.Text = ListView1.SelectedItems(0).SubItems(2).Text.ToString
        ComboBox2.Text = ListView1.SelectedItems(0).SubItems(3).Text.ToString
        TextBox4.Text = ListView1.SelectedItems(0).SubItems(4).Text.ToString
        TextBox5.Text = ListView1.SelectedItems(0).SubItems(5).Text.ToString


    End Sub

    Private Sub ListView1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ListView1.SelectedIndexChanged

    End Sub

    Private Sub batal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles batal.Click
        If TextBox1.Text = "" Then
            MsgBox("Pilih data terlebih dahulu")
        Else
            Try
                Using Koneksi As New OleDbConnection(Skripsi)
                    Using Cmd As New OleDbCommand("update Barang set Kd_Penyakit='" & ComboBox1.Text & _
                                                                      "',Kd_Gejala='" & ComboBox2.Text & _
                                                                      "',mb='" & TextBox4.Text & _
                                                                      "',md='" & TextBox5.Text & _
                                                                         "' where Kodepengetahuan='" & TextBox1.Text & "'", Koneksi)
                        Koneksi.Open()
                        Cmd.CommandType = CommandType.Text
                        Cmd.ExecuteNonQuery()

                    End Using
                End Using
                MsgBox("Perubahan Data Berhasil")
                Call TampilData()
                Call bersihdata()

            Catch ex As Exception
                MsgBox(ex.Message())
            End Try
        End If
    End Sub

    Private Sub tutup_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tutup.Click
        Me.Close()

    End Sub

    Private Sub simpan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles simpan.Click

        If TextBox1.Text = "" Or ComboBox2.Text = "" Or ComboBox1.Text = "" Then
            MsgBox("Data Belum Lengkap")
        Else
            Try

                Using koneksi As New OleDbConnection(Skripsi)
                    Using Cmd As New OleDbCommand("insert into Rule values('" & _
                                                  TextBox1.Text & "','" & _
                                                  ComboBox1.Text & "','" & _
                                                  ComboBox2.Text & "','" & _
                                                  TextBox4.Text & "','" & _
                                                 TextBox5.Text & "')", koneksi)
                        koneksi.Open()
                        Cmd.CommandType = CommandType.Text
                        Cmd.ExecuteNonQuery()
                        MsgBox("Data " & TextBox1.Text & " Berhasil Disimpan")
                        Call TampilData()
                        Call bersihdata()

                    End Using
                End Using
            Catch ex As Exception
                MsgBox("Gagal Disimpan, periksa kembali data inputnya")
            End Try
            Call TampilData()

        End If




    End Sub

    Private Sub hapus_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles hapus.Click
        If TextBox1.Text = "" Then
            MsgBox("Pilih data terlebih dahulu")
        Else
            Dim konfirmasi As String
            konfirmasi = MsgBox("Anda Yakin Ingin Menghapus Data " & TextBox1.Text & " ...?", vbYesNo, "Konfirmasi")
            If konfirmasi = vbYes Then
                Try
                    Using Koneksi As New OleDbConnection(Skripsi)
                        Using Cmd As New OleDbCommand("delete * from Rule where Kodepengetahuan='" & TextBox1.Text & "'", Koneksi)
                            Koneksi.Open()
                            Cmd.CommandType = CommandType.Text
                            Cmd.ExecuteNonQuery()
                        End Using
                    End Using
                    Call TampilData()

                    Call bersihdata()

                Catch ex As Exception
                    MsgBox(ex.Message())
                End Try

            Else
                bersihdata()

            End If

        End If

    End Sub

    Private Sub ComboBox2_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox2.SelectedIndexChanged

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Call bersihdata()

    End Sub
End Class