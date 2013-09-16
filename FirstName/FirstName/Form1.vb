Option Strict On

Public Class Form1

    Private Sub btnFirstName_Click(sender As System.Object, e As System.EventArgs) Handles btnFirstName.Click

        Dim fullname As String
        ' read the input from the user
        fullname = txtBox1.Text

        'Trim the input so as to remove leading spaces
        Dim fullnameTrimmed As String
        fullnameTrimmed = fullname.Trim()

        ' find the index of the first space
        Dim idxSpace As Integer
        idxSpace = fullnameTrimmed.IndexOf(" ")

        'extract the first name
        Dim firstName As String
        firstName = fullnameTrimmed.Substring(0, idxSpace)

        ' diplay result to user
        txtFirstName.Text = fullname





    End Sub
End Class
