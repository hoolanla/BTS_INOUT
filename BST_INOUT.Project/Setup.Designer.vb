<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Setup
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.CheckCompany = New System.Windows.Forms.CheckBox()
        Me.CheckTimeStamp = New System.Windows.Forms.CheckBox()
        Me.CheckName = New System.Windows.Forms.CheckBox()
        Me.BtnSave = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.CheckCompany)
        Me.GroupBox1.Controls.Add(Me.CheckTimeStamp)
        Me.GroupBox1.Controls.Add(Me.CheckName)
        Me.GroupBox1.Controls.Add(Me.BtnSave)
        Me.GroupBox1.Location = New System.Drawing.Point(6, 0)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(241, 106)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        '
        'CheckCompany
        '
        Me.CheckCompany.AutoSize = True
        Me.CheckCompany.Location = New System.Drawing.Point(17, 54)
        Me.CheckCompany.Name = "CheckCompany"
        Me.CheckCompany.Size = New System.Drawing.Size(100, 17)
        Me.CheckCompany.TabIndex = 4
        Me.CheckCompany.Text = "Show Company"
        Me.CheckCompany.UseVisualStyleBackColor = True
        '
        'CheckTimeStamp
        '
        Me.CheckTimeStamp.AutoSize = True
        Me.CheckTimeStamp.Location = New System.Drawing.Point(17, 33)
        Me.CheckTimeStamp.Name = "CheckTimeStamp"
        Me.CheckTimeStamp.Size = New System.Drawing.Size(107, 17)
        Me.CheckTimeStamp.TabIndex = 3
        Me.CheckTimeStamp.Text = "Show Timestamp"
        Me.CheckTimeStamp.UseVisualStyleBackColor = True
        '
        'CheckName
        '
        Me.CheckName.AutoSize = True
        Me.CheckName.Location = New System.Drawing.Point(17, 13)
        Me.CheckName.Name = "CheckName"
        Me.CheckName.Size = New System.Drawing.Size(84, 17)
        Me.CheckName.TabIndex = 2
        Me.CheckName.Text = "Show Name"
        Me.CheckName.UseVisualStyleBackColor = True
        '
        'BtnSave
        '
        Me.BtnSave.Location = New System.Drawing.Point(160, 74)
        Me.BtnSave.Name = "BtnSave"
        Me.BtnSave.Size = New System.Drawing.Size(75, 23)
        Me.BtnSave.TabIndex = 1
        Me.BtnSave.Text = "Save"
        Me.BtnSave.UseVisualStyleBackColor = True
        '
        'Setup
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(254, 109)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Setup"
        Me.Text = "Setup"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents BtnSave As System.Windows.Forms.Button
    Friend WithEvents CheckName As System.Windows.Forms.CheckBox
    Friend WithEvents CheckCompany As System.Windows.Forms.CheckBox
    Friend WithEvents CheckTimeStamp As System.Windows.Forms.CheckBox
End Class
