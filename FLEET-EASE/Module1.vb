Imports System.Data.SqlClient
Module Module1
    Public cn As New SqlConnection("Data Source=SUBASHGURUNG\SUBASH;Initial Catalog=fleetease;Integrated Security=True;")
    Public cm As New SqlCommand
    Public dr As SqlDataReader

    Public LoggedInUsename As String = ""


End Module
