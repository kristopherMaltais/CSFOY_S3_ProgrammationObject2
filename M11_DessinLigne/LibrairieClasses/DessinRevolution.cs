using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibrairieClasses
{
    public class DessinRevolution
    {
        // ** Champs ** //

        // ** Propriétés ** //

        // ** Constructeurs ** //

        // ** Méthodes ** //
        public static Point[] GenererPoints(ConfigurationRevolution p_configuration)
        {
            Point[] points = new Point[p_configuration.NombreLigne + 1];

            points[0] = p_configuration.PositionDepart;
            double angle = 0;
            double anglePas = ConversionAngleRadian(p_configuration.Angle);
            int longueur = p_configuration.Longueur;

            for (int index = 1; index < points.Length; index++)
            {
                points[index] = PositionSuivante(points[index - 1], angle, longueur);
                longueur += p_configuration.Pas;
                angle += anglePas;
            }

            return points;
        }
        private static Point PositionSuivante(Point p_positionActuelle, double p_angle, int p_longueur)
        {
            Point nouveauPoint = new Point();
            nouveauPoint.Y = (int)(p_positionActuelle.Y + Math.Sin(p_angle) * p_longueur);
            nouveauPoint.X = (int)(p_positionActuelle.X + Math.Cos(p_angle) * p_longueur);

            return nouveauPoint;
        }
        private static double ConversionAngleRadian(int p_angle)
        {
            double angleRadian = (p_angle * Math.PI) / 180;
            return angleRadian;
        }

    }
}
