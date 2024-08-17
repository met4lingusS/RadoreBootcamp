using OdemeFormuV3.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OdemeFormuV3.Interface
{
    public interface IOdemeTipiFactory
    {
        IOdemeTipi NesneOlustur(string className, List<string> propertyNames)
        {
            var dinamikType = DinamikSınıfOlusturma.DinamikSınıfOlustur(className, propertyNames);
            if (dinamikType != null)
            {
                throw new InvalidOperationException("Dinamik type oluşturulamadı.");
            }
            return (IOdemeTipi)Activator.CreateInstance(dinamikType);
        }
    }
}
