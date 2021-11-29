using FormatsEchanges_LibrairieClasses.Entites;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace FormatsEchanges_LibrairieClasses.TraitementsLots.ModifierNomPrenomPremiereLettreMajuscule
{
    public class ModifierNomPrenomPremiereLettreMajusculeTraitementLot : ITraitementLot
    {
        // ** Champs ** //
        private IDepotClients m_depot;

        // ** Propriétés ** //

        // **Constructeurs ** //
        public ModifierNomPrenomPremiereLettreMajusculeTraitementLot(IDepotClients depotClient)
        {
            this.m_depot = depotClient;
        }

        // ** Méthodes ** //
        public void Executer()
        {
            List<Client> clients = m_depot.ListerClients();
            TextInfo textInfo = new CultureInfo("en-US", false).TextInfo;

            foreach(Client client in clients)
            {
                string prenom = textInfo.ToTitleCase(client.Prenom);
                string nom = textInfo.ToTitleCase(client.Nom);
                
                if(client.Prenom != prenom || client.Nom != nom)
                {
                    Client clientMiseAJour = new Client(client.ClientId, nom, prenom, client.Adresses);
                    this.m_depot.ModifierClient(clientMiseAJour);
                }
            }
        }
    }
}
