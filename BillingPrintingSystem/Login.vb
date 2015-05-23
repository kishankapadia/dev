Imports BussinessLayer

Public Class Login
    Dim objUser As Tbluser_master
    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        objUser = New Tbluser_master
        Dim dt As New DataTable
        Dim result = objUser.LoadgridData(txtUsername.Text, txtPassword.Text)
        If (result = 1) Then
            MsgBox("Login successfull")
        Else
            MsgBox("Inva;id username or password")
        End If


    End Sub
End Class
