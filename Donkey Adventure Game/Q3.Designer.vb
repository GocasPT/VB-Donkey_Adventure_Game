<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Q3
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ListNames = New System.Windows.Forms.CheckedListBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.OptionButton = New System.Windows.Forms.Button()
        Me.NextButton = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Castellar", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label1.Location = New System.Drawing.Point(13, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(390, 118)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Preciso de chamar os meus 3 filhos para irmos fazer um biscoito de gengibre gigan" &
    "te. Só precisamos de os chamar que eles aparecem já… tu sabes os nomes deles cer" &
    "to?"
        '
        'ListNames
        '
        Me.ListNames.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ListNames.Font = New System.Drawing.Font("Castellar", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListNames.FormattingEnabled = True
        Me.ListNames.Location = New System.Drawing.Point(17, 145)
        Me.ListNames.Name = "ListNames"
        Me.ListNames.Size = New System.Drawing.Size(228, 224)
        Me.ListNames.TabIndex = 1
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Donkey_Adventure_Game.My.Resources.Resources.Fiona
        Me.PictureBox1.Location = New System.Drawing.Point(251, 145)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(119, 214)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 2
        Me.PictureBox1.TabStop = False
        '
        'OptionButton
        '
        Me.OptionButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.OptionButton.Font = New System.Drawing.Font("Castellar", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OptionButton.Location = New System.Drawing.Point(142, 391)
        Me.OptionButton.Name = "OptionButton"
        Me.OptionButton.Size = New System.Drawing.Size(111, 34)
        Me.OptionButton.TabIndex = 16
        Me.OptionButton.Text = "Opções"
        Me.OptionButton.UseVisualStyleBackColor = True
        '
        'NextButton
        '
        Me.NextButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.NextButton.Enabled = False
        Me.NextButton.Font = New System.Drawing.Font("Castellar", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NextButton.Location = New System.Drawing.Point(259, 391)
        Me.NextButton.Name = "NextButton"
        Me.NextButton.Size = New System.Drawing.Size(111, 34)
        Me.NextButton.TabIndex = 15
        Me.NextButton.Text = "Passar"
        Me.NextButton.UseVisualStyleBackColor = True
        '
        'Q3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Peru
        Me.ClientSize = New System.Drawing.Size(408, 450)
        Me.Controls.Add(Me.OptionButton)
        Me.Controls.Add(Me.NextButton)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.ListNames)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Q3"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Donkey Adventure"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents ListNames As CheckedListBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents OptionButton As Button
    Friend WithEvents NextButton As Button
End Class
