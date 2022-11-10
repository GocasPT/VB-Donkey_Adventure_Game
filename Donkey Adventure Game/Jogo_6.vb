Public Class Jogo_6
    Dim nome = Menu_Início.nome
    Dim contador As Integer = 0

    Private Sub Jogo_6_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Icon = My.Resources.Burro_icon
        Label1.Text = nome & " veio-se embora, sem esperar que o biscoito de gengibre ficasse pronto, e voltou para o seu caminho."
    End Sub

    Private Sub OptionButton_Click(sender As Object, e As EventArgs) Handles OptionButton.Click
        Opcoes.Show()
    End Sub

    Private Sub NextButton_Click(sender As Object, e As EventArgs) Handles NextButton.Click
        contador += 1
        Select Case contador
            Case = 1
                Label1.Text = "Finalmente o nosso herói chegou ao reino do seu inimigo que prendia Dragão."
                PictureBox1.Image = My.Resources.Cena5_2
            Case = 2
                Me.Hide()
                Q5.Show()
        End Select
    End Sub
End Class