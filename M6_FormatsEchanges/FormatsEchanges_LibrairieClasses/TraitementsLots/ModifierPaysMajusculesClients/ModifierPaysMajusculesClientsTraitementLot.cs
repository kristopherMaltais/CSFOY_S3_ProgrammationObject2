using FormatsEchanges_LibrairieClasses.Entites;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace FormatsEchanges_LibrairieClasses.TraitementsLots.ModifierPaysMajusculesClients
{
    public class ModifierPaysMajusculesClientsTraitementLot : ITraitementLot
    {
        // ** Champs ** //
        private IDepotClients m_depot;

        // ** Propriétés ** //

        // **Constructeurs ** //
        public ModifierPaysMajusculesClientsTraitementLot(IDepotClients p_depot)
        {
            this.m_depot = p_depot;
        }

        // ** Méthodes** //
        public void Executer()
        {
            List<Client> clients = m_depot.ListerClients();

            foreach (Client client in clients)
            {
                bool clientModifie = false;
                List<Adresse> adresses = new List<Adresse>();

                foreach (Adresse adresse in client.Adresses)
                {
                    string paysMajuscule = adresse.Pays.ToUpper();

                    if (paysMajuscule != adresse.Pays)
                    {
                        Adresse adresseMiseAJour = new Adresse(adresse.AdresseId, adresse.NumeroCivique, adresse.InformationComplementaire, adresse.Odonyme, adresse.TypeVoie, adresse.CodePostal, adresse.NomMunicipalite, adresse.Etat, paysMajuscule);

                        adresses.Add(adresseMiseAJour);
                        clientModifie = true;
                    }
                }
                
                if(clientModifie)
                {
                    Client clientMiseAJour = new Client(client.ClientId, client.Nom, client.Prenom, adresses);
                    this.m_depot.ModifierClient(clientMiseAJour);
                }
            }
        }
    }
}
