using OdemeFormu.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace OdemeFormu.Classes
{
    public class OdemeIslemiFactory
    {
        public IOdemeTipi NesneOlustur(string className)
        {
            //OdemeFormu projesi içindeki parametre olarak verilen className ile ilgili bir class var ise
            // runtime'da dinamik olarak bir nesne oluşturur
            // Oluşturulan nesne IOdemeTipi cast edilerek oluşturulur
            var newInstance = Assembly.GetAssembly(typeof(IOdemeTipi)).CreateInstance("OdemeFormu.Classes." + className);
            return (IOdemeTipi)newInstance;


        }
    }
}
