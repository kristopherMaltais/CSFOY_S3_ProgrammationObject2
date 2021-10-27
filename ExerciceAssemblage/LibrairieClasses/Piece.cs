using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace LibrairieClasses
{
    public class Piece
    {
        // ** Champs ** //
        private string m_Description;
        private int m_NumeroSerie;
        private int m_Reference;
        private List<Piece> m_ListeSousPiece;

        //* Propriétés ** //

        // ** Constructeur ** //
        public Piece(string description, int numeroSerie, int reference)
        {
            m_Description = description;
            m_NumeroSerie = numeroSerie;
            m_Reference = reference;
            m_ListeSousPiece = new List<Piece>();
        }

        // ** Méthodes ** //
        public void AjouterPiece(Piece pieceAAjouter)
        {
            m_ListeSousPiece.Add(pieceAAjouter);
        }

        public string SortieHierarchiePiece(Piece piece, StringBuilder sortie, int compteIndentation = 0)
        {

            // Déclaration des variables
            List<(Piece, int)> suivi = new List<(Piece, int)>();
            
            // Description de la pièce avec indentation selon son niveau
            string indentation = new string(' ', compteIndentation);
            sortie.Append(indentation + piece + "\n");

            // Créer une liste que la pièce contient et ajuster le niveau d'indentation selon le niveau
            suivi = piece.m_ListeSousPiece.Select(x => (x, compteIndentation + 2)).ToList();

            // Récursivité de la méthode
            foreach((Piece, int) element in suivi)
            {
                SortieHierarchiePiece(element.Item1, sortie, element.Item2);
            }

            return sortie.ToString();
        }

        public Dictionary<string, int> SortieNomenclature(Piece piece, List<Piece> listePieces)
        {
            List<Piece> suiviPiece = new List<Piece>();
            listePieces.Add(piece);

            suiviPiece = piece.m_ListeSousPiece.Select(x => x).ToList();
            
            foreach (Piece element in suiviPiece)
            {
                SortieNomenclature(element, listePieces);
            }

            return listePieces.GroupBy(x => x.m_Description).ToDictionary(x => x.Key, x => x.Count());
            
        }

        public override string ToString()
        {
            return $"Pièce : {m_Description}, Part - #{m_Reference}, numéro série - #{m_NumeroSerie}";
        }
    }
}
