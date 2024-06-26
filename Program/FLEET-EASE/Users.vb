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
        If TxtUsername.Text <> "" And TxtPasswword.Text <> "" And TxtUsertype.Text <> "" And TxtContact.Text <> "" Then
            Try
                If cn.State = ConnectionState.Closed Then
                    cn.Open()
                End If
                cm = New SqlClient.SqlCommand("INSERT INTO tbllogin (Username, Password, Usertype, Contact) VALUES (@Username, @Password, @Usertype, @Contact)", cn)
                With cm
                    .Parameters.AddWithValue("@Username", TxtUsername.Text)
                    .Parameters.AddWithValue("@Password", TxtPasswword.Text)
                    .Parameters.AddWithValue("@Usertype", TxtUsertype.Text)
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
        Else
            MsgBox("Fulfill all the requirements first")
        End If

        ClearFields()
        TxtUsername.Select()
        LoadRecord()
    End Sub

    Private Sub BtnHome_Click(sender As Object, e As EventArgs)
        Me.Hide()
        Dim obj As New Homee
        obj.Show()
    End Sub

    Private Sub BtnCars_Click(sender As Object, e As EventArgs)
        Me.Hide()
        Dim obj As New Cars
        obj.Show()
    End Sub

    Private Sub BtnCustomer_Click(sender As Object, e As EventArgs)
        Me.Hide()
        Dim obj As New Customers
        obj.Show()
    End Sub

    Private Sub BtnClear_Click(sender As Object, e As EventArgs) Handles BtnClear.Click
        ClearFields()
    End Sub

    Private Sub Users_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim loginform As Login = DirectCast(Application.OpenForms("Login"), Login)
        If loginform IsNot Nothing Then
            LblUsername.Text = loginform.Loggedinusername
        End If

        LoadRecord()

        ' Set DataGridView properties
        Dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        Dgv.MultiSelect = False
    End Sub

    Private Sub BtnLogout_Click(sender As Object, e As EventArgs)
        Me.Hide()
        Dim obj As New Login
        obj.Show()
    End Sub

    'UserId Value
    Dim UidValue As Integer = 0
    Private Sub BtnUpdate_Click(sender As Object, e As EventArgs) Handles BtnUpdate.Click
        Debug.WriteLine($"Selected Cells: {Dgv.SelectedCells.Count}, Selected Rows: {Dgv.SelectedRows.Count}")

        If Dgv.SelectedCells.Count = 0 Then
            MsgBox("Please select a row to update.")
            Return
        End If

        Dim selectedRowIndex As Integer = Dgv.SelectedCells(0).RowIndex
        Debug.WriteLine($"Selected Row Index: {selectedRowIndex}")

        If TxtUsername.Text = "" Or TxtPasswword.Text = "" Or TxtUsertype.Text = "" Or TxtContact.Text = "" Then
            MsgBox("Please fill in all the fields to update.")
            Return
        End If

        Try
            UidValue = Convert.ToInt32(Dgv.Rows(selectedRowIndex).Cells(0).Value)
            If cn.State = ConnectionState.Closed Then
                cn.Open()
            End If
            cm = New SqlClient.SqlCommand("UPDATE tbllogin SET username = @username, password = @password, usertype = @usertype, contact = @contact WHERE Uid = @Uid", cn)
            With cm
                .Parameters.AddWithValue("@Uid", UidValue)
                .Parameters.AddWithValue("@username", TxtUsername.Text)
                .Parameters.AddWithValue("@password", TxtPasswword.Text)
                .Parameters.AddWithValue("@usertype", TxtUsertype.Text)
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

    Private Sub Dgv_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles Dgv.CellClick
        If e.RowIndex >= 0 Then
            Dgv.Rows(e.RowIndex).Selected = True
            Dim row As DataGridViewRow = Dgv.Rows(e.RowIndex)
            TxtUsername.Text = If(row.Cells(1).Value IsNot Nothing, row.Cells(1).Value.ToString(), "")
            TxtPasswword.Text = If(row.Cells(2).Value IsNot Nothing, row.Cells(2).Value.ToString(), "")
            TxtUsertype.Text = If(row.Cells(3).Value IsNot Nothing, row.Cells(3).Value.ToString(), "")
            TxtContact.Text = If(row.Cells(4).Value IsNot Nothing, row.Cells(4).Value.ToString(), "")

            Debug.WriteLine($"Row clicked and selected: Username={TxtUsername.Text}, Usertype={TxtUsertype.Text}, Contact={TxtContact.Text}")
        End If

    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        TxtPasswword.UseSystemPasswordChar = Not CheckBox1.Checked
    End Sub

    Private Sub ClearFields()
        TxtContact.Clear()
        TxtUsertype.Clear()
        TxtUsername.Clear()
        TxtPasswword.Clear()
        TxtUsername.Select()
    End Sub

    Private Sub BtnHome_Click_1(sender As Object, e As EventArgs)
        Me.Hide()
        Dim obj As New Homee
        obj.Show()
    End Sub

    Private Sub Panel2_Paint(sender As Object, e As PaintEventArgs)

    End Sub

    Private Sub Panel7_Paint(sender As Object, e As PaintEventArgs)

    End Sub

    Private Sub Panel6_Paint(sender As Object, e As PaintEventArgs)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)
        Me.Hide()
        Dim obj As New Cars
        obj.Show()
    End Sub

    Private Sub Panel5_Paint(sender As Object, e As PaintEventArgs)

    End Sub

    Private Sub BtnUsers_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Panel4_Paint(sender As Object, e As PaintEventArgs)

    End Sub

    Private Sub BtnCustomers_Click(sender As Object, e As EventArgs)
        Me.Hide()
        Dim obj As New Customers
        obj.Show()
    End Sub

    Private Sub Panel3_Paint(sender As Object, e As PaintEventArgs)

    End Sub

    Private Sub BtnStats_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub BtnLogout_Click_1(sender As Object, e As EventArgs)
        Me.Hide()
        Dim obj As New Login
        obj.Show()
    End Sub

    Private Sub BtnCustomers_Click_1(sender As Object, e As EventArgs) Handles BtnCustomers.Click
        Me.Hide()
        Dim obj As New Customers
        obj.Show()
    End Sub

    Private Sub BtnHome_Click_2(sender As Object, e As EventArgs) Handles BtnHome.Click
        Me.Hide()
        Dim obj As New Homee
        obj.Show()
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles BtnCars.Click
        Me.Hide()
        Dim obj As New Cars
        obj.Show()
    End Sub

    Private Sub Panel7_Paint_1(sender As Object, e As PaintEventArgs) Handles Panel7.Paint

    End Sub

    Private Sub Panel6_Paint_1(sender As Object, e As PaintEventArgs) Handles Panel6.Paint

    End Sub

    Private Sub Panel5_Paint_1(sender As Object, e As PaintEventArgs) Handles Panel5.Paint

    End Sub

    Private Sub Panel4_Paint_1(sender As Object, e As PaintEventArgs) Handles Panel4.Paint

    End Sub

    Private Sub Panel3_Paint_1(sender As Object, e As PaintEventArgs) Handles Panel3.Paint

    End Sub

    Private Sub BtnLogout_Click_2(sender As Object, e As EventArgs) Handles BtnLogout.Click
        Me.Hide()
        Dim obj As New Login
        obj.Show()
    End Sub

    Private Sub BtnStats_Click_1(sender As Object, e As EventArgs) Handles BtnStats.Click
        Me.Hide()
        Dim obj As New Statistics
        obj.Show()
    End Sub

    Private Sub Panel2_Paint_1(sender As Object, e As PaintEventArgs) Handles Panel2.Paint

    End Sub

    Private Sub BtnUsers_Click_1(sender As Object, e As EventArgs) Handles BtnUsers.Click

    End Sub
End Class