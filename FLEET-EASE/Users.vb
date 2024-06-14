Public Class Users
    Sub LoadRecord()
        cn.Open()
        Dgv.Rows.Clear()
        Dim i As Integer

        cm = New SqlClient.SqlCommand("select *from tbllogin", cn)
        dr = cm.ExecuteReader
        While dr.Read
            i = i + 1
            Dgv.Rows.Add(i, dr.Item("Username"), dr.Item("Password"), dr.Item("Usertype"), dr.Item("Contact"))

        End While


        cn.Close()
    End Sub
    Private Sub BtnAddUser_Click(sender As Object, e As EventArgs) Handles BtnAddUser.Click
        If TxtUsername.Text <> "" And TxtPasswword.Text <> "" And TxtUsertype.Text <> "" And TxtContact.Text <> "" Then


            cn.Open()
            cm = New SqlClient.SqlCommand("INSERT INTO tbllogin (Username, Password, Usertype, Contact) VALUES (@Username, @Password, @Usertype, @Contact)", cn)
            With cm
                .Parameters.AddWithValue("@Username", TxtUsername.Text)
                .Parameters.AddWithValue("@Password", TxtPasswword.Text)
                .Parameters.AddWithValue("@Usertype", TxtUsertype.Text)
                .Parameters.AddWithValue("@Contact", TxtContact.Text)
                .ExecuteNonQuery()
                cn.Close()
            End With
            MsgBox("User saved successfully")

        Else
            MsgBox("Fulfill all the requirements first")
        End If

        TxtContact.Clear()
        TxtUsertype.Clear()
        TxtUsername.Clear()
        TxtPasswword.Clear()
        TxtUsername.Select()

        LoadRecord()
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

    Private Sub BtnCustomer_Click(sender As Object, e As EventArgs) Handles BtnCustomer.Click
        Me.Hide()
        Dim obj As New Customers
        obj.Show()
    End Sub

    Private Sub BtnClear_Click(sender As Object, e As EventArgs) Handles BtnClear.Click
        TxtContact.Clear()
        TxtUsertype.Clear()
        TxtUsername.Clear()
        TxtPasswword.Clear()
        TxtUsername.Select()
    End Sub

    Private Sub Users_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadRecord()
    End Sub

    Private Sub BtnLogout_Click(sender As Object, e As EventArgs) Handles BtnLogout.Click
        Me.Hide()
        Dim obj As New Login
        obj.Show()
    End Sub

    Private Sub BtnUpdate_Click(sender As Object, e As EventArgs) Handles BtnUpdate.Click

        If TxtUsername.Text <> "" And TxtPasswword.Text <> "" And TxtUsertype.Text <> "" And TxtContact.Text <> "" Then
            Dim selectedRowIndex As Integer = Dgv.SelectedCells(0).RowIndex
            Dim UidValue As Integer = Convert.ToInt32(Dgv.Rows(selectedRowIndex).Cells(0).Value)
            cn.Open()
            cm = New SqlClient.SqlCommand("Update tbllogin SET username = @username, password = @password, usertype = @usertype, contact = @contact where Uid = @Uid", cn)
            With cm
                .Parameters.AddWithValue("@Uid", UidValue)
                .Parameters.AddWithValue("@username", TxtUsername.Text)
                .Parameters.AddWithValue("@password", TxtPasswword.Text)
                .Parameters.AddWithValue("@usertype", TxtUsertype.Text)
                .Parameters.AddWithValue("@contact", TxtContact.Text)
                .ExecuteNonQuery()
                cn.Close()
            End With
            MsgBox("User updated successfully")
            LoadRecord()
        Else
            MsgBox("Please FullFill the requirements to Update")

        End If

    End Sub

    Private Sub Dgv_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles Dgv.CellClick

        If e.RowIndex >= 0 Then
            Dim row As DataGridViewRow = Dgv.Rows(e.RowIndex)
            ' TxtCusid .Text = row.Cells(0).Value.ToString()
            TxtUsername.Text = row.Cells(1).Value.ToString()
            TxtPasswword.Text = row.Cells(2).Value.ToString()
            TxtUsertype.Text = row.Cells(3).Value.ToString()
            TxtContact.Text = row.Cells(4).Value.ToString()
        End If


    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked = True Then
            TxtPasswword.UseSystemPasswordChar = False
        Else
            TxtPasswword.UseSystemPasswordChar = True
        End If
    End Sub
End Class