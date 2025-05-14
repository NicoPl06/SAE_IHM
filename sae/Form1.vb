Public Class accueil

    Private Sub btnPartie_Click(sender As Object, e As EventArgs) Handles btnPartie.Click
        If (Trim(cmbNom.Text) <> "") AndAlso Trim(cmbNom.Text).Length >= 3 Then
            Dim J As New Joueur
            With J
                .Prenom = cmbNom.Text
                .NbPartie = 0
                .MeilleurTemps = 0
                .TempsJoue = 0
            End With
            If Not EnregistrementJoueur.Existe(J.Prenom) AndAlso Not String.IsNullOrEmpty(J.Prenom) Then
                EnregistrementJoueur.ajout(J)
                cmbNom.Items.Add(J.Prenom)
            End If
            jeu.Show()
            Me.Hide()
            cmbNom.Text = String.Empty
        Else
            MsgBox("Veuillez saisir un nom d'au moins 3 caractères", MsgBoxStyle.OkOnly, "Erreur Prénom")
        End If

    End Sub

    Private Sub btnReglage_Click(sender As Object, e As EventArgs) Handles btnReglage.Click
        Me.Hide()
        reglage.Show()
    End Sub

    Private Sub btnStat_Click(sender As Object, e As EventArgs) Handles btnStat.Click
        Me.Hide()
        reglage.Show()
    End Sub

    Private Sub btnQuitter_Click(sender As Object, e As EventArgs) Handles btnQuitter.Click
        Dim rep As MsgBoxResult
        rep = MsgBox("Voulez vous quitter le jeu ?", vbYesNo, "Fermer le jeu")
        If rep = MsgBoxResult.Yes Then
            Application.Exit()
        End If
    End Sub
End Class
