
using System;
using Xunit;
using Moq;
using System.Collections.Generic;
using FormatsEchanges_LibrairieClasses.Entites;
using FormatsEchanges_LibrairieClasses.TraitementsLots.ModifierNomPrenomPremiereLettreMajuscule;
using FormatsEchanges_LibrairieClasses.TraitementsLots.ModifierPaysMajusculesClients;

namespace FormatsEchanges_TestsUnitaires
{
    public class UnitTest1
    {
        public object Mock { get; private set; }

        // ModifierPaysMajusculesClientsTraitementLot
        [Fact]
        public void Executer_MiseAJourNomPrenomDejaCorrect_retour()
        {
            // Arrange
            Guid code1 = Guid.NewGuid();
            Guid code2 = Guid.NewGuid();
            List<Adresse> adresses1 = new List<Adresse>();
            List<Adresse> adresses2 = new List<Adresse>();

            Client client1 = new Client(code1, "Kristopher", "Maltais", adresses1);
            Client client2 = new Client(code2, "André", "Nicole", adresses2);
            List<Client> clients = new List<Client>() { client1, client2 };

            Mock<IDepotClients> mockDepotClient = new Mock<IDepotClients>();
            mockDepotClient.Setup(c => c.ListerClients()).Returns(clients);

            ModifierNomPrenomPremiereLettreMajusculeTraitementLot traitementLot = new ModifierNomPrenomPremiereLettreMajusculeTraitementLot(mockDepotClient.Object);

            // Act
            traitementLot.Executer();

            // Assert
            mockDepotClient.Verify(m => m.ListerClients(), Times.Once);
            mockDepotClient.VerifyNoOtherCalls();
        }
        [Fact]
        public void Executer_MiseAJourNomPrenomUnSeulClientCorrect_retour()
        {
            // Arrange
            Guid code1 = Guid.NewGuid();
            Guid code2 = Guid.NewGuid();
            List<Adresse> adresses1 = new List<Adresse>();
            List<Adresse> adresses2 = new List<Adresse>();

            Client client1 = new Client(code1, "kristopher", "maltais", adresses1);
            Client client2 = new Client(code2, "Mike", "Tremblay", adresses2);
            List<Client> clients = new List<Client>() { client1, client2 };

            Mock<IDepotClients> mockDepotClient = new Mock<IDepotClients>();
            mockDepotClient.Setup(c => c.ListerClients()).Returns(clients);

            ModifierNomPrenomPremiereLettreMajusculeTraitementLot traitementLot = new ModifierNomPrenomPremiereLettreMajusculeTraitementLot(mockDepotClient.Object);

            // Act
            traitementLot.Executer();

            // Assert
            mockDepotClient.Verify(m => m.ListerClients(), Times.Once);
            mockDepotClient.Verify(m => m.ModifierClient(It.IsAny<Client>()), Times.Once);
            mockDepotClient.VerifyNoOtherCalls();
        }
        [Fact]
        public void Executer_MiseAJourNomPrenomAucunClientCorrect_retour()
        {
            // Arrange
            Guid code1 = Guid.NewGuid();
            Guid code2 = Guid.NewGuid();
            List<Adresse> adresses1 = new List<Adresse>();
            List<Adresse> adresses2 = new List<Adresse>();

            Client client1 = new Client(code1, "kristopher", "maltais", adresses1);
            Client client2 = new Client(code2, "andré", "bouchard", adresses2);
            List<Client> clients = new List<Client>() { client1, client2 };

            Mock<IDepotClients> mockDepotClient = new Mock<IDepotClients>();
            mockDepotClient.Setup(c => c.ListerClients()).Returns(clients);

            ModifierNomPrenomPremiereLettreMajusculeTraitementLot traitementLot = new ModifierNomPrenomPremiereLettreMajusculeTraitementLot(mockDepotClient.Object);

            // Act
            traitementLot.Executer();

            // Assert
            mockDepotClient.Verify(m => m.ListerClients(), Times.Once);
            mockDepotClient.Verify(m => m.ModifierClient(It.IsAny<Client>()), Times.Exactly(2));
            mockDepotClient.VerifyNoOtherCalls();
        }

        // ModifierPaysMajusculesClientsTraitementLot
        [Fact]
        public void Executer_MiseAJourPaysDejaCorrect_AucuneModification()
        {
            // Arrange
            Guid code1 = Guid.NewGuid();
            Guid code2 = Guid.NewGuid();
            Adresse adresse1 = new Adresse(code1, "1232", "pas de lettre", "boule", "avenue", "G8B1V3", "Québec", "Québec", "CANADA");
            Adresse adresse2 = new Adresse(code2, "1222", "pas de lettre", "ste-foy", "chemin", "G8B1V2", "Québec", "Québec", "CANADA");
            List<Adresse> adresses1 = new List<Adresse>() { adresse1};
            List<Adresse> adresses2 = new List<Adresse>() { adresse2 };

            Client client1 = new Client(code1, "Kristopher", "Maltais", adresses1);
            Client client2 = new Client(code2, "André", "Nicole", adresses2);
            List<Client> clients = new List<Client>() { client1, client2 };

            Mock<IDepotClients> mockDepotClient = new Mock<IDepotClients>();
            mockDepotClient.Setup(c => c.ListerClients()).Returns(clients);

            ModifierPaysMajusculesClientsTraitementLot traitementLot = new ModifierPaysMajusculesClientsTraitementLot(mockDepotClient.Object);

            // Act
            traitementLot.Executer();

            // Assert
            mockDepotClient.Verify(m => m.ListerClients(), Times.Once);
            mockDepotClient.VerifyNoOtherCalls();
        }
        [Fact]
        public void Executer_MiseAJourPaysUneSeuleAdresseCorrect_UneSeuleModification()
        {
            // Arrange
            Guid code1 = Guid.NewGuid();
            Guid code2 = Guid.NewGuid();
            Adresse adresse1 = new Adresse(code1, "1232", "pas de lettre", "boule", "avenue", "G8B1V3", "Québec", "Québec", "canada");
            Adresse adresse2 = new Adresse(code2, "1222", "pas de lettre", "ste-foy", "chemin", "G8B1V2", "Québec", "Québec", "CANADA");
            List<Adresse> adresses1 = new List<Adresse>() { adresse1 };
            List<Adresse> adresses2 = new List<Adresse>() { adresse2 };

            Client client1 = new Client(code1, "Kristopher", "Maltais", adresses1);
            Client client2 = new Client(code2, "André", "Nicole", adresses2);
            List<Client> clients = new List<Client>() { client1, client2 };

            Mock<IDepotClients> mockDepotClient = new Mock<IDepotClients>();
            mockDepotClient.Setup(c => c.ListerClients()).Returns(clients);

            ModifierPaysMajusculesClientsTraitementLot traitementLot = new ModifierPaysMajusculesClientsTraitementLot(mockDepotClient.Object);

            // Act
            traitementLot.Executer();

            // Assert
            mockDepotClient.Verify(m => m.ListerClients(), Times.Once);
            mockDepotClient.Verify(m => m.ModifierClient(It.IsAny<Client>()), Times.Exactly(1));
            mockDepotClient.VerifyNoOtherCalls();
        }
        [Fact]
        public void Executer_MiseAJourAucunClientCorrect_retour()
        {
            // Arrange
            Guid code1 = Guid.NewGuid();
            Guid code2 = Guid.NewGuid();
            Adresse adresse1 = new Adresse(code1, "1232", "pas de lettre", "boule", "avenue", "G8B1V3", "Québec", "Québec", "canada");
            Adresse adresse2 = new Adresse(code2, "1222", "pas de lettre", "ste-foy", "chemin", "G8B1V2", "Québec", "Québec", "canada");
            List<Adresse> adresses1 = new List<Adresse>() { adresse1 };
            List<Adresse> adresses2 = new List<Adresse>() { adresse2 };

            Client client1 = new Client(code1, "Kristopher", "Maltais", adresses1);
            Client client2 = new Client(code2, "André", "Nicole", adresses2);
            List<Client> clients = new List<Client>() { client1, client2 };

            Mock<IDepotClients> mockDepotClient = new Mock<IDepotClients>();
            mockDepotClient.Setup(c => c.ListerClients()).Returns(clients);

            ModifierPaysMajusculesClientsTraitementLot traitementLot = new ModifierPaysMajusculesClientsTraitementLot(mockDepotClient.Object);

            // Act
            traitementLot.Executer();

            // Assert
            mockDepotClient.Verify(m => m.ListerClients(), Times.Once);
            mockDepotClient.Verify(m => m.ModifierClient(It.IsAny<Client>()), Times.Exactly(2));
            mockDepotClient.VerifyNoOtherCalls();
        }
    }
}
