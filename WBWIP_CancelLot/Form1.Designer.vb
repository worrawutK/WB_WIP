<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.WbwipTableAdapter1 = New WBWIP_CancelLot.DataSet1TableAdapters.WBWIPTableAdapter()
        Me.WbRackWIPTableAdapter1 = New WBWIP_CancelLot.DataSet1TableAdapters.WBRackWIPTableAdapter()
        Me.DataSet11 = New WBWIP_CancelLot.DataSet1()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.AscThemeContainer1 = New WBWIP_CancelLot.ascThemeContainer()
        Me.StatusStripInfo = New System.Windows.Forms.StatusStrip()
        Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabelInfo = New System.Windows.Forms.ToolStripStatusLabel()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.ViewRackToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.R01ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.R02ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.R03ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.R04ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.R05ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.R06ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.R07ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.R08ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.R09ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.R10ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.R11ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.R12ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.R13ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.R14ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.R15ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.R16ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.R17ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.R18ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.R19ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.R20ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.R21ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.R22ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.WIBHistoryToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btCancelLot = New System.Windows.Forms.Button()
        Me.tbOPNo = New System.Windows.Forms.TextBox()
        Me.tbRemark = New System.Windows.Forms.TextBox()
        Me.tbLotNo = New System.Windows.Forms.TextBox()
        CType(Me.DataSet11, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.AscThemeContainer1.SuspendLayout()
        Me.StatusStripInfo.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'WbwipTableAdapter1
        '
        Me.WbwipTableAdapter1.ClearBeforeFill = True
        '
        'WbRackWIPTableAdapter1
        '
        Me.WbRackWIPTableAdapter1.ClearBeforeFill = True
        '
        'DataSet11
        '
        Me.DataSet11.DataSetName = "DataSet1"
        Me.DataSet11.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Timer1
        '
        '
        'AscThemeContainer1
        '
        Me.AscThemeContainer1.Controls.Add(Me.StatusStripInfo)
        Me.AscThemeContainer1.Controls.Add(Me.MenuStrip1)
        Me.AscThemeContainer1.Controls.Add(Me.Label4)
        Me.AscThemeContainer1.Controls.Add(Me.Label3)
        Me.AscThemeContainer1.Controls.Add(Me.Label2)
        Me.AscThemeContainer1.Controls.Add(Me.Label1)
        Me.AscThemeContainer1.Controls.Add(Me.btCancelLot)
        Me.AscThemeContainer1.Controls.Add(Me.tbOPNo)
        Me.AscThemeContainer1.Controls.Add(Me.tbRemark)
        Me.AscThemeContainer1.Controls.Add(Me.tbLotNo)
        Me.AscThemeContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.AscThemeContainer1.Location = New System.Drawing.Point(0, 0)
        Me.AscThemeContainer1.Name = "AscThemeContainer1"
        Me.AscThemeContainer1.Size = New System.Drawing.Size(403, 310)
        Me.AscThemeContainer1.TabIndex = 0
        Me.AscThemeContainer1.Text = "AscThemeContainer1"
        '
        'StatusStripInfo
        '
        Me.StatusStripInfo.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.StatusStripInfo.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel1, Me.ToolStripStatusLabelInfo})
        Me.StatusStripInfo.Location = New System.Drawing.Point(0, 260)
        Me.StatusStripInfo.Name = "StatusStripInfo"
        Me.StatusStripInfo.Size = New System.Drawing.Size(403, 50)
        Me.StatusStripInfo.TabIndex = 13
        Me.StatusStripInfo.Text = "StatusStrip1"
        '
        'ToolStripStatusLabel1
        '
        Me.ToolStripStatusLabel1.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripStatusLabel1.ForeColor = System.Drawing.Color.SteelBlue
        Me.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
        Me.ToolStripStatusLabel1.Size = New System.Drawing.Size(61, 45)
        Me.ToolStripStatusLabel1.Text = "Info :"
        '
        'ToolStripStatusLabelInfo
        '
        Me.ToolStripStatusLabelInfo.AutoSize = False
        Me.ToolStripStatusLabelInfo.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripStatusLabelInfo.Name = "ToolStripStatusLabelInfo"
        Me.ToolStripStatusLabelInfo.Size = New System.Drawing.Size(250, 45)
        Me.ToolStripStatusLabelInfo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.Color.DarkSeaGreen
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ViewRackToolStripMenuItem, Me.WIBHistoryToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(403, 24)
        Me.MenuStrip1.TabIndex = 15
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ViewRackToolStripMenuItem
        '
        Me.ViewRackToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.R01ToolStripMenuItem, Me.R02ToolStripMenuItem, Me.R03ToolStripMenuItem, Me.R04ToolStripMenuItem, Me.R05ToolStripMenuItem, Me.R06ToolStripMenuItem, Me.R07ToolStripMenuItem, Me.R08ToolStripMenuItem, Me.R09ToolStripMenuItem, Me.R10ToolStripMenuItem, Me.R11ToolStripMenuItem, Me.R12ToolStripMenuItem, Me.R13ToolStripMenuItem, Me.R14ToolStripMenuItem, Me.R15ToolStripMenuItem, Me.R16ToolStripMenuItem, Me.R17ToolStripMenuItem, Me.R18ToolStripMenuItem, Me.R19ToolStripMenuItem, Me.R20ToolStripMenuItem, Me.R21ToolStripMenuItem, Me.R22ToolStripMenuItem})
        Me.ViewRackToolStripMenuItem.Name = "ViewRackToolStripMenuItem"
        Me.ViewRackToolStripMenuItem.Size = New System.Drawing.Size(72, 20)
        Me.ViewRackToolStripMenuItem.Text = "View Rack"
        '
        'R01ToolStripMenuItem
        '
        Me.R01ToolStripMenuItem.Name = "R01ToolStripMenuItem"
        Me.R01ToolStripMenuItem.Size = New System.Drawing.Size(93, 22)
        Me.R01ToolStripMenuItem.Text = "R01"
        '
        'R02ToolStripMenuItem
        '
        Me.R02ToolStripMenuItem.Name = "R02ToolStripMenuItem"
        Me.R02ToolStripMenuItem.Size = New System.Drawing.Size(93, 22)
        Me.R02ToolStripMenuItem.Text = "R02"
        '
        'R03ToolStripMenuItem
        '
        Me.R03ToolStripMenuItem.Name = "R03ToolStripMenuItem"
        Me.R03ToolStripMenuItem.Size = New System.Drawing.Size(93, 22)
        Me.R03ToolStripMenuItem.Text = "R03"
        '
        'R04ToolStripMenuItem
        '
        Me.R04ToolStripMenuItem.Name = "R04ToolStripMenuItem"
        Me.R04ToolStripMenuItem.Size = New System.Drawing.Size(93, 22)
        Me.R04ToolStripMenuItem.Text = "R04"
        '
        'R05ToolStripMenuItem
        '
        Me.R05ToolStripMenuItem.Name = "R05ToolStripMenuItem"
        Me.R05ToolStripMenuItem.Size = New System.Drawing.Size(93, 22)
        Me.R05ToolStripMenuItem.Text = "R05"
        '
        'R06ToolStripMenuItem
        '
        Me.R06ToolStripMenuItem.Name = "R06ToolStripMenuItem"
        Me.R06ToolStripMenuItem.Size = New System.Drawing.Size(93, 22)
        Me.R06ToolStripMenuItem.Text = "R06"
        '
        'R07ToolStripMenuItem
        '
        Me.R07ToolStripMenuItem.Name = "R07ToolStripMenuItem"
        Me.R07ToolStripMenuItem.Size = New System.Drawing.Size(93, 22)
        Me.R07ToolStripMenuItem.Text = "R07"
        '
        'R08ToolStripMenuItem
        '
        Me.R08ToolStripMenuItem.Name = "R08ToolStripMenuItem"
        Me.R08ToolStripMenuItem.Size = New System.Drawing.Size(93, 22)
        Me.R08ToolStripMenuItem.Text = "R08"
        '
        'R09ToolStripMenuItem
        '
        Me.R09ToolStripMenuItem.Name = "R09ToolStripMenuItem"
        Me.R09ToolStripMenuItem.Size = New System.Drawing.Size(93, 22)
        Me.R09ToolStripMenuItem.Text = "R09"
        '
        'R10ToolStripMenuItem
        '
        Me.R10ToolStripMenuItem.Name = "R10ToolStripMenuItem"
        Me.R10ToolStripMenuItem.Size = New System.Drawing.Size(93, 22)
        Me.R10ToolStripMenuItem.Text = "R10"
        '
        'R11ToolStripMenuItem
        '
        Me.R11ToolStripMenuItem.Name = "R11ToolStripMenuItem"
        Me.R11ToolStripMenuItem.Size = New System.Drawing.Size(93, 22)
        Me.R11ToolStripMenuItem.Text = "R11"
        '
        'R12ToolStripMenuItem
        '
        Me.R12ToolStripMenuItem.Name = "R12ToolStripMenuItem"
        Me.R12ToolStripMenuItem.Size = New System.Drawing.Size(93, 22)
        Me.R12ToolStripMenuItem.Text = "R12"
        '
        'R13ToolStripMenuItem
        '
        Me.R13ToolStripMenuItem.Name = "R13ToolStripMenuItem"
        Me.R13ToolStripMenuItem.Size = New System.Drawing.Size(93, 22)
        Me.R13ToolStripMenuItem.Text = "R13"
        '
        'R14ToolStripMenuItem
        '
        Me.R14ToolStripMenuItem.Name = "R14ToolStripMenuItem"
        Me.R14ToolStripMenuItem.Size = New System.Drawing.Size(93, 22)
        Me.R14ToolStripMenuItem.Text = "R14"
        '
        'R15ToolStripMenuItem
        '
        Me.R15ToolStripMenuItem.Name = "R15ToolStripMenuItem"
        Me.R15ToolStripMenuItem.Size = New System.Drawing.Size(93, 22)
        Me.R15ToolStripMenuItem.Text = "R15"
        '
        'R16ToolStripMenuItem
        '
        Me.R16ToolStripMenuItem.Name = "R16ToolStripMenuItem"
        Me.R16ToolStripMenuItem.Size = New System.Drawing.Size(93, 22)
        Me.R16ToolStripMenuItem.Text = "R16"
        '
        'R17ToolStripMenuItem
        '
        Me.R17ToolStripMenuItem.Name = "R17ToolStripMenuItem"
        Me.R17ToolStripMenuItem.Size = New System.Drawing.Size(93, 22)
        Me.R17ToolStripMenuItem.Text = "R17"
        '
        'R18ToolStripMenuItem
        '
        Me.R18ToolStripMenuItem.Name = "R18ToolStripMenuItem"
        Me.R18ToolStripMenuItem.Size = New System.Drawing.Size(93, 22)
        Me.R18ToolStripMenuItem.Text = "R18"
        '
        'R19ToolStripMenuItem
        '
        Me.R19ToolStripMenuItem.Name = "R19ToolStripMenuItem"
        Me.R19ToolStripMenuItem.Size = New System.Drawing.Size(93, 22)
        Me.R19ToolStripMenuItem.Text = "R19"
        '
        'R20ToolStripMenuItem
        '
        Me.R20ToolStripMenuItem.Name = "R20ToolStripMenuItem"
        Me.R20ToolStripMenuItem.Size = New System.Drawing.Size(93, 22)
        Me.R20ToolStripMenuItem.Text = "R20"
        '
        'R21ToolStripMenuItem
        '
        Me.R21ToolStripMenuItem.Name = "R21ToolStripMenuItem"
        Me.R21ToolStripMenuItem.Size = New System.Drawing.Size(93, 22)
        Me.R21ToolStripMenuItem.Text = "R21"
        '
        'R22ToolStripMenuItem
        '
        Me.R22ToolStripMenuItem.Name = "R22ToolStripMenuItem"
        Me.R22ToolStripMenuItem.Size = New System.Drawing.Size(93, 22)
        Me.R22ToolStripMenuItem.Text = "R22"
        '
        'WIBHistoryToolStripMenuItem
        '
        Me.WIBHistoryToolStripMenuItem.Name = "WIBHistoryToolStripMenuItem"
        Me.WIBHistoryToolStripMenuItem.Size = New System.Drawing.Size(81, 20)
        Me.WIBHistoryToolStripMenuItem.Text = "WIP History"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label4.Location = New System.Drawing.Point(26, 41)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(258, 29)
        Me.Label4.TabIndex = 11
        Me.Label4.Text = "Cancel Wip Rack WB"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label3.Location = New System.Drawing.Point(34, 180)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(116, 25)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Remark >>"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label2.Location = New System.Drawing.Point(34, 138)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(111, 25)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "OP No. >>"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label1.Location = New System.Drawing.Point(34, 94)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(111, 25)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "Lot No. >>"
        '
        'btCancelLot
        '
        Me.btCancelLot.Location = New System.Drawing.Point(154, 221)
        Me.btCancelLot.Name = "btCancelLot"
        Me.btCancelLot.Size = New System.Drawing.Size(114, 34)
        Me.btCancelLot.TabIndex = 7
        Me.btCancelLot.Text = "Cancel Lot"
        Me.btCancelLot.UseVisualStyleBackColor = True
        '
        'tbOPNo
        '
        Me.tbOPNo.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.tbOPNo.Location = New System.Drawing.Point(154, 135)
        Me.tbOPNo.Name = "tbOPNo"
        Me.tbOPNo.Size = New System.Drawing.Size(223, 31)
        Me.tbOPNo.TabIndex = 4
        '
        'tbRemark
        '
        Me.tbRemark.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.tbRemark.Location = New System.Drawing.Point(154, 177)
        Me.tbRemark.Name = "tbRemark"
        Me.tbRemark.Size = New System.Drawing.Size(223, 31)
        Me.tbRemark.TabIndex = 5
        Me.tbRemark.Text = "CANCELLOT"
        '
        'tbLotNo
        '
        Me.tbLotNo.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.tbLotNo.Location = New System.Drawing.Point(154, 92)
        Me.tbLotNo.Name = "tbLotNo"
        Me.tbLotNo.Size = New System.Drawing.Size(223, 31)
        Me.tbLotNo.TabIndex = 6
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(403, 310)
        Me.Controls.Add(Me.AscThemeContainer1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "WB RACK Cancel Lot"
        CType(Me.DataSet11, System.ComponentModel.ISupportInitialize).EndInit()
        Me.AscThemeContainer1.ResumeLayout(False)
        Me.AscThemeContainer1.PerformLayout()
        Me.StatusStripInfo.ResumeLayout(False)
        Me.StatusStripInfo.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents WbwipTableAdapter1 As DataSet1TableAdapters.WBWIPTableAdapter
    Friend WithEvents WbRackWIPTableAdapter1 As DataSet1TableAdapters.WBRackWIPTableAdapter
    Friend WithEvents DataSet11 As DataSet1
    Friend WithEvents Timer1 As Timer
    Friend WithEvents AscThemeContainer1 As ascThemeContainer
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents btCancelLot As Button
    Friend WithEvents tbOPNo As TextBox
    Friend WithEvents tbRemark As TextBox
    Friend WithEvents tbLotNo As TextBox
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents ViewRackToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents R01ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents R02ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents R03ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents R04ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents R05ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents R06ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents R07ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents R08ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents R09ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents R10ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents R11ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents R12ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents R13ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents R14ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents R15ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents R16ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents R17ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents R18ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents R19ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents R20ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents R21ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents R22ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents StatusStripInfo As StatusStrip
    Friend WithEvents ToolStripStatusLabel1 As ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabelInfo As ToolStripStatusLabel
    Friend WithEvents WIBHistoryToolStripMenuItem As ToolStripMenuItem
End Class
