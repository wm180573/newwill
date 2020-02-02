Public Class AddToRecent
    Private Sub btnYes_Click(sender As Object, e As EventArgs) Handles btnYes.Click
        Dim conn As New System.Data.OleDb.OleDbConnection()
        conn.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\ipr0z\Downloads\MongooseGames.accdb"

        Dim sql As String = "INSERT INTO RecentGames (GameName,Price,Genre,Developer,BoughtOrSold,CustomerID) VALUES ('" & AddGame.txtTitle.Text & "', '" & AddGame.txtPrice.Text & "', '" & AddGame.txtGenre.Text & "', '" & AddGame.txtDeveloper.Text & "','" & AddGame.BoughtOrSold.Text & "', '" & AddGame.txtCustomerID.Text & "')"

        Dim sqlCom As New System.Data.OleDb.OleDbCommand(sql)
        MessageBox.Show("Game added to system, you will now be redirected to the main menu screen", "Appending of game successful")
        Me.Hide()
        StaffMenu.Show()

        'Open Database Connection
        sqlCom.Connection = conn
        conn.Open()

        Dim sqlRead As System.Data.OleDb.OleDbDataReader = sqlCom.ExecuteReader()
    End Sub

    Private Sub BtnNo_Click(sender As Object, e As EventArgs) Handles BtnNo.Click
        Me.Hide()
        StaffMenu.Show()
    End Sub
End Class