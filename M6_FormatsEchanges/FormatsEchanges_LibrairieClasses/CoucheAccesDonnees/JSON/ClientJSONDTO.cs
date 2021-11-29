using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FormatsEchanges_LibrairieClasses.CoucheAccesDonneesXML;
using FormatsEchanges_LibrairieClasses.Entites;


namespace FormatsEchanges_LibrairieClasses.CoucheAccesDonneesJSON
{
    public class ClientJSONDTO
    {
        // ** Champs ** //

        // ** Propriétés ** //
        public Guid ClientId { get; set; }
        public string Nom { get; set; }
        public string Prenom { get; set; }
        public List<AdresseJSONDTO> Adresses { get; set; }

        // ** Constructeurs ** //
        public ClientJSONDTO() { }
        public ClientJSONDTO(Client p_client)
        {
            List<AdresseJSONDTO> adressesClientDTO = new List<AdresseJSONDTO>();

            adressesClientDTO = p_client.Adresses.Select(adresse => new AdresseJSONDTO(adresse)).ToList();

            this.Prenom = p_client.Prenom;
            this.Nom = p_client.Nom;
            this.ClientId = p_client.ClientId;
            this.Adresses = adressesClientDTO;
        }

        // ** Méthodes ** //
        public Client ClientDTOVersClientEntite()
        {
            List<Adresse> adresses = this.Adresses.Select(adresse => adresse.AdresseDTOVersAdresseEntite()).ToList();
            Client nouveauClientEntite = new Client(this.ClientId, this.Nom, this.Prenom, adresses);
            return nouveauClientEntite;
        }
    }
}
