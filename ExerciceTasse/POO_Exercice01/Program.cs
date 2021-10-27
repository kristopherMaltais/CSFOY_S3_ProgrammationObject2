using System;
using Librairie_Classes;

namespace POO_Exercice01
{
    class Program
    {
        static void Main(string[] args)
        {
            Liquide liquide1 = new Liquide("Lait");
            Liquide liquide2 = new Liquide("Café");
            Liquide liquide3 = new Liquide("Chocolat");
            Liquide liquide4 = new Liquide("Crème");

            Bol bol = new Bol();
            Tasse tasse = new Tasse();

            bol.AjouterLiquide(20m, liquide1);
            Console.WriteLine(bol);
            bol.AjouterLiquide(20m, liquide2);
            Console.WriteLine(bol);
            bol.AjouterLiquide(20m, liquide3);
            Console.WriteLine(bol);
            bol.AjouterLiquide(20m, liquide4);
            Console.WriteLine(bol);
            bol.TransfererLiquide(60m, tasse);

            Console.WriteLine(bol);
            Console.WriteLine(tasse);

        }
    }
}
