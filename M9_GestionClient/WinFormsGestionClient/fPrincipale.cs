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

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        // ** Methodes ** //


    }
}
