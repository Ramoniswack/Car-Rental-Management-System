Imports System.Data.SqlClient

Public Class Users
    Sub LoadRecord()
        Try
            If cn.State = ConnectionState.Closed Then
                cn.Open()
            End If
            Dgv.Rows.Clear()
            Dim i As Integer

            cm = New SqlClient.SqlCommand("select * from tbllogin", cn)
            dr = cm.ExecuteReader
            While dr.Read
                i = i + 1
                Dgv.Rows.Add(i, dr.Item("Username"), dr.Item("Password"), dr.Item("Usertype"), dr.Item("Contact"))
            End While
        Catch ex As Exception
            MsgBox("An error occurred while loading records: " & ex.Message)
        Finally
            If cn.State = ConnectionState.Open Then
                cn.Close()
            End If
        End Try
    End Sub

    Private Sub BtnAddUser_Click(sender As Object, e As EventArgs) Handles BtnAddUser.Click
        If ValidateInputs() Then
            If Not IsUsernameOrContactDuplicate() Then
                InsertUser()
                ClearFields()
                LoadRecord()
            Else
                MsgBox("This username or contact number already exists in the database.")
            End If
        Else
            MsgBox("Please fulfill all the requirements first.")
        End If
    End Sub

    Private Function ValidateInputs() As Boolean
        ' Check if Username starts with a capital letter
        If Not Char.IsUpper(TxtUsername.Text.FirstOrDefault()) Then
            MsgBox("Username must start with a capital letter.")
            Return False
        End If

        ' Check if Password starts with a capital letter
        If Not Char.IsUpper(TxtPasswword.Text.FirstOrDefault()) Then
            MsgBox("Password must start with a capital letter.")
            Return False
        End If

        ' Check if Usertype is selected from ComboBox
        If TxtUsertype.SelectedIndex = -1 Then
            MsgBox("Please select a user type.")
            Return False
        End If

        ' Check if Contact has exactly 10 digits
        If Not (TxtContact.Text.Length = 10 AndAlso TxtContact.Text.All(AddressOf Char.IsDigit)) Then
            MsgBox("Contact must be exactly 10 digits.")
            Return False
        End If

        Return True
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

        If Not ValidateInputs() Then
            Return
        End If

        Try
            Dim UidValue As Integer = Convert.ToInt32(Dgv.Rows(selectedRowIndex).Cells(0).Value)

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
                .ExecuteNonQuery()
            End With
            MsgBox("User updated successfully")
            LoadRecord()
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
            Dim query As String = "SELECT COUNT(*) FROM tbllogin WHERE (Username = @Username OR Contact = @Contact) AND Uid <> @Uid"
            cm = New SqlClient.SqlCommand(query, cn)
            cm.Parameters.AddWithValue("@Username", TxtUsername.Text)
            cm.Parameters.AddWithValue("@Contact", TxtContact.Text)
            cm.Parameters.AddWithValue("@Uid", uid)
            Dim count As Integer = CInt(cm.ExecuteScalar())
            Return count > 0
        Catch ex As Exception
            MsgBox("Error checking for duplicates: " & ex.Message)
            Return True ' Assume duplicate to be safe
        Finally
            If cn.State = ConnectionState.Open Then cn.Close()
        End Try
    End Function

    Private Sub Users_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim loginform As Login = DirectCast(Application.OpenForms("Login"), Login)
        If loginform IsNot Nothing Then
            LblUsername.Text = loginform.Loggedinusername
        End If

        LoadRecord()

        ' Set DataGridView properties
        Dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        Dgv.MultiSelect = False

        ' Populate TxtUsertype ComboBox
        TxtUsertype.Items.AddRange({"Admin", "User"})
    End Sub

    Private Sub Dgv_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles Dgv.CellClick
        If e.RowIndex >= 0 Then
            Dgv.Rows(e.RowIndex).Selected = True
            Dim row As DataGridViewRow = Dgv.Rows(e.RowIndex)
            TxtUsername.Text = If(row.Cells(1).Value IsNot Nothing, row.Cells(1).Value.ToString(), "")
            TxtPasswword.Text = If(row.Cells(2).Value IsNot Nothing, row.Cells(2).Value.ToString(), "")
            TxtUsertype.SelectedItem = If(row.Cells(3).Value IsNot Nothing, row.Cells(3).Value.ToString(), "")
            TxtContact.Text = If(row.Cells(4).Value IsNot Nothing, row.Cells(4).Value.ToString(), "")
        End If
    End Sub

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

    ' Other event handlers remain the same...

End Class