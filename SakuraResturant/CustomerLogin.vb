Imports System.Security.Cryptography
Imports System.Text
Imports System.IO
Imports System.Data
Imports System.Configuration
Imports System.Data.SqlClient

Public Class CustomerLogin
    Private AddressIDInteger As Integer
    Public CustomerIDInteger As Integer
    Public CustomerFirstNameString, CustomerLastNameString As String

    Public Function EncryptData(ByVal PlainTextString As String) As String

        Dim PasswordString As String = PlainTextString 'The password to be encrypted
        Dim HashedDataByte As Byte() 'Byte array containing the encrypted string
        Dim Encoder As New UTF8Encoding() 'Used to convert the string into byte format
        Dim Md5Hasher As New MD5CryptoServiceProvider 'MD5 is an encryption method

        HashedDataByte = Md5Hasher.ComputeHash(Encoder.GetBytes(PlainTextString))

        'Convert the byte array into a string
        Return Convert.ToBase64String(HashedDataByte)

    End Function

    Private Sub LogOutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LogOutToolStripMenuItem.Click
        Login.Show()
        Me.Close()
    End Sub

    Private Sub ViewSectionsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ViewSectionsToolStripMenuItem.Click
        SectionsForm.Show()
        Me.Hide()
    End Sub

    Private Sub ViewMenuToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ViewMenuToolStripMenuItem.Click
        MenuForm.Show()
        Me.Hide()
    End Sub

    Private Sub CustomerLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Set the Calling Form String
        Login.DB.CallingFormString = Me.Name
    End Sub

    Private Sub ChangeReservationToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ChangeReservationToolStripMenuItem.Click
        ChangeReservationForm.Show()
    End Sub

    Private Sub MakeReservationToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MakeReservationToolStripMenuItem.Click
        NewReservation.Show()
    End Sub
End Class