'Imports System.Data.SqlClient

'Public Class Cancel
'    ' Define connection string and SQL objects
'    Dim ConnectionString As String = "Data Source=DESKTOP-FE6OBHL\SQLEXPRESS;Initial Catalog=fleetease;Integrated Security=True;"
'    Dim cn As New SqlConnection(ConnectionString)
'    Dim cm As New SqlCommand
'    Dim dr As SqlDataReader

'    Private Sub Cancel_Load(sender As Object, e As EventArgs) Handles MyBase.Load
'        ' Load data into DataGridView when form loads
'        LoadRecord1()

'        ' Display logged-in username if applicable (assuming LblUsername is a label)
'        Dim loginform As Login = DirectCast(Application.OpenForms("Login"), Login)
'        If loginform IsNot Nothing Then
'            LblUsername.Text = loginform.Loggedinusername
'        End If

'        ' Set DataGridView properties
'        Dgv1.SelectionMode = DataGridViewSelectionMode.FullRowSelect
'        Dgv1.MultiSelect = False
'    End Sub

'    Private Sub LoadRecord1()
'        Try
'            cn.Open()
'            Dgv1.Rows.Clear()
'            Dim query As String = "SELECT RegNumber, CusName, PickupLocation, RentDate, ReturnDate, Charges FROM tblcarrentals3"
'            cm = New SqlCommand(query, cn)
'            dr = cm.ExecuteReader()
'            Dim i As Integer = 0
'            While dr.Read()
'                i += 1
'                Dgv1.Rows.Add(i, dr("RegNumber"), dr("CusName"), dr("PickupLocation"), dr("RentDate"), dr("ReturnDate"), dr("Charges"))
'            End While
'            dr.Close()
'        Catch ex As Exception
'            MessageBox.Show("Error loading records: " & ex.Message)
'        Finally
'            cn.Close()
'        End Try
'    End Sub

'    Private Sub btncancel_Click(sender As Object, e As EventArgs) Handles Btncancel.Click
'        ' Check if a row is selected
'        If Dgv1.SelectedRows.Count = 0 Then
'            MessageBox.Show("Please select a rental record to cancel.")
'            Return
'        End If

'        Try
'            ' Get the selected row
'            Dim selectedRow As DataGridViewRow = Dgv1.SelectedRows(0)

'            ' Extract necessary information from the selected row
'            Dim regNumber As String = If(selectedRow.Cells("RegNumber").Value IsNot DBNull.Value AndAlso selectedRow.Cells("RegNumber").Value IsNot Nothing, selectedRow.Cells("RegNumber").Value.ToString(), "")

'            ' Open connection
'            cn.Open()

'            ' Find the corresponding CarID in tblcars based on RegNumber
'            Dim query As String = "SELECT CarID FROM tblcars WHERE RegNumber = @RegNumber"
'            cm = New SqlCommand(query, cn)
'            cm.Parameters.AddWithValue("@RegNumber", regNumber)

'            ' Execute query to get CarID
'            Dim carID As Integer = Convert.ToInt32(cm.ExecuteScalar())

'            If carID > 0 Then
'                ' Perform cancellation: Delete from tblcarrentals3 or update status depending on your application logic
'                ' For example, you can delete from tblcarrentals3:
'                Dim deleteQuery As String = "DELETE FROM tblcarrentals3 WHERE CarID = @CarID"
'                cm = New SqlCommand(deleteQuery, cn)
'                cm.Parameters.AddWithValue("@CarID", carID)
'                cm.ExecuteNonQuery()

'                MessageBox.Show("Rental record cancelled successfully.")
'                LoadRecord1() ' Refresh DataGridView after cancellation
'            Else
'                MessageBox.Show("Selected rental record not found.")
'            End If
'        Catch ex As Exception
'            MessageBox.Show("Error cancelling rental: " & ex.Message)
'        Finally
'            ' Close connection
'            cn.Close()
'        End Try
'    End Sub

'    Private Sub BtnLogout_Click(sender As Object, e As EventArgs) Handles BtnLogout.Click
'        ' Logout functionality: Hide current form and show Login form
'        Me.Hide()
'        Dim obj As New Login
'        obj.Show()
'    End Sub

'    ' Other event handlers for navigation buttons (if applicable)
'    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
'        Me.Hide()
'        Dim obj As New UHomee()
'        obj.Show()
'    End Sub

'    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
'        Me.Hide()
'        Dim obj As New UCustomers
'        obj.Show()
'    End Sub

'    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
'        Me.Hide()
'        Dim obj As New CheckOut
'        obj.Show()
'    End Sub

'    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
'        Me.Hide()
'        Dim settingsForm As New Settings
'        settingsForm.Show()
'    End Sub

'    Private Sub Dgv1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles Dgv1.CellContentClick
'        ' This event handler is empty. You can add code here if you need to handle cell clicks.
'    End Sub
'End Class