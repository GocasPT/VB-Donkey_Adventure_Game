Public Class Q2
    Public p2 As Integer
    Dim pontuacao As Integer = 15
    Dim arma = Jogo_1.arma
    Public ea2 As Integer = 0

    Private Sub Q2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Icon = My.Resources.Burro_icon

        ListaDeCalcado.Items.Add("Sapatilhas")
        ListaDeCalcado.Items.Add("Crocs")
        ListaDeCalcado.Items.Add("Sabrinas")
        ListaDeCalcado.Items.Add("Botas")
        ListaDeCalcado.Items.Add("Pantufas")
        ListaDeCalcado.Items.Add("Mocassins")
        ListaDeCalcado.Items.Add("Sandálias")
    End Sub

    Private Sub OptionButton_Click(sender As Object, e As EventArgs) Handles OptionButton.Click
        Opcoes.Show()
    End Sub

    Private Sub ListaDeCalcado_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListaDeCalcado.SelectedIndexChanged
        If Not ListaDeCalcado.SelectedItem = "" Then
            NextButton.Enabled = True
        End If
    End Sub

    Private Sub NextButton_Click(sender As Object, e As EventArgs) Handles NextButton.Click
        p2 = 0

        If ListaDeCalcado.SelectedIndex > -1 Then
            Dim calcado As String
            calcado = ListaDeCalcado.SelectedItem
            If calcado = "Botas" Then
                p2 = pontuacao
            Else
                p2 = 0
            End If
        End If

        If arma = "Espada" Then
            Dim calcado As String = ListaDeCalcado.SelectedItem
            If calcado = "Sandálias" Then
                ea2 = 1
                MsgBox("Espadas e Sandálias", 0, Title:="Easter Egg")
            End If
        End If

        Me.Hide()
        Jogo_4.Show()
    End Sub
End Class