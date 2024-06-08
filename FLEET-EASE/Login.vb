Imports Microsoft.VisualBasic.ApplicationServices
Imports System.Data.SqlClient
Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class Login
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub BtnGetStarted_Click(sender As Object, e As EventArgs) Handles BtnLogin.Click
        '    Try
        '        ' Check the state of the connection and open it if necessary
        '        If con.State = ConnectionState.Open Then
        '            con.Close()
        '        End If
        '        con.Open()

        '        If TextBox1.Text = "" Then
        '            MsgBox("Enter Username.", MsgBoxStyle.Critical)
        '        ElseIf TextBox2.Text = "" Then
        '            MsgBox("Enter Password.", MsgBoxStyle.Critical)
        '        Else
        '            ' Use COLLATE keyword to enforce case-sensitive comparison
        '            Dim query As String = "SELECT * FROM login WHERE username COLLATE Latin1_General_BIN = @username AND password COLLATE Latin1_General_BIN = @password AND usertype = @type"
        '            cmd = New SqlCommand(query, con)
        '            cmd.Parameters.AddWithValue("@username", TextBox1.Text)
        '            cmd.Parameters.AddWithValue("@password", TextBox2.Text)
        '            cmd.Parameters.AddWithValue("@type", ComboBox1.SelectedItem)

        '            Dim das As SqlDataAdapter = New SqlDataAdapter(cmd)
        '            Dim ds As DataSet = New DataSet()
        '            das.Fill(ds)

        '            Dim a As Integer = ds.Tables(0).Rows.Count
        '            If a = 0 Then
        '                MsgBox("Failed", MsgBoxStyle.Critical)
        '            ElseIf ComboBox1.SelectedItem = "admin" Then
        '                admin.Show()
        '                Me.Hide()
        '            ElseIf ComboBox1.SelectedItem = "user" Then
        '                user.Show()
        '                Me.Hide()
        '            End If
        '        End If

        '    Catch ex As SqlException
        '        MsgBox("SQL Error: " & ex.Message, MsgBoxStyle.Critical)
        '    Catch ex As Exception
        '        MsgBox("Error: " & ex.Message, MsgBoxStyle.Critical)
        '    Finally
        '        If con.State = ConnectionState.Open Then
        '            con.Close()
        '        End If
        '    End Try
        'End Sub

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
            dr = cm.ExecuteReader
            Dim dt As DataTable = New DataTable()
            dt.Load(dr)
            If dt.Rows.Count > 0 Then
                MessageBox.Show("Logged in as:" & dt.Rows(0)("Usertype"))

                If dt.Rows(0)("Usertype").ToString().ToLower() = "user" Then
                    cn.Close()

                    Dim u As New UHomee
                    u.Show()
                    Me.Hide()
                ElseIf dt.Rows(0)("Usertype").ToString().ToLower() = "admin" Then
                    cn.Close()

                    Dim h As New Homee
                    h.Show()
                    Me.Hide()
                Else
                    MessageBox.Show("Invalid user type.")
                End If
            Else
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