Imports CrystalDecisions.CrystalReports.Engine
Public Class Form1

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim rptClear As New rptClearance
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

        firstParagraph.Text = frmReport.TextBox1.Text + " years of age, was bonafide, resident of Barangay Pili, Pinamalayan, Oriental Mindoro" +
            " is personally known to me of good moral character and law abiding citizen in the community."
        secondParagraph.Text = "This certifies further that he/she has no derogatory records file on this office."
        thirdParagraph.Text = "This certification is issued upon request of the above-named person" +
            " for " + "WHATEVER LEGAL PURPOSES MAY IT SERVE."
        fourthParagraph.Text = "Given this " + "at Barangay Pili, Pinamalayan, Oriental Mindoro."
        name2.Text = frmReport.NameTextBox.Text.ToUpper
        controlNum.Text = Me.TextBox1.Text
        'secondParagraph.Text = "Issued this " + DateTimePicker1.Value.Date +
        '  " upon the request of Ms. Ledha Jane L. Delos Santos for whatever legal purpose may it serve."

        frmReport.CrystalReportViewer1.ReportSource = rptClear

    End Sub
End Class