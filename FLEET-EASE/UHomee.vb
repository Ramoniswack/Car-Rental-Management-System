Public Class UHomee
    Public Sub LoadRecord()
        cn.Open()
        'Dgv.Rows.Clear()
        Dim i As Integer

        cm = New SqlClient.SqlCommand("select *from tblcars", cn)
        dr = cm.ExecuteReader
        While dr.Read
            i = i + 1
            Dgv.Rows.Add(i, dr.Item("Carname"), dr.Item("Model"), dr.Item("Color"), dr.Item("Qty"))
        End While
        cn.Close()
    End Sub
    Public Sub Loadrecord1()
        cn.Open()
        Dgv1.Rows.Clear()
        Dim i As Integer

        cm = New SqlClient.SqlCommand("select *from tblcarrentals1", cn)
        dr = cm.ExecuteReader
        While dr.Read
            i = i + 1
            Dgv1.Rows.Add(i, dr.Item("CusID"), dr.Item("CustomerName"), dr.Item("CarID"), dr.Item("Carname"), dr.Item("PickupLocation"), dr.Item("RentDate"), dr.Item("ReturnDate"), dr.Item("Charges"))
        End While
        cn.Close()
    End Sub



    Private Sub BtnLogout_Click(sender As Object, e As EventArgs) Handles BtnLogout.Click
        Me.Hide()
        Dim obj As New Login
        obj.Show()
    End Sub


    Private Sub UHomee_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.TblcarsTableAdapter.Fill(Me.FleeteaseDataSet.tblcars)
        LoadRecord()
        Loadrecord1()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
        Dim obj As New Rent
        obj.Show()
    End Sub





End Class