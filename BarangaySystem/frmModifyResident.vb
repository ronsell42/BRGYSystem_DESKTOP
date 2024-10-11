Imports Word = Microsoft.Office.Interop.Word

Public Class frmModifyResident
    Dim YLocation As Integer = (WorkingArea.Height - Me.Height) / 7 'Startup Location, Higher number = higher starting

    Private Sub tmrOpen_Tick(sender As Object, e As EventArgs) Handles tmrOpen.Tick
        If Me.Location.Y >= YLocation Then
            'Stop timer when popup form Y location reached to final location
            tmrOpen.Stop()
        Else
            'increase popup form Y location gradually
            Me.Location = New Point(Me.Location.X, Me.Location.Y + 10) 'Speed of Transition

        End If
        Button1.Text = "?"
    End Sub


    Private Sub Button1_TextChanged(sender As Object, e As EventArgs) Handles Button1.TextChanged
        If Button1.Text = "Saved" Then
            frmResidents.refreshBtn.PerformClick()
            Me.Close()
        End If

    End Sub

    Private Sub Guna2Button4_Click(sender As Object, e As EventArgs) Handles Guna2Button4.Click
        Me.Close()
    End Sub


    Private Sub frmModifyResident_Load(sender As Object, e As EventArgs) Handles MyBase.Load
     
        If frmResidents.Label1.Text = "Add" Then
            lblCurrentFrm.Text = "Add New Resident"
            Panel1.BackColor = Color.SeaGreen
            TblResidentsBindingSource.AddNew()
            BunifuMetroTextbox2.Text = ""
        Else
            lblCurrentFrm.Text = "Modify Resident"
            Panel1.BackColor = Color.DodgerBlue
            Dim residentSearch As Integer = frmResidents.IDTextBox.Text
            Me.TblResidentsTableAdapter.searchbyID(Me.DbBrgySystemDataSet.tblResidents, residentSearch)
            BunifuMetroTextbox2.Text = BDayDateTimePicker.Value

        End If
        fNameTxtBox.Focus()


    End Sub

    Private Sub Guna2Button2_Click(sender As Object, e As EventArgs) Handles Guna2Button2.Click
        'IF INCOMPLETE INFO
        If fNameTxtBox.Text = "" Or lNameTxtBox.Text = "" Or bPlaceTxtBox.Text = "" Or AgeBox.Text = "" Or
          SexTextBox.Text = "" Or CStatusTextBox.Text = "" Or CitizenshipTextBox.Text = "" Or
          PurokTextBox.Text = "" Then
            MessageBox.Show("Please complete all required fields!")


            'IF COMPLETE INFO
        Else
            Try
                FullNameTextBox.Text = LastNameTextBox.Text +
                    ", " + FirstNameTextBox.Text + " " + MInitialTextBox.Text
                Try
                    BDayDateTimePicker.Value = BunifuMetroTextbox2.Text
                    Me.Validate()
                    Me.TblResidentsBindingSource.EndEdit()
                    Me.TableAdapterManager.UpdateAll(Me.DbBrgySystemDataSet)


                    'Me.TblResidentsTableAdapter.Fill(Me.DbBrgySystemDataSet.tblResidents)
                    Button1.Text = "Saved"
                    MsgBox("Data Saved!", MsgBoxStyle.Information)

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
                    If frmResidents.Label1.Text = "Add" Then
                        frmHistory.ActionTakenTextBox.Text = "Add Resident"
                    ElseIf frmResidents.Label1.Text = "Edit" Then
                        frmHistory.ActionTakenTextBox.Text = "Modify Resident"
                    End If

                    frmHistory.Button4.PerformClick()

                    frmMain.btnResidents.PerformClick()
                Catch ex As Exception
                    MessageBox.Show("Wrong Birthday Format!")
                End Try

            Catch ex As Exception
                MsgBox("Error saving data.!", MsgBoxStyle.Exclamation)
            End Try
        End If
        

    End Sub

    Private Sub fNameTxtBox_OnValueChanged(sender As Object, e As EventArgs) Handles fNameTxtBox.OnValueChanged
        FirstNameTextBox.Text = fNameTxtBox.Text
    End Sub

    Private Sub miTxtBox_OnValueChanged(sender As Object, e As EventArgs) Handles miTxtBox.OnValueChanged
        MInitialTextBox.Text = miTxtBox.Text
    End Sub

    Private Sub lNameTxtBox_OnValueChanged(sender As Object, e As EventArgs) Handles lNameTxtBox.OnValueChanged
        LastNameTextBox.Text = lNameTxtBox.Text
    End Sub


    Private Sub bPlaceTxtBox_OnValueChanged(sender As Object, e As EventArgs) Handles bPlaceTxtBox.OnValueChanged
        BPlaceTextBox.Text = bPlaceTxtBox.Text
    End Sub

    Private Sub AgeBox_OnValueChanged(sender As Object, e As EventArgs) Handles AgeBox.OnValueChanged
        AgeTextBox.Text = AgeBox.Text
    End Sub

    Private Sub Guna2ComboBox3_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Guna2ComboBox3.SelectedIndexChanged
        If Guna2ComboBox3.SelectedIndex = 0 Then
            SexTextBox.Text = ""
        Else
            SexTextBox.Text = Guna2ComboBox3.Text
        End If

    End Sub

    Private Sub SexTextBox_TextChanged(sender As Object, e As EventArgs) Handles SexTextBox.TextChanged
        Guna2ComboBox3.Text = SexTextBox.Text
    End Sub

    Private Sub Guna2ComboBox8_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Guna2ComboBox8.SelectedIndexChanged
        If Guna2ComboBox8.SelectedIndex = 0 Then
            NameExtTextBox.Text = ""
        Else
            NameExtTextBox.Text = Guna2ComboBox8.Text
        End If
    End Sub

    Private Sub NameExtTextBox_TextChanged(sender As Object, e As EventArgs) Handles NameExtTextBox.TextChanged
        Guna2ComboBox8.Text = NameExtTextBox.Text
    End Sub

    Private Sub Guna2ComboBox5_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Guna2ComboBox5.SelectedIndexChanged
        If Guna2ComboBox5.SelectedIndex = 0 Then
            ReligionTextBox.Text = ""
        Else
            ReligionTextBox.Text = Guna2ComboBox5.Text
        End If

    End Sub

    Private Sub ReligionTextBox_TextChanged(sender As Object, e As EventArgs) Handles ReligionTextBox.TextChanged
        Guna2ComboBox5.Text = ReligionTextBox.Text
    End Sub

    Private Sub Guna2ComboBox4_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Guna2ComboBox4.SelectedIndexChanged
        If Guna2ComboBox4.SelectedIndex = 0 Then
            CStatusTextBox.Text = ""
        Else
            CStatusTextBox.Text = Guna2ComboBox4.Text
        End If

    End Sub

    Private Sub CStatusTextBox_TextChanged(sender As Object, e As EventArgs) Handles CStatusTextBox.TextChanged
        Guna2ComboBox4.Text = CStatusTextBox.Text
    End Sub

    Private Sub Guna2ComboBox2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Guna2ComboBox2.SelectedIndexChanged
        If Guna2ComboBox2.SelectedIndex = 0 Then
            CitizenshipTextBox.Text = ""
        Else
            CitizenshipTextBox.Text = Guna2ComboBox2.Text
        End If
    End Sub

    Private Sub CitizenshipTextBox_TextChanged(sender As Object, e As EventArgs) Handles CitizenshipTextBox.TextChanged
        Guna2ComboBox2.Text = CitizenshipTextBox.Text
    End Sub

    Private Sub Guna2ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Guna2ComboBox1.SelectedIndexChanged
        If Guna2ComboBox1.SelectedIndex = 0 Then
            EdAttainmentTextBox.Text = ""
        Else
            EdAttainmentTextBox.Text = Guna2ComboBox1.Text
        End If
    End Sub

    Private Sub EdAttainmentTextBox_TextChanged(sender As Object, e As EventArgs) Handles EdAttainmentTextBox.TextChanged
        Guna2ComboBox1.Text = EdAttainmentTextBox.Text
    End Sub

    Private Sub BunifuMetroTextbox1_OnValueChanged(sender As Object, e As EventArgs) Handles BunifuMetroTextbox1.OnValueChanged
        OccupationTextBox.Text = BunifuMetroTextbox1.Text
    End Sub

    Private Sub Guna2ComboBox7_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Guna2ComboBox7.SelectedIndexChanged
        If Guna2ComboBox7.SelectedIndex = 0 Then
            PurokTextBox.Text = ""
        Else
            PurokTextBox.Text = Guna2ComboBox7.Text
        End If
    End Sub

    Private Sub PurokTextBox_TextChanged(sender As Object, e As EventArgs) Handles PurokTextBox.TextChanged
        Guna2ComboBox7.Text = PurokTextBox.Text
    End Sub


End Class