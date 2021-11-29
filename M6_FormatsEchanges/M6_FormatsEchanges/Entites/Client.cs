using System;
using System.Collections.Generic;
using System.Text;

namespace FormatsEchanges_LibrairieClasses.Entites
{
    public class Client
    {
        // ** Champs ** //

        // ** Propriétés ** //
        public Guid ClientId { get; private set; }
        public string Nom { get; private set; }
        public string Prenom { get; private set; }
        public List<Adresse> Adresses { get; private set; }

        // ** Constructeurs ** //
        public Client() { }
        public Client(Guid p_clientId, string p_nom, string p_prenom, List<Adresse> p_adresses)
        {
            ClientId = p_clientId;
            Nom = p_nom;
            Prenom = p_prenom;
            Adresses = (List<Adresse>)p_adresses;
        }

        // ** Méthodes ** //
        public override string ToString()
        {
            StringBuilder client = new StringBuilder();
            client.Append($"Numéro de client: {this.ClientId} \n");
            client.Append($"Nom du client: {this.Prenom} {this.Nom} \n");
            client.Append("Liste des adresses du client:  \n");

            foreach(Adresse adresse in Adresses)
            {
                client.Append(adresse.ToString() + "\n");
            }

            return client.ToString();
        }
    }
}
