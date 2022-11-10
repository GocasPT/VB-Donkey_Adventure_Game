Public Class BadEnding
    Dim nome = Menu_Início.nome

    Private Sub BadEnding_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Icon = My.Resources.Burro_icon
        Label1.Text = nome & " perdeu a batalha contra o Lorde Farquaad. Como consequência, a Dragão morre e o castigo do nosso herói será guardar a torre para o resto dos tempos….FIM."
    End Sub

    Private Sub OptionButton_Click(sender As Object, e As EventArgs) Handles OptionButton.Click
        Opcoes.Show()
    End Sub

    Private Sub NextButton_Click(sender As Object, e As EventArgs) Handles NextButton.Click
        Me.Hide()
        Final.Show()
    End Sub
End Class