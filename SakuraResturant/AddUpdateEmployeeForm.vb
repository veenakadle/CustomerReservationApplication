Imports System.Security.Cryptography
Imports System.Text
Imports System.IO
Imports System.Data
Imports System.Configuration
Imports System.Data.SqlClient
Imports System.Web
Imports System.Net.Mail

Public Class AddUpdateEmployeeForm

    Private EmployeeAccess As New SakuraClass
    Private AddressIDInteger, SupervisorIDInteger, CustomerIDInteger As Integer

    Private PasswordString As String

    Private Sub AddUpdateEmployeeForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        If EmployeeMaintenanceForm.AddUpdateString = "&Add" Then
            'Hide the employee ID
            EmployeeIDLabel.Visible = False
            EmployeeIDTextBox.Visible = False
        Else
            'Show the employee ID
            EmployeeIDLabel.Visible = True
            EmployeeIDTextBox.Visible = True
            EmployeeIDTextBox.ReadOnly = True

            EmployeeAccess.AddParam("@employeeID", EmployeeMaintenanceForm.EmployeeIDInteger)
            EmployeeAccess.ExecuteQuery("SELECT * FROM employee WHERE employeeID = ?")
            If EmployeeAccess.ExceptionString <> String.Empty Then
                MessageBox.Show(EmployeeAccess.ExceptionString)
                Exit Sub
            End If

            'Display the details in the respective text boxes
            EmployeeIDTextBox.Text = EmployeeAccess.DBDataTable(0)!employeeID
            FirstNameTextBox.Text = EmployeeAccess.DBDataTable(0)!firstName
            LastNameTextBox.Text = EmployeeAccess.DBDataTable(0)!lastName
            PositionTextBox.Text = EmployeeAccess.DBDataTable(0)!position
            PhoneNumberTextBox.Text = EmployeeAccess.DBDataTable(0)!phoneNumber
            EmailTextBox.Text = EmployeeAccess.DBDataTable(0)!email
            PasswordTextBox.Text = EmployeeAccess.DBDataTable(0)!empPassword

            If EmployeeAccess.DBDataTable(0)!supervisorID IsNot DBNull.Value Then
                SupervisorIDInteger = EmployeeAccess.DBDataTable(0)!supervisorID
            End If

            AddressIDInteger = EmployeeAccess.DBDataTable(0)!addressID

            EmployeeAccess.AddParam("@addressID", AddressIDInteger)
            EmployeeAccess.ExecuteQuery("SELECT * FROM houseaddress WHERE addressID = ?")
            If EmployeeAccess.ExceptionString <> String.Empty Then
                MessageBox.Show(EmployeeAccess.ExceptionString)
                Exit Sub
            End If

            StreetTextBox.Text = EmployeeAccess.DBDataTable(0)!street
            CityTextBox.Text = EmployeeAccess.DBDataTable(0)!city
            StateTextBox.Text = EmployeeAccess.DBDataTable(0)!state
            ZipcodeTextBox.Text = EmployeeAccess.DBDataTable(0)!zipcode

            If SupervisorIDInteger > 0 Then
                EmployeeAccess.AddParam("@employeeID", SupervisorIDInteger)
                EmployeeAccess.ExecuteQuery("SELECT firstName, lastName FROM employee
                                         WHERE employeeID = ?")
                If EmployeeAccess.ExceptionString <> String.Empty Then
                    MessageBox.Show(EmployeeAccess.ExceptionString)
                    Exit Sub
                End If
                SupervisorComboBox.Text = EmployeeAccess.DBDataTable(0)!firstName & " " & EmployeeAccess.DBDataTable(0)!lastName
            End If
        End If

        'Fill in the supervisor combo box
        EmployeeAccess.AddParam("@position", "manager")
        EmployeeAccess.ExecuteQuery("SELECT firstName, lastName FROM employee
                                         WHERE position = ?")
        If EmployeeAccess.ExceptionString <> String.Empty Then
            MessageBox.Show(EmployeeAccess.ExceptionString)
            Exit Sub
        End If

        For Each item In EmployeeAccess.DBDataTable.Rows
            SupervisorComboBox.Items.Add(item("firstName") & " " & item("lastName"))
        Next

        'Change the name of the button to add/update an employee
        AddUpdateButton.Text = EmployeeMaintenanceForm.AddUpdateString

    End Sub

    Private Sub ExitButton_Click(sender As Object, e As EventArgs) Handles ExitButton.Click
        EmployeeMaintenanceForm.Show()
        Me.Close()
    End Sub

    Private Sub AddUpdateButton_Click(sender As Object, e As EventArgs) Handles AddUpdateButton.Click

        If AddUpdateButton.Text = "&Add" Then
            'Add the employee to the employee and houseaddress tables
            EmployeeAccess.AddParam("@street", StreetTextBox.Text)
            EmployeeAccess.AddParam("@city", CityTextBox.Text)
            EmployeeAccess.AddParam("@state", StateTextBox.Text)
            EmployeeAccess.AddParam("@zipcode", ZipcodeTextBox.Text)
            EmployeeAccess.ExecuteQuery("INSERT INTO houseaddress(street, city, state, zipcode) VALUES (?,?,?,?)")
            If EmployeeAccess.ExceptionString <> String.Empty Then
                MessageBox.Show(EmployeeAccess.ExceptionString)
                Exit Sub
            End If

            EmployeeAccess.ExecuteQuery("SELECT addressID FROM houseaddress ORDER BY addressID DESC LIMIT 1")
            If EmployeeAccess.ExceptionString <> String.Empty Then
                MessageBox.Show(EmployeeAccess.ExceptionString)
                Exit Sub
            End If
            AddressIDInteger = EmployeeAccess.DBDataTable(0)!addressID

            EmployeeAccess.AddParam("@supervisorID", SupervisorIDInteger)
            EmployeeAccess.AddParam("@addressID", AddressIDInteger)
            EmployeeAccess.AddParam("@firstName", FirstNameTextBox.Text)
            EmployeeAccess.AddParam("@lastName", LastNameTextBox.Text)
            EmployeeAccess.AddParam("@position", PositionTextBox.Text)
            EmployeeAccess.AddParam("@active", 1)
            EmployeeAccess.AddParam("@phone", PhoneNumberTextBox.Text)
            EmployeeAccess.AddParam("@email", EmailTextBox.Text)
            EmployeeAccess.AddParam("@password", "123")
            If AdminTextBox.Text = String.Empty Then
                EmployeeAccess.AddParam("@admin", 0)
            Else
                EmployeeAccess.AddParam("@admin", 1)
            End If

            EmployeeAccess.ExecuteQuery("INSERT INTO employee(supervisorID, addressID, firstName, lastName,
                                         position, active, phoneNumber, email, empPassword, admin) 
                                         VALUES(?,?,?,?,?,?,?,?,?,?)")
            If EmployeeAccess.ExceptionString <> String.Empty Then
                MessageBox.Show(EmployeeAccess.ExceptionString)
                Exit Sub
            End If

            'Add to customer table
            EmployeeAccess.AddParam("@addressID", AddressIDInteger)
            EmployeeAccess.AddParam("@firstName", FirstNameTextBox.Text)
            EmployeeAccess.AddParam("@lastName", LastNameTextBox.Text)
            EmployeeAccess.AddParam("@phone", PhoneNumberTextBox.Text)
            EmployeeAccess.AddParam("@active", 1)
            EmployeeAccess.AddParam("@email", EmailTextBox.Text)
            EmployeeAccess.AddParam("@password", "123")

            EmployeeAccess.ExecuteQuery("INSERT INTO customer(addressID, firstName, lastName, phoneNumber, 
                                         active, primaryEmailID, custPassword) 
                                         VALUES(?,?,?,?,?,?,?)")
            If EmployeeAccess.ExceptionString <> String.Empty Then
                MessageBox.Show(EmployeeAccess.ExceptionString)
                Exit Sub
            End If

            MessageBox.Show("Employee successfully added. Activation email sent to: " & EmailTextBox.Text)
            SendEmail(EmailTextBox.Text)
            ForgotPasswordform.TempPasswordString = "123"

        Else
            'Update the employee and houseaddress tables
            EmployeeAccess.AddParam("@supervisorID", SupervisorIDInteger)
            EmployeeAccess.AddParam("@firstName", FirstNameTextBox.Text)
            EmployeeAccess.AddParam("@lastName", LastNameTextBox.Text)
            EmployeeAccess.AddParam("@position", PositionTextBox.Text)
            EmployeeAccess.AddParam("@phone", PhoneNumberTextBox.Text)
            EmployeeAccess.AddParam("@email", EmailTextBox.Text)
            PasswordString = EncryptData(PasswordTextBox.Text)
            EmployeeAccess.AddParam("@password", PasswordString)
            EmployeeAccess.AddParam("@employeeID", EmployeeIDTextBox.Text)
            EmployeeAccess.AddParam("@admin", AdminTextBox.Text)

            EmployeeAccess.ExecuteQuery("UPDATE employee SET supervisorID = ?, firstName = ?, lastName = ?,
                                         position = ?, phoneNumber = ?, email = ?, empPassword = ?, admin = ?,
                                         WHERE employeeID = ?")
            If EmployeeAccess.ExceptionString <> String.Empty Then
                MessageBox.Show(EmployeeAccess.ExceptionString)
                Exit Sub
            End If

            'Update Customer table
            EmployeeAccess.AddParam("@email", EmailTextBox.Text)
            EmployeeAccess.AddParam("@password", PasswordString)
            EmployeeAccess.ExecuteQuery("SELECT customerID FROM customer WHERE primaryEmailID = ? AND custPassword = ?")
            If EmployeeAccess.ExceptionString <> String.Empty Then
                MessageBox.Show(EmployeeAccess.ExceptionString)
                Exit Sub
            End If
            CustomerIDInteger = EmployeeAccess.DBDataTable(0)!customerID

            EmployeeAccess.AddParam("@firstName", FirstNameTextBox.Text)
            EmployeeAccess.AddParam("@lastName", LastNameTextBox.Text)
            EmployeeAccess.AddParam("@phone", PhoneNumberTextBox.Text)
            EmployeeAccess.AddParam("@email", EmailTextBox.Text)
            EmployeeAccess.AddParam("@password", PasswordString)
            EmployeeAccess.AddParam("@customerID", CustomerIDInteger)

            EmployeeAccess.ExecuteQuery("UPDATE customer SET firstName = ?, lastName = ?, phoneNumber = ?, 
                                         primaryEmailID = ?, custPassword = ? WHERE customerID = ?")
            If EmployeeAccess.ExceptionString <> String.Empty Then
                MessageBox.Show(EmployeeAccess.ExceptionString)
                Exit Sub
            End If

            EmployeeAccess.AddParam("@street", StreetTextBox.Text)
            EmployeeAccess.AddParam("@city", CityTextBox.Text)
            EmployeeAccess.AddParam("@state", StateTextBox.Text)
            EmployeeAccess.AddParam("@zipcode", ZipcodeTextBox.Text)
            EmployeeAccess.AddParam("@addressID", AddressIDInteger)
            EmployeeAccess.ExecuteQuery("UPDATE houseaddress SET street = ?, city = ?,
                                         state = ?, zipcode = ? WHERE addressID = ?")

            If EmployeeAccess.ExceptionString <> String.Empty Then
                MessageBox.Show(EmployeeAccess.ExceptionString)
                Exit Sub
            End If

            MessageBox.Show("Employee ID " & EmployeeIDTextBox.Text & " updated successfully.")

        End If
    End Sub

    Private Sub SupervisorComboBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles SupervisorComboBox.SelectedIndexChanged
        Dim NameString As String = SupervisorComboBox.SelectedItem
        Dim SplitString As String() = NameString.Split()

        EmployeeAccess.AddParam("@firstName", SplitString(0))
        EmployeeAccess.AddParam("@firstName", SplitString(1))
        EmployeeAccess.AddParam("@position", "manager")

        EmployeeAccess.ExecuteQuery("SELECT employeeID FROM employee WHERE firstName = ? AND lastName = ? AND position = ?")
        If EmployeeAccess.ExceptionString <> String.Empty Then
            MessageBox.Show(EmployeeAccess.ExceptionString)
            Exit Sub
        End If

        SupervisorIDInteger = EmployeeAccess.DBDataTable(0)!employeeID

    End Sub

    Public Function EncryptData(ByVal PlainTextString As String) As String

        Dim PasswordString As String = PlainTextString 'The password to be encrypted
        Dim HashedDataByte As Byte() 'Byte array containing the encrypted string
        Dim Encoder As New UTF8Encoding() 'Used to convert the string into byte format
        Dim Md5Hasher As New MD5CryptoServiceProvider 'MD5 is an encryption method

        HashedDataByte = Md5Hasher.ComputeHash(Encoder.GetBytes(PlainTextString))

        'Convert the byte array into a string
        Return Convert.ToBase64String(HashedDataByte)

    End Function

    Private Sub SendEmail(EmailID)

        'Send an email to the customer/organization
        Dim BodyOfEmailString, RecipientEmailString As String

        BodyOfEmailString = "Greetings, " & Environment.NewLine & Environment.NewLine &
        "We are pleased to have you on-board the Sakura family!" & Environment.NewLine &
        "Your email ID is: " & EmailID & Environment.NewLine &
        "Your temporary password is: 123" & Environment.NewLine &
        "Please try to login with the temporary password, and reset the same." & Environment.NewLine &
        "Regards," & Environment.NewLine &
        "Sakura Management"

        RecipientEmailString = EmailID

        Try
            Dim SmtpServer As New SmtpClient()
            Dim mail As New MailMessage()
            SmtpServer.Credentials = New _
            Net.NetworkCredential("sakurarestaurantmanagement@gmail.com", "Sakura@123")
            SmtpServer.Port = 587
            SmtpServer.Host = "smtp.gmail.com"
            SmtpServer.EnableSsl = True
            mail = New MailMessage()
            mail.From = New MailAddress("sakurarestaurantmanagement@gmail.com")
            mail.To.Add(RecipientEmailString)
            mail.Subject = "Sakura Japanese Sushi & Hibachi - Password Reset"
            mail.Body = BodyOfEmailString
            SmtpServer.Send(mail)
            MsgBox("Email sent successfully to " + EmailID)
        Catch ex As Exception

        End Try

    End Sub

End Class