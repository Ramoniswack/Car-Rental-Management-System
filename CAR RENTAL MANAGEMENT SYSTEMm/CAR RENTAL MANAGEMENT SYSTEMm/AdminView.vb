Public Class AdminView


    Private Sub LblTransactions_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LblTransactions.LinkClicked
        Me.Hide()
        Dim obj As New TransactionsInfo
        obj.Show()
    End Sub

    Private Sub LblVehicleInfo_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LblVehicleInfo.LinkClicked
        Me.Hide()
        Dim obj As New VehicleInfo
        obj.Show()
    End Sub

    Private Sub Lbluserinfo_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles Lbluserinfo.LinkClicked
        Me.Hide()
        Dim obj As New UserInfo
        obj.Show()
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Me.Hide()
        Dim obj As New CustomerInfo
        obj.Show()
    End Sub
End Class