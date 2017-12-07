Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btCancelLot.Click
        CancelLot()
    End Sub
    Private Sub CancelLot()
        ToolStripStatusLabelInfo.ForeColor = Color.Red
        If tbLotNo.Text.Trim = "" Or tbOPNo.Text.Trim = "" Then
            '  MsgBox("กรุณาใส่ข้อมูลให้ครบ")
            ToolStripStatusLabelInfo.Text = "กรุณาใส่ข้อมูลให้ครบ"
            Exit Sub
        End If

        Dim result As Integer = MessageBox.Show("ต้องการ Cancel Lot " & tbLotNo.Text & " หรือไม่ ?", "Cancel Lot", MessageBoxButtons.YesNo)

        If result = DialogResult.No Then

        ElseIf result = DialogResult.Yes Then

            If tbLotNo.Text.Trim.Length <> 10 Then
                ' MsgBox("กรุณาใส่ Lot No. ให้ถูกต้อง")
                ToolStripStatusLabelInfo.Text = "กรุณาใส่ Lot No. ให้ถูกต้อง"
                Exit Sub
            End If
            If tbOPNo.Text.Trim.Length <> 6 Then
                ToolStripStatusLabelInfo.Text = "กรุณาใส่ OP No. ให้ถูกต้อง"
                Exit Sub
            End If
            If tbRemark.Text = "" Then
                ToolStripStatusLabelInfo.Text = "กรุณาใส่ข้อมูลให้ครบ"
                Exit Sub
            End If

            WbwipTableAdapter1.Fill(DataSet11.WBWIP, tbLotNo.Text)
            For Each data As DataSet1.WBWIPRow In DataSet11.WBWIP
                data.OutputRackTime = CDate(Format(Now, "yyyy-MM-dd HH:mm:ss"))
                data.OPNoOutputRack = tbOPNo.Text
                data.Remark = tbRemark.Text.Trim.ToUpper

                WbRackWIPTableAdapter1.Fill(DataSet11.WBRackWIP, data.RackID)
                For Each rackId As DataSet1.WBRackWIPRow In DataSet11.WBRackWIP
                    rackId.UseLot = False
                Next
            Next

            If DataSet11.WBRackWIP.Rows.Count > 0 Then
                WbRackWIPTableAdapter1.Update(DataSet11.WBRackWIP)
                WbwipTableAdapter1.Update(DataSet11.WBWIP)
                ' MsgBox("Cancel Lot " & tbLotNo.Text & " สำเร็จ")
                ToolStripStatusLabelInfo.Text = "Cancel Lot " & tbLotNo.Text & " สำเร็จ"
                ToolStripStatusLabelInfo.ForeColor = Color.Green
            Else
                '  MsgBox("ไม่สามารถ Cancel Lot " & tbLotNo.Text & " ได้")
                ToolStripStatusLabelInfo.Text = "ไม่สามารถ Cancel Lot " & tbLotNo.Text & " ได้"
            End If

            ClearText()
            tbLotNo.Focus()
        End If
    End Sub
    Private Sub ClearText()
        DataSet11.WBRackWIP.Clear()
        tbLotNo.Text = Nothing
        tbOPNo.Text = Nothing
        tbRemark.Text = "CANCELLOT"
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'ToolStripComboBox1.SelectedIndex = 0
        Timer1.Start()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        tbLotNo.Focus()
        Timer1.Stop()
    End Sub
    Dim url As String = "http://webserv.thematrix.net/WBWIP/WBWIP.aspx?Process=WBRackMaster&RackNo=WB-"
    Private Sub ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles R22ToolStripMenuItem.Click, R21ToolStripMenuItem.Click, R20ToolStripMenuItem.Click, R19ToolStripMenuItem.Click, R18ToolStripMenuItem.Click, R17ToolStripMenuItem.Click, R16ToolStripMenuItem.Click, R15ToolStripMenuItem.Click, R14ToolStripMenuItem.Click, R13ToolStripMenuItem.Click, R12ToolStripMenuItem.Click, R11ToolStripMenuItem.Click, R10ToolStripMenuItem.Click, R09ToolStripMenuItem.Click, R08ToolStripMenuItem.Click, R07ToolStripMenuItem.Click, R06ToolStripMenuItem.Click, R05ToolStripMenuItem.Click, R04ToolStripMenuItem.Click, R03ToolStripMenuItem.Click, R02ToolStripMenuItem.Click, R01ToolStripMenuItem.Click
        Dim val As ToolStripMenuItem = CType(sender, ToolStripMenuItem)
        Process.Start("iexplore.exe", url & val.Text)

    End Sub

    Private Sub WIBHistoryToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles WIBHistoryToolStripMenuItem.Click
        Dim frm As FormHistoryWBWIP = New FormHistoryWBWIP
        frm.ShowDialog()
    End Sub
End Class
