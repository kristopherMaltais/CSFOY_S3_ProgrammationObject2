using LibrairieClasses;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class fClient : Form
    {
        // ** Champs ** //
        private Facture m_facture;
        private ObservateurFacture m_observateur;
        private const string m_messageBienvenu = "Bienvenue";
        // ** Propriétés ** //

        // ** Constructeur ** //

        // ** Méthodes ** //
        public fClient(Facture p_facture)
        {
            InitializeComponent();
            this.m_facture = p_facture;
            this.m_observateur = new ObservateurFacture(
                factureEvent =>
                {
                    if(factureEvent.Type == Evement.AJOUTlIGNE)
                    {
                        tbInformationsClient.Text = factureEvent.LigneFacture.ToString();
                    }
                    else
                    {
                        tbInformationsClient.Text = m_messageBienvenu;
                    }
                },
                m_facture
                );
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            tbInformationsClient.Text = m_messageBienvenu;
        }
    }
}
