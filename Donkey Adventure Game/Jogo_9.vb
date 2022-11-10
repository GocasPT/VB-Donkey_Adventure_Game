Public Class Jogo_9
    Dim nome = Menu_Início.nome
    Dim contador As Integer = 0

    Private Sub Jogo_9_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Icon = My.Resources.Burro_icon
        Label1.Text = "Depois de um breve momento a observar o seu reflexo, " & nome & " ouve uma voz vinda do espelho que lhe diz:"
    End Sub

    Private Sub OptionButton_Click(sender As Object, e As EventArgs) Handles OptionButton.Click
        Opcoes.Show()
    End Sub

    Private Sub NextButton_Click(sender As Object, e As EventArgs) Handles NextButton.Click
        contador += 1
        Select Case contador
            Case = 1
                Label1.Text = """O que é que estás a fazer?"""
            Case = 2
                Label1.Text = """Ah! Tu estás vivo!"""
            Case = 3
                Label1.Text = """Sim, eu sou um Espelho Mágico. Agora o que é que queres?"""
            Case = 4
                Label1.Text = """Espelho meu, espelho meu. Como é que eu tiro a Dragão daqui?"""
            Case = 5
                Label1.Text = """Se passares por aquela porta vais encontrar o que estás à procura. Mas cuidado, vais ter de travar uma batalha antes de conseguirem fugir."""
            Case = 6
                Label1.Text = """Obrigado pela tua ajuda, Espelho Mágico."""
            Case = 7
                Label1.Text = """Boa sorte, " & nome & "."
            Case = 8
                Label1.Text = "Quando passa pela porta, " & nome & " está finalmente de frente ao seu inimigo, Farquaad. Agora tudo o que resta é derrotá-lo e finalmente poderá salvar a Dragão"
            Case = 9
                Me.Hide()
                Jogo_10.Show()
        End Select
    End Sub
End Class