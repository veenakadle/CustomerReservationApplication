﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EmployeeMainForm
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
        Me.EmployeeNameLabel = New System.Windows.Forms.Label()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.ReservationsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CustomerToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EmployeeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MaintenanceToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SectionToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DiscountsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ScheduleToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ViewPastReservationsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ViewTodaysReservationsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ViewFutureReservationsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReportsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ViewReservationToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ViewStaffReportToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ViewCustomerReportToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ViewSectionReportToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.LogoutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'EmployeeNameLabel
        '
        Me.EmployeeNameLabel.AutoSize = True
        Me.EmployeeNameLabel.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EmployeeNameLabel.Location = New System.Drawing.Point(28, 44)
        Me.EmployeeNameLabel.Name = "EmployeeNameLabel"
        Me.EmployeeNameLabel.Size = New System.Drawing.Size(0, 21)
        Me.EmployeeNameLabel.TabIndex = 0
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ReservationsToolStripMenuItem, Me.CustomerToolStripMenuItem, Me.EmployeeToolStripMenuItem, Me.MaintenanceToolStripMenuItem, Me.ScheduleToolStripMenuItem, Me.ReportsToolStripMenuItem, Me.LogoutToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1008, 24)
        Me.MenuStrip1.TabIndex = 2
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ReservationsToolStripMenuItem
        '
        Me.ReservationsToolStripMenuItem.Name = "ReservationsToolStripMenuItem"
        Me.ReservationsToolStripMenuItem.Size = New System.Drawing.Size(85, 20)
        Me.ReservationsToolStripMenuItem.Text = "&Reservations"
        '
        'CustomerToolStripMenuItem
        '
        Me.CustomerToolStripMenuItem.Name = "CustomerToolStripMenuItem"
        Me.CustomerToolStripMenuItem.Size = New System.Drawing.Size(71, 20)
        Me.CustomerToolStripMenuItem.Text = "&Customer"
        '
        'EmployeeToolStripMenuItem
        '
        Me.EmployeeToolStripMenuItem.Name = "EmployeeToolStripMenuItem"
        Me.EmployeeToolStripMenuItem.Size = New System.Drawing.Size(71, 20)
        Me.EmployeeToolStripMenuItem.Text = "&Employee"
        '
        'MaintenanceToolStripMenuItem
        '
        Me.MaintenanceToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MenuToolStripMenuItem, Me.SectionToolStripMenuItem, Me.DiscountsToolStripMenuItem})
        Me.MaintenanceToolStripMenuItem.Name = "MaintenanceToolStripMenuItem"
        Me.MaintenanceToolStripMenuItem.Size = New System.Drawing.Size(88, 20)
        Me.MaintenanceToolStripMenuItem.Text = "&Maintenance"
        '
        'MenuToolStripMenuItem
        '
        Me.MenuToolStripMenuItem.Name = "MenuToolStripMenuItem"
        Me.MenuToolStripMenuItem.Size = New System.Drawing.Size(126, 22)
        Me.MenuToolStripMenuItem.Text = "Menu"
        '
        'SectionToolStripMenuItem
        '
        Me.SectionToolStripMenuItem.Name = "SectionToolStripMenuItem"
        Me.SectionToolStripMenuItem.Size = New System.Drawing.Size(126, 22)
        Me.SectionToolStripMenuItem.Text = "Section"
        '
        'DiscountsToolStripMenuItem
        '
        Me.DiscountsToolStripMenuItem.Name = "DiscountsToolStripMenuItem"
        Me.DiscountsToolStripMenuItem.Size = New System.Drawing.Size(126, 22)
        Me.DiscountsToolStripMenuItem.Text = "Discounts"
        '
        'ScheduleToolStripMenuItem
        '
        Me.ScheduleToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ViewPastReservationsToolStripMenuItem, Me.ViewTodaysReservationsToolStripMenuItem, Me.ViewFutureReservationsToolStripMenuItem})
        Me.ScheduleToolStripMenuItem.Name = "ScheduleToolStripMenuItem"
        Me.ScheduleToolStripMenuItem.Size = New System.Drawing.Size(67, 20)
        Me.ScheduleToolStripMenuItem.Text = "&Schedule"
        '
        'ViewPastReservationsToolStripMenuItem
        '
        Me.ViewPastReservationsToolStripMenuItem.Name = "ViewPastReservationsToolStripMenuItem"
        Me.ViewPastReservationsToolStripMenuItem.Size = New System.Drawing.Size(211, 22)
        Me.ViewPastReservationsToolStripMenuItem.Text = "View Past Reservations"
        '
        'ViewTodaysReservationsToolStripMenuItem
        '
        Me.ViewTodaysReservationsToolStripMenuItem.Name = "ViewTodaysReservationsToolStripMenuItem"
        Me.ViewTodaysReservationsToolStripMenuItem.Size = New System.Drawing.Size(211, 22)
        Me.ViewTodaysReservationsToolStripMenuItem.Text = "View Today's Reservations"
        '
        'ViewFutureReservationsToolStripMenuItem
        '
        Me.ViewFutureReservationsToolStripMenuItem.Name = "ViewFutureReservationsToolStripMenuItem"
        Me.ViewFutureReservationsToolStripMenuItem.Size = New System.Drawing.Size(211, 22)
        Me.ViewFutureReservationsToolStripMenuItem.Text = "View Future Reservations"
        '
        'ReportsToolStripMenuItem
        '
        Me.ReportsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ViewReservationToolStripMenuItem, Me.ViewStaffReportToolStripMenuItem1, Me.ViewCustomerReportToolStripMenuItem1, Me.ViewSectionReportToolStripMenuItem1})
        Me.ReportsToolStripMenuItem.Name = "ReportsToolStripMenuItem"
        Me.ReportsToolStripMenuItem.Size = New System.Drawing.Size(59, 20)
        Me.ReportsToolStripMenuItem.Text = "Re&ports"
        '
        'ViewReservationToolStripMenuItem
        '
        Me.ViewReservationToolStripMenuItem.Name = "ViewReservationToolStripMenuItem"
        Me.ViewReservationToolStripMenuItem.Size = New System.Drawing.Size(204, 22)
        Me.ViewReservationToolStripMenuItem.Text = "View Reservation Report "
        '
        'ViewStaffReportToolStripMenuItem1
        '
        Me.ViewStaffReportToolStripMenuItem1.Name = "ViewStaffReportToolStripMenuItem1"
        Me.ViewStaffReportToolStripMenuItem1.Size = New System.Drawing.Size(204, 22)
        Me.ViewStaffReportToolStripMenuItem1.Text = "View Staff Report"
        '
        'ViewCustomerReportToolStripMenuItem1
        '
        Me.ViewCustomerReportToolStripMenuItem1.Name = "ViewCustomerReportToolStripMenuItem1"
        Me.ViewCustomerReportToolStripMenuItem1.Size = New System.Drawing.Size(204, 22)
        Me.ViewCustomerReportToolStripMenuItem1.Text = "View Customer Report"
        '
        'ViewSectionReportToolStripMenuItem1
        '
        Me.ViewSectionReportToolStripMenuItem1.Name = "ViewSectionReportToolStripMenuItem1"
        Me.ViewSectionReportToolStripMenuItem1.Size = New System.Drawing.Size(204, 22)
        Me.ViewSectionReportToolStripMenuItem1.Text = "View Section Report"
        '
        'LogoutToolStripMenuItem
        '
        Me.LogoutToolStripMenuItem.Name = "LogoutToolStripMenuItem"
        Me.LogoutToolStripMenuItem.Size = New System.Drawing.Size(57, 20)
        Me.LogoutToolStripMenuItem.Text = "&Logout"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.SakuraResturant.My.Resources.Resources.Sakura_Image
        Me.PictureBox1.Location = New System.Drawing.Point(61, 124)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(854, 491)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 1
        Me.PictureBox1.TabStop = False
        '
        'EmployeeMainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Linen
        Me.ClientSize = New System.Drawing.Size(1008, 711)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.EmployeeNameLabel)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "EmployeeMainForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Sakura Japanese Sushi & Hibachi - Employee Login"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents EmployeeNameLabel As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents ReservationsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CustomerToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ReportsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ViewReservationToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LogoutToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ViewStaffReportToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents ViewCustomerReportToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents ViewSectionReportToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents MaintenanceToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MenuToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SectionToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DiscountsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ScheduleToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ViewTodaysReservationsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ViewFutureReservationsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ViewPastReservationsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EmployeeToolStripMenuItem As ToolStripMenuItem
End Class
