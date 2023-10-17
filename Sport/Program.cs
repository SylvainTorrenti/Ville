using Sport;

#region Création pour le test
Contrat contrat = new Contrat(new DateTime(2024, 02, 19), new DateTime(2024, 04, 09));
Joueur joueur = new Joueur("Sylvain");
Equipe equipe = new Equipe("Stagiaire");
#endregion
#region Test des méthode
contrat.addJoueur(joueur);
contrat.addEquipe(equipe);
Console.WriteLine(contrat.ToString());
Console.WriteLine("-----------------");
contrat.removeJoueur(joueur);
contrat.removeEquipe(equipe);
Console.WriteLine(contrat.ToString()); 
#endregion
