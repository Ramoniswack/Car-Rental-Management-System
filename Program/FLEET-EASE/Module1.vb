Imports System.Data.SqlClient
Module Module1
    Public cn As New SqlConnection("Data Source=DESKTOP-FE6OBHL\SQLEXPRESS;Initial Catalog=fleetease;Integrated Security=True;")
    Public cm As New SqlCommand
    Public dr As SqlDataReader

    Public LoggedInUsename As String = ""

    Public Property CurrentloggedInUser As String = ""
End Module
