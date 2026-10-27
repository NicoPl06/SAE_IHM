# Memory : jeu solo en VB.NET

Projet de SAÉ IHM (BUT Informatique, IUT de Paris - Rives de Seine) : une variante solo du jeu Memory, avec suivi statistique des joueurs et sauvegarde entre les sessions.

## Règles du jeu

Le joueur doit retrouver le plus de « carrés » possible, c'est-à-dire des groupes de 4 cartes identiques, en moins de **60 secondes**. La grille contient 20 cartes (4 × 5), soit 5 carrés à trouver.

## Fonctionnalités

- **Accueil** : saisie ou choix du nom du joueur (3 caractères minimum), nouvelle partie, statistiques, réglages, quitter avec confirmation.
- **Jeu** : chronomètre dynamique, pause, abandon avec confirmation, vérification des paires, affichage des résultats en fin de partie.
- **5 plateaux (maps)** : cinq dispositions de cartes différentes, à choisir dans les réglages pour varier la difficulté.
- **Statistiques** : meilleur score, meilleur temps, nombre de parties, temps cumulé. Tri croissant / décroissant, recherche par nom, suppression d'un joueur.
- **Sauvegarde** : les données des joueurs sont enregistrées dans `joueurs.txt` et rechargées au lancement.
- **Direction artistique** : pixel art rétro, cartes redessinées, fond animé sur la page d'accueil.

## Technologies

- VB.NET, Windows Forms (8 formulaires)
- Bibliothèque MaterialSkin
- Fichier texte pour la persistance

## Format des données

Chaque joueur est une ligne de `joueurs.txt` :

```
Prenom;MeilleurTemps;NbPartie;TempsJoue;nbCarte
```

Les données sont gérées par le module `EnregistrementJoueur` (structure `Joueur`, tableau dynamique, fonctions d'ajout, de mise à jour, de sauvegarde, de chargement et de suppression).

## Lancer le projet

Prérequis : Windows et Visual Studio ([À compléter : version de Visual Studio et du .NET Framework]).

1. Cloner le dépôt : `git clone [À compléter : URL du dépôt]`
2. Ouvrir la solution (`.sln`) dans Visual Studio.
3. Restaurer les paquets NuGet (MaterialSkin).
4. Lancer avec F5.

## Équipe

Projet réalisé à 3 :

- Nicolas Plaisance : [À compléter : formulaires dont tu t'es occupé]
- Mateo R.
- Moussa W.

## Limites et pistes d'amélioration

- Pas de son : une musique d'ambiance et des effets ont été tentés, mais abandonnés faute de temps.
- Niveaux de difficulté personnalisables (12, 20 ou 24 cartes) avec un temps adapté.
- Animation de retournement des cartes.
- Mode 1 contre 1 au tour par tour.
- Couleurs de cartes adaptées à l'accessibilité (daltonisme).
- Factoriser le code des 5 formulaires de jeu, qui répètent la même logique.
