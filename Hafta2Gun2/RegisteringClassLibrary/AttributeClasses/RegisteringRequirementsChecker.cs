using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace RegisteringClassLibrary.AttributeClasses
{
    public static class RegisteringRequirementsChecker
    {

        public static bool Dogrula(object dogrulanacakNesne)
        {
            Type dogrulanacakTur = dogrulanacakNesne.GetType();

            PropertyInfo[] dogrulanacakOzellikler = dogrulanacakTur.GetProperties(BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic);
            foreach (PropertyInfo dogrulanacakOzellik in dogrulanacakOzellikler)
            {
                object[] zorunluAlanOznitelikleri = dogrulanacakOzellik.GetCustomAttributes(typeof(RegisteringRequirementsAttribute), true);
                if (zorunluAlanOznitelikleri.Length != 0)
                {
                    object alanDegeri = dogrulanacakOzellik.GetValue(dogrulanacakNesne) as string;
                    if (string.IsNullOrEmpty((string)alanDegeri))
                    {
                        return false;
                    }
                }
            }
            return true;
        }

    }
}
