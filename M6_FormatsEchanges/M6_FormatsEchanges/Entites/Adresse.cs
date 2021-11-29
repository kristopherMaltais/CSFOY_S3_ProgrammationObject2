using System;
using System.Collections.Generic;
using System.Text;

namespace FormatsEchanges_LibrairieClasses.Entites
{
    public class Adresse  // Créer un constructeur et tout mettre mes set private | Mettre un tostring ici et l'utiliser dans client
    {
        // ** Champs ** //

        // ** Propriétés ** //
        public Guid AdresseId { get; private set; }
        public string NumeroCivique { get; private set; }
        public string InformationComplementaire { get; private set; }
        public string Odonyme { get; private set; }
        public string TypeVoie { get; private set; }
        public string CodePostal { get; private set; }
        public string NomMunicipalite { get; private set; }
        public string Etat { get; private set; }
        public string Pays { get; private set; }

        // ** Constructeurs ** //
        public Adresse(Guid p_adresse_Id, string p_numeroCivique, string p_information, string p_odonyme, string p_typeVoie, string p_codePostal, string p_nomMunicipalite, string p_etat, string p_pays)
        {
            this.AdresseId = p_adresse_Id;
            this.NumeroCivique = p_numeroCivique;
            this.InformationComplementaire = p_information;
            this.Odonyme = p_odonyme;
            this.TypeVoie = p_typeVoie;
            this.CodePostal = p_codePostal;
            this.NomMunicipalite = p_nomMunicipalite;
            this.Etat = p_etat;
            this.Pays = p_pays;
        }

        // ** Méthodes ** //
        public override string ToString()
        {
            string adresse = $"    --> {this.NumeroCivique} {this.TypeVoie} {this.Odonyme}, {this.CodePostal}, {this.NomMunicipalite}, {this.Etat}, {this.Pays}. Commentaire: {this.InformationComplementaire}";
            return adresse;
        }
    }
}
