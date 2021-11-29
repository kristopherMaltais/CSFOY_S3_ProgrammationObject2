using System;
using FormatsEchanges_LibrairieClasses.Entites;
using System.Collections.Generic;
using Unity;
using FormatsEchanges_LibrairieClasses.CoucheAccesDonneesJSON;
using FormatsEchanges_LibrairieClasses.CoucheAccesDonneesXML;

namespace FormatsEchanges_Console
{
    class Program
    {
        static void Main(string[] args)
        {
            IUnityContainer conteneur = new UnityContainer();

            conteneur.RegisterType<IDepotClients, DepotClientsXML>(TypeLifetime.Singleton, new Unity.Injection.InjectionConstructor(new object[] { "C:\\Users\\rache\\OneDrive\\Bureau\\M6_FormatsEchanges\\FormatsEchanges_Console\\bin\\Debug\\net5.0\\testXML" }));

            ClientUIConsole clientUIConsole = conteneur.Resolve<ClientUIConsole>();
            clientUIConsole.ExecuterUI();
            
        }
    }
}
