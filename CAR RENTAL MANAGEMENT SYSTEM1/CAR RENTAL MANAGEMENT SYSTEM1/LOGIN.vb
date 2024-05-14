Imports Microsoft.VisualBasic.ApplicationServices

Public Class LOGIN

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        OpenFileDialog1.ShowDialog()
        Loginpicture.Load(OpenFileDialog1.FileName)
    End Sub



    Private Sub TxtUsername_Leave(sender As Object, e As EventArgs) Handles TxtUsername.Leave
        If String.IsNullOrEmpty(TxtUsername.Text) = True Then
            TxtUsername.Focus()
            ErrorProvider1.SetError(TxtUsername, "Please enter something in this field")
        Else
            ErrorProvider1.SetError(TxtUsername, String.Empty)
        End If
    End Sub



    Private Sub Txtpassword_Leave(sender As Object, e As EventArgs) Handles Txtpassword.Leave

        If String.IsNullOrEmpty(Txtpassword.Text) = True Then
            Txtpassword.Focus()
            ErrorProvider1.SetError(Txtpassword, "Please enter a password")
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
End Class