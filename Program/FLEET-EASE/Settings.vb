Imports System.Data.SqlClient
Imports System.Text.RegularExpressions

Public Class Settings
    ' Define connection string and SQL objects
    Private ConnectionString As String = "Data Source=DESKTOP-FE6OBHL\SQLEXPRESS;Initial Catalog=fleetease;Integrated Security=True;"
    Private cn As New SqlConnection(ConnectionString)
    Private cm As SqlCommand
    Private LoadedContactNumber As String = ""
    Private Sub Settings_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        UpdateUsername()
        LoadUserInfo()
    End Sub

    Public Sub UpdateUsername()
        LblUsername.Text = Module1.LoggedInUsename
    End Sub

    Private Sub LoadUserInfo()
        Try
            If cn.State = ConnectionState.Closed Then
                cn.Open()
            End If
            cm = New SqlCommand("SELECT username, contact FROM tbllogin WHERE username = @username", cn)
            cm.Parameters.AddWithValue("@username", Module1.LoggedInUsename)

            Using dr As SqlDataReader = cm.ExecuteReader()
                If dr.Read() Then
                    TxtUsername.Text = dr("username").ToString()
                    LoadedContactNumber = dr("contact").ToString()
                    TxtContact.Text = LoadedContactNumber
                End If
            End Using
        Catch ex As Exception
            MessageBox.Show("Error loading user info: " & ex.Message)
        Finally
            If cn.State = ConnectionState.Open Then
                cn.Close()

            End If
        End Try
    End Sub


    Private Sub BtnUpdate_Click(sender As Object, e As EventArgs) Handles BtnUpdate.Click
        ' Check if any changes are attempted
        If TxtUsername.Text <> Module1.LoggedInUsename Then
            MessageBox.Show("Changing username is not allowed.")
            TxtUsername.Text = Module1.LoggedInUsename ' Reset to original username
            Return
        End If

        Dim isPasswordChangeAttempted As Boolean = Not String.IsNullOrEmpty(TxtOldpassword.Text) OrElse Not String.IsNullOrEmpty(TxtNewpassword.Text) OrElse Not String.IsNullOrEmpty(TxtRenewpassword.Text)
        Dim isContactChangeAttempted As Boolean = TxtContact.Text <> "" AndAlso TxtContact.Text <> LoadedContactNumber ' Compare with the loaded contact number

        If Not isPasswordChangeAttempted AndAlso Not isContactChangeAttempted Then
            MessageBox.Show("No changes detected. Please update either password or contact.")
            Return
        End If

        ' Validate contact if change is attempted
        If isContactChangeAttempted Then
            If Not IsValidContact(TxtContact.Text) Then
                MessageBox.Show("Contact must be exactly 10 digits.")
                Return
            End If
        Else
            TxtContact.Text = LoadedContactNumber ' Display the unchanged contact number
        End If

        ' Validate password if change is attempted
        If isPasswordChangeAttempted Then
            If String.IsNullOrEmpty(TxtOldpassword.Text) OrElse String.IsNullOrEmpty(TxtNewpassword.Text) OrElse String.IsNullOrEmpty(TxtRenewpassword.Text) Then
                MessageBox.Show("Please fill in all password fields to change the password.")
                Return
            End If

            If Not IsValidPassword(TxtNewpassword.Text) Then
                MessageBox.Show("New password must be at least 8 characters long, contain at least one capital letter, one number, and one symbol.")
                Return
            End If

            If TxtNewpassword.Text <> TxtRenewpassword.Text Then
                MessageBox.Show("New passwords do not match.")
                Return
            End If
        End If

        Try
            cn.Open()

            ' Verify the old password if password change is attempted
            If isPasswordChangeAttempted Then
                cm = New SqlCommand("SELECT password FROM tbllogin WHERE username = @username", cn)
                cm.Parameters.AddWithValue("@username", Module1.LoggedInUsename)
                Dim storedPassword As String = CStr(cm.ExecuteScalar())

                If storedPassword <> TxtOldpassword.Text Then
                    MessageBox.Show("Old password is incorrect.")
                    Return
                End If

                ' Check if the new password is the same as the old password
                If TxtNewpassword.Text = TxtOldpassword.Text Then
                    MessageBox.Show("New password cannot be the same as the old password. Please choose a different password.")
                    Return
                End If
            End If

            ' Prepare the UPDATE statement
            Dim updateQuery As String = "UPDATE tbllogin SET "
            Dim updateParams As New List(Of String)

            If isPasswordChangeAttempted Then
                updateParams.Add("password = @newPassword")
            End If

            If isContactChangeAttempted Then
                updateParams.Add("contact = @newContact")
            End If

            updateQuery &= String.Join(", ", updateParams)
            updateQuery &= " WHERE username = @currentUsername"

            cm = New SqlCommand(updateQuery, cn)

            If isPasswordChangeAttempted Then
                cm.Parameters.AddWithValue("@newPassword", TxtNewpassword.Text)
            End If

            If isContactChangeAttempted Then
                cm.Parameters.AddWithValue("@newContact", TxtContact.Text)
            End If

            cm.Parameters.AddWithValue("@currentUsername", Module1.LoggedInUsename)

            Dim rowsAffected As Integer = cm.ExecuteNonQuery()

            If rowsAffected > 0 Then
                MessageBox.Show("Information updated successfully.")
                LoadUserInfo() ' Reload user info to reflect changes
            Else
                MessageBox.Show("No changes were made to the database.")
            End If
        Catch ex As Exception
            MessageBox.Show("Error updating information: " & ex.Message)
        Finally
            cn.Close()
        End Try
    End Sub

    Private Function IsValidPassword(password As String) As Boolean
        ' Check if password is at least 8 characters long, contains at least one capital letter, one number, and one symbol
        Dim regex As New Regex("^(?=.*[A-Z])(?=.*\d)(?=.*[^\da-zA-Z]).{8,}$")
        Return regex.IsMatch(password)
    End Function

    Private Function IsValidContact(contact As String) As Boolean
        ' Check if contact is exactly 10 digits
        Return Regex.IsMatch(contact, "^\d{10}$")
    End Function

    Sub clear()
        TxtContact.Clear()
        TxtNewpassword.Clear()
        TxtOldpassword.Clear()
        TxtRenewpassword.Clear()
        TxtUsername.Clear()
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        TxtOldpassword.UseSystemPasswordChar = Not CheckBox1.Checked
    End Sub

    Private Sub CheckBox2_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox2.CheckedChanged
        TxtNewpassword.UseSystemPasswordChar = Not CheckBox2.Checked
    End Sub

    Private Sub BtnClear_Click(sender As Object, e As EventArgs) Handles BtnClear.Click
        clear()
    End Sub

    Private Sub BtnHome_Click_2(sender As Object, e As EventArgs) Handles BtnHome.Click
        Me.Hide()
        Dim obj As New UHomee
        obj.Show()
    End Sub

    Private Sub BtnCustomers_Click_1(sender As Object, e As EventArgs) Handles BtnCustomers.Click
        Me.Hide()
        Dim obj As New UCustomers
        obj.Show()
    End Sub

    Private Sub BtnRent_Click(sender As Object, e As EventArgs) Handles BtnRent.Click
        Me.Hide()
        Dim obj As New Rent
        obj.Show()
    End Sub

    Private Sub BtnCancel_Click(sender As Object, e As EventArgs) Handles BtnCancel.Click
        Me.Hide()
        Dim obj As New Cancel
        obj.Show()
    End Sub

    Private Sub BtnCheckout_Click(sender As Object, e As EventArgs) Handles BtnCheckout.Click
        Me.Hide()
        Dim obj As New CheckOut
        obj.Show()
    End Sub

    Private Sub BtnSettings_Click(sender As Object, e As EventArgs) Handles BtnSettings.Click
        Me.Hide()
        Dim obj As New Settings
        obj.Show()
    End Sub

    Private Sub BtnLogout_Click_1(sender As Object, e As EventArgs) Handles BtnLogout.Click
        Me.Hide()
        Dim obj As New Login
        obj.Show()
    End Sub
End Class