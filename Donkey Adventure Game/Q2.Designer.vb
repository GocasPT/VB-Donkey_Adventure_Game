<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Q2
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
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ListaDeCalcado = New System.Windows.Forms.ComboBox()
        Me.OptionButton = New System.Windows.Forms.Button()
        Me.NextButton = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Donkey_Adventure_Game.My.Resources.Resources.Gato_das_botas
        Me.PictureBox1.Location = New System.Drawing.Point(-60, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(237, 194)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Castellar", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label1.Location = New System.Drawing.Point(183, 12)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(420, 43)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Este gato veio-me ajudar na minha jornada, este curioso"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Castellar", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(187, 78)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(102, 19)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Gato das"
        '
        'ListaDeCalcado
        '
        Me.ListaDeCalcado.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ListaDeCalcado.FormattingEnabled = True
        Me.ListaDeCalcado.Location = New System.Drawing.Point(287, 78)
        Me.ListaDeCalcado.Name = "ListaDeCalcado"
        Me.ListaDeCalcado.Size = New System.Drawing.Size(121, 21)
        Me.ListaDeCalcado.TabIndex = 3
        '
        'OptionButton
        '
        Me.OptionButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.OptionButton.Font = New System.Drawing.Font("Castellar", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OptionButton.Location = New System.Drawing.Point(491, 132)
        Me.OptionButton.Name = "OptionButton"
        Me.OptionButton.Size = New System.Drawing.Size(111, 34)
        Me.OptionButton.TabIndex = 10
        Me.OptionButton.Text = "Opções"
        Me.OptionButton.UseVisualStyleBackColor = True
        '
        'NextButton
        '
        Me.NextButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.NextButton.Enabled = False
        Me.NextButton.Font = New System.Drawing.Font("Castellar", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NextButton.Location = New System.Drawing.Point(492, 172)
        Me.NextButton.Name = "NextButton"
        Me.NextButton.Size = New System.Drawing.Size(111, 34)
        Me.NextButton.TabIndex = 9
        Me.NextButton.Text = "Passar"
        Me.NextButton.UseVisualStyleBackColor = True
        '
        'Q2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Peru
        Me.ClientSize = New System.Drawing.Size(614, 227)
        Me.Controls.Add(Me.OptionButton)
        Me.Controls.Add(Me.NextButton)
        Me.Controls.Add(Me.ListaDeCalcado)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "Q2"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Donkey Adventure"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents ListaDeCalcado As ComboBox
    Friend WithEvents OptionButton As Button
    Friend WithEvents NextButton As Button
End Class
