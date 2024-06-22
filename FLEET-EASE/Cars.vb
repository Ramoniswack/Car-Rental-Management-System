Public Class Cars
    Public Sub LoadRecord()
        cn.Open()
        Dgv.Rows.Clear()
        Dim i As Integer

        cm = New SqlClient.SqlCommand("select *from tblcars", cn)
        dr = cm.ExecuteReader
        While dr.Read
            i = i + 1
            Dgv.Rows.Add(dr.Item("CarID"), dr.Item("Carname"), dr.Item("Model"), dr.Item("Color"), dr.Item("RegNumber"), dr.Item("Available"))
        End While
        cn.Close()
    End Sub

    Private Sub BtnAddCustomer_Click(sender As Object, e As EventArgs) Handles BtnAddCustomer.Click
        If TxtCarname.Text <> "" And Txtmodel.Text <> "" And TxtColor.Text <> "" And TxtAvailable.Text <> "" Then
            cn.Open()
            cm = New SqlClient.SqlCommand("INSERT INTO tblcars (Carname, Model, Color,RegNumber, Available) VALUES (@Carname, @Model, @Color,@RegNumber, @Available)", cn)
            With cm
                .Parameters.AddWithValue("@CarName", TxtCarname.Text)
                .Parameters.AddWithValue("@Model", Txtmodel.Text)
                .Parameters.AddWithValue("@Color", TxtColor.Text)
                .Parameters.AddWithValue("@RegNumber", TxtRegNum.Text)
                .Parameters.AddWithValue("@Available", TxtAvailable.Text)
                .ExecuteNonQuery()
                cn.Close()
            End With
            MsgBox("Customer saved successfully")
        Else
            MsgBox("Please fullfill all requirements first")
        End If

        TxtColor.Clear()
        Txtmodel.Clear()
        TxtCarname.Clear()
        TxtAvailable.Clear()
        TxtRegNum.Clear()

        TxtCarname.Select()

        LoadRecord()
    End Sub



    Private Sub Customers_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim loginform As Login = DirectCast(Application.OpenForms("Login"), Login)
        If loginform IsNot Nothing Then
            LblUsername.Text = loginform.Loggedinusername

        End If
        LoadRecord()
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

    Private Sub Dgv_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles Dgv.CellContentClick

    End Sub
    Dim carIdValue As Integer = 0
    Private Sub BtnUpdate_Click(sender As Object, e As EventArgs) Handles BtnUpdate.Click
        If Dgv.SelectedRows.Count > 0 AndAlso TxtCarname.Text <> "" And TxtColor.Text <> "" And Txtmodel.Text <> "" And TxtAvailable.Text <> "" Then
            Dim selectedRowIndex As Integer = Dgv.SelectedCells(0).RowIndex
            carIdValue = Convert.ToInt32(Dgv.Rows(selectedRowIndex).Cells(0).Value)
            cn.Open()
            cm = New SqlClient.SqlCommand("UPDATE tblcars SET Carname = @Carname, Model = @Model, Color = @Color, Qty = @Qty WHERE Carid = @Carid", cn)
            With cm
                .Parameters.AddWithValue("@CarId", carIdValue)
                .Parameters.AddWithValue("@Carname", TxtCarname.Text)
                .Parameters.AddWithValue("@Model", Txtmodel.Text)
                .Parameters.AddWithValue("@Color", TxtColor.Text)
                .Parameters.AddWithValue("@Qty", TxtAvailable.Text)
                .ExecuteNonQuery()
                cn.Close()
            End With
            MsgBox("Car information updated successfully")
            LoadRecord()
        Else
            MsgBox("Please select a row and fill in all the fields to update.")
        End If
        clear()
    End Sub

    Private Sub Dgv_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles Dgv.CellClick
        If e.RowIndex >= 0 Then
            Dim row As DataGridViewRow = Dgv.Rows(e.RowIndex)
            ' TxtCarID.Text = row.Cells(0).Value.ToString()
            TxtCarname.Text = row.Cells(1).Value.ToString()
            Txtmodel.Text = row.Cells(2).Value.ToString()
            TxtColor.Text = row.Cells(3).Value.ToString()
            TxtAvailable.Text = row.Cells(4).Value.ToString()
        End If

    End Sub

    Sub clear()
        TxtColor.Clear()
        Txtmodel.Clear()
        TxtCarname.Clear()
        TxtAvailable.Clear()
        TxtRegNum.Clear()

    End Sub

End Class