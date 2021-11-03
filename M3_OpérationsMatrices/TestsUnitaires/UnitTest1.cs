using System;
using Xunit;
using LibrairieClasses;

namespace TestsUnitaires
{
    public class UnitTest1
    {
        #region Constructeur

        [Fact]
        public void CtrDimensions_PreconditionLignes_LanceException()
        {
            // Arrange
            int nommbreLigne = 0;
            int nombreColonne = 3;

            // Act and Assert
            Assert.Throws<ArgumentOutOfRangeException>(() => { new Matrice2D(nommbreLigne, nombreColonne); });
            
        }

        [Fact]
        public void CtrDimensions_PreconditionColonnes_LanceException()
        {
            // Arrange
            int nombreLigne = 3;
            int nombreColonne = 0;

            // Act and Assert
            Assert.Throws<ArgumentOutOfRangeException>(() => { new Matrice2D(nombreLigne, nombreColonne); });

        }

        [Fact]
        public void CtrDimensions_InitialiseLignesEtColonnes_BonnesDimensions()
        {
            // Arrange
            int nombreLigne = 3;
            int nombreColonne = 4;

            int nombreLigneAttendu = 3;
            int nombreColonneAttendu = 4;

            // Act
            Matrice2D matrice = new Matrice2D(nombreLigne, nombreColonne);

            // Assert
            Assert.Equal(nombreLigneAttendu, matrice.NombreDeLignes);
            Assert.Equal(nombreColonneAttendu, matrice.NombreDeColonnes);
        }

        [Fact]
        public void ctrTableau_PreconditionTableauNull_LanceException()
        {
            // Arrange
            float[,] tableauNull = null;

            // Act and Assert
            Assert.Throws<ArgumentNullException>(() => { new Matrice2D(tableauNull); });
        }

        [Fact]
        public void ctrTableau_InitialiseMatrice_BonnesDimensionsBonnesValeurs()
        {
            // Arrange
            float[,] tableauDeuxDimensions = new float[,] { { 1f, 3f }, { 5f, 4f } };
            Matrice2D matriceAttendue = new Matrice2D(tableauDeuxDimensions);
            int nombreLigneAttendu = 2;
            int nombreColonneAttendu = 2;


            // Act
            Matrice2D matriceObtenue = new Matrice2D(tableauDeuxDimensions);

            // Assert
            Assert.True(matriceObtenue.Equals(matriceAttendue));
            Assert.Equal(nombreLigneAttendu, matriceObtenue.NombreDeLignes);
            Assert.Equal(nombreColonneAttendu, matriceObtenue.NombreDeColonnes);




        }

        #endregion

        #region Proprietes
        
        [Fact]
        public void OperateurCrochetGet_PreconditionLigneIndexInferieurZero_LanceException()
        {
            // Arrange
            int indexLigne = -1;
            int indexColonne = 1;

            float[,] tableau = new float[,]
            {
                {1, 2},
                {3, 5}
            };

            Matrice2D matrice = new Matrice2D(tableau);
            float valeur = 0f;

            // Act and Assert
            Assert.Throws<ArgumentOutOfRangeException>(() => { valeur = matrice[indexLigne, indexColonne]; });
        }

        [Fact]
        public void OperateurCrochetGet_PreconditionLigneIndexHorsCapacite_LanceException()
        {
            // Arrange
            int indexLigne = 2;
            int indexColonne = 1;

            float[,] tableau = new float[,]
            {
                {1, 2},
                {3, 5}
            };

            Matrice2D matrice = new Matrice2D(tableau);
            float valeur = 0f;

            // Act and Assert
            Assert.Throws<ArgumentOutOfRangeException>(() => { valeur = matrice[indexLigne, indexColonne]; });
        }

        [Fact]
        public void OperateurCrochetGet_PreconditionColonneIndexInferieurZero_LanceException()
        {
            // Arrange
            int indexLigne = 1;
            int indexColonne = -1;

            float[,] tableau = new float[,]
            {
                {1, 2},
                {3, 5}
            };

            Matrice2D matrice = new Matrice2D(tableau);
            float valeur = 0f;

            // Act and Assert
            Assert.Throws<ArgumentOutOfRangeException>(() => { valeur = matrice[indexLigne, indexColonne]; });
        }

        [Fact]
        public void OperateurCrochetGet_PreconditionColonneIndexHorsCapacite_LanceException()
        {
            // Arrange
            int indexLigne = 1;
            int indexColonne = 2;

            float[,] tableau = new float[,]
            {
                {1, 2},
                {3, 5}
            };

            Matrice2D matrice = new Matrice2D(tableau);
            float valeur = 0f;

            // Act and Assert
            Assert.Throws<ArgumentOutOfRangeException>(() => { valeur = matrice[indexLigne, indexColonne]; });
        }

        [Fact]
        public void OperateurCrochetGet_ChangerValeur_AjouteBonneValeurBonnePosition()
        {
            // Arrange
            float[,] tableau = new float[,]
            {
                {1, 2},
                {3, 5}
            };

            Matrice2D matrice = new Matrice2D(tableau);

            int indexLigne = 1;
            int indexColonne = 1;

            float valeurAttendue = 5;

            // Act
            float valeurObtenue = matrice[indexLigne, indexColonne];

            // Assert
            Assert.Equal(valeurAttendue,valeurObtenue);
        }

        [Fact]
        public void OperateurCrochetSet_PreconditionLigneIndexInferieurZero_LanceException()
        {
            // Arrange
            int indexLigne = -1;
            int indexColonne = 1;

            float[,] tableau = new float[,]
            {
                {1, 2},
                {3, 5}
            };

            Matrice2D matrice = new Matrice2D(tableau);
            float valeurAAjouter = 2f;

            // Act and Assert
            Assert.Throws<ArgumentOutOfRangeException>(() => {matrice[indexLigne, indexColonne] = valeurAAjouter; });
        }

        [Fact]
        public void OperateurCrochetSet_PreconditionLigneIndexHorsCapacite_LanceException()
        {
            // Arrange
            int indexLigne = 2;
            int indexColonne = 1;

            float[,] tableau = new float[,]
            {
                {1, 2},
                {3, 5}
            };

            Matrice2D matrice = new Matrice2D(tableau);
            float valeurAAjouter = 2f;

            // Act and Assert
            Assert.Throws<ArgumentOutOfRangeException>(() => { matrice[indexLigne, indexColonne] = valeurAAjouter; });
        }

        [Fact]
        public void OperateurCrochetSet_PreconditionColonneIndexInferieurZero_LanceException()
        {
            // Arrange
            int indexLigne = 1;
            int indexColonne = -1;

            float[,] tableau = new float[,]
            {
                {1, 2},
                {3, 5}
            };

            Matrice2D matrice = new Matrice2D(tableau);
            float valeurAAjouter = 2f;

            // Act and Assert
            Assert.Throws<ArgumentOutOfRangeException>(() => { matrice[indexLigne, indexColonne] = valeurAAjouter; });
        }

        [Fact]
        public void OperateurCrochetSet_PreconditionColonneIndexHorsCapacite_LanceException()
        {
            // Arrange
            int indexLigne = 1;
            int indexColonne = 2;

            float[,] tableau = new float[,]
            {
                {1, 2},
                {3, 5}
            };

            Matrice2D matrice = new Matrice2D(tableau);
            float valeurAAjouter = 2f;

            // Act and Assert
            Assert.Throws<ArgumentOutOfRangeException>(() => { matrice[indexLigne, indexColonne] = valeurAAjouter; });
        }

        [Fact]
        public void OperateurCrochetSet_ChangerValeur_AjouteBonneValeurBonnePosition()
        {
            // Arrange
            float[,] tableau = new float[,]
            {
                {1, 2},
                {3, 5}
            };

            Matrice2D matrice = new Matrice2D(tableau);

            float valeurAChanger = 3;
            int indexLigne = 0;
            int indexColonne = 0;

            float valeurAttendue = 3;

            // Act
            matrice[indexLigne, indexColonne] = valeurAChanger;

            // Assert
            Assert.Equal(valeurAttendue, matrice[indexLigne, indexColonne]);
        }

        [Fact]
        public void NombreDeLignes_ObtenirNombreDeLignes_RetourneNombreLignesExact()
        {
            // Arrange
            float[,] tableau = new float[,]
            {
                {1, 2},
                {3, 5}
            };

            Matrice2D matrice = new Matrice2D(tableau);
            int nombreLigneAttendu = 2;

            // Act
            int nombreLigneObtenu = matrice.NombreDeLignes;

            // Assert
            Assert.Equal(nombreLigneAttendu, nombreLigneObtenu);
        }

        [Fact]
        public void NombreDeColonnes_ObtenirNombreDeColonnes_RetourneNombreColonnesExact()
        {
            // Arrange
            float[,] tableau = new float[,]
            {
                {1, 2},
                {3, 5}
            };

            Matrice2D matrice = new Matrice2D(tableau);
            int nombreColonneAttendu = 2;

            // Act
            int nombreColonneObtenu = matrice.NombreDeColonnes;

            // Assert
            Assert.Equal(nombreColonneAttendu, nombreColonneObtenu);
        }
        #endregion

        #region methodes

        [Fact]
        public void Equals_PreconditionObjetNull_LanceException()
        {
            // Arrange
            Object objetNull = null;

            float[,] tableau = new float[,]
            {
                {1, 2, 3},
                {3, 5, 2},
                {8, 2, 1}
            };

            Matrice2D matrice = new Matrice2D(tableau);

            // Act
            Assert.Throws<ArgumentNullException>(() => { matrice.Equals(objetNull); });
        }
        
        [Fact]
        public void Equals_ComparerMatriceNull_RetourneFalse()
        {
            // Arrange
            float[,] tableau = new float[,]
            {
                {1, 2, 3},
                {3, 5, 2},
                {8, 2, 1}
            };

            Matrice2D matrice = new Matrice2D(tableau);
            String pasUneMatrice = "aaa";

            // Act
            bool comparaisonObtenu = matrice.Equals(pasUneMatrice);

            // Assert
            Assert.False(comparaisonObtenu);
        }
        
        [Fact]
        public void Equals_MatriceDimensionsDifferentes_RetourneFalse()
        {
            // Arrange
            float[,] tableau1 = new float[,]
            {
                {1, 2, 3},
                {3, 5, 2},
                {8, 2, 1}
            };

            Matrice2D matrice1 = new Matrice2D(tableau1);

            float[,] tableau2 = new float[,]
            {
                {1, 2},
                {3, 5},
                {8, 2}
            };

            Matrice2D matrice2 = new Matrice2D(tableau2);

            // Act
            bool matriceDimensionEgale =  matrice1.Equals(matrice2);

            // Act
            Assert.False(matriceDimensionEgale);
        }

        [Fact]
        public void Equals_MatriceDimensionsEgalesValeurDifferente_RetourneFalse()
        {
            // Arrange
            float[,] tableau1 = new float[,]
            {
                {1, 2, 3},
                {3, 5, 2},
                {8, 2, 1}
            };

            Matrice2D matrice1 = new Matrice2D(tableau1);

            float[,] tableau2 = new float[,]
            {
                {1, 2, 3},
                {3, 5, 2},
                {8, 2, 8}
            };

            Matrice2D matrice2 = new Matrice2D(tableau2);

            // Act
            bool matriceDimensionEgale = matrice1.Equals(matrice2);

            // Act
            Assert.False(matriceDimensionEgale);
        }
        
        [Fact]
        public void Equals_MatricesIdentiques_RetourneFalse()
        {
            // Arrange
            float[,] tableau1 = new float[,]
            {
                {1, 2, 3},
                {3, 5, 2},
                {8, 2, 1}
            };

            Matrice2D matrice1 = new Matrice2D(tableau1);

            float[,] tableau2 = new float[,]
            {
                {1, 2, 3},
                {3, 5, 2},
                {8, 2, 1}
            };

            Matrice2D matrice2 = new Matrice2D(tableau2);

            // Act
            bool matriceDimensionEgale = matrice1.Equals(matrice2);

            // Act
            Assert.True(matriceDimensionEgale);
        }

        [Fact]
        public void MatriceIdentite_CreationMatriceIdentiteCarree_CreeMatriceDiagonale1Reste0()
        {
            // Arrange
            int dimensionMatrice = 3;

            float[,] tableau1 = new float[,]
            {
                {1, 0, 0},
                {0, 1, 0},
                {0, 0, 1}
            };

            Matrice2D matriceIdentiteAttendue = new Matrice2D(tableau1);

            // Act
            Matrice2D matriceIdentiteObtenue = Matrice2D.MatriceIdentite(dimensionMatrice);

            // Assert
            Assert.True(matriceIdentiteAttendue.Equals(matriceIdentiteObtenue));
        }

        [Fact]
        public void MatriceTransposee_CreationMatriceTransposeeCarree_ValeurInverseSaufDiagonalePrincipale()
        {
            // Arrange
            float[,] tableau1 = new float[,]
            {
                {1, 2, 6},
                {4, 1, 9},
                {2, 3, 1}
            };

            Matrice2D matriceATransposer = new Matrice2D(tableau1);

            // Arrange
            float[,] tableau2 = new float[,]
            {
                {1, 4, 2},
                {2, 1, 3},
                {6, 9, 1}
            };

            Matrice2D matriceTransposeeAttendue = new Matrice2D(tableau2);

            // Act
            Matrice2D matriceTransposeeObtenue = Matrice2D.MatriceTransposee(matriceATransposer);

            // Assert
            Assert.True(matriceTransposeeAttendue.Equals(matriceTransposeeObtenue));
        }

        [Fact]
        public void MatriceTransposee_CreationMatriceTransposeeNonCarree_ValeurInverseSaufDiagonalePrincipale()
        {
            // Arrange
            float[,] tableau1 = new float[,]
            {
                {1, 2},
                {4, 1},
                {2, 3}
            };

            Matrice2D matriceATransposer = new Matrice2D(tableau1);

            // Arrange
            float[,] tableau2 = new float[,]
            {
                {1, 4, 2},
                {2, 1, 3}
            };

            Matrice2D matriceTransposeeAttendue = new Matrice2D(tableau2);

            // Act
            Matrice2D matriceTransposeeObtenue = Matrice2D.MatriceTransposee(matriceATransposer);

            // Assert
            Assert.True(matriceTransposeeAttendue.Equals(matriceTransposeeObtenue));
        }
        #endregion

        #region Operateur

        [Fact]
        public void OperatorAddition_PreconditionMatriceUnNull_LanceException()
        {
            // Arrange
            float[,] tableau = new float[,]
            {
                {2, 4, 4},
                {1, 2, 3},
                {1, 4, 4}
            };

            Matrice2D matrice = new Matrice2D(tableau);

            Matrice2D matriceNull = null;

            // Act and Assert
            Assert.Throws<ArgumentNullException>(() => { Matrice2D matriceResultat = matriceNull + matrice; });
        }

        [Fact]
        public void OperatorAddition_PreconditionMatriceDeuxNull_LanceException()
        {
            // Arrange
            float[,] tableau = new float[,]
            {
                {2, 4, 4},
                {1, 2, 3},
                {1, 4, 4}
            };

            Matrice2D matrice = new Matrice2D(tableau);

            Matrice2D matriceNull = null;

            // Act and Assert
            Assert.Throws<ArgumentNullException>(() => { Matrice2D matriceResultat = matrice + matriceNull; });
        }

        [Fact]
        public void OperatorAddition_PreconditionAdditionMatricesDimensionsDifferentes_LanceException()
        {
            // Arrange
            float[,] tableau1 = new float[,]
            {
                {2, 4, 4},
                {1, 2, 3},
                {1, 4, 4}
            };

            Matrice2D matrice1 = new Matrice2D(tableau1);

            float[,] tableau2 = new float[,]
            {
                {2, 4, 4, 6},
                {1, 2, 6, 6},
                {1, 4, 8, 6}
            };

            Matrice2D matrice2 = new Matrice2D(tableau2);



            // Act and Assert
            Assert.Throws<MatriceDimensionsInvalidesException>(() => {Matrice2D matriceResultat = matrice1 + matrice2; });
        }

        [Fact]
        public void OperatorAddition_AdditionDeuxMatricesCarrees_SommeCorrectChaquePosition()
        {
            // Arrange
            float[,] tableau1 = new float[,]
            {
                {2, 4, 4},
                {1, 2, 3},
                {1, 4, 4}
            };

            Matrice2D matrice1 = new Matrice2D(tableau1);

            float[,] tableau2 = new float[,]
            {
                {1, 2, 3},
                {3, 4, 2},
                {2, 2, 1}
            };

            Matrice2D matrice2 = new Matrice2D(tableau2);

            float[,] tableauResultat = new float[,]
            {
                {3, 6, 7},
                {4, 6, 5},
                {3, 6, 5}
            };

            Matrice2D matriceAttendue = new Matrice2D(tableauResultat);

            // Act
            Matrice2D matriceObtenue = matrice1 + matrice2;

            // Assert
            Assert.True(matriceObtenue.Equals(matriceAttendue));

        }

        [Fact]
        public void OperatorAddition_AdditionDeuxMatricesNonCarrees_SommeCorrectChaquePosition()
        {
            // Arrange
            float[,] tableau1 = new float[,]
            {
                {2, 4, 4, 4},
                {1, 2, 3, 2},
                {1, 4, 4, 9}
            };

            Matrice2D matrice1 = new Matrice2D(tableau1);

            float[,] tableau2 = new float[,]
            {
                {1, 2, 3, 3},
                {3, 4, 2, 1},
                {2, 2, 1, 2}
            };

            Matrice2D matrice2 = new Matrice2D(tableau2);

            float[,] tableauResultat = new float[,]
            {
                {3, 6, 7, 7},
                {4, 6, 5, 3},
                {3, 6, 5, 11}
            };

            Matrice2D matriceAttendue = new Matrice2D(tableauResultat);

            // Act
            Matrice2D matriceObtenue = matrice1 + matrice2;

            // Assert
            Assert.True(matriceObtenue.Equals(matriceAttendue));

        }

        [Fact]
        public void OperatorSoustraction_PreconditionMatriceUnNull_LanceException()
        {
            // Arrange
            float[,] tableau = new float[,]
            {
                {2, 4, 4},
                {1, 2, 3},
                {1, 4, 4}
            };

            Matrice2D matrice = new Matrice2D(tableau);

            Matrice2D matriceNull = null;

            // Act and Assert
            Assert.Throws<ArgumentNullException>(() => { Matrice2D matriceResultat = matriceNull - matrice; });
        }

        [Fact]
        public void OperatorSoustraction_PreconditionMatriceDeuxNull_LanceException()
        {
            // Arrange
            float[,] tableau = new float[,]
            {
                {2, 4, 4},
                {1, 2, 3},
                {1, 4, 4}
            };

            Matrice2D matrice = new Matrice2D(tableau);

            Matrice2D matriceNull = null;

            // Act and Assert
            Assert.Throws<ArgumentNullException>(() => { Matrice2D matriceResultat = matrice - matriceNull; });
        }

        [Fact]
        public void OperatorSoustraction_PreconditionAdditionMatricesDimensionsDifferentes_LanceException()
        {
            // Arrange
            float[,] tableau1 = new float[,]
            {
                {2, 4, 4},
                {1, 2, 3},
                {1, 4, 4}
            };

            Matrice2D matrice1 = new Matrice2D(tableau1);

            float[,] tableau2 = new float[,]
            {
                {2, 4, 4, 6},
                {1, 2, 6, 6},
                {1, 4, 8, 6}
            };

            Matrice2D matrice2 = new Matrice2D(tableau2);



            // Act and Assert
            Assert.Throws<MatriceDimensionsInvalidesException>(() => { Matrice2D matriceResultat = matrice1 - matrice2; });
        }

        [Fact]
        public void OperatorSoustraction_SoustractionDeuxMatricesCarrees_ResultatCorrectChaquePosition()
        {
            // Arrange
            float[,] tableau1 = new float[,]
            {
                {2, 4, 4},
                {1, 2, 3},
                {1, 4, 4}
            };

            Matrice2D matrice1 = new Matrice2D(tableau1);

            float[,] tableau2 = new float[,]
            {
                {1, 2, 3},
                {3, 4, 2},
                {2, 2, 1}
            };

            Matrice2D matrice2 = new Matrice2D(tableau2);

            float[,] tableauResultat = new float[,]
            {
                {1, 2, 1},
                {-2, -2, 1},
                {-1, 2, 3}
            };

            Matrice2D matriceAttendue = new Matrice2D(tableauResultat);

            // Act
            Matrice2D matriceObtenue = matrice1 - matrice2;

            // Assert
            Assert.True(matriceObtenue.Equals(matriceAttendue));

        }

        [Fact]
        public void OperatorAddition_SoustractionDeuxMatricesNonCarrees_SommeCorrectChaquePosition()
        {
            // Arrange
            float[,] tableau1 = new float[,]
            {
                {2, 4, 4, 4},
                {1, 2, 3, 2},
                {1, 4, 4, 9}
            };

            Matrice2D matrice1 = new Matrice2D(tableau1);

            float[,] tableau2 = new float[,]
            {
                {1, 2, 3, 3},
                {3, 4, 2, 1},
                {2, 2, 1, 2}
            };

            Matrice2D matrice2 = new Matrice2D(tableau2);

            float[,] tableauResultat = new float[,]
            {
                {1, 2, 1, 1},
                {-2, -2, 1, 1},
                {-1, 2, 3, 7}
            };

            Matrice2D matriceAttendue = new Matrice2D(tableauResultat);

            // Act
            Matrice2D matriceObtenue = matrice1 - matrice2;

            // Assert
            Assert.True(matriceObtenue.Equals(matriceAttendue));

        }

        [Fact]
        public void OperatorMultiplicationScalaire_MultiplierMatriceCarreeParScalaire_ProduitCorrectChaquePosition()
        {
            // Arrange
            float[,] tableau = new float[,]
            {
                {2, 4, 4},
                {1, 2, 3},
                {1, 4, 4}
            };

            Matrice2D matrice = new Matrice2D(tableau);

            int scalaire = 2;
           

           

            float[,] tableauResultat = new float[,]
            {
                {4, 8, 8},
                {2, 4, 6},
                {2, 8, 8}
            };

            Matrice2D matriceAttendue = new Matrice2D(tableauResultat);

            // Act
            Matrice2D matriceObtenue = matrice * scalaire;

            // Assert
            Assert.True(matriceObtenue.Equals(matriceAttendue));

        }

        [Fact]
        public void OperatorMultiplicationScalaire_MultiplierMatriceNonCarreeParScalaire_ProduitCorrectChaquePosition()
        {
            // Arrange
            float[,] tableau = new float[,]
            {
                {2, 4, 4, 3},
                {1, 2, 3, 7},
                {1, 4, 4, 2}
            };

            Matrice2D matrice = new Matrice2D(tableau);

            int scalaire = 2;

            float[,] tableauResultat = new float[,]
            {
                {4, 8, 8, 6},
                {2, 4, 6, 14},
                {2, 8, 8, 4}
            };

            Matrice2D matriceAttendue = new Matrice2D(tableauResultat);

            // Act
            Matrice2D matriceObtenue = matrice * scalaire;

            // Assert
            Assert.True(matriceObtenue.Equals(matriceAttendue));

        }

        [Fact]
        public void OperatorMultiplicationScalaire_PreconditionMatriceNull_LanceException()
        {
            // Arrange
            float[,] tableau = new float[,]
            {
                {2, 4, 4},
                {1, 2, 3},
                {1, 4, 4}
            };

            Matrice2D matrice = new Matrice2D(tableau);

            Matrice2D matriceNull = null;

            // Act and Assert
            Assert.Throws<ArgumentNullException>(() => { Matrice2D matriceResultat = matriceNull * 2; });
        }

        [Fact]
        public void OperatorMultiplication_MultiplierDeuxMatricesCarrees_ProduitCorrectChaquePosition()
        {
            // Arrange
            float[,] tableau1 = new float[,]
            {
                {1, 0, 2},
                {0, 2, -6},
                {0, 0, 1}
            };

            Matrice2D matrice1 = new Matrice2D(tableau1);

            float[,] tableau2 = new float[,]
            {
                {1, 0, 4},
                {0, 1, -3},
                {0, 0, 1}
            };

            Matrice2D matrice2 = new Matrice2D(tableau2);

            float[,] tableauResultat = new float[,]
            {
                {1, 0, 6},
                {0, 2, -12},
                {0, 0, 1}
            };

            Matrice2D matriceAttendue = new Matrice2D(tableauResultat);

            // Act
            Matrice2D matriceObtenue = matrice1 * matrice2;

            // Assert
            Assert.True(matriceObtenue.Equals(matriceAttendue));

        }

        [Fact]
        public void OperatorMultiplication_MultiplierDeuxMatricesNonCarrees_ProduitCorrectChaquePosition()
        {
            // Arrange
            float[,] tableau1 = new float[,]
            {
                {1, 5},
                {2, 2},
                {3, 1}
            };

            Matrice2D matrice1 = new Matrice2D(tableau1);

            float[,] tableau2 = new float[,]
            {
                {2},
                {3}
            };

            Matrice2D matrice2 = new Matrice2D(tableau2);

            float[,] tableauResultat = new float[,]
            {
                {17},
                {10},
                {9}
            };

            Matrice2D matriceAttendue = new Matrice2D(tableauResultat);

            // Act
            Matrice2D matriceObtenue = matrice1 * matrice2;

            // Assert
            Assert.True(matriceObtenue.Equals(matriceAttendue));

        }

        [Fact]
        public void OperatorMultiplication_PreconditionMatriceUnNull_LanceException()
        {
            // Arrange
            float[,] tableau = new float[,]
            {
                {2, 4, 4},
                {1, 2, 3},
                {1, 4, 4}
            };

            Matrice2D matrice = new Matrice2D(tableau);

            Matrice2D matriceNull = null;

            // Act and Assert
            Assert.Throws<ArgumentNullException>(() => { Matrice2D matriceResultat = matriceNull * matrice; });
        }

        [Fact]
        public void OperatorMultiplication_PreconditionMatriceDeuxNull_LanceException()
        {
            // Arrange
            float[,] tableau = new float[,]
            {
                {2, 4, 4},
                {1, 2, 3},
                {1, 4, 4}
            };

            Matrice2D matrice = new Matrice2D(tableau);

            Matrice2D matriceNull = null;

            // Act and Assert
            Assert.Throws<ArgumentNullException>(() => { Matrice2D matriceResultat = matrice * matriceNull; });
        }

        [Fact]
        public void OperatorMultiplication_PreconditionMultiplicationMatricesDimensionsDifferentes_LanceException()
        {
            // Arrange
            float[,] tableau1 = new float[,]
            {
                {2, 4, 4},
                {1, 2, 3},
                {1, 4, 4}
            };

            Matrice2D matrice1 = new Matrice2D(tableau1);

            float[,] tableau2 = new float[,]
            {
                {2, 4, 4, 6},
                {1, 2, 6, 6}
            };

            Matrice2D matrice2 = new Matrice2D(tableau2);



            // Act and Assert
            Assert.Throws<MatriceDimensionsInvalidesException>(() => { Matrice2D matriceResultat = matrice1 * matrice2; });
        }

        #endregion
    }
}
