Imports Microsoft.VisualBasic.ApplicationServices

Public Class LOGIN

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        OpenFileDialog1.ShowDialog()
        Loginpicture.Load(OpenFileDialog1.FileName)
    End Sub



    Private Sub txtUsername_Leave(sender As Object, e As EventArgs) Handles txtUsername.Leave
        If String.IsNullOrEmpty(txtUsername.Text) = True Then
            txtUsername.Focus()
            'Dim errorProvider As New ErrorProvider()
            'Dim txtUsername As TextBox = Me.UsernameTextBox

            ErrorProvider1.SetError(txtUsername, "Please enter something in this field")
        Else
            ErrorProvider1.Clear(txtUsername.Text, String.Empty)
        End If

    End Sub


    Private Sub txtpassword_Leave(sender As Object, e As EventArgs) Handles txtpassword.Leave
        If Private Sub() txtUsername_Leave(sender As Object, e As EventArgs) Handles txtUsername.Leave
             If String.IsNullOrEmpty(txtUsername.Text) = True Then
                txtUsername.Focus()
                ErrorProvider1.SetError(txtUsername, "Please enter something in this field")
            Else
                ErrorProvider1.SetError(txtUsername, String.Empty) ' Clear the error message
            End If





    End Sub
End Class