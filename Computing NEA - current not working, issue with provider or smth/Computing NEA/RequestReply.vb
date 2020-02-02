
Public Class RequestReply
    Private Sub BtnSend_Click(sender As Object, e As EventArgs) Handles BtnSend.Click
        Dim conn As New System.Data.OleDb.OleDbConnection()
        ' Defines location of the database
        conn.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\ipr0z\Downloads\MongooseGames.accdb"
        ' Opens connection to the database
        conn.Open()
        ' SQL (Structured Query Lanugage) statement which inserts what the staff member input into the database in the corresponding table
        Dim sql As String = "INSERT INTO StaffActions(StaffUser,CustUser,Message) VALUES ('" & StaffLogin.TxtUsername.Text & "', '" & txtCustUser.Text & "', '" & txtMsg.Text & "')"
        ' Allows the sql command to be executed against the database
        Dim sqlCom As New System.Data.OleDb.OleDbCommand(sql)
        ' Staff member is notififed of their success of their required task.
        MessageBox.Show("Message sent", "Sending of message successful")
        'Open Database Connection again
        sqlCom.Connection = conn
        conn.Open()

        ' Carry out the sql statement
        Dim sqlRead As System.Data.OleDb.OleDbDataReader = sqlCom.ExecuteReader()

        ' Close the connection to the database
        conn.Close()
    End Sub

    Private Sub BtnMenu_Click(sender As Object, e As EventArgs) Handles BtnMenu.Click
        Me.Hide()
        StaffMenu.Show()
    End Sub
End Class