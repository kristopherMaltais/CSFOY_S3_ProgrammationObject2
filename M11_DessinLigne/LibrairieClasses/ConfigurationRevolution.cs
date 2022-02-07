using System;
using System.Drawing;

namespace LibrairieClasses
{
    public class ConfigurationRevolution
    {   
        // ** Champs ** //

        // ** Propriétés ** //
        public int Angle { get; private set; }
        public int Longueur { get; private set; }
        public int NombreLigne { get; private set; }
        public int Pas { get; private set; }
        public Point PositionDepart { get; private set; }

        // ** Constructeurs ** //
        public ConfigurationRevolution(int p_angle, int p_longueur, int p_nombreLigne, int p_pas, Point p_positionDepart)
        {
            this.Angle = p_angle;
            this.Longueur = p_longueur;
            this.NombreLigne = p_nombreLigne;
            this.Pas = p_pas;
            this.PositionDepart = p_positionDepart;
        }

        // ** Méthodes ** //

    }
}
