using Sport;

Contrat contrat = new Contrat(new DateTime(2024,02,19), new DateTime(2024,04,09));
Joueur joueur = new Joueur("Sylvain");
Equipe equipe = new Equipe("Stagiaire");

contrat.addJoueur(joueur);
contrat.addEquipe(equipe);
Console.WriteLine(contrat.ToString());
