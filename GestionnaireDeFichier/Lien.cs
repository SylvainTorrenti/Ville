using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestionnaire
{
    public class Lien : Element
    {
        private Referencable reference;

        public Referencable Reference { get => reference; set => reference = value; }

        public override int getTaille()
        {
            return 0;
        }
    }
}
