using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TraitementImage_LibrairieClasse.TraitementsImage
{
    public class TraitementImageFlou : TraitementImageMasque
    {
        // ** Champs ** //

        // ** Propriétés ** //

        // ** Constructeurs ** //

        // ** Méthodes ** //
        private static byte TraiterDonnees(byte[] p_donnees)
        {
            int somme = 0;
            for (int i = 0; i < p_donnees.Length; i++)
            {
                somme += p_donnees[i];
            }

            return (byte)(somme / p_donnees.Length);
        }
    }
}
