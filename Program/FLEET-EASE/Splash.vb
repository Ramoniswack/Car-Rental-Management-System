Imports System.Windows.Forms

Public Class Splash
    Dim i As Integer

    Private Sub ProgressBar1_Click(sender As Object, e As EventArgs) Handles ProgressBar1.Click
        ' This event handler is not needed for the desired functionality
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles BtnGo.Click
        Timer1.Enabled = True
        ProgressBar1.Maximum = 100
        i = 1
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If ProgressBar1.Value < ProgressBar1.Maximum Then
            ProgressBar1.Value += 1
            Label2.Text = "Process " & ProgressBar1.Value & " % Completed "
        Else
            Timer1.Enabled = False
            ' Open the Login form
            Dim obj As New Login
            obj.Show()
            Me.Hide() ' Hide the Splash form
        End If
    End Sub

    Private Sub Splash_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Interval = 10
    End Sub
End Class