<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Jogo_1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.NextButton = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Seletor = New System.Windows.Forms.NumericUpDown()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.NomeArma = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Seletor, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'NextButton
        '
        Me.NextButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.NextButton.Enabled = False
        Me.NextButton.Font = New System.Drawing.Font("Castellar", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NextButton.Location = New System.Drawing.Point(601, 338)
        Me.NextButton.Name = "NextButton"
        Me.NextButton.Size = New System.Drawing.Size(111, 34)
        Me.NextButton.TabIndex = 4
        Me.NextButton.Text = "Passar"
        Me.NextButton.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Location = New System.Drawing.Point(12, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(361, 363)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 5
        Me.PictureBox1.TabStop = False
        '
        'Seletor
        '
        Me.Seletor.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Seletor.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Seletor.Location = New System.Drawing.Point(385, 12)
        Me.Seletor.Name = "Seletor"
        Me.Seletor.Size = New System.Drawing.Size(18, 35)
        Me.Seletor.TabIndex = 6
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Castellar", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(415, 12)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(297, 50)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Escolhe uma arma para a sua aventura"
        '
        'NomeArma
        '
        Me.NomeArma.AutoSize = True
        Me.NomeArma.Font = New System.Drawing.Font("Castellar", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NomeArma.ForeColor = System.Drawing.Color.Gold
        Me.NomeArma.Location = New System.Drawing.Point(415, 97)
        Me.NomeArma.Name = "NomeArma"
        Me.NomeArma.Size = New System.Drawing.Size(112, 29)
        Me.NomeArma.TabIndex = 8
        Me.NomeArma.Text = "Label2"
        Me.NomeArma.Visible = False
        '
        'Jogo_1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Peru
        Me.ClientSize = New System.Drawing.Size(720, 392)
        Me.Controls.Add(Me.NomeArma)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Seletor)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.NextButton)
        Me.Name = "Jogo_1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Donkey Adventure"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Seletor, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents NextButton As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Seletor As NumericUpDown
    Friend WithEvents Label1 As Label
    Friend WithEvents NomeArma As Label
End Class
