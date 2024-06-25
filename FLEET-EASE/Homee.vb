Public Class Homee

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
    Public Sub Loadrecord1()
        cn.Open()
        Dgv1.Rows.Clear()
        Dim i As Integer

        cm = New SqlClient.SqlCommand("select *from tblcarrentals3", cn)
        dr = cm.ExecuteReader
        While dr.Read
            i = i + 1
            Dgv1.Rows.Add(i, dr.Item("RegNumber"), dr.Item("CusName"), dr.Item("PickupLocation"), dr.Item("RentDate"), dr.Item("ReturnDate"), dr.Item("Charges"))
        End While
        cn.Close()
    End Sub






    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles BtnCustomers.Click
        Me.Hide()
        Dim obj As New Customers
        obj.Show()
    End Sub

    Private Sub BtnCars_Click(sender As Object, e As EventArgs) Handles BtnCars.Click
        Me.Hide()
        Dim obj As New Cars
        obj.Show()
    End Sub

    Private Sub Homee_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim loginform As Login = DirectCast(Application.OpenForms("Login"), Login)
        If loginform IsNot Nothing Then
            LblUsername.Text = loginform.loggedinusername

        End If


        'TODO: This line of code loads data into the 'FleeteaseDataSet.tblcars' table. You can move, or remove it, as needed.
        'Me.TblcarsTableAdapter.Fill(Me.FleeteaseDataSet.tblcars)
        LoadRecord()
        Loadrecord1()
    End Sub

    Private Sub BtnUsers_Click(sender As Object, e As EventArgs) Handles BtnUsers.Click
        Me.Hide()
        Dim obj As New Users
        obj.Show()
    End Sub

    Private Sub BtnLogout_Click(sender As Object, e As EventArgs) Handles BtnLogout.Click
        Me.Hide()
        Dim obj As New Login
        obj.Show()
    End Sub


End Class
