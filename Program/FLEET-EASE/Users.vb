Imports System.Data.SqlClient
Imports System.IO
Imports System.Text.RegularExpressions

Public Class Users
    Private ConnectionString As String = "Data Source=DESKTOP-FE6OBHL\SQLEXPRESS;Initial Catalog=fleetease;Integrated Security=True;"
    Private cn As New SqlConnection(ConnectionString)
    Private cm As SqlCommand
    Private dr As SqlDataReader
    Private currentuid As Integer = -1

    Sub LoadRecord()
        Try
            If cn.State = ConnectionState.Closed Then
                cn.Open()
            End If
            Dgv.Rows.Clear()
            Dim i As Integer

            cm = New SqlClient.SqlCommand("SELECT * FROM tbllogin WHERE active = 1", cn)
            dr = cm.ExecuteReader
            While dr.Read
                i += 1
                Dgv.Rows.Add(dr.Item("Uid"), dr.Item("Username"), dr.Item("Password"), dr.Item("Usertype"), dr.Item("Contact"))
            End While

            ' Debugging
            Console.WriteLine($"Loaded {i} records")
        Catch ex As Exception
            MsgBox("An error occurred while loading records: " & ex.Message)
        Finally
            If cn.State = ConnectionState.Open Then
                cn.Close()
            End If
        End Try
    End Sub


    Private Sub BtnAddUser_Click(sender As Object, e As EventArgs) Handles BtnAddUser.Click
        If TxtContact.Text = "" And TxtPasswword.Text = "" And TxtUsername.Text = "" And TxtUsertype.Text = "" Then
            MsgBox("Please fulfill all the requirements first.")
        Else
            If ValidateInputs() Then
                If Not IsUsernameOrContactDuplicate() Then
                    InsertUser()
                    ClearFields()
                    LoadRecord()
                Else
                    MsgBox("This username or contact number already exists in the database.")
                End If
            End If
        End If
    End Sub

    Private Function ValidateInputs() As Boolean
        ' Check if Username starts with a capital letter
        If Not Char.IsUpper(TxtUsername.Text.FirstOrDefault()) Then
            MsgBox("Username must start with a capital letter.")
            Return False
        End If

        ' Check if Password is valid
        If Not IsValidPassword(TxtPasswword.Text) Then
            MsgBox("Password must be at least 8 characters long, contain at least one capital letter, one number, and one symbol.")
            Return False
        End If

        ' Check if Usertype is selected from ComboBox
        If TxtUsertype.SelectedIndex = -1 Then
            MsgBox("Please select a user type.")
            Return False
        End If

        ' Check if Contact has exactly 10 digits
        If Not IsValidContact(TxtContact.Text) Then
            MsgBox("Contact must be exactly 10 digits.")
            Return False
        End If

        Return True
    End Function

    Private Function IsValidPassword(password As String) As Boolean
        ' Check if password is at least 8 characters long, contains at least one capital letter, one number, and one symbol
        Dim regex As New Regex("^(?=.*[A-Z])(?=.*\d)(?=.*[^\da-zA-Z]).{8,}$")
        Return regex.IsMatch(password)
    End Function

    Private Function IsValidContact(contact As String) As Boolean
        ' Check if contact is exactly 10 digits
        Return Regex.IsMatch(contact, "^\d{10}$")
    End Function

    Private Function IsUsernameOrContactDuplicate() As Boolean
        Try
            If cn.State = ConnectionState.Closed Then
                cn.Open()
            End If
            Dim query As String = "SELECT COUNT(*) FROM tbllogin WHERE Username = @Username OR Contact = @Contact"
            cm = New SqlClient.SqlCommand(query, cn)
            cm.Parameters.AddWithValue("@Username", TxtUsername.Text)
            cm.Parameters.AddWithValue("@Contact", TxtContact.Text)
            Dim count As Integer = CInt(cm.ExecuteScalar())
            Return count > 0
        Catch ex As Exception
            MsgBox("Error checking for duplicates: " & ex.Message)
            Return True ' Assume duplicate to be safe
        Finally
            If cn.State = ConnectionState.Open Then cn.Close()
        End Try
    End Function

    Private Sub InsertUser()
        Try
            If cn.State = ConnectionState.Closed Then
                cn.Open()
            End If
            cm = New SqlClient.SqlCommand("INSERT INTO tbllogin (Username, Password, Usertype, Contact) VALUES (@Username, @Password, @Usertype, @Contact)", cn)
            With cm
                .Parameters.AddWithValue("@Username", TxtUsername.Text)
                .Parameters.AddWithValue("@Password", TxtPasswword.Text)
                .Parameters.AddWithValue("@Usertype", TxtUsertype.SelectedItem.ToString())
                .Parameters.AddWithValue("@Contact", TxtContact.Text)
                .ExecuteNonQuery()
            End With
            MsgBox("User saved successfully")
        Catch ex As Exception
            MsgBox("An error occurred while adding the user: " & ex.Message)
        Finally
            If cn.State = ConnectionState.Open Then
                cn.Close()
            End If
        End Try
    End Sub

    Private Sub BtnUpdate_Click(sender As Object, e As EventArgs) Handles BtnUpdate.Click
        If Dgv.SelectedCells.Count = 0 Then
            MsgBox("Please select a row to update.")
            Return
        End If

        Dim selectedRowIndex As Integer = Dgv.SelectedCells(0).RowIndex
        Dim UidValue As Integer = Convert.ToInt32(Dgv.Rows(selectedRowIndex).Cells(0).Value)

        If Not HasChangesFromDatabase(UidValue) Then
            MsgBox("No changes detected. Please update something first.")
            Return
        End If

        If Not ValidateInputs() Then
            Return
        End If

        Try
            If IsUsernameOrContactDuplicateForUpdate(UidValue) Then
                MsgBox("This username or contact number already exists for another user.")
                Return
            End If

            If cn.State = ConnectionState.Closed Then
                cn.Open()
            End If

            cm = New SqlClient.SqlCommand("UPDATE tbllogin SET username = @username, password = @password, usertype = @usertype, contact = @contact WHERE Uid = @Uid", cn)
            With cm
                .Parameters.AddWithValue("@Uid", UidValue)
                .Parameters.AddWithValue("@username", TxtUsername.Text)
                .Parameters.AddWithValue("@password", TxtPasswword.Text)
                .Parameters.AddWithValue("@usertype", TxtUsertype.SelectedItem.ToString())
                .Parameters.AddWithValue("@contact", TxtContact.Text)
                Dim rowsAffected As Integer = .ExecuteNonQuery()
                If rowsAffected > 0 Then
                    MsgBox("User information updated successfully")
                    LoadRecord()
                Else
                    MsgBox("No changes were made to the database.")
                End If
            End With
        Catch ex As Exception
            MsgBox("An error occurred while updating the user: " & ex.Message)
        Finally
            If cn.State = ConnectionState.Open Then
                cn.Close()
            End If
        End Try
        ClearFields()
    End Sub
    Private Function IsUsernameOrContactDuplicateForUpdate(uid As Integer) As Boolean
        Try
            If cn.State = ConnectionState.Closed Then
                cn.Open()
            End If

            ' Check for duplicates, excluding the current user
            Dim query As String = "SELECT COUNT(*) FROM tbllogin WHERE (Username = @Username OR Contact = @Contact) AND Uid <> @Uid AND active = 1"
            cm = New SqlClient.SqlCommand(query, cn)
            cm.Parameters.AddWithValue("@Username", TxtUsername.Text)
            cm.Parameters.AddWithValue("@Contact", TxtContact.Text)
            cm.Parameters.AddWithValue("@Uid", uid)

            Dim count As Integer = CInt(cm.ExecuteScalar())

            ' Debugging
            Console.WriteLine($"Duplicate check: Username={TxtUsername.Text}, Contact={TxtContact.Text}, Uid={uid}, Count={count}")

            Return count > 0
        Catch ex As Exception
            MsgBox("Error checking for duplicates: " & ex.Message)
            Return True ' Assume duplicate to be safe
        Finally
            If cn.State = ConnectionState.Open Then cn.Close()
        End Try
    End Function

    Private Sub Users_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Dim loginform As Login = DirectCast(Application.OpenForms("Login"), Login)
        'If loginform IsNot Nothing Then
        '    LblUsername.Text = loginform.LoggedInUsename
        'End If
        UpdateUsername()
        LoadRecord()

        ' Set DataGridView properties
        Dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        Dgv.MultiSelect = False

        ' Populate TxtUsertype ComboBox
        ' TxtUsertype.Items.AddRange({"Admin", "User"})
    End Sub
    Public Sub UpdateUsername()
        LblUsername.Text = Module1.LoggedInUsename
    End Sub
    Private Sub Dgv_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles Dgv.CellClick
        If e.RowIndex >= 0 Then
            Dgv.Rows(e.RowIndex).Selected = True
            Dim row As DataGridViewRow = Dgv.Rows(e.RowIndex)

            ' Use column indices instead of names
            ' Adjust these indices based on the actual order of your columns
            currentuid = Convert.ToInt32(row.Cells(0).Value)  ' Assuming Uid is in the first column
            TxtUsername.Text = If(row.Cells(1).Value IsNot Nothing, row.Cells(1).Value.ToString(), "")
            TxtPasswword.Text = If(row.Cells(2).Value IsNot Nothing, row.Cells(2).Value.ToString(), "")
            TxtUsertype.Text = If(row.Cells(3).Value IsNot Nothing, row.Cells(3).Value.ToString(), "")
            TxtContact.Text = If(row.Cells(4).Value IsNot Nothing, row.Cells(4).Value.ToString(), "")

            ' Debugging
            Console.WriteLine($"Selected User: Uid={currentuid}, Username={TxtUsername.Text}, Contact={TxtContact.Text}")
        End If
    End Sub
    Private Function HasChangesFromDatabase(uid As Integer) As Boolean
        Try
            If cn.State = ConnectionState.Closed Then
                cn.Open()
            End If

            cm = New SqlClient.SqlCommand("SELECT Username, Password, Usertype, Contact FROM tbllogin WHERE Uid = @Uid", cn)
            cm.Parameters.AddWithValue("@Uid", uid)

            Using dr As SqlDataReader = cm.ExecuteReader()
                If dr.Read() Then
                    Return TxtUsername.Text <> dr("Username").ToString() OrElse
                       TxtPasswword.Text <> dr("Password").ToString() OrElse
                       TxtUsertype.SelectedItem.ToString() <> dr("Usertype").ToString() OrElse
                       TxtContact.Text <> dr("Contact").ToString()
                End If
            End Using

            Return False ' If no record found, assume no changes
        Catch ex As Exception
            MsgBox("Error checking for changes: " & ex.Message)
            Return False ' Assume no changes in case of error
        Finally
            If cn.State = ConnectionState.Open Then cn.Close()
        End Try
    End Function




    Private Sub ClearFields()
        TxtContact.Clear()
        TxtUsertype.SelectedIndex = -1
        TxtUsername.Clear()
        TxtPasswword.Clear()
        TxtUsername.Select()
    End Sub

    Private Sub BtnClear_Click(sender As Object, e As EventArgs) Handles BtnClear.Click
        ClearFields()
    End Sub

    Private Sub BtnHome_Click(sender As Object, e As EventArgs) Handles BtnHome.Click
        Me.Hide()
        Dim obj As New Homee
        obj.Show()
    End Sub

    Private Sub BtnCars_Click(sender As Object, e As EventArgs) Handles BtnCars.Click
        Me.Hide()
        Dim obj As New Cars
        obj.Show()
    End Sub

    Private Sub BtnCustomers_Click(sender As Object, e As EventArgs) Handles BtnCustomers.Click
        Me.Hide()
        Dim obj As New Customers
        obj.Show()
    End Sub

    Private Sub BtnStats_Click(sender As Object, e As EventArgs) Handles BtnStats.Click
        Me.Hide()
        Dim obj As New Statistics
        obj.Show()
    End Sub

    Private Sub BtnLogout_Click(sender As Object, e As EventArgs) Handles BtnLogout.Click
        LoggedInUsename = ""
        Me.Hide()
        Dim obj As New Login
        obj.Show()
    End Sub



    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        TxtPasswword.UseSystemPasswordChar = Not CheckBox1.Checked

    End Sub

    Private Sub BtnDelete_Click(sender As Object, e As EventArgs) Handles BtnDelete.Click
        Try
            If Dgv.SelectedRows.Count = 0 Then
                MsgBox("Please select a user to disable.")
                Return
            End If

            Dim selectedRow As DataGridViewRow = Dgv.SelectedRows(0)

            ' Get the Uid (assuming it's in the first column)
            Dim uid As Integer = Convert.ToInt32(selectedRow.Cells(0).Value)

            ' Get the username (assuming it's in the second column)
            Dim username As String = selectedRow.Cells(1).Value.ToString()

            Dim result As DialogResult = MessageBox.Show($"Are you sure you want to disable the user: {username}?", "Confirm Disable", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

            If result = DialogResult.Yes Then
                If cn.State = ConnectionState.Closed Then
                    cn.Open()
                End If

                ' Update the SQL command to set IsActive to 0
                cm = New SqlClient.SqlCommand("UPDATE tbllogin SET active = 0 WHERE Uid = @Uid", cn)
                cm.Parameters.AddWithValue("@Uid", uid)
                cm.ExecuteNonQuery()

                MsgBox($"User '{username}' has been disabled successfully.")
                LoadRecord()
                ClearFields()
            End If
        Catch ex As Exception
            MsgBox("An error occurred while disabling the user: " & ex.Message)
        Finally
            If cn.State = ConnectionState.Open Then
                cn.Close()
            End If
        End Try
    End Sub
End Class