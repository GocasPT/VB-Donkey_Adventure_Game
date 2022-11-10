Public Class Rules
    Private Sub BackButton_Click(sender As Object, e As EventArgs) Handles BackButton.Click
        Me.Close()
    End Sub

    Private Sub Rules_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Icon = My.Resources.Engrenagem_Icon
    End Sub
End Class