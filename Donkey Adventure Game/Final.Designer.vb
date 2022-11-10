<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Final
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
        Me.NomeArma = New System.Windows.Forms.Label()
        Me.Time = New System.Windows.Forms.Label()
        Me.Per = New System.Windows.Forms.Label()
        Me.EA = New System.Windows.Forms.Label()
        Me.TipoFinal = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Consolas", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(25, 21)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(140, 22)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Ficha tecnica"
        '
        'NomeArma
        '
        Me.NomeArma.AutoSize = True
        Me.NomeArma.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NomeArma.Location = New System.Drawing.Point(26, 67)
        Me.NomeArma.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.NomeArma.Name = "NomeArma"
        Me.NomeArma.Size = New System.Drawing.Size(49, 16)
        Me.NomeArma.TabIndex = 1
        Me.NomeArma.Text = "Label2"
        '
        'Time
        '
        Me.Time.AutoSize = True
        Me.Time.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Time.Location = New System.Drawing.Point(26, 87)
        Me.Time.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Time.Name = "Time"
        Me.Time.Size = New System.Drawing.Size(49, 16)
        Me.Time.TabIndex = 2
        Me.Time.Text = "Label3"
        '
        'Per
        '
        Me.Per.AutoSize = True
        Me.Per.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Per.Location = New System.Drawing.Point(26, 107)
        Me.Per.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Per.Name = "Per"
        Me.Per.Size = New System.Drawing.Size(49, 16)
        Me.Per.TabIndex = 3
        Me.Per.Text = "Label4"
        '
        'EA
        '
        Me.EA.AutoSize = True
        Me.EA.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EA.Location = New System.Drawing.Point(26, 127)
        Me.EA.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.EA.Name = "EA"
        Me.EA.Size = New System.Drawing.Size(49, 16)
        Me.EA.TabIndex = 4
        Me.EA.Text = "Label5"
        '
        'TipoFinal
        '
        Me.TipoFinal.AutoSize = True
        Me.TipoFinal.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TipoFinal.Location = New System.Drawing.Point(26, 146)
        Me.TipoFinal.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.TipoFinal.Name = "TipoFinal"
        Me.TipoFinal.Size = New System.Drawing.Size(49, 16)
        Me.TipoFinal.TabIndex = 5
        Me.TipoFinal.Text = "Label6"
        '
        'Button1
        '
        Me.Button1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button1.Font = New System.Drawing.Font("Castellar", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Button1.Location = New System.Drawing.Point(347, 236)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(140, 42)
        Me.Button1.TabIndex = 6
        Me.Button1.Text = "Terminar"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Final
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Peru
        Me.ClientSize = New System.Drawing.Size(499, 290)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.TipoFinal)
        Me.Controls.Add(Me.EA)
        Me.Controls.Add(Me.Per)
        Me.Controls.Add(Me.Time)
        Me.Controls.Add(Me.NomeArma)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "Final"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Final"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents NomeArma As Label
    Friend WithEvents Time As Label
    Friend WithEvents Per As Label
    Friend WithEvents EA As Label
    Friend WithEvents TipoFinal As Label
    Friend WithEvents Button1 As Button
End Class
