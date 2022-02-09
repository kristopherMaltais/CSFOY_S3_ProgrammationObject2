using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TraitementImage_LibrairieClasse
{
    public class TraitementImageConvertirNoirEtBlanc : ITraitementImage
    {
        // ** Champs ** //

        // ** Propriétés ** //
        public ITraitementImage Suivant { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

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
        }
        
    }
}
