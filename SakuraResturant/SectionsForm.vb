Public Class SectionsForm
    Private Sub HomeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles HomeToolStripMenuItem.Click
        CustomerLogin.Show()
        Me.Close()
    End Sub

    Private Sub LOGOUTToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LOGOUTToolStripMenuItem.Click
        Login.Show()
        Me.Close()
    End Sub

    Private Sub DineInRadioButton_CheckedChanged(sender As Object, e As EventArgs) Handles DineInRadioButton.CheckedChanged
        ImagesPictureBox.Image = My.Resources.common_dinning_area
    End Sub

    Private Sub HibachiRadioButton_CheckedChanged(sender As Object, e As EventArgs) Handles HibachiRadioButton.CheckedChanged
        ImagesPictureBox.Image = My.Resources.Hibachi_area
    End Sub

    Private Sub GrillRadioButton_CheckedChanged(sender As Object, e As EventArgs) Handles GrillRadioButton.CheckedChanged
        ImagesPictureBox.Image = My.Resources.Hibachi_area_2
    End Sub

    Private Sub PartyRadioButton_CheckedChanged(sender As Object, e As EventArgs) Handles PartyRadioButton.CheckedChanged
        ImagesPictureBox.Image = My.Resources.sushi_area
    End Sub

    Private Sub SectionsForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If Login.DB.CallingFormString = "CustomerLogin" Then
            LOGOUTToolStripMenuItem.Visible = True
        ElseIf Login.db.CallingFormString = "Login" Then
            LOGOUTToolStripMenuItem.Visible = False
        End If
    End Sub
End Class