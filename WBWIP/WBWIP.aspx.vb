Imports System.Data.SqlClient
Imports System.ComponentModel
Imports System.Web.UI
Imports System.Web.UI.WebControls
Imports System.Collections.Generic
Public Class DBWIP
    Inherits System.Web.UI.Page

    Private Const VIEWSTATE_C1_VALUE As String = "VIEWSTATE_C1"

    Dim NetVersion As String = "2017-02-03 V0.1"

    Dim C1 As Class1
    'Start program Check Process
    Private ConnectionString As String = My.Settings.DBxConnectionString
    Private Sub RequestUrl()
        IsPostBackINPUT()
        lbGotoProcess.Text = Request.QueryString("RackNo")

        '  ScriptManager.RegisterStartupScript(Me, Page.GetType, "Script", "showDialog2('Url ExWB:WBWIP.aspx?Process=WB&RackNo=WB-R01(Rack)','Url ExWB:WBWIP.aspx?Process=Blank(ShowBlank)','Url ExBefore:WBWIP.aspx?LotNo=1108A1535V&Process=DB&MCNo=D-01&OPNo=000123&Package=HRP5&FramType=FramType&StatusLot=Delay&NextProcess=WB(DB)','Url ExBefore:WBWIP.aspx?LotNo=1108A1535V&Process=DB&MCNo=D-01&OPNo=000123&Package=HRP5&NextProcess=WB(PLASMA,INS,Other)');", True)

    End Sub
    'INPUT Rack

    'Private Sub LImenu(Process As String)

    '    If Process Like "*WB*" Then
    '        Blank()
    '        Tab3.Attributes("Class") = "hide"
    '        '  Tab3.Attributes("Class") = "ui-tabs-active"
    '        ' Tab1.Attributes("Class") = "hide"
    '        Tab2.Attributes("Class") = "hide"
    '        PanelRackSelect.Visible = False
    '        PanelListBlank.Visible = False
    '        tabs.Visible = False

    '        'ElseIf Process = "Blank" Then
    '        '    Tab2.Attributes("Class") = "ui-tabs-active"
    '        '    Tab3.Attributes("Class") = "hide"
    '        '    PanelRackSelect.Visible = True
    '    Else 'DB         
    '        PanelListBlank.Visible = True
    '        Blank()
    '        Tab2.Attributes("Class") = "ui-tabs-active"
    '        Tab3.Attributes("Class") = "hide"
    '        PanelRackSelect.Visible = True
    '        tabs.Visible = True
    '    End If
    'End Sub
    Dim WorkingSlip As WorkingSlipQRCode = New WorkingSlipQRCode
    Private Sub IsPostBackINPUT()

        If IsPostBack Then
            If (tbOPNo.Text.Length = 6) AndAlso Session("OPNoIN") Is Nothing Then

                tbOPNo.Text = tbOPNo.Text.Substring(0, 6)
                Session("OPNoIN") = tbOPNo.Text.Substring(0, 6)
                '    tbOPNo.Text = tbOPNo.Text.Substring(0, 6)
                ' tbOPNo.Text = Nothing
                tbLotNo.Text = Nothing
                tbLotNo.Focus()

            ElseIf tbLotNo.Text.Length = 252 AndAlso Session("LotNoIN") Is Nothing Then
                If Session("OPNoIN") = Nothing Then

                    '   MsgBox("กรุณา Scan OPNo.")
                    tbLotNo.Text = Nothing
                    tbOPNo.Focus()
                    ' ScriptManager.RegisterStartupScript(Me, Page.GetType, "Script", "showDialog('กรุณา Scan OPNo.');", True)
                    Session("Massage") = "showDialog,กรุณา Scan OPNo."
                    Response.Redirect(Request.Url.AbsoluteUri)
                    Exit Sub
                End If

                WorkingSlip.SplitQRCode(tbLotNo.Text)

                SqlDBx.SelectCommand = "SELECT  WIP.WBRackWIP.ID,WIP.WBRackWIP.Position,WIP.WBRackWIP.RackNo,WIP.WBWIP.LotNo, WIP.WBWIP.PackageID,wip.WBWIP.InputRackTime FROM WIP.WBWIP INNER JOIN WIP.WBRackWIP ON WIP.WBWIP.RackID = WIP.WBRackWIP.ID where LotNo='" & WorkingSlip.LotNo & "' and OutputRackTime is null "
                Dim dviewCheckPosition As DataView = CType(SqlDBx.Select(DataSourceSelectArguments.Empty), DataView)
                If dviewCheckPosition.Count > 0 Then

                    'tbLotNo.Text = Nothing
                    '' ScriptManager.RegisterStartupScript(Me, Page.GetType, "Script", "showDialog('Lot No. นี้ถูกยิ่งเข้าไปแล้ว');", True)
                    'Session("Massage") = "showDialog,Lot No. นี้ถูกยิ่งเข้าไปแล้ว"
                    'Response.Redirect(Request.Url.AbsoluteUri)
                    'Exit Sub
                    Session("Massage") = "showDialog,Cancel Lot"
                    SqlDBx.UpdateCommand = "UPDATE WIP.WBWIP SET Remark='CANCELLOT', OutputRackTime = '" & Format(Now, "yyyy-MM-dd HH:mm:ss") & "',OPNoOutputRack='" & Session("OPNoIN") & "' WHERE LotNo = '" & WorkingSlip.LotNo & "' and OutputRackTime is Null "
                    SqlDBx.Update()

                    SqlDBx.UpdateCommand = "UPDATE WIP.WBRackWIP SET UseLot = 'False' WHERE ID = '" & dviewCheckPosition(0)(0) & "'"  'RackID
                    SqlDBx.Update()
                    Session("OPNoIN") = Nothing
                    Session("LotNoIN") = Nothing
                    tbLotNo.Text = Nothing
                    tbOPNo.Text = Nothing
                    Response.Redirect(Request.Url.AbsoluteUri)
                End If

                If CheckPKG(WorkingSlip.Package) = False Then
                    Session("Massage") = "showDialog,PKG. ไม่สามารถเข้า Rack No. นี้ได้"
                    Response.Redirect(Request.Url.AbsoluteUri)
                End If

                Session("Package") = WorkingSlip.Package
                Session("LotNoIN") = WorkingSlip.LotNo
                '   Session("Device") = WorkingSlip.Device
                Session("FramType") = WorkingSlip.FrameType
                tbLotNo.Text = WorkingSlip.LotNo

                ' Session("StatusLot") = "DeD"
                ' Session("ProcessBefore") = "DBX"
                'tbLotNo.Text = Nothing
                tbRackNo.Text = Nothing
                tbRackNo.Focus()
            ElseIf tbRackNo.Text.Length = 9 AndAlso Session("RackNoIN") Is Nothing Then
                If Session("OPNoIN") = Nothing Then

                    ' MsgBox("กรุณา Scan OPNo.")
                    tbRackNo.Text = Nothing
                    '  tbOPNo.Focus()
                    ' ScriptManager.RegisterStartupScript(Me, Page.GetType, "Script", "showDialog('กรุณา Scan OPNo.');", True)
                    Session("Massage") = "showDialog,กรุณา Scan OPNo."
                    Response.Redirect(Request.Url.AbsoluteUri)
                    Exit Sub
                End If
                If Session("LotNoIN") = Nothing Then

                    tbRackNo.Text = Nothing
                    '   tbLotNo.Focus()
                    '  ScriptManager.RegisterStartupScript(Me, Page.GetType, "Script", "showDialog('กรุณา Scan LotNo.');", True)
                    Session("Massage") = "showDialog,กรุณา Scan LotNo."
                    Response.Redirect(Request.Url.AbsoluteUri)
                    Exit Sub
                End If

                Session("RackNoIN") = tbRackNo.Text
                If Not Session("RackNoIN") Like "*" & Request.QueryString("RackNo") & "*" Then
                    Session("RackNoIN") = Nothing
                    tbRackNo.Text = Nothing
                    Session("Massage") = "showDialog,กรุณาเลือกให้ตรง Rack No."
                    Response.Redirect(Request.Url.AbsoluteUri)
                    Exit Sub
                End If
                Dim Rack As String = Session("RackNoIN").ToString.Split("-")(0) & "-" & Session("RackNoIN").ToString.Split("-")(1)
                Dim Position As String = Session("RackNoIN").ToString.Split("-")(2)
                SqlDBx.SelectCommand = "SELECT ID, RackNo, Position, UseLot FROM WIP.WBRackWIP where RackNo='" & Rack & "' and Position='" & Position.Replace("0", "") & "' and UseLot='0'"
                Dim dviewCheckLot As DataView = CType(SqlDBx.Select(DataSourceSelectArguments.Empty), DataView)

                If dviewCheckLot.Count > 0 Then
                    '   ScriptManager.RegisterStartupScript(Me, Page.GetType, "Script", "showDialog2();", True)

                    Session("Massage") = "showDialog2"
                    Response.Redirect(Request.Url.AbsoluteUri)
                Else
                    Session("RackNoIN") = Nothing
                    tbRackNo.Text = Nothing
                    ' ScriptManager.RegisterStartupScript(Me, Page.GetType, "Script", "showDialog('ช่องนี้มีงานอยู่');", True)
                    Session("Massage") = "showDialog,ช่องนี้มีงานอยู่"
                    Response.Redirect(Request.Url.AbsoluteUri)
                End If

            Else
                If (tbOPNo.Text.Length <> "6" AndAlso tbOPNo.Text.Length <> 0) OrElse (tbLotNo.Text.Length <> 252 AndAlso tbLotNo.Text.Length <> 0) OrElse (tbRackNo.Text.Length <> 9 AndAlso tbRackNo.Text.Length <> 0) Then
                    ' ScriptManager.RegisterStartupScript(Me, Page.GetType, "Script", "showDialog('กรุณาสแกนใหม่อีกรอบ');", True)
                    Session("Massage") = "showDialog,กรุณาสแกนใหม่อีกรอบ"
                    Response.Redirect(Request.Url.AbsoluteUri)
                End If

            End If
        End If
    End Sub
    Private Sub ClearText()
        Session("OPNoIN") = Nothing
        tbOPNo.Text = Nothing
        Session("LotNoIN") = Nothing
        tbLotNo.Text = Nothing
        Session("RackNoIN") = Nothing
        tbRackNo.Text = Nothing
        tbOPNo.Focus()
    End Sub
    Private Function CheckPKG(PKG As String) As Boolean
        SqlDBx.SelectCommand = "SELECT ID, AssyName FROM Package Where AssyName = '" & PKG & "'"
        Dim searchPackageID As DataView = CType(SqlDBx.Select(DataSourceSelectArguments.Empty), DataView)
        Session("PackageID") = searchPackageID.Item(0).Row(0)


        SqlDBx.SelectCommand = "SELECT  RackNo, PackageID FROM   WIP.WBRackPackage WHERE  PackageID = '" & Session("PackageID") & "'"
        Dim CheckPackageID As DataView = CType(SqlDBx.Select(DataSourceSelectArguments.Empty), DataView)
        Dim StatusPKG As Boolean = False

        For Each ListRack As DataRowView In CheckPackageID
            If ListRack("RackNo") = Request.QueryString("RackNo") Then
                StatusPKG = True
            End If
        Next

        Return StatusPKG
    End Function
    Private Sub InPutRack()

        'SqlDBx.SelectCommand = "SELECT ID, AssyName FROM Package Where AssyName = '" & Session("Package") & "'"
        'Dim searchPackageID As DataView = CType(SqlDBx.Select(DataSourceSelectArguments.Empty), DataView)
        'Session("PackageID") = searchPackageID.Item(0).Row(0)


        'SqlDBx.SelectCommand = "SELECT  RackNo, PackageID FROM   WIP.WBRackPackage WHERE  PackageID = '" & Session("PackageID") & "'"
        'Dim CheckPackageID As DataView = CType(SqlDBx.Select(DataSourceSelectArguments.Empty), DataView)
        'Dim StatusPKG As Boolean = False

        'For Each ListRack As DataRowView In CheckPackageID
        '    If ListRack("RackNo") = Request.QueryString("RackNo") Then
        '        StatusPKG = True
        '    End If
        'Next
        'If StatusPKG = False Then
        '    Session("Massage") = "showDialog,PKG. ไม่สามารถเข้า Rack No. นี้ได้"
        '    Response.Redirect(Request.Url.AbsoluteUri)
        '    Exit Sub
        'End If
        'Request.QueryString("FramType")
        'Session("StatusLot") = Request.QueryString("StatusLot")
        SqlAPCSDB.SelectCommand = "SELECT [LOT_NO_1],[MANU_COND_GOLD_LINE] FROM [APCSDB].[dbo].[LCQW_UNION_WORK_DENPYO_PRINT] where LOT_NO_1='" & Session("LotNoIN") & "'"
            Dim CheckWireType As DataView = CType(SqlAPCSDB.Select(DataSourceSelectArguments.Empty), DataView)
            Session("WireTypeSize") = CheckWireType.Item(0).Row(1) '[MANU_COND_GOLD_LINE]  'Request.QueryString("WireTypeSize") '"D-01"

        Dim Rack As String = Session("RackNoIN").ToString.Split("-")(0) & "-" & Session("RackNoIN").ToString.Split("-")(1)
        Dim Position As String = Session("RackNoIN").ToString.Split("-")(2)
        SqlDBx.SelectCommand = "SELECT ID, RackNo, Position, UseLot FROM WIP.WBRackWIP where RackNo='" & Rack & "' and Position='" & Position.Replace("0", "") & "'"
        Dim dviewCheckLot As DataView = CType(SqlDBx.Select(DataSourceSelectArguments.Empty), DataView)

        If dviewCheckLot.Count > 0 Then 'หา RackNo ที่ว่าง

            SqlDBx.UpdateCommand = "UPDATE WIP.WBRackWIP SET UseLot = 'True' WHERE ID = '" & dviewCheckLot.Item(0).Row(0).ToString & "'" 'row ,cell
            SqlDBx.Update()
            Session("RackNo") = dviewCheckLot.Item(0).Row(1).ToString
            Dim Time As String = Format(Now, "yyyy-MM-dd HH:mm:ss")
            SqlDBx.InsertCommand = "INSERT INTO WIP.WBWIP (LotNo,PackageID,ProcessBefore,FramType,WireTypeSize,StatusLot,InputRackTime,OPNoInputRack,RackID,ProcessBeforeEndTime) VALUES ('" & Session("LotNoIN").ToString & "','" & Session("PackageID").ToString & "','" & Session("Process") & "','" & Session("FramType").ToString & "','" & Session("WireTypeSize").ToString & "','" & Session("Status") & "','" & Time & "','" & Session("OPNoIN") & "','" & dviewCheckLot.Item(0).Row(0).ToString & "','" & Time & "')"
            SqlDBx.Insert()
        End If



        ' End If
    End Sub
    Private Sub Dialog()
        If Request.QueryString("RackNo") Is Nothing Then
            ScriptManager.RegisterStartupScript(Me, Page.GetType, "Script", "showDialog('WBWIP.aspx?Process=WB&RackNo=WB-R01,CheckWBWIP.aspx?');", True)
            Exit Sub
        Else
            lbGotoProcess.Text = Request.QueryString("RackNo")
        End If



        If Session("OPNoIN") IsNot Nothing Then
            tbOPNo.Text = Session("OPNoIN")
        End If
        If Session("LotNoIN") IsNot Nothing Then
            tbLotNo.Text = Session("LotNoIN")
        End If

        If Session("Massage") IsNot Nothing Then
            If Session("Massage").ToString.Split(",")(0) = "showDialog" Then
                ScriptManager.RegisterStartupScript(Me, Page.GetType, "Script", "showDialog('" & Session("Massage").ToString.Split(",")(1) & "');", True)
            ElseIf Session("Massage") = "CancelLot" Then
                ' ScriptManager.RegisterStartupScript(Me, Page.GetType, "Script", "showDialogCancel();", True)
            Else
                ScriptManager.RegisterStartupScript(Me, Page.GetType, "Script", "showDialog2();", True)
            End If

            Session("Massage") = Nothing
        End If
    End Sub
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Try
            Dialog()
            Dim Input As Boolean = False
            If IsPostBack Then
                Dim ctrlname As String = Page.Request.Params("__EVENTTARGET")
                If ctrlname = "SubmitButton" Then
                    RequestUrl()

                End If
                Dim ListStatus() As String = {"DELAY", "NORMAL", "URGENT"}

                If ListStatus.Contains(ctrlname.Split("-")(0)) Then

                    Session("Status") = ctrlname.Split("-")(0)
                    Session("Process") = ctrlname.Split("-")(1)


                    InPutRack()
                    ClearText()
                    Session("Massage") = "showDialog,Input เรียบร้อย"
                    Response.Redirect(Request.Url.AbsoluteUri)
                End If

                If Session("OPNoIN") Is Nothing Then
                    '  tbOPNo.Focus()
                    ScriptManager2.SetFocus(tbOPNo)

                ElseIf Session("LotNoIN") Is Nothing Then

                    ScriptManager2.SetFocus(tbLotNo)
                ElseIf Session("RackNoIN") Is Nothing Then

                    ScriptManager2.SetFocus(tbRackNo)
                End If

                Exit Sub

            Else

                'If Request.QueryString("Process") IsNot Nothing Then
                '    LImenu(Request.QueryString("Process").ToUpper)
                'End If

                Input = True

            End If

        Catch ex As Exception
            ScriptManager.RegisterClientScriptBlock(Me, Me.GetType(), "alertMessage", "Page_Load" & ex.Message.ToString, True)
        End Try


        'Try

        '    '   Me.BindGrid(Input)
        '    Me.BindGrid(False)
        'Catch

        'End Try

    End Sub
    Private Sub BindGrid()


        Dim dtMessages As DataTable = DirectCast(Cache.[Get]("Messages" & Request.QueryString("RackNo")), DataTable)
            Debug.Print(Now.ToString("yyyy/MM/dd HH:mm:ss") & " LoadMessages :=" & (dtMessages Is Nothing))
        If dtMessages Is Nothing Then
            lblDate.Text = "Version 1.03 >> " & String.Format("Last retrieved DateTime : {0}", System.DateTime.Now.ToString("HH:mm:ss"))


            Try
                dtMessages = Me.LoadMessages()
            Catch ex As Exception
                ScriptManager.RegisterClientScriptBlock(Me, Me.GetType(), "alertMessage", "LoadMessages" & ex.Message.ToString, True)
            End Try
            'If Forloop = False Then
            '    RequestUrl()
            '    ' UpdatePanelControl.Update()
            '    ' UpdatePanelBlank.Update()
            'End If

        Else
            '  lblDate.Text = "Data Retrieved from Cache"
            '     lblDate.Text = String.Format("Last cache DateTime : {0}", System.DateTime.Now.ToString("HH:mm:ss"))
            Try
                GetCache()
            Catch ex As Exception
                ScriptManager.RegisterClientScriptBlock(Me, Me.GetType(), "alertMessage", "GetCache" & ex.Message.ToString, True)
            End Try
        End If




    End Sub
    Private Sub GetCache()

        Debug.Print("GetCache()")
        Dim CacheData As DataTable = DirectCast(Cache.[Get](Request.QueryString("RackNo")), DataTable)
        For Each user As Control In Panel1.Controls
            If TypeOf user Is UserControl = True Then
                Dim UserControl As ControlPosition = user
                For Each listData As DataRow In CacheData.Rows
                    If user.ID Like "*" & listData("lbPosition") & "*" Then
                        Dim Color As Drawing.Color
                        If listData("Color").ToString.ToUpper = "RED" Then
                            Color = Drawing.Color.Red
                        ElseIf listData("Color").ToString.ToUpper = "LAWNGREEN" Then
                            Color = Drawing.Color.LawnGreen
                        ElseIf listData("Color").ToString.ToUpper = "YELLOW" Then
                            Color = Drawing.Color.Yellow
                        Else
                            Color = Drawing.Color.Transparent
                        End If

                        Dim CountTime As TimeSpan = New TimeSpan(0, 0, 0)
                        If listData("InputRackTime") IsNot DBNull.Value Then
                            CountTime = Date.Now - CDate(listData("InputRackTime"))
                        End If
                        '   UserControl.CountTime(CountTime)
                        UserControl.SetData(listData("lbLotNo"), listData("lbPKG"), listData("lbDevice"), listData("lbWireType"), listData("lbFrameType"), listData("lbMCNoRequest"), listData("lbPosition"), listData("lbStatus"), Color, listData("BackImageUrl"), CountTime)
                    End If
                    ' UserControl.SetData()
                    '    Debug.Print(listData("lbPKG") & " : " & listData("lbPosition") & ":" & Now.ToString("yyyy/MM/dd HH:mm:ss"))
                Next

            End If

        Next

        ' GridView1.DataSource = CacheData
        ' GridView1.DataBind()
        '   GridView1.RowStyle.HorizontalAlign = HorizontalAlign.Left
    End Sub
    Private Function LoadMessages() As DataTable

        Dim dtMessages As New DataTable()

        Debug.Print(Now.ToString("yyyy/MM/dd HH:mm:ss") & " LoadMessages :=" & Request.UrlReferrer.OriginalString)

        Using connection As New SqlConnection(Me.ConnectionString)
            Dim sql As String = "SELECT LotNo,ProcessBefore,RackID FROM WIP.WBWIP"
            'If Request.QueryString("RackNo") IsNot Nothing Then
            '    If Request.QueryString("RackNo") = "WB-R01" Then
            '        sql = "SELECT LotNo,ProcessBefore,RackID FROM WIP.WBWIP where RackID='1'"
            '        Button3.Text = "1"
            '    ElseIf Request.QueryString("RackNo") = "WB-R02" Then
            '        sql = "SELECT LotNo,ProcessBefore,RackID FROM WIP.WBWIP where RackID='29'"
            '        Button3.Text = "29"
            '    End If

            'End If


            If Request.QueryString("RackNo") IsNot Nothing Then
                'SqlDBx.SelectCommand = "SELECT * from  WIP.WBRackWIP a1 " _
                '    & " where (0 = (SELECT count(*) from (SELECT id from  WIP.WBRackWIP where  RackNo ='WB-R02' GROUP BY id) a2 where a2.ID<a1.id) " _
                '    & " or  0 = (SELECT count(*) from (SELECT id from  WIP.WBRackWIP where  RackNo ='WB-R02' GROUP BY id) a2 where a2.ID>a1.id)) " _
                '    & " and RackNo ='WB-R02'"
                'Dim dviewCheckRack As DataView = CType(SqlDBx.Select(DataSourceSelectArguments.Empty), DataView) ''RackID



                'Length min-max 1-20 Rack 1 ,min-max 21-40 Rack 2,... แยก Rack ในการ service
                Dim min As Double = 0
                Dim max As Double = 20
                max = max * CDbl(Request.QueryString("RackNo").Split("R")(1))
                min = max - 19
                '    CacheRemove.Text = min & "-" & max
                sql = "Select  LotNo,ProcessBefore,RackID FROM WIP.WBWIP where RackID between '" & min & "' and '" & max & "' and OutputRackTime is null "
            End If

            Dim command As New SqlCommand(sql, connection) 'WHERE ProcessBefore='WB'
            ' Dim command As New SqlCommand("SELECT LotNo,ProcessBefore,RackID FROM WIP.WBWIP ", connection) 

            Dim dependency As New SqlCacheDependency(command)


            If connection.State = ConnectionState.Closed Then
                connection.Open()
            End If

            dtMessages.Load(command.ExecuteReader(CommandBehavior.CloseConnection))
            'Cache.Remove("Messages")

            'Cache Save
            SubRefreshDisplayCache(Request.QueryString("RackNo"))


            Cache.Insert("Messages" & Request.QueryString("RackNo"), dtMessages, dependency)
        End Using

        Return dtMessages
    End Function

    Private Sub SubRefreshDisplayCache(Messages As String)
        Try
            ' RequestUrl()
            Debug.Print("SubRefreshDisplayCache()")
            LoadWIP(Request.QueryString("RackNo"))
            Dim _T1 As DataTable = New DataTable
            _T1.Columns.Add("RackNo")
            _T1.Columns.Add("lbLotNo")
            _T1.Columns.Add("lbPKG")
            _T1.Columns.Add("lbDevice")
            _T1.Columns.Add("lbWireType")
            _T1.Columns.Add("lbFrameType")
            _T1.Columns.Add("lbMCNoRequest")
            _T1.Columns.Add("lbPosition")
            _T1.Columns.Add("lbStatus")
            _T1.Columns.Add("Color")
            _T1.Columns.Add("BackImageUrl")
            _T1.Columns.Add("InputRackTime")

            For Each user As Control In Panel1.Controls
                Dim _row As DataRow = _T1.NewRow
                If TypeOf user Is UserControl = True Then
                    Dim UserControl As ControlPosition = user
                    UserControl.GetData()
                    '  Debug.Print(Session("lbLotNo") & ">>" & Request.Cookies("Rack")("InputRackTime" & CInt(user.ID.Split("n")(2))))
                    _row("RackNo") = Request.QueryString("RackNo")
                    _row("lbLotNo") = Session("lbLotNo")
                    _row("lbPKG") = Session("lbPKG")
                    _row("lbDevice") = Session("lbDevice")
                    _row("lbWireType") = Session("lbWireType")
                    _row("lbFrameType") = Session("lbFrameType")
                    _row("lbMCNoRequest") = Session("lbMCNoRequest")
                    _row("lbPosition") = Session("lbPosition")
                    _row("lbStatus") = Session("lbStatus")
                    _row("Color") = Session("Color")
                    _row("BackImageUrl") = Session("BackImageUrl")
                    _row("InputRackTime") = Session("InputRackTime" & CInt(user.ID.Split("n")(2))) ' Request.Cookies("Rack")("InputRackTime" & CInt(user.ID.Split("n")(2)))
                    'Session("lbLotNo") = lbLotNo.Text
                    'Session("lbPKG") = lbPKG.Text
                    'Session("lbDevice") = lbDevice.Text
                    'Session("lbWireType") = lbWireType.Text
                    'Session("lbFrameType") = lbFrameType.Text
                    'Session("lbMCNoRequest") = lbMCNoRequest.Text
                    'Session("lbPosition") = lbPosition.Text
                    '  Debug.Print("sum" & Session("lbPosition"))
                    _T1.Rows.Add(_row)
                End If


            Next
            Cache.Insert(Messages, _T1)
        Catch ex As Exception
            ScriptManager.RegisterClientScriptBlock(Me, Me.GetType(), "alertMessage", "SubRefreshDisplayCache" & ex.Message.ToString, True)
        End Try


    End Sub


    Protected Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick

        'RequestUrl()

        Dim cookieRack As HttpCookie = Request.Cookies("Rack")
        If cookieRack Is Nothing Then
            Me.BindGrid()
            Exit Sub
        End If

        'For Each user As Control In Panel1.Controls

        '    If TypeOf user Is UserControl = True Then
        '        Dim UserControl As ControlPosition = user
        '        Dim CountTime As TimeSpan = New TimeSpan(0, 0, 0)
        '        ' Try

        '        '  cookieRack.Item
        '        If cookieRack("InputRackTime" & CInt(user.ID.Split("n")(2))) IsNot Nothing Then
        '            CountTime = Date.Now - CDate(Request.Cookies("Rack")("InputRackTime" & CInt(user.ID.Split("n")(2))))
        '        End If
        '        'Catch ex As Exception

        '        'End Try


        '        UserControl.CountTime(CountTime)

        '        '  'HoldLot
        '        'Dim Data As List(Of String) = UserControl.CountTime(CountTime)
        '        ' If Data.Count > 0 Then
        '        '   Dim LotNo As String = Data(0).Split("(")(0)
        '        '    Dim Process As String = Data(1)

        '        '   If Request.QueryString("Process") Is Nothing OrElse Not Request.QueryString("Process") Like "*WB*" Then '<>WB and WBMASTER
        '        ' 'Exit Sub
        '        '     GoTo SkipStep
        '        'End If
        '        'Dim SetHoldLot As Double = 240
        '        'If Request.QueryString("HOLDLOT") IsNot Nothing Then
        '        '    SetHoldLot = Request.QueryString("HOLDLOT")
        '        'End If
        '        'If CountTime.TotalMinutes >= SetHoldLot AndAlso Request.Cookies("Rack")("HoldLot" & CInt(user.ID.Split("n")(2))) <> Nothing AndAlso Request.Cookies("Rack")("HoldLot" & CInt(user.ID.Split("n")(2))) <> "CANCELHOLD" Then ' Hold Lot 4 Hour ยังไม่ได้ทำ Setting
        '        '    Debug.Print(CountTime.TotalSeconds.ToString)
        '        '    SqlDBx.SelectCommand = "SELECT  RackID FROM  WIP.WBWIP where LotNo ='" & LotNo & "' and OutputRackTime is Null"
        '        '    Dim dviewCheckRack As DataView = CType(SqlDBx.Select(DataSourceSelectArguments.Empty), DataView) ''RackID

        '        '    SqlDBx.UpdateCommand = "UPDATE WIP.WBRackWIP SET UseLot = 'False' WHERE ID = '" & dviewCheckRack(0)(0) & "'"  'RackID
        '        '    SqlDBx.Update()
        '        '    SqlDBx.UpdateCommand = "UPDATE WIP.WBWIP SET RackID = NULL,WBWIP.Remark='HOLD' WHERE LotNo = '" & LotNo & "' and OutputRackTime is Null "
        '        '    SqlDBx.Update()

        '        'End If
        '        'SkipStep:


        '        'End If

        '    End If
        'Next
        'Dim Time As TimeSpan = New TimeSpan(0, DateTime.Now.Minute, DateTime.Now.Second)
        'If Time.TotalMinutes Mod 4 = 0 Then
        '    RequestUrl()
        'End If

        Me.BindGrid()
    End Sub


    Private Sub LoadWIP(RackNo As String)
        Dim newCookie As HttpCookie = New HttpCookie("Rack")
        SqlDBx.SelectCommand = "SELECT  WIP.WBRackWIP.ID, WIP.WBRackWIP.RackNo, WIP.WBRackWIP.Position, WIP.WBRackWIP.UseLot, WBWIP.LotNo, Package.AssyName, TransactionData.Device, TransactionData.FrameNo,TransactionData.CodeNo, WBWIP.PackageID, WBWIP.ProcessBefore,WBWIP.MCNoProcessBefore, WBWIP.OPNoProcessBefore, WBWIP.ProcessBeforeEndTime,WBWIP.FramType, WBWIP.WireTypeSize, WBWIP.RackID, WBWIP.InputRackTime, WBWIP.OPNoInputRack, WBWIP.OutputRackTime,WBWIP.OPNoOutputRack, WBWIP.MachineRequest, WBWIP.OPNoRequest, WBWIP.RequestTime,WBWIP.StatusLot,WBWIP.Remark FROM  Package INNER JOIN (select * from WIP.WBWIP where OutputRackTime is null) as WBWIP ON Package.ID = WBWIP.PackageID LEFT OUTER JOIN TransactionData ON WBWIP.LotNo = TransactionData.LotNo RIGHT OUTER JOIN WIP.WBRackWIP ON WBWIP.RackID = WIP.WBRackWIP.ID WHERE (WIP.WBRackWIP.RackNo  = '" & RackNo & "') and OutputRackTime is null"
        Dim dviewCheckRack As DataView = CType(SqlDBx.Select(DataSourceSelectArguments.Empty), DataView)
        For Each user As Control In Panel1.Controls
            For Each data As DataRowView In dviewCheckRack
                If TypeOf user Is UserControl = True Then
                    Dim No As String = data("Position")
                    If user.ID Like "*" & No & "*" Then

                        '-----------
                        Dim UserControl As ControlPosition = user
                        If data("LotNo") Is DBNull.Value Then
                            UserControl.newControl(data("UseLot"), "-", System.Drawing.Color.Red, "-", "-", "-", " ", " ", RackNo & "-" & "0" & No, " ", "", "") 'UseLot True Red ,UseLot False No Color 'AssyName
                        Else
                            ' If data("Position").ToString <> Request.Cookies("Rack")("No" & data("Position").ToString) Then
                            If data("Remark") IsNot DBNull.Value Then 'data("Remark")
                                newCookie("HoldLot" & data("Position").ToString) = data("Remark")
                            Else
                                newCookie("HoldLot" & data("Position").ToString) = "NULL"
                            End If
                            ' newCookie("No" & data("Position").ToString) = data("LotNo")
                            newCookie("InputRackTime" & data("Position").ToString) = data("InputRackTime")
                            Session("InputRackTime" & data("Position").ToString) = data("InputRackTime")
                            Dim Color As Drawing.Color
                            If data("InputRackTime") Is DBNull.Value Then
                                If data("RequestTime") IsNot DBNull.Value Then
                                    Color = System.Drawing.Color.Yellow 'request
                                Else
                                    Color = System.Drawing.Color.Orange 'Booking
                                End If
                            Else
                                If data("RequestTime") IsNot DBNull.Value Then
                                    Color = System.Drawing.Color.Yellow 'request
                                Else
                                    Color = System.Drawing.Color.LawnGreen
                                End If
                                'Color = System.Drawing.Color.LawnGreen
                            End If

                            If data("Device") Is DBNull.Value Then
                                Dim Device As String = "-"
                                SqlAPCSDB.SelectCommand = "SELECT ASSY_MODEL_NAME_1, FORM_NAME_1, LOT_NO_1 FROM LCQW_UNION_WORK_DENPYO_PRINT WHERE (LOT_NO_1 = '" & data("LotNo") & "')"
                                Dim GetDeviceAPCS As DataView = CType(SqlAPCSDB.Select(DataSourceSelectArguments.Empty), DataView)
                                For Each DeviceAPCS As DataRowView In GetDeviceAPCS
                                    Device = DeviceAPCS("ASSY_MODEL_NAME_1")
                                Next

                                Dim MachineRequest As String = "-"
                                If data("MachineRequest") IsNot DBNull.Value Then
                                    MachineRequest = data("MachineRequest")
                                End If
                                Dim OPNoRequest As String = ""
                                If data("OPNoRequest") IsNot DBNull.Value Then
                                    OPNoRequest = " (" & data("OPNoRequest") & ")"
                                End If

                                UserControl.newControl(data("UseLot"), data("LotNo"), Color, data("AssyName") & " | CodeNo :" & data("CodeNo"), Device, data("ProcessBefore"), MachineRequest, OPNoRequest, RackNo & "-" & "0" & No, data("StatusLot"), data("FramType"), data("WireTypeSize"))
                            Else
                                Dim MCNo As String = "-"
                                If data("MachineRequest") IsNot DBNull.Value Then
                                    MCNo = data("MachineRequest")
                                End If
                                Dim OPNoRequest As String = ""
                                If data("OPNoRequest") IsNot DBNull.Value Then
                                    OPNoRequest = " (" & data("OPNoRequest") & ")"
                                End If
                                UserControl.newControl(data("UseLot"), data("LotNo"), Color, data("AssyName") & " | CodeNo :" & data("CodeNo"), data("Device"), data("ProcessBefore"), MCNo, OPNoRequest, RackNo & "-" & "0" & No, data("StatusLot"), data("FramType"), data("WireTypeSize"))
                            End If

                        End If

                    End If
                End If
            Next
        Next
        newCookie.Expires = DateTime.Now.AddDays(7)
        Response.Cookies.Add(newCookie)
    End Sub

    Protected Sub Button3_Click(sender As Object, e As EventArgs) Handles CacheRemove.Click
        '  Dim czx As String = Request.Cookies("Rack")("No1")
        ' RequestUrl()
        'Tab1.Attributes("Class") = "ui-tabs-active" 
        ' ScriptManager.RegisterStartupScript(Me, Page.GetType, "Script", "showDialog('กรุณา Scan OPNo.');", True)
        '  ScriptManager.RegisterStartupScript(Me, Page.GetType, "Script", "showDialog2('กรุณา Scan OPNo.','bb','cc','DD');", True)
        'Dim UserKey As String = "121dfdf1" กำหนดตัวอักษรที่อินพุต
        'Dim Val = ""
        'Dim Base = "98765432108A" 
        'For Each Item In UserKey
        '    If Base.IndexOf(Item) >= 0 Then
        '        Val += Item
        '    End If
        'Next

        Cache.Remove("Messages" & Request.QueryString("RackNo"))
    End Sub


    'Private Sub Blank()
    '    SqlDBx.SelectCommand = "SELECT  distinct  Package.AssyName FROM WIP.WBRackPackage INNER JOIN Package ON WIP.WBRackPackage.PackageID = Package.ID order by AssyName asc"
    '    Dim dviewCheckPKG As DataView = CType(SqlDBx.Select(DataSourceSelectArguments.Empty), DataView)
    '    Dim Text As String = ""
    '    'DropDownListPKG.Items.Clear()
    '    For Each data As DataRowView In dviewCheckPKG

    '        'DropDownListPKG.Items.Add(data("AssyName"))

    '        SqlDBx.SelectCommand = "SELECT count(WIP.WBRackPackage.RackNo) as Blank ,WIP.WBRackPackage.RackNo, Package.AssyName FROM WIP.WBRackPackage INNER JOIN Package ON WIP.WBRackPackage.PackageID = Package.ID INNER JOIN WIP.WBRackWIP ON WIP.WBRackPackage.RackNo = WIP.WBRackWIP.RackNo WHERE (Package.AssyName = '" & data("AssyName") & "') and UseLot='0' group by WIP.WBRackPackage.RackNo,Package.AssyName"
    '        Dim dviewCheckBlank As DataView = CType(SqlDBx.Select(DataSourceSelectArguments.Empty), DataView)
    '        Dim str As String = ""

    '        For Each data2 As DataRowView In dviewCheckBlank
    '            If str = "" Then
    '                str &= data2("RackNo") & "(" & data2("Blank") & ")"
    '            Else
    '                str &= "," & data2("RackNo") & "(" & data2("Blank") & ")"
    '            End If
    '        Next
    '        Text &= data("AssyName") & " :" & str & vbNewLine
    '    Next
    '    TextBox1.Text = Text

    'End Sub



    Protected Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        ClearText()
    End Sub

    Protected Sub CacheRemove0_Click(sender As Object, e As EventArgs) Handles CacheRemove0.Click
        'Session("Massage") = "CancelLot"
        'Response.Redirect(Request.Url.AbsoluteUri)
        ''SqlDBx.UpdateCommand = "UPDATE WIP.WBWIP SET RackID = NULL,WBWIP.Remark='HOLD' WHERE LotNo = '" & LotNo & "' and OutputRackTime is Null "
        ''SqlDBx.Update()
        ScriptManager.RegisterClientScriptBlock(Me, Me.GetType(), "alertMessage", "alert('Record Inserted Successfully')", True)
    End Sub

    Protected Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        Session("Massage") = "CancelLot"
    End Sub
End Class