Public Class Customers
    Sub LoadRecord()
        Try
            If cn.State = ConnectionState.Closed Then
                cn.Open()
            End If
            Dgv.Rows.Clear()
            Dim i As Integer

            cm = New SqlClient.SqlCommand("SELECT * FROM tblcustomers", cn)
            dr = cm.ExecuteReader
            While dr.Read
                i += 1
                Dgv.Rows.Add(i, dr.Item("CustomerName"), dr.Item("Contact"), dr.Item("Address"), dr.Item("LicenseID"))
            End While
        Catch ex As Exception
            MsgBox("An error occurred while loading records: " & ex.Message)
        Finally
            If cn.State = ConnectionState.Open Then
                cn.Close()
            End If
        End Try
    End Sub

    Private Sub BtnAddCustomer_Click(sender As Object, e As EventArgs) Handles BtnAddCustomer.Click
        If txtCustomerName.Text <> "" And TxtAddress.Text <> "" And TxtContact.Text <> "" And TxtLicecnseCode.Text <> "" Then
            Try
                If cn.State = ConnectionState.Closed Then
                    cn.Open()
                End If
                cm = New SqlClient.SqlCommand("INSERT INTO tblcustomers (CustomerName, Contact, Address, LicenseID) VALUES (@CustomerName, @Contact, @Address, @LicenseID)", cn)
                With cm
                    .Parameters.AddWithValue("@CustomerName", txtCustomerName.Text)
                    .Parameters.AddWithValue("@Contact", TxtContact.Text)
                    .Parameters.AddWithValue("@Address", TxtAddress.Text)
                    .Parameters.AddWithValue("@LicenseID", TxtLicecnseCode.Text)
                    .ExecuteNonQuery()
                End With
                MsgBox("Customer saved successfully")
            Catch ex As Exception
                MsgBox("An error occurred while adding the customer: " & ex.Message)
            Finally
                If cn.State = ConnectionState.Open Then
                    cn.Close()
                End If
            End Try
        Else
            MsgBox("Please fulfill all the requirements first")
        End If
        ClearFields()
        LoadRecord()
    End Sub

    Private Sub Customers_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim loginform As Login = DirectCast(Application.OpenForms("Login"), Login)
        If loginform IsNot Nothing Then
            LblUsername.Text = loginform.Loggedinusername
        End If
        LoadRecord()

        ' Set DataGridView properties
        Dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        Dgv.MultiSelect = False
    End Sub

    ' ... (other button click events remain the same) ...

    Private Sub BtnUpdate_Click(sender As Object, e As EventArgs) Handles BtnUpdate.Click
        If Dgv.SelectedCells.Count = 0 Then
            MsgBox("Please select a row to update.")
            Return
        End If

        Dim selectedRowIndex As Integer = Dgv.SelectedCells(0).RowIndex

        If txtCustomerName.Text = "" Or TxtAddress.Text = "" Or TxtContact.Text = "" Or TxtLicecnseCode.Text = "" Then
            MsgBox("Please fill in all the fields to update.")
            Return
        End If

        Try
            Dim CusIdValue As Integer = Convert.ToInt32(Dgv.Rows(selectedRowIndex).Cells(0).Value)
            If cn.State = ConnectionState.Closed Then
                cn.Open()
            End If
            cm = New SqlClient.SqlCommand("UPDATE tblcustomers SET CustomerName = @CustomerName, LicenseID = @LicenseID, Contact = @Contact, Address = @Address WHERE CusID = @CusID", cn)
            With cm
                .Parameters.AddWithValue("@CusID", CusIdValue)
                .Parameters.AddWithValue("@CustomerName", txtCustomerName.Text)
                .Parameters.AddWithValue("@LicenseID", TxtLicecnseCode.Text)
                .Parameters.AddWithValue("@Contact", TxtContact.Text)
                .Parameters.AddWithValue("@Address", TxtAddress.Text)
                .ExecuteNonQuery()
            End With
            MsgBox("Customer information updated successfully")
            LoadRecord()
        Catch ex As Exception
            MsgBox("An error occurred while updating the customer: " & ex.Message)
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
            txtCustomerName.Text = If(row.Cells(1).Value IsNot Nothing, row.Cells(1).Value.ToString(), "")
            TxtContact.Text = If(row.Cells(2).Value IsNot Nothing, row.Cells(2).Value.ToString(), "")
            TxtAddress.Text = If(row.Cells(3).Value IsNot Nothing, row.Cells(3).Value.ToString(), "")
            TxtLicecnseCode.Text = If(row.Cells(4).Value IsNot Nothing, row.Cells(4).Value.ToString(), "")
        End If
    End Sub

    Private Sub ClearFields()
        TxtLicecnseCode.Clear()
        TxtAddress.Clear()
        TxtContact.Clear()
        txtCustomerName.Clear()
        txtCustomerName.Select()
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

    Private Sub BtnUsers_Click(sender As Object, e As EventArgs)
        Me.Hide()
        Dim obj As New Users
        obj.Show()
    End Sub

    Private Sub BtnStatistics_Click(sender As Object, e As EventArgs)
        'Me.Hide()
        'Dim obj As New 
        'obj.Show()
    End Sub

    Private Sub BtnLogout_Click(sender As Object, e As EventArgs)
        Me.Hide()
        Dim obj As New Login
        obj.Show()
    End Sub

    Private Sub BtnCheckout_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub BtnCustomers_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub BtnCustomers_Click_1(sender As Object, e As EventArgs)

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

    Private Sub BtnUsers_Click_1(sender As Object, e As EventArgs)
        Me.Hide()
        Dim obj As New Users
        obj.Show()
    End Sub

    Private Sub Panel4_Paint(sender As Object, e As PaintEventArgs)

    End Sub

    Private Sub BtnCustomers_Click_2(sender As Object, e As EventArgs)

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

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles BtnCars.Click
        Me.Hide()
        Dim obj As New Cars
        obj.Show()
    End Sub

    Private Sub BtnUsers_Click_2(sender As Object, e As EventArgs) Handles BtnUsers.Click
        Me.Hide()
        Dim obj As New Users
        obj.Show()
    End Sub

    Private Sub BtnLogout_Click_2(sender As Object, e As EventArgs) Handles BtnLogout.Click
        Me.Hide()
        Dim obj As New Login
        obj.Show()
    End Sub

    Private Sub BtnCustomers_Click_3(sender As Object, e As EventArgs) Handles BtnCustomers.Click

    End Sub

    Private Sub BtnHome_Click_2(sender As Object, e As EventArgs) Handles BtnHome.Click
        Me.Hide()
        Dim obj As New Homee
        obj.Show()
    End Sub
End Class