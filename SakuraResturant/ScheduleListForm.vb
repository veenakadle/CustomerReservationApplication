Public Class ScheduleListForm

    Private ScheduleAccess As New SakuraClass

    Private Sub ScheduleListForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If ScheduleListLabel.Text = "Today's Reservations" Then
            DateLabel.Visible = False
            ReservationsDateTimePicker.Visible = False

            'Display the current reservations
            ScheduleAccess.AddParam("@fromDate", Date.Now)
            ScheduleAccess.ExecuteQuery("SELECT c.firstName AS 'First Name', c.lastName AS 'Last Name', c.phoneNumber AS 'Phone Number',
                                         c.primaryEmailID AS 'Email ID', r.reservationID AS 'Reservation ID', s.sectionID,
                                         r.discountID AS 'Discount ID', d.discountDescription AS 'Discount Description', d.discountPercent AS 'Discount Value',
                                         r.fromDate AS 'From Date', r.ToDate AS 'To Date', r.fromTime AS 'From Time', r.toTime AS 'To Time',
                                         r.numberOfAdults AS 'No. Of Adults', r.numberOfChildren AS 'No. Of Children', 
                                         r.depositAmount AS 'Deposit Amount', r.orderAmount AS 'Order Amount', r.totalAmount AS 'Total Amount'
                                         FROM customer AS c JOIN reservation AS r ON c.customerID = r.customerID
                                         JOIN section AS s ON r.sectionID = s.sectionID
                                         JOIN discount AS d ON r.discountID = d.discountID WHERE r.fromDate = ?")

            If ScheduleAccess.ExceptionString <> String.Empty Then
                MessageBox.Show(ScheduleAccess.ExceptionString)
                Exit Sub
            End If

            ReservationsDataGridView.DataSource = ScheduleAccess.DBDataTable
            ReservationsDataGridView.ReadOnly = True
            ReservationsDataGridView.AutoResizeColumns()

        ElseIf scheduleListLabel.Text = "Future Reservations" Then
            DateLabel.Visible = True
            ReservationsDateTimePicker.Visible = True
            ReservationsDateTimePicker.MinDate = DateTime.Today

            'Display the current reservations
            ScheduleAccess.AddParam("@fromDate", Date.Now)
            ScheduleAccess.ExecuteQuery("SELECT c.firstName AS 'First Name', c.lastName AS 'Last Name', c.phoneNumber AS 'Phone Number',
                                         c.primaryEmailID AS 'Email ID', r.reservationID AS 'Reservation ID', s.sectionID,
                                         r.discountID AS 'Discount ID', d.discountDescription AS 'Discount Description', d.discountPercent AS 'Discount Value',
                                         r.fromDate AS 'From Date', r.ToDate AS 'To Date', r.fromTime AS 'From Time', r.toTime AS 'To Time',
                                         r.numberOfAdults AS 'No. Of Adults', r.numberOfChildren AS 'No. Of Children', 
                                         r.depositAmount AS 'Deposit Amount', r.orderAmount AS 'Order Amount', r.totalAmount AS 'Total Amount'
                                         FROM customer AS c JOIN reservation AS r ON c.customerID = r.customerID
                                         JOIN section AS s ON r.sectionID = s.sectionID
                                         JOIN discount AS d ON r.discountID = d.discountID WHERE r.fromDate > ?")

            If ScheduleAccess.ExceptionString <> String.Empty Then
                MessageBox.Show(ScheduleAccess.ExceptionString)
                Exit Sub
            End If

            ReservationsDataGridView.DataSource = ScheduleAccess.DBDataTable
            ReservationsDataGridView.ReadOnly = True
            ReservationsDataGridView.AutoResizeColumns()

        Else
            DateLabel.Visible = True
            ReservationsDateTimePicker.Visible = True
            ReservationsDateTimePicker.MaxDate = DateTime.Today

            'Display the past reservations
            ScheduleAccess.AddParam("@fromDate", Date.Now)
            ScheduleAccess.ExecuteQuery("SELECT c.firstName AS 'First Name', c.lastName AS 'Last Name', c.phoneNumber AS 'Phone Number',
                                         c.primaryEmailID AS 'Email ID', r.reservationID AS 'Reservation ID', s.sectionID,
                                         r.discountID AS 'Discount ID', d.discountDescription AS 'Discount Description', d.discountPercent AS 'Discount Value',
                                         r.fromDate AS 'From Date', r.ToDate AS 'To Date', r.fromTime AS 'From Time', r.toTime AS 'To Time',
                                         r.numberOfAdults AS 'No. Of Adults', r.numberOfChildren AS 'No. Of Children', 
                                         r.depositAmount AS 'Deposit Amount', r.orderAmount AS 'Order Amount', r.totalAmount AS 'Total Amount'
                                         FROM customer AS c JOIN reservation AS r ON c.customerID = r.customerID
                                         JOIN section AS s ON r.sectionID = s.sectionID
                                         JOIN discount AS d ON r.discountID = d.discountID WHERE r.fromDate < ?")

            If ScheduleAccess.ExceptionString <> String.Empty Then
                MessageBox.Show(ScheduleAccess.ExceptionString)
                Exit Sub
            End If

            ReservationsDataGridView.DataSource = ScheduleAccess.DBDataTable
            ReservationsDataGridView.ReadOnly = True
            ReservationsDataGridView.AutoResizeColumns()
        End If
    End Sub

    Private Sub ReservationsDateTimePicker_ValueChanged(sender As Object, e As EventArgs) Handles ReservationsDateTimePicker.ValueChanged

        ReservationsDateTimePicker.Format = DateTimePickerFormat.Custom
        ReservationsDateTimePicker.CustomFormat = "yyyy-MM-dd"
        ScheduleAccess.AddParam("@fromDate", ReservationsDateTimePicker.Text)
        ScheduleAccess.ExecuteQuery("SELECT c.firstName AS 'First Name', c.lastName AS 'Last Name', c.phoneNumber AS 'Phone Number',
                                         c.primaryEmailID AS 'Email ID', r.reservationID AS 'Reservation ID', s.sectionID,
                                         r.discountID AS 'Discount ID', d.discountDescription AS 'Discount Description', d.discountPercent AS 'Discount Value',
                                         r.fromDate AS 'From Date', r.ToDate AS 'To Date', r.fromTime AS 'From Time', r.toTime AS 'To Time',
                                         r.numberOfAdults AS 'No. Of Adults', r.numberOfChildren AS 'No. Of Children', 
                                         r.depositAmount AS 'Deposit Amount', r.orderAmount AS 'Order Amount', r.totalAmount AS 'Total Amount'
                                         FROM customer AS c JOIN reservation AS r ON c.customerID = r.customerID
                                         JOIN section AS s ON r.sectionID = s.sectionID
                                         JOIN discount AS d ON r.discountID = d.discountID WHERE r.fromDate = ?")

        If ScheduleAccess.ExceptionString <> String.Empty Then
            MessageBox.Show(ScheduleAccess.ExceptionString)
            Exit Sub
        End If

        ReservationsDataGridView.DataSource = ScheduleAccess.DBDataTable
        ReservationsDataGridView.ReadOnly = True
        ReservationsDataGridView.AutoResizeColumns()

        ReservationsDateTimePicker.Format = DateTimePickerFormat.Long
        ReservationsDateTimePicker.CustomFormat = " "
    End Sub

    Private Sub FirstNameTextBox_KeyUp(sender As Object, e As EventArgs) Handles FirstNameTextBox.KeyUp
        LastNameTextBox.Clear()
        ScheduleAccess.AddParam("@firstName", FirstNameTextBox.Text & "%")

        If ReservationsDateTimePicker.Visible = True Then
            ReservationsDateTimePicker.Format = DateTimePickerFormat.Custom
            ReservationsDateTimePicker.CustomFormat = "yyyy-MM-dd"
            ScheduleAccess.AddParam("@fromDate", ReservationsDateTimePicker.Text)
            ReservationsDateTimePicker.Format = DateTimePickerFormat.Long
            ReservationsDateTimePicker.CustomFormat = ""
        Else
            ScheduleAccess.AddParam("@fromDate", Date.Now)
        End If

        ScheduleAccess.ExecuteQuery("SELECT c.firstName AS 'First Name', c.lastName AS 'Last Name', c.phoneNumber AS 'Phone Number',
                                         c.primaryEmailID AS 'Email ID', r.reservationID AS 'Reservation ID', s.sectionID,
                                         r.discountID AS 'Discount ID', d.discountDescription AS 'Discount Description', d.discountPercent AS 'Discount Value',
                                         r.fromDate AS 'From Date', r.ToDate AS 'To Date', r.fromTime AS 'From Time', r.toTime AS 'To Time',
                                         r.numberOfAdults AS 'No. Of Adults', r.numberOfChildren AS 'No. Of Children', 
                                         r.depositAmount AS 'Deposit Amount', r.orderAmount AS 'Order Amount', r.totalAmount AS 'Total Amount'
                                         FROM customer AS c JOIN reservation AS r ON c.customerID = r.customerID
                                         JOIN section AS s ON r.sectionID = s.sectionID
                                         JOIN discount AS d ON r.discountID = d.discountID WHERE c.firstName LIKE ? AND r.fromDate = ?")

        If ScheduleAccess.ExceptionString <> String.Empty Then
            MessageBox.Show(ScheduleAccess.ExceptionString)
            Exit Sub
        End If

        ReservationsDataGridView.DataSource = ScheduleAccess.DBDataTable
        ReservationsDataGridView.ReadOnly = True
        ReservationsDataGridView.AutoResizeColumns()

    End Sub

    Private Sub LastNameTextBox_KeyUp(sender As Object, e As EventArgs) Handles LastNameTextBox.KeyUp
        FirstNameTextBox.Clear()
        ScheduleAccess.AddParam("@lastName", LastNameTextBox.Text & "%")
        If ReservationsDateTimePicker.Visible = True Then
            ReservationsDateTimePicker.Format = DateTimePickerFormat.Custom
            ReservationsDateTimePicker.CustomFormat = "yyyy-MM-dd"
            ScheduleAccess.AddParam("@fromDate", ReservationsDateTimePicker.Text)
            ReservationsDateTimePicker.Format = DateTimePickerFormat.Long
            ReservationsDateTimePicker.CustomFormat = ""
        Else
            ScheduleAccess.AddParam("@fromDate", Date.Now)
        End If
        ScheduleAccess.ExecuteQuery("SELECT c.firstName AS 'First Name', c.lastName AS 'Last Name', c.phoneNumber AS 'Phone Number',
                                         c.primaryEmailID AS 'Email ID', r.reservationID AS 'Reservation ID', s.sectionID,
                                         r.discountID AS 'Discount ID', d.discountDescription AS 'Discount Description', d.discountPercent AS 'Discount Value',
                                         r.fromDate AS 'From Date', r.ToDate AS 'To Date', r.fromTime AS 'From Time', r.toTime AS 'To Time',
                                         r.numberOfAdults AS 'No. Of Adults', r.numberOfChildren AS 'No. Of Children', 
                                         r.depositAmount AS 'Deposit Amount', r.orderAmount AS 'Order Amount', r.totalAmount AS 'Total Amount'
                                         FROM customer AS c JOIN reservation AS r ON c.customerID = r.customerID
                                         JOIN section AS s ON r.sectionID = s.sectionID
                                         JOIN discount AS d ON r.discountID = d.discountID WHERE c.lastName LIKE ? AND r.fromDate = ?")

        If ScheduleAccess.ExceptionString <> String.Empty Then
            MessageBox.Show(ScheduleAccess.ExceptionString)
            Exit Sub
        End If

        ReservationsDataGridView.DataSource = ScheduleAccess.DBDataTable
        ReservationsDataGridView.ReadOnly = True
        ReservationsDataGridView.AutoResizeColumns()
    End Sub

    Private Sub BackButton_Click(sender As Object, e As EventArgs) Handles BackButton.Click
        EmployeeMainForm.Show()
        Me.Close()
    End Sub
End Class