﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form4
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
        Me.registerbtn = New System.Windows.Forms.Button()
        Me.view2 = New System.Windows.Forms.Button()
        Me.exit1 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.SaddleBrown
        Me.Label1.Location = New System.Drawing.Point(1, -2)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(578, 115)
        Me.Label1.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.SaddleBrown
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.Control
        Me.Label2.Location = New System.Drawing.Point(219, 42)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(143, 26)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "THANKYOU"
        '
        'registerbtn
        '
        Me.registerbtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.registerbtn.Location = New System.Drawing.Point(96, 255)
        Me.registerbtn.Name = "registerbtn"
        Me.registerbtn.Size = New System.Drawing.Size(121, 67)
        Me.registerbtn.TabIndex = 25
        Me.registerbtn.Text = "Register"
        Me.registerbtn.UseVisualStyleBackColor = False
        '
        'view2
        '
        Me.view2.BackColor = System.Drawing.Color.Gray
        Me.view2.Location = New System.Drawing.Point(368, 255)
        Me.view2.Name = "view2"
        Me.view2.Size = New System.Drawing.Size(130, 67)
        Me.view2.TabIndex = 28
        Me.view2.Text = "View Data"
        Me.view2.UseVisualStyleBackColor = False
        '
        'exit1
        '
        Me.exit1.BackColor = System.Drawing.Color.Red
        Me.exit1.Location = New System.Drawing.Point(31, 396)
        Me.exit1.Name = "exit1"
        Me.exit1.Size = New System.Drawing.Size(72, 29)
        Me.exit1.TabIndex = 29
        Me.exit1.Text = "Exit"
        Me.exit1.UseVisualStyleBackColor = False
        '
        'Form4
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(577, 450)
        Me.Controls.Add(Me.exit1)
        Me.Controls.Add(Me.view2)
        Me.Controls.Add(Me.registerbtn)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form4"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents registerbtn As Button
    Friend WithEvents view2 As Button
    Friend WithEvents exit1 As Button
End Class
