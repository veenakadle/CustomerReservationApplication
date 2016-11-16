Public Class ResetPasswordForm
    Private Sub CancelButton_Click(sender As Object, e As EventArgs) Handles CancelButton.Click
        Login.Show()
        Me.Close()
    End Sub
    Private Sub ResetPasswordButton_Click(sender As Object, e As EventArgs) Handles ResetPasswordButton.Click
        If TempPasswordTextBox.Text <> ForgotPasswordform.TempPasswordString Then
            MessageBox.Show("Incorrect Temporary Password")
        Else
            ResetPasswordGroupBox.Visible = True
        End If
    End Sub

    Private Sub ConfirmPasswordTextBox_TextChanged(sender As Object, e As EventArgs) Handles ConfirmPasswordTextBox.TextChanged
        'Compare first and second Passwords
        If ResetPasswordTextBox.Text <> ConfirmPasswordTextBox.Text Then
            PasswordMatchLabel.Text = "Passwords do not match"
        Else
            PasswordMatchLabel.Text = "Passwords match"
        End If
    End Sub

    Private Sub ConfirmButton_Click(sender As Object, e As EventArgs) Handles ConfirmButton.Click
        If PasswordMatchLabel.Text = "Passwords do not match" Then
            Exit Sub
        Else
            Dim PasswordString As String = Login.EncryptData(ResetPasswordTextBox.Text)

            If Login.CustomerIDInteger > 0 Then
                Login.DB.AddParam("@password", PasswordString)
                Login.DB.AddParam("@customerID", ForgotPasswordform.CustomerIDInteger)

                Login.DB.ExecuteQuery("UPDATE customer SET custPassword = ? WHERE customerID=?")
                If Login.DB.ExceptionString <> String.Empty Then
                    MessageBox.Show(Login.DB.ExceptionString)
                    Exit Sub
                End If
            End If

            If Login.EmployeeIDInteger > 0 Then
                Login.DB.AddParam("@password", PasswordString)
                Login.DB.AddParam("@employeeID", Login.EmployeeIDInteger)

                Login.DB.ExecuteQuery("UPDATE employee SET empPassword = ? WHERE employeeID = ?")

                If Login.DB.ExceptionString <> String.Empty Then
                    MessageBox.Show(Login.DB.ExceptionString)
                    Exit Sub
                End If
            End If

            MessageBox.Show("Your password has been reset successfully. Please login again")
            ForgotPasswordform.TempPasswordString = String.Empty
            Login.Show()
            Me.Close()
        End If
    End Sub
End Class