Imports CrystalDecisions.CrystalReports.Engine

Public Class frmReport

    Private Sub Guna2Button2_Click(sender As Object, e As EventArgs)
        frmMain.Show()

        Me.Close()

    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        frmMain.btnBusinessTrade.Visible = False
        frmMain.btnClearance.Visible = False
        frmMain.btnResidency.Visible = False
        frmMain.btnIndigency.Visible = False

        frmMain.btnOut.Visible = True
        frmMain.btnSettings.Visible = True
        frmMain.btnHistory.Visible = True
            frmMain.btnBlotterReport.Visible = True
            frmMain.btnResidents.Visible = True
            frmMain.btnHome.Visible = True
            frmMain.btnAbout.Visible = True
            With frmResidents
                .TopLevel = False
                frmMain.pnlCenter.Controls.Add(frmResidents)
                .BringToFront()
                .Show()

                Me.Close()
            End With
    End Sub

    Private Sub frmReport_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DbBrgySystemDataSet.tblPrintIndigency' table. You can move, or remove it, as needed.
        Me.TblPrintIndigencyTableAdapter.Fill(Me.DbBrgySystemDataSet.tblPrintIndigency)
        'TODO: This line of code loads data into the 'DbBrgySystemDataSet.tblResidents' table. You can move, or remove it, as needed.
        Me.TblResidentsTableAdapter.Fill(Me.DbBrgySystemDataSet.tblResidents)

    End Sub

    Private Sub TblResidentsBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.TblResidentsBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DbBrgySystemDataSet)

    End Sub

    Private Sub TblResidentsBindingNavigatorSaveItem_Click_1(sender As Object, e As EventArgs)
        Me.Validate()
        Me.TblResidentsBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DbBrgySystemDataSet)

    End Sub

    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles Guna2Button1.Click

        CrystalReportViewer1.PrintReport()
        If MsgBox("Do you want to add that document to the printed documents?",
                      MsgBoxStyle.YesNo, "Add as 'PRINTED'") =
                      MsgBoxResult.Yes Then
            Dim addPrint As String = Me.FirstParagraphTextBox.Text + 1
            Try

                TblPrintIndigencyTableAdapter.updatePrinted(addPrint)
                TblPrintIndigencyTableAdapter.Fill(DbBrgySystemDataSet.tblPrintIndigency)
                MsgBox("Total Documents Printed: " + FirstParagraphTextBox.Text)
            Catch

            End Try
                End If
    End Sub




    Public Sub CrystalReportViewer1_Load(sender As Object, e As EventArgs) Handles CrystalReportViewer1.Load
      
    End Sub

    Private Sub NameTextBox_TextChanged(sender As Object, e As EventArgs) Handles NameTextBox.TextChanged
        CrystalReportViewer1_Load(sender, e)
    End Sub



    Private Sub lblCurrentFrm_TextChanged(sender As Object, e As EventArgs) Handles lblCurrentFrm.TextChanged
        If lblCurrentFrm.Text = "Please Select A Document" Then
            Guna2Button1.Enabled = False
        Else
            Guna2Button1.Enabled = True
        End If
    End Sub
End Class