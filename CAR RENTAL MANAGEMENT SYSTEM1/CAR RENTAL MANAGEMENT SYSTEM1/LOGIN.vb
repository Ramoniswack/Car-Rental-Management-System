Imports Microsoft.VisualBasic.ApplicationServices
Imports System.Data.SqlClient
Imports System.Diagnostics.Eventing

Public Class LOGIN
    Dim connectionstring As String = "Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\PROJECT\CAR-RENTAL-SYSTEM\CAR RENTAL MANAGEMENT SYSTEM1\CAR RENTAL MANAGEMENT SYSTEM1\CRMS.mdf;Integrated Security=True"



    Private Sub Btnlogin_Click(sender As Object, e As EventArgs) Handles Btnlogin.Click
        Dim email As String
        Dim password As String
        ' Dim usertype As String


        email = Txtemail.Text
        password = Txtpassword.Text


        Dim con As New SqlConnection(connectionstring)
        Dim query As String = " select usertype from USERS where email= @email And passwordd = @password"
        Dim cmd As New SqlCommand(query, con)
        cmd.Parameters.AddWithValue("@email", email)
        cmd.Parameters.AddWithValue("@password", password)
        '  cmd.Parameters.AddWithValue("@usertype", usertype)

        Dim usertype As String = String.Empty



        con.Open()
        Dim reader As SqlDataReader = cmd.ExecuteReader()

        If reader.HasRows Then
            While reader.Read()
                usertype = reader("usertype").ToString().ToLower()
            End While

            If usertype = "USER" Then
                Me.Close()
                Dim userinterface As New User_interface
                userinterface.Show()
            ElseIf usertype = "ADMIN" Then
                Me.Close()
                Dim admininterface As New admin_interface
                admininterface.Show()
            Else
                MessageBox.Show("INVALID USER TYPE")
            End If
        Else
            MessageBox.Show("INVALID EMAIL OR PASSWORD")

        End If





        reader.Close()
        con.Close()





    End Sub


    Private Sub TxtUsername_Leave(sender As Object, e As EventArgs) Handles Txtemail.Leave
        If String.IsNullOrEmpty(Txtemail.Text) = True Then
            Txtemail.Focus()
            ErrorProvider1.SetError(Txtemail, "ENTER YOUR USERNAME TO LOGIN")
        Else
            ErrorProvider1.SetError(Txtemail, String.Empty)
        End If
    End Sub



    Private Sub Txtpassword_Leave(sender As Object, e As EventArgs) Handles Txtpassword.Leave

        If String.IsNullOrEmpty(Txtpassword.Text) = True Then
            Txtpassword.Focus()
            ErrorProvider1.SetError(Txtpassword, "ENTER A PASSWORD")
        Else
            ErrorProvider1.SetError(Txtpassword, String.Empty) ' Clear the error message
        End If
    End Sub


    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked = True Then
            Txtpassword.PasswordChar = ""
        Else
            Txtpassword.PasswordChar = "*"
        End If
    End Sub


    Private Sub Btncancel_Click(sender As Object, e As EventArgs) Handles Btncancel.Click
        Me.Close()
        Dim obj As New Form1
        obj.Show()
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Me.Hide()
        Dim obj As New Registration
        obj.Show()
    End Sub


End Class