Imports System.Data.SqlClient

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
        If ValidateInputs() Then
            If Not IsContactOrLicenseCodeDuplicate() Then
                InsertCustomer()
                ClearFields()
                LoadRecord()
            Else
                MsgBox("This contact number or license code already exists in the database.")
            End If
        Else
            MsgBox("Please fulfill all the requirements first.")
        End If
        ClearFields()
    End Sub

    Private Function ValidateInputs() As Boolean
        ' Check if CustomerName starts with a capital letter
        If Not Char.IsUpper(txtCustomerName.Text.FirstOrDefault()) Then
            MsgBox("Customer name must start with a capital letter.")
            Return False
        End If

        ' Check if Contact has exactly 10 digits
        If Not (TxtContact.Text.Length = 10 AndAlso TxtContact.Text.All(AddressOf Char.IsDigit)) Then
            MsgBox("Contact must be exactly 10 digits.")
            Return False
        End If

        ' Check if Address starts with a capital letter
        If Not Char.IsUpper(TxtAddress.Text.FirstOrDefault()) Then
            MsgBox("Address must start with a capital letter.")
            Return False
        End If

        ' Check LicenseCode format (****-****-*********)
        Dim licensePattern As String = "^\d{1,4}-\d{1,4}-\d{1,9}$"
        If Not System.Text.RegularExpressions.Regex.IsMatch(TxtLicecnseCode.Text, licensePattern) Then
            MsgBox("License code must be in the format ****-****-*********, with at least one digit between hyphens.")
            Return False
        End If

        Return True
    End Function

    Private Function IsContactOrLicenseCodeDuplicate() As Boolean
        Try
            If cn.State = ConnectionState.Closed Then
                cn.Open()
            End If
            Dim query As String = "SELECT COUNT(*) FROM tblcustomers WHERE Contact = @Contact OR LicenseID = @LicenseID"
            cm = New SqlClient.SqlCommand(query, cn)
            cm.Parameters.AddWithValue("@Contact", TxtContact.Text)
            cm.Parameters.AddWithValue("@LicenseID", TxtLicecnseCode.Text)
            Dim count As Integer = CInt(cm.ExecuteScalar())
            Return count > 0
        Catch ex As Exception
            MsgBox("Error checking for duplicates: " & ex.Message)
            Return True ' Assume duplicate to be safe
        Finally
            If cn.State = ConnectionState.Open Then cn.Close()
        End Try
    End Function

    Private Sub InsertCustomer()
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
            MsgBox("Error saving customer: " & ex.Message)
        Finally
            If cn.State = ConnectionState.Open Then cn.Close()
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
            Dim CusIdValue As Integer = Convert.ToInt32(Dgv.Rows(selectedRowIndex).Cells(0).Value)

            If IsContactOrLicenseCodeDuplicateForUpdate(CusIdValue) Then
                MsgBox("This contact number or license code already exists for another customer.")
                Return
            End If

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

    Private Function IsContactOrLicenseCodeDuplicateForUpdate(cusId As Integer) As Boolean
        Try
            If cn.State = ConnectionState.Closed Then
                cn.Open()
            End If
            Dim query As String = "SELECT COUNT(*) FROM tblcustomers WHERE (Contact = @Contact OR LicenseID = @LicenseID) AND CusID <> @CusID"
            cm = New SqlClient.SqlCommand(query, cn)
            cm.Parameters.AddWithValue("@Contact", TxtContact.Text)
            cm.Parameters.AddWithValue("@LicenseID", TxtLicecnseCode.Text)
            cm.Parameters.AddWithValue("@CusID", cusId)
            Dim count As Integer = CInt(cm.ExecuteScalar())
            Return count > 0
        Catch ex As Exception
            MsgBox("Error checking for duplicates: " & ex.Message)
            Return True ' Assume duplicate to be safe
        Finally
            If cn.State = ConnectionState.Open Then cn.Close()
        End Try
    End Function

    Private Sub Customers_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Dim loginform As Login = DirectCast(Application.OpenForms("Login"), Login)
        'If loginform IsNot Nothing Then
        '    LblUsername.Text = loginform.LoggedInUsename
        'End If
        UpdateUsername()
        LoadRecord()

        ' Set DataGridView properties
        Dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        Dgv.MultiSelect = False
    End Sub
    Public Sub UpdateUsername()
        LblUsername.Text = Module1.LoggedInUsename
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

    Private Sub BtnUsers_Click(sender As Object, e As EventArgs) Handles BtnUsers.Click
        Me.Hide()
        Dim obj As New Users
        obj.Show()
    End Sub

    Private Sub BtnStats_Click(sender As Object, e As EventArgs) Handles BtnStats.Click
        Me.Hide()
        Dim obj As New Statistics
        obj.Show()
    End Sub

    Private Sub BtnLogout_Click(sender As Object, e As EventArgs) Handles BtnLogout.Click
        Me.Hide()
        Dim obj As New Login
        obj.Show()
    End Sub

    Private Sub BtnCustomers_Click(sender As Object, e As EventArgs) Handles BtnCustomers.Click
        ' This button is already on the Customers form, so we don't need to do anything here
    End Sub
End Class