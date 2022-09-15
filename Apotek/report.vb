Public Class report

    Private Sub report_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DbApotekDataSet.transaksi' table. You can move, or remove it, as needed.
        Me.transaksiTableAdapter.Fill(Me.DbApotekDataSet.transaksi)

        Me.ReportViewer1.RefreshReport()
    End Sub
End Class