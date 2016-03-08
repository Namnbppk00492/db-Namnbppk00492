Imports System.Drawing.Font
Public Class frmgiaodiendangnhap
    Dim s As Integer = 4
    Private Sub ProgressBar1_Click(sender As Object, e As EventArgs) Handles ProgressBar1.Click

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If ProgressBar2.Value >= 100 Then
            ProgressBar2.Value = 99
        End If
        ProgressBar2.Value += 1
    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        lbs.Text = s
        s -= 1
        If s = 0 Then
            Timer1.Stop()
            Timer2.Stop()
            Me.Hide()
            'frmDangnhap.Show()
        End If
    End Sub

    Private Sub Timer3_Tick(sender As Object, e As EventArgs) Handles Timer3.Tick
        If Label1.ForeColor = Color.IndianRed Then
            Label1.ForeColor = Color.Green

        Else
            Label1.ForeColor = Color.IndianRed

        End If
    End Sub
End Class
