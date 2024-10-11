<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmBltrRpt
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
        Dim ReportTextLabel As System.Windows.Forms.Label
        Dim ReportAttachedLabel As System.Windows.Forms.Label
        Dim IDLabel As System.Windows.Forms.Label
        Dim ComplainantLabel As System.Windows.Forms.Label
        Dim ReportAttachedLabel1 As System.Windows.Forms.Label
        Dim WhoLabel As System.Windows.Forms.Label
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmBltrRpt))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Guna2Button6 = New Guna.UI2.WinForms.Guna2Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ComplainantTextBox = New System.Windows.Forms.TextBox()
        Me.TblBlotterBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DbBrgySystemDataSet = New BarangaySystem.dbBrgySystemDataSet()
        Me.IDTextBox = New System.Windows.Forms.TextBox()
        Me.lblCurrentFrm = New System.Windows.Forms.Label()
        Me.picCurrentFrm = New Guna.UI2.WinForms.Guna2PictureBox()
        Me.Guna2Panel2 = New Guna.UI2.WinForms.Guna2Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Guna2Button5 = New Guna.UI2.WinForms.Guna2Button()
        Me.clearSearch = New System.Windows.Forms.Button()
        Me.Guna2Button4 = New Guna.UI2.WinForms.Guna2Button()
        Me.Guna2Button3 = New Guna.UI2.WinForms.Guna2Button()
        Me.Guna2Button2 = New Guna.UI2.WinForms.Guna2Button()
        Me.Guna2Button1 = New Guna.UI2.WinForms.Guna2Button()
        Me.residentSearchBox = New Guna.UI2.WinForms.Guna2TextBox()
        Me.ReportTextTextBox = New System.Windows.Forms.TextBox()
        Me.blotterTbl = New System.Windows.Forms.DataGridView()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.WhoTextBox = New System.Windows.Forms.TextBox()
        Me.ReportAttachedTextBox = New System.Windows.Forms.TextBox()
        Me.Guna2Elipse1 = New Guna.UI2.WinForms.Guna2Elipse(Me.components)
        Me.Guna2Elipse3 = New Guna.UI2.WinForms.Guna2Elipse(Me.components)
        Me.Guna2Elipse2 = New Guna.UI2.WinForms.Guna2Elipse(Me.components)
        Me.DataGridViewImageColumn1 = New System.Windows.Forms.DataGridViewImageColumn()
        Me.DataGridViewImageColumn2 = New System.Windows.Forms.DataGridViewImageColumn()
        Me.TableAdapterManager = New BarangaySystem.dbBrgySystemDataSetTableAdapters.TableAdapterManager()
        Me.TblBlotterTableAdapter = New BarangaySystem.dbBrgySystemDataSetTableAdapters.tblBlotterTableAdapter()
        Me.IDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ReportDateDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ReportIssueDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IncidentDateDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LocationDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.WhoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ReportAttachedDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ReportTextDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ComplainantDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.OnDutyDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        ReportTextLabel = New System.Windows.Forms.Label()
        ReportAttachedLabel = New System.Windows.Forms.Label()
        IDLabel = New System.Windows.Forms.Label()
        ComplainantLabel = New System.Windows.Forms.Label()
        ReportAttachedLabel1 = New System.Windows.Forms.Label()
        WhoLabel = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        CType(Me.TblBlotterBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DbBrgySystemDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picCurrentFrm, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Guna2Panel2.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.blotterTbl, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ReportTextLabel
        '
        ReportTextLabel.AutoSize = True
        ReportTextLabel.Font = New System.Drawing.Font("Trebuchet MS", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        ReportTextLabel.Location = New System.Drawing.Point(14, 366)
        ReportTextLabel.Name = "ReportTextLabel"
        ReportTextLabel.Size = New System.Drawing.Size(76, 18)
        ReportTextLabel.TabIndex = 10264
        ReportTextLabel.Text = "report Text:"
        '
        'ReportAttachedLabel
        '
        ReportAttachedLabel.AutoSize = True
        ReportAttachedLabel.Font = New System.Drawing.Font("Trebuchet MS", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        ReportAttachedLabel.Location = New System.Drawing.Point(1084, 43)
        ReportAttachedLabel.Name = "ReportAttachedLabel"
        ReportAttachedLabel.Size = New System.Drawing.Size(41, 18)
        ReportAttachedLabel.TabIndex = 10265
        ReportAttachedLabel.Text = "Proof:"
        '
        'IDLabel
        '
        IDLabel.AutoSize = True
        IDLabel.Location = New System.Drawing.Point(800, 12)
        IDLabel.Name = "IDLabel"
        IDLabel.Size = New System.Drawing.Size(21, 13)
        IDLabel.TabIndex = 4
        IDLabel.Text = "ID:"
        '
        'ComplainantLabel
        '
        ComplainantLabel.AutoSize = True
        ComplainantLabel.Location = New System.Drawing.Point(952, 15)
        ComplainantLabel.Name = "ComplainantLabel"
        ComplainantLabel.Size = New System.Drawing.Size(67, 13)
        ComplainantLabel.TabIndex = 5
        ComplainantLabel.Text = "complainant:"
        '
        'ReportAttachedLabel1
        '
        ReportAttachedLabel1.AutoSize = True
        ReportAttachedLabel1.Location = New System.Drawing.Point(663, 544)
        ReportAttachedLabel1.Name = "ReportAttachedLabel1"
        ReportAttachedLabel1.Size = New System.Drawing.Size(83, 13)
        ReportAttachedLabel1.TabIndex = 9
        ReportAttachedLabel1.Text = "report Attached:"
        '
        'WhoLabel
        '
        WhoLabel.AutoSize = True
        WhoLabel.Location = New System.Drawing.Point(749, 137)
        WhoLabel.Name = "WhoLabel"
        WhoLabel.Size = New System.Drawing.Size(30, 13)
        WhoLabel.TabIndex = 10287
        WhoLabel.Text = "who:"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.Controls.Add(Me.Guna2Button6)
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(ComplainantLabel)
        Me.Panel1.Controls.Add(Me.ComplainantTextBox)
        Me.Panel1.Controls.Add(IDLabel)
        Me.Panel1.Controls.Add(Me.IDTextBox)
        Me.Panel1.Controls.Add(Me.lblCurrentFrm)
        Me.Panel1.Controls.Add(Me.picCurrentFrm)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1372, 63)
        Me.Panel1.TabIndex = 8
        '
        'Guna2Button6
        '
        Me.Guna2Button6.Animated = True
        Me.Guna2Button6.AnimatedGIF = True
        Me.Guna2Button6.BorderRadius = 10
        Me.Guna2Button6.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Guna2Button6.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.Guna2Button6.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.Guna2Button6.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.Guna2Button6.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.Guna2Button6.FillColor = System.Drawing.Color.Firebrick
        Me.Guna2Button6.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Bold)
        Me.Guna2Button6.ForeColor = System.Drawing.Color.White
        Me.Guna2Button6.Image = Global.BarangaySystem.My.Resources.Resources.iconCancel
        Me.Guna2Button6.Location = New System.Drawing.Point(1303, 6)
        Me.Guna2Button6.Name = "Guna2Button6"
        Me.Guna2Button6.Size = New System.Drawing.Size(55, 49)
        Me.Guna2Button6.TabIndex = 19
        Me.Guna2Button6.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.Guna2Button6.TextOffset = New System.Drawing.Point(-5, 0)
        '
        'Panel2
        '
        Me.Panel2.Location = New System.Drawing.Point(482, 3)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(679, 57)
        Me.Panel2.TabIndex = 8
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(728, 12)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(39, 13)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Label1"
        '
        'ComplainantTextBox
        '
        Me.ComplainantTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblBlotterBindingSource, "complainant", True))
        Me.ComplainantTextBox.Enabled = False
        Me.ComplainantTextBox.Location = New System.Drawing.Point(1025, 12)
        Me.ComplainantTextBox.Name = "ComplainantTextBox"
        Me.ComplainantTextBox.Size = New System.Drawing.Size(100, 20)
        Me.ComplainantTextBox.TabIndex = 6
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
        'IDTextBox
        '
        Me.IDTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.IDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblBlotterBindingSource, "ID", True))
        Me.IDTextBox.Enabled = False
        Me.IDTextBox.Location = New System.Drawing.Point(827, 9)
        Me.IDTextBox.Name = "IDTextBox"
        Me.IDTextBox.Size = New System.Drawing.Size(100, 13)
        Me.IDTextBox.TabIndex = 5
        '
        'lblCurrentFrm
        '
        Me.lblCurrentFrm.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblCurrentFrm.AutoSize = True
        Me.lblCurrentFrm.Font = New System.Drawing.Font("Trebuchet MS", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCurrentFrm.Location = New System.Drawing.Point(64, 11)
        Me.lblCurrentFrm.Name = "lblCurrentFrm"
        Me.lblCurrentFrm.Size = New System.Drawing.Size(221, 40)
        Me.lblCurrentFrm.TabIndex = 4
        Me.lblCurrentFrm.Text = "Blotter Report"
        '
        'picCurrentFrm
        '
        Me.picCurrentFrm.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.picCurrentFrm.Image = Global.BarangaySystem.My.Resources.Resources.iconBltrRpt
        Me.picCurrentFrm.ImageRotate = 0.0!
        Me.picCurrentFrm.Location = New System.Drawing.Point(6, 11)
        Me.picCurrentFrm.Name = "picCurrentFrm"
        Me.picCurrentFrm.Size = New System.Drawing.Size(63, 38)
        Me.picCurrentFrm.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picCurrentFrm.TabIndex = 3
        Me.picCurrentFrm.TabStop = False
        '
        'Guna2Panel2
        '
        Me.Guna2Panel2.AutoRoundedCorners = True
        Me.Guna2Panel2.BackColor = System.Drawing.Color.White
        Me.Guna2Panel2.BorderRadius = 305
        Me.Guna2Panel2.Controls.Add(Me.PictureBox1)
        Me.Guna2Panel2.Controls.Add(Me.Guna2Button5)
        Me.Guna2Panel2.Controls.Add(Me.clearSearch)
        Me.Guna2Panel2.Controls.Add(Me.Guna2Button4)
        Me.Guna2Panel2.Controls.Add(Me.Guna2Button3)
        Me.Guna2Panel2.Controls.Add(Me.Guna2Button2)
        Me.Guna2Panel2.Controls.Add(Me.Guna2Button1)
        Me.Guna2Panel2.Controls.Add(Me.residentSearchBox)
        Me.Guna2Panel2.Controls.Add(ReportAttachedLabel)
        Me.Guna2Panel2.Controls.Add(ReportTextLabel)
        Me.Guna2Panel2.Controls.Add(Me.ReportTextTextBox)
        Me.Guna2Panel2.Controls.Add(Me.blotterTbl)
        Me.Guna2Panel2.Controls.Add(Me.Button1)
        Me.Guna2Panel2.Controls.Add(Me.Label2)
        Me.Guna2Panel2.Controls.Add(WhoLabel)
        Me.Guna2Panel2.Controls.Add(Me.WhoTextBox)
        Me.Guna2Panel2.Controls.Add(Me.ReportAttachedTextBox)
        Me.Guna2Panel2.Controls.Add(ReportAttachedLabel1)
        Me.Guna2Panel2.Location = New System.Drawing.Point(0, 69)
        Me.Guna2Panel2.Name = "Guna2Panel2"
        Me.Guna2Panel2.Size = New System.Drawing.Size(1372, 613)
        Me.Guna2Panel2.TabIndex = 9
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.SystemColors.Control
        Me.PictureBox1.Location = New System.Drawing.Point(1076, 73)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(282, 280)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 10287
        Me.PictureBox1.TabStop = False
        '
        'Guna2Button5
        '
        Me.Guna2Button5.Animated = True
        Me.Guna2Button5.AnimatedGIF = True
        Me.Guna2Button5.BorderRadius = 10
        Me.Guna2Button5.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Guna2Button5.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.Guna2Button5.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.Guna2Button5.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.Guna2Button5.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.Guna2Button5.FillColor = System.Drawing.Color.Goldenrod
        Me.Guna2Button5.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Bold)
        Me.Guna2Button5.ForeColor = System.Drawing.Color.White
        Me.Guna2Button5.Image = Global.BarangaySystem.My.Resources.Resources.iconCancel
        Me.Guna2Button5.Location = New System.Drawing.Point(14, 0)
        Me.Guna2Button5.Name = "Guna2Button5"
        Me.Guna2Button5.Size = New System.Drawing.Size(180, 49)
        Me.Guna2Button5.TabIndex = 20
        Me.Guna2Button5.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.Guna2Button5.TextOffset = New System.Drawing.Point(-5, 0)
        '
        'clearSearch
        '
        Me.clearSearch.BackColor = System.Drawing.Color.White
        Me.clearSearch.Cursor = System.Windows.Forms.Cursors.Hand
        Me.clearSearch.FlatAppearance.BorderColor = System.Drawing.Color.Lavender
        Me.clearSearch.FlatAppearance.BorderSize = 0
        Me.clearSearch.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Lavender
        Me.clearSearch.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Lavender
        Me.clearSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.clearSearch.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.clearSearch.Location = New System.Drawing.Point(452, 7)
        Me.clearSearch.Name = "clearSearch"
        Me.clearSearch.Size = New System.Drawing.Size(44, 39)
        Me.clearSearch.TabIndex = 10284
        Me.clearSearch.Text = "x"
        Me.clearSearch.UseVisualStyleBackColor = False
        Me.clearSearch.Visible = False
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
        Me.Guna2Button4.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2Button4.ForeColor = System.Drawing.Color.White
        Me.Guna2Button4.Image = Global.BarangaySystem.My.Resources.Resources.delete_button
        Me.Guna2Button4.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.Guna2Button4.Location = New System.Drawing.Point(746, 4)
        Me.Guna2Button4.Name = "Guna2Button4"
        Me.Guna2Button4.Size = New System.Drawing.Size(80, 45)
        Me.Guna2Button4.TabIndex = 10281
        Me.Guna2Button4.Text = "Delete"
        Me.Guna2Button4.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.Guna2Button4.TextOffset = New System.Drawing.Point(-5, 0)
        Me.Guna2Button4.Visible = False
        '
        'Guna2Button3
        '
        Me.Guna2Button3.Animated = True
        Me.Guna2Button3.AnimatedGIF = True
        Me.Guna2Button3.BorderRadius = 10
        Me.Guna2Button3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Guna2Button3.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.Guna2Button3.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.Guna2Button3.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.Guna2Button3.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.Guna2Button3.FillColor = System.Drawing.Color.DodgerBlue
        Me.Guna2Button3.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Bold)
        Me.Guna2Button3.ForeColor = System.Drawing.Color.White
        Me.Guna2Button3.Location = New System.Drawing.Point(663, 4)
        Me.Guna2Button3.Name = "Guna2Button3"
        Me.Guna2Button3.Size = New System.Drawing.Size(80, 45)
        Me.Guna2Button3.TabIndex = 10282
        Me.Guna2Button3.Text = "View"
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
        Me.Guna2Button2.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Bold)
        Me.Guna2Button2.ForeColor = System.Drawing.Color.White
        Me.Guna2Button2.Image = Global.BarangaySystem.My.Resources.Resources.plus
        Me.Guna2Button2.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.Guna2Button2.Location = New System.Drawing.Point(580, 4)
        Me.Guna2Button2.Name = "Guna2Button2"
        Me.Guna2Button2.Size = New System.Drawing.Size(80, 45)
        Me.Guna2Button2.TabIndex = 10283
        Me.Guna2Button2.Text = "Add"
        Me.Guna2Button2.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.Guna2Button2.TextOffset = New System.Drawing.Point(-5, 0)
        '
        'Guna2Button1
        '
        Me.Guna2Button1.Animated = True
        Me.Guna2Button1.AnimatedGIF = True
        Me.Guna2Button1.BorderRadius = 10
        Me.Guna2Button1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Guna2Button1.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.Guna2Button1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.Guna2Button1.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.Guna2Button1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.Guna2Button1.FillColor = System.Drawing.Color.Goldenrod
        Me.Guna2Button1.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2Button1.ForeColor = System.Drawing.Color.White
        Me.Guna2Button1.Location = New System.Drawing.Point(504, 4)
        Me.Guna2Button1.Name = "Guna2Button1"
        Me.Guna2Button1.Size = New System.Drawing.Size(70, 45)
        Me.Guna2Button1.TabIndex = 10280
        Me.Guna2Button1.Text = "Search"
        '
        'residentSearchBox
        '
        Me.residentSearchBox.Animated = True
        Me.residentSearchBox.BackColor = System.Drawing.Color.White
        Me.residentSearchBox.BorderColor = System.Drawing.Color.Black
        Me.residentSearchBox.BorderRadius = 10
        Me.residentSearchBox.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.residentSearchBox.DefaultText = ""
        Me.residentSearchBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.residentSearchBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.residentSearchBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.residentSearchBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.residentSearchBox.FocusedState.BorderColor = System.Drawing.Color.Goldenrod
        Me.residentSearchBox.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.residentSearchBox.ForeColor = System.Drawing.Color.Black
        Me.residentSearchBox.HoverState.BorderColor = System.Drawing.Color.Goldenrod
        Me.residentSearchBox.IconLeft = Global.BarangaySystem.My.Resources.Resources.iconSearch
        Me.residentSearchBox.IconLeftOffset = New System.Drawing.Point(8, 0)
        Me.residentSearchBox.Location = New System.Drawing.Point(201, 4)
        Me.residentSearchBox.Margin = New System.Windows.Forms.Padding(4)
        Me.residentSearchBox.Name = "residentSearchBox"
        Me.residentSearchBox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.residentSearchBox.PlaceholderForeColor = System.Drawing.Color.DimGray
        Me.residentSearchBox.PlaceholderText = "Search Last Name, First Name"
        Me.residentSearchBox.SelectedText = ""
        Me.residentSearchBox.Size = New System.Drawing.Size(299, 45)
        Me.residentSearchBox.TabIndex = 10279
        Me.residentSearchBox.TextOffset = New System.Drawing.Point(5, 0)
        '
        'ReportTextTextBox
        '
        Me.ReportTextTextBox.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.ReportTextTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblBlotterBindingSource, "reportText", True))
        Me.ReportTextTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ReportTextTextBox.Location = New System.Drawing.Point(14, 387)
        Me.ReportTextTextBox.Multiline = True
        Me.ReportTextTextBox.Name = "ReportTextTextBox"
        Me.ReportTextTextBox.ReadOnly = True
        Me.ReportTextTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.ReportTextTextBox.Size = New System.Drawing.Size(1344, 206)
        Me.ReportTextTextBox.TabIndex = 10265
        '
        'blotterTbl
        '
        Me.blotterTbl.AllowUserToAddRows = False
        Me.blotterTbl.AllowUserToDeleteRows = False
        Me.blotterTbl.AllowUserToResizeColumns = False
        Me.blotterTbl.AllowUserToResizeRows = False
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.Ivory
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.Goldenrod
        Me.blotterTbl.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle4
        Me.blotterTbl.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.blotterTbl.AutoGenerateColumns = False
        Me.blotterTbl.BackgroundColor = System.Drawing.Color.Silver
        Me.blotterTbl.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.blotterTbl.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.blotterTbl.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = System.Drawing.Color.DarkGoldenrod
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.Goldenrod
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.blotterTbl.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle5
        Me.blotterTbl.ColumnHeadersHeight = 35
        Me.blotterTbl.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.blotterTbl.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IDDataGridViewTextBoxColumn, Me.ReportDateDataGridViewTextBoxColumn, Me.ReportIssueDataGridViewTextBoxColumn, Me.IncidentDateDataGridViewTextBoxColumn, Me.LocationDataGridViewTextBoxColumn, Me.WhoDataGridViewTextBoxColumn, Me.ReportAttachedDataGridViewTextBoxColumn, Me.ReportTextDataGridViewTextBoxColumn, Me.ComplainantDataGridViewTextBoxColumn, Me.OnDutyDataGridViewTextBoxColumn})
        Me.blotterTbl.Cursor = System.Windows.Forms.Cursors.Hand
        Me.blotterTbl.DataSource = Me.TblBlotterBindingSource
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.Goldenrod
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.blotterTbl.DefaultCellStyle = DataGridViewCellStyle6
        Me.blotterTbl.EnableHeadersVisualStyles = False
        Me.blotterTbl.Location = New System.Drawing.Point(14, 52)
        Me.blotterTbl.Name = "blotterTbl"
        Me.blotterTbl.ReadOnly = True
        Me.blotterTbl.RowHeadersVisible = False
        Me.blotterTbl.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.blotterTbl.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.blotterTbl.Size = New System.Drawing.Size(1056, 299)
        Me.blotterTbl.TabIndex = 10264
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(666, 16)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(68, 23)
        Me.Button1.TabIndex = 10285
        Me.Button1.Text = "Button1"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(731, 94)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(39, 13)
        Me.Label2.TabIndex = 10289
        Me.Label2.Text = "Label2"
        '
        'WhoTextBox
        '
        Me.WhoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblBlotterBindingSource, "who", True))
        Me.WhoTextBox.Location = New System.Drawing.Point(785, 134)
        Me.WhoTextBox.Name = "WhoTextBox"
        Me.WhoTextBox.Size = New System.Drawing.Size(100, 20)
        Me.WhoTextBox.TabIndex = 10288
        '
        'ReportAttachedTextBox
        '
        Me.ReportAttachedTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblBlotterBindingSource, "reportAttached", True))
        Me.ReportAttachedTextBox.Location = New System.Drawing.Point(752, 541)
        Me.ReportAttachedTextBox.Name = "ReportAttachedTextBox"
        Me.ReportAttachedTextBox.Size = New System.Drawing.Size(100, 20)
        Me.ReportAttachedTextBox.TabIndex = 10
        '
        'Guna2Elipse1
        '
        Me.Guna2Elipse1.BorderRadius = 30
        Me.Guna2Elipse1.TargetControl = Me.Panel1
        '
        'Guna2Elipse3
        '
        Me.Guna2Elipse3.BorderRadius = 30
        Me.Guna2Elipse3.TargetControl = Me.Guna2Panel2
        '
        'Guna2Elipse2
        '
        Me.Guna2Elipse2.BorderRadius = 30
        Me.Guna2Elipse2.TargetControl = Me.Guna2Panel2
        '
        'DataGridViewImageColumn1
        '
        Me.DataGridViewImageColumn1.HeaderText = "Edit"
        Me.DataGridViewImageColumn1.Image = CType(resources.GetObject("DataGridViewImageColumn1.Image"), System.Drawing.Image)
        Me.DataGridViewImageColumn1.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom
        Me.DataGridViewImageColumn1.Name = "DataGridViewImageColumn1"
        Me.DataGridViewImageColumn1.ReadOnly = True
        Me.DataGridViewImageColumn1.ToolTipText = "Edit Record"
        Me.DataGridViewImageColumn1.Width = 50
        '
        'DataGridViewImageColumn2
        '
        Me.DataGridViewImageColumn2.HeaderText = "Delete"
        Me.DataGridViewImageColumn2.Image = CType(resources.GetObject("DataGridViewImageColumn2.Image"), System.Drawing.Image)
        Me.DataGridViewImageColumn2.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom
        Me.DataGridViewImageColumn2.Name = "DataGridViewImageColumn2"
        Me.DataGridViewImageColumn2.ReadOnly = True
        Me.DataGridViewImageColumn2.ToolTipText = "Delete Record"
        Me.DataGridViewImageColumn2.Width = 50
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.tblBlotterTableAdapter = Me.TblBlotterTableAdapter
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
        'TblBlotterTableAdapter
        '
        Me.TblBlotterTableAdapter.ClearBeforeFill = True
        '
        'IDDataGridViewTextBoxColumn
        '
        Me.IDDataGridViewTextBoxColumn.DataPropertyName = "ID"
        Me.IDDataGridViewTextBoxColumn.HeaderText = "ID"
        Me.IDDataGridViewTextBoxColumn.Name = "IDDataGridViewTextBoxColumn"
        Me.IDDataGridViewTextBoxColumn.ReadOnly = True
        '
        'ReportDateDataGridViewTextBoxColumn
        '
        Me.ReportDateDataGridViewTextBoxColumn.DataPropertyName = "reportDate"
        Me.ReportDateDataGridViewTextBoxColumn.HeaderText = "reportDate"
        Me.ReportDateDataGridViewTextBoxColumn.Name = "ReportDateDataGridViewTextBoxColumn"
        Me.ReportDateDataGridViewTextBoxColumn.ReadOnly = True
        '
        'ReportIssueDataGridViewTextBoxColumn
        '
        Me.ReportIssueDataGridViewTextBoxColumn.DataPropertyName = "reportIssue"
        Me.ReportIssueDataGridViewTextBoxColumn.HeaderText = "reportIssue"
        Me.ReportIssueDataGridViewTextBoxColumn.Name = "ReportIssueDataGridViewTextBoxColumn"
        Me.ReportIssueDataGridViewTextBoxColumn.ReadOnly = True
        '
        'IncidentDateDataGridViewTextBoxColumn
        '
        Me.IncidentDateDataGridViewTextBoxColumn.DataPropertyName = "incidentDate"
        Me.IncidentDateDataGridViewTextBoxColumn.HeaderText = "incidentDate"
        Me.IncidentDateDataGridViewTextBoxColumn.Name = "IncidentDateDataGridViewTextBoxColumn"
        Me.IncidentDateDataGridViewTextBoxColumn.ReadOnly = True
        '
        'LocationDataGridViewTextBoxColumn
        '
        Me.LocationDataGridViewTextBoxColumn.DataPropertyName = "location"
        Me.LocationDataGridViewTextBoxColumn.HeaderText = "location"
        Me.LocationDataGridViewTextBoxColumn.Name = "LocationDataGridViewTextBoxColumn"
        Me.LocationDataGridViewTextBoxColumn.ReadOnly = True
        '
        'WhoDataGridViewTextBoxColumn
        '
        Me.WhoDataGridViewTextBoxColumn.DataPropertyName = "who"
        Me.WhoDataGridViewTextBoxColumn.HeaderText = "who"
        Me.WhoDataGridViewTextBoxColumn.Name = "WhoDataGridViewTextBoxColumn"
        Me.WhoDataGridViewTextBoxColumn.ReadOnly = True
        '
        'ReportAttachedDataGridViewTextBoxColumn
        '
        Me.ReportAttachedDataGridViewTextBoxColumn.DataPropertyName = "reportAttached"
        Me.ReportAttachedDataGridViewTextBoxColumn.HeaderText = "reportAttached"
        Me.ReportAttachedDataGridViewTextBoxColumn.Name = "ReportAttachedDataGridViewTextBoxColumn"
        Me.ReportAttachedDataGridViewTextBoxColumn.ReadOnly = True
        '
        'ReportTextDataGridViewTextBoxColumn
        '
        Me.ReportTextDataGridViewTextBoxColumn.DataPropertyName = "reportText"
        Me.ReportTextDataGridViewTextBoxColumn.HeaderText = "reportText"
        Me.ReportTextDataGridViewTextBoxColumn.Name = "ReportTextDataGridViewTextBoxColumn"
        Me.ReportTextDataGridViewTextBoxColumn.ReadOnly = True
        '
        'ComplainantDataGridViewTextBoxColumn
        '
        Me.ComplainantDataGridViewTextBoxColumn.DataPropertyName = "complainant"
        Me.ComplainantDataGridViewTextBoxColumn.HeaderText = "complainant"
        Me.ComplainantDataGridViewTextBoxColumn.Name = "ComplainantDataGridViewTextBoxColumn"
        Me.ComplainantDataGridViewTextBoxColumn.ReadOnly = True
        '
        'OnDutyDataGridViewTextBoxColumn
        '
        Me.OnDutyDataGridViewTextBoxColumn.DataPropertyName = "onDuty"
        Me.OnDutyDataGridViewTextBoxColumn.HeaderText = "onDuty"
        Me.OnDutyDataGridViewTextBoxColumn.Name = "OnDutyDataGridViewTextBoxColumn"
        Me.OnDutyDataGridViewTextBoxColumn.ReadOnly = True
        '
        'frmBltrRpt
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(1364, 726)
        Me.Controls.Add(Me.Guna2Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MaximumSize = New System.Drawing.Size(1364, 726)
        Me.MinimumSize = New System.Drawing.Size(1364, 726)
        Me.Name = "frmBltrRpt"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmBltrRpt"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.TblBlotterBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DbBrgySystemDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picCurrentFrm, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Guna2Panel2.ResumeLayout(False)
        Me.Guna2Panel2.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.blotterTbl, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents lblCurrentFrm As System.Windows.Forms.Label
    Friend WithEvents picCurrentFrm As Guna.UI2.WinForms.Guna2PictureBox
    Friend WithEvents Guna2Panel2 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Guna2Elipse1 As Guna.UI2.WinForms.Guna2Elipse
    Friend WithEvents Guna2Elipse3 As Guna.UI2.WinForms.Guna2Elipse
    Friend WithEvents blotterTbl As System.Windows.Forms.DataGridView
    Friend WithEvents ReportTextTextBox As System.Windows.Forms.TextBox
    Friend WithEvents TableAdapterManager As BarangaySystem.dbBrgySystemDataSetTableAdapters.TableAdapterManager
    Friend WithEvents clearSearch As System.Windows.Forms.Button
    Friend WithEvents Guna2Button4 As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Guna2Button3 As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Guna2Button2 As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Guna2Button1 As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents residentSearchBox As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents IDTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ComplainantTextBox As System.Windows.Forms.TextBox
    Friend WithEvents DataGridViewImageColumn1 As System.Windows.Forms.DataGridViewImageColumn
    Friend WithEvents DataGridViewImageColumn2 As System.Windows.Forms.DataGridViewImageColumn
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Guna2Elipse2 As Guna.UI2.WinForms.Guna2Elipse
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Guna2Button5 As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Guna2Button6 As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents TblBlotterTableAdapter As BarangaySystem.dbBrgySystemDataSetTableAdapters.tblBlotterTableAdapter
    Friend WithEvents DbBrgySystemDataSet As BarangaySystem.dbBrgySystemDataSet
    Friend WithEvents TblBlotterBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ReportAttachedTextBox As System.Windows.Forms.TextBox
    Friend WithEvents WhoTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents IDDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ReportDateDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ReportIssueDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents IncidentDateDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents LocationDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents WhoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ReportAttachedDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ReportTextDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ComplainantDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents OnDutyDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
