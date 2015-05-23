Imports BussinessLayer
Public Class UC_CompanyMaster
    Private dtSource As DataTable

    Dim objCompany As Tblcompany_master

    Private Sub btnAddCompany_Click(sender As Object, e As EventArgs) Handles btnAddCompany.Click
        Dim CD As New CompanyDetails
        CD.ShowDialog()
        loadGridData()
    End Sub
    Private Sub loadGridData()
        objCompany = New Tblcompany_master
        dtSource = objCompany.LoadgridData()
        dgvCompany.DataSource = dtSource
    End Sub

    Private Sub UC_CompanyMaster_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        loadGridData()
    End Sub

    Private Sub dgvCompany_CellClicked(sender As Object, e As DataGridViewCellEventArgs) Handles dgvCompany.CellClick
        Dim ColumnIndex As String = ""
        Dim index As Integer
        index = dgvCompany.SelectedCells(0).RowIndex
        ColumnIndex = dgvCompany.SelectedCells(0).ColumnIndex.ToString()
        If ColumnIndex = 0 Then

        ElseIf ColumnIndex = 1 Then
            Dim pkID As Integer = Convert.ToInt16(Me.dgvCompany("id", index).Value.ToString())
            Dim cdForm As New CompanyDetails
            cdForm.pkID = pkID
            cdForm.ShowDialog()
            loadGridData()

        End If
        
    End Sub

    Private Sub btnDeleteCompany_Click(sender As Object, e As EventArgs) Handles btnDeleteCompany.Click
        Dim result = MessageBox.Show("Are u sure u want to delete ?", "Warning", MessageBoxButtons.YesNo)
        Dim SelectedIDs As Boolean = False
        If result.ToString = "Yes" Then
            'Dim objCustomerPayments As tblCustomerPayment

            For Each r As DataGridViewRow In dgvCompany.Rows
                If r.Cells("Delete").Value = True Then
                    objCompany = New Tblcompany_master
                    If objCompany.LoadByPrimaryKey(r.Cells("id").Value) Then
                        objCompany.MarkAsDeleted()
                        objCompany.Save()
                    End If
                    objCompany = Nothing
                    SelectedIDs = True
                End If
            Next
            If SelectedIDs Then
                'loadGridData ("", "", False)
                MessageBox.Show("Record has been deleted successfully.", "Information", MessageBoxButtons.OK)
            Else
                MessageBox.Show("Please select atleast one customer.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
            'objCustomerPayments = Nothing
        End If
        loadGridData()

    End Sub

    Private Sub dgvCompany_DatabindingComplete(sender As Object, e As DataGridViewBindingCompleteEventArgs) Handles dgvCompany.DataBindingComplete
        dgvCompany.Columns.Item(2).Visible = False
    End Sub
End Class
