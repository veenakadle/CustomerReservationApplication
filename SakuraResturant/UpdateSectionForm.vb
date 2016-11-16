﻿Public Class UpdateSectionForm

    Private UpdateAccess As New SakuraClass

    Private Sub UpdateSectionForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        UpdateAccess.AddParam("@sectionID", AddUpdateSectionForm.SectionIDInteger)
        UpdateAccess.ExecuteQuery("SELECT * FROM section WHERE sectionID =?")
        If UpdateAccess.ExceptionString <> String.Empty Then
            MessageBox.Show(UpdateAccess.ExceptionString)
            Exit Sub
        End If

        'Display the details
        SectionNameTextBox.Text = UpdateAccess.DBDataTable(0)!sectionName
        CapacityTextBox.Text = UpdateAccess.DBDataTable(0)!capacity
    End Sub

    Private Sub UpdateButton_Click(sender As Object, e As EventArgs) Handles UpdateButton.Click
        If SectionNameTextBox.Text = String.Empty Then
            MessageBox.Show("Section Name cannot be blank.")
            Exit Sub
        ElseIf CapacityTextBox.Text = String.Empty Or CapacityTextBox.Text = 0 Then
            MessageBox.Show("Capacity cannot be blank or 0")
            Exit Sub
        End If

        UpdateAccess.AddParam("@sectionName", SectionNameTextBox.Text)
        UpdateAccess.AddParam("@capacity", CapacityTextBox.Text)
        UpdateAccess.AddParam("@sectionID", AddUpdateSectionForm.SectionIDInteger)

        UpdateAccess.ExecuteQuery("UPDATE section SET sectionName = ?, capacity =? 
                                   WHERE sectionID =?")
        If UpdateAccess.ExceptionString <> String.Empty Then
            MessageBox.Show(UpdateAccess.ExceptionString)
            Exit Sub
        End If

        MessageBox.Show("Section updated successfully.")
        AddUpdateSectionForm.Show()
        Me.Close()
    End Sub

    Private Sub CancelButton_Click(sender As Object, e As EventArgs) Handles CancelButton.Click
        AddUpdateSectionForm.Show()
        Me.Close()
    End Sub
End Class