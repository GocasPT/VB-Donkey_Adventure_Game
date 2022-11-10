Public Class NeutralEnding
    Dim nome = Menu_Início.nome

    Private Sub NeutralEnding_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Icon = My.Resources.Burro_icon
        Label1.Text = nome & "perdeu a batalha contra o Lorde Farquaad. Agora, em conjunto com a Dragão, vão passar o resto das suas vidas presos na torre do castelo, juntos, e com os seus filhos….. FIM"
    End Sub

    Private Sub OptionButton_Click(sender As Object, e As EventArgs) Handles OptionButton.Click
        Opcoes.Show()
    End Sub

    Private Sub NextButton_Click(sender As Object, e As EventArgs) Handles NextButton.Click
        Me.Hide()
        Final.Show()
    End Sub
End Class