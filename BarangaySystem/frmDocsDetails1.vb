Imports CrystalDecisions.CrystalReports.Engine

Public Class frmDocsDetails1



    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If frmReport.lblCurrentFrm.Text = "Request Certificate of Indigency" Then

            Dim rptIn As New rptIndigency
            Dim toWhom As TextObject
            Dim firstParagraph As TextObject
            Dim secondParagraph As TextObject
            Dim printDate As FieldObject



            toWhom = rptIn.ReportDefinition.ReportObjects("txtToWhom")
            firstParagraph = rptIn.ReportDefinition.ReportObjects("txtFirstParagraph")
            secondParagraph = rptIn.ReportDefinition.ReportObjects("txtSecondParagraph")
            ' display the value for the report
            toWhom.Text = "TO WHOM IT MAY CONCERN:"
            firstParagraph.Text = "This is to certify that based on the records filed with this office" +
                " that" + " " + frmReport.NameTextBox.Text + ", " + frmReport.TextBox1.Text + " years old, " +
                " resident of Barangay Pili, Pinamalayan, Oriental Mindoro " +
                "had no taxable property, no permanent job, and for whatever legal purposes it may serve."

            secondParagraph.Text = "This certification is issued this " + Me.TextBox1.Text +
               " upon the request of " + frmReport.TextBox2.Text + " " + frmReport.NameTextBox.Text + " for whatever legal purpose may it serve."

            frmReport.CrystalReportViewer1.ReportSource = rptIn

        ElseIf frmReport.lblCurrentFrm.Text = "Request Certificate of Residency" Then
            Dim rptRes As New rptResidency
            Dim toWhom As TextObject
            Dim firstParagraph As TextObject
            Dim secondParagraph As TextObject

            toWhom = rptRes.ReportDefinition.ReportObjects("txtToWhom")
            firstParagraph = rptRes.ReportDefinition.ReportObjects("txtFirstParagraph")
            secondParagraph = rptRes.ReportDefinition.ReportObjects("txtSecondParagraph")
            ' display the value for the report
            toWhom.Text = "TO WHOM IT MAY CONCERN:"
            firstParagraph.Text = "This is to certify that based on the records filed with this office" +
                " that" + " " + frmReport.NameTextBox.Text.ToUpper + ", " + frmReport.TextBox1.Text + " years of age, Filipino is an actual resident of Barangay Pili, Pinamalayan, Oriental Mindoro since birth."

            secondParagraph.Text = "Issued this " + Me.TextBox1.Text +
               " upon the request of " + frmReport.TextBox2.Text + frmReport.NameTextBox.Text.ToUpper + " for whatever legal purpose may it serve."

            frmReport.CrystalReportViewer1.ReportSource = rptRes


        End If
        Me.Hide()
        

    End Sub

   
End Class