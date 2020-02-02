
' Allows the database defined in the system configuration to be used
Imports System.Configuration
' Allows connection to be established with the connection string and the program
Imports System.Data
Imports System.Data.OleDb
Public Class ViewCustomerRequests
    Private Sub ViewCustomerRequests_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Sets data source which will be the function returning the data table
        CustomerRequestDataGridView.DataSource = GetCustomerRequests()

    End Sub

    ' Creates function which returns the table to the staff member
    Private Function GetCustomerRequests() As DataTable

        ' Defines the data table
        Dim CustRequests As New DataTable

        ' Fills data table with data from the database
        Dim connString As String = ConfigurationManager.ConnectionStrings("Computing_NEA.My.MySettings.MongooseGamesConnectionString").ConnectionString

        ' Allows sql statement to be performed on the database
        Using conn As New OleDbConnection(connString)
            ' SQL Statement which shows all of the data to the staff member in the table
            Using cmd As New OleDbCommand("SELECT * FROM CustRequests", conn)

                ' Opens connection to the database
                conn.Open()
                ' As SELECT statement is being used, reader is used, allows data to be read and sent to the form
                Dim reader As OleDbDataReader = cmd.ExecuteReader()

                ' Loads the reader data into the form
                CustRequests.Load(reader)
            End Using
        End Using


        ' The function returns the data table
        Return CustRequests

    End Function

    Private Sub BtnMenu_Click(sender As Object, e As EventArgs) Handles BtnMenu.Click
        ' Hides current form
        Me.Hide()
        ' Shows staff menu
        StaffMenu.Show()
    End Sub
End Class