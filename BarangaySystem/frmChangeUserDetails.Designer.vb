<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmChangeUserDetails
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
        Dim FirstNameLabel As System.Windows.Forms.Label
        Dim MILabel As System.Windows.Forms.Label
        Dim LastNameLabel As System.Windows.Forms.Label
        Dim PINLabel As System.Windows.Forms.Label
        Dim UserTypeLabel As System.Windows.Forms.Label
        Dim PasswordLabel As System.Windows.Forms.Label
        Dim PositionLabel As System.Windows.Forms.Label
        Dim EmailLabel As System.Windows.Forms.Label
        Dim UserPicLabel As System.Windows.Forms.Label
        Dim Label1 As System.Windows.Forms.Label
        Dim Label2 As System.Windows.Forms.Label
        Dim Label3 As System.Windows.Forms.Label
        Dim Label4 As System.Windows.Forms.Label
        Dim Label5 As System.Windows.Forms.Label
        Dim Label6 As System.Windows.Forms.Label
        Dim qweqwe As System.Windows.Forms.Label
        Dim star2 As System.Windows.Forms.Label
        Dim askterisk5 As System.Windows.Forms.Label
        Dim Label10 As System.Windows.Forms.Label
        Dim star3 As System.Windows.Forms.Label
        Dim star4 As System.Windows.Forms.Label
        Dim star6 As System.Windows.Forms.Label
        Me.tmrOpen = New System.Windows.Forms.Timer(Me.components)
        Me.Guna2BorderlessForm1 = New Guna.UI2.WinForms.Guna2BorderlessForm(Me.components)
        Me.Guna2Button5 = New Guna.UI2.WinForms.Guna2Button()
        Me.usernameBox = New Bunifu.Framework.UI.BunifuMetroTextbox()
        Me.TblUserAccountsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DbBrgySystemDataSet = New BarangaySystem.dbBrgySystemDataSet()
        Me.fNameBox = New Bunifu.Framework.UI.BunifuMetroTextbox()
        Me.UsernameTextBox = New System.Windows.Forms.TextBox()
        Me.FirstNameTextBox = New System.Windows.Forms.TextBox()
        Me.MITextBox = New System.Windows.Forms.TextBox()
        Me.LastNameTextBox = New System.Windows.Forms.TextBox()
        Me.PINTextBox = New System.Windows.Forms.TextBox()
        Me.UserTypeTextBox = New System.Windows.Forms.TextBox()
        Me.PasswordTextBox = New System.Windows.Forms.TextBox()
        Me.PositionTextBox = New System.Windows.Forms.TextBox()
        Me.EmailTextBox = New System.Windows.Forms.TextBox()
        Me.UserPicPictureBox = New System.Windows.Forms.PictureBox()
        Me.BunifuMetroTextbox1 = New Bunifu.Framework.UI.BunifuMetroTextbox()
        Me.BunifuMetroTextbox2 = New Bunifu.Framework.UI.BunifuMetroTextbox()
        Me.BunifuMetroTextbox3 = New Bunifu.Framework.UI.BunifuMetroTextbox()
        Me.BunifuMetroTextbox4 = New Bunifu.Framework.UI.BunifuMetroTextbox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.lblCurrentFrm = New System.Windows.Forms.Label()
        Me.Guna2Button4 = New Guna.UI2.WinForms.Guna2Button()
        Me.Guna2Button2 = New Guna.UI2.WinForms.Guna2Button()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.TblUserAccountsTableAdapter = New BarangaySystem.dbBrgySystemDataSetTableAdapters.tblUserAccountsTableAdapter()
        Me.TableAdapterManager = New BarangaySystem.dbBrgySystemDataSetTableAdapters.TableAdapterManager()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Button1 = New System.Windows.Forms.Button()
        UsernameLabel = New System.Windows.Forms.Label()
        FirstNameLabel = New System.Windows.Forms.Label()
        MILabel = New System.Windows.Forms.Label()
        LastNameLabel = New System.Windows.Forms.Label()
        PINLabel = New System.Windows.Forms.Label()
        UserTypeLabel = New System.Windows.Forms.Label()
        PasswordLabel = New System.Windows.Forms.Label()
        PositionLabel = New System.Windows.Forms.Label()
        EmailLabel = New System.Windows.Forms.Label()
        UserPicLabel = New System.Windows.Forms.Label()
        Label1 = New System.Windows.Forms.Label()
        Label2 = New System.Windows.Forms.Label()
        Label3 = New System.Windows.Forms.Label()
        Label4 = New System.Windows.Forms.Label()
        Label5 = New System.Windows.Forms.Label()
        Label6 = New System.Windows.Forms.Label()
        qweqwe = New System.Windows.Forms.Label()
        star2 = New System.Windows.Forms.Label()
        askterisk5 = New System.Windows.Forms.Label()
        Label10 = New System.Windows.Forms.Label()
        star3 = New System.Windows.Forms.Label()
        star4 = New System.Windows.Forms.Label()
        star6 = New System.Windows.Forms.Label()
        CType(Me.TblUserAccountsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DbBrgySystemDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UserPicPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.SuspendLayout()
        '
        'UsernameLabel
        '
        UsernameLabel.AutoSize = True
        UsernameLabel.Location = New System.Drawing.Point(531, 376)
        UsernameLabel.Name = "UsernameLabel"
        UsernameLabel.Size = New System.Drawing.Size(56, 13)
        UsernameLabel.TabIndex = 10277
        UsernameLabel.Text = "username:"
        '
        'FirstNameLabel
        '
        FirstNameLabel.AutoSize = True
        FirstNameLabel.Location = New System.Drawing.Point(531, 402)
        FirstNameLabel.Name = "FirstNameLabel"
        FirstNameLabel.Size = New System.Drawing.Size(57, 13)
        FirstNameLabel.TabIndex = 10279
        FirstNameLabel.Text = "first Name:"
        '
        'MILabel
        '
        MILabel.AutoSize = True
        MILabel.Location = New System.Drawing.Point(557, 428)
        MILabel.Name = "MILabel"
        MILabel.Size = New System.Drawing.Size(22, 13)
        MILabel.TabIndex = 10281
        MILabel.Text = "MI:"
        '
        'LastNameLabel
        '
        LastNameLabel.AutoSize = True
        LastNameLabel.Location = New System.Drawing.Point(531, 454)
        LastNameLabel.Name = "LastNameLabel"
        LastNameLabel.Size = New System.Drawing.Size(57, 13)
        LastNameLabel.TabIndex = 10283
        LastNameLabel.Text = "last Name:"
        '
        'PINLabel
        '
        PINLabel.AutoSize = True
        PINLabel.Location = New System.Drawing.Point(558, 384)
        PINLabel.Name = "PINLabel"
        PINLabel.Size = New System.Drawing.Size(28, 13)
        PINLabel.TabIndex = 10285
        PINLabel.Text = "PIN:"
        '
        'UserTypeLabel
        '
        UserTypeLabel.AutoSize = True
        UserTypeLabel.Location = New System.Drawing.Point(531, 390)
        UserTypeLabel.Name = "UserTypeLabel"
        UserTypeLabel.Size = New System.Drawing.Size(57, 13)
        UserTypeLabel.TabIndex = 10287
        UserTypeLabel.Text = "user Type:"
        '
        'PasswordLabel
        '
        PasswordLabel.AutoSize = True
        PasswordLabel.Location = New System.Drawing.Point(531, 412)
        PasswordLabel.Name = "PasswordLabel"
        PasswordLabel.Size = New System.Drawing.Size(55, 13)
        PasswordLabel.TabIndex = 10289
        PasswordLabel.Text = "password:"
        '
        'PositionLabel
        '
        PositionLabel.AutoSize = True
        PositionLabel.Location = New System.Drawing.Point(542, 442)
        PositionLabel.Name = "PositionLabel"
        PositionLabel.Size = New System.Drawing.Size(46, 13)
        PositionLabel.TabIndex = 10291
        PositionLabel.Text = "position:"
        '
        'EmailLabel
        '
        EmailLabel.AutoSize = True
        EmailLabel.Location = New System.Drawing.Point(554, 468)
        EmailLabel.Name = "EmailLabel"
        EmailLabel.Size = New System.Drawing.Size(34, 13)
        EmailLabel.TabIndex = 10293
        EmailLabel.Text = "email:"
        '
        'UserPicLabel
        '
        UserPicLabel.AutoSize = True
        UserPicLabel.Location = New System.Drawing.Point(542, 497)
        UserPicLabel.Name = "UserPicLabel"
        UserPicLabel.Size = New System.Drawing.Size(48, 13)
        UserPicLabel.TabIndex = 10295
        UserPicLabel.Text = "user Pic:"
        '
        'Label1
        '
        Label1.AutoSize = True
        Label1.Font = New System.Drawing.Font("Trebuchet MS", 9.75!)
        Label1.Location = New System.Drawing.Point(116, 53)
        Label1.Name = "Label1"
        Label1.Size = New System.Drawing.Size(71, 18)
        Label1.TabIndex = 10298
        Label1.Text = "Username:"
        '
        'Label2
        '
        Label2.AutoSize = True
        Label2.Font = New System.Drawing.Font("Trebuchet MS", 9.75!)
        Label2.Location = New System.Drawing.Point(117, 140)
        Label2.Name = "Label2"
        Label2.Size = New System.Drawing.Size(77, 18)
        Label2.TabIndex = 10298
        Label2.Text = "First Name:"
        '
        'Label3
        '
        Label3.AutoSize = True
        Label3.Font = New System.Drawing.Font("Trebuchet MS", 9.75!)
        Label3.Location = New System.Drawing.Point(399, 140)
        Label3.Name = "Label3"
        Label3.Size = New System.Drawing.Size(32, 18)
        Label3.TabIndex = 10298
        Label3.Text = "M.I."
        '
        'Label4
        '
        Label4.AutoSize = True
        Label4.Font = New System.Drawing.Font("Trebuchet MS", 9.75!)
        Label4.Location = New System.Drawing.Point(480, 139)
        Label4.Name = "Label4"
        Label4.Size = New System.Drawing.Size(75, 18)
        Label4.TabIndex = 10298
        Label4.Text = "Last Name:"
        '
        'Label5
        '
        Label5.AutoSize = True
        Label5.Font = New System.Drawing.Font("Trebuchet MS", 9.75!)
        Label5.Location = New System.Drawing.Point(22, 8)
        Label5.Name = "Label5"
        Label5.Size = New System.Drawing.Size(66, 18)
        Label5.TabIndex = 10298
        Label5.Text = "Password:"
        '
        'Label6
        '
        Label6.AutoSize = True
        Label6.Font = New System.Drawing.Font("Trebuchet MS", 9.75!)
        Label6.Location = New System.Drawing.Point(20, 13)
        Label6.Name = "Label6"
        Label6.Size = New System.Drawing.Size(117, 18)
        Label6.TabIndex = 10298
        Label6.Text = "Confirm Password:"
        '
        'qweqwe
        '
        qweqwe.AutoSize = True
        qweqwe.Font = New System.Drawing.Font("Trebuchet MS", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        qweqwe.ForeColor = System.Drawing.Color.Red
        qweqwe.Location = New System.Drawing.Point(102, 53)
        qweqwe.Name = "qweqwe"
        qweqwe.Size = New System.Drawing.Size(18, 24)
        qweqwe.TabIndex = 10298
        qweqwe.Text = "*"
        '
        'star2
        '
        star2.AutoSize = True
        star2.Font = New System.Drawing.Font("Trebuchet MS", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        star2.ForeColor = System.Drawing.Color.Red
        star2.Location = New System.Drawing.Point(102, 139)
        star2.Name = "star2"
        star2.Size = New System.Drawing.Size(18, 24)
        star2.TabIndex = 10298
        star2.Text = "*"
        '
        'askterisk5
        '
        askterisk5.AutoSize = True
        askterisk5.Font = New System.Drawing.Font("Trebuchet MS", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        askterisk5.ForeColor = System.Drawing.Color.Red
        askterisk5.Location = New System.Drawing.Point(8, 7)
        askterisk5.Name = "askterisk5"
        askterisk5.Size = New System.Drawing.Size(18, 24)
        askterisk5.TabIndex = 10298
        askterisk5.Text = "*"
        '
        'Label10
        '
        Label10.AutoSize = True
        Label10.Font = New System.Drawing.Font("Trebuchet MS", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label10.ForeColor = System.Drawing.Color.Red
        Label10.Location = New System.Drawing.Point(-20, -1)
        Label10.Name = "Label10"
        Label10.Size = New System.Drawing.Size(18, 24)
        Label10.TabIndex = 10298
        Label10.Text = "*"
        '
        'star3
        '
        star3.AutoSize = True
        star3.Font = New System.Drawing.Font("Trebuchet MS", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        star3.ForeColor = System.Drawing.Color.Red
        star3.Location = New System.Drawing.Point(384, 139)
        star3.Name = "star3"
        star3.Size = New System.Drawing.Size(18, 24)
        star3.TabIndex = 10298
        star3.Text = "*"
        '
        'star4
        '
        star4.AutoSize = True
        star4.Font = New System.Drawing.Font("Trebuchet MS", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        star4.ForeColor = System.Drawing.Color.Red
        star4.Location = New System.Drawing.Point(466, 139)
        star4.Name = "star4"
        star4.Size = New System.Drawing.Size(18, 24)
        star4.TabIndex = 10298
        star4.Text = "*"
        '
        'star6
        '
        star6.AutoSize = True
        star6.Font = New System.Drawing.Font("Trebuchet MS", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        star6.ForeColor = System.Drawing.Color.Red
        star6.Location = New System.Drawing.Point(6, 13)
        star6.Name = "star6"
        star6.Size = New System.Drawing.Size(18, 24)
        star6.TabIndex = 10298
        star6.Text = "*"
        '
        'tmrOpen
        '
        Me.tmrOpen.Enabled = True
        Me.tmrOpen.Interval = 8
        '
        'Guna2BorderlessForm1
        '
        Me.Guna2BorderlessForm1.BorderRadius = 30
        Me.Guna2BorderlessForm1.ContainerControl = Me
        Me.Guna2BorderlessForm1.DockIndicatorTransparencyValue = 0.6R
        Me.Guna2BorderlessForm1.DragForm = False
        Me.Guna2BorderlessForm1.TransparentWhileDrag = True
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
        Me.Guna2Button5.Location = New System.Drawing.Point(745, 4)
        Me.Guna2Button5.Name = "Guna2Button5"
        Me.Guna2Button5.Size = New System.Drawing.Size(55, 49)
        Me.Guna2Button5.TabIndex = 19
        Me.Guna2Button5.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.Guna2Button5.TextOffset = New System.Drawing.Point(-5, 0)
        '
        'usernameBox
        '
        Me.usernameBox.BorderColorFocused = System.Drawing.Color.Goldenrod
        Me.usernameBox.BorderColorIdle = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.usernameBox.BorderColorMouseHover = System.Drawing.Color.Goldenrod
        Me.usernameBox.BorderThickness = 1
        Me.usernameBox.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.usernameBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblUserAccountsBindingSource, "username", True))
        Me.usernameBox.Font = New System.Drawing.Font("Trebuchet MS", 9.75!)
        Me.usernameBox.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.usernameBox.isPassword = False
        Me.usernameBox.Location = New System.Drawing.Point(98, 76)
        Me.usernameBox.Margin = New System.Windows.Forms.Padding(4)
        Me.usernameBox.Name = "usernameBox"
        Me.usernameBox.Size = New System.Drawing.Size(284, 47)
        Me.usernameBox.TabIndex = 10276
        Me.usernameBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
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
        'fNameBox
        '
        Me.fNameBox.BorderColorFocused = System.Drawing.Color.Goldenrod
        Me.fNameBox.BorderColorIdle = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.fNameBox.BorderColorMouseHover = System.Drawing.Color.Goldenrod
        Me.fNameBox.BorderThickness = 1
        Me.fNameBox.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.fNameBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblUserAccountsBindingSource, "firstName", True))
        Me.fNameBox.Font = New System.Drawing.Font("Trebuchet MS", 9.75!)
        Me.fNameBox.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.fNameBox.isPassword = False
        Me.fNameBox.Location = New System.Drawing.Point(98, 162)
        Me.fNameBox.Margin = New System.Windows.Forms.Padding(4)
        Me.fNameBox.Name = "fNameBox"
        Me.fNameBox.Size = New System.Drawing.Size(274, 47)
        Me.fNameBox.TabIndex = 10276
        Me.fNameBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'UsernameTextBox
        '
        Me.UsernameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblUserAccountsBindingSource, "username", True))
        Me.UsernameTextBox.Location = New System.Drawing.Point(594, 393)
        Me.UsernameTextBox.Name = "UsernameTextBox"
        Me.UsernameTextBox.Size = New System.Drawing.Size(100, 20)
        Me.UsernameTextBox.TabIndex = 10278
        '
        'FirstNameTextBox
        '
        Me.FirstNameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblUserAccountsBindingSource, "firstName", True))
        Me.FirstNameTextBox.Location = New System.Drawing.Point(594, 399)
        Me.FirstNameTextBox.Name = "FirstNameTextBox"
        Me.FirstNameTextBox.Size = New System.Drawing.Size(100, 20)
        Me.FirstNameTextBox.TabIndex = 10280
        '
        'MITextBox
        '
        Me.MITextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblUserAccountsBindingSource, "MI", True))
        Me.MITextBox.Location = New System.Drawing.Point(594, 425)
        Me.MITextBox.Name = "MITextBox"
        Me.MITextBox.Size = New System.Drawing.Size(100, 20)
        Me.MITextBox.TabIndex = 10282
        '
        'LastNameTextBox
        '
        Me.LastNameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblUserAccountsBindingSource, "lastName", True))
        Me.LastNameTextBox.Location = New System.Drawing.Point(594, 451)
        Me.LastNameTextBox.Name = "LastNameTextBox"
        Me.LastNameTextBox.Size = New System.Drawing.Size(100, 20)
        Me.LastNameTextBox.TabIndex = 10284
        '
        'PINTextBox
        '
        Me.PINTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblUserAccountsBindingSource, "PIN", True))
        Me.PINTextBox.Location = New System.Drawing.Point(594, 477)
        Me.PINTextBox.Name = "PINTextBox"
        Me.PINTextBox.Size = New System.Drawing.Size(100, 20)
        Me.PINTextBox.TabIndex = 10286
        '
        'UserTypeTextBox
        '
        Me.UserTypeTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblUserAccountsBindingSource, "userType", True))
        Me.UserTypeTextBox.Location = New System.Drawing.Point(594, 383)
        Me.UserTypeTextBox.Name = "UserTypeTextBox"
        Me.UserTypeTextBox.Size = New System.Drawing.Size(100, 20)
        Me.UserTypeTextBox.TabIndex = 10288
        '
        'PasswordTextBox
        '
        Me.PasswordTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblUserAccountsBindingSource, "password", True))
        Me.PasswordTextBox.Location = New System.Drawing.Point(594, 409)
        Me.PasswordTextBox.Name = "PasswordTextBox"
        Me.PasswordTextBox.Size = New System.Drawing.Size(100, 20)
        Me.PasswordTextBox.TabIndex = 10290
        '
        'PositionTextBox
        '
        Me.PositionTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblUserAccountsBindingSource, "position", True))
        Me.PositionTextBox.Location = New System.Drawing.Point(594, 435)
        Me.PositionTextBox.Name = "PositionTextBox"
        Me.PositionTextBox.Size = New System.Drawing.Size(100, 20)
        Me.PositionTextBox.TabIndex = 10292
        '
        'EmailTextBox
        '
        Me.EmailTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblUserAccountsBindingSource, "email", True))
        Me.EmailTextBox.Location = New System.Drawing.Point(594, 461)
        Me.EmailTextBox.Name = "EmailTextBox"
        Me.EmailTextBox.Size = New System.Drawing.Size(100, 20)
        Me.EmailTextBox.TabIndex = 10294
        '
        'UserPicPictureBox
        '
        Me.UserPicPictureBox.DataBindings.Add(New System.Windows.Forms.Binding("Image", Me.TblUserAccountsBindingSource, "userPic", True))
        Me.UserPicPictureBox.Location = New System.Drawing.Point(594, 521)
        Me.UserPicPictureBox.Name = "UserPicPictureBox"
        Me.UserPicPictureBox.Size = New System.Drawing.Size(100, 50)
        Me.UserPicPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.UserPicPictureBox.TabIndex = 10296
        Me.UserPicPictureBox.TabStop = False
        '
        'BunifuMetroTextbox1
        '
        Me.BunifuMetroTextbox1.BorderColorFocused = System.Drawing.Color.Goldenrod
        Me.BunifuMetroTextbox1.BorderColorIdle = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.BunifuMetroTextbox1.BorderColorMouseHover = System.Drawing.Color.Goldenrod
        Me.BunifuMetroTextbox1.BorderThickness = 1
        Me.BunifuMetroTextbox1.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.BunifuMetroTextbox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblUserAccountsBindingSource, "MI", True))
        Me.BunifuMetroTextbox1.Font = New System.Drawing.Font("Trebuchet MS", 9.75!)
        Me.BunifuMetroTextbox1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.BunifuMetroTextbox1.isPassword = False
        Me.BunifuMetroTextbox1.Location = New System.Drawing.Point(380, 162)
        Me.BunifuMetroTextbox1.Margin = New System.Windows.Forms.Padding(4)
        Me.BunifuMetroTextbox1.Name = "BunifuMetroTextbox1"
        Me.BunifuMetroTextbox1.Size = New System.Drawing.Size(74, 47)
        Me.BunifuMetroTextbox1.TabIndex = 10276
        Me.BunifuMetroTextbox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'BunifuMetroTextbox2
        '
        Me.BunifuMetroTextbox2.BorderColorFocused = System.Drawing.Color.Goldenrod
        Me.BunifuMetroTextbox2.BorderColorIdle = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.BunifuMetroTextbox2.BorderColorMouseHover = System.Drawing.Color.Goldenrod
        Me.BunifuMetroTextbox2.BorderThickness = 1
        Me.BunifuMetroTextbox2.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.BunifuMetroTextbox2.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblUserAccountsBindingSource, "lastName", True))
        Me.BunifuMetroTextbox2.Font = New System.Drawing.Font("Trebuchet MS", 9.75!)
        Me.BunifuMetroTextbox2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.BunifuMetroTextbox2.isPassword = False
        Me.BunifuMetroTextbox2.Location = New System.Drawing.Point(462, 162)
        Me.BunifuMetroTextbox2.Margin = New System.Windows.Forms.Padding(4)
        Me.BunifuMetroTextbox2.Name = "BunifuMetroTextbox2"
        Me.BunifuMetroTextbox2.Size = New System.Drawing.Size(213, 47)
        Me.BunifuMetroTextbox2.TabIndex = 10276
        Me.BunifuMetroTextbox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'BunifuMetroTextbox3
        '
        Me.BunifuMetroTextbox3.BorderColorFocused = System.Drawing.Color.Goldenrod
        Me.BunifuMetroTextbox3.BorderColorIdle = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.BunifuMetroTextbox3.BorderColorMouseHover = System.Drawing.Color.Goldenrod
        Me.BunifuMetroTextbox3.BorderThickness = 1
        Me.BunifuMetroTextbox3.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.BunifuMetroTextbox3.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblUserAccountsBindingSource, "password", True))
        Me.BunifuMetroTextbox3.Font = New System.Drawing.Font("Trebuchet MS", 9.75!)
        Me.BunifuMetroTextbox3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.BunifuMetroTextbox3.isPassword = True
        Me.BunifuMetroTextbox3.Location = New System.Drawing.Point(4, 30)
        Me.BunifuMetroTextbox3.Margin = New System.Windows.Forms.Padding(4)
        Me.BunifuMetroTextbox3.Name = "BunifuMetroTextbox3"
        Me.BunifuMetroTextbox3.Size = New System.Drawing.Size(274, 47)
        Me.BunifuMetroTextbox3.TabIndex = 10276
        Me.BunifuMetroTextbox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'BunifuMetroTextbox4
        '
        Me.BunifuMetroTextbox4.BorderColorFocused = System.Drawing.Color.Goldenrod
        Me.BunifuMetroTextbox4.BorderColorIdle = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.BunifuMetroTextbox4.BorderColorMouseHover = System.Drawing.Color.Goldenrod
        Me.BunifuMetroTextbox4.BorderThickness = 1
        Me.BunifuMetroTextbox4.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.BunifuMetroTextbox4.Font = New System.Drawing.Font("Trebuchet MS", 9.75!)
        Me.BunifuMetroTextbox4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.BunifuMetroTextbox4.isPassword = True
        Me.BunifuMetroTextbox4.Location = New System.Drawing.Point(0, 33)
        Me.BunifuMetroTextbox4.Margin = New System.Windows.Forms.Padding(4)
        Me.BunifuMetroTextbox4.Name = "BunifuMetroTextbox4"
        Me.BunifuMetroTextbox4.Size = New System.Drawing.Size(284, 47)
        Me.BunifuMetroTextbox4.TabIndex = 10276
        Me.BunifuMetroTextbox4.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Label10)
        Me.Panel1.Location = New System.Drawing.Point(24, 325)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(444, 237)
        Me.Panel1.TabIndex = 10332
        '
        'lblCurrentFrm
        '
        Me.lblCurrentFrm.AutoSize = True
        Me.lblCurrentFrm.Font = New System.Drawing.Font("Trebuchet MS", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCurrentFrm.Location = New System.Drawing.Point(339, 5)
        Me.lblCurrentFrm.Name = "lblCurrentFrm"
        Me.lblCurrentFrm.Size = New System.Drawing.Size(80, 40)
        Me.lblCurrentFrm.TabIndex = 10333
        Me.lblCurrentFrm.Text = "User"
        '
        'Guna2Button4
        '
        Me.Guna2Button4.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.Guna2Button4.Animated = True
        Me.Guna2Button4.AnimatedGIF = True
        Me.Guna2Button4.BorderRadius = 10
        Me.Guna2Button4.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Guna2Button4.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.Guna2Button4.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.Guna2Button4.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.Guna2Button4.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.Guna2Button4.FillColor = System.Drawing.Color.Firebrick
        Me.Guna2Button4.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Bold)
        Me.Guna2Button4.ForeColor = System.Drawing.Color.White
        Me.Guna2Button4.Image = Global.BarangaySystem.My.Resources.Resources.iconCancel
        Me.Guna2Button4.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.Guna2Button4.Location = New System.Drawing.Point(389, 297)
        Me.Guna2Button4.Name = "Guna2Button4"
        Me.Guna2Button4.Size = New System.Drawing.Size(103, 49)
        Me.Guna2Button4.TabIndex = 10335
        Me.Guna2Button4.Text = "Cancel"
        Me.Guna2Button4.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.Guna2Button4.TextOffset = New System.Drawing.Point(-5, 0)
        '
        'Guna2Button2
        '
        Me.Guna2Button2.Anchor = System.Windows.Forms.AnchorStyles.Bottom
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
        Me.Guna2Button2.Image = Global.BarangaySystem.My.Resources.Resources.iconAddPerson
        Me.Guna2Button2.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.Guna2Button2.Location = New System.Drawing.Point(274, 297)
        Me.Guna2Button2.Name = "Guna2Button2"
        Me.Guna2Button2.Size = New System.Drawing.Size(103, 49)
        Me.Guna2Button2.TabIndex = 10334
        Me.Guna2Button2.Text = "Save"
        Me.Guna2Button2.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.Guna2Button2.TextOffset = New System.Drawing.Point(-5, 0)
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
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
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(551, 383)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(45, 13)
        Me.Label15.TabIndex = 10336
        Me.Label15.Text = "Label15"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(618, 383)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(45, 13)
        Me.Label16.TabIndex = 10337
        Me.Label16.Text = "Label16"
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.Label13)
        Me.Panel2.Controls.Add(Label6)
        Me.Panel2.Controls.Add(Me.BunifuMetroTextbox4)
        Me.Panel2.Controls.Add(star6)
        Me.Panel2.Location = New System.Drawing.Point(379, 209)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(295, 94)
        Me.Panel2.TabIndex = 10338
        Me.Panel2.Visible = False
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.Red
        Me.Label13.Location = New System.Drawing.Point(137, 13)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(147, 18)
        Me.Label13.TabIndex = 10299
        Me.Label13.Text = "Password do not match!"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(358, 26)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(45, 13)
        Me.Label17.TabIndex = 10339
        Me.Label17.Text = "Label17"
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.BunifuMetroTextbox3)
        Me.Panel3.Controls.Add(Label5)
        Me.Panel3.Controls.Add(askterisk5)
        Me.Panel3.Location = New System.Drawing.Point(95, 212)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(284, 100)
        Me.Panel3.TabIndex = 10340
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(402, 309)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 10341
        Me.Button1.Text = "Button1"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'frmChangeUserDetails
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(805, 356)
        Me.Controls.Add(Me.Guna2Button4)
        Me.Controls.Add(Me.Guna2Button2)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.lblCurrentFrm)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(star2)
        Me.Controls.Add(star4)
        Me.Controls.Add(star3)
        Me.Controls.Add(qweqwe)
        Me.Controls.Add(Label1)
        Me.Controls.Add(UsernameLabel)
        Me.Controls.Add(Me.UsernameTextBox)
        Me.Controls.Add(FirstNameLabel)
        Me.Controls.Add(Me.FirstNameTextBox)
        Me.Controls.Add(MILabel)
        Me.Controls.Add(Me.MITextBox)
        Me.Controls.Add(LastNameLabel)
        Me.Controls.Add(Me.LastNameTextBox)
        Me.Controls.Add(PINLabel)
        Me.Controls.Add(Me.PINTextBox)
        Me.Controls.Add(UserTypeLabel)
        Me.Controls.Add(Me.UserTypeTextBox)
        Me.Controls.Add(PasswordLabel)
        Me.Controls.Add(Me.PasswordTextBox)
        Me.Controls.Add(PositionLabel)
        Me.Controls.Add(Me.PositionTextBox)
        Me.Controls.Add(EmailLabel)
        Me.Controls.Add(Me.EmailTextBox)
        Me.Controls.Add(UserPicLabel)
        Me.Controls.Add(Me.BunifuMetroTextbox2)
        Me.Controls.Add(Me.BunifuMetroTextbox1)
        Me.Controls.Add(Me.UserPicPictureBox)
        Me.Controls.Add(Me.fNameBox)
        Me.Controls.Add(Me.usernameBox)
        Me.Controls.Add(Me.Guna2Button5)
        Me.Controls.Add(Label2)
        Me.Controls.Add(Label3)
        Me.Controls.Add(Label4)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label17)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmChangeUserDetails"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmChangeUserDetails"
        Me.TopMost = True
        CType(Me.TblUserAccountsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DbBrgySystemDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UserPicPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents tmrOpen As System.Windows.Forms.Timer
    Friend WithEvents Guna2Button5 As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Guna2BorderlessForm1 As Guna.UI2.WinForms.Guna2BorderlessForm
    Friend WithEvents TblUserAccountsBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents DbBrgySystemDataSet As BarangaySystem.dbBrgySystemDataSet
    Friend WithEvents fNameBox As Bunifu.Framework.UI.BunifuMetroTextbox
    Friend WithEvents usernameBox As Bunifu.Framework.UI.BunifuMetroTextbox
    Friend WithEvents TblUserAccountsTableAdapter As BarangaySystem.dbBrgySystemDataSetTableAdapters.tblUserAccountsTableAdapter
    Friend WithEvents TableAdapterManager As BarangaySystem.dbBrgySystemDataSetTableAdapters.TableAdapterManager
    Friend WithEvents UsernameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents FirstNameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents MITextBox As System.Windows.Forms.TextBox
    Friend WithEvents LastNameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents PINTextBox As System.Windows.Forms.TextBox
    Friend WithEvents UserTypeTextBox As System.Windows.Forms.TextBox
    Friend WithEvents PasswordTextBox As System.Windows.Forms.TextBox
    Friend WithEvents PositionTextBox As System.Windows.Forms.TextBox
    Friend WithEvents EmailTextBox As System.Windows.Forms.TextBox
    Friend WithEvents UserPicPictureBox As System.Windows.Forms.PictureBox
    Friend WithEvents BunifuMetroTextbox4 As Bunifu.Framework.UI.BunifuMetroTextbox
    Friend WithEvents BunifuMetroTextbox3 As Bunifu.Framework.UI.BunifuMetroTextbox
    Friend WithEvents BunifuMetroTextbox2 As Bunifu.Framework.UI.BunifuMetroTextbox
    Friend WithEvents BunifuMetroTextbox1 As Bunifu.Framework.UI.BunifuMetroTextbox
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents lblCurrentFrm As System.Windows.Forms.Label
    Friend WithEvents Guna2Button4 As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Guna2Button2 As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents Button1 As System.Windows.Forms.Button
End Class
