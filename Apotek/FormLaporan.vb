Imports System.Data.OleDb
Public Class FormLaporan
    Dim h1, b1, t1, h2, b2, t2 As String
    Dim jam, menit, detik As Integer
    Dim dari, sampai As String

    Sub tampil()
        Dim total As Integer = 0
        da = New OleDbDataAdapter("select * from transaksi", konek())
        dt = New DataTable
        da.Fill(dt)
        dgv.DataSource = dt
        For i = 0 To dgv.Rows.Count - 1
            total += Val(dgv.Rows(i).Cells("total").Value)
        Next
        t.Text = total
    End Sub

    Sub tampilcari()
        'h1 = Format(dtp1.Value, "dd") - 1
        'b1 = Format(dtp1.Value, "MM")
        't1 = Format(dtp1.Value, "yyyy")
        'h2 = Format(dtp2.Value, "dd") + 1
        'b2 = Format(dtp2.Value, "MM")
        't2 = Format(dtp2.Value, "yyyy")
        'jam = 23
        'menit = 59
        'detik = 59

        'dari = h1 & "/" & b1 & "/" & t1
        'sampai = h2 & "/" & b2 & "/" & t2

        'da = New OleDbDataAdapter("SELECT transaksi.no_transaksi,transaksi.nm_apoteker,transaksi.nm_pasien, transaksi.tgl_transaksi ,transaksi.total FROM transaksi WHERE (((transaksi.tgl_transaksi)between format(tgl_transaksi,'" & dari & "') And format(tgl_transaksi,'" & sampai & "')))", konek())
        'dt = New DataTable
        'da.Fill(dt)
        'dgv.DataSource = dt
    End Sub
    Private Sub Form4_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        tampil()
        WindowState = FormWindowState.Maximized
        FormBorderStyle = Windows.Forms.FormBorderStyle.None
    End Sub

    Private Sub btnr_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnr.Click
        tampil()
    End Sub

    Private Sub btnp_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        report.Show()
    End Sub
End Class