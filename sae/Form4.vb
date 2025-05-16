Public Class stat

    Dim tn() As String = {"daubisse", "dambrot", "lamarche", "sabatier", "saporta", "dureux", "cosnefroy", "cavy", "pavel", "pradeilles"}
    Dim tp() As String = {"catherine", "annette", "jean", "roland", "gilbert", "jacques", "francoise", "mireille", "monique", "anne"}
    
    Dim tc() As String = {"lens", "paris", "lyon", "lens", "rennes", "rennes", "lens", "nimes",
    "lens", "lyon"}

    Private Sub btnRetour_Click(sender As Object, e As EventArgs) Handles btnRetour.Click
        Me.Hide()
        accueil.Show()
    End Sub

    Private players As New List(Of Joueur)

    ' Variable pour gérer l'ordre du tri
    Dim ascendingOrder As Boolean = True ' Par défaut, tri croissant

    Private Sub stat_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadPlayers()

        ' Ajouter les joueurs dans la ListBox et la ComboBox
        UpdateListBoxes()
        CmBoxJ.Items.Clear()
        For Each joueur As Joueur In players
            CmBoxJ.Items.Add(joueur.Prenom)
        Next
    End Sub



    Private Sub ListBoxNom_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBoxNom.SelectedIndexChanged
        ListBoxNbpartie.SelectedIndex = ListBoxNom.SelectedIndex
        ListBoxCumul.SelectedIndex = ListBoxNom.SelectedIndex
        ListBoxNbcarte.SelectedIndex = ListBoxNom.SelectedIndex
        ListBoxtemps.SelectedIndex = ListBoxNom.SelectedIndex
        CmBoxJ.Text = ListBoxNom.Text
    End Sub

    Private Sub ListBoxNbcarte_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBoxNbcarte.SelectedIndexChanged
        ListBoxNom.SelectedIndex = ListBoxNbcarte.SelectedIndex
        ListBoxNbpartie.SelectedIndex = ListBoxNbcarte.SelectedIndex
        ListBoxCumul.SelectedIndex = ListBoxNbcarte.SelectedIndex
        ListBoxtemps.SelectedIndex = ListBoxNbcarte.SelectedIndex
    End Sub

    Private Sub ListBoxtemps_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBoxtemps.SelectedIndexChanged
        ListBoxNom.SelectedIndex = ListBoxtemps.SelectedIndex
        ListBoxNbpartie.SelectedIndex = ListBoxtemps.SelectedIndex
        ListBoxCumul.SelectedIndex = ListBoxtemps.SelectedIndex
        ListBoxNbcarte.SelectedIndex = ListBoxtemps.SelectedIndex
    End Sub

    Private Sub ListBoxNbpartie_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBoxNbpartie.SelectedIndexChanged
        ListBoxNom.SelectedIndex = ListBoxNbpartie.SelectedIndex
        ListBoxNbcarte.SelectedIndex = ListBoxNbpartie.SelectedIndex
        ListBoxCumul.SelectedIndex = ListBoxNbpartie.SelectedIndex
        ListBoxtemps.SelectedIndex = ListBoxNbpartie.SelectedIndex
    End Sub

    Private Sub ListBoxCumul_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBoxCumul.SelectedIndexChanged
        ListBoxNom.SelectedIndex = ListBoxCumul.SelectedIndex
        ListBoxNbpartie.SelectedIndex = ListBoxCumul.SelectedIndex
        ListBoxNbcarte.SelectedIndex = ListBoxCumul.SelectedIndex
        ListBoxtemps.SelectedIndex = ListBoxCumul.SelectedIndex
    End Sub

    'Private Sub ListBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBoxNom.SelectedIndexChanged, ListBoxNbcarte.SelectedIndexChanged, ListBoxCumul.SelectedIndexChanged, ListBoxtemps.SelectedIndexChanged, ListBoxNbpartie.SelectedIndexChanged
    'Dim selectedIndex As Integer = ListBoxNom.SelectedIndex
    'If selectedIndex >= 0 Then
    '   ListBoxNbpartie.SelectedIndex = selectedIndex
    '   ListBoxCumul.SelectedIndex = selectedIndex
    '   ListBoxNbcarte.SelectedIndex = selectedIndex
    '   ListBoxtemps.SelectedIndex = selectedIndex
    '   CmBoxJ.Text = ListBoxNom.Text
    ' If
    'End Sub

    Private Sub LoadPlayers()
        players.Clear() ' Réinitialiser la liste des joueurs

        ' Charger les joueurs du module
        For i As Integer = 0 To EnregistrementJoueur.getNbPers() - 1
            Dim j As Joueur = EnregistrementJoueur.getPers(i)
            players.Add(j)
        Next
    End Sub

    Private Sub UpdateListBoxes()
        ' Trier la liste en fonction de l'ordre (nombre de parties, puis meilleur temps)
        If ascendingOrder Then
            players.Sort(Function(a, b) a.NbPartie.CompareTo(b.NbPartie))
        Else
            players.Sort(Function(a, b) b.NbPartie.CompareTo(a.NbPartie))
        End If

        ' Mettre à jour les ListBox
        ListBoxNom.Items.Clear()
        ListBoxNbcarte.Items.Clear()
        ListBoxCumul.Items.Clear()
        ListBoxtemps.Items.Clear()
        ListBoxNbpartie.Items.Clear()

        For Each player In players
            ListBoxNom.Items.Add(player.Prenom)
            ListBoxNbcarte.Items.Add(player.MeilleurTemps) ' Affiche le meilleur temps
            ListBoxCumul.Items.Add(player.TempsJoue) ' Affiche le temps total joué
            ListBoxtemps.Items.Add(player.MeilleurTemps) ' Affiche le meilleur temps
            ListBoxNbpartie.Items.Add(player.NbPartie) ' Affiche le nombre de parties
        Next
    End Sub

    Private Sub BtnTri_Click(sender As Object, e As EventArgs) Handles BtnTri.Click
        ascendingOrder = Not ascendingOrder
        UpdateListBoxes()
    End Sub

    'Private Sub CmBoxJ_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CmBoxJ.SelectedIndexChanged
    'Dim selectedPlayerName As String = CmBoxJ.SelectedItem.ToString()
    'Dim player = players.FirstOrDefault(Function(p) p.Item1 = selectedPlayerName)

    'If player IsNot Nothing Then
    '     MsgBox("Nom: " & player.Item1 & vbCrLf & "Nombre de cartes: " & player.Item2 & vbCrLf & "Temps: " & player.Item3 & " secondes")
    'End If
    'End Sub
End Class