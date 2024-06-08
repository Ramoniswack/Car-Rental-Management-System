

Imports System.Data.SqlClient

Public Class Rent
    Private Sub Rentvehicle()
        Dim cusID As String = TxtCusID.Text
        Dim customername As String = TxtCustomerName.Text
        Dim carID As String = TxtCarID.Text
        Dim carname As String = TxtCarName.Text
        Dim pickupLocation As String = TxtPickupFrom.Text
        Dim rentDate As Date = TxtRentDate.Value.Date
        Dim returnDate As Date = TxtReturnDate.Value.Date
        Dim charges As Decimal = TxtCharges.Text

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

        Dim carQuery As String = "SELECT COUNT(*) FROM tblcars WHERE carid = @carid AND carname = @carname"
        Dim carCmd As New SqlCommand(carQuery, cn)
        carCmd.Parameters.AddWithValue("@carid", carID)
        carCmd.Parameters.AddWithValue("@carname", carname)

        cn.Open()
        Dim carCount As Integer = CInt(carCmd.ExecuteScalar())
        cn.Close()

        If carCount = 0 Then
            MessageBox.Show("Invalid Car ID or Car Name. Please check the details.")
            Return
        End If


        cn.Open()
        cm = New SqlClient.SqlCommand("INSERT INTO tblcarrentals1 (CusID,CustomerName, CarID,CarName, PickupLocation, RentDate, ReturnDate, Charges) VALUES (@CusID,@CustomerName, @CarID,@CarName, @PickupLocation, @RentDate, @ReturnDate, @Charges)", cn)
        With cm
            .Parameters.AddWithValue("@CusID", cusID)
            .Parameters.AddWithValue("@CustomerName", customername)
            .Parameters.AddWithValue("@CarID", carID)
            .Parameters.AddWithValue("@CarName", carname)
            .Parameters.AddWithValue("@PickupLocation", pickupLocation)
            .Parameters.AddWithValue("@RentDate", rentDate)
            .Parameters.AddWithValue("@ReturnDate", returnDate)
            .Parameters.AddWithValue("@Charges", charges)
            cm.ExecuteNonQuery()
            cn.Close()
        End With
        MessageBox.Show("Vehicle rented successfully!")
        TxtCusID.Clear()
        TxtCustomerName.Clear()
        TxtCarID.Clear()
        TxtCarName.Clear()
        TxtPickupFrom.Clear()
        TxtRentDate.Value = DateTime.Now
        TxtReturnDate.Value = DateTime.Now
        TxtCharges.Clear()
        TxtCusID.Select()
    End Sub

    Private Sub BtnRent_Click(sender As Object, e As EventArgs) Handles BtnRent.Click
        Rentvehicle()
    End Sub

    Private Sub Rent_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    End Sub

    Private Sub BtnLogout_Click(sender As Object, e As EventArgs) Handles BtnLogout.Click
        Me.Hide()
        Dim obj As New Login
        obj.Show()
    End Sub

    Private Sub TxtReturnDate_TextChanged(sender As Object, e As EventArgs)
    End Sub

    Private Sub TxtCharges_TextChanged(sender As Object, e As EventArgs) Handles TxtCharges.TextChanged
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
        Dim obj As New UHomee
        obj.Show()
    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click

    End Sub

    Private Sub Label8_Click(sender As Object, e As EventArgs) Handles Label8.Click

    End Sub
End Class