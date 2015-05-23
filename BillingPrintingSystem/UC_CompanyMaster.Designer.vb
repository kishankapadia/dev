<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UC_CompanyMaster
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(UC_CompanyMaster))
        Me.btnAddCompany = New System.Windows.Forms.Button()
        Me.btnResetCompany = New System.Windows.Forms.Button()
        Me.btnDeleteCompany = New System.Windows.Forms.Button()
        Me.dgvCompany = New System.Windows.Forms.DataGridView()
        Me.Delete = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.Edit = New System.Windows.Forms.DataGridViewImageColumn()
        CType(Me.dgvCompany, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnAddCompany
        '
        Me.btnAddCompany.Location = New System.Drawing.Point(256, 49)
        Me.btnAddCompany.Name = "btnAddCompany"
        Me.btnAddCompany.Size = New System.Drawing.Size(159, 23)
        Me.btnAddCompany.TabIndex = 0
        Me.btnAddCompany.Text = "Add Company"
        Me.btnAddCompany.UseVisualStyleBackColor = True
        '
        'btnResetCompany
        '
        Me.btnResetCompany.Location = New System.Drawing.Point(421, 49)
        Me.btnResetCompany.Name = "btnResetCompany"
        Me.btnResetCompany.Size = New System.Drawing.Size(159, 23)
        Me.btnResetCompany.TabIndex = 1
        Me.btnResetCompany.Text = "Reset"
        Me.btnResetCompany.UseVisualStyleBackColor = True
        '
        'btnDeleteCompany
        '
        Me.btnDeleteCompany.Location = New System.Drawing.Point(91, 49)
        Me.btnDeleteCompany.Name = "btnDeleteCompany"
        Me.btnDeleteCompany.Size = New System.Drawing.Size(159, 23)
        Me.btnDeleteCompany.TabIndex = 2
        Me.btnDeleteCompany.Text = "Delete Company"
        Me.btnDeleteCompany.UseVisualStyleBackColor = True
        '
        'dgvCompany
        '
        Me.dgvCompany.AllowUserToAddRows = False
        Me.dgvCompany.AllowUserToDeleteRows = False
        Me.dgvCompany.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader
        Me.dgvCompany.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight
        Me.dgvCompany.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvCompany.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Delete, Me.Edit})
        Me.dgvCompany.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnF2
        Me.dgvCompany.Location = New System.Drawing.Point(91, 123)
        Me.dgvCompany.Name = "dgvCompany"
        Me.dgvCompany.Size = New System.Drawing.Size(489, 191)
        Me.dgvCompany.TabIndex = 3
        '
        'Delete
        '
        Me.Delete.HeaderText = "Delete"
        Me.Delete.Name = "Delete"
        Me.Delete.Width = 44
        '
        'Edit
        '
        Me.Edit.HeaderText = "Edit"
        Me.Edit.Image = CType(resources.GetObject("Edit.Image"), System.Drawing.Image)
        Me.Edit.Name = "Edit"
        Me.Edit.Width = 31
        '
        'UC_CompanyMaster
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.dgvCompany)
        Me.Controls.Add(Me.btnDeleteCompany)
        Me.Controls.Add(Me.btnResetCompany)
        Me.Controls.Add(Me.btnAddCompany)
        Me.Name = "UC_CompanyMaster"
        Me.Size = New System.Drawing.Size(777, 340)
        CType(Me.dgvCompany, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnAddCompany As System.Windows.Forms.Button
    Friend WithEvents btnResetCompany As System.Windows.Forms.Button
    Friend WithEvents btnDeleteCompany As System.Windows.Forms.Button
    Friend WithEvents dgvCompany As System.Windows.Forms.DataGridView
    Friend WithEvents Delete As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents Edit As System.Windows.Forms.DataGridViewImageColumn

End Class
