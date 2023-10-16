using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sport
{
    public class Contrat
    {
        static int id = 0;
        private int? idContrat { get; set; }
        private DateTime? dateDebut { get; set; }
        private DateTime? dateFin { get; set; }
        private Joueur? joueur { get; set; }
        private Equipe? equipe { get; set; }

        public Contrat(DateTime dateDebut,DateTime dateFin)
        {
            id++;
            this.idContrat = id;
            this.dateDebut = dateDebut;
            this.dateFin = dateFin;
        }
        public override string ToString()
        {
            return $@"Le contrat à pour ID : {this.idContrat}
Il début le {this.dateDebut} et finit le {this.dateFin}
Il concerne {this.joueur} dans {this.equipe}";
        }
        public void addJoueur(Joueur joueur)
        {
            this.joueur = joueur;
        }
        public void addEquipe(Equipe equipe)
        {
            this.equipe = equipe;
        }

    }
}
