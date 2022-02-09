using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TraitementImage_LibrairieClasse
{
    public interface ITraitementImage
    {
        public ITraitementImage Suivant { get; set; }
        public void TraiterImage(ImageManipulable p_image);
    }
}
