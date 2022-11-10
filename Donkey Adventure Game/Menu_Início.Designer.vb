<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Menu_Início
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
        Me.Calendario = New System.Windows.Forms.MonthCalendar()
        Me.PlayButton = New System.Windows.Forms.Button()
        Me.OptionButton = New System.Windows.Forms.Button()
        Me.RulesButton = New System.Windows.Forms.Button()
        Me.ExitButton = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Namebox = New System.Windows.Forms.TextBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Calendario
        '
        Me.Calendario.Location = New System.Drawing.Point(18, 242)
        Me.Calendario.Name = "Calendario"
        Me.Calendario.TabIndex = 1
        '
        'PlayButton
        '
        Me.PlayButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PlayButton.Enabled = False
        Me.PlayButton.Font = New System.Drawing.Font("Castellar", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PlayButton.Location = New System.Drawing.Point(268, 270)
        Me.PlayButton.Name = "PlayButton"
        Me.PlayButton.Size = New System.Drawing.Size(134, 58)
        Me.PlayButton.TabIndex = 2
        Me.PlayButton.Text = "Jogar"
        Me.PlayButton.UseVisualStyleBackColor = True
        '
        'OptionButton
        '
        Me.OptionButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.OptionButton.Font = New System.Drawing.Font("Castellar", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OptionButton.Location = New System.Drawing.Point(424, 270)
        Me.OptionButton.Name = "OptionButton"
        Me.OptionButton.Size = New System.Drawing.Size(134, 58)
        Me.OptionButton.TabIndex = 3
        Me.OptionButton.Text = "Opções"
        Me.OptionButton.UseVisualStyleBackColor = True
        '
        'RulesButton
        '
        Me.RulesButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.RulesButton.Font = New System.Drawing.Font("Castellar", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RulesButton.Location = New System.Drawing.Point(268, 346)
        Me.RulesButton.Name = "RulesButton"
        Me.RulesButton.Size = New System.Drawing.Size(134, 58)
        Me.RulesButton.TabIndex = 4
        Me.RulesButton.Text = "Regras"
        Me.RulesButton.UseVisualStyleBackColor = True
        '
        'ExitButton
        '
        Me.ExitButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ExitButton.Font = New System.Drawing.Font("Castellar", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ExitButton.Location = New System.Drawing.Point(424, 346)
        Me.ExitButton.Name = "ExitButton"
        Me.ExitButton.Size = New System.Drawing.Size(134, 58)
        Me.ExitButton.TabIndex = 5
        Me.ExitButton.Text = "Sair"
        Me.ExitButton.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Donkey_Adventure_Game.My.Resources.Resources.Donkey_Adventure
        Me.PictureBox1.Location = New System.Drawing.Point(1, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(579, 211)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Castellar", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(265, 238)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(60, 16)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Nome:"
        '
        'Namebox
        '
        Me.Namebox.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Namebox.Location = New System.Drawing.Point(323, 235)
        Me.Namebox.Name = "Namebox"
        Me.Namebox.Size = New System.Drawing.Size(235, 20)
        Me.Namebox.TabIndex = 7
        '
        'Menu_Início
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Peru
        Me.ClientSize = New System.Drawing.Size(581, 424)
        Me.Controls.Add(Me.Namebox)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ExitButton)
        Me.Controls.Add(Me.RulesButton)
        Me.Controls.Add(Me.OptionButton)
        Me.Controls.Add(Me.PlayButton)
        Me.Controls.Add(Me.Calendario)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "Menu_Início"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Menu"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Calendario As MonthCalendar
    Friend WithEvents PlayButton As Button
    Friend WithEvents OptionButton As Button
    Friend WithEvents RulesButton As Button
    Friend WithEvents ExitButton As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Namebox As TextBox
End Class
