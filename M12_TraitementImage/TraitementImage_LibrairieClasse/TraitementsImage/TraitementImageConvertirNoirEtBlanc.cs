using System;
using System.Collections.Generic;
using System.ComponentModel;
using static TraitementImage_LibrairieClasse.UtilitaireTraitements;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TraitementImage_LibrairieClasse
{
    [Description("Traiter couler noir et blanc")]
    public class TraitementImageConvertirNoirEtBlanc : ITraitementImage
    {
        // ** Champs ** //

        // ** Propriétés ** //
        [Browsable(false)]
        public ITraitementImage Suivant { get; set; }

        // ** Constructeurs ** //

        // ** Méthodes ** //
        public void TraiterImage(ImageManipulable p_image)
        {
            byte[] raw = p_image.Raw;
            for (int longueur = 0; longueur < raw.Length / 3; longueur++)
            {
                int l3 = longueur * 3;
                byte luminance = (byte)((raw[l3] + raw[l3 + 1] + raw[l3 + 2]) / 3);
                raw[l3] = luminance;
                raw[l3 + 1] = luminance;
                raw[l3 + 2] = luminance;
            }

            this.Suivant?.TraiterImage(p_image);
        }
        public override string ToString()
        {
            return UtilitaireTraitements.DescriptionTraitement(this);
        }

    }
}
