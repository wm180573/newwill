Public Class StaffMenu
    Private Sub BtnQuotaCalc_Click(sender As Object, e As EventArgs) Handles BtnQuotaCalc.Click
        Me.Hide()
        QuotaCalculator.Show()
    End Sub

    Private Sub BtnResell_Click(sender As Object, e As EventArgs) Handles BtnResell.Click
        Me.Hide()
        ResellCalculator.Show()
    End Sub

    Private Sub BtnAddGame_Click(sender As Object, e As EventArgs) Handles BtnAddGame.Click
        Me.Hide()
        AddGame.Show()
    End Sub

    Private Sub BtnRecentGames_Click(sender As Object, e As EventArgs) Handles BtnRecentGames.Click
        Me.Hide()
        ViewRecentGames.Show()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles BtnSearchGame.Click
        Me.Hide()
        SearchGames.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles BtnUpdateDetails.Click
        Me.Hide()
        UpdateCustDetails.Show()
    End Sub

    Private Sub BtnViewDetails_Click(sender As Object, e As EventArgs) Handles BtnViewDetails.Click
        Me.Hide()
        ViewCustDetails.Show()
    End Sub

    Private Sub BtnViewQuotes_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub BtnSendQuote_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub BtnLogout_Click(sender As Object, e As EventArgs) Handles BtnLogout.Click
        Me.Hide()
        Form1.Show()
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
        ViewCustomerRequests.Show()
    End Sub

    Private Sub BtnInform_Click(sender As Object, e As EventArgs) Handles BtnInform.Click
        Me.Hide()
        RequestReply.Show()
    End Sub
End Class