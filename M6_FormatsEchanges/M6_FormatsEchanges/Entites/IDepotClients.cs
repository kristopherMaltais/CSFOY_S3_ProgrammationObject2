using System;
using System.Collections.Generic;
using System.Text;

namespace FormatsEchanges_LibrairieClasses.Entites
{
    public interface IDepotClients
    {
        public void AjouterClient(Client p_client);
        public void ModifierClient(Client p_client);
        public Client ChercherClient(Guid p_clientId);
        public List<Client> ListerClients();
    }
}
