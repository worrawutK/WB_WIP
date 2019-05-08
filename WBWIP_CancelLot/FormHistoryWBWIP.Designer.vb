<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormHistoryWBWIP
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.WBWIPHistoryBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataSet1 = New WBWIP_CancelLot.DataSet1()
        Me.WBWIP_HistoryTableAdapter = New WBWIP_CancelLot.DataSet1TableAdapters.WBWIP_HistoryTableAdapter()
        Me.AscThemeContainer1 = New WBWIP_CancelLot.ascThemeContainer()
        Me.LabelVersion = New System.Windows.Forms.Label()
        Me.LabelCancelLot = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.LabelRemark = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.LabelWIP = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.AscProgressBar1 = New WBWIP_CancelLot.ascProgressBar()
        Me.AscButtonSearch = New WBWIP_CancelLot.ascButton()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.LotNoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AssyNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RackNoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PositionDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ProcessBeforeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.OPNoInputRackDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.InputRackTimeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.OPNoOutputRackDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.OutputRackTimeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MachineRequestDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.OPNoRequestDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RequestTimeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FramTypeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.WireTypeSizeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.StatusLotDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RemarkDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DateTimePicker2 = New System.Windows.Forms.DateTimePicker()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.TimerText = New System.Windows.Forms.Timer(Me.components)
        CType(Me.WBWIPHistoryBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.AscThemeContainer1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Timer1
        '
        Me.Timer1.Interval = 50
        '
        'WBWIPHistoryBindingSource
        '
        Me.WBWIPHistoryBindingSource.DataMember = "WBWIP_History"
        Me.WBWIPHistoryBindingSource.DataSource = Me.DataSet1
        '
        'DataSet1
        '
        Me.DataSet1.DataSetName = "DataSet1"
        Me.DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'WBWIP_HistoryTableAdapter
        '
        Me.WBWIP_HistoryTableAdapter.ClearBeforeFill = True
        '
        'AscThemeContainer1
        '
        Me.AscThemeContainer1.Controls.Add(Me.LabelVersion)
        Me.AscThemeContainer1.Controls.Add(Me.LabelCancelLot)
        Me.AscThemeContainer1.Controls.Add(Me.Label6)
        Me.AscThemeContainer1.Controls.Add(Me.LabelRemark)
        Me.AscThemeContainer1.Controls.Add(Me.Label4)
        Me.AscThemeContainer1.Controls.Add(Me.LabelWIP)
        Me.AscThemeContainer1.Controls.Add(Me.Label2)
        Me.AscThemeContainer1.Controls.Add(Me.Label1)
        Me.AscThemeContainer1.Controls.Add(Me.AscProgressBar1)
        Me.AscThemeContainer1.Controls.Add(Me.AscButtonSearch)
        Me.AscThemeContainer1.Controls.Add(Me.DataGridView1)
        Me.AscThemeContainer1.Controls.Add(Me.DateTimePicker2)
        Me.AscThemeContainer1.Controls.Add(Me.DateTimePicker1)
        Me.AscThemeContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.AscThemeContainer1.Location = New System.Drawing.Point(0, 0)
        Me.AscThemeContainer1.Margin = New System.Windows.Forms.Padding(2)
        Me.AscThemeContainer1.Name = "AscThemeContainer1"
        Me.AscThemeContainer1.Size = New System.Drawing.Size(668, 463)
        Me.AscThemeContainer1.TabIndex = 0
        Me.AscThemeContainer1.Text = "AscThemeContainer1"
        '
        'LabelVersion
        '
        Me.LabelVersion.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LabelVersion.AutoSize = True
        Me.LabelVersion.Location = New System.Drawing.Point(594, 7)
        Me.LabelVersion.Name = "LabelVersion"
        Me.LabelVersion.Size = New System.Drawing.Size(66, 13)
        Me.LabelVersion.TabIndex = 9
        Me.LabelVersion.Text = "Version 1.01"
        '
        'LabelCancelLot
        '
        Me.LabelCancelLot.AutoSize = True
        Me.LabelCancelLot.Location = New System.Drawing.Point(251, 441)
        Me.LabelCancelLot.Name = "LabelCancelLot"
        Me.LabelCancelLot.Size = New System.Drawing.Size(58, 13)
        Me.LabelCancelLot.TabIndex = 8
        Me.LabelCancelLot.Text = "Cancel Lot"
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.Color.Silver
        Me.Label6.Location = New System.Drawing.Point(210, 438)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(36, 17)
        Me.Label6.TabIndex = 7
        '
        'LabelRemark
        '
        Me.LabelRemark.AutoSize = True
        Me.LabelRemark.Location = New System.Drawing.Point(156, 441)
        Me.LabelRemark.Name = "LabelRemark"
        Me.LabelRemark.Size = New System.Drawing.Size(44, 13)
        Me.LabelRemark.TabIndex = 8
        Me.LabelRemark.Text = "Remark"
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.DarkOrange
        Me.Label4.Location = New System.Drawing.Point(115, 438)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(36, 17)
        Me.Label4.TabIndex = 7
        '
        'LabelWIP
        '
        Me.LabelWIP.AutoSize = True
        Me.LabelWIP.Location = New System.Drawing.Point(68, 440)
        Me.LabelWIP.Name = "LabelWIP"
        Me.LabelWIP.Size = New System.Drawing.Size(28, 13)
        Me.LabelWIP.TabIndex = 8
        Me.LabelWIP.Text = "WIP"
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.LawnGreen
        Me.Label2.Location = New System.Drawing.Point(27, 437)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(36, 17)
        Me.Label2.TabIndex = 7
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(289, 22)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(20, 13)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "To"
        '
        'AscProgressBar1
        '
        Me.AscProgressBar1.Font = New System.Drawing.Font("Arial", 11.0!)
        Me.AscProgressBar1.Location = New System.Drawing.Point(27, 77)
        Me.AscProgressBar1.Margin = New System.Windows.Forms.Padding(2)
        Me.AscProgressBar1.Maximum = 100
        Me.AscProgressBar1.Name = "AscProgressBar1"
        Me.AscProgressBar1.Size = New System.Drawing.Size(619, 26)
        Me.AscProgressBar1.TabIndex = 5
        Me.AscProgressBar1.Text = "AscProgressBar1"
        Me.AscProgressBar1.Value = 0
        '
        'AscButtonSearch
        '
        Me.AscButtonSearch.BackColor = System.Drawing.Color.FromArgb(CType(CType(5, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.AscButtonSearch.Cursor = System.Windows.Forms.Cursors.Hand
        Me.AscButtonSearch.Font = New System.Drawing.Font("Arial", 11.0!)
        Me.AscButtonSearch.ForeColor = System.Drawing.Color.FromArgb(CType(CType(195, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.AscButtonSearch.GlowColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(95, Byte), Integer), CType(CType(210, Byte), Integer))
        Me.AscButtonSearch.Location = New System.Drawing.Point(27, 47)
        Me.AscButtonSearch.Margin = New System.Windows.Forms.Padding(2)
        Me.AscButtonSearch.Name = "AscButtonSearch"
        Me.AscButtonSearch.Size = New System.Drawing.Size(105, 26)
        Me.AscButtonSearch.TabIndex = 4
        Me.AscButtonSearch.Text = "Search"
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.LotNoDataGridViewTextBoxColumn, Me.AssyNameDataGridViewTextBoxColumn, Me.RackNoDataGridViewTextBoxColumn, Me.PositionDataGridViewTextBoxColumn, Me.ProcessBeforeDataGridViewTextBoxColumn, Me.OPNoInputRackDataGridViewTextBoxColumn, Me.InputRackTimeDataGridViewTextBoxColumn, Me.OPNoOutputRackDataGridViewTextBoxColumn, Me.OutputRackTimeDataGridViewTextBoxColumn, Me.MachineRequestDataGridViewTextBoxColumn, Me.OPNoRequestDataGridViewTextBoxColumn, Me.RequestTimeDataGridViewTextBoxColumn, Me.FramTypeDataGridViewTextBoxColumn, Me.WireTypeSizeDataGridViewTextBoxColumn, Me.StatusLotDataGridViewTextBoxColumn, Me.RemarkDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.WBWIPHistoryBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(27, 107)
        Me.DataGridView1.Margin = New System.Windows.Forms.Padding(2)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.RowTemplate.Height = 28
        Me.DataGridView1.Size = New System.Drawing.Size(619, 328)
        Me.DataGridView1.TabIndex = 2
        '
        'LotNoDataGridViewTextBoxColumn
        '
        Me.LotNoDataGridViewTextBoxColumn.DataPropertyName = "LotNo"
        Me.LotNoDataGridViewTextBoxColumn.HeaderText = "LotNo"
        Me.LotNoDataGridViewTextBoxColumn.Name = "LotNoDataGridViewTextBoxColumn"
        Me.LotNoDataGridViewTextBoxColumn.ReadOnly = True
        '
        'AssyNameDataGridViewTextBoxColumn
        '
        Me.AssyNameDataGridViewTextBoxColumn.DataPropertyName = "AssyName"
        Me.AssyNameDataGridViewTextBoxColumn.HeaderText = "AssyName"
        Me.AssyNameDataGridViewTextBoxColumn.Name = "AssyNameDataGridViewTextBoxColumn"
        Me.AssyNameDataGridViewTextBoxColumn.ReadOnly = True
        '
        'RackNoDataGridViewTextBoxColumn
        '
        Me.RackNoDataGridViewTextBoxColumn.DataPropertyName = "RackNo"
        Me.RackNoDataGridViewTextBoxColumn.HeaderText = "RackNo"
        Me.RackNoDataGridViewTextBoxColumn.Name = "RackNoDataGridViewTextBoxColumn"
        Me.RackNoDataGridViewTextBoxColumn.ReadOnly = True
        '
        'PositionDataGridViewTextBoxColumn
        '
        Me.PositionDataGridViewTextBoxColumn.DataPropertyName = "Position"
        Me.PositionDataGridViewTextBoxColumn.HeaderText = "Position"
        Me.PositionDataGridViewTextBoxColumn.Name = "PositionDataGridViewTextBoxColumn"
        Me.PositionDataGridViewTextBoxColumn.ReadOnly = True
        '
        'ProcessBeforeDataGridViewTextBoxColumn
        '
        Me.ProcessBeforeDataGridViewTextBoxColumn.DataPropertyName = "ProcessBefore"
        Me.ProcessBeforeDataGridViewTextBoxColumn.HeaderText = "ProcessBefore"
        Me.ProcessBeforeDataGridViewTextBoxColumn.Name = "ProcessBeforeDataGridViewTextBoxColumn"
        Me.ProcessBeforeDataGridViewTextBoxColumn.ReadOnly = True
        '
        'OPNoInputRackDataGridViewTextBoxColumn
        '
        Me.OPNoInputRackDataGridViewTextBoxColumn.DataPropertyName = "OPNoInputRack"
        Me.OPNoInputRackDataGridViewTextBoxColumn.HeaderText = "OPNoInputRack"
        Me.OPNoInputRackDataGridViewTextBoxColumn.Name = "OPNoInputRackDataGridViewTextBoxColumn"
        Me.OPNoInputRackDataGridViewTextBoxColumn.ReadOnly = True
        '
        'InputRackTimeDataGridViewTextBoxColumn
        '
        Me.InputRackTimeDataGridViewTextBoxColumn.DataPropertyName = "InputRackTime"
        Me.InputRackTimeDataGridViewTextBoxColumn.HeaderText = "InputRackTime"
        Me.InputRackTimeDataGridViewTextBoxColumn.Name = "InputRackTimeDataGridViewTextBoxColumn"
        Me.InputRackTimeDataGridViewTextBoxColumn.ReadOnly = True
        '
        'OPNoOutputRackDataGridViewTextBoxColumn
        '
        Me.OPNoOutputRackDataGridViewTextBoxColumn.DataPropertyName = "OPNoOutputRack"
        Me.OPNoOutputRackDataGridViewTextBoxColumn.HeaderText = "OPNoOutputRack"
        Me.OPNoOutputRackDataGridViewTextBoxColumn.Name = "OPNoOutputRackDataGridViewTextBoxColumn"
        Me.OPNoOutputRackDataGridViewTextBoxColumn.ReadOnly = True
        '
        'OutputRackTimeDataGridViewTextBoxColumn
        '
        Me.OutputRackTimeDataGridViewTextBoxColumn.DataPropertyName = "OutputRackTime"
        Me.OutputRackTimeDataGridViewTextBoxColumn.HeaderText = "OutputRackTime"
        Me.OutputRackTimeDataGridViewTextBoxColumn.Name = "OutputRackTimeDataGridViewTextBoxColumn"
        Me.OutputRackTimeDataGridViewTextBoxColumn.ReadOnly = True
        '
        'MachineRequestDataGridViewTextBoxColumn
        '
        Me.MachineRequestDataGridViewTextBoxColumn.DataPropertyName = "MachineRequest"
        Me.MachineRequestDataGridViewTextBoxColumn.HeaderText = "MachineRequest"
        Me.MachineRequestDataGridViewTextBoxColumn.Name = "MachineRequestDataGridViewTextBoxColumn"
        Me.MachineRequestDataGridViewTextBoxColumn.ReadOnly = True
        '
        'OPNoRequestDataGridViewTextBoxColumn
        '
        Me.OPNoRequestDataGridViewTextBoxColumn.DataPropertyName = "OPNoRequest"
        Me.OPNoRequestDataGridViewTextBoxColumn.HeaderText = "OPNoRequest"
        Me.OPNoRequestDataGridViewTextBoxColumn.Name = "OPNoRequestDataGridViewTextBoxColumn"
        Me.OPNoRequestDataGridViewTextBoxColumn.ReadOnly = True
        '
        'RequestTimeDataGridViewTextBoxColumn
        '
        Me.RequestTimeDataGridViewTextBoxColumn.DataPropertyName = "RequestTime"
        Me.RequestTimeDataGridViewTextBoxColumn.HeaderText = "RequestTime"
        Me.RequestTimeDataGridViewTextBoxColumn.Name = "RequestTimeDataGridViewTextBoxColumn"
        Me.RequestTimeDataGridViewTextBoxColumn.ReadOnly = True
        '
        'FramTypeDataGridViewTextBoxColumn
        '
        Me.FramTypeDataGridViewTextBoxColumn.DataPropertyName = "FramType"
        Me.FramTypeDataGridViewTextBoxColumn.HeaderText = "FramType"
        Me.FramTypeDataGridViewTextBoxColumn.Name = "FramTypeDataGridViewTextBoxColumn"
        Me.FramTypeDataGridViewTextBoxColumn.ReadOnly = True
        '
        'WireTypeSizeDataGridViewTextBoxColumn
        '
        Me.WireTypeSizeDataGridViewTextBoxColumn.DataPropertyName = "WireTypeSize"
        Me.WireTypeSizeDataGridViewTextBoxColumn.HeaderText = "WireTypeSize"
        Me.WireTypeSizeDataGridViewTextBoxColumn.Name = "WireTypeSizeDataGridViewTextBoxColumn"
        Me.WireTypeSizeDataGridViewTextBoxColumn.ReadOnly = True
        '
        'StatusLotDataGridViewTextBoxColumn
        '
        Me.StatusLotDataGridViewTextBoxColumn.DataPropertyName = "StatusLot"
        Me.StatusLotDataGridViewTextBoxColumn.HeaderText = "StatusLot"
        Me.StatusLotDataGridViewTextBoxColumn.Name = "StatusLotDataGridViewTextBoxColumn"
        Me.StatusLotDataGridViewTextBoxColumn.ReadOnly = True
        '
        'RemarkDataGridViewTextBoxColumn
        '
        Me.RemarkDataGridViewTextBoxColumn.DataPropertyName = "Remark"
        Me.RemarkDataGridViewTextBoxColumn.HeaderText = "Remark"
        Me.RemarkDataGridViewTextBoxColumn.Name = "RemarkDataGridViewTextBoxColumn"
        Me.RemarkDataGridViewTextBoxColumn.ReadOnly = True
        '
        'DateTimePicker2
        '
        Me.DateTimePicker2.Location = New System.Drawing.Point(313, 20)
        Me.DateTimePicker2.Margin = New System.Windows.Forms.Padding(2)
        Me.DateTimePicker2.Name = "DateTimePicker2"
        Me.DateTimePicker2.Size = New System.Drawing.Size(251, 20)
        Me.DateTimePicker2.TabIndex = 0
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Location = New System.Drawing.Point(27, 20)
        Me.DateTimePicker1.Margin = New System.Windows.Forms.Padding(2)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(257, 20)
        Me.DateTimePicker1.TabIndex = 0
        '
        'TimerText
        '
        Me.TimerText.Enabled = True
        Me.TimerText.Interval = 300
        '
        'FormHistoryWBWIP
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(668, 463)
        Me.Controls.Add(Me.AscThemeContainer1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "FormHistoryWBWIP"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FormHistoryWBWIP"
        Me.TopMost = True
        CType(Me.WBWIPHistoryBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.AscThemeContainer1.ResumeLayout(False)
        Me.AscThemeContainer1.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents AscThemeContainer1 As ascThemeContainer
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents DateTimePicker2 As DateTimePicker
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents WBWIPHistoryBindingSource As BindingSource
    Friend WithEvents DataSet1 As DataSet1
    Friend WithEvents WBWIP_HistoryTableAdapter As DataSet1TableAdapters.WBWIP_HistoryTableAdapter
    Friend WithEvents AscButtonSearch As ascButton
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents AscProgressBar1 As ascProgressBar
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Label1 As Label
    Friend WithEvents LotNoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents AssyNameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents RackNoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PositionDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ProcessBeforeDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents OPNoInputRackDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents InputRackTimeDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents OPNoOutputRackDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents OutputRackTimeDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents MachineRequestDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents OPNoRequestDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents RequestTimeDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents FramTypeDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents WireTypeSizeDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents StatusLotDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents RemarkDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents LabelCancelLot As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents LabelRemark As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents LabelWIP As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents LabelVersion As Label
    Friend WithEvents TimerText As Timer
End Class
