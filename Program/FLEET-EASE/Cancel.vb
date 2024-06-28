Imports System.Data.SqlClient

Public Class Cancel
    Private Const REMARKS_COLUMN_SIZE As Integer = 50
    Private LoggedInUsername As String = ""  ' Add this line to store the username

    Private Sub Cancel_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Dim loginform As Login = DirectCast(Application.OpenForms("Login"), Login)
        'If loginform IsNot Nothing Then
        '    LoggedInUsername = loginform.LoggedInUsename  ' Store the username
        '    LblUsername.Text = LoggedInUsename
        'End If
        UpdateUsername()

        ' Set up DataGridView columns
        With Dgv1
            .ColumnCount = 8
            .Columns(0).Name = "No."
            .Columns(1).Name = "RentalID"
            .Columns(2).Name = "RegNumber"
            .Columns(3).Name = "CusName"
            .Columns(4).Name = "PickupLocation"
            .Columns(5).Name = "RentDate"
            .Columns(6).Name = "ReturnDate"
            .Columns(7).Name = "Charges"
            .SelectionMode = DataGridViewSelectionMode.FullRowSelect
            .MultiSelect = False
        End With

        Loadrecord()
    End Sub
    Public Sub UpdateUsername()
        LblUsername.Text = Module1.LoggedInUsename
    End Sub
    Public Sub Loadrecord()
        If cn.State = ConnectionState.Open Then
            cn.Close()
        End If

        Try
            cn.Open()
            Dgv1.Rows.Clear()
            Dim i As Integer

            Dim query As String = "SELECT cr.* FROM tblcarrentals3 cr " &
                              "INNER JOIN tblcars c ON cr.CarID = c.CarID " &
                              "LEFT JOIN tblcheckouts co ON cr.RentalID = co.RentalID " &
                              "WHERE (cr.iscancelled = 0 OR cr.iscancelled IS NULL) " &
                              "AND c.Available = 'NO' " &
                              "AND co.RentalID IS NULL " &
                              "ORDER BY cr.RentDate DESC"

            cm = New SqlClient.SqlCommand(query, cn)
            dr = cm.ExecuteReader

            While dr.Read
                i += 1
                Dgv1.Rows.Add(i,
                         dr.Item("RentalID"),
                         dr.Item("RegNumber"),
                         dr.Item("CusName"),
                         dr.Item("PickupLocation"),
                         dr.Item("RentDate"),
                         dr.Item("ReturnDate"),
                         dr.Item("Charges"))
            End While

        Catch ex As Exception
            MessageBox.Show("Error loading rentals: " & ex.Message)
        Finally
            If dr IsNot Nothing AndAlso Not dr.IsClosed Then
                dr.Close()
            End If
            If cn.State = ConnectionState.Open Then
                cn.Close()
            End If
        End Try
    End Sub

    Private Sub CancelRental(rentalID As String, remarks As String)
        If cn.State = ConnectionState.Open Then
            cn.Close()
        End If

        Dim transaction As SqlTransaction = Nothing

        Try
            cn.Open()
            transaction = cn.BeginTransaction()

            Dim truncatedRemarks As String = TruncateRemarks(remarks, REMARKS_COLUMN_SIZE)

            If truncatedRemarks.Length > REMARKS_COLUMN_SIZE Then
                Throw New Exception($"Remarks are too long. Maximum length is {REMARKS_COLUMN_SIZE} characters.")
            End If

            ' Debug: Log the LoggedInUsername
            Debug.WriteLine($"LoggedInUsername: {LoggedInUsername}")

            ' 1. Insert into tblcancel
            Dim insertQuery As String = "INSERT INTO tblcancel (RentalID, CarID, RegNumber, CusID, CusName, PickupLocation, RentDate, ReturnDate, Charges, CancelledBy, Remarks, CreatedDate, CancelledDate) " &
                                "SELECT RentalID, CarID, RegNumber, CusID, CusName, PickupLocation, RentDate, ReturnDate, Charges, @CancelledBy, @Remarks, CreatedDate, @CurrentDate " &
                                "FROM tblCarRentals3 WHERE RentalID = @RentalID"
            Dim insertCmd As New SqlCommand(insertQuery, cn, transaction)
            insertCmd.Parameters.Add("@RentalID", SqlDbType.NVarChar, 50).Value = rentalID
            insertCmd.Parameters.Add("@CancelledBy", SqlDbType.NVarChar, 50).Value = If(String.IsNullOrEmpty(LoggedInUsername), DBNull.Value, LoggedInUsername)
            insertCmd.Parameters.Add("@Remarks", SqlDbType.NVarChar, REMARKS_COLUMN_SIZE).Value = truncatedRemarks
            insertCmd.Parameters.AddWithValue("@CurrentDate", DateTime.Now)

            ' Debug: Log the SQL command
            Debug.WriteLine($"SQL Command: {insertCmd.CommandText}")
            Debug.WriteLine($"Parameters: RentalID={rentalID}, CancelledBy={LoggedInUsername}, Remarks={truncatedRemarks}")

            insertCmd.ExecuteNonQuery()

            ' 2. Update tblcars to set Available = 'YES'
            Dim updateCarQuery As String = "UPDATE tblcars SET Available = 'YES' WHERE CarID = (SELECT CarID FROM tblCarRentals3 WHERE RentalID = @RentalID)"
            Dim updateCarCmd As New SqlCommand(updateCarQuery, cn, transaction)
            updateCarCmd.Parameters.Add("@RentalID", SqlDbType.NVarChar, 50).Value = rentalID
            updateCarCmd.ExecuteNonQuery()

            ' 3. Update tblCarRentals3 to mark as cancelled
            Dim updateRentalQuery As String = "UPDATE tblCarRentals3 SET IsCancelled = 1 WHERE RentalID = @RentalID"
            Dim updateRentalCmd As New SqlCommand(updateRentalQuery, cn, transaction)
            updateRentalCmd.Parameters.Add("@RentalID", SqlDbType.NVarChar, 50).Value = rentalID
            updateRentalCmd.ExecuteNonQuery()

            transaction.Commit()

            MessageBox.Show("Rental cancelled successfully.")
            Loadrecord()
            TxtRemarks.Clear()
        Catch ex As SqlException
            If transaction IsNot Nothing Then
                transaction.Rollback()
            End If
            If ex.Number = 8152 Then
                MessageBox.Show($"The remarks are too long. Maximum length is {REMARKS_COLUMN_SIZE} characters. Please shorten your remarks and try again.")
            Else
                MessageBox.Show($"SQL Error cancelling rental: {ex.Message}")
            End If
        Catch ex As Exception
            If transaction IsNot Nothing Then
                transaction.Rollback()
            End If
            MessageBox.Show($"Error cancelling rental: {ex.Message}")
        Finally
            If cn.State = ConnectionState.Open Then
                cn.Close()
            End If
        End Try
    End Sub

    Private Function TruncateRemarks(remarks As String, maxLength As Integer) As String
        If String.IsNullOrEmpty(remarks) Then
            Return ""
        Else
            Return If(remarks.Length <= maxLength, remarks, remarks.Substring(0, maxLength))
        End If
    End Function

    Private Sub BtnBack_Click(sender As Object, e As EventArgs)
        Me.Hide()
        Dim obj As New UHomee()
        obj.Show()
    End Sub

    Private Sub TxtRemarks_TextChanged(sender As Object, e As EventArgs) Handles TxtRemarks.TextChanged
        ' You can add any logic here if needed when the remarks text changes
    End Sub

    Private Sub dgv1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles Dgv1.CellClick
        If e.RowIndex >= 0 Then
            Dgv1.Rows(e.RowIndex).Selected = True
        End If
    End Sub

    Private Sub Btncancel_Click(sender As Object, e As EventArgs) Handles Btncancel.Click
        If Dgv1.SelectedRows.Count > 0 Then
            Dim selectedRow As DataGridViewRow = Dgv1.SelectedRows(0)
            Dim rentalID As String = selectedRow.Cells("RentalID").Value.ToString()
            If MessageBox.Show("Are you sure you want to cancel this rental?", "Confirm Cancellation", MessageBoxButtons.YesNo) = DialogResult.Yes Then
                Dim remarks As String = TxtRemarks.Text
                CancelRental(rentalID, remarks)
            End If
        Else
            MessageBox.Show("Please select a rental to cancel.")
        End If
    End Sub

    Private Sub BtnCheckout_Click(sender As Object, e As EventArgs) Handles BtnCheckout.Click
        Me.Hide()
        Dim obj As New CheckOut
        obj.Show()
    End Sub

    Private Sub BtnHome_Click(sender As Object, e As EventArgs) Handles BtnHome.Click
        Me.Hide()
        Dim obj As New UHomee
        obj.Show()
    End Sub

    Private Sub BtnCustomers_Click_1(sender As Object, e As EventArgs) Handles BtnCustomers.Click
        Me.Hide()
        Dim obj As New UCustomers
        obj.Show()
    End Sub

    Private Sub BtnRent_Click(sender As Object, e As EventArgs) Handles BtnRent.Click
        Me.Hide()
        Dim obj As New Rent
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

    Private Sub Dgv1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles Dgv1.CellContentClick

    End Sub
End Class