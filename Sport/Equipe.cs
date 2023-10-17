using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sport
{
    public class Equipe
    {
        private string? nom { get; set; }
        private Contrat? contrat { get; set; }
        /// <summary>
        /// Constructeur d'une équipe
        /// </summary>
        /// <param name="nom">Le nom de l'équipe</param>
        public Equipe(string nom)
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
