Public Class frmChangeUserDetails

    Dim YLocation As Integer = (WorkingArea.Height - Me.Height) / 7 'Startup Location, Higher number = higher starting

    Private Sub tmrOpen_Tick(sender As Object, e As EventArgs) Handles tmrOpen.Tick
        If Me.Location.Y >= YLocation Then
            'Stop timer when popup form Y location reached to final location
            tmrOpen.Stop()
        Else
            'increase popup form Y location gradually
            Me.Location = New Point(Me.Location.X, Me.Location.Y + 5) 'Speed of Transition

        End If
    End Sub

    Private Sub Guna2Button5_Click(sender As Object, e As EventArgs) Handles Guna2Button5.Click
        Me.Close()
    End Sub


    Private Sub frmChangeUserDetails_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DbBrgySystemDataSet.tblUserAccounts' table. You can move, or remove it, as needed.

        If frmMain.TextBox2.Text = "Add" Then
            TblUserAccountsBindingSource.AddNew()

            Me.BunifuMetroTextbox3.isPassword = False
            Me.BunifuMetroTextbox4.isPassword = False
            BunifuMetroTextbox3.Text = "12345678"
            BunifuMetroTextbox4.Text = "12345678"
            Me.BunifuMetroTextbox4.Text = Me.BunifuMetroTextbox4.Text
            Me.BunifuMetroTextbox3.Enabled = False
            Me.BunifuMetroTextbox4.Enabled = False
        ElseIf frmMain.TextBox2.Text = "Edit" Then
            Dim searchByUser As String = frmMain.TextBox1.Text
            Me.TblUserAccountsTableAdapter.searchByUser(Me.DbBrgySystemDataSet.tblUserAccounts, searchByUser)
            Panel2.Visible = False

        ElseIf frmMain.TextBox2.Text = "Edit2" Then
            Dim searchByUser As String = frmMain.TextBox3.Text
            Me.TblUserAccountsTableAdapter.searchByUser(Me.DbBrgySystemDataSet.tblUserAccounts, searchByUser)

            Panel2.Visible = False
            Panel3.Visible = False
            Me.Height = 284
        End If

        Label17.Text = PasswordTextBox.Text

    'Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles Guna2Button1.Click
    'If OpenFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
    'PictureBox1.Image = Image.FromFile(OpenFileDialog1.FileName)
    ' UserPicPictureBox.Image = PictureBox1.Image
        ' End If
        UsernameTextBox.Focus()
    End Sub



    Private Sub BunifuMetroTextbox2_OnValueChanged(sender As Object, e As EventArgs) Handles BunifuMetroTextbox2.OnValueChanged
        LastNameTextBox.Text = BunifuMetroTextbox2.Text
    End Sub

    Private Sub BunifuMetroTextbox3_OnValueChanged(sender As Object, e As EventArgs) Handles BunifuMetroTextbox3.OnValueChanged

        If frmMain.TextBox2.Text = "Add" Then

            If BunifuMetroTextbox3.Text = "" Then
                Panel2.Visible = False
            Else
                Panel2.Visible = True
            End If

        ElseIf frmMain.TextBox2.Text = "Edit" Then

            Label17.Text = PasswordTextBox.Text

            If Label17.Text = BunifuMetroTextbox3.Text Then
                'Panel2.Visible = False
            Else
                Panel2.Visible = True
            End If

        ElseIf frmMain.TextBox2.Text = "Edit2" Then
            Label17.Text = PasswordTextBox.Text
        End If

    End Sub

    Private Sub Guna2Button2_Click(sender As Object, e As EventArgs) Handles Guna2Button2.Click
        'IF REQUIRED FIELD IS INCOMPLETE
        If usernameBox.Text = "" Or fNameBox.Text = "" Or BunifuMetroTextbox1.Text = "" Or
            BunifuMetroTextbox2.Text = "" Or BunifuMetroTextbox3.Text = "" Or BunifuMetroTextbox4.Text = "" And
             BunifuMetroTextbox4.Visible = True And Not BunifuMetroTextbox3.Text = BunifuMetroTextbox4.Text Then

            MessageBox.Show("Please complete all required fields!")


            'IF  REQUIRED FIELD IS COMPLETE
        Else

            If frmMain.TextBox3.Text = "" And frmMain.TextBox2.Text = "Edit" Then
                Try
                    PasswordTextBox.Text = BunifuMetroTextbox3.Text
                    If frmMain.TextBox4.Text = "User" Then
                        UserTypeTextBox.Text = "User"
                    Else
                        UserTypeTextBox.Text = "Administrator"
                    End If
                    Me.Validate()
                    Me.TblUserAccountsBindingSource.EndEdit()
                    Me.TableAdapterManager.UpdateAll(Me.DbBrgySystemDataSet)

                    MsgBox("Data Saved!", MsgBoxStyle.Information)

                    Dim searchUser As String = frmSettings.Label8.Text
                    MessageBox.Show("Your System will restart. Please login again!")
                    Application.Restart()

                Catch ex As Exception
                    MsgBox("Error saving data.!", MsgBoxStyle.Exclamation)
                End Try

            ElseIf frmMain.TextBox3.Text = "" And frmMain.TextBox2.Text = "Add" Then
                Try
                    PasswordTextBox.Text = BunifuMetroTextbox3.Text
                    UserTypeTextBox.Text = "User"
                    Me.Validate()
                    Me.TblUserAccountsBindingSource.EndEdit()
                    Me.TableAdapterManager.UpdateAll(Me.DbBrgySystemDataSet)

                    Button1.PerformClick()
                    MsgBox("Data Saved!", MsgBoxStyle.Information)
                    frmUsers.Button1.PerformClick()
                    Me.Close()


                Catch ex As Exception
                    MsgBox("Error saving data.!", MsgBoxStyle.Exclamation)
                End Try
            Else
                Try
                    PasswordTextBox.Text = BunifuMetroTextbox3.Text
                    UserTypeTextBox.Text = "User"
                    Me.Validate()
                    Me.TblUserAccountsBindingSource.EndEdit()
                    Me.TableAdapterManager.UpdateAll(Me.DbBrgySystemDataSet)

                    MsgBox("Data Saved!", MsgBoxStyle.Information)
                    Button1.PerformClick()
                    Me.Close()
                Catch ex As Exception
                    MsgBox("Error saving data.!", MsgBoxStyle.Exclamation)
                End Try
            End If

        End If


    End Sub

    Private Sub Guna2Button4_Click(sender As Object, e As EventArgs) Handles Guna2Button4.Click
        Me.Close()
    End Sub

    Private Sub usernameBox_OnValueChanged(sender As Object, e As EventArgs) Handles usernameBox.OnValueChanged
        UsernameTextBox.Text = usernameBox.Text

    End Sub

    Private Sub fNameBox_OnValueChanged(sender As Object, e As EventArgs) Handles fNameBox.OnValueChanged
        FirstNameTextBox.Text = fNameBox.Text
    End Sub

    Private Sub BunifuMetroTextbox4_OnValueChanged(sender As Object, e As EventArgs) Handles BunifuMetroTextbox4.OnValueChanged
        If BunifuMetroTextbox4.Text = BunifuMetroTextbox3.Text Then
            Label13.Text = "Passwords match!"
            Label13.ForeColor = Color.SeaGreen

        Else
            Label13.Text = "Password do not match!"
            Label13.ForeColor = Color.Red
        End If
    End Sub


    Private Sub BunifuMetroTextbox1_OnValueChanged(sender As Object, e As EventArgs) Handles BunifuMetroTextbox1.OnValueChanged
        MITextBox.Text = BunifuMetroTextbox1.Text
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        frmUsers.Button1.PerformClick()
    End Sub
End Class