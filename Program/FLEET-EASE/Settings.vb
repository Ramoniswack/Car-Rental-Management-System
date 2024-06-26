
Imports System.Data.SqlClient

Public Class Settings
    ' Define connection string and SQL objects
    Private ConnectionString As String = "Data Source=DESKTOP-FE6OBHL\SQLEXPRESS;Initial Catalog=fleetease;Integrated Security=True;"
    Private cn As New SqlConnection(ConnectionString)
    Private cm As SqlCommand

    Private Sub Settings_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Dim loginform As Login = DirectCast(Application.OpenForms("Login"), Login)
            If loginform IsNot Nothing AndAlso Not String.IsNullOrEmpty(loginform.Loggedinusername) Then
                Login.Loggedinusername = loginform.Loggedinusername
                LblUsername.Text = $"{Login.Loggedinusername}"
            Else
                MessageBox.Show("Unable to retrieve logged-in username.")
                Return
            End If
            LoadUserInfo()
        Catch ex As Exception
            MessageBox.Show($"Error in Settings_Load: {ex.Message}")
        End Try
    End Sub


    Private Sub LoadUserInfo()
        Try
            cn.Open()
            cm = New SqlCommand("SELECT username, contact FROM tbllogin WHERE username = @username", cn)
            cm.Parameters.AddWithValue("@username", Login.Loggedinusername)

            Using dr As SqlDataReader = cm.ExecuteReader()
                If dr.Read() Then
                    TxtUsername.Text = dr("username").ToString()
                    TxtContact.Text = dr("contact").ToString()
                End If
            End Using
        Catch ex As Exception
            MessageBox.Show("Error loading user info: " & ex.Message)
        Finally
            cn.Close()
        End Try
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles BtnUpdate.Click
        If String.IsNullOrEmpty(TxtUsername.Text) OrElse String.IsNullOrEmpty(TxtOldpassword.Text) _
           OrElse String.IsNullOrEmpty(TxtNewpassword.Text) OrElse String.IsNullOrEmpty(TxtRenewpassword.Text) _
           OrElse String.IsNullOrEmpty(TxtContact.Text) Then
            MessageBox.Show("Please fill in all fields.")
            Return
        End If

        If TxtNewpassword.Text <> TxtRenewpassword.Text Then
            MessageBox.Show("New passwords do not match.")
            Return
        End If

        If TxtUsername.Text <> Login.Loggedinusername Then
            MessageBox.Show("Cannot change other user's information.")
            Return
        End If

        Try
            cn.Open()

            ' First, verify the old password
            cm = New SqlCommand("SELECT COUNT(*) FROM tbllogin WHERE username = @username AND password = @oldPassword", cn)
            cm.Parameters.AddWithValue("@username", Login.Loggedinusername)
            cm.Parameters.AddWithValue("@oldPassword", TxtOldpassword.Text)

            Dim count As Integer = CInt(cm.ExecuteScalar())

            If count = 0 Then
                MessageBox.Show("Old password is incorrect.")
                Return
            End If

            ' If old password is correct, proceed with update
            cm = New SqlCommand("UPDATE tbllogin SET username = @newUsername, password = @newPassword, contact = @newContact WHERE username = @currentUsername", cn)
            cm.Parameters.AddWithValue("@newUsername", TxtUsername.Text)
            cm.Parameters.AddWithValue("@newPassword", TxtNewpassword.Text)
            cm.Parameters.AddWithValue("@newContact", TxtContact.Text)
            cm.Parameters.AddWithValue("@currentUsername", Login.Loggedinusername)

            Dim rowsAffected As Integer = cm.ExecuteNonQuery()

            If rowsAffected > 0 Then
                MessageBox.Show("Information updated successfully.")
                Login.Loggedinusername = TxtUsername.Text  ' Update the logged-in username if it was changed
                LblUsername.Text = Login.Loggedinusername  ' Update the label
            Else
                MessageBox.Show("Failed to update information.")
            End If
        Catch ex As Exception
            MessageBox.Show("Error updating information: " & ex.Message)
        Finally
            cn.Close()
        End Try
        clear()
    End Sub

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

    Private Sub BtnHome_Click(sender As Object, e As EventArgs)
        Me.Hide()
        Dim obj As New UHomee
        obj.Show()

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs)
        Me.Hide()
        Dim obj As New UCustomers
        obj.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)
        Me.Hide()
        Dim obj As New Rent
        obj.Show()
    End Sub

    Private Sub BtnCustomers_Click(sender As Object, e As EventArgs)
        Me.Hide()
        Dim obj As New CheckOut
        obj.Show()
    End Sub

    Private Sub BtnLogout_Click(sender As Object, e As EventArgs)
        Me.Hide()
        Dim obj As New Login
        obj.Show()
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