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

        LoadRecord()
    End Sub



    Private Sub Customers_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim loginform As Login = DirectCast(Application.OpenForms("Login"), Login)
        If loginform IsNot Nothing Then
            LblUsername.Text = loginform.loggedinusername

        End If
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

    Private Sub BtnUpdate_Click(sender As Object, e As EventArgs) Handles BtnUpdate.Click


        Dim CusIdValue As Integer = 0

        If Dgv.SelectedRows.Count > 0 AndAlso txtCustomerName.Text <> "" And TxtAddress.Text <> "" And TxtContact.Text <> "" And TxtLicecnseCode.Text <> "" Then
            Dim selectedRowIndex As Integer = Dgv.SelectedCells(0).RowIndex
            CusIdValue = Convert.ToInt32(Dgv.Rows(selectedRowIndex).Cells(0).Value)
            cn.Open()
            cm = New SqlClient.SqlCommand("Update tblcustomers SET Customername= @CustomerName, Licenseid= @licenseid, contact= @contact, address= @address where Cusid = @Cusid ", cn)
            With cm
                .Parameters.AddWithValue("@CusID", CusIdValue)
                .Parameters.AddWithValue("@Customername", txtCustomerName.Text)
                .Parameters.AddWithValue("@Licenseid", TxtLicecnseCode.Text)
                .Parameters.AddWithValue("@contact", TxtContact.Text)
                .Parameters.AddWithValue("@address", TxtAddress.Text)
                .ExecuteNonQuery()
                cn.Close()
            End With
            MsgBox("Customer information updated successfully")
            LoadRecord()
        Else
            MsgBox("Please Fullfill the requirements to Update")
                End If




    End Sub

    Private Sub Dgv_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles Dgv.CellClick
        If e.RowIndex >= 0 Then
            Dim row As DataGridViewRow = Dgv.Rows(e.RowIndex)
            ' TxtCarID.Text = row.Cells(0).Value.ToString()
            txtCustomerName.Text = row.Cells(1).Value.ToString()
            TxtAddress.Text = row.Cells(2).Value.ToString()
            TxtContact.Text = row.Cells(3).Value.ToString()
            TxtLicecnseCode.Text = row.Cells(4).Value.ToString()
        End If

    End Sub
End Class

