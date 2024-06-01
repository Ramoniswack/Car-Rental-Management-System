Public Class Register
    Private Sub LblLogin_Click(sender As Object, e As EventArgs) Handles LblRegister.Click

    End Sub

    Private Sub BtnGetStarted_Click(sender As Object, e As EventArgs) Handles BtnCancel.Click
        Me.Hide()
        Dim obj As New Login
        obj.Show()
    End Sub

    Private Sub BtnExit_Click(sender As Object, e As EventArgs) Handles BtnExit.Click
        Me.Hide()
    End Sub

    Private Sub LogoFleetEase_Click(sender As Object, e As EventArgs) Handles LogoUserpic.Click

    End Sub
End Class