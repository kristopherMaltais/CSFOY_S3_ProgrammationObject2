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
    public partial class fImprimante : Form
    {
        // ** Champs ** //
        private Facture m_facture;
        private ObservateurFacture m_observateur;
        private const string m_signature = "** Metro Mon Épicier - 2650 Chemin Ste-Foy **";
        // ** Propriétés ** //

        // ** Constructeurs ** //

        public fImprimante(Facture p_facture)
        {
            InitializeComponent();
            this.m_facture = p_facture;
            this.m_observateur = new ObservateurFacture(
                factureEvent =>
                {
                    string nouvelleLigne = Environment.NewLine;
                    if (factureEvent.Type == Evement.AJOUTlIGNE)
                    {
                        if (m_facture.LignesFacture.Count == 1)
                        {
                            tbImprimante.Text = "";
                            tbImprimante.Text += m_signature + nouvelleLigne + nouvelleLigne;
                            tbImprimante.Text += factureEvent.LigneFacture.ToString() + nouvelleLigne;
                        }
                        else
                        {
                            tbImprimante.Text += factureEvent.LigneFacture.ToString() + nouvelleLigne;
                        }
                    }
                    else
                    {
                        tbImprimante.Text += nouvelleLigne + "Total: " + this.m_facture.Total.ToString() + nouvelleLigne;
                        tbImprimante.Text += "MERCI D'AVOIR FAIT AFFAIRE AVEC NOUS :)";
                    }
                    
                },
                this.m_facture
                ); ;
        }

        // ** Méthodes ** //
        
    }
}
