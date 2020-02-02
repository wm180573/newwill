Imports System.Data.OleDb
Public Class StaffLogin
    Dim connString As String
    Public myConnection As OleDbConnection = New OleDbConnection
    Public dr As OleDbDataReader
    Public attempts As Integer

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles BtnStaffLogin.Click
        Me.TxtUsername.Text = TxtUsername.Text
        Try
        ' Check if username or password is empty
        If TxtStaffPassword.Text = "" Or TxtUsername.Text = "" Then
                MessageBox.Show("Please complete the required fields..", "Authentication Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Else
                ' Both fields was supply
                ' Check if user exist in database
                ' Connect to DB
                Dim conn As New System.Data.OleDb.OleDbConnection()
                ' Connect with database on the current system
                conn.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\ipr0z\Downloads\MongooseGames.accdb"

                Dim sql As String = "SELECT * FROM Staff WHERE StaffUser='" & TxtUsername.Text & "' AND StaffPass = '" & TxtStaffPassword.Text & "'"
                Dim sqlCom As New System.Data.OleDb.OleDbCommand(sql)

                'Open Database Connection
                sqlCom.Connection = conn
                conn.Open()

                Dim sqlRead As System.Data.OleDb.OleDbDataReader = sqlCom.ExecuteReader()

                ' If they enter credentials that match to the database, they are then redirected to the customer menu
                If sqlRead.Read() Then
                    MsgBox("Login successful")
                    ' Hides current form
                    Me.Hide()
                    ' Shows staff menu
                    StaffMenu.Show()

                    ' if they expend their 3 attempts, they are then notified of this and the application is closed
                ElseIf attempts = 2 Then
                    MessageBox.Show("You have expended your 3 attempts, system shutting down", "Security procedure")
                    Close()


                Else
                    ' If user enter wrong username and password combination
                    ' Throw an error message
                    ' Every time they get the credentials wrong, the attempts value increments by 1 to register that an attempt has been made
                    attempts += 1
                    MessageBox.Show("Username and Password do not match, you have expended " & attempts & "/3 retries", "Authentication Failure", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

                    'Clear all fields
                    TxtStaffPassword.Text = ""
                    TxtUsername.Text = ""

                    'Focus on Username field (so that they can prompty retry without having to use their mouse)
                    TxtUsername.Focus()
                    ' Closes the connection to the data source
                    conn.Close()
                End If
            End If
            ' Catch exception is caught here, so that if there is an issue connecting to the database they are aware of this, instead of the program crashing
        Catch ex As Exception
            MessageBox.Show("Failed to connect to Database..", "Database Connection Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
End Class