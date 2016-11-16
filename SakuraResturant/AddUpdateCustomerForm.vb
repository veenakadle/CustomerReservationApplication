Imports System.Security.Cryptography
Imports System.Text
Imports System.IO
Imports System.Data
Imports System.Configuration
Imports System.Data.SqlClient
Imports System.Web
Imports System.Net.Mail

Public Class AddUpdateCustomerForm

    Private AddUpdateAccess As New SakuraClass
    Private AddressIDInteger As Integer

    Private Sub AddUpdateCustomerForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        If CustomerMaintenanceForm.AddUpdateString = "&Add" Then
            CustomerIDLabel.Visible = False
            CustomerIDTextBox.Visible = False
        Else
            CustomerIDLabel.Visible = True
            CustomerIDTextBox.Visible = True
            CustomerIDTextBox.ReadOnly = True

            'Display the required details in the text boxes
            AddUpdateAccess.AddParam("@customerID", CustomerMaintenanceForm.CustomerIDInteger)
            AddUpdateAccess.ExecuteQuery("SELECT * FROM customer WHERE customerID =?")
            If AddUpdateAccess.ExceptionString <> String.Empty Then
                MessageBox.Show(AddUpdateAccess.ExceptionString)
                Exit Sub
            End If

            CustomerIDTextBox.Text = AddUpdateAccess.DBDataTable(0)!customerID
            FirstNameTextBox.Text = AddUpdateAccess.DBDataTable(0)!firstName
            LastNameTextBox.Text = AddUpdateAccess.DBDataTable(0)!lastName
            PhoneNumberTextBox.Text = AddUpdateAccess.DBDataTable(0)!phoneNumber
            PrimaryEmailIDTextBox.Text = AddUpdateAccess.DBDataTable(0)!primaryEmailID
            SecondaryEmailIDTextBox.Text = AddUpdateAccess.DBDataTable(0)!secondaryEmailID
            PasswordTextBox.Text = AddUpdateAccess.DBDataTable(0)!custPassword

            AddUpdateAccess.AddParam("@addressID", AddUpdateAccess.DBDataTable(0)!addressID)
            AddUpdateAccess.ExecuteQuery("SELECT * FROM houseaddress WHERE addressID = ?")
            If AddUpdateAccess.ExceptionString <> String.Empty Then
                MessageBox.Show(AddUpdateAccess.ExceptionString)
                Exit Sub
            End If

            StreetTextBox.Text = AddUpdateAccess.DBDataTable(0)!street
            CityTextBox.Text = AddUpdateAccess.DBDataTable(0)!city
            StateTextBox.Text = AddUpdateAccess.DBDataTable(0)!state
            ZipcodeTextBox.Text = AddUpdateAccess.DBDataTable(0)!zipcode
        End If

        AddUpdateButton.Text = CustomerMaintenanceForm.AddUpdateString
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

    Private Sub CancelButton_Click(sender As Object,
                                   e As EventArgs) Handles CancelButton.Click
        CustomerMaintenanceForm.Show()
        Me.Close()
    End Sub

    Private Sub AddUpdateButton_Click(sender As Object,
                                      e As EventArgs) Handles AddUpdateButton.Click

        Dim PasswordString As String

        If AddUpdateButton.Text = "&Add" Then
            'Insert customer and houseaddress tables
            AddUpdateAccess.AddParam("@street", StreetTextBox.Text)
            AddUpdateAccess.AddParam("@city", CityTextBox.Text)
            AddUpdateAccess.AddParam("@state", StateTextBox.Text)
            AddUpdateAccess.AddParam("@zipcode", ZipcodeTextBox.Text)
            AddUpdateAccess.ExecuteQuery("INSERT INTO houseaddress(street, city, state, zipcode)
                                          VALUES(?,?,?,?)")
            If AddUpdateAccess.ExceptionString <> String.Empty Then
                MessageBox.Show(AddUpdateAccess.ExceptionString)
                Exit Sub
            End If

            AddUpdateAccess.ExecuteQuery("SELECT addressID FROM houseaddress ORDER BY addressID DESC LIMIT 1")
            If AddUpdateAccess.ExceptionString <> String.Empty Then
                MessageBox.Show(AddUpdateAccess.ExceptionString)
                Exit Sub
            End If
            AddressIDInteger = AddUpdateAccess.DBDataTable(0)!addressID

            AddUpdateAccess.AddParam("@addressID", AddressIDInteger)
            AddUpdateAccess.AddParam("@firstName", FirstNameTextBox.Text)
            AddUpdateAccess.AddParam("@lastName", LastNameTextBox.Text)
            AddUpdateAccess.AddParam("@phoneNumber", PhoneNumberTextBox.Text)
            AddUpdateAccess.AddParam("@active", 1)
            AddUpdateAccess.AddParam("@primaryEmail", PrimaryEmailIDTextBox.Text)
            AddUpdateAccess.AddParam("@secondaryEmail", SecondaryEmailIDTextBox.Text)
            PasswordString = EncryptData(PasswordTextBox.Text)
            AddUpdateAccess.AddParam("@password", PasswordString)
            AddUpdateAccess.ExecuteQuery("INSERT INTO customer(addressID, firstName, lastName, phoneNumber,
                                          active, primaryEmailID, secondaryEmailID, custPassword)
                                          VALUES(?,?,?,?,?,?,?,?)")
            If AddUpdateAccess.ExceptionString <> String.Empty Then
                MessageBox.Show(AddUpdateAccess.ExceptionString)
                Exit Sub
            End If

        Else
            'Update the customer and if needed, the employee table
            AddUpdateAccess.AddParam("@firstName", FirstNameTextBox.Text)
            AddUpdateAccess.AddParam("@lastName", LastNameTextBox.Text)
            AddUpdateAccess.AddParam("@phoneNumber", PhoneNumberTextBox.Text)
            AddUpdateAccess.AddParam("@primaryEmail", PrimaryEmailIDTextBox.Text)
            AddUpdateAccess.AddParam("@secondaryEmail", SecondaryEmailIDTextBox.Text)
            PasswordString = EncryptData(PasswordTextBox.Text)
            AddUpdateAccess.AddParam("@password", PasswordString)
            AddUpdateAccess.AddParam("@customerID", CustomerIDTextBox.Text)
            AddUpdateAccess.ExecuteQuery("UPDATE customer SET firstName =?, lastName =?, phoneNumber =?,
                                          primaryEmailID=?, secondaryEmailID =?, custPassword=? WHERE customerID = ?")
            If AddUpdateAccess.ExceptionString <> String.Empty Then
                MessageBox.Show(AddUpdateAccess.ExceptionString)
                Exit Sub
            End If

            If Login.EmployeeIDInteger > 0 Then
                AddUpdateAccess.AddParam("@firstName", FirstNameTextBox.Text)
                AddUpdateAccess.AddParam("@lastName", LastNameTextBox.Text)
                AddUpdateAccess.AddParam("@phone", PhoneNumberTextBox.Text)
                AddUpdateAccess.AddParam("@email", PrimaryEmailIDTextBox.Text)
                PasswordString = EncryptData(PasswordTextBox.Text)
                AddUpdateAccess.AddParam("@password", PasswordString)
                AddUpdateAccess.AddParam("@employeeID", Login.EmployeeIDInteger)

                AddUpdateAccess.ExecuteQuery("UPDATE employee SET firstName = ?, lastName = ?,
                                             phoneNumber = ?, email = ?, empPassword = ? WHERE employeeID = ?")
                If AddUpdateAccess.ExceptionString <> String.Empty Then
                    MessageBox.Show(AddUpdateAccess.ExceptionString)
                    Exit Sub
                End If
            End If

            MessageBox.Show("Customer " & CustomerIDTextBox.Text & " updated.")
        End If
    End Sub
End Class