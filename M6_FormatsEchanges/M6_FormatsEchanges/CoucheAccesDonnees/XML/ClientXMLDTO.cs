using System;
using System.Collections.Generic;
using System.Text;
using FormatsEchanges_LibrairieClasses.Entites;
using System.Xml;
using System.Xml.Serialization;
using System.Linq;

namespace FormatsEchanges_LibrairieClasses.CoucheAccesDonneesXML
{
    [XmlType("Client")]
    public class ClientXMLDTO
    {
        // ** Champs ** //

        // ** Propriétés ** //
        public Guid ClientId { get; set; }
        public string Nom { get; set; }
        public string Prenom { get; set; }
        public List<AdresseXMLDTO> Adresses { get; set; }

        // ** Constructeurs ** //
        public ClientXMLDTO() { }
        public ClientXMLDTO(Client p_client)
        {
            List<AdresseXMLDTO> adressesClientDTO = new List<AdresseXMLDTO>();

            adressesClientDTO = p_client.Adresses.Select(adresse => new AdresseXMLDTO(adresse)).ToList();
            
            this.Prenom = p_client.Prenom;
            this.Nom = p_client.Nom;
            this.ClientId = p_client.ClientId;
            this.Adresses = adressesClientDTO;
        }

        // ** Méthodes ** //
        public Client ClientDTOVersClientEntite()
        {
            List<Adresse> listeAdresse = this.Adresses.Select(adresse => adresse.AdresseDTOVersAdresseEntite()).ToList();
            Client nouveauClientEntite = new Client(this.ClientId, this.Nom, this.Prenom, listeAdresse);
            return nouveauClientEntite;
        }
        
    }
}
