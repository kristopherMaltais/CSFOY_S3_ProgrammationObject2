using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace TraitementImage_LibrairieClasse
{
    public class CreateurTraitement
    {
        public Type Type { get; set; }
        public ITraitementImage Creer()
        {
            return (ITraitementImage)Activator.CreateInstance(this.Type);
        }
        public override string ToString()
        {
            string res = this.Type.Name;
            DescriptionAttribute da = this.Type.GetCustomAttribute<DescriptionAttribute>();

            if (da != null)
            {
                res = da.Description;
            }

            return res;
        }
    }
}
