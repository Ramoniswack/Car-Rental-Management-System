Public Class Login

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
        Dim obj As New AdminView
        obj.Show()
    End Sub

    Private Sub BtnGetStarted_Click(sender As Object, e As EventArgs) Handles BtnGetStarted.Click
        Me.Hide()
        Dim obj As New Form1
        obj.Show()
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkRegister.LinkClicked
        Me.Hide()
        Dim obj As New Register
        obj.Show()
    End Sub

    Private Sub BtnExit_Click(sender As Object, e As EventArgs) Handles BtnExit.Click
        Me.Hide()
    End Sub
End Class