Public Class EmployeeMainForm
    Private Sub EmployeeMainForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Set the welcome String
        EmployeeNameLabel.Text = "Welcome,  " & Login.EmployeeFirstNameString & " " &
                                                Login.EmployeeLastNameString
    End Sub

    Private Sub LogoutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LogoutToolStripMenuItem.Click
        Login.Show()
        Me.Close()
    End Sub

    Private Sub MenuToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MenuToolStripMenuItem.Click
        MenuMaintenanceForm.Show()
        Me.Close()
    End Sub

    Private Sub SectionToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SectionToolStripMenuItem.Click
        AddUpdateSectionForm.Show()
        Me.Close()
    End Sub

    Private Sub DiscountsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DiscountsToolStripMenuItem.Click
        DiscountsForm.Show()
        Me.Close()
    End Sub

    Private Sub ViewTodaysReservationsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ViewTodaysReservationsToolStripMenuItem.Click
        ScheduleListForm.ScheduleListLabel.Text = "Today's Reservations"
        ScheduleListForm.Show()
        Me.Close()
    End Sub

    Private Sub ViewFutureReservationsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ViewFutureReservationsToolStripMenuItem.Click
        ScheduleListForm.ScheduleListLabel.Text = "Future Reservations"
        ScheduleListForm.Show()
        Me.Close()
    End Sub

    Private Sub ViewPastReservationsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ViewPastReservationsToolStripMenuItem.Click
        ScheduleListForm.ScheduleListLabel.Text = "Past Reservations"
        ScheduleListForm.Show()
        Me.Close()
    End Sub

    Private Sub EmployeeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EmployeeToolStripMenuItem.Click
        EmployeeMaintenanceForm.Show()
        Me.Close()
    End Sub

    Private Sub ReservationsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ReservationsToolStripMenuItem.Click
        ReservationMaintenanceForm.Show()
        Me.Close()
    End Sub

    Private Sub CustomerToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CustomerToolStripMenuItem.Click
        CustomerMaintenanceForm.Show()
        Me.Close()
    End Sub
End Class