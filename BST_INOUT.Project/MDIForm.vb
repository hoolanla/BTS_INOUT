Imports System.Windows.Forms
Imports System.IO

Public Class MDIForm



    Dim paneltimeTmpIn, paneltimeTmpOut As Integer
    Dim f As New FrmMain
    Private Sub ShowNewForm(ByVal sender As Object, ByVal e As EventArgs) Handles NewToolStripMenuItem.Click


        Dim bool As Boolean = False

        For Each f As Form In Me.MdiChildren

            If f.Name = "FrmMain" Then
                f.Activate()
                bool = True
                Exit For
            End If

        Next

        If bool <> True Then
            Dim ChildForm As New FrmMain
            ChildForm.MdiParent = Me
            ChildForm.Text = "BTS Project "
            ChildForm.Width = Me.Width - 23
            ChildForm.Height = Me.Height - 90

            ChildForm.Show()
            ChildForm.Location = New Point(1, 1)
        End If
    End Sub

    Private Sub OpenFile(ByVal sender As Object, ByVal e As EventArgs)
        Dim OpenFileDialog As New OpenFileDialog
        OpenFileDialog.InitialDirectory = My.Computer.FileSystem.SpecialDirectories.MyDocuments
        OpenFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*"
        If (OpenFileDialog.ShowDialog(Me) = System.Windows.Forms.DialogResult.OK) Then
            Dim FileName As String = OpenFileDialog.FileName
            ' TODO: Add code here to open the file.
        End If
    End Sub

    Private Sub SaveAsToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        Dim SaveFileDialog As New SaveFileDialog
        SaveFileDialog.InitialDirectory = My.Computer.FileSystem.SpecialDirectories.MyDocuments
        SaveFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*"

        If (SaveFileDialog.ShowDialog(Me) = System.Windows.Forms.DialogResult.OK) Then
            Dim FileName As String = SaveFileDialog.FileName
            ' TODO: Add code here to save the current contents of the form to a file.
        End If
    End Sub


    Private Sub ExitToolsStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles ExitToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub CutToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        ' Use My.Computer.Clipboard to insert the selected text or images into the clipboard
    End Sub

    Private Sub CopyToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles CopyToolStripMenuItem.Click

        Setup.Show()

    End Sub

    Private Sub PasteToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        'Use My.Computer.Clipboard.GetText() or My.Computer.Clipboard.GetData to retrieve information from the clipboard.
    End Sub


    Private Sub CascadeToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        Me.LayoutMdi(MdiLayout.Cascade)
    End Sub

    Private Sub TileVerticalToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        Me.LayoutMdi(MdiLayout.TileVertical)
    End Sub

    Private Sub TileHorizontalToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        Me.LayoutMdi(MdiLayout.TileHorizontal)
    End Sub

    Private Sub ArrangeIconsToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        Me.LayoutMdi(MdiLayout.ArrangeIcons)
    End Sub

    Private Sub CloseAllToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        ' Close all child forms of the parent.
        For Each ChildForm As Form In Me.MdiChildren
            ChildForm.Close()
        Next
    End Sub

    Private m_ChildFormNumber As Integer

    Private Sub WindowsMenu_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub MDIForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load



        Me.WindowState = FormWindowState.Maximized


        f.MdiParent = Me
        f.Width = Me.Width - 23
        f.Height = Me.Height - 90
        f.StartPosition = FormStartPosition.CenterScreen
        f.Show()
        '  f.Location = New Point(1, 1)
        Timer1.Enabled = True
    End Sub

    Private Sub FileMenu_Click(sender As Object, e As EventArgs) Handles FileMenu.Click

    End Sub

    Private Sub EditMenu_Click(sender As Object, e As EventArgs) Handles EditMenu.Click

    End Sub

    Private Function checkNewDataIn(paneltimeTmpIn As Integer) As Boolean

        Dim _BLL As New BLL.Data
        Dim dt As DataTable
        dt = _BLL.getNewDataIn(paneltimeTmpIn)
        If dt.Rows.Count > 0 Then
            paneltimeTmpIn = dt.Rows(0)("panelTime").ToString
            Return True
        Else
            Return False
        End If



    End Function

    Private Function checkNewDataOut(paneltimeTmpOut As Integer) As Boolean

        Dim _BLL As New BLL.Data
        If _BLL.getNewDataOut(paneltimeTmpOut) Then
            Return True
        Else
            Return False
        End If
    End Function



    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick


        ToolStripStatusLabel.Text = Now()

        If checkNewDataIn(paneltimeTmpIn) Then
            initData()
            f.panelTimeIN = paneltimeTmpIn

        End If

        If checkNewDataOut(paneltimeTmpOut) Then
            initDataOUT()
            f.panelTimeOUT = paneltimeTmpOut

        End If

    End Sub

    Private Sub initData()

        Dim _BBL As New BLL.Data
        Dim dt As DataTable
        dt = _BBL.getDataIn()

        If dt.Rows.Count > 0 Then


            paneltimeTmpIn = dt.Rows(0)("panelTime").ToString()

            If Not IsDBNull(dt.Rows(0)("Photo")) Then
                Dim img As Byte()
                img = dt.Rows(0)("Photo")
                Dim ms As New MemoryStream(img)
                FrmShowIn.img = Image.FromStream(ms)
            End If

            Dim strDesc As String = ""

            If My.Settings.CheckName Then
                strDesc += dt.Rows(0)("firstname").ToString() & "    " & dt.Rows(0)("lastname").ToString()
            End If

            If My.Settings.CheckCompany Then
                strDesc += vbCrLf & dt.Rows(0)("Company").ToString()
            End If

            If My.Settings.CheckTimeStamp Then
                strDesc += "   " & panelDT(dt.Rows(0)("panelTime").ToString())
            End If



            FrmShowIn.MdiParent = Me
            FrmShowIn.Name = strDesc

            FrmShowIn.Show()
            FrmShowIn.Location = New Point(500, 10)
            FrmShowIn.panelTimeIn = paneltimeTmpIn
        End If

        'If dtOut.Rows.Count > 0 Then


        '    Dim img As Byte()
        '    img = dt.Rows(0)("Photo")
        '    Dim ms As New MemoryStream(img)

        '    Dim strDesc As String = ""

        '    If My.Settings.CheckName Then
        '        strDesc += dt.Rows(0)("firstname").ToString() & "    " & dt.Rows(0)("lastname").ToString()
        '    End If

        '    If My.Settings.CheckCompany Then
        '        strDesc += vbCrLf & dt.Rows(0)("Company").ToString()
        '    End If

        '    If My.Settings.CheckTimeStamp Then
        '        strDesc += "   " & panelDT(dt.Rows(0)("panelTime").ToString())
        '    End If


        '    paneltimeTmpIn = dt.Rows(0)("panelTime").ToString()

        '    FrmShowIn.MdiParent = Me
        '    FrmShowIn.Name = strDesc
        '    FrmShowIn.img = Image.FromStream(ms)
        '    FrmShowIn.Show()
        '    FrmShowIn.Location = New Point(500, 10)

        'End If



    End Sub


    Private Sub initDataOUT()

        Dim _BBL As New BLL.Data
        Dim dtOut As DataTable

        dtOut = _BBL.getDataOut()
        If dtOut.Rows.Count > 0 Then


            paneltimeTmpOut = dtOut.Rows(0)("panelTime").ToString()


        End If

        'If dtOut.Rows.Count > 0 Then


        '    Dim img As Byte()
        '    img = dt.Rows(0)("Photo")
        '    Dim ms As New MemoryStream(img)

        '    Dim strDesc As String = ""

        '    If My.Settings.CheckName Then
        '        strDesc += dt.Rows(0)("firstname").ToString() & "    " & dt.Rows(0)("lastname").ToString()
        '    End If

        '    If My.Settings.CheckCompany Then
        '        strDesc += vbCrLf & dt.Rows(0)("Company").ToString()
        '    End If

        '    If My.Settings.CheckTimeStamp Then
        '        strDesc += "   " & panelDT(dt.Rows(0)("panelTime").ToString())
        '    End If


        '    paneltimeTmpIn = dt.Rows(0)("panelTime").ToString()

        '    FrmShowIn.MdiParent = Me
        '    FrmShowIn.Name = strDesc
        '    FrmShowIn.img = Image.FromStream(ms)
        '    FrmShowIn.Show()
        '    FrmShowIn.Location = New Point(500, 10)

        'End If



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

    Private Sub ToolStripStatusLabel_Click(sender As Object, e As EventArgs) Handles ToolStripStatusLabel.Click

    End Sub
End Class
