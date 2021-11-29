using System;
using System.IO;

namespace M3_TraitementException1
{
    class Program
    {
        static void Main(string[] args)
        {
            string cheminFichier = saisiUtilisateur();
            try
            {
                LectureFichier(cheminFichier);
            }

            catch (ArgumentNullException)
            {

            }

            catch(FileNotFoundException ex1)
            {
                
            }

            catch (DirectoryNotFoundException ex2)
            {

            }

        }

        public static string saisiUtilisateur()
        {
            // Demander le chemin absolu
            string cheminFichier;
            Console.Write("Veuillez entrer le chemin de votre fichier: ");
            cheminFichier = Console.ReadLine();
            return cheminFichier;
        }

        public static void LectureFichier(string p_cheminFichier)
        {
            // Préconditions
            if(p_cheminFichier == null)
            {
                throw new ArgumentNullException("Le chemin du fichier ne peut pas être null", "p_cheminFichier");
            }

          
            // Lire le fichier
            using(StreamReader sr = new StreamReader(p_cheminFichier))
            {
                
                // Tant que nous ne sommes pas arrivés à la fin du fichier
                while (!sr.EndOfStream)
                {
                    // Lire une ligne
                    string ligneActuelleFichier = sr.ReadLine();
                    Console.WriteLine(ligneActuelleFichier);
                }
            }
        }
    }
}
