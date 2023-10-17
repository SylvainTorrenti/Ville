using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestionnaire
{
    public class ObservateurQuiEcritDansConsole : ObservateurGestionnaireFichier
    {
        public void changementSystemeFichier(TypeChangement typeChangement, Element element)
        {
            Console.WriteLine($"**** {typeChangement.ToString()} {element.ToString()} ***");
        }
    }
}
