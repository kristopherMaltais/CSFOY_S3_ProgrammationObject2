using System;
using System.Collections.Generic;
using static TraitementImage_LibrairieClasse.UtilitaireTraitements;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace TraitementImage_LibrairieClasse.TraitementsImage
{
    public abstract class TraitementImageMasque : ITraitementImage
    {
        // ** Champs ** //
        private int m_largeur = 7;

        // ** Propriétés ** //
        [Browsable(false)]
        public ITraitementImage Suivant { get; set; }
        public int Largeur
        {
            get => this.m_largeur;
            set
            {
                if(value < 1)
                {
                    throw new ArgumentOutOfRangeException("Largeur ne peut pas être inférieur à zéro");
                }
                if(value % 2 == 0)
                {
                    throw new ArgumentOutOfRangeException("Largeur doit être impaire");
                }

                this.m_largeur = value;

            }
        }
        public Func<byte[], byte> Transformation { get; set; }

        // ** Constructeurs ** //

        // ** Méthodes ** //
        public void TraiterImage(ImageManipulable p_image)
        {
            byte[] raw = p_image.Raw;
            byte[] res = new byte[raw.Length];
            int width = p_image.Width;
            int height = p_image.Height;
            int stride = p_image.Stride;
            byte[] donneesCourantes = new byte[this.Largeur * this.Largeur];
            for (int colonne = 0; colonne < width; colonne++)
            {
                for (int ligne = 0; ligne < height; ligne++)
                {
                    for (int composante = 0; composante < 3; composante++)
                    {
                        int posDonneesCourantes = 0;
                        for (int masqueX = -this.Largeur / 2; masqueX <= this.Largeur / 2; masqueX++)
                        {
                            int posX = Math.Min(Math.Max(0, colonne + masqueX), width - 1);
                            for (int masqueY = -this.Largeur / 2; masqueY <= this.Largeur / 2; masqueY++)
                            {
                                int posY = Math.Min(Math.Max(0, ligne + masqueY), height - 1);
                                donneesCourantes[posDonneesCourantes] = raw[posY * stride + posX * 3 + composante];
                                ++posDonneesCourantes;
                            }
                        }
                        res[ligne * stride + colonne * 3 + composante] = this.Transformation(donneesCourantes);
                    }
                }
            }

            Array.Copy(res, raw, raw.Length);

            this.Suivant?.TraiterImage(p_image);
        }
        public override string ToString()
        {
            return UtilitaireTraitements.DescriptionTraitement(this);
        }
    }
          
}
