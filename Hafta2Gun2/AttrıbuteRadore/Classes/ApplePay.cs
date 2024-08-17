using OdemeFormu.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OdemeFormu.Classes
{
    public class ApplePay : IOdemeTipi
    {

        public string ode(double tutar)
        {
            return $"Apple Pay ile {tutar} TL ödeme yapılmıştır.";
        }

    }   
}
