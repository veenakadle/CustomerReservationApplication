Public Class IndividualReservationForm
    Private Sub IndividualReservationForm_Load(sender As Object,
                                               e As EventArgs) Handles MyBase.Load

        'Display the details in the corresponding fields
        ReservationIDTextBox.Text = Login.DB.DBDataTable(0)!reservationID
        DepositAmountTextBox.Text = Login.DB.DBDataTable(0)!depositAmount
        DiscountTextBox.Text = Login.DB.DBDataTable(0)!discountPercent
        OrderAmountTextBox.Text = Login.DB.DBDataTable(0)!orderAmount
        TotalAmountTextBox.Text = Login.DB.DBDataTable(0)!totalAmount
        FromDateTimePicker.Value = Login.DB.DBDataTable(0)!fromDate
        ToDateTimePicker.Value = Login.DB.DBDataTable(0)!toDate
        FromTimeDateTimePicker.Text = Login.DB.DBDataTable(0)!fromTime.ToString()
        ToTimeDateTimePicker.Text = Login.DB.DBDataTable(0)!toTime.ToString()
        NumberOfAdultsNumericUpDown.Value = Login.DB.DBDataTable(0)!numberOfAdults
        NumberOfChildrenNumericUpDown.Value = Login.DB.DBDataTable(0)!numberOfChildren

        Select Case Login.DB.DBDataTable(0)!sectionName
            Case "Party Room"
                PartyRoomRadioButton.Checked = True
                OrderAdvanceButton.Visible = True
            Case "Restaurant/Dine In"
                DinningAreaRadioButton.Checked = True
                OrderAdvanceButton.Visible = False
            Case "Food Bar"
                FoodBarRadioButton.Checked = True
                OrderAdvanceButton.Visible = False
            Case "Hibachi"
                HibachiRadioButton.Checked = True
                OrderAdvanceButton.Visible = False
        End Select

    End Sub
    Private Sub CancelButton_Click(sender As Object,
                                   e As EventArgs) Handles CancelButton.Click
        ChangeReservationForm.Show()
        Me.Close()
    End Sub

    Private Sub OrderAdvanceButton_Click(sender As Object,
                                         e As EventArgs) Handles OrderAdvanceButton.Click
        'Set the Calling Form String
        Login.DB.CallingFormString = Me.Name
        MenuForm.Show()
    End Sub

End Class