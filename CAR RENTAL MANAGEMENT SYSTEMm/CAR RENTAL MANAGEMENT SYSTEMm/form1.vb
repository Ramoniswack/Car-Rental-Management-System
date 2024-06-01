Public Class Form1


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles BtnGetStarted.Click
        TimerLoadLanding.Enabled = True

        Me.Hide()
        Dim Obj As New Login
        Obj.Show()
    End Sub

    Private Sub BtnExit_Click(sender As Object, e As EventArgs) Handles BtnExit.Click
        Me.Hide()
    End Sub

    Private Sub ProgressBar1_Click(sender As Object, e As EventArgs)

    End Sub


End Class
