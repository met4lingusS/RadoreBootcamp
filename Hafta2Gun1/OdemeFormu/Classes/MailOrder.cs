using OdemeFormu.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OdemeFormu.Classes
{
    public class MailOrder : IOdemeTipi
    {
        public string ode(double tutar)
        {
            return $"Mail Order ile {tutar} TL ödeme yapılmıştır.";
        }

    }
}
