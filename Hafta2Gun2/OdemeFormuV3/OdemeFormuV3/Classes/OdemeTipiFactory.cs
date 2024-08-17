using OdemeFormuV3.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OdemeFormuV3.Classes
{
    public class OdemeTipiFactory : IOdemeTipiFactory
    {
        public IOdemeTipi NesneOlustur(string className, List<string> propertyNames)
        {
            var odemeTipi = DinamikSınıfOlusturma.DinamikSınıfOlustur(className, propertyNames);
            if (odemeTipi == null)
            {
                throw new InvalidOperationException("Ödeme tipi oluşturulamadı");
            }
            return (IOdemeTipi)Activator.CreateInstance(odemeTipi);
        }
    }
}
    