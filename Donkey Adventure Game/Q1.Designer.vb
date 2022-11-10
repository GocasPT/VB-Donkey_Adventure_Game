<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Q1
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
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Errado_1 = New System.Windows.Forms.RadioButton()
        Me.Errado_Mark = New System.Windows.Forms.RadioButton()
        Me.Errado_2 = New System.Windows.Forms.RadioButton()
        Me.Certo = New System.Windows.Forms.RadioButton()
        Me.OptionButton = New System.Windows.Forms.Button()
        Me.NextButton = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Donkey_Adventure_Game.My.Resources.Resources.Lord_Farquaad
        Me.PictureBox1.Location = New System.Drawing.Point(12, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(200, 159)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Castellar", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(219, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(476, 47)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Qual o nome do vilão que aprisionou a Dragão?"
        '
        'Errado_1
        '
        Me.Errado_1.AutoSize = True
        Me.Errado_1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Errado_1.Font = New System.Drawing.Font("Castellar", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Errado_1.Location = New System.Drawing.Point(219, 87)
        Me.Errado_1.Name = "Errado_1"
        Me.Errado_1.Size = New System.Drawing.Size(155, 23)
        Me.Errado_1.TabIndex = 2
        Me.Errado_1.TabStop = True
        Me.Errado_1.Text = "Kim Jong-un"
        Me.Errado_1.UseVisualStyleBackColor = True
        '
        'Errado_Mark
        '
        Me.Errado_Mark.AutoSize = True
        Me.Errado_Mark.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Errado_Mark.Font = New System.Drawing.Font("Castellar", 12.0!)
        Me.Errado_Mark.Location = New System.Drawing.Point(420, 87)
        Me.Errado_Mark.Name = "Errado_Mark"
        Me.Errado_Mark.Size = New System.Drawing.Size(135, 23)
        Me.Errado_Mark.TabIndex = 3
        Me.Errado_Mark.TabStop = True
        Me.Errado_Mark.Text = "Markiplier"
        Me.Errado_Mark.UseVisualStyleBackColor = True
        '
        'Errado_2
        '
        Me.Errado_2.AutoSize = True
        Me.Errado_2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Errado_2.Font = New System.Drawing.Font("Castellar", 12.0!)
        Me.Errado_2.Location = New System.Drawing.Point(219, 132)
        Me.Errado_2.Name = "Errado_2"
        Me.Errado_2.Size = New System.Drawing.Size(144, 23)
        Me.Errado_2.TabIndex = 4
        Me.Errado_2.TabStop = True
        Me.Errado_2.Text = "Logan Paul"
        Me.Errado_2.UseVisualStyleBackColor = True
        '
        'Certo
        '
        Me.Certo.AutoSize = True
        Me.Certo.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Certo.Font = New System.Drawing.Font("Castellar", 12.0!)
        Me.Certo.Location = New System.Drawing.Point(420, 131)
        Me.Certo.Name = "Certo"
        Me.Certo.Size = New System.Drawing.Size(185, 23)
        Me.Certo.TabIndex = 5
        Me.Certo.TabStop = True
        Me.Certo.Text = "Lord Farquaad"
        Me.Certo.UseVisualStyleBackColor = True
        '
        'OptionButton
        '
        Me.OptionButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.OptionButton.Font = New System.Drawing.Font("Castellar", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OptionButton.Location = New System.Drawing.Point(467, 177)
        Me.OptionButton.Name = "OptionButton"
        Me.OptionButton.Size = New System.Drawing.Size(111, 34)
        Me.OptionButton.TabIndex = 8
        Me.OptionButton.Text = "Opções"
        Me.OptionButton.UseVisualStyleBackColor = True
        '
        'NextButton
        '
        Me.NextButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.NextButton.Enabled = False
        Me.NextButton.Font = New System.Drawing.Font("Castellar", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NextButton.Location = New System.Drawing.Point(584, 177)
        Me.NextButton.Name = "NextButton"
        Me.NextButton.Size = New System.Drawing.Size(111, 34)
        Me.NextButton.TabIndex = 7
        Me.NextButton.Text = "Passar"
        Me.NextButton.UseVisualStyleBackColor = True
        '
        'Q1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Peru
        Me.ClientSize = New System.Drawing.Size(707, 226)
        Me.Controls.Add(Me.OptionButton)
        Me.Controls.Add(Me.NextButton)
        Me.Controls.Add(Me.Certo)
        Me.Controls.Add(Me.Errado_2)
        Me.Controls.Add(Me.Errado_Mark)
        Me.Controls.Add(Me.Errado_1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "Q1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Donkey Adventure"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Errado_1 As RadioButton
    Friend WithEvents Errado_Mark As RadioButton
    Friend WithEvents Errado_2 As RadioButton
    Friend WithEvents Certo As RadioButton
    Friend WithEvents OptionButton As Button
    Friend WithEvents NextButton As Button
End Class
