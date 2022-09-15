Imports System.Data
Imports System.Data.OleDb
Public Class FormObat

    Sub clear()
        cr.Text = ""
        kd.Text = ""
        nm.Text = ""
        hr.Text = ""
        dtp.Value = Now
    End Sub
    Sub tampil()
        Try
            da = New OleDbDataAdapter("select * from obat order by kd_obat asc", konek())
            dt = New DataTable
            da.Fill(dt)
            dgv.DataSource = dt
        Catch ex As Exception
            MsgBox(ex.Message, vbInformation, "Messege")
        End Try
    End Sub
    Sub cari(ByVal cari)
        Try
            Try
                cmd = New OleDbCommand("select * from obat where kd_obat like '%" & cari & "%' OR nm_obat like '%" & cari & "%'", konek())
                dr = cmd.ExecuteReader
                If dr.HasRows Then
                    da = New OleDbDataAdapter("select * from obat where kd_obat like '%" & cari & "%' OR nm_obat like '%" & cari & "%' order by kd_obat asc", konek())
                    dt = New DataTable
                    da.Fill(dt)
                    dgv.DataSource = dt
                Else
                    MsgBox("Data tidak ditemukan", vbInformation, "Messege")
                    clear()
                    tampil()
                End If
            Catch ex As Exception
                MsgBox(ex.Message, vbInformation, "Messege")
            End Try
        Catch ex As Exception

        End Try
    End Sub

    Sub insert()
        Try
            cmd = New OleDbCommand("insert into obat values ('" & kd.Text & "','" & nm.Text & "','" & dtp.Value & "','" & hr.Text & "')", konek())
            cmd.ExecuteNonQuery()
            MsgBox("Data berhasil ditambahkan", vbYes + 64, "Messege")
            clear()
            tampil()
        Catch ex As Exception
            MsgBox(ex.Message, vbYes + 64, "Messege")
        End Try
    End Sub


    Sub delete()
        Try
            cmd = New OleDbCommand("delete from obat where kd_obat = '" & kd.Text & "'", konek())
            cmd.ExecuteNonQuery()
            MsgBox("Data berhasil dihapus", vbInformation, "Messege")
            clear()
            tampil()
        Catch ex As Exception
            MsgBox(ex.Message, vbInformation, "Messege")
        End Try
    End Sub

    Sub edit()
        Try
            cmd = New OleDbCommand("update obat set nm_obat='" & nm.Text & "',expired_date='" & dtp.Value & "',harga='" & hr.Text & "' where kd_obat='" & kd.Text & "'", konek())
            cmd.ExecuteNonQuery()
            MsgBox("Data berhasil diedit", vbYes + 64, "Messege")
            clear()
            tampil()
        Catch ex As Exception
            MsgBox(ex.Message, vbYes + 64, "Messege")
        End Try
    End Sub


    Private Sub Form2_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        WindowState = FormWindowState.Maximized
        FormBorderStyle = Windows.Forms.FormBorderStyle.None
        tampil()
    End Sub

    Private Sub btns_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btns.Click
        cari(cr.Text)
    End Sub

    Private Sub btni_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btni.Click
        If (MsgBox("Tambah data ini?", vbYesNo + 32, "Edit")) = vbYes Then
            insert()
        End If
    End Sub

    Private Sub btnu_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnu.Click
        If (MsgBox("Edit data ini?", vbYesNo + 32, "Edit")) = vbYes Then
            edit()
        End If
    End Sub

    Private Sub btnd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnd.Click
        If (MsgBox("Hapus data ini?", vbYesNo + 32, "Edit")) = vbYes Then
            delete()
        End If
    End Sub

    Private Sub dgv_CellMouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles dgv.CellMouseClick
        Try
            kd.Text = dgv.Rows(e.RowIndex).Cells("kd_obat").Value
            nm.Text = dgv.Rows(e.RowIndex).Cells("nm_obat").Value
            kd.Text = dgv.Rows(e.RowIndex).Cells("kd_obat").Value
            hr.Text = dgv.Rows(e.RowIndex).Cells("harga").Value
            dtp.Value = dgv.Rows(e.RowIndex).Cells("expired_date").Value
        Catch ex As Exception
            MsgBox(ex.Message, vbYes + 64, "Messege")
        End Try
    End Sub

    Private Sub btnk_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnk.Click
        clear()
    End Sub
End Class