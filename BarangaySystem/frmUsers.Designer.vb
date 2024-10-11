<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmUsers
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
        Dim UsernameLabel As System.Windows.Forms.Label
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Guna2Button4 = New Guna.UI2.WinForms.Guna2Button()
        Me.Guna2Button6 = New Guna.UI2.WinForms.Guna2Button()
        Me.Guna2Button7 = New Guna.UI2.WinForms.Guna2Button()
        Me.TblUserAccountsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DbBrgySystemDataSetBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DbBrgySystemDataSet = New BarangaySystem.dbBrgySystemDataSet()
        Me.UsernameTextBox = New System.Windows.Forms.TextBox()
        Me.Guna2Button8 = New Guna.UI2.WinForms.Guna2Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.ResidentsTbl = New System.Windows.Forms.DataGridView()
        Me.firstName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MI = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.lastName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UsernameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UserTypeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TblUserAccountsTableAdapter = New BarangaySystem.dbBrgySystemDataSetTableAdapters.tblUserAccountsTableAdapter()
        Me.TableAdapterManager = New BarangaySystem.dbBrgySystemDataSetTableAdapters.TableAdapterManager()
        UsernameLabel = New System.Windows.Forms.Label()
        CType(Me.TblUserAccountsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DbBrgySystemDataSetBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DbBrgySystemDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ResidentsTbl, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'UsernameLabel
        '
        UsernameLabel.AutoSize = True
        UsernameLabel.Location = New System.Drawing.Point(491, 67)
        UsernameLabel.Name = "UsernameLabel"
        UsernameLabel.Size = New System.Drawing.Size(56, 13)
        UsernameLabel.TabIndex = 10299
        UsernameLabel.Text = "username:"
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
        Me.Guna2Button4.Location = New System.Drawing.Point(184, 1)
        Me.Guna2Button4.Name = "Guna2Button4"
        Me.Guna2Button4.Size = New System.Drawing.Size(80, 45)
        Me.Guna2Button4.TabIndex = 10296
        Me.Guna2Button4.Text = "Delete"
        Me.Guna2Button4.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.Guna2Button4.TextOffset = New System.Drawing.Point(-5, 0)
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
        Me.Guna2Button6.FillColor = System.Drawing.Color.DodgerBlue
        Me.Guna2Button6.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Bold)
        Me.Guna2Button6.ForeColor = System.Drawing.Color.White
        Me.Guna2Button6.Image = Global.BarangaySystem.My.Resources.Resources.edit
        Me.Guna2Button6.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.Guna2Button6.Location = New System.Drawing.Point(101, 1)
        Me.Guna2Button6.Name = "Guna2Button6"
        Me.Guna2Button6.Size = New System.Drawing.Size(80, 45)
        Me.Guna2Button6.TabIndex = 10297
        Me.Guna2Button6.Text = "Edit"
        Me.Guna2Button6.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.Guna2Button6.TextOffset = New System.Drawing.Point(-5, 0)
        '
        'Guna2Button7
        '
        Me.Guna2Button7.Animated = True
        Me.Guna2Button7.AnimatedGIF = True
        Me.Guna2Button7.BorderRadius = 10
        Me.Guna2Button7.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Guna2Button7.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.Guna2Button7.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.Guna2Button7.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.Guna2Button7.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.Guna2Button7.FillColor = System.Drawing.Color.SeaGreen
        Me.Guna2Button7.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2Button7.ForeColor = System.Drawing.Color.White
        Me.Guna2Button7.Image = Global.BarangaySystem.My.Resources.Resources.plus
        Me.Guna2Button7.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.Guna2Button7.Location = New System.Drawing.Point(18, 0)
        Me.Guna2Button7.Name = "Guna2Button7"
        Me.Guna2Button7.Size = New System.Drawing.Size(80, 45)
        Me.Guna2Button7.TabIndex = 10298
        Me.Guna2Button7.Text = "Add"
        Me.Guna2Button7.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.Guna2Button7.TextOffset = New System.Drawing.Point(-5, 0)
        '
        'TblUserAccountsBindingSource
        '
        Me.TblUserAccountsBindingSource.DataMember = "tblUserAccounts"
        Me.TblUserAccountsBindingSource.DataSource = Me.DbBrgySystemDataSetBindingSource
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
        'UsernameTextBox
        '
        Me.UsernameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblUserAccountsBindingSource, "username", True))
        Me.UsernameTextBox.Location = New System.Drawing.Point(322, 12)
        Me.UsernameTextBox.Name = "UsernameTextBox"
        Me.UsernameTextBox.Size = New System.Drawing.Size(100, 20)
        Me.UsernameTextBox.TabIndex = 10300
        '
        'Guna2Button8
        '
        Me.Guna2Button8.Animated = True
        Me.Guna2Button8.AnimatedGIF = True
        Me.Guna2Button8.BorderRadius = 10
        Me.Guna2Button8.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Guna2Button8.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.Guna2Button8.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.Guna2Button8.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.Guna2Button8.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.Guna2Button8.FillColor = System.Drawing.Color.Goldenrod
        Me.Guna2Button8.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2Button8.ForeColor = System.Drawing.Color.White
        Me.Guna2Button8.Location = New System.Drawing.Point(285, 1)
        Me.Guna2Button8.Name = "Guna2Button8"
        Me.Guna2Button8.Size = New System.Drawing.Size(153, 45)
        Me.Guna2Button8.TabIndex = 10295
        Me.Guna2Button8.Text = "Reset Password"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(355, 12)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(67, 21)
        Me.Button1.TabIndex = 10301
        Me.Button1.Text = "Button1"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'ResidentsTbl
        '
        Me.ResidentsTbl.AllowUserToAddRows = False
        Me.ResidentsTbl.AllowUserToDeleteRows = False
        Me.ResidentsTbl.AllowUserToResizeColumns = False
        Me.ResidentsTbl.AllowUserToResizeRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.Ivory
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Goldenrod
        Me.ResidentsTbl.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.ResidentsTbl.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ResidentsTbl.AutoGenerateColumns = False
        Me.ResidentsTbl.BackgroundColor = System.Drawing.Color.Silver
        Me.ResidentsTbl.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.ResidentsTbl.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.ResidentsTbl.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.DarkGoldenrod
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Goldenrod
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.ResidentsTbl.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.ResidentsTbl.ColumnHeadersHeight = 35
        Me.ResidentsTbl.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.ResidentsTbl.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.firstName, Me.MI, Me.lastName, Me.UsernameDataGridViewTextBoxColumn, Me.UserTypeDataGridViewTextBoxColumn})
        Me.ResidentsTbl.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ResidentsTbl.DataSource = Me.TblUserAccountsBindingSource
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Goldenrod
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.ResidentsTbl.DefaultCellStyle = DataGridViewCellStyle3
        Me.ResidentsTbl.EnableHeadersVisualStyles = False
        Me.ResidentsTbl.Location = New System.Drawing.Point(19, 52)
        Me.ResidentsTbl.Name = "ResidentsTbl"
        Me.ResidentsTbl.ReadOnly = True
        Me.ResidentsTbl.RowHeadersVisible = False
        Me.ResidentsTbl.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.ResidentsTbl.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.ResidentsTbl.Size = New System.Drawing.Size(1033, 431)
        Me.ResidentsTbl.TabIndex = 10293
        '
        'firstName
        '
        Me.firstName.DataPropertyName = "firstName"
        Me.firstName.HeaderText = "First Name"
        Me.firstName.Name = "firstName"
        Me.firstName.ReadOnly = True
        Me.firstName.Width = 200
        '
        'MI
        '
        Me.MI.DataPropertyName = "MI"
        Me.MI.HeaderText = "M.I."
        Me.MI.Name = "MI"
        Me.MI.ReadOnly = True
        Me.MI.Width = 50
        '
        'lastName
        '
        Me.lastName.DataPropertyName = "lastName"
        Me.lastName.HeaderText = "Last Name"
        Me.lastName.Name = "lastName"
        Me.lastName.ReadOnly = True
        '
        'UsernameDataGridViewTextBoxColumn
        '
        Me.UsernameDataGridViewTextBoxColumn.DataPropertyName = "username"
        Me.UsernameDataGridViewTextBoxColumn.HeaderText = "Username"
        Me.UsernameDataGridViewTextBoxColumn.Name = "UsernameDataGridViewTextBoxColumn"
        Me.UsernameDataGridViewTextBoxColumn.ReadOnly = True
        '
        'UserTypeDataGridViewTextBoxColumn
        '
        Me.UserTypeDataGridViewTextBoxColumn.DataPropertyName = "userType"
        Me.UserTypeDataGridViewTextBoxColumn.HeaderText = "Account Type"
        Me.UserTypeDataGridViewTextBoxColumn.Name = "UserTypeDataGridViewTextBoxColumn"
        Me.UserTypeDataGridViewTextBoxColumn.ReadOnly = True
        Me.UserTypeDataGridViewTextBoxColumn.Width = 150
        '
        'TblUserAccountsTableAdapter
        '
        Me.TblUserAccountsTableAdapter.ClearBeforeFill = True
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
        Me.TableAdapterManager.tblResidentsTableAdapter = Nothing
        Me.TableAdapterManager.tblSysSettingsTableAdapter = Nothing
        Me.TableAdapterManager.tblUserAccountsTableAdapter = Me.TblUserAccountsTableAdapter
        Me.TableAdapterManager.UpdateOrder = BarangaySystem.dbBrgySystemDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'frmUsers
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1083, 542)
        Me.Controls.Add(Me.Guna2Button4)
        Me.Controls.Add(Me.Guna2Button6)
        Me.Controls.Add(Me.Guna2Button7)
        Me.Controls.Add(Me.Guna2Button8)
        Me.Controls.Add(Me.ResidentsTbl)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(UsernameLabel)
        Me.Controls.Add(Me.UsernameTextBox)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmUsers"
        Me.Text = "frmUsers"
        CType(Me.TblUserAccountsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DbBrgySystemDataSetBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DbBrgySystemDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ResidentsTbl, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Guna2Button4 As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Guna2Button6 As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Guna2Button7 As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents DbBrgySystemDataSetBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents DbBrgySystemDataSet As BarangaySystem.dbBrgySystemDataSet
    Friend WithEvents TblUserAccountsBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TblUserAccountsTableAdapter As BarangaySystem.dbBrgySystemDataSetTableAdapters.tblUserAccountsTableAdapter
    Friend WithEvents TableAdapterManager As BarangaySystem.dbBrgySystemDataSetTableAdapters.TableAdapterManager
    Friend WithEvents UsernameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Guna2Button8 As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents ResidentsTbl As System.Windows.Forms.DataGridView
    Friend WithEvents UsernameDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents UserTypeDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents firstName As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MI As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents lastName As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
