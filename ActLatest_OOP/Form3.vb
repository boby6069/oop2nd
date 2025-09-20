Imports MySql.Data.MySqlClient

Public Class Form3

    ' Updated MySQL connection string
    Dim connectionstring As String = DbConfig.MySqlConnectionString
    Private originalValues As Dictionary(Of String, Object)

    Private Sub Registered_List_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadDataintoDataGridView()
    End Sub

    Private Sub LoadDataintoDataGridView()
        Using conn As New MySqlConnection(connectionstring)
            Dim query As String = "SELECT `First Name`, `Middle Name`, `Last Name`, `Suffix`, `Age`, `Birth Date`, `House Number / Street`, `Municipality`, `Province`, `Contact Number`, `Email`, `Gender` FROM Registered"
            Dim adapter As New MySqlDataAdapter(query, conn)
            Dim datatable As New DataTable()
            Try
                conn.Open()
                adapter.Fill(datatable)
                DataGridView1.DataSource = datatable
            Catch ex As Exception
                MessageBox.Show("Error: " & ex.Message)
            End Try
        End Using
    End Sub

    Private Sub view_Click(sender As Object, e As EventArgs) Handles back.Click
        Me.Hide()
        Dim f2 As New Form1()
        f2.ShowDialog()
    End Sub

    Private Sub submit_Click(sender As Object, e As EventArgs) Handles save.Click

    End Sub

    ' Enable editing on DataGridView when Edit is clicked
    Private Sub edit_Click(sender As Object, e As EventArgs) Handles edit.Click
        If DataGridView1.CurrentRow Is Nothing Then
            MessageBox.Show("Please select a row to edit.")
            Return
        End If

        ' Store original values
        originalValues = New Dictionary(Of String, Object)()
        For Each col As DataGridViewColumn In DataGridView1.Columns
            originalValues(col.Name) = DataGridView1.CurrentRow.Cells(col.Name).Value
        Next

        DataGridView1.ReadOnly = False
        MessageBox.Show("You can now edit the selected row. Click Save when done.")
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles exit3.Click
        Application.Exit()
    End Sub

    Private Sub delete_Click(sender As Object, e As EventArgs) Handles delete.Click
        If DataGridView1.CurrentRow Is Nothing Then
            MessageBox.Show("Please select a row to delete.")
            Return
        End If

        Dim row = DataGridView1.CurrentRow
        Dim result = MessageBox.Show("Are you sure you want to delete this record?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
        If result = DialogResult.Yes Then
            Using conn As New MySqlConnection(connectionstring)
                Dim query As String = "DELETE FROM Registered WHERE `First Name`=@fname AND `Middle Name`=@mname AND `Last Name`=@lname AND `Suffix`=@suffix AND `Age`=@age AND `Birth Date`=@bdate AND `House Number / Street`=@house AND `Municipality`=@municipality AND `Province`=@province AND `Contact Number`=@contact AND `Email`=@email AND `Gender`=@gender"
                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@fname", row.Cells("First Name").Value)
                    cmd.Parameters.AddWithValue("@mname", row.Cells("Middle Name").Value)
                    cmd.Parameters.AddWithValue("@lname", row.Cells("Last Name").Value)
                    cmd.Parameters.AddWithValue("@suffix", row.Cells("Suffix").Value)
                    cmd.Parameters.AddWithValue("@age", row.Cells("Age").Value)
                    cmd.Parameters.AddWithValue("@bdate", row.Cells("Birth Date").Value)
                    cmd.Parameters.AddWithValue("@house", row.Cells("House Number / Street").Value)
                    cmd.Parameters.AddWithValue("@municipality", row.Cells("Municipality").Value)
                    cmd.Parameters.AddWithValue("@province", row.Cells("Province").Value)
                    cmd.Parameters.AddWithValue("@contact", row.Cells("Contact Number").Value)
                    cmd.Parameters.AddWithValue("@email", row.Cells("Email").Value)
                    cmd.Parameters.AddWithValue("@gender", row.Cells("Gender").Value)
                    Try
                        conn.Open()
                        cmd.ExecuteNonQuery()
                        MessageBox.Show("Record deleted successfully.")
                        LoadDataintoDataGridView()
                    Catch ex As Exception
                        MessageBox.Show("Error: " & ex.Message)
                    End Try
                End Using
            End Using
        End If
    End Sub

    Private Sub save_Click(sender As Object, e As EventArgs) Handles save.Click
        If DataGridView1.CurrentRow Is Nothing Then
            MessageBox.Show("Please select a row to save.")
            Return
        End If

        If originalValues Is Nothing Then
            MessageBox.Show("No original data to compare. Please click Edit first.")
            Return
        End If

        Dim row = DataGridView1.CurrentRow

        Using conn As New MySqlConnection(connectionstring)
            Dim query As String = "UPDATE Registered SET `First Name`=@new_fname, `Middle Name`=@new_mname, `Last Name`=@new_lname, `Suffix`=@new_suffix, `Age`=@new_age, `Birth Date`=@new_bdate, `House Number / Street`=@new_house, `Municipality`=@new_municipality, `Province`=@new_province, `Contact Number`=@new_contact, `Email`=@new_email, `Gender`=@new_gender " &
                              "WHERE `First Name`=@old_fname AND `Middle Name`=@old_mname AND `Last Name`=@old_lname AND `Suffix`=@old_suffix AND `Age`=@old_age AND `Birth Date`=@old_bdate AND `House Number / Street`=@old_house AND `Municipality`=@old_municipality AND `Province`=@old_province AND `Contact Number`=@old_contact AND `Email`=@old_email AND `Gender`=@old_gender"
            Using cmd As New MySqlCommand(query, conn)
                ' New values (from the grid)
                cmd.Parameters.AddWithValue("@new_fname", row.Cells("First Name").Value)
                cmd.Parameters.AddWithValue("@new_mname", row.Cells("Middle Name").Value)
                cmd.Parameters.AddWithValue("@new_lname", row.Cells("Last Name").Value)
                cmd.Parameters.AddWithValue("@new_suffix", row.Cells("Suffix").Value)
                cmd.Parameters.AddWithValue("@new_age", row.Cells("Age").Value)
                cmd.Parameters.AddWithValue("@new_bdate", row.Cells("Birth Date").Value)
                cmd.Parameters.AddWithValue("@new_house", row.Cells("House Number / Street").Value)
                cmd.Parameters.AddWithValue("@new_municipality", row.Cells("Municipality").Value)
                cmd.Parameters.AddWithValue("@new_province", row.Cells("Province").Value)
                cmd.Parameters.AddWithValue("@new_contact", row.Cells("Contact Number").Value)
                cmd.Parameters.AddWithValue("@new_email", row.Cells("Email").Value)
                cmd.Parameters.AddWithValue("@new_gender", row.Cells("Gender").Value)
                ' Old values (from originalValues)
                cmd.Parameters.AddWithValue("@old_fname", originalValues("First Name"))
                cmd.Parameters.AddWithValue("@old_mname", originalValues("Middle Name"))
                cmd.Parameters.AddWithValue("@old_lname", originalValues("Last Name"))
                cmd.Parameters.AddWithValue("@old_suffix", originalValues("Suffix"))
                cmd.Parameters.AddWithValue("@old_age", originalValues("Age"))
                cmd.Parameters.AddWithValue("@old_bdate", originalValues("Birth Date"))
                cmd.Parameters.AddWithValue("@old_house", originalValues("House Number / Street"))
                cmd.Parameters.AddWithValue("@old_municipality", originalValues("Municipality"))
                cmd.Parameters.AddWithValue("@old_province", originalValues("Province"))
                cmd.Parameters.AddWithValue("@old_contact", originalValues("Contact Number"))
                cmd.Parameters.AddWithValue("@old_email", originalValues("Email"))
                cmd.Parameters.AddWithValue("@old_gender", originalValues("Gender"))
                Try
                    conn.Open()
                    Dim rowsAffected = cmd.ExecuteNonQuery()
                    If rowsAffected > 0 Then
                        MessageBox.Show("Edit saved successfully!", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Else
                        MessageBox.Show("No changes were saved. The record may have been modified or deleted by another user.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    End If
                    DataGridView1.ReadOnly = True
                    LoadDataintoDataGridView()
                    originalValues = Nothing
                Catch ex As Exception
                    MessageBox.Show("Error: " & ex.Message)
                End Try
            End Using
        End Using
    End Sub

    ' Other event handlers remain unchanged
End Class