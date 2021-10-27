using System;
using System.Collections.Generic;
using System.Text;

namespace Librairie_Classes
{
    public class Liquide
    {
        // ** Champs ** //
        private string m_nomLiquide;

        // ** Propriétés ** //
        

        // ** Constructeurs ** //
        public Liquide(string typeLiquide)
        {
            m_nomLiquide = typeLiquide;
        }

        // ** Méthodes ** //
        public override string ToString()
        {
            return m_nomLiquide;
        }
    }
}
