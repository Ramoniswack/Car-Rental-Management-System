Imports Microsoft.VisualBasic.ApplicationServices
Imports System.Text.RegularExpressions
Imports System.Data.SqlClient

Public Class Cars
    Sub LoadRecord()
        Try
            If cn.State = ConnectionState.Closed Then
                cn.Open()
            End If
            Dgv.Rows.Clear()
            Dim i As Integer

            cm = New SqlClient.SqlCommand("SELECT * FROM tblcars", cn)
            dr = cm.ExecuteReader
            While dr.Read
                i = i + 1
                Dgv.Rows.Add(dr.Item("CarID"), dr.Item("Carname"), dr.Item("Model"), dr.Item("Color"), dr.Item("RegNumber"), dr.Item("Available"), dr.Item("TotalKilometers"), dr.Item("LastMaintenanceDate"), dr.Item("LastMaintenanceKilometers"))
                Debug.WriteLine($"Row {i}: CarID={dr.Item("CarID")}, Carname={dr.Item("Carname")}, Model={dr.Item("Model")}, Color={dr.Item("Color")}, RegNumber={dr.Item("RegNumber")}, Available={dr.Item("Available")}, TotalKilometers={dr.Item("TotalKilometers")}, LastMaintenanceDate={dr.Item("LastMaintenanceDate")}, LastMaintenanceKilometers={dr.Item("LastMaintenanceKilometers")}")
            End While
            Debug.WriteLine($"LoadRecord completed. Total rows loaded: {i}")
        Catch ex As Exception
            Debug.WriteLine($"Error in LoadRecord: {ex.Message}")
            Debug.WriteLine($"Stack trace: {ex.StackTrace}")
            MsgBox("An error occurred while loading records: " & ex.Message)
        Finally
            If cn.State = ConnectionState.Open Then
                cn.Close()
            End If
        End Try
    End Sub

    Private Function ValidateInputs() As Boolean
        ' Validate Car Name
        If String.IsNullOrWhiteSpace(TxtCarname.Text) OrElse Not Char.IsUpper(TxtCarname.Text(0)) Then
            MsgBox("Car name must start with a capital letter.")
            Return False
        End If

        ' Validate Model
        If String.IsNullOrWhiteSpace(Txtmodel.Text) OrElse Not Char.IsUpper(Txtmodel.Text(0)) Then
            MsgBox("Model must start with a capital letter.")
            Return False
        End If

        ' Validate Color
        If String.IsNullOrWhiteSpace(TxtColor.Text) OrElse Not Char.IsUpper(TxtColor.Text(0)) Then
            MsgBox("Color must start with a capital letter.")
            Return False
        End If

        ' Validate Registration Number
        If Not IsValidRegNumber(TxtRegNum.Text) Then
            MsgBox("Invalid registration number format. Please use the format: ZZ00X0000 (e.g., BA20B2080)")
            Return False
        End If

        ' Validate other fields
        If String.IsNullOrWhiteSpace(TxtAvaiable.Text) Then
            MsgBox("Availability status cannot be empty.")
            Return False
        End If

        If String.IsNullOrWhiteSpace(TxtInitialKm.Text) OrElse Not Integer.TryParse(TxtInitialKm.Text, Nothing) Then
            MsgBox("Initial kilometers must be a valid number.")
            Return False
        End If

        If String.IsNullOrWhiteSpace(TxtLastmaintenancedate.Text) OrElse Not Date.TryParse(TxtLastmaintenancedate.Text, Nothing) Then
            MsgBox("Last maintenance date must be a valid date.")
            Return False
        End If

        Return True
    End Function

    Private Function IsValidRegNumber(regNumber As String) As Boolean
        Dim pattern As String = "^(BA|GA|KO|LU|ME|NA|RA|SA)\d{1,2}[A-E]\d{4}$"
        Return Regex.IsMatch(regNumber, pattern)
    End Function

    Private Function IsRegNumberDuplicate(regNumber As String, excludeCarId As Integer) As Boolean
        Try
            If cn.State = ConnectionState.Closed Then
                cn.Open()
            End If
            Dim query As String = "SELECT COUNT(*) FROM tblcars WHERE RegNumber = @RegNumber AND CarID <> @CarID"
            cm = New SqlClient.SqlCommand(query, cn)
            cm.Parameters.AddWithValue("@RegNumber", regNumber)
            cm.Parameters.AddWithValue("@CarID", excludeCarId)
            Dim count As Integer = CInt(cm.ExecuteScalar())
            Return count > 0
        Catch ex As Exception
            MsgBox("Error checking for duplicate registration number: " & ex.Message)
            Return True ' Assume duplicate to be safe
        Finally
            If cn.State = ConnectionState.Open Then cn.Close()
        End Try
    End Function

    Private Sub BtnAddCustomer_Click(sender As Object, e As EventArgs) Handles BtnAddCustomer.Click
        If Not ValidateInputs() Then
            Return
        End If

        If IsRegNumberDuplicate(TxtRegNum.Text, -1) Then
            MsgBox("This registration number already exists in Records.")
            clear()
            Return
        End If

        Try
            If cn.State = ConnectionState.Closed Then
                cn.Open()
            End If
            cm = New SqlClient.SqlCommand("INSERT INTO tblcars (Carname, Model, Color, RegNumber, Available, TotalKilometers, LastMaintenanceDate, LastMaintenanceKilometers) VALUES (@Carname, @Model, @Color, @RegNumber, @Available, @TotalKilometers, @LastMaintenanceDate, @LastMaintenanceKilometers)", cn)
            With cm
                .Parameters.AddWithValue("@CarName", TxtCarname.Text)
                .Parameters.AddWithValue("@Model", Txtmodel.Text)
                .Parameters.AddWithValue("@Color", TxtColor.Text)
                .Parameters.AddWithValue("@RegNumber", TxtRegNum.Text)
                .Parameters.AddWithValue("@Available", TxtAvaiable.Text)
                .Parameters.AddWithValue("@TotalKilometers", Convert.ToInt32(TxtInitialKm.Text))
                .Parameters.AddWithValue("@LastMaintenanceDate", Convert.ToDateTime(TxtLastmaintenancedate.Text))
                .Parameters.AddWithValue("@LastMaintenanceKilometers", Convert.ToInt32(TxtInitialKm.Text))
                .ExecuteNonQuery()
            End With
            MsgBox("Car saved successfully")
        Catch ex As Exception
            MsgBox("An error occurred while adding the car: " & ex.Message)
        Finally
            If cn.State = ConnectionState.Open Then
                cn.Close()
            End If
        End Try

        clear()
        TxtCarname.Select()
        LoadRecord()
    End Sub

    Private Sub BtnUpdate_Click(sender As Object, e As EventArgs) Handles BtnUpdate.Click
        Try
            Debug.WriteLine($"Button Update clicked. Rows count: {Dgv.Rows.Count}, SelectedCells count: {Dgv.SelectedCells.Count}, SelectedRows count: {Dgv.SelectedRows.Count}")

            If Dgv.Rows.Count = 0 Then
                MsgBox("There are no rows to update.")
                Return
            End If

            If Dgv.SelectedCells.Count = 0 AndAlso Dgv.SelectedRows.Count = 0 Then
                MsgBox("Please select a row to update.")
                Return
            End If

            If Not ValidateInputs() Then
                Return
            End If

            Dim selectedRowIndex As Integer = -1
            If Dgv.SelectedCells.Count > 0 Then
                selectedRowIndex = Dgv.SelectedCells(0).RowIndex
            ElseIf Dgv.SelectedRows.Count > 0 Then
                selectedRowIndex = Dgv.SelectedRows(0).Index
            End If

            Debug.WriteLine($"Selected row index: {selectedRowIndex}")

            If selectedRowIndex < 0 Or selectedRowIndex >= Dgv.Rows.Count Then
                MsgBox("Invalid row index.")
                Return
            End If

            carIdValue = Convert.ToInt32(Dgv.Rows(selectedRowIndex).Cells(0).Value)

            If IsRegNumberDuplicate(TxtRegNum.Text, carIdValue) Then
                MsgBox("This registration number already exists for another car.")
                Return
            End If

            If cn.State = ConnectionState.Closed Then
                cn.Open()
            End If

            cm = New SqlClient.SqlCommand("UPDATE tblcars SET Carname = @Carname, Model = @Model, Color = @Color, RegNumber = @RegNumber, Available = @Available, TotalKilometers = @TotalKilometers, LastMaintenanceDate = @LastMaintenanceDate, LastMaintenanceKilometers = @LastMaintenanceKilometers WHERE Carid = @Carid", cn)
            With cm
                .Parameters.AddWithValue("@CarId", carIdValue)
                .Parameters.AddWithValue("@Carname", TxtCarname.Text)
                .Parameters.AddWithValue("@Model", Txtmodel.Text)
                .Parameters.AddWithValue("@Color", TxtColor.Text)
                .Parameters.AddWithValue("@RegNumber", TxtRegNum.Text)
                .Parameters.AddWithValue("@Available", TxtAvaiable.Text)
                .Parameters.AddWithValue("@TotalKilometers", Convert.ToInt32(TxtInitialKm.Text))
                .Parameters.AddWithValue("@LastMaintenanceDate", Convert.ToDateTime(TxtLastmaintenancedate.Text))
                .Parameters.AddWithValue("@LastMaintenanceKilometers", Convert.ToInt32(TxtInitialKm.Text))
                .ExecuteNonQuery()
            End With
            MsgBox("Car information updated successfully")
            LoadRecord()
        Catch ex As Exception
            Debug.WriteLine($"Error in BtnUpdate_Click: {ex.Message}")
            Debug.WriteLine($"Stack trace: {ex.StackTrace}")
            MsgBox($"An error occurred: {ex.Message}")
        Finally
            If cn.State = ConnectionState.Open Then
                cn.Close()
            End If
        End Try
        clear()
    End Sub
    Public Sub UpdateUsername()
        LblUsername.Text = Module1.LoggedInUsename
    End Sub
    Private Sub Customers_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'FleeteaseDataSet.tblcars' table. You can move, or remove it, as needed.
        'Me.TblcarsTableAdapter.Fill(Me.FleeteaseDataSet.tblcars)
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

    Dim carIdValue As Integer = 0

    Private Sub Dgv_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles Dgv.CellClick
        Try
            If e.RowIndex >= 0 AndAlso e.RowIndex < Dgv.Rows.Count Then
                Dgv.Rows(e.RowIndex).Selected = True
                Dim row As DataGridViewRow = Dgv.Rows(e.RowIndex)

                Debug.WriteLine($"Number of cells in the selected row: {row.Cells.Count}")

                ' Populate the text boxes with data from the selected row
                TxtCarname.Text = GetCellValue(row, 1)
                Txtmodel.Text = GetCellValue(row, 2)
                TxtColor.Text = GetCellValue(row, 3)
                TxtRegNum.Text = GetCellValue(row, 4)
                TxtAvaiable.Text = GetCellValue(row, 5)
                TxtInitialKm.Text = GetCellValue(row, 6)  ' This is TotalKilometers

                ' Handle LastMaintenanceDate
                If row.Cells.Count > 7 AndAlso row.Cells(7).Value IsNot Nothing Then
                    If DateTime.TryParse(row.Cells(7).Value.ToString(), Nothing) Then
                        TxtLastmaintenancedate.Value = Convert.ToDateTime(row.Cells(7).Value)
                    Else
                        TxtLastmaintenancedate.Value = DateTime.Now
                    End If
                Else
                    TxtLastmaintenancedate.Value = DateTime.Now
                End If

                ' Handle LastMaintenanceKilometers (assuming it's the last column)
                If row.Cells.Count > 8 Then
                    Dim lastMaintenanceKm As String = GetCellValue(row, 8)
                    ' You can add this to a label or another text box if needed
                    ' For now, we'll just log it
                    Debug.WriteLine($"Last Maintenance Kilometers: {lastMaintenanceKm}")
                End If

                Debug.WriteLine($"Row clicked and selected: CarName={TxtCarname.Text}, Model={Txtmodel.Text}, Color={TxtColor.Text}, RegNum={TxtRegNum.Text}, Available={TxtAvaiable.Text}, TotalKilometers={TxtInitialKm.Text}, LastMaintenanceDate={TxtLastmaintenancedate.Value}")
            Else
                Debug.WriteLine($"Invalid row index: {e.RowIndex}")
            End If
        Catch ex As Exception
            Debug.WriteLine($"Error in Dgv_CellClick: {ex.Message}")
            Debug.WriteLine($"Stack trace: {ex.StackTrace}")
        End Try
    End Sub

    ' Helper function to safely get cell values
    Private Function GetCellValue(row As DataGridViewRow, index As Integer) As String
        If row.Cells.Count > index AndAlso row.Cells(index).Value IsNot Nothing Then
            Return row.Cells(index).Value.ToString()
        End If
        Return String.Empty
    End Function
    Sub clear()
        TxtColor.Clear()
        Txtmodel.Clear()
        TxtCarname.Clear()
        TxtAvaiable.Text = ""
        TxtRegNum.Clear()
        TxtInitialKm.Clear()
        TxtLastmaintenancedate.Value = DateTime.Now
    End Sub

    Private Sub BtnHome_Click_1(sender As Object, e As EventArgs) Handles BtnHome.Click
        Me.Hide()
        Dim obj As New Homee
        obj.Show()
    End Sub

    Private Sub BtnLogout_Click_2(sender As Object, e As EventArgs) Handles BtnLogout.Click
        Me.Hide()
        Dim obj As New Login
        obj.Show()
    End Sub

    Private Sub BtnStats_Click_1(sender As Object, e As EventArgs) Handles BtnStats.Click
        Me.Hide()
        Dim obj As New Statistics
        obj.Show()
    End Sub

    Private Sub BtnCustomers_Click_1(sender As Object, e As EventArgs) Handles BtnCustomers.Click
        Me.Hide()
        Dim obj As New Customers
        obj.Show()
    End Sub

    Private Sub BtnUsers_Click_1(sender As Object, e As EventArgs) Handles BtnUsers.Click
        Me.Hide()
        Dim obj As New Users
        obj.Show()
    End Sub
End Class