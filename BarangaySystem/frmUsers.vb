Public Class frmUsers

    Private Sub frmUsers_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DbBrgySystemDataSet.tblUserAccounts' table. You can move, or remove it, as needed.
        Me.TblUserAccountsTableAdapter.Fill(Me.DbBrgySystemDataSet.tblUserAccounts)


    End Sub

    Private Sub Guna2Button6_Click(sender As Object, e As EventArgs) Handles Guna2Button6.Click
        If UsernameTextBox.Text = frmMain.TextBox1.Text Then
            frmMain.TextBox2.Text = "Edit"
            frmMain.TextBox3.Text = ""
            Dim foam As New frmChangeUserDetails
            foam.Location = New Point((WorkingArea.Width - foam.Width) / 2, 0) 'set popup form in the middle of the screen
            TransparentBG2.ShowForm(foam)
        Else
            frmMain.TextBox2.Text = "Edit2"
            frmMain.TextBox3.Text = UsernameTextBox.Text
            Dim foam As New frmChangeUserDetails
            foam.Location = New Point((WorkingArea.Width - foam.Width) / 2, 0) 'set popup form in the middle of the screen
            TransparentBG2.ShowForm(foam)
        End If

    End Sub

    Private Sub Guna2Button7_Click(sender As Object, e As EventArgs) Handles Guna2Button7.Click
        frmMain.TextBox2.Text = "Add"

        Dim frm As New frmChangeUserDetails
        frm.Location = New Point((WorkingArea.Width - frm.Width) / 2, 0) 'set popup form in the middle of the screen
        TransparentBG2.ShowForm(frm)
    End Sub

    Private Sub UsernameTextBox_TextChanged(sender As Object, e As EventArgs) Handles UsernameTextBox.TextChanged
        

        If frmMain.TextBox1.Text = UsernameTextBox.Text Then
            frmMain.TextBox2.Text = "Edit"
            Guna2Button4.Enabled = False
            Guna2Button8.Enabled = False
        Else
            Guna2Button4.Enabled = True
            Guna2Button8.Enabled = True
        End If
    End Sub

    Private Sub Guna2Button4_Click(sender As Object, e As EventArgs) Handles Guna2Button4.Click
        If MsgBox("Are you sure you want to delete user" + "'" + UsernameTextBox.Text +
                 " from the system? This action will not be undone.",
                 MsgBoxStyle.YesNo, "Accounts") = MsgBoxResult.Yes Then
            Try

                Dim deleteUser As String = UsernameTextBox.Text
                Me.TblUserAccountsTableAdapter.DeleteQuery(deleteUser)
                Me.TblUserAccountsTableAdapter.Fill(Me.DbBrgySystemDataSet.tblUserAccounts)

                MsgBox("Account successfully deleted!", MsgBoxStyle.Information, "Account")

            Catch ex As Exception
                MsgBox("An error occured while deleting. Try to restart the application.", MsgBoxStyle.Exclamation, "Residents")
            End Try
        End If
    End Sub

    Private Sub Guna2Button8_Click(sender As Object, e As EventArgs) Handles Guna2Button8.Click
        If MsgBox("Are you sure you want reset user" + "'" + UsernameTextBox.Text +
                 " password to '12345678'?",
                 MsgBoxStyle.YesNo, "Accounts") = MsgBoxResult.Yes Then

            Try
                Dim password As Integer = 12345678
                Dim searchUser As String = "%" + UsernameTextBox.Text + "%"
                Me.TblUserAccountsTableAdapter.resetPassword(searchUser)

                MessageBox.Show("Password successfuly reset!")
            Catch ex As Exception
                MessageBox.Show("Error Changing Password. Please restart the Application")
            End Try
            

        End If

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.TblUserAccountsTableAdapter.Fill(Me.DbBrgySystemDataSet.tblUserAccounts)
    End Sub

End Class