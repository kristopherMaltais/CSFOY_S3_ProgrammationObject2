using System;
using System.Collections.Generic;

namespace LibrairieClasses
{
    public class Facture : IObservable<FactureEvent>
    {
        // ** Champs ** //
        private List<IObserver<FactureEvent>> m_observeurs;
        private FactureEvent m_valeur;

        // ** Propriétés ** //
        public List<LigneFacture> LignesFacture { get; private set; }
        public decimal Total { get; private set; }
        
        // ** Constructeurs ** //
        public Facture()
        {
            this.m_observeurs = new List<IObserver<FactureEvent>>();
            this.LignesFacture = new List<LigneFacture>();
        }

        // ** Méthodes ** //
        public IDisposable Subscribe(IObserver<FactureEvent> p_observer)
        {
            // Précondition
            if(p_observer is null)
            {
                throw new ArgumentNullException(nameof(p_observer), "Observeur ne peut pas être null");
            }

            this.m_observeurs.Add(p_observer);

            return new UnsubscribeObserver(this.m_observeurs, p_observer);
        }
        public void AjouterLigneFacture(LigneFacture p_ligneFacture)
        {
            this.Total = this.Total + p_ligneFacture.Total;
            LignesFacture.Add(p_ligneFacture);


            this.InformerObservateur(Evement.AJOUTlIGNE, p_ligneFacture);
        }
        public void SupprimerLignesFacture()
        {
            this.LignesFacture = new List<LigneFacture>();
            this.InformerObservateur(Evement.NOUVELLEFACTURE);
        }
        public void InformerObservateur(Evement p_typeEvenement, LigneFacture p_ligneFacture = null)
        {
            m_valeur = new FactureEvent(p_typeEvenement, this, p_ligneFacture);
            this.m_observeurs.ForEach(observeur => observeur.OnNext(m_valeur));
        }


    }
}
