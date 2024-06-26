Imports Microsoft.VisualBasic.ApplicationServices

Public Class Cars
    Public Sub LoadRecord()
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

    Private Sub BtnAddCustomer_Click(sender As Object, e As EventArgs) Handles BtnAddCustomer.Click
        If TxtCarname.Text <> "" And Txtmodel.Text <> "" And TxtColor.Text <> "" And TxtRegNum.Text <> "" And TxtAvailable.Text <> "" Then
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
                    .Parameters.AddWithValue("@Available", TxtAvailable.Text)
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
        Else
            MsgBox("Please fulfill all requirements first")
        End If

        clear()
        TxtCarname.Select()
        LoadRecord()
    End Sub

    Private Sub Customers_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim loginform As Login = DirectCast(Application.OpenForms("Login"), Login)
        If loginform IsNot Nothing Then
            LblUsername.Text = loginform.Loggedinusername
        End If
        LoadRecord()

        ' Set DataGridView properties
        Dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        Dgv.MultiSelect = False
    End Sub

    Dim carIdValue As Integer = 0

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

            ' Check each field individually
            If String.IsNullOrWhiteSpace(TxtCarname.Text) Then
                MsgBox("Car name cannot be empty.")
                Return
            End If
            If String.IsNullOrWhiteSpace(TxtColor.Text) Then
                MsgBox("Color cannot be empty.")
                Return
            End If
            If String.IsNullOrWhiteSpace(Txtmodel.Text) Then
                MsgBox("Model cannot be empty.")
                Return
            End If
            If String.IsNullOrWhiteSpace(TxtRegNum.Text) Then
                MsgBox("Registration number cannot be empty.")
                Return
            End If
            If String.IsNullOrWhiteSpace(TxtAvailable.Text) Then
                MsgBox("Availability status cannot be empty.")
                Return
            End If
            If String.IsNullOrWhiteSpace(TxtInitialKm.Text) Then
                MsgBox("Initial kilometers cannot be empty.")
                Return
            End If
            If String.IsNullOrWhiteSpace(TxtLastmaintenancedate.Text) Then
                MsgBox("Last maintenance date cannot be empty.")
                Return
            End If

            carIdValue = Convert.ToInt32(Dgv.Rows(selectedRowIndex).Cells(0).Value)

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
                .Parameters.AddWithValue("@Available", TxtAvailable.Text)
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

    Private Sub Dgv_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles Dgv.CellClick
        Try
            Debug.WriteLine($"Cell clicked. RowIndex: {e.RowIndex}, ColumnIndex: {e.ColumnIndex}")

            If e.RowIndex >= 0 AndAlso e.RowIndex < Dgv.Rows.Count Then
                Dgv.Rows(e.RowIndex).Selected = True

                Dim row As DataGridViewRow = Dgv.Rows(e.RowIndex)
                TxtCarname.Text = If(row.Cells(1).Value IsNot Nothing, row.Cells(1).Value.ToString(), "")
                Txtmodel.Text = If(row.Cells(2).Value IsNot Nothing, row.Cells(2).Value.ToString(), "")
                TxtColor.Text = If(row.Cells(3).Value IsNot Nothing, row.Cells(3).Value.ToString(), "")
                TxtRegNum.Text = If(row.Cells(4).Value IsNot Nothing, row.Cells(4).Value.ToString(), "")
                TxtAvailable.Text = If(row.Cells(5).Value IsNot Nothing, row.Cells(5).Value.ToString(), "")
                TxtInitialKm.Text = If(row.Cells(6).Value IsNot Nothing, row.Cells(6).Value.ToString(), "")
                TxtLastmaintenancedate.Text = If(row.Cells(7).Value IsNot Nothing, CType(row.Cells(7).Value, DateTime).ToString("yyyy-MM-dd"), "")

                Debug.WriteLine($"Row clicked and selected: CarName={TxtCarname.Text}, Model={Txtmodel.Text}, Color={TxtColor.Text}, RegNum={TxtRegNum.Text}, Available={TxtAvailable.Text}, InitialKm={TxtInitialKm.Text}, LastMaintenanceDate={TxtLastmaintenancedate.Text}")
            Else
                Debug.WriteLine($"Invalid row index: {e.RowIndex}")
            End If
        Catch ex As Exception
            Debug.WriteLine($"Error in Dgv_CellClick: {ex.Message}")
            Debug.WriteLine($"Stack trace: {ex.StackTrace}")
        End Try
    End Sub

    Sub clear()
        TxtColor.Clear()
        Txtmodel.Clear()
        TxtCarname.Clear()
        TxtAvailable.Clear()
        TxtRegNum.Clear()
        TxtInitialKm.Clear()
        TxtLastmaintenancedate.Refresh()
    End Sub

    Private Sub Dgv_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles Dgv.CellContentClick
    End Sub

    Private Sub BtnHome_Click_1(sender As Object, e As EventArgs) Handles BtnHome.Click
        Me.Hide()
        Dim obj As New Homee
        obj.Show()
    End Sub

    Private Sub Panel2_Paint_1(sender As Object, e As PaintEventArgs) Handles Panel2.Paint
    End Sub

    Private Sub Button1_Click_2(sender As Object, e As EventArgs) Handles Button1.Click
    End Sub

    Private Sub Panel7_Paint_1(sender As Object, e As PaintEventArgs) Handles Panel7.Paint
    End Sub

    Private Sub Panel6_Paint_1(sender As Object, e As PaintEventArgs) Handles Panel6.Paint
    End Sub

    Private Sub Panel5_Paint_1(sender As Object, e As PaintEventArgs) Handles Panel5.Paint
    End Sub

    Private Sub Panel4_Paint_1(sender As Object, e As PaintEventArgs) Handles Panel4.Paint
    End Sub

    Private Sub Panel3_Paint_1(sender As Object, e As PaintEventArgs) Handles Panel3.Paint
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

    Private Sub TxtColor_TextChanged(sender As Object, e As EventArgs) Handles TxtColor.TextChanged
    End Sub
End Class