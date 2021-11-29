using System;

namespace LibrairieClasses
{
    public class Matrice2D
    {
        // ** Champs ** //
        private float[,] m_donnees2D;

        // ** Propriétés ** //
        public float this[int p_ligne, int p_colonne]
        {

            get
            {
                // Préconditions
                if(p_ligne < 0 || p_ligne >= this.NombreDeLignes)
                {
                    throw new ArgumentOutOfRangeException("La valeur p_ligne doit est supérieur ou égal à zéro et inférieur au nombre de ligne", "p_ligne");
                }

                if (p_colonne < 0 || p_colonne >= this.NombreDeColonnes)
                {
                    throw new ArgumentOutOfRangeException("La valeur p_colonne doit est supérieur ou égal à zéro et inférieur au nombre de colonne", "p_colonne");
                }

                return m_donnees2D[p_ligne, p_colonne];
            }

            set
            {
                // Préconditions
                if (p_ligne < 0 || p_ligne >= this.NombreDeLignes)
                {
                    throw new ArgumentOutOfRangeException("La valeur p_ligne doit est supérieur ou égal à zéro et inférieur au nombre de ligne", "p_ligne");
                }

                if (p_colonne < 0 || p_colonne >= this.NombreDeColonnes)
                {
                    throw new ArgumentOutOfRangeException("La valeur p_colonne doit est supérieur ou égal à zéro et inférieur au nombre de colonne", "p_colonne");
                }

                m_donnees2D[p_ligne, p_colonne] = value;
            }
        }
        public int NombreDeLignes { get => m_donnees2D.GetLength(0); }
        public int NombreDeColonnes { get => m_donnees2D.GetLength(1); }

        // ** Constructeurs ** //
        public Matrice2D(int p_nombreLigne, int p_nombreColonne)
        {
            // Préconditions
            if(p_nombreLigne <= 0)
            {
                throw new ArgumentOutOfRangeException("Le nombre de ligne doit être supérieur à zéro", "p_nombreLigne");
            }

            if(p_nombreColonne <= 0)
            {
                throw new ArgumentOutOfRangeException("Le nombre de colonne doit être supérieur à zéro", "p_nombreColonne");
            }

            m_donnees2D = new float[p_nombreLigne, p_nombreColonne];
        }
        public Matrice2D(float[,] p_tableau2D)
        {
            // Préconditon
            if(p_tableau2D == null)
            {
                throw new ArgumentNullException("Le tableau ne peut pas être null", "p_tableau2D");
            }

            m_donnees2D = p_tableau2D;
        }

        // ** Méthodes ** //
        public override bool Equals(object p_matriceAComparer)
        {
            // Préconditions
            if(p_matriceAComparer == null)
            {
                throw new ArgumentNullException("l'objet ne peut pas être null", "p_matriceAComparer");
            }

            Matrice2D matriceAComparer = p_matriceAComparer as Matrice2D;
            bool matriceEgale = true;

            if(matriceAComparer == null)
            {
                matriceEgale = false;
            }

            else if(this.NombreDeLignes != matriceAComparer.NombreDeLignes || this.NombreDeColonnes != matriceAComparer.NombreDeColonnes)
            {
                matriceEgale = false;
            }

            for(int ligne = 0; matriceEgale && ligne < this.NombreDeLignes; ligne++)
            {
                for (int colonne = 0; matriceEgale && colonne < this.NombreDeColonnes; colonne++)
                {
                    if(this[ligne, colonne] != matriceAComparer[ligne, colonne])
                    {
                        matriceEgale = false;
                    }
                }
            }

            return matriceEgale;
        }
        public static Matrice2D MatriceIdentite(int p_dimensionMatrice)
        {
            Matrice2D matriceIdentite = new Matrice2D(p_dimensionMatrice, p_dimensionMatrice);
            float diagonalePrincipale = 1f;
            float horsDiagonalePrincipale = 0f;

            for (int ligne = 0; ligne < matriceIdentite.NombreDeLignes; ligne++)
            {
                for (int colonne = 0; colonne < matriceIdentite.NombreDeColonnes; colonne++)
                {
                    matriceIdentite[ligne, colonne] = ligne == colonne ? diagonalePrincipale : horsDiagonalePrincipale;
                }
            }

            return matriceIdentite;
        }
        public static Matrice2D MatriceTransposee(Matrice2D p_matriceATransposer)
        {
            // Préconditions
            if(p_matriceATransposer == null)
            {
                throw new ArgumentNullException("La matrice ne peut pas être null", "p_matriceATransposer");
            }

            Matrice2D matriceTransposee = new Matrice2D(p_matriceATransposer.NombreDeColonnes, p_matriceATransposer.NombreDeLignes);

            for (int ligne = 0; ligne < matriceTransposee.NombreDeLignes; ligne++)
            {
                for (int colonne = 0; colonne < matriceTransposee.NombreDeColonnes; colonne++)
                {
                    matriceTransposee[ligne, colonne] = p_matriceATransposer[colonne, ligne];
                }
            }

            return matriceTransposee;
        }

        // ** Opérateurs ** //
        public static Matrice2D operator + (Matrice2D p_matrice1, Matrice2D p_matrice2)
        {
            // Précondition
            if(p_matrice1 == null)
            {
                throw new ArgumentNullException("La matrice ne peut pas être null", "p_matrice1");
            }

            if (p_matrice2 == null)
            {
                throw new ArgumentNullException("La matrice ne peut pas être null", "p_matrice2");
            }

            if (p_matrice1.NombreDeLignes != p_matrice2.NombreDeLignes || p_matrice1.NombreDeColonnes != p_matrice2.NombreDeColonnes)
            {
                throw new MatriceDimensionsInvalidesException("Les matrices doivent avoir la même dimension");
            }

            Matrice2D matriceSomme = new Matrice2D(p_matrice1.NombreDeLignes, p_matrice2.NombreDeColonnes);

            for (int ligne = 0; ligne < p_matrice1.NombreDeLignes; ligne++)
            {
                for (int colonne = 0; colonne < p_matrice1.NombreDeColonnes; colonne++)
                {
                    matriceSomme[ligne, colonne] = p_matrice1[ligne, colonne] + p_matrice2[ligne, colonne];
                }
            }

            return matriceSomme;

        }
        public static Matrice2D operator - (Matrice2D p_matrice1, Matrice2D p_matrice2)
        {
            // Précondition
            if (p_matrice1 == null)
            {
                throw new ArgumentNullException("La matrice ne peut pas être null", "p_matrice1");
            }

            if (p_matrice2 == null)
            {
                throw new ArgumentNullException("La matrice ne peut pas être null", "p_matrice2");
            }

            if (p_matrice1.NombreDeLignes != p_matrice2.NombreDeLignes || p_matrice1.NombreDeColonnes != p_matrice2.NombreDeColonnes)
            {
                throw new MatriceDimensionsInvalidesException("Les matrices doivent avoir la même dimension");
            }

            Matrice2D matriceSomme = new Matrice2D(p_matrice1.NombreDeLignes, p_matrice2.NombreDeColonnes);

            for (int ligne = 0; ligne < p_matrice1.NombreDeLignes; ligne++)
            {
                for (int colonne = 0; colonne < p_matrice1.NombreDeColonnes; colonne++)
                {
                    matriceSomme[ligne, colonne] = p_matrice1[ligne, colonne] - p_matrice2[ligne, colonne];
                }
            }

            return matriceSomme;
        }
        public static Matrice2D operator * (Matrice2D p_matrice1, Matrice2D p_matrice2)
        {
            // Précondition
            if (p_matrice1 == null)
            {
                throw new ArgumentNullException("La matrice ne peut pas être null", "p_matrice1");
            }

            if (p_matrice2 == null)
            {
                throw new ArgumentNullException("La matrice ne peut pas être null", "p_matrice2");
            }

            if (p_matrice1.NombreDeColonnes != p_matrice2.NombreDeLignes)
            {
                throw new MatriceDimensionsInvalidesException("Les matrices doivent avoir le même nombre de colonnes et de lignes");
            }

            Matrice2D matriceProduit = new Matrice2D(p_matrice1.NombreDeLignes, p_matrice2.NombreDeColonnes);

            for (int ligne = 0; ligne < matriceProduit.NombreDeLignes; ligne++)
            {
                for (int colonne = 0; colonne < matriceProduit.NombreDeColonnes; colonne++)
                {
                    float total = 0;
                    for (int index = 0; index < p_matrice1.NombreDeColonnes; index++)
                    {
                        total += p_matrice1[ligne, index] * p_matrice2[index, colonne];
                    }
                    matriceProduit[ligne, colonne] = total;
                }
            }

            return matriceProduit;
        }
        public static Matrice2D operator * (Matrice2D p_matrice, int p_scalaire)
        {
            // Préconditions
            if(p_matrice == null)
            {
                throw new ArgumentNullException("La matrice ne peut pas être null", "p_matrice");
            }

            Matrice2D matriceProduit = new Matrice2D(p_matrice.NombreDeLignes, p_matrice.NombreDeColonnes);

            for (int ligne = 0; ligne < p_matrice.NombreDeLignes; ligne++)
            {
                for (int colonne = 0; colonne < p_matrice.NombreDeColonnes; colonne++)
                {
                    matriceProduit[ligne, colonne] = p_matrice[ligne, colonne] * p_scalaire;
                }
            }

            return matriceProduit;
        }

    }
}
