<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ReservationMaintenanceForm
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
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.MakeReservationToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AsEmployeeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AsCustomerToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ChangeReservationToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CancelReservationToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SendReminderToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MakeReservationToolStripMenuItem, Me.ChangeReservationToolStripMenuItem, Me.CancelReservationToolStripMenuItem, Me.SendReminderToolStripMenuItem, Me.ExitToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(721, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'MakeReservationToolStripMenuItem
        '
        Me.MakeReservationToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AsEmployeeToolStripMenuItem, Me.AsCustomerToolStripMenuItem})
        Me.MakeReservationToolStripMenuItem.Name = "MakeReservationToolStripMenuItem"
        Me.MakeReservationToolStripMenuItem.Size = New System.Drawing.Size(112, 20)
        Me.MakeReservationToolStripMenuItem.Text = "&Make Reservation"
        '
        'AsEmployeeToolStripMenuItem
        '
        Me.AsEmployeeToolStripMenuItem.Name = "AsEmployeeToolStripMenuItem"
        Me.AsEmployeeToolStripMenuItem.Size = New System.Drawing.Size(142, 22)
        Me.AsEmployeeToolStripMenuItem.Text = "As &Employee"
        '
        'AsCustomerToolStripMenuItem
        '
        Me.AsCustomerToolStripMenuItem.Name = "AsCustomerToolStripMenuItem"
        Me.AsCustomerToolStripMenuItem.Size = New System.Drawing.Size(142, 22)
        Me.AsCustomerToolStripMenuItem.Text = "As &Customer"
        '
        'ChangeReservationToolStripMenuItem
        '
        Me.ChangeReservationToolStripMenuItem.Name = "ChangeReservationToolStripMenuItem"
        Me.ChangeReservationToolStripMenuItem.Size = New System.Drawing.Size(124, 20)
        Me.ChangeReservationToolStripMenuItem.Text = "&Change Reservation"
        '
        'CancelReservationToolStripMenuItem
        '
        Me.CancelReservationToolStripMenuItem.Name = "CancelReservationToolStripMenuItem"
        Me.CancelReservationToolStripMenuItem.Size = New System.Drawing.Size(119, 20)
        Me.CancelReservationToolStripMenuItem.Text = "Cancel &Reservation"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.ExitToolStripMenuItem.Text = "E&xit"
        '
        'SendReminderToolStripMenuItem
        '
        Me.SendReminderToolStripMenuItem.Name = "SendReminderToolStripMenuItem"
        Me.SendReminderToolStripMenuItem.Size = New System.Drawing.Size(99, 20)
        Me.SendReminderToolStripMenuItem.Text = "&Send Reminder"
        '
        'ReservationMaintenanceForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LemonChiffon
        Me.ClientSize = New System.Drawing.Size(721, 537)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "ReservationMaintenanceForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Sakura Japanese Sushi & Hibachi - Reservation Options"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents MakeReservationToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ChangeReservationToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CancelReservationToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AsEmployeeToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AsCustomerToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SendReminderToolStripMenuItem As ToolStripMenuItem
End Class
