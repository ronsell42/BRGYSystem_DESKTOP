<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmLogin
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
        Dim PasswordLabel As System.Windows.Forms.Label
        Me.Guna2Elipse3 = New Guna.UI2.WinForms.Guna2Elipse(Me.components)
        Me.Guna2Elipse2 = New Guna.UI2.WinForms.Guna2Elipse(Me.components)
        Me.Guna2Elipse1 = New Guna.UI2.WinForms.Guna2Elipse(Me.components)
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Label5 = New System.Windows.Forms.Label()
        Me.version_label = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.btnLogin = New Guna.UI2.WinForms.Guna2Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.pass1 = New Guna.UI2.WinForms.Guna2TextBox()
        Me.user1 = New Guna.UI2.WinForms.Guna2TextBox()
        Me.TblHistoryBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DbBrgySystemDataSet = New BarangaySystem.dbBrgySystemDataSet()
        Me.icon1 = New System.Windows.Forms.PictureBox()
        Me.TblUserAccountsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TblUserAccountsTableAdapter = New BarangaySystem.dbBrgySystemDataSetTableAdapters.tblUserAccountsTableAdapter()
        Me.TableAdapterManager = New BarangaySystem.dbBrgySystemDataSetTableAdapters.TableAdapterManager()
        Me.UsernameTextBox = New System.Windows.Forms.TextBox()
        Me.PasswordTextBox = New System.Windows.Forms.TextBox()
        Me.TblHistoryTableAdapter = New BarangaySystem.dbBrgySystemDataSetTableAdapters.tblHistoryTableAdapter()
        UsernameLabel = New System.Windows.Forms.Label()
        PasswordLabel = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        CType(Me.TblHistoryBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DbBrgySystemDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.icon1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblUserAccountsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'UsernameLabel
        '
        UsernameLabel.AutoSize = True
        UsernameLabel.Location = New System.Drawing.Point(231, 421)
        UsernameLabel.Name = "UsernameLabel"
        UsernameLabel.Size = New System.Drawing.Size(56, 13)
        UsernameLabel.TabIndex = 10298
        UsernameLabel.Text = "username:"
        '
        'PasswordLabel
        '
        PasswordLabel.AutoSize = True
        PasswordLabel.Location = New System.Drawing.Point(232, 447)
        PasswordLabel.Name = "PasswordLabel"
        PasswordLabel.Size = New System.Drawing.Size(55, 13)
        PasswordLabel.TabIndex = 10299
        PasswordLabel.Text = "password:"
        '
        'Guna2Elipse3
        '
        Me.Guna2Elipse3.BorderRadius = 20
        '
        'Guna2Elipse2
        '
        Me.Guna2Elipse2.BorderRadius = 20
        '
        'Guna2Elipse1
        '
        Me.Guna2Elipse1.BorderRadius = 20
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(443, 54)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(203, 111)
        Me.Label5.TabIndex = 10293
        Me.Label5.Text = "Barangay" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Management" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "System"
        '
        'version_label
        '
        Me.version_label.AutoSize = True
        Me.version_label.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.version_label.ForeColor = System.Drawing.SystemColors.GrayText
        Me.version_label.Location = New System.Drawing.Point(564, 140)
        Me.version_label.Name = "version_label"
        Me.version_label.Size = New System.Drawing.Size(93, 16)
        Me.version_label.TabIndex = 10297
        Me.version_label.Text = "2023 version 1"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label3.Location = New System.Drawing.Point(109, 77)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(192, 40)
        Me.Label3.TabIndex = 10295
        Me.Label3.Text = """Records and Documents" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "all in one place."""
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.SystemColors.GrayText
        Me.Label8.Location = New System.Drawing.Point(110, 133)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(100, 20)
        Me.Label8.TabIndex = 10294
        Me.Label8.Text = "Please Login"
        '
        'btnLogin
        '
        Me.btnLogin.AutoRoundedCorners = True
        Me.btnLogin.BorderRadius = 24
        Me.btnLogin.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnLogin.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnLogin.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnLogin.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnLogin.FillColor = System.Drawing.Color.Goldenrod
        Me.btnLogin.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLogin.ForeColor = System.Drawing.Color.White
        Me.btnLogin.Location = New System.Drawing.Point(114, 269)
        Me.btnLogin.Name = "btnLogin"
        Me.btnLogin.Size = New System.Drawing.Size(299, 51)
        Me.btnLogin.TabIndex = 2
        Me.btnLogin.Text = "Log In"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.Controls.Add(Me.pass1)
        Me.Panel1.Controls.Add(Me.user1)
        Me.Panel1.Controls.Add(Me.btnLogin)
        Me.Panel1.Controls.Add(Me.Label8)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Location = New System.Drawing.Point(221, 176)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(528, 396)
        Me.Panel1.TabIndex = 4
        '
        'pass1
        '
        Me.pass1.Animated = True
        Me.pass1.BackColor = System.Drawing.Color.White
        Me.pass1.BorderColor = System.Drawing.Color.Black
        Me.pass1.BorderRadius = 10
        Me.pass1.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.pass1.DefaultText = ""
        Me.pass1.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.pass1.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.pass1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.pass1.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.pass1.FocusedState.BorderColor = System.Drawing.Color.Goldenrod
        Me.pass1.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pass1.ForeColor = System.Drawing.Color.Black
        Me.pass1.HoverState.BorderColor = System.Drawing.Color.Goldenrod
        Me.pass1.IconLeft = Global.BarangaySystem.My.Resources.Resources.icon_password
        Me.pass1.IconLeftOffset = New System.Drawing.Point(8, 0)
        Me.pass1.Location = New System.Drawing.Point(114, 217)
        Me.pass1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.pass1.Name = "pass1"
        Me.pass1.PasswordChar = Global.Microsoft.VisualBasic.ChrW(8226)
        Me.pass1.PlaceholderForeColor = System.Drawing.Color.DimGray
        Me.pass1.PlaceholderText = "Password"
        Me.pass1.SelectedText = ""
        Me.pass1.Size = New System.Drawing.Size(299, 45)
        Me.pass1.TabIndex = 1
        Me.pass1.TextOffset = New System.Drawing.Point(5, 0)
        '
        'user1
        '
        Me.user1.Animated = True
        Me.user1.BackColor = System.Drawing.Color.White
        Me.user1.BorderColor = System.Drawing.Color.Black
        Me.user1.BorderRadius = 10
        Me.user1.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.user1.DefaultText = ""
        Me.user1.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.user1.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.user1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.user1.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.user1.FocusedState.BorderColor = System.Drawing.Color.Goldenrod
        Me.user1.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.user1.ForeColor = System.Drawing.Color.Black
        Me.user1.HoverState.BorderColor = System.Drawing.Color.Goldenrod
        Me.user1.IconLeft = Global.BarangaySystem.My.Resources.Resources.icon_username
        Me.user1.IconLeftOffset = New System.Drawing.Point(8, 0)
        Me.user1.Location = New System.Drawing.Point(114, 164)
        Me.user1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.user1.Name = "user1"
        Me.user1.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.user1.PlaceholderForeColor = System.Drawing.Color.DimGray
        Me.user1.PlaceholderText = "Username"
        Me.user1.SelectedText = ""
        Me.user1.Size = New System.Drawing.Size(299, 45)
        Me.user1.TabIndex = 0
        Me.user1.TextOffset = New System.Drawing.Point(5, 0)
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
        'icon1
        '
        Me.icon1.Image = Global.BarangaySystem.My.Resources.Resources.iconBrgyPic
        Me.icon1.Location = New System.Drawing.Point(271, 41)
        Me.icon1.Name = "icon1"
        Me.icon1.Size = New System.Drawing.Size(162, 128)
        Me.icon1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.icon1.TabIndex = 10292
        Me.icon1.TabStop = False
        '
        'TblUserAccountsBindingSource
        '
        Me.TblUserAccountsBindingSource.DataMember = "tblUserAccounts"
        Me.TblUserAccountsBindingSource.DataSource = Me.DbBrgySystemDataSet
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
        Me.TableAdapterManager.tblOrganizationTableAdapter = Nothing
        Me.TableAdapterManager.tblPrintIndigencyTableAdapter = Nothing
        Me.TableAdapterManager.tblResidentsTableAdapter = Nothing
        Me.TableAdapterManager.tblSysSettingsTableAdapter = Nothing
        Me.TableAdapterManager.tblUserAccountsTableAdapter = Me.TblUserAccountsTableAdapter
        Me.TableAdapterManager.UpdateOrder = BarangaySystem.dbBrgySystemDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'UsernameTextBox
        '
        Me.UsernameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblUserAccountsBindingSource, "username", True))
        Me.UsernameTextBox.Enabled = False
        Me.UsernameTextBox.Location = New System.Drawing.Point(293, 418)
        Me.UsernameTextBox.Name = "UsernameTextBox"
        Me.UsernameTextBox.Size = New System.Drawing.Size(100, 20)
        Me.UsernameTextBox.TabIndex = 10299
        '
        'PasswordTextBox
        '
        Me.PasswordTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblUserAccountsBindingSource, "password", True))
        Me.PasswordTextBox.Enabled = False
        Me.PasswordTextBox.Location = New System.Drawing.Point(293, 444)
        Me.PasswordTextBox.Name = "PasswordTextBox"
        Me.PasswordTextBox.Size = New System.Drawing.Size(100, 20)
        Me.PasswordTextBox.TabIndex = 10300
        '
        'TblHistoryTableAdapter
        '
        Me.TblHistoryTableAdapter.ClearBeforeFill = True
        '
        'frmLogin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(976, 648)
        Me.Controls.Add(Me.version_label)
        Me.Controls.Add(Me.icon1)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(PasswordLabel)
        Me.Controls.Add(Me.UsernameTextBox)
        Me.Controls.Add(Me.PasswordTextBox)
        Me.Controls.Add(UsernameLabel)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmLogin"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmLogin"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.TblHistoryBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DbBrgySystemDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.icon1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblUserAccountsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Guna2Elipse3 As Guna.UI2.WinForms.Guna2Elipse
    Friend WithEvents Guna2Elipse2 As Guna.UI2.WinForms.Guna2Elipse
    Friend WithEvents Guna2Elipse1 As Guna.UI2.WinForms.Guna2Elipse
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents icon1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents version_label As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents btnLogin As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents user1 As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents pass1 As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents DbBrgySystemDataSet As BarangaySystem.dbBrgySystemDataSet
    Friend WithEvents TblUserAccountsBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TblUserAccountsTableAdapter As BarangaySystem.dbBrgySystemDataSetTableAdapters.tblUserAccountsTableAdapter
    Friend WithEvents TableAdapterManager As BarangaySystem.dbBrgySystemDataSetTableAdapters.TableAdapterManager
    Friend WithEvents UsernameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents PasswordTextBox As System.Windows.Forms.TextBox
    Friend WithEvents TblHistoryBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TblHistoryTableAdapter As BarangaySystem.dbBrgySystemDataSetTableAdapters.tblHistoryTableAdapter
End Class
