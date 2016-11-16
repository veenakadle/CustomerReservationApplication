<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AddUpdateCustomerForm
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
        Me.CustomerGroupBox = New System.Windows.Forms.GroupBox()
        Me.CustomerIDLabel = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.CustomerIDTextBox = New System.Windows.Forms.TextBox()
        Me.FirstNameTextBox = New System.Windows.Forms.TextBox()
        Me.LastNameTextBox = New System.Windows.Forms.TextBox()
        Me.PhoneNumberTextBox = New System.Windows.Forms.TextBox()
        Me.PrimaryEmailIDTextBox = New System.Windows.Forms.TextBox()
        Me.SecondaryEmailIDTextBox = New System.Windows.Forms.TextBox()
        Me.PasswordTextBox = New System.Windows.Forms.TextBox()
        Me.AddressGroupBox = New System.Windows.Forms.GroupBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.ZipcodeTextBox = New System.Windows.Forms.TextBox()
        Me.StateTextBox = New System.Windows.Forms.TextBox()
        Me.CityTextBox = New System.Windows.Forms.TextBox()
        Me.StreetTextBox = New System.Windows.Forms.TextBox()
        Me.AddUpdateButton = New System.Windows.Forms.Button()
        Me.CancelButton = New System.Windows.Forms.Button()
        Me.CustomerGroupBox.SuspendLayout()
        Me.AddressGroupBox.SuspendLayout()
        Me.SuspendLayout()
        '
        'CustomerGroupBox
        '
        Me.CustomerGroupBox.Controls.Add(Me.CancelButton)
        Me.CustomerGroupBox.Controls.Add(Me.AddUpdateButton)
        Me.CustomerGroupBox.Controls.Add(Me.AddressGroupBox)
        Me.CustomerGroupBox.Controls.Add(Me.PasswordTextBox)
        Me.CustomerGroupBox.Controls.Add(Me.SecondaryEmailIDTextBox)
        Me.CustomerGroupBox.Controls.Add(Me.PrimaryEmailIDTextBox)
        Me.CustomerGroupBox.Controls.Add(Me.PhoneNumberTextBox)
        Me.CustomerGroupBox.Controls.Add(Me.LastNameTextBox)
        Me.CustomerGroupBox.Controls.Add(Me.FirstNameTextBox)
        Me.CustomerGroupBox.Controls.Add(Me.CustomerIDTextBox)
        Me.CustomerGroupBox.Controls.Add(Me.Label7)
        Me.CustomerGroupBox.Controls.Add(Me.Label6)
        Me.CustomerGroupBox.Controls.Add(Me.Label5)
        Me.CustomerGroupBox.Controls.Add(Me.Label4)
        Me.CustomerGroupBox.Controls.Add(Me.Label3)
        Me.CustomerGroupBox.Controls.Add(Me.Label2)
        Me.CustomerGroupBox.Controls.Add(Me.CustomerIDLabel)
        Me.CustomerGroupBox.Location = New System.Drawing.Point(144, 29)
        Me.CustomerGroupBox.Name = "CustomerGroupBox"
        Me.CustomerGroupBox.Size = New System.Drawing.Size(410, 541)
        Me.CustomerGroupBox.TabIndex = 0
        Me.CustomerGroupBox.TabStop = False
        Me.CustomerGroupBox.Text = "Customer Details"
        '
        'CustomerIDLabel
        '
        Me.CustomerIDLabel.AutoSize = True
        Me.CustomerIDLabel.Location = New System.Drawing.Point(72, 36)
        Me.CustomerIDLabel.Name = "CustomerIDLabel"
        Me.CustomerIDLabel.Size = New System.Drawing.Size(73, 15)
        Me.CustomerIDLabel.TabIndex = 0
        Me.CustomerIDLabel.Text = "Customer ID"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(81, 67)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(64, 15)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "First Name"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(82, 98)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(63, 15)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Last Name"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(57, 129)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(88, 15)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Phone Number"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(51, 160)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(94, 15)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Primary Email ID"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(37, 191)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(108, 15)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Secondary Email ID"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(88, 222)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(57, 15)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "Password"
        '
        'CustomerIDTextBox
        '
        Me.CustomerIDTextBox.Location = New System.Drawing.Point(161, 33)
        Me.CustomerIDTextBox.MaxLength = 10
        Me.CustomerIDTextBox.Name = "CustomerIDTextBox"
        Me.CustomerIDTextBox.Size = New System.Drawing.Size(83, 23)
        Me.CustomerIDTextBox.TabIndex = 0
        '
        'FirstNameTextBox
        '
        Me.FirstNameTextBox.Location = New System.Drawing.Point(161, 64)
        Me.FirstNameTextBox.MaxLength = 45
        Me.FirstNameTextBox.Name = "FirstNameTextBox"
        Me.FirstNameTextBox.Size = New System.Drawing.Size(167, 23)
        Me.FirstNameTextBox.TabIndex = 1
        '
        'LastNameTextBox
        '
        Me.LastNameTextBox.Location = New System.Drawing.Point(161, 98)
        Me.LastNameTextBox.MaxLength = 45
        Me.LastNameTextBox.Name = "LastNameTextBox"
        Me.LastNameTextBox.Size = New System.Drawing.Size(167, 23)
        Me.LastNameTextBox.TabIndex = 2
        '
        'PhoneNumberTextBox
        '
        Me.PhoneNumberTextBox.Location = New System.Drawing.Point(161, 129)
        Me.PhoneNumberTextBox.MaxLength = 10
        Me.PhoneNumberTextBox.Name = "PhoneNumberTextBox"
        Me.PhoneNumberTextBox.Size = New System.Drawing.Size(97, 23)
        Me.PhoneNumberTextBox.TabIndex = 3
        '
        'PrimaryEmailIDTextBox
        '
        Me.PrimaryEmailIDTextBox.Location = New System.Drawing.Point(161, 157)
        Me.PrimaryEmailIDTextBox.MaxLength = 50
        Me.PrimaryEmailIDTextBox.Name = "PrimaryEmailIDTextBox"
        Me.PrimaryEmailIDTextBox.Size = New System.Drawing.Size(196, 23)
        Me.PrimaryEmailIDTextBox.TabIndex = 4
        '
        'SecondaryEmailIDTextBox
        '
        Me.SecondaryEmailIDTextBox.Location = New System.Drawing.Point(161, 188)
        Me.SecondaryEmailIDTextBox.MaxLength = 50
        Me.SecondaryEmailIDTextBox.Name = "SecondaryEmailIDTextBox"
        Me.SecondaryEmailIDTextBox.Size = New System.Drawing.Size(196, 23)
        Me.SecondaryEmailIDTextBox.TabIndex = 5
        '
        'PasswordTextBox
        '
        Me.PasswordTextBox.Location = New System.Drawing.Point(161, 219)
        Me.PasswordTextBox.MaxLength = 45
        Me.PasswordTextBox.Name = "PasswordTextBox"
        Me.PasswordTextBox.Size = New System.Drawing.Size(196, 23)
        Me.PasswordTextBox.TabIndex = 6
        '
        'AddressGroupBox
        '
        Me.AddressGroupBox.Controls.Add(Me.Label19)
        Me.AddressGroupBox.Controls.Add(Me.Label14)
        Me.AddressGroupBox.Controls.Add(Me.Label17)
        Me.AddressGroupBox.Controls.Add(Me.Label18)
        Me.AddressGroupBox.Controls.Add(Me.ZipcodeTextBox)
        Me.AddressGroupBox.Controls.Add(Me.StateTextBox)
        Me.AddressGroupBox.Controls.Add(Me.CityTextBox)
        Me.AddressGroupBox.Controls.Add(Me.StreetTextBox)
        Me.AddressGroupBox.Location = New System.Drawing.Point(12, 261)
        Me.AddressGroupBox.Name = "AddressGroupBox"
        Me.AddressGroupBox.Size = New System.Drawing.Size(379, 186)
        Me.AddressGroupBox.TabIndex = 151
        Me.AddressGroupBox.TabStop = False
        Me.AddressGroupBox.Text = "Address"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(44, 142)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(53, 15)
        Me.Label19.TabIndex = 72
        Me.Label19.Text = "Zipcode:"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(61, 101)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(36, 15)
        Me.Label14.TabIndex = 72
        Me.Label14.Text = "State:"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(66, 65)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(31, 15)
        Me.Label17.TabIndex = 72
        Me.Label17.Text = "City:"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(57, 30)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(40, 15)
        Me.Label18.TabIndex = 72
        Me.Label18.Text = "Street:"
        '
        'ZipcodeTextBox
        '
        Me.ZipcodeTextBox.Location = New System.Drawing.Point(103, 138)
        Me.ZipcodeTextBox.MaxLength = 45
        Me.ZipcodeTextBox.Name = "ZipcodeTextBox"
        Me.ZipcodeTextBox.Size = New System.Drawing.Size(83, 23)
        Me.ZipcodeTextBox.TabIndex = 3
        '
        'StateTextBox
        '
        Me.StateTextBox.Location = New System.Drawing.Point(103, 101)
        Me.StateTextBox.MaxLength = 45
        Me.StateTextBox.Name = "StateTextBox"
        Me.StateTextBox.Size = New System.Drawing.Size(143, 23)
        Me.StateTextBox.TabIndex = 2
        '
        'CityTextBox
        '
        Me.CityTextBox.Location = New System.Drawing.Point(103, 64)
        Me.CityTextBox.MaxLength = 45
        Me.CityTextBox.Name = "CityTextBox"
        Me.CityTextBox.Size = New System.Drawing.Size(143, 23)
        Me.CityTextBox.TabIndex = 1
        '
        'StreetTextBox
        '
        Me.StreetTextBox.Location = New System.Drawing.Point(103, 27)
        Me.StreetTextBox.MaxLength = 45
        Me.StreetTextBox.Name = "StreetTextBox"
        Me.StreetTextBox.Size = New System.Drawing.Size(252, 23)
        Me.StreetTextBox.TabIndex = 0
        '
        'AddUpdateButton
        '
        Me.AddUpdateButton.Location = New System.Drawing.Point(115, 479)
        Me.AddUpdateButton.Name = "AddUpdateButton"
        Me.AddUpdateButton.Size = New System.Drawing.Size(75, 23)
        Me.AddUpdateButton.TabIndex = 7
        Me.AddUpdateButton.Text = "&Add"
        Me.AddUpdateButton.UseVisualStyleBackColor = True
        '
        'CancelButton
        '
        Me.CancelButton.Location = New System.Drawing.Point(226, 479)
        Me.CancelButton.Name = "CancelButton"
        Me.CancelButton.Size = New System.Drawing.Size(75, 23)
        Me.CancelButton.TabIndex = 9
        Me.CancelButton.Text = "&Cancel"
        Me.CancelButton.UseVisualStyleBackColor = True
        '
        'AddUpdateCustomerForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LemonChiffon
        Me.ClientSize = New System.Drawing.Size(684, 611)
        Me.Controls.Add(Me.CustomerGroupBox)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "AddUpdateCustomerForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Sakura Japanese Sushi & Hibachi - Customer Details"
        Me.CustomerGroupBox.ResumeLayout(False)
        Me.CustomerGroupBox.PerformLayout()
        Me.AddressGroupBox.ResumeLayout(False)
        Me.AddressGroupBox.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents CustomerGroupBox As GroupBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents CustomerIDLabel As Label
    Friend WithEvents CustomerIDTextBox As TextBox
    Friend WithEvents PasswordTextBox As TextBox
    Friend WithEvents SecondaryEmailIDTextBox As TextBox
    Friend WithEvents PrimaryEmailIDTextBox As TextBox
    Friend WithEvents PhoneNumberTextBox As TextBox
    Friend WithEvents LastNameTextBox As TextBox
    Friend WithEvents FirstNameTextBox As TextBox
    Friend WithEvents AddressGroupBox As GroupBox
    Friend WithEvents Label19 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents Label18 As Label
    Friend WithEvents ZipcodeTextBox As TextBox
    Friend WithEvents StateTextBox As TextBox
    Friend WithEvents CityTextBox As TextBox
    Friend WithEvents StreetTextBox As TextBox
    Friend WithEvents CancelButton As Button
    Friend WithEvents AddUpdateButton As Button
End Class
