Imports System.Data.SqlClient
Imports System.Text.RegularExpressions

Public Class Rent
    Private Sub Rentvehicle()
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
        TxtRegNum.Clear()
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
        Dim loginform As Login = DirectCast(Application.OpenForms("Login"), Login)
        If loginform IsNot Nothing Then
            LblUsername.Text = loginform.Loggedinusername
        End If

        ' Configure TxtCheckoutOdometer
        TxtCheckoutOdometer.Minimum = 0
        TxtCheckoutOdometer.Maximum = 1000000  ' Or whatever maximum makes sense
        TxtCheckoutOdometer.Increment = 1
        TxtCheckoutOdometer.ThousandsSeparator = True
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