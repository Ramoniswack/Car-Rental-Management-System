Public Class UCustomers


    Public Sub Loadrecord()
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
    Private Sub BtnHome_Click(sender As Object, e As EventArgs) Handles BtnHome.Click
        Me.Hide()
        Dim oBJ As New UHomee()
        oBJ.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
        Dim oBJ As New Rent
        oBJ.Show()
    End Sub

    Private Sub BtnLogout_Click(sender As Object, e As EventArgs) Handles BtnLogout.Click
        Me.Hide()
        Dim oBJ As New Login
        oBJ.Show()
    End Sub

    Private Sub Panel8_Paint(sender As Object, e As PaintEventArgs) Handles Panel8.Paint

    End Sub

    Private Sub UCustomers_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim loginform As Login = DirectCast(Application.OpenForms("Login"), Login)
        If loginform IsNot Nothing Then
            LblUsername.Text = loginform.loggedinusername

        End If
        Loadrecord()
    End Sub

    Private Sub BtnAddCustomer_Click(sender As Object, e As EventArgs) Handles BtnAddCustomer.Click
        If txtCustomerName.Text <> "" And TxtAddress.Text <> "" And TxtContact.Text <> "" And TxtLicecnseCode.Text <> "" Then


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
        Else
            MsgBox("Please Fullfill all the requirements first")
        End If
        TxtLicecnseCode.Clear()
        TxtAddress.Clear()
        TxtContact.Clear()

        txtCustomerName.Clear()
        txtCustomerName.Select()

        Loadrecord()
    End Sub

    Private Sub BtnCancel_Click(sender As Object, e As EventArgs) Handles BtnCancel.Click
        Me.Hide()
        Dim obj As New CheckOut
        obj.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        ' Assuming you have a variable or property named loggedInUsername in your form
        Me.Hide()
        Dim obj As New Settings
        obj.Show()
    End Sub
End Class