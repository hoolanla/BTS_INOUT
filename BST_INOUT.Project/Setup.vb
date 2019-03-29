Public Class Setup

    Private Sub Setup_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        initCheckbox()
    End Sub

    Private Sub initCheckbox()

        CheckName.Checked = My.Settings.CheckName
        CheckTimeStamp.Checked = My.Settings.CheckTimeStamp
        CheckCompany.Checked = My.Settings.CheckCompany


    End Sub

    Private Sub CheckedListBox1_SelectedIndexChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub BtnSave_Click(sender As Object, e As EventArgs) Handles BtnSave.Click

        My.Settings.CheckName = CheckName.Checked
        My.Settings.CheckTimeStamp = CheckTimeStamp.Checked
        My.Settings.CheckCompany = CheckCompany.Checked
        My.Settings.Save()



        Me.Close()
    End Sub

End Class