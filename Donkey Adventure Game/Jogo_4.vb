Public Class Jogo_4
    Dim nome = Menu_Início.nome
    Public n As Integer = 0

    Private Sub Jogo_4_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Icon = My.Resources.Burro_icon
        Label1.Text = """Olá " & nome &
", eu sei que estás a tentar salvar a Dragão, mas será que me podes ajudar primeiro?"""
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
                n = 1
                resposta = MsgBox("Queres ajudar a Fiona?", vbQuestion + vbOKOnly)
                If resposta = vbOK Then
                    Me.Hide()
                    Q3.Show()
                End If
            Else
                Me.Hide()
                Q3.Show()
            End If
        Else
            Me.Hide()
            Q3.Show()
        End If
    End Sub
End Class