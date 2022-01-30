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
    public partial class fPrincipale : Form
    {
        // ** Champs ** //
        private Facture m_facture;
        private ObservateurFacture m_observateur;
        private fClient m_client;
        private fImprimante m_imprimante;

        // ** Propriétés ** //


        // ** Constructeurs ** //
        public fPrincipale()
        {
            InitializeComponent();
            this.m_facture = new Facture();
            this.m_client = new fClient(this.m_facture);
            this.m_imprimante = new fImprimante(this.m_facture);
            
            this.m_observateur = new ObservateurFacture(
                factureEvent =>
                {
                    if (factureEvent.Type == Evement.AJOUTlIGNE)
                    {
                        string[] row = new string[] { factureEvent.LigneFacture.Description, factureEvent.LigneFacture.Quantite.ToString(), factureEvent.LigneFacture.Prix.ToString(), factureEvent.LigneFacture.Total.ToString() };
                        this.dataGridView1.Rows.Add(row);
                        this.tbTotal.Text = factureEvent.Facture.Total.ToString();
                    }
                    else
                    {
                        dataGridView1.Rows.Clear();
                    }

                },
                m_facture
                );
        }

        // ** Méthodes ** //
        private void bSimuler_Click(object sender, EventArgs e)
        {
            LigneFacture nouvelleLigneFacture = new LigneFacture(tbDescription.Text, (int)nQuantite.Value, nPrix.Value);
            this.m_facture.AjouterLigneFacture(nouvelleLigneFacture);

            tbDescription.Text = "";
            nQuantite.Text = "";
            nPrix.Text = "";
        }
        private void button1_Click(object sender, EventArgs e)
        {
            this.m_facture.SupprimerLignesFacture();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            this.m_client.Show();
            this.m_imprimante.Show();
        }
    }
}
