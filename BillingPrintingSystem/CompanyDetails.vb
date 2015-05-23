Imports BussinessLayer
Public Class CompanyDetails
    Public pkID As String
    Dim msg As String
    Dim objCompanyDetails As Tblcompany_master
    Dim obj As Tblcompany_master
    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        obj = New Tblcompany_master
        If pkID <> "" Then
            obj.LoadByPrimaryKey(pkID)
            msg = "Record is updated successfully"
        Else
            obj.AddNew()
            msg = "Record is added successfully"
        End If
        obj.Name = txtCompanyName.Text
        obj.Address = txtCompanyAddress.Text
        obj.Description = txtCompanyDesc.Text
        obj.Vat_tin_no = txtVatTinNo.Text
        obj.Cst_tin_no = txtCstTinNo.Text
        obj.Phoneno = txtPhoneNo.Text
        obj.Vat = txtVat.Text
        obj.Add_tax = txtTax.Text
        obj.Type = cmbType.SelectedItem.ToString()
        obj.Save()
        MsgBox(msg, MsgBoxStyle.Information)
    End Sub

    Private Sub CompanyDetails_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If pkID <> "" Then
            setValuesToControl()
        End If
    End Sub
    Private Sub setValuesToControl()
        objCompanyDetails = New Tblcompany_master
        If objCompanyDetails.LoadByPrimaryKey(pkID) Then
            txtCompanyName.Text = objCompanyDetails.Name
            txtCompanyAddress.Text = objCompanyDetails.Address
            txtCompanyDesc.Text = objCompanyDetails.Description
            txtVatTinNo.Text = objCompanyDetails.Vat_tin_no
            txtCstTinNo.Text = objCompanyDetails.Cst_tin_no
            txtPhoneNo.Text = objCompanyDetails.Phoneno
            txtVat.Text = objCompanyDetails.Vat
            txtTax.Text = objCompanyDetails.Add_tax
            cmbType.SelectedText = objCompanyDetails.Type
            cmbType.SelectedItem = objCompanyDetails.Type
        End If
        objCompanyDetails = Nothing
    End Sub
End Class