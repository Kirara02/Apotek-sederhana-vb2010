Imports System.Data.OleDb
Public Class FormTransaksi
    Dim notrans As String
    Sub getNoTrans()
        Try
            Dim time As String = Format(Now, "yyyyMMdd")
            Dim urut As Integer
            cmd = New OleDbCommand("select top 1 no_transaksi from transaksi where no_transaksi like '%" & time & "%' order by no_transaksi desc", konek)
            dr = cmd.ExecuteReader
            dr.Read()
            If dr.HasRows Then
                urut = Val(dr.Item("no_transaksi").ToString.Substring(8, 4) + 1)
                notrans = time & Format(urut, "0000")
            Else
                notrans = time & "0001"
            End If
        Catch ex As Exception
            MsgBox(ex.Message, vbInformation, "Messege")
        End Try
    End Sub
    Sub clearorder()
        nmo.Text = ""
        hr.Text = ""
        ido.Text = ""
        jml.Text = ""
    End Sub

    Sub clearsave()
        np.Text = ""
        na.Text = ""
        km.Text = ""
        u.Text = ""
    End Sub

    Sub tampilObat()
        Try
            da = New OleDbDataAdapter("select kd_obat,nm_obat, harga from obat order by nm_obat asc", konek())
            dt = New DataTable
            da.Fill(dt)
            DataGridView1.DataSource = dt
        Catch ex As Exception
            MsgBox(ex.Message, vbInformation, "Messege")
        End Try
    End Sub

    Sub tampilOrder()
        Try
            Dim total As Integer = 0
            da = New OleDbDataAdapter("SELECT td.ID, o.nm_obat as nama_obat, o.harga, td.jml_beli as jumlah, td.subtotal from transaksiDetail as td INNER JOIN obat as o ON o.kd_obat = td.kd_obat where no_transaksi = '" & notrans & "' order by ID asc", konek())
            dt = New DataTable
            da.Fill(dt)
            DataGridView2.DataSource = dt
            DataGridView2.Columns("ID").Visible = False
            For i = 0 To DataGridView2.Rows.Count - 1
                total += Val(DataGridView2.Rows(i).Cells("subtotal").Value)
            Next
            t.Text = total
        Catch ex As Exception
            MsgBox(ex.Message, vbInformation, "Messege")
        End Try
    End Sub

    Sub cariObat(ByVal cari)
        Try
            da = New OleDbDataAdapter("select * from obat where kd_obat like '%" & cari & "%' OR nm_obat like '%" & cari & "%' order by kd_obat asc", konek())
            dt = New DataTable
            da.Fill(dt)
            DataGridView1.DataSource = dt
        Catch ex As Exception
            MsgBox(ex.Message, vbInformation, "Messege")
        End Try
    End Sub

    Sub insertTransaksi()
        Dim waktu As String = Now
        cmd = New OleDbCommand("insert into transaksi(no_transaksi,tgl_transaksi) values ('" & notrans & "','" & waktu & "')", konek())
        cmd.ExecuteNonQuery()
    End Sub

    Sub add()
        Dim subtotal As String = Val(hr.Text) * Val(jml.Text)
        cmd = New OleDbCommand("insert into transaksiDetail(no_transaksi,kd_obat,jml_beli,subtotal) values ('" & notrans & "','" & ido.Text & "','" & jml.Text & "','" & subtotal & "')", konek())
        cmd.ExecuteNonQuery()
        MsgBox("Berhasil menambahkan pesanan", vbInformation, "Messege")
        tampilOrder()
        clearorder()
    End Sub

    Sub cancel()
        cmd = New OleDbCommand("DELETE transaksiDetail.*, transaksiDetail.ID FROM(transaksiDetail) WHERE (((transaksiDetail.ID)=" & idd.Text & ")) AND (((transaksiDetail.no_transaksi)='" & notrans & "'))", konek())
        cmd.ExecuteNonQuery()
        MsgBox("Berhasil membatalkan pesanan", vbInformation, "Messege")
        idd.Text = ""
        tampilOrder()
    End Sub

    Sub updateBayar()
        cmd = New OleDbCommand("update transaksi set nm_apoteker='" & na.Text & "',nm_pasien='" & np.Text & "',total='" & t.Text & "' where no_transaksi='" & notrans & "'", konek())
        cmd.ExecuteNonQuery()
    End Sub
    Sub bayar()
        Dim uang As Integer = u.Text
        Dim total As Integer = t.Text
        If (Val(uang) >= Val(total)) Then
            updateBayar()
            km.Text = Val(uang) - Val(total)
            MsgBox("Pembayaran berhasil", vbInformation, "Messege")
            btns.Enabled = True
        Else
            MsgBox("Maap uang anda kurang", 16, "Messege")

        End If
    End Sub

    Private Sub Form3_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        getNoTrans()
        tampilObat()
        tampilOrder()
        WindowState = FormWindowState.Maximized
        FormBorderStyle = Windows.Forms.FormBorderStyle.None
    End Sub

    Private Sub DataGridView1_CellMouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles DataGridView1.CellMouseClick
        Try
            ido.Text = DataGridView1.Rows(e.RowIndex).Cells("kd_obat").Value
            nmo.Text = DataGridView1.Rows(e.RowIndex).Cells("nm_obat").Value
            hr.Text = DataGridView1.Rows(e.RowIndex).Cells("harga").Value
            jml.Focus()
        Catch ex As Exception
            MsgBox(ex.Message, vbInformation, "Messege")
        End Try
    End Sub

    Private Sub DataGridView2_CellMouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles DataGridView2.CellMouseClick
        Try
            idd.Text = DataGridView2.Rows(e.RowIndex).Cells("ID").Value
        Catch ex As Exception
            MsgBox(ex.Message, vbInformation, "Messege")
        End Try
    End Sub

    Private Sub btnsr_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsr.Click
        cariObat(cr.Text)
    End Sub

    Private Sub btna_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btna.Click
        Try
            cmd = New OleDbCommand("select no_transaksi from transaksi where no_transaksi='" & notrans & "'", konek())
            dr = cmd.ExecuteReader
            If dr.HasRows Then
                cmd = New OleDbCommand("select * from transaksiDetail where no_transaksi='" & notrans & "' AND kd_obat='" & ido.Text & "'", konek())
                dr = cmd.ExecuteReader
                dr.Read()
                If dr.HasRows Then
                    Dim jumlah As Integer = dr.Item("jml_beli") + Val(jml.Text)
                    Dim st As Integer = dr.Item("subtotal") + Val(jml.Text) * Val(hr.Text)
                    cmd = New OleDbCommand("update transaksiDetail set jml_beli='" & jumlah & "', subtotal='" & st & "' where no_transaksi='" & notrans & "' AND kd_obat='" & ido.Text & "'", konek())
                    cmd.ExecuteNonQuery()
                    MsgBox("Berhasil menambahkan pesanan", vbInformation, "Messege")
                    tampilOrder()
                    clearorder()
                Else
                    add()
                End If
            Else
                insertTransaksi()
                add()
            End If
        Catch ex As Exception
            MsgBox(ex.Message, vbInformation, "Messege")
        End Try
    End Sub

    Private Sub btnc_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnc.Click
        Try
            cancel()
        Catch ex As Exception
            MsgBox(ex.Message, vbInformation, "Messege")
        End Try
    End Sub

    Private Sub btnb_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnb.Click
        Try
            bayar()
        Catch ex As Exception
            MsgBox(ex.Message, vbInformation, "Messege")
        End Try
    End Sub

    Private Sub btns_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btns.Click
        Try
            getNoTrans()
            tampilObat()
            tampilOrder()
            clearsave()
        Catch ex As Exception
            MsgBox(ex.Message, vbInformation, "Messege")
        End Try
    End Sub
End Class