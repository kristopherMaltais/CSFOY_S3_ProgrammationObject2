using FormatsEchanges_LibrairieClasses.Entites;
using System;
using System.Collections.Generic;
using System.Text;

namespace FormatsEchanges_LibrairieClasses.CoucheAccesDonneesJSON
{
    public class AdresseJSONDTO
    {
        // ** Champs ** //

        // ** Propriétés ** //
        public Guid AdresseId { get; set; }
        public string NumeroCivique { get; set; }
        public string InformationComplementaire { get; set; }
        public string Odonyme { get; set; }
        public string TypeVoie { get; set; }
        public string CodePostal { get; set; }
        public string NomMunicipalite { get; set; }
        public string Etat { get; set; }
        public string Pays { get; set; }

        // ** Constructeurs ** //
        public AdresseJSONDTO() { }
        public AdresseJSONDTO(Adresse p_adresse)
        {
            this.AdresseId = p_adresse.AdresseId;
            this.NumeroCivique = p_adresse.NumeroCivique;
            this.InformationComplementaire = p_adresse.InformationComplementaire;
            this.Odonyme = p_adresse.Odonyme;
            this.TypeVoie = p_adresse.TypeVoie;
            this.CodePostal = p_adresse.CodePostal;
            this.NomMunicipalite = p_adresse.NomMunicipalite;
            this.Etat = p_adresse.Etat;
            this.Pays = p_adresse.Pays;
        }

        // ** Méthodes ** //
        public Adresse AdresseDTOVersAdresseEntite()
        {
            Adresse nouvelleAdresseEntite = new Adresse(this.AdresseId, this.NumeroCivique, this.InformationComplementaire, this.Odonyme, this.TypeVoie, this.CodePostal, this.NomMunicipalite, this.Etat, this.Pays);
            return nouvelleAdresseEntite;
        }
    }
}
