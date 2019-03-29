Imports System.IO

Public Class FrmMain


    Dim State_ As Int16
    Public panelTimeIN, panelTimeOUT As Double
    Private panelTimeTmpIN, panelTimeTmpOUT As Double

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load


        initDataIN()
        initDataOUT()

        Timer1.Interval = My.Settings.IntervalCheck
        Timer1.Enabled = True
    End Sub

    Private Sub initState()

    End Sub

    Private Function initDataIN() As Boolean


        Dim flagPic As Boolean = False
        Dim dt As DataTable
        Dim _BLL As New BLL.Data()

        dt = _BLL.getDataIn()
        If dt.Rows.Count > 0 Then

            For i As Int16 = 0 To dt.Rows.Count - 1

                Select Case i
                    Case 0

                        If Not IsDBNull(dt.Rows(i)("photo")) Then
                            Dim img As Byte()
                            img = dt.Rows(i)("Photo")
                            Dim ms As New MemoryStream(img)

                            Pic1.Image = Image.FromStream(ms)
                        Else
                            Pic1.Image = My.Resources.no_person
                        End If

                        lbName1.Text = ""
                        If My.Settings.CheckName Then
                            lbName1.Text += dt.Rows(i)("firstname").ToString() & "    " & dt.Rows(i)("lastname").ToString()
                        End If

                        If My.Settings.CheckCompany Then
                            lbName1.Text += vbCrLf & dt.Rows(i)("Company").ToString()
                        End If

                        If My.Settings.CheckTimeStamp Then
                            lbName1.Text += "   " & panelDT(dt.Rows(i)("panelTime").ToString())
                        End If

                        panelTimeTmpIN = dt.Rows(i)("panelLocalDT").ToString()
                    Case 1

                        If Not IsDBNull(dt.Rows(i)("photo")) Then
                            Dim img As Byte()
                            img = dt.Rows(i)("Photo")
                            Dim ms As New MemoryStream(img)

                            Pic2.Image = Image.FromStream(ms)
                        Else

                            Pic2.Image = My.Resources.no_person
                        End If

                        lbName2.Text = ""
                        If My.Settings.CheckName Then
                            lbName2.Text += dt.Rows(i)("firstname").ToString() & "    " & dt.Rows(i)("lastname").ToString()
                        End If

                        If My.Settings.CheckCompany Then
                            lbName2.Text += vbCrLf & dt.Rows(i)("Company").ToString()
                        End If

                        If My.Settings.CheckTimeStamp Then
                            lbName2.Text += "   " & panelDT(dt.Rows(i)("panelTime").ToString())
                        End If
                    Case 2
                        If Not IsDBNull(dt.Rows(i)("photo")) Then
                            Dim img As Byte()
                            img = dt.Rows(i)("Photo")
                            Dim ms As New MemoryStream(img)

                            Pic3.Image = Image.FromStream(ms)

                        Else

                            Pic3.Image = My.Resources.no_person
                        End If
                        lbName3.Text = ""
                        If My.Settings.CheckName Then
                            lbName3.Text += dt.Rows(i)("firstname").ToString() & "    " & dt.Rows(i)("lastname").ToString()
                        End If

                        If My.Settings.CheckCompany Then
                            lbName3.Text += vbCrLf & dt.Rows(i)("Company").ToString()
                        End If

                        If My.Settings.CheckTimeStamp Then
                            lbName3.Text += "   " & panelDT(dt.Rows(i)("panelTime").ToString())
                        End If

                End Select
            Next

        End If



    End Function
    

    Private Function initDataOUT() As Boolean


        Dim flagPic As Boolean = False
        Dim dt, dtOut As DataTable
        Dim _BLL As New BLL.Data()

        dtOut = _BLL.getDataOut()
        If dtOut.Rows.Count > 0 Then

            For i As Int16 = 0 To dtOut.Rows.Count - 1

                Select Case i
                    Case 0

                        If Not IsDBNull(dtOut.Rows(i)("photo")) Then
                            Dim img As Byte()
                            img = dtOut.Rows(i)("Photo")
                            Dim ms As New MemoryStream(img)

                            Pic4.Image = Image.FromStream(ms)
                        Else
                            Pic4.Image = My.Resources.no_person

                        End If

                        lbName4.Text = ""
                        If My.Settings.CheckName Then
                            lbName4.Text += dtOut.Rows(i)("firstname").ToString() & "    " & dtOut.Rows(i)("lastname").ToString()
                        End If

                        If My.Settings.CheckCompany Then
                            lbName4.Text += vbCrLf & dtOut.Rows(i)("Company").ToString()
                        End If

                        If My.Settings.CheckTimeStamp Then
                            lbName4.Text += "   " & panelDT(dtOut.Rows(i)("panelTime").ToString())
                        End If

                        panelTimeTmpOUT = dtOut.Rows(i)("panelLocalDT").ToString()
                    Case 1

                        If Not IsDBNull(dtOut.Rows(i)("photo")) Then
                            Dim img As Byte()
                            img = dtOut.Rows(i)("Photo")
                            Dim ms As New MemoryStream(img)

                            Pic5.Image = Image.FromStream(ms)
                        Else
                            Pic5.Image = My.Resources.no_person
                        End If

                        lbName5.Text = ""
                        If My.Settings.CheckName Then
                            lbName5.Text += dtOut.Rows(i)("firstname").ToString() & "    " & dtOut.Rows(i)("lastname").ToString()
                        End If

                        If My.Settings.CheckCompany Then
                            lbName5.Text += vbCrLf & dtOut.Rows(i)("Company").ToString()
                        End If

                        If My.Settings.CheckTimeStamp Then
                            lbName5.Text += "   " & panelDT(dtOut.Rows(i)("panelTime").ToString())
                        End If
                    Case 2
                        If Not IsDBNull(dtOut.Rows(i)("photo")) Then
                            Dim img As Byte()
                            img = dtOut.Rows(i)("Photo")
                            Dim ms As New MemoryStream(img)

                            Pic6.Image = Image.FromStream(ms)
                        Else
                            Pic6.Image = My.Resources.no_person
                        End If
                        lbName6.Text = ""
                        If My.Settings.CheckName Then
                            lbName6.Text += dtOut.Rows(i)("firstname").ToString() & "    " & dtOut.Rows(i)("lastname").ToString()
                        End If

                        If My.Settings.CheckCompany Then
                            lbName6.Text += vbCrLf & dtOut.Rows(i)("Company").ToString()
                        End If

                        If My.Settings.CheckTimeStamp Then
                            lbName6.Text += "   " & panelDT(dtOut.Rows(i)("panelTime").ToString())
                        End If

                End Select
            Next

        End If



    End Function
    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs)

    End Sub

    Private Sub Pic3_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Pic1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub TableLayoutPanel2_Paint(sender As Object, e As PaintEventArgs)

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label6_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub lbName1_Click(sender As Object, e As EventArgs)

    End Sub


    Private Sub lbName4_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub lbName1_Click_1(sender As Object, e As EventArgs)

    End Sub

    Private Sub lbName5_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Pic2_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub TableLayoutPanel1_Paint(sender As Object, e As PaintEventArgs)

    End Sub

    Private Sub GroupBox2_Enter(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)

        FrmShowIn.Show()
        ' FrmReport1.Show()


    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs)


        'FrmReport2.Show()
    End Sub


    Private Sub GroupBox3_Enter(sender As Object, e As EventArgs)

    End Sub

    Private Sub lbName3_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub TableLayoutPanel5_Paint(sender As Object, e As PaintEventArgs)

    End Sub

    Private Sub TableLayoutPanel1_CellPaint(sender As Object, e As TableLayoutCellPaintEventArgs)


        If e.Row = 1 Then
            e.Graphics.FillRectangle(Brushes.Red, e.CellBounds)
        Else
            e.Graphics.FillRectangle(Brushes.Green, e.CellBounds)
        End If

    End Sub

    Private Sub lbName6_Click(sender As Object, e As EventArgs)

    End Sub


    Private Function panelDT(panelTime As String) As String


        Dim MM, DD, HH, MN, SS, tmp As String

        'MM = Now.Month
        'DD = Now.Day
        'HH = Now.Hour
        'MN = Now.Minute
        'SS = Now.Second

        'tmp = (MM * 100000000) + (DD * 1000000) + (HH * 10000) + (MN * 100) + SS


        SS = panelTime.Substring(panelTime.Length - 2, 2)
        MN = panelTime.Substring(panelTime.Length - 4, 2)
        HH = panelTime.Substring(panelTime.Length - 6, 2)
        DD = panelTime.Substring(panelTime.Length - 8, 2)
        If panelTime.Length = 9 Then
            MM = "0" + panelTime.Substring(0, 1)
        Else
            MM = panelTime.Substring(0, 2)
        End If


        Return DD & "/" & MM & " " & HH & ":" & MN & ":" & SS



    End Function
   

    Private Sub Label1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick




        If panelTimeIN > panelTimeTmpIN Then
            initDataIN()
            panelTimeTmpIN = panelTimeIN
        End If

        If panelTimeOUT > panelTimeTmpOUT Then
            initDataOUT()
            panelTimeTmpOUT = panelTimeOUT
        End If

    End Sub

    Private Sub Pic3_Click_1(sender As Object, e As EventArgs) Handles Pic3.Click

    End Sub

    Private Sub Pic5_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub TableLayoutPanel6_Paint(sender As Object, e As PaintEventArgs)

    End Sub

    Private Sub TableLayoutPanel1_Paint_1(sender As Object, e As PaintEventArgs) Handles TableLayoutPanel1.Paint

    End Sub

    Private Sub lbName4_Click_1(sender As Object, e As EventArgs)

    End Sub
End Class
