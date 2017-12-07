Imports System.Web.UI.HtmlControls
Imports System.Data.SqlClient
Imports System.ComponentModel
Public Class ControlPosition
    Inherits System.Web.UI.UserControl

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub

    Public Sub newControl(Use As String, LotNo As String, Color As Drawing.Color, Package As String, Device As String, Process As String, MCNo As String, OPNoRequest As String, RackNo As String, StatusLot As String, FrameType As String, WireType As String)
        If Use = "True" Then
            Panel1.BackImageUrl = ""
            If MCNo <> "-" And Color <> Drawing.Color.LawnGreen Then
                lbStatus.Text = "WB"
            ElseIf MCNo = "-" And Color = Drawing.Color.LawnGreen Then
                '   lbStatus.Text = "Rack"
                lbStatus.Text = Process
                'ElseIf Process = "PLASMAEND" Then
                '    lbStatus.Text = "Now !"
            Else
                lbStatus.Text = Process
            End If

            Panel1.BackColor = Color 'System.Drawing.Color.LawnGreen 'No Request
            'lbLotNo.ForeColor = System.Drawing.Color.Black
            'lbMCNoBack.ForeColor = System.Drawing.Color.Black
            'lbDevice.ForeColor = System.Drawing.Color.Black
            'lbPKG.ForeColor = System.Drawing.Color.Black
            'lbFrameType.ForeColor = System.Drawing.Color.Black
            'lbFrameType.ForeColor = System.Drawing.Color.Black
            'lbWireType.ForeColor = System.Drawing.Color.Black


            ' lbPosition.Text = RackNo '.Split("-")(2)
            If LotNo.Length < 10 Then
                Exit Sub
            End If

            If StatusLot <> "" Then
                lbLotNo.Text = "LotNo :" & LotNo & "(" & StatusLot & ")"
            Else
                lbLotNo.Text = "LotNo :" & LotNo
            End If

            lbDevice.Text = "Device :" & Device
            lbPKG.Text = "Package :" & Package
            lbFrameType.Text = "FrameType :" & FrameType
            lbWireType.Text = "WireType :" & WireType
            lbMCNoRequest.Text = "WB MC No." & MCNo & OPNoRequest  'Back
        Else
            Panel1.BackImageUrl = "Image/" & RackNo & ".jpg" ' "Image/14emoticon-sad-emotion.png"
            '  Panel1.BackImageUrl.la
            'Panel1.CssClass = "body"
            Panel1.BackColor = System.Drawing.Color.Transparent
            'lbLotNo.ForeColor = System.Drawing.Color.Transparent
            'lbMCNoBack.ForeColor = System.Drawing.Color.Transparent
            'lbDevice.ForeColor = System.Drawing.Color.Transparent
            'lbPKG.ForeColor = System.Drawing.Color.Transparent
            'lbFrameType.ForeColor = System.Drawing.Color.Transparent

            'lbFrameType.ForeColor = System.Drawing.Color.Transparent
            'lbWireType.ForeColor = System.Drawing.Color.Transparent
            lbStatus.Text = "NO WIP  "
            lbLotNo.Text = ""
            lbWireType.Text = ""
            lbDevice.Text = ""
            lbPKG.Text = ""
            lbFrameType.Text = ""
            lbWireType.Text = ""
            lbMCNoRequest.Text = ""
            lbTime.Text = ""
        End If
        lbPosition.Text = RackNo.Split("-")(2)
        'If LotNo.Length < 10 Then
        '    Exit Sub
        'End If

        'If StatusLot <> "" Then
        '    lbLotNo.Text = "LotNo :" & LotNo & "(" & StatusLot & ")"
        'Else
        '    lbLotNo.Text = "LotNo :" & LotNo
        'End If

        'lbDevice.Text = "Device :" & Device
        'lbPKG.Text = "Package :" & Package
        'lbFrameType.Text = "FrameType :" & FrameType
        'lbWireType.Text = "WireType :" & WireType
        'lbMCNoBack.Text = "WB MC No." & MCNo & OPNoRequest  'Back
    End Sub
    'Public Function SearchLot(LotNo As String, Color As Drawing.Color)
    '    If lbLotNo.Text.Split("(")(0) = LotNo Then
    '        Panel1.BackImageUrl = ""
    '        lbStatus.Text = Nothing
    '        Panel1.BackColor = Color 'System.Drawing.Color.LawnGreen 'No Request
    '        lbLotNo.ForeColor = System.Drawing.Color.Black
    '        lbDevice.ForeColor = System.Drawing.Color.Black
    '        lbPKG.ForeColor = System.Drawing.Color.Black
    '        lbFrameType.ForeColor = System.Drawing.Color.Black
    '        lbStatus.Text = "Book" ' "Now !"
    '        lbStatus.ForeColor = Drawing.Color.White
    '        Session("Position") = lbPosition.Text
    '        Return True
    '    Else
    '        Return False
    '    End If

    'End Function
    'Public Function SearchLotTimeout(LotNo As String)
    '    If lbLotNo.Text.Split("(")(0) = LotNo Then

    '        Return True
    '    Else
    '        Return False
    '    End If

    'End Function
    Public Function CountTime(Time As TimeSpan) As List(Of String)
        ' lbTime.Text = Time.ToString()

        Dim List As List(Of String) = New List(Of String)


        If lbLotNo.Text.Length > 10 Then
            lbTime.Text = Math.Floor(Time.TotalHours).ToString("0#") & ":" & Time.Minutes.ToString("0#") & ":" & Time.Seconds.ToString("0#")  ' Time.TotalHours ' Time.Minutes & ":" & Time.Seconds 'Time.TotalHours & ":" & Time.Minutes & ":" &
            If Panel1.BackColor = Drawing.Color.LawnGreen Then
                Return List
                Exit Function
            End If

            List.Add(lbLotNo.Text)
            List.Add(lbStatus.Text)

            If Time.TotalSeconds = 0 Then
                lbLotNo.Text = Nothing
                lbFrameType.Text = Nothing
                lbPKG.Text = Nothing
                lbDevice.Text = Nothing
                lbMCNoRequest.Text = Nothing
                lbTime.Text = Nothing
                lbWireType.Text = Nothing
                ' newControl()
                ' newControl("FALSE", "-", System.Drawing.Color.Transparent, "-", "-", "-", "-", "-", " ", " ", lbRackNo.Text, " ")
            End If
            'If Panel1.BackColor = Drawing.Color.Red Then 'เพิ่ม status เตือน
            '    Panel1.BackColor = Drawing.Color.Orange
            'Else
            '    Panel1.BackColor = Drawing.Color.Red
            'End If

        End If
        Return List
    End Function
    Public Sub GetData()
        Session("lbLotNo") = lbLotNo.Text
        Session("lbPKG") = lbPKG.Text
        Session("lbDevice") = lbDevice.Text
        Session("lbWireType") = lbWireType.Text
        Session("lbFrameType") = lbFrameType.Text
        Session("lbMCNoRequest") = lbMCNoRequest.Text
        Session("lbPosition") = lbPosition.Text
        Session("lbStatus") = lbStatus.Text
        Session("Color") = Panel1.BackColor.Name
        Session("BackImageUrl") = Panel1.BackImageUrl
    End Sub

    Public Sub SetData(LotNo As String, PKG As String, Device As String, WireType As String, FrameType As String, MCNoRequest As String, Position As String, Status As String _
                       , Color As Drawing.Color, BackImageUrl As String, Time As TimeSpan)

        If lbLotNo.Text.Length > 10 Then
            lbTime.Text = Math.Floor(Time.TotalHours).ToString("0#") & ":" & Time.Minutes.ToString("0#") & ":" & Time.Seconds.ToString("0#")  ' Time.TotalHours ' Time.Minutes & ":" & Time.Seconds 'Time.TotalHours & ":" & Time.Minutes & ":" &

            If Time.TotalSeconds = 0 Then
                lbLotNo.Text = Nothing
                lbFrameType.Text = Nothing
                lbPKG.Text = Nothing
                lbDevice.Text = Nothing
                lbMCNoRequest.Text = Nothing
                lbTime.Text = Nothing
                lbWireType.Text = Nothing
                ' newControl()
                ' newControl("FALSE", "-", System.Drawing.Color.Transparent, "-", "-", "-", "-", "-", " ", " ", lbRackNo.Text, " ")
            End If
            'If Panel1.BackColor = Drawing.Color.Red Then 'เพิ่ม status เตือน
            '    Panel1.BackColor = Drawing.Color.Orange
            'Else
            '    Panel1.BackColor = Drawing.Color.Red
            'End If
            If Time.TotalHours > 18 AndAlso Time.TotalHours < 24 Then
                If Panel1.BackColor = Color Then
                    Panel1.BackColor = Drawing.Color.White
                Else
                    Panel1.BackColor = Color
                End If
            ElseIf Time.TotalHours >= 24 Then
                Panel1.BackColor = Drawing.Color.Red
                lbStatus.ForeColor = Drawing.Color.White
            Else
                Panel1.BackColor = Color
            End If
        End If



        If LotNo = Nothing Then
            lbTime.Text = ""
        End If
        lbLotNo.Text = LotNo
        lbPKG.Text = PKG
        lbDevice.Text = Device
        lbWireType.Text = WireType
        lbFrameType.Text = FrameType
        lbMCNoRequest.Text = MCNoRequest
        lbPosition.Text = Position
        'If Status.ToUpper.Trim = "WB" Then
        '    lbStatus.ForeColor = Drawing.Color.White
        'End If
        lbStatus.Text = Status
        'If Panel1.BackColor = Color Then
        '    Panel1.BackColor = Drawing.Color.White

        'Else
        '    Panel1.BackColor = Color
        'End If

        Panel1.BackImageUrl = BackImageUrl
    End Sub
End Class