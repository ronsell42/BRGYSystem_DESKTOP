Public Class frmHome

    Private Sub TblHistoryBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.TblHistoryBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DbBrgySystemDataSet)

    End Sub


    Private Sub TblHistoryBindingNavigatorSaveItem_Click_1(sender As Object, e As EventArgs)
        Me.Validate()
        Me.TblHistoryBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DbBrgySystemDataSet)

    End Sub

    Private Sub frmHome_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DbBrgySystemDataSet.tblPrintIndigency' table. You can move, or remove it, as needed.
        Me.TblPrintIndigencyTableAdapter.Fill(Me.DbBrgySystemDataSet.tblPrintIndigency)
        'TODO: This line of code loads data into the 'DbBrgySystemDataSet.tblResidents' table. You can move, or remove it, as needed.
        Me.TblResidentsTableAdapter.Fill(Me.DbBrgySystemDataSet.tblResidents)
        'TODO: This line of code loads data into the 'DbBrgySystemDataSet.tblHistory' table. You can move, or remove it, as needed.
        Me.TblHistoryTableAdapter.Fill(Me.DbBrgySystemDataSet.tblHistory)

        Dim centro As Decimal = Me.TblResidentsTableAdapter.countCentro()
        Dim dalamEast As Double = Me.TblResidentsTableAdapter.countDalamEast()
        Dim dalamWest As Double = Me.TblResidentsTableAdapter.countDalamWest()
        Dim hagnayahan As Double = Me.TblResidentsTableAdapter.countHagnayahan()
        Dim lowerB As Double = Me.TblResidentsTableAdapter.countLowBongol()
        Dim upperB As Double = Me.TblResidentsTableAdapter.countUpBongol()
        Dim piliEast As Double = Me.TblResidentsTableAdapter.countPiliEast()

        Button9.Text = Me.TblResidentsTableAdapter.countMale()
        Button7.Text = Me.TblResidentsTableAdapter.countFemale()

        lblTotalRes.Text = Me.TblResidentsTableAdapter.totalResidents()

        

        Me.Chart1.Series(0).Points.AddXY("Centro = " & centro, centro)
        Me.Chart1.Series(0).Points.AddXY("Dalampasigan East = " & dalamEast, dalamEast)
        Me.Chart1.Series(0).Points.AddXY("Dalampasigan West = " & dalamWest, dalamWest)
        Me.Chart1.Series(0).Points.AddXY("Hagnayahan = " & hagnayahan, hagnayahan)
        Me.Chart1.Series(0).Points.AddXY("Lower Bongol = " & lowerB, lowerB)
        Me.Chart1.Series(0).Points.AddXY("Upper Bongol = " & upperB, upperB)
        Me.Chart1.Series(0).Points.AddXY("Pili East = " & piliEast, piliEast)

      
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        TblHistoryBindingSource.AddNew()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        EventDateDateTimePicker.Value = Date.Now
        WhoWasItTextBox.Text = frmMain.TextBox1.Text
        ActionTakenTextBox.Text = "Login to database"
        ByWhoTextBox.Text = frmMain.TextBox1.Text
        Me.Validate()
        Me.TblHistoryBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DbBrgySystemDataSet)
    End Sub

    Private Sub FirstParagraphTextBox_TextChanged(sender As Object, e As EventArgs) Handles FirstParagraphTextBox.TextChanged
        Button5.Text = FirstParagraphTextBox.Text
    End Sub
End Class