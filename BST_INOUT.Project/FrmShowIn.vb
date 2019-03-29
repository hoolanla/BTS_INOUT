Imports System.IO

Public Class FrmShowIn

    Public img As Image
    Public Name As String
    Public Company As String
    Public panelDT As String
    Public panelTimeIn As Integer


    Private Sub FrmShowIn_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Pic1.Image = img
        lbName1.Text = Name
        Timer1.Interval = My.Settings.IntervalFadeOut
        Timer1.Enabled = True
    End Sub

    Private Sub TableLayoutPanel1_CellPaint(sender As Object, e As TableLayoutCellPaintEventArgs) Handles TableLayoutPanel1.CellPaint
        If e.Row = 1 Then
            e.Graphics.FillRectangle(Brushes.Green, e.CellBounds)
        Else
            e.Graphics.FillRectangle(Brushes.Green, e.CellBounds)
        End If
    End Sub

    Private Sub TableLayoutPanel1_Paint(sender As Object, e As PaintEventArgs) Handles TableLayoutPanel1.Paint

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Me.Close()
    End Sub
End Class