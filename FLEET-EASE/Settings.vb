Imports System.Data.SqlClient

Public Class Settings
    Private Sub BtnHome_Click(sender As Object, e As EventArgs) Handles BtnHome.Click
        Me.Hide()
        Dim obj As New Homee
        obj.Show()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Hide()
        Dim obj As New Customers
        obj.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
        Dim obj As New Rent
        obj.Show()
    End Sub

    Private Sub BtnCustomers_Click(sender As Object, e As EventArgs) Handles BtnCustomers.Click
        Me.Hide()
        Dim obj As New CheckOut
        obj.Show()
    End Sub

    Private Sub BtnLogout_Click(sender As Object, e As EventArgs) Handles BtnLogout.Click
        Me.Hide()
        Dim obj As New Login
        obj.Show()
    End Sub

    Private Sub BtnClear_Click(sender As Object, e As EventArgs) Handles BtnClear.Click
        clear()
    End Sub

    Sub clear()
        TxtContact.Clear()
        TxtNewpassword.Clear()
        TxtOldpassword.Clear()
        TxtRenewpassword.Clear()
        TxtUsername.Clear()
    End Sub

    Private Sub BtnUpdate_Click(sender As Object, e As EventArgs) Handles BtnUpdate.Click
        ' Get the entered values from the textboxes
        Dim newUsername As String = TxtUsername.Text
        Dim oldPassword As String = TxtOldpassword.Text
        Dim newPassword As String = TxtNewpassword.Text
        Dim confirmPassword As String = TxtRenewpassword.Text
        Dim newContact As String = TxtContact.Text

        ' Validate the entered data
        If String.IsNullOrEmpty(newUsername) OrElse String.IsNullOrEmpty(oldPassword) OrElse String.IsNullOrEmpty(newPassword) OrElse String.IsNullOrEmpty(confirmPassword) OrElse String.IsNullOrEmpty(newContact) Then
            MessageBox.Show("Please fill in all the required fields.")
            Return
        End If

        If newPassword <> confirmPassword Then
            MessageBox.Show("New password and confirm password do not match.")
            Return
        End If

        ' Get the logged-in user's information
        Dim loginform As Login = DirectCast(Application.OpenForms("Login"), Login)
        Dim loggedInUsername As String = loginform.Loggedinusername

        ' Check if the logged-in user is of type "user"
        Dim checkUserTypeQuery As String = "SELECT UserType FROM tbllogin WHERE Username = @Username"
        Dim checkUserTypeCmd As New SqlCommand(checkUserTypeQuery, cn)
        checkUserTypeCmd.Parameters.AddWithValue("@Username", loggedInUsername)

        cn.Open()
        Dim loggedInUserType As String = checkUserTypeCmd.ExecuteScalar().ToString()
        cn.Close()

        If loggedInUserType.ToLower() = "admin" Then
            MessageBox.Show("Cannot change admin's details.")
            Return
        ElseIf loggedInUserType.ToLower() <> "user" Then
            MessageBox.Show("Only users are allowed to change their details.")
            Return
        End If

        ' Check if the old password matches the stored password for the logged-in user
        Dim checkPasswordQuery As String = "SELECT Password FROM tbllogin WHERE Username = @Username"
        Dim checkPasswordCmd As New SqlCommand(checkPasswordQuery, cn)
        checkPasswordCmd.Parameters.AddWithValue("@Username", loggedInUsername)

        cn.Open()
        Dim storedPassword As String = checkPasswordCmd.ExecuteScalar().ToString()
        cn.Close()

        If storedPassword.ToLower() <> oldPassword.ToLower() Then
            MessageBox.Show("Incorrect old password.")
            Return
        End If

        ' Update the user's details in the database
        Dim updateQuery As String = "UPDATE tbllogin SET Username = @NewUsername, Password = @NewPassword, Contact = @NewContact WHERE Username = @OldUsername AND UserType = 'user'"
        Dim updateCmd As New SqlCommand(updateQuery, cn)
        updateCmd.Parameters.AddWithValue("@NewUsername", newUsername)
        updateCmd.Parameters.AddWithValue("@NewPassword", newPassword)
        updateCmd.Parameters.AddWithValue("@NewContact", newContact)
        updateCmd.Parameters.AddWithValue("@OldUsername", loggedInUsername)

        cn.Open()
        Dim rowsAffected As Integer = updateCmd.ExecuteNonQuery()
        cn.Close()

        If rowsAffected > 0 Then
            MessageBox.Show("Details updated successfully.")
            ' Update the logged-in user's information in the Login form
            loginform.Loggedinusername = newUsername
        Else
            MessageBox.Show("An error occurred while updating the details.")
        End If
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked = True Then
            TxtOldpassword.UseSystemPasswordChar = False
        Else
            TxtOldpassword.UseSystemPasswordChar = True
        End If
    End Sub

    Private Sub CheckBox2_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox2.CheckedChanged
        If CheckBox1.Checked = True Then
            TxtNewpassword.UseSystemPasswordChar = False
        Else
            TxtNewpassword.UseSystemPasswordChar = True
        End If
    End Sub
End Class