Public Class Q6
    Public p6 As Integer
    Dim pontuacao As Integer = 3
    Public ea7 As Integer = 0

    Private Sub Q6_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Icon = My.Resources.Burro_icon
    End Sub

    Private Sub OptionButton_Click(sender As Object, e As EventArgs) Handles OptionButton.Click
        Opcoes.Show()
    End Sub

    Private Sub NextButton_Click(sender As Object, e As EventArgs) Handles NextButton.Click
        If I1.Checked = True Then
            p6 += pontuacao
        End If
        If All2.Checked = True Then
            p6 += pontuacao
        End If
        If Now3.Checked = True Then
            p6 += pontuacao
        End If
        If Livin4.Checked = True Then
            p6 += pontuacao
        End If

        If All1.Checked = True Then
            If Now2.Checked = True Then
                If Livin3.Checked = True Then
                    If I4.Checked = True Then
                        ea7 = 1
                        MsgBox("Geometria Time", 0, Title:="Easter Egg")
                    End If
                End If
            End If
        End If

        Me.Hide()
        Jogo_8.Show()
    End Sub
End Class