<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Jogo_8
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.OptionButton = New System.Windows.Forms.Button()
        Me.NextButton = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'OptionButton
        '
        Me.OptionButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.OptionButton.Font = New System.Drawing.Font("Castellar", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OptionButton.Location = New System.Drawing.Point(488, 336)
        Me.OptionButton.Name = "OptionButton"
        Me.OptionButton.Size = New System.Drawing.Size(111, 34)
        Me.OptionButton.TabIndex = 30
        Me.OptionButton.Text = "Opções"
        Me.OptionButton.UseVisualStyleBackColor = True
        '
        'NextButton
        '
        Me.NextButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.NextButton.Font = New System.Drawing.Font("Castellar", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NextButton.Location = New System.Drawing.Point(605, 336)
        Me.NextButton.Name = "NextButton"
        Me.NextButton.Size = New System.Drawing.Size(111, 34)
        Me.NextButton.TabIndex = 29
        Me.NextButton.Text = "Passar"
        Me.NextButton.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Castellar", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(10, 226)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(702, 107)
        Me.Label1.TabIndex = 28
        Me.Label1.Text = "Depois de passados os pequenos cantores e momentos de nostalgia, o nosso herói e " &
    "os seus companheiros continuaram à procura do inimigo para libertar a sua amada," &
    " até que se distraem com algo mágico."
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Donkey_Adventure_Game.My.Resources.Resources.Cena7
        Me.PictureBox1.Location = New System.Drawing.Point(14, 10)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(702, 213)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 27
        Me.PictureBox1.TabStop = False
        '
        'Jogo_8
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Peru
        Me.ClientSize = New System.Drawing.Size(727, 380)
        Me.Controls.Add(Me.OptionButton)
        Me.Controls.Add(Me.NextButton)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "Jogo_8"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Donkey Adventure"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents OptionButton As Button
    Friend WithEvents NextButton As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox1 As PictureBox
End Class
