Imports System.Data.OleDb
Public Class Form1

    Private Sub BtnStaffLogin_Click(sender As Object, e As EventArgs) Handles BtnStaffLogin.Click
        ' Hides the MainLogin form
        Hide()
        ' Shows the Member Login form when BtnMemberLogin is clicked
        StaffLogin.Show()
    End Sub

    Private Sub BtnCustomerLogin_Click(sender As Object, e As EventArgs) Handles BtnCustomerLogin.Click
        ' Hides the MainLogin form
        Hide()
        ' Shows the Customer Login form when BtnCustomerLogin is pressed
        CustomerLogin.Show()
    End Sub
End Class
