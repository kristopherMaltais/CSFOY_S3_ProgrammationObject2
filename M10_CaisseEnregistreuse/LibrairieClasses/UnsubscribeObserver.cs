using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibrairieClasses
{
    class UnsubscribeObserver : IDisposable
    {
        // ** champs ** //
        private IObserver<FactureEvent> m_observer;
        private List<IObserver<FactureEvent>> m_observers;

        // ** Propriétés ** //

        // ** constructeurs ** //
        public UnsubscribeObserver(List<IObserver<FactureEvent>> p_observers, IObserver<FactureEvent> p_observer)
        {
            this.m_observer = p_observer;
            this.m_observers = p_observers;
        }

        // ** méthodes ** //
        public void Dispose()
        {
            m_observers.Remove(this.m_observer);
        }
    }
}
