Public Class Form2

    Private Sub DetermineButton_Click(ByVal sender As Object, ByVale As EventArgs)
        Dim name As String
        name = FullNameTextBox.Text
        Call FirstName(name)
    End Sub
    Private Sub FirstName(ByVal name As String)
        Dim firstSpace As Integer
        firstSpace = name.IndexOf(" ")
        FirstNameTextBox.Text = name.Substring(0, firstSpace)
    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class