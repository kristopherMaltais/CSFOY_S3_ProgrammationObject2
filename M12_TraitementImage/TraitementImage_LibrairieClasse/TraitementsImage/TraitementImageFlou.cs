using System;
using System.Collections.Generic;
using System.ComponentModel;
using static TraitementImage_LibrairieClasse.UtilitaireTraitements;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TraitementImage_LibrairieClasse.TraitementsImage
{
    [Description("Traiter le flou de l'image")]
    public class TraitementImageFlou : TraitementImageMasque
    {
        // ** Champs ** //

        // ** Propriétés ** //

        // ** Constructeurs ** //
        public TraitementImageFlou()
        {
            base.Transformation = t =>
            {
                return TraiterDonnees(t);
            };
        }
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
        public override string ToString()
        {
            return UtilitaireTraitements.DescriptionTraitement(this);
        }
    }
}
