Public Class MainForm

    Private Sub Panel2_Paint(sender As Object, e As PaintEventArgs) Handles PnlMain.Paint

    End Sub

    Private Sub btnItem_Click(sender As Object, e As EventArgs) Handles btnItem.Click
        Dim uc As New UC_CompanyMaster

        PnlMain.Controls.Add(uc)
    End Sub

    Private Sub MainForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Dim uc As New Login
        'PnlMain.Controls.Add(uc)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)

    End Sub
End Class