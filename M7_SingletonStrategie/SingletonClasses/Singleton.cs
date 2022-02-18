using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonClasses
{
    public class Singleton
    {
        // ** Champs ** //
        private static GenerateurIdentifiant _instance;
        private static object _lock = new object();

        // ** Propriétés**
        public static GenerateurIdentifiant Instance
        {
            get
            {
                if(_instance is null)
                {
                    lock (_lock)
                    {
                        if(_instance is null)
                        {
                            _instance = new GenerateurIdentifiant();
                        }
                    }
                }

                return _instance;
            }
        }

        // ** Constructeurs ** /

        // ** méthodes ** //
        public int GenererInstance()
        {
           return _instance.GenererProchainId();
        }
    }
    internal class GenerateurIdentifiant
    {
        // ** Champs ** //
        private int m_identifiant;

        // ** propriétés ** //

        // ** Constructeurs ** //

        // ** Méthodes ** //
        public int GenererProchainId()
        {
            this.m_identifiant++;
            return this.m_identifiant;
        }
    }
}
