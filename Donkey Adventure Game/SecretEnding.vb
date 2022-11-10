Public Class SecretEnding
    Dim nome = Menu_Início.nome

    Private Sub SecretEnding_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Icon = My.Resources.Burro_icon
        Label1.Text = "Parabéns, tiveste uma jornada única!! Este é o teu prémio, " & nome & ".....FIM"
    End Sub

    Private Sub OptionButton_Click(sender As Object, e As EventArgs) Handles OptionButton.Click
        Opcoes.Show()
    End Sub

    Private Sub NextButton_Click(sender As Object, e As EventArgs) Handles NextButton.Click
        Me.Hide()
        Final.Show()
    End Sub
End Class