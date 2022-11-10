Public Class GoodEnding
    Dim nome = Menu_Início.nome

    Private Sub GoodEnding_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Icon = My.Resources.Burro_icon
        Label1.Text = "Após ganhar a batalha contra o Lorde Farquaad, " & nome & " salvou a Dragão e os dois foram ao encontro dos seus filhos. E viveram felizes para sempre….. FIM"
    End Sub

    Private Sub OptionButton_Click(sender As Object, e As EventArgs) Handles OptionButton.Click
        Opcoes.Show()
    End Sub

    Private Sub NextButton_Click(sender As Object, e As EventArgs) Handles NextButton.Click
        Me.Hide()
        Final.Show()
    End Sub
End Class