Public Class ResellCalculator
    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click

        Dim PricePaid As Integer = Convert.ToDouble(txtPricePaid.Text)

        txtResellPrice.Text = PricePaid * 1.3 'Input string was not in a correct format.'

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        StaffMenu.Show()
    End Sub
End Class