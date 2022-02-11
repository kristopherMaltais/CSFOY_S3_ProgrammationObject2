using System;
using System.Collections.Generic;
using TraitementImage_LibrairieClasse;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TraitementImage_UI
{
    public partial class fTraitementImage : Form
    {
        // ** Champs ** //
        private ImageManipulable m_imageManipulable;
        // ** Propriétés ** //

        // ** Constructeurs ** //
        public fTraitementImage()
        {
            InitializeComponent();
        }

        // ** Méthodes **
        private void fTraitementImage_Load(object sender, EventArgs e)
        {
            IEnumerable<CreateurTraitement> traitements =  UtilitaireTraitements.RechercherTraitementsImage();

            foreach(CreateurTraitement traitement in traitements)
            {
                cbTraitementAAjouter.Items.Add(traitement);
            }

        }
        private void tsmiOuvrir_Click(object sender, EventArgs e)
        {
            OpenFileDialog ouvrirImage = new OpenFileDialog();
            ImageManipulable imageChoisie = null;
            ouvrirImage.Filter = "Image Files(*.jpeg; *.jpg;)|*.jpeg; *.jpg;";

            if(ouvrirImage.ShowDialog() == DialogResult.OK)
            {
                imageChoisie = new ImageManipulable(ouvrirImage.FileName);
            }

            this.m_imageManipulable = imageChoisie;
            pbImage.Image = imageChoisie.Image;
        }
        private void bAjouterTraitement_Click(object sender, EventArgs e)
        {

            if (cbTraitementAAjouter.SelectedItem is not null)
            { 
                lbSuiteTraitementsAAppliquer.Items.Add(cbTraitementAAjouter.SelectedItem);
            }
        }
        private void bAppliquerSuiteTraitements_Click(object sender, EventArgs e)
        {
            CreateurTraitement[] traitements = new CreateurTraitement[lbSuiteTraitementsAAppliquer.Items.Count];
            lbSuiteTraitementsAAppliquer.Items.CopyTo(traitements, 0);

            ITraitementImage traitementAEffectuer = CreerChaineTraitement(traitements);

            traitementAEffectuer.TraiterImage(m_imageManipulable);
            pbImage.Image = m_imageManipulable.Image;

        }
        private void bSupprimerTraitement_Click(object sender, EventArgs e)
        {
            if (lbSuiteTraitementsAAppliquer.SelectedItem is not null)
            {
                int indexSelectionne = lbSuiteTraitementsAAppliquer.SelectedIndex;
                lbSuiteTraitementsAAppliquer.Items.RemoveAt(indexSelectionne);
            }
        }
        private void bSuiteTraitementsDeplacerHaut_Click(object sender, EventArgs e)
        {
            if(lbSuiteTraitementsAAppliquer.SelectedIndex != 0)
            {
                var traitementADeplacer = lbSuiteTraitementsAAppliquer.SelectedItem;
                int indexSelectionne = lbSuiteTraitementsAAppliquer.SelectedIndex;

                lbSuiteTraitementsAAppliquer.Items[indexSelectionne] = lbSuiteTraitementsAAppliquer.Items[indexSelectionne - 1];
                lbSuiteTraitementsAAppliquer.Items[indexSelectionne - 1] = traitementADeplacer;

                lbSuiteTraitementsAAppliquer.SelectedItem = lbSuiteTraitementsAAppliquer.Items[indexSelectionne - 1];
            }
        }
        private void bSuiteTraitementsDeplacerBas_Click(object sender, EventArgs e)
        {
            if (lbSuiteTraitementsAAppliquer.SelectedIndex != lbSuiteTraitementsAAppliquer.Items.Count - 1)
            {
                var traitementADeplacer = lbSuiteTraitementsAAppliquer.SelectedItem;
                int indexSelectionne = lbSuiteTraitementsAAppliquer.SelectedIndex;

                lbSuiteTraitementsAAppliquer.Items[indexSelectionne] = lbSuiteTraitementsAAppliquer.Items[indexSelectionne + 1];
                lbSuiteTraitementsAAppliquer.Items[indexSelectionne + 1] = traitementADeplacer;

                lbSuiteTraitementsAAppliquer.SelectedItem = lbSuiteTraitementsAAppliquer.Items[indexSelectionne + 1];
            }
        }
        private void lbSuiteTraitementsAAppliquer_SelectedIndexChanged(object sender, EventArgs e)
        {
            CreateurTraitement proprietesTraitementAAfficher = (CreateurTraitement)lbSuiteTraitementsAAppliquer.SelectedItem;
            pgProprieteTraitementSelectionne.SelectedObject = proprietesTraitementAAfficher is null ? null : proprietesTraitementAAfficher.Creer();


        }
        private ITraitementImage CreerChaineTraitement(CreateurTraitement[] p_traitements)
        {
            ITraitementImage chaineTraitement = null;
            ITraitementImage dernierTraitementAjoute = null;
            for (int index = 0; index < lbSuiteTraitementsAAppliquer.Items.Count; index++)
            {
                if(index == 0)
                {
                    chaineTraitement = p_traitements[index].Creer();
                    dernierTraitementAjoute = chaineTraitement;
                }
                else
                {
                    dernierTraitementAjoute.Suivant = p_traitements[index].Creer();
                    dernierTraitementAjoute = dernierTraitementAjoute.Suivant;
                }

            }

            return chaineTraitement;
        }
    }
}
