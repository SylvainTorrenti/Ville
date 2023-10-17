using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestionnaire
{
    public class Racine : Dossier
    {
        private static Racine? instance;

        public static Racine getInstance()
        {
            if (instance == null)
            {
                instance = new Racine();
            }
            return instance;
        }


        private string typeSystemeFichier;
        public string TypeSystemeFichier { get => typeSystemeFichier; set => typeSystemeFichier = value; }

        override public string Nom { get => nom; set => nom = "/"; }

        private Racine() : base("/", null)
        {
            this.typeSystemeFichier = "ZZ_FS";
        }
        public override string ToString()
        {
            return this.nom;
        }
    }
}
