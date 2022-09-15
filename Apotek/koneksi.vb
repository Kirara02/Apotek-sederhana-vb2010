Imports System.Data.OleDb
Module koneksi
    Public cmd As OleDbCommand
    Public da As OleDbDataAdapter
    Public dr As OleDbDataReader
    Public dt As DataTable

    Dim koneksi As OleDbConnection

    Public Function konek() As OleDbConnection
        koneksi = New OleDbConnection("provider=microsoft.ace.oledb.12.0; data source=DbApotek.accdb")
        koneksi.Open()
        Return koneksi
    End Function
End Module
