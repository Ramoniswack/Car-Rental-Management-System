Public Class Customers

    Sub LoadRecord()
        cn.Open()
        Dgv.Rows.Clear()
        Dim i As Integer

        cm = New SqlClient.SqlCommand("select *from tblcustomers", cn)
        dr = cm.ExecuteReader
        While dr.Read
            i = i + 1
            Dgv.Rows.Add(i, dr.Item("CustomerName"), dr.Item("Contact"), dr.Item("Address"), dr.Item("LicenseID"))

        End While


        cn.Close()
    End Sub

    Private Sub BtnAddCustomer_Click(sender As Object, e As EventArgs) Handles BtnAddCustomer.Click
        cn.Open()
        cm = New SqlClient.SqlCommand("INSERT INTO tblcustomers (CustomerName, Contact, Address,LicenseID) VALUES (@CustomerName, @Contact, @Address,@LicenseID)", cn)
        With cm
            .Parameters.AddWithValue("@CustomerName", txtCustomerName.Text)
            .Parameters.AddWithValue("@Contact", TxtContact.Text)
            .Parameters.AddWithValue("@Address", TxtAddress.Text)
            .Parameters.AddWithValue("@LicenseID", TxtLicecnseCode.Text)
            .ExecuteNonQuery()
            cn.Close()
        End With
        MsgBox("Customer saved successfully")

        TxtLicecnseCode.Clear()
        TxtAddress.Clear()
        TxtContact.Clear()

        txtCustomerName.Clear()
        txtCustomerName.Select()

        LoadRecord()
    End Sub



    Private Sub Customers_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadRecord()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles BtnCars.Click
        Me.Hide()
        Dim obj As New Cars
        obj.Show()
    End Sub

    Private Sub BtnHome_Click(sender As Object, e As EventArgs) Handles BtnHome.Click
        Me.Hide()
        Dim obj As New Homee
        obj.Show()
    End Sub

    Private Sub BtnUsers_Click(sender As Object, e As EventArgs) Handles BtnUsers.Click
        Me.Hide()
        Dim obj As New Users
        obj.Show()
    End Sub

    Private Sub BtnLogout_Click(sender As Object, e As EventArgs) Handles BtnLogout.Click
        Me.Hide()
        Dim obj As New Login
        obj.Show()
    End Sub
End Class

