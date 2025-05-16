<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class stat
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
        Me.btnRetour = New System.Windows.Forms.Button()
        Me.ListBoxNom = New System.Windows.Forms.ListBox()
        Me.ListBoxNbcarte = New System.Windows.Forms.ListBox()
        Me.ListBoxtemps = New System.Windows.Forms.ListBox()
        Me.ListBoxNbpartie = New System.Windows.Forms.ListBox()
        Me.ListBoxCumul = New System.Windows.Forms.ListBox()
        Me.CmBoxJ = New System.Windows.Forms.ComboBox()
        Me.BtnVal = New System.Windows.Forms.Button()
        Me.BtnTri = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnRetour
        '
        Me.btnRetour.Location = New System.Drawing.Point(231, 383)
        Me.btnRetour.Margin = New System.Windows.Forms.Padding(2)
        Me.btnRetour.Name = "btnRetour"
        Me.btnRetour.Size = New System.Drawing.Size(145, 36)
        Me.btnRetour.TabIndex = 7
        Me.btnRetour.Text = "Retour"
        Me.btnRetour.UseVisualStyleBackColor = True
        '
        'ListBoxNom
        '
        Me.ListBoxNom.FormattingEnabled = True
        Me.ListBoxNom.Location = New System.Drawing.Point(54, 136)
        Me.ListBoxNom.Name = "ListBoxNom"
        Me.ListBoxNom.Size = New System.Drawing.Size(120, 95)
        Me.ListBoxNom.TabIndex = 8
        '
        'ListBoxNbcarte
        '
        Me.ListBoxNbcarte.FormattingEnabled = True
        Me.ListBoxNbcarte.Location = New System.Drawing.Point(231, 136)
        Me.ListBoxNbcarte.Name = "ListBoxNbcarte"
        Me.ListBoxNbcarte.Size = New System.Drawing.Size(120, 95)
        Me.ListBoxNbcarte.TabIndex = 9
        '
        'ListBoxtemps
        '
        Me.ListBoxtemps.FormattingEnabled = True
        Me.ListBoxtemps.Location = New System.Drawing.Point(401, 136)
        Me.ListBoxtemps.Name = "ListBoxtemps"
        Me.ListBoxtemps.Size = New System.Drawing.Size(120, 95)
        Me.ListBoxtemps.TabIndex = 10
        '
        'ListBoxNbpartie
        '
        Me.ListBoxNbpartie.FormattingEnabled = True
        Me.ListBoxNbpartie.Location = New System.Drawing.Point(584, 136)
        Me.ListBoxNbpartie.Name = "ListBoxNbpartie"
        Me.ListBoxNbpartie.Size = New System.Drawing.Size(120, 95)
        Me.ListBoxNbpartie.TabIndex = 11
        '
        'ListBoxCumul
        '
        Me.ListBoxCumul.FormattingEnabled = True
        Me.ListBoxCumul.Location = New System.Drawing.Point(759, 136)
        Me.ListBoxCumul.Name = "ListBoxCumul"
        Me.ListBoxCumul.Size = New System.Drawing.Size(120, 95)
        Me.ListBoxCumul.TabIndex = 12
        '
        'CmBoxJ
        '
        Me.CmBoxJ.FormattingEnabled = True
        Me.CmBoxJ.Location = New System.Drawing.Point(324, 299)
        Me.CmBoxJ.Name = "CmBoxJ"
        Me.CmBoxJ.Size = New System.Drawing.Size(134, 21)
        Me.CmBoxJ.TabIndex = 13
        '
        'BtnVal
        '
        Me.BtnVal.Location = New System.Drawing.Point(485, 299)
        Me.BtnVal.Name = "BtnVal"
        Me.BtnVal.Size = New System.Drawing.Size(104, 23)
        Me.BtnVal.TabIndex = 14
        Me.BtnVal.Text = "Validation cmbox"
        Me.BtnVal.UseVisualStyleBackColor = True
        '
        'BtnTri
        '
        Me.BtnTri.Location = New System.Drawing.Point(485, 338)
        Me.BtnTri.Name = "BtnTri"
        Me.BtnTri.Size = New System.Drawing.Size(75, 23)
        Me.BtnTri.TabIndex = 15
        Me.BtnTri.Text = "Tri"
        Me.BtnTri.UseVisualStyleBackColor = True
        '
        'stat
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(903, 583)
        Me.Controls.Add(Me.BtnTri)
        Me.Controls.Add(Me.BtnVal)
        Me.Controls.Add(Me.CmBoxJ)
        Me.Controls.Add(Me.ListBoxCumul)
        Me.Controls.Add(Me.ListBoxNbpartie)
        Me.Controls.Add(Me.ListBoxtemps)
        Me.Controls.Add(Me.ListBoxNbcarte)
        Me.Controls.Add(Me.ListBoxNom)
        Me.Controls.Add(Me.btnRetour)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "stat"
        Me.Text = "Stat"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnRetour As Button
    Friend WithEvents ListBoxNom As ListBox
    Friend WithEvents ListBoxNbcarte As ListBox
    Friend WithEvents ListBoxtemps As ListBox
    Friend WithEvents ListBoxNbpartie As ListBox
    Friend WithEvents ListBoxCumul As ListBox
    Friend WithEvents CmBoxJ As ComboBox
    Friend WithEvents BtnVal As Button
    Friend WithEvents BtnTri As Button
End Class
