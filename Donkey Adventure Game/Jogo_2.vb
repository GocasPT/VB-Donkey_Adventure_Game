Public Class Jogo_2
    Dim nome = Menu_Início.nome
    Dim arma = Jogo_1.arma
    Dim contador As Integer = 0

    Private Sub Jogo_2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Icon = My.Resources.Burro_icon

        Label1.Text = "Há bué bué tempo… havia um burro com o nome de " & nome & ". "

    End Sub

    Private Sub NextButton_Click(sender As Object, e As EventArgs) Handles NextButton.Click
        contador += 1
        Select Case contador
            Case = 1
                Label1.Text = nome & " foi separado da sua amada, a Dragão."
                PictureBox1.Image = My.Resources.Cena1_2
            Case = 2
                Label1.Text = "Agora, para poder voltar para a sua amada e libertá-la do castelo em que se encontra aprisionada, " & nome &
                    " e o seu companheiro de confiança, " & arma &
                    ", vão ter de derrotar o vilão."
                Select Case arma
                    Case = "Arco"
                        PictureBox1.Image = My.Resources.Cena1_3_Arco
                    Case = "Desert Eagle"
                        PictureBox1.Image = My.Resources.Cena1_3_Desert_Eagle
                    Case = "Escudo"
                        PictureBox1.Image = My.Resources.Cena1_3_Escudo
                    Case = "Espada"
                        PictureBox1.Image = My.Resources.Cena1_3_Espada
                    Case = "Juan"
                        PictureBox1.Image = My.Resources.Cena1_3_Juan
                    Case = "PL-01"
                        PictureBox1.Image = My.Resources.Cena1_3_PL_01
                    Case = "Punhos"
                        PictureBox1.Image = My.Resources.Cena1_3_Punhos
                    Case = "Shrek"
                        PictureBox1.Image = My.Resources.Cena1_3_Shrek
                End Select
            Case = 3
                Me.Hide()
                Q1.Show()
        End Select
    End Sub

    Private Sub OptionButton_Click(sender As Object, e As EventArgs) Handles OptionButton.Click
        Opcoes.Show()
    End Sub
End Class