Imports MySql.Data.MySqlClient

Public Class Form1
    Private connectionString As String = "server=localhost;user id=root;password=;database=org_record"


    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click

        If String.IsNullOrWhiteSpace(txtUsername.Text) OrElse String.IsNullOrWhiteSpace(txtPassword.Text) Then
            MessageBox.Show("Username and Password cannot be blank.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If


        Using connection As New MySqlConnection(connectionString)
            Dim query As String = "SELECT COUNT(*) FROM admin WHERE username = @username AND password = @password"
            Using command As New MySqlCommand(query, connection)
                command.Parameters.AddWithValue("@username", txtUsername.Text.Trim())
                command.Parameters.AddWithValue("@password", txtPassword.Text.Trim())

                Try
                    connection.Open()
                    Dim count As Integer = Convert.ToInt32(command.ExecuteScalar())

                    If count > 0 Then

                        MessageBox.Show("Login successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)


                        Dim mainForm As New Form2()
                        mainForm.Show()

                        Me.Hide()
                    Else
                        MessageBox.Show("Invalid username or password.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End If

                Catch ex As MySqlException
                    MessageBox.Show("Error: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End Try
            End Using
        End Using
    End Sub

End Class

