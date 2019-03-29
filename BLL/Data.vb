Public Class Data



    Private _DAL = New DAL.Data

    Public Function getDataIn() As DataTable
        Return _DAL.getDataIn

    End Function


    Public Function getDataOut() As DataTable
        Return _DAL.getDataOut

    End Function

    Public Function getNewDataIn(panelTimeTmp As Integer) As DataTable
        Return _DAL.getNewDataIn(panelTimeTmp)
    End Function

    Public Function getNewDataOut(panelTimeTmp As Integer) As Boolean
        Return _DAL.getNewDataOut(panelTimeTmp)
    End Function
End Class
