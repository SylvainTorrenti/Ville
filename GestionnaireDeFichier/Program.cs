//using Gestionnaire;

//GestionnaireDeFichier gestionnaireDeFichier = new GestionnaireDeFichier();
//// AJout de l'observateur
//gestionnaireDeFichier.ajouterObservateur(new ObservateurQuiEcritDansConsole());
//gestionnaireDeFichier.ajouterObservateur(new ObservateurQuiEcritDansConsole());
//gestionnaireDeFichier.ajouterObservateur(new ObservateurQuiEcritDansConsole());
//gestionnaireDeFichier.ajouterObservateur(new ObservateurQuiEcritDansConsole());

//gestionnaireDeFichier.creeerNouveauDossier().Nom = "Mon Dossier";
//gestionnaireDeFichier.creerNouveauFichier().Nom = "Mon Fichier";

//Console.WriteLine(gestionnaireDeFichier.ToString());
//Console.WriteLine("Il y à dans le dossier : ");
//foreach (Element element in gestionnaireDeFichier.getContenuDossierCourant())
//{
//    Console.WriteLine(element.Nom);
//}

// Création du gestionnaire
using Gestionnaire;

GestionnaireDeFichier gestionnaireDeFichier = new GestionnaireDeFichier();


// AJout de l'observateur
gestionnaireDeFichier.ajouterObservateur(new ObservateurQuiEcritDansConsole());
gestionnaireDeFichier.ajouterObservateur(new ObservateurQuiEcritDansConsole());
gestionnaireDeFichier.ajouterObservateur(new ObservateurQuiEcritDansConsole());
gestionnaireDeFichier.ajouterObservateur(new ObservateurQuiEcritDansConsole());


gestionnaireDeFichier.creerNouveauFichier().Nom = "le fichier";
Dossier dossier1 = gestionnaireDeFichier.creeerNouveauDossier();
dossier1.Nom = "dossier_1";
Console.WriteLine("----");
foreach (Element element in gestionnaireDeFichier.getContenuDossierCourant())
{
    Console.WriteLine(element.Nom);
}
gestionnaireDeFichier.descendreDansDossierEnfant(dossier1);
Console.WriteLine("----");
foreach (Element element in gestionnaireDeFichier.getContenuDossierCourant())
{
    Console.WriteLine(element.Nom);
}

gestionnaireDeFichier.creerNouveauFichier().Nom = "le fichier 2";
Console.WriteLine("----");
foreach (Element element in gestionnaireDeFichier.getContenuDossierCourant())
{
    Console.WriteLine(element.Nom);
}

Dossier dossier2 = gestionnaireDeFichier.creeerNouveauDossier();
dossier2.Nom = "dossier_2";
gestionnaireDeFichier.descendreDansDossierEnfant(dossier2);
gestionnaireDeFichier.creerNouveauFichier().Nom = "un autre fichier ";
gestionnaireDeFichier.creeerNouveauLien(dossier1).Nom = "Racourci vers D1";

Console.WriteLine("");
Console.WriteLine("");
Console.WriteLine("");
Console.WriteLine(Racine.getInstance().ToString());

