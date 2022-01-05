using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonClasses
{
    public class Singleton<TypeElement>
    where TypeElement : class, new()
    {
        // ** Champs ** //
        private static Singleton<TypeElement> _instance;
        private static object _lock = new object();

        // ** Propriétés**
        public static Singleton<TypeElement> Instance
        {
            get
            {
                if(_instance is null)
                {
                    lock (_lock)
                    {
                        if(_instance is null)
                        {
                            _instance = new Singleton<TypeElement>();
                        }
                    }
                }

                return _instance;
            }
        }

        // ** Constructeurs ** /

        // ** méthodes ** //
    }
}
