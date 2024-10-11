<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmHistory
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
        Dim EventDateLabel As System.Windows.Forms.Label
        Dim WhoWasItLabel As System.Windows.Forms.Label
        Dim ActionTakenLabel As System.Windows.Forms.Label
        Dim ByWhoLabel As System.Windows.Forms.Label
        Dim UsernameLabel As System.Windows.Forms.Label
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.lblCurrentFrm = New System.Windows.Forms.Label()
        Me.picCurrentFrm = New Guna.UI2.WinForms.Guna2PictureBox()
        Me.Guna2Panel2 = New Guna.UI2.WinForms.Guna2Panel()
        Me.BunifuDropdown3 = New Bunifu.Framework.UI.BunifuDropdown()
        Me.TblUserAccountsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DbBrgySystemDataSet = New BarangaySystem.dbBrgySystemDataSet()
        Me.HistoryTbl = New System.Windows.Forms.DataGridView()
        Me.IDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EventDateDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.WhoWasItDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ActionTakenDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ByWhoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TblHistoryBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Button5 = New System.Windows.Forms.Button()
        Me.UsernameTextBox = New System.Windows.Forms.TextBox()
        Me.TblUserAccountsDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.BunifuDropdown2 = New Bunifu.Framework.UI.BunifuDropdown()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.IDTextBox = New System.Windows.Forms.TextBox()
        Me.EventDateDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.WhoWasItTextBox = New System.Windows.Forms.TextBox()
        Me.ActionTakenTextBox = New System.Windows.Forms.TextBox()
        Me.ByWhoTextBox = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Guna2Elipse1 = New Guna.UI2.WinForms.Guna2Elipse(Me.components)
        Me.Guna2Elipse3 = New Guna.UI2.WinForms.Guna2Elipse(Me.components)
        Me.Guna2Elipse2 = New Guna.UI2.WinForms.Guna2Elipse(Me.components)
        Me.Guna2Elipse4 = New Guna.UI2.WinForms.Guna2Elipse(Me.components)
        Me.TblHistoryTableAdapter = New BarangaySystem.dbBrgySystemDataSetTableAdapters.tblHistoryTableAdapter()
        Me.TableAdapterManager = New BarangaySystem.dbBrgySystemDataSetTableAdapters.TableAdapterManager()
        Me.TblUserAccountsTableAdapter = New BarangaySystem.dbBrgySystemDataSetTableAdapters.tblUserAccountsTableAdapter()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        IDLabel = New System.Windows.Forms.Label()
        EventDateLabel = New System.Windows.Forms.Label()
        WhoWasItLabel = New System.Windows.Forms.Label()
        ActionTakenLabel = New System.Windows.Forms.Label()
        ByWhoLabel = New System.Windows.Forms.Label()
        UsernameLabel = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        CType(Me.picCurrentFrm, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Guna2Panel2.SuspendLayout()
        CType(Me.TblUserAccountsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DbBrgySystemDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.HistoryTbl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblHistoryBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblUserAccountsDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'IDLabel
        '
        IDLabel.AutoSize = True
        IDLabel.Location = New System.Drawing.Point(223, 170)
        IDLabel.Name = "IDLabel"
        IDLabel.Size = New System.Drawing.Size(21, 13)
        IDLabel.TabIndex = 10262
        IDLabel.Text = "ID:"
        '
        'EventDateLabel
        '
        EventDateLabel.AutoSize = True
        EventDateLabel.Location = New System.Drawing.Point(223, 197)
        EventDateLabel.Name = "EventDateLabel"
        EventDateLabel.Size = New System.Drawing.Size(63, 13)
        EventDateLabel.TabIndex = 10264
        EventDateLabel.Text = "event Date:"
        '
        'WhoWasItLabel
        '
        WhoWasItLabel.AutoSize = True
        WhoWasItLabel.Location = New System.Drawing.Point(223, 222)
        WhoWasItLabel.Name = "WhoWasItLabel"
        WhoWasItLabel.Size = New System.Drawing.Size(64, 13)
        WhoWasItLabel.TabIndex = 10266
        WhoWasItLabel.Text = "who Was It:"
        '
        'ActionTakenLabel
        '
        ActionTakenLabel.AutoSize = True
        ActionTakenLabel.Location = New System.Drawing.Point(223, 248)
        ActionTakenLabel.Name = "ActionTakenLabel"
        ActionTakenLabel.Size = New System.Drawing.Size(73, 13)
        ActionTakenLabel.TabIndex = 10268
        ActionTakenLabel.Text = "action Taken:"
        '
        'ByWhoLabel
        '
        ByWhoLabel.AutoSize = True
        ByWhoLabel.Location = New System.Drawing.Point(223, 274)
        ByWhoLabel.Name = "ByWhoLabel"
        ByWhoLabel.Size = New System.Drawing.Size(47, 13)
        ByWhoLabel.TabIndex = 10270
        ByWhoLabel.Text = "by Who:"
        '
        'UsernameLabel
        '
        UsernameLabel.AutoSize = True
        UsernameLabel.Location = New System.Drawing.Point(664, 143)
        UsernameLabel.Name = "UsernameLabel"
        UsernameLabel.Size = New System.Drawing.Size(56, 13)
        UsernameLabel.TabIndex = 10276
        UsernameLabel.Text = "username:"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Controls.Add(Me.DateTimePicker1)
        Me.Panel1.Controls.Add(Me.lblCurrentFrm)
        Me.Panel1.Controls.Add(Me.picCurrentFrm)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1128, 63)
        Me.Panel1.TabIndex = 8
        '
        'Panel2
        '
        Me.Panel2.Location = New System.Drawing.Point(213, 12)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(489, 57)
        Me.Panel2.TabIndex = 10278
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Location = New System.Drawing.Point(213, 32)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(200, 20)
        Me.DateTimePicker1.TabIndex = 10277
        '
        'lblCurrentFrm
        '
        Me.lblCurrentFrm.AutoSize = True
        Me.lblCurrentFrm.Font = New System.Drawing.Font("Trebuchet MS", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCurrentFrm.Location = New System.Drawing.Point(64, 12)
        Me.lblCurrentFrm.Name = "lblCurrentFrm"
        Me.lblCurrentFrm.Size = New System.Drawing.Size(118, 40)
        Me.lblCurrentFrm.TabIndex = 4
        Me.lblCurrentFrm.Text = "History"
        '
        'picCurrentFrm
        '
        Me.picCurrentFrm.Image = Global.BarangaySystem.My.Resources.Resources.history
        Me.picCurrentFrm.ImageRotate = 0.0!
        Me.picCurrentFrm.Location = New System.Drawing.Point(6, 12)
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
        Me.Guna2Panel2.Controls.Add(Me.BunifuDropdown3)
        Me.Guna2Panel2.Controls.Add(Me.HistoryTbl)
        Me.Guna2Panel2.Controls.Add(Me.Button5)
        Me.Guna2Panel2.Controls.Add(UsernameLabel)
        Me.Guna2Panel2.Controls.Add(Me.UsernameTextBox)
        Me.Guna2Panel2.Controls.Add(Me.TblUserAccountsDataGridView)
        Me.Guna2Panel2.Controls.Add(Me.Label5)
        Me.Guna2Panel2.Controls.Add(Me.Label2)
        Me.Guna2Panel2.Controls.Add(Me.BunifuDropdown2)
        Me.Guna2Panel2.Controls.Add(Me.Button4)
        Me.Guna2Panel2.Controls.Add(Me.Button3)
        Me.Guna2Panel2.Controls.Add(IDLabel)
        Me.Guna2Panel2.Controls.Add(Me.IDTextBox)
        Me.Guna2Panel2.Controls.Add(EventDateLabel)
        Me.Guna2Panel2.Controls.Add(Me.EventDateDateTimePicker)
        Me.Guna2Panel2.Controls.Add(WhoWasItLabel)
        Me.Guna2Panel2.Controls.Add(Me.WhoWasItTextBox)
        Me.Guna2Panel2.Controls.Add(ActionTakenLabel)
        Me.Guna2Panel2.Controls.Add(Me.ActionTakenTextBox)
        Me.Guna2Panel2.Controls.Add(ByWhoLabel)
        Me.Guna2Panel2.Controls.Add(Me.ByWhoTextBox)
        Me.Guna2Panel2.Controls.Add(Me.Label6)
        Me.Guna2Panel2.Controls.Add(Me.Label4)
        Me.Guna2Panel2.Location = New System.Drawing.Point(0, 69)
        Me.Guna2Panel2.Name = "Guna2Panel2"
        Me.Guna2Panel2.Size = New System.Drawing.Size(1128, 612)
        Me.Guna2Panel2.TabIndex = 11
        '
        'BunifuDropdown3
        '
        Me.BunifuDropdown3.BackColor = System.Drawing.Color.Transparent
        Me.BunifuDropdown3.BorderRadius = 3
        Me.BunifuDropdown3.DataBindings.Add(New System.Windows.Forms.Binding("Tag", Me.TblUserAccountsBindingSource, "username", True))
        Me.BunifuDropdown3.DisabledColor = System.Drawing.Color.Gray
        Me.BunifuDropdown3.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Bold)
        Me.BunifuDropdown3.ForeColor = System.Drawing.Color.White
        Me.BunifuDropdown3.Items = New String() {"All"}
        Me.BunifuDropdown3.Location = New System.Drawing.Point(376, 17)
        Me.BunifuDropdown3.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.BunifuDropdown3.Name = "BunifuDropdown3"
        Me.BunifuDropdown3.NomalColor = System.Drawing.Color.DarkGoldenrod
        Me.BunifuDropdown3.onHoverColor = System.Drawing.Color.Goldenrod
        Me.BunifuDropdown3.selectedIndex = 0
        Me.BunifuDropdown3.Size = New System.Drawing.Size(206, 45)
        Me.BunifuDropdown3.TabIndex = 10274
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
        'HistoryTbl
        '
        Me.HistoryTbl.AllowUserToAddRows = False
        Me.HistoryTbl.AllowUserToDeleteRows = False
        Me.HistoryTbl.AllowUserToResizeColumns = False
        Me.HistoryTbl.AllowUserToResizeRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.Ivory
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Goldenrod
        Me.HistoryTbl.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.HistoryTbl.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.HistoryTbl.AutoGenerateColumns = False
        Me.HistoryTbl.BackgroundColor = System.Drawing.Color.Silver
        Me.HistoryTbl.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.HistoryTbl.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.HistoryTbl.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.DarkGoldenrod
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Goldenrod
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.HistoryTbl.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.HistoryTbl.ColumnHeadersHeight = 35
        Me.HistoryTbl.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.HistoryTbl.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IDDataGridViewTextBoxColumn, Me.EventDateDataGridViewTextBoxColumn, Me.WhoWasItDataGridViewTextBoxColumn, Me.ActionTakenDataGridViewTextBoxColumn, Me.ByWhoDataGridViewTextBoxColumn})
        Me.HistoryTbl.Cursor = System.Windows.Forms.Cursors.Hand
        Me.HistoryTbl.DataSource = Me.TblHistoryBindingSource
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Goldenrod
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.HistoryTbl.DefaultCellStyle = DataGridViewCellStyle3
        Me.HistoryTbl.EnableHeadersVisualStyles = False
        Me.HistoryTbl.Location = New System.Drawing.Point(12, 82)
        Me.HistoryTbl.Name = "HistoryTbl"
        Me.HistoryTbl.ReadOnly = True
        Me.HistoryTbl.RowHeadersVisible = False
        Me.HistoryTbl.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.HistoryTbl.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.HistoryTbl.Size = New System.Drawing.Size(1000, 513)
        Me.HistoryTbl.TabIndex = 10262
        '
        'IDDataGridViewTextBoxColumn
        '
        Me.IDDataGridViewTextBoxColumn.DataPropertyName = "ID"
        Me.IDDataGridViewTextBoxColumn.HeaderText = "ID"
        Me.IDDataGridViewTextBoxColumn.Name = "IDDataGridViewTextBoxColumn"
        Me.IDDataGridViewTextBoxColumn.ReadOnly = True
        '
        'EventDateDataGridViewTextBoxColumn
        '
        Me.EventDateDataGridViewTextBoxColumn.DataPropertyName = "eventDate"
        Me.EventDateDataGridViewTextBoxColumn.HeaderText = "eventDate"
        Me.EventDateDataGridViewTextBoxColumn.Name = "EventDateDataGridViewTextBoxColumn"
        Me.EventDateDataGridViewTextBoxColumn.ReadOnly = True
        Me.EventDateDataGridViewTextBoxColumn.Width = 300
        '
        'WhoWasItDataGridViewTextBoxColumn
        '
        Me.WhoWasItDataGridViewTextBoxColumn.DataPropertyName = "whoWasIt"
        Me.WhoWasItDataGridViewTextBoxColumn.HeaderText = "whoWasIt"
        Me.WhoWasItDataGridViewTextBoxColumn.Name = "WhoWasItDataGridViewTextBoxColumn"
        Me.WhoWasItDataGridViewTextBoxColumn.ReadOnly = True
        Me.WhoWasItDataGridViewTextBoxColumn.Width = 200
        '
        'ActionTakenDataGridViewTextBoxColumn
        '
        Me.ActionTakenDataGridViewTextBoxColumn.DataPropertyName = "actionTaken"
        Me.ActionTakenDataGridViewTextBoxColumn.HeaderText = "actionTaken"
        Me.ActionTakenDataGridViewTextBoxColumn.Name = "ActionTakenDataGridViewTextBoxColumn"
        Me.ActionTakenDataGridViewTextBoxColumn.ReadOnly = True
        Me.ActionTakenDataGridViewTextBoxColumn.Width = 200
        '
        'ByWhoDataGridViewTextBoxColumn
        '
        Me.ByWhoDataGridViewTextBoxColumn.DataPropertyName = "byWho"
        Me.ByWhoDataGridViewTextBoxColumn.HeaderText = "byWho"
        Me.ByWhoDataGridViewTextBoxColumn.Name = "ByWhoDataGridViewTextBoxColumn"
        Me.ByWhoDataGridViewTextBoxColumn.ReadOnly = True
        Me.ByWhoDataGridViewTextBoxColumn.Width = 200
        '
        'TblHistoryBindingSource
        '
        Me.TblHistoryBindingSource.DataMember = "tblHistory"
        Me.TblHistoryBindingSource.DataSource = Me.DbBrgySystemDataSet
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(474, 30)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(75, 16)
        Me.Button5.TabIndex = 10278
        Me.Button5.Text = "Button5"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'UsernameTextBox
        '
        Me.UsernameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblUserAccountsBindingSource, "username", True))
        Me.UsernameTextBox.Enabled = False
        Me.UsernameTextBox.Location = New System.Drawing.Point(726, 140)
        Me.UsernameTextBox.Name = "UsernameTextBox"
        Me.UsernameTextBox.Size = New System.Drawing.Size(100, 20)
        Me.UsernameTextBox.TabIndex = 10277
        '
        'TblUserAccountsDataGridView
        '
        Me.TblUserAccountsDataGridView.AutoGenerateColumns = False
        Me.TblUserAccountsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.TblUserAccountsDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn8})
        Me.TblUserAccountsDataGridView.DataSource = Me.TblUserAccountsBindingSource
        Me.TblUserAccountsDataGridView.Location = New System.Drawing.Point(526, 82)
        Me.TblUserAccountsDataGridView.Name = "TblUserAccountsDataGridView"
        Me.TblUserAccountsDataGridView.Size = New System.Drawing.Size(300, 220)
        Me.TblUserAccountsDataGridView.TabIndex = 10276
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "username"
        Me.DataGridViewTextBoxColumn1.HeaderText = "username"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "firstName"
        Me.DataGridViewTextBoxColumn2.HeaderText = "firstName"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "MI"
        Me.DataGridViewTextBoxColumn3.HeaderText = "MI"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "lastName"
        Me.DataGridViewTextBoxColumn4.HeaderText = "lastName"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "PIN"
        Me.DataGridViewTextBoxColumn5.HeaderText = "PIN"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "userType"
        Me.DataGridViewTextBoxColumn6.HeaderText = "userType"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "password"
        Me.DataGridViewTextBoxColumn7.HeaderText = "password"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "position"
        Me.DataGridViewTextBoxColumn8.HeaderText = "position"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(322, 30)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(47, 22)
        Me.Label5.TabIndex = 10275
        Me.Label5.Text = "User:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(13, 29)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(61, 22)
        Me.Label2.TabIndex = 10275
        Me.Label2.Text = "Action:"
        '
        'BunifuDropdown2
        '
        Me.BunifuDropdown2.BackColor = System.Drawing.Color.Transparent
        Me.BunifuDropdown2.BorderRadius = 3
        Me.BunifuDropdown2.DisabledColor = System.Drawing.Color.Gray
        Me.BunifuDropdown2.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Bold)
        Me.BunifuDropdown2.ForeColor = System.Drawing.Color.White
        Me.BunifuDropdown2.Items = New String() {"All", "Login to database", "Add Resident", "Modify Resident", "Delete Resident", "Add Blotter"}
        Me.BunifuDropdown2.Location = New System.Drawing.Point(81, 17)
        Me.BunifuDropdown2.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.BunifuDropdown2.Name = "BunifuDropdown2"
        Me.BunifuDropdown2.NomalColor = System.Drawing.Color.DarkGoldenrod
        Me.BunifuDropdown2.onHoverColor = System.Drawing.Color.Goldenrod
        Me.BunifuDropdown2.selectedIndex = -1
        Me.BunifuDropdown2.Size = New System.Drawing.Size(206, 45)
        Me.BunifuDropdown2.TabIndex = 10274
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(264, 340)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(75, 23)
        Me.Button4.TabIndex = 10273
        Me.Button4.Text = "Button4"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(264, 311)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(75, 23)
        Me.Button3.TabIndex = 10272
        Me.Button3.Text = "Button3"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'IDTextBox
        '
        Me.IDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblHistoryBindingSource, "ID", True))
        Me.IDTextBox.Enabled = False
        Me.IDTextBox.Location = New System.Drawing.Point(302, 167)
        Me.IDTextBox.Name = "IDTextBox"
        Me.IDTextBox.Size = New System.Drawing.Size(200, 20)
        Me.IDTextBox.TabIndex = 10263
        '
        'EventDateDateTimePicker
        '
        Me.EventDateDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.TblHistoryBindingSource, "eventDate", True))
        Me.EventDateDateTimePicker.Enabled = False
        Me.EventDateDateTimePicker.Location = New System.Drawing.Point(302, 193)
        Me.EventDateDateTimePicker.Name = "EventDateDateTimePicker"
        Me.EventDateDateTimePicker.Size = New System.Drawing.Size(200, 20)
        Me.EventDateDateTimePicker.TabIndex = 10265
        '
        'WhoWasItTextBox
        '
        Me.WhoWasItTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblHistoryBindingSource, "whoWasIt", True))
        Me.WhoWasItTextBox.Enabled = False
        Me.WhoWasItTextBox.Location = New System.Drawing.Point(302, 219)
        Me.WhoWasItTextBox.Name = "WhoWasItTextBox"
        Me.WhoWasItTextBox.Size = New System.Drawing.Size(200, 20)
        Me.WhoWasItTextBox.TabIndex = 10267
        '
        'ActionTakenTextBox
        '
        Me.ActionTakenTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblHistoryBindingSource, "actionTaken", True))
        Me.ActionTakenTextBox.Enabled = False
        Me.ActionTakenTextBox.Location = New System.Drawing.Point(302, 245)
        Me.ActionTakenTextBox.Name = "ActionTakenTextBox"
        Me.ActionTakenTextBox.Size = New System.Drawing.Size(200, 20)
        Me.ActionTakenTextBox.TabIndex = 10269
        '
        'ByWhoTextBox
        '
        Me.ByWhoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblHistoryBindingSource, "byWho", True))
        Me.ByWhoTextBox.Enabled = False
        Me.ByWhoTextBox.Location = New System.Drawing.Point(302, 271)
        Me.ByWhoTextBox.Name = "ByWhoTextBox"
        Me.ByWhoTextBox.Size = New System.Drawing.Size(200, 20)
        Me.ByWhoTextBox.TabIndex = 10271
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(499, 49)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(39, 13)
        Me.Label6.TabIndex = 10279
        Me.Label6.Text = "Label6"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(157, 49)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(39, 13)
        Me.Label4.TabIndex = 10276
        Me.Label4.Text = "Label4"
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
        Me.Guna2Elipse2.BorderRadius = 10
        '
        'Guna2Elipse4
        '
        Me.Guna2Elipse4.BorderRadius = 10
        Me.Guna2Elipse4.TargetControl = Me.BunifuDropdown2
        '
        'TblHistoryTableAdapter
        '
        Me.TblHistoryTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.tblBlotterTableAdapter = Nothing
        Me.TableAdapterManager.tblDatabaseTableAdapter = Nothing
        Me.TableAdapterManager.tblHistoryTableAdapter = Me.TblHistoryTableAdapter
        Me.TableAdapterManager.tblIncrementsTableAdapter = Nothing
        Me.TableAdapterManager.tblOrganizationTableAdapter = Nothing
        Me.TableAdapterManager.tblPrintIndigencyTableAdapter = Nothing
        Me.TableAdapterManager.tblResidentsTableAdapter = Nothing
        Me.TableAdapterManager.tblSysSettingsTableAdapter = Nothing
        Me.TableAdapterManager.tblUserAccountsTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = BarangaySystem.dbBrgySystemDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'TblUserAccountsTableAdapter
        '
        Me.TblUserAccountsTableAdapter.ClearBeforeFill = True
        '
        'Timer1
        '
        '
        'frmHistory
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1128, 691)
        Me.Controls.Add(Me.Guna2Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MaximumSize = New System.Drawing.Size(1128, 691)
        Me.MinimumSize = New System.Drawing.Size(1128, 691)
        Me.Name = "frmHistory"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmHistory"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.picCurrentFrm, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Guna2Panel2.ResumeLayout(False)
        Me.Guna2Panel2.PerformLayout()
        CType(Me.TblUserAccountsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DbBrgySystemDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.HistoryTbl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblHistoryBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblUserAccountsDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents lblCurrentFrm As System.Windows.Forms.Label
    Friend WithEvents picCurrentFrm As Guna.UI2.WinForms.Guna2PictureBox
    Friend WithEvents Guna2Panel2 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Guna2Elipse1 As Guna.UI2.WinForms.Guna2Elipse
    Friend WithEvents Guna2Elipse3 As Guna.UI2.WinForms.Guna2Elipse
    Friend WithEvents HistoryTbl As System.Windows.Forms.DataGridView
    Friend WithEvents DbBrgySystemDataSet As BarangaySystem.dbBrgySystemDataSet
    Friend WithEvents TblHistoryBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TblHistoryTableAdapter As BarangaySystem.dbBrgySystemDataSetTableAdapters.tblHistoryTableAdapter
    Friend WithEvents TableAdapterManager As BarangaySystem.dbBrgySystemDataSetTableAdapters.TableAdapterManager
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents IDTextBox As System.Windows.Forms.TextBox
    Friend WithEvents EventDateDateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents WhoWasItTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ActionTakenTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ByWhoTextBox As System.Windows.Forms.TextBox
    Friend WithEvents IDDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents EventDateDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents WhoWasItDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ActionTakenDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ByWhoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents BunifuDropdown2 As Bunifu.Framework.UI.BunifuDropdown
    Friend WithEvents Guna2Elipse2 As Guna.UI2.WinForms.Guna2Elipse
    Friend WithEvents Guna2Elipse4 As Guna.UI2.WinForms.Guna2Elipse
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents BunifuDropdown3 As Bunifu.Framework.UI.BunifuDropdown
    Friend WithEvents TblUserAccountsBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TblUserAccountsTableAdapter As BarangaySystem.dbBrgySystemDataSetTableAdapters.tblUserAccountsTableAdapter
    Friend WithEvents UsernameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents TblUserAccountsDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
End Class
