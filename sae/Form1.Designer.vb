<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class accueil
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
        Me.cmbNom = New System.Windows.Forms.ComboBox()
        Me.btnReglage = New System.Windows.Forms.Button()
        Me.btnPartie = New System.Windows.Forms.Button()
        Me.btnStat = New System.Windows.Forms.Button()
        Me.btnQuitter = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'cmbNom
        '
        Me.cmbNom.FormattingEnabled = True
        Me.cmbNom.Location = New System.Drawing.Point(218, 106)
        Me.cmbNom.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.cmbNom.Name = "cmbNom"
        Me.cmbNom.Size = New System.Drawing.Size(92, 21)
        Me.cmbNom.TabIndex = 0
        '
        'btnReglage
        '
        Me.btnReglage.Location = New System.Drawing.Point(59, 232)
        Me.btnReglage.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnReglage.Name = "btnReglage"
        Me.btnReglage.Size = New System.Drawing.Size(110, 36)
        Me.btnReglage.TabIndex = 1
        Me.btnReglage.Text = "Règlage"
        Me.btnReglage.UseVisualStyleBackColor = True
        '
        'btnPartie
        '
        Me.btnPartie.Location = New System.Drawing.Point(241, 232)
        Me.btnPartie.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnPartie.Name = "btnPartie"
        Me.btnPartie.Size = New System.Drawing.Size(110, 36)
        Me.btnPartie.TabIndex = 2
        Me.btnPartie.Text = "Nouvelle Partie"
        Me.btnPartie.UseVisualStyleBackColor = True
        '
        'btnStat
        '
        Me.btnStat.Location = New System.Drawing.Point(398, 232)
        Me.btnStat.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnStat.Name = "btnStat"
        Me.btnStat.Size = New System.Drawing.Size(110, 36)
        Me.btnStat.TabIndex = 3
        Me.btnStat.Text = "Afficher le(s) score(s)"
        Me.btnStat.UseVisualStyleBackColor = True
        '
        'btnQuitter
        '
        Me.btnQuitter.Location = New System.Drawing.Point(241, 297)
        Me.btnQuitter.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnQuitter.Name = "btnQuitter"
        Me.btnQuitter.Size = New System.Drawing.Size(110, 36)
        Me.btnQuitter.TabIndex = 4
        Me.btnQuitter.Text = "Quitter"
        Me.btnQuitter.UseVisualStyleBackColor = True
        '
        'accueil
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(600, 366)
        Me.Controls.Add(Me.btnQuitter)
        Me.Controls.Add(Me.btnStat)
        Me.Controls.Add(Me.btnPartie)
        Me.Controls.Add(Me.btnReglage)
        Me.Controls.Add(Me.cmbNom)
        Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Name = "accueil"
        Me.Text = "Accueil"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents cmbNom As ComboBox
    Friend WithEvents btnReglage As Button
    Friend WithEvents btnPartie As Button
    Friend WithEvents btnStat As Button
    Friend WithEvents btnQuitter As Button
End Class
