using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestionnaire
{
    public class GestionnaireDeFichier
    {
        private Dossier dossierCourant;
        private List<ObservateurGestionnaireFichier> observateurs = new List<ObservateurGestionnaireFichier>();

        public void ajouterObservateur(ObservateurGestionnaireFichier observateur)
        {
            observateurs.Add(observateur);
        }
        public void retirerObservateur(ObservateurGestionnaireFichier observateur)
        {
            observateurs.Remove(observateur);
        }

        public void avertir(TypeChangement typeChangement, Element element)
        {
            foreach (ObservateurGestionnaireFichier observateur in observateurs)
            {
                observateur.changementSystemeFichier(typeChangement, element);
            }
        }

        public GestionnaireDeFichier(Dossier dossierCourant)
        {
            this.dossierCourant = dossierCourant;
        }

        public GestionnaireDeFichier() : this(Racine.getInstance())
        {
        }

        /// <summary>
        /// Retourne le dossier courant sur lequel pointe le gestionnaire
        /// </summary>
        /// <returns></returns>
        public Dossier getDossierCourant()
        {
            return dossierCourant;
        }

        public List<Element> getContenuDossierCourant()
        {
            return dossierCourant.getContenu();
        }

        public void monterVersDossierParent()
        {
            if (dossierCourant.DossierParent != null)
            {
                dossierCourant = dossierCourant.DossierParent;
            }
        }

        public void descendreDansDossierEnfant(Dossier dossierEnfant)
        {
            if (dossierCourant.getContenu().Contains(dossierEnfant))
            {
                dossierCourant = dossierEnfant;
            }
        }
        public void supprimerElement(Element element)
        {
            if (element.DossierParent != null)
            {
                element.DossierParent.retirerElement(element);
                element.DossierParent = null;
            }
        }

        public Fichier creerNouveauFichier()
        {
            Fichier nouveauFichier = new Fichier();
            dossierCourant.ajouterElement(nouveauFichier);
            return nouveauFichier;
        }

        public Dossier creeerNouveauDossier()
        {
            Dossier nouveauDossier = new Dossier();
            dossierCourant.ajouterElement(nouveauDossier);
            return nouveauDossier;
        }

        public Lien creeerNouveauLien(Referencable reference)
        {
            Lien nouveauLien = new Lien();
            nouveauLien.Reference = reference;
            dossierCourant.ajouterElement(nouveauLien);
            return nouveauLien;
        }

        public void deplacerElement(Element elementADeplacer, Dossier dossierDestination)
        {
            // retrait de l'éléement de son dossier actuel
            elementADeplacer.DossierParent.retirerElement(elementADeplacer);
            // Ajout dans le nouveau dossier
            dossierDestination.ajouterElement(elementADeplacer);
            elementADeplacer.DossierParent = dossierDestination;
        }
        public override string ToString()
        {
            return $"Le dossier courant est : {this.dossierCourant}"; 
        }
        
    }
}
