using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ville
{
    /// <summary>
    /// Interface pour rendre possible de devenir une capitale
    /// </summary>
    public interface Capitalisable
    {
        bool estCapital();
        void devenirCapitale();
        void nePlusDevenirCapitale();
    }
}
