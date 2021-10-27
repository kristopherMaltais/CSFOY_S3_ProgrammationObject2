using System;
using LibrairieClasses;
using System.Collections.Generic;
using System.Text;

namespace Assemblage
{
    class Program
    {
        static void Main(string[] args)
        {
            Piece valveEau = new Piece("Valve à eau", 1234, 0481);
            Piece laBase = new Piece("Base", 1387, 0474);
            Piece systemeActivation = new Piece("Système d'activation", 1887, 0574);
            Piece systemeActivation2 = new Piece("Système d'activation", 1887, 0574);
            Piece couvercleLateral = new Piece("Couvercle latéral", 1987, 0374);
            Piece couvercleLateral2 = new Piece("Couvercle latéral", 1987, 0374);
            Piece pin = new Piece("pin", 1687, 0974);
            Piece plug = new Piece("plug", 1657, 0964);
            Piece poigne = new Piece("poigné", 3157, 2547);
            Piece couvercleMonobloc = new Piece("Couvercle monobloc", 1257, 9874);
            Piece visse = new Piece("Vise M8", 8757, 3774);


            valveEau.AjouterPiece(laBase);
            valveEau.AjouterPiece(systemeActivation);
            valveEau.AjouterPiece(couvercleLateral);
            valveEau.AjouterPiece(couvercleLateral);
            
            systemeActivation.AjouterPiece(pin);
            systemeActivation.AjouterPiece(plug);
            systemeActivation.AjouterPiece(poigne);
            
            couvercleLateral.AjouterPiece(couvercleMonobloc);
            couvercleLateral.AjouterPiece(visse);
            couvercleLateral.AjouterPiece(visse);
            couvercleLateral.AjouterPiece(visse);
            couvercleLateral.AjouterPiece(visse);
            
            couvercleLateral2.AjouterPiece(couvercleMonobloc);
            couvercleLateral2.AjouterPiece(visse);
            couvercleLateral2.AjouterPiece(visse);
            couvercleLateral2.AjouterPiece(visse);
            couvercleLateral2.AjouterPiece(visse);

            //StringBuilder test = new StringBuilder();
            //Console.WriteLine(valveEau.SortieHierarchiePiece(valveEau, test));

            List<Piece> liste = new List<Piece>();

            Dictionary<string, int> test2 = valveEau.SortieNomenclature(valveEau, liste);

            foreach (KeyValuePair<string, int> element in test2)
            {
                Console.WriteLine($"{element.Key} --- {element.Value}");
            }








        }
    }
}
