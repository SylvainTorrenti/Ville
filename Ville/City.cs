using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ville
{
    internal class City : Capitalisable
    {
        private string? nom { get; set; }
        private double? population { get; set; }
        private bool estCapitale;
        private Pays? pays { get; set; }
        public City(string nom, double pop, Pays pays)
        {
            this.nom = nom;
            this.population = pop;
            this.pays = pays;
        }
        public bool estCapital()
        {
            return estCapitale;
        }
        public override string ToString()
        {
            return $@"Le nom de la ville est : {this.nom} 
Sa population est de : {this.population}  
Son pays est : {this.pays}
Elle est la capitale : {this.estCapital}";
        }
        public void devenirCapitale()
        {
            this.estCapitale = true;
        }

        public void nePlusDevenirCapitale()
        {
            this.estCapitale = false;
        }
    }
}
