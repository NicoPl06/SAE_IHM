Imports System.Reflection
Imports MaterialSkin

Module EnregistrementJoueur
    Public Structure Joueur
        Dim Prenom As String
        Dim MeilleurTemps As Integer
        Dim NbPartie As Integer
        Dim TempsJoue As Integer
    End Structure

    Private tabJoueur() As Joueur = New Joueur(9) {} ' Initialisation du tableau avec une taille initiale de 10
    Private nbJoueur As Integer = 0

    ' Ajoute un joueur au tableau
    Public Sub ajout(j As Joueur)
        Debug.Assert(Trim(j.Prenom) <> "")

        ' Augmenter la capacité du tableau si nécessaire
        If nbJoueur >= tabJoueur.Length Then
            ReDim Preserve tabJoueur(tabJoueur.Length * 2 - 1) ' Double la taille du tableau
        End If

        tabJoueur(nbJoueur) = j
        nbJoueur += 1
    End Sub

    ' Récupère un joueur par son index
    Public Function getPers(i As Integer) As Joueur
        Debug.Assert(i >= 0 And i < nbJoueur)
        Return tabJoueur(i)
    End Function

    ' Récupère un joueur par son prénom
    Public Function getPersPrenom(prenom As String) As Joueur?
        For i As Integer = 0 To nbJoueur - 1
            If tabJoueur(i).Prenom = prenom Then
                Return getPers(i)
            End If
        Next
        Return Nothing
    End Function

    ' Retourne le nombre total de joueurs
    Public Function getNbPers() As Integer
        Return nbJoueur
    End Function

    ' Vérifie si un prénom existe déjà dans le tableau
    Public Function Existe(prenom As String) As Boolean
        For i As Integer = 0 To nbJoueur - 1
            If tabJoueur(i).Prenom = prenom Then Return True
        Next
        Return False
    End Function

    ' Modifie le temps joué d'un joueur
    Public Sub setTempsJoue(index As Integer, temps As Integer)
        Debug.Assert(index >= 0 And index < nbJoueur)
        tabJoueur(index).TempsJoue += temps
    End Sub

    ' Met à jour le meilleur temps d'un joueur
    Public Sub setMeilleurTemps(index As Integer, temps As Integer)
        Debug.Assert(index >= 0 And index < nbJoueur)
        If tabJoueur(index).MeilleurTemps = 0 OrElse temps < tabJoueur(index).MeilleurTemps Then
            tabJoueur(index).MeilleurTemps = temps
        End If
    End Sub

    ' Incrémente le nombre de parties jouées par un joueur
    Public Sub incrementNbPartie(index As Integer)
        Debug.Assert(index >= 0 And index < nbJoueur)
        tabJoueur(index).NbPartie += 1
    End Sub

    Public Sub setModeClair(form As Form)
        Dim SkinManager As MaterialSkinManager = MaterialSkinManager.Instance
        SkinManager.AddFormToManage(form)
        SkinManager.Theme = MaterialSkinManager.Themes.LIGHT
        SkinManager.ColorScheme = New ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE)
    End Sub

    Public Sub setModeDark(form As Form)
        Dim SkinManager As MaterialSkinManager = MaterialSkinManager.Instance
        SkinManager.AddFormToManage(form)
        SkinManager.Theme = MaterialSkinManager.Themes.DARK
        SkinManager.ColorScheme = New ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE)
    End Sub

End Module
