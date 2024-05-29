Imports System.Configuration
Imports System.Data.SqlClient
Imports System.Windows.Forms.AxHost
Public Class Registration

    Dim connectionstring As String = "Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\PROJECT\CAR-RENTAL-SYSTEM\CAR RENTAL MANAGEMENT SYSTEM1\CAR RENTAL MANAGEMENT SYSTEM1\CRMS.mdf;Integrated Security=True"



    Private Sub BtnRegister_Click(sender As Object, e As EventArgs) Handles BtnRegister.Click
        Dim Usertype As String
        Dim Username As String
        Dim Password As String
        Dim contact As Long
        Dim email As String
        Usertype = Txtusertype.Text
        Username = TxtUsername.Text
        Password = TxtPassword.Text
        contact = Convert.ToUInt64(TxtContact.Text)
        email = TxtEmail.Text
        ' MessageBox.Show(Usertype & vbNewLine & Username & vbNewLine & Password & vbNewLine & contact & vbNewLine & email)
        Dim query As String = " insert into Users " _
+ "values(' " & Usertype & "','" & Username & "','" & Password & "','" & contact & "','" & email & "')"

        Dim con As New SqlConnection(connectionstring)

        con.Open()
        Dim command As New SqlCommand(query, con)

        Dim idata As Integer = command.ExecuteNonQuery
        If idata > 0 Then
            MsgBox("Data has benn inserted succesfully")

        End If
        con.Close()


    End Sub




    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Me.Hide()
        Dim Obj As New LOGIN
        Obj.Show()
    End Sub

    Private Sub ComboBox1_Leave(sender As Object, e As EventArgs) Handles Txtusertype.Leave
        If String.IsNullOrEmpty(Txtusertype.Text) = True Then
            Txtusertype.Focus()
            ErrorProvider1.SetError(Txtusertype, " SELECT THE USER TYPE FIRST")
        Else
            ErrorProvider1.SetError(Txtusertype, String.Empty)

        End If
    End Sub

    Private Sub CheckPassword_CheckedChanged(sender As Object, e As EventArgs) Handles CheckPassword.CheckedChanged, TxtPassword.Leave
        If CheckPassword.Checked = True Then
            TxtPassword.PasswordChar = ""
        Else
            TxtPassword.PasswordChar = "*"
        End If
    End Sub


    Private Sub TxtPassword_TextChanged(sender As Object, e As EventArgs) Handles TxtPassword.TextChanged
        If String.IsNullOrEmpty(TxtPassword.Text) = True Then
            TxtPassword.Focus()
            ErrorProvider1.SetError(TxtPassword, " ENTER A PASSWORD")
        Else
            ErrorProvider1.SetError(TxtPassword, String.Empty)
        End If

    End Sub

    Private Sub CheckUsername_CheckedChanged(sender As Object, e As EventArgs) Handles TxtUsername.Leave
        If String.IsNullOrEmpty(TxtUsername.Text) = True Then
            TxtUsername.Focus()
            ErrorProvider1.SetError(TxtUsername, "ENTER A USERNAME")
        Else
            ErrorProvider1.SetError(TxtUsername, String.Empty)
        End If
    End Sub

    Private Sub TxtRegistration_Click(sender As Object, e As EventArgs) Handles TxtRegistration.Click

    End Sub



    Private Sub TxtContact_Leave(sender As Object, e As EventArgs) Handles TxtContact.Leave
        If String.IsNullOrEmpty(TxtContact.Text) = True Then
            TxtContact.Focus()
            ErrorProvider1.SetError(TxtContact, "ENTER YOUR CONTACT NUMBER")
        Else
            ErrorProvider1.SetError(TxtContact, String.Empty)
        End If
    End Sub

    Private Sub Loginpicture_Click(sender As Object, e As EventArgs) Handles Loginpicture.Click

    End Sub

    Private Sub Btnbrowse_Click(sender As Object, e As EventArgs) Handles Btnbrowse.Click
        OpenFileDialog1.ShowDialog()
        Loginpicture.Load(OpenFileDialog1.FileName)
    End Sub
End Class