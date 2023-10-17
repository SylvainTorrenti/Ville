using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ville
{
    internal class Pays
    {
        private string? nom { get; set; }
        private List<City> villes = new List<City>();
        /// <summary>
        /// Constructeur de Pays
        /// </summary>
        /// <param name="nom"></param>
        public Pays(string nom)
        {
            this.nom = nom;
        }
        /// <summary>
        /// Redefinition de la méthode ToString()
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return this.nom;
        }
    }
}
