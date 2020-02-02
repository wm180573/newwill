Imports System.Data.OleDb
Public Class AddGame
    Private Sub BtnAdd_Click(sender As Object, e As EventArgs) Handles BtnAdd.Click

        ' if the staff member wishes to add a game into the database as it has been bought by a customer, this action is carried out
        If BoughtOrSold.Text = "Bought" Then

            ' Create connection to the database
            Dim conn As New System.Data.OleDb.OleDbConnection()
            ' Defines location of the database
            conn.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\ipr0z\Downloads\MongooseGames.accdb"

            ' SQL (Structured Query Lanugage) statement which inserts what the staff member input into the database in the corresponding table
            Dim sql As String = "INSERT INTO Games (GameName,Price,Genre,Developer) VALUES ('" & txtTitle.Text & "', '" & txtPrice.Text & "', '" & txtGenre.Text & "', '" & txtDeveloper.Text & "')"


            Dim sqlCom As New System.Data.OleDb.OleDbCommand(sql)

            ' Staff member is notififed of their success of their required task.
            MessageBox.Show("Game added to system, you will now be redirected to the main menu screen", "Appending of game successful")
            ' Current form is hidden to allow the staff member to focus their attention on the AddToRecent form
            Me.Hide()
            ' AddToRecent Form is shown, which asks the staff member if they wish to log the transaction into the system
            AddToRecent.Show()
            ' Close database connection

            'Open Database Connection again
            sqlCom.Connection = conn
            conn.Open()

            ' Carry out the sql statement
            Dim sqlRead As System.Data.OleDb.OleDbDataReader = sqlCom.ExecuteReader()

            ' Close the connection to the database
            conn.Close()

            ' If the staff member wishes to delete a game from the database as it has been sold to a customer, this action is carried out
        ElseIf BoughtOrSold.Text = "Sold" Then
            ' Create connection to the database
            Dim conn As New System.Data.OleDb.OleDbConnection()
            ' Define location of the database
            conn.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\ipr0z\Downloads\MongooseGames.accdb"

            ' SQL (Structured Query Lanugage) statement which deletes the game that the staff member has referred to (using its ID) from the database
            Dim sql As String = "DELETE * FROM Games WHERE (GameID) = (" & txtGameID.Text & ")"


            Dim sqlCom As New System.Data.OleDb.OleDbCommand(sql)
            ' Staff member is notififed of their success of their required task.
            MessageBox.Show("Game removed from system, you will now be redirected to the main menu screen", "Removal of game successful")
            ' Current form is hidden to allow the staff member to focus their attention on the AddToRecent form
            Me.Hide()
            ' AddToRecent Form is shown, which asks the staff member if they wish to log the transaction into the system
            AddToRecent.Show()

            ' Open connection with sql
            sqlCom.Connection = conn
            conn.Open()

            ' Carry out the sql statement
            Dim sqlRead As System.Data.OleDb.OleDbDataReader = sqlCom.ExecuteReader()

            ' Close the connection to the database
            conn.Close()
        End If
    End Sub

    ' When main menu button is clicked
    Private Sub BtnMainMenu_Click(sender As Object, e As EventArgs) Handles BtnMainMenu.Click
        ' Hides current menu
        Me.Hide()
        ' Displays the staff main menu
        StaffMenu.Show()
    End Sub
End Class