using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestionnaire
{
    public class Dossier : Element, Referencable
    {
        /// <summary>
        /// Elements contenus dans le dossier
        /// </summary>
        private List<Element> contenu;

        public Dossier() : this(null, null)
        {
        }

        public Dossier(string nom, Dossier? dossierParent) : base(nom, dossierParent)
        {
            contenu = new List<Element>();
        }


        public List<Element> getContenu()
        {
            return contenu;
        }

        public override int getTaille()
        {
            int taille = 0;
            foreach (Element element in contenu)
            {
                taille += element.getTaille();
            }
            return taille;
        }

        public void ajouterElement(Element e)
        {
            contenu.Add(e);
        }

        public void retirerElement(Element e)
        {
            contenu.Remove(e);
        }
        public override string ToString()
        {
            return $"Le dossier : {this.Nom}.";
        }
    }
}
