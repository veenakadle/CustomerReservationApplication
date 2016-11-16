Imports System.Data.SqlClient
Imports System.Web
Imports System.Net.Mail

Public Class NewReservation

    Public TotalAmountDecimal, DepositDecimal, DiscountDecimal,
            OrderAmountDecimal, DiscountValueDecimal As Decimal
    Private SectionIDInteger, PaymentIDInteger, ReservationIDInteger,
        ItemIDInteger As Integer
    Public DiscountIDString As String
    Public DiscountBoolean As Boolean = False
    Private Reservation As New SakuraClass

    Private Sub NewReservation_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Login.DB.CallingFormString = "NewReservation"

        'Restaurant/Dine in radio button checked by default
        DinningAreaRadioButton.Checked = True

        'Display the customer Name in the reservation details
        CustomerNameTextBox.Text = Login.CustomerFirstNameString & " " &
                                   Login.CustomerLastNameString

        TotalAmountDecimal = 0
        DepositDecimal = 0
        DiscountDecimal = 0
        DiscountValueDecimal = 0
        OrderAmountDecimal = 0

    End Sub

    Private Sub NewReservation_Activated(sender As Object, e As EventArgs) Handles Me.Activated

        'Order Amount to be updated
        If AddToCartForm.OrderAmountDecimal > 0 Then
            OrderAmountDecimal = AddToCartForm.OrderAmountDecimal
        End If

        OrderAmountTextBox.Text = OrderAmountDecimal.ToString("C")
    End Sub

    Private Sub PartyRoomRadioButton_CheckedChanged(sender As Object, e As EventArgs) Handles PartyRoomRadioButton.CheckedChanged

        If PartyRoomRadioButton.Checked = True Then
            'To date and To time need to be enabled
            ToDateTimePicker.Enabled = True
            ToTimeDateTimePicker.Enabled = True
            ToDateLabel.Visible = True
            ToTimeLabel.Visible = True
            'Display the deposit amount
            DepositDecimal = 20
            'Display the Order food in advance button
            OrderAdvanceButton.Visible = True
        Else
            ToDateTimePicker.Enabled = False
            ToTimeDateTimePicker.Enabled =
            OrderAdvanceButton.Visible = False
            ToDateLabel.Visible = False
            ToTimeLabel.Visible = False
            DepositDecimal = 0
        End If

        DepositAmountTextBox.Text = DepositDecimal.ToString("C")

    End Sub

    Private Sub OrderAdvanceButton_Click(sender As Object, e As EventArgs) Handles OrderAdvanceButton.Click
        'Call the Menu Form to order food
        MenuForm.Show()
    End Sub

    Private Sub SubmitButton_Click(sender As Object, e As EventArgs) Handles SubmitButton.Click

        Dim ErrorString As String

        'Validations
        ErrorProvider1.Clear()

        If PartyRoomRadioButton.Checked Then
            If FromDateTimePicker.Text > ToDateTimePicker.Text Then
                Me.ErrorProvider1.SetError(ToDateTimePicker,
                                           "To date cannot be lesser than From date")
                Exit Sub
            End If

            If FromTimeDateTimePicker.Text > ToTimeDateTimePicker.Text Then
                Me.ErrorProvider1.SetError(ToTimeDateTimePicker,
                               "To time cannot be lesser than From time")
                Exit Sub
            End If
        End If

        If NumberOfAdultsNumericUpDown.Value = 0 Then
            Me.ErrorProvider1.SetError(NumberOfAdultsNumericUpDown,
                                       "Number of Adults must be atleast one")
            Exit Sub
        End If

        If PartyRoomRadioButton.Checked Then
            MessageBox.Show("Please proceed to payment")
        End If

        'Check for Employee ID
        If EmployeeIDTextBox.Text <> String.Empty Then
            ErrorString = EmployeeIDCheck()
        End If

        If ErrorString <> String.Empty Or EmployeeIDTextBox.Text = String.Empty Then

            If (NumberOfAdultsNumericUpDown.Value + NumberOfChildrenNumericUpDown.Value) > 10 Then
                DiscountIDString = "CD10"
                Reservation.AddParam("@discountID", DiscountIDString)
                Reservation.ExecuteQuery("SELECT discountPercent FROM discount WHERE discountID = ?")
                If Reservation.ExceptionString <> String.Empty Then
                    MessageBox.Show(Reservation.ExceptionString)
                    Exit Sub
                End If

                DiscountDecimal = Reservation.DBDataTable.Rows(0)("discountPercent")

            End If
        End If

        DiscountTextBox.Text = DiscountDecimal.ToString("P0")

        If PartyRoomRadioButton.Checked = False Then
            BookReservation()
            Exit Sub
        End If

        'Calculate the total Amount
        If OrderAmountDecimal > 0 Then
            TotalAmountDecimal = OrderAmountDecimal - DepositDecimal
            DiscountValueDecimal = TotalAmountDecimal * DiscountDecimal
            TotalAmountDecimal = TotalAmountDecimal - DiscountValueDecimal
        Else
            'If no food is ordered, just add the 
            'Deposit amount as Total
            TotalAmountDecimal = DepositDecimal
            If DiscountDecimal > 0 Then
                'Send an email with the coupon code and description
                'Along with the reservation details
                DiscountBoolean = True
            End If
        End If

        TotalAmountTextBox.Text = TotalAmountDecimal.ToString("C")

        AmountPaidTextBox.Text = TotalAmountTextBox.Text

        'Disable Reservation details
        'Make payment details visible
        SubmitButton.Enabled = False
        PaymentGroupBox.Visible = True
    End Sub

    Private Sub BookReservation()

        Select Case True
            Case DinningAreaRadioButton.Checked
                Reservation.AddParam("@sectionName", DinningAreaRadioButton.Text)
            Case FoodBarRadioButton.Checked
                Reservation.AddParam("@sectionName", FoodBarRadioButton.Text)
            Case HibachiRadioButton.Checked
                Reservation.AddParam("@sectionName", HibachiRadioButton.Text)
            Case PartyRoomRadioButton.Checked
                Reservation.AddParam("@sectionName", PartyRoomRadioButton.Text)
        End Select

        Reservation.ExecuteQuery("SELECT sectionID FROM section WHERE sectionName = ?")
        If Reservation.ExceptionString <> String.Empty Then
            MessageBox.Show(Reservation.ExceptionString)
            Exit Sub
        End If
        SectionIDInteger = Reservation.DBDataTable.Rows(0)("sectionID")

        'Put in the details into the corresponding tables
        'Reservation Table
        Reservation.AddParam("@customerID", Login.CustomerIDInteger)
        Reservation.AddParam("@discountID", DiscountIDString)
        Reservation.AddParam("@sectionID", SectionIDInteger)
        Reservation.AddParam("@paymentID", PaymentIDInteger)
        Reservation.AddParam("@depositAmt", DepositDecimal)
        Reservation.AddParam("@orderAmt", AddToCartForm.OrderAmountDecimal)

        FromDateTimePicker.CustomFormat = "yyyy-MM-dd"
        ToDateTimePicker.CustomFormat = "yyyy-MM-dd"

        Reservation.AddParam("@fromDate", FromDateTimePicker.Text)
        If ToDateTimePicker.Enabled = False Then
            Reservation.AddParam("@toDate", DBNull.Value)
        Else
            Reservation.AddParam("@toDate", ToDateTimePicker.Text)
        End If

        FromDateTimePicker.CustomFormat = "MM/dd/yyyy"
        ToDateTimePicker.CustomFormat = "MM/dd/yyyy"

        Reservation.AddParam("@fromTime", FromTimeDateTimePicker.Text)
        If ToTimeDateTimePicker.Enabled = False Then
            Reservation.AddParam("@toTime", DBNull.Value)
        Else
            Reservation.AddParam("@toTime", ToTimeDateTimePicker.Text)
        End If

        Reservation.AddParam("@numberAdults", NumberOfAdultsNumericUpDown.Value)
        Reservation.AddParam("@numberChildren", NumberOfChildrenNumericUpDown.Value)
        Reservation.AddParam("@totalAmt", TotalAmountDecimal)
        Reservation.AddParam("@reservationStatus", "Reserved")

        Reservation.ExecuteQuery("INSERT INTO reservation(customerID, discountID, sectionID, 
                        paymentID, depositAmount, orderAmount,fromDate,toDate,fromTime,toTime,
                        numberOfAdults, numberOfChildren,totalAmount,reservationStatus) VALUES(?,?,?,?,?,?,?,?,?,?,?,?,?,?)")
        If Reservation.ExceptionString <> String.Empty Then
            MessageBox.Show(Reservation.ExceptionString)
            Exit Sub
        End If

        Reservation.ExecuteQuery("SELECT reservationID, fromDate, fromTime FROM reservation ORDER BY reservationID DESC LIMIT 1")
        If Reservation.ExceptionString <> String.Empty Then
            MessageBox.Show(Reservation.ExceptionString)
            Exit Sub
        End If
        ReservationIDInteger = Integer.Parse(Reservation.DBDataTable.Rows(0)("reservationID"))
        SendEmail(Login.CustomerEmailIDString)
        MessageBox.Show("Your reservation is successful." & Environment.NewLine &
                        "An email has been sent to " & Login.CustomerEmailIDString)

        'Order Table
        If AddToCartForm.Cart IsNot Nothing Then
            For Each item In AddToCartForm.Cart.DBDataTable.Rows
                Reservation.AddParam("@itemType", item("Item Type"))
                Reservation.ExecuteQuery("SELECT itemID FROM menuitem WHERE itemType = ?")
                If Reservation.ExceptionString <> String.Empty Then
                    MessageBox.Show(Reservation.ExceptionString)
                    Exit Sub
                End If

                ItemIDInteger = Reservation.DBDataTable.Rows(0)!itemID

                'Insert into customerorder table
                Reservation.AddParam("@reservationID", ReservationIDInteger)
                Reservation.AddParam("@itemID", ItemIDInteger)
                Reservation.AddParam("@quantity", item("Quantity"))
                Reservation.AddParam("@orderPrice", item("Price"))
                Reservation.ExecuteQuery("INSERT INTO customerorder(reservationID, itemID, quantity, orderPrice)
                                   VALUES(?,?,?,?)")
                If Reservation.ExceptionString <> String.Empty Then
                    MessageBox.Show(Reservation.ExceptionString)
                    Exit Sub
                End If
            Next
        End If
        DiscountBoolean = False
    End Sub

    Private Sub CancelButton_Click(sender As Object, e As EventArgs) Handles CancelButton.Click
        Reservation.CallingFormString = "CustomerLogin"
        CustomerLogin.Show()
        MenuForm.Close()
        AddToCartForm.Close()
        Me.Close()
    End Sub

    Function EmployeeIDCheck()

        Dim ErrorString As String

        Reservation.AddParam("@employeeID", Integer.Parse(EmployeeIDTextBox.Text))
        Reservation.ExecuteQuery("SELECT employeeID FROM employee WHERE employeeID = ?")
        If Reservation.ExceptionString <> String.Empty Then
            ErrorString = Reservation.ExceptionString
            Return ErrorString
        End If

        If Reservation.RecordCountInteger = 0 Then
            ErrorString = "Employee ID does not exist"
            DiscountDecimal = 0
            Return ErrorString
        Else
            DiscountIDString = "ED20"
            Reservation.AddParam("@discountID", "ED20")
            Reservation.ExecuteQuery("SELECT discountPercent FROM discount WHERE discountID = ?")
            If Reservation.ExceptionString <> String.Empty Then
                ErrorString = Reservation.ExceptionString
                Return ErrorString
            End If

            DiscountDecimal = Reservation.DBDataTable.Rows(0)("discountPercent")
            DiscountValueDecimal = TotalAmountDecimal * DiscountValueDecimal
            TotalAmountDecimal = TotalAmountDecimal - DiscountValueDecimal
        End If

    End Function

    Private Sub SendEmail(EmailID)

        'Send an email to the customer/organization
        Dim BodyOfEmailString, RecipientEmailString, DiscountTextString As String

        If DiscountBoolean = True Then
            DiscountTextString = "You have availed a discount of " & DiscountDecimal.ToString("P0") & Environment.NewLine &
                                "Please show the coupon code " & DiscountIDString & "to the receptionist upon arrival. "
        Else
            DiscountTextString = String.Empty
        End If

        BodyOfEmailString = "Greetings, " & Login.CustomerFirstNameString & Environment.NewLine & Environment.NewLine &
        "Your reservation has been booked. Please find the reservation details below: " & Environment.NewLine & Environment.NewLine &
        "Reservation ID: " & Reservation.DBDataTable.Rows(0)!reservationID.ToString() & Environment.NewLine &
        "Date: " & Reservation.DBDataTable.Rows(0)!fromDate.ToString() & Environment.NewLine &
        "Time: " & Reservation.DBDataTable.Rows(0)!fromTime.ToString() & Environment.NewLine & Environment.NewLine &
        DiscountTextString & Environment.NewLine &
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
        Catch ex As Exception

        End Try

    End Sub

    Private Sub ConfirmPaymentButton_Click(sender As Object, e As EventArgs) Handles ConfirmPaymentButton.Click

        ErrorProvider1.Clear()

        If CreditCardNameTextBox.Text = String.Empty Then
            Me.ErrorProvider1.SetError(CreditCardNameTextBox,
                           "Card Holder Name cannot be blank")
            Exit Sub
        End If

        If CreditCardNoTextBox.Text = String.Empty Then
            Me.ErrorProvider1.SetError(CreditCardNoTextBox,
               "Credit card number cannot be blank")
            Exit Sub
        End If

        If CVVTextBox.Text = String.Empty Then
            Me.ErrorProvider1.SetError(CVVTextBox,
                                         "CVV cannot be blank")
            Exit Sub
        End If

        'To get the latest payment ID
        Reservation.ExecuteQuery("SELECT paymentID FROM reservation ORDER BY reservationID DESC LIMIT 1")
        If Reservation.ExceptionString <> String.Empty Then
            MessageBox.Show(Reservation.ExceptionString)
            Exit Sub
        End If

        If Reservation.RecordCountInteger = 0 Then
            PaymentIDInteger = 1
        Else
            PaymentIDInteger = Integer.Parse(Reservation.DBDataTable.Rows(0)("paymentID"))
            PaymentIDInteger += 1
        End If

        BookReservation()

    End Sub

    Private Sub CancelPaymentButton_Click(sender As Object, e As EventArgs) Handles CancelPaymentButton.Click

        'Clear the boxes
        AmountPaidTextBox.Clear()
        CreditCardNameTextBox.Clear()
        CreditCardNoTextBox.Clear()
        CVVTextBox.Clear()
        ExpiryDateTimePicker.Value = DateTime.Now

        'Hide the Payment group box
        'Enable the reservation group box
        PaymentGroupBox.Visible = False
        SubmitButton.Enabled = True
    End Sub

    Private Sub LOGOUTToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LOGOUTToolStripMenuItem.Click
        Login.Show()
        Me.Close()
    End Sub

End Class