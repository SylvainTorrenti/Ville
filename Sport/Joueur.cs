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

        public Joueur(string nom)
        {
            this.nom = nom;
        }
        public override string ToString()
        {
            return this.nom;
        }
    }
}
