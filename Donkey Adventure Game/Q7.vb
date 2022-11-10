Public Class Q7
    Public p7 As Integer
    Dim pontuacao As Integer = 11

    Private Sub Q7_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Icon = My.Resources.Burro_icon
    End Sub

    Private Sub PictureArco_Click(sender As Object, e As EventArgs) Handles PictureArco.Click
        ArcoCheck.Checked = True
        NextButton.Enabled = True
    End Sub

    Private Sub ArcoCheck_CheckedChanged(sender As Object, e As EventArgs) Handles ArcoCheck.CheckedChanged
        If ArcoCheck.Checked = True Then
            PictureArco.BackColor = Color.DeepSkyBlue
            PictureEscudo.BackColor = Color.Peru
            PicturePunhos.BackColor = Color.Peru
            PicturePL01.BackColor = Color.Peru
            PictureDeagle.BackColor = Color.Peru
            PictureShrek.BackColor = Color.Peru
            PictureEspada.BackColor = Color.Peru
            PictureJuan.BackColor = Color.Peru
        End If
    End Sub

    Private Sub PicturePunhos_Click(sender As Object, e As EventArgs) Handles PicturePunhos.Click
        PunhosCheck.Checked = True
        NextButton.Enabled = True
    End Sub

    Private Sub PunhosCheck_CheckedChanged(sender As Object, e As EventArgs) Handles PunhosCheck.CheckedChanged
        If PunhosCheck.Checked = True Then
            PictureArco.BackColor = Color.Peru
            PictureEscudo.BackColor = Color.Peru
            PicturePunhos.BackColor = Color.DeepSkyBlue
            PicturePL01.BackColor = Color.Peru
            PictureDeagle.BackColor = Color.Peru
            PictureShrek.BackColor = Color.Peru
            PictureEspada.BackColor = Color.Peru
            PictureJuan.BackColor = Color.Peru
        End If
    End Sub

    Private Sub PictureEscudo_Click(sender As Object, e As EventArgs) Handles PictureEscudo.Click
        EscudoCheck.Checked = True
        NextButton.Enabled = True
    End Sub

    Private Sub EscudoCheck_CheckedChanged(sender As Object, e As EventArgs) Handles EscudoCheck.CheckedChanged
        If EscudoCheck.Checked = True Then
            PictureArco.BackColor = Color.Peru
            PictureEscudo.BackColor = Color.DeepSkyBlue
            PicturePunhos.BackColor = Color.Peru
            PicturePL01.BackColor = Color.Peru
            PictureDeagle.BackColor = Color.Peru
            PictureShrek.BackColor = Color.Peru
            PictureEspada.BackColor = Color.Peru
            PictureJuan.BackColor = Color.Peru
        End If
    End Sub

    Private Sub PictureEspada_Click(sender As Object, e As EventArgs) Handles PictureEspada.Click
        EspadaCheck.Checked = True
        NextButton.Enabled = True
    End Sub

    Private Sub EspadaCheck_CheckedChanged(sender As Object, e As EventArgs) Handles EspadaCheck.CheckedChanged
        If EspadaCheck.Checked = True Then
            PictureArco.BackColor = Color.Peru
            PictureEscudo.BackColor = Color.Peru
            PicturePunhos.BackColor = Color.Peru
            PicturePL01.BackColor = Color.Peru
            PictureDeagle.BackColor = Color.Peru
            PictureShrek.BackColor = Color.Peru
            PictureEspada.BackColor = Color.DeepSkyBlue
            PictureJuan.BackColor = Color.Peru
        End If
    End Sub

    Private Sub PictureShrek_Click(sender As Object, e As EventArgs) Handles PictureShrek.Click
        ShrekCheck.Checked = True
        NextButton.Enabled = True
    End Sub

    Private Sub ShrekCheck_CheckedChanged(sender As Object, e As EventArgs) Handles ShrekCheck.CheckedChanged
        If ShrekCheck.Checked = True Then
            PictureArco.BackColor = Color.Peru
            PictureEscudo.BackColor = Color.Peru
            PicturePunhos.BackColor = Color.Peru
            PicturePL01.BackColor = Color.Peru
            PictureDeagle.BackColor = Color.Peru
            PictureShrek.BackColor = Color.DeepSkyBlue
            PictureEspada.BackColor = Color.Peru
            PictureJuan.BackColor = Color.Peru
        End If
    End Sub

    Private Sub PicturePL01_Click(sender As Object, e As EventArgs) Handles PicturePL01.Click
        PLO1Check.Checked = True
        NextButton.Enabled = True
    End Sub

    Private Sub PLO1Check_CheckedChanged(sender As Object, e As EventArgs) Handles PLO1Check.CheckedChanged
        If PLO1Check.Checked = True Then
            PictureArco.BackColor = Color.Peru
            PictureEscudo.BackColor = Color.Peru
            PicturePunhos.BackColor = Color.Peru
            PicturePL01.BackColor = Color.DeepSkyBlue
            PictureDeagle.BackColor = Color.Peru
            PictureShrek.BackColor = Color.Peru
            PictureEspada.BackColor = Color.Peru
            PictureJuan.BackColor = Color.Peru
        End If
    End Sub

    Private Sub PictureDeagle_Click(sender As Object, e As EventArgs) Handles PictureDeagle.Click
        DeagleCheck.Checked = True
        NextButton.Enabled = True
    End Sub

    Private Sub DeagleCheck_CheckedChanged(sender As Object, e As EventArgs) Handles DeagleCheck.CheckedChanged
        If DeagleCheck.Checked = True Then
            PictureArco.BackColor = Color.Peru
            PictureEscudo.BackColor = Color.Peru
            PicturePunhos.BackColor = Color.Peru
            PicturePL01.BackColor = Color.Peru
            PictureDeagle.BackColor = Color.DeepSkyBlue
            PictureShrek.BackColor = Color.Peru
            PictureEspada.BackColor = Color.Peru
            PictureJuan.BackColor = Color.Peru
        End If
    End Sub

    Private Sub PictureJuan_Click(sender As Object, e As EventArgs) Handles PictureJuan.Click
        JuanCheck.Checked = True
        NextButton.Enabled = True
    End Sub

    Private Sub JuanCheck_CheckedChanged(sender As Object, e As EventArgs) Handles JuanCheck.CheckedChanged
        If JuanCheck.Checked = True Then
            PictureArco.BackColor = Color.Peru
            PictureEscudo.BackColor = Color.Peru
            PicturePunhos.BackColor = Color.Peru
            PicturePL01.BackColor = Color.Peru
            PictureDeagle.BackColor = Color.Peru
            PictureShrek.BackColor = Color.Peru
            PictureEspada.BackColor = Color.Peru
            PictureJuan.BackColor = Color.DeepSkyBlue
        End If
    End Sub

    Private Sub OptionButton_Click(sender As Object, e As EventArgs) Handles OptionButton.Click
        Opcoes.Show()
    End Sub

    Private Sub NextButton_Click(sender As Object, e As EventArgs) Handles NextButton.Click
        Dim arma = Jogo_1.arma
        p7 = 0

        Select Case arma
            Case = "Arco"
                If ArcoCheck.Checked = True Then
                    p7 = pontuacao
                End If

            Case = "Escudo"
                If EscudoCheck.Checked = True Then
                    p7 = pontuacao
                End If

            Case = "Punho"
                If PunhosCheck.Checked = True Then
                    p7 = pontuacao
                End If

            Case = "PL-01"
                If PLO1Check.Checked = True Then
                    p7 = pontuacao
                End If

            Case = "Desert Eagle"
                If DeagleCheck.Checked = True Then
                    p7 = pontuacao
                End If

            Case = "Shrek"
                If ShrekCheck.Checked = True Then
                    p7 = pontuacao
                End If

            Case = "Espada"
                If EspadaCheck.Checked = True Then
                    p7 = pontuacao
                End If

            Case = "Juan"
                If JuanCheck.Checked = True Then
                    p7 = pontuacao
                End If
        End Select

        Me.Hide()
        Jogo_9.show()
    End Sub
End Class