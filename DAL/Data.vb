

Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Text
Imports System.Threading.Tasks
Imports System.Data
Imports System.Data.SqlClient
Imports System.Threading
Imports System.Globalization
Imports COMMON

Public Class Data


    Public Function getDataIn() As DataTable
        Dim connStr As String = "Data Source=172.16.128.16\Verex ;Initial Catalog=Director;Persist Security Info=True;User ID=DirectorQueryUser;Password=P@ssw0rd;Connection Timeout=120;"
        Dim conn As SqlConnection = COMMON.DataHelper.getSQLServerConnectionObject(connStr)
        Dim ds As New DataSet()

        Try
            Dim sql As String

            'sql = "SELECT top 3  ve.PanelTime ,ve.UserNumber into #tmp1"
            'sql += " FROM  dbo.ViewEvents as ve"
            'sql += " where DoorNumberText ='Innerfence I-8 IN' and priority=1000"
            'sql += " order by PanelTime desc"
            'sql += " select vu.FirstName,vu.LastName,vu.userinfo4 as company, vu.photo,vt.PanelTime "
            'sql += " from viewUser as vu,#tmp1 as vt "
            'sql += " where vu.UserNumber = vt.UserNumber"
            'sql += " Drop table #tmp1"

            sql = "  SELECT top 3  ve.PanelTime ,ve.UserNumber,ve.PanelLocalDT into #tmp1 "
            sql += " FROM  dbo.ViewEvents as ve "
            sql += " where DoorNumberText ='Innerfence I-8 IN' and priority=1000 and PanelLocalDT > 43465.9999421296"
            sql += " order by PanelTime desc "


            sql += " select vu.FirstName,vu.LastName, isnull(vf.NameInIndex,vf3.NameInIndex) as company , vu.photo,vt.PanelTime,vt.PanelLocalDT "
            sql += " from viewUser as vu "
            sql += " inner join #tmp1 as vt on vu.UserNumber = vt.UserNumber  "
            sql += " left join ViewDropDownFields as vf on vf.Index_ = '3' and vu.UserInfoDropDown4 = vf.DropDownID "
            sql += " left join ViewDropDownFields as vf3 on vf3.Index_ = '10' and vu.UserInfoDropDown11 = vf3.DropDownID "



            sql += " Drop table #tmp1"

            Dim adp As New SqlDataAdapter(sql, conn)
            adp.SelectCommand.CommandType = CommandType.Text
            adp.Fill(ds)

            Return ds.Tables(0)

        Catch ex As Exception
            '      Common.DataHelper.WriteLogFile("Call Function getDepartment_Search_L1 - ERROR: " + ex.Message, LogFileName);
            Throw ex
        Finally
            conn.Close()
        End Try
    End Function


    Public Function getDataOut() As DataTable
        Dim connStr As String = "Data Source=172.16.128.16\Verex ;Initial Catalog=Director;Persist Security Info=True;User ID=DirectorQueryUser;Password=P@ssw0rd;Connection Timeout=120;"
        Dim conn As SqlConnection = COMMON.DataHelper.getSQLServerConnectionObject(connStr)
        Dim ds As New DataSet()

        Try
            Dim sql As String

            'sql = "SELECT top 3  ve.PanelTime ,ve.UserNumber into #tmp1"
            'sql += " FROM  dbo.ViewEvents as ve"
            'sql += " where DoorNumberText ='Innerfence I-8 OUT' "
            'sql += " order by PanelTime desc"

            'sql += " select vu.FirstName,vu.LastName,vu.userinfo4 as company, vu.photo,vt.PanelTime "
            'sql += " from viewUser as vu,#tmp1 as vt "
            'sql += " where vu.UserNumber = vt.UserNumber"

            'sql += " Drop table #tmp1"


            sql = "  SELECT top 3  ve.PanelTime ,ve.UserNumber,ve.PanelLocalDT into #tmp1 "
            sql += " FROM  dbo.ViewEvents as ve "
            sql += " where DoorNumberText ='Innerfence I-8 OUT' and priority=1000 and PanelLocalDT > 43465.9999421296 "
            sql += " order by PanelTime desc "


            sql += " select vu.FirstName,vu.LastName,isnull(vf.NameInIndex,vf3.NameInIndex) as company , vu.photo,vt.PanelTime,vt.PanelLocalDT "
            sql += " from viewUser as vu "
            sql += " inner join #tmp1 as vt on vu.UserNumber = vt.UserNumber  "
            sql += " left join ViewDropDownFields as vf on vf.Index_ = '3' and vu.UserInfoDropDown4 = vf.DropDownID "
            sql += " left join ViewDropDownFields as vf3 on vf3.Index_ = '10' and vu.UserInfoDropDown11 = vf3.DropDownID "


            sql += " Drop table #tmp1"

            Dim adp As New SqlDataAdapter(sql, conn)
            adp.SelectCommand.CommandType = CommandType.Text
            adp.Fill(ds)

            Return ds.Tables(0)

        Catch ex As Exception
            '      Common.DataHelper.WriteLogFile("Call Function getDepartment_Search_L1 - ERROR: " + ex.Message, LogFileName);
            Throw ex
        Finally
            conn.Close()
        End Try
    End Function



    Public Function getNewDataIN(panelTimeTmp As Integer) As DataTable
        Dim connStr As String = "Data Source=172.16.128.16\Verex ;Initial Catalog=Director;Persist Security Info=True;User ID=DirectorQueryUser;Password=P@ssw0rd;Connection Timeout=120;"
        Dim conn As SqlConnection = COMMON.DataHelper.getSQLServerConnectionObject(connStr)
        Dim ds As New DataSet()

        Try
            Dim sql As String



            sql = "  SELECT top 1 ve.PanelTime,ve.PanelLocalDT ,ve.UserNumber,ve.DoorNumberText"
            sql += " FROM  dbo.ViewEvents as ve"
            sql += " where ve.panelTime > " & panelTimeTmp & " and ve.DoorNumberText ='Innerfence I-8 IN' and priority=1000 and PanelLocalDT > 43465.9999421296"
            sql += " order by ve.Paneltime desc"
            'sql += " select * From #tmp1"
            'sql += " Drop table #tmp1"
            Dim adp As New SqlDataAdapter(sql, conn)
            adp.SelectCommand.CommandType = CommandType.Text
            adp.Fill(ds)


            Dim dt As DataTable
            dt = ds.Tables(0)
            Return dt


        Catch ex As Exception
            '      Common.DataHelper.WriteLogFile("Call Function getDepartment_Search_L1 - ERROR: " + ex.Message, LogFileName);
            Throw ex
        Finally
            conn.Close()
        End Try
    End Function

    Public Function getNewDataOut(panelTimeTmp As Integer) As Boolean
        Dim connStr As String = "Data Source=172.16.128.16\Verex ;Initial Catalog=Director;Persist Security Info=True;User ID=DirectorQueryUser;Password=P@ssw0rd;Connection Timeout=120;"
        Dim conn As SqlConnection = COMMON.DataHelper.getSQLServerConnectionObject(connStr)
        Dim ds As New DataSet()

        Try


            Dim sql As String

            sql = "  SELECT top 1 ve.PanelTime,ve.UserNumber,ve.PanelLocalDT"
            sql += " FROM  dbo.ViewEvents as ve"
            sql += " where panelTime > " & panelTimeTmp & " and DoorNumberText ='Innerfence I-8 OUT' and  PanelLocalDT > 43465.9999421296"
            sql += " order by ve.Paneltime desc"
            'sql += " Select * From #tmp1 "
            'sql += " order by PanelLocalDT desc"
            'sql += " drop table #tmp1"
            Dim adp As New SqlDataAdapter(sql, conn)
            adp.SelectCommand.CommandType = CommandType.Text
            adp.Fill(ds)


            Dim dt As DataTable
            dt = ds.Tables(0)
            If dt.Rows.Count > 0 Then
                Return True
            Else
                Return False

            End If


        Catch ex As Exception
            '      Common.DataHelper.WriteLogFile("Call Function getDepartment_Search_L1 - ERROR: " + ex.Message, LogFileName);
            Throw ex
        Finally
            conn.Close()
        End Try
    End Function

End Class
