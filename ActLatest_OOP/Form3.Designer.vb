<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form3
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.back = New System.Windows.Forms.Button()
        Me.delete = New System.Windows.Forms.Button()
        Me.save = New System.Windows.Forms.Button()
        Me.edit = New System.Windows.Forms.Button()
        Me.exit3 = New System.Windows.Forms.Button()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.SaddleBrown
        Me.Label1.Location = New System.Drawing.Point(0, -2)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(1076, 75)
        Me.Label1.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.SaddleBrown
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.Control
        Me.Label2.Location = New System.Drawing.Point(382, 24)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(221, 26)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "REGISTERED LIST"
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToOrderColumns = True
        Me.DataGridView1.AllowUserToResizeColumns = False
        Me.DataGridView1.AllowUserToResizeRows = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(0, 72)
        Me.DataGridView1.Margin = New System.Windows.Forms.Padding(2)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.RowHeadersWidth = 51
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.Size = New System.Drawing.Size(937, 262)
        Me.DataGridView1.TabIndex = 3
        '
        'back
        '
        Me.back.BackColor = System.Drawing.Color.Gray
        Me.back.Location = New System.Drawing.Point(777, 339)
        Me.back.Margin = New System.Windows.Forms.Padding(2)
        Me.back.Name = "back"
        Me.back.Size = New System.Drawing.Size(63, 31)
        Me.back.TabIndex = 24
        Me.back.Text = "Back"
        Me.back.UseVisualStyleBackColor = False
        '
        'delete
        '
        Me.delete.BackColor = System.Drawing.Color.Red
        Me.delete.Location = New System.Drawing.Point(710, 339)
        Me.delete.Margin = New System.Windows.Forms.Padding(2)
        Me.delete.Name = "delete"
        Me.delete.Size = New System.Drawing.Size(63, 31)
        Me.delete.TabIndex = 25
        Me.delete.Text = "Delete"
        Me.delete.UseVisualStyleBackColor = False
        '
        'save
        '
        Me.save.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.save.Location = New System.Drawing.Point(579, 339)
        Me.save.Name = "save"
        Me.save.Size = New System.Drawing.Size(60, 31)
        Me.save.TabIndex = 26
        Me.save.Text = "Save"
        Me.save.UseVisualStyleBackColor = False
        '
        'edit
        '
        Me.edit.BackColor = System.Drawing.Color.Yellow
        Me.edit.Location = New System.Drawing.Point(645, 339)
        Me.edit.Name = "edit"
        Me.edit.Size = New System.Drawing.Size(60, 31)
        Me.edit.TabIndex = 27
        Me.edit.Text = "Edit"
        Me.edit.UseVisualStyleBackColor = False
        '
        'exit3
        '
        Me.exit3.BackColor = System.Drawing.SystemColors.InfoText
        Me.exit3.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.exit3.Location = New System.Drawing.Point(860, 339)
        Me.exit3.Margin = New System.Windows.Forms.Padding(2)
        Me.exit3.Name = "exit3"
        Me.exit3.Size = New System.Drawing.Size(63, 31)
        Me.exit3.TabIndex = 28
        Me.exit3.Text = "Exit"
        Me.exit3.UseVisualStyleBackColor = False
        '
        'Form3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(934, 375)
        Me.Controls.Add(Me.exit3)
        Me.Controls.Add(Me.edit)
        Me.Controls.Add(Me.save)
        Me.Controls.Add(Me.delete)
        Me.Controls.Add(Me.back)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.MaximizeBox = False
        Me.Name = "Form3"
        Me.Text = "Registered List"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents back As Button
    Friend WithEvents delete As Button
    Friend WithEvents save As Button
    Friend WithEvents edit As Button
    Friend WithEvents exit3 As Button
End Class
