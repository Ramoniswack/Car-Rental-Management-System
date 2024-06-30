Public Class Homee

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
    Public Sub Loadrecord1()
        cn.Open()
        Dgv1.Rows.Clear()
        Dim i As Integer

        cm = New SqlClient.SqlCommand("SELECT cr.* FROM tblcarrentals3 cr " &
                                  "INNER JOIN tblcars c ON cr.CarID = c.CarID " &
                                  "WHERE (cr.iscancelled = 0 OR cr.iscancelled IS NULL) " &
                                  "AND c.Available = 'NO'", cn)
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

    Private Sub BtnCars_Click(sender As Object, e As EventArgs)
        Me.Hide()
        Dim obj As New Cars
        obj.Show()
    End Sub

    Private Sub Homee_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        UpdateUsername()

        'TODO: This line of code loads data into the 'FleeteaseDataSet.tblcars' table. You can move, or remove it, as needed.
        'Me.TblcarsTableAdapter.Fill(Me.FleeteaseDataSet.tblcars)
        LoadRecord()
        Loadrecord1()
    End Sub


    Public Sub UpdateUsername()
        LblUsername.Text = Module1.LoggedInUsename
    End Sub

    Private Sub BtnUsers_Click(sender As Object, e As EventArgs) Handles BtnUsers.Click
        Me.Hide()
        Dim obj As New Users
        obj.Show()
    End Sub

    Private Sub BtnLogout_Click(sender As Object, e As EventArgs)
        Me.Hide()
        Dim obj As New Login
        obj.Show()
    End Sub

    'Private Sub BtnStatistics_Click(sender As Object, e As EventArgs) Handles BtnStats.Click
    '    Me.Hide()
    '    Dim obj As New Stats()
    '    obj.Show()
    'End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles BtnCars.Click
        Me.Hide()
        Dim obj As New Cars
        obj.Show()
    End Sub

    Private Sub BtnHome_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Panel2_Paint(sender As Object, e As PaintEventArgs) Handles Panel2.Paint

    End Sub

    Private Sub Panel7_Paint(sender As Object, e As PaintEventArgs) Handles Panel7.Paint

    End Sub

    Private Sub Panel6_Paint(sender As Object, e As PaintEventArgs) Handles Panel6.Paint

    End Sub

    Private Sub Panel5_Paint(sender As Object, e As PaintEventArgs) Handles Panel5.Paint

    End Sub

    Private Sub Panel4_Paint(sender As Object, e As PaintEventArgs) Handles Panel4.Paint

    End Sub

    Private Sub Panel3_Paint(sender As Object, e As PaintEventArgs) Handles Panel3.Paint

    End Sub

    Private Sub BtnStats_Click(sender As Object, e As EventArgs) Handles BtnStats.Click
        Me.Hide()
        Dim obj As New Statistics
        obj.Show()
    End Sub

    Private Sub BtnHome_Click_1(sender As Object, e As EventArgs) Handles BtnHome.Click

    End Sub

    Private Sub BtnLogout_Click_1(sender As Object, e As EventArgs) Handles BtnLogout.Click
        Module1.LoggedInUsename = ""
        Me.Hide()
        Dim obj As New Login
        obj.Show()
    End Sub
End Class
