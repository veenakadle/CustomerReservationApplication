<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ScheduleListForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.ReservationsDataGridView = New System.Windows.Forms.DataGridView()
        Me.BackButton = New System.Windows.Forms.Button()
        Me.ScheduleListLabel = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.FirstNameTextBox = New System.Windows.Forms.TextBox()
        Me.LastNameTextBox = New System.Windows.Forms.TextBox()
        Me.ReservationsDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.DateLabel = New System.Windows.Forms.Label()
        CType(Me.ReservationsDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ReservationsDataGridView
        '
        Me.ReservationsDataGridView.AllowUserToAddRows = False
        Me.ReservationsDataGridView.AllowUserToDeleteRows = False
        Me.ReservationsDataGridView.BackgroundColor = System.Drawing.Color.LemonChiffon
        Me.ReservationsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.ReservationsDataGridView.Location = New System.Drawing.Point(35, 117)
        Me.ReservationsDataGridView.Name = "ReservationsDataGridView"
        Me.ReservationsDataGridView.ReadOnly = True
        Me.ReservationsDataGridView.Size = New System.Drawing.Size(747, 417)
        Me.ReservationsDataGridView.TabIndex = 0
        '
        'BackButton
        '
        Me.BackButton.Location = New System.Drawing.Point(695, 540)
        Me.BackButton.Name = "BackButton"
        Me.BackButton.Size = New System.Drawing.Size(87, 27)
        Me.BackButton.TabIndex = 1
        Me.BackButton.Text = "&Back"
        Me.BackButton.UseVisualStyleBackColor = True
        '
        'ScheduleListLabel
        '
        Me.ScheduleListLabel.AutoSize = True
        Me.ScheduleListLabel.Font = New System.Drawing.Font("Segoe UI Semibold", 15.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ScheduleListLabel.Location = New System.Drawing.Point(41, 46)
        Me.ScheduleListLabel.Name = "ScheduleListLabel"
        Me.ScheduleListLabel.Size = New System.Drawing.Size(213, 30)
        Me.ScheduleListLabel.TabIndex = 2
        Me.ScheduleListLabel.Text = "Today's Reservations"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(365, 62)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(116, 15)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Search by Customer:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(487, 62)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(67, 15)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "First Name:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(488, 91)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(66, 15)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Last Name:"
        '
        'FirstNameTextBox
        '
        Me.FirstNameTextBox.Location = New System.Drawing.Point(560, 59)
        Me.FirstNameTextBox.Name = "FirstNameTextBox"
        Me.FirstNameTextBox.Size = New System.Drawing.Size(222, 23)
        Me.FirstNameTextBox.TabIndex = 6
        '
        'LastNameTextBox
        '
        Me.LastNameTextBox.Location = New System.Drawing.Point(560, 88)
        Me.LastNameTextBox.Name = "LastNameTextBox"
        Me.LastNameTextBox.Size = New System.Drawing.Size(222, 23)
        Me.LastNameTextBox.TabIndex = 7
        '
        'ReservationsDateTimePicker
        '
        Me.ReservationsDateTimePicker.Location = New System.Drawing.Point(560, 21)
        Me.ReservationsDateTimePicker.Name = "ReservationsDateTimePicker"
        Me.ReservationsDateTimePicker.Size = New System.Drawing.Size(222, 23)
        Me.ReservationsDateTimePicker.TabIndex = 9
        '
        'DateLabel
        '
        Me.DateLabel.AutoSize = True
        Me.DateLabel.Location = New System.Drawing.Point(520, 27)
        Me.DateLabel.Name = "DateLabel"
        Me.DateLabel.Size = New System.Drawing.Size(34, 15)
        Me.DateLabel.TabIndex = 8
        Me.DateLabel.Text = "Date:"
        '
        'ScheduleListForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LemonChiffon
        Me.ClientSize = New System.Drawing.Size(812, 580)
        Me.Controls.Add(Me.ReservationsDateTimePicker)
        Me.Controls.Add(Me.DateLabel)
        Me.Controls.Add(Me.LastNameTextBox)
        Me.Controls.Add(Me.FirstNameTextBox)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ScheduleListLabel)
        Me.Controls.Add(Me.BackButton)
        Me.Controls.Add(Me.ReservationsDataGridView)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "ScheduleListForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Sakura Japanese Sushi & Hibachi - Schedule List"
        CType(Me.ReservationsDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ReservationsDataGridView As DataGridView
    Friend WithEvents BackButton As Button
    Friend WithEvents ScheduleListLabel As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents FirstNameTextBox As TextBox
    Friend WithEvents LastNameTextBox As TextBox
    Friend WithEvents ReservationsDateTimePicker As DateTimePicker
    Friend WithEvents DateLabel As Label
End Class
