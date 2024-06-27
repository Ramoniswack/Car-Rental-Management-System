Imports System.Data.SqlClient
Imports Microsoft.VisualBasic.ApplicationServices

Public Class Statistics

    Private Sub Statistics_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim loginform As Login = DirectCast(Application.OpenForms("Login"), Login)
        If loginform IsNot Nothing Then
            LblUsername.Text = loginform.Loggedinusername

        End If
        ' Load initial data (you can choose which one to load by default)
        LoadIndividualCarStats()
    End Sub

    Private Sub LoadIndividualCarStats()
        Try
            cn.Open()
            Dim query As String = "SELECT c.RegNumber, COUNT(co.CheckoutID) AS TotalRentals, " &
                                  "SUM(co.TotalCharges) AS TotalRevenue, " &
                                  "AVG(DATEDIFF(day, co.RentDate, co.ActualReturnDate)) AS AvgRentalDuration " &
                                  "FROM tblcars c " &
                                  "LEFT JOIN tblcheckouts co ON c.CarID = co.CarID " &
                                  "GROUP BY c.RegNumber"

            cm = New SqlCommand(query, cn)
            Dim adapter As New SqlDataAdapter(cm)
            Dim dt As New DataTable()
            adapter.Fill(dt)

            DGV.DataSource = dt
        Catch ex As Exception
            MessageBox.Show("Error loading individual car stats: " & ex.Message)
        Finally
            If cn.State = ConnectionState.Open Then cn.Close()
        End Try
    End Sub

    Private Sub LoadOverallTransactions()
        Try
            cn.Open()
            Dim query As String = "SELECT 'Overall' AS Category, " &
                                  "COUNT(CheckoutID) AS TotalTransactions, " &
                                  "SUM(TotalCharges) AS TotalRevenue, " &
                                  "AVG(TotalCharges) AS AverageRevenue " &
                                  "FROM tblcheckouts"

            cm = New SqlCommand(query, cn)
            Dim adapter As New SqlDataAdapter(cm)
            Dim dt As New DataTable()
            adapter.Fill(dt)

            DGV.DataSource = dt
        Catch ex As Exception
            MessageBox.Show("Error loading overall transactions: " & ex.Message)
        Finally
            If cn.State = ConnectionState.Open Then cn.Close()
        End Try
    End Sub

    Private Sub LoadUserLoginDetails()
        Try
            cn.Open()
            Dim query As String = "SELECT Username, LastLoginDate, LoginCount FROM tbllogin ORDER BY LastLoginDate DESC"
            cm = New SqlCommand(query, cn)
            Dim adapter As New SqlDataAdapter(cm)
            Dim dt As New DataTable()
            adapter.Fill(dt)
            DGV.DataSource = dt
        Catch ex As Exception
            MessageBox.Show("Error loading user login details: " & ex.Message)
        Finally
            If cn.State = ConnectionState.Open Then cn.Close()
        End Try
    End Sub
    Private Sub CheckVehicleMaintenance()
        Try
            cn.Open()
            Dim query As String = "SELECT RegNumber, LastMaintenanceDate, TotalKilometers, " &
                              "DATEDIFF(month, LastMaintenanceDate, GETDATE()) AS MonthsSinceLastMaintenance " &
                              "FROM tblcars " &
                              "WHERE TotalKilometers > 6000 OR DATEDIFF(month, LastMaintenanceDate, GETDATE()) > 6"

            cm = New SqlCommand(query, cn)
            Dim adapter As New SqlDataAdapter(cm)
            Dim dt As New DataTable()
            adapter.Fill(dt)

            DGV.DataSource = dt

            If dt.Rows.Count > 0 Then
                MessageBox.Show($"{dt.Rows.Count} vehicle(s) need maintenance. Select a vehicle and click 'Done' to update its maintenance status.")
                BtnDone.Enabled = True
            Else
                MessageBox.Show("No vehicles currently need maintenance.")
                BtnDone.Enabled = False
            End If
        Catch ex As Exception
            MessageBox.Show("Error checking vehicle maintenance: " & ex.Message)
        Finally
            If cn.State = ConnectionState.Open Then cn.Close()
        End Try
    End Sub
    Private Sub UpdateMaintenanceStatus(regNumber As String)
        Try
            cn.Open()
            Dim query As String = "UPDATE tblcars SET LastMaintenanceDate = GETDATE(), TotalKilometers = 0 WHERE RegNumber = @RegNumber"
            cm = New SqlCommand(query, cn)
            cm.Parameters.AddWithValue("@RegNumber", regNumber)
            cm.ExecuteNonQuery()
            MessageBox.Show("Maintenance status updated successfully for vehicle: " & regNumber)
        Catch ex As Exception
            MessageBox.Show("Error updating maintenance status: " & ex.Message)
        Finally
            If cn.State = ConnectionState.Open Then cn.Close()
        End Try
    End Sub
    Private Sub BtnIndividualTransactions_Click(sender As Object, e As EventArgs) Handles BtnIndividualTransactions.Click
        LoadIndividualCarStats()
    End Sub

    Private Sub BtnOverallTransactionSummary_Click(sender As Object, e As EventArgs) Handles BtnOverallTransactionSummary.Click
        LoadOverallTransactions()
    End Sub

    Private Sub BtnUserlogindetails_Click(sender As Object, e As EventArgs) Handles BtnUserlogindetails.Click
        LoadUserLoginDetails()
    End Sub

    Private Sub BtnVehicleMaintenanceAlert_Click(sender As Object, e As EventArgs) Handles BtnVehicleMaintenanceAlert.Click
        CheckVehicleMaintenance()
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

    Private Sub BtnCustomers_Click(sender As Object, e As EventArgs) Handles BtnCustomers.Click
        Me.Hide()
        Dim obj As New Customers
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

    Private Sub BtnDone_Click(sender As Object, e As EventArgs) Handles BtnDone.Click
        If DGV.SelectedRows.Count > 0 Then
            Dim regNumber As String = DGV.SelectedRows(0).Cells("RegNumber").Value.ToString()
            UpdateMaintenanceStatus(regNumber)
            CheckVehicleMaintenance() ' Refresh the list
        Else
            MessageBox.Show("Please select a vehicle to mark as maintained.")
        End If
    End Sub
End Class