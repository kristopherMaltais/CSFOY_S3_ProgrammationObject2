using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibrairieClasses
{
    public class ObservateurFacture : IObserver<FactureEvent>
    {
        // ** Champs ** //
        private Action<FactureEvent> m_traitement;
        private IDisposable m_seDesabonner;

        // ** Propriétés ** //

        // ** constructeurs ** //
        public ObservateurFacture(Action<FactureEvent> p_traitement, IObservable<FactureEvent> p_sujet)
        {
            this.m_traitement = p_traitement;
            m_seDesabonner = p_sujet.Subscribe(this);
        }

        // ** méthodes ** //
        public void OnCompleted()
        {
            ;
        }
        public void OnError(Exception p_error)
        {
            ;
        }
        public void OnNext(FactureEvent p_value)
        {
            this.m_traitement(p_value);
        }
    }
}
