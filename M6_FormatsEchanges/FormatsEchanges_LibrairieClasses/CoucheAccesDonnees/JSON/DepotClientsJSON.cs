using System;
using System.Collections.Generic;
using System.Text;
using FormatsEchanges_LibrairieClasses.Entites;
using System.IO;
using Newtonsoft.Json;
using System.Linq;

namespace FormatsEchanges_LibrairieClasses.CoucheAccesDonneesJSON
{
    public class DepotClientsJSON : IDepotClients
    {
        // ** Champs ** //
        private string m_nomFichier;

        // ** Propriétés ** //

        // ** Constructeurs ** //
        public DepotClientsJSON(string p_nomFichier)
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

            if (ancienClient != null)
            {
                List<Client> clientsEntites = this.ListerClients();
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
            List<ClientJSONDTO> clientsDTO = this.DeserializerClients();
            List<Client> clientsEntites = clientsDTO.Select(client => client.ClientDTOVersClientEntite()).ToList();
            return clientsEntites;
        }
        private void SerializerClients(List<Client> clientsEntites)
        {
            List<ClientJSONDTO> clientsDTO = clientsEntites.Select(client => new ClientJSONDTO(client)).ToList();
            JsonSerializerSettings settings = new JsonSerializerSettings
            {
                TypeNameHandling = TypeNameHandling.Auto,
                Formatting = Formatting.Indented
            };

            string chaineJson = JsonConvert.SerializeObject(clientsDTO, settings);
            File.WriteAllText(this.m_nomFichier, chaineJson);
        }
        private List<ClientJSONDTO> DeserializerClients()
        {
            List<ClientJSONDTO> clientsDTO = new List<ClientJSONDTO>();

            if (File.Exists(this.m_nomFichier))
            {
                string chaineJSON = File.ReadAllText(this.m_nomFichier);
                JsonSerializerSettings settings = new JsonSerializerSettings
                {
                    TypeNameHandling = TypeNameHandling.Auto
                };

                clientsDTO = JsonConvert.DeserializeObject<List<ClientJSONDTO>>(chaineJSON, settings);
            }

            return clientsDTO;
        }

    }
}
