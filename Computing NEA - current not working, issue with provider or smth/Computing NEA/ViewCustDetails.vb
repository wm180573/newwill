Public Class ViewCustDetails
    Private Sub BtnMenu_Click(sender As Object, e As EventArgs) Handles BtnMenu.Click
        ' Hides current form
        Me.Hide()
        ' Shows staff menu
        StaffMenu.Show()
    End Sub

    Private Sub BtnCustSearch_Click(sender As Object, e As EventArgs) Handles BtnCustSearch.Click
        ' Define connection
        Dim conn As New System.Data.OleDb.OleDbConnection()
        ' Define database location for connection
        conn.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\ipr0z\Downloads\MongooseGames.accdb"
        ' Retrieves the record of the customer with the username that the staff member inputs
        Dim sql As String = "SELECT CustomerID,FirstName,Surname,PhoneNum,Address,County,Town,Postcode FROM Customers WHERE (CustUser) = ('" & TxtCustUser.Text & "')"
        ' Allows sql command to communicate with the data source
        Dim sqlCom As New System.Data.OleDb.OleDbCommand(sql)
        'Open Database Connection
        sqlCom.Connection = conn
        conn.Open()
        ' Provides a way of reading the data rows from the database
        Dim sqlRead As System.Data.OleDb.OleDbDataReader = sqlCom.ExecuteReader()
        ' Executes following code if there are records found
        If sqlRead.HasRows Then
            ' This while loop populates the relevant textbox with the corresponding information from the database until finished.
            While sqlRead.Read()
                TxtCustID.Text = sqlRead.Item("CustomerID")
                TxtCustName.Text = sqlRead.Item("FirstName")
                TxtCustSurname.Text = sqlRead.Item("Surname")
                TxtCustPhone.Text = sqlRead.Item("PhoneNum")
                TxtCustAddress.Text = sqlRead.Item("Address")
                TxtCustCounty.Text = sqlRead.Item("County")
                TxtCustTown.Text = sqlRead.Item("Town")
                TxtCustPostcode.Text = sqlRead.Item("Postcode")
                ' Informs the staff member of their success of searching for a customer
                MessageBox.Show("Customer found", "Searching of customer details successful")
            End While
            ' Close connection between sql and database
            sqlRead.Close()
        Else
            ' If there are no customers with the username that the staff member inputted in the system they are informed of this and prompted to try again.
            MessageBox.Show("No customer with the username of " & TxtCustUser.Text & " & "" was found. Please try again", "Error while searching for customer details")
            ' The customer username field is then cleared to faciliate the re-population of the textbox
            TxtCustUser.Clear()
        End If
        ' Connection of the database is closed
        conn.Close()
    End Sub
End Class