Imports System.Drawing

Public Class Form1
    Private rect As Rectangle
    Private moveX As Integer = 10 ' Initial horizontal movement value
    Private moveY As Integer = 10 ' Initial vertical movement value

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Create a new rectangle with initial position and size
        rect = New Rectangle(10, 10, 50, 50)
    End Sub

    Private Sub Form1_Paint(sender As Object, e As PaintEventArgs) Handles MyBase.Paint
        ' Draw the rectangle on the Panel
        Using brush As New SolidBrush(Color.Red)
            e.Graphics.FillRectangle(brush, rect)
        End Using
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)
        ' Move the rectangle
        MoveRectangle()
        Me.Invalidate() ' Trigger the Paint event to redraw the rectangle
    End Sub

    Private Sub MoveRectangle()
        ' Check if the rectangle has reached the right or left edge of the Panel
        If rect.X + rect.Width >= Panel1.Width - rect.Width OrElse rect.X <= 0 Then
            ' Reverse the horizontal movement direction
            moveX = -moveX
        End If

        ' Check if the rectangle has reached the top or bottom edge of the Panel
        If rect.Y + rect.Height >= Panel1.Height - rect.Height OrElse rect.Y <= 0 Then
            ' Reverse the vertical movement direction
            moveY = -moveY
        End If

        ' Update the rectangle's position
        rect.X += moveX
        rect.Y += moveY
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        MoveRectangle()
        Me.Invalidate()
    End Sub
End Class