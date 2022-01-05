using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonClasses
{
    class Personne
    {
        // ** Champs ** //

        // ** Propriétés ** //
        public string Nom;
        public int identifiantUnique;
        public List<Voiture> Voitures;

        // ** Constructeus ** //
        public Personne(string p_nom, int p_identifiantUnique, List<Voiture> p_voitures)
        {
            Nom = p_nom;
            identifiantUnique = p_identifiantUnique;
            Voitures = p_voitures;
        }

        // ** Méthodes ** //
    }
}
