Public Class DiscountsForm

    Private DiscountAccess As New SakuraClass

    Private Sub AddDiscountToolStripMenuItem_Click(sender As Object,
                                                   e As EventArgs) Handles AddDiscountToolStripMenuItem.Click
        'Make the add discount group box visible
        AddDiscountGroupBox.Visible = True
        'Make the datagridview, the buttons, search label and search text box invisible
        DiscountDataGridView.Visible = False
        UpdateDeleteButton.Visible = False
        DBCancelButton.Visible = False
        SearchLabel.Visible = False
        SearchDiscountIDTextBox.Visible = False
        SearchDiscountIDTextBox.Clear()

        TemporaryRadioButton.Checked = False
        DatesGroupBox.Enabled = False

    End Sub

    Private Sub TemporaryRadioButton_CheckedChanged(sender As Object, e As EventArgs) Handles TemporaryRadioButton.CheckedChanged
        If TemporaryRadioButton.Checked Then
            DatesGroupBox.Enabled = True
        Else
            DatesGroupBox.Enabled = False
        End If
    End Sub

    Private Sub SaveButton_Click(sender As Object, e As EventArgs) Handles SaveButton.Click
        'Add a discount value to the database
        'Validations
        ErrorProvider1.Clear()
        If DiscountIDTextBox.Text = String.Empty Then
            ErrorProvider1.SetError(DiscountIDTextBox, "Discount ID cannot be blank")
            Exit Sub
        ElseIf DescriptionTextBox.Text = String.Empty Then
            ErrorProvider1.SetError(DescriptionTextBox, "Discount description cannot be blank")
            Exit Sub
        ElseIf DiscountValueTextBox.Text = String.Empty Or DiscountValueTextBox.Text = 0 Then
            ErrorProvider1.SetError(DiscountValueTextBox, "Discount value cannot be blank or 0")
            Exit Sub
        End If

        'Check if discount ID already exists
        DiscountAccess.AddParam("@discountID", DiscountIDTextBox.Text)
        DiscountAccess.ExecuteQuery("SELECT discountID FROM discount WHERE discountID =? AND active = 1")
        If DiscountAccess.ExceptionString <> String.Empty Then
            MessageBox.Show(DiscountAccess.ExceptionString)
            Exit Sub
        End If

        'If it does not exist, add to the table
        DiscountAccess.AddParam("@discountID", DiscountIDTextBox.Text)
        DiscountAccess.AddParam("@description", DescriptionTextBox.Text)
        DiscountAccess.AddParam("@percent", Decimal.Parse(DiscountValueTextBox.Text))

        ValidFromDateTimePicker.CustomFormat = "yyyy-MM-dd"
        ValidToDateTimePicker.CustomFormat = "yyyy-MM-dd"
        If TemporaryRadioButton.Checked Then
            DiscountAccess.AddParam("@validFrom", ValidFromDateTimePicker.Text)
            DiscountAccess.AddParam("@validTo", ValidToDateTimePicker.Text)
        Else
            DiscountAccess.AddParam("@validFrom", DBNull.Value)
            DiscountAccess.AddParam("@validTo", DBNull.Value)
        End If
        ValidFromDateTimePicker.CustomFormat = "MM-dd-yyyy"
        ValidToDateTimePicker.CustomFormat = "MM-dd-yyyy"

        DiscountAccess.AddParam("@active", 1)
        DiscountAccess.ExecuteQuery("INSERT INTO discount(discountID, discountDescription,
                                     discountPercent, validFrom, validTo, active) VALUES
                                     (?,?,?,?,?,?)")
        If DiscountAccess.ExceptionString <> String.Empty Then
            MessageBox.Show(DiscountAccess.ExceptionString)
            Exit Sub
        End If

        MessageBox.Show("Discount ID " & DiscountIDTextBox.Text & " added.")

        DiscountIDTextBox.Clear()
        DescriptionTextBox.Clear()
        DiscountValueTextBox.Clear()
        TemporaryRadioButton.Checked = False
        DatesGroupBox.Enabled = False

    End Sub

    Private Sub CancelButton_Click(sender As Object, e As EventArgs) Handles CancelButton.Click
        AddDiscountGroupBox.Visible = False
        DiscountIDTextBox.Clear()
        DescriptionTextBox.Clear()
        DiscountValueTextBox.Clear()
        ValidFromDateTimePicker.Value = Date.Now
        ValidToDateTimePicker.Value = Date.Now
        TemporaryRadioButton.Checked = False
    End Sub

    Private Sub SearchDiscountIDTextBox_KeyUp(sender As Object,
                                              e As EventArgs) Handles SearchDiscountIDTextBox.KeyUp

        DiscountAccess.AddParam("@discountID", SearchDiscountIDTextBox.Text & "%")
        DiscountAccess.ExecuteQuery("SELECT discountID AS 'Discount ID', discountDescription AS 'Discount Description',
                                     discountPercent AS 'Discount Value', validFrom AS 'Valid From', validTo AS 'Valid To' FROM discount
                                     WHERE discountID LIKE ?")
        If DiscountAccess.ExceptionString <> String.Empty Then
            MessageBox.Show(DiscountAccess.ExceptionString)
            Exit Sub
        End If
    End Sub

    Private Sub UpdateDiscountToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UpdateDiscountToolStripMenuItem.Click
        DiscountDataGridView.Visible = True
        AddDiscountGroupBox.Visible = False
        UpdateDeleteButton.Visible = True
        DBCancelButton.Visible = True

        UpdateDeleteButton.Text = "&Update"

        DiscountAccess.ExecuteQuery("SELECT discountID AS 'Discount ID', discountDescription AS 'Discount Description',
                                     discountPercent AS 'Discount Value', validFrom AS 'Valid From', validTo AS 'Valid To' FROM discount
                                     WHERE active = 1")
        If DiscountAccess.ExceptionString <> String.Empty Then
            MessageBox.Show(DiscountAccess.ExceptionString)
            Exit Sub
        End If

        DiscountDataGridView.DataSource = DiscountAccess.DBDataTable
        For Each row As DataGridViewRow In DiscountDataGridView.Rows
            DiscountDataGridView.Rows(row.Index).Cells(0).ReadOnly = True
        Next
        DiscountDataGridView.AllowUserToAddRows = False
        DiscountDataGridView.AutoResizeColumns()

    End Sub

    Private Sub DeleteDiscountToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DeleteDiscountToolStripMenuItem.Click
        DiscountDataGridView.Visible = True
        AddDiscountGroupBox.Visible = False
        UpdateDeleteButton.Visible = True
        DBCancelButton.Visible = True

        UpdateDeleteButton.Text = "&Delete"

        DiscountAccess.ExecuteQuery("SELECT discountID AS 'Discount ID', discountDescription AS 'Discount Description',
                                     discountPercent AS 'Discount Value', validFrom AS 'Valid From', validTo AS 'Valid To' FROM discount
                                     WHERE active = 1")
        If DiscountAccess.ExceptionString <> String.Empty Then
            MessageBox.Show(DiscountAccess.ExceptionString)
            Exit Sub
        End If

        DiscountDataGridView.DataSource = DiscountAccess.DBDataTable
        DiscountDataGridView.ReadOnly = True
        DiscountDataGridView.AllowUserToAddRows = False
        DiscountDataGridView.AutoResizeColumns()

    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        EmployeeMainForm.Show()
        Me.Close()
    End Sub

    Private Sub UpdateDeleteButton_Click(sender As Object, e As EventArgs) Handles UpdateDeleteButton.Click
        If UpdateDeleteButton.Text = "&Update" Then
            If DiscountDataGridView.SelectedRows.Count = 0 Then
                MessageBox.Show("Select atleast one row")
                Exit Sub
            Else
                For Each row As DataGridViewRow In DiscountDataGridView.SelectedRows
                    DiscountAccess.AddParam("@description", DiscountDataGridView.Rows(row.Index).Cells(1).Value)
                    DiscountAccess.AddParam("@value", DiscountDataGridView.Rows(row.Index).Cells(2).Value)
                    DiscountAccess.AddParam("@validFrom", DiscountDataGridView.Rows(row.Index).Cells(3).Value)
                    DiscountAccess.AddParam("@validTo", DiscountDataGridView.Rows(row.Index).Cells(4).Value)
                    DiscountAccess.AddParam("@discountID", DiscountDataGridView.Rows(row.Index).Cells(0).Value)
                    DiscountAccess.ExecuteQuery("UPDATE discount SET discountDescription =?, discountPercent = ?, validFrom = ?,
                                                 validTo = ? WHERE discountID =?")
                    If DiscountAccess.ExceptionString <> String.Empty Then
                        MessageBox.Show(DiscountAccess.ExceptionString)
                        Exit Sub
                    End If
                Next
            End If

            MessageBox.Show("Discount details successfully updated.")
        Else
            If DiscountDataGridView.SelectedRows.Count = 0 Then
                MessageBox.Show("Select one row.")
                Exit Sub
            ElseIf DiscountDataGridView.SelectedRows.Count > 1 Then
                MessageBox.Show("Select only one row.")
                Exit Sub
            End If

            If MessageBox.Show("You are going to delete the selected discount ID. " &
               "Are you sure?",
               "Confirm Deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = DialogResult.No Then
                Exit Sub
            End If

            For Each row As DataGridViewRow In DiscountDataGridView.SelectedRows
                DiscountAccess.AddParam("@discountID", DiscountDataGridView.Rows(row.Index).Cells(0).Value)
                DiscountAccess.ExecuteQuery("UPDATE discount SET active = 0 WHERE discountID =?")
                If DiscountAccess.ExceptionString <> String.Empty Then
                    MessageBox.Show(DiscountAccess.ExceptionString)
                    Exit Sub
                End If

                MessageBox.Show("Discount ID " & DiscountDataGridView.Rows(row.Index).Cells(0).Value & "deleted.")
            Next
        End If
    End Sub

    Private Sub DBCancelButton_Click(sender As Object, e As EventArgs) Handles DBCancelButton.Click
        DiscountDataGridView.Visible = False
        UpdateDeleteButton.Visible = False
        DBCancelButton.Visible = False
    End Sub

End Class