using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibrairieClasses
{
    public enum Evement
    {
        AJOUTlIGNE,
        NOUVELLEFACTURE
    }
    public class FactureEvent
    {
        // ** Champs ** //

        // ** Propriétés ** //
        public Evement Type { get; private set; }
        public LigneFacture LigneFacture { get; private set; }
        public Facture Facture { get; private set; }
        
        // ** Constructeurs ** //
        public FactureEvent(Evement p_typeEvenement, Facture p_facture, LigneFacture p_ligneFacture = null)
        {
            this.Type = p_typeEvenement;
            this.LigneFacture = p_ligneFacture;
            this.Facture = p_facture;
        }

        // ** Méthodes ** //
    }
}
