Public Class Jogo_7
    Dim nome = Menu_Início.nome
    Dim contador As Integer = 0

    Private Sub Jogo_7_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Icon = My.Resources.Burro_icon

        Label1.Text = """" & nome & " ,¿recuerdas cómo solíamos cantar?"
    End Sub

    Private Sub OptionButton_Click(sender As Object, e As EventArgs) Handles OptionButton.Click
        Opcoes.Show()
    End Sub

    Private Sub NextButton_Click(sender As Object, e As EventArgs) Handles NextButton.Click
        contador += 1
        Select Case contador
            Case = 1
                Label1.Text = """Sim, nós cantamos bem, Gato..."""
                PictureBox1.Image = My.Resources.Cena6_2
            Case = 2
                Label1.Text = ""
                PictureBox1.Image = My.Resources.Cena6_3
            Case = 3
                Me.Hide()
                Q6.Show()
        End Select
    End Sub
End Class