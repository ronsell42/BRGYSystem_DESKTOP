<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSettings
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
        Dim UsernameLabel1 As System.Windows.Forms.Label
        Dim FirstNameLabel1 As System.Windows.Forms.Label
        Dim MILabel1 As System.Windows.Forms.Label
        Dim LastNameLabel1 As System.Windows.Forms.Label
        Dim PINLabel1 As System.Windows.Forms.Label
        Dim UserTypeLabel1 As System.Windows.Forms.Label
        Dim PasswordLabel1 As System.Windows.Forms.Label
        Dim PositionLabel1 As System.Windows.Forms.Label
        Dim EmailLabel1 As System.Windows.Forms.Label
        Dim UserPicLabel As System.Windows.Forms.Label
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Guna2Button5 = New Guna.UI2.WinForms.Guna2Button()
        Me.lblCurrentFrm = New System.Windows.Forms.Label()
        Me.picCurrentFrm = New Guna.UI2.WinForms.Guna2PictureBox()
        Me.Guna2Panel2 = New Guna.UI2.WinForms.Guna2Panel()
        Me.Guna2Button1 = New Guna.UI2.WinForms.Guna2Button()
        Me.Guna2TabControl1 = New Guna.UI2.WinForms.Guna2TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.UserPicPictureBox = New System.Windows.Forms.PictureBox()
        Me.TblUserAccountsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DbBrgySystemDataSet = New BarangaySystem.dbBrgySystemDataSet()
        Me.Guna2Button10 = New Guna.UI2.WinForms.Guna2Button()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.UsernameTextBox1 = New System.Windows.Forms.TextBox()
        Me.FirstNameTextBox1 = New System.Windows.Forms.TextBox()
        Me.MITextBox1 = New System.Windows.Forms.TextBox()
        Me.LastNameTextBox1 = New System.Windows.Forms.TextBox()
        Me.PINTextBox1 = New System.Windows.Forms.TextBox()
        Me.UserTypeTextBox1 = New System.Windows.Forms.TextBox()
        Me.PasswordTextBox1 = New System.Windows.Forms.TextBox()
        Me.PositionTextBox1 = New System.Windows.Forms.TextBox()
        Me.EmailTextBox1 = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.ShapeContainer1 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.LineShape1 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.Panel9 = New System.Windows.Forms.Panel()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Guna2Elipse1 = New Guna.UI2.WinForms.Guna2Elipse(Me.components)
        Me.Guna2Elipse3 = New Guna.UI2.WinForms.Guna2Elipse(Me.components)
        Me.Guna2Elipse2 = New Guna.UI2.WinForms.Guna2Elipse(Me.components)
        Me.Guna2BorderlessForm1 = New Guna.UI2.WinForms.Guna2BorderlessForm(Me.components)
        Me.tmrOpen = New System.Windows.Forms.Timer(Me.components)
        Me.TblUserAccountsTableAdapter = New BarangaySystem.dbBrgySystemDataSetTableAdapters.tblUserAccountsTableAdapter()
        Me.TableAdapterManager = New BarangaySystem.dbBrgySystemDataSetTableAdapters.TableAdapterManager()
        UsernameLabel1 = New System.Windows.Forms.Label()
        FirstNameLabel1 = New System.Windows.Forms.Label()
        MILabel1 = New System.Windows.Forms.Label()
        LastNameLabel1 = New System.Windows.Forms.Label()
        PINLabel1 = New System.Windows.Forms.Label()
        UserTypeLabel1 = New System.Windows.Forms.Label()
        PasswordLabel1 = New System.Windows.Forms.Label()
        PositionLabel1 = New System.Windows.Forms.Label()
        EmailLabel1 = New System.Windows.Forms.Label()
        UserPicLabel = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        CType(Me.picCurrentFrm, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Guna2Panel2.SuspendLayout()
        Me.Guna2TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        CType(Me.UserPicPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblUserAccountsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DbBrgySystemDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage2.SuspendLayout()
        Me.TabPage3.SuspendLayout()
        Me.SuspendLayout()
        '
        'UsernameLabel1
        '
        UsernameLabel1.AutoSize = True
        UsernameLabel1.Location = New System.Drawing.Point(409, 302)
        UsernameLabel1.Name = "UsernameLabel1"
        UsernameLabel1.Size = New System.Drawing.Size(56, 13)
        UsernameLabel1.TabIndex = 19
        UsernameLabel1.Text = "username:"
        '
        'FirstNameLabel1
        '
        FirstNameLabel1.AutoSize = True
        FirstNameLabel1.Location = New System.Drawing.Point(409, 328)
        FirstNameLabel1.Name = "FirstNameLabel1"
        FirstNameLabel1.Size = New System.Drawing.Size(57, 13)
        FirstNameLabel1.TabIndex = 21
        FirstNameLabel1.Text = "first Name:"
        '
        'MILabel1
        '
        MILabel1.AutoSize = True
        MILabel1.Location = New System.Drawing.Point(409, 354)
        MILabel1.Name = "MILabel1"
        MILabel1.Size = New System.Drawing.Size(22, 13)
        MILabel1.TabIndex = 23
        MILabel1.Text = "MI:"
        '
        'LastNameLabel1
        '
        LastNameLabel1.AutoSize = True
        LastNameLabel1.Location = New System.Drawing.Point(409, 380)
        LastNameLabel1.Name = "LastNameLabel1"
        LastNameLabel1.Size = New System.Drawing.Size(57, 13)
        LastNameLabel1.TabIndex = 25
        LastNameLabel1.Text = "last Name:"
        '
        'PINLabel1
        '
        PINLabel1.AutoSize = True
        PINLabel1.Location = New System.Drawing.Point(409, 406)
        PINLabel1.Name = "PINLabel1"
        PINLabel1.Size = New System.Drawing.Size(28, 13)
        PINLabel1.TabIndex = 27
        PINLabel1.Text = "PIN:"
        '
        'UserTypeLabel1
        '
        UserTypeLabel1.AutoSize = True
        UserTypeLabel1.Location = New System.Drawing.Point(409, 432)
        UserTypeLabel1.Name = "UserTypeLabel1"
        UserTypeLabel1.Size = New System.Drawing.Size(57, 13)
        UserTypeLabel1.TabIndex = 29
        UserTypeLabel1.Text = "user Type:"
        '
        'PasswordLabel1
        '
        PasswordLabel1.AutoSize = True
        PasswordLabel1.Location = New System.Drawing.Point(409, 458)
        PasswordLabel1.Name = "PasswordLabel1"
        PasswordLabel1.Size = New System.Drawing.Size(55, 13)
        PasswordLabel1.TabIndex = 31
        PasswordLabel1.Text = "password:"
        '
        'PositionLabel1
        '
        PositionLabel1.AutoSize = True
        PositionLabel1.Location = New System.Drawing.Point(409, 484)
        PositionLabel1.Name = "PositionLabel1"
        PositionLabel1.Size = New System.Drawing.Size(46, 13)
        PositionLabel1.TabIndex = 33
        PositionLabel1.Text = "position:"
        '
        'EmailLabel1
        '
        EmailLabel1.AutoSize = True
        EmailLabel1.Location = New System.Drawing.Point(409, 510)
        EmailLabel1.Name = "EmailLabel1"
        EmailLabel1.Size = New System.Drawing.Size(34, 13)
        EmailLabel1.TabIndex = 35
        EmailLabel1.Text = "email:"
        '
        'UserPicLabel
        '
        UserPicLabel.AutoSize = True
        UserPicLabel.Location = New System.Drawing.Point(418, 243)
        UserPicLabel.Name = "UserPicLabel"
        UserPicLabel.Size = New System.Drawing.Size(48, 13)
        UserPicLabel.TabIndex = 1000000015
        UserPicLabel.Text = "user Pic:"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.Controls.Add(Me.Guna2Button5)
        Me.Panel1.Controls.Add(Me.lblCurrentFrm)
        Me.Panel1.Controls.Add(Me.picCurrentFrm)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1364, 63)
        Me.Panel1.TabIndex = 9
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
        Me.Guna2Button5.FillColor = System.Drawing.Color.Firebrick
        Me.Guna2Button5.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Bold)
        Me.Guna2Button5.ForeColor = System.Drawing.Color.White
        Me.Guna2Button5.Image = Global.BarangaySystem.My.Resources.Resources.iconCancel
        Me.Guna2Button5.Location = New System.Drawing.Point(1302, 7)
        Me.Guna2Button5.Name = "Guna2Button5"
        Me.Guna2Button5.Size = New System.Drawing.Size(55, 49)
        Me.Guna2Button5.TabIndex = 18
        Me.Guna2Button5.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.Guna2Button5.TextOffset = New System.Drawing.Point(-5, 0)
        '
        'lblCurrentFrm
        '
        Me.lblCurrentFrm.AutoSize = True
        Me.lblCurrentFrm.Font = New System.Drawing.Font("Trebuchet MS", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCurrentFrm.Location = New System.Drawing.Point(64, 12)
        Me.lblCurrentFrm.Name = "lblCurrentFrm"
        Me.lblCurrentFrm.Size = New System.Drawing.Size(130, 40)
        Me.lblCurrentFrm.TabIndex = 4
        Me.lblCurrentFrm.Text = "Settings"
        '
        'picCurrentFrm
        '
        Me.picCurrentFrm.Image = Global.BarangaySystem.My.Resources.Resources.iconSettings
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
        Me.Guna2Panel2.BackColor = System.Drawing.SystemColors.Control
        Me.Guna2Panel2.BorderRadius = 311
        Me.Guna2Panel2.Controls.Add(Me.Guna2Button1)
        Me.Guna2Panel2.Controls.Add(Me.Guna2TabControl1)
        Me.Guna2Panel2.Location = New System.Drawing.Point(0, 68)
        Me.Guna2Panel2.Name = "Guna2Panel2"
        Me.Guna2Panel2.Size = New System.Drawing.Size(1128, 625)
        Me.Guna2Panel2.TabIndex = 10
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
        Me.Guna2Button1.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Bold)
        Me.Guna2Button1.ForeColor = System.Drawing.Color.White
        Me.Guna2Button1.Image = Global.BarangaySystem.My.Resources.Resources.iconCancel
        Me.Guna2Button1.Location = New System.Drawing.Point(14, 0)
        Me.Guna2Button1.Name = "Guna2Button1"
        Me.Guna2Button1.Size = New System.Drawing.Size(180, 49)
        Me.Guna2Button1.TabIndex = 19
        Me.Guna2Button1.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.Guna2Button1.TextOffset = New System.Drawing.Point(-5, 0)
        '
        'Guna2TabControl1
        '
        Me.Guna2TabControl1.Alignment = System.Windows.Forms.TabAlignment.Left
        Me.Guna2TabControl1.Controls.Add(Me.TabPage1)
        Me.Guna2TabControl1.Controls.Add(Me.TabPage2)
        Me.Guna2TabControl1.Controls.Add(Me.TabPage3)
        Me.Guna2TabControl1.ItemSize = New System.Drawing.Size(180, 40)
        Me.Guna2TabControl1.Location = New System.Drawing.Point(12, 54)
        Me.Guna2TabControl1.Name = "Guna2TabControl1"
        Me.Guna2TabControl1.SelectedIndex = 0
        Me.Guna2TabControl1.Size = New System.Drawing.Size(1340, 571)
        Me.Guna2TabControl1.TabButtonHoverState.BorderColor = System.Drawing.Color.Empty
        Me.Guna2TabControl1.TabButtonHoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.Guna2TabControl1.TabButtonHoverState.Font = New System.Drawing.Font("Segoe UI Semibold", 10.0!)
        Me.Guna2TabControl1.TabButtonHoverState.ForeColor = System.Drawing.Color.White
        Me.Guna2TabControl1.TabButtonHoverState.InnerColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.Guna2TabControl1.TabButtonIdleState.BorderColor = System.Drawing.Color.Empty
        Me.Guna2TabControl1.TabButtonIdleState.FillColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(57, Byte), Integer))
        Me.Guna2TabControl1.TabButtonIdleState.Font = New System.Drawing.Font("Segoe UI Semibold", 10.0!)
        Me.Guna2TabControl1.TabButtonIdleState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(156, Byte), Integer), CType(CType(160, Byte), Integer), CType(CType(167, Byte), Integer))
        Me.Guna2TabControl1.TabButtonIdleState.InnerColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(57, Byte), Integer))
        Me.Guna2TabControl1.TabButtonSelectedState.BorderColor = System.Drawing.Color.Empty
        Me.Guna2TabControl1.TabButtonSelectedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(29, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.Guna2TabControl1.TabButtonSelectedState.Font = New System.Drawing.Font("Segoe UI Semibold", 10.0!)
        Me.Guna2TabControl1.TabButtonSelectedState.ForeColor = System.Drawing.Color.White
        Me.Guna2TabControl1.TabButtonSelectedState.InnerColor = System.Drawing.Color.FromArgb(CType(CType(76, Byte), Integer), CType(CType(132, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Guna2TabControl1.TabButtonSize = New System.Drawing.Size(180, 40)
        Me.Guna2TabControl1.TabButtonTextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.Guna2TabControl1.TabButtonTextOffset = New System.Drawing.Point(10, 0)
        Me.Guna2TabControl1.TabIndex = 10307
        Me.Guna2TabControl1.TabMenuBackColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(57, Byte), Integer))
        '
        'TabPage1
        '
        Me.TabPage1.BackColor = System.Drawing.Color.White
        Me.TabPage1.Controls.Add(Me.Panel3)
        Me.TabPage1.Controls.Add(Me.Button1)
        Me.TabPage1.Controls.Add(UserPicLabel)
        Me.TabPage1.Controls.Add(Me.UserPicPictureBox)
        Me.TabPage1.Controls.Add(Me.Guna2Button10)
        Me.TabPage1.Controls.Add(Me.Label9)
        Me.TabPage1.Controls.Add(Me.Label8)
        Me.TabPage1.Controls.Add(Me.Label7)
        Me.TabPage1.Controls.Add(UsernameLabel1)
        Me.TabPage1.Controls.Add(Me.UsernameTextBox1)
        Me.TabPage1.Controls.Add(FirstNameLabel1)
        Me.TabPage1.Controls.Add(Me.FirstNameTextBox1)
        Me.TabPage1.Controls.Add(MILabel1)
        Me.TabPage1.Controls.Add(Me.MITextBox1)
        Me.TabPage1.Controls.Add(LastNameLabel1)
        Me.TabPage1.Controls.Add(Me.LastNameTextBox1)
        Me.TabPage1.Controls.Add(PINLabel1)
        Me.TabPage1.Controls.Add(Me.PINTextBox1)
        Me.TabPage1.Controls.Add(UserTypeLabel1)
        Me.TabPage1.Controls.Add(Me.UserTypeTextBox1)
        Me.TabPage1.Controls.Add(PasswordLabel1)
        Me.TabPage1.Controls.Add(Me.PasswordTextBox1)
        Me.TabPage1.Controls.Add(PositionLabel1)
        Me.TabPage1.Controls.Add(Me.PositionTextBox1)
        Me.TabPage1.Controls.Add(EmailLabel1)
        Me.TabPage1.Controls.Add(Me.EmailTextBox1)
        Me.TabPage1.Controls.Add(Me.Label6)
        Me.TabPage1.Controls.Add(Me.ShapeContainer1)
        Me.TabPage1.Location = New System.Drawing.Point(184, 4)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(1152, 563)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "My Account"
        '
        'Panel3
        '
        Me.Panel3.Location = New System.Drawing.Point(261, 206)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(589, 333)
        Me.Panel3.TabIndex = 1000000018
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(277, 299)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(104, 35)
        Me.Button1.TabIndex = 1000000017
        Me.Button1.Text = "Button1"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'UserPicPictureBox
        '
        Me.UserPicPictureBox.DataBindings.Add(New System.Windows.Forms.Binding("Image", Me.TblUserAccountsBindingSource, "userPic", True))
        Me.UserPicPictureBox.Location = New System.Drawing.Point(472, 243)
        Me.UserPicPictureBox.Name = "UserPicPictureBox"
        Me.UserPicPictureBox.Size = New System.Drawing.Size(100, 50)
        Me.UserPicPictureBox.TabIndex = 1000000016
        Me.UserPicPictureBox.TabStop = False
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
        'Guna2Button10
        '
        Me.Guna2Button10.Animated = True
        Me.Guna2Button10.AnimatedGIF = True
        Me.Guna2Button10.BorderRadius = 10
        Me.Guna2Button10.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Guna2Button10.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.Guna2Button10.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.Guna2Button10.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.Guna2Button10.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.Guna2Button10.FillColor = System.Drawing.Color.DodgerBlue
        Me.Guna2Button10.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Bold)
        Me.Guna2Button10.ForeColor = System.Drawing.Color.White
        Me.Guna2Button10.Image = Global.BarangaySystem.My.Resources.Resources.edit
        Me.Guna2Button10.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.Guna2Button10.Location = New System.Drawing.Point(11, 161)
        Me.Guna2Button10.Name = "Guna2Button10"
        Me.Guna2Button10.Size = New System.Drawing.Size(137, 31)
        Me.Guna2Button10.TabIndex = 1000000015
        Me.Guna2Button10.Text = "Change details"
        Me.Guna2Button10.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.Guna2Button10.TextOffset = New System.Drawing.Point(-5, 0)
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(11, 136)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(71, 22)
        Me.Label9.TabIndex = 1000000013
        Me.Label9.Text = "usertype"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(11, 112)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(93, 22)
        Me.Label8.TabIndex = 1000000012
        Me.Label8.Text = "username__"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Trebuchet MS", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(8, 81)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(127, 29)
        Me.Label7.TabIndex = 37
        Me.Label7.Text = "Your Name"
        '
        'UsernameTextBox1
        '
        Me.UsernameTextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblUserAccountsBindingSource, "username", True))
        Me.UsernameTextBox1.Enabled = False
        Me.UsernameTextBox1.Location = New System.Drawing.Point(472, 299)
        Me.UsernameTextBox1.Name = "UsernameTextBox1"
        Me.UsernameTextBox1.Size = New System.Drawing.Size(100, 20)
        Me.UsernameTextBox1.TabIndex = 20
        '
        'FirstNameTextBox1
        '
        Me.FirstNameTextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblUserAccountsBindingSource, "firstName", True))
        Me.FirstNameTextBox1.Enabled = False
        Me.FirstNameTextBox1.Location = New System.Drawing.Point(472, 325)
        Me.FirstNameTextBox1.Name = "FirstNameTextBox1"
        Me.FirstNameTextBox1.Size = New System.Drawing.Size(100, 20)
        Me.FirstNameTextBox1.TabIndex = 22
        '
        'MITextBox1
        '
        Me.MITextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblUserAccountsBindingSource, "MI", True))
        Me.MITextBox1.Enabled = False
        Me.MITextBox1.Location = New System.Drawing.Point(472, 351)
        Me.MITextBox1.Name = "MITextBox1"
        Me.MITextBox1.Size = New System.Drawing.Size(100, 20)
        Me.MITextBox1.TabIndex = 24
        '
        'LastNameTextBox1
        '
        Me.LastNameTextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblUserAccountsBindingSource, "lastName", True))
        Me.LastNameTextBox1.Enabled = False
        Me.LastNameTextBox1.Location = New System.Drawing.Point(472, 377)
        Me.LastNameTextBox1.Name = "LastNameTextBox1"
        Me.LastNameTextBox1.Size = New System.Drawing.Size(100, 20)
        Me.LastNameTextBox1.TabIndex = 26
        '
        'PINTextBox1
        '
        Me.PINTextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblUserAccountsBindingSource, "PIN", True))
        Me.PINTextBox1.Enabled = False
        Me.PINTextBox1.Location = New System.Drawing.Point(472, 403)
        Me.PINTextBox1.Name = "PINTextBox1"
        Me.PINTextBox1.Size = New System.Drawing.Size(100, 20)
        Me.PINTextBox1.TabIndex = 28
        '
        'UserTypeTextBox1
        '
        Me.UserTypeTextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblUserAccountsBindingSource, "userType", True))
        Me.UserTypeTextBox1.Enabled = False
        Me.UserTypeTextBox1.Location = New System.Drawing.Point(472, 429)
        Me.UserTypeTextBox1.Name = "UserTypeTextBox1"
        Me.UserTypeTextBox1.Size = New System.Drawing.Size(100, 20)
        Me.UserTypeTextBox1.TabIndex = 30
        '
        'PasswordTextBox1
        '
        Me.PasswordTextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblUserAccountsBindingSource, "password", True))
        Me.PasswordTextBox1.Enabled = False
        Me.PasswordTextBox1.Location = New System.Drawing.Point(472, 455)
        Me.PasswordTextBox1.Name = "PasswordTextBox1"
        Me.PasswordTextBox1.Size = New System.Drawing.Size(100, 20)
        Me.PasswordTextBox1.TabIndex = 32
        '
        'PositionTextBox1
        '
        Me.PositionTextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblUserAccountsBindingSource, "position", True))
        Me.PositionTextBox1.Enabled = False
        Me.PositionTextBox1.Location = New System.Drawing.Point(472, 481)
        Me.PositionTextBox1.Name = "PositionTextBox1"
        Me.PositionTextBox1.Size = New System.Drawing.Size(100, 20)
        Me.PositionTextBox1.TabIndex = 34
        '
        'EmailTextBox1
        '
        Me.EmailTextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblUserAccountsBindingSource, "email", True))
        Me.EmailTextBox1.Enabled = False
        Me.EmailTextBox1.Location = New System.Drawing.Point(472, 507)
        Me.EmailTextBox1.Name = "EmailTextBox1"
        Me.EmailTextBox1.Size = New System.Drawing.Size(100, 20)
        Me.EmailTextBox1.TabIndex = 36
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Trebuchet MS", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(6, 17)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(142, 40)
        Me.Label6.TabIndex = 19
        Me.Label6.Text = "Your Info"
        '
        'ShapeContainer1
        '
        Me.ShapeContainer1.Location = New System.Drawing.Point(3, 3)
        Me.ShapeContainer1.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer1.Name = "ShapeContainer1"
        Me.ShapeContainer1.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.LineShape1})
        Me.ShapeContainer1.Size = New System.Drawing.Size(1146, 557)
        Me.ShapeContainer1.TabIndex = 1000000019
        Me.ShapeContainer1.TabStop = False
        '
        'LineShape1
        '
        Me.LineShape1.BorderColor = System.Drawing.SystemColors.ControlDark
        Me.LineShape1.BorderWidth = 2
        Me.LineShape1.Name = "LineShape1"
        Me.LineShape1.X1 = 6
        Me.LineShape1.X2 = 667
        Me.LineShape1.Y1 = 68
        Me.LineShape1.Y2 = 67
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.Panel9)
        Me.TabPage2.Location = New System.Drawing.Point(184, 4)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Size = New System.Drawing.Size(1152, 563)
        Me.TabPage2.TabIndex = 3
        Me.TabPage2.Text = "Users"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'Panel9
        '
        Me.Panel9.Location = New System.Drawing.Point(2, 2)
        Me.Panel9.Name = "Panel9"
        Me.Panel9.Size = New System.Drawing.Size(910, 610)
        Me.Panel9.TabIndex = 0
        '
        'TabPage3
        '
        Me.TabPage3.AutoScroll = True
        Me.TabPage3.BackColor = System.Drawing.Color.White
        Me.TabPage3.Controls.Add(Me.Panel2)
        Me.TabPage3.Location = New System.Drawing.Point(184, 4)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage3.Size = New System.Drawing.Size(1152, 563)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "Database Settings"
        '
        'Panel2
        '
        Me.Panel2.AutoScroll = True
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(913, 605)
        Me.Panel2.TabIndex = 0
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
        'tmrOpen
        '
        Me.tmrOpen.Enabled = True
        Me.tmrOpen.Interval = 8
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
        'frmSettings
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(1364, 726)
        Me.Controls.Add(Me.Guna2Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MaximumSize = New System.Drawing.Size(1364, 726)
        Me.MinimumSize = New System.Drawing.Size(1364, 726)
        Me.Name = "frmSettings"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmSettings"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.picCurrentFrm, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Guna2Panel2.ResumeLayout(False)
        Me.Guna2TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        CType(Me.UserPicPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblUserAccountsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DbBrgySystemDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage3.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents lblCurrentFrm As System.Windows.Forms.Label
    Friend WithEvents picCurrentFrm As Guna.UI2.WinForms.Guna2PictureBox
    Friend WithEvents Guna2Panel2 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Guna2Elipse1 As Guna.UI2.WinForms.Guna2Elipse
    Friend WithEvents Guna2Elipse3 As Guna.UI2.WinForms.Guna2Elipse
    Friend WithEvents Guna2Elipse2 As Guna.UI2.WinForms.Guna2Elipse
    Friend WithEvents Guna2BorderlessForm1 As Guna.UI2.WinForms.Guna2BorderlessForm
    Friend WithEvents tmrOpen As System.Windows.Forms.Timer
    Friend WithEvents Guna2Button5 As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Guna2TabControl1 As Guna.UI2.WinForms.Guna2TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage3 As System.Windows.Forms.TabPage
    Friend WithEvents DbBrgySystemDataSet As BarangaySystem.dbBrgySystemDataSet
    Friend WithEvents TblUserAccountsBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TblUserAccountsTableAdapter As BarangaySystem.dbBrgySystemDataSetTableAdapters.tblUserAccountsTableAdapter
    Friend WithEvents TableAdapterManager As BarangaySystem.dbBrgySystemDataSetTableAdapters.TableAdapterManager
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents UsernameTextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents FirstNameTextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents MITextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents LastNameTextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents PINTextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents UserTypeTextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents PasswordTextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents PositionTextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents EmailTextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Guna2Button10 As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Panel9 As System.Windows.Forms.Panel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents UserPicPictureBox As System.Windows.Forms.PictureBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents ShapeContainer1 As Microsoft.VisualBasic.PowerPacks.ShapeContainer
    Friend WithEvents LineShape1 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents Guna2Button1 As Guna.UI2.WinForms.Guna2Button
End Class
