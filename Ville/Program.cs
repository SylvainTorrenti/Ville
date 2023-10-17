using Ville;
#region Création du jeu de test
//Creation du pays
Pays pays1 = new Pays("France");
//Creation de la ville
City ville1 = new City("Paris", 1500000, pays1);
#endregion
#region Test des méthode
ville1.devenirCapitale();
Console.WriteLine(ville1.ToString());
Console.WriteLine("------------------------------");
ville1.nePlusDevenirCapitale();
Console.WriteLine(ville1.ToString()); 
#endregion

