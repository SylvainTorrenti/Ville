using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ville
{
    /// <summary>
    /// A l'interface Capitalisable
    /// </summary>
    internal class City : Capitalisable
    {
        private string? nom { get; set; }
        private double? population { get; set; }
        private bool estCapitale;
        private Pays? pays { get; set; }
        /// <summary>
        /// Constructeur de la ville
        /// </summary>
        /// <param name="nom"></param>
        /// <param name="pop"></param>
        /// <param name="pays"></param>
        public City(string nom, double pop, Pays pays)
        {
            this.nom = nom;
            this.population = pop;
            this.pays = pays;
        }
        /// <summary>
        /// Verifie si la ville est capitale
        /// </summary>
        /// <returns></returns>
        public bool estCapital()
        {
            return estCapitale;
        }
        /// <summary>
        /// Redefinition de la méthode ToString()
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return $@"Le nom de la ville est : {this.nom} 
Sa population est de : {this.population}  
Son pays est : {this.pays}
Elle est la capitale : {this.estCapital}";
        }
        /// <summary>
        /// Rend la ville capitale
        /// </summary>
        public void devenirCapitale()
        {
            this.estCapitale = true;
        }
        /// <summary>
        /// Rend la ville non-capitale
        /// </summary>
        public void nePlusDevenirCapitale()
        {
            this.estCapitale = false;
        }
    }
}
