Imports System.Data.SqlClient

Public Class Rent
    Private Sub Rentvehicle()
        Dim cusID As String = TxtCusID.Text
        Dim carID As String = TxtCarID.Text
        Dim pickupLocation As String = TxtPickupFrom.Text
        '  Dim rentdate As Date
        'TxtRentDate.Format = DateTimePickerFormat.Custom
        'TxtRentDate.CustomFormat = "dd/mm/yyyy"
        'TxtReturnDate.Format = DateTimePickerFormat.Custom
        'TxtReturnDate.CustomFormat = "dd/mm/yyyy"


        Dim rentDate As Date = TxtRentDate.Value.Date
        'rentDate = rentDate.ToShortDateString()
        rentDate.ToOADate()
        Dim returnDate As Date = TxtReturnDate.Value.Date
        'returnDate = returnDate.ToShortDateString()

        Dim charges As Decimal = TxtCharges.Text
        cn.Open()

        cm = New SqlClient.SqlCommand("INSERT INTO tblCarRentals (CusID, CarID, PickupLocation, RentDate, ReturnDate, Charges) VALUES (@CusID, @CarID, @PickupLocation, @RentDate,@ReturnDate, @Charges)", cn)

        With cm
            .Parameters.AddWithValue("@CusID", cusID)
            .Parameters.AddWithValue("@CarID", carID)
            .Parameters.AddWithValue("@PickupLocation", pickupLocation)
            .Parameters.AddWithValue("@RentDate", rentDate)
            .Parameters.AddWithValue("@ReturnDate", returnDate)
            .Parameters.AddWithValue("@Charges", charges)

            cm.ExecuteNonQuery()
            cn.Close()
        End With
        MessageBox.Show("Vehicle rented successfully!")
        TxtCusID.Clear()
        TxtCarID.Clear()
        TxtPickupFrom.Clear()
        ' TxtRentDate.Clear()
        ' TxtReturnDate.Clear()
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
End Class