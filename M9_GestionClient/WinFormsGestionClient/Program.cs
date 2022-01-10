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
        //private static string _fichierDepotClientsJSON = "clients.json";
        //private static string _fichierDepotClientsXML = "clients.xml";
        [STAThread]
        static void Main()
        {
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

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
    }
}
