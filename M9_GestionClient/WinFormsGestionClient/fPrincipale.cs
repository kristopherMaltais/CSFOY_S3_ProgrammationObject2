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
    public partial class fPrincipale : Form
    {
        // ** champs ** //
        private IDepotClients m_depotClient;

        // ** propriétés ** //

        // ** Constructeur ** //
        public fPrincipale(IDepotClients p_depotClient)
        {
            InitializeComponent();
            m_depotClient = p_depotClient;
        }

        // ** Methodes ** //
        private void tbRechercheClient_TextChanged(object sender, EventArgs e)
        {
            
            lbClients.Items.Clear();

            Client[] clientsTrouves = m_depotClient.RechercherClients(tbRechercheClient.Text).ToArray();

            if (!String.IsNullOrEmpty(tbRechercheClient.Text))
            {
                lbClients.Items.AddRange(clientsTrouves);
            }
        }
        private void bNouveau_Click(object sender, EventArgs e)
        {
            fSaisieClient fenetreSaisieClient = new fSaisieClient();
            fenetreSaisieClient.ShowDialog(this);

            if (fenetreSaisieClient.DialogResult == DialogResult.OK)
            {
                m_depotClient.AjouterClient(fenetreSaisieClient.ResultatClient);
            }
        }
        private void lbClients_DoubleClick(object sender, EventArgs e)
        {
            fSaisieClient fenetreSaisieClient = new fSaisieClient((Client)lbClients.SelectedItem);
            fenetreSaisieClient.ShowDialog(this);

            if (fenetreSaisieClient.DialogResult == DialogResult.OK)
            {
                tbRechercheClient.Text = "";
                m_depotClient.ModifierClient(fenetreSaisieClient.ResultatClient);
            }

        }
    }
}
