Imports System.Data.SqlClient
Imports System.ComponentModel
Imports System.Web.UI
Imports System.Web.UI.WebControls
Imports System.Collections.Generic
Public Class CheckWBWIP
    Inherits System.Web.UI.Page
    Private ConnectionString As String = My.Settings.DBxConnectionString
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        'SqlDBx.SelectCommand = "SELECT  distinct  Package.AssyName FROM WIP.WBRackPackage INNER JOIN Package ON WIP.WBRackPackage.PackageID = Package.ID order by AssyName asc"
        'Dim dviewCheckPKG As DataView = CType(SqlDBx.Select(DataSourceSelectArguments.Empty), DataView)
        'Dim Text As String = ""
        'DropDownListPKG.Items.Clear()
        'For Each data As DataRowView In dviewCheckPKG
        '    DropDownListPKG.Items.Add(data("AssyName"))
        'Next
        If IsPostBack Then

        Else
            ItemDropdownRack()
            Blank()
            LoadWIP(DropDownListPKG.Text.Split("(")(0))
            '   LoadWIP("WB-R01")
        End If

    End Sub
    Private Function LoadMessages() As DataTable
        Dim dtMessages As New DataTable()

        Using connection As New SqlConnection(Me.ConnectionString)
            Dim sql As String = "SELECT LotNo,ProcessBefore,RackID FROM WIP.WBWIP"
            If DropDownListPKG.Text.Split("(")(0) IsNot Nothing Then

                'Length min-max 1-20 Rack 1 ,min-max 21-40 Rack 2,... แยก Rack ในการ service
                Dim min As Double = 0
                Dim max As Double = 20
                max = max * CDbl(DropDownListPKG.Text.Split("(")(0).ToString.Split("R")(1))
                min = max - 19
                Button3.Text = min & "-" & max
                sql = "Select  LotNo,ProcessBefore,RackID FROM WIP.WBWIP where RackID between '" & min & "' and '" & max & "'"
            End If

            Dim command As New SqlCommand(sql, connection) 'WHERE ProcessBefore='WB'
            ' Dim command As New SqlCommand("Select ID, RackNo, Position, UseLot From WIP.WBRackWIP ", connection) 'WHERE ProcessBefore='WB'

            Dim dependency As New SqlCacheDependency(command)


            If connection.State = ConnectionState.Closed Then
                connection.Open()
            End If

            dtMessages.Load(command.ExecuteReader(CommandBehavior.CloseConnection))
            '   SubRefreshDisplayCache(Request.QueryString("RackNo"))
            Cache.Insert("Messages" & DropDownListPKG.Text.Split("(")(0), dtMessages, dependency)
        End Using

        Return dtMessages
    End Function
    'Private Sub SubRefreshDisplayCache(Messages As String)
    '    ' RequestUrl()
    '    LoadWIP(Request.QueryString("RackNo"))
    '    Dim _T1 As DataTable = New DataTable
    '    _T1.Columns.Add("RackNo")
    '    _T1.Columns.Add("lbLotNo")
    '    _T1.Columns.Add("lbPKG")
    '    _T1.Columns.Add("lbDevice")
    '    _T1.Columns.Add("lbWireType")
    '    _T1.Columns.Add("lbFrameType")
    '    _T1.Columns.Add("lbMCNoRequest")
    '    _T1.Columns.Add("lbPosition")
    '    _T1.Columns.Add("lbStatus")
    '    _T1.Columns.Add("Color")
    '    _T1.Columns.Add("BackImageUrl")

    '    For Each user As Control In Panel1.Controls
    '        Dim _row As DataRow = _T1.NewRow
    '        If TypeOf user Is UserControl = True Then
    '            Dim UserControl As ControlPosition = user
    '            UserControl.GetData()

    '            _row("RackNo") = Request.QueryString("RackNo")
    '            _row("lbLotNo") = Session("lbLotNo")
    '            _row("lbPKG") = Session("lbPKG")
    '            _row("lbDevice") = Session("lbDevice")
    '            _row("lbWireType") = Session("lbWireType")
    '            _row("lbFrameType") = Session("lbFrameType")
    '            _row("lbMCNoRequest") = Session("lbMCNoRequest")
    '            _row("lbPosition") = Session("lbPosition")
    '            _row("lbStatus") = Session("lbStatus")
    '            _row("Color") = Session("Color")
    '            _row("BackImageUrl") = Session("BackImageUrl")
    '            'Session("lbLotNo") = lbLotNo.Text
    '            'Session("lbPKG") = lbPKG.Text
    '            'Session("lbDevice") = lbDevice.Text
    '            'Session("lbWireType") = lbWireType.Text
    '            'Session("lbFrameType") = lbFrameType.Text
    '            'Session("lbMCNoRequest") = lbMCNoRequest.Text
    '            'Session("lbPosition") = lbPosition.Text
    '            Debug.Print("sum" & Session("lbPosition"))
    '            _T1.Rows.Add(_row)
    '        End If


    '    Next
    '    Cache.Insert(Messages, _T1)

    'End Sub
    'Private Sub BindGrid()

    '    Dim dtMessages As DataTable = DirectCast(Cache.[Get]("Messages" & DropDownListPKG.Text.Split("(")(0)), DataTable)

    '    If dtMessages Is Nothing Then
    '        ItemDropdownRack()
    '        Blank()
    '        LoadWIP(DropDownListPKG.Text.Split("(")(0))

    '        dtMessages = Me.LoadMessages()
    '        '  lblDate.Text = String.Format("Last retrieved DateTime : {0}", System.DateTime.Now.ToString("HH:mm:ss"))

    '        UpdatePanelRackList.Update()
    '        UpdatePanelBlank.Update()
    '    Else
    '        Try
    '            GetCache()
    '        Catch ex As Exception

    '        End Try

    '        '     lblDate.Text = "Data Retrieved from Cache"
    '    End If
    '    ' RequestUrl()
    '    ' grdMessages.DataSource = dtMessages
    '    '  grdMessages.DataBind()
    'End Sub
    Private Sub ItemDropdownRack()

        Dim item As Integer = DropDownListPKG.SelectedIndex
        DropDownListPKG.Items.Clear()
        Dim RackNo As String = ""
        SqlDBx.SelectCommand = "SELECT   DISTINCT   WIP.WBRackWIP.RackNo " _
                & " FROM    WIP.WBRackWIP INNER JOIN" _
                & " WIP.WBRackPackage ON WIP.WBRackWIP.RackNo = WIP.WBRackPackage.RackNo"
        'SqlDBx.SelectCommand = "SELECT   DISTINCT   WIP.WBRackWIP.RackNo FROM    WIP.WBRackWIP INNER JOIN WIP.WBRackPackage ON WIP.WBRackWIP.RackNo = WIP.WBRackPackage.RackNo"
        Dim dviewCheckRack As DataView = CType(SqlDBx.Select(DataSourceSelectArguments.Empty), DataView)
        For Each data As DataRowView In dviewCheckRack
            SqlDBx.SelectCommand = "Select WIP.WBRackPackage.RackNo, WIP.WBRackPackage.PackageID, COUNT(WIP.WBRackWIP.UseLot) As Blank, Package.AssyName" _
                & " FROM WIP.WBRackPackage INNER JOIN" _
                & " WIP.WBRackWIP On WIP.WBRackPackage.RackNo = WIP.WBRackWIP.RackNo INNER JOIN" _
                & " Package On WIP.WBRackPackage.PackageID = Package.ID" _
                & " WHERE (WIP.WBRackWIP.RackNo = '" & data("RackNo") & "') AND (WIP.WBRackWIP.UseLot = 'false')" _
                & " GROUP BY WIP.WBRackPackage.PackageID, WIP.WBRackPackage.RackNo, Package.AssyName"
            Dim dviewCheckPKGBlank As DataView = CType(SqlDBx.Select(DataSourceSelectArguments.Empty), DataView)
            Dim PKG As String = ""
            Dim Blank As String = ""

            For Each PKGINRack As DataRowView In dviewCheckPKGBlank
                If PKG <> "" Then
                    PKG = PKG & "," & PKGINRack("AssyName")
                Else
                    PKG = PKGINRack("AssyName")
                End If

                Blank = PKGINRack("Blank")
            Next
            ' PKG = "(" & PKG & ")"
            Blank = "(" & Blank & ") "
            RackNo = data("RackNo") & Blank & PKG

            DropDownListPKG.Items.Add(RackNo)
        Next
        DropDownListPKG.SelectedIndex = item
        '  Dim xx As String = DropDownListPKG.Text
    End Sub
    Private Sub Blank()
        SqlDBx.SelectCommand = "SELECT  distinct  Package.AssyName FROM WIP.WBRackPackage INNER JOIN Package ON WIP.WBRackPackage.PackageID = Package.ID order by AssyName asc"
        Dim dviewCheckPKG As DataView = CType(SqlDBx.Select(DataSourceSelectArguments.Empty), DataView)
        Dim Text As String = ""

        For Each data As DataRowView In dviewCheckPKG

            SqlDBx.SelectCommand = "SELECT count(WIP.WBRackPackage.RackNo) as Blank ,WIP.WBRackPackage.RackNo, Package.AssyName FROM WIP.WBRackPackage INNER JOIN Package ON WIP.WBRackPackage.PackageID = Package.ID INNER JOIN WIP.WBRackWIP ON WIP.WBRackPackage.RackNo = WIP.WBRackWIP.RackNo WHERE (Package.AssyName = '" & data("AssyName") & "') and UseLot='0' group by WIP.WBRackPackage.RackNo,Package.AssyName"
            Dim dviewCheckBlank As DataView = CType(SqlDBx.Select(DataSourceSelectArguments.Empty), DataView)
            Dim str As String = ""

            For Each data2 As DataRowView In dviewCheckBlank
                If str = "" Then
                    str &= data2("RackNo") & "(" & data2("Blank") & ")"
                Else
                    str &= "," & data2("RackNo") & "(" & data2("Blank") & ")"
                End If
            Next
            Text &= data("AssyName") & " :" & str & vbNewLine
        Next
        TextBox1.Text = Text

    End Sub
    Private Sub LoadWIP(RackNo As String)
        Blank()
        '   Dim newCookie As HttpCookie = New HttpCookie("Rack")
        SqlDBx.SelectCommand = "SELECT  WIP.WBRackWIP.ID, WIP.WBRackWIP.RackNo, WIP.WBRackWIP.Position, WIP.WBRackWIP.UseLot, WBWIP.LotNo, Package.AssyName, TransactionData.Device, TransactionData.FrameNo, WBWIP.PackageID, WBWIP.ProcessBefore,WBWIP.MCNoProcessBefore, WBWIP.OPNoProcessBefore, WBWIP.ProcessBeforeEndTime,WBWIP.FramType, WBWIP.WireTypeSize, WBWIP.RackID, WBWIP.InputRackTime, WBWIP.OPNoInputRack, WBWIP.OutputRackTime,WBWIP.OPNoOutputRack, WBWIP.MachineRequest, WBWIP.OPNoRequest, WBWIP.RequestTime,WBWIP.StatusLot,WBWIP.Remark FROM  Package INNER JOIN (select * from WIP.WBWIP where OutputRackTime is null) as WBWIP ON Package.ID = WBWIP.PackageID LEFT OUTER JOIN TransactionData ON WBWIP.LotNo = TransactionData.LotNo RIGHT OUTER JOIN WIP.WBRackWIP ON WBWIP.RackID = WIP.WBRackWIP.ID WHERE (WIP.WBRackWIP.RackNo  = '" & RackNo & "') and OutputRackTime is null"
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
                            'If data("Position").ToString <> Request.Cookies("Rack")("No" & data("Position").ToString) Then
                            'If data("Remark") IsNot DBNull.Value Then 'data("Remark")
                            '    newCookie("HoldLot" & data("Position").ToString) = data("Remark")
                            'Else
                            '    newCookie("HoldLot" & data("Position").ToString) = "NULL"
                            'End If
                            ' newCookie("No" & data("Position").ToString) = data("LotNo")
                            ' newCookie("EndTime" & data("Position").ToString) = data("ProcessBeforeEndTime")

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
                                Dim MachineRequest As String = "-"
                                If data("MachineRequest") IsNot DBNull.Value Then
                                    MachineRequest = data("MachineRequest")
                                End If
                                Dim OPNoRequest As String = ""
                                If data("OPNoRequest") IsNot DBNull.Value Then
                                    OPNoRequest = " (" & data("OPNoRequest") & ")"
                                End If
                                UserControl.newControl(data("UseLot"), data("LotNo"), Color, data("AssyName"), "-", data("ProcessBefore"), MachineRequest, OPNoRequest, RackNo & "-" & "0" & No, data("StatusLot"), data("FramType"), data("WireTypeSize"))
                            Else
                                Dim MCNo As String = "-"
                                If data("MachineRequest") IsNot DBNull.Value Then
                                    MCNo = data("MachineRequest")
                                End If
                                Dim OPNoRequest As String = ""
                                If data("OPNoRequest") IsNot DBNull.Value Then
                                    OPNoRequest = " (" & data("OPNoRequest") & ")"
                                End If
                                UserControl.newControl(data("UseLot"), data("LotNo"), Color, data("AssyName"), data("Device"), data("ProcessBefore"), MCNo, OPNoRequest, RackNo & "-" & "0" & No, data("StatusLot"), data("FramType"), data("WireTypeSize"))
                            End If

                        End If

                    End If
                End If
            Next
        Next
        lbGotoProcess.Text = RackNo
        'newCookie.Expires = DateTime.Now.AddDays(7)
        'Response.Cookies.Add(newCookie)
    End Sub
    Protected Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        '  Dim ss As String = "12345" _
        '& "67890"
        '  'Dim ss As String = "12345"
        '  'ss &= "67890"
        '  '  MsgBox(ss)
        '  ItemDropdownRack()
        '  Blank()
        LoadWIP("WB-R02")
    End Sub

    Protected Sub DropDownListPKG_SelectedIndexChanged(sender As Object, e As EventArgs) Handles DropDownListPKG.SelectedIndexChanged
        LoadWIP(DropDownListPKG.Text.Split("(")(0))
        ItemDropdownRack()
        UpdatePanelControl.Update()
    End Sub

    Protected Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick

        'BindGrid()
        'For Each user As Control In Panel1.Controls

        '    If TypeOf user Is UserControl = True Then
        '        Dim UserControl As ControlPosition = user
        '        Dim CountTime As TimeSpan = New TimeSpan(0, 0, 0)
        '        If Request.Cookies("Rack")("InputRackTime" & CInt(user.ID.Split("n")(2))) <> Nothing Then
        '            CountTime = Date.Now - CDate(Request.Cookies("Rack")("InputRackTime" & CInt(user.ID.Split("n")(2))))
        '        End If

        '        UserControl.CountTime(CountTime)
        '    End If
        'Next
        '   UpdatePanelControl.Update()

        '   UpdatePanelControl.Update()
    End Sub
    'Private Sub GetCache()
    '    Dim CacheData As DataTable = DirectCast(Cache.[Get](DropDownListPKG.Text.Split("(")(0)), DataTable)
    '    For Each user As Control In Panel1.Controls
    '        If TypeOf user Is UserControl = True Then
    '            Dim UserControl As ControlPosition = user
    '            For Each listData As DataRow In CacheData.Rows
    '                If user.ID Like "*" & listData("lbPosition") & "*" Then
    '                    Dim Color As Drawing.Color
    '                    If listData("Color").ToString.ToUpper = "RED" Then
    '                        Color = Drawing.Color.Red
    '                    ElseIf listData("Color").ToString.ToUpper = "LAWNGREEN" Then
    '                        Color = Drawing.Color.LawnGreen
    '                    ElseIf listData("Color").ToString.ToUpper = "YELLOW" Then
    '                        Color = Drawing.Color.Yellow
    '                    Else
    '                        Color = Drawing.Color.Transparent
    '                    End If
    '                    Dim CountTime As TimeSpan = New TimeSpan(0, 0, 0)
    '                    If listData("InputRackTime") IsNot DBNull.Value Then
    '                        CountTime = Date.Now - CDate(listData("InputRackTime"))
    '                    End If

    '                    UserControl.CountTime(CountTime)
    '                    UserControl.SetData(listData("lbLotNo"), listData("lbPKG"), listData("lbDevice"), listData("lbWireType"), listData("lbFrameType"), listData("lbMCNoRequest"), listData("lbPosition"), listData("lbStatus"), Color, listData("BackImageUrl"))
    '                End If
    '                ' UserControl.SetData()
    '                '    Debug.Print(listData("lbPKG") & " : " & listData("lbPosition") & ":" & Now.ToString("yyyy/MM/dd HH:mm:ss"))
    '            Next

    '        End If

    '    Next

    '    'GridView1.DataSource = CacheData
    '    '  GridView1.DataBind()
    '    ' GridView1.RowStyle.HorizontalAlign = HorizontalAlign.Left
    'End Sub
End Class