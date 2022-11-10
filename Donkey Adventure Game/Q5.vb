Public Class Q5
    Public p5 As Integer
    Dim pontuacao As Integer = 3
    Public ea6 As Integer = 0

    Private Sub Q5_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Icon = My.Resources.Burro_icon

        v1.Items.Add("DoLuc")
        v1.Items.Add("LucDo")
        v1.Items.Add("LocDu")
        v1.Items.Add("Lolita")
        v1.Items.Add("DuLoc")

        v2.Items.Add("lactoses")
        v2.Items.Add("leis")
        v2.Items.Add("latas")
        v2.Items.Add("leites")
        v2.Items.Add("seis")

        v3.Items.Add("nós")
        v3.Items.Add("vós")
        v3.Items.Add("avós")
        v3.Items.Add("pós")
        v3.Items.Add("voz")

        v4.Items.Add("cu")
        v4.Items.Add("nu")
        v4.Items.Add("pus")
        v4.Items.Add("tu")
        v4.Items.Add("luz")

        v5.Items.Add("patrão")
        v5.Items.Add("alcatrão")
        v5.Items.Add("chão")
        v5.Items.Add("cu")
        v5.Items.Add("balão")

        v6.Items.Add("raíz")
        v6.Items.Add("país")
        v6.Items.Add("pais")
        v6.Items.Add("beatriz")
        v6.Items.Add("imperatriz")
    End Sub

    Private Sub OptionButton_Click(sender As Object, e As EventArgs) Handles OptionButton.Click
        Opcoes.Show()
    End Sub

    Private Sub v1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles v1.SelectedIndexChanged
        NextButton.Enabled = True
    End Sub

    Private Sub v2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles v2.SelectedIndexChanged
        NextButton.Enabled = True
    End Sub

    Private Sub v3_SelectedIndexChanged(sender As Object, e As EventArgs) Handles v3.SelectedIndexChanged
        NextButton.Enabled = True
    End Sub

    Private Sub v4_SelectedIndexChanged(sender As Object, e As EventArgs) Handles v4.SelectedIndexChanged
        NextButton.Enabled = True
    End Sub

    Private Sub v5_SelectedIndexChanged(sender As Object, e As EventArgs) Handles v5.SelectedIndexChanged
        NextButton.Enabled = True
    End Sub

    Private Sub v6_SelectedIndexChanged(sender As Object, e As EventArgs) Handles v6.SelectedIndexChanged
        NextButton.Enabled = True
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        If Play.Checked = True Then
            Play.Checked = False
        Else
            Play.Checked = True
        End If
    End Sub

    Private Sub Play_CheckedChanged(sender As Object, e As EventArgs) Handles Play.CheckedChanged
        My.Computer.Audio.Play(My.Resources.Shrek___Welcome_to_Duloc__EU_Portuguese_, AudioPlayMode.WaitToComplete)
    End Sub

    Private Sub NextButton_Click(sender As Object, e As EventArgs) Handles NextButton.Click
        p5 = 0
        If v1.SelectedItem = "Duloc" Then
            p5 += pontuacao
        End If
        If v2.SelectedItem = "leis" Then
            p5 += pontuacao
        End If
        If v3.SelectedItem = "nós" Then
            p5 += pontuacao
        End If
        If v4.SelectedItem = "tu" Then
            p5 += pontuacao
        End If
        If v5.SelectedItem = "chão" Then
            p5 += pontuacao
        End If
        If v6.SelectedItem = "país" Then
            p5 += pontuacao
        End If

        If v1.SelectedItem = "Lolita" Then
            If v2.SelectedItem = "lactoses" Then
                If v3.SelectedItem = "pós" Then
                    If v4.SelectedItem = "cu" Then
                        If v5.SelectedItem = "cu" Then
                            If v6.SelectedItem = "imperatriz" Then
                                ea6 = 1
                                MsgBox("Imperatriz Lolita do cu grande e da lactose em pó", 0, Title:="Easter Egg")
                            End If
                        End If
                    End If
                End If
            End If
        End If

        My.Computer.Audio.Play(My.Resources.Every_JoJo_Opening_but_it_s_pitch_shifted_All_Star___The_Sequel_2, AudioPlayMode.BackgroundLoop)
        Me.Hide()
        Jogo_7.Show()
    End Sub
End Class