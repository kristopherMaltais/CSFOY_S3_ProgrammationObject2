using System;
using System.Collections.Generic;
using System.Text;
using FormatsEchanges_LibrairieClasses.Entites;
using System.Xml;
using System.Xml.Serialization;
using System.IO;
using System.Linq;

namespace FormatsEchanges_LibrairieClasses.CoucheAccesDonneesXML
{
    public class DepotClientsXML : IDepotClients
    {
        // ** Champs ** //
        private string m_nomFichier;

        // ** Propriétés ** //

        // ** Constructeurs ** //
        public DepotClientsXML(string p_nomFichier)
        {
            this.m_nomFichier = p_nomFichier;
        }

        // ** Méthodes ** //
        public void AjouterClient(Client p_client)
        {
            // Préconditions
            if (p_client == null)
            {
                throw new ArgumentNullException("Le client ne peut pas être null", "p_client");
            }
            
            List<Client> clientsEntites = this.ListerClients();

            clientsEntites.Add(p_client);
            this.SerializerClients(clientsEntites);
        }
        public void ModifierClient(Client p_clientModifie)
        {
            Client ancienClient = ChercherClient(p_clientModifie.ClientId);
            
            if(ancienClient != null)
            {
                List<Client> clientsEntites = ListerClients();
                clientsEntites = clientsEntites.Where(client => client.ClientId != ancienClient.ClientId).ToList();
                clientsEntites.Add(p_clientModifie);

                this.SerializerClients(clientsEntites);
            }
        }
        public Client ChercherClient(Guid p_clientId) 
        {
            List<Client> clientsEntites = this.ListerClients();

            Client clientTrouve = clientsEntites.Where(client => client.ClientId == p_clientId).SingleOrDefault();

            return clientTrouve;
        }
        public List<Client> ListerClients() 
        {
            List<ClientXMLDTO> clientsDTO = this.Deserializer();
            List<Client> clientsEntites = clientsDTO.Select(client => client.ClientDTOVersClientEntite()).ToList();
            return clientsEntites;
        }
        private void SerializerClients(List<Client> p_clientsEntites)
        {
            XmlWriterSettings settings = new XmlWriterSettings
            {
                Indent = true,
                IndentChars = "\t"
            };

            List<ClientXMLDTO> clientsDTO = new List<ClientXMLDTO>();

            using (XmlWriter document = XmlWriter.Create(this.m_nomFichier, settings))
            {
                XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<ClientXMLDTO>));

                clientsDTO = p_clientsEntites.Select(client => new ClientXMLDTO(client)).ToList();
                document.WriteStartDocument();
                xmlSerializer.Serialize(document, clientsDTO);
                document.Close();
            }

        }
        private List<ClientXMLDTO> Deserializer()
        {
            List<ClientXMLDTO> clientsDTO = new List<ClientXMLDTO>();

            if (File.Exists(this.m_nomFichier))
            {
                XmlReader document = XmlReader.Create(this.m_nomFichier);
                XmlSerializer serializer = new XmlSerializer(typeof(List<ClientXMLDTO>));
                clientsDTO = (List<ClientXMLDTO>)serializer.Deserialize(document);
                document.Close();
            }

            return clientsDTO;
        }
    }
}
