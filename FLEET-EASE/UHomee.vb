Public Class UHomee

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



    Private Sub BtnLogout_Click(sender As Object, e As EventArgs) Handles BtnLogout.Click
        Me.Hide()
        Dim obj As New Login
        obj.Show()
    End Sub


    Private Sub UHomee_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim loginform As Login = DirectCast(Application.OpenForms("Login"), Login)
        If loginform IsNot Nothing Then
            LblUsername.Text = loginform.loggedinusername

        End If








        'Me.TblcarsTableAdapter.Fill(Me.FleeteaseDataSet.tblcars)
        LoadRecord()
        Loadrecord1()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
        Dim obj As New Rent
        obj.Show()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Hide()
        Dim obj As New UCustomers
        obj.Show()
    End Sub

    Private Sub Dgv1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles Dgv1.CellContentClick

    End Sub

    Private Sub Dgv_CellContentClick(sender As Object, e As DataGridViewCellEventArgs)

    End Sub

    Private Sub BtnHome_Click(sender As Object, e As EventArgs) Handles BtnHome.Click

    End Sub

    Private Sub Dgv_CellContentClick_1(sender As Object, e As DataGridViewCellEventArgs) Handles Dgv.CellContentClick

    End Sub

    Private Sub BtnCustomers_Click(sender As Object, e As EventArgs) Handles BtnCustomers.Click
        Me.Hide()
        Dim obj As New CheckOut
        obj.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Hide()
        Dim obj As New Settings
        obj.Show()
    End Sub

    Private Sub Panel4_Paint(sender As Object, e As PaintEventArgs) Handles Panel4.Paint

    End Sub

    Private Sub Panel3_Paint(sender As Object, e As PaintEventArgs) Handles Panel3.Paint

    End Sub

    Private Sub Panel7_Paint(sender As Object, e As PaintEventArgs) Handles Panel7.Paint

    End Sub

    Private Sub Panel5_Paint(sender As Object, e As PaintEventArgs) Handles Panel5.Paint

    End Sub

    Private Sub Panel2_Paint(sender As Object, e As PaintEventArgs) Handles Panel2.Paint

    End Sub

    Private Sub LblUsername_Click(sender As Object, e As EventArgs) Handles LblUsername.Click

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Panel6_Paint(sender As Object, e As PaintEventArgs) Handles Panel6.Paint

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub PictureBox7_Click(sender As Object, e As EventArgs) Handles PictureBox7.Click

    End Sub

    Private Sub PictureBox5_Click(sender As Object, e As EventArgs) Handles PictureBox5.Click

    End Sub

    Private Sub PictureBox4_Click(sender As Object, e As EventArgs) Handles PictureBox4.Click

    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click

    End Sub

    Private Sub PictureBox6_Click(sender As Object, e As EventArgs) Handles PictureBox6.Click

    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub

    Private Sub Fleetease_Click(sender As Object, e As EventArgs) Handles Fleetease.Click

    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Me.Hide()
        Dim obj As New Cancel
        obj.Show()
    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click

    End Sub

    Private Sub Panel10_Paint(sender As Object, e As PaintEventArgs) Handles Panel10.Paint

    End Sub
End Class