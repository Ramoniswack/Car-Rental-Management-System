Public Class Cars
    Public Sub LoadRecord()
        cn.Open()
        Dgv.Rows.Clear()
        Dim i As Integer

        cm = New SqlClient.SqlCommand("select *from tblcars", cn)
        dr = cm.ExecuteReader
        While dr.Read
            i = i + 1
            Dgv.Rows.Add(i, dr.Item("Carname"), dr.Item("Model"), dr.Item("Color"))
        End While
        cn.Close()
    End Sub
    Private Sub BtnAddCustomer_Click(sender As Object, e As EventArgs) Handles BtnAddCustomer.Click
        cn.Open()
        cm = New SqlClient.SqlCommand("INSERT INTO tblcars (Carname, Model, Color) VALUES (@Carname, @Model, @Color)", cn)
        With cm
            .Parameters.AddWithValue("@CarName", TxtCarname.Text)
            .Parameters.AddWithValue("@Model", Txtmodel.Text)
            .Parameters.AddWithValue("@Color", TxtColor.Text)
            .ExecuteNonQuery()
            cn.Close()
        End With
        MsgBox("Customer saved successfully")

        TxtColor.Clear()
        Txtmodel.Clear()
        TxtCarname.Clear()

        TxtCarname.Select()

        LoadRecord()
    End Sub



    Private Sub Customers_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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
End Class