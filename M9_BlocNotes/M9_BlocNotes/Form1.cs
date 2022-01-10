using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace M9_BlocNotes
{
    public partial class Form1 : Form
    {
        // ** Champs ** //
        private string m_nomFichier;

        // ** Propriétés ** //

        // ** Constructeurs ** //
        public Form1()
        {
            InitializeComponent();
        }

        // ** Méthodes ** //
        private void tsmiNouveau_Click(object sender, EventArgs e)
        {
            tbTexte.Text = String.Empty;
        }
        private void tsmiOuvrir_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Fichier texte (*.txt)|*.txt";
            DialogResult dr = ofd.ShowDialog();

            if(dr == DialogResult.OK)
            {
                tbTexte.Text = File.ReadAllText(ofd.FileName);
            }

            m_nomFichier = ofd.FileName;
        }
        private void tsmiEnregistrer_Click(object sender, EventArgs e)
        {
            if(tbTexte.Text != String.Empty && m_nomFichier is not null)
            {
                File.WriteAllText(m_nomFichier, tbTexte.Text);
            }
        }
        private void tsmiEnregistrerSous_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog sfd = new SaveFileDialog())
            {
                sfd.Filter = "Fichier texte (*.txt)|*.txt";

                if(sfd.ShowDialog() == DialogResult.OK)
                {
                    File.WriteAllText(sfd.FileName, tbTexte.Text);
                }
            }
        }
        private void tsmiQuitter_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
