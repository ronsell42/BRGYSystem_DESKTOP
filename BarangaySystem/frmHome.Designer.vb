<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmHome
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
        Dim ByWhoLabel As System.Windows.Forms.Label
        Dim ActionTakenLabel As System.Windows.Forms.Label
        Dim WhoWasItLabel As System.Windows.Forms.Label
        Dim EventDateLabel As System.Windows.Forms.Label
        Dim IDLabel As System.Windows.Forms.Label
        Dim FirstParagraphLabel As System.Windows.Forms.Label
        Dim ChartArea1 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend1 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series1 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.lblCurrentFrm = New System.Windows.Forms.Label()
        Me.picCurrentFrm = New Guna.UI2.WinForms.Guna2PictureBox()
        Me.Guna2Panel1 = New Guna.UI2.WinForms.Guna2Panel()
        Me.EventDateDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.TblHistoryBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DbBrgySystemDataSet = New BarangaySystem.dbBrgySystemDataSet()
        Me.TblHistoryDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.WhoWasItTextBox = New System.Windows.Forms.TextBox()
        Me.ActionTakenTextBox = New System.Windows.Forms.TextBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.IDTextBox = New System.Windows.Forms.TextBox()
        Me.ByWhoTextBox = New System.Windows.Forms.TextBox()
        Me.Guna2Elipse1 = New Guna.UI2.WinForms.Guna2Elipse(Me.components)
        Me.Guna2Panel2 = New Guna.UI2.WinForms.Guna2Panel()
        Me.FirstParagraphTextBox = New System.Windows.Forms.TextBox()
        Me.TblPrintIndigencyBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button9 = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.lblTotalRes = New System.Windows.Forms.Button()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Button8 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Chart1 = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Guna2Elipse2 = New Guna.UI2.WinForms.Guna2Elipse(Me.components)
        Me.Guna2Elipse3 = New Guna.UI2.WinForms.Guna2Elipse(Me.components)
        Me.TblHistoryTableAdapter = New BarangaySystem.dbBrgySystemDataSetTableAdapters.tblHistoryTableAdapter()
        Me.TableAdapterManager = New BarangaySystem.dbBrgySystemDataSetTableAdapters.TableAdapterManager()
        Me.TblResidentsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TblResidentsTableAdapter = New BarangaySystem.dbBrgySystemDataSetTableAdapters.tblResidentsTableAdapter()
        Me.Guna2Elipse4 = New Guna.UI2.WinForms.Guna2Elipse(Me.components)
        Me.Guna2Elipse5 = New Guna.UI2.WinForms.Guna2Elipse(Me.components)
        Me.Guna2Elipse6 = New Guna.UI2.WinForms.Guna2Elipse(Me.components)
        Me.Guna2Elipse7 = New Guna.UI2.WinForms.Guna2Elipse(Me.components)
        Me.TblPrintIndigencyTableAdapter = New BarangaySystem.dbBrgySystemDataSetTableAdapters.tblPrintIndigencyTableAdapter()
        ByWhoLabel = New System.Windows.Forms.Label()
        ActionTakenLabel = New System.Windows.Forms.Label()
        WhoWasItLabel = New System.Windows.Forms.Label()
        EventDateLabel = New System.Windows.Forms.Label()
        IDLabel = New System.Windows.Forms.Label()
        FirstParagraphLabel = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        CType(Me.picCurrentFrm, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Guna2Panel1.SuspendLayout()
        CType(Me.TblHistoryBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DbBrgySystemDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblHistoryDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Guna2Panel2.SuspendLayout()
        CType(Me.TblPrintIndigencyBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Chart1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblResidentsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ByWhoLabel
        '
        ByWhoLabel.AutoSize = True
        ByWhoLabel.Enabled = False
        ByWhoLabel.Location = New System.Drawing.Point(119, 165)
        ByWhoLabel.Name = "ByWhoLabel"
        ByWhoLabel.Size = New System.Drawing.Size(47, 13)
        ByWhoLabel.TabIndex = 13
        ByWhoLabel.Text = "by Who:"
        '
        'ActionTakenLabel
        '
        ActionTakenLabel.AutoSize = True
        ActionTakenLabel.Enabled = False
        ActionTakenLabel.Location = New System.Drawing.Point(119, 177)
        ActionTakenLabel.Name = "ActionTakenLabel"
        ActionTakenLabel.Size = New System.Drawing.Size(73, 13)
        ActionTakenLabel.TabIndex = 11
        ActionTakenLabel.Text = "action Taken:"
        '
        'WhoWasItLabel
        '
        WhoWasItLabel.AutoSize = True
        WhoWasItLabel.Enabled = False
        WhoWasItLabel.Location = New System.Drawing.Point(119, 151)
        WhoWasItLabel.Name = "WhoWasItLabel"
        WhoWasItLabel.Size = New System.Drawing.Size(64, 13)
        WhoWasItLabel.TabIndex = 9
        WhoWasItLabel.Text = "who Was It:"
        '
        'EventDateLabel
        '
        EventDateLabel.AutoSize = True
        EventDateLabel.Enabled = False
        EventDateLabel.Location = New System.Drawing.Point(119, 126)
        EventDateLabel.Name = "EventDateLabel"
        EventDateLabel.Size = New System.Drawing.Size(63, 13)
        EventDateLabel.TabIndex = 7
        EventDateLabel.Text = "event Date:"
        '
        'IDLabel
        '
        IDLabel.AutoSize = True
        IDLabel.Enabled = False
        IDLabel.Location = New System.Drawing.Point(119, 102)
        IDLabel.Name = "IDLabel"
        IDLabel.Size = New System.Drawing.Size(21, 13)
        IDLabel.TabIndex = 5
        IDLabel.Text = "ID:"
        '
        'FirstParagraphLabel
        '
        FirstParagraphLabel.AutoSize = True
        FirstParagraphLabel.Location = New System.Drawing.Point(875, 219)
        FirstParagraphLabel.Name = "FirstParagraphLabel"
        FirstParagraphLabel.Size = New System.Drawing.Size(78, 13)
        FirstParagraphLabel.TabIndex = 10261
        FirstParagraphLabel.Text = "first Paragraph:"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.Controls.Add(Me.lblCurrentFrm)
        Me.Panel1.Controls.Add(Me.picCurrentFrm)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1170, 63)
        Me.Panel1.TabIndex = 6
        '
        'lblCurrentFrm
        '
        Me.lblCurrentFrm.AutoSize = True
        Me.lblCurrentFrm.Font = New System.Drawing.Font("Trebuchet MS", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCurrentFrm.Location = New System.Drawing.Point(64, 12)
        Me.lblCurrentFrm.Name = "lblCurrentFrm"
        Me.lblCurrentFrm.Size = New System.Drawing.Size(99, 40)
        Me.lblCurrentFrm.TabIndex = 4
        Me.lblCurrentFrm.Text = "Home"
        '
        'picCurrentFrm
        '
        Me.picCurrentFrm.Image = Global.BarangaySystem.My.Resources.Resources.iconHome
        Me.picCurrentFrm.ImageRotate = 0.0!
        Me.picCurrentFrm.Location = New System.Drawing.Point(6, 12)
        Me.picCurrentFrm.Name = "picCurrentFrm"
        Me.picCurrentFrm.Size = New System.Drawing.Size(63, 38)
        Me.picCurrentFrm.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picCurrentFrm.TabIndex = 3
        Me.picCurrentFrm.TabStop = False
        '
        'Guna2Panel1
        '
        Me.Guna2Panel1.AutoRoundedCorners = True
        Me.Guna2Panel1.BackColor = System.Drawing.Color.White
        Me.Guna2Panel1.BorderRadius = 279
        Me.Guna2Panel1.Controls.Add(Me.EventDateDateTimePicker)
        Me.Guna2Panel1.Controls.Add(Me.TblHistoryDataGridView)
        Me.Guna2Panel1.Controls.Add(WhoWasItLabel)
        Me.Guna2Panel1.Controls.Add(Me.WhoWasItTextBox)
        Me.Guna2Panel1.Controls.Add(ActionTakenLabel)
        Me.Guna2Panel1.Controls.Add(Me.ActionTakenTextBox)
        Me.Guna2Panel1.Controls.Add(Me.Button2)
        Me.Guna2Panel1.Controls.Add(Me.Button1)
        Me.Guna2Panel1.Controls.Add(IDLabel)
        Me.Guna2Panel1.Controls.Add(Me.IDTextBox)
        Me.Guna2Panel1.Controls.Add(EventDateLabel)
        Me.Guna2Panel1.Controls.Add(Me.ByWhoTextBox)
        Me.Guna2Panel1.Controls.Add(ByWhoLabel)
        Me.Guna2Panel1.Location = New System.Drawing.Point(567, 69)
        Me.Guna2Panel1.Name = "Guna2Panel1"
        Me.Guna2Panel1.Size = New System.Drawing.Size(560, 610)
        Me.Guna2Panel1.TabIndex = 7
        '
        'EventDateDateTimePicker
        '
        Me.EventDateDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.TblHistoryBindingSource, "eventDate", True))
        Me.EventDateDateTimePicker.Enabled = False
        Me.EventDateDateTimePicker.Location = New System.Drawing.Point(198, 122)
        Me.EventDateDateTimePicker.Name = "EventDateDateTimePicker"
        Me.EventDateDateTimePicker.Size = New System.Drawing.Size(78, 20)
        Me.EventDateDateTimePicker.TabIndex = 8
        '
        'TblHistoryBindingSource
        '
        Me.TblHistoryBindingSource.DataMember = "tblHistory"
        Me.TblHistoryBindingSource.DataSource = Me.DbBrgySystemDataSet
        '
        'DbBrgySystemDataSet
        '
        Me.DbBrgySystemDataSet.DataSetName = "dbBrgySystemDataSet"
        Me.DbBrgySystemDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TblHistoryDataGridView
        '
        Me.TblHistoryDataGridView.AutoGenerateColumns = False
        Me.TblHistoryDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.TblHistoryDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5})
        Me.TblHistoryDataGridView.DataSource = Me.TblHistoryBindingSource
        Me.TblHistoryDataGridView.Location = New System.Drawing.Point(173, 312)
        Me.TblHistoryDataGridView.Name = "TblHistoryDataGridView"
        Me.TblHistoryDataGridView.Size = New System.Drawing.Size(254, 144)
        Me.TblHistoryDataGridView.TabIndex = 5
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "ID"
        Me.DataGridViewTextBoxColumn1.HeaderText = "ID"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "eventDate"
        Me.DataGridViewTextBoxColumn2.HeaderText = "eventDate"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "whoWasIt"
        Me.DataGridViewTextBoxColumn3.HeaderText = "whoWasIt"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "actionTaken"
        Me.DataGridViewTextBoxColumn4.HeaderText = "actionTaken"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "byWho"
        Me.DataGridViewTextBoxColumn5.HeaderText = "byWho"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        '
        'WhoWasItTextBox
        '
        Me.WhoWasItTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblHistoryBindingSource, "whoWasIt", True))
        Me.WhoWasItTextBox.Enabled = False
        Me.WhoWasItTextBox.Location = New System.Drawing.Point(198, 148)
        Me.WhoWasItTextBox.Name = "WhoWasItTextBox"
        Me.WhoWasItTextBox.Size = New System.Drawing.Size(78, 20)
        Me.WhoWasItTextBox.TabIndex = 10
        '
        'ActionTakenTextBox
        '
        Me.ActionTakenTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblHistoryBindingSource, "actionTaken", True))
        Me.ActionTakenTextBox.Enabled = False
        Me.ActionTakenTextBox.Location = New System.Drawing.Point(198, 174)
        Me.ActionTakenTextBox.Name = "ActionTakenTextBox"
        Me.ActionTakenTextBox.Size = New System.Drawing.Size(78, 20)
        Me.ActionTakenTextBox.TabIndex = 12
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(301, 155)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 10301
        Me.Button2.Text = "Button2"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(301, 120)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(77, 29)
        Me.Button1.TabIndex = 10300
        Me.Button1.Text = "Button1"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'IDTextBox
        '
        Me.IDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblHistoryBindingSource, "ID", True))
        Me.IDTextBox.Enabled = False
        Me.IDTextBox.Location = New System.Drawing.Point(198, 119)
        Me.IDTextBox.Name = "IDTextBox"
        Me.IDTextBox.Size = New System.Drawing.Size(78, 20)
        Me.IDTextBox.TabIndex = 6
        '
        'ByWhoTextBox
        '
        Me.ByWhoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblHistoryBindingSource, "byWho", True))
        Me.ByWhoTextBox.Enabled = False
        Me.ByWhoTextBox.Location = New System.Drawing.Point(198, 177)
        Me.ByWhoTextBox.Name = "ByWhoTextBox"
        Me.ByWhoTextBox.Size = New System.Drawing.Size(78, 20)
        Me.ByWhoTextBox.TabIndex = 14
        '
        'Guna2Elipse1
        '
        Me.Guna2Elipse1.BorderRadius = 30
        Me.Guna2Elipse1.TargetControl = Me.Guna2Panel1
        '
        'Guna2Panel2
        '
        Me.Guna2Panel2.AutoRoundedCorners = True
        Me.Guna2Panel2.BackColor = System.Drawing.Color.White
        Me.Guna2Panel2.BorderRadius = 312
        Me.Guna2Panel2.Controls.Add(Me.PictureBox4)
        Me.Guna2Panel2.Controls.Add(Me.PictureBox3)
        Me.Guna2Panel2.Controls.Add(Me.PictureBox2)
        Me.Guna2Panel2.Controls.Add(Me.PictureBox1)
        Me.Guna2Panel2.Controls.Add(Me.Button5)
        Me.Guna2Panel2.Controls.Add(Me.Button9)
        Me.Guna2Panel2.Controls.Add(Me.Label7)
        Me.Guna2Panel2.Controls.Add(Me.Button7)
        Me.Guna2Panel2.Controls.Add(Me.lblTotalRes)
        Me.Guna2Panel2.Controls.Add(Me.Label9)
        Me.Guna2Panel2.Controls.Add(Me.Label6)
        Me.Guna2Panel2.Controls.Add(Me.Button4)
        Me.Guna2Panel2.Controls.Add(Me.Label8)
        Me.Guna2Panel2.Controls.Add(Me.Button8)
        Me.Guna2Panel2.Controls.Add(Me.Button3)
        Me.Guna2Panel2.Controls.Add(Me.Label1)
        Me.Guna2Panel2.Controls.Add(Me.Chart1)
        Me.Guna2Panel2.Controls.Add(Me.Button6)
        Me.Guna2Panel2.Controls.Add(FirstParagraphLabel)
        Me.Guna2Panel2.Controls.Add(Me.FirstParagraphTextBox)
        Me.Guna2Panel2.Location = New System.Drawing.Point(0, 69)
        Me.Guna2Panel2.Name = "Guna2Panel2"
        Me.Guna2Panel2.Size = New System.Drawing.Size(1170, 627)
        Me.Guna2Panel2.TabIndex = 7
        '
        'FirstParagraphTextBox
        '
        Me.FirstParagraphTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblPrintIndigencyBindingSource, "firstParagraph", True))
        Me.FirstParagraphTextBox.Location = New System.Drawing.Point(959, 216)
        Me.FirstParagraphTextBox.Name = "FirstParagraphTextBox"
        Me.FirstParagraphTextBox.Size = New System.Drawing.Size(100, 20)
        Me.FirstParagraphTextBox.TabIndex = 10262
        '
        'TblPrintIndigencyBindingSource
        '
        Me.TblPrintIndigencyBindingSource.DataMember = "tblPrintIndigency"
        Me.TblPrintIndigencyBindingSource.DataSource = Me.DbBrgySystemDataSet
        '
        'PictureBox4
        '
        Me.PictureBox4.BackColor = System.Drawing.Color.SeaGreen
        Me.PictureBox4.Image = Global.BarangaySystem.My.Resources.Resources.printer
        Me.PictureBox4.Location = New System.Drawing.Point(933, 98)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(100, 99)
        Me.PictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox4.TabIndex = 10261
        Me.PictureBox4.TabStop = False
        '
        'PictureBox3
        '
        Me.PictureBox3.BackColor = System.Drawing.Color.Firebrick
        Me.PictureBox3.Image = Global.BarangaySystem.My.Resources.Resources.woman
        Me.PictureBox3.Location = New System.Drawing.Point(650, 102)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(100, 99)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox3.TabIndex = 10261
        Me.PictureBox3.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.DodgerBlue
        Me.PictureBox2.Image = Global.BarangaySystem.My.Resources.Resources.man
        Me.PictureBox2.Location = New System.Drawing.Point(374, 102)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(100, 99)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox2.TabIndex = 10261
        Me.PictureBox2.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Goldenrod
        Me.PictureBox1.Image = Global.BarangaySystem.My.Resources.Resources.iconResidents
        Me.PictureBox1.Location = New System.Drawing.Point(95, 102)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(100, 99)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 10261
        Me.PictureBox1.TabStop = False
        '
        'Button5
        '
        Me.Button5.BackColor = System.Drawing.Color.SeaGreen
        Me.Button5.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button5.FlatAppearance.BorderColor = System.Drawing.Color.SeaGreen
        Me.Button5.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SeaGreen
        Me.Button5.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SeaGreen
        Me.Button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button5.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button5.ForeColor = System.Drawing.Color.White
        Me.Button5.Location = New System.Drawing.Point(855, 191)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(36, 51)
        Me.Button5.TabIndex = 10258
        Me.Button5.Text = "0"
        Me.Button5.UseVisualStyleBackColor = False
        '
        'Button9
        '
        Me.Button9.BackColor = System.Drawing.Color.DodgerBlue
        Me.Button9.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button9.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue
        Me.Button9.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DodgerBlue
        Me.Button9.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DodgerBlue
        Me.Button9.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button9.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button9.ForeColor = System.Drawing.Color.White
        Me.Button9.Location = New System.Drawing.Point(302, 191)
        Me.Button9.Name = "Button9"
        Me.Button9.Size = New System.Drawing.Size(32, 51)
        Me.Button9.TabIndex = 10258
        Me.Button9.Text = "0"
        Me.Button9.UseVisualStyleBackColor = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.SeaGreen
        Me.Label7.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(865, 66)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(194, 25)
        Me.Label7.TabIndex = 10257
        Me.Label7.Text = "Printed Documents"
        '
        'Button7
        '
        Me.Button7.BackColor = System.Drawing.Color.Firebrick
        Me.Button7.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button7.FlatAppearance.BorderColor = System.Drawing.Color.Firebrick
        Me.Button7.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Firebrick
        Me.Button7.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Firebrick
        Me.Button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button7.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button7.ForeColor = System.Drawing.Color.White
        Me.Button7.Location = New System.Drawing.Point(570, 191)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(52, 50)
        Me.Button7.TabIndex = 10258
        Me.Button7.Text = "0"
        Me.Button7.UseVisualStyleBackColor = False
        '
        'lblTotalRes
        '
        Me.lblTotalRes.BackColor = System.Drawing.Color.Goldenrod
        Me.lblTotalRes.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblTotalRes.FlatAppearance.BorderColor = System.Drawing.Color.Goldenrod
        Me.lblTotalRes.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Goldenrod
        Me.lblTotalRes.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Goldenrod
        Me.lblTotalRes.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lblTotalRes.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalRes.ForeColor = System.Drawing.Color.White
        Me.lblTotalRes.Location = New System.Drawing.Point(22, 191)
        Me.lblTotalRes.Name = "lblTotalRes"
        Me.lblTotalRes.Size = New System.Drawing.Size(47, 51)
        Me.lblTotalRes.TabIndex = 10258
        Me.lblTotalRes.Text = "0"
        Me.lblTotalRes.UseVisualStyleBackColor = False
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.DodgerBlue
        Me.Label9.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.White
        Me.Label9.Location = New System.Drawing.Point(316, 66)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(113, 25)
        Me.Label9.TabIndex = 10257
        Me.Label9.Text = "Total Male"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Goldenrod
        Me.Label6.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(33, 66)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(162, 25)
        Me.Label6.TabIndex = 10257
        Me.Label6.Text = "Total Residents"
        '
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.Color.SeaGreen
        Me.Button4.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button4.FlatAppearance.BorderColor = System.Drawing.Color.SeaGreen
        Me.Button4.FlatAppearance.BorderSize = 0
        Me.Button4.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SeaGreen
        Me.Button4.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SeaGreen
        Me.Button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button4.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button4.Location = New System.Drawing.Point(849, 61)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(259, 183)
        Me.Button4.TabIndex = 10256
        Me.Button4.UseVisualStyleBackColor = False
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Firebrick
        Me.Label8.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.White
        Me.Label8.Location = New System.Drawing.Point(583, 65)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(137, 25)
        Me.Label8.TabIndex = 10257
        Me.Label8.Text = "Total Female"
        '
        'Button8
        '
        Me.Button8.BackColor = System.Drawing.Color.DodgerBlue
        Me.Button8.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button8.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue
        Me.Button8.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DodgerBlue
        Me.Button8.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DodgerBlue
        Me.Button8.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button8.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button8.Location = New System.Drawing.Point(293, 61)
        Me.Button8.Name = "Button8"
        Me.Button8.Size = New System.Drawing.Size(259, 183)
        Me.Button8.TabIndex = 10256
        Me.Button8.UseVisualStyleBackColor = False
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.Goldenrod
        Me.Button3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button3.FlatAppearance.BorderColor = System.Drawing.Color.Goldenrod
        Me.Button3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Goldenrod
        Me.Button3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Goldenrod
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button3.Location = New System.Drawing.Point(17, 61)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(259, 183)
        Me.Button3.TabIndex = 10256
        Me.Button3.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Trebuchet MS", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 17)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(500, 29)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Barangay Pili, Pinamalayan, Oriental Mindoro"
        '
        'Chart1
        '
        ChartArea1.Name = "ChartArea1"
        Me.Chart1.ChartAreas.Add(ChartArea1)
        Me.Chart1.Cursor = System.Windows.Forms.Cursors.Hand
        Legend1.Name = "Legend1"
        Me.Chart1.Legends.Add(Legend1)
        Me.Chart1.Location = New System.Drawing.Point(3, 245)
        Me.Chart1.Name = "Chart1"
        Me.Chart1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Pastel
        Series1.ChartArea = "ChartArea1"
        Series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Doughnut
        Series1.Legend = "Legend1"
        Series1.Name = "course"
        Me.Chart1.Series.Add(Series1)
        Me.Chart1.Size = New System.Drawing.Size(823, 362)
        Me.Chart1.TabIndex = 10260
        Me.Chart1.Text = "Chart1"
        '
        'Button6
        '
        Me.Button6.BackColor = System.Drawing.Color.Firebrick
        Me.Button6.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button6.FlatAppearance.BorderColor = System.Drawing.Color.Firebrick
        Me.Button6.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Firebrick
        Me.Button6.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Firebrick
        Me.Button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button6.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button6.Location = New System.Drawing.Point(567, 60)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(259, 184)
        Me.Button6.TabIndex = 10256
        Me.Button6.UseVisualStyleBackColor = False
        '
        'Guna2Elipse2
        '
        Me.Guna2Elipse2.BorderRadius = 30
        Me.Guna2Elipse2.TargetControl = Me.Guna2Panel2
        '
        'Guna2Elipse3
        '
        Me.Guna2Elipse3.BorderRadius = 30
        Me.Guna2Elipse3.TargetControl = Me.Panel1
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
        'TblResidentsBindingSource
        '
        Me.TblResidentsBindingSource.DataMember = "tblResidents"
        Me.TblResidentsBindingSource.DataSource = Me.DbBrgySystemDataSet
        '
        'TblResidentsTableAdapter
        '
        Me.TblResidentsTableAdapter.ClearBeforeFill = True
        '
        'Guna2Elipse4
        '
        Me.Guna2Elipse4.BorderRadius = 20
        Me.Guna2Elipse4.TargetControl = Me.Button3
        '
        'Guna2Elipse5
        '
        Me.Guna2Elipse5.BorderRadius = 20
        Me.Guna2Elipse5.TargetControl = Me.Button4
        '
        'Guna2Elipse6
        '
        Me.Guna2Elipse6.BorderRadius = 20
        Me.Guna2Elipse6.TargetControl = Me.Button6
        '
        'Guna2Elipse7
        '
        Me.Guna2Elipse7.BorderRadius = 20
        Me.Guna2Elipse7.TargetControl = Me.Button8
        '
        'TblPrintIndigencyTableAdapter
        '
        Me.TblPrintIndigencyTableAdapter.ClearBeforeFill = True
        '
        'frmHome
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(1128, 691)
        Me.Controls.Add(Me.Guna2Panel2)
        Me.Controls.Add(Me.Guna2Panel1)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MaximumSize = New System.Drawing.Size(1128, 691)
        Me.MinimumSize = New System.Drawing.Size(1128, 691)
        Me.Name = "frmHome"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmHome"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.picCurrentFrm, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Guna2Panel1.ResumeLayout(False)
        Me.Guna2Panel1.PerformLayout()
        CType(Me.TblHistoryBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DbBrgySystemDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblHistoryDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Guna2Panel2.ResumeLayout(False)
        Me.Guna2Panel2.PerformLayout()
        CType(Me.TblPrintIndigencyBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Chart1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblResidentsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents lblCurrentFrm As System.Windows.Forms.Label
    Friend WithEvents picCurrentFrm As Guna.UI2.WinForms.Guna2PictureBox
    Friend WithEvents Guna2Panel1 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Guna2Elipse1 As Guna.UI2.WinForms.Guna2Elipse
    Friend WithEvents Guna2Panel2 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Guna2Elipse2 As Guna.UI2.WinForms.Guna2Elipse
    Friend WithEvents Guna2Elipse3 As Guna.UI2.WinForms.Guna2Elipse
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents DbBrgySystemDataSet As BarangaySystem.dbBrgySystemDataSet
    Friend WithEvents TblHistoryBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TblHistoryTableAdapter As BarangaySystem.dbBrgySystemDataSetTableAdapters.tblHistoryTableAdapter
    Friend WithEvents TableAdapterManager As BarangaySystem.dbBrgySystemDataSetTableAdapters.TableAdapterManager
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents IDTextBox As System.Windows.Forms.TextBox
    Friend WithEvents EventDateDateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents WhoWasItTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ActionTakenTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ByWhoTextBox As System.Windows.Forms.TextBox
    Friend WithEvents TblHistoryDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents lblTotalRes As System.Windows.Forms.Button
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents TblResidentsBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TblResidentsTableAdapter As BarangaySystem.dbBrgySystemDataSetTableAdapters.tblResidentsTableAdapter
    Friend WithEvents Chart1 As System.Windows.Forms.DataVisualization.Charting.Chart
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents Guna2Elipse4 As Guna.UI2.WinForms.Guna2Elipse
    Friend WithEvents Guna2Elipse5 As Guna.UI2.WinForms.Guna2Elipse
    Friend WithEvents Button9 As System.Windows.Forms.Button
    Friend WithEvents Button7 As System.Windows.Forms.Button
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Button8 As System.Windows.Forms.Button
    Friend WithEvents Button6 As System.Windows.Forms.Button
    Friend WithEvents Guna2Elipse6 As Guna.UI2.WinForms.Guna2Elipse
    Friend WithEvents Guna2Elipse7 As Guna.UI2.WinForms.Guna2Elipse
    Friend WithEvents PictureBox4 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox3 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents TblPrintIndigencyBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TblPrintIndigencyTableAdapter As BarangaySystem.dbBrgySystemDataSetTableAdapters.tblPrintIndigencyTableAdapter
    Friend WithEvents FirstParagraphTextBox As System.Windows.Forms.TextBox
End Class
