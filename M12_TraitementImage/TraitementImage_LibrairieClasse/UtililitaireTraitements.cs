using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace TraitementImage_LibrairieClasse
{
    class UtililitaireTraitements
    {
        public static class UtilitaireTraitements
        {

            public static IEnumerable<CreateurTraitement> RechercherTraitementsImage()
            {
                Type typeITraitementImage = typeof(ITraitementImage);

                List<Type> traitements = AppDomain.CurrentDomain.GetAssemblies()
                    .SelectMany(e => e.GetTypes())
                    .Where(t => typeITraitementImage.IsAssignableFrom(t)
                    && t.GetCustomAttribute<DescriptionAttribute>() != null)
                    .ToList();


                return traitements.Select(t => new CreateurTraitement() { Type = t });
            }
            public static string DescriptionTraitement(ITraitementImage p_traitementImage)
            {
                string res = p_traitementImage.GetType().Name;
                DescriptionAttribute da = p_traitementImage.GetType().GetCustomAttribute<DescriptionAttribute>();

                if (da != null)
                {
                    res = da.Description;
                }

                return res;
            }
        }
    }
}
