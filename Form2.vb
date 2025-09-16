Imports MySql.Data.MySqlClient

Public Class Form2
    Private connectionString As String = "server=localhost;user id=root;password=;database=org_record"


    Private Function GetSelectedOrganizations() As List(Of String)
        Dim orgs As New List(Of String)
        If chkPGITS.Checked Then orgs.Add("PGITS")
        If chkPSITS.Checked Then orgs.Add("PSITS")
        If chkGMITS.Checked Then orgs.Add("GMITS")
        Return orgs
    End Function

    Private Function OrgsToString(orgs As List(Of String)) As String
        Return String.Join(", ", orgs)
    End Function


    Private Sub SetOrganizations(orgs As String)
        chkPGITS.Checked = orgs.Contains("PGITS")
        chkPSITS.Checked = orgs.Contains("PSITS")
        chkGMITS.Checked = orgs.Contains("GMITS")
    End Sub


    Private Sub ClearInputs()
        inputFNAME.Clear()
        inputLNAME.Clear()
        inputYearLevel.Clear()
        chkPGITS.Checked = False
        chkPSITS.Checked = False
        chkGMITS.Checked = False
    End Sub


    Private Sub btnTest_Click(sender As Object, e As EventArgs) Handles btnTest.Click
        Using connection As New MySqlConnection(connectionString)
            Try
                connection.Open()
                lblTest.Text = "Connected"
                lblTest.ForeColor = Color.Green
            Catch ex As MySqlException
                lblTest.Text = "Error: " & ex.Message
                lblTest.ForeColor = Color.Red
            End Try
        End Using
    End Sub


    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        If String.IsNullOrWhiteSpace(inputFNAME.Text) OrElse String.IsNullOrWhiteSpace(inputLNAME.Text) OrElse
           String.IsNullOrWhiteSpace(inputYearLevel.Text) Then

            MessageBox.Show("Please fill in all fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        Dim orgs As List(Of String) = GetSelectedOrganizations()
        If orgs.Count < 1 OrElse orgs.Count > 2 Then
            MessageBox.Show("You must select at least 1 and at most 2 organizations.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        Using connection As New MySqlConnection(connectionString)
            connection.Open()

            Dim checkQuery As String = "SELECT COUNT(*) FROM names WHERE fname=@fname AND lname=@lname AND year_level=@year AND organization=@org"
            Using checkCmd As New MySqlCommand(checkQuery, connection)
                checkCmd.Parameters.AddWithValue("@fname", inputFNAME.Text)
                checkCmd.Parameters.AddWithValue("@lname", inputLNAME.Text)
                checkCmd.Parameters.AddWithValue("@year", inputYearLevel.Text)
                checkCmd.Parameters.AddWithValue("@org", OrgsToString(orgs))

                Dim count As Integer = Convert.ToInt32(checkCmd.ExecuteScalar())
                If count > 0 Then
                    MessageBox.Show("This record already exists!", "Duplicate Entry", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    Return
                End If
            End Using

            Dim query As String = "INSERT INTO names (fname, lname, year_level, organization) VALUES (@fname, @lname, @year, @org)"
            Using command As New MySqlCommand(query, connection)
                command.Parameters.AddWithValue("@fname", inputFNAME.Text)
                command.Parameters.AddWithValue("@lname", inputLNAME.Text)
                command.Parameters.AddWithValue("@year", inputYearLevel.Text)
                command.Parameters.AddWithValue("@org", OrgsToString(orgs))

                Try
                    command.ExecuteNonQuery()
                    MessageBox.Show("Record created successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    RetrieveData()
                    ClearInputs()
                Catch ex As MySqlException
                    MessageBox.Show("Error: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End Try
            End Using
        End Using
    End Sub


    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        RetrieveData()
    End Sub


    Private Sub RetrieveData()
        Dim query As String = "SELECT id, fname, lname, year_level, organization FROM names"
        Using connection As New MySqlConnection(connectionString)
            Using adapter As New MySqlDataAdapter(query, connection)
                Dim table As New DataTable()
                Try
                    adapter.Fill(table)
                    dgvNames.DataSource = table

                    dgvNames.Columns("id").HeaderText = "ID"
                    dgvNames.Columns("fname").HeaderText = "First Name"
                    dgvNames.Columns("lname").HeaderText = "Last Name"
                    dgvNames.Columns("year_level").HeaderText = "Year Level"
                    dgvNames.Columns("organization").HeaderText = "Organization/s"
                Catch ex As MySqlException
                    MessageBox.Show("Error: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End Try
            End Using
        End Using
    End Sub


    Private Sub dgvNames_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvNames.CellContentClick
        If e.RowIndex >= 0 Then
            Dim selectedRow As DataGridViewRow = dgvNames.Rows(e.RowIndex)


            updateID.Text = selectedRow.Cells("id").Value.ToString()
            updateFNAME.Text = selectedRow.Cells("fname").Value.ToString()
            updateLNAME.Text = selectedRow.Cells("lname").Value.ToString()
            updateYearLevel.Text = selectedRow.Cells("year_level").Value.ToString()
            SetOrganizations(selectedRow.Cells("organization").Value.ToString())

            deleteID.Text = selectedRow.Cells("id").Value.ToString()
            deleteFNAME.Text = selectedRow.Cells("fname").Value.ToString()
            deleteLNAME.Text = selectedRow.Cells("lname").Value.ToString()
            deleteYearLevel.Text = selectedRow.Cells("year_level").Value.ToString()
            deleteOrganization.Text = selectedRow.Cells("organization").Value.ToString()
        End If
    End Sub


    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        If String.IsNullOrWhiteSpace(updateFNAME.Text) OrElse
       String.IsNullOrWhiteSpace(updateLNAME.Text) OrElse
       String.IsNullOrWhiteSpace(updateYearLevel.Text) Then

            MessageBox.Show("First Name, Last Name, and Year Level cannot be blank.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If


        Dim selectedOrgs As New List(Of String)
        If chkPGITS.Checked Then selectedOrgs.Add(chkPGITS.Text)
        If chkPSITS.Checked Then selectedOrgs.Add(chkPSITS.Text)
        If chkGMITS.Checked Then selectedOrgs.Add(chkGMITS.Text)


        If selectedOrgs.Count = 0 OrElse selectedOrgs.Count > 2 Then
            MessageBox.Show("Please select 1 or 2 organizations only.", "Invalid Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Dim orgString As String = String.Join(", ", selectedOrgs)

        Dim query = "UPDATE names SET fname = @fname, lname = @lname, year_level = @year_level, organization = @organization WHERE id = @id"

        Using connection As New MySqlConnection(connectionString)
            Using command As New MySqlCommand(query, connection)

                command.Parameters.AddWithValue("@fname", updateFNAME.Text)
                command.Parameters.AddWithValue("@lname", updateLNAME.Text)
                command.Parameters.AddWithValue("@year_level", updateYearLevel.Text)
                command.Parameters.AddWithValue("@organization", orgString)
                command.Parameters.AddWithValue("@id", updateID.Text)

                Try
                    connection.Open()
                    command.ExecuteNonQuery()
                    MessageBox.Show("Record updated successfully!", "Success",
                                MessageBoxButtons.OK, MessageBoxIcon.Information)
                    RetrieveData()


                    updateID.Text = ""
                    updateFNAME.Text = ""
                    updateLNAME.Text = ""
                    updateYearLevel.Text = ""
                    chkPGITS.Checked = False
                    chkPSITS.Checked = False
                    chkGMITS.Checked = False

                Catch ex As MySqlException
                    MessageBox.Show("Error: " & ex.Message, "Error",
                                MessageBoxButtons.OK, MessageBoxIcon.Error)
                End Try
            End Using
        End Using
    End Sub



    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        If String.IsNullOrWhiteSpace(deleteID.Text) Then
            MessageBox.Show("Please select a record to delete", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        Dim confirmDelete As DialogResult = MessageBox.Show(
            $"Are you sure you want to delete {deleteFNAME.Text} {deleteLNAME.Text}?",
            "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning
        )

        If confirmDelete = DialogResult.Yes Then
            Dim query As String = "DELETE FROM names WHERE id=@id"
            Using connection As New MySqlConnection(connectionString)
                Using command As New MySqlCommand(query, connection)
                    command.Parameters.AddWithValue("@id", deleteID.Text)
                    Try
                        connection.Open()
                        command.ExecuteNonQuery()
                        MessageBox.Show("Record deleted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        RetrieveData()


                        deleteID.Text = "--"
                        deleteFNAME.Text = "--"
                        deleteLNAME.Text = "--"
                        deleteYearLevel.Text = "--"
                        deleteOrganization.Text = "--"
                    Catch ex As MySqlException
                        MessageBox.Show("Error: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End Try
                End Using
            End Using
        End If
    End Sub


    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        Dim searchValue As String = TextBox1.Text.Trim()
        Dim query As String

        If String.IsNullOrWhiteSpace(searchValue) Then
            RetrieveData()
            Return
        End If

        query = "SELECT id, fname, lname, year_level, organization FROM names " &
                "WHERE id LIKE @search OR fname LIKE @search OR lname LIKE @search OR year_level LIKE @search OR organization LIKE @search"

        Using connection As New MySqlConnection(connectionString)
            Using adapter As New MySqlDataAdapter(query, connection)
                adapter.SelectCommand.Parameters.AddWithValue("@search", "%" & searchValue & "%")
                Dim table As New DataTable()
                Try
                    adapter.Fill(table)
                    dgvNames.DataSource = table

                    If table.Rows.Count = 0 Then
                        MessageBox.Show("No records found.", "Search", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    End If
                Catch ex As MySqlException
                    MessageBox.Show("Error: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End Try
            End Using
        End Using
    End Sub
End Class
