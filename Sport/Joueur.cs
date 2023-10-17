using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sport
{
    public class Joueur
    {
        private string? nom { get; set; }
        private DateTime? dateNaissance { get; set; }
        private Contrat? contrat { get; set; }
        /// <summary>
        /// Constructeur du joueur
        /// </summary>
        /// <param name="nom"></param>
        public Joueur(string nom)
        {
            this.nom = nom;
        }
        /// <summary>
        /// Redefinition de la méthode ToString() pour l'utiliser dans d'autre méthode
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return this.nom;
        }
    }
}
