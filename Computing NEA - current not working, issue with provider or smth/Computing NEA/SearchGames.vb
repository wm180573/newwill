Public Class SearchGames
    Private Sub BtnSearch_Click(sender As Object, e As EventArgs) Handles BtnSearch.Click
        Dim conn As New System.Data.OleDb.OleDbConnection()
        conn.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\ipr0z\Downloads\MongooseGames.accdb"

        Dim sql As String = "SELECT GameID,GameName,Price,Genre,Developer FROM Games WHERE (GameName) = ('" & txtGameTitle.Text & "')"
        Dim sqlCom As New System.Data.OleDb.OleDbCommand(sql)

        'Open Database Connection
        sqlCom.Connection = conn
        conn.Open()

        Dim sqlRead As System.Data.OleDb.OleDbDataReader = sqlCom.ExecuteReader()
        If sqlRead.HasRows Then
            While sqlRead.Read()
                txtGameID.Text = sqlRead.Item("GameID")
                txtGameTitle.Text = sqlRead.Item("GameName")
                txtPrice.Text = sqlRead.Item("Price")
                txtGenre.Text = sqlRead.Item("Genre")
                txtDeveloper.Text = sqlRead.Item("Developer")
                MessageBox.Show("Game found", "Searching of game successful")
            End While
            sqlRead.Close()
        Else
            MessageBox.Show("No game called """ & txtGameTitle.Text & """" & " was found. Please try again", "Error while searching for game")
            txtGameID.Clear()
        End If
        conn.Close()

    End Sub

    Private Sub BtnMainMenu_Click(sender As Object, e As EventArgs) Handles BtnMainMenu.Click
        Me.Hide()
        StaffMenu.Show()
    End Sub
End Class