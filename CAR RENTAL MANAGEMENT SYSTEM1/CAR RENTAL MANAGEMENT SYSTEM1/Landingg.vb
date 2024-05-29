Public Class Landingg
    Private Sub btngetstarted_Click(sender As Object, e As EventArgs) Handles btngetstarted.Click
        Me.Hide()
        Dim obj As New LOGIN
        obj.Show()
    End Sub

    Private Sub btnExitLanding_Click(sender As Object, e As EventArgs) Handles btnExitLanding.Click
        Me.Hide()
    End Sub
End Class