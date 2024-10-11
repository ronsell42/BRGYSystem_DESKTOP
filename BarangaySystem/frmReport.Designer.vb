<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmReport
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
        Dim FirstNameLabel As System.Windows.Forms.Label
        Dim ToLabel As System.Windows.Forms.Label
        Dim FirstParagraphLabel As System.Windows.Forms.Label
        Me.Guna2Panel2 = New Guna.UI2.WinForms.Guna2Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.Guna2Button1 = New Guna.UI2.WinForms.Guna2Button()
        Me.btnBack = New Guna.UI2.WinForms.Guna2Button()
        Me.CrystalReportViewer1 = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.NameTextBox = New System.Windows.Forms.TextBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.lblCurrentFrm = New System.Windows.Forms.Label()
        Me.ToTextBox = New System.Windows.Forms.TextBox()
        Me.TblPrintIndigencyBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DbBrgySystemDataSet = New BarangaySystem.dbBrgySystemDataSet()
        Me.FirstParagraphTextBox = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Guna2Elipse3 = New Guna.UI2.WinForms.Guna2Elipse(Me.components)
        Me.Guna2Elipse1 = New Guna.UI2.WinForms.Guna2Elipse(Me.components)
        Me.Guna2Elipse2 = New Guna.UI2.WinForms.Guna2Elipse(Me.components)
        Me.Panel7 = New System.Windows.Forms.Panel()
        Me.rptIndigency1 = New BarangaySystem.rptIndigency()
        Me.TblResidentsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TblResidentsTableAdapter = New BarangaySystem.dbBrgySystemDataSetTableAdapters.tblResidentsTableAdapter()
        Me.TableAdapterManager = New BarangaySystem.dbBrgySystemDataSetTableAdapters.TableAdapterManager()
        Me.TblIncrementsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TblIncrementsTableAdapter = New BarangaySystem.dbBrgySystemDataSetTableAdapters.tblIncrementsTableAdapter()
        Me.TblPrintIndigencyTableAdapter = New BarangaySystem.dbBrgySystemDataSetTableAdapters.tblPrintIndigencyTableAdapter()
        Me.PrintDialog1 = New System.Windows.Forms.PrintDialog()
        FirstNameLabel = New System.Windows.Forms.Label()
        ToLabel = New System.Windows.Forms.Label()
        FirstParagraphLabel = New System.Windows.Forms.Label()
        Me.Guna2Panel2.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.TblPrintIndigencyBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DbBrgySystemDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblResidentsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblIncrementsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'FirstNameLabel
        '
        FirstNameLabel.AutoSize = True
        FirstNameLabel.Location = New System.Drawing.Point(333, 28)
        FirstNameLabel.Name = "FirstNameLabel"
        FirstNameLabel.Size = New System.Drawing.Size(38, 13)
        FirstNameLabel.TabIndex = 10384
        FirstNameLabel.Text = "Name:"
        '
        'ToLabel
        '
        ToLabel.AutoSize = True
        ToLabel.Location = New System.Drawing.Point(55, 38)
        ToLabel.Name = "ToLabel"
        ToLabel.Size = New System.Drawing.Size(19, 13)
        ToLabel.TabIndex = 10385
        ToLabel.Text = "to:"
        '
        'FirstParagraphLabel
        '
        FirstParagraphLabel.AutoSize = True
        FirstParagraphLabel.Location = New System.Drawing.Point(100, 40)
        FirstParagraphLabel.Name = "FirstParagraphLabel"
        FirstParagraphLabel.Size = New System.Drawing.Size(78, 13)
        FirstParagraphLabel.TabIndex = 10386
        FirstParagraphLabel.Text = "first Paragraph:"
        '
        'Guna2Panel2
        '
        Me.Guna2Panel2.AutoRoundedCorners = True
        Me.Guna2Panel2.BackColor = System.Drawing.Color.White
        Me.Guna2Panel2.BorderRadius = 315
        Me.Guna2Panel2.Controls.Add(Me.Panel6)
        Me.Guna2Panel2.Controls.Add(Me.Guna2Button1)
        Me.Guna2Panel2.Controls.Add(Me.btnBack)
        Me.Guna2Panel2.Controls.Add(Me.CrystalReportViewer1)
        Me.Guna2Panel2.Location = New System.Drawing.Point(0, 69)
        Me.Guna2Panel2.Name = "Guna2Panel2"
        Me.Guna2Panel2.Size = New System.Drawing.Size(1113, 633)
        Me.Guna2Panel2.TabIndex = 11
        '
        'Panel3
        '
        Me.Panel3.Location = New System.Drawing.Point(416, 21)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(425, 29)
        Me.Panel3.TabIndex = 10387
        '
        'Panel6
        '
        Me.Panel6.BackColor = System.Drawing.Color.DarkGoldenrod
        Me.Panel6.Location = New System.Drawing.Point(12, 601)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(1088, 32)
        Me.Panel6.TabIndex = 10382
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
        Me.Guna2Button1.Enabled = False
        Me.Guna2Button1.FillColor = System.Drawing.Color.Goldenrod
        Me.Guna2Button1.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Bold)
        Me.Guna2Button1.ForeColor = System.Drawing.Color.White
        Me.Guna2Button1.Image = Global.BarangaySystem.My.Resources.Resources.icon_BackWhite
        Me.Guna2Button1.Location = New System.Drawing.Point(12, 63)
        Me.Guna2Button1.Name = "Guna2Button1"
        Me.Guna2Button1.Size = New System.Drawing.Size(105, 45)
        Me.Guna2Button1.TabIndex = 1
        Me.Guna2Button1.Text = "Print"
        '
        'btnBack
        '
        Me.btnBack.Animated = True
        Me.btnBack.AnimatedGIF = True
        Me.btnBack.BorderRadius = 10
        Me.btnBack.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnBack.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnBack.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnBack.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnBack.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnBack.FillColor = System.Drawing.Color.Goldenrod
        Me.btnBack.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Bold)
        Me.btnBack.ForeColor = System.Drawing.Color.White
        Me.btnBack.Image = Global.BarangaySystem.My.Resources.Resources.icon_BackWhite
        Me.btnBack.Location = New System.Drawing.Point(12, 12)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(105, 45)
        Me.btnBack.TabIndex = 0
        Me.btnBack.Text = "Back"
        '
        'CrystalReportViewer1
        '
        Me.CrystalReportViewer1.ActiveViewIndex = -1
        Me.CrystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CrystalReportViewer1.Cursor = System.Windows.Forms.Cursors.Default
        Me.CrystalReportViewer1.DisplayToolbar = False
        Me.CrystalReportViewer1.InitialFocus = CrystalDecisions.Windows.Forms.UIComponent.ToolBar
        Me.CrystalReportViewer1.Location = New System.Drawing.Point(12, 8)
        Me.CrystalReportViewer1.Name = "CrystalReportViewer1"
        Me.CrystalReportViewer1.ShowCloseButton = False
        Me.CrystalReportViewer1.ShowCopyButton = False
        Me.CrystalReportViewer1.ShowExportButton = False
        Me.CrystalReportViewer1.ShowGotoPageButton = False
        Me.CrystalReportViewer1.ShowGroupTreeButton = False
        Me.CrystalReportViewer1.ShowLogo = False
        Me.CrystalReportViewer1.ShowPageNavigateButtons = False
        Me.CrystalReportViewer1.ShowParameterPanelButton = False
        Me.CrystalReportViewer1.Size = New System.Drawing.Size(1088, 587)
        Me.CrystalReportViewer1.TabIndex = 10268
        Me.CrystalReportViewer1.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(556, 24)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(100, 20)
        Me.TextBox2.TabIndex = 10385
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(430, 21)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(100, 20)
        Me.TextBox1.TabIndex = 10385
        '
        'NameTextBox
        '
        Me.NameTextBox.Enabled = False
        Me.NameTextBox.Location = New System.Drawing.Point(396, 25)
        Me.NameTextBox.Name = "NameTextBox"
        Me.NameTextBox.Size = New System.Drawing.Size(140, 20)
        Me.NameTextBox.TabIndex = 10386
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Controls.Add(Me.DateTimePicker1)
        Me.Panel1.Controls.Add(Me.lblCurrentFrm)
        Me.Panel1.Controls.Add(Me.NameTextBox)
        Me.Panel1.Controls.Add(Me.ToTextBox)
        Me.Panel1.Controls.Add(ToLabel)
        Me.Panel1.Controls.Add(FirstParagraphLabel)
        Me.Panel1.Controls.Add(Me.FirstParagraphTextBox)
        Me.Panel1.Controls.Add(FirstNameLabel)
        Me.Panel1.Controls.Add(Me.TextBox1)
        Me.Panel1.Controls.Add(Me.TextBox2)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.Panel3)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1128, 80)
        Me.Panel1.TabIndex = 10
        '
        'Panel2
        '
        Me.Panel2.Location = New System.Drawing.Point(21, 31)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(263, 29)
        Me.Panel2.TabIndex = 10385
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.CustomFormat = "MMMM dd, yyyy"
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateTimePicker1.Location = New System.Drawing.Point(21, 38)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(159, 20)
        Me.DateTimePicker1.TabIndex = 10384
        Me.DateTimePicker1.Value = New Date(2023, 4, 17, 0, 0, 0, 0)
        '
        'lblCurrentFrm
        '
        Me.lblCurrentFrm.AutoSize = True
        Me.lblCurrentFrm.Font = New System.Drawing.Font("Trebuchet MS", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCurrentFrm.Location = New System.Drawing.Point(312, 10)
        Me.lblCurrentFrm.Name = "lblCurrentFrm"
        Me.lblCurrentFrm.Size = New System.Drawing.Size(384, 40)
        Me.lblCurrentFrm.TabIndex = 4
        Me.lblCurrentFrm.Text = "Please Select A Document"
        '
        'ToTextBox
        '
        Me.ToTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblPrintIndigencyBindingSource, "to", True))
        Me.ToTextBox.Location = New System.Drawing.Point(80, 35)
        Me.ToTextBox.Name = "ToTextBox"
        Me.ToTextBox.Size = New System.Drawing.Size(100, 20)
        Me.ToTextBox.TabIndex = 10386
        '
        'TblPrintIndigencyBindingSource
        '
        Me.TblPrintIndigencyBindingSource.DataMember = "tblPrintIndigency"
        Me.TblPrintIndigencyBindingSource.DataSource = Me.DbBrgySystemDataSet
        '
        'DbBrgySystemDataSet
        '
        Me.DbBrgySystemDataSet.DataSetName = "dbBrgySystemDataSet"
        Me.DbBrgySystemDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'FirstParagraphTextBox
        '
        Me.FirstParagraphTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblPrintIndigencyBindingSource, "firstParagraph", True))
        Me.FirstParagraphTextBox.Location = New System.Drawing.Point(184, 37)
        Me.FirstParagraphTextBox.Name = "FirstParagraphTextBox"
        Me.FirstParagraphTextBox.Size = New System.Drawing.Size(100, 20)
        Me.FirstParagraphTextBox.TabIndex = 10387
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(626, 31)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(39, 13)
        Me.Label1.TabIndex = 10383
        Me.Label1.Text = "Label1"
        '
        'Guna2Elipse3
        '
        Me.Guna2Elipse3.BorderRadius = 30
        Me.Guna2Elipse3.TargetControl = Me.Guna2Panel2
        '
        'Guna2Elipse1
        '
        Me.Guna2Elipse1.BorderRadius = 30
        Me.Guna2Elipse1.TargetControl = Me.Panel1
        '
        'Guna2Elipse2
        '
        Me.Guna2Elipse2.BorderRadius = 30
        '
        'Panel7
        '
        Me.Panel7.BackColor = System.Drawing.Color.DarkGoldenrod
        Me.Panel7.Location = New System.Drawing.Point(3, 64)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(1124, 5)
        Me.Panel7.TabIndex = 10379
        '
        'TblResidentsBindingSource
        '
        Me.TblResidentsBindingSource.DataMember = "tblResidents"
        Me.TblResidentsBindingSource.DataSource = Me.DbBrgySystemDataSet
        '
        'TblResidentsTableAdapter
        '
        Me.TblResidentsTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.tblBlotterTableAdapter = Nothing
        Me.TableAdapterManager.tblDatabaseTableAdapter = Nothing
        Me.TableAdapterManager.tblHistoryTableAdapter = Nothing
        Me.TableAdapterManager.tblIncrementsTableAdapter = Nothing
        Me.TableAdapterManager.tblOrganizationTableAdapter = Nothing
        Me.TableAdapterManager.tblPrintIndigencyTableAdapter = Nothing
        Me.TableAdapterManager.tblResidentsTableAdapter = Me.TblResidentsTableAdapter
        Me.TableAdapterManager.tblSysSettingsTableAdapter = Nothing
        Me.TableAdapterManager.tblUserAccountsTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = BarangaySystem.dbBrgySystemDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'TblIncrementsBindingSource
        '
        Me.TblIncrementsBindingSource.DataSource = Me.DbBrgySystemDataSet
        Me.TblIncrementsBindingSource.Position = 0
        '
        'TblIncrementsTableAdapter
        '
        Me.TblIncrementsTableAdapter.ClearBeforeFill = True
        '
        'TblPrintIndigencyTableAdapter
        '
        Me.TblPrintIndigencyTableAdapter.ClearBeforeFill = True
        '
        'PrintDialog1
        '
        Me.PrintDialog1.UseEXDialog = True
        '
        'frmReport
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(1128, 702)
        Me.Controls.Add(Me.Panel7)
        Me.Controls.Add(Me.Guna2Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmReport"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmReport"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Guna2Panel2.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.TblPrintIndigencyBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DbBrgySystemDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblResidentsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblIncrementsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Guna2Panel2 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents lblCurrentFrm As System.Windows.Forms.Label
    Friend WithEvents Guna2Elipse3 As Guna.UI2.WinForms.Guna2Elipse
    Friend WithEvents Guna2Elipse1 As Guna.UI2.WinForms.Guna2Elipse
    Friend WithEvents Guna2Elipse2 As Guna.UI2.WinForms.Guna2Elipse
    Friend WithEvents btnBack As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents CrystalReportViewer1 As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents DbBrgySystemDataSet As BarangaySystem.dbBrgySystemDataSet
    Friend WithEvents TblResidentsBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TblResidentsTableAdapter As BarangaySystem.dbBrgySystemDataSetTableAdapters.tblResidentsTableAdapter
    Friend WithEvents TableAdapterManager As BarangaySystem.dbBrgySystemDataSetTableAdapters.TableAdapterManager
    Friend WithEvents Panel6 As System.Windows.Forms.Panel
    Friend WithEvents Panel7 As System.Windows.Forms.Panel
    Friend WithEvents Guna2Button1 As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents rptIndigency1 As BarangaySystem.rptIndigency
    Friend WithEvents NameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents TblIncrementsBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TblIncrementsTableAdapter As BarangaySystem.dbBrgySystemDataSetTableAdapters.tblIncrementsTableAdapter
    Friend WithEvents TblPrintIndigencyBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TblPrintIndigencyTableAdapter As BarangaySystem.dbBrgySystemDataSetTableAdapters.tblPrintIndigencyTableAdapter
    Friend WithEvents ToTextBox As System.Windows.Forms.TextBox
    Friend WithEvents PrintDialog1 As System.Windows.Forms.PrintDialog
    Friend WithEvents FirstParagraphTextBox As System.Windows.Forms.TextBox
End Class
