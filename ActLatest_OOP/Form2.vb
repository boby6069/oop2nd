Imports MySql.Data.MySqlClient

Public Class Form2

    ' Update with your MySQL connection details
    Dim connectionstring As String = DbConfig.MySqlConnectionString

    ' Province-Municipality Dictionary
    Private ProvinceMunicipality As New Dictionary(Of String, List(Of String)) From {
        {"NCR", New List(Of String) From {"Caloocan", "Quezon City", "Valenzuela"}},
        {"Cebu", New List(Of String) From {"Cebu City", "Mandaue", "Lapu-Lapu"}},
        {"Davao", New List(Of String) From {"Davao City", "Samal", "Panabo"}}
    }

    Private countryList As New List(Of String) From {
        "Afghanistan – +93", "Albania – +355", "Algeria – +213", "Andorra – +376", "Angola – +244",
        "Argentina – +54", "Armenia – +374", "Australia – +61", "Austria – +43", "Azerbaijan – +994",
        "Bahamas – +1-242", "Bahrain – +973", "Bangladesh – +880", "Belarus – +375", "Belgium – +32",
        "Belize – +501", "Benin – +229", "Bhutan – +975", "Bolivia – +591", "Bosnia & Herzegovina – +387",
        "Brazil – +55", "Brunei – +673", "Bulgaria – +359", "Burkina Faso – +226", "Burundi – +257",
        "Cambodia – +855", "Cameroon – +237", "Canada – +1", "Chile – +56", "China – +86",
        "Colombia – +57", "Costa Rica – +506", "Croatia – +385", "Cuba – +53", "Cyprus – +357",
        "Czech Republic – +420", "Denmark – +45", "Djibouti – +253", "Dominican Republic – +1-809",
        "Ecuador – +593", "Egypt – +20", "El Salvador – +503", "Estonia – +372", "Ethiopia – +251",
        "Finland – +358", "France – +33", "Gabon – +241", "Gambia – +220", "Georgia – +995",
        "Germany – +49", "Ghana – +233", "Greece – +30", "Guatemala – +502", "Haiti – +509",
        "Honduras – +504", "Hungary – +36", "Iceland – +354", "India – +91", "Indonesia – +62",
        "Iran – +98", "Iraq – +964", "Ireland – +353", "Israel – +972", "Italy – +39",
        "Jamaica – +1-876", "Japan – +81", "Jordan – +962", "Kazakhstan – +7", "Kenya – +254",
        "Kuwait – +965", "Kyrgyzstan – +996", "Laos – +856", "Latvia – +371", "Lebanon – +961",
        "Libya – +218", "Lithuania – +370", "Luxembourg – +352", "Madagascar – +261", "Malaysia – +60",
        "Maldives – +960", "Mali – +223", "Malta – +356", "Mexico – +52", "Moldova – +373",
        "Monaco – +377", "Mongolia – +976", "Montenegro – +382", "Morocco – +212", "Mozambique – +258",
        "Myanmar – +95", "Namibia – +264", "Nepal – +977", "Netherlands – +31", "New Zealand – +64",
        "Nicaragua – +505", "Nigeria – +234", "North Korea – +850", "North Macedonia – +389", "Norway – +47",
        "Oman – +968", "Pakistan – +92", "Panama – +507", "Paraguay – +595", "Peru – +51",
        "Philippines – +63", "Poland – +48", "Portugal – +351", "Qatar – +974", "Romania – +40",
        "Russia – +7", "Rwanda – +250", "Saudi Arabia – +966", "Senegal – +221", "Serbia – +381",
        "Singapore – +65", "Slovakia – +421", "Slovenia – +386", "South Africa – +27", "South Korea – +82",
        "Spain – +34", "Sri Lanka – +94", "Sudan – +249", "Sweden – +46", "Switzerland – +41",
        "Syria – +963", "Taiwan – +886", "Tajikistan – +992", "Tanzania – +255", "Thailand – +66",
        "Tunisia – +216", "Turkey – +90", "Turkmenistan – +993", "Uganda – +256", "Ukraine – +380",
        "United Arab Emirates – +971", "United Kingdom – +44", "United States – +1", "Uruguay – +598",
        "Uzbekistan – +998", "Venezuela – +58", "Vietnam – +84", "Yemen – +967", "Zambia – +260", "Zimbabwe – +263"
    }

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Make ComboBoxes untypable (selection only)
        province1.DropDownStyle = ComboBoxStyle.DropDownList
        municipality1.DropDownStyle = ComboBoxStyle.DropDownList
        suffix1.DropDownStyle = ComboBoxStyle.DropDownList
        gender.DropDownStyle = ComboBoxStyle.DropDownList

        ' Populate Province ComboBox (province1)
        province1.Items.AddRange(ProvinceMunicipality.Keys.ToArray())

        ' Populate Suffix ComboBox (suffix1) with generational suffixes
        suffix1.Items.Clear()
        suffix1.Items.AddRange(New String() {"", "Jr.", "Sr.", "II", "III", "IV", "V"})

        ' Populate Gender ComboBox (gender) with "Male" and "Female"
        gender.Items.Clear()
        gender.Items.AddRange(New String() {"Male", "Female"})

        ' Populate country ComboBox and enable typing initially
        country.DropDownStyle = ComboBoxStyle.DropDown
        country.AutoCompleteMode = AutoCompleteMode.SuggestAppend
        country.AutoCompleteSource = AutoCompleteSource.ListItems
        country.Items.Clear()
        country.Items.AddRange(countryList.ToArray())
    End Sub

    Private Sub province1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles province1.SelectedIndexChanged
        ' Clear Municipality ComboBox (municipality1)
        municipality1.Items.Clear()
        municipality1.SelectedIndex = -1

        ' Get selected Province
        If province1.SelectedItem IsNot Nothing Then
            Dim selectedProvince As String = province1.SelectedItem.ToString()

            ' Load Municipalities
            If ProvinceMunicipality.ContainsKey(selectedProvince) Then
                municipality1.Items.AddRange(ProvinceMunicipality(selectedProvince).ToArray())
            End If
        End If
    End Sub

    Private Sub municipality1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles municipality1.SelectedIndexChanged
        ' Example: Uncomment if you want to debug
        ' MessageBox.Show("You selected: " & municipality1.SelectedItem.ToString())
    End Sub

    Private Sub submit_Click(sender As Object, e As EventArgs) Handles submit.Click
        ' Sequential required field validation
        If String.IsNullOrWhiteSpace(fname1.Text) Then
            MessageBox.Show("Please input First Name.")
            fname1.Focus()
            Exit Sub
        End If
        If String.IsNullOrWhiteSpace(mname1.Text) Then
            MessageBox.Show("Please input Middle Name.")
            mname1.Focus()
            Exit Sub
        End If
        If String.IsNullOrWhiteSpace(lname1.Text) Then
            MessageBox.Show("Please input Last Name.")
            lname1.Focus()
            Exit Sub
        End If
        If String.IsNullOrWhiteSpace(age1.Text) Then
            MessageBox.Show("Please input Age.")
            age1.Focus()
            Exit Sub
        End If
        If String.IsNullOrWhiteSpace(housenum1.Text) Then
            MessageBox.Show("Please input House # / St.")
            housenum1.Focus()
            Exit Sub
        End If
        If String.IsNullOrWhiteSpace(contact1.Text) Then
            MessageBox.Show("Please input Contact Number.")
            contact1.Focus()
            Exit Sub
        End If
        If String.IsNullOrWhiteSpace(email1.Text) Then
            MessageBox.Show("Please input Email.")
            email1.Focus()
            Exit Sub
        End If
        If province1.SelectedIndex = -1 Then
            MessageBox.Show("Please select a Province.")
            province1.Focus()
            Exit Sub
        End If
        If municipality1.SelectedIndex = -1 Then
            MessageBox.Show("Please select a Municipality.")
            municipality1.Focus()
            Exit Sub
        End If
        If gender.SelectedIndex = -1 Then
            MessageBox.Show("Please select Gender.")
            gender.Focus()
            Exit Sub
        End If

        ' Existing length and format validations (optional, can be kept after required checks)
        If fname1.Text.Length > 255 Then
            MessageBox.Show("First Name must be 255 characters or less.")
            fname1.Focus()
            Exit Sub
        End If
        If mname1.Text.Length > 255 Then
            MessageBox.Show("Middle Name must be 255 characters or less.")
            mname1.Focus()
            Exit Sub
        End If
        If lname1.Text.Length > 255 Then
            MessageBox.Show("Last Name must be 255 characters or less.")
            lname1.Focus()
            Exit Sub
        End If
        If housenum1.Text.Length > 255 Then
            MessageBox.Show("House # / St. must be 255 characters or less.")
            housenum1.Focus()
            Exit Sub
        End If

        If contact1.Text.Length <> 10 OrElse Not IsNumeric(contact1.Text) Then
            MessageBox.Show("Contact Number must be exactly 10 digits.")
            contact1.Focus()
            Exit Sub
        End If

        If Not email1.Text.EndsWith("com") Then
            MessageBox.Show("Email must end with '@link.com'.")
            email1.Focus()
            Exit Sub
        End If

        ' Show validation dialog before submitting
        Dim result As DialogResult = MessageBox.Show(
            "Is this information correct?",
            "Confirm Submission",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Question
        )

        If result = DialogResult.Yes Then
            ' If all validations pass, proceed to insert
            Dim fname As String = fname1.Text
            Dim mname As String = mname1.Text
            Dim lname As String = lname1.Text
            Dim suffix As String = suffix1.Text
            Dim age As String = age1.Text
            Dim birthdate As Date = birthdate1.Value
            Dim houseNum As String = housenum1.Text
            Dim municipality As String = municipality1.Text
            Dim province As String = province1.Text
            Dim contactNum As String = contact1.Text
            Dim email As String = email1.Text
            Dim genderValue As String = gender.Text

            Dim query As String = "INSERT INTO Registered (`First Name`, `Middle Name`, `Last Name`, `Suffix`, `Age`, `Birth Date`, `House Number / Street`, `Municipality`, `Province`, `Contact Number`, `Email`, `Gender`) " &
                              "VALUES (@fname, @mname, @lname, @suffix, @age, @birthdate, @houseNum, @municipality, @province, @contactNum, @email, @gender)"

            Using conn As New MySqlConnection(connectionstring)
                    Using cmd As New MySqlCommand(query, conn)
                        cmd.Parameters.AddWithValue("@fname", fname)
                        cmd.Parameters.AddWithValue("@mname", mname)
                        cmd.Parameters.AddWithValue("@lname", lname)
                        cmd.Parameters.AddWithValue("@suffix", suffix)
                        cmd.Parameters.AddWithValue("@age", age)
                        cmd.Parameters.AddWithValue("@birthdate", birthdate)
                        cmd.Parameters.AddWithValue("@houseNum", houseNum)
                        cmd.Parameters.AddWithValue("@municipality", municipality)
                        cmd.Parameters.AddWithValue("@province", province)
                        cmd.Parameters.AddWithValue("@contactNum", contactNum)
                        cmd.Parameters.AddWithValue("@email", email)
                        cmd.Parameters.AddWithValue("@gender", genderValue)

                        Try
                            conn.Open()
                            cmd.ExecuteNonQuery()
                            MessageBox.Show("Data submitted successfully!")
                            Me.Hide()
                            Dim f4 As New Form4()
                            f4.ShowDialog()
                            Me.Show()
                            ' Clear all form controls after successful submission
                            ClearForm()
                        Catch ex As Exception
                            MessageBox.Show("Error submitting data: " & ex.Message)
                        End Try
                    End Using
                End Using
                ElseIf result = DialogResult.No Then
                ' "Double Check" - just return to the form for editing
                MessageBox.Show("Please review your information.", "Double Check", MessageBoxButtons.OK, MessageBoxIcon.Information)
                ' No further action needed; user can edit the form
                Return
                End If
    End Sub

    ' Method to clear all form controls
    Private Sub ClearForm()
        ' Clear text boxes
        fname1.Text = ""
        mname1.Text = ""
        lname1.Text = ""
        age1.Text = ""
        housenum1.Text = ""
        contact1.Text = ""
        email1.Text = ""

        ' Reset combo boxes
        suffix1.SelectedIndex = -1
        municipality1.Items.Clear()
        municipality1.SelectedIndex = -1
        province1.SelectedIndex = -1

        ' Reset date picker to today's date
        birthdate1.Value = DateTime.Now

        ' Set focus back to first field
        fname1.Focus()
    End Sub

    Private Sub view_Click(sender As Object, e As EventArgs) Handles view.Click
        Me.Hide()
        Dim f2 As New Form3()
        f2.ShowDialog()
    End Sub

    Private Sub backbtn_Click(sender As Object, e As EventArgs) Handles backbtn.Click
        Me.Hide()
        Dim f2 As New Form1()
        f2.ShowDialog()
    End Sub

    ' Add these event handlers to prevent numbers in the name textboxes
    Private Sub fname1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles fname1.KeyPress
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub mname1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles mname1.KeyPress
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub lname1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles lname1.KeyPress
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub age1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles age1.KeyPress
        Dim allowedRoman As String = "IVX"
        Dim isRomanInput As Boolean = age1.Text.All(Function(c) allowedRoman.Contains(Char.ToUpper(c)))
        Dim isNumericInput As Boolean = age1.Text.All(Function(c) Char.IsDigit(c))

        ' If textbox is empty, allow both numbers and roman numerals
        If age1.Text.Length = 0 Then
            If Not Char.IsControl(e.KeyChar) AndAlso
               Not Char.IsDigit(e.KeyChar) AndAlso
               Not allowedRoman.Contains(Char.ToUpper(e.KeyChar)) Then
                e.Handled = True
            End If
            Return
        End If

        ' If current input is all numbers, only allow more numbers (and control keys)
        If isNumericInput Then
            If Not Char.IsControl(e.KeyChar) AndAlso Not Char.IsDigit(e.KeyChar) Then
                e.Handled = True
            End If
            ' Limit to 10 digits
            If Char.IsDigit(e.KeyChar) AndAlso age1.Text.Length >= 5 AndAlso Not age1.SelectedText.Length > 0 Then
                MessageBox.Show("Are you a demon? You can't be that old")
                e.Handled = True
            End If
            Return
        End If

        ' If current input is all roman numerals, only allow more roman numerals (and control keys)
        If isRomanInput Then
            If Not Char.IsControl(e.KeyChar) AndAlso Not allowedRoman.Contains(Char.ToUpper(e.KeyChar)) Then
                e.Handled = True
            End If
            Return
        End If

        ' If mixed input, block further typing
        e.Handled = True
    End Sub

    Private Sub age1_TextChanged(sender As Object, e As EventArgs) Handles age1.TextChanged
        ' Always convert to uppercase for roman numerals
        Dim txt = age1
        Dim selStart = txt.SelectionStart
        Dim newText = txt.Text.ToUpper()
        If txt.Text <> newText Then
            txt.Text = newText
            txt.SelectionStart = selStart
        End If

        ' If input is mixed (numbers and roman numerals), clear and show error
        Dim allowedRoman As String = "IVX"
        Dim hasRoman As Boolean = txt.Text.Any(Function(c) allowedRoman.Contains(c))
        Dim hasNumber As Boolean = txt.Text.Any(Function(c) Char.IsDigit(c))
        If hasRoman AndAlso hasNumber Then
            MessageBox.Show("Input must be either all numbers or all Roman numerals, not both.")
            txt.Text = ""
        End If
    End Sub

    Private Sub birthdate1_ValueChanged(sender As Object, e As EventArgs) Handles birthdate1.ValueChanged
        ' Automatically calculate and set age based on selected birthdate
        Dim today As Date = Date.Today
        Dim bday As Date = birthdate1.Value
        Dim age As Integer = today.Year - bday.Year
        If (bday > today.AddYears(-age)) Then
            age -= 1
        End If
        age1.Text = age.ToString()
        age1.ReadOnly = True ' Make age1 textbox read-only after setting age
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles gender.SelectedIndexChanged

    End Sub

    Private Sub Label8_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub country_SelectedIndexChanged(sender As Object, e As EventArgs) Handles country.SelectedIndexChanged
        ' Make country ComboBox untypable after selection
        country.DropDownStyle = ComboBoxStyle.DropDownList
    End Sub

    Private Sub contact1_TextChanged(sender As Object, e As EventArgs) Handles contact1.TextChanged

    End Sub

    Private Sub contact1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles contact1.KeyPress
        ' Allow only digits and control keys, and limit to 10 digits
        If Not Char.IsControl(e.KeyChar) AndAlso Not Char.IsDigit(e.KeyChar) Then
            e.Handled = True
        End If

        ' Prevent input if already 10 digits and not replacing selected text
        If Char.IsDigit(e.KeyChar) AndAlso contact1.Text.Length >= 10 AndAlso contact1.SelectionLength = 0 Then
            e.Handled = True
        End If
    End Sub
End Class