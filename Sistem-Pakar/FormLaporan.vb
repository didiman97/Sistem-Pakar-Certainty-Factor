Public Class FormLaporan

    Private Sub FormLaporan_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DataSet1.Diagnosa' table. You can move, or remove it, as needed.
        Me.DiagnosaTableAdapter.Fill(Me.DataSet1.Diagnosa)

        Me.ReportViewer1.RefreshReport()
    End Sub
End Class