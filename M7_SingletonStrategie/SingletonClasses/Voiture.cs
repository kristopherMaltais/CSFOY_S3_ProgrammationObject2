using System;

namespace SingletonClasses
{
    public class Voiture
    {
        // * Champs ** ///

        // ** Propriétés ** //
        public string Modele { get; private set; }
        public string Annee { get; private set; }
        public int IdentifiantUnique { get; private set; }

        // ** Constructeurs ** //
        public Voiture(string p_modele, string p_annee)
        {
            Modele = p_modele;
            Annee = Annee;
            IdentifiantUnique = Singleton<GenerateurIdentifiant>;
        }

        // ** Méthodes ** //
    }
}
