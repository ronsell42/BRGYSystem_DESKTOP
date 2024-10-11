<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmResidents
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
        Dim IDLabel As System.Windows.Forms.Label
        Dim FullNameLabel As System.Windows.Forms.Label
        Dim FirstNameLabel As System.Windows.Forms.Label
        Dim MInitialLabel As System.Windows.Forms.Label
        Dim LastNameLabel As System.Windows.Forms.Label
        Dim AgeLabel As System.Windows.Forms.Label
        Dim NameExtLabel As System.Windows.Forms.Label
        Dim SexLabel As System.Windows.Forms.Label
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmResidents))
        Me.lblCurrentFrm = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.AgeTextBox = New System.Windows.Forms.TextBox()
        Me.TblResidentsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DbBrgySystemDataSetBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DbBrgySystemDataSet = New BarangaySystem.dbBrgySystemDataSet()
        Me.FullNameTextBox = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.IDTextBox = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.picCurrentFrm = New Guna.UI2.WinForms.Guna2PictureBox()
        Me.LastNameTextBox = New System.Windows.Forms.TextBox()
        Me.MInitialTextBox = New System.Windows.Forms.TextBox()
        Me.FirstNameTextBox = New System.Windows.Forms.TextBox()
        Me.SexTextBox = New System.Windows.Forms.TextBox()
        Me.NameExtTextBox = New System.Windows.Forms.TextBox()
        Me.Guna2Elipse1 = New Guna.UI2.WinForms.Guna2Elipse(Me.components)
        Me.Guna2Panel2 = New Guna.UI2.WinForms.Guna2Panel()
        Me.clearSearch = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Guna2Button4 = New Guna.UI2.WinForms.Guna2Button()
        Me.Guna2Button3 = New Guna.UI2.WinForms.Guna2Button()
        Me.Guna2Button5 = New Guna.UI2.WinForms.Guna2Button()
        Me.Guna2Button2 = New Guna.UI2.WinForms.Guna2Button()
        Me.ResidentsTbl = New System.Windows.Forms.DataGridView()
        Me.Guna2Button1 = New Guna.UI2.WinForms.Guna2Button()
        Me.residentSearchBox = New Guna.UI2.WinForms.Guna2TextBox()
        Me.refreshBtn = New System.Windows.Forms.Button()
        Me.Guna2Elipse2 = New Guna.UI2.WinForms.Guna2Elipse(Me.components)
        Me.Guna2Elipse3 = New Guna.UI2.WinForms.Guna2Elipse(Me.components)
        Me.TblResidentsTableAdapter = New BarangaySystem.dbBrgySystemDataSetTableAdapters.tblResidentsTableAdapter()
        Me.TableAdapterManager = New BarangaySystem.dbBrgySystemDataSetTableAdapters.TableAdapterManager()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.DataGridViewImageColumn1 = New System.Windows.Forms.DataGridViewImageColumn()
        Me.DataGridViewImageColumn2 = New System.Windows.Forms.DataGridViewImageColumn()
        Me.ID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Delete = New System.Windows.Forms.DataGridViewImageColumn()
        Me.Edit = New System.Windows.Forms.DataGridViewImageColumn()
        Me.fullName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PurokDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AgeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BDayDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SexDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CStatusDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ReligionDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        IDLabel = New System.Windows.Forms.Label()
        FullNameLabel = New System.Windows.Forms.Label()
        FirstNameLabel = New System.Windows.Forms.Label()
        MInitialLabel = New System.Windows.Forms.Label()
        LastNameLabel = New System.Windows.Forms.Label()
        AgeLabel = New System.Windows.Forms.Label()
        NameExtLabel = New System.Windows.Forms.Label()
        SexLabel = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        CType(Me.TblResidentsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DbBrgySystemDataSetBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DbBrgySystemDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picCurrentFrm, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Guna2Panel2.SuspendLayout()
        CType(Me.ResidentsTbl, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'IDLabel
        '
        IDLabel.AutoSize = True
        IDLabel.Location = New System.Drawing.Point(575, 33)
        IDLabel.Name = "IDLabel"
        IDLabel.Size = New System.Drawing.Size(21, 13)
        IDLabel.TabIndex = 8
        IDLabel.Text = "ID:"
        '
        'FullNameLabel
        '
        FullNameLabel.AutoSize = True
        FullNameLabel.Location = New System.Drawing.Point(714, 33)
        FullNameLabel.Name = "FullNameLabel"
        FullNameLabel.Size = New System.Drawing.Size(54, 13)
        FullNameLabel.TabIndex = 9
        FullNameLabel.Text = "full Name:"
        '
        'FirstNameLabel
        '
        FirstNameLabel.AutoSize = True
        FirstNameLabel.Location = New System.Drawing.Point(217, 6)
        FirstNameLabel.Name = "FirstNameLabel"
        FirstNameLabel.Size = New System.Drawing.Size(57, 13)
        FirstNameLabel.TabIndex = 10
        FirstNameLabel.Text = "first Name:"
        '
        'MInitialLabel
        '
        MInitialLabel.AutoSize = True
        MInitialLabel.Location = New System.Drawing.Point(229, 27)
        MInitialLabel.Name = "MInitialLabel"
        MInitialLabel.Size = New System.Drawing.Size(45, 13)
        MInitialLabel.TabIndex = 11
        MInitialLabel.Text = "m Initial:"
        '
        'LastNameLabel
        '
        LastNameLabel.AutoSize = True
        LastNameLabel.Location = New System.Drawing.Point(217, 48)
        LastNameLabel.Name = "LastNameLabel"
        LastNameLabel.Size = New System.Drawing.Size(57, 13)
        LastNameLabel.TabIndex = 12
        LastNameLabel.Text = "last Name:"
        '
        'AgeLabel
        '
        AgeLabel.AutoSize = True
        AgeLabel.Location = New System.Drawing.Point(391, 9)
        AgeLabel.Name = "AgeLabel"
        AgeLabel.Size = New System.Drawing.Size(28, 13)
        AgeLabel.TabIndex = 14
        AgeLabel.Text = "age:"
        '
        'NameExtLabel
        '
        NameExtLabel.AutoSize = True
        NameExtLabel.Location = New System.Drawing.Point(384, 36)
        NameExtLabel.Name = "NameExtLabel"
        NameExtLabel.Size = New System.Drawing.Size(54, 13)
        NameExtLabel.TabIndex = 17
        NameExtLabel.Text = "name Ext:"
        '
        'SexLabel
        '
        SexLabel.AutoSize = True
        SexLabel.Location = New System.Drawing.Point(570, 51)
        SexLabel.Name = "SexLabel"
        SexLabel.Size = New System.Drawing.Size(26, 13)
        SexLabel.TabIndex = 19
        SexLabel.Text = "sex:"
        '
        'lblCurrentFrm
        '
        Me.lblCurrentFrm.AutoSize = True
        Me.lblCurrentFrm.Font = New System.Drawing.Font("Trebuchet MS", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCurrentFrm.Location = New System.Drawing.Point(64, 12)
        Me.lblCurrentFrm.Name = "lblCurrentFrm"
        Me.lblCurrentFrm.Size = New System.Drawing.Size(152, 40)
        Me.lblCurrentFrm.TabIndex = 4
        Me.lblCurrentFrm.Text = "Residents"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.Controls.Add(Me.Panel3)
        Me.Panel1.Controls.Add(AgeLabel)
        Me.Panel1.Controls.Add(Me.AgeTextBox)
        Me.Panel1.Controls.Add(FullNameLabel)
        Me.Panel1.Controls.Add(Me.FullNameTextBox)
        Me.Panel1.Controls.Add(IDLabel)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.IDTextBox)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.lblCurrentFrm)
        Me.Panel1.Controls.Add(Me.picCurrentFrm)
        Me.Panel1.Controls.Add(LastNameLabel)
        Me.Panel1.Controls.Add(Me.LastNameTextBox)
        Me.Panel1.Controls.Add(MInitialLabel)
        Me.Panel1.Controls.Add(Me.MInitialTextBox)
        Me.Panel1.Controls.Add(FirstNameLabel)
        Me.Panel1.Controls.Add(Me.FirstNameTextBox)
        Me.Panel1.Controls.Add(SexLabel)
        Me.Panel1.Controls.Add(Me.SexTextBox)
        Me.Panel1.Controls.Add(NameExtLabel)
        Me.Panel1.Controls.Add(Me.NameExtTextBox)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1128, 85)
        Me.Panel1.TabIndex = 5
        '
        'Panel3
        '
        Me.Panel3.Location = New System.Drawing.Point(211, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(694, 68)
        Me.Panel3.TabIndex = 16
        '
        'AgeTextBox
        '
        Me.AgeTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblResidentsBindingSource, "age", True))
        Me.AgeTextBox.Enabled = False
        Me.AgeTextBox.Location = New System.Drawing.Point(425, 6)
        Me.AgeTextBox.Name = "AgeTextBox"
        Me.AgeTextBox.Size = New System.Drawing.Size(100, 20)
        Me.AgeTextBox.TabIndex = 15
        '
        'TblResidentsBindingSource
        '
        Me.TblResidentsBindingSource.DataMember = "tblResidents"
        Me.TblResidentsBindingSource.DataSource = Me.DbBrgySystemDataSetBindingSource
        '
        'DbBrgySystemDataSetBindingSource
        '
        Me.DbBrgySystemDataSetBindingSource.DataSource = Me.DbBrgySystemDataSet
        Me.DbBrgySystemDataSetBindingSource.Position = 0
        '
        'DbBrgySystemDataSet
        '
        Me.DbBrgySystemDataSet.DataSetName = "dbBrgySystemDataSet"
        Me.DbBrgySystemDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'FullNameTextBox
        '
        Me.FullNameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblResidentsBindingSource, "fullName", True))
        Me.FullNameTextBox.Enabled = False
        Me.FullNameTextBox.Location = New System.Drawing.Point(774, 30)
        Me.FullNameTextBox.Name = "FullNameTextBox"
        Me.FullNameTextBox.Size = New System.Drawing.Size(100, 20)
        Me.FullNameTextBox.TabIndex = 10
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(679, 12)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(13, 13)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "0"
        '
        'IDTextBox
        '
        Me.IDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblResidentsBindingSource, "ID", True))
        Me.IDTextBox.Enabled = False
        Me.IDTextBox.Location = New System.Drawing.Point(602, 30)
        Me.IDTextBox.Name = "IDTextBox"
        Me.IDTextBox.Size = New System.Drawing.Size(100, 20)
        Me.IDTextBox.TabIndex = 9
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(620, 8)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(39, 13)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Label1"
        '
        'picCurrentFrm
        '
        Me.picCurrentFrm.Image = Global.BarangaySystem.My.Resources.Resources.iconResidents
        Me.picCurrentFrm.ImageRotate = 0.0!
        Me.picCurrentFrm.Location = New System.Drawing.Point(6, 12)
        Me.picCurrentFrm.Name = "picCurrentFrm"
        Me.picCurrentFrm.Size = New System.Drawing.Size(63, 38)
        Me.picCurrentFrm.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picCurrentFrm.TabIndex = 3
        Me.picCurrentFrm.TabStop = False
        '
        'LastNameTextBox
        '
        Me.LastNameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblResidentsBindingSource, "lastName", True))
        Me.LastNameTextBox.Enabled = False
        Me.LastNameTextBox.Location = New System.Drawing.Point(280, 45)
        Me.LastNameTextBox.Name = "LastNameTextBox"
        Me.LastNameTextBox.Size = New System.Drawing.Size(100, 20)
        Me.LastNameTextBox.TabIndex = 13
        '
        'MInitialTextBox
        '
        Me.MInitialTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblResidentsBindingSource, "mInitial", True))
        Me.MInitialTextBox.Enabled = False
        Me.MInitialTextBox.Location = New System.Drawing.Point(280, 24)
        Me.MInitialTextBox.Name = "MInitialTextBox"
        Me.MInitialTextBox.Size = New System.Drawing.Size(100, 20)
        Me.MInitialTextBox.TabIndex = 12
        '
        'FirstNameTextBox
        '
        Me.FirstNameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblResidentsBindingSource, "firstName", True))
        Me.FirstNameTextBox.Enabled = False
        Me.FirstNameTextBox.Location = New System.Drawing.Point(280, 3)
        Me.FirstNameTextBox.Name = "FirstNameTextBox"
        Me.FirstNameTextBox.Size = New System.Drawing.Size(100, 20)
        Me.FirstNameTextBox.TabIndex = 11
        '
        'SexTextBox
        '
        Me.SexTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblResidentsBindingSource, "sex", True))
        Me.SexTextBox.Enabled = False
        Me.SexTextBox.Location = New System.Drawing.Point(602, 48)
        Me.SexTextBox.Name = "SexTextBox"
        Me.SexTextBox.Size = New System.Drawing.Size(100, 20)
        Me.SexTextBox.TabIndex = 20
        '
        'NameExtTextBox
        '
        Me.NameExtTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblResidentsBindingSource, "nameExt", True))
        Me.NameExtTextBox.Location = New System.Drawing.Point(444, 33)
        Me.NameExtTextBox.Name = "NameExtTextBox"
        Me.NameExtTextBox.Size = New System.Drawing.Size(100, 20)
        Me.NameExtTextBox.TabIndex = 18
        '
        'Guna2Elipse1
        '
        Me.Guna2Elipse1.BorderRadius = 30
        Me.Guna2Elipse1.TargetControl = Me.Panel1
        '
        'Guna2Panel2
        '
        Me.Guna2Panel2.AutoRoundedCorners = True
        Me.Guna2Panel2.BackColor = System.Drawing.Color.White
        Me.Guna2Panel2.BorderRadius = 305
        Me.Guna2Panel2.Controls.Add(Me.clearSearch)
        Me.Guna2Panel2.Controls.Add(Me.Panel2)
        Me.Guna2Panel2.Controls.Add(Me.Guna2Button4)
        Me.Guna2Panel2.Controls.Add(Me.Guna2Button3)
        Me.Guna2Panel2.Controls.Add(Me.Guna2Button5)
        Me.Guna2Panel2.Controls.Add(Me.Guna2Button2)
        Me.Guna2Panel2.Controls.Add(Me.ResidentsTbl)
        Me.Guna2Panel2.Controls.Add(Me.Guna2Button1)
        Me.Guna2Panel2.Controls.Add(Me.residentSearchBox)
        Me.Guna2Panel2.Controls.Add(Me.refreshBtn)
        Me.Guna2Panel2.Location = New System.Drawing.Point(0, 69)
        Me.Guna2Panel2.Name = "Guna2Panel2"
        Me.Guna2Panel2.Size = New System.Drawing.Size(1128, 612)
        Me.Guna2Panel2.TabIndex = 8
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
        Me.clearSearch.Location = New System.Drawing.Point(289, 14)
        Me.clearSearch.Name = "clearSearch"
        Me.clearSearch.Size = New System.Drawing.Size(44, 39)
        Me.clearSearch.TabIndex = 10278
        Me.clearSearch.Text = "x"
        Me.ToolTip1.SetToolTip(Me.clearSearch, "Clear Search")
        Me.clearSearch.UseVisualStyleBackColor = False
        Me.clearSearch.Visible = False
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.DarkGoldenrod
        Me.Panel2.Location = New System.Drawing.Point(138, 65)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(169, 34)
        Me.Panel2.TabIndex = 10263
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
        Me.Guna2Button4.Location = New System.Drawing.Point(579, 13)
        Me.Guna2Button4.Name = "Guna2Button4"
        Me.Guna2Button4.Size = New System.Drawing.Size(80, 45)
        Me.Guna2Button4.TabIndex = 4
        Me.Guna2Button4.Text = "Delete"
        Me.Guna2Button4.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.Guna2Button4.TextOffset = New System.Drawing.Point(-5, 0)
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
        Me.Guna2Button3.Image = Global.BarangaySystem.My.Resources.Resources.edit
        Me.Guna2Button3.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.Guna2Button3.Location = New System.Drawing.Point(496, 13)
        Me.Guna2Button3.Name = "Guna2Button3"
        Me.Guna2Button3.Size = New System.Drawing.Size(80, 45)
        Me.Guna2Button3.TabIndex = 3
        Me.Guna2Button3.Text = "Edit"
        Me.Guna2Button3.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.Guna2Button3.TextOffset = New System.Drawing.Point(-5, 0)
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
        Me.Guna2Button5.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2Button5.ForeColor = System.Drawing.Color.White
        Me.Guna2Button5.Location = New System.Drawing.Point(665, 12)
        Me.Guna2Button5.Name = "Guna2Button5"
        Me.Guna2Button5.Size = New System.Drawing.Size(225, 45)
        Me.Guna2Button5.TabIndex = 5
        Me.Guna2Button5.Text = "Proceed to Documents"
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
        Me.Guna2Button2.Image = Global.BarangaySystem.My.Resources.Resources.plus
        Me.Guna2Button2.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.Guna2Button2.Location = New System.Drawing.Point(413, 12)
        Me.Guna2Button2.Name = "Guna2Button2"
        Me.Guna2Button2.Size = New System.Drawing.Size(80, 45)
        Me.Guna2Button2.TabIndex = 2
        Me.Guna2Button2.Text = "Add"
        Me.Guna2Button2.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.Guna2Button2.TextOffset = New System.Drawing.Point(-5, 0)
        '
        'ResidentsTbl
        '
        Me.ResidentsTbl.AllowUserToAddRows = False
        Me.ResidentsTbl.AllowUserToDeleteRows = False
        Me.ResidentsTbl.AllowUserToResizeColumns = False
        Me.ResidentsTbl.AllowUserToResizeRows = False
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.Ivory
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.Goldenrod
        Me.ResidentsTbl.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle4
        Me.ResidentsTbl.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ResidentsTbl.AutoGenerateColumns = False
        Me.ResidentsTbl.BackgroundColor = System.Drawing.Color.Silver
        Me.ResidentsTbl.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.ResidentsTbl.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.ResidentsTbl.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = System.Drawing.Color.DarkGoldenrod
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.Goldenrod
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.ResidentsTbl.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle5
        Me.ResidentsTbl.ColumnHeadersHeight = 35
        Me.ResidentsTbl.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.ResidentsTbl.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ID, Me.Delete, Me.Edit, Me.fullName, Me.PurokDataGridViewTextBoxColumn, Me.AgeDataGridViewTextBoxColumn, Me.BDayDataGridViewTextBoxColumn, Me.SexDataGridViewTextBoxColumn, Me.CStatusDataGridViewTextBoxColumn, Me.ReligionDataGridViewTextBoxColumn})
        Me.ResidentsTbl.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ResidentsTbl.DataSource = Me.TblResidentsBindingSource
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.Goldenrod
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.ResidentsTbl.DefaultCellStyle = DataGridViewCellStyle6
        Me.ResidentsTbl.EnableHeadersVisualStyles = False
        Me.ResidentsTbl.Location = New System.Drawing.Point(37, 65)
        Me.ResidentsTbl.Name = "ResidentsTbl"
        Me.ResidentsTbl.ReadOnly = True
        Me.ResidentsTbl.RowHeadersVisible = False
        Me.ResidentsTbl.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.ResidentsTbl.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.ResidentsTbl.Size = New System.Drawing.Size(1002, 519)
        Me.ResidentsTbl.TabIndex = 6
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
        Me.Guna2Button1.Location = New System.Drawing.Point(337, 12)
        Me.Guna2Button1.Name = "Guna2Button1"
        Me.Guna2Button1.Size = New System.Drawing.Size(70, 45)
        Me.Guna2Button1.TabIndex = 1
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
        Me.residentSearchBox.Location = New System.Drawing.Point(37, 11)
        Me.residentSearchBox.Margin = New System.Windows.Forms.Padding(4)
        Me.residentSearchBox.Name = "residentSearchBox"
        Me.residentSearchBox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.residentSearchBox.PlaceholderForeColor = System.Drawing.Color.DimGray
        Me.residentSearchBox.PlaceholderText = "Search Last Name, First Name"
        Me.residentSearchBox.SelectedText = ""
        Me.residentSearchBox.Size = New System.Drawing.Size(299, 45)
        Me.residentSearchBox.TabIndex = 0
        Me.residentSearchBox.TextOffset = New System.Drawing.Point(5, 0)
        '
        'refreshBtn
        '
        Me.refreshBtn.Location = New System.Drawing.Point(815, 23)
        Me.refreshBtn.Name = "refreshBtn"
        Me.refreshBtn.Size = New System.Drawing.Size(75, 23)
        Me.refreshBtn.TabIndex = 10279
        Me.refreshBtn.Text = "Refresh"
        Me.refreshBtn.UseVisualStyleBackColor = True
        '
        'Guna2Elipse2
        '
        Me.Guna2Elipse2.BorderRadius = 30
        '
        'Guna2Elipse3
        '
        Me.Guna2Elipse3.BorderRadius = 30
        Me.Guna2Elipse3.TargetControl = Me.Guna2Panel2
        '
        'TblResidentsTableAdapter
        '
        Me.TblResidentsTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.Connection = Nothing
        Me.TableAdapterManager.tblBlotterTableAdapter = Nothing
        Me.TableAdapterManager.tblDatabaseTableAdapter = Nothing
        Me.TableAdapterManager.tblHistoryTableAdapter = Nothing
        Me.TableAdapterManager.tblOrganizationTableAdapter = Nothing
        Me.TableAdapterManager.tblPrintIndigencyTableAdapter = Nothing
        Me.TableAdapterManager.tblResidentsTableAdapter = Nothing
        Me.TableAdapterManager.tblSysSettingsTableAdapter = Nothing
        Me.TableAdapterManager.tblUserAccountsTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = BarangaySystem.dbBrgySystemDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
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
        'ID
        '
        Me.ID.DataPropertyName = "ID"
        Me.ID.HeaderText = "ID"
        Me.ID.Name = "ID"
        Me.ID.ReadOnly = True
        Me.ID.Width = 5
        '
        'Delete
        '
        Me.Delete.HeaderText = "Delete"
        Me.Delete.Image = CType(resources.GetObject("Delete.Image"), System.Drawing.Image)
        Me.Delete.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom
        Me.Delete.Name = "Delete"
        Me.Delete.ReadOnly = True
        Me.Delete.ToolTipText = "Delete Record"
        Me.Delete.Width = 50
        '
        'Edit
        '
        Me.Edit.HeaderText = "Edit"
        Me.Edit.Image = CType(resources.GetObject("Edit.Image"), System.Drawing.Image)
        Me.Edit.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom
        Me.Edit.Name = "Edit"
        Me.Edit.ReadOnly = True
        Me.Edit.ToolTipText = "Edit Record"
        Me.Edit.Width = 50
        '
        'fullName
        '
        Me.fullName.DataPropertyName = "fullName"
        Me.fullName.HeaderText = "Name"
        Me.fullName.Name = "fullName"
        Me.fullName.ReadOnly = True
        Me.fullName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.fullName.Width = 175
        '
        'PurokDataGridViewTextBoxColumn
        '
        Me.PurokDataGridViewTextBoxColumn.DataPropertyName = "purok"
        Me.PurokDataGridViewTextBoxColumn.HeaderText = "Purok"
        Me.PurokDataGridViewTextBoxColumn.Name = "PurokDataGridViewTextBoxColumn"
        Me.PurokDataGridViewTextBoxColumn.ReadOnly = True
        Me.PurokDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.PurokDataGridViewTextBoxColumn.Width = 90
        '
        'AgeDataGridViewTextBoxColumn
        '
        Me.AgeDataGridViewTextBoxColumn.DataPropertyName = "age"
        Me.AgeDataGridViewTextBoxColumn.HeaderText = "Age"
        Me.AgeDataGridViewTextBoxColumn.Name = "AgeDataGridViewTextBoxColumn"
        Me.AgeDataGridViewTextBoxColumn.ReadOnly = True
        Me.AgeDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.AgeDataGridViewTextBoxColumn.Width = 50
        '
        'BDayDataGridViewTextBoxColumn
        '
        Me.BDayDataGridViewTextBoxColumn.DataPropertyName = "bDay"
        Me.BDayDataGridViewTextBoxColumn.HeaderText = "Birthday"
        Me.BDayDataGridViewTextBoxColumn.Name = "BDayDataGridViewTextBoxColumn"
        Me.BDayDataGridViewTextBoxColumn.ReadOnly = True
        Me.BDayDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'SexDataGridViewTextBoxColumn
        '
        Me.SexDataGridViewTextBoxColumn.DataPropertyName = "sex"
        Me.SexDataGridViewTextBoxColumn.HeaderText = "Sex"
        Me.SexDataGridViewTextBoxColumn.Name = "SexDataGridViewTextBoxColumn"
        Me.SexDataGridViewTextBoxColumn.ReadOnly = True
        Me.SexDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.SexDataGridViewTextBoxColumn.Width = 75
        '
        'CStatusDataGridViewTextBoxColumn
        '
        Me.CStatusDataGridViewTextBoxColumn.DataPropertyName = "cStatus"
        Me.CStatusDataGridViewTextBoxColumn.HeaderText = "Civil Status"
        Me.CStatusDataGridViewTextBoxColumn.Name = "CStatusDataGridViewTextBoxColumn"
        Me.CStatusDataGridViewTextBoxColumn.ReadOnly = True
        Me.CStatusDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'ReligionDataGridViewTextBoxColumn
        '
        Me.ReligionDataGridViewTextBoxColumn.DataPropertyName = "religion"
        Me.ReligionDataGridViewTextBoxColumn.HeaderText = "Religion"
        Me.ReligionDataGridViewTextBoxColumn.Name = "ReligionDataGridViewTextBoxColumn"
        Me.ReligionDataGridViewTextBoxColumn.ReadOnly = True
        Me.ReligionDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.ReligionDataGridViewTextBoxColumn.Width = 150
        '
        'frmResidents
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(1128, 691)
        Me.Controls.Add(Me.Guna2Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MaximumSize = New System.Drawing.Size(1128, 691)
        Me.MinimumSize = New System.Drawing.Size(1128, 691)
        Me.Name = "frmResidents"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmResidents"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.TblResidentsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DbBrgySystemDataSetBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DbBrgySystemDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picCurrentFrm, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Guna2Panel2.ResumeLayout(False)
        CType(Me.ResidentsTbl, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents lblCurrentFrm As System.Windows.Forms.Label
    Friend WithEvents picCurrentFrm As Guna.UI2.WinForms.Guna2PictureBox
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Guna2Elipse1 As Guna.UI2.WinForms.Guna2Elipse
    Friend WithEvents Guna2Panel2 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Guna2Elipse2 As Guna.UI2.WinForms.Guna2Elipse
    Friend WithEvents Guna2Elipse3 As Guna.UI2.WinForms.Guna2Elipse
    Friend WithEvents residentSearchBox As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents ResidentsTbl As System.Windows.Forms.DataGridView
    Friend WithEvents Guna2Button4 As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Guna2Button3 As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Guna2Button2 As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Guna2Button5 As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents DbBrgySystemDataSetBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents DbBrgySystemDataSet As BarangaySystem.dbBrgySystemDataSet
    Friend WithEvents TblResidentsBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TblResidentsTableAdapter As BarangaySystem.dbBrgySystemDataSetTableAdapters.tblResidentsTableAdapter
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Guna2Button1 As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents IDTextBox As System.Windows.Forms.TextBox
    Friend WithEvents TableAdapterManager As BarangaySystem.dbBrgySystemDataSetTableAdapters.TableAdapterManager
    Friend WithEvents FullNameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents clearSearch As System.Windows.Forms.Button
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents refreshBtn As System.Windows.Forms.Button
    Friend WithEvents LastNameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents MInitialTextBox As System.Windows.Forms.TextBox
    Friend WithEvents FirstNameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents AgeTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents NameExtTextBox As System.Windows.Forms.TextBox
    Friend WithEvents SexTextBox As System.Windows.Forms.TextBox
    Friend WithEvents DataGridViewImageColumn1 As System.Windows.Forms.DataGridViewImageColumn
    Friend WithEvents DataGridViewImageColumn2 As System.Windows.Forms.DataGridViewImageColumn
    Friend WithEvents ID As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Delete As System.Windows.Forms.DataGridViewImageColumn
    Friend WithEvents Edit As System.Windows.Forms.DataGridViewImageColumn
    Friend WithEvents fullName As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PurokDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents AgeDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents BDayDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SexDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CStatusDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ReligionDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
