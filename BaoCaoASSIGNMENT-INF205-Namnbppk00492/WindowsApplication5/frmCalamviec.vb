Imports System.IO
Public Class frmCalamviec
    Dim arrCalamviec As New ArrayList
    Private Sub cbbCalamviec_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbbCalamviec.SelectedIndexChanged
        Dim kiemTratimkiem As Boolean = False
        Dim reader As New StreamReader("FileNhanVien.txt")
        lsvCalamviec.Items.Clear()
        Do Until reader.EndOfStream
            Dim mangTT(2) As String
            Dim noiDungmotdong As String

            noiDungmotdong = reader.ReadLine()
            mangTT = Split(noiDungmotdong, "^")
            If (mangTT(0).ToLower.Contains(cbbCalamviec.Text.ToLower) Or mangTT(2).ToLower.Contains(cbbCalamviec.Text.ToLower)) Then
                ThemNhanvienVaoListView(mangTT(0), mangTT(2))
            End If
        Loop
        reader.Close()
    End Sub

    Private Sub frmCalamviec_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Docfile()
    End Sub
    Public Sub Docfile()
        frmNhanvien.lsvNhanvien.Items.Clear()

        Dim reader As New StreamReader("FileNhanVien.txt")
        Do Until reader.EndOfStream
            Dim mangTT(1) As String
            Dim noiDungmotdong As String
            noiDungmotdong = reader.ReadLine()
            mangTT = Split(noiDungmotdong, "^")
            ThemNhanvienVaoListView(mangTT(0), mangTT(2))
        Loop
        reader.Close()
    End Sub
    Public Sub ThemNhanvienVaoListView(Nhanvien As String, Ca As String)

        Dim soTT = lsvCalamviec.Items.Count + 1
        Dim item = New ListViewItem(soTT)
        item.SubItems.Add(Nhanvien)
        item.SubItems.Add(Ca)
        lsvCalamviec.Items.Add(item)

    End Sub

    Private Sub btnThoat_Click(sender As Object, e As EventArgs) Handles btnThoat.Click
        Close()
    End Sub

    Private Sub btnGhi_Click(sender As Object, e As EventArgs) Handles btnGhi.Click
        Docfile()
    End Sub
End Class