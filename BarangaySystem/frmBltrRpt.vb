Public Class frmBltrRpt

    Private Sub frmBltrRpt_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DbBrgySystemDataSet.tblBlotter' table. You can move, or remove it, as needed.
        Me.TblBlotterTableAdapter.Fill(Me.DbBrgySystemDataSet.tblBlotter)

        blotterTbl.Sort(blotterTbl.Columns(0), System.ComponentModel.ListSortDirection.Descending)
    End Sub

    Private Sub Guna2Button4_Click(sender As Object, e As EventArgs) Handles Guna2Button4.Click
        If MsgBox("Are you sure you want to delete the report of" + "'" + ComplainantTextBox.Text +
                " from the record? This action will not be undone.",
                MsgBoxStyle.YesNo, "Blotter Report") =
                MsgBoxResult.Yes Then
            Try
                Label2.Text = WhoTextBox.Text
                Dim deleteBlotter As Integer = IDTextBox.Text
                Me.TblBlotterTableAdapter.DeleteQueryBlotter(deleteBlotter)
                Me.TblBlotterTableAdapter.Fill(Me.DbBrgySystemDataSet.tblBlotter)

                'Call the History Window
                With frmHistory
                    .TopLevel = False
                    frmMain.pnlCenter.Controls.Add(frmHistory)
                    .BringToFront()
                    .Show()
                    frmHistory.TblHistoryTableAdapter.Fill(frmHistory.DbBrgySystemDataSet.tblHistory)

                End With
                frmHistory.Button3.PerformClick()
                frmHistory.WhoWasItTextBox.Text = Label2.Text
                frmHistory.EventDateDateTimePicker.Value = Date.Now

                frmHistory.ActionTakenTextBox.Text = "Delete Blotter"

                frmHistory.Button4.PerformClick()
                frmMain.btnBlotterReport.PerformClick()

                MsgBox("Record successfully deleted!", MsgBoxStyle.Information, "Residents")

            Catch ex As Exception
                MsgBox("An error occured while deleting. Try to restart the application.", MsgBoxStyle.Exclamation, "Residents")
            End Try

        End If
    End Sub

    Private Sub Guna2Button3_Click(sender As Object, e As EventArgs) Handles Guna2Button3.Click
        Label1.Text = "Edit"
        frmModifyBlotter.Show()
        Me.Opacity = 0%

    End Sub


    Private Sub Guna2Button2_Click(sender As Object, e As EventArgs) Handles Guna2Button2.Click
        Label1.Text = "Add"
        frmModifyBlotter.Show()
        Me.Opacity = 0%
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.TblBlotterTableAdapter.Fill(Me.DbBrgySystemDataSet.tblBlotter)

    End Sub

    Private Sub studentsTbl_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles blotterTbl.CellContentClick
        If blotterTbl.Columns(e.ColumnIndex).Name = "Edit" Then
            Guna2Button3_Click(sender, e)
        ElseIf blotterTbl.Columns(e.ColumnIndex).Name = "Delete" Then
            Guna2Button4_Click(sender, e)
        End If
    End Sub

    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles Guna2Button1.Click
        Dim searchBLotter As String = "%" + residentSearchBox.Text + "%"
        Me.TblBlotterTableAdapter.searchBlotter(Me.DbBrgySystemDataSet.tblBlotter, searchBLotter, searchBLotter)
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
        Me.TblBlotterTableAdapter.Fill(Me.DbBrgySystemDataSet.tblBlotter)

    End Sub

    Private Sub Guna2Button5_Click(sender As Object, e As EventArgs) Handles Guna2Button5.Click
        frmMain.Opacity = 100%
        frmMain.ShowInTaskbar = True
        frmMain.Show()
        frmMain.BringToFront()
        If frmMain.btnHistory.FillColor = Color.Khaki Then
            'do nothing
        Else
            frmHistory.Close()
        End If

        Me.Close()
    End Sub

    Private Sub Guna2Button6_Click(sender As Object, e As EventArgs) Handles Guna2Button6.Click
        frmMain.Opacity = 100%
        frmMain.ShowInTaskbar = True
        frmMain.BringToFront()
        frmMain.Show()
        If frmMain.btnHistory.FillColor = Color.Khaki Then
            'do nothing
        Else
            frmHistory.Close()
        End If

        Me.Close()
    End Sub

    Public Sub ReportAttachedTextBox_TextChanged(sender As Object, e As EventArgs) Handles ReportAttachedTextBox.TextChanged

        If ReportAttachedTextBox.Text = "" Then
            PictureBox1.Image = Nothing
        Else
            Dim id As String = ReportAttachedTextBox.Text
            Dim folder As String = "C:\BRGYSys\blotterPictures"
            Dim fileName As String = System.IO.Path.Combine(folder, id)

            Try
                Using fs As New System.IO.FileStream(fileName, IO.FileMode.Open)
                    PictureBox1.Image = New Bitmap(Image.FromStream(fs))
                End Using
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If

    End Sub
End Class