using System;
using System.Collections.Generic;
using System.Text;
using FormatsEchanges_LibrairieClasses.Entites;
using FormatsEchanges_LibrairieClasses.CoucheAccesDonneesXML;
using AutoMapper;
using FormatsEchanges_LibrairieClasses.TraitementsLots.ModifierPaysMajusculesClients;
using FormatsEchanges_LibrairieClasses.TraitementsLots.ModifierNomPrenomPremiereLettreMajuscule;

namespace FormatsEchanges_Console
{
    public class ClientUIConsole
    {
        // ** Champs ** //
        private IDepotClients m_depotClient;
        
        // ** Propriétés ** //


        // ** Constructeur ** //
        public ClientUIConsole(IDepotClients p_depotClient)
        {
            m_depotClient = p_depotClient;
        }

        // ** Méthodes ** //
        public void AfficherMenu()
        {
            Console.Out.WriteLine("--- Système de gestion des clients ---");
            Console.Out.WriteLine("             --- MENU ---             ");
            Console.Out.WriteLine("[1] Saisir client avec adresse");
            Console.Out.WriteLine("[2] Rechercher et afficher client par ID");
            Console.Out.WriteLine("[3] Afficher tous les clients");
            Console.Out.WriteLine("[4] Mise à jour pays");
            Console.Out.WriteLine("[5] Mise à jour nom et prénom");
            Console.Out.WriteLine("[6] Quitter");
        }
        public int SaisirChoixMenu()
        {
            Console.Out.WriteLine();
            Console.Out.Write("Que voulez-vous faire: ");
            string saisiUtilisateur = Console.In.ReadLine();
            Console.Out.WriteLine();

            int.TryParse(saisiUtilisateur, out int choixUtilisateur);
            return choixUtilisateur;
        }
        public void ExecuterUI()
        {
            int choixUtilisateur = 0;

            while (choixUtilisateur != 6)
            {
                this.AfficherMenu();
                choixUtilisateur = this.SaisirChoixMenu();

                switch (choixUtilisateur)
                {
                    case 1:
                        this.SaisirClientAvecAdresse();
                        break;
                    case 2:
                        this.RechercherEtAfficherClientParId();
                        break;
                    case 3:
                        this.ListerEtAfficherClients();
                        break;
                    case 4:
                        this.MiseAJourPays();
                        break;
                    case 5:
                        this.MiseAJourNomPrenom();
                            break;
                    default:
                        break;
                }
            }
        }
        public void SaisirClientAvecAdresse()
        {
            Guid codeClient = Guid.NewGuid();

            Console.Out.Write("Quel est le Prénom de votre client: ");
            String prenomClient = Console.In.ReadLine();

            Console.Out.Write("Quel est le Nom de votre client: ");
            String nomClient = Console.In.ReadLine();

            Console.Out.Write("Combien d'adresse a le client: ");
            int nombreAdresse = int.Parse(Console.In.ReadLine());

            List<Adresse> listeAdresseClient = new List<Adresse>();

            for (int adresse = 0; adresse < nombreAdresse; adresse++)
            {
                Adresse nouvelleAdresse = GenererAdresseAleatoire();
                listeAdresseClient.Add(nouvelleAdresse);
            }
            
            Client nouveauClient = new Client(codeClient, nomClient, prenomClient, listeAdresseClient);

            m_depotClient.AjouterClient(nouveauClient);
        }
        public void RechercherEtAfficherClientParId()
        {
            Console.Out.Write("Quel est le id du client que vous souhaitez voir: ");
            string idClient = Console.In.ReadLine();

            Guid.TryParse(idClient, out Guid guidId);

            Client clientTrouve = this.m_depotClient.ChercherClient(guidId);

            if(clientTrouve == null)
            {
                Console.Out.WriteLine("Aucun client trouvé ne correspond à cet ID...");
            }
            else
            {
                Console.Out.WriteLine(clientTrouve.ToString());
            }
        }
        public void ListerEtAfficherClients()
        {
            List<Client> listeClients = m_depotClient.ListerClients();

            foreach(Client client in listeClients)
            {
                Console.Out.WriteLine(client.ToString());
            }
        }
        public Adresse GenererAdresseAleatoire()
        {
            Random chiffreAleatoire = new Random();

            Guid adresseId = Guid.NewGuid();
            string[] listeNumeroCivique = new string[] { "123", "4583", "1254", "666", "1111", "9876" };
            string[] listeInformation = new string[] { "chien dangereux", "Porte rouge", "Pas de courrier", "Porte arrière", "Cognez pour enter", "Porte sur la gauche" };
            string[] listeOdonyme = new string[] { "Ste-Foy", "Ouellet", "Scott", "Charest", "Merisier", "Des neiges" };
            string[] listeTypeVoie = new string[] { "Rue", "Boulevard", "Autoroute", "Côte", "Chemin", "Avenue" };
            string[] listeCodePostal = new string[] { "G8BS3F", "1C4F5G", "G8M1H8", "G9K1S1", "G8M3F4", "D1D4F5" };
            string[] listeNomMunicipalite = new string[] { "Québec", "Alma", "Montréal", "Roberval", "St-Gedeon", "St-Bruno" };
            string province = "québec";
            string pays = "Canada";

            Adresse adresseAleatoire = new Adresse(adresseId,
                                                   listeNumeroCivique[chiffreAleatoire.Next(0, 6)],
                                                   listeInformation[chiffreAleatoire.Next(0, 6)], 
                                                   listeOdonyme[chiffreAleatoire.Next(0, 6)], 
                                                   listeTypeVoie[chiffreAleatoire.Next(0, 6)], 
                                                   listeCodePostal[chiffreAleatoire.Next(0, 6)], 
                                                   listeNomMunicipalite[chiffreAleatoire.Next(0, 6)],
                                                   province,
                                                   pays);
            return adresseAleatoire;
        }
        public void MiseAJourPays()
        {
            ModifierPaysMajusculesClientsTraitementLot miseAJour = new ModifierPaysMajusculesClientsTraitementLot(this.m_depotClient);
            miseAJour.Executer();
        }
        public void MiseAJourNomPrenom()
        {
            ModifierNomPrenomPremiereLettreMajusculeTraitementLot miseAJour = new ModifierNomPrenomPremiereLettreMajusculeTraitementLot(this.m_depotClient);
            miseAJour.Executer();
        }
    }

}
