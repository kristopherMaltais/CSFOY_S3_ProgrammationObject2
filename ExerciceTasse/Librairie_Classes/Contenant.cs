using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Librairie_Classes
{
    public abstract class Contenant
    {
        // ** Champs ** //
        protected decimal m_volume;
        protected decimal m_volumeMax;
        protected decimal m_zoneTampon;
        private decimal m_volumeOccupe;
        private decimal m_pourcentageOccupe;
        private Dictionary<Liquide, decimal> m_liquides;

        // ** Propriétés ** //
        

        // ** Constructeurs ** //
        public Contenant()
        {
            m_liquides = new Dictionary<Liquide, decimal>();

            m_volumeOccupe = 0m;
            m_pourcentageOccupe = 0m;
            m_zoneTampon = 0.05m;
        }

        // ** Méthodes ** //
        public void AjouterLiquide(decimal quantite, Liquide liquideAAjouter)
        {
            if(m_volumeOccupe + quantite <= m_volumeMax)
            {
                // Ajouter liquide dans le contenant
                m_volumeOccupe += quantite;

                // Ajuster la quantité du liquide ajouté
                if (m_liquides.ContainsKey(liquideAAjouter)) { m_liquides[liquideAAjouter] += quantite; }
                else { m_liquides.Add(liquideAAjouter, quantite);}

                // Ajuster le pourcentage de volume utilisé
                m_pourcentageOccupe = (m_volumeOccupe * 100) / m_volumeMax;
            }
        }

        public void EnleverLiquide(decimal quantite, Liquide liquideAAjouter)
        {
            if(m_volumeOccupe - quantite >= 0)
            {
                // Ajouter liquide dans le contenant
                m_volumeOccupe -= quantite;

                // Ajuster la quantité du liquide ajouté
                if (m_liquides.ContainsKey(liquideAAjouter)) { m_liquides[liquideAAjouter] -= quantite; }
                else { m_liquides.Add(liquideAAjouter, quantite); }

                // Ajuster le pourcentage de volume utilisé
                m_pourcentageOccupe = (m_volumeOccupe * 100) / m_volumeMax;
            }
        }

        public void TransfererLiquide(decimal quantite, Contenant contenantDestination)
        {
            if(quantite + contenantDestination.m_volumeOccupe <= contenantDestination.m_volumeMax)
            {
                // Calculer la proportiion de chacun des liquides
                var liquideProportion = m_liquides.Select(x => (x.Key, (x.Value * quantite) / m_volumeOccupe)).ToDictionary(x => x.Item1, x => x.Item2);

                // Retirer le liquide du contenant source et ajouter les liquides dans le contenant destinataire
                foreach (KeyValuePair<Liquide, decimal> liquide in liquideProportion)
                {
                    // Retirer les liquides du contenant source
                    this.EnleverLiquide(liquide.Value, liquide.Key);

                    // Ajouter les liquides dans le contenant destinataire
                    contenantDestination.AjouterLiquide(liquide.Value, liquide.Key);
                }
            }

            if(this.m_volumeOccupe == 0)
            {
                m_liquides.Clear();
            }
        }  

        public override string ToString()
        {
            StringBuilder liquides = new StringBuilder("Aucun");

            if(m_liquides.Count > 0)
            {
                liquides.Clear();

                foreach(KeyValuePair<Liquide, decimal> element in m_liquides)
                {
                    liquides.Append(element.Key.ToString() + " ");
                }
            }
            return ($"Liquide mélangé: {liquides} | Volume maximum: {m_volumeMax}, VolumeUtilise : {Math.Round(m_volumeOccupe, 2)}ml, Volume Utilisé: {Math.Round(m_pourcentageOccupe)}%");
        }
    }
}
