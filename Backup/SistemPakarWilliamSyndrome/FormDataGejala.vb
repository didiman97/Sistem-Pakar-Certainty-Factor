Imports System.Data.OleDb

Public Class FormDataGejala
    Sub TampilData()
        Using koneksi As New OleDbConnection(Skripsi)
            Using cmd As New OleDbCommand("select * from Gejala", koneksi)
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

    Private Sub FormDataGejala_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call TampilData()

    End Sub

    Private Sub ListView1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles ListView1.Click
        TextBox1.Text = ListView1.SelectedItems(0).Text.ToString
        TextBox2.Text = ListView1.SelectedItems(0).SubItems(1).Text.ToString

    End Sub

    Private Sub ListView1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ListView1.SelectedIndexChanged

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If TextBox1.Text = "" Or TextBox2.Text = "" Then
            MsgBox("Data Belum Lengkap")
        Else
            Try

                Using koneksi As New OleDbConnection(Skripsi)
                    Using Cmd As New OleDbCommand("insert into Gejala values('" & _
                                                  TextBox1.Text & "','" & _
                                                 TextBox2.Text & "')", koneksi)
                        koneksi.Open()
                        Cmd.CommandType = CommandType.Text
                        Cmd.ExecuteNonQuery()
                        MsgBox("Data " & TextBox2.Text & " Berhasil Disimpan")
                        Call TampilData()
                        Call bersihdata()

                    End Using
                End Using
            Catch ex As Exception
                MsgBox(ex.Message())
            End Try

        End If


    End Sub

    Sub bersihdata()
        TextBox1.Clear()
        TextBox2.Clear()

    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        If TextBox1.Text = "" Or TextBox2.Text = "" Then
            MsgBox("Data Belum Dipilih dari Listview")
        Else
            Try
                Using Koneksi As New OleDbConnection(Skripsi)
                    Using Cmd As New OleDbCommand("update Gejala set Nm_Gejala='" & TextBox2.Text & _
                                                                                       "' where Kd_Gejala='" & TextBox1.Text & "'", Koneksi)
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

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        If TextBox1.Text = "" Or TextBox2.Text = "" Then
            MsgBox("Data Belum Dipilih dari Listview")
        Else
            Dim konfirmasi As String
            konfirmasi = MsgBox("Anda Yakin Ingin Menghapus Data " & TextBox1.Text & " ...?", vbYesNo, "Konfirmasi")
            If konfirmasi = vbYes Then
                Try
                    Using Koneksi As New OleDbConnection(Skripsi)
                        Using Cmd As New OleDbCommand("delete * from Gejala where Kd_Gejala='" & TextBox1.Text & "'", Koneksi)
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

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Call bersihdata()

    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Me.Close()

    End Sub
End Class