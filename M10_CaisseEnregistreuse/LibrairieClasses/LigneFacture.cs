using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibrairieClasses
{
    public class LigneFacture
    {
        // ** Champs ** //

        // ** Propriétés ** //
        public string Description { get; private set; }
        public int Quantite { get; private set; }
        public decimal Prix { get; private set; }
        public decimal Total { get; private    set; }

        // ** Constructeurs ** //
        public LigneFacture(string p_description, int p_quantite, decimal p_prix)
        {
            this.Description = p_description;
            this.Quantite = p_quantite;
            this.Prix = p_prix;
            this.Total = p_quantite * p_prix;
        }

        // ** Méthodes ** //
        public override string ToString()
        {
            return $"{this.Description}    {this.Quantite} @ {this.Prix}$\n";
        }
    }
}
