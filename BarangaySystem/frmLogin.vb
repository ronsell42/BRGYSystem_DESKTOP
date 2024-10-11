Public Class frmLogin


    Private Sub TblUserAccountsBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.TblUserAccountsBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DbBrgySystemDataSet)

    End Sub

    Private Sub frmLogin_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed

    End Sub

    Public Sub frmLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Try
            'TODO: This line of code loads data into the 'DbBrgySystemDataSet.tblHistory' table. You can move, or remove it, as needed.
            Me.TblHistoryTableAdapter.Fill(Me.DbBrgySystemDataSet.tblHistory)
            'TODO: This line of code loads data into the 'DbBrgySystemDataSet.tblUserAccounts' table. You can move, or remove it, as needed.
            Me.TblUserAccountsTableAdapter.Fill(Me.DbBrgySystemDataSet.tblUserAccounts)

        Catch ex As Exception
            frmDBSett.Show()

        End Try
        pass1.Focus()

    End Sub

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        Dim user_1 = From tblUserAccounts In DbBrgySystemDataSet.tblUserAccounts
        Where tblUserAccounts.username = user1.Text

        If user_1.Count = 1 Or user_1.Count > 1 Then
            Dim username = user1.Text

            Me.TblUserAccountsTableAdapter.passbyUser(Me.DbBrgySystemDataSet.tblUserAccounts, username)
            If PasswordTextBox.Text = pass1.Text Then


                'Kill = False

                frmMain.Show()
                frmMain.TextBox1.Text = user1.Text
                MsgBox("Welcome " + user1.Text + ".", MsgBoxStyle.Information, "User Accounts")

                Me.TblUserAccountsTableAdapter.Fill(Me.DbBrgySystemDataSet.tblUserAccounts)
                Me.Hide()


            Else
                MsgBox("Wrong username or password.", MsgBoxStyle.Exclamation, "User Accounts")
            End If
        ElseIf user1.Text = "" And pass1.Text = "" Then
            MsgBox("Please fill login fields!", MsgBoxStyle.Exclamation, "User Accounts")

        ElseIf user1.Text = "" Then
            MsgBox("Username cannot be empty!", MsgBoxStyle.Exclamation, "User Accounts")
        ElseIf pass1.Text = "" Then
            MsgBox("Please enter a password!", MsgBoxStyle.Exclamation, "User Accounts")
        Else
            MsgBox("Wrong username or password.", MsgBoxStyle.Exclamation, "User Accounts")
        End If

     

    End Sub

   

End Class