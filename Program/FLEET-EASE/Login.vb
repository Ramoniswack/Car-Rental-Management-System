
Imports Microsoft.VisualBasic.ApplicationServices
Imports System.Data.SqlClient
Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.Button
Public Class Login
    Public Property LoggedInUsename As String

    Private Sub BtnGetStarted_Click(sender As Object, e As EventArgs) Handles BtnLogin.Click
        If TxtUsername.Text = "" Then
            MsgBox("Enter a Username")
            TxtUsername.Select()
            Exit Sub
        ElseIf TxtPassword.Text = "" Then
            MsgBox("Enter the password")
            TxtPassword.Select()
            Exit Sub
        Else
            Try
                cn.Open()
                Dim query As String = "SELECT * FROM tbllogin where username = @username COLLATE Latin1_General_CS_AS AND password = @password COLLATE Latin1_General_CS_AS AND active = 1"
                cm = New SqlClient.SqlCommand(query, cn)
                cm.Parameters.AddWithValue("@username", TxtUsername.Text)
                cm.Parameters.AddWithValue("@password", TxtPassword.Text)
                Dim dt As New DataTable()
                Dim adapter As New SqlDataAdapter(cm)
                adapter.Fill(dt)
                If dt.Rows.Count > 0 Then
                    LoggedInUsename = dt.Rows(0)("Username").ToString()
                    Module1.LoggedInUsename = LoggedInUsename  ' Update the global variable
                    '  MessageBox.Show("Logged in as: " & dt.Rows(0)("Usertype"))
                    ' Update LastLoginDate and increment LoginCount
                    Dim updateQuery As String = "UPDATE tbllogin SET LastLoginDate = @lastLoginDate, LoginCount = ISNULL(LoginCount, 0) + 1 WHERE Username = @username COLLATE Latin1_General_CS_AS"
                    Dim updateCmd As New SqlClient.SqlCommand(updateQuery, cn)
                    updateCmd.Parameters.AddWithValue("@lastLoginDate", DateTime.Now)
                    updateCmd.Parameters.AddWithValue("@username", LoggedInUsename)
                    updateCmd.ExecuteNonQuery()
                    If dt.Rows(0)("Usertype").ToString().ToLower() = "user" Then
                        Dim u As New UHomee()
                        u.UpdateUsername()
                        u.Show()
                        Me.Hide()
                    ElseIf dt.Rows(0)("Usertype").ToString().ToLower() = "admin" Then
                        Dim h As New Homee()
                        h.UpdateUsername()
                        h.Show()
                        Me.Hide()
                    Else
                        MessageBox.Show("Invalid user type.")
                    End If
                Else
                    MsgBox("Invalid username or password")
                End If
            Catch ex As Exception
                MessageBox.Show("An error occurred: " & ex.Message)
            Finally
                If cn.State = ConnectionState.Open Then cn.Close()
            End Try
        End If
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        TxtPassword.UseSystemPasswordChar = Not CheckBox1.Checked
    End Sub
End Class