Public Class QuotaCalculator
    Private Sub BtnCalc_Click(sender As Object, e As EventArgs) Handles BtnCalc.Click
        Try
            ' Factors inputted are converted into variables with the double datatype, to allow any sort of calculations under any circumstances to be performed
            Dim GameAge As Integer = Convert.ToDouble(txtGameAge.Text)

            Dim condition As Integer = Convert.ToDouble(NumUpDownCondition.Value)

            Dim popularity As Integer = Convert.ToDouble(NumUpDownPopularity.Value)

            Dim RRP As Integer = Convert.ToDouble(txtRRP.Text)



            ' rules for games under a year old

            ' for every 1 condition value below 10, the price is subtracted by £1.5
            ' the less popular a game is, the more they are worth less than the RRP

            If popularity >= 7 And GameAge <= 365 Then
                txtPrice.Text = (RRP * 0.75) - (10 - condition) * 1.5

            ElseIf popularity >= 5 And GameAge <= 365 Then
                txtPrice.Text = (RRP * 0.65) - (10 - condition) * 1.5

            ElseIf popularity >= 3 And GameAge <= 365 Then
                txtPrice.Text = (RRP * 0.5) - (10 - condition) * 1.5

            ElseIf popularity < 2 And GameAge <= 365 Then
                txtPrice.Text = (RRP * 0.3) - (10 - condition) * 1.5

                ' now rules for games over a year old

                ' for every 1 condition value below 10, the price is subtracted by £1.5
                ' the less popular a game is, the more they are worth less than the RRP

            ElseIf popularity >= 7 And GameAge > 365 Then
                txtPrice.Text = (RRP * 0.7) - (10 - condition) * 1.5

            ElseIf popularity >= 5 And GameAge > 365 Then
                txtPrice.Text = (RRP * 0.6) - (10 - condition) * 1.5

            ElseIf popularity >= 3 And GameAge > 365 Then
                txtPrice.Text = (RRP * 0.45) - (10 - condition) * 1.5

            ElseIf popularity < 2 And GameAge > 365 Then
                txtPrice.Text = (RRP * 0.25) - (10 - condition) * 1.5


                ' If there is an error while trying to fit the inputted values into a category for a respective quote, the staff member is notified of this.
            Else
                MessageBox.Show("The game's characteristics do not match any field ", "Error while calculating quote")
            End If

            ' If there is some sort of error, the staff member is made aware of it, without the program crashing.
        Catch ex As Exception
            MessageBox.Show("Please enter the required fields", "Error While compiling values")
        End Try
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ' Hide current form
        Me.Hide()
        ' Show staff menu
        StaffMenu.Show()
    End Sub
End Class