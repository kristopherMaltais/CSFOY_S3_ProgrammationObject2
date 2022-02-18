using System;
using System.Collections.Generic;
using System.ComponentModel;
using static TraitementImage_LibrairieClasse.UtilitaireTraitements;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TraitementImage_LibrairieClasse.TraitementsImage
{
    [Description("Traiter le bruit de l'image")]
    public class TraitementImageDiminuerBruit : TraitementImageMasque
    {
        // ** Champs ** //

        // ** Propriétés ** //

        // ** Constructeurs ** //
        public TraitementImageDiminuerBruit()
        {
            base.Transformation = t =>
            {
                return TraiterDonnees(t);
            };
        }

        // ** Méthodes ** //
        private static byte TraiterDonnees(byte[] p_donnees)
        {
            Array.Sort(p_donnees);

            return p_donnees[p_donnees.Length / 2];
        }
        public override string ToString()
        {
            return UtilitaireTraitements.DescriptionTraitement(this);
        }
    }
}
