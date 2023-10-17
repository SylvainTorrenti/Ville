using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestionnaire
{
    /// <summary>
    /// Classe Fichier
    /// </summary>
    public class Fichier : Element, Referencable
    {
        private int taille = 0;

        public int Taille { set => taille = value; }

        public Fichier()
        {
        }

        public override int getTaille()
        {
            return taille;
        }
        public override string ToString()
        {
            return $"Le fichier : {this.Nom}.";
        }
    }
}
