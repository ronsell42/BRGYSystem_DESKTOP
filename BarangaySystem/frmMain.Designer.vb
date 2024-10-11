<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
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
        Dim Animation1 As Guna.UI2.AnimatorNS.Animation = New Guna.UI2.AnimatorNS.Animation()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMain))
        Me.Guna2Transition1 = New Guna.UI2.WinForms.Guna2Transition()
        Me.pnlMenu = New System.Windows.Forms.Panel()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btnBusinessTrade = New Guna.UI2.WinForms.Guna2Button()
        Me.btnClearance = New Guna.UI2.WinForms.Guna2Button()
        Me.btnResidency = New Guna.UI2.WinForms.Guna2Button()
        Me.btnIndigency = New Guna.UI2.WinForms.Guna2Button()
        Me.btnAbout = New Guna.UI2.WinForms.Guna2Button()
        Me.btnSettings = New Guna.UI2.WinForms.Guna2Button()
        Me.btnHistory = New Guna.UI2.WinForms.Guna2Button()
        Me.btnBlotterReport = New Guna.UI2.WinForms.Guna2Button()
        Me.btnResidents = New Guna.UI2.WinForms.Guna2Button()
        Me.btnHome = New Guna.UI2.WinForms.Guna2Button()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.btnOut = New Guna.UI2.WinForms.Guna2Button()
        Me.btnAddUser = New Guna.UI2.WinForms.Guna2Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnUser = New Guna.UI2.WinForms.Guna2Button()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.TblUserAccountsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DbBrgySystemDataSet = New BarangaySystem.dbBrgySystemDataSet()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.picBrgyLogo = New Guna.UI2.WinForms.Guna2PictureBox()
        Me.pnlCenter = New System.Windows.Forms.Panel()
        Me.pnlTop = New Guna.UI2.WinForms.Guna2ShadowPanel()
        Me.TblUserAccountsTableAdapter = New BarangaySystem.dbBrgySystemDataSetTableAdapters.tblUserAccountsTableAdapter()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.pnlMenu.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.TblUserAccountsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DbBrgySystemDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picBrgyLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Guna2Transition1
        '
        Me.Guna2Transition1.Cursor = Nothing
        Animation1.AnimateOnlyDifferences = True
        Animation1.BlindCoeff = CType(resources.GetObject("Animation1.BlindCoeff"), System.Drawing.PointF)
        Animation1.LeafCoeff = 0.0!
        Animation1.MaxTime = 1.0!
        Animation1.MinTime = 0.0!
        Animation1.MosaicCoeff = CType(resources.GetObject("Animation1.MosaicCoeff"), System.Drawing.PointF)
        Animation1.MosaicShift = CType(resources.GetObject("Animation1.MosaicShift"), System.Drawing.PointF)
        Animation1.MosaicSize = 0
        Animation1.Padding = New System.Windows.Forms.Padding(0)
        Animation1.RotateCoeff = 0.0!
        Animation1.RotateLimit = 0.0!
        Animation1.ScaleCoeff = CType(resources.GetObject("Animation1.ScaleCoeff"), System.Drawing.PointF)
        Animation1.SlideCoeff = CType(resources.GetObject("Animation1.SlideCoeff"), System.Drawing.PointF)
        Animation1.TimeCoeff = 0.0!
        Animation1.TransparencyCoeff = 0.0!
        Me.Guna2Transition1.DefaultAnimation = Animation1
        '
        'pnlMenu
        '
        Me.pnlMenu.AutoScroll = True
        Me.pnlMenu.BackColor = System.Drawing.SystemColors.Control
        Me.pnlMenu.Controls.Add(Me.btnBusinessTrade)
        Me.pnlMenu.Controls.Add(Me.btnClearance)
        Me.pnlMenu.Controls.Add(Me.btnResidency)
        Me.pnlMenu.Controls.Add(Me.btnIndigency)
        Me.pnlMenu.Controls.Add(Me.btnAbout)
        Me.pnlMenu.Controls.Add(Me.btnSettings)
        Me.pnlMenu.Controls.Add(Me.btnHistory)
        Me.pnlMenu.Controls.Add(Me.btnBlotterReport)
        Me.pnlMenu.Controls.Add(Me.btnResidents)
        Me.pnlMenu.Controls.Add(Me.btnHome)
        Me.pnlMenu.Controls.Add(Me.Panel3)
        Me.pnlMenu.Controls.Add(Me.Panel2)
        Me.pnlMenu.Controls.Add(Me.Panel1)
        Me.pnlMenu.Controls.Add(Me.picBrgyLogo)
        Me.pnlMenu.Controls.Add(Me.TextBox4)
        Me.pnlMenu.Controls.Add(Me.TextBox3)
        Me.pnlMenu.Controls.Add(Me.TextBox2)
        Me.pnlMenu.Controls.Add(Me.TextBox1)
        Me.pnlMenu.Controls.Add(Me.Label6)
        Me.pnlMenu.Controls.Add(Me.Label5)
        Me.pnlMenu.Controls.Add(Me.Label4)
        Me.pnlMenu.Controls.Add(Me.Label3)
        Me.pnlMenu.Controls.Add(Me.Label2)
        Me.pnlMenu.Controls.Add(Me.Label1)
        Me.Guna2Transition1.SetDecoration(Me.pnlMenu, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.pnlMenu.Dock = System.Windows.Forms.DockStyle.Left
        Me.pnlMenu.Location = New System.Drawing.Point(0, 14)
        Me.pnlMenu.Name = "pnlMenu"
        Me.pnlMenu.Size = New System.Drawing.Size(235, 735)
        Me.pnlMenu.TabIndex = 3
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Guna2Transition1.SetDecoration(Me.Label6, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.Label6.Location = New System.Drawing.Point(12, 91)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(39, 13)
        Me.Label6.TabIndex = 71
        Me.Label6.Text = "Label1"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Guna2Transition1.SetDecoration(Me.Label5, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.Label5.Location = New System.Drawing.Point(24, 78)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(39, 13)
        Me.Label5.TabIndex = 70
        Me.Label5.Text = "Label1"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Guna2Transition1.SetDecoration(Me.Label4, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.Label4.Location = New System.Drawing.Point(24, 64)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(39, 13)
        Me.Label4.TabIndex = 69
        Me.Label4.Text = "Label1"
        '
        'btnBusinessTrade
        '
        Me.btnBusinessTrade.Animated = True
        Me.btnBusinessTrade.AnimatedGIF = True
        Me.btnBusinessTrade.BorderRadius = 20
        Me.btnBusinessTrade.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Guna2Transition1.SetDecoration(Me.btnBusinessTrade, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.btnBusinessTrade.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnBusinessTrade.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnBusinessTrade.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnBusinessTrade.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnBusinessTrade.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnBusinessTrade.FillColor = System.Drawing.SystemColors.Control
        Me.btnBusinessTrade.Font = New System.Drawing.Font("Trebuchet MS", 12.75!)
        Me.btnBusinessTrade.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnBusinessTrade.HoverState.FillColor = System.Drawing.Color.Khaki
        Me.btnBusinessTrade.Image = Global.BarangaySystem.My.Resources.Resources.documents
        Me.btnBusinessTrade.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.btnBusinessTrade.ImageOffset = New System.Drawing.Point(10, 0)
        Me.btnBusinessTrade.Location = New System.Drawing.Point(0, 747)
        Me.btnBusinessTrade.Name = "btnBusinessTrade"
        Me.btnBusinessTrade.PressedColor = System.Drawing.Color.DarkGoldenrod
        Me.btnBusinessTrade.PressedDepth = 100
        Me.btnBusinessTrade.Size = New System.Drawing.Size(218, 57)
        Me.btnBusinessTrade.TabIndex = 59
        Me.btnBusinessTrade.Text = "Cert. of Community Service"
        Me.btnBusinessTrade.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.btnBusinessTrade.TextOffset = New System.Drawing.Point(20, 0)
        Me.btnBusinessTrade.Visible = False
        '
        'btnClearance
        '
        Me.btnClearance.Animated = True
        Me.btnClearance.AnimatedGIF = True
        Me.btnClearance.BorderRadius = 20
        Me.btnClearance.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Guna2Transition1.SetDecoration(Me.btnClearance, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.btnClearance.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnClearance.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnClearance.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnClearance.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnClearance.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnClearance.FillColor = System.Drawing.SystemColors.Control
        Me.btnClearance.Font = New System.Drawing.Font("Trebuchet MS", 12.75!)
        Me.btnClearance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnClearance.HoverState.FillColor = System.Drawing.Color.Khaki
        Me.btnClearance.Image = Global.BarangaySystem.My.Resources.Resources.documents
        Me.btnClearance.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.btnClearance.ImageOffset = New System.Drawing.Point(10, 0)
        Me.btnClearance.Location = New System.Drawing.Point(0, 702)
        Me.btnClearance.Name = "btnClearance"
        Me.btnClearance.PressedColor = System.Drawing.Color.DarkGoldenrod
        Me.btnClearance.PressedDepth = 100
        Me.btnClearance.Size = New System.Drawing.Size(218, 45)
        Me.btnClearance.TabIndex = 9
        Me.btnClearance.Text = "Brgy. Clearance"
        Me.btnClearance.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.btnClearance.TextOffset = New System.Drawing.Point(20, 0)
        Me.btnClearance.Visible = False
        '
        'btnResidency
        '
        Me.btnResidency.Animated = True
        Me.btnResidency.AnimatedGIF = True
        Me.btnResidency.BorderRadius = 20
        Me.btnResidency.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Guna2Transition1.SetDecoration(Me.btnResidency, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.btnResidency.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnResidency.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnResidency.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnResidency.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnResidency.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnResidency.FillColor = System.Drawing.SystemColors.Control
        Me.btnResidency.Font = New System.Drawing.Font("Trebuchet MS", 12.75!)
        Me.btnResidency.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnResidency.HoverState.FillColor = System.Drawing.Color.Khaki
        Me.btnResidency.Image = Global.BarangaySystem.My.Resources.Resources.documents
        Me.btnResidency.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.btnResidency.ImageOffset = New System.Drawing.Point(10, 0)
        Me.btnResidency.Location = New System.Drawing.Point(0, 657)
        Me.btnResidency.Name = "btnResidency"
        Me.btnResidency.PressedColor = System.Drawing.Color.DarkGoldenrod
        Me.btnResidency.PressedDepth = 100
        Me.btnResidency.Size = New System.Drawing.Size(218, 45)
        Me.btnResidency.TabIndex = 8
        Me.btnResidency.Text = "Cert. of Residency"
        Me.btnResidency.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.btnResidency.TextOffset = New System.Drawing.Point(20, 0)
        Me.btnResidency.Visible = False
        '
        'btnIndigency
        '
        Me.btnIndigency.Animated = True
        Me.btnIndigency.AnimatedGIF = True
        Me.btnIndigency.BorderRadius = 20
        Me.btnIndigency.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Guna2Transition1.SetDecoration(Me.btnIndigency, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.btnIndigency.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnIndigency.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnIndigency.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnIndigency.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnIndigency.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnIndigency.FillColor = System.Drawing.SystemColors.Control
        Me.btnIndigency.Font = New System.Drawing.Font("Trebuchet MS", 12.75!)
        Me.btnIndigency.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnIndigency.HoverState.FillColor = System.Drawing.Color.Khaki
        Me.btnIndigency.Image = Global.BarangaySystem.My.Resources.Resources.documents
        Me.btnIndigency.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.btnIndigency.ImageOffset = New System.Drawing.Point(10, 0)
        Me.btnIndigency.Location = New System.Drawing.Point(0, 612)
        Me.btnIndigency.Name = "btnIndigency"
        Me.btnIndigency.PressedColor = System.Drawing.Color.DarkGoldenrod
        Me.btnIndigency.PressedDepth = 100
        Me.btnIndigency.Size = New System.Drawing.Size(218, 45)
        Me.btnIndigency.TabIndex = 7
        Me.btnIndigency.Text = "Cert. of Indigency"
        Me.btnIndigency.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.btnIndigency.TextOffset = New System.Drawing.Point(20, 0)
        Me.btnIndigency.Visible = False
        '
        'btnAbout
        '
        Me.btnAbout.Animated = True
        Me.btnAbout.AnimatedGIF = True
        Me.btnAbout.BorderRadius = 20
        Me.btnAbout.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Guna2Transition1.SetDecoration(Me.btnAbout, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.btnAbout.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnAbout.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnAbout.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnAbout.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnAbout.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnAbout.FillColor = System.Drawing.SystemColors.Control
        Me.btnAbout.Font = New System.Drawing.Font("Trebuchet MS", 12.75!)
        Me.btnAbout.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnAbout.HoverState.FillColor = System.Drawing.Color.Khaki
        Me.btnAbout.Image = Global.BarangaySystem.My.Resources.Resources.iconAbout
        Me.btnAbout.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.btnAbout.ImageOffset = New System.Drawing.Point(10, 0)
        Me.btnAbout.Location = New System.Drawing.Point(0, 567)
        Me.btnAbout.Name = "btnAbout"
        Me.btnAbout.PressedColor = System.Drawing.Color.DarkGoldenrod
        Me.btnAbout.PressedDepth = 100
        Me.btnAbout.Size = New System.Drawing.Size(218, 45)
        Me.btnAbout.TabIndex = 6
        Me.btnAbout.Text = "About"
        Me.btnAbout.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.btnAbout.TextOffset = New System.Drawing.Point(20, 0)
        '
        'btnSettings
        '
        Me.btnSettings.Animated = True
        Me.btnSettings.AnimatedGIF = True
        Me.btnSettings.BorderRadius = 20
        Me.btnSettings.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Guna2Transition1.SetDecoration(Me.btnSettings, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.btnSettings.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnSettings.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnSettings.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnSettings.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnSettings.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnSettings.FillColor = System.Drawing.SystemColors.Control
        Me.btnSettings.Font = New System.Drawing.Font("Trebuchet MS", 12.75!)
        Me.btnSettings.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnSettings.HoverState.FillColor = System.Drawing.Color.Khaki
        Me.btnSettings.Image = Global.BarangaySystem.My.Resources.Resources.iconSettings
        Me.btnSettings.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.btnSettings.ImageOffset = New System.Drawing.Point(10, 0)
        Me.btnSettings.Location = New System.Drawing.Point(0, 522)
        Me.btnSettings.Name = "btnSettings"
        Me.btnSettings.PressedColor = System.Drawing.Color.DarkGoldenrod
        Me.btnSettings.PressedDepth = 100
        Me.btnSettings.Size = New System.Drawing.Size(218, 45)
        Me.btnSettings.TabIndex = 5
        Me.btnSettings.Text = "Settings"
        Me.btnSettings.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.btnSettings.TextOffset = New System.Drawing.Point(20, 0)
        '
        'btnHistory
        '
        Me.btnHistory.Animated = True
        Me.btnHistory.AnimatedGIF = True
        Me.btnHistory.BorderRadius = 20
        Me.btnHistory.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Guna2Transition1.SetDecoration(Me.btnHistory, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.btnHistory.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnHistory.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnHistory.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnHistory.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnHistory.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnHistory.FillColor = System.Drawing.SystemColors.Control
        Me.btnHistory.Font = New System.Drawing.Font("Trebuchet MS", 12.75!)
        Me.btnHistory.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnHistory.HoverState.FillColor = System.Drawing.Color.Khaki
        Me.btnHistory.Image = Global.BarangaySystem.My.Resources.Resources.history
        Me.btnHistory.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.btnHistory.ImageOffset = New System.Drawing.Point(10, 0)
        Me.btnHistory.Location = New System.Drawing.Point(0, 477)
        Me.btnHistory.Name = "btnHistory"
        Me.btnHistory.PressedColor = System.Drawing.Color.DarkGoldenrod
        Me.btnHistory.PressedDepth = 100
        Me.btnHistory.Size = New System.Drawing.Size(218, 45)
        Me.btnHistory.TabIndex = 4
        Me.btnHistory.Text = "History"
        Me.btnHistory.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.btnHistory.TextOffset = New System.Drawing.Point(20, 0)
        '
        'btnBlotterReport
        '
        Me.btnBlotterReport.Animated = True
        Me.btnBlotterReport.AnimatedGIF = True
        Me.btnBlotterReport.BorderRadius = 20
        Me.btnBlotterReport.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Guna2Transition1.SetDecoration(Me.btnBlotterReport, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.btnBlotterReport.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnBlotterReport.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnBlotterReport.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnBlotterReport.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnBlotterReport.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnBlotterReport.FillColor = System.Drawing.SystemColors.Control
        Me.btnBlotterReport.Font = New System.Drawing.Font("Trebuchet MS", 12.75!)
        Me.btnBlotterReport.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnBlotterReport.HoverState.FillColor = System.Drawing.Color.Khaki
        Me.btnBlotterReport.Image = Global.BarangaySystem.My.Resources.Resources.iconBltrRpt
        Me.btnBlotterReport.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.btnBlotterReport.ImageOffset = New System.Drawing.Point(10, 0)
        Me.btnBlotterReport.Location = New System.Drawing.Point(0, 432)
        Me.btnBlotterReport.Name = "btnBlotterReport"
        Me.btnBlotterReport.PressedColor = System.Drawing.Color.DarkGoldenrod
        Me.btnBlotterReport.PressedDepth = 100
        Me.btnBlotterReport.Size = New System.Drawing.Size(218, 45)
        Me.btnBlotterReport.TabIndex = 3
        Me.btnBlotterReport.Text = "Blotter Report"
        Me.btnBlotterReport.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.btnBlotterReport.TextOffset = New System.Drawing.Point(20, 0)
        '
        'btnResidents
        '
        Me.btnResidents.Animated = True
        Me.btnResidents.AnimatedGIF = True
        Me.btnResidents.BorderRadius = 20
        Me.btnResidents.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Guna2Transition1.SetDecoration(Me.btnResidents, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.btnResidents.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnResidents.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnResidents.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnResidents.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnResidents.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnResidents.FillColor = System.Drawing.SystemColors.Control
        Me.btnResidents.Font = New System.Drawing.Font("Trebuchet MS", 12.75!)
        Me.btnResidents.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnResidents.HoverState.FillColor = System.Drawing.Color.Khaki
        Me.btnResidents.Image = Global.BarangaySystem.My.Resources.Resources.iconResidents
        Me.btnResidents.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.btnResidents.ImageOffset = New System.Drawing.Point(10, 0)
        Me.btnResidents.Location = New System.Drawing.Point(0, 387)
        Me.btnResidents.Name = "btnResidents"
        Me.btnResidents.PressedColor = System.Drawing.Color.DarkGoldenrod
        Me.btnResidents.PressedDepth = 100
        Me.btnResidents.Size = New System.Drawing.Size(218, 45)
        Me.btnResidents.TabIndex = 2
        Me.btnResidents.Text = "Residents"
        Me.btnResidents.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.btnResidents.TextOffset = New System.Drawing.Point(20, 0)
        '
        'btnHome
        '
        Me.btnHome.Animated = True
        Me.btnHome.AnimatedGIF = True
        Me.btnHome.BorderRadius = 20
        Me.btnHome.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Guna2Transition1.SetDecoration(Me.btnHome, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.btnHome.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnHome.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnHome.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnHome.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnHome.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnHome.FillColor = System.Drawing.SystemColors.Control
        Me.btnHome.Font = New System.Drawing.Font("Trebuchet MS", 12.75!)
        Me.btnHome.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnHome.HoverState.FillColor = System.Drawing.Color.Khaki
        Me.btnHome.Image = Global.BarangaySystem.My.Resources.Resources.iconHome
        Me.btnHome.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.btnHome.ImageOffset = New System.Drawing.Point(10, 0)
        Me.btnHome.Location = New System.Drawing.Point(0, 342)
        Me.btnHome.Name = "btnHome"
        Me.btnHome.PressedColor = System.Drawing.Color.DarkGoldenrod
        Me.btnHome.PressedDepth = 100
        Me.btnHome.Size = New System.Drawing.Size(218, 45)
        Me.btnHome.TabIndex = 1
        Me.btnHome.Text = "Home"
        Me.btnHome.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.btnHome.TextOffset = New System.Drawing.Point(20, 0)
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Guna2Transition1.SetDecoration(Me.Panel3, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel3.Location = New System.Drawing.Point(0, 341)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(218, 1)
        Me.Panel3.TabIndex = 65
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Panel2.Controls.Add(Me.btnOut)
        Me.Panel2.Controls.Add(Me.btnAddUser)
        Me.Guna2Transition1.SetDecoration(Me.Panel2, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 281)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(218, 60)
        Me.Panel2.TabIndex = 64
        Me.Panel2.Visible = False
        '
        'btnOut
        '
        Me.btnOut.Animated = True
        Me.btnOut.AnimatedGIF = True
        Me.btnOut.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Guna2Transition1.SetDecoration(Me.btnOut, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.btnOut.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnOut.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnOut.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnOut.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnOut.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnOut.FillColor = System.Drawing.SystemColors.ControlLight
        Me.btnOut.Font = New System.Drawing.Font("Trebuchet MS", 12.75!)
        Me.btnOut.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnOut.HoverState.FillColor = System.Drawing.Color.LightCoral
        Me.btnOut.Image = Global.BarangaySystem.My.Resources.Resources.iconLogout
        Me.btnOut.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.btnOut.ImageOffset = New System.Drawing.Point(45, 0)
        Me.btnOut.Location = New System.Drawing.Point(0, 30)
        Me.btnOut.Name = "btnOut"
        Me.btnOut.PressedColor = System.Drawing.Color.Firebrick
        Me.btnOut.PressedDepth = 100
        Me.btnOut.Size = New System.Drawing.Size(218, 30)
        Me.btnOut.TabIndex = 65
        Me.btnOut.Text = "Logout"
        Me.btnOut.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.btnOut.TextOffset = New System.Drawing.Point(45, 0)
        '
        'btnAddUser
        '
        Me.btnAddUser.Animated = True
        Me.btnAddUser.AnimatedGIF = True
        Me.btnAddUser.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Guna2Transition1.SetDecoration(Me.btnAddUser, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.btnAddUser.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnAddUser.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnAddUser.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnAddUser.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnAddUser.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnAddUser.FillColor = System.Drawing.SystemColors.ControlLight
        Me.btnAddUser.Font = New System.Drawing.Font("Trebuchet MS", 12.75!)
        Me.btnAddUser.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnAddUser.HoverState.FillColor = System.Drawing.Color.MediumSeaGreen
        Me.btnAddUser.Image = Global.BarangaySystem.My.Resources.Resources.iconAddUser
        Me.btnAddUser.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.btnAddUser.ImageOffset = New System.Drawing.Point(45, 0)
        Me.btnAddUser.Location = New System.Drawing.Point(0, 0)
        Me.btnAddUser.Name = "btnAddUser"
        Me.btnAddUser.PressedColor = System.Drawing.Color.SeaGreen
        Me.btnAddUser.PressedDepth = 100
        Me.btnAddUser.Size = New System.Drawing.Size(218, 30)
        Me.btnAddUser.TabIndex = 64
        Me.btnAddUser.Text = "Add User"
        Me.btnAddUser.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.btnAddUser.TextOffset = New System.Drawing.Point(45, 0)
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Panel1.Controls.Add(Me.btnUser)
        Me.Guna2Transition1.SetDecoration(Me.Panel1, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 221)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(218, 60)
        Me.Panel1.TabIndex = 63
        '
        'btnUser
        '
        Me.btnUser.Animated = True
        Me.btnUser.AnimatedGIF = True
        Me.btnUser.BackColor = System.Drawing.Color.DarkGoldenrod
        Me.btnUser.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Guna2Transition1.SetDecoration(Me.btnUser, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.btnUser.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnUser.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnUser.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnUser.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnUser.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnUser.FillColor = System.Drawing.SystemColors.ControlLight
        Me.btnUser.Font = New System.Drawing.Font("Trebuchet MS", 12.75!)
        Me.btnUser.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnUser.HoverState.FillColor = System.Drawing.Color.Khaki
        Me.btnUser.Image = Global.BarangaySystem.My.Resources.Resources.icon_more
        Me.btnUser.ImageAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.btnUser.ImageOffset = New System.Drawing.Point(10, 0)
        Me.btnUser.Location = New System.Drawing.Point(0, 0)
        Me.btnUser.Name = "btnUser"
        Me.btnUser.PressedColor = System.Drawing.Color.Khaki
        Me.btnUser.PressedDepth = 100
        Me.btnUser.Size = New System.Drawing.Size(218, 60)
        Me.btnUser.TabIndex = 0
        Me.btnUser.Text = "username"
        '
        'TextBox4
        '
        Me.TextBox4.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblUserAccountsBindingSource, "userType", True))
        Me.Guna2Transition1.SetDecoration(Me.TextBox4, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.TextBox4.Enabled = False
        Me.TextBox4.Location = New System.Drawing.Point(163, 94)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(39, 20)
        Me.TextBox4.TabIndex = 68
        '
        'TblUserAccountsBindingSource
        '
        Me.TblUserAccountsBindingSource.DataMember = "tblUserAccounts"
        Me.TblUserAccountsBindingSource.DataSource = Me.DbBrgySystemDataSet
        '
        'DbBrgySystemDataSet
        '
        Me.DbBrgySystemDataSet.DataSetName = "dbBrgySystemDataSet"
        Me.DbBrgySystemDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TextBox3
        '
        Me.Guna2Transition1.SetDecoration(Me.TextBox3, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.TextBox3.Enabled = False
        Me.TextBox3.Location = New System.Drawing.Point(118, 94)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(39, 20)
        Me.TextBox3.TabIndex = 67
        '
        'TextBox2
        '
        Me.Guna2Transition1.SetDecoration(Me.TextBox2, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.TextBox2.Enabled = False
        Me.TextBox2.Location = New System.Drawing.Point(80, 94)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(32, 20)
        Me.TextBox2.TabIndex = 60
        '
        'TextBox1
        '
        Me.Guna2Transition1.SetDecoration(Me.TextBox1, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.TextBox1.Enabled = False
        Me.TextBox1.Location = New System.Drawing.Point(37, 94)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(37, 20)
        Me.TextBox1.TabIndex = 60
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Guna2Transition1.SetDecoration(Me.Label3, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.Label3.Location = New System.Drawing.Point(80, 94)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(39, 13)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Label1"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Guna2Transition1.SetDecoration(Me.Label2, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.Label2.Location = New System.Drawing.Point(77, 78)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(39, 13)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Label1"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Guna2Transition1.SetDecoration(Me.Label1, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.Label1.Location = New System.Drawing.Point(77, 64)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(39, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Label1"
        '
        'picBrgyLogo
        '
        Me.picBrgyLogo.BackColor = System.Drawing.Color.Transparent
        Me.Guna2Transition1.SetDecoration(Me.picBrgyLogo, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.picBrgyLogo.Dock = System.Windows.Forms.DockStyle.Top
        Me.picBrgyLogo.FillColor = System.Drawing.Color.Maroon
        Me.picBrgyLogo.Image = Global.BarangaySystem.My.Resources.Resources.iconBrgyPic
        Me.picBrgyLogo.ImageRotate = 0.0!
        Me.picBrgyLogo.Location = New System.Drawing.Point(0, 0)
        Me.picBrgyLogo.Name = "picBrgyLogo"
        Me.picBrgyLogo.Size = New System.Drawing.Size(218, 221)
        Me.picBrgyLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picBrgyLogo.TabIndex = 39
        Me.picBrgyLogo.TabStop = False
        Me.picBrgyLogo.UseTransparentBackground = True
        '
        'pnlCenter
        '
        Me.pnlCenter.BackColor = System.Drawing.Color.Khaki
        Me.Guna2Transition1.SetDecoration(Me.pnlCenter, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.pnlCenter.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlCenter.Location = New System.Drawing.Point(235, 14)
        Me.pnlCenter.Name = "pnlCenter"
        Me.pnlCenter.Size = New System.Drawing.Size(1135, 735)
        Me.pnlCenter.TabIndex = 0
        '
        'pnlTop
        '
        Me.pnlTop.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Guna2Transition1.SetDecoration(Me.pnlTop, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.pnlTop.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlTop.FillColor = System.Drawing.Color.Goldenrod
        Me.pnlTop.Location = New System.Drawing.Point(0, 0)
        Me.pnlTop.Name = "pnlTop"
        Me.pnlTop.ShadowColor = System.Drawing.Color.Black
        Me.pnlTop.ShadowShift = 3
        Me.pnlTop.ShadowStyle = Guna.UI2.WinForms.Guna2ShadowPanel.ShadowMode.Dropped
        Me.pnlTop.Size = New System.Drawing.Size(1370, 14)
        Me.pnlTop.TabIndex = 1
        '
        'TblUserAccountsTableAdapter
        '
        Me.TblUserAccountsTableAdapter.ClearBeforeFill = True
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 1000
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1370, 749)
        Me.Controls.Add(Me.pnlCenter)
        Me.Controls.Add(Me.pnlMenu)
        Me.Controls.Add(Me.pnlTop)
        Me.Guna2Transition1.SetDecoration(Me, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.MaximumSize = New System.Drawing.Size(1386, 788)
        Me.MinimumSize = New System.Drawing.Size(693, 726)
        Me.Name = "frmMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Barangay System - Pili, Pinamalayan, Oriental Mindoro"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.pnlMenu.ResumeLayout(False)
        Me.pnlMenu.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        CType(Me.TblUserAccountsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DbBrgySystemDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picBrgyLogo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Guna2Transition1 As Guna.UI2.WinForms.Guna2Transition
    Friend WithEvents pnlMenu As System.Windows.Forms.Panel
    Friend WithEvents btnHome As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents picBrgyLogo As Guna.UI2.WinForms.Guna2PictureBox
    Friend WithEvents pnlCenter As System.Windows.Forms.Panel
    Friend WithEvents pnlTop As Guna.UI2.WinForms.Guna2ShadowPanel
    Friend WithEvents btnHistory As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnBlotterReport As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnResidents As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnSettings As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnBusinessTrade As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnClearance As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnResidency As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnIndigency As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents btnUser As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnAddUser As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents btnAbout As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox3 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox4 As System.Windows.Forms.TextBox
    Friend WithEvents DbBrgySystemDataSet As BarangaySystem.dbBrgySystemDataSet
    Friend WithEvents TblUserAccountsBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TblUserAccountsTableAdapter As BarangaySystem.dbBrgySystemDataSetTableAdapters.tblUserAccountsTableAdapter
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents btnOut As Guna.UI2.WinForms.Guna2Button


End Class
