Public Class Menu_Início
    Public nome As String
    Dim n As Integer

    Private Sub Menu_Início_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Icon = My.Resources.Burro_icon
    End Sub

    Private Sub Namebox_TextChanged(sender As Object, e As EventArgs) Handles Namebox.TextChanged
        If IsNumeric(Namebox) Then
            Namebox.Text = ""
        End If

        If Not Namebox.Text = "" Then
            PlayButton.Enabled = True
        End If
    End Sub

    Private Sub PlayButton_Click(sender As Object, e As EventArgs) Handles PlayButton.Click
        Dim nasciemnto As DateTime = Calendario.SelectionRange.Start.Date
        Dim hoje As DateTime = DateTime.Now
        Dim idade As TimeSpan = hoje - nasciemnto
        Dim check As Integer = Int(idade.Days / 365.25)

        nome = Namebox.Text

        If n = 0 Then
            MsgBox("Abra primeiro as opções")
            Exit Sub
        End If

        If check >= 18 And check <= 100 Then
            Me.Hide()
            Jogo_1.Show()
        Else
            MsgBox("Só podes jogar se tiveres 18 a 100 anos.")
        End If
    End Sub

    Private Sub OptionButton_Click(sender As Object, e As EventArgs) Handles OptionButton.Click
        Opcoes.Show()
        n = 1
    End Sub

    Private Sub RulesButton_Click(sender As Object, e As EventArgs) Handles RulesButton.Click
        Rules.Show()
    End Sub

    Private Sub ExitButton_Click(sender As Object, e As EventArgs) Handles ExitButton.Click
        End
    End Sub
End Class