<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDBSett
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
        Dim Label2 As System.Windows.Forms.Label
        Dim Label3 As System.Windows.Forms.Label
        Dim BackupPathLabel As System.Windows.Forms.Label
        Dim RestorePathLabel As System.Windows.Forms.Label
        Me.Guna2Elipse1 = New Guna.UI2.WinForms.Guna2Elipse(Me.components)
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnUndo1 = New Guna.UI2.WinForms.Guna2Button()
        Me.btnChange = New Guna.UI2.WinForms.Guna2Button()
        Me.txtBoxBackupDir = New Guna.UI2.WinForms.Guna2TextBox()
        Me.bakcupText = New System.Windows.Forms.Label()
        Me.btnBackupNow = New Guna.UI2.WinForms.Guna2Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.BackupPathTextBox = New System.Windows.Forms.TextBox()
        Me.TblDatabaseBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DbBrgySystemDataSet = New BarangaySystem.dbBrgySystemDataSet()
        Me.Guna2Elipse2 = New Guna.UI2.WinForms.Guna2Elipse(Me.components)
        Me.Guna2Elipse3 = New Guna.UI2.WinForms.Guna2Elipse(Me.components)
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtBoxRestoreDir = New Guna.UI2.WinForms.Guna2TextBox()
        Me.btnBrowse = New Guna.UI2.WinForms.Guna2Button()
        Me.btnRestoreNow = New Guna.UI2.WinForms.Guna2Button()
        Me.RestorePathTextBox = New System.Windows.Forms.TextBox()
        Me.FolderBrowserDialog1 = New System.Windows.Forms.FolderBrowserDialog()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.Guna2Elipse4 = New Guna.UI2.WinForms.Guna2Elipse(Me.components)
        Me.ShapeContainer1 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.LineShape2 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.LineShape1 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.TblDatabaseTableAdapter = New BarangaySystem.dbBrgySystemDataSetTableAdapters.tblDatabaseTableAdapter()
        Me.TableAdapterManager = New BarangaySystem.dbBrgySystemDataSetTableAdapters.TableAdapterManager()
        Label2 = New System.Windows.Forms.Label()
        Label3 = New System.Windows.Forms.Label()
        BackupPathLabel = New System.Windows.Forms.Label()
        RestorePathLabel = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        CType(Me.TblDatabaseBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DbBrgySystemDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label2
        '
        Label2.AutoSize = True
        Label2.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label2.ForeColor = System.Drawing.Color.Black
        Label2.Location = New System.Drawing.Point(24, 70)
        Label2.Name = "Label2"
        Label2.Size = New System.Drawing.Size(141, 18)
        Label2.TabIndex = 1000000017
        Label2.Text = "Database Backup Path:"
        '
        'Label3
        '
        Label3.AutoSize = True
        Label3.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label3.ForeColor = System.Drawing.Color.Black
        Label3.Location = New System.Drawing.Point(24, 70)
        Label3.Name = "Label3"
        Label3.Size = New System.Drawing.Size(115, 18)
        Label3.TabIndex = 1000000024
        Label3.Text = "Restore Database:"
        '
        'BackupPathLabel
        '
        BackupPathLabel.AutoSize = True
        BackupPathLabel.Location = New System.Drawing.Point(120, 110)
        BackupPathLabel.Name = "BackupPathLabel"
        BackupPathLabel.Size = New System.Drawing.Size(71, 13)
        BackupPathLabel.TabIndex = 0
        BackupPathLabel.Text = "backup Path:"
        '
        'RestorePathLabel
        '
        RestorePathLabel.AutoSize = True
        RestorePathLabel.Location = New System.Drawing.Point(143, 104)
        RestorePathLabel.Name = "RestorePathLabel"
        RestorePathLabel.Size = New System.Drawing.Size(67, 13)
        RestorePathLabel.TabIndex = 2
        RestorePathLabel.Text = "restore Path:"
        '
        'Guna2Elipse1
        '
        Me.Guna2Elipse1.BorderRadius = 30
        Me.Guna2Elipse1.TargetControl = Me
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.Controls.Add(Me.btnUndo1)
        Me.Panel1.Controls.Add(Label2)
        Me.Panel1.Controls.Add(Me.btnChange)
        Me.Panel1.Controls.Add(Me.txtBoxBackupDir)
        Me.Panel1.Controls.Add(Me.bakcupText)
        Me.Panel1.Controls.Add(Me.btnBackupNow)
        Me.Panel1.Controls.Add(Me.Button2)
        Me.Panel1.Controls.Add(Me.Label9)
        Me.Panel1.Controls.Add(Me.Label8)
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(BackupPathLabel)
        Me.Panel1.Controls.Add(Me.BackupPathTextBox)
        Me.Panel1.Location = New System.Drawing.Point(0, 3)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(668, 176)
        Me.Panel1.TabIndex = 0
        '
        'btnUndo1
        '
        Me.btnUndo1.Animated = True
        Me.btnUndo1.AnimatedGIF = True
        Me.btnUndo1.BorderRadius = 10
        Me.btnUndo1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnUndo1.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnUndo1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnUndo1.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnUndo1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnUndo1.FillColor = System.Drawing.Color.Firebrick
        Me.btnUndo1.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Bold)
        Me.btnUndo1.ForeColor = System.Drawing.Color.White
        Me.btnUndo1.Image = Global.BarangaySystem.My.Resources.Resources.undo__1_
        Me.btnUndo1.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.btnUndo1.Location = New System.Drawing.Point(17, 140)
        Me.btnUndo1.Name = "btnUndo1"
        Me.btnUndo1.Size = New System.Drawing.Size(120, 31)
        Me.btnUndo1.TabIndex = 1000000012
        Me.btnUndo1.Text = "Undo Change"
        Me.btnUndo1.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.btnUndo1.TextOffset = New System.Drawing.Point(-5, 0)
        Me.btnUndo1.Visible = False
        '
        'btnChange
        '
        Me.btnChange.Animated = True
        Me.btnChange.AnimatedGIF = True
        Me.btnChange.BorderRadius = 10
        Me.btnChange.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnChange.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnChange.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnChange.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnChange.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnChange.FillColor = System.Drawing.Color.DodgerBlue
        Me.btnChange.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Bold)
        Me.btnChange.ForeColor = System.Drawing.Color.White
        Me.btnChange.Image = Global.BarangaySystem.My.Resources.Resources.edit
        Me.btnChange.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.btnChange.Location = New System.Drawing.Point(343, 92)
        Me.btnChange.Name = "btnChange"
        Me.btnChange.Size = New System.Drawing.Size(94, 45)
        Me.btnChange.TabIndex = 1000000013
        Me.btnChange.Text = "Change"
        Me.btnChange.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.btnChange.TextOffset = New System.Drawing.Point(-5, 0)
        '
        'txtBoxBackupDir
        '
        Me.txtBoxBackupDir.Animated = True
        Me.txtBoxBackupDir.BackColor = System.Drawing.Color.White
        Me.txtBoxBackupDir.BorderColor = System.Drawing.Color.Black
        Me.txtBoxBackupDir.BorderRadius = 10
        Me.txtBoxBackupDir.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtBoxBackupDir.DefaultText = ""
        Me.txtBoxBackupDir.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtBoxBackupDir.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtBoxBackupDir.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtBoxBackupDir.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtBoxBackupDir.FocusedState.BorderColor = System.Drawing.Color.Goldenrod
        Me.txtBoxBackupDir.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBoxBackupDir.ForeColor = System.Drawing.Color.Black
        Me.txtBoxBackupDir.HoverState.BorderColor = System.Drawing.Color.Goldenrod
        Me.txtBoxBackupDir.IconLeftOffset = New System.Drawing.Point(8, 0)
        Me.txtBoxBackupDir.Location = New System.Drawing.Point(17, 92)
        Me.txtBoxBackupDir.Margin = New System.Windows.Forms.Padding(4)
        Me.txtBoxBackupDir.Name = "txtBoxBackupDir"
        Me.txtBoxBackupDir.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtBoxBackupDir.PlaceholderForeColor = System.Drawing.Color.DimGray
        Me.txtBoxBackupDir.PlaceholderText = "Choose directory"
        Me.txtBoxBackupDir.SelectedText = ""
        Me.txtBoxBackupDir.Size = New System.Drawing.Size(318, 45)
        Me.txtBoxBackupDir.TabIndex = 1000000015
        Me.txtBoxBackupDir.TextOffset = New System.Drawing.Point(5, 0)
        '
        'bakcupText
        '
        Me.bakcupText.AutoSize = True
        Me.bakcupText.Font = New System.Drawing.Font("Trebuchet MS", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bakcupText.Location = New System.Drawing.Point(13, 30)
        Me.bakcupText.Name = "bakcupText"
        Me.bakcupText.Size = New System.Drawing.Size(71, 24)
        Me.bakcupText.TabIndex = 1000000011
        Me.bakcupText.Text = "Backup"
        '
        'btnBackupNow
        '
        Me.btnBackupNow.Animated = True
        Me.btnBackupNow.AnimatedGIF = True
        Me.btnBackupNow.BorderRadius = 10
        Me.btnBackupNow.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnBackupNow.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnBackupNow.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnBackupNow.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnBackupNow.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnBackupNow.FillColor = System.Drawing.Color.SeaGreen
        Me.btnBackupNow.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBackupNow.ForeColor = System.Drawing.Color.White
        Me.btnBackupNow.Image = Global.BarangaySystem.My.Resources.Resources.backup
        Me.btnBackupNow.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.btnBackupNow.Location = New System.Drawing.Point(443, 92)
        Me.btnBackupNow.Name = "btnBackupNow"
        Me.btnBackupNow.Size = New System.Drawing.Size(131, 45)
        Me.btnBackupNow.TabIndex = 1000000014
        Me.btnBackupNow.Text = "Backup Now"
        Me.btnBackupNow.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(353, 109)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 1000000018
        Me.Button2.Text = "Button2"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(258, 114)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(39, 13)
        Me.Label9.TabIndex = 1000000022
        Me.Label9.Text = "Label9"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(213, 114)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(39, 13)
        Me.Label8.TabIndex = 1000000021
        Me.Label8.Text = "Label8"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(168, 114)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(39, 13)
        Me.Label7.TabIndex = 1000000020
        Me.Label7.Text = "Label7"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(123, 114)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(39, 13)
        Me.Label6.TabIndex = 1000000019
        Me.Label6.Text = "Label6"
        '
        'BackupPathTextBox
        '
        Me.BackupPathTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblDatabaseBindingSource, "backupPath", True))
        Me.BackupPathTextBox.Enabled = False
        Me.BackupPathTextBox.Location = New System.Drawing.Point(225, 107)
        Me.BackupPathTextBox.Name = "BackupPathTextBox"
        Me.BackupPathTextBox.Size = New System.Drawing.Size(100, 20)
        Me.BackupPathTextBox.TabIndex = 1
        '
        'TblDatabaseBindingSource
        '
        Me.TblDatabaseBindingSource.DataMember = "tblDatabase"
        Me.TblDatabaseBindingSource.DataSource = Me.DbBrgySystemDataSet
        '
        'DbBrgySystemDataSet
        '
        Me.DbBrgySystemDataSet.DataSetName = "dbBrgySystemDataSet"
        Me.DbBrgySystemDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Guna2Elipse2
        '
        Me.Guna2Elipse2.BorderRadius = 30
        Me.Guna2Elipse2.TargetControl = Me.Panel1
        '
        'Guna2Elipse3
        '
        Me.Guna2Elipse3.BorderRadius = 30
        Me.Guna2Elipse3.TargetControl = Me.Panel2
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.White
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Controls.Add(Me.txtBoxRestoreDir)
        Me.Panel2.Controls.Add(Label3)
        Me.Panel2.Controls.Add(Me.btnBrowse)
        Me.Panel2.Controls.Add(Me.btnRestoreNow)
        Me.Panel2.Controls.Add(RestorePathLabel)
        Me.Panel2.Controls.Add(Me.RestorePathTextBox)
        Me.Panel2.Location = New System.Drawing.Point(0, 185)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(668, 179)
        Me.Panel2.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Trebuchet MS", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(13, 28)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(73, 24)
        Me.Label1.TabIndex = 1000000018
        Me.Label1.Text = "Restore"
        '
        'txtBoxRestoreDir
        '
        Me.txtBoxRestoreDir.Animated = True
        Me.txtBoxRestoreDir.BackColor = System.Drawing.Color.White
        Me.txtBoxRestoreDir.BorderColor = System.Drawing.Color.Black
        Me.txtBoxRestoreDir.BorderRadius = 10
        Me.txtBoxRestoreDir.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtBoxRestoreDir.DefaultText = ""
        Me.txtBoxRestoreDir.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtBoxRestoreDir.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtBoxRestoreDir.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtBoxRestoreDir.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtBoxRestoreDir.FocusedState.BorderColor = System.Drawing.Color.Goldenrod
        Me.txtBoxRestoreDir.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBoxRestoreDir.ForeColor = System.Drawing.Color.Black
        Me.txtBoxRestoreDir.HoverState.BorderColor = System.Drawing.Color.Goldenrod
        Me.txtBoxRestoreDir.IconLeftOffset = New System.Drawing.Point(8, 0)
        Me.txtBoxRestoreDir.Location = New System.Drawing.Point(18, 92)
        Me.txtBoxRestoreDir.Margin = New System.Windows.Forms.Padding(4)
        Me.txtBoxRestoreDir.Name = "txtBoxRestoreDir"
        Me.txtBoxRestoreDir.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtBoxRestoreDir.PlaceholderForeColor = System.Drawing.Color.DimGray
        Me.txtBoxRestoreDir.PlaceholderText = "Locate database"
        Me.txtBoxRestoreDir.SelectedText = ""
        Me.txtBoxRestoreDir.Size = New System.Drawing.Size(318, 45)
        Me.txtBoxRestoreDir.TabIndex = 1000000022
        Me.txtBoxRestoreDir.TextOffset = New System.Drawing.Point(5, 0)
        '
        'btnBrowse
        '
        Me.btnBrowse.Animated = True
        Me.btnBrowse.AnimatedGIF = True
        Me.btnBrowse.BorderRadius = 10
        Me.btnBrowse.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnBrowse.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnBrowse.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnBrowse.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnBrowse.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnBrowse.FillColor = System.Drawing.Color.DodgerBlue
        Me.btnBrowse.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Bold)
        Me.btnBrowse.ForeColor = System.Drawing.Color.White
        Me.btnBrowse.Image = Global.BarangaySystem.My.Resources.Resources.search
        Me.btnBrowse.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.btnBrowse.Location = New System.Drawing.Point(343, 92)
        Me.btnBrowse.Name = "btnBrowse"
        Me.btnBrowse.Size = New System.Drawing.Size(94, 45)
        Me.btnBrowse.TabIndex = 1000000020
        Me.btnBrowse.Text = "Browse"
        Me.btnBrowse.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.btnBrowse.TextOffset = New System.Drawing.Point(-5, 0)
        '
        'btnRestoreNow
        '
        Me.btnRestoreNow.Animated = True
        Me.btnRestoreNow.AnimatedGIF = True
        Me.btnRestoreNow.BorderRadius = 10
        Me.btnRestoreNow.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnRestoreNow.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnRestoreNow.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnRestoreNow.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnRestoreNow.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnRestoreNow.FillColor = System.Drawing.Color.SeaGreen
        Me.btnRestoreNow.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRestoreNow.ForeColor = System.Drawing.Color.White
        Me.btnRestoreNow.Image = Global.BarangaySystem.My.Resources.Resources.restore
        Me.btnRestoreNow.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.btnRestoreNow.Location = New System.Drawing.Point(442, 92)
        Me.btnRestoreNow.Name = "btnRestoreNow"
        Me.btnRestoreNow.Size = New System.Drawing.Size(131, 45)
        Me.btnRestoreNow.TabIndex = 1000000021
        Me.btnRestoreNow.Text = "Restore Now"
        Me.btnRestoreNow.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'RestorePathTextBox
        '
        Me.RestorePathTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblDatabaseBindingSource, "restorePath", True))
        Me.RestorePathTextBox.Enabled = False
        Me.RestorePathTextBox.Location = New System.Drawing.Point(216, 101)
        Me.RestorePathTextBox.Name = "RestorePathTextBox"
        Me.RestorePathTextBox.Size = New System.Drawing.Size(100, 20)
        Me.RestorePathTextBox.TabIndex = 3
        '
        'Guna2Elipse4
        '
        Me.Guna2Elipse4.BorderRadius = 30
        '
        'ShapeContainer1
        '
        Me.ShapeContainer1.Location = New System.Drawing.Point(0, 0)
        Me.ShapeContainer1.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer1.Name = "ShapeContainer1"
        Me.ShapeContainer1.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.LineShape2, Me.LineShape1})
        Me.ShapeContainer1.Size = New System.Drawing.Size(684, 397)
        Me.ShapeContainer1.TabIndex = 1000000026
        Me.ShapeContainer1.TabStop = False
        '
        'LineShape2
        '
        Me.LineShape2.BorderColor = System.Drawing.SystemColors.ControlDark
        Me.LineShape2.BorderWidth = 2
        Me.LineShape2.Name = "LineShape2"
        Me.LineShape2.X1 = 6
        Me.LineShape2.X2 = 667
        Me.LineShape2.Y1 = 367
        Me.LineShape2.Y2 = 366
        '
        'LineShape1
        '
        Me.LineShape1.BorderColor = System.Drawing.SystemColors.ControlDark
        Me.LineShape1.BorderWidth = 2
        Me.LineShape1.Name = "LineShape1"
        Me.LineShape1.X1 = 7
        Me.LineShape1.X2 = 668
        Me.LineShape1.Y1 = 182
        Me.LineShape1.Y2 = 181
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 10
        '
        'TblDatabaseTableAdapter
        '
        Me.TblDatabaseTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.tblBlotterTableAdapter = Nothing
        Me.TableAdapterManager.tblDatabaseTableAdapter = Me.TblDatabaseTableAdapter
        Me.TableAdapterManager.tblHistoryTableAdapter = Nothing
        Me.TableAdapterManager.tblIncrementsTableAdapter = Nothing
        Me.TableAdapterManager.tblOrganizationTableAdapter = Nothing
        Me.TableAdapterManager.tblPrintIndigencyTableAdapter = Nothing
        Me.TableAdapterManager.tblResidentsTableAdapter = Nothing
        Me.TableAdapterManager.tblSysSettingsTableAdapter = Nothing
        Me.TableAdapterManager.tblUserAccountsTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = BarangaySystem.dbBrgySystemDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'frmDBSett
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(684, 397)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.ShapeContainer1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmDBSett"
        Me.Text = "frmDBSett"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.TblDatabaseBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DbBrgySystemDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Guna2Elipse1 As Guna.UI2.WinForms.Guna2Elipse
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Guna2Elipse2 As Guna.UI2.WinForms.Guna2Elipse
    Friend WithEvents Guna2Elipse3 As Guna.UI2.WinForms.Guna2Elipse
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents TblDatabaseBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents DbBrgySystemDataSet As BarangaySystem.dbBrgySystemDataSet
    Friend WithEvents TblDatabaseTableAdapter As BarangaySystem.dbBrgySystemDataSetTableAdapters.tblDatabaseTableAdapter
    Friend WithEvents TableAdapterManager As BarangaySystem.dbBrgySystemDataSetTableAdapters.TableAdapterManager
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtBoxRestoreDir As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents btnBrowse As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnRestoreNow As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnUndo1 As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnChange As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents txtBoxBackupDir As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents bakcupText As System.Windows.Forms.Label
    Friend WithEvents btnBackupNow As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents FolderBrowserDialog1 As System.Windows.Forms.FolderBrowserDialog
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents Guna2Elipse4 As Guna.UI2.WinForms.Guna2Elipse
    Friend WithEvents ShapeContainer1 As Microsoft.VisualBasic.PowerPacks.ShapeContainer
    Friend WithEvents LineShape2 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents LineShape1 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents RestorePathTextBox As System.Windows.Forms.TextBox
    Friend WithEvents BackupPathTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
End Class
