
Public Class ViewRecentGames
    Private Sub BtnView_Click(sender As Object, e As EventArgs) Handles BtnView.Click
        Dim conn As New System.Data.OleDb.OleDbConnection()
        conn.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\ipr0z\Downloads\MongooseGames.accdb"
        Dim sql As String = "SELECT GameName,Price,Genre,Developer,BoughtOrSold,CustomerID,GameID FROM RecentGames"")"
        Dim sqlCom As New System.Data.OleDb.OleDbCommand(sql)

        Dim sqlRead As System.Data.OleDb.OleDbDataReader = sqlCom.ExecuteReader()



    End Sub

    Private Sub BtnMainMenu_Click(sender As Object, e As EventArgs) Handles BtnMainMenu.Click
        Me.Hide()
        StaffMenu.Show()
    End Sub
End Class