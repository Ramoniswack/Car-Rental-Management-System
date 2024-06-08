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
        MsgBox("Customer saved successfully")

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
End Class