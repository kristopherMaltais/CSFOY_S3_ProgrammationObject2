using System;
using System.Collections.Generic;
using System.Text;

namespace Librairie_Classes
{
    public class Tasse : Contenant
    {
        // ** Champs ** //

        // ** Propriétés ** //

        // ** Constructeurs ** //
        public Tasse()
        {
            base.m_volume = 250m;
            base.m_volumeMax = m_volume - (base.m_zoneTampon * m_volume);
        }

        // ** Méthodes ** //
        
    }
}
