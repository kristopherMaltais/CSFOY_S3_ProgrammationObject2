using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TraitementImage_LibrairieClasse.TraitementsImage
{
    public class TraitementImageDiminuerBruit : TraitementImageMasque
    {
        // ** Champs ** //

        // ** Propriétés ** //

        // ** Constructeurs ** //

        // ** Méthodes ** //
        private static byte TraiterDonnees(byte[] p_donnees)
        {
            Array.Sort(p_donnees);

            return p_donnees[p_donnees.Length / 2];
        }
    }
}
