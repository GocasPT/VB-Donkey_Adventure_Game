Imports System.Runtime.InteropServices

Public Class Opcoes
    Public vol As UInteger

    Private Sub Opcoes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Icon = My.Resources.Engrenagem_Icon
        HScrollBar1.Minimum = 0
        HScrollBar1.Maximum = 100
        HScrollBar1.Value = 50
        Valor.Text = HScrollBar1.Value.ToString & "%"
        Timer1.Start()
    End Sub

    Private Sub HScrollBar1_Scroll(sender As Object, e As ScrollEventArgs) Handles HScrollBar1.Scroll
        vol = CUInt((UShort.MaxValue / 100) * HScrollBar1.Value)
        waveOutSetVolume(IntPtr.Zero, CUInt((vol And &HFFFF) Or (vol << 16)))
        Valor.Text = HScrollBar1.Value.ToString & "%"
    End Sub

    Private Function GetApplicationVolume() As Integer
        vol = 0
        waveOutGetVolume(IntPtr.Zero, vol)
        Return CInt((vol And &HFFFF) / (UShort.MaxValue / 100))
    End Function

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Dim v As Integer = GetApplicationVolume()

        If HScrollBar1.Value <> v Then
            HScrollBar1.Value = v
            Valor.Text = HScrollBar1.Value.ToString & "%"
        End If
    End Sub

    Private Sub BackButton_Click(sender As Object, e As EventArgs) Handles BackButton.Click
        Me.Hide()
    End Sub

    <DllImport("winmm.dll")> Private Shared Function waveOutSetVolume(ByVal hwo As IntPtr, ByVal dwVolume As UInteger) As UInteger
    End Function

    <DllImport("winmm.dll")> Private Shared Function waveOutGetVolume(ByVal hwo As IntPtr, ByRef pdwVolume As UInteger) As UInteger
    End Function

End Class