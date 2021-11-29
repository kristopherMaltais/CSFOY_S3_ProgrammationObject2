using System;
using FormatsEchanges_LibrairieClasses.Entites;
using System.Collections.Generic;
using FormatsEchanges_LibrairieClasses.CoucheAccesDonneesXML;
using FormatsEchanges_LibrairieClasses.CoucheAccesDonneesJSON;
using Unity;

namespace FormatsEchanges_Console
{
    class Program
    {
        static void Main(string[] args)
        {
            IUnityContainer conteneur = new UnityContainer();

            conteneur.RegisterType<IDepotClients, DepotClientsJSON>(TypeLifetime.Singleton, new Unity.Injection.InjectionConstructor(new object[] { "C:\\info\\S3\\Poo2\\CSFOY__S3_ProgrammationObject2\\M6_FormatsEchanges2\\FormatsEchanges_Console\\bin\\Debug\\netcoreapp3.1\\testJSON" }));

            ClientUIConsole clientUIConsole = conteneur.Resolve<ClientUIConsole>();
            clientUIConsole.ExecuterUI();
            
        }
    }
}
