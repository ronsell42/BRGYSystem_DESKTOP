Public Class frmSettings

    Private Sub Guna2Button5_Click(sender As Object, e As EventArgs) Handles Guna2Button5.Click
        Me.Hide()
        frmMain.Show()
        frmMain.Opacity = 100
        frmMain.BringToFront()
    End Sub

    Private Sub btnAccSett_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub frmSettings_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DbBrgySystemDataSet.tblUserAccounts' table. You can move, or remove it, as needed.
        Me.TblUserAccountsTableAdapter.Fill(Me.DbBrgySystemDataSet.tblUserAccounts)

        Label8.Text = frmMain.TextBox1.Text
        Label7.Text = FirstNameTextBox1.Text + " " + MITextBox1.Text + " " + LastNameTextBox1.Text
        Label9.Text = UserTypeTextBox1.Text

        With frmUsers
            .TopLevel = False
            Panel9.Controls.Add(frmUsers)
            .BringToFront()
            .Show()
        End With

        With frmDBSett
            .TopLevel = False
            Panel2.Controls.Add(frmDBSett)
            .BringToFront()
            .Show()
        End With

        'CHECK IF ADMIN
        If frmMain.TextBox4.Text = "User" Then
            Guna2TabControl1.TabPages.Remove(TabPage2)
            Guna2TabControl1.TabPages.Remove(TabPage3)
        Else

        End If
    End Sub


    Private Sub Guna2Button10_Click(sender As Object, e As EventArgs) Handles Guna2Button10.Click

        frmMain.TextBox2.Text = "Edit"
        Dim frm As New frmChangeUserDetails
        frm.Location = New Point((WorkingArea.Width - frm.Width) / 2, 0) 'set popup form in the middle of the screen
        TransparentBG2.ShowForm(frm)



    End Sub

    Private Sub Label8_TxtChanged(sender As Object, e As EventArgs) Handles Label8.TextChanged
        Dim searchUser As String = Label8.Text
        Me.TblUserAccountsTableAdapter.searchByUser(Me.DbBrgySystemDataSet.tblUserAccounts, searchUser)
    End Sub


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim searchUser As String = Label8.Text
        Me.TblUserAccountsTableAdapter.searchByUser(Me.DbBrgySystemDataSet.tblUserAccounts, searchUser)
    End Sub

    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles Guna2Button1.Click
        Me.Hide()
        frmMain.Show()

        frmMain.Opacity = 100%
        frmMain.BringToFront()
    End Sub
End Class