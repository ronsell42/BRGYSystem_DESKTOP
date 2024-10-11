Imports System.Text
Imports System.IO
Public Class frmDBSett

    Private Sub TblDatabaseBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.TblDatabaseBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DbBrgySystemDataSet)

    End Sub

    Private Sub frmDBSett_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DbBrgySystemDataSet.tblDatabase' table. You can move, or remove it, as needed.
        Me.TblDatabaseTableAdapter.Fill(Me.DbBrgySystemDataSet.tblDatabase)
    End Sub

    Private Sub btnBackupNow_Click(sender As Object, e As EventArgs) Handles btnBackupNow.Click
        Button2.Text = txtBoxBackupDir.Text
        BackupPathTextBox.Text = Button2.Text
        Button2.PerformClick()
    
    End Sub

    Private Sub btnChange_Click(sender As Object, e As EventArgs) Handles btnChange.Click
        If FolderBrowserDialog1.ShowDialog() = Windows.Forms.DialogResult.OK Then
            txtBoxBackupDir.Text = FolderBrowserDialog1.SelectedPath.ToString

            Dim root As Environment.SpecialFolder = FolderBrowserDialog1.RootFolder
        End If
    End Sub


    Private Sub btnBrowse_Click(sender As Object, e As EventArgs) Handles btnBrowse.Click
        If OpenFileDialog1.ShowDialog = DialogResult.OK Then
            txtBoxRestoreDir.Text = OpenFileDialog1.FileName
        End If
    End Sub

    Private Sub BackupPathTextBox_TextChanged(sender As Object, e As EventArgs) Handles BackupPathTextBox.TextChanged
        txtBoxBackupDir.Text = BackupPathTextBox.Text
    End Sub

    Private Sub RestorePathTextBox_TextChanged(sender As Object, e As EventArgs) Handles RestorePathTextBox.TextChanged
        'txtBoxRestoreDir.Text = RestorePathTextBox.Text
    End Sub

    Private Sub txtBoxBackupDir_TextChanged(sender As Object, e As EventArgs) Handles txtBoxBackupDir.TextChanged
        If Not txtBoxBackupDir.Text = BackupPathTextBox.Text Then
            btnUndo1.Visible = True
        Else
            btnUndo1.Visible = False
        End If
    End Sub

    Private Sub txtBoxRestoreDir_TextChanged(sender As Object, e As EventArgs) Handles txtBoxRestoreDir.TextChanged
      
    End Sub

    Private Sub btnUndo1_Click(sender As Object, e As EventArgs) Handles btnUndo1.Click
        txtBoxBackupDir.Text = BackupPathTextBox.Text
    End Sub

    Private Sub btnUndo2_Click(sender As Object, e As EventArgs)
        txtBoxRestoreDir.Text = RestorePathTextBox.Text
    End Sub

    Private Sub btnRestoreNow_Click(sender As Object, e As EventArgs) Handles btnRestoreNow.Click


        If System.IO.File.Exists("C:\BRGYSys\dbBrgySystem.mdb") Then
            If MsgBox("Do you want to overwrite the current database saved on your directory?",
                MsgBoxStyle.YesNo, "Database Already Exists") =
                MsgBoxResult.Yes Then
                Try
                    File.Delete("C:\BRGYSys\dbBrgySystem.mdb")
                    File.Copy(txtBoxRestoreDir.Text, "C:\BRGYSys\dbBrgySystem.mdb")

                    MsgBox("Databse backup successfuly!")
                    Application.Restart()
                Catch ex As Exception
                    MessageBox.Show("There was an error, please try restarting the application.")
                End Try

            End If
        Else
            Try
                File.Copy(txtBoxRestoreDir.Text, "C:\BRGYSys\dbBrgySystem.mdb")
                MsgBox("Databse backup successfuly!")
            Catch ex As Exception
                MessageBox.Show("There was an error, please try restarting the application.")
            End Try

        End If

    End Sub

    Dim successbackup As Boolean = False

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        Try
            Dim fileNumber As String = frmMain.Label4.Text + frmMain.Label5.Text + frmMain.Label6.Text +
            frmMain.Label1.Text + frmMain.Label2.Text + frmMain.Label3.Text

            File.Copy("C:\BRGYSys\dbBrgySystem.mdb", txtBoxBackupDir.Text & "\" & fileNumber & "dbBrgySystem.mdb")

            Dim backupPath As String = Button2.Text
            Me.TblDatabaseTableAdapter.UpdateBackup(backupPath)

            MessageBox.Show("Backup Succesful!")
            successbackup = True
        Catch ex As Exception
            MessageBox.Show("There was an error, please try restarting the application.")
        End Try
     

    End Sub


    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Label6.Text = Date.Now.Hour
        Label7.Text = Date.Now.Minute
        Label8.Text = Date.Now.Second

    End Sub

End Class