
' Generated by MyGeneration Version # (1.3.0.3)

Public Class Tblitem_master 
	Inherits _Tblitem_master
    Public Function LoadgridData() As DataTable
        Dim strQuery As String = "SELECT IM.id,IM.name  FROM Tblitem_master IM"
        MyBase.LoadFromRawSql(strQuery)
        Return MyBase.DefaultView.Table
    End Function
End Class
