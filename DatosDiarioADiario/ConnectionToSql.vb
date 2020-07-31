Imports System.Data.SqlClient

Public MustInherit Class ConnectionToSql
    Public connectionString As String
    Protected Sub New()
        connectionString = "Data Source=DESKTOP-GL2VC9T\SQLSERVER;Initial Catalog=DDBD;Persist Security Info=True;User ID=sa;Password=54325432a"

    End Sub
    Protected Function GetConnection() As SqlConnection
        Return New SqlConnection(connectionString)
    End Function
End Class

