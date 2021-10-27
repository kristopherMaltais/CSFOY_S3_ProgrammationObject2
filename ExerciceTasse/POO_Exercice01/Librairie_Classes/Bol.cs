using System;
using System.Collections.Generic;
using System.Text;

namespace Librairie_Classes
{
    public class Bol : Contenant
    {
        // ** Champs ** //

        // ** Propriétés ** //

        // ** Constructeurs ** //
        public Bol()
        {
            base.m_volume = 350;
            base.m_volumeMax = m_volume - (base.m_zoneTampon * m_volume);
        }

        // ** Méthodes ** //
       
    }
}
