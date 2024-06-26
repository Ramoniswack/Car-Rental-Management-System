Imports System.ComponentModel.Design
Imports System.Data.SqlClient

Public Class CheckOut


    Public Sub Loadrecord()
        cn.Open()
        Dgv.Rows.Clear()
        Dim i As Integer

        cm = New SqlClient.SqlCommand("SELECT cr.* FROM tblcarrentals3 cr " &
                                  "INNER JOIN tblcars c ON cr.CarID = c.CarID " &
                                  "WHERE (cr.iscancelled = 0 OR cr.iscancelled IS NULL) " &
                                  "AND c.Available = 'NO'", cn)
        dr = cm.ExecuteReader
        While dr.Read
            i = i + 1
            Dgv.Rows.Add(i, dr.Item("RegNumber"), dr.Item("CusName"), dr.Item("PickupLocation"), dr.Item("RentDate"), dr.Item("ReturnDate"), dr.Item("Charges"))
        End While
        cn.Close()
    End Sub



    Private rentalID As Integer
    Private carID As Integer
    Private regNumber As String
    Private cusID As String
    Private cusName As String
    Private rentDate As Date
    Private returnDate As Date
    Private charges As Decimal
    Private finedescription As String
    Private Sub LoadRentalDetails()
        If String.IsNullOrWhiteSpace(TxtRegNum.Text) Then
            ' If the registration number is empty, just clear the fields and return
            ClearFields()
            Return
        End If

        Dim inputRegNumber As String = TxtRegNum.Text.Trim()

        Dim rentalQuery As String = "SELECT cr.RentalID, cr.CarID, cr.RegNumber, cr.CusID, cr.CusName, cr.RentDate, cr.ReturnDate, cr.Charges " &
                                "FROM tblcarrentals3 cr " &
                                "INNER JOIN tblcars c ON cr.CarID = c.CarID " &
                                "WHERE cr.RegNumber = @RegNumber AND c.Available = 'NO' " &
                                "AND (cr.iscancelled = 0 OR cr.iscancelled IS NULL) " &
                                "ORDER BY cr.RentalID DESC"

        Try
            If cn.State = ConnectionState.Closed Then
                cn.Open()
            End If

            cm = New SqlCommand(rentalQuery, cn)
            cm.Parameters.AddWithValue("@RegNumber", inputRegNumber)

            dr = cm.ExecuteReader()

            If dr.Read() Then
                rentalID = CInt(dr("RentalID"))
                carID = CInt(dr("CarID"))
                regNumber = dr("RegNumber").ToString()
                cusID = dr("CusID").ToString()
                cusName = dr("CusName").ToString()
                rentDate = CDate(dr("RentDate"))
                returnDate = CDate(dr("ReturnDate"))
                charges = CDec(dr("Charges"))

                ' Populate the form fields
                TxtCusid.Text = cusID
                TxtCusname.Text = cusName
                TxtRentDate.Value = rentDate
                TxtrETURNDATE.Value = returnDate
                TxtCharges.Text = charges.ToString("F2")

                ' Set the minimum date for actual return date
                TxtActualReturndate.MinDate = rentDate
                TxtActualReturndate.Value = Date.Today
            Else
                ' Only show the message if the form is visible and the registration number isn't empty
                If Me.Visible AndAlso Not String.IsNullOrWhiteSpace(inputRegNumber) Then
                    MessageBox.Show("No active, non-cancelled rental found for this registration number, or the vehicle is marked as available.")
                End If
                ClearFields()
            End If

        Catch ex As Exception
            MessageBox.Show("An error occurred while loading rental details: " & ex.Message)
            ClearFields()
        Finally
            If dr IsNot Nothing AndAlso Not dr.IsClosed Then
                dr.Close()
            End If
            If cn.State = ConnectionState.Open Then
                cn.Close()
            End If
        End Try
    End Sub

    Private Sub ProcessCheckout()
        If rentalID = 0 Or rentalID = 1 Then
            MessageBox.Show("Please load a valid rental record first.")
            Return
        End If

        ' Check if the rental is still active (not cancelled) and the car is still unavailable
        Dim checkQuery As String = "SELECT cr.iscancelled, c.Available FROM tblcarrentals3 cr " &
                               "INNER JOIN tblcars c ON cr.CarID = c.CarID " &
                               "WHERE cr.RentalID = @RentalID"
        Dim checkCmd As New SqlCommand(checkQuery, cn)
        checkCmd.Parameters.AddWithValue("@RentalID", rentalID)

        cn.Open()
        Dim reader As SqlDataReader = checkCmd.ExecuteReader()

        If reader.Read() Then
            Dim isCancelled As Boolean = Convert.ToBoolean(reader("iscancelled"))
            Dim isAvailable As Boolean = (reader("Available").ToString().ToUpper() = "YES")

            If isCancelled Or isAvailable Then
                reader.Close()
                cn.Close()
                MessageBox.Show("This rental has been cancelled or the vehicle has been marked as available. Checkout is not possible.")
                ClearFields()
                Return
            End If
        Else
            reader.Close()
            cn.Close()
            MessageBox.Show("Rental record not found. Checkout is not possible.")
            ClearFields()
            Return
        End If

        reader.Close()
        cn.Close()

        Dim actualReturnDate As Date = TxtActualReturndate.Value.Date
        Dim delayDays As Integer = Math.Max(0, (actualReturnDate - returnDate).Days)
        Dim fine As Decimal
        If Not Decimal.TryParse(TxtFine.Text, fine) Then
            MessageBox.Show("Please enter a valid fine amount.")
            Return
        End If
        Dim totalCharges As Decimal = charges + fine

        ' Insert checkout record and update car availability
        cn.Open()
        cm = New SqlClient.SqlCommand(
            "INSERT INTO tblcheckouts (RentalID, CarID, RegNumber, CusID, CusName, RentDate, ReturnDate, ActualReturnDate, Charges, DelayDays, Fine, TotalCharges, LoggedInUser, CreatedDate, FineDescription) " &
            "VALUES (@RentalID, @CarID, @RegNumber, @CusID, @CusName, @RentDate, @ReturnDate, @ActualReturnDate, @Charges, @DelayDays, @Fine, @TotalCharges, @LoggedInUser, @CreatedDate, @FineDescription); " &
            "UPDATE tblcars SET Available = 'YES' WHERE CarID = @CarID", cn)
        With cm
            .Parameters.AddWithValue("@RentalID", rentalID)
            .Parameters.AddWithValue("@CarID", carID)
            .Parameters.AddWithValue("@RegNumber", regNumber)
            .Parameters.AddWithValue("@CusID", cusID)
            .Parameters.AddWithValue("@CusName", cusName)
            .Parameters.AddWithValue("@RentDate", rentDate)
            .Parameters.AddWithValue("@ReturnDate", returnDate)
            .Parameters.AddWithValue("@ActualReturnDate", actualReturnDate)
            .Parameters.AddWithValue("@Charges", charges)
            .Parameters.AddWithValue("@DelayDays", delayDays)
            .Parameters.AddWithValue("@Fine", fine)
            .Parameters.AddWithValue("@TotalCharges", totalCharges)
            .Parameters.AddWithValue("@LoggedInUser", LblUsername.Text)
            .Parameters.AddWithValue("@CreatedDate", DateTime.Now)
            .Parameters.AddWithValue("@FineDescription", TxtFinedescription.Text)
            cm.ExecuteNonQuery()
        End With
        cn.Close()


        MessageBox.Show("Checkout processed successfully! The car is now marked as available.")
        ClearFields()
    End Sub

    Private Sub ClearFields()
        TxtRegNum.Clear()
        TxtCusid.Clear()
        TxtCusname.Clear()
        TxtRentDate.Value = DateTime.Now
        TxtrETURNDATE.Value = DateTime.Now
        TxtActualReturndate.Value = DateTime.Now
        TxtCharges.Clear()
        TxtFine.Clear()
        TxtFinedescription.Clear()

        TxtRegNum.Select()

        ' Reset the private fields
        rentalID = 0
        carID = 0
        regNumber = ""
        cusID = ""
        cusName = ""
        rentDate = Date.MinValue
        returnDate = Date.MinValue
        charges = 0
    End Sub

    Private Sub TxtRegNum_Leave(sender As Object, e As EventArgs) Handles TxtRegNum.Leave
        If Not Me.IsDisposed AndAlso Me.Visible Then
            LoadRentalDetails()

        End If

    End Sub

    Private Sub BtnCheckout_Click(sender As Object, e As EventArgs) Handles BtnCheckout.Click
        ProcessCheckout()
    End Sub

    Private Sub CheckOut_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim loginform As Login = DirectCast(Application.OpenForms("Login"), Login)
        If loginform IsNot Nothing Then
            LblUsername.Text = loginform.Loggedinusername
        End If

        LoadRecord()
    End Sub

    Private Sub BtnHome_Click(sender As Object, e As EventArgs) Handles BtnHome.Click
        Me.Hide()
        Dim obj As New UHomee
        obj.Show()
    End Sub

    Private Sub BtnCustomers_Click(sender As Object, e As EventArgs) Handles BtnCustomers.Click
        Me.Hide()
        Dim obj As New UCustomers
        obj.Show()
    End Sub

    Private Sub BtnRent_Click(sender As Object, e As EventArgs) Handles BtnRent.Click
        Me.Hide()
        Dim obj As New Rent
        obj.Show()
    End Sub

    Private Sub BtnCancel_Click(sender As Object, e As EventArgs) Handles BtnCancel.Click
        Me.Hide()
        Dim obj As New Cancel
        obj.Show()
    End Sub

    Private Sub BtnCheckoutt_Click(sender As Object, e As EventArgs) Handles BtnCheckoutt.Click
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