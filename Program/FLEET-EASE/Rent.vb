﻿Imports System.Data.SqlClient
Imports System.Text.RegularExpressions

Public Class Rent


    Public Sub LoadRecord1()
        Try
            If cn.State = ConnectionState.Open Then
                cn.Close()
            End If
            cn.Open()
            Dgv.Rows.Clear()
            Dim i As Integer = 0
            cm = New SqlClient.SqlCommand("SELECT * FROM tblcars ", cn)
            Using dr As SqlDataReader = cm.ExecuteReader()
                While dr.Read()
                    i += 1
                    Dgv.Rows.Add(dr.Item("CarID"), dr.Item("Carname"), dr.Item("Model"), dr.Item("Color"), dr.Item("RegNumber"), dr.Item("Available"))
                End While
            End Using
        Catch ex As Exception
            MessageBox.Show("An error occurred while loading records: " & ex.Message)
        Finally
            If cn.State = ConnectionState.Open Then
                cn.Close()
            End If
        End Try
    End Sub



    Public Sub Loadrecord()
        cn.Open()
        Dgv1.Rows.Clear()
        Dim i As Integer

        cm = New SqlClient.SqlCommand("select *from tblcustomers", cn)
        dr = cm.ExecuteReader
        While dr.Read
            i = i + 1
            Dgv1.Rows.Add(i, dr.Item("CustomerName"), dr.Item("Contact"), dr.Item("Address"), dr.Item("LicenseID"))

        End While

        cn.Close()


    End Sub

    Private Sub LoadAvailableCars()
        'Try
        '    cn.Open()
        '    Dim query As String = "SELECT RegNumber, CarName FROM tblcars WHERE Available = 'YES'"
        '    Dim cmd As New SqlCommand(query, cn)
        '    Dim adapter As New SqlDataAdapter(cmd)
        '    Dim dt As New DataTable()
        '    adapter.Fill(dt)

        '    TxtRegNum.DataSource = dt
        '    TxtRegNum.DisplayMember = "RegNumber"
        '    TxtRegNum.ValueMember = "RegNumber"

        '    ' Set the format string to display both RegNumber and CarName
        '    TxtRegNum.FormatString = "{0} - {1}"
        '    TxtRegNum.FormattingEnabled = True

        'Catch ex As Exception
        '    MessageBox.Show("Error loading available cars: " & ex.Message)
        'Finally
        '    cn.Close()
        'End Try
    End Sub

    Private Sub Dgv_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles Dgv.CellClick
        If e.RowIndex >= 0 Then
            ' Debug: Print all column names and indices
            For i As Integer = 0 To Dgv.Columns.Count - 1
                Console.WriteLine($"Column {i}: {Dgv.Columns(i).Name}")
            Next

            Dim selectedRow As DataGridViewRow = Dgv.Rows(e.RowIndex)

            ' Assuming RegNumber is the 5th column (index 4), adjust if necessary
            Dim regNumber As String = selectedRow.Cells(4).Value.ToString()

            Console.WriteLine($"Selected RegNumber: {regNumber}")
            TxtRegNum.Text = regNumber
            '    ' If TxtRegNum is a ComboBox
            '    Dim index As Integer = TxtRegNum.FindStringExact(regNumber)
            '    If index <> -1 Then
            '        TxtRegNum.SelectedIndex = index
            '    Else
            '        ' If it's not found in the ComboBox, just set the text
            '        TxtRegnum.Text = regNumber
            '    End If
        End If
    End Sub
    Private Sub Dgv1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles Dgv1.CellClick
        If e.RowIndex >= 0 Then
            ' Debug: Print all column names and indices
            For i As Integer = 0 To Dgv1.Columns.Count - 1
                Console.WriteLine($"Column {i}: {Dgv1.Columns(i).Name}")
            Next

            Dim selectedRow As DataGridViewRow = Dgv1.Rows(e.RowIndex)

            ' Adjust these indices based on the debug output
            TxtCusid.Text = selectedRow.Cells(0).Value.ToString()
            Txtcusname.Text = selectedRow.Cells(1).Value.ToString()

            Console.WriteLine($"Selected CusID: {TxtCusid.Text}")
            Console.WriteLine($"Selected CustomerName: {Txtcusname.Text}")
        End If
    End Sub

    Private Sub FormatComboBoxItem(sender As Object, e As ListControlConvertEventArgs)
        Dim row As DataRowView = DirectCast(e.ListItem, DataRowView)
        e.Value = $"{row("RegNumber")} - {row("CarName")}"
    End Sub
    Private Sub Rentvehicle()

        ' Check if every details are entered
        If String.IsNullOrWhiteSpace(TxtRegNum.Text) OrElse
   String.IsNullOrWhiteSpace(TxtCusid.Text) OrElse
   String.IsNullOrWhiteSpace(Txtcusname.Text) OrElse
   String.IsNullOrWhiteSpace(TxtPickupfrom.Text) OrElse
   String.IsNullOrWhiteSpace(TxtCharges.Text) Then
            MessageBox.Show("Please fill in all required fields.", "Missing Information", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        ' Store the initial value immediately when the method is called
        Dim initialOdometerValue As Integer = CInt(TxtCheckoutOdometer.Value)
        Console.WriteLine("Initial Checkout Odometer Value: " & initialOdometerValue)

        Dim regNumber As String = TxtRegNum.Text.ToUpper()
        Dim cusID As String = TxtCusid.Text
        Dim customername As String = Txtcusname.Text
        Dim pickupLocation As String = CapitalizeFirstLetter(TxtPickupfrom.Text)
        Dim rentDate As Date = TxtRentDate.Value.Date
        Dim returnDate As Date = TxtReturnDate.Value.Date
        Dim charges As String = TxtCharges.Text

        ' Validate registration number format
        If Not IsValidRegNumber(regNumber) Then
            MessageBox.Show("Invalid registration number format. Please use the format: ZZ00X0000 (e.g., BA20B2080)")
            Return
        End If

        ' Right before using the value, check if it has changed
        If CInt(TxtCheckoutOdometer.Value) <> initialOdometerValue Then
            Console.WriteLine("Warning: Odometer value changed unexpectedly. Using original value.")
            TxtCheckoutOdometer.Value = initialOdometerValue
        End If

        Dim checkoutOdometer As Integer = CInt(TxtCheckoutOdometer.Value)
        Console.WriteLine("Final Checkout Odometer Value: " & checkoutOdometer)

        Dim customerQuery As String = "SELECT COUNT(*) FROM tblcustomers WHERE cusid = @cusid AND customername = @customername"
        Dim customerCmd As New SqlCommand(customerQuery, cn)
        customerCmd.Parameters.AddWithValue("@cusid", cusID)
        customerCmd.Parameters.AddWithValue("@customername", customername)

        cn.Open()
        Dim customerCount As Integer = CInt(customerCmd.ExecuteScalar())
        cn.Close()

        If customerCount = 0 Then
            MessageBox.Show("Invalid Customer ID or Customer Name. Please check the details.")
            Return
        End If

        Dim carQuery As String = "SELECT CarID, Available FROM tblcars WHERE RegNumber = @RegNumber"
        Dim carCmd As New SqlCommand(carQuery, cn)
        carCmd.Parameters.AddWithValue("@RegNumber", regNumber)

        cn.Open()
        Dim reader As SqlDataReader = carCmd.ExecuteReader()

        If reader.HasRows Then
            reader.Read()
            Dim carID As Integer = CInt(reader("CarID"))
            Dim Available As String = reader("Available").ToString()

            Console.WriteLine("Car Registration Number: " & regNumber)
            Console.WriteLine("Available Value: " & Available)

            If Not String.IsNullOrEmpty(Available) AndAlso Available.ToUpper() = "YES" Then
                reader.Close()
                cn.Close()

                ' Insert rental record and update car availability
                cn.Open()
                cm = New SqlClient.SqlCommand("INSERT INTO tblcarrentals3 (CarID, RegNumber, CusID, CusName, PickupLocation, RentDate, ReturnDate, Charges, LoggedInUser, CreatedDate, CheckoutOdometer) VALUES (@CarID, @RegNumber, @CusID, @CusName, @PickupLocation, @RentDate, @ReturnDate, @Charges, @LoggedInUser, @CreatedDate, @CheckoutOdometer); UPDATE tblcars SET Available = 'NO' WHERE CarID = @CarID", cn)
                With cm
                    .Parameters.AddWithValue("@CarID", carID)
                    .Parameters.AddWithValue("@RegNumber", regNumber)
                    .Parameters.AddWithValue("@CusID", cusID)
                    .Parameters.AddWithValue("@CusName", customername)
                    .Parameters.AddWithValue("@PickupLocation", pickupLocation)
                    .Parameters.AddWithValue("@RentDate", rentDate)
                    .Parameters.AddWithValue("@ReturnDate", returnDate)
                    .Parameters.AddWithValue("@Charges", charges)
                    .Parameters.AddWithValue("@LoggedInUser", LblUsername.Text)
                    .Parameters.AddWithValue("@CreatedDate", DateTime.Now)
                    Console.WriteLine("Checkout Odometer before SQL: " & checkoutOdometer)
                    .Parameters.Add("@CheckoutOdometer", SqlDbType.Int).Value = checkoutOdometer

                    Console.WriteLine("SQL Query: " & cm.CommandText)
                    Console.WriteLine("Parameter values:")
                    For Each param As SqlParameter In cm.Parameters
                        Console.WriteLine($"{param.ParameterName}: {param.Value}")
                    Next

                    cm.ExecuteNonQuery()
                End With

                ' Check the inserted value
                Dim checkInsertCmd As New SqlCommand("SELECT TOP 1 CheckoutOdometer FROM tblcarrentals3 WHERE CarID = @CarID ORDER BY CreatedDate DESC", cn)
                checkInsertCmd.Parameters.AddWithValue("@CarID", carID)
                Dim insertedValue As Object = checkInsertCmd.ExecuteScalar()
                Console.WriteLine("Value in database after insert: " & insertedValue)

                cn.Close()

                MessageBox.Show("Vehicle rented successfully!")
                ClearFields()
            Else
                reader.Close()
                cn.Close()
                MessageBox.Show("The selected vehicle is not available for rent at the moment.")
            End If
        Else
            reader.Close()
            cn.Close()
            MessageBox.Show("Invalid Car Registration Number. Please check the details.")
        End If
    End Sub

    Private Function IsValidRegNumber(regNumber As String) As Boolean
        Dim pattern As String = "^(BA|GA|KO|LU|ME|NA|RA|SA)\d{1,2}[A-E]\d{4}$"
        Return Regex.IsMatch(regNumber, pattern)
    End Function

    Private Function CapitalizeFirstLetter(input As String) As String
        If String.IsNullOrEmpty(input) Then
            Return input
        End If
        Return Char.ToUpper(input(0)) & input.Substring(1)
    End Function

    Private Sub ClearFields()
        TxtRegNum.Refresh()
        TxtCusid.Clear()
        Txtcusname.Clear()
        TxtPickupfrom.Clear()
        TxtRentDate.Value = DateTime.Now
        TxtReturnDate.Value = DateTime.Now
        TxtCharges.Clear()
        TxtCheckoutOdometer.Value = 0
        TxtRegNum.Select()
    End Sub

    Private Sub BtnRent_Click(sender As Object, e As EventArgs) Handles BtnRent.Click
        Dim originalValue As Integer = CInt(TxtCheckoutOdometer.Value)
        Console.WriteLine("Value before clicking Rent: " & originalValue)
        Rentvehicle()
        Console.WriteLine("Value after Rentvehicle() call: " & TxtCheckoutOdometer.Value)
    End Sub

    Private Sub Rent_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Dim loginform As Login = DirectCast(Application.OpenForms("Login"), Login)
        'If loginform IsNot Nothing Then
        '    LblUsername.Text = loginform.LoggedInUsename
        'End If
        UpdateUsername()
        ' Configure TxtCheckoutOdometer
        TxtCheckoutOdometer.Minimum = 0
        TxtCheckoutOdometer.Maximum = 1000000  ' Or whatever maximum makes sense
        TxtCheckoutOdometer.Increment = 1
        TxtCheckoutOdometer.ThousandsSeparator = True
        LoadRecord1()
        Loadrecord()
    End Sub
    Public Sub UpdateUsername()
        LblUsername.Text = Module1.LoggedInUsename
    End Sub
    Private Sub TxtCusid_Leave(sender As Object, e As EventArgs) Handles TxtCusid.Leave
        ' Fetch customer name when customer ID is entered
        If Not String.IsNullOrEmpty(TxtCusid.Text) Then
            Try
                cn.Open()
                Dim query As String = "SELECT customername FROM tblcustomers WHERE cusid = @cusid"
                Dim cmd As New SqlCommand(query, cn)
                cmd.Parameters.AddWithValue("@cusid", TxtCusid.Text)
                Dim result As Object = cmd.ExecuteScalar()
                If result IsNot Nothing Then
                    Txtcusname.Text = result.ToString()
                Else
                    Txtcusname.Clear()
                    MessageBox.Show("No customer found with this ID.")
                End If
            Catch ex As Exception
                MessageBox.Show("Error fetching customer name: " & ex.Message)
            Finally
                cn.Close()
            End Try
        End If
    End Sub

    Private Sub TxtPickupfrom_Leave(sender As Object, e As EventArgs) Handles TxtPickupfrom.Leave
        ' Capitalize first letter of pickup location
        TxtPickupfrom.Text = CapitalizeFirstLetter(TxtPickupfrom.Text)
    End Sub

    Private Sub BtnHome_Click_1(sender As Object, e As EventArgs) Handles BtnHome.Click
        Me.Hide()
        Dim obj As New UHomee
        obj.Show()
    End Sub

    Private Sub BtnCustomers_Click(sender As Object, e As EventArgs) Handles BtnCustomers.Click
        Me.Hide()
        Dim obj As New UCustomers
        obj.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
        Dim obj As New Rent
        obj.Show()
    End Sub

    Private Sub BtnCancel_Click(sender As Object, e As EventArgs) Handles BtnCancel.Click
        Me.Hide()
        Dim obj As New Cancel
        obj.Show()
    End Sub

    Private Sub BtnCheckout_Click(sender As Object, e As EventArgs) Handles BtnCheckout.Click
        Me.Hide()
        Dim obj As New CheckOut
        obj.Show()
    End Sub

    Private Sub BtnSettings_Click(sender As Object, e As EventArgs) Handles BtnSettings.Click
        Me.Hide()
        Dim obj As New Settings
        obj.Show()
    End Sub

    Private Sub BtnLogout_Click(sender As Object, e As EventArgs) Handles BtnLogout.Click
        Me.Hide()
        Dim obj As New Login
        obj.Show()
    End Sub
End Class