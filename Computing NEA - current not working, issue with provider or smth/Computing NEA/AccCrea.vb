Imports System.Data.OleDb
Public Class AccCrea


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ' Check if any field is empty
        If txtPassword.Text = "" Or txtUsername.Text = "" Or txtFirstName.Text = "" Or txtSurname.Text = "" Or txtTelephone.Text = "" Or txtAddress.Text = "" Or txtCounty.Text = "" Or txtTown.Text = "" Or txtPostcode.Text = "" Then
            ' If any of them are empty, then the user is notified of this and they are to then fill them in
            MessageBox.Show("Please complete the required fields..", "Authentication Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

            ' If they use their name as their username or their surname as their password
        ElseIf txtUsername.Text = txtFirstName.Text Or txtPassword.Text = txtSurname.Text Then
            ' They are then warned to not do so as it could warrant their details easy to be guessed
            MessageBox.Show("Please do not use your name as a username or password ", "Security warning")
        Else

            ' Open connection
            Dim conn As New System.Data.OleDb.OleDbConnection()
            ' Connect with database on system
            conn.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\ipr0z\Downloads\MongooseGames.accdb"
            ' Inserts all of the information that the user inputs into the database
            Dim sql As String = "INSERT INTO customers (CustUser,CustPass,FirstName,Surname,PhoneNum,Address,County,Town,Postcode) VALUES ('" & txtUsername.Text & "', '" & txtPassword.Text & "', '" & txtFirstName.Text & "', '" & txtSurname.Text & "', '" & txtTelephone.Text & "', '" & txtAddress.Text & "', '" & txtCounty.Text & "', '" & txtTown.Text & "', '" & txtPostcode.Text & "')"
            Dim sqlCom As New System.Data.OleDb.OleDbCommand(sql)
            ' They are then informed of their account creation
            MessageBox.Show("Account Created, and details saved, you will now be redirected to the login screen", "Account creation successful")
            ' Current form hidden
            Me.Hide()
            ' Directed to the customer login form to now use their newly created credentials to gain access to the system
            CustomerLogin.Show()


            'Open Database Connection
            sqlCom.Connection = conn
            conn.Open()

            Dim sqlRead As System.Data.OleDb.OleDbDataReader = sqlCom.ExecuteReader()
        End If
    End Sub
End Class