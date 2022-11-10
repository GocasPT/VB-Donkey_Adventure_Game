Imports System.Runtime.InteropServices

Public Class Final
    Public cronometro = Jogo_1.cronometro
    Public tempo = Jogo_1.tempo
    Public decorrido As TimeSpan
    Dim nome = Menu_Início.nome
    Dim arma = Jogo_1.arma
    Dim p = Jogo_10.p
    Dim nota As String
    Dim EasterEgg = Jogo_10.EasterEgg
    Dim f = Jogo_10.f
    Dim final As String
    Dim vol = Opcoes.vol

    Private Sub Final_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cronometro.Stop()
        decorrido = cronometro.Elapsed
        tempo = decorrido.Minutes.ToString() & " minutos " & decorrido.Seconds.ToString() & " segundos " & decorrido.Milliseconds.ToString() & " milissegundos"

        Me.Icon = My.Resources.Burro_icon

        My.Computer.Audio.Play(My.Resources.Musica_Final_01, AudioPlayMode.BackgroundLoop)
        waveOutSetVolume(IntPtr.Zero, CUInt((vol And &HFFFF) Or (vol << 16)))

        NomeArma.Text = "Seu nome: " & nome & " e sua arma " & arma
        Time.Text = "Demoraste: " & tempo
        Per.Text = "Conseguiste: " & p & "% das perguntas certas"
        EA.Text = "Encontrastes " & EasterEgg & " de 8 Easter Eggs"

        Select Case f
            Case = 1
                final = "Bad Ending"
            Case = 2
                final = "Neutral Ending"
            Case = 3
                final = "Good Ending"
            Case = 4
                final = "Secret/Easter Egg Ending"
        End Select

        Select Case p
            Case 0 To 19.9
                nota = "Fraco"
            Case 20 To 49.9
                nota = "Insuficiente"
            Case 50 To 69.9
                nota = "Suficiente"
            Case 70 To 89.9
                nota = "Bom"
            Case 90 To 100
                nota = "Muito Bom"
        End Select

        TipoFinal.Text = "Tivestes um " & final & ". Tivestes um " & nota & " neste RPG QUIZ de Shrek"
    End Sub

    <DllImport("winmm.dll")> Private Shared Function waveOutSetVolume(ByVal hwo As IntPtr, ByVal dwVolume As UInteger) As UInteger
    End Function

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        End
    End Sub
End Class