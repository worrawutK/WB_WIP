Public Class Form2
    Dim WBRack As DataSet1.WBRackWIPDataTable
    Dim WBRackAdapter As DataSet1TableAdapters.WBRackWIPTableAdapter

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If ComboBox1.Text.ToUpper.Length <> 6 Then
            MsgBox("ข้อมูลไม่ถูกต้อง Ex. WB-R01")
            Exit Sub
        End If
        WBRack = New DataSet1.WBRackWIPDataTable
        WBRackAdapter = New DataSet1TableAdapters.WBRackWIPTableAdapter
        Dim RackNo As Integer = CInt(ComboBox1.Text.ToUpper.Split("R")(1))
        Dim ID As Integer = (RackNo * 20) - 19
        Try
            For i = 1 To 9
                Dim row As DataSet1.WBRackWIPRow = WBRack.NewRow
                row.ID = ID
                row.RackNo = ComboBox1.Text.ToUpper
                row.Position = i
                row.UseLot = False
                WBRack.Rows.Add(row)
                ID += 1
            Next
            WBRackAdapter.Update(WBRack)
        Catch ex As Exception
            MsgBox(ex.Message.ToString)
        End Try



        WBRackAdapter.Fill(WBRack, ComboBox1.Text.ToUpper)
        DataGridView1.DataSource = WBRack
    End Sub
End Class