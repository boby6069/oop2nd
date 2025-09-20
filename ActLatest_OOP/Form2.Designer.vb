<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form2
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
        Me.components = New System.ComponentModel.Container()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.fname1 = New System.Windows.Forms.TextBox()
        Me.RegisteredBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Act2LatestOOPDataSet = New ActLatest_OOP.Act2LatestOOPDataSet()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.mname1 = New System.Windows.Forms.TextBox()
        Me.lname = New System.Windows.Forms.Label()
        Me.lname1 = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.suffix1 = New System.Windows.Forms.ComboBox()
        Me.Age = New System.Windows.Forms.Label()
        Me.age1 = New System.Windows.Forms.TextBox()
        Me.Address = New System.Windows.Forms.Label()
        Me.Contact = New System.Windows.Forms.Label()
        Me.Email = New System.Windows.Forms.Label()
        Me.housenum1 = New System.Windows.Forms.TextBox()
        Me.contact1 = New System.Windows.Forms.TextBox()
        Me.email1 = New System.Windows.Forms.TextBox()
        Me.municipality1 = New System.Windows.Forms.ComboBox()
        Me.province1 = New System.Windows.Forms.ComboBox()
        Me.birthdate1 = New System.Windows.Forms.DateTimePicker()
        Me.submit = New System.Windows.Forms.Button()
        Me.view = New System.Windows.Forms.Button()
        Me.RegisteredTableAdapter = New ActLatest_OOP.Act2LatestOOPDataSetTableAdapters.RegisteredTableAdapter()
        Me.RegisteredBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.RegisteredBindingSource2 = New System.Windows.Forms.BindingSource(Me.components)
        Me.RegisteredBindingSource3 = New System.Windows.Forms.BindingSource(Me.components)
        Me.RegisteredBindingSource4 = New System.Windows.Forms.BindingSource(Me.components)
        Me.RegisteredBindingSource5 = New System.Windows.Forms.BindingSource(Me.components)
        Me.RegisteredTableAdapter1 = New ActLatest_OOP.Act2LatestOOPDataSetTableAdapters.RegisteredTableAdapter()
        Me.backbtn = New System.Windows.Forms.Button()
        Me.gender = New System.Windows.Forms.ComboBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.country = New System.Windows.Forms.ComboBox()
        CType(Me.RegisteredBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Act2LatestOOPDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RegisteredBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RegisteredBindingSource2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RegisteredBindingSource3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RegisteredBindingSource4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RegisteredBindingSource5, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.SaddleBrown
        Me.Label1.Location = New System.Drawing.Point(-5, -2)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(613, 115)
        Me.Label1.TabIndex = 0
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.SaddleBrown
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.Control
        Me.Label2.Location = New System.Drawing.Point(151, 43)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(262, 26)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "REGISTRATION FORM"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.SystemColors.Control
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.SaddleBrown
        Me.Label3.Location = New System.Drawing.Point(15, 130)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(165, 18)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Personal Information"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(38, 182)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(73, 15)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "First Name :"
        '
        'fname1
        '
        Me.fname1.BackColor = System.Drawing.Color.LightGray
        Me.fname1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.fname1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.RegisteredBindingSource, "First Name", True))
        Me.fname1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.fname1.Location = New System.Drawing.Point(155, 175)
        Me.fname1.Margin = New System.Windows.Forms.Padding(4)
        Me.fname1.Name = "fname1"
        Me.fname1.Size = New System.Drawing.Size(252, 21)
        Me.fname1.TabIndex = 4
        '
        'RegisteredBindingSource
        '
        Me.RegisteredBindingSource.DataMember = "Registered"
        Me.RegisteredBindingSource.DataSource = Me.Act2LatestOOPDataSet
        '
        'Act2LatestOOPDataSet
        '
        Me.Act2LatestOOPDataSet.DataSetName = "Act2LatestOOPDataSet"
        Me.Act2LatestOOPDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(14, 237)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(88, 15)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "Middle Name :"
        '
        'mname1
        '
        Me.mname1.BackColor = System.Drawing.Color.LightGray
        Me.mname1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.mname1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.RegisteredBindingSource, "Middle Name", True))
        Me.mname1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mname1.Location = New System.Drawing.Point(155, 230)
        Me.mname1.Margin = New System.Windows.Forms.Padding(4)
        Me.mname1.Name = "mname1"
        Me.mname1.Size = New System.Drawing.Size(252, 21)
        Me.mname1.TabIndex = 6
        '
        'lname
        '
        Me.lname.AutoSize = True
        Me.lname.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lname.Location = New System.Drawing.Point(36, 290)
        Me.lname.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lname.Name = "lname"
        Me.lname.Size = New System.Drawing.Size(73, 15)
        Me.lname.TabIndex = 7
        Me.lname.Text = "Last Name :"
        '
        'lname1
        '
        Me.lname1.BackColor = System.Drawing.Color.LightGray
        Me.lname1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lname1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.RegisteredBindingSource, "Last Name", True))
        Me.lname1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lname1.Location = New System.Drawing.Point(155, 284)
        Me.lname1.Margin = New System.Windows.Forms.Padding(4)
        Me.lname1.Name = "lname1"
        Me.lname1.Size = New System.Drawing.Size(428, 21)
        Me.lname1.TabIndex = 8
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(415, 182)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(43, 15)
        Me.Label6.TabIndex = 9
        Me.Label6.Text = "Suffix :"
        '
        'suffix1
        '
        Me.suffix1.BackColor = System.Drawing.Color.LightGray
        Me.suffix1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.RegisteredBindingSource, "Suffix", True))
        Me.suffix1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.suffix1.FormattingEnabled = True
        Me.suffix1.Location = New System.Drawing.Point(473, 176)
        Me.suffix1.Margin = New System.Windows.Forms.Padding(4)
        Me.suffix1.Name = "suffix1"
        Me.suffix1.Size = New System.Drawing.Size(110, 28)
        Me.suffix1.TabIndex = 10
        '
        'Age
        '
        Me.Age.AutoSize = True
        Me.Age.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Age.Location = New System.Drawing.Point(81, 340)
        Me.Age.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Age.Name = "Age"
        Me.Age.Size = New System.Drawing.Size(34, 15)
        Me.Age.TabIndex = 11
        Me.Age.Text = "Age :"
        '
        'age1
        '
        Me.age1.BackColor = System.Drawing.Color.LightGray
        Me.age1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.age1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.RegisteredBindingSource, "Age", True))
        Me.age1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.age1.Location = New System.Drawing.Point(156, 341)
        Me.age1.Margin = New System.Windows.Forms.Padding(4)
        Me.age1.Name = "age1"
        Me.age1.Size = New System.Drawing.Size(133, 21)
        Me.age1.TabIndex = 12
        '
        'Address
        '
        Me.Address.AutoSize = True
        Me.Address.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Address.Location = New System.Drawing.Point(54, 392)
        Me.Address.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Address.Name = "Address"
        Me.Address.Size = New System.Drawing.Size(57, 15)
        Me.Address.TabIndex = 13
        Me.Address.Text = "Address :"
        '
        'Contact
        '
        Me.Contact.AutoSize = True
        Me.Contact.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Contact.Location = New System.Drawing.Point(35, 443)
        Me.Contact.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Contact.Name = "Contact"
        Me.Contact.Size = New System.Drawing.Size(64, 15)
        Me.Contact.TabIndex = 14
        Me.Contact.Text = "Contact # :"
        '
        'Email
        '
        Me.Email.AutoSize = True
        Me.Email.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Email.Location = New System.Drawing.Point(71, 491)
        Me.Email.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Email.Name = "Email"
        Me.Email.Size = New System.Drawing.Size(45, 15)
        Me.Email.TabIndex = 15
        Me.Email.Text = "Email :"
        '
        'housenum1
        '
        Me.housenum1.BackColor = System.Drawing.Color.LightGray
        Me.housenum1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.housenum1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.RegisteredBindingSource, "House Number/ Street", True))
        Me.housenum1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.housenum1.Location = New System.Drawing.Point(155, 387)
        Me.housenum1.Margin = New System.Windows.Forms.Padding(4)
        Me.housenum1.Name = "housenum1"
        Me.housenum1.Size = New System.Drawing.Size(134, 21)
        Me.housenum1.TabIndex = 16
        '
        'contact1
        '
        Me.contact1.BackColor = System.Drawing.Color.LightGray
        Me.contact1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.contact1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.RegisteredBindingSource, "Contact Number", True))
        Me.contact1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.contact1.Location = New System.Drawing.Point(385, 435)
        Me.contact1.Margin = New System.Windows.Forms.Padding(4)
        Me.contact1.Name = "contact1"
        Me.contact1.Size = New System.Drawing.Size(167, 21)
        Me.contact1.TabIndex = 17
        '
        'email1
        '
        Me.email1.BackColor = System.Drawing.Color.LightGray
        Me.email1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.email1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.RegisteredBindingSource, "Email", True))
        Me.email1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.email1.Location = New System.Drawing.Point(155, 483)
        Me.email1.Margin = New System.Windows.Forms.Padding(4)
        Me.email1.Name = "email1"
        Me.email1.Size = New System.Drawing.Size(406, 21)
        Me.email1.TabIndex = 18
        '
        'municipality1
        '
        Me.municipality1.BackColor = System.Drawing.Color.LightGray
        Me.municipality1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.RegisteredBindingSource, "Municipality", True))
        Me.municipality1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.municipality1.ForeColor = System.Drawing.Color.Black
        Me.municipality1.FormattingEnabled = True
        Me.municipality1.Location = New System.Drawing.Point(435, 385)
        Me.municipality1.Margin = New System.Windows.Forms.Padding(4)
        Me.municipality1.Name = "municipality1"
        Me.municipality1.Size = New System.Drawing.Size(148, 23)
        Me.municipality1.TabIndex = 19
        Me.municipality1.Text = "Municipality"
        '
        'province1
        '
        Me.province1.BackColor = System.Drawing.Color.LightGray
        Me.province1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.RegisteredBindingSource, "Province", True))
        Me.province1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.province1.ForeColor = System.Drawing.Color.Black
        Me.province1.FormattingEnabled = True
        Me.province1.Location = New System.Drawing.Point(305, 384)
        Me.province1.Margin = New System.Windows.Forms.Padding(4)
        Me.province1.Name = "province1"
        Me.province1.Size = New System.Drawing.Size(110, 23)
        Me.province1.TabIndex = 20
        Me.province1.Text = "Province"
        '
        'birthdate1
        '
        Me.birthdate1.CalendarMonthBackground = System.Drawing.Color.White
        Me.birthdate1.Location = New System.Drawing.Point(305, 337)
        Me.birthdate1.Name = "birthdate1"
        Me.birthdate1.Size = New System.Drawing.Size(278, 23)
        Me.birthdate1.TabIndex = 21
        '
        'submit
        '
        Me.submit.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.submit.Location = New System.Drawing.Point(499, 538)
        Me.submit.Name = "submit"
        Me.submit.Size = New System.Drawing.Size(84, 38)
        Me.submit.TabIndex = 22
        Me.submit.Text = "Submit"
        Me.submit.UseVisualStyleBackColor = False
        '
        'view
        '
        Me.view.BackColor = System.Drawing.Color.Gray
        Me.view.Location = New System.Drawing.Point(409, 538)
        Me.view.Name = "view"
        Me.view.Size = New System.Drawing.Size(84, 38)
        Me.view.TabIndex = 23
        Me.view.Text = "View"
        Me.view.UseVisualStyleBackColor = False
        '
        'RegisteredTableAdapter
        '
        Me.RegisteredTableAdapter.ClearBeforeFill = True
        '
        'RegisteredBindingSource1
        '
        Me.RegisteredBindingSource1.DataMember = "Registered"
        Me.RegisteredBindingSource1.DataSource = Me.Act2LatestOOPDataSet
        '
        'RegisteredBindingSource2
        '
        Me.RegisteredBindingSource2.DataMember = "Registered"
        Me.RegisteredBindingSource2.DataSource = Me.Act2LatestOOPDataSet
        '
        'RegisteredBindingSource3
        '
        Me.RegisteredBindingSource3.DataMember = "Registered"
        Me.RegisteredBindingSource3.DataSource = Me.Act2LatestOOPDataSet
        '
        'RegisteredBindingSource4
        '
        Me.RegisteredBindingSource4.DataMember = "Registered"
        Me.RegisteredBindingSource4.DataSource = Me.Act2LatestOOPDataSet
        '
        'RegisteredBindingSource5
        '
        Me.RegisteredBindingSource5.DataMember = "Registered"
        Me.RegisteredBindingSource5.DataSource = Me.Act2LatestOOPDataSet
        '
        'RegisteredTableAdapter1
        '
        Me.RegisteredTableAdapter1.ClearBeforeFill = True
        '
        'backbtn
        '
        Me.backbtn.BackColor = System.Drawing.Color.DarkOrange
        Me.backbtn.Location = New System.Drawing.Point(25, 544)
        Me.backbtn.Name = "backbtn"
        Me.backbtn.Size = New System.Drawing.Size(84, 38)
        Me.backbtn.TabIndex = 24
        Me.backbtn.Text = "Back"
        Me.backbtn.UseVisualStyleBackColor = False
        '
        'gender
        '
        Me.gender.BackColor = System.Drawing.Color.LightGray
        Me.gender.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.RegisteredBindingSource, "Suffix", True))
        Me.gender.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gender.FormattingEnabled = True
        Me.gender.Location = New System.Drawing.Point(473, 226)
        Me.gender.Margin = New System.Windows.Forms.Padding(4)
        Me.gender.Name = "gender"
        Me.gender.Size = New System.Drawing.Size(110, 28)
        Me.gender.TabIndex = 25
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(415, 232)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(48, 15)
        Me.Label7.TabIndex = 26
        Me.Label7.Text = "Gender"
        '
        'country
        '
        Me.country.BackColor = System.Drawing.Color.LightGray
        Me.country.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.RegisteredBindingSource, "Suffix", True))
        Me.country.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.country.FormattingEnabled = True
        Me.country.ItemHeight = 20
        Me.country.Location = New System.Drawing.Point(156, 431)
        Me.country.Margin = New System.Windows.Forms.Padding(4)
        Me.country.Name = "country"
        Me.country.Size = New System.Drawing.Size(205, 28)
        Me.country.TabIndex = 27
        Me.country.Text = "Country"
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(606, 594)
        Me.Controls.Add(Me.country)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.gender)
        Me.Controls.Add(Me.backbtn)
        Me.Controls.Add(Me.view)
        Me.Controls.Add(Me.submit)
        Me.Controls.Add(Me.birthdate1)
        Me.Controls.Add(Me.province1)
        Me.Controls.Add(Me.municipality1)
        Me.Controls.Add(Me.email1)
        Me.Controls.Add(Me.contact1)
        Me.Controls.Add(Me.housenum1)
        Me.Controls.Add(Me.Email)
        Me.Controls.Add(Me.Contact)
        Me.Controls.Add(Me.Address)
        Me.Controls.Add(Me.age1)
        Me.Controls.Add(Me.Age)
        Me.Controls.Add(Me.suffix1)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.lname1)
        Me.Controls.Add(Me.lname)
        Me.Controls.Add(Me.mname1)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.fname1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.Name = "Form2"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.Text = "Registration Form"
        CType(Me.RegisteredBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Act2LatestOOPDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RegisteredBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RegisteredBindingSource2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RegisteredBindingSource3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RegisteredBindingSource4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RegisteredBindingSource5, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents fname1 As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents mname1 As TextBox
    Friend WithEvents lname As Label
    Friend WithEvents lname1 As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents suffix1 As ComboBox
    Friend WithEvents Age As Label
    Friend WithEvents age1 As TextBox
    Friend WithEvents Address As Label
    Friend WithEvents Contact As Label
    Friend WithEvents Email As Label
    Friend WithEvents housenum1 As TextBox
    Friend WithEvents contact1 As TextBox
    Friend WithEvents email1 As TextBox
    Friend WithEvents municipality1 As ComboBox
    Friend WithEvents province1 As ComboBox
    Friend WithEvents birthdate1 As DateTimePicker
    Friend WithEvents submit As Button
    Friend WithEvents view As Button
    Friend WithEvents Act2LatestOOPDataSet As Act2LatestOOPDataSet
    Friend WithEvents RegisteredBindingSource As BindingSource
    Friend WithEvents RegisteredTableAdapter As Act2LatestOOPDataSetTableAdapters.RegisteredTableAdapter
    Friend WithEvents RegisteredBindingSource5 As BindingSource
    Friend WithEvents RegisteredBindingSource1 As BindingSource
    Friend WithEvents RegisteredBindingSource2 As BindingSource
    Friend WithEvents RegisteredBindingSource3 As BindingSource
    Friend WithEvents RegisteredBindingSource4 As BindingSource
    Friend WithEvents RegisteredTableAdapter1 As Act2LatestOOPDataSetTableAdapters.RegisteredTableAdapter
    Friend WithEvents backbtn As Button
    Friend WithEvents gender As ComboBox
    Friend WithEvents Label7 As Label
    Friend WithEvents country As ComboBox
End Class
