Public Class AddToCartForm

    Public OrderAmountDecimal As Decimal
    Public Cart As New SakuraClass

    Private Sub AddToCartForm_Load(sender As Object,
                                   e As EventArgs) Handles MyBase.Load

        Dim ComboBoxColumn As New DataGridViewComboBoxColumn()

        'Add columns to the DataGridView
        CartDataGridView.ColumnCount = 6
        CartDataGridView.Columns(0).Name = "Item Type"
        CartDataGridView.Columns(1).Name = "Item Description"

        CartDataGridView.Columns(2).Name = "Price"

        ComboBoxColumn.HeaderText = "Options"
        ComboBoxColumn.Name = "ComboBoxColumn"
        ComboBoxColumn.MaxDropDownItems = 4


        CartDataGridView.Columns.Insert(3, ComboBoxColumn)

        CartDataGridView.Columns(4).Name = "Quantity"
        CartDataGridView.Columns(5).Name = "Total Price"

        'Display the details of the Cart details in the Datagrid
        For Each item As MenuForm.CartDetails In MenuForm.CartDetailsArray
            If item.MenuTypeString = "Sushi & Sashimi" Then
                ComboBoxColumn.Items.Add("Sushi")
                ComboBoxColumn.Items.Add("Sashimi")
            End If

            If item.ItemTypeString <> String.Empty Then
                CartDataGridView.Rows.Add(item.ItemTypeString, item.ItemDescriptionString, item.UnitPriceDecimal, ComboBoxColumn.ValueMember)
            End If
        Next

        CartDataGridView.AllowUserToAddRows = False

        Dim CheckBoxColumn = New DataGridViewCheckBoxColumn()
        CheckBoxColumn.HeaderText = ""
        CheckBoxColumn.Width = 30
        CheckBoxColumn.Name = "checkBoxColumn"
        CartDataGridView.Columns.Insert(0, CheckBoxColumn)

        'To check the checkboxes
        For Each row As DataGridViewRow In CartDataGridView.Rows
            CartDataGridView.Rows(row.Index).Cells(0).Value = True

            'Make few fields read-only
            CartDataGridView.Rows(row.Index).Cells(1).ReadOnly = True
            CartDataGridView.Rows(row.Index).Cells(2).ReadOnly = True
            CartDataGridView.Rows(row.Index).Cells(3).ReadOnly = True
            CartDataGridView.Rows(row.Index).Cells(6).ReadOnly = True
        Next
    End Sub

    Private Sub CancelButton_Click(sender As Object,
                               e As EventArgs) Handles CancelButton.Click
        MenuForm.Show()
        Me.Close()
    End Sub

    Private Sub CartDataGridView_CellEndEdit(sender As Object,
                                             e As DataGridViewCellEventArgs) Handles CartDataGridView.CellEndEdit

        'If CartDataGridView.Rows(e.RowIndex).Cells(0).Value = True And CartDataGridView.Rows(e.RowIndex).Cells(5).Value <= 0 Then
        'MessageBox.Show("Quantity must be greater than 0")
        'Exit Sub
        'End If

        'When there is a change in the Quantity field, 
        'the total price needs to be updated
        If CartDataGridView.Rows(e.RowIndex).Cells(5).Value > 0 Then
            CartDataGridView.Rows(e.RowIndex).Cells(6).Value = CartDataGridView.Rows(e.RowIndex).Cells(5).Value *
                CartDataGridView.Rows(e.RowIndex).Cells(3).Value
        End If
    End Sub

    Private Sub ConfirmButton_Click(sender As Object,
                                    e As EventArgs) Handles ConfirmButton.Click

        OrderAmountDecimal = 0

        For Each row As DataGridViewRow In CartDataGridView.Rows
            If CartDataGridView.Rows(row.Index).Cells(0).Value = True Then
                OrderAmountDecimal += CartDataGridView.Rows(row.Index).Cells(6).Value
            End If
        Next

        MessageBox.Show("Your order total is: " & OrderAmountDecimal.ToString("C"))

        Cart.DBDataTable = CartDataGridView.DataSource

        NewReservation.Show()
        MenuForm.Hide()
        Me.Hide()

    End Sub
End Class