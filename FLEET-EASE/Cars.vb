Public Class Cars
    Public Sub LoadRecord()
        Try
            If cn.State = ConnectionState.Closed Then
                cn.Open()
            End If
            Dgv.Rows.Clear()
            Dim i As Integer

            cm = New SqlClient.SqlCommand("select * from tblcars", cn)
            dr = cm.ExecuteReader
            While dr.Read
                i = i + 1
                Dgv.Rows.Add(dr.Item("CarID"), dr.Item("Carname"), dr.Item("Model"), dr.Item("Color"), dr.Item("RegNumber"), dr.Item("Available"))
            End While
        Catch ex As Exception
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
                cm = New SqlClient.SqlCommand("INSERT INTO tblcars (Carname, Model, Color, RegNumber, Available) VALUES (@Carname, @Model, @Color, @RegNumber, @Available)", cn)
                With cm
                    .Parameters.AddWithValue("@CarName", TxtCarname.Text)
                    .Parameters.AddWithValue("@Model", Txtmodel.Text)
                    .Parameters.AddWithValue("@Color", TxtColor.Text)
                    .Parameters.AddWithValue("@RegNumber", TxtRegNum.Text)
                    .Parameters.AddWithValue("@Available", TxtAvailable.Text)
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

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles BtnCustomer.Click
        Me.Hide()
        Dim obj As New Customers
        obj.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles BtnHome.Click
        Me.Hide()
        Dim obj As New Homee
        obj.Show()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles BtnUsers.Click
        Me.Hide()
        Dim obj As New Users
        obj.Show()
    End Sub

    Private Sub BtnLogout_Click(sender As Object, e As EventArgs) Handles BtnLogout.Click
        Me.Hide()
        Dim obj As New Login
        obj.Show()
    End Sub

    Dim carIdValue As Integer = 0

    Private Sub BtnUpdate_Click(sender As Object, e As EventArgs) Handles BtnUpdate.Click
        Debug.WriteLine($"Selected Cells: {Dgv.SelectedCells.Count}, Selected Rows: {Dgv.SelectedRows.Count}")

        ' Check if any cell is selected
        If Dgv.SelectedCells.Count = 0 Then
            MsgBox("Please select a row to update.")
            Return
        End If

        ' Get the selected row index
        Dim selectedRowIndex As Integer = Dgv.SelectedCells(0).RowIndex
        Debug.WriteLine($"Selected Row Index: {selectedRowIndex}")

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

        ' If we've made it this far, all checks have passed
        Try
            carIdValue = Convert.ToInt32(Dgv.Rows(selectedRowIndex).Cells(0).Value)

            ' Check if the connection is already open
            If cn.State = ConnectionState.Closed Then
                cn.Open()
            End If

            cm = New SqlClient.SqlCommand("UPDATE tblcars SET Carname = @Carname, Model = @Model, Color = @Color, RegNumber = @RegNumber, Available = @Available WHERE Carid = @Carid", cn)
            With cm
                .Parameters.AddWithValue("@CarId", carIdValue)
                .Parameters.AddWithValue("@Carname", TxtCarname.Text)
                .Parameters.AddWithValue("@Model", Txtmodel.Text)
                .Parameters.AddWithValue("@Color", TxtColor.Text)
                .Parameters.AddWithValue("@RegNumber", TxtRegNum.Text)
                .Parameters.AddWithValue("@Available", TxtAvailable.Text)
                .ExecuteNonQuery()
            End With
            MsgBox("Car information updated successfully")
            LoadRecord()
        Catch ex As Exception
            MsgBox("An error occurred: " & ex.Message)
        Finally
            If cn.State = ConnectionState.Open Then
                cn.Close()
            End If
        End Try
        clear()
    End Sub

    Private Sub Dgv_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles Dgv.CellClick
        If e.RowIndex >= 0 Then
            ' Select the entire row
            Dgv.Rows(e.RowIndex).Selected = True

            Dim row As DataGridViewRow = Dgv.Rows(e.RowIndex)
            TxtCarname.Text = If(row.Cells(1).Value IsNot Nothing, row.Cells(1).Value.ToString(), "")
            Txtmodel.Text = If(row.Cells(2).Value IsNot Nothing, row.Cells(2).Value.ToString(), "")
            TxtColor.Text = If(row.Cells(3).Value IsNot Nothing, row.Cells(3).Value.ToString(), "")
            TxtRegNum.Text = If(row.Cells(4).Value IsNot Nothing, row.Cells(4).Value.ToString(), "")
            TxtAvailable.Text = If(row.Cells(5).Value IsNot Nothing, row.Cells(5).Value.ToString(), "")

            ' Debug output
            Debug.WriteLine($"Row clicked and selected: CarName={TxtCarname.Text}, Model={Txtmodel.Text}, Color={TxtColor.Text}, RegNum={TxtRegNum.Text}, Available={TxtAvailable.Text}")
        End If
    End Sub

    Sub clear()
        TxtColor.Clear()
        Txtmodel.Clear()
        TxtCarname.Clear()
        TxtAvailable.Clear()
        TxtRegNum.Clear()
    End Sub

    Private Sub Dgv_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles Dgv.CellContentClick

    End Sub
End Class