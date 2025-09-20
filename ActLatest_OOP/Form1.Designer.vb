<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.viewbtn = New System.Windows.Forms.Button()
        Me.registerbtn = New System.Windows.Forms.Button()
        Me.exit1 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.SaddleBrown
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.Control
        Me.Label2.Location = New System.Drawing.Point(207, 44)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(133, 26)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "WELCOME"
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.SaddleBrown
        Me.Label1.Location = New System.Drawing.Point(-1, -1)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(706, 115)
        Me.Label1.TabIndex = 2
        '
        'viewbtn
        '
        Me.viewbtn.BackColor = System.Drawing.Color.Gray
        Me.viewbtn.Location = New System.Drawing.Point(326, 260)
        Me.viewbtn.Name = "viewbtn"
        Me.viewbtn.Size = New System.Drawing.Size(130, 67)
        Me.viewbtn.TabIndex = 25
        Me.viewbtn.Text = "View Data"
        Me.viewbtn.UseVisualStyleBackColor = False
        '
        'registerbtn
        '
        Me.registerbtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.registerbtn.Location = New System.Drawing.Point(99, 260)
        Me.registerbtn.Name = "registerbtn"
        Me.registerbtn.Size = New System.Drawing.Size(121, 67)
        Me.registerbtn.TabIndex = 24
        Me.registerbtn.Text = "Register"
        Me.registerbtn.UseVisualStyleBackColor = False
        '
        'exit1
        '
        Me.exit1.BackColor = System.Drawing.Color.Red
        Me.exit1.Location = New System.Drawing.Point(12, 409)
        Me.exit1.Name = "exit1"
        Me.exit1.Size = New System.Drawing.Size(72, 29)
        Me.exit1.TabIndex = 26
        Me.exit1.Text = "Exit"
        Me.exit1.UseVisualStyleBackColor = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(558, 450)
        Me.Controls.Add(Me.exit1)
        Me.Controls.Add(Me.viewbtn)
        Me.Controls.Add(Me.registerbtn)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents viewbtn As Button
    Friend WithEvents registerbtn As Button
    Friend WithEvents exit1 As Button
End Class
