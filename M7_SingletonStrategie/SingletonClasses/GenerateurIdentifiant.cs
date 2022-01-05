using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonClasses
{
    internal class GenerateurIdentifiant
    {
        // ** Champs ** //
        private int m_identifiant;

        // ** propriétés ** //

        // ** Constructeurs ** //

        // ** Méthodes ** //
        public void GenererProchainId()
        {
            this.m_identifiant++;
        }
    }
}
