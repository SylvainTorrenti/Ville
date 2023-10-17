using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestionnaire
{
    public enum TypeChangement
    {
        CREATION,
        SUPPRESSION,
        AVANT_DEPLACEMENT,
        APRES_DEPLACEMENT,
    }

    /// <summary>
    /// 
    /// </summary>
    public interface ObservateurGestionnaireFichier
    {
        public void changementSystemeFichier(TypeChangement typeChangement, Element element);
    }
}
