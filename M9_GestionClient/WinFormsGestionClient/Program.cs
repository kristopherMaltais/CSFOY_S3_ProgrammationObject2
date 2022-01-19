using Microsoft.Extensions.Configuration;
using Module08_Exercice01_Base_Console.CoucheAccesDonnees.JSON;
using Module08_Exercice01_Base_Console.CoucheAccesDonnees.XML;
using Module08_Exercice01_Base_Console.Entites;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Unity;

namespace WinFormsGestionClient
{
    static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        /// 
        private static string _fichierDepotClientsJSON = "clients.json";
        private static string _fichierDepotClientsXML = "clients.xml";
        [STAThread]
        static void Main()
        {
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            GenererFichiersDepotSiNonExistant(false);
            IUnityContainer conteneur = new UnityContainer();

            // Configuration du dépôt
            IConfigurationRoot configuration =
                new ConfigurationBuilder()
                    .SetBasePath(Directory.GetParent(AppContext.BaseDirectory).FullName)
                    .AddJsonFile("appsettings.json", false)
                    .Build();
            string repertoireDepotClient = configuration["RepertoireDepotsClients"];
            string nomFichierDepotClient = configuration["NomFichierDepotClients"];
            string cheminComplet = Path.Combine(repertoireDepotClient, nomFichierDepotClient);
            string typeDepot = configuration["TypeDepot"];

            switch (typeDepot.ToLower())
            {
                case "json":
                    conteneur.RegisterType<IDepotClients, DepotClientsJSON>(TypeLifetime.Singleton, new Unity.Injection.InjectionConstructor(new object[] { cheminComplet }));
                    break;
                case "xml":
                    conteneur.RegisterType<IDepotClients, DepotClientsXML>(TypeLifetime.Singleton, new Unity.Injection.InjectionConstructor(new object[] { cheminComplet }));
                    break;
                default:
                    throw new InvalidOperationException("le type de dépot n'est pas valide, mettre json ou xml");
            }
             
            // Injection dépendance pour interface utilisateur
            fPrincipale windowForm = conteneur.Resolve<fPrincipale>();
            Application.Run(windowForm);
        }

        private static void GenererFichiersDepotSiNonExistant(bool p_forceCreation)
        {
            bool fichierDepotClientJSONExiste = File.Exists(_fichierDepotClientsJSON);
            bool fichierDepotClientXMLExiste = File.Exists(_fichierDepotClientsXML);

            if (fichierDepotClientJSONExiste && p_forceCreation)
            {
                File.Delete(_fichierDepotClientsJSON);
            }

            if (fichierDepotClientXMLExiste && p_forceCreation)
            {
                File.Delete(_fichierDepotClientsXML);
            }

            if (!fichierDepotClientJSONExiste || p_forceCreation)
            {
                GenerateurDonnees.GenererDepotJsonClients(_fichierDepotClientsJSON);
            }

            if (!fichierDepotClientJSONExiste || p_forceCreation)
            {
                GenerateurDonnees.GenererDepotXMLClients(_fichierDepotClientsXML);
            }
        }
    }

    internal class GenerateurDonnees
    {
        private static Random _generateurNombres = new Random(DateTime.Now.Millisecond);

        // Utilitaires
        public static List<Client> GenererClients(int p_nombreClients)
        {
            return Enumerable.Range(1, _generateurNombres.Next(1, p_nombreClients + 1))
            .Select(_ => GenererClient()
            ).ToList();
        }
        public static Client GenererClient()
        {
            // https://fr.wikipedia.org/wiki/Liste_des_noms_de_famille_les_plus_courants_au_Québec
            string[] noms = {
"Tremblay",
"Gagnon",
"Roy",
"Côté",
"Bouchard",
"Gauthier",
"Morin",
"Lavoie",
"Fortin",
"Gagné",
"Ouellet",
"Pelletier",
"Bélanger",
"Lévesque",
"Bergeron",
};
            // https://www.retraitequebec.gouv.qc.ca/fr/services-en-ligne-outils/banque-de-prenoms/Pages/recherche_par_popularite.aspx?AnRefBp=2019&NbPre=10
            string[] prenoms = {
"olivia",
"emma",
"alice",
"charlie",
"charlotte",
"liam",
"william",
"thomas",
"léo",
"noah",
};

            return new Client(
            Guid.NewGuid(),
            noms[_generateurNombres.Next(0, noms.Length)],
            prenoms[_generateurNombres.Next(0, prenoms.Length)],
            GenererAdresses()
            );
        }

        public static void GenererDepotJsonClients(string p_nomDepot)
        {
            IDepotClients depotClients = new DepotClientsJSON(p_nomDepot);
            GenererClients(_generateurNombres.Next(5, 11)).ForEach(c => depotClients.AjouterClient(c));
        }
        public static void GenererDepotXMLClients(string p_nomDepot)
        {
            IDepotClients depotClients = new DepotClientsXML(p_nomDepot);
            GenererClients(_generateurNombres.Next(5, 11)).ForEach(c => depotClients.AjouterClient(c));
        }

        public static Adresse GenererAdresseAleatoire()
        {
            Random random = new Random();
            string[] tableauInfoComplementaire = { "rang de terre", "rang de gravelle", "belle route asphaltée", "route dangereuse" };
            string[] tableauOdonyme = { "des roses", "de la grande route", "des perchaudes", "du pommier" };
            string[] tableauTypeVoie = { "Rue", "Avenue", "Boulevard", "Rang" };
            string[] tableauCodePostal = { "G5X 1X5", "G6X 2X4", "G3D G6X", "GX8 2P2" };
            string[] tableauNomMunicipalite = { "Beauceville", "Quebec", "St-Georges", "Ste-Foy" };
            string[] tableauEtat = { "Quebec", "Alberta", "Saskatchewan", "Ontario" };
            string[] tableauPays = { "USA", "Canada", "France", "Russie" };

            int numeroCivique = random.Next(9999);
            int infoCompIndice = random.Next(tableauInfoComplementaire.Length);
            int odonymeIndice = random.Next(tableauOdonyme.Length);
            int typeVoieIndice = random.Next(tableauTypeVoie.Length);
            int codePostalIndice = random.Next(tableauCodePostal.Length);
            int nomMunicipaliteIndice = random.Next(tableauNomMunicipalite.Length);
            int etatIndice = random.Next(tableauEtat.Length);
            int paysIndice = random.Next(tableauPays.Length);

            Adresse nouvelleAdresse = new Adresse(Guid.NewGuid(), numeroCivique, tableauInfoComplementaire[infoCompIndice],
            tableauOdonyme[odonymeIndice], tableauTypeVoie[typeVoieIndice], tableauCodePostal[codePostalIndice],
            tableauNomMunicipalite[nomMunicipaliteIndice], tableauEtat[etatIndice], tableauPays[paysIndice]);

            return nouvelleAdresse;
        }
        private static List<Adresse> GenererAdresses()
        {
            return Enumerable.Range(1, _generateurNombres.Next(1, 6)).Select(_ => GenererAdresseAleatoire()).ToList();
        }
    }
}
