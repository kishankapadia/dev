<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UCItem
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(UCItem))
        Me.pnlReset = New System.Windows.Forms.Panel()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.btnAddItem = New System.Windows.Forms.Button()
        Me.btnReset = New System.Windows.Forms.Button()
        Me.dgvItem = New System.Windows.Forms.DataGridView()
        Me.Edit = New System.Windows.Forms.DataGridViewImageColumn()
        Me.Delete = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.pnlReset.SuspendLayout()
        CType(Me.dgvItem, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pnlReset
        '
        Me.pnlReset.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.pnlReset.Controls.Add(Me.btnReset)
        Me.pnlReset.Controls.Add(Me.btnAddItem)
        Me.pnlReset.Controls.Add(Me.btnDelete)
        Me.pnlReset.Location = New System.Drawing.Point(65, 24)
        Me.pnlReset.Name = "pnlReset"
        Me.pnlReset.Size = New System.Drawing.Size(860, 100)
        Me.pnlReset.TabIndex = 0
        '
        'btnDelete
        '
        Me.btnDelete.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnDelete.Location = New System.Drawing.Point(125, 29)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(169, 36)
        Me.btnDelete.TabIndex = 0
        Me.btnDelete.Text = "Delete Item"
        Me.btnDelete.UseVisualStyleBackColor = False
        '
        'btnAddItem
        '
        Me.btnAddItem.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnAddItem.Location = New System.Drawing.Point(351, 29)
        Me.btnAddItem.Name = "btnAddItem"
        Me.btnAddItem.Size = New System.Drawing.Size(169, 36)
        Me.btnAddItem.TabIndex = 1
        Me.btnAddItem.Text = "Add New Item"
        Me.btnAddItem.UseVisualStyleBackColor = False
        '
        'btnReset
        '
        Me.btnReset.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnReset.Location = New System.Drawing.Point(579, 29)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(169, 36)
        Me.btnReset.TabIndex = 2
        Me.btnReset.Text = "Reset"
        Me.btnReset.UseVisualStyleBackColor = False
        '
        'dgvItem
        '
        Me.dgvItem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvItem.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Edit, Me.Delete})
        Me.dgvItem.Location = New System.Drawing.Point(65, 151)
        Me.dgvItem.Name = "dgvItem"
        Me.dgvItem.Size = New System.Drawing.Size(860, 207)
        Me.dgvItem.TabIndex = 3
        '
        'Edit
        '
        Me.Edit.HeaderText = "Edit"
        Me.Edit.Image = CType(resources.GetObject("Edit.Image"), System.Drawing.Image)
        Me.Edit.Name = "Edit"
        '
        'Delete
        '
        Me.Delete.HeaderText = "Delete"
        Me.Delete.Name = "Delete"
        '
        'UCItem
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 23.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.Controls.Add(Me.dgvItem)
        Me.Controls.Add(Me.pnlReset)
        Me.Font = New System.Drawing.Font("Gill Sans MT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.Name = "UCItem"
        Me.Size = New System.Drawing.Size(980, 650)
        Me.pnlReset.ResumeLayout(False)
        CType(Me.dgvItem, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents pnlReset As System.Windows.Forms.Panel
    Friend WithEvents btnReset As System.Windows.Forms.Button
    Friend WithEvents btnAddItem As System.Windows.Forms.Button
    Friend WithEvents btnDelete As System.Windows.Forms.Button
    Friend WithEvents dgvItem As System.Windows.Forms.DataGridView
    Friend WithEvents Edit As System.Windows.Forms.DataGridViewImageColumn
    Friend WithEvents Delete As System.Windows.Forms.DataGridViewCheckBoxColumn

End Class
