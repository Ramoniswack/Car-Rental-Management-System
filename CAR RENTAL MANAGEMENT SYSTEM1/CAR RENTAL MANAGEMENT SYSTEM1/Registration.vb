Public Class Registration
    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Me.Hide()
        Dim Obj As New LOGIN
        Obj.Show()
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
End Class