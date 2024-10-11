Imports CrystalDecisions.CrystalReports.Engine
Public Class frmMain

    Dim menuShrink As Boolean = False

    Private Sub frmMain_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed


        If kill = False Then

        Else
            Application.Exit()
            frmDBSett.Close()
        End If
    End Sub

    Private Sub frmMain_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing

        If MsgBox("Do you want to backup database before you close the application? ",
            MsgBoxStyle.YesNo, "Exiting Application") =
            MsgBoxResult.Yes Then
            frmDBSett.Show()
            frmDBSett.Opacity = 0%
            frmDBSett.Timer1.Start()
            frmDBSett.btnBackupNow.PerformClick()
            frmDBSett.Close()
            If kill = False Then

            Else

            End If
        Else

        End If

    End Sub


    Public Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DbBrgySystemDataSet.tblUserAccounts' table. You can move, or remove it, as needed.

        btnHome_Click(sender, e)

        'CHECK THE USERTYPE FOR RESTRICTIONS
        If TextBox4.Text = "Administrator" Then
            btnAddUser.Visible = True
            btnHistory.Visible = True
        ElseIf TextBox4.Text = "User" Then
            btnAddUser.Visible = False
            btnHistory.Visible = False
        End If

    End Sub

    Private Sub frmMain_resize(sender As Object, e As EventArgs) Handles Me.ResizeBegin
        If Me.Width < 1040 Then
            pnlMenu.Width = 60
            btnHome.BorderRadius = 0
            btnResidents.BorderRadius = 0
            btnBlotterReport.BorderRadius = 0
            btnSettings.BorderRadius = 0

            btnOut.BorderRadius = 0
            picBrgyLogo.Width = 45
            picBrgyLogo.Height = 45
        Else
            pnlMenu.Width = 235
            btnHome.BorderRadius = 20
            btnResidents.BorderRadius = 20
            btnBlotterReport.BorderRadius = 20
            btnSettings.BorderRadius = 20

            btnOut.BorderRadius = 20
            picBrgyLogo.Width = 235
            picBrgyLogo.Height = 171
        End If

    End Sub


    Private Sub btnHome_Click(sender As Object, e As EventArgs) Handles btnHome.Click
        btnHome.FillColor = Color.Khaki
        btnAbout.FillColor = Color.WhiteSmoke
        btnResidents.FillColor = Color.WhiteSmoke
        btnBlotterReport.FillColor = Color.WhiteSmoke
        btnHistory.FillColor = Color.WhiteSmoke
        btnSettings.FillColor = Color.WhiteSmoke
        btnOut.FillColor = Color.WhiteSmoke

        With frmHome
            .TopLevel = False
            pnlCenter.Controls.Add(frmHome)
            .BringToFront()
            .Show()

            frmOrganization.Hide()
            frmResidents.Hide()
            frmBltrRpt.Hide()
            'frmHistory.Hide()
            frmSettings.Hide()
        End With


    End Sub

    Private Sub btnResidents_Click(sender As Object, e As EventArgs) Handles btnResidents.Click

        btnHome.FillColor = Color.WhiteSmoke
        btnAbout.FillColor = Color.WhiteSmoke
        btnResidents.FillColor = Color.Khaki
        btnBlotterReport.FillColor = Color.WhiteSmoke
        btnHistory.FillColor = Color.WhiteSmoke
        btnSettings.FillColor = Color.WhiteSmoke
        btnOut.FillColor = Color.WhiteSmoke

        frmHome.Close()

        With frmResidents
            .TopLevel = False
            pnlCenter.Controls.Add(frmResidents)
            .BringToFront()
            .Show()

            frmHome.Hide()
            frmOrganization.Hide()
            frmBltrRpt.Hide()
            'frmHistory.Hide()
            frmSettings.Hide()
        End With
    End Sub

    Private Sub btnBlotterReport_Click(sender As Object, e As EventArgs) Handles btnBlotterReport.Click

        frmBltrRpt.Show()
        Me.ShowInTaskbar = False
        Me.Opacity = 0%
    End Sub

    Private Sub btnSettings_Click(sender As Object, e As EventArgs) Handles btnSettings.Click
        frmSettings.Show()
        Me.ShowInTaskbar = True
        Me.Opacity = 0%

    End Sub




    Private Sub btnBack_Click(sender As Object, e As EventArgs)
        btnBusinessTrade.Visible = False
        btnClearance.Visible = False
        btnResidency.Visible = False
        btnIndigency.Visible = False

        btnOut.Visible = True

        btnSettings.Visible = True
        btnBlotterReport.Visible = True
        btnResidents.Visible = True
        btnHome.Visible = True
    End Sub

    Public Sub btnIndigency_Click(sender As Object, e As EventArgs) Handles btnIndigency.Click
        btnIndigency.FillColor = Color.Khaki
        btnResidency.FillColor = Color.WhiteSmoke
        btnClearance.FillColor = Color.WhiteSmoke
        btnBusinessTrade.FillColor = Color.WhiteSmoke

        With frmReport
            .TopLevel = False
            pnlCenter.Controls.Add(frmReport)
            .BringToFront()
            .Show()
        End With

        frmReport.lblCurrentFrm.Text = "Request Certificate of Indigency"
        frmReport.CrystalReportViewer1_Load(sender, e)
        Dim rptIn As New rptIndigency
        Dim toWhom As TextObject
        Dim firstParagraph As TextObject
        Dim secondParagraph As TextObject
        Dim printDate As FieldObject

        Dim getMonth As String = Me.Label4.Text
        Dim getDay As String = Me.Label5.Text
        Dim getYear As String = Me.Label6.Text
        Dim allDate As String
        Select Case getMonth
            Case "1" Or "01"
                getMonth = "January"
            Case "2" Or "02"
                getMonth = "February"
            Case "3" Or "03"
                getMonth = "March"
            Case "4" Or "04"
                getMonth = "April"
            Case "5" Or "05"
                getMonth = "May"
            Case "6" Or "06"
                getMonth = "June"
            Case "7" Or "07"
                getMonth = "July"
            Case "8" Or "08"
                getMonth = "August"
            Case "9" Or "09"
                getMonth = "September"
            Case "10"
                getMonth = "October"
            Case "11"
                getMonth = "November"
            Case "12"
                getMonth = "December"
        End Select

        Select Case getDay
            Case "1" Or "01"
                getDay = "1st"
            Case "2" Or "02"
                getDay = "2nd"
            Case "3" Or "03"
                getDay = "3rd"
            Case "4" Or "04"
                getDay = "4th"
            Case "5" Or "05"
                getDay = "5th"
            Case "6" Or "06"
                getDay = "6th"
            Case "7" Or "07"
                getDay = "7th"
            Case "8" Or "08"
                getDay = "8th"
            Case "9" Or "09"
                getDay = "9th"
            Case "10"
                getDay = "10th"
            Case "11"
                getDay = "11th"
            Case "12"
                getDay = "12th"
            Case "13"
                getDay = "13th"
            Case "14"
                getDay = "14th"
            Case "15"
                getDay = "15th"
            Case "16"
                getDay = "16th"
            Case "17"
                getDay = "17th"
            Case "18"
                getDay = "18th"
            Case "19"
                getDay = "19th"
            Case "20"
                getDay = "12th"
            Case "12"
                getDay = "20th"
            Case "21"
                getDay = "21st"
            Case "22"
                getDay = "22nd"
            Case "23"
                getDay = "23rd"
            Case "24"
                getDay = "24th"
            Case "25"
                getDay = "25th"
            Case "26"
                getDay = "26th"
            Case "27"
                getDay = "27th"
            Case "28"
                getDay = "28th"
            Case "29"
                getDay = "29th"
            Case "30"
                getDay = "30th"
            Case "31"
                getDay = "31st"
        End Select

        allDate = getDay + " of " + getMonth + " " + getYear


        toWhom = rptIn.ReportDefinition.ReportObjects("txtToWhom")
        firstParagraph = rptIn.ReportDefinition.ReportObjects("txtFirstParagraph")
        secondParagraph = rptIn.ReportDefinition.ReportObjects("txtSecondParagraph")
        ' display the value for the report
        toWhom.Text = "TO WHOM IT MAY CONCERN:"
        firstParagraph.Text = "This is to certify that based on the records filed with this office" +
            " that" + " " + frmReport.NameTextBox.Text + ", " + frmReport.TextBox1.Text + " years old, " +
            " resident of Barangay Pili, Pinamalayan, Oriental Mindoro " +
            "had no taxable property, no permanent job, and for whatever legal purposes it may serve."

        secondParagraph.Text = "This certification is issued this " + allDate +
           " upon the request of " + frmReport.TextBox2.Text + " " + frmReport.NameTextBox.Text + " for whatever legal purpose may it serve."

        frmReport.CrystalReportViewer1.ReportSource = rptIn
        openClearance = False


    End Sub

    Private Sub btnResidency_Click(sender As Object, e As EventArgs) Handles btnResidency.Click
        btnIndigency.FillColor = Color.WhiteSmoke
        btnResidency.FillColor = Color.Khaki
        btnClearance.FillColor = Color.WhiteSmoke
        btnBusinessTrade.FillColor = Color.WhiteSmoke

        With frmReport
            .TopLevel = False
            pnlCenter.Controls.Add(frmReport)
            .BringToFront()
            .Show()
        End With

        frmReport.lblCurrentFrm.Text = "Request Certificate of Residency"
        frmReport.CrystalReportViewer1_Load(sender, e)
        Dim rptRes As New rptResidency
        Dim toWhom As TextObject
        Dim firstParagraph As TextObject
        Dim secondParagraph As TextObject

        Dim getMonth As String = Me.Label4.Text
        Dim getDay As String = Me.Label5.Text
        Dim getYear As String = Me.Label6.Text
        Dim allDate As String
        Select Case getMonth
            Case "1" Or "01"
                getMonth = "January"
            Case "2" Or "02"
                getMonth = "February"
            Case "3" Or "03"
                getMonth = "March"
            Case "4" Or "04"
                getMonth = "April"
            Case "5" Or "05"
                getMonth = "May"
            Case "6" Or "06"
                getMonth = "June"
            Case "7" Or "07"
                getMonth = "July"
            Case "8" Or "08"
                getMonth = "August"
            Case "9" Or "09"
                getMonth = "September"
            Case "10"
                getMonth = "October"
            Case "11"
                getMonth = "November"
            Case "12"
                getMonth = "December"
        End Select

        Select Case getDay
            Case "1" Or "01"
                getDay = "1st"
            Case "2" Or "02"
                getDay = "2nd"
            Case "3" Or "03"
                getDay = "3rd"
            Case "4" Or "04"
                getDay = "4th"
            Case "5" Or "05"
                getDay = "5th"
            Case "6" Or "06"
                getDay = "6th"
            Case "7" Or "07"
                getDay = "7th"
            Case "8" Or "08"
                getDay = "8th"
            Case "9" Or "09"
                getDay = "9th"
            Case "10"
                getDay = "10th"
            Case "11"
                getDay = "11th"
            Case "12"
                getDay = "12th"
            Case "13"
                getDay = "13th"
            Case "14"
                getDay = "14th"
            Case "15"
                getDay = "15th"
            Case "16"
                getDay = "16th"
            Case "17"
                getDay = "17th"
            Case "18"
                getDay = "18th"
            Case "19"
                getDay = "19th"
            Case "20"
                getDay = "12th"
            Case "12"
                getDay = "20th"
            Case "21"
                getDay = "21st"
            Case "22"
                getDay = "22nd"
            Case "23"
                getDay = "23rd"
            Case "24"
                getDay = "24th"
            Case "25"
                getDay = "25th"
            Case "26"
                getDay = "26th"
            Case "27"
                getDay = "27th"
            Case "28"
                getDay = "28th"
            Case "29"
                getDay = "29th"
            Case "30"
                getDay = "30th"
            Case "31"
                getDay = "31st"
        End Select

        allDate = getDay + " of " + getMonth + " " + getYear
        toWhom = rptRes.ReportDefinition.ReportObjects("txtToWhom")
        firstParagraph = rptRes.ReportDefinition.ReportObjects("txtFirstParagraph")
        secondParagraph = rptRes.ReportDefinition.ReportObjects("txtSecondParagraph")
        ' display the value for the report
        toWhom.Text = "TO WHOM IT MAY CONCERN:"
        firstParagraph.Text = "This is to certify that based on the records filed with this office" +
            " that" + " " + frmReport.NameTextBox.Text.ToUpper + ", " + frmReport.TextBox1.Text + " years of age, Filipino is an actual resident of Barangay Pili, Pinamalayan, Oriental Mindoro since birth."

        secondParagraph.Text = "Issued this " + allDate +
           " upon the request of " + frmReport.TextBox2.Text + frmReport.NameTextBox.Text.ToUpper + " for whatever legal purpose may it serve."

        frmReport.CrystalReportViewer1.ReportSource = rptRes
        openClearance = False


    End Sub

    Public openClearance As Boolean = False
    Private Sub btnClearance_Click(sender As Object, e As EventArgs) Handles btnClearance.Click
        btnIndigency.FillColor = Color.WhiteSmoke
        btnResidency.FillColor = Color.WhiteSmoke
        btnClearance.FillColor = Color.Khaki
        btnBusinessTrade.FillColor = Color.WhiteSmoke

        With frmReport
            .TopLevel = False
            pnlCenter.Controls.Add(frmReport)
            .BringToFront()
            .Show()

        End With

        frmReport.lblCurrentFrm.Text = "Request Barangay Clearance"
        Dim rptClear As New rptClearance
        If MsgBox("Are you sure you want to release a Barangay Clearance? Click 'YES' to proceed.",
                       MsgBoxStyle.YesNo, "Control Number Notice!") =
                       MsgBoxResult.Yes Then
            Dim addClearance As String = frmReport.ToTextBox.Text + 1
            Try
                
                frmReport.TblPrintIndigencyTableAdapter.updateControlNum(addClearance)
                frmReport.TblPrintIndigencyTableAdapter.Fill(DbBrgySystemDataSet.tblPrintIndigency)
                MsgBox("Clearance added! Control Number: " + Label6.Text + "-" + frmReport.ToTextBox.Text)


                Dim toWhom As TextObject
                Dim firstParagraph As TextObject
                Dim secondParagraph As TextObject
                Dim thirdParagraph As TextObject
                Dim fourthParagraph As TextObject
                Dim name1 As TextObject
                Dim name2 As TextObject
                Dim controlNum As TextObject

                'toWhom = rptRes.ReportDefinition.ReportObjects("txtToWhom")
                firstParagraph = rptClear.ReportDefinition.ReportObjects("txtFirstParagraph")
                secondParagraph = rptClear.ReportDefinition.ReportObjects("txtSecondParagraph")
                thirdParagraph = rptClear.ReportDefinition.ReportObjects("txtThirdPar")
                fourthParagraph = rptClear.ReportDefinition.ReportObjects("txtFourthPar")
                name1 = rptClear.ReportDefinition.ReportObjects("txtName")
                name2 = rptClear.ReportDefinition.ReportObjects("txtName2")
                controlNum = rptClear.ReportDefinition.ReportObjects("txtControl")
                ' display the value for the report
                ' toWhom.Text = "TO WHOM IT MAY CONCERN:"

                name1.Text = frmReport.NameTextBox.Text.ToUpper

                firstParagraph.Text = Me.TextBox1.Text + " years of age, was bonafide, resident of Barangay Pili, Pinamalayan, Oriental Mindoro" +
                    " is personally known to me of good moral character and law abiding citizen in the community."
                secondParagraph.Text = "This certifies further that he/she has no derogatory records file on this office."
                thirdParagraph.Text = "This certification is issued upon request of the above-named person" +
                    " for " + "WHATEVER LEGAL PURPOSES MAY IT SERVE."
                fourthParagraph.Text = "Given this " + "at Barangay Pili, Pinamalayan, Oriental Mindoro."
                name2.Text = frmReport.NameTextBox.Text.ToUpper
                controlNum.Text = Me.Label6.Text + "-" + frmReport.ToTextBox.Text
                'secondParagraph.Text = "Issued this " + DateTimePicker1.Value.Date +
                '  " upon the request of Ms. Ledha Jane L. Delos Santos for whatever legal purpose may it serve."

                frmReport.CrystalReportViewer1.ReportSource = rptClear


            Catch ex As Exception
                MsgBox("There was an error")
            End Try


        End If

        'rptIn.SetDataSource(DbBrgySystemDataSet.Tables("tblResidents"))
        frmReport.CrystalReportViewer1.Zoom(100)

    End Sub

    Private Sub btnBusinessTrade_Click(sender As Object, e As EventArgs) Handles btnBusinessTrade.Click
        btnIndigency.FillColor = Color.WhiteSmoke
        btnResidency.FillColor = Color.WhiteSmoke
        btnClearance.FillColor = Color.WhiteSmoke
        btnBusinessTrade.FillColor = Color.Khaki

        With frmReport
            .TopLevel = False
            pnlCenter.Controls.Add(frmReport)
            .BringToFront()
            .Show()
        End With

        frmReport.lblCurrentFrm.Text = "Certificate of Community Service"
        frmReport.CrystalReportViewer1_Load(sender, e)
        Dim rptServ As New rptService
        Dim toWhom As TextObject
        Dim firstParagraph As TextObject
        Dim secondParagraph As TextObject
        Dim Text1 As TextObject

        Dim getMonth As String = Me.Label4.Text
        Dim getDay As String = Me.Label5.Text
        Dim getYear As String = Me.Label6.Text
        Dim allDate As String
        Select Case getMonth
            Case "1" Or "01"
                getMonth = "January"
            Case "2" Or "02"
                getMonth = "February"
            Case "3" Or "03"
                getMonth = "March"
            Case "4" Or "04"
                getMonth = "April"
            Case "5" Or "05"
                getMonth = "May"
            Case "6" Or "06"
                getMonth = "June"
            Case "7" Or "07"
                getMonth = "July"
            Case "8" Or "08"
                getMonth = "August"
            Case "9" Or "09"
                getMonth = "September"
            Case "10"
                getMonth = "October"
            Case "11"
                getMonth = "November"
            Case "12"
                getMonth = "December"
        End Select

        Select Case getDay
            Case "1" Or "01"
                getDay = "1st"
            Case "2" Or "02"
                getDay = "2nd"
            Case "3" Or "03"
                getDay = "3rd"
            Case "4" Or "04"
                getDay = "4th"
            Case "5" Or "05"
                getDay = "5th"
            Case "6" Or "06"
                getDay = "6th"
            Case "7" Or "07"
                getDay = "7th"
            Case "8" Or "08"
                getDay = "8th"
            Case "9" Or "09"
                getDay = "9th"
            Case "10"
                getDay = "10th"
            Case "11"
                getDay = "11th"
            Case "12"
                getDay = "12th"
            Case "13"
                getDay = "13th"
            Case "14"
                getDay = "14th"
            Case "15"
                getDay = "15th"
            Case "16"
                getDay = "16th"
            Case "17"
                getDay = "17th"
            Case "18"
                getDay = "18th"
            Case "19"
                getDay = "19th"
            Case "20"
                getDay = "12th"
            Case "12"
                getDay = "20th"
            Case "21"
                getDay = "21st"
            Case "22"
                getDay = "22nd"
            Case "23"
                getDay = "23rd"
            Case "24"
                getDay = "24th"
            Case "25"
                getDay = "25th"
            Case "26"
                getDay = "26th"
            Case "27"
                getDay = "27th"
            Case "28"
                getDay = "28th"
            Case "29"
                getDay = "29th"
            Case "30"
                getDay = "30th"
            Case "31"
                getDay = "31st"
        End Select

        allDate = getDay + " of " + getMonth + " " + getYear
        toWhom = rptServ.ReportDefinition.ReportObjects("txtToWhom")
        firstParagraph = rptServ.ReportDefinition.ReportObjects("txtFirstParagraph")
        secondParagraph = rptServ.ReportDefinition.ReportObjects("txtSecondParagraph")
        Text1 = rptServ.ReportDefinition.ReportObjects("Text1")
        ' display the value for the report
        toWhom.Text = "TO WHOM IT MAY CONCERN:"
        firstParagraph.Text = "This is to certify that " & frmReport.NameTextBox.Text.ToUpper + ", " & frmReport.TextBox1.Text & " years of age, Filipino, is an actual resident of Barangay Pili, Pinamalayan, Oriental Mindoro since birth."


        secondParagraph.Text = "This is hereby certify that he/she has rendered 52 hours of Community Service at Barangay Pili, Pinamalayan, Oriental Mindoro."
        Text1.Text = "Issued this " & allDate &
           ", upon the request of " & frmReport.TextBox2.Text & frmReport.NameTextBox.Text.ToUpper & " for whatever legal purpose may it serve."

        frmReport.CrystalReportViewer1.ReportSource = rptServ

    End Sub


    Private Sub btnHistory_Click(sender As Object, e As EventArgs) Handles btnHistory.Click
        btnHome.FillColor = Color.WhiteSmoke
        btnAbout.FillColor = Color.WhiteSmoke
        btnResidents.FillColor = Color.WhiteSmoke
        btnBlotterReport.FillColor = Color.WhiteSmoke
        btnHistory.FillColor = Color.Khaki
        btnSettings.FillColor = Color.WhiteSmoke
        btnOut.FillColor = Color.WhiteSmoke
        frmHistory.Timer1.Start()
        With frmHistory
            .TopLevel = False
            pnlCenter.Controls.Add(frmHistory)
            .BringToFront()
            .Show()

            frmHome.Hide()
            frmOrganization.Hide()
            frmResidents.Hide()
            frmBltrRpt.Hide()
            frmSettings.Hide()

            frmHistory.Timer1.Start()
        End With
    End Sub


    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        frmHome.Button1.PerformClick()
        frmHome.Button2.PerformClick()
        btnUser.Text = TextBox1.Text

        Dim user As String = TextBox1.Text
        Me.TblUserAccountsTableAdapter.searchByUser(Me.DbBrgySystemDataSet.tblUserAccounts, user)
    End Sub

    Dim clickUser As Boolean = False
    Private Sub btnUser_Click(sender As Object, e As EventArgs) Handles btnUser.Click

        'CHECK USERTYPE FOR RESTRICTIONS
        If TextBox4.Text = "User" Then
            If clickUser = False Then
                Panel2.Visible = True
                btnAddUser.Visible = False
                Panel2.Height = Panel2.Height - 30
                clickUser = True
                btnUser.Image = My.Resources.icon_less
            Else
                Panel2.Visible = False
                Panel2.Height = Panel2.Height + 30
                clickUser = False
                btnUser.Image = My.Resources.icon_more
            End If

        ElseIf TextBox4.Text = "Administrator" Then
            If clickUser = False Then
                Panel2.Visible = True
                clickUser = True
                btnUser.Image = My.Resources.icon_less
            Else
                Panel2.Visible = False
                clickUser = False
                btnUser.Image = My.Resources.icon_more
            End If
        End If



    End Sub


    Private Sub btnAbout_Click(sender As Object, e As EventArgs) Handles btnAbout.Click
        btnHome.FillColor = Color.WhiteSmoke
        btnResidents.FillColor = Color.WhiteSmoke
        btnBlotterReport.FillColor = Color.WhiteSmoke
        btnHistory.FillColor = Color.WhiteSmoke
        btnAbout.FillColor = Color.Khaki
        btnSettings.FillColor = Color.WhiteSmoke
        btnOut.FillColor = Color.WhiteSmoke
        frmHistory.Timer1.Start()
        With frmAbout
            .TopLevel = False
            pnlCenter.Controls.Add(frmAbout)
            .BringToFront()
            .Show()

            frmHome.Hide()
            frmOrganization.Hide()
            frmResidents.Hide()
            frmBltrRpt.Hide()
            frmSettings.Hide()
        End With
    End Sub

    Private Sub TextBox4_TextChanged(sender As Object, e As EventArgs) Handles TextBox4.TextChanged
        If TextBox4.Text = "User" Then
            'btnHistory.Visible = False
        End If
    End Sub

    Private Sub btnAddUser_Click(sender As Object, e As EventArgs) Handles btnAddUser.Click

        frmUsers.Guna2Button7.PerformClick()

    End Sub

    Public kill As Boolean = True
    Private Sub btnOut_Click(sender As Object, e As EventArgs) Handles btnOut.Click
        If MsgBox("Are you sure you want to logout? You will be redirected to login again!",
                MsgBoxStyle.YesNo, "Residents Record") =
                MsgBoxResult.Yes Then
            frmLogin.Show()
            frmLogin.user1.Focus()
            frmLogin.TblUserAccountsTableAdapter.Fill(Me.DbBrgySystemDataSet.tblUserAccounts)
            frmLogin.user1.Focus()
            frmLogin.user1.ResetText()
            frmLogin.pass1.ResetText()
            kill = False
            Me.Hide()
            Me.Close()
        End If
    End Sub


    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Label4.Text = Date.Now.Month
        Label5.Text = Date.Now.Day
        Label6.Text = Date.Now.Year
        Label1.Text = Date.Now.Hour
        Label2.Text = Date.Now.Minute
        Label3.Text = Date.Now.Second
        Label4.Text = Date.Now.Month
    End Sub
End Class
