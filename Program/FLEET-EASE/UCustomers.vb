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
    Private Sub BtnHome_Click(sender As Object, e As EventArgs)
        Me.Hide()
        Dim oBJ As New UHomee()
        oBJ.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)
        Me.Hide()
        Dim oBJ As New Rent()
        oBJ.Show()
    End Sub

    Private Sub BtnLogout_Click(sender As Object, e As EventArgs)
        Me.Hide()
        Dim oBJ As New Login
        oBJ.Show()
    End Sub



    Private Sub UCustomers_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Dim loginform As Login = DirectCast(Application.OpenForms("Login"), Login)
        'If loginform IsNot Nothing Then
        '    LblUsername.Text = loginform.LoggedInUsename

        'End If
        UpdateUsername()
        Loadrecord()
    End Sub
    Public Sub UpdateUsername()
        LblUsername.Text = Module1.LoggedInUsename
    End Sub
    Private Sub BtnAddCustomer_Click(sender As Object, e As EventArgs) Handles BtnAddCustomer.Click
        If txtCustomerName.Text = "" And TxtAddress.Text = "" And TxtContact.Text = "" And TxtLicecnseCode.Text = "" Then
            MsgBox("Please fulfill all the requirements first.")
        Else
            If ValidateInputs() Then
                If Not IsContactOrLicenseCodeDuplicate() Then
                    InsertCustomer()
                    ClearInputs()
                    Loadrecord()
                Else
                    MsgBox("This contact number or license code already exists in the database.")
                End If
            End If
        End If
        ClearInputs()
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
            cn.Open()
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
            cn.Open()
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

    Private Sub ClearInputs()
        TxtLicecnseCode.Clear()
        TxtAddress.Clear()
        TxtContact.Clear()
        txtCustomerName.Clear()
        txtCustomerName.Select()
    End Sub


    Private Sub BtnCancel_Click_1(sender As Object, e As EventArgs) Handles BtnCancel.Click
        Me.Hide()
        Dim oBJ As New Cancel
        oBJ.Show()
    End Sub

    Private Sub BtnHome_Click_1(sender As Object, e As EventArgs) Handles BtnHome.Click
        Me.Hide()
        Dim oBJ As New UHomee
        oBJ.Show()
    End Sub

    Private Sub BtnCustomers_Click(sender As Object, e As EventArgs) Handles BtnCustomers.Click
        Me.Hide()
        Dim oBJ As New UCustomers
        oBJ.Show()
    End Sub

    Private Sub BtnRent_Click(sender As Object, e As EventArgs) Handles BtnRent.Click
        Me.Hide()
        Dim oBJ As New Rent
        oBJ.Show()
    End Sub

    Private Sub BtnCheckout_Click(sender As Object, e As EventArgs) Handles BtnCheckout.Click
        Me.Hide()
        Dim oBJ As New CheckOut
        oBJ.Show()
    End Sub

    Private Sub BtnSettings_Click(sender As Object, e As EventArgs) Handles BtnSettings.Click
        Me.Hide()
        Dim oBJ As New Settings
        oBJ.Show()
    End Sub

    Private Sub BtnLogout_Click_1(sender As Object, e As EventArgs) Handles BtnLogout.Click
        Me.Hide()
        Dim oBJ As New Login
        oBJ.Show()
    End Sub
End Class