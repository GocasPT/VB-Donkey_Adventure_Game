<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Opcoes
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
        Me.components = New System.ComponentModel.Container()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Valor = New System.Windows.Forms.Label()
        Me.HScrollBar1 = New System.Windows.Forms.HScrollBar()
        Me.BackButton = New System.Windows.Forms.Button()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Castellar", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(163, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(58, 23)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Som"
        '
        'Valor
        '
        Me.Valor.AutoSize = True
        Me.Valor.Location = New System.Drawing.Point(173, 60)
        Me.Valor.Name = "Valor"
        Me.Valor.Size = New System.Drawing.Size(39, 13)
        Me.Valor.TabIndex = 1
        Me.Valor.Text = "Label2"
        '
        'HScrollBar1
        '
        Me.HScrollBar1.Cursor = System.Windows.Forms.Cursors.SizeWE
        Me.HScrollBar1.Location = New System.Drawing.Point(9, 89)
        Me.HScrollBar1.Name = "HScrollBar1"
        Me.HScrollBar1.Size = New System.Drawing.Size(365, 17)
        Me.HScrollBar1.TabIndex = 2
        '
        'BackButton
        '
        Me.BackButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BackButton.Font = New System.Drawing.Font("Castellar", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BackButton.Location = New System.Drawing.Point(263, 120)
        Me.BackButton.Name = "BackButton"
        Me.BackButton.Size = New System.Drawing.Size(111, 34)
        Me.BackButton.TabIndex = 3
        Me.BackButton.Text = "Fechar"
        Me.BackButton.UseVisualStyleBackColor = True
        '
        'Timer1
        '
        Me.Timer1.Interval = 1
        '
        'Opcoes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlDark
        Me.ClientSize = New System.Drawing.Size(381, 162)
        Me.Controls.Add(Me.BackButton)
        Me.Controls.Add(Me.HScrollBar1)
        Me.Controls.Add(Me.Valor)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Opcoes"
        Me.Text = "Opcoes"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Valor As Label
    Friend WithEvents HScrollBar1 As HScrollBar
    Friend WithEvents BackButton As Button
    Friend WithEvents Timer1 As Timer
End Class
