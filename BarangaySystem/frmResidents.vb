Public Class frmResidents

    Private Sub frmResidents_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'TODO: This line of code loads data into the 'DbBrgySystemDataSet.tblResidents' table. You can move, or remove it, as needed.
        Me.TblResidentsTableAdapter.Fill(Me.DbBrgySystemDataSet.tblResidents)
        ResidentsTbl.Sort(ResidentsTbl.Columns(0), System.ComponentModel.ListSortDirection.Descending)
    End Sub

    Private Sub Guna2Button2_Click(sender As Object, e As EventArgs) Handles Guna2Button2.Click
        Label1.Text = "Add"
        Dim frm As New frmModifyResident
        frm.Location = New Point((WorkingArea.Width - frm.Width) / 2, 0) 'set popup form in the middle of the screen
        frmTransparentBG.ShowForm(frm)
        'frm.ShowDialog()


    End Sub


    Private Sub Guna2Button3_Click(sender As Object, e As EventArgs) Handles Guna2Button3.Click
        Label1.Text = "Edit"
        Dim frm As New frmModifyResident
        frm.Location = New Point((WorkingArea.Width - frm.Width) / 2, 0) 'set popup form in the middle of the screen
        frmTransparentBG.ShowForm(frm)
        'frm.ShowDialog()

    End Sub

    Private Sub studentsTbl_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles ResidentsTbl.CellContentClick
        If ResidentsTbl.Columns(e.ColumnIndex).Name = "Edit" Then
            Guna2Button3_Click(sender, e)
        ElseIf ResidentsTbl.Columns(e.ColumnIndex).Name = "Delete" Then
            Guna2Button4_Click(sender, e)
        End If
    End Sub

    Public Sub Guna2Button5_Click(sender As Object, e As EventArgs) Handles Guna2Button5.Click
        With frmReport
            .TopLevel = False
            frmMain.pnlCenter.Controls.Add(frmReport)
            .BringToFront()
            .Show()

            Me.Hide()
        End With

        frmMain.btnBusinessTrade.Visible = True
        frmMain.btnClearance.Visible = True
        frmMain.btnResidency.Visible = True
        frmMain.btnIndigency.Visible = True

        frmMain.btnHome.Visible = False
        frmMain.btnResidents.Visible = False
        frmMain.btnBlotterReport.Visible = False
        frmMain.btnHistory.Visible = False
        frmMain.btnAbout.Visible = False
        frmMain.btnSettings.Visible = False


        'frmMain.btnIndigency_Click(sender, e)
        If Me.SexTextBox.Text = "Male" Then
            frmReport.TextBox2.Text = "Mr."
        ElseIf Me.SexTextBox.Text = "Female" Then
            frmReport.TextBox2.Text = "Ms."
        End If
        frmReport.TextBox1.Text = Me.AgeTextBox.Text
        frmReport.NameTextBox.Text = Me.FirstNameTextBox.Text +
            " " + MInitialTextBox.Text + " " + LastNameTextBox.Text + " " + NameExtTextBox.Text


    


    End Sub


    Private Sub Guna2Button4_Click(sender As Object, e As EventArgs) Handles Guna2Button4.Click
       
        If MsgBox("Are you sure you want to delete " + "'" + FullNameTextBox.Text +
                  " from the record? This action will not be undone.",
                  MsgBoxStyle.YesNo, "Residents Record") =
                  MsgBoxResult.Yes Then
            Try

                Dim deleteResident As Integer = IDTextBox.Text
                Me.TblResidentsTableAdapter.DeleteQuery(deleteResident)
                Me.TblResidentsTableAdapter.Fill(Me.DbBrgySystemDataSet.tblResidents)
                'Call the History Window
                With frmHistory
                    .TopLevel = False
                    frmMain.pnlCenter.Controls.Add(frmHistory)
                    .BringToFront()
                    .Show()
                    frmHistory.TblHistoryTableAdapter.Fill(frmHistory.DbBrgySystemDataSet.tblHistory)

                End With
                frmHistory.Button3.PerformClick()
                frmHistory.WhoWasItTextBox.Text = FullNameTextBox.Text
                frmHistory.EventDateDateTimePicker.Value = Date.Now

                frmHistory.ActionTakenTextBox.Text = "Delete Resident"

                frmHistory.Button4.PerformClick()
                frmMain.btnResidents.PerformClick()
                MsgBox("Record successfully deleted!", MsgBoxStyle.Information, "Residents")

            Catch ex As Exception
                MsgBox("An error occured while deleting. Try to restart the application.", MsgBoxStyle.Exclamation, "Residents")
            End Try

        End If
    End Sub

    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles Guna2Button1.Click
        Dim searchResident As String = "%" + residentSearchBox.Text + "%"
        Me.TblResidentsTableAdapter.searchResident(Me.DbBrgySystemDataSet.tblResidents, searchResident, searchResident, searchResident)
        If IDTextBox.Text = "" Then
            MsgBox("No record found!")
        Else

        End If
    End Sub

    Private Sub residentSearchBox_TextChanged(sender As Object, e As EventArgs) Handles residentSearchBox.TextChanged
        If residentSearchBox.Text = "" Then
            clearSearch.Visible = False
            Guna2Button1.Enabled = False
        Else
            clearSearch.Visible = True
            Guna2Button1.Enabled = True
        End If
    End Sub

    Private Sub clearSearch_Click(sender As Object, e As EventArgs) Handles clearSearch.Click
        residentSearchBox.ResetText()
        Me.TblResidentsTableAdapter.Fill(Me.DbBrgySystemDataSet.tblResidents)

    End Sub

    Private Sub refreshBtn_Click(sender As Object, e As EventArgs) Handles refreshBtn.Click
        Me.TblResidentsTableAdapter.Fill(Me.DbBrgySystemDataSet.tblResidents)
        ResidentsTbl.Sort(ResidentsTbl.Columns(0), System.ComponentModel.ListSortDirection.Descending)
    End Sub

End Class