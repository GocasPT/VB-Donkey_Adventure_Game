Imports System.IO
Imports System.Runtime.InteropServices

Public Class Jogo_1
    Public arma As String
    Public cronometro As New Stopwatch
    Public decorrido As TimeSpan
    Public tempo As String
    Dim vol = Opcoes.vol

    Private Sub Jogo_1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cronometro.Start()
        Me.Icon = My.Resources.Burro_icon
        My.Computer.Audio.Play(My.Resources.Every_JoJo_Opening_but_it_s_pitch_shifted_All_Star___The_Sequel, AudioPlayMode.BackgroundLoop)
        waveOutSetVolume(IntPtr.Zero, CUInt((vol And &HFFFF) Or (vol << 16)))
    End Sub

    Private Sub Seletor_ValueChanged(sender As Object, e As EventArgs) Handles Seletor.ValueChanged
        If Seletor.Value = 0 Then
            NextButton.Enabled = False
        End If

        Dim fullPath As String = IO.Path.GetFullPath(My.Resources.ResourceManager.BaseName)
        fullPath = fullPath.Substring(0, fullPath.Length - 42) & "\Armas"

        Dim pasta_imagens As New DirectoryInfo(fullPath)

        Dim ficheiros() As FileInfo
        ficheiros = pasta_imagens.GetFiles()

        Dim num_ficheiro As Long
        num_ficheiro = ficheiros.Length

        Seletor.Minimum = 1
        Seletor.Maximum = num_ficheiro

        Dim num_fich_escolhido As Long
        num_fich_escolhido = Seletor.Value - 1

        Dim caminho_fich_escolhido As String
        caminho_fich_escolhido = ficheiros(num_fich_escolhido).FullName

        arma = ficheiros(num_fich_escolhido).Name.Replace(".png", "")

        PictureBox1.BackgroundImage = Image.FromFile(caminho_fich_escolhido)
        NomeArma.Text = arma
        NomeArma.Show()
        NextButton.Enabled = True
    End Sub

    Private Sub NextButton_Click(sender As Object, e As EventArgs) Handles NextButton.Click
        Dim resposta As Integer
        resposta = MsgBox("Tem a certeza que quer esta arma?", vbQuestion + vbYesNo + vbDefaultButton2, "Checking...")
        If resposta = vbYes Then
            Me.Hide()
            Jogo_2.Show()
        Else
            Exit Sub
        End If
    End Sub

    <DllImport("winmm.dll")> Private Shared Function waveOutSetVolume(ByVal hwo As IntPtr, ByVal dwVolume As UInteger) As UInteger
    End Function
End Class