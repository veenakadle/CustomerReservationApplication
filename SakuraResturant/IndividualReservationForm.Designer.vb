<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class IndividualReservationForm
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
        Me.ReservationGroupBox = New System.Windows.Forms.GroupBox()
        Me.ReservationIDTextBox = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.CancelButton = New System.Windows.Forms.Button()
        Me.DiscountTextBox = New System.Windows.Forms.TextBox()
        Me.UpdateReservationButton = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.OrderAmountTextBox = New System.Windows.Forms.TextBox()
        Me.ToDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.TotalAmountTextBox = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.DepositAmountTextBox = New System.Windows.Forms.TextBox()
        Me.FromTimeDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.ToTimeDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.FromDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.OrderAdvanceButton = New System.Windows.Forms.Button()
        Me.DinningAreaRadioButton = New System.Windows.Forms.RadioButton()
        Me.FoodBarRadioButton = New System.Windows.Forms.RadioButton()
        Me.HibachiRadioButton = New System.Windows.Forms.RadioButton()
        Me.PartyRoomRadioButton = New System.Windows.Forms.RadioButton()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.NumberOfAdultsNumericUpDown = New System.Windows.Forms.NumericUpDown()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.NumberOfChildrenNumericUpDown = New System.Windows.Forms.NumericUpDown()
        Me.ReservationGroupBox.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.NumberOfAdultsNumericUpDown, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumberOfChildrenNumericUpDown, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ReservationGroupBox
        '
        Me.ReservationGroupBox.Controls.Add(Me.ReservationIDTextBox)
        Me.ReservationGroupBox.Controls.Add(Me.Label8)
        Me.ReservationGroupBox.Controls.Add(Me.CancelButton)
        Me.ReservationGroupBox.Controls.Add(Me.DiscountTextBox)
        Me.ReservationGroupBox.Controls.Add(Me.UpdateReservationButton)
        Me.ReservationGroupBox.Controls.Add(Me.Label2)
        Me.ReservationGroupBox.Controls.Add(Me.Label11)
        Me.ReservationGroupBox.Controls.Add(Me.Label3)
        Me.ReservationGroupBox.Controls.Add(Me.OrderAmountTextBox)
        Me.ReservationGroupBox.Controls.Add(Me.ToDateTimePicker)
        Me.ReservationGroupBox.Controls.Add(Me.TotalAmountTextBox)
        Me.ReservationGroupBox.Controls.Add(Me.Label4)
        Me.ReservationGroupBox.Controls.Add(Me.DepositAmountTextBox)
        Me.ReservationGroupBox.Controls.Add(Me.FromTimeDateTimePicker)
        Me.ReservationGroupBox.Controls.Add(Me.Label10)
        Me.ReservationGroupBox.Controls.Add(Me.ToTimeDateTimePicker)
        Me.ReservationGroupBox.Controls.Add(Me.Label9)
        Me.ReservationGroupBox.Controls.Add(Me.Label5)
        Me.ReservationGroupBox.Controls.Add(Me.Label1)
        Me.ReservationGroupBox.Controls.Add(Me.FromDateTimePicker)
        Me.ReservationGroupBox.Controls.Add(Me.GroupBox1)
        Me.ReservationGroupBox.Controls.Add(Me.Label6)
        Me.ReservationGroupBox.Controls.Add(Me.NumberOfAdultsNumericUpDown)
        Me.ReservationGroupBox.Controls.Add(Me.Label7)
        Me.ReservationGroupBox.Controls.Add(Me.NumberOfChildrenNumericUpDown)
        Me.ReservationGroupBox.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.ReservationGroupBox.Location = New System.Drawing.Point(37, 24)
        Me.ReservationGroupBox.Name = "ReservationGroupBox"
        Me.ReservationGroupBox.Size = New System.Drawing.Size(551, 594)
        Me.ReservationGroupBox.TabIndex = 36
        Me.ReservationGroupBox.TabStop = False
        '
        'ReservationIDTextBox
        '
        Me.ReservationIDTextBox.Location = New System.Drawing.Point(237, 27)
        Me.ReservationIDTextBox.Name = "ReservationIDTextBox"
        Me.ReservationIDTextBox.ReadOnly = True
        Me.ReservationIDTextBox.Size = New System.Drawing.Size(100, 23)
        Me.ReservationIDTextBox.TabIndex = 34
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label8.Location = New System.Drawing.Point(137, 30)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(82, 15)
        Me.Label8.TabIndex = 33
        Me.Label8.Text = "Reservation ID"
        '
        'CancelButton
        '
        Me.CancelButton.ForeColor = System.Drawing.SystemColors.ControlText
        Me.CancelButton.Location = New System.Drawing.Point(279, 549)
        Me.CancelButton.Name = "CancelButton"
        Me.CancelButton.Size = New System.Drawing.Size(159, 27)
        Me.CancelButton.TabIndex = 13
        Me.CancelButton.Text = "Cancel"
        Me.CancelButton.UseVisualStyleBackColor = True
        '
        'DiscountTextBox
        '
        Me.DiscountTextBox.Location = New System.Drawing.Point(252, 441)
        Me.DiscountTextBox.Name = "DiscountTextBox"
        Me.DiscountTextBox.ReadOnly = True
        Me.DiscountTextBox.Size = New System.Drawing.Size(103, 23)
        Me.DiscountTextBox.TabIndex = 9
        '
        'UpdateReservationButton
        '
        Me.UpdateReservationButton.ForeColor = System.Drawing.SystemColors.ControlText
        Me.UpdateReservationButton.Location = New System.Drawing.Point(101, 549)
        Me.UpdateReservationButton.Name = "UpdateReservationButton"
        Me.UpdateReservationButton.Size = New System.Drawing.Size(159, 27)
        Me.UpdateReservationButton.TabIndex = 12
        Me.UpdateReservationButton.Text = "&Update Reservation"
        Me.UpdateReservationButton.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label2.Location = New System.Drawing.Point(154, 62)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(62, 15)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "From Date"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label11.Location = New System.Drawing.Point(177, 444)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(54, 15)
        Me.Label11.TabIndex = 32
        Me.Label11.Text = "Discount"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label3.Location = New System.Drawing.Point(170, 91)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(47, 15)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "To Date"
        '
        'OrderAmountTextBox
        '
        Me.OrderAmountTextBox.Location = New System.Drawing.Point(252, 471)
        Me.OrderAmountTextBox.Name = "OrderAmountTextBox"
        Me.OrderAmountTextBox.ReadOnly = True
        Me.OrderAmountTextBox.Size = New System.Drawing.Size(103, 23)
        Me.OrderAmountTextBox.TabIndex = 10
        '
        'ToDateTimePicker
        '
        Me.ToDateTimePicker.CustomFormat = "MM/dd/yyyy"
        Me.ToDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.ToDateTimePicker.Location = New System.Drawing.Point(237, 85)
        Me.ToDateTimePicker.Name = "ToDateTimePicker"
        Me.ToDateTimePicker.Size = New System.Drawing.Size(233, 23)
        Me.ToDateTimePicker.TabIndex = 2
        '
        'TotalAmountTextBox
        '
        Me.TotalAmountTextBox.Location = New System.Drawing.Point(252, 501)
        Me.TotalAmountTextBox.Name = "TotalAmountTextBox"
        Me.TotalAmountTextBox.ReadOnly = True
        Me.TotalAmountTextBox.Size = New System.Drawing.Size(103, 23)
        Me.TotalAmountTextBox.TabIndex = 11
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label4.Location = New System.Drawing.Point(167, 153)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(50, 15)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "To Time"
        '
        'DepositAmountTextBox
        '
        Me.DepositAmountTextBox.Location = New System.Drawing.Point(252, 414)
        Me.DepositAmountTextBox.Name = "DepositAmountTextBox"
        Me.DepositAmountTextBox.ReadOnly = True
        Me.DepositAmountTextBox.Size = New System.Drawing.Size(103, 23)
        Me.DepositAmountTextBox.TabIndex = 8
        '
        'FromTimeDateTimePicker
        '
        Me.FromTimeDateTimePicker.CustomFormat = "HH:MM:ss"
        Me.FromTimeDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.FromTimeDateTimePicker.Location = New System.Drawing.Point(237, 116)
        Me.FromTimeDateTimePicker.Name = "FromTimeDateTimePicker"
        Me.FromTimeDateTimePicker.ShowUpDown = True
        Me.FromTimeDateTimePicker.Size = New System.Drawing.Size(233, 23)
        Me.FromTimeDateTimePicker.TabIndex = 3
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label10.Location = New System.Drawing.Point(151, 504)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(80, 15)
        Me.Label10.TabIndex = 28
        Me.Label10.Text = "Total Amount"
        '
        'ToTimeDateTimePicker
        '
        Me.ToTimeDateTimePicker.CustomFormat = "HH:MM:ss"
        Me.ToTimeDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.ToTimeDateTimePicker.Location = New System.Drawing.Point(237, 147)
        Me.ToTimeDateTimePicker.Name = "ToTimeDateTimePicker"
        Me.ToTimeDateTimePicker.ShowUpDown = True
        Me.ToTimeDateTimePicker.Size = New System.Drawing.Size(233, 23)
        Me.ToTimeDateTimePicker.TabIndex = 4
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label9.Location = New System.Drawing.Point(147, 474)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(84, 15)
        Me.Label9.TabIndex = 27
        Me.Label9.Text = "Order Amount"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label5.Location = New System.Drawing.Point(154, 122)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(65, 15)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "From Time"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label1.Location = New System.Drawing.Point(137, 417)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(94, 15)
        Me.Label1.TabIndex = 26
        Me.Label1.Text = "Deposit Amount"
        '
        'FromDateTimePicker
        '
        Me.FromDateTimePicker.CustomFormat = "MM/dd/yyyy"
        Me.FromDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.FromDateTimePicker.Location = New System.Drawing.Point(237, 56)
        Me.FromDateTimePicker.Name = "FromDateTimePicker"
        Me.FromDateTimePicker.Size = New System.Drawing.Size(233, 23)
        Me.FromDateTimePicker.TabIndex = 1
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.OrderAdvanceButton)
        Me.GroupBox1.Controls.Add(Me.DinningAreaRadioButton)
        Me.GroupBox1.Controls.Add(Me.FoodBarRadioButton)
        Me.GroupBox1.Controls.Add(Me.HibachiRadioButton)
        Me.GroupBox1.Controls.Add(Me.PartyRoomRadioButton)
        Me.GroupBox1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.GroupBox1.Location = New System.Drawing.Point(80, 248)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(380, 148)
        Me.GroupBox1.TabIndex = 7
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Select a Section"
        '
        'OrderAdvanceButton
        '
        Me.OrderAdvanceButton.ForeColor = System.Drawing.SystemColors.ControlText
        Me.OrderAdvanceButton.Location = New System.Drawing.Point(159, 95)
        Me.OrderAdvanceButton.Name = "OrderAdvanceButton"
        Me.OrderAdvanceButton.Size = New System.Drawing.Size(147, 23)
        Me.OrderAdvanceButton.TabIndex = 21
        Me.OrderAdvanceButton.Text = "Order food in advance?"
        Me.OrderAdvanceButton.UseVisualStyleBackColor = True
        Me.OrderAdvanceButton.Visible = False
        '
        'DinningAreaRadioButton
        '
        Me.DinningAreaRadioButton.AutoSize = True
        Me.DinningAreaRadioButton.Location = New System.Drawing.Point(21, 22)
        Me.DinningAreaRadioButton.Name = "DinningAreaRadioButton"
        Me.DinningAreaRadioButton.Size = New System.Drawing.Size(123, 19)
        Me.DinningAreaRadioButton.TabIndex = 19
        Me.DinningAreaRadioButton.TabStop = True
        Me.DinningAreaRadioButton.Text = "Restaurant/Dine In"
        Me.DinningAreaRadioButton.UseVisualStyleBackColor = True
        '
        'FoodBarRadioButton
        '
        Me.FoodBarRadioButton.AutoSize = True
        Me.FoodBarRadioButton.Location = New System.Drawing.Point(21, 47)
        Me.FoodBarRadioButton.Name = "FoodBarRadioButton"
        Me.FoodBarRadioButton.Size = New System.Drawing.Size(72, 19)
        Me.FoodBarRadioButton.TabIndex = 20
        Me.FoodBarRadioButton.TabStop = True
        Me.FoodBarRadioButton.Text = "Food Bar"
        Me.FoodBarRadioButton.UseVisualStyleBackColor = True
        '
        'HibachiRadioButton
        '
        Me.HibachiRadioButton.AutoSize = True
        Me.HibachiRadioButton.Location = New System.Drawing.Point(21, 72)
        Me.HibachiRadioButton.Name = "HibachiRadioButton"
        Me.HibachiRadioButton.Size = New System.Drawing.Size(66, 19)
        Me.HibachiRadioButton.TabIndex = 18
        Me.HibachiRadioButton.TabStop = True
        Me.HibachiRadioButton.Text = "Hibachi"
        Me.HibachiRadioButton.UseVisualStyleBackColor = True
        '
        'PartyRoomRadioButton
        '
        Me.PartyRoomRadioButton.AutoSize = True
        Me.PartyRoomRadioButton.Location = New System.Drawing.Point(21, 97)
        Me.PartyRoomRadioButton.Name = "PartyRoomRadioButton"
        Me.PartyRoomRadioButton.Size = New System.Drawing.Size(87, 19)
        Me.PartyRoomRadioButton.TabIndex = 17
        Me.PartyRoomRadioButton.TabStop = True
        Me.PartyRoomRadioButton.Text = "Party Room"
        Me.PartyRoomRadioButton.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label6.Location = New System.Drawing.Point(113, 180)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(104, 15)
        Me.Label6.TabIndex = 13
        Me.Label6.Text = "Number Of Adults"
        '
        'NumberOfAdultsNumericUpDown
        '
        Me.NumberOfAdultsNumericUpDown.Location = New System.Drawing.Point(237, 178)
        Me.NumberOfAdultsNumericUpDown.Maximum = New Decimal(New Integer() {40, 0, 0, 0})
        Me.NumberOfAdultsNumericUpDown.Name = "NumberOfAdultsNumericUpDown"
        Me.NumberOfAdultsNumericUpDown.Size = New System.Drawing.Size(140, 23)
        Me.NumberOfAdultsNumericUpDown.TabIndex = 5
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label7.Location = New System.Drawing.Point(102, 209)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(115, 15)
        Me.Label7.TabIndex = 15
        Me.Label7.Text = "Number Of Children"
        '
        'NumberOfChildrenNumericUpDown
        '
        Me.NumberOfChildrenNumericUpDown.Location = New System.Drawing.Point(237, 207)
        Me.NumberOfChildrenNumericUpDown.Maximum = New Decimal(New Integer() {40, 0, 0, 0})
        Me.NumberOfChildrenNumericUpDown.Name = "NumberOfChildrenNumericUpDown"
        Me.NumberOfChildrenNumericUpDown.Size = New System.Drawing.Size(140, 23)
        Me.NumberOfChildrenNumericUpDown.TabIndex = 6
        '
        'IndividualReservationForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LemonChiffon
        Me.ClientSize = New System.Drawing.Size(630, 630)
        Me.Controls.Add(Me.ReservationGroupBox)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "IndividualReservationForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Change a reservation"
        Me.ReservationGroupBox.ResumeLayout(False)
        Me.ReservationGroupBox.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.NumberOfAdultsNumericUpDown, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumberOfChildrenNumericUpDown, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ReservationGroupBox As GroupBox
    Friend WithEvents CancelButton As Button
    Friend WithEvents DiscountTextBox As TextBox
    Friend WithEvents UpdateReservationButton As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents OrderAmountTextBox As TextBox
    Friend WithEvents ToDateTimePicker As DateTimePicker
    Friend WithEvents TotalAmountTextBox As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents DepositAmountTextBox As TextBox
    Friend WithEvents FromTimeDateTimePicker As DateTimePicker
    Friend WithEvents Label10 As Label
    Friend WithEvents ToTimeDateTimePicker As DateTimePicker
    Friend WithEvents Label9 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents FromDateTimePicker As DateTimePicker
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents OrderAdvanceButton As Button
    Friend WithEvents DinningAreaRadioButton As RadioButton
    Friend WithEvents FoodBarRadioButton As RadioButton
    Friend WithEvents HibachiRadioButton As RadioButton
    Friend WithEvents PartyRoomRadioButton As RadioButton
    Friend WithEvents Label6 As Label
    Friend WithEvents NumberOfAdultsNumericUpDown As NumericUpDown
    Friend WithEvents Label7 As Label
    Friend WithEvents NumberOfChildrenNumericUpDown As NumericUpDown
    Friend WithEvents ReservationIDTextBox As TextBox
    Friend WithEvents Label8 As Label
End Class
