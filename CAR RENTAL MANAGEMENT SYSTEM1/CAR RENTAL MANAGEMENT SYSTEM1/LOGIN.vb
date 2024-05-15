Imports Microsoft.VisualBasic.ApplicationServices
Imports System.Data.SqlClient

Public Class LOGIN

    Private Sub Btnlogin_Click(sender As Object, e As EventArgs) Handles Btnlogin.Click
        Dim Con As String
        Con = "Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\PROJECT\CAR-RENTAL-SYSTEM\CAR RENTAL MANAGEMENT SYSTEM1\CAR RENTAL MANAGEMENT SYSTEM1\CRMS.mdf;Integrated Security=True"
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Btnbrowse.Click
        OpenFileDialog1.ShowDialog()
        Loginpicture.Load(OpenFileDialog1.FileName)
    End Sub



    Private Sub TxtUsername_Leave(sender As Object, e As EventArgs) Handles TxtUsername.Leave
        If String.IsNullOrEmpty(TxtUsername.Text) = True Then
            TxtUsername.Focus()
            ErrorProvider1.SetError(TxtUsername, "ENTER YOUR USERNAME TO LOGIN")
        Else
            ErrorProvider1.SetError(TxtUsername, String.Empty)
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
        obj.show()
    End Sub


End Class