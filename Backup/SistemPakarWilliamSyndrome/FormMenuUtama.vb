Public Class FormMenuUtama

    Private Sub FormMenuUtama_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        End

    End Sub

    Private Sub FormMenuUtama_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub MenuStrip1_ItemClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ToolStripItemClickedEventArgs) Handles MenuStrip1.ItemClicked

    End Sub

    Private Sub DataKerusakanToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        FormPenyakit.Show()

    End Sub

    Private Sub DataGejalaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        FormDataGejala.Show()

    End Sub

    Private Sub BasisPengetahuanToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        FormBasisPengetahuan.Show()

    End Sub

    Private Sub DataPasienToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub DempsterShaferToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub ProsesCFToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ProsesCFToolStripMenuItem.Click
        Diagnosa.Show()

    End Sub

    Private Sub LaporanHasilDiagnosaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        FormLaporan.Show()

    End Sub

    Private Sub DataBakatToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DataBakatToolStripMenuItem.Click
        FormPenyakit.Show()

    End Sub

    Private Sub DataGejalaToolStripMenuItem_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DataGejalaToolStripMenuItem.Click
        FormDataGejala.Show()

    End Sub

    Private Sub BasisPengetahuanToolStripMenuItem_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BasisPengetahuanToolStripMenuItem.Click
        FormBasisPengetahuan.Show()

    End Sub

    Private Sub HelpToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles HelpToolStripMenuItem.Click
        End

    End Sub
End Class