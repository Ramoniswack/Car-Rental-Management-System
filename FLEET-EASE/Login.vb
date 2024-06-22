Imports Microsoft.VisualBasic.ApplicationServices
Imports System.Data.SqlClient
Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class Login
    Public Property Loggedinusername As String
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

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
            cn.Open()
            cm = New SqlClient.SqlCommand("select *from tbllogin where username like '" & TxtUsername.Text & "' and password like '" & TxtPassword.Text & "'", cn)
            cm.Parameters.AddWithValue("@username", TxtUsername.Text)
            cm.Parameters.AddWithValue("@Password", TxtPassword.Text)
            dr = cm.ExecuteReader
            Dim dt As DataTable = New DataTable()
            dt.Load(dr)
            If dt.Rows.Count > 0 Then
                loggedinusername = dt.Rows(0)("Username").ToString()
                MessageBox.Show("Logged in as:" & dt.Rows(0)("Usertype"))

                If dt.Rows(0)("Usertype").ToString().ToLower() = "user" Then
                    cn.Close()

                    Dim u As New UHomee()
                    u.Show()
                    Me.Hide()
                ElseIf dt.Rows(0)("Usertype").ToString().ToLower() = "admin" Then
                    cn.Close()

                    Dim h As New Homee()
                    h.Show()
                    Me.Hide()
                Else
                    cn.Close()
                    MessageBox.Show("Invalid user type.")
                End If
            Else
                cn.Close()

                MsgBox("Invalid username or password")
            End If
        End If
    End Sub


    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked = True Then
            TxtPassword.UseSystemPasswordChar = False
        Else
            TxtPassword.UseSystemPasswordChar = True
        End If
    End Sub
End Class