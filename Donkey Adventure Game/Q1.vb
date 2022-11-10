Public Class Q1
    Public p1 As Integer
    Dim pontuacao As Integer = 11
    Public ea1 As Integer = 0

    Private Sub Q1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Icon = My.Resources.Burro_icon
    End Sub

    Private Sub OptionButton_Click(sender As Object, e As EventArgs) Handles OptionButton.Click
        Opcoes.Show()
    End Sub

    Private Sub Errado_1_CheckedChanged(sender As Object, e As EventArgs) Handles Errado_1.CheckedChanged
        NextButton.Enabled = True
    End Sub

    Private Sub Errado_Mark_CheckedChanged(sender As Object, e As EventArgs) Handles Errado_Mark.CheckedChanged
        NextButton.Enabled = True
    End Sub

    Private Sub Errado_2_CheckedChanged(sender As Object, e As EventArgs) Handles Errado_2.CheckedChanged
        NextButton.Enabled = True
    End Sub

    Private Sub Certo_CheckedChanged(sender As Object, e As EventArgs) Handles Certo.CheckedChanged
        NextButton.Enabled = True
    End Sub

    Private Sub NextButton_Click(sender As Object, e As EventArgs) Handles NextButton.Click
        p1 = 0

        If Certo.Checked = True Then
            p1 = pontuacao
        Else
            p1 = 0
        End If

        If Errado_Mark.Checked = True Then
            ea1 = 1
            MsgBox("Larga os memes, pá", 0, Title:="Easter Egg")
        End If

        Me.Hide()
        Jogo_3.Show()
    End Sub
End Class