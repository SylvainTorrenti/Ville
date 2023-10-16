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

        public Equipe(string nom)
        {
            this.nom = nom;
        }
        public override string ToString()
        {
            return this.nom;
        }
    }
}
