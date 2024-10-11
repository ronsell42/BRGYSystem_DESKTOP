<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmModifyBlotter
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim ReportDateLabel As System.Windows.Forms.Label
        Dim ReportIssueLabel As System.Windows.Forms.Label
        Dim IncidentDateLabel As System.Windows.Forms.Label
        Dim LocationLabel As System.Windows.Forms.Label
        Dim WhoLabel As System.Windows.Forms.Label
        Dim ReportAttachedLabel As System.Windows.Forms.Label
        Dim ReportTextLabel As System.Windows.Forms.Label
        Dim ComplainantLabel As System.Windows.Forms.Label
        Dim OnDutyLabel As System.Windows.Forms.Label
        Dim IDLabel As System.Windows.Forms.Label
        Dim Label1 As System.Windows.Forms.Label
        Dim Label3 As System.Windows.Forms.Label
        Dim Label4 As System.Windows.Forms.Label
        Dim ReportAttachedLabel1 As System.Windows.Forms.Label
        Dim FirstNameLabel As System.Windows.Forms.Label
        Dim MInitialLabel As System.Windows.Forms.Label
        Dim LastNameLabel As System.Windows.Forms.Label
        Dim Label2 As System.Windows.Forms.Label
        Dim Label5 As System.Windows.Forms.Label
        Dim Label7 As System.Windows.Forms.Label
        Me.tmrOpen = New System.Windows.Forms.Timer(Me.components)
        Me.Guna2BorderlessForm1 = New Guna.UI2.WinForms.Guna2BorderlessForm(Me.components)
        Me.Button1 = New System.Windows.Forms.Button()
        Me.IDTextBox = New System.Windows.Forms.TextBox()
        Me.TblBlotterBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DbBrgySystemDataSet = New BarangaySystem.dbBrgySystemDataSet()
        Me.ReportDateDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.ReportIssueTextBox = New System.Windows.Forms.TextBox()
        Me.IncidentDateDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.LocationTextBox = New System.Windows.Forms.TextBox()
        Me.WhoTextBox = New System.Windows.Forms.TextBox()
        Me.ReportAttachedPictureBox = New System.Windows.Forms.PictureBox()
        Me.ReportTextTextBox = New System.Windows.Forms.TextBox()
        Me.ComplainantTextBox = New System.Windows.Forms.TextBox()
        Me.OnDutyTextBox = New System.Windows.Forms.TextBox()
        Me.Guna2Button4 = New Guna.UI2.WinForms.Guna2Button()
        Me.Guna2Button2 = New Guna.UI2.WinForms.Guna2Button()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.rptPhoto = New System.Windows.Forms.PictureBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.RptIssue = New Bunifu.Framework.UI.BunifuMetroTextbox()
        Me.BunifuMetroTextbox1 = New Bunifu.Framework.UI.BunifuMetroTextbox()
        Me.complainant = New Bunifu.Framework.UI.BunifuMetroTextbox()
        Me.rptLoc = New Bunifu.Framework.UI.BunifuMetroTextbox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.ReportAttached1PictureBox = New System.Windows.Forms.PictureBox()
        Me.ReportAttached2PictureBox = New System.Windows.Forms.PictureBox()
        Me.OpenFileDialog2 = New System.Windows.Forms.OpenFileDialog()
        Me.OpenFileDialog3 = New System.Windows.Forms.OpenFileDialog()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.ReportAttachedTextBox = New System.Windows.Forms.TextBox()
        Me.Rpt = New System.Windows.Forms.TextBox()
        Me.TblBlotterTableAdapter = New BarangaySystem.dbBrgySystemDataSetTableAdapters.tblBlotterTableAdapter()
        Me.lblOrigAttachement = New System.Windows.Forms.Label()
        Me.TableAdapterManager = New BarangaySystem.dbBrgySystemDataSetTableAdapters.TableAdapterManager()
        Me.BunifuMetroTextbox2 = New Bunifu.Framework.UI.BunifuMetroTextbox()
        Me.BunifuDatepicker1 = New Bunifu.Framework.UI.BunifuDatepicker()
        ReportDateLabel = New System.Windows.Forms.Label()
        ReportIssueLabel = New System.Windows.Forms.Label()
        IncidentDateLabel = New System.Windows.Forms.Label()
        LocationLabel = New System.Windows.Forms.Label()
        WhoLabel = New System.Windows.Forms.Label()
        ReportAttachedLabel = New System.Windows.Forms.Label()
        ReportTextLabel = New System.Windows.Forms.Label()
        ComplainantLabel = New System.Windows.Forms.Label()
        OnDutyLabel = New System.Windows.Forms.Label()
        IDLabel = New System.Windows.Forms.Label()
        Label1 = New System.Windows.Forms.Label()
        Label3 = New System.Windows.Forms.Label()
        Label4 = New System.Windows.Forms.Label()
        ReportAttachedLabel1 = New System.Windows.Forms.Label()
        FirstNameLabel = New System.Windows.Forms.Label()
        MInitialLabel = New System.Windows.Forms.Label()
        LastNameLabel = New System.Windows.Forms.Label()
        Label2 = New System.Windows.Forms.Label()
        Label5 = New System.Windows.Forms.Label()
        Label7 = New System.Windows.Forms.Label()
        CType(Me.TblBlotterBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DbBrgySystemDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ReportAttachedPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.Panel3.SuspendLayout()
        CType(Me.rptPhoto, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        CType(Me.ReportAttached1PictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ReportAttached2PictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ReportDateLabel
        '
        ReportDateLabel.AutoSize = True
        ReportDateLabel.Enabled = False
        ReportDateLabel.Location = New System.Drawing.Point(246, 83)
        ReportDateLabel.Name = "ReportDateLabel"
        ReportDateLabel.Size = New System.Drawing.Size(63, 13)
        ReportDateLabel.TabIndex = 4
        ReportDateLabel.Text = "report Date:"
        '
        'ReportIssueLabel
        '
        ReportIssueLabel.AutoSize = True
        ReportIssueLabel.Enabled = False
        ReportIssueLabel.Location = New System.Drawing.Point(158, 82)
        ReportIssueLabel.Name = "ReportIssueLabel"
        ReportIssueLabel.Size = New System.Drawing.Size(65, 13)
        ReportIssueLabel.TabIndex = 6
        ReportIssueLabel.Text = "report Issue:"
        '
        'IncidentDateLabel
        '
        IncidentDateLabel.AutoSize = True
        IncidentDateLabel.Enabled = False
        IncidentDateLabel.Location = New System.Drawing.Point(124, 136)
        IncidentDateLabel.Name = "IncidentDateLabel"
        IncidentDateLabel.Size = New System.Drawing.Size(73, 13)
        IncidentDateLabel.TabIndex = 8
        IncidentDateLabel.Text = "incident Date:"
        '
        'LocationLabel
        '
        LocationLabel.AutoSize = True
        LocationLabel.Enabled = False
        LocationLabel.Location = New System.Drawing.Point(158, 193)
        LocationLabel.Name = "LocationLabel"
        LocationLabel.Size = New System.Drawing.Size(47, 13)
        LocationLabel.TabIndex = 10
        LocationLabel.Text = "location:"
        '
        'WhoLabel
        '
        WhoLabel.AutoSize = True
        WhoLabel.Location = New System.Drawing.Point(117, 149)
        WhoLabel.Name = "WhoLabel"
        WhoLabel.Size = New System.Drawing.Size(30, 13)
        WhoLabel.TabIndex = 12
        WhoLabel.Text = "who:"
        '
        'ReportAttachedLabel
        '
        ReportAttachedLabel.AutoSize = True
        ReportAttachedLabel.Enabled = False
        ReportAttachedLabel.Location = New System.Drawing.Point(528, 243)
        ReportAttachedLabel.Name = "ReportAttachedLabel"
        ReportAttachedLabel.Size = New System.Drawing.Size(83, 13)
        ReportAttachedLabel.TabIndex = 14
        ReportAttachedLabel.Text = "report Attached:"
        '
        'ReportTextLabel
        '
        ReportTextLabel.AutoSize = True
        ReportTextLabel.Enabled = False
        ReportTextLabel.Location = New System.Drawing.Point(528, 330)
        ReportTextLabel.Name = "ReportTextLabel"
        ReportTextLabel.Size = New System.Drawing.Size(61, 13)
        ReportTextLabel.TabIndex = 16
        ReportTextLabel.Text = "report Text:"
        '
        'ComplainantLabel
        '
        ComplainantLabel.AutoSize = True
        ComplainantLabel.Enabled = False
        ComplainantLabel.Location = New System.Drawing.Point(169, 234)
        ComplainantLabel.Name = "ComplainantLabel"
        ComplainantLabel.Size = New System.Drawing.Size(67, 13)
        ComplainantLabel.TabIndex = 18
        ComplainantLabel.Text = "complainant:"
        '
        'OnDutyLabel
        '
        OnDutyLabel.AutoSize = True
        OnDutyLabel.Enabled = False
        OnDutyLabel.Location = New System.Drawing.Point(509, 299)
        OnDutyLabel.Name = "OnDutyLabel"
        OnDutyLabel.Size = New System.Drawing.Size(47, 13)
        OnDutyLabel.TabIndex = 20
        OnDutyLabel.Text = "on Duty:"
        '
        'IDLabel
        '
        IDLabel.AutoSize = True
        IDLabel.Enabled = False
        IDLabel.Location = New System.Drawing.Point(776, 89)
        IDLabel.Name = "IDLabel"
        IDLabel.Size = New System.Drawing.Size(21, 13)
        IDLabel.TabIndex = 2
        IDLabel.Text = "ID:"
        '
        'Label1
        '
        Label1.AutoSize = True
        Label1.Font = New System.Drawing.Font("Trebuchet MS", 9.75!)
        Label1.Location = New System.Drawing.Point(17, 31)
        Label1.Name = "Label1"
        Label1.Size = New System.Drawing.Size(82, 18)
        Label1.TabIndex = 10282
        Label1.Text = "Report Date:"
        '
        'Label3
        '
        Label3.AutoSize = True
        Label3.Font = New System.Drawing.Font("Trebuchet MS", 9.75!)
        Label3.Location = New System.Drawing.Point(18, 185)
        Label3.Name = "Label3"
        Label3.Size = New System.Drawing.Size(86, 18)
        Label3.TabIndex = 10281
        Label3.Text = "Complainant:"
        AddHandler Label3.Click, AddressOf Me.Label3_Click
        '
        'Label4
        '
        Label4.AutoSize = True
        Label4.Font = New System.Drawing.Font("Trebuchet MS", 9.75!)
        Label4.Location = New System.Drawing.Point(627, 146)
        Label4.Name = "Label4"
        Label4.Size = New System.Drawing.Size(51, 18)
        Label4.TabIndex = 10281
        Label4.Text = "Report:"
        AddHandler Label4.Click, AddressOf Me.Label3_Click
        '
        'ReportAttachedLabel1
        '
        ReportAttachedLabel1.AutoSize = True
        ReportAttachedLabel1.Location = New System.Drawing.Point(629, 78)
        ReportAttachedLabel1.Name = "ReportAttachedLabel1"
        ReportAttachedLabel1.Size = New System.Drawing.Size(83, 13)
        ReportAttachedLabel1.TabIndex = 10292
        ReportAttachedLabel1.Text = "report Attached:"
        '
        'FirstNameLabel
        '
        FirstNameLabel.AutoSize = True
        FirstNameLabel.Font = New System.Drawing.Font("Trebuchet MS", 9.75!)
        FirstNameLabel.Location = New System.Drawing.Point(8, 28)
        FirstNameLabel.Name = "FirstNameLabel"
        FirstNameLabel.Size = New System.Drawing.Size(85, 18)
        FirstNameLabel.TabIndex = 10279
        FirstNameLabel.Text = "Report Issue:"
        '
        'MInitialLabel
        '
        MInitialLabel.AutoSize = True
        MInitialLabel.Font = New System.Drawing.Font("Trebuchet MS", 9.75!)
        MInitialLabel.Location = New System.Drawing.Point(10, 79)
        MInitialLabel.Name = "MInitialLabel"
        MInitialLabel.Size = New System.Drawing.Size(91, 18)
        MInitialLabel.TabIndex = 10280
        MInitialLabel.Text = "Incident Date:"
        '
        'LastNameLabel
        '
        LastNameLabel.AutoSize = True
        LastNameLabel.Font = New System.Drawing.Font("Trebuchet MS", 9.75!)
        LastNameLabel.Location = New System.Drawing.Point(19, 129)
        LastNameLabel.Name = "LastNameLabel"
        LastNameLabel.Size = New System.Drawing.Size(63, 18)
        LastNameLabel.TabIndex = 10281
        LastNameLabel.Text = "Location:"
        '
        'Label2
        '
        Label2.AutoSize = True
        Label2.Font = New System.Drawing.Font("Trebuchet MS", 9.75!)
        Label2.Location = New System.Drawing.Point(38, 230)
        Label2.Name = "Label2"
        Label2.Size = New System.Drawing.Size(39, 18)
        Label2.TabIndex = 10281
        Label2.Text = "Who:"
        '
        'Label5
        '
        Label5.AutoSize = True
        Label5.Font = New System.Drawing.Font("Trebuchet MS", 9.75!)
        Label5.Location = New System.Drawing.Point(38, 8)
        Label5.Name = "Label5"
        Label5.Size = New System.Drawing.Size(43, 18)
        Label5.TabIndex = 10281
        Label5.Text = "Proof:"
        AddHandler Label5.Click, AddressOf Me.Label3_Click
        '
        'Label7
        '
        Label7.AutoSize = True
        Label7.Font = New System.Drawing.Font("Trebuchet MS", 9.75!)
        Label7.Location = New System.Drawing.Point(15, 174)
        Label7.Name = "Label7"
        Label7.Size = New System.Drawing.Size(86, 18)
        Label7.TabIndex = 10281
        Label7.Text = "Complainant:"
        '
        'tmrOpen
        '
        Me.tmrOpen.Enabled = True
        Me.tmrOpen.Interval = 8
        '
        'Guna2BorderlessForm1
        '
        Me.Guna2BorderlessForm1.AnimationInterval = 50
        Me.Guna2BorderlessForm1.BorderRadius = 30
        Me.Guna2BorderlessForm1.ContainerControl = Me
        Me.Guna2BorderlessForm1.DockForm = False
        Me.Guna2BorderlessForm1.DockIndicatorTransparencyValue = 0.6R
        Me.Guna2BorderlessForm1.DragForm = False
        Me.Guna2BorderlessForm1.TransparentWhileDrag = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(799, 296)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(113, 44)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Button1"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'IDTextBox
        '
        Me.IDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblBlotterBindingSource, "ID", True))
        Me.IDTextBox.Enabled = False
        Me.IDTextBox.Location = New System.Drawing.Point(669, 177)
        Me.IDTextBox.Name = "IDTextBox"
        Me.IDTextBox.Size = New System.Drawing.Size(76, 20)
        Me.IDTextBox.TabIndex = 3
        '
        'TblBlotterBindingSource
        '
        Me.TblBlotterBindingSource.DataMember = "tblBlotter"
        Me.TblBlotterBindingSource.DataSource = Me.DbBrgySystemDataSet
        '
        'DbBrgySystemDataSet
        '
        Me.DbBrgySystemDataSet.DataSetName = "dbBrgySystemDataSet"
        Me.DbBrgySystemDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ReportDateDateTimePicker
        '
        Me.ReportDateDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.TblBlotterBindingSource, "reportDate", True))
        Me.ReportDateDateTimePicker.Enabled = False
        Me.ReportDateDateTimePicker.Location = New System.Drawing.Point(644, 82)
        Me.ReportDateDateTimePicker.Name = "ReportDateDateTimePicker"
        Me.ReportDateDateTimePicker.Size = New System.Drawing.Size(179, 20)
        Me.ReportDateDateTimePicker.TabIndex = 5
        '
        'ReportIssueTextBox
        '
        Me.ReportIssueTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblBlotterBindingSource, "reportIssue", True))
        Me.ReportIssueTextBox.Enabled = False
        Me.ReportIssueTextBox.Location = New System.Drawing.Point(639, 44)
        Me.ReportIssueTextBox.Name = "ReportIssueTextBox"
        Me.ReportIssueTextBox.Size = New System.Drawing.Size(273, 20)
        Me.ReportIssueTextBox.TabIndex = 7
        '
        'IncidentDateDateTimePicker
        '
        Me.IncidentDateDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.TblBlotterBindingSource, "incidentDate", True))
        Me.IncidentDateDateTimePicker.Enabled = False
        Me.IncidentDateDateTimePicker.Location = New System.Drawing.Point(644, 226)
        Me.IncidentDateDateTimePicker.Name = "IncidentDateDateTimePicker"
        Me.IncidentDateDateTimePicker.Size = New System.Drawing.Size(174, 20)
        Me.IncidentDateDateTimePicker.TabIndex = 9
        '
        'LocationTextBox
        '
        Me.LocationTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblBlotterBindingSource, "location", True))
        Me.LocationTextBox.Enabled = False
        Me.LocationTextBox.Location = New System.Drawing.Point(212, 186)
        Me.LocationTextBox.Name = "LocationTextBox"
        Me.LocationTextBox.Size = New System.Drawing.Size(200, 20)
        Me.LocationTextBox.TabIndex = 11
        '
        'WhoTextBox
        '
        Me.WhoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblBlotterBindingSource, "who", True))
        Me.WhoTextBox.Enabled = False
        Me.WhoTextBox.Location = New System.Drawing.Point(212, 296)
        Me.WhoTextBox.Name = "WhoTextBox"
        Me.WhoTextBox.Size = New System.Drawing.Size(200, 20)
        Me.WhoTextBox.TabIndex = 13
        '
        'ReportAttachedPictureBox
        '
        Me.ReportAttachedPictureBox.DataBindings.Add(New System.Windows.Forms.Binding("Image", Me.TblBlotterBindingSource, "reportAttached", True))
        Me.ReportAttachedPictureBox.Enabled = False
        Me.ReportAttachedPictureBox.Location = New System.Drawing.Point(630, 389)
        Me.ReportAttachedPictureBox.Name = "ReportAttachedPictureBox"
        Me.ReportAttachedPictureBox.Size = New System.Drawing.Size(96, 91)
        Me.ReportAttachedPictureBox.TabIndex = 15
        Me.ReportAttachedPictureBox.TabStop = False
        '
        'ReportTextTextBox
        '
        Me.ReportTextTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblBlotterBindingSource, "reportText", True))
        Me.ReportTextTextBox.Enabled = False
        Me.ReportTextTextBox.Location = New System.Drawing.Point(669, 327)
        Me.ReportTextTextBox.Multiline = True
        Me.ReportTextTextBox.Name = "ReportTextTextBox"
        Me.ReportTextTextBox.Size = New System.Drawing.Size(149, 87)
        Me.ReportTextTextBox.TabIndex = 17
        '
        'ComplainantTextBox
        '
        Me.ComplainantTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblBlotterBindingSource, "complainant", True))
        Me.ComplainantTextBox.Enabled = False
        Me.ComplainantTextBox.Location = New System.Drawing.Point(197, 243)
        Me.ComplainantTextBox.Name = "ComplainantTextBox"
        Me.ComplainantTextBox.Size = New System.Drawing.Size(200, 20)
        Me.ComplainantTextBox.TabIndex = 19
        '
        'OnDutyTextBox
        '
        Me.OnDutyTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblBlotterBindingSource, "onDuty", True))
        Me.OnDutyTextBox.Enabled = False
        Me.OnDutyTextBox.Location = New System.Drawing.Point(644, 296)
        Me.OnDutyTextBox.Name = "OnDutyTextBox"
        Me.OnDutyTextBox.Size = New System.Drawing.Size(200, 20)
        Me.OnDutyTextBox.TabIndex = 21
        '
        'Guna2Button4
        '
        Me.Guna2Button4.Animated = True
        Me.Guna2Button4.AnimatedGIF = True
        Me.Guna2Button4.BorderRadius = 10
        Me.Guna2Button4.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Guna2Button4.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.Guna2Button4.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.Guna2Button4.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.Guna2Button4.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.Guna2Button4.FillColor = System.Drawing.Color.Firebrick
        Me.Guna2Button4.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Bold)
        Me.Guna2Button4.ForeColor = System.Drawing.Color.White
        Me.Guna2Button4.Image = Global.BarangaySystem.My.Resources.Resources.iconCancel
        Me.Guna2Button4.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.Guna2Button4.Location = New System.Drawing.Point(716, 655)
        Me.Guna2Button4.Name = "Guna2Button4"
        Me.Guna2Button4.Size = New System.Drawing.Size(80, 49)
        Me.Guna2Button4.TabIndex = 10286
        Me.Guna2Button4.Text = "Cancel"
        Me.Guna2Button4.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.Guna2Button4.TextOffset = New System.Drawing.Point(-5, 0)
        '
        'Guna2Button2
        '
        Me.Guna2Button2.Animated = True
        Me.Guna2Button2.AnimatedGIF = True
        Me.Guna2Button2.BorderRadius = 10
        Me.Guna2Button2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Guna2Button2.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.Guna2Button2.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.Guna2Button2.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.Guna2Button2.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.Guna2Button2.FillColor = System.Drawing.Color.SeaGreen
        Me.Guna2Button2.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2Button2.ForeColor = System.Drawing.Color.White
        Me.Guna2Button2.Image = Global.BarangaySystem.My.Resources.Resources.iconAddPerson
        Me.Guna2Button2.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.Guna2Button2.Location = New System.Drawing.Point(630, 655)
        Me.Guna2Button2.Name = "Guna2Button2"
        Me.Guna2Button2.Size = New System.Drawing.Size(80, 49)
        Me.Guna2Button2.TabIndex = 10285
        Me.Guna2Button2.Text = "Save"
        Me.Guna2Button2.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.Guna2Button2.TextOffset = New System.Drawing.Point(-5, 0)
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'Panel1
        '
        Me.Panel1.AutoScroll = True
        Me.Panel1.BackColor = System.Drawing.SystemColors.Control
        Me.Panel1.Controls.Add(Me.Panel3)
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Controls.Add(Label3)
        Me.Panel1.Location = New System.Drawing.Point(13, 64)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(598, 671)
        Me.Panel1.TabIndex = 10288
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.rptPhoto)
        Me.Panel3.Controls.Add(Me.TextBox1)
        Me.Panel3.Controls.Add(Label5)
        Me.Panel3.Controls.Add(Me.Button2)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel3.Location = New System.Drawing.Point(0, 279)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(598, 331)
        Me.Panel3.TabIndex = 10296
        '
        'rptPhoto
        '
        Me.rptPhoto.BackColor = System.Drawing.Color.DarkGray
        Me.rptPhoto.Image = Global.BarangaySystem.My.Resources.Resources.man
        Me.rptPhoto.Location = New System.Drawing.Point(95, 8)
        Me.rptPhoto.Name = "rptPhoto"
        Me.rptPhoto.Size = New System.Drawing.Size(331, 285)
        Me.rptPhoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.rptPhoto.TabIndex = 10284
        Me.rptPhoto.TabStop = False
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(95, 273)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(251, 20)
        Me.TextBox1.TabIndex = 10297
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(103, 296)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(324, 32)
        Me.Button2.TabIndex = 10287
        Me.Button2.Text = "Browse"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.SystemColors.Control
        Me.Panel2.Controls.Add(Me.BunifuDatepicker1)
        Me.Panel2.Controls.Add(Me.RptIssue)
        Me.Panel2.Controls.Add(Label2)
        Me.Panel2.Controls.Add(Label7)
        Me.Panel2.Controls.Add(LastNameLabel)
        Me.Panel2.Controls.Add(MInitialLabel)
        Me.Panel2.Controls.Add(FirstNameLabel)
        Me.Panel2.Controls.Add(Me.BunifuMetroTextbox1)
        Me.Panel2.Controls.Add(Me.complainant)
        Me.Panel2.Controls.Add(Me.rptLoc)
        Me.Panel2.Controls.Add(Me.Label10)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(598, 279)
        Me.Panel2.TabIndex = 10297
        '
        'RptIssue
        '
        Me.RptIssue.BackColor = System.Drawing.Color.White
        Me.RptIssue.BorderColorFocused = System.Drawing.Color.Blue
        Me.RptIssue.BorderColorIdle = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.RptIssue.BorderColorMouseHover = System.Drawing.Color.Blue
        Me.RptIssue.BorderThickness = 1
        Me.RptIssue.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.RptIssue.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblBlotterBindingSource, "reportIssue", True))
        Me.RptIssue.Font = New System.Drawing.Font("Trebuchet MS", 9.75!)
        Me.RptIssue.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.RptIssue.isPassword = False
        Me.RptIssue.Location = New System.Drawing.Point(103, 4)
        Me.RptIssue.Margin = New System.Windows.Forms.Padding(4)
        Me.RptIssue.Name = "RptIssue"
        Me.RptIssue.Size = New System.Drawing.Size(323, 47)
        Me.RptIssue.TabIndex = 0
        Me.RptIssue.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'BunifuMetroTextbox1
        '
        Me.BunifuMetroTextbox1.BackColor = System.Drawing.Color.White
        Me.BunifuMetroTextbox1.BorderColorFocused = System.Drawing.Color.Blue
        Me.BunifuMetroTextbox1.BorderColorIdle = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.BunifuMetroTextbox1.BorderColorMouseHover = System.Drawing.Color.Blue
        Me.BunifuMetroTextbox1.BorderThickness = 1
        Me.BunifuMetroTextbox1.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.BunifuMetroTextbox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblBlotterBindingSource, "who", True))
        Me.BunifuMetroTextbox1.Font = New System.Drawing.Font("Trebuchet MS", 9.75!)
        Me.BunifuMetroTextbox1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.BunifuMetroTextbox1.isPassword = False
        Me.BunifuMetroTextbox1.Location = New System.Drawing.Point(103, 217)
        Me.BunifuMetroTextbox1.Margin = New System.Windows.Forms.Padding(4)
        Me.BunifuMetroTextbox1.Name = "BunifuMetroTextbox1"
        Me.BunifuMetroTextbox1.Size = New System.Drawing.Size(323, 47)
        Me.BunifuMetroTextbox1.TabIndex = 4
        Me.BunifuMetroTextbox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'complainant
        '
        Me.complainant.BackColor = System.Drawing.Color.White
        Me.complainant.BorderColorFocused = System.Drawing.Color.Blue
        Me.complainant.BorderColorIdle = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.complainant.BorderColorMouseHover = System.Drawing.Color.Blue
        Me.complainant.BorderThickness = 1
        Me.complainant.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.complainant.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblBlotterBindingSource, "complainant", True))
        Me.complainant.Font = New System.Drawing.Font("Trebuchet MS", 9.75!)
        Me.complainant.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.complainant.isPassword = False
        Me.complainant.Location = New System.Drawing.Point(104, 162)
        Me.complainant.Margin = New System.Windows.Forms.Padding(4)
        Me.complainant.Name = "complainant"
        Me.complainant.Size = New System.Drawing.Size(323, 47)
        Me.complainant.TabIndex = 3
        Me.complainant.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'rptLoc
        '
        Me.rptLoc.BackColor = System.Drawing.Color.White
        Me.rptLoc.BorderColorFocused = System.Drawing.Color.Blue
        Me.rptLoc.BorderColorIdle = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.rptLoc.BorderColorMouseHover = System.Drawing.Color.Blue
        Me.rptLoc.BorderThickness = 1
        Me.rptLoc.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.rptLoc.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblBlotterBindingSource, "location", True))
        Me.rptLoc.Font = New System.Drawing.Font("Trebuchet MS", 9.75!)
        Me.rptLoc.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.rptLoc.isPassword = False
        Me.rptLoc.Location = New System.Drawing.Point(103, 113)
        Me.rptLoc.Margin = New System.Windows.Forms.Padding(4)
        Me.rptLoc.Name = "rptLoc"
        Me.rptLoc.Size = New System.Drawing.Size(323, 47)
        Me.rptLoc.TabIndex = 2
        Me.rptLoc.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(381, 31)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(45, 13)
        Me.Label10.TabIndex = 10298
        Me.Label10.Text = "Label10"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(116, 26)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(66, 24)
        Me.Label9.TabIndex = 10296
        Me.Label9.Text = "Label9"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(116, 100)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(39, 13)
        Me.Label6.TabIndex = 10292
        Me.Label6.Text = "Label6"
        '
        'ReportAttached1PictureBox
        '
        Me.ReportAttached1PictureBox.DataBindings.Add(New System.Windows.Forms.Binding("Image", Me.TblBlotterBindingSource, "reportAttached1", True))
        Me.ReportAttached1PictureBox.Location = New System.Drawing.Point(864, 546)
        Me.ReportAttached1PictureBox.Name = "ReportAttached1PictureBox"
        Me.ReportAttached1PictureBox.Size = New System.Drawing.Size(100, 91)
        Me.ReportAttached1PictureBox.TabIndex = 10289
        Me.ReportAttached1PictureBox.TabStop = False
        '
        'ReportAttached2PictureBox
        '
        Me.ReportAttached2PictureBox.DataBindings.Add(New System.Windows.Forms.Binding("Image", Me.TblBlotterBindingSource, "reportAttached2", True))
        Me.ReportAttached2PictureBox.Location = New System.Drawing.Point(970, 546)
        Me.ReportAttached2PictureBox.Name = "ReportAttached2PictureBox"
        Me.ReportAttached2PictureBox.Size = New System.Drawing.Size(100, 91)
        Me.ReportAttached2PictureBox.TabIndex = 10290
        Me.ReportAttached2PictureBox.TabStop = False
        '
        'OpenFileDialog2
        '
        Me.OpenFileDialog2.FileName = "OpenFileDialog2"
        '
        'OpenFileDialog3
        '
        Me.OpenFileDialog3.FileName = "OpenFileDialog3"
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 1000
        '
        'ReportAttachedTextBox
        '
        Me.ReportAttachedTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblBlotterBindingSource, "reportAttached", True))
        Me.ReportAttachedTextBox.Location = New System.Drawing.Point(680, 122)
        Me.ReportAttachedTextBox.Name = "ReportAttachedTextBox"
        Me.ReportAttachedTextBox.Size = New System.Drawing.Size(243, 20)
        Me.ReportAttachedTextBox.TabIndex = 10293
        '
        'Rpt
        '
        Me.Rpt.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblBlotterBindingSource, "reportText", True))
        Me.Rpt.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Rpt.Location = New System.Drawing.Point(630, 36)
        Me.Rpt.Multiline = True
        Me.Rpt.Name = "Rpt"
        Me.Rpt.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.Rpt.Size = New System.Drawing.Size(717, 611)
        Me.Rpt.TabIndex = 10283
        '
        'TblBlotterTableAdapter
        '
        Me.TblBlotterTableAdapter.ClearBeforeFill = True
        '
        'lblOrigAttachement
        '
        Me.lblOrigAttachement.AutoSize = True
        Me.lblOrigAttachement.Location = New System.Drawing.Point(666, 51)
        Me.lblOrigAttachement.Name = "lblOrigAttachement"
        Me.lblOrigAttachement.Size = New System.Drawing.Size(111, 13)
        Me.lblOrigAttachement.TabIndex = 10299
        Me.lblOrigAttachement.Text = "ORIG ATTACHMENT"
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.Connection = Nothing
        Me.TableAdapterManager.tblBlotterTableAdapter = Nothing
        Me.TableAdapterManager.tblDatabaseTableAdapter = Nothing
        Me.TableAdapterManager.tblHistoryTableAdapter = Nothing
        Me.TableAdapterManager.tblIncrementsTableAdapter = Nothing
        Me.TableAdapterManager.tblOrganizationTableAdapter = Nothing
        Me.TableAdapterManager.tblPrintIndigencyTableAdapter = Nothing
        Me.TableAdapterManager.tblResidentsTableAdapter = Nothing
        Me.TableAdapterManager.tblSysSettingsTableAdapter = Nothing
        Me.TableAdapterManager.tblUserAccountsTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = BarangaySystem.dbBrgySystemDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'BunifuMetroTextbox2
        '
        Me.BunifuMetroTextbox2.BackColor = System.Drawing.Color.White
        Me.BunifuMetroTextbox2.BorderColorFocused = System.Drawing.Color.Blue
        Me.BunifuMetroTextbox2.BorderColorIdle = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.BunifuMetroTextbox2.BorderColorMouseHover = System.Drawing.Color.Blue
        Me.BunifuMetroTextbox2.BorderThickness = 1
        Me.BunifuMetroTextbox2.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.BunifuMetroTextbox2.Font = New System.Drawing.Font("Trebuchet MS", 9.75!)
        Me.BunifuMetroTextbox2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.BunifuMetroTextbox2.isPassword = False
        Me.BunifuMetroTextbox2.Location = New System.Drawing.Point(669, 164)
        Me.BunifuMetroTextbox2.Margin = New System.Windows.Forms.Padding(4)
        Me.BunifuMetroTextbox2.Name = "BunifuMetroTextbox2"
        Me.BunifuMetroTextbox2.Size = New System.Drawing.Size(323, 47)
        Me.BunifuMetroTextbox2.TabIndex = 1
        Me.BunifuMetroTextbox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'BunifuDatepicker1
        '
        Me.BunifuDatepicker1.BackColor = System.Drawing.Color.SeaGreen
        Me.BunifuDatepicker1.BorderRadius = 0
        Me.BunifuDatepicker1.ForeColor = System.Drawing.Color.White
        Me.BunifuDatepicker1.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.BunifuDatepicker1.FormatCustom = Nothing
        Me.BunifuDatepicker1.Location = New System.Drawing.Point(104, 58)
        Me.BunifuDatepicker1.Name = "BunifuDatepicker1"
        Me.BunifuDatepicker1.Size = New System.Drawing.Size(323, 47)
        Me.BunifuDatepicker1.TabIndex = 10299
        Me.BunifuDatepicker1.Value = New Date(2023, 5, 4, 19, 22, 34, 831)
        '
        'frmModifyBlotter
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1372, 755)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Guna2Button4)
        Me.Controls.Add(Me.Guna2Button2)
        Me.Controls.Add(Me.Rpt)
        Me.Controls.Add(Label4)
        Me.Controls.Add(IDLabel)
        Me.Controls.Add(Me.IDTextBox)
        Me.Controls.Add(ReportDateLabel)
        Me.Controls.Add(ReportIssueLabel)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.ReportIssueTextBox)
        Me.Controls.Add(Me.ReportDateDateTimePicker)
        Me.Controls.Add(IncidentDateLabel)
        Me.Controls.Add(Label1)
        Me.Controls.Add(Me.IncidentDateDateTimePicker)
        Me.Controls.Add(LocationLabel)
        Me.Controls.Add(Me.LocationTextBox)
        Me.Controls.Add(Me.ReportAttachedPictureBox)
        Me.Controls.Add(WhoLabel)
        Me.Controls.Add(Me.WhoTextBox)
        Me.Controls.Add(ReportAttachedLabel)
        Me.Controls.Add(ReportTextLabel)
        Me.Controls.Add(Me.ReportTextTextBox)
        Me.Controls.Add(ComplainantLabel)
        Me.Controls.Add(Me.ComplainantTextBox)
        Me.Controls.Add(OnDutyLabel)
        Me.Controls.Add(Me.OnDutyTextBox)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.ReportAttached2PictureBox)
        Me.Controls.Add(Me.ReportAttached1PictureBox)
        Me.Controls.Add(ReportAttachedLabel1)
        Me.Controls.Add(Me.ReportAttachedTextBox)
        Me.Controls.Add(Me.lblOrigAttachement)
        Me.Controls.Add(Me.BunifuMetroTextbox2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmModifyBlotter"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "frmModifyBlotter"
        CType(Me.TblBlotterBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DbBrgySystemDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ReportAttachedPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        CType(Me.rptPhoto, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.ReportAttached1PictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ReportAttached2PictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents tmrOpen As System.Windows.Forms.Timer
    Friend WithEvents Guna2BorderlessForm1 As Guna.UI2.WinForms.Guna2BorderlessForm
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents TblBlotterBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents DbBrgySystemDataSet As BarangaySystem.dbBrgySystemDataSet
    Friend WithEvents TblBlotterTableAdapter As BarangaySystem.dbBrgySystemDataSetTableAdapters.tblBlotterTableAdapter
    Friend WithEvents IDTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ReportDateDateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents ReportIssueTextBox As System.Windows.Forms.TextBox
    Friend WithEvents IncidentDateDateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents LocationTextBox As System.Windows.Forms.TextBox
    Friend WithEvents WhoTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ReportAttachedPictureBox As System.Windows.Forms.PictureBox
    Friend WithEvents ReportTextTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ComplainantTextBox As System.Windows.Forms.TextBox
    Friend WithEvents OnDutyTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Guna2Button4 As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Guna2Button2 As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents ReportAttached2PictureBox As System.Windows.Forms.PictureBox
    Friend WithEvents ReportAttached1PictureBox As System.Windows.Forms.PictureBox
    Friend WithEvents OpenFileDialog2 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents OpenFileDialog3 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents ReportAttachedTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents rptPhoto As System.Windows.Forms.PictureBox
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents RptIssue As Bunifu.Framework.UI.BunifuMetroTextbox
    Friend WithEvents BunifuMetroTextbox1 As Bunifu.Framework.UI.BunifuMetroTextbox
    Friend WithEvents complainant As Bunifu.Framework.UI.BunifuMetroTextbox
    Friend WithEvents rptLoc As Bunifu.Framework.UI.BunifuMetroTextbox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Rpt As System.Windows.Forms.TextBox
    Friend WithEvents TableAdapterManager As BarangaySystem.dbBrgySystemDataSetTableAdapters.TableAdapterManager
    Friend WithEvents lblOrigAttachement As System.Windows.Forms.Label
    Friend WithEvents BunifuMetroTextbox2 As Bunifu.Framework.UI.BunifuMetroTextbox
    Friend WithEvents BunifuDatepicker1 As Bunifu.Framework.UI.BunifuDatepicker
End Class
