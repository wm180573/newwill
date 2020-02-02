Public Class UpdateCustDetails
    Private Sub BtnUpd_Click(sender As Object, e As EventArgs) Handles BtnUpd.Click
        ' Converts the textbox value for the CustomerID into an integer to enalbe for it to be used in the SQL statement
        Dim CustomerID As Integer = Convert.ToDouble(txtCustID.Text)

        ' Create connection to the database
        Dim conn As New System.Data.OleDb.OleDbConnection()
        ' Defines location of the database
        conn.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\ipr0z\Downloads\MongooseGames.accdb"
        ' SQL (Structured Query Lanugage) statement which changes the value of the desired field to the desired value in the record of the desired customer
        Dim sql As String = "UPDATE Customers SET " & FieldName.SelectedItem & " = """ & txtNewData.Text & """ WHERE CustomerID = " & CustomerID & ""

        ' Executes the statement against the database
        Dim sqlCom As New System.Data.OleDb.OleDbCommand(sql)

        ' Connects the sql statement to the database
        sqlCom.Connection = conn

        ' Opens the connection
        conn.Open()


        ' Staff member is notified of their success of their required task.
        MessageBox.Show("Field value updated", "Database record updation successful")

        ' Carry out the sql statement
        Dim sqlRead As System.Data.OleDb.OleDbDataReader = sqlCom.ExecuteReader()

        ' Close the connection to the database
        conn.Close()
    End Sub

    Private Sub BtnMenu_Click(sender As Object, e As EventArgs) Handles BtnMenu.Click
        ' Hides the current form
        Me.Hide()
        ' Shows the staff menu
        StaffMenu.Show()
    End Sub
End Class