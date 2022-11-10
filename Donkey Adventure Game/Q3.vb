Public Class Q3
    Public p3 As Integer
    Dim pontuacao As Integer = 5
    Public ea3 As Integer = 0

    Private Sub Q3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Icon = My.Resources.Burro_icon

        ListNames.Items.Add("Feliz")
        ListNames.Items.Add("Falange")
        ListNames.Items.Add("Felícia")
        ListNames.Items.Add("Fergus")
        ListNames.Items.Add("Flauta")
        ListNames.Items.Add("Fernando Pessoa")
        ListNames.Items.Add("Fabrício")
        ListNames.Items.Add("Flatus")
        ListNames.Items.Add("Floribella")
        ListNames.Items.Add("Smurfina")
    End Sub

    Private Sub OptionButton_Click(sender As Object, e As EventArgs) Handles OptionButton.Click
        Opcoes.Show()
    End Sub

    Private Sub ListNames_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListNames.SelectedIndexChanged
        NextButton.Enabled = True
    End Sub

    Private Sub NextButton_Click(sender As Object, e As EventArgs) Handles NextButton.Click
        p3 = 0
        If ListNames.CheckedItems.Count <> 3 Then
            MsgBox("Tenho 3 filhos ó burro")
            Exit Sub
        Else
            For i = 0 To ListNames.CheckedItems.Count - 1
                If ListNames.CheckedItems(i).ToString = "Felícia" Then
                    p3 += pontuacao
                End If
                If ListNames.CheckedItems(i).ToString = "Fergus" Then
                    p3 += pontuacao
                End If
                If ListNames.CheckedItems(i).ToString = "Flatus" Then
                    p3 += pontuacao
                End If
            Next
            For i = 0 To ListNames.CheckedItems.Count - 1
                If ListNames.CheckedItems(i).ToString = "Feliz" Then
                    i = i + 1
                    If ListNames.CheckedItems(i).ToString = "Floribella" Then
                        i = i + 1
                        If ListNames.CheckedItems(i).ToString = "Smurfina" Then
                            ea3 = 1
                            MsgBox("Crossover Time", 0, Title:="Easter Egg")
                        End If
                    End If
                End If
            Next
        End If

        Me.Hide()
        Jogo_5.Show()
    End Sub
End Class