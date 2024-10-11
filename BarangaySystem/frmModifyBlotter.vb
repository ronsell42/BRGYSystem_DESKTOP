Imports System.IO
Public Class frmModifyBlotter
    Private Sub frmModifyBlotter_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        BunifuDatepicker1.Value = Date.Now
        If frmBltrRpt.Label1.Text = "Add" Then
            Label10.Text = "Add"
            TblBlotterBindingSource.AddNew()
            Timer1.Start()
            'IDTextBox.Text = frmMain.Label4.Text + frmMain.Label5.Text + frmMain.Label6.Text +
            'frmMain.Label1.Text(+frmMain.Label2.Text + frmMain.Label3.Text)

            Guna2Button2.Enabled = True
            Rpt.Enabled = True
            Panel1.Enabled = True
            RptIssue.Focus()
        Else
            Label10.Text = "Edit"



            Label9.Text = ReportDateDateTimePicker.Value
            Dim blotterSearch As Integer = frmBltrRpt.IDTextBox.Text
            Me.TblBlotterTableAdapter.searchByID(Me.DbBrgySystemDataSet.tblBlotter, blotterSearch)
            TextBox1.Text = ReportAttachedTextBox.Text
            Timer1.Stop()

            Guna2Button2.Enabled = False
            Rpt.Enabled = False
            Panel1.Enabled = False
            RptIssue.Focus()

        End If

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Me.Close()


    End Sub

    Private Sub TblBlotterBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.TblBlotterBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DbBrgySystemDataSet)

    End Sub


    Private Sub Label3_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub RptIssue_OnValueChanged(sender As Object, e As EventArgs) Handles RptIssue.OnValueChanged
        ReportIssueTextBox.Text = RptIssue.Text
    End Sub

    Private Sub rptLoc_OnValueChanged(sender As Object, e As EventArgs) Handles rptLoc.OnValueChanged
        LocationTextBox.Text = rptLoc.Text
    End Sub

    Private Sub complainant_OnValueChanged(sender As Object, e As EventArgs) Handles complainant.OnValueChanged
        ComplainantTextBox.Text = complainant.Text
    End Sub

    Private Sub Rpt_TextChanged(sender As Object, e As EventArgs) Handles Rpt.TextChanged
        ReportTextTextBox.Text = Rpt.Text
    End Sub

    Private Sub rptPhoto_Click(sender As Object, e As EventArgs) Handles rptPhoto.Click
        ReportAttachedPictureBox.Image = rptPhoto.Image
    End Sub

    Private Sub BunifuMetroTextbox1_OnValueChanged(sender As Object, e As EventArgs) Handles BunifuMetroTextbox1.OnValueChanged
        WhoTextBox.Text = BunifuMetroTextbox1.Text
    End Sub

    Private Sub Guna2Button2_Click(sender As Object, e As EventArgs) Handles Guna2Button2.Click
        Try

            If Label10.Text = "Edit" Then
                Dim UPDATERPTA As String = TextBox1.Text
                Dim seachID As String = IDTextBox.Text
                lblOrigAttachement.Text = ReportAttachedTextBox.Text
                'rptPhoto.Image.Save("C:\BRGYSys\blotterPictures\" & IDTextBox.Text & ".jpg")


                '------------

                Dim PICNAME As String = frmMain.Label4.Text + frmMain.Label5.Text + frmMain.Label6.Text +
               frmMain.Label1.Text + frmMain.Label2.Text + frmMain.Label3.Text
                'Dim identitity As Integer = IDTextBox.Text
                Try
                    Dim rptDate As String = Label9.Text
                    Dim reportIssue As String = RptIssue.Text
                    Dim incDate As String = BunifuDatepicker1.Value
                    Dim loc As String = rptLoc.Text
                    Dim beingRpt As String = BunifuMetroTextbox1.Text

                    Dim RPTtext As String = Rpt.Text
                    Dim reporting As String = complainant.Text
                    Dim OOD As String = frmMain.TextBox1.Text
                    File.Delete(ReportAttachedTextBox.Text)
                    File.Copy(TextBox1.Text, ReportAttachedTextBox.Text)
                    Me.TblBlotterTableAdapter.updateBltr(rptDate, reportIssue, incDate, loc, beingRpt, RPTtext, reporting, OOD, IDTextBox.Text)

            
                Catch ex As Exception
                    'MsgBox("Error here")
                End Try





                '----


                'Me.TblBlotterTableAdapter.updateAttachments(UPDATERPTA, seachID)
                MsgBox("Data Changed!", MsgBoxStyle.Information)
                'Button1.Text = "Saved"

                'Call the History Window
                With frmHistory
                    .TopLevel = False
                    frmMain.pnlCenter.Controls.Add(frmHistory)
                    .BringToFront()
                    .Show()
                    frmHistory.TblHistoryTableAdapter.Fill(frmHistory.DbBrgySystemDataSet.tblHistory)

                End With
                frmHistory.Button3.PerformClick()
                frmHistory.WhoWasItTextBox.Text = WhoTextBox.Text
                frmHistory.EventDateDateTimePicker.Value = Date.Now

                frmHistory.ActionTakenTextBox.Text = "Modify Blotter"


                frmHistory.Button4.PerformClick()

                frmBltrRpt.Opacity = 100%
                'Button1.Text = "Saved"
                Me.Close()


            Else

                Dim PICNAME As String = frmMain.Label4.Text + frmMain.Label5.Text + frmMain.Label6.Text +
               frmMain.Label1.Text + frmMain.Label2.Text + frmMain.Label3.Text
                'Dim identitity As Integer = IDTextBox.Text
                Dim rptDate As String = Label9.Text
                Dim reportIssue As String = RptIssue.Text
                Dim incDate As String = BunifuDatepicker1.Value
                Dim loc As String = rptLoc.Text
                Dim beingRpt As String = BunifuMetroTextbox1.Text
                Dim RPTA As String = "C:\BRGYSys\blotterPictures\" + PICNAME + ".jpg"
                Dim RPTtext As String = Rpt.Text
                Dim reporting As String = complainant.Text
                Dim OOD As String = frmMain.TextBox1.Text

                Me.TblBlotterTableAdapter.addBltr(rptDate, reportIssue, incDate, loc, beingRpt, RPTA, RPTtext, reporting, OOD)
                Try

                    File.Copy(TextBox1.Text, "C:\BRGYSys\blotterPictures\" & PICNAME & ".jpg")

                    'Me.Validate()
                    'Me.TblBlotterBindingSource.EndEdit()
                    'Me.TableAdapterManager.UpdateAll(Me.DbBrgySystemDataSet)

                    MsgBox("Data Saved!", MsgBoxStyle.Information)
                    Button1.Text = "Saved"

                    'Call the History Window
                    With frmHistory
                        .TopLevel = False
                        frmMain.pnlCenter.Controls.Add(frmHistory)
                        .BringToFront()
                        .Show()
                        frmHistory.TblHistoryTableAdapter.Fill(frmHistory.DbBrgySystemDataSet.tblHistory)

                    End With
                    frmHistory.Button3.PerformClick()
                    frmHistory.WhoWasItTextBox.Text = BunifuMetroTextbox1.Text
                    frmHistory.EventDateDateTimePicker.Value = Date.Now

                    frmHistory.ActionTakenTextBox.Text = "Add Blotter"


                    frmHistory.Button4.PerformClick()

                    frmBltrRpt.Opacity = 100%
                    Me.Close()
                    Button1.Text = "Saved"
                Catch ex As Exception
                    MsgBox("didn't save")
                End Try


            End If



        Catch ex As Exception
            MsgBox("Error Saving Please try to complete fields correctly", MsgBoxStyle.Exclamation)
        End Try
    End Sub

    Private Sub Guna2Button4_Click(sender As Object, e As EventArgs) Handles Guna2Button4.Click
        frmBltrRpt.Opacity = 100%
        frmBltrRpt.ReportAttachedTextBox_TextChanged(sender, e)
        Me.Close()
    End Sub

    Private Sub Button1_TextChanged(sender As Object, e As EventArgs) Handles Button1.TextChanged
        If Button1.Text = "Saved" Then
            frmBltrRpt.Button1.PerformClick()
            Me.Close()
        End If

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
   
        Dim open As OpenFileDialog = New OpenFileDialog()
        open.Filter = "jpg(*.jpg)|*.jpg|jpeg(*.jpeg)|*.jpeg|png(*.png)|*.png"
        open.Title = "Open File"
        open.FilterIndex = 1

        If open.ShowDialog = Windows.Forms.DialogResult.OK Then
            TextBox1.Text = open.FileName
            rptPhoto.Image = Image.FromFile(open.FileName)
        End If
    End Sub


    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Label9.Text = Date.Now
    End Sub

    Private Sub BunifuMetroTextbox2_OnValueChanged(sender As Object, e As EventArgs) Handles BunifuMetroTextbox2.OnValueChanged

    End Sub

    Private Sub IncidentDateDateTimePicker_ValueChanged(sender As Object, e As EventArgs) Handles IncidentDateDateTimePicker.ValueChanged
        BunifuMetroTextbox2.Text = IncidentDateDateTimePicker.Value
    End Sub


    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs)

    End Sub


    Private Sub ReportAttachedTextBox_TextChanged(sender As Object, e As EventArgs) Handles ReportAttachedTextBox.TextChanged
        If ReportAttachedTextBox.Text = "" Then
            rptPhoto.Image = Nothing
        Else
            Dim id As String = ReportAttachedTextBox.Text
            Dim folder As String = "C:\BRGYSys\blotterPictures"
            Dim fileName As String = System.IO.Path.Combine(folder, id)

            Try
                Using fs As New System.IO.FileStream(fileName, IO.FileMode.Open)
                    rptPhoto.Image = New Bitmap(Image.FromStream(fs))
                End Using
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If
    End Sub

 
    Private Sub Label10_TextChanged(sender As Object, e As EventArgs) Handles Label10.TextChanged
        If Label10.Text = "Edit" Then
            lblOrigAttachement.Text = ReportAttachedTextBox.Text
        Else

        End If
    End Sub
End Class