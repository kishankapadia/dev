<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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
        Me.pnlMenu = New System.Windows.Forms.Panel()
        Me.btnItem = New System.Windows.Forms.Button()
        Me.PnlMain = New System.Windows.Forms.Panel()
        Me.pnlHead = New System.Windows.Forms.Panel()
        Me.pnlMenu.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnlMenu
        '
        Me.pnlMenu.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.pnlMenu.Controls.Add(Me.btnItem)
        Me.pnlMenu.Location = New System.Drawing.Point(0, 97)
        Me.pnlMenu.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.pnlMenu.Name = "pnlMenu"
        Me.pnlMenu.Size = New System.Drawing.Size(157, 562)
        Me.pnlMenu.TabIndex = 0
        '
        'btnItem
        '
        Me.btnItem.Font = New System.Drawing.Font("Gill Sans MT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnItem.Image = Global.BillingPrintingSystem.My.Resources.Resources.Edit
        Me.btnItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnItem.Location = New System.Drawing.Point(22, 30)
        Me.btnItem.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnItem.Name = "btnItem"
        Me.btnItem.Size = New System.Drawing.Size(108, 40)
        Me.btnItem.TabIndex = 0
        Me.btnItem.Text = "new item"
        Me.btnItem.UseVisualStyleBackColor = True
        '
        'PnlMain
        '
        Me.PnlMain.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PnlMain.Location = New System.Drawing.Point(154, 97)
        Me.PnlMain.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.PnlMain.Name = "PnlMain"
        Me.PnlMain.Size = New System.Drawing.Size(827, 568)
        Me.PnlMain.TabIndex = 0
        '
        'pnlHead
        '
        Me.pnlHead.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.pnlHead.Location = New System.Drawing.Point(3, 1)
        Me.pnlHead.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.pnlHead.Name = "pnlHead"
        Me.pnlHead.Size = New System.Drawing.Size(983, 99)
        Me.pnlHead.TabIndex = 0
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(984, 662)
        Me.Controls.Add(Me.PnlMain)
        Me.Controls.Add(Me.pnlHead)
        Me.Controls.Add(Me.pnlMenu)
        Me.Font = New System.Drawing.Font("Gill Sans MT", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "MainForm"
        Me.Text = "MainForm"
        Me.pnlMenu.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents pnlMenu As System.Windows.Forms.Panel
    Friend WithEvents btnItem As System.Windows.Forms.Button
    Friend WithEvents PnlMain As System.Windows.Forms.Panel
    Friend WithEvents pnlHead As System.Windows.Forms.Panel
End Class
