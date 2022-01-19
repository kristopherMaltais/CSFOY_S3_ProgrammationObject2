using Module08_Exercice01_Base_Console.Entites;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsGestionClient
{
    public partial class fSaisieClient : Form
    {
        // ** champs ** //
        private Client m_client;
        private Client m_resultat;

        // ** Propriété ** //
        public bool Nouveau
        {
            get => this.m_client is null;
        }
        public Client ResultatClient
        {
            get => this.m_resultat;

            private set
            {
                this.m_resultat = value;
            }
        }

        // ** Constructeurs ** //
        public fSaisieClient(Client p_client = null)
        {
            InitializeComponent();
            this.m_client = p_client;
        }

        // ** Méthodes ** //
        private void bEnregistrerClient_Click(object sender, EventArgs e)
        {
            Client nouveauClient;
            List<Adresse> listeAdresseVide = new List<Adresse>();
            Guid numeroUnique;
            if (Nouveau)
            {
                numeroUnique = Guid.NewGuid();
                nouveauClient = new Client(numeroUnique, tNomClient.Text, tPrenomClient.Text, listeAdresseVide);
            }
            else
            {
                numeroUnique = m_client.ClientId;
                nouveauClient = new Client(numeroUnique, tNomClient.Text, tPrenomClient.Text, listeAdresseVide);
            }

            this.m_resultat = nouveauClient;
        }
        private void fSaisieClient_Load(object sender, EventArgs e)
        {
            if (Nouveau)
            {
                this.Text = "Saisie d'un nouveau client";
            }
            else
            {
                this.Text = "Modification d'un client";
            }

            if (!Nouveau)
            {
                tNomClient.Text = m_client.Nom;
                tPrenomClient.Text = m_client.Prenom;
            }
        }
    }
}
