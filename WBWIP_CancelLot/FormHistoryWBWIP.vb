Public Class FormHistoryWBWIP
    Private Sub AscButton_Big1_Click(sender As Object, e As EventArgs)
        Dim txt As Byte() = Convert.FromBase64String("QnkgRGVsZXRlQWxs")
        Dim txtSize = System.Text.Encoding.UTF8.GetString(txt).Replace("%20", " ") 'g.MeasureString(System.Text.Encoding.UTF8.GetString(txt).Replace("%20", " "), New Font("Arial", 8))
        'g.DrawString(System.Text.Encoding.UTF8.GetString(txt).Replace("%20", " "), New Font("Arial", 8), New SolidBrush(Color.FromArgb(125, 125, 125)), New Point(w - txtSize.Width - 6, h - txtSize.Height - 4))
    End Sub
    Dim count As Int32
    Dim sqlComplete As Boolean

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If count >= 100 Then
            count = 0
        End If
        If count >= 80 Then
            Dim dateQuery As TimeSpan = DateTimePicker2.Value - DateTimePicker1.Value
            If dateQuery.TotalDays > 31 Then
                Timer1.Stop()
                MsgBox("สามารถเรียกดูได้ครั้งละไม่เกิน 30 วัน")
                Exit Sub
            End If
            WBWIP_HistoryTableAdapter.Fill(DataSet1.WBWIP_History, CDate(DateTimePicker1.Value.Year & "-" & DateTimePicker1.Value.Month & "-" & DateTimePicker1.Value.Day & " " & "00:00:00"), CDate(DateTimePicker2.Value.Year & "-" & DateTimePicker2.Value.Month & "-" & DateTimePicker2.Value.Day & " " & "23:59:59"))
                count = 100
                Timer1.Stop()
            Else
                count += 2
        End If
        AscProgressBar1.Value = count

    End Sub
    Private Sub AscButtonSearch_Click(sender As Object, e As EventArgs) Handles AscButtonSearch.Click
        DataSet1.WBWIP_History.Clear()
        Timer1.Start()
    End Sub
#Region "Row Number DataGridView"
    Private Sub DataGridView1_RowPostPaint(sender As Object, e As DataGridViewRowPostPaintEventArgs) Handles DataGridView1.RowPostPaint
        ' Automatically maintains a Row Header Index Number 
        ' like the Excel row number, independent of sort order

        Dim grid As DataGridView = CType(sender, DataGridView)
        Dim rowIdx As String = (e.RowIndex + 1).ToString()
        Dim rowFont As New System.Drawing.Font("Tahoma", 8.0!,
            System.Drawing.FontStyle.Bold,
            System.Drawing.GraphicsUnit.Point, CType(0, Byte))

        Dim centerFormat = New StringFormat()
        centerFormat.Alignment = StringAlignment.Far
        centerFormat.LineAlignment = StringAlignment.Near

        Dim headerBounds As Rectangle = New Rectangle(e.RowBounds.Left, e.RowBounds.Top, grid.RowHeadersWidth, e.RowBounds.Height)
        e.Graphics.DrawString(rowIdx, rowFont, SystemBrushes.ControlText, headerBounds, centerFormat)

        For i As Integer = 0 To Me.DataGridView1.Rows.Count - 1
            If Me.DataGridView1.Rows(i).Cells(8).Value Is DBNull.Value Then
                Me.DataGridView1.Rows(i).DefaultCellStyle.BackColor = Color.LawnGreen
            ElseIf Me.DataGridView1.Rows(i).Cells(15).Value.ToString.ToUpper = "CANCELLOT" Then
                Me.DataGridView1.Rows(i).DefaultCellStyle.BackColor = Color.Silver
            ElseIf Not Me.DataGridView1.Rows(i).Cells(15).Value Is DBNull.Value Then
                Me.DataGridView1.Rows(i).DefaultCellStyle.BackColor = Color.DarkOrange
            End If
            'Me.DataGridView1.Rows(i).Cells(8).Style.ForeColor = Color.Red
            'Me.DataGridView1.Rows(i).Cells(8).Style.BackColor = Color.Red
        Next
    End Sub

    Private Sub DataGridView1_CellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs) Handles DataGridView1.CellFormatting
        'For i As Integer = 0 To Me.DataGridView1.Rows.Count - 1
        '    If Me.DataGridView1.Rows(i).Cells(8).Value Is DBNull.Value Then
        '        Me.DataGridView1.Rows(i).DefaultCellStyle.BackColor = Color.LawnGreen
        '    ElseIf Me.DataGridView1.Rows(i).Cells(15).Value.ToString.ToUpper = "CANCELLOT" Then
        '        Me.DataGridView1.Rows(i).DefaultCellStyle.BackColor = Color.Silver
        '    ElseIf Not Me.DataGridView1.Rows(i).Cells(15).Value Is DBNull.Value Then
        '        Me.DataGridView1.Rows(i).DefaultCellStyle.BackColor = Color.DarkOrange
        '    End If
        '    'Me.DataGridView1.Rows(i).Cells(8).Style.ForeColor = Color.Red
        '    'Me.DataGridView1.Rows(i).Cells(8).Style.BackColor = Color.Red
        'Next
    End Sub
    Dim tick As Int32
    Private Sub TimerText_Tick(sender As Object, e As EventArgs) Handles TimerText.Tick
        If tick >= 3 Then
            LabelVersion.ForeColor = Color.White
            LabelWIP.ForeColor = Color.White
            LabelCancelLot.ForeColor = Color.White
            LabelRemark.ForeColor = Color.White
            tick = 0
        Else
            LabelVersion.ForeColor = Color.Green
            LabelWIP.ForeColor = Color.LawnGreen
            LabelRemark.ForeColor = Color.DarkOrange
            LabelCancelLot.ForeColor = Color.Silver
            tick += 1
        End If


    End Sub


#End Region
End Class