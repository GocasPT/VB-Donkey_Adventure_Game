Public Class Jogo_10
    Dim nome = Menu_Início.nome
    Dim arma = Jogo_1.arma
    Public f As Integer = 0

    Public p As Integer = 0
    Dim p1 = Q1.p1
    Dim p2 = Q2.p2
    Dim p3 = Q3.p3
    Dim p4 = Q4.p4
    Dim p5 = Q5.p5
    Dim p6 = Q6.p6
    Dim p7 = Q7.p7

    Public EasterEgg As Integer
    Dim ea1 = Q1.ea1
    Dim ea2 = Q2.ea2
    Dim ea3 = Q3.ea3
    Dim ea4 = Jogo_5.ea4
    Dim ea5 = Q4.ea5
    Dim ea6 = Q5.ea6
    Dim ea7 = Q6.ea7
    Dim ea8 As Integer = 0

    Private Sub Jogo_10_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Icon = My.Resources.Burro_icon
    End Sub

    Private Sub OptionButton_Click(sender As Object, e As EventArgs) Handles OptionButton.Click
        Opcoes.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        MsgBox("Por alguma razão," & nome & " , o burro que falava, já não conseguia falar. Por isso não consegues falar com ele", 0, Title:="Info")
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        MsgBox("O salário da programação acabou e não conseguiram criar um inventário para esta aventura. A única coisa que tens é o tem companheiro " & arma, 0, Title:="info")
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        MsgBox("As portas por que entraste estão trancadas, não tens escapatória desta situação", 0, Title:="Info")
    End Sub

    Private Sub NextButton_Click(sender As Object, e As EventArgs) Handles NextButton.Click
        p = (p1 + p2 + p3 + p4 + p5 + p6 + p7)

        If p = 0 Then
            ea8 = 1
            MsgBox("Zero à esquerda", 0, Title:="Easter Egg")
        End If

        EasterEgg = ea1 + ea2 + ea3 + ea4 + ea5 + ea6 + ea7 + ea8

        If EasterEgg = 8 Then
            Me.Hide()
            SecretEnding.Show()
            f = 4
        Else
            Select Case p
                Case < 49.9
                    Me.Hide()
                    BadEnding.Show()
                    f = 1
                Case 50 To 89.9
                    Me.Hide()
                    NeutralEnding.Show()
                    f = 2
                Case > 90
                    Me.Hide()
                    GoodEnding.Show()
                    f = 3
            End Select
        End If
    End Sub
End Class