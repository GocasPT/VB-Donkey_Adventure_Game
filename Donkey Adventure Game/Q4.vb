Public Class Q4
    Dim nome = Menu_Início.nome
    Public p4 As Integer
    Dim pontuacao As Integer = 3
    Dim retirar As Integer = 3
    Public ea5 As Integer = 0

    Private Sub Q4_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Icon = My.Resources.Burro_icon
        Label1.Text = "Muito bem, " & nome & ". O Homem-Biscoito tem a receita dele e ele vai precisar de uns ingredientes. Podes ir buscá-los à dispensa?"
    End Sub

    Private Sub OptionButton_Click(sender As Object, e As EventArgs) Handles OptionButton.Click
        Opcoes.Show()
    End Sub

    Private Sub Certo_4_CheckedChanged(sender As Object, e As EventArgs) Handles Certo_4.CheckedChanged
        NextButton.Enabled = True
    End Sub

    Private Sub Errado_2_CheckedChanged(sender As Object, e As EventArgs) Handles Errado_2.CheckedChanged
        NextButton.Enabled = True
    End Sub

    Private Sub Errado_Lama_CheckedChanged(sender As Object, e As EventArgs) Handles Errado_Lama.CheckedChanged
        NextButton.Enabled = True
    End Sub

    Private Sub Errado_1_CheckedChanged(sender As Object, e As EventArgs) Handles Errado_1.CheckedChanged
        NextButton.Enabled = True
    End Sub

    Private Sub Certo_5_CheckedChanged(sender As Object, e As EventArgs) Handles Certo_5.CheckedChanged
        NextButton.Enabled = True
    End Sub

    Private Sub Certo_6_CheckedChanged(sender As Object, e As EventArgs) Handles Certo_6.CheckedChanged
        NextButton.Enabled = True
    End Sub

    Private Sub Certo_1_CheckedChanged(sender As Object, e As EventArgs) Handles Certo_1.CheckedChanged
        NextButton.Enabled = True
    End Sub

    Private Sub Certo_2_CheckedChanged(sender As Object, e As EventArgs) Handles Certo_2.CheckedChanged
        NextButton.Enabled = True
    End Sub

    Private Sub Errado_Cebola_CheckedChanged(sender As Object, e As EventArgs) Handles Errado_Cebola.CheckedChanged
        NextButton.Enabled = True
    End Sub

    Private Sub Certo_3_CheckedChanged(sender As Object, e As EventArgs) Handles Certo_3.CheckedChanged
        NextButton.Enabled = True
    End Sub

    Private Sub Errado_Sapo_CheckedChanged(sender As Object, e As EventArgs) Handles Errado_Sapo.CheckedChanged
        NextButton.Enabled = True
    End Sub

    Private Sub Errado_Rato_CheckedChanged(sender As Object, e As EventArgs) Handles Errado_Rato.CheckedChanged
        NextButton.Enabled = True
    End Sub

    Private Sub NextButton_Click(sender As Object, e As EventArgs) Handles NextButton.Click
        p4 = 0
        If Certo_1.Checked = True Then
            p4 += pontuacao
        End If
        If Certo_2.Checked = True Then
            p4 += pontuacao
        End If
        If Certo_3.Checked = True Then
            p4 += pontuacao
        End If
        If Certo_4.Checked = True Then
            p4 += pontuacao
        End If
        If Certo_5.Checked = True Then
            p4 += pontuacao
        End If
        If Certo_6.Checked = True Then
            p4 += pontuacao
        End If

        If Errado_1.Checked = True Then
            p4 -= retirar
        End If
        If Errado_2.Checked = True Then
            p4 -= retirar
        End If
        If Errado_Cebola.Checked = True Then
            p4 -= retirar
        End If
        If Errado_Sapo.Checked = True Then
            p4 -= retirar
        End If
        If Errado_Rato.Checked = True Then
            p4 -= retirar
        End If
        If Errado_Lama.Checked = True Then
            p4 -= retirar
        End If

        If Errado_Cebola.Checked = True Then
            If Errado_Lama.Checked = True Then
                If Errado_Sapo.Checked = True Then
                    If Errado_Rato.Checked = True Then
                        ea5 = 1
                        MsgBox("Shrek favorite food", 0, Title:="Easter Egg")
                    End If
                End If
            End If
        End If

        If p4 < 0 Then
            p4 = 0
        End If

        Me.Hide()
        Jogo_6.show()
    End Sub
End Class