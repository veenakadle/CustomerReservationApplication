Public Class ChangeReservationForm
    Private Sub ChangeReservationForm_Load(sender As Object,
                                           e As EventArgs) Handles MyBase.Load
        'Display the customer name
        CustomerNameTextBox.Text = Login.CustomerFirstNameString & " " &
                                   Login.CustomerLastNameString
        'Display all the reservations of that customer
        'from the current date onwards
        Login.DB.AddParam("@customerID", Login.CustomerIDInteger)
        Login.DB.ExecuteQuery("SELECT r.reservationID, s.sectionName, r.discountID, d.discountPercent,
                               r.depositAmount, r.orderAmount, r.fromDate, r.toDate,
                               r.fromTime, r.toTime, r.numberOfAdults, r.numberOfChildren, 
                               r.totalAmount FROM reservation as r 
                               JOIN section as s ON r.sectionID = s.sectionID
                               JOIN discount as d ON d.discountID = r.discountID
                               WHERE r.customerID = ?")
        If Login.DB.ExceptionString <> String.Empty Then
            MessageBox.Show(Login.DB.ExceptionString)
            Exit Sub
        End If

        'Display the details in the datagrid view
        ReservationsDataGridView.DataSource = Login.DB.DBDataTable

    End Sub

    Private Sub LOGOUTToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LOGOUTToolStripMenuItem.Click
        Login.Show()
        Me.Close()
    End Sub

    Private Sub HomeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles HomeToolStripMenuItem.Click
        Login.DB.CallingFormString = "CustomerLogin"
        CustomerLogin.Show()
        Me.Close()
    End Sub

    Private Sub ReservationsDataGridView_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles ReservationsDataGridView.CellDoubleClick
        IndividualReservationForm.Show()
    End Sub
End Class