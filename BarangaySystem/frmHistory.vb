Public Class frmHistory

    Private Sub frmHistory_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DbBrgySystemDataSet.tblUserAccounts' table. You can move, or remove it, as needed.
        Me.TblUserAccountsTableAdapter.Fill(Me.DbBrgySystemDataSet.tblUserAccounts)

        'TODO: This line of code loads data into the 'DbBrgySystemDataSet.tblHistory' table. You can move, or remove it, as needed.
        Me.TblHistoryTableAdapter.Fill(Me.DbBrgySystemDataSet.tblHistory)

        HistoryTbl.Sort(HistoryTbl.Columns(0), System.ComponentModel.ListSortDirection.Descending)

        Label4.Text = BunifuDropdown2.selectedIndex

        Dim listCount As Integer = 1
        Dim userCount As Integer

        userCount = TblUserAccountsDataGridView.RowCount

        Do Until listCount = userCount

            BunifuDropdown3.AddItem(UsernameTextBox.Text)

            TblUserAccountsBindingSource.MoveNext()
            listCount = listCount + 1
        Loop
        BunifuDropdown3.selectedIndex = 0
        BunifuDropdown2.selectedIndex = 0
        Label6.Text = BunifuDropdown3.selectedValue
        Dim filterAction As String = BunifuDropdown2.selectedValue
        Dim filterByWho As String = BunifuDropdown3.selectedValue
        Me.TblHistoryTableAdapter.FillbyFilters(Me.DbBrgySystemDataSet.tblHistory, filterAction, filterByWho)

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        TblHistoryBindingSource.AddNew()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        EventDateDateTimePicker.Value = Date.Now
        'WhoWasItTextBox.Text = frmMain.TextBox1.Text
        'ActionTakenTextBox.Text = "TEst"
        ByWhoTextBox.Text = frmMain.TextBox1.Text
        Me.Validate()
        Me.TblHistoryBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DbBrgySystemDataSet)
    End Sub



    Private Sub BunifuDropdown2_onItemSelected(sender As Object, e As EventArgs) Handles BunifuDropdown2.onItemSelected

        Label4.Text = BunifuDropdown2.selectedValue
        Timer1.Start()
        If BunifuDropdown2.selectedIndex = 0 Then

            Dim filterByWho As String = BunifuDropdown3.selectedValue
            Me.TblHistoryTableAdapter.FillByUser(Me.DbBrgySystemDataSet.tblHistory, filterByWho)

        ElseIf BunifuDropdown3.selectedIndex = 0 Then
            Dim filterAction As String = BunifuDropdown2.selectedValue
            Me.TblHistoryTableAdapter.FilterAction(Me.DbBrgySystemDataSet.tblHistory, filterAction)

        ElseIf BunifuDropdown2.selectedIndex = 0 And BunifuDropdown3.selectedIndex = 0 Then

            Button5.PerformClick()

        Else
            Dim filterAction As String = BunifuDropdown2.selectedValue
            Dim filterByWho As String = BunifuDropdown3.selectedValue
            Me.TblHistoryTableAdapter.FillbyFilters(Me.DbBrgySystemDataSet.tblHistory, filterAction, filterByWho)

        End If


    End Sub



    Private Sub BunifuDropdown3_onItemSelected(sender As Object, e As EventArgs) Handles BunifuDropdown3.onItemSelected
        Label6.Text = BunifuDropdown3.selectedValue
        Timer1.Start()
        Try

            If BunifuDropdown2.selectedIndex = 0 Then

                Dim filterByWho As String = BunifuDropdown3.selectedValue
                Me.TblHistoryTableAdapter.FillByUser(Me.DbBrgySystemDataSet.tblHistory, filterByWho)

            ElseIf BunifuDropdown3.selectedIndex = 0 Then
                Dim filterAction As String = BunifuDropdown2.selectedValue
                Me.TblHistoryTableAdapter.FilterAction(Me.DbBrgySystemDataSet.tblHistory, filterAction)


            ElseIf BunifuDropdown2.selectedIndex = 0 And BunifuDropdown3.selectedIndex = 0 Then
                Button5.PerformClick()

            Else
                Dim filterAction As String = BunifuDropdown2.selectedValue
                Dim filterByWho As String = BunifuDropdown3.selectedValue
                Me.TblHistoryTableAdapter.FillbyFilters(Me.DbBrgySystemDataSet.tblHistory, filterAction, filterByWho)

            End If



        Catch ex As Exception

        End Try


    End Sub


    Private Sub Label4_TextChanged(sender As Object, e As EventArgs) Handles Label4.TextChanged
        If Label4.Text = Label6.Text Then
            Timer1.Start()

        End If
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Me.TblHistoryTableAdapter.Fill(Me.DbBrgySystemDataSet.tblHistory)
        Try
            HistoryTbl.Sort(HistoryTbl.Columns(0), System.ComponentModel.ListSortDirection.Descending)
        Catch ex As Exception

        End Try

    End Sub

    Private Sub Label6_TextChanged(sender As Object, e As EventArgs) Handles Label6.TextChanged

        If Label4.Text = Label6.Text Then
            Timer1.Start()

            Button5.PerformClick()

        End If
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick

        If Label4.Text = "All" And Label6.Text = "All" Then
            Button5_Click(sender, e)
            Timer1.Stop()
        Else
            Timer1.Stop()
        End If

    End Sub
End Class