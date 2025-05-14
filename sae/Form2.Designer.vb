<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class jeu
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
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

    'Requise par le Concepteur Windows Form
    Private components As System.ComponentModel.IContainer

    'REMARQUE : la procédure suivante est requise par le Concepteur Windows Form
    'Elle peut être modifiée à l'aide du Concepteur Windows Form.  
    'Ne la modifiez pas à l'aide de l'éditeur de code.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.btnAband = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnAband
        '
        Me.btnAband.Location = New System.Drawing.Point(327, 203)
        Me.btnAband.Name = "btnAband"
        Me.btnAband.Size = New System.Drawing.Size(193, 44)
        Me.btnAband.TabIndex = 5
        Me.btnAband.Text = "Abandonner la partir"
        Me.btnAband.UseVisualStyleBackColor = True
        '
        'jeu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btnAband)
        Me.Name = "jeu"
        Me.Text = "Jeu"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnAband As Button
End Class
