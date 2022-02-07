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

namespace ApplicationGraphique_Winform
{
    public partial class fRevolutionLignes : Form
    {
        // ** Champs ** //

        // ** Propriétés ** //

        // ** Contructeurs ** //
        public fRevolutionLignes()
        {
            InitializeComponent();
        }

        // ** Méthodes ** //
        private ConfigurationRevolution EtablirConfiguration()
        {
            int y = pCanvas.Height / 2;
            int x = pCanvas.Width / 2;

            Point centre = new Point(y, x);
            ConfigurationRevolution nouvelleConfiguration = new ConfigurationRevolution((int)nudAngle.Value, (int)nudLongueur.Value, (int)nubNombreLigne.Value, (int)nudPas.Value, centre);
            return nouvelleConfiguration;
        }
        public void Dessiner(ConfigurationRevolution p_configuration)
        {
            Point[] points = DessinRevolution.GenererPoints(p_configuration);
            Pen crayon = new Pen(Color.Black);

            using (Graphics graphique = pCanvas.CreateGraphics())
            {
                graphique.Clear(Color.White);
                for (int index = 0; index < points.Length - 1; index++)
                {
                    graphique.DrawLine(crayon, points[index], points[index + 1]);
                }
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            ConfigurationRevolution configuration = EtablirConfiguration();
            Dessiner(configuration);
        }
    }
}
