Imports System.Data.SqlClient
Public Class UHomee
    Public Sub LoadRecord1()
        Try
            If cn.State = ConnectionState.Open Then
                cn.Close()
            End If
            cn.Open()
            Dgv.Rows.Clear()
            Dim i As Integer = 0
            cm = New SqlClient.SqlCommand("SELECT * FROM tblcars where active = 1", cn)
            Using dr As SqlDataReader = cm.ExecuteReader()
                While dr.Read()
                    i += 1
                    Dgv.Rows.Add(dr.Item("CarID"), dr.Item("Carname"), dr.Item("Model"), dr.Item("Color"), dr.Item("RegNumber"), dr.Item("Available"))
                End While
            End Using
        Catch ex As Exception
            MessageBox.Show("An error occurred while loading records: " & ex.Message)
        Finally
            If cn.State = ConnectionState.Open Then
                cn.Close()
            End If
        End Try
    End Sub
    Public Sub Loadrecord()
        Try
            If cn.State = ConnectionState.Open Then
                cn.Close()
            End If
            cn.Open()
            Dgv1.Rows.Clear()
            Dim i As Integer = 0
            cm = New SqlClient.SqlCommand("SELECT cr.* FROM tblcarrentals3 cr " &
                                      "INNER JOIN tblcars c ON cr.CarID = c.CarID " &
                                      "WHERE (cr.iscancelled = 0 OR cr.iscancelled IS NULL) " &
                                      "AND c.Available = 'NO' AND c.Active = 1", cn)
            'cm = New SqlClient.SqlCommand("SELECT cr.* FROM tblcarrentals3 cr " &
            '                      "INNER JOIN tblcars c ON cr.CarID = c.CarID " &
            '                      "WHERE (cr.iscancelled = 0 OR cr.iscancelled IS NULL) ", cn)
            Using dr As SqlDataReader = cm.ExecuteReader()
                While dr.Read()
                    i += 1
                    Dgv1.Rows.Add(i, dr.Item("RegNumber"), dr.Item("CusName"), dr.Item("PickupLocation"), dr.Item("RentDate"), dr.Item("ReturnDate"), dr.Item("Charges"))
                End While
            End Using
        Catch ex As Exception
            MessageBox.Show("An error occurred while loading records: " & ex.Message)
        Finally
            If cn.State = ConnectionState.Open Then
                cn.Close()
            End If
        End Try
    End Sub
    Private Sub BtnLogout_Click(sender As Object, e As EventArgs)
        Me.Hide()
        Dim obj As New Login
        obj.Show()
    End Sub
    Private Sub UHomee_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Dim loginform As Login = DirectCast(Application.OpenForms("Login"), Login)
        'LoggedInUsename = ""
        'If loginform IsNot Nothing Then
        '    LblUsername.Text = loginform.LoggedInUsename
        'End If
        'Me.TblcarsTableAdapter.Fill(Me.FleeteaseDataSet.tblcars)
        UpdateUsername()
        Loadrecord()
        LoadRecord1()
    End Sub
    Public Sub UpdateUsername()
        LblUsername.Text = Module1.LoggedInUsename
    End Sub
    Private Sub BtnCustomers_Click_1(sender As Object, e As EventArgs) Handles BtnCustomers.Click
        Me.Hide()
        Dim oBJ As New UCustomers()
        oBJ.Show()
    End Sub
    Private Sub BtnRent_Click(sender As Object, e As EventArgs) Handles BtnRent.Click
        Me.Hide()
        Dim oBJ As New Rent()
        oBJ.Show()
    End Sub
    Private Sub BtnCheckout_Click(sender As Object, e As EventArgs) Handles BtnCheckout.Click
        Me.Hide()
        Dim oBJ As New CheckOut()
        oBJ.Show()
    End Sub
    Private Sub BtnSettings_Click(sender As Object, e As EventArgs) Handles BtnSettings.Click
        Me.Hide()
        Dim oBJ As New Settings()
        oBJ.Show()
    End Sub
    Private Sub BtnLogout_Click_1(sender As Object, e As EventArgs) Handles BtnLogout.Click
        LoggedInUsename = ""
        Me.Hide()
        Dim obj As New Login
        obj.Show()
    End Sub
    Private Sub BtnCancel_Click(sender As Object, e As EventArgs) Handles BtnCancel.Click
        Me.Hide()
        Dim obj As New Cancel
        obj.Show()
    End Sub
End Class