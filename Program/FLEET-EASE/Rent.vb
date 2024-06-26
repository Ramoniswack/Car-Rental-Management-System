Imports System.Data.SqlClient

Public Class Rent

    Private Sub Rentvehicle()
        Dim regNumber As String = TxtRegNum.Text
        Dim cusID As String = TxtCusid.Text
        Dim customername As String = Txtcusname.Text
        Dim pickupLocation As String = TxtPickupfrom.Text
        Dim rentDate As Date = TxtRentDate.Value.Date
        Dim returnDate As Date = TxtReturnDate.Value.Date
        Dim charges As String = TxtCharges.Text

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
                cm = New SqlClient.SqlCommand("INSERT INTO tblcarrentals3 (CarID, RegNumber, CusID, CusName, PickupLocation, RentDate, ReturnDate, Charges,LoggedInUser,CreatedDate) VALUES (@CarID, @RegNumber, @CusID, @CusName, @PickupLocation, @RentDate, @ReturnDate, @Charges, @LoggedInUser, @CreatedDate); UPDATE tblcars SET Available = 'NO' WHERE CarID = @CarID", cn)
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
                    cm.ExecuteNonQuery()
                    cn.Close()
                End With

                MessageBox.Show("Vehicle rented successfully!")
                TxtRegNum.Clear()
                TxtCusid.Clear()
                Txtcusname.Clear()
                TxtPickupfrom.Clear()
                TxtRentDate.Value = DateTime.Now
                TxtReturnDate.Value = DateTime.Now
                TxtCharges.Clear()
                TxtRegNum.Select()
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

    Private Sub BtnRent_Click(sender As Object, e As EventArgs) Handles BtnRent.Click
        Rentvehicle()
    End Sub

    Private Sub Rent_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim loginform As Login = DirectCast(Application.OpenForms("Login"), Login)
        If loginform IsNot Nothing Then
            LblUsername.Text = loginform.Loggedinusername
        End If
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