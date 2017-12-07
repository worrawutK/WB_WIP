Public Class Form1
    Dim Package As DataSet1.PackageDataTable
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If tbPackage.Text = "" Then
            MsgBox("PKG is Null")
            Exit Sub
        End If
        Dim list As List(Of String) = New List(Of String)
        Package = New DataSet1.PackageDataTable
        Dim DR As DataSet1.PackageRow = Package.NewRow
        Dim PackageAdapters As New DataSet1TableAdapters.PackageTableAdapter
        Dim QUERY As String
        If CheckBox1.Checked Then
            QUERY = "%" & tbPackage.Text & "%"
        Else
            QUERY = tbPackage.Text

        End If
        PackageAdapters.Fill(Package, QUERY)
        For Each data As DataSet1.PackageRow In Package
            'list.Add(data.AssyName)
        Next
        DataGridView1.DataSource = Package

    End Sub
    Dim WBRackPackageName As DataSet1.PackageNameDataTable
    Dim WBRackPackageNameAdapter As DataSet1TableAdapters.PackageNameTableAdapter

    Dim WBRackPackage As DataSet1.WBRackPackageDataTable
    Dim WBRackPackageAdapter As DataSet1TableAdapters.WBRackPackageTableAdapter
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        WBRackPackage = New DataSet1.WBRackPackageDataTable
        WBRackPackageAdapter = New DataSet1TableAdapters.WBRackPackageTableAdapter
        If cbRackNo.Text = "" Then
            MsgBox("RackNo is Null")
            Exit Sub
            ' GoTo SHOW
        End If
        If tbPackage.Text = "" Then

            GoTo SHOW
        End If

        For Each data As DataSet1.PackageRow In Package
            If data.IsAssyNameNull = False Then
                Dim DR As DataSet1.WBRackPackageRow = WBRackPackage.NewRow
                DR.RackNo = cbRackNo.Text
                DR.PackageID = data.ID
                WBRackPackage.Rows.Add(DR)

            End If
        Next

        WBRackPackageAdapter.Update(WBRackPackage)

SHOW:
        WBRackPackageName = New DataSet1.PackageNameDataTable
        WBRackPackageNameAdapter = New DataSet1TableAdapters.PackageNameTableAdapter

        ' WBRackPackageAdapter.Fill(WBRackPackage, cbRackNo.Text)
        WBRackPackageNameAdapter.Fill(WBRackPackageName, cbRackNo.Text)
        DataGridView2.DataSource = WBRackPackageName
        DataGridView2.Columns(2).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        'DataGridView2.Columns(0).Width = 150
        'DataGridView2.Columns(1).Width = 150
        'DataGridView2.Columns(2).Width = 150
        'DataGridView2.Columns(4).Width = 150
        'DataGridView2.Columns(5).Width = 200
    End Sub


    Dim RackNo As String
    Dim PackageID As String

    Private Sub DataGridView2_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView2.CellClick
        Try
            RackNo = DataGridView2.Item(0, e.RowIndex).Value
            PackageID = DataGridView2.Item(1, e.RowIndex).Value
            Label3.Text = RackNo
            Label4.Text = DataGridView2.Item(2, e.RowIndex).Value
        Catch ex As Exception

        End Try

    End Sub
    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        WBRackPackage = New DataSet1.WBRackPackageDataTable
        WBRackPackageAdapter = New DataSet1TableAdapters.WBRackPackageTableAdapter
        WBRackPackageAdapter.Delete(RackNo, PackageID)
        MsgBox("Delete Successful")
        WBRackPackageNameAdapter.Fill(WBRackPackageName, cbRackNo.Text)
        DataGridView2.DataSource = WBRackPackageName
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim frm As Form2 = New Form2
        frm.ShowDialog()

    End Sub
End Class
