using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestionnaire
{
    /// <summary>
    /// INterface des éléments référençable par un lien
    /// </summary>
    public interface Referencable
    {

    }
    /// <summary>
    /// Classe Element (tout élément du système de fichier)
    /// </summary>
    public abstract class Element
    {
        // nom de l'élément
        protected string? nom;

        // dossier parent
        private Dossier? dossierParent;

        public virtual string Nom { get => nom; set => nom = value; }
        public Dossier? DossierParent { get => dossierParent; set => dossierParent = value; }

        protected Element()
        {
        }
        protected Element(string nom, Dossier? dossierParent)
        {
            this.nom = nom;
            this.dossierParent = dossierParent;
        }

        // Méthode pour obteir la taille de l'élément
        public abstract int getTaille();
    }
}
