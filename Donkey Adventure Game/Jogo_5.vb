Public Class Jogo_5
    Dim n = Jogo_4.n
    Public ea4 As Integer = 0

    Private Sub Jogo_5_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Icon = My.Resources.Burro_icon
    End Sub

    Private Sub OptionButton_Click(sender As Object, e As EventArgs) Handles OptionButton.Click
        Opcoes.Show()
    End Sub

    Private Sub NextButton_Click(sender As Object, e As EventArgs) Handles NextButton.Click
        Dim resposta As Integer
        resposta = MsgBox("Queres ajudar a Fiona?", vbQuestion + vbYesNo + vbDefaultButton2)
        If resposta = vbNo Then
            resposta = MsgBox("Queres ajudar a Fiona?", vbQuestion + vbYesNo + vbDefaultButton2)
            If resposta = vbNo Then
                If n = 1 Then
                    ea4 = 1
                    MsgBox("Chato", 0, Title:="Easter Egg")
                End If
                resposta = MsgBox("Queres ajudar a Fiona?", vbQuestion + vbOKOnly)
                If resposta = vbOK Then
                    Me.Hide()
                    Q4.Show()
                End If
            Else
                Me.Hide()
                Q4.Show()
            End If
        Else
            Me.Hide()
            Q4.Show()
        End If
    End Sub
End Class