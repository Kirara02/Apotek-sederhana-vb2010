Public Class FormUtama

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub KelolaResepToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles KelolaResepToolStripMenuItem.Click
        FormObat.MdiParent = Me
        FormObat.Show()
        FormTransaksi.Hide()
        FormLaporan.Hide()
        FormAbout.Hide()
    End Sub

    Private Sub TransaksiToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TransaksiToolStripMenuItem.Click
        FormTransaksi.MdiParent = Me
        FormTransaksi.Show()
        FormObat.Hide()
        FormLaporan.Hide()
        FormAbout.Hide()
    End Sub

    Private Sub LaporanToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LaporanToolStripMenuItem.Click
        FormLaporan.MdiParent = Me
        FormLaporan.Show()
        FormObat.Hide()
        FormTransaksi.Hide()
        FormAbout.Hide()
    End Sub

    Private Sub AboutToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AboutToolStripMenuItem.Click
        FormAbout.MdiParent = Me
        FormAbout.Show()
        FormObat.Hide()
        FormTransaksi.Hide()
        FormLaporan.Hide()
    End Sub
End Class
