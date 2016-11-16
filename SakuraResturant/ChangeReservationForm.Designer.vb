<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ChangeReservationForm
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
        Me.HomeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LOGOUTToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.CustomerNameTextBox = New System.Windows.Forms.TextBox()
        Me.ReservationsDataGridView = New System.Windows.Forms.DataGridView()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.ReservationsDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.HomeToolStripMenuItem, Me.LOGOUTToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1008, 24)
        Me.MenuStrip1.TabIndex = 36
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'HomeToolStripMenuItem
        '
        Me.HomeToolStripMenuItem.Name = "HomeToolStripMenuItem"
        Me.HomeToolStripMenuItem.Size = New System.Drawing.Size(52, 20)
        Me.HomeToolStripMenuItem.Text = "&Home"
        '
        'LOGOUTToolStripMenuItem
        '
        Me.LOGOUTToolStripMenuItem.Name = "LOGOUTToolStripMenuItem"
        Me.LOGOUTToolStripMenuItem.Size = New System.Drawing.Size(66, 20)
        Me.LOGOUTToolStripMenuItem.Text = "&LOGOUT"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label8.Location = New System.Drawing.Point(30, 54)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(94, 15)
        Me.Label8.TabIndex = 38
        Me.Label8.Text = "Customer Name"
        '
        'CustomerNameTextBox
        '
        Me.CustomerNameTextBox.Location = New System.Drawing.Point(140, 51)
        Me.CustomerNameTextBox.MaxLength = 100
        Me.CustomerNameTextBox.Name = "CustomerNameTextBox"
        Me.CustomerNameTextBox.ReadOnly = True
        Me.CustomerNameTextBox.Size = New System.Drawing.Size(292, 23)
        Me.CustomerNameTextBox.TabIndex = 37
        '
        'ReservationsDataGridView
        '
        Me.ReservationsDataGridView.BackgroundColor = System.Drawing.Color.LemonChiffon
        Me.ReservationsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.ReservationsDataGridView.Location = New System.Drawing.Point(12, 96)
        Me.ReservationsDataGridView.Name = "ReservationsDataGridView"
        Me.ReservationsDataGridView.Size = New System.Drawing.Size(972, 439)
        Me.ReservationsDataGridView.TabIndex = 39
        '
        'ChangeReservationForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LemonChiffon
        Me.ClientSize = New System.Drawing.Size(1008, 547)
        Me.Controls.Add(Me.ReservationsDataGridView)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.CustomerNameTextBox)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "ChangeReservationForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Sakura Restaurant - Change Reservation"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.ReservationsDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents LOGOUTToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Label8 As Label
    Friend WithEvents CustomerNameTextBox As TextBox
    Friend WithEvents ReservationsDataGridView As DataGridView
    Friend WithEvents HomeToolStripMenuItem As ToolStripMenuItem
End Class
